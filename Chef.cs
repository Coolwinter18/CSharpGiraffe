using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef Makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef Makes Salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef Makes bbq Ribs");
        }
    }
}
