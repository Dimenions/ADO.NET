using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Round2.Validators;
using FluentValidation.Results;
using System.ComponentModel;

namespace Round2
{
    class Program
    {
        public static void Main()
        {
            UiLogic a = new UiLogic();
            a.Run();
        }
    }
}
