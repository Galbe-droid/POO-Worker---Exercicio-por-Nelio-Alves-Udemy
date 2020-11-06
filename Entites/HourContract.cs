using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerInfo.Entites
{
    class HourContract
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public double ValuePerHour { get; private set; }
        public int Hours { get; private set; }

        public HourContract()
        {

        }

        public HourContract(int id,double price, int hour, DateTime date)
        {
            Id = id;
            Date = new DateTime();
            ValuePerHour = price;
            Hours = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return "ID: " + Id + " ," + "Date: " + Date + " ," + "Price: " + TotalValue();
        }
    }
}
