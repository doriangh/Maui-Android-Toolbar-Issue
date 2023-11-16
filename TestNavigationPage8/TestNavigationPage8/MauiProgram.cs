using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace TestNavigationPage8;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		ToolbarHandler.Mapper.AppendToMapping("Test", (handler, toolbar) =>
		{
#if ANDROID
			handler.PlatformView.TitleCentered = true;
			handler.PlatformView.SetTitleTextColor(Colors.Red.ToPlatform());
#endif
		});


		return builder.Build();
	}
}

