namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {

        string vez = "X";
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try {

                Button btn = (Button)sender;
                btn.IsEnabled = false;
                //Console.WriteLine(btn);

                if (vez == "X")
                {
                    btn.Text = "X";
                    vez = "O";
                    count++;
                    //DisplayAlert("QTD: " + count, "", "OK");
                }
                else
                {
                    btn.Text = "O";
                    vez = "X";
                    count++;
                    //DisplayAlert("QTD: " + count, "", "OK");
                }

                if (count >= 9)
                {
                    DisplayAlert("O JOGO DEU VELHA", "", "ZERAR");
                    limpar()zerar();
                }

                //Verificando se x ganhou na linha 1
                if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X"){
                    DisplayAlert("Parabéns", "O X ganhoue", "zerar");
                    zerar();
                }

                if (
                    btn20.Text == "X" && //Verificando se x ganhou na linha 2
                    btn21.Text == "X" && //Verificando se x ganhou na linha 2
                    btn22.Text == "X")//Verificando se x ganhou na linha 2
                {
                    DisplayAlert("Parabéns", "O X ganhoue", "zerar");//Exibe a mensagem de parabéns para o jogador X
                    zerar();
                }

                if (
                    btn30.Text == "X" && 
                    btn31.Text == "X" && 
                    btn32.Text == "X")
                {
                    DisplayAlert("Parabéns", "O X ganhou ", "zerar");
                    zerar();
                }

                if (
                    btn10.Text == "X" && 
                    btn11.Text == "X" && 
                    btn12.Text == "X")
                {
                    DisplayAlert("Parabéns", "O X ganhoue", "zerar");
                    zerar();
                }
                //Verificando Coluna para jogardor X

                //Verificando se ganhou na diagonal 
                if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns", "O X ganhoue", "zerar");
                    zerar();
                }

                if (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X")
                {
                    DisplayAlert("Parabéns", "O X ganhoue", "zerar");
                    zerar();
                }



                //Verificando se O ganhou na linha 1
                if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
                {
                    DisplayAlert("Parabéns", "O ganhoue", "zerar");
                    zerar();
                }

                if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
                {
                    DisplayAlert("Parabéns", "O O ganhoue", "zerar");//Exibe a mensagem de parabéns para o jogador O
                    zerar();
                }

                if (btn30.Text == "O" && btn31.Text == "X" && btn32.Text == "X")
                {
                    DisplayAlert("Parabéns", "O O ganhou ", "zerar");
                    zerar();
                }

                if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
                {
                    DisplayAlert("Parabéns", "O O ganhoue", "zerar");
                    zerar();
                }

                //Verificando Coluna para jogador O

                //Verificando Diagonal para jogador O
                if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
                {
                    DisplayAlert("Parabéns", "O O ganhoue", "zerar");
                    zerar();
                }

                if (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O")
                {
                    DisplayAlert("Parabéns", "O O ganhoue", "zerar");
                    zerar();
                }

            } catch (Exception) {

            }
        }

        void zerar(){
            vez = "X";
            count = 0;

            btn10.Text = "";
            btn20.Text = "";
            btn30.Text = "";

            btn11.Text = "";
            btn21.Text = "";
            btn31.Text = "";

            btn12.Text = "";
            btn22.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn20.IsEnabled = true;
            btn30.IsEnabled = true;

            btn11.IsEnabled = true;
            btn21.IsEnabled = true;
            btn31.IsEnabled = true;

            btn12.IsEnabled = true;
            btn22.IsEnabled = true;
            btn32.IsEnabled = true;

        }
    }
}
