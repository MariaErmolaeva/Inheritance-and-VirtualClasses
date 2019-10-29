using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public interface IModel
    {
        int index { set; }
        int countArray { get; }
        Person person { get; }
        
    }
}
