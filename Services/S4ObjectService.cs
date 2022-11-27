using ImTo1CDataExportService.Models;
using System.Collections.Generic;
using System.Linq;
using ImTo1CDataExportService.Repository;

namespace ImTo1CDataExportService.Services
{
    public class S4ObjectService : IS4ObjectService
    {
        S4ObjectRepository repository;
        List<S4Object> s4Objects;

        public S4ObjectService() 
        {
            repository = new S4ObjectRepository();
            s4Objects = repository.GetS4Objects();
        }

        public List<S4Object> GetAllS4Objects()
        {
            if (s4Objects.Any())
            {
                return s4Objects;
            }
            else
            {
                return new List<S4Object>();
            }    
        }

        public S4Object GetS4ObjectByDesignation(string designation)
        {
            if (s4Objects.Any())
            {
                foreach (S4Object s4Object in s4Objects)
                {
                    if (designation.Equals(s4Object.designation))
                    {
                        return s4Object;
                    }
                }
            }

            return null;
        }

        public S4Object GetS4ObjectById(int id)
        {
            if (s4Objects.Any())
            {
                foreach (S4Object s4Object in s4Objects)
                {
                    if (id == s4Object.s4ObjectId)
                    {
                        return s4Object;
                    }
                }
            }

            return null;
        }
    }
}