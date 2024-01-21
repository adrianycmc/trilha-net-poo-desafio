using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //Implementado

        private string Modelo {get; set;}

        private string Imei {get; set;}

        private int Memoria {get; set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // Implementado

            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        //Implementações extras
        public virtual void Data()
        {
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));
        }

        public virtual void Relogio()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }

        private List<string> agenda = new List<string>();
        public void AdicionarItemNaAgenda(string Data, string Evento)
        {
            string data = Data;
            string evento = Evento;
            agenda.Add(data + evento);
        }

        public void RemoverItemAgenda(string Data, string Evento)
        {
            string data = Data;
            string evento = Evento;
            agenda.Remove(data + evento);

            Console.WriteLine($"Seu compromisso: '{data + evento}' foi removido.");
        }

        public void ListarItemAgenda()
        {
            if(agenda.Any())
            {
                foreach (string item in agenda)
                {
                    Console.WriteLine($"Seus compromissos são: {item}.");
                }
            }
            else
            {
                Console.WriteLine("Você não tem compromissos!");                
            }
        }        
    }
}    
    