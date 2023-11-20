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
            }
        }
    }

