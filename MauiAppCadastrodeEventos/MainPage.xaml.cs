using MauiAppCadastrodeEventos.ViewModel;

namespace MauiAppCadastrodeEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new EventoViewModel();
        }
    }
       
        

}
