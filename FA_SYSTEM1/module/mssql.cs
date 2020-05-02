using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace FA_SYSTEM1
{
    static class mssql
    {
        private static Thread[] threadArray = new Thread[2];
        private static SqlConnection cnn;
        private static string log;
        static  mssql()
        {
            ParameterizedThreadStart thread = new ParameterizedThreadStart(connect_sql);
            threadArray[0] = new Thread(thread);
            threadArray[0].Start(cnn);

            log = "Start thread";
            Console.WriteLine(log);
        }
        public static void main()
        {
            Console.WriteLine("Goodby oor");
        }
        public static void ms_qery()
        {
            Console.WriteLine("Goodby oor 1");
        }

        private static void connect_sql( Object cc )
        {

            
            log = "Process thread"; 
            Console.WriteLine(log);
            string connetionString = null;

            connetionString = "Data Source=192.168.161.101;Initial Catalog=FASYSTEM;User ID=pcs_admin;Password=P@ss!fa";
            cc = new SqlConnection(connetionString);
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message + " => " + "Can not open connection ! ");
            }

        }

    }
}
