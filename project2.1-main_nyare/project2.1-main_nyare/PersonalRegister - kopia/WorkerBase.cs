using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public abstract class WorkerBase
    {
        public string name { get; private set; }
        public string lastname {get; private set; }
        public string Id {get; private set; }

        public WorkerBase(string name, string lastname, string id)
        {
            this.name = name;
            this.lastname = lastname;
            this.Id = id;

        }


        public abstract string getName();

        public abstract string getLastname();


        // get id
        public abstract string getId();


        public abstract string getWorker();
      

    }
}
