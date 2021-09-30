using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOPInterfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        void Enter();
        void Display();

    }

}
