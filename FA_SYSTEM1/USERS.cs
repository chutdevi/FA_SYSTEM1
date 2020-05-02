using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FA_SYSTEM1
{
    class USERS
    {
        public JArray SYSTEM_USER { get; set; }
        public System.Drawing.Image IMAGE_USER { get; set; }
        public string NAME_USER { get; set; }
        public string ENAME_USER { get; set; }
        public string SUR_USER { get; set; }
        public string UID_USER { get; set; }
        public string DEP_USER { get; set; }
        public USERS()
        {

        }
        public USERS(string uid)
        {
            JArray user = API.API_GETJARRAY("http://192.168.161.102/api_system/Api_emptransfer/usersys?user=" + uid );

            this.SYSTEM_USER = user;
            if (this.SYSTEM_USER.Count > 0)
            {
               // Console.WriteLine(user);
                WORKERSET(user);
            }
            else
            {
                MessageBox.Show("error login");
            }



            IMAGE_USER  = API.DOWNLOADIMAGE("http://192.168.161.102/api_system/img_mem/" + uid + ".jpg" );            
        }


        private void WORKERSET(JArray user)
        {
            this.UID_USER = user[0]["USER_CD"].ToString();
            this.NAME_USER = user[0]["USER_TNAME"].ToString();
            this.ENAME_USER = user[0]["USER_ENAME"].ToString();
            this.DEP_USER = user[0]["DEPT_NAME"].ToString();
        }

        public Boolean USERPIN(String p)
        {
           String url  = "http://192.168.161.102/api_system/Api_emptransfer/user_pinlogin?user=";
           Boolean flg = ( API.API_REQUEST( url + this.UID_USER + "&upin=" + p ).Equals("1")) ? true : false;
           return flg;
        }
        public Boolean USERIN()
        {
            // Console.WriteLine(this._SYSTEM_USER);
            Boolean flg = (SYSTEM_USER.Count() > 0) ? true : false;
            return flg;
        }
    }
}
