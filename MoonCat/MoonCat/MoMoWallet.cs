using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace MoonCat
{
    public class MoMoWallet
    {
        public async void OpenMoMoWallet()
        {
            var canOpen = await Launcher.CanOpenAsync("momo://");
            if (canOpen)
            {
                await Launcher.OpenAsync("momo://");
            }
        }
    }
}
