namespace AppJogoDaVelha
{
    public partial class App : Application //Classe principal do aplicativo
    {
        public App()//Construtor da classe
        {
            InitializeComponent();//Inicializa o componente

            MainPage = new AppShell();//Define a página principal do aplicativo
        }
    }
}
