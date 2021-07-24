using ExcelDataReader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumFirst01
{
    class ExcelLib
    {
        private static DataTable ExcelToDataTable(string fileName)
        {
            //open file and return as stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            //createopenxmlcader via ExcelcaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx

            //object excelDataReader = null;
            //set the firstv row as column name
            excelReader.IsFirstRowAsColumnNames = true;

            //return as dataset
            DataSet result = excelReader.AsDataSet();

            //get all the tables
            DataTableCollection table = result.Tables;

            //store it in datatable
            DataTable resultTable = table["Sheet1 "];

            //RETURN
            return resultTable;
        }

        static List<Datacollection> dataCol = new List<Datacollection>();
        //private static object excelDataReader;

        public static  void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col <= table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colvalue = table.Rows[row - 1][col].ToString()
                    };
                    //add all the details for each row
                    dataCol.Add(dtTable);
                }
            }

        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //retrieving data using LINQ to reduce number of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colvalue).SingleOrDefault();
                // var datas = dataCol.Where(x => x.colName == columnName && x.rownumber  == rowNumber).SingleOrDefault().colvalue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }

        }

    }
    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colvalue { get; set; }

    }


}



