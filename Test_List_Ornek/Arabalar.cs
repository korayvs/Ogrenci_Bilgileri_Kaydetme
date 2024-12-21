using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_List_Ornek
{
    internal class Arabalar
    {
        string marka;
        string model;
        int yil;
        string renk;

        public string MARKASI
        {
            get { return marka; }
            set { marka = value; }
        }
        public string MODELI
        {
            get { return model; }
            set {model = value; }
        }
        public int YILI
        {
            get { return yil; }
            set { yil = value; }
        }
        public string RENK
        {
            get { return renk; }
            set { renk = value; }
        }
    }
}
