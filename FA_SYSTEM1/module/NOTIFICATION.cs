using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FA_SYSTEM1
{   
    

    //string Name, Age;
    static class NOTIFICATION
    {
        private static string STRPAHT = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
        
        public static void LINENOTF(string s="")
        {
            string token = "4KmjVqmBhxqwsfkasWJakXvDkE5qgby2j918pMxYHYD";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
                var postData = string.Format("message={0}", s);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllLines(STRPAHT, new[] { "Error time : " + DateTime.Now.ToString() + "Error " + ex.Message });
            }
        }
    }


}
