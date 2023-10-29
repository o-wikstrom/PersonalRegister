using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Worker_Ants : WorkerBase, Iworker
    {


        string info = " ";
  
 
        public Worker_Ants(string name, string lastname, string id) : base(name, lastname, id) //konstruktur
        {
        }

        //private String name { get; set; }
        //private String lastname { get; set; }
        //private int Id { get; set; }

        
        public bool WorkerShoes() 
        {
            Console.WriteLine("Vill du ha skydds Skor, svara 1 för ja eller 0 för nej!");
            int input;
            input = Convert.ToInt32(Console.ReadLine());


            if (input == 1)
            {
                Console.WriteLine("Tack! du har skor nu");
                return true;
            }
            else 
            {
                
                Console.WriteLine("Tack! du har inga skor nu");
                return false;
            }
            /*else
            {
                Console.WriteLine("Fel inträffat");
            }

            return (false);*/
        }

        public override string getWorker() //inherate from abs
        {
            return info = "Arbetaren's Full namn är :  " + getName() +" "+ getLastname() + "\n" + " ID till användaren är : " + getId() + "\n" + " Arbetaren är typen of : " + getDescription() + "\n" + "Arbetskor: " + WorkerShoes();
            //throw new NotImplementedException();
        }

        public string getDescription()
        {
            return "Ant";
        }

        public override string getLastname()
        {
            return lastname;
        }

        public override string getId()
        {
            return Id;
        }

        public override string getName()
        {
            return name;
        }
    }
}
