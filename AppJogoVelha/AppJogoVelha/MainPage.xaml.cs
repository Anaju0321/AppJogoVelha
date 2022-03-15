using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            jogadas = jogadas + 1;

            // Identificando qual botão disparou o evento
            Button btn = (Button)sender;
            
            // Desabilitando o botão
            btn.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            if (vez == "X")
            {
                btn.Text = "X";                
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se a linha 1 teve ganhador.
            if(btn00.Text == "X" && btn01.Text == "X" && btn02.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";


            } else if (btn00.Text == "O" && btn01.Text == "O" && btn02.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }





            // Verificando se a linha 2 teve ganhador.
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";


            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }


            // Verificando se a linha 3 teve ganhador.
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";

            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }


            // Verificando se a coluna 1 teve ganhador.
            if (btn00.Text == "X" && btn10.Text == "X" && btn20.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";

            }
            else if (btn00.Text == "O" && btn10.Text == "O" && btn20.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }



            // Verificando se a coluna 2 teve ganhador.
            if (btn01.Text == "X" && btn11.Text == "X" && btn21.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";

            }
            else if (btn01.Text == "O" && btn11.Text == "O" && btn21.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }



            // Verificando se a coluna 3 teve ganhador.
            if (btn02.Text == "X" && btn12.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";

            }
            else if (btn02.Text == "O" && btn12.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }



            // Verificando se a diagonal 1 teve ganhador.
            if (btn00.Text == "X" && btn11.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";

            }
            else if (btn00.Text == "O" && btn11.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }





            // Verificando se a diagonal 2 teve ganhador.
            if (btn20.Text == "X" && btn11.Text == "X" && btn02.Text == "X")
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";

            }
            else if (btn20.Text == "O" && btn11.Text == "O" && btn02.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }
            else if (btn20.Text == "O" && btn11.Text == "O" && btn02.Text == "O")
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");

                btn00.IsEnabled = true;
                btn00.Text = "";
                btn01.IsEnabled = true;
                btn01.Text = "";
                btn02.IsEnabled = true;
                btn02.Text = "";

                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";

                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
            }

            if(jogadas == 9)
            {

            }
        }
    }
}
