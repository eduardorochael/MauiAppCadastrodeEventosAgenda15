using MauiAppCadastrodeEventos.Model;

namespace MauiAppCadastrodeEventos;

public partial class ResumoPage : ContentPage
{
	public ResumoPage(Evento evento)
	{
        InitializeComponent();
        BindingContext = evento;
    }
}