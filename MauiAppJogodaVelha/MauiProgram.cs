using Microsoft.Extensions.Logging;

namespace AppJogoDaVelha
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()//Método para criar o aplicativo
        {
            var builder = MauiApp.CreateBuilder();//Cria um novo
            builder
                .UseMauiApp<App>()//Define a classe principal do aplicativo
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");//Adiciona a fonte OpenSans-Regular
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");//Adiciona a fonte OpenSans-Semibold
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
