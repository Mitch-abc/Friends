using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    internal class dataTypeAttribute : Attribute
    {
        private DataType date;

        public dataTypeAttribute(DataType date)
        {
            this.date = date;
        }
    }
}