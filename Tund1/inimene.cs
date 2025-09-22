using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Jurgen
{
    public abstract class Inimene
    {
        
        public string Nimi;
        public int Vanus;
        public Inimene()
        {          
        }

        public Inimene(string nimi, int vanus) 
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Tervita()
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }
        public abstract void Mida_Teeb();
            

        }
    }

