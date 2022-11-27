using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ImTo1CDataExportService.Services;

namespace ImTo1CDataExportService.Controllers
{
    public class S4ObjectsController : ApiController
    {
        private S4ObjectService objectService = new S4ObjectService();

        public IHttpActionResult GetAll()
        {
            return Ok(objectService.GetAllS4Objects());
        }

        public IHttpActionResult GetS4ObjectById(int id)
        {
            return Ok(objectService.GetS4ObjectById(id));
        }

        public IHttpActionResult GetS4ObjectById(string designation)
        {
            return Ok(objectService.GetS4ObjectByDesignation(designation));
        }
    }
}