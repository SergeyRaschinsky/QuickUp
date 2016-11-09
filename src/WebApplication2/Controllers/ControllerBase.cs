using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ControllerBase : Controller
    {
        public bool IsExportRequired { get; set; }
    }
}