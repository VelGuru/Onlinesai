using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSai.FrameworkLib
{
    class ExcelHelper
    {
        public static string FileConnection()
        {
            string conStrContainer = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties ='Excel 8.0;HDR={1}';";
            string path = ConfigurationManager.AppSettings["TestDatapath"];
            string connectionString = String.Format(conStrContainer, path, "Yes");
            return connectionString;
        }

        public static string getTestData(string sheetName,string testMethodName,string columnName)
        {
            OleDbConnection excelDbCon = new OleDbConnection(FileConnection());
            try
            {
                OleDbCommand dbcommand = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                dbcommand.Connection = excelDbCon;
                excelDbCon.Open();

                DataTable excelSchema = excelDbCon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string curSheetName = sheetName + "$";

                dbcommand.CommandText = "Select * From [" + curSheetName + "] where TestMethodname='" + testMethodName + "'";
                dataAdapter.SelectCommand = dbcommand;
                DataTable curSheetData = new DataTable();
                dataAdapter.Fill(curSheetData);
                DataRowCollection datarowcollection = curSheetData.Rows;
                string data = null;
                foreach (DataRow eachdata in datarowcollection)
                {
                    data = eachdata[columnName].ToString().Trim();
                    
                }
                return data;
            }catch(Exception e)
            {

            }finally
                {excelDbCon.Close();}
            
            return null;
        }
    }
}
