using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ADR.Models;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;
using System.Net;

namespace ADR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


      

        [HttpPost]
        public JsonResult HostPing(string GethostnameIP)
        {
          //  System.Diagnostics.Debug.WriteLine("Qual?-" + GethostnameIP);

            Ping ping = new Ping();
            PingReply reply = ping.Send(GethostnameIP, 1000);
            IPHostEntry entry = Dns.GetHostEntry(GethostnameIP);
            List<HostDetails> HOST_IP_details = new List<HostDetails>();
          
            try
            {


                if (reply == null)
                {
                    HOST_IP_details.Add(new HostDetails() { Hostname = entry.HostName, HostIP = reply.Address.ToString(), PingTime = 0, TTL = 0, TimeNow = DateTime.Now.ToString("HH:mm:ss"), Bytes = 0 });

                }

                if (reply.Status == IPStatus.Success)
                {
                 
                    HOST_IP_details.Add(new HostDetails() { Hostname = entry.HostName, HostIP = reply.Address.ToString(), PingTime = reply.RoundtripTime,TTL = reply.Options.Ttl, TimeNow = DateTime.Now.ToString("HH:mm:ss"), Bytes = reply.Buffer.Length });
                }

                
            }
            catch (PingException ex)
            {

               
                return Json("Error Message: " + ex.Message);

                HOST_IP_details.Add(new HostDetails() { Hostname = entry.HostName, HostIP = reply.Address.ToString(), PingTime = 0, TTL = 0, TimeNow = DateTime.Now.ToString("HH:mm:ss"), Bytes = 0 });


            }


            return Json(HOST_IP_details.ToList());



        }


    }
}
