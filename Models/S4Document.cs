namespace ImTo1CDataExportService.Models
{
    public class S4Document
    {
        public int DocumentId { get; }
        public string Designation { get; }
        public string Name { get; }
        public string Type { get; }
        public int TypeId { get; }

        public S4Document(int documentId, string designation, string name, int typeId)
        {
            DocumentId = documentId;
            Designation = designation;
            Name = name;
            TypeId = typeId;
        }
    }
}