﻿using Foundation;

namespace OperacionesApp
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MainTabbedProgram.CreateMauiApp();
    }
}