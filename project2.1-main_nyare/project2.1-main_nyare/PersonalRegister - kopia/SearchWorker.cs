using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class SearchWorker : Comparer<WorkerBase>
    {
        public override int Compare(WorkerBase o1, WorkerBase o2)
        {
            
            if(o1.getId() == o2.getId())
            {
                return 0;
            }
            return -1;
        }
    }
}
