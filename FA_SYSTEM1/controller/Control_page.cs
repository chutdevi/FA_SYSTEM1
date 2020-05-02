//using FA_SYSTEM1;

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1
{
    public class Control_page : Worker
    {
        public F_page    home_page;
        public Page_reci reci_page;
        public Page_pass pass_page;
        public Page_rtag rtag_page;
        public Worker user_dt;

        public Control_page( F_page lin)
        {
            home_page = lin;
            reci_page = new Page_reci();
            pass_page = new Page_pass();
            rtag_page = new Page_rtag();
        }
        public void Control_set( Control_page ty, Worker wk)
        {
            user_dt = wk;
            reci_page.tread_task(ty);
            rtag_page.tread_task(ty);

            pass_page.tread_task(ty, wk);
        }



        public void Control_login()
        {
            pass_page.ShowDialog();
        }

        public void Control_logout()
        {
            
            home_page.Show();
            reci_page.Close();
        }


    }
}
