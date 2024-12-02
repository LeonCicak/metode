using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseObjekti1
{
    class Automobil
    {
        string marka;
        string brojSasije;
        int snaga;
        int godinaProizvodnje;

        public string BrojSasije { get => brojSasije; set => brojSasije = value; }
        public int Snaga { get => snaga; set => snaga = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }

        public void setMarka(string marka)
        {

            this.marka = marka;
        }
        
        public string getMarka()
        {
            return this.marka;
        }
        public Automobil()
        {

        }
        public Automobil(string marka, string brojSasije,int snaga,int godinaProizvodnje) {
            this.snaga = snaga;
            this.marka = marka; 
            this.godinaProizvodnje= godinaProizvodnje;
            this.BrojSasije= brojSasije;

                
                }

        public override string ToString()
        {
            string ispis= "Marka:" + this.marka + "\n Broj Šasije:" + this.brojSasije + "\n Snaga:" + this.snaga + "\n KS:" + "\n Godina proivodnje:" + this.godinaProizvodnje;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Automobil automobil= new Automobil();
            automobil.setMarka("BMW");
            automobil.Snaga = 10;
            automobil.BrojSasije = "12345ABC";
            automobil.GodinaProizvodnje = 2023;
            */
            Automobil automobil = new Automobil("BMW ", "123456ABC", 150, 2023);
            Console.WriteLine (automobil.getMarka());
            Console.WriteLine(automobil.Snaga);
            Console.WriteLine(automobil.BrojSasije);
            Console.WriteLine(automobil.GodinaProizvodnje);


            Console.WriteLine(automobil.ToString());
            Console.ReadKey();
        }
    }
}
