namespace PushApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using PushApi.Contracts;
using Shiny.Extensions.Push;


[ApiController]
[Route("[controller]")]
public class ShinyController : ControllerBase
{
    readonly IPushManager pushManager;


    public ShinyController(IPushManager pushManager)
    {
        this.pushManager = pushManager;
    }


    [HttpPost("send")]
    public async Task<ActionResult> Send([FromBody] ShinySendArgs args)
    {
        await this.pushManager.Send(
            new Notification
            {
                Title = args.Title,
                Message = args.Message
            },
            args.Filter
        );
        return this.Ok();
    }


    [HttpGet("register/{platform}/{deviceToken}")]
    public Task<ActionResult> Register(string platform, string deviceToken)
        => this.DoRegister(true, platform, deviceToken);


    [HttpGet("unregister/{platform}/{deviceToken}")]
    public Task<ActionResult> UnRegister(string platform, string deviceToken)
        => this.DoRegister(false, platform, deviceToken);


    async Task<ActionResult> DoRegister(bool register, string platform, string deviceToken)
    {
        var plat = Enum.Parse<PushPlatforms>(platform, true);

        var task = register 
            ? this.pushManager.Register(new PushRegistration
            {
                Platform = plat,
                DeviceToken = deviceToken
            }) 
            : this.pushManager.UnRegister(plat, deviceToken);

        await task;

        return this.Ok();
    }
}
