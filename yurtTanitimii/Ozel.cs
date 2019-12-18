using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yurtTanitimii
{
    public class Ozel : Yurt
    {
        public Ozel(Cinsiyet c)
            :base(c)
        {
            
        }
        string y;
        public override void cinsiyetSecim()
        {
             y="...Ozel Yurt...";
            base.cinsiyetSecim();   
        }
        
    }
}
