using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;

namespace WPFDesktopApp
{
   
    class Helper
    {
       
       
        public static string file;
        public static DataTable DataTableFromTextFile(string location ,char delimeter = ',')
        {
            DataTable result;
            location = file;
            string[] LineArray = File.ReadAllLines(location); 
            result = FromDataTable(LineArray, delimeter);
            return result;

        }
        private static DataTable FromDataTable(string[] LineArray,char delimeter =',')
        {
            DataTable dt = new DataTable();
            AddColumnToTable(LineArray, delimeter, ref dt);
            AddRowToTable(LineArray, delimeter, ref dt);
            return dt;
        }

        private static void AddRowToTable(string[] RowCollect, char delimeter, ref DataTable dt)
        {
            for(int i=1; i<RowCollect.Length; i++)
            {
                string[] rows = RowCollect[i].Split(delimeter);
                DataRow dr = dt.NewRow();
                for(int j =0;j< rows.Length;j++)
                {
                    dr[j] = rows[j];

                }
                dt.Rows.Add(dr);
               
            }
        }

        private static void AddColumnToTable(string[] columnCollect,char delimeter,ref DataTable dt)
        {
            string[] columns = columnCollect[0].Split(delimeter);
            foreach(string columnName in columns)
            {
                DataColumn dc = new DataColumn(columnName, typeof(string));
                dt.Columns.Add(dc);
                dt.Columns.AsParallel();
            }
        }
        
        public static string BeautiyJson(string jsonString)
        {
            JToken parseJson = JToken.Parse(jsonString);

            return parseJson.ToString(Formatting.Indented);
        }

    }
}
