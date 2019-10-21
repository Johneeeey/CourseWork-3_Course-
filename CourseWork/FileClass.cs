using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CourseWork
{
    public static class FileClass
    {
        private static string _fileAddress;
        private static List<string> _tableList;

        public static string FileAddress
        {
            get { return _fileAddress; }
            set
            {
                /*Т.к. класс статический при смене адреса файла нужно обнулять список объектов, чтобы позже он изменялся*/
                if (value != _fileAddress)
                {
                    _fileAddress = value;
                    _tableList = null;
                }
            }
        }
        public static List<string> TableList
        {
            get
            {
                if (_tableList == null)
                {
                    _tableList = ReadFromFile();
                }
                return _tableList;
            }
            set { _tableList = value; }
        }
        
        public static List<string> ReadFromFile()
        {
            string[] _bufMass = File.ReadAllLines(_fileAddress);
            List<string> _bufList = new List<string>();
            foreach(string str in _bufMass)
            {
                if (str.Contains(';') && str.Split(';').Length == 8)
                {
                    _bufList.Add(str.Trim());
                }
            }
            return _bufList;
        }
        public static string ReadFromFile(Int16 ID)
        {
            string[] _bufMass = File.ReadAllLines(_fileAddress);
            foreach(string str in _bufMass)
            {
                string[] info = str.Split(';');
                if (info[0] == ID.ToString())
                {
                    return str;
                }
            }
            return null;
        }
        public static void AddToFile(string value)
        {
            TableList.Add(value);
            Save(TableList);
        }
        public static void AddToFile(Table table)
        {
            string value = table.TableNumber.ToString() + ";" +
                            table.NumberOfSeats.ToString() + ";" +
                            table.Color + ";" +
                            table.FormFactor + ";" +
                            table.Material + ";" +
                            table.Status + ";" +
                            table.Owner + ";" +
                            "Картинки\\none.jpg";
            TableList.Add(value);
            Save(TableList);
        }
        public static void RemoveFromFile(string value)
        {
            foreach(string table in TableList.ToArray())
            {
                if (table == value)
                    TableList.Remove(value);
            }
            Save(TableList);
        }
        public static void RemoveFromFile(Int16 ID)
        {
            foreach(string table in TableList.ToArray())
            {
                string[] info = table.Split(';');
                if (Convert.ToInt16(info[0].Trim()) == ID)
                {
                    TableList.Remove(table);
                }
            }
            Save(TableList);
        }
        public static void ChangeFile(Int16 Table_ID, string[] value)
        {
            Int16 RowCount = 0;
            string[] tableInfo = null;
            string bufStr = null;
            foreach (string table in TableList.ToArray())
            {
                tableInfo = table.Split(';');
                if (Int16.Parse(tableInfo[0]) == Table_ID)
                {
                    for(int i = 0; i < tableInfo.Length; i++)
                    {
                        tableInfo[i] = value[i];
                    }
                    break;
                }
                RowCount++;
            }
            for(int i = 0; i < tableInfo.Length; i++)
            {
                if (i == tableInfo.Length - 1)
                {
                    bufStr += tableInfo[i];
                    break;
                }
                bufStr += tableInfo[i] + ";";
            }
            TableList[RowCount] = bufStr;
            Save(TableList);
        }
        public static DataView TableGrid()
        {
            DataTable dt = new DataTable();
            DataColumn TableIDColumn = new DataColumn("TableNumber", typeof(string));
            DataColumn NumberOfSeatsColumn = new DataColumn("PlaceCount", typeof(string));
            DataColumn TableColorColumn = new DataColumn("Color", typeof(string));
            DataColumn TableMaterialColumn = new DataColumn("FormFactor", typeof(string));
            DataColumn TableFormColumn = new DataColumn("Material", typeof(string));
            DataColumn TableStatusColumn = new DataColumn("Status", typeof(string));
            DataColumn TableOwner = new DataColumn("Owner", typeof(string));
            DataColumn Image = new DataColumn("Image", typeof(string));
            dt.Columns.Add(TableIDColumn);
            dt.Columns.Add(NumberOfSeatsColumn);
            dt.Columns.Add(TableColorColumn);
            dt.Columns.Add(TableMaterialColumn);
            dt.Columns.Add(TableFormColumn);
            dt.Columns.Add(TableStatusColumn);
            dt.Columns.Add(TableOwner);
            dt.Columns.Add(Image);
            foreach(string table in TableList)
            {
                string[] _tableInfo = table.Split(';');
                DataRow row = dt.NewRow();
                row.ItemArray = new object[] { _tableInfo[0],
                                                _tableInfo[1],
                                                _tableInfo[2],
                                                _tableInfo[3],
                                                _tableInfo[4],
                                                _tableInfo[5],
                                                _tableInfo[6],
                                                _tableInfo[7] };
                dt.Rows.Add(row);
            }
            return dt.DefaultView;
        }
        public static Int16 GetNewElementNum()
        {
            string[] temp = TableList[TableList.Count - 1].Split(';');
            Int16 number = Int16.Parse(temp[0]);
            return number;
        }
        public static void Save(List<string> Info)
        {
            File.WriteAllLines(FileAddress, Info);
        }
    }
}
