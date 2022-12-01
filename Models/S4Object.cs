namespace ImTo1CDataExportService.Models
{
    public class S4Object
    {
        private static int id = 1;
        public int S4ObjectId { get; set; }
        public string Designation { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public S4Object(string designation, string name, double weight)
        {
            this.S4ObjectId = GetNextId();
            this.Designation = designation;
            this.Name = name;
            this.Weight = weight;
        }

        public static int GetNextId()
        {
            return id++;
        }
    }
}