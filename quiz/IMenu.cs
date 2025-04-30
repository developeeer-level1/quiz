using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal interface IMenu
    {
        void Display();
        void ClearItself();
        int Input();
    }
}
