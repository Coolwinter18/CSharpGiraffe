using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            //base.MakeSpecialDish();
            Console.WriteLine("The chef makes chicken parm");
        }
        public void MakesPasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
        

    }
}
