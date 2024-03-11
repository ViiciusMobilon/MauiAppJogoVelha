namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        int contador = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
        Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez == "O") 
            {
            disparador.Text = "0";
                vez = "X";
            } else
            {
                disparador.Text="X";
                vez = "O";


            }



        }

       
    }

}
