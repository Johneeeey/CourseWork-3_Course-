using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Table
    {
        private Int16 _tableNumber;
        private Int16 _numberOfSeats;
        private string _color;
        private string _material;
        private string _formFactor;
        private string _status;
        private string _owner;
        private string _imagePath;

        public Int16 TableNumber
        {
            get { return _tableNumber; }
            set { _tableNumber = value; }
        }
        public Int16 NumberOfSeats
        {
            get { return _numberOfSeats; }
            set { _numberOfSeats = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public string FormFactor
        {
            get { return _formFactor; }
            set { _formFactor = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public string ImagePath
        {
            get { return _imagePath; }
        }

        public Table()
        {
            this._tableNumber = 0;
            this._numberOfSeats = 0;
            this._color = null;
            this._material = null;
            this._formFactor = null;
            this._status = null;
            this._owner = null;
            this._imagePath = null;
        }
        public Table(Int16 ID)
            : this(FileClass.ReadFromFile(ID)) { }
        public Table(string FullInfo)
        {
            TableObjectInitialization(FullInfo);
        }
        private void TableObjectInitialization(string FullInfo)
        {
            string[] _fullInfo = FullInfo.Split(';');
            this._tableNumber = Int16.Parse(_fullInfo[0]);
            this._numberOfSeats = Int16.Parse(_fullInfo[1]);
            this._color = _fullInfo[2];
            this._formFactor = _fullInfo[3];
            this._material = _fullInfo[4];
            this._status = _fullInfo[5];
            this._owner = _fullInfo[6];
            this._imagePath = _fullInfo[7];
        }
    }
}