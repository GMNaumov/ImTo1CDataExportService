using System.Collections.Generic;
using ImTo1CDataExportService.Models;

namespace ImTo1CDataExportService.Repository
{
    public class S4ObjectRepository
    {
        List<S4Object> s4Objects;

        public S4ObjectRepository() 
        {
            s4Objects = new List<S4Object>();
            InitS4Repository();
        }

        private void InitS4Repository()
        {
            S4Object firstObject = new S4Object("111-000-222", "Планка", 0.14);
            S4Object secontObject = new S4Object("333-555-444", "Кронштейн", 1.24);
            S4Object thirdObject = new S4Object("777-555-999", "Ручка", 2.00);
            s4Objects.Add(firstObject);
            s4Objects.Add(secontObject);
            s4Objects.Add(thirdObject);
        }

        public List<S4Object> GetS4Objects()
        {
            return s4Objects;
        }
    }
}