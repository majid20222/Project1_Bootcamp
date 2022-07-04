using System;

namespace ElectricBill
{
    class ElectricBill
    {

        //public
        protected double Totalsum ;
        public double  Units;
        public ElectricBill(double units)
        {
            Units = units;
        }
        public void  CalculateBill(string type)
        {
            if (type=="commercial")
            {
                Commercial newBill = new Commercial(Units);
                
                Console.WriteLine("Commercial Bill: "+newBill.CalculateBill());
            }
            else
            {
                Residential newBill = new Residential(Units);
                Console.WriteLine("Residential Bill: "+newBill.CalculateBill());
            }
        }
    
    }

    ////Inheritance Class 1
    class Residential : ElectricBill  // derived class (child)
    {
        
        public Residential(double units ):base(units)
        {
 
        }
        public double  CalculateBill()
        {
            if (Units <= 100 && Units > 0)
            {
                Totalsum += Units * 5;
            }
            else if (Units > 100 && Units <= 200)
            {
                double x = Units - 100;
                Totalsum += (100 * 5) + (x * 17);
            }
            else if (Units > 200 && Units <= 500)
            {
                double x = Units - 100;
                double y = x - 100;
                Totalsum += (100 * 5) + (100 * 17) + (y * 23);
            }
            else if (Units > 500)
            {
                double x = Units - 100;
                double y = x - 100;
                double z = y - 300;
                Totalsum += (100 * 5) + (100 * 17) + (300 * 23) + (z * 69);
            }
            double tax = Totalsum * 0.13;
            double finalBill = tax + Totalsum;
            return finalBill;


        }
    }
    //Inheritance Class 2
    class Commercial : ElectricBill  // derived class (child)
    {
    
        public Commercial(double units) : base(units)
        {
        }
        public double CalculateBill()
        {
            if (Units <= 100 && Units > 0)
            {
                Totalsum += Units * 8;
            }
            else if (Units > 100 && Units <= 200)
            {
                double x = Units - 100;
                Totalsum += (100 * 8) + (x * 21);
            }
            else if (Units > 200 && Units <= 500)
            {
                double x = Units - 100;
                double y = x - 100;
                Totalsum += (100 * 8) + (100 * 21) + (y * 23);
            }
            else if (Units > 500)
            {
                double x = Units - 100;
                double y = x - 100;
                double z = y - 300;
                Totalsum += (100 * 8) + (100 * 21) + (300 * 23) + (z * 79);
            }
            double tax = Totalsum * 0.17;
            double finalBill = tax + Totalsum;
            return finalBill;


        }
    }
}
