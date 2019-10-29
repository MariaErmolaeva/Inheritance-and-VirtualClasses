using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtualClasses
{
    public interface IView
    {

        string gender { get; }
        string course { get; }
        string department { get; }

        void MessageError(string message);
        void RequestSuccess(string message);

        void RequestGetNameOnSuccess(Person person);
        void RequestGetNameStudentOnSuccess(Person person);
        void RequestGetTeacherOnSuccess(Person person);

        event EventHandler getNameClick;
        event EventHandler getNameStudentClick;
        event EventHandler getTeacherClick;

    }
}
