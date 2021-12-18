using CryptoPanel.Models;
using CryptoPanel.Models.Contexsts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPanel.Controllers
{
    [Authorize]
    public class BarController : Controller
    {

        private readonly EntityContext context;

        public BarController(EntityContext context)
        {
            this.context = context;
        }

        public async Task <IActionResult> Statistics(int pageNumber = 1)
        {
            ViewBag.Online = context.Stats.Where(x => x.Time > DateTime.Now.AddHours(-1)).Count();
            ViewBag.All = context.Stats.Count();
            return View(await Pagination<Stats>.CreateAsync(context.Stats, pageNumber, 10));
        }

        [HttpGet]
        public IActionResult AddUpdateInfo()
        {
            Update upd = new Update();
            return View(upd);
        }

        [HttpPost]
        public IActionResult AddUpdateInfo(string Link, string Name)
        {

            if (Link.Length > 0 || Name.Length > 0)
            {
                Update upd = new Update()
                {
                    Link = Link,
                    Name = Name
                };

                context.Updates.Add(upd);
                context.SaveChanges();
            }
            return View();
        }


        public IActionResult Modules()
        {
            return View();
        }

    }
}
