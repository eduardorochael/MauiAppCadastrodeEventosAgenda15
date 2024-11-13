using MauiAppCadastrodeEventos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppCadastrodeEventos.ViewModel
{
    public class EventoViewModel : BindableObject
    {
        private Evento _evento;
        public Evento Evento
        {
            get => _evento;
            set
            {
                _evento = value;
                OnPropertyChanged();
            }
        }

        public ICommand CadastrarEventoCommand { get; }

        public EventoViewModel()
        {
            Evento = new Evento
            {
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1)
            };

            CadastrarEventoCommand = new Command(OnCadastrarEvento);
        }

        private async void OnCadastrarEvento()
        {
            // Navegar para a página de resumo
            await Application.Current.MainPage.Navigation.PushAsync(new ResumoPage(Evento));
        }
    }
}
