using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastrodeEventos.Model
{
    public class Evento
    {
        // Propriedades básicas do evento
        public string NomeEvento { get; set; }          // Nome do evento
        public DateTime DataInicio { get; set; }         // Data de início do evento
        public DateTime DataTermino { get; set; }        // Data de término do evento
        public int NumeroParticipantes { get; set; }     // Número de participantes no evento
        public string Local { get; set; }                // Local onde o evento ocorrerá
        public decimal CustoPorParticipante { get; set; }// Custo por cada participante

        // Propriedade calculada para a duração do evento em dias
        public int DuracaoEmDias
        {
            get
            {
                // TimeSpan calcula a diferença entre as datas
                return (DataTermino - DataInicio).Days;
            }
        }

        // Propriedade calculada para o custo total do evento
        public decimal CustoTotal
        {
            get
            {
                // Custo total é o número de participantes multiplicado pelo custo por participante
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}