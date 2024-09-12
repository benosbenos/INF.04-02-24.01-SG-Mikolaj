using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace INF._04_02_24._01_SG_Mikolaj
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
