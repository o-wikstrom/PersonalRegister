using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class User : WorkerBase
    {
        string info = " ";
        bool sak = true;
        public User(string name, string lastname, string id) : base(name, lastname, id)
        {
        }
        List<WorkerBase> arbetare = new List<WorkerBase>();
        public string addWorker(string name, string lastname, string id)
        {
            

            
            while (sak)
            {
                Console.Write("Namn: ");
                name = Console.ReadLine();
                Console.Write("Efternamn: ");
                lastname = Console.ReadLine();
                Console.Write("ID: ");
                id = Console.ReadLine();
                //birth = DateTime.Now;
                arbetare.Add(new Worker_Ants(name, lastname, id));
                Console.WriteLine("Vill du lägga till en till person? Y/N Y = Yes, N = No");
                string input = Console.ReadLine();
                string toUpper = input.ToUpper();
                if (toUpper == "Y")
                {
                    sak = true;
                }
                else if (toUpper == "N")
                {
                    break;
                }
                

                
            }
            foreach (var i in arbetare)
            {
                Console.WriteLine(i.getWorker());

            }
            return getWorker();
            
        }
        public string SearchWorker(string name, string lastname, string id)
        {
            String sSearch;

            Console.WriteLine("Who do you want to find?");
            sSearch = Console.ReadLine();

            for (int icount = 0; icount < arbetare.Count; icount++)
            {
                if (arbetare[icount].getId().Equals(sSearch))
                {
                    Console.WriteLine("found it");
                    Console.WriteLine(arbetare[icount].getName() + " " + arbetare[icount].getLastname());
            
                }
            }
            return "";
        }
        //public string removeArbetare(string name, string lastname, string id)
        //{
        //    String sSearch;

        //    Console.WriteLine("Who do you want to remove?");
        //    sSearch = Console.ReadLine();

        //    for (int icount = 0; icount < arbetare.Count; icount++)
        //    {
        //        if (arbetare[icount].getId().Equals(sSearch))
        //        {
        //            arbetare[icount].
        //            //arbetare[icount].getId().Remove(icount);
        //            Console.WriteLine("Removed the worker!");
        //        }
        //    }
        //    //foreach (var i in arbetare)
        //    //{
        //       // Console.WriteLine(i.getWorker());

        //    //}

        //    return "";
        //}


        //public string removeArbetare(string name, string lastname, string id)
        //{
        //    int indexfunnen = -1;
        //    Console.WriteLine("Vilken arbetare vill du ta bort? skriv in arbetarens ID:");

        //    string finnArbetareId = Console.ReadLine();

        //    int indexForstNullvarde = arbetare.Count;

        //    for (int i = 0; i < arbetare.Count; i++)
        //    {
        //        if(arbetare[i] != null)
        //        {
        //            if (arbetare[i].getId().Equals(finnArbetareId))
        //            {
        //                indexfunnen = i;
        //            }
        //        }
        //    }
        //    for (int i = 0; i < arbetare.Count; i++)
        //    {
        //        if (arbetare[i] == null)
        //        {
        //            indexForstNullvarde = i;
        //        }
        //        Console.WriteLine("Arbetaren med id:" + finnArbetareId + " har tagits bort!");
        //    }
        //    if (indexfunnen != 0)
        //    {
        //        arbetare[indexfunnen] = arbetare[indexfunnen - 1] = null;
        //    }





            //Console.Write("Namn: ");
            //name = Console.ReadLine();
            //Console.Write("Efternamn: ");
            //lastname = Console.ReadLine();
            //Console.Write("ID: ");
            //id = Console.ReadLine();
            ////birth = DateTime.Now;
            //arbetare.Remove(new Worker_Ants(name, lastname, id));








            //string input = Console.ReadLine();
            //Console.Write(arbetare.Contains(new Worker_Ants("","",input)));

            //foreach(var value in arbetare)
            //{
            //    if(value.Equals(input))
            //    {
            //    arbetare.Remove(new Worker_Ants(name, lastname, id));
            //    }
            //}

            //foreach (var i in arbetare)
            //{
            //    Console.WriteLine(i.getWorker());

            //}



            //return getWorker();
        //}

        public override string getWorker()
        {
            return info = "Arbetaren's Full namn är :  " + getName() + " " + getLastname() + "\n" + " ID till användaren är : " + getId() + "\n";
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

