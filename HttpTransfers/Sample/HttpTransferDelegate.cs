﻿using System;
using System.Threading.Tasks;
using Shiny.Net.Http;
using Shiny.Notifications;


namespace Sample
{
    public class HttpTransferDelegate : IHttpTransferDelegate
    {
        readonly INotificationManager notificationManager;
        readonly SampleSqliteConnection conn;


        public HttpTransferDelegate(INotificationManager notificationManager, SampleSqliteConnection conn)
        {
            this.notificationManager = notificationManager;
            this.conn = conn;
        }


        public async Task OnError(HttpTransfer transfer, Exception ex) { }
            //=> this.CreateHttpTransferEvent(transfer, "ERROR: " + ex);


        public async Task OnCompleted(HttpTransfer transfer)
        {
            //if (!transfer.IsUpload && Path.GetExtension(transfer.LocalFilePath) == "db")
            //{
            //    try
            //    {
            //        using (var conn = new SQLiteConnection(transfer.LocalFilePath))
            //        {
            //            var count = conn.Execute("SELECT COUNT(*) FROM sqlite_master WHERE type='table'");
            //            await this.CreateHttpTransferEvent(transfer, $"COMPLETE - SQLITE PASSED ({count} tables)");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        await this.CreateHttpTransferEvent(transfer, $"COMPLETE - SQLITE FAILED - " + ex);
            //    }
            //}
            //else
            //{
            //    await this.CreateHttpTransferEvent(transfer, "COMPLETE");
            //}
        }


        //async Task CreateHttpTransferEvent(HttpTransfer transfer, string description)
        //{
        //    await this.services.Connection.InsertAsync(new HttpEvent
        //    {
        //        Identifier = transfer.Identifier,
        //        IsUpload = transfer.IsUpload,
        //        FileSize = transfer.FileSize,
        //        Uri = transfer.Uri,
        //        Description = description,
        //        DateCreated = DateTime.Now
        //    });
        //    await this.services.Notifications.Send(
        //        this.GetType(),
        //        false,
        //        "HTTP Transfer",
        //        description
        //    );
        //}

        //public void Start()
        //    => this.services.Notifications.Register(this.GetType(), false, "HTTP Transfers");
    }
}
