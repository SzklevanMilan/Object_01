using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Object_01
{
    class Ember
    {
       public string nev;
       public int eletkor;
        public string Bemutatkozas()
        {
            //string valasz =$"{nev} vagyok {eletkor} éves.";
            //return valasz;
            return $"{nev} vagyok {eletkor} éves.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ember pisti = new Ember();

            pisti.nev = "Tóth Pisti";
            pisti.eletkor = 26;
            //pisti.eletkor++;


            Ember eva = new Ember();
            eva.nev = "Nagy Éva";
            eva.eletkor = 18;


            Console.WriteLine(eva.Bemutatkozas());
            Console.WriteLine(pisti.Bemutatkozas());

            Console.ReadKey();
        }
    }
}
