using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FA_SYSTEM1
{
    static class Evk
    {
        public static int key_num { get; set; }
        public static void KeyDown_even(Keys key_cd )
        {
            switch (key_cd)
            {
                case Keys.F1:
                    key_num += System.Convert.ToInt32(Keys.F1);
                    break;
                case Keys.O:
                    key_num += System.Convert.ToInt32(Keys.O);
                    break;
                case Keys.D1:
                    key_num += System.Convert.ToInt32(Keys.D1);
                    break;
                case Keys.D2:
                    key_num += System.Convert.ToInt32(Keys.D2);
                    break;
                case Keys.D3:
                    key_num += System.Convert.ToInt32(Keys.D3);
                    break;
                case Keys.D4:
                    key_num += System.Convert.ToInt32(Keys.D4);
                    break;
                case Keys.D5:
                    key_num += System.Convert.ToInt32(Keys.D5);
                    break;
                case Keys.D6:
                    key_num += System.Convert.ToInt32(Keys.D6);
                    break;
                case Keys.D7:
                    key_num += System.Convert.ToInt32(Keys.D7);
                    break;
                default:
                    key_num = 0;
                    break;
            }
        }

        public static void Keyup_even( Form gu)
        {

            //re
//
            //ey_num = 0;
        }


    }
}
