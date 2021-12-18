using CryptoPanel.Models;
using CryptoPanel.Models.Contexsts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CryptoPanel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataController : Controller
    {

        private readonly EntityContext context;
        public DataController(EntityContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("GetInfo")]
        public void Get(Stats stats)
        {
            stats.Time = DateTime.Now;

            if (context.Stats.Any(e => e.Unique == stats.Unique))
            {
                var change = context.Stats.Where(un => un.Unique == stats.Unique).FirstOrDefault();
                change.Time = stats.Time;
                change.ToyCpuStatus = stats.ToyCpuStatus;
                change.ToyGpuStatus = stats.ToyGpuStatus;
            }
            else
            {
                context.Entry(stats).State = EntityState.Added;
            }

            context.SaveChanges();
        }

        [HttpGet]
        [Produces("application/xml")]
        [Route("GetUpdateInfo")]
        public Update GetUpdateInfo()
        {
            Update showPiece = context.Updates.OrderByDescending(p => p.Version).FirstOrDefault();
            return (showPiece);
        }
    }
}