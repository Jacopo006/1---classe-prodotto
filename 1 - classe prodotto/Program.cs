using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___classe_prodotto
{
        class Prodotto
        {
            private string nome;
            private double prezzo;
            public Prodotto()
            {
                nome = "";
                prezzo = 0;
            }
            public Prodotto(string nome, double prezzo)
            {
                this.nome = nome;
                this.prezzo = prezzo;
            }

            public string ottieninome()
            {
                return nome;
            }
            public double ottieniprezzo()
            {
                return prezzo;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
            Prodotto prodotto1 = new Prodotto("Patata", 20);
            Prodotto prodotto2 = new Prodotto("Pizza", 50);
            Console.WriteLine("Prodotto 1 - Nome: {0}, Prezzo: {1}", prodotto1.ottieninome(), prodotto1.ottieniprezzo());
            Console.WriteLine("Prodotto 2 - Nome: {0}, Prezzo: {1}", prodotto2.ottieninome(), prodotto2.ottieniprezzo());
        }
        }
    }

