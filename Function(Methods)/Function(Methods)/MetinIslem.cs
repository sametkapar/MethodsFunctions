using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Function_Methods_
{
    internal class MetinIslem
    {
        //Kendisine Gönderilen Metnin Başında Boşlukları silen Metot
        public string BastanBoslukSil(string metin)
        {
            int index = -1;
            for (int i = 0; i < metin.Length; i++)
            {
                if(metin[i] != ' ')
                {
                    index = i;
                    break;
                }
            }
            string yenimetin = "";
            for (int i = index; i < metin.Length; i++)
            {
                yenimetin += metin[i];
            }
            return yenimetin;
        }
    }
}
