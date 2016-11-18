using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PivotalCF.Models;

namespace PivotalCF.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var environment = @"
                {
 
                  'application_id': 'fa05c1a9-0fc1-4fbd-bae1-139850dec7a3',
                  'application_name': 'my-app',
                  'instance_id':'72769cd1-0dfa-423d-47cd-732113ec580c',
                  'PORT':'8080',
                  'start':'26/10/2016 12:15:46 AM',
                  'application_uris': [
                    'my-app.10.244.0.34.xip.io'
                  ],
                  'application_version': 'fb8fbcc6-8d58-479e-bcc7-3b4ce5a7f0ca',
                  'limits': {
                    'disk': 1024,
                    'fds': 16384,
                    'mem': 256
                  },
                  'name': 'my-app',
                  'space_id': '06450c72-4669-4dc6-8096-45f9777db68a',
                  'space_name': 'my-space',
                  'uris': [
                    'my-app.10.244.0.34.xip.io',
                    'my-app2.10.244.0.34.xip.io'
                  ],
                  'users': null,
                  'version': 'fb8fbcc6-8d58-479e-bcc7-3b4ce5a7f0ca'
                }";

            // Arrange
            //Environment.SetEnvironmentVariable("VCAP_APPLICATION", environment);
            //var services = new ServiceCollection().AddOptions();

            //var builder = new ConfigurationBuilder().AddCloudFoundry();
            //var config = builder.Build();

            //services.Configure<CloudFoundryApplicationOptions>(config);
            //var service = services.BuildServiceProvider().GetService<IOptions<CloudFoundryApplicationOptions>>();
            //var options = service.Value;
            var p = System.Environment.GetEnvironmentVariable("VCAP_APPLICATION");

            if (p != null)
            {
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(p);

                return View(result);
            }
            return View(new RootObject());
        }

        public IActionResult Kill()
        {
            Environment.Exit(-1);


            TempData["Message"] = "Your application description page.";

            return RedirectToAction("Index");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
