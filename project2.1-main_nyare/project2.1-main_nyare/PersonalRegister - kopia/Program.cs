using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PersonalRegister // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int menyUI;
            bool mainMeny = true;
            User user = new User("","","");
            //ArrayList myList = new ArrayList();
            while (mainMeny)
            {

                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("Välj ett av dem fem alternativen genom att skriva 1-5! \n");
                Console.WriteLine("1) Lägga till en arbetare");
                Console.WriteLine("2) Söka upp en arbetare");
                Console.WriteLine("3) Tar bort en person ur queue");
                Console.WriteLine("4) Binary search!");
                Console.WriteLine("5) Stäng av programmet!\n");
                Console.Write("Välj ett alternativ: ");

                menyUI = Convert.ToInt32(Console.ReadLine());

                switch(menyUI)
                {
                    case 1:
                        
                        user.addWorker("","","");
                        break;

                    case 2:
                        
                        user.SearchWorker("","","");
                        break;

                    case 3:

                        Queue<WorkerBase> queueWorker = new Queue<WorkerBase>();

                        queueWorker.Enqueue(new Worker_Bees("Alexander", "Nordström", "80"));
                        queueWorker.Enqueue(new Worker_Ants("Aisha", "Hassan", "99"));
                        queueWorker.Enqueue(new Worker_Bees("Laza", "Gabriout", "90"));
                        queueWorker.Enqueue(new Worker_Ants("Oscar", "Wikström", "90"));


                        foreach (var i in queueWorker)
                        {
                            Console.WriteLine(i.getWorker());

                        }

                        Console.WriteLine("Sedan så tar vi bort den första i kön!");

                        queueWorker.Dequeue();

                        foreach (var i in queueWorker)
                        {
                            Console.WriteLine(i.getWorker());

                        }


                        break;
                    case 4:

                        List<WorkerBase> myList = new List<WorkerBase>();






                        myList.Add(new Worker_Ants("Aisha", "Hassan", "996"));
                        myList.Add(new Worker_Ants("Rikard", "Land", "696"));
                        myList.Add(new Worker_Ants("Alice", "Hansson", "423"));
                        myList.Add(new Worker_Ants("Titti", "Hane", "789"));

                        foreach (var i in myList)
                        {
                            Console.WriteLine(i.getWorker());

                        }


                        WorkerBase SearchArbetare = new Worker_Ants("Rikard", "Land", "696");
                        int index = myList.BinarySearch(SearchArbetare, new SearchWorker());
                        Console.WriteLine($"\n{SearchArbetare.getName()} finns i index: {index}"); 


                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }


            }
        }
    }
}
