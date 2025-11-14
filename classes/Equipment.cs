using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Equipment
    {
        private long equipmentID;
        private string equipmentName;
        private string brand;
        private string model;
        private long categoryID;
        private double cost;
        private int quantity;

        public Equipment()
        {
            this.equipmentID = 0;                 
            this.equipmentName = string.Empty;    
            this.brand = string.Empty;          
            this.model = string.Empty;          
            this.categoryID = 0;               
            this.cost = 0.0;                    
            this.quantity = 0;                    
        }

        public long EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }

        public string EquipmentName
        {
            get { return equipmentName; }
            set { equipmentName = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public long CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
