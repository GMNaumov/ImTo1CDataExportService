using System.Collections.Generic;
using ImTo1CDataExportService.Models;

namespace ImTo1CDataExportService.Services
{
    interface IS4ObjectService
    {
        List<S4Object> GetAllS4Objects();

        S4Object GetS4ObjectById(int id);

        S4Object GetS4ObjectByDesignation(string designation);
    }
}
