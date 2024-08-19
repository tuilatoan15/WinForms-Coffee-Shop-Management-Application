using System.Data;

namespace PhanMemQuanLyQuanCAFE.DTO
{
    public class Table
    {
        private int iD;
        private string name;
        private string status;

        public Table() { }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        public Table(int iD, string name, string status)
        {
            this.ID = iD;
            this.Name = name;
            this.Status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
