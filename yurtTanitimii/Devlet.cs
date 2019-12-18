using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yurtTanitimii
{
    class Devlet : Yurt
    {
        public Devlet(Cinsiyet c)
            : base(c)
        {

        }
        public override void cinsiyetSecim()
        {
            Console.WriteLine("...Devlet Yurt...");
            base.cinsiyetSecim();
        }


    }
}
