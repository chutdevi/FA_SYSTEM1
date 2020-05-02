using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_SYSTEM1
{
    class DATAS
    {
        public JArray DATASYS { get; set; }
        public List<string[]> DATALIST { get; set; }
        public DATAS()
        {

        }
        public DATAS(string d)
        {
            string u = "http://192.168.161.102/api_system/Api_receiveinmanage/list_acpt?adate=" + d;
            DATASYS  =  API.API_GETJARRAY(u);
        }


        public List<string[]> CONVERTOLISTRECEIVE()
        {
            int index = 1;
            List<string[]> l = new List<string[]>();
            foreach (var items in DATASYS)
            {
                if( !items["PUCH_ODR_CD"].ToString().Equals(String.Empty) )
                l.Add(new string[]
                {
                      (index++).ToString().PadLeft(3, '0')
                    , items["PUCH_ODR_CD"].ToString()
                    , items["ITEM_CD"].ToString()
                    , items["VEND_CD"].ToString()
                    , ((int)(float)items["RECEIVE_QTY"] ).ToString()
                    //, items["DLV_DATE"].ToString()
                    //, items["LOT_RECEIVE"].ToString()
                    , items["INVOICE_CD"].ToString()
                });

            }
            DATALIST = l;
            return l;
        }
        public string GETDATAFROMINDEX(int i, string s)
        {
            return DATASYS[i][s].ToString();
        }
    }
}
