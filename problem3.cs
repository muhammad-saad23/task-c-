using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class car
    {
        private string make;
        private string model;
        private string year;

        public void setMethod(string Make,string Model,string Year)
        {
            this.make = Make;
            this.model = Model; 
            this.year = Year;
        }
        public void getMethod()
        {
            Console.WriteLine("car: " + "make:" +make +"\nmodel :"+model +"\nyear :"+year);
        }

        
    }

    internal class problem3
    {
        //static void Main(string[] args)
        //{
        //    car car = new car();
        //    car.setMethod("Honda","2017","2022-2024");
        //    car.getMethod();
        //}

    }
}
