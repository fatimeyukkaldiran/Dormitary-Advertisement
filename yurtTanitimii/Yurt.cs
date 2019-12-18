using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yurtTanitimii
{
    public abstract class Yurt
    {
        public Cinsiyet _Cinsiyet;
        public Yurt(Cinsiyet c)
        {
            this._Cinsiyet = c;
        }
         public virtual void cinsiyetSecim()
        {
            _Cinsiyet.cinsiyetSecim();
        }
    }


}
