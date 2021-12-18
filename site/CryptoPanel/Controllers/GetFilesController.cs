using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPanel.Controllers
{
    public class GetFilesController : Controller
    {
        private readonly IWebHostEnvironment web;

        public GetFilesController(IWebHostEnvironment web)
        {
            this.web = web;
        }
        public VirtualFileResult GetCp()
        {
            var filepath = Path.Combine("~/Files", "1");
            return File(filepath, "exe/plain", "1.exe");
        }

        public VirtualFileResult GetGp()
        {
            var filepath = Path.Combine("~/Files", "2");
            return File(filepath, "exe/plain", "2.exe");
        }
    }
}
