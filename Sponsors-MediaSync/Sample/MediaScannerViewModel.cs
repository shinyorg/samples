﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Shiny;
using Shiny.MediaSync;
using Shiny.MediaSync.Infrastructure;
using Shiny.XamForms;


namespace Sample
{
    public class MediaScannerViewModel : ViewModel
    {
        public MediaScannerViewModel(IDialogs dialogs, IMediaGalleryScanner? scanner = null)
        {
            this.RunQuery = ReactiveCommand.CreateFromTask(async () =>
            {
                this.IsSearchExpanded = false;
                this.IsBusy = true;
                if (scanner == null)
                {
                    await dialogs.Alert("Media scanner not supported");
                    return;
                }
                var result = await scanner.RequestAccess();
                if (result != AccessState.Available)
                {
                    await dialogs.Alert("Invalid Status - " + result);
                    return;
                }
                var mediaTypes = MediaTypes.None;
                if (this.IncludeAudio)
                    mediaTypes |= MediaTypes.Audio;
                if (this.IncludeImages)
                    mediaTypes |= MediaTypes.Image;
                if (this.IncludeVideos)
                    mediaTypes |= MediaTypes.Video;

                var list = await scanner.Query(mediaTypes, this.SyncFrom);
                this.List.AddRange(list.Select(x => new CommandItem
                {
                    Text = $"{x.Type} - {x.FilePath}",
                    ImageUri = x.Type == MediaTypes.Audio ? null : x.FilePath
                }));
                this.RaisePropertyChanging(nameof(this.List));
                this.IsBusy = false;
            });
            this.BindBusyCommand(this.RunQuery);
        }


        public ICommand RunQuery { get; }
        [Reactive] public bool IsSearchExpanded { get; set; } = true;
        [Reactive] public bool IncludeVideos { get; set; } = true;
        [Reactive] public bool IncludeImages { get; set; } = true;
        [Reactive] public bool IncludeAudio { get; set; } = true;
        [Reactive] public DateTime SyncFrom { get; set; } = DateTime.Now.AddDays(-30);
        public List<CommandItem> List { get; } = new List<CommandItem>();
    }
}
