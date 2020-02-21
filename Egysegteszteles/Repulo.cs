using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszteles
{
    class Repulo
    {
        int ferohelyek;
        int foglalas;
        private int v;

        public Repulo(int ferohelyek)
        {
            if (ferohelyek<=0)
            {
                throw new ArgumentException("A férőhelyek száma pozitív kell legyen");
            }
            this.ferohelyek = ferohelyek;
        }

        public double SzabadHelyek {
            get { return ferohelyek- foglalas; }
        }

        public bool teli
        {
            get
            {
                return ferohelyek == foglalas;
            }
        }

        public bool lefoglal()
        {
            if (teli)
            {
                return false;
            }
            foglalas++;
            return true;
        }

    }
}
