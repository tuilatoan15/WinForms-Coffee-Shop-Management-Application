using System;
using System.Data;

namespace PhanMemQuanLyQuanCAFE.DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private int iDcategory;
        private float price;

        public Food(int iD, string name, int iDcategory, float price)
        {
            this.ID = iD;
            this.Name = name;
            this.IDcategory = iDcategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.IDcategory = (int)row["IDCategory"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IDcategory { get => iDcategory; set => iDcategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
