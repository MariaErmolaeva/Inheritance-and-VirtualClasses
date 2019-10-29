using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
   public class Presentor
    {
        IView view;
        IModel model;

        public Presentor(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
        }
    }
}
