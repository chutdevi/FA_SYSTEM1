using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_SYSTEM1
{
    
    public class Worker
    {
        public JArray _system_user { get; set; }
        public System.Drawing.Image img_user { get; set; }
        public string _name_user { get; set; }
        public string _ename_user { get; set; }
        public string _sur_user { get; set; }
        public string _uid_user { get; set; }
        public string _dep_user { get; set; }
        //private string _name_user { get; set; }
        public Worker()
        {

        }

        public Worker(string uid)
        {
            JArray user = Api.api_getJArray("http://192.168.161.102/api_system/Api_emptransfer/user_ck?user=" + uid);
            img_user = Api.DownloadImage("http://192.168.82.23/member/photo/" + uid + ".jpg");
            this._system_user = user;
        }

        public void worker_set(JArray user )
        {
            this._uid_user   = user[0]["USER_CD"].ToString();
            this._name_user  = user[0]["USER_TNAME"].ToString();
            this._ename_user = user[0]["USER_ENAME"].ToString();
            this._dep_user   = user[0]["DEPT_NAME"].ToString();
        }


        public int user_in()
        {
           // Console.WriteLine(this._system_user);
            return this._system_user.Count();
        }
    }
}
