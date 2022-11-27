using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImTo1CDataExportService.Models
{
    public class S4Object
    {
        private static int id = 1;
        public int s4ObjectId { get; set; }
        public string designation { get; set; }
        public string name { get; set; }
        public double weight { get; set; }

        public S4Object(string designation, string name, double weight)
        {
            this.s4ObjectId = GetNextId();
            this.designation = designation;
            this.name = name;
            this.weight = weight;
        }

        public static int GetNextId()
        {
            return id++;
        }
    }
}