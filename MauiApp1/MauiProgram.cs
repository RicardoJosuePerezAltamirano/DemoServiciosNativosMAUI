

using MauiApp1.Platforms.Android;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
#if ANDROID
        builder.Services.AddTransient<IServicesTest, DemoServices>();
        builder.Services.AddTransient<IMessage, MessageTest>();
#endif
        builder.Services.AddTransient<MainPage>();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
