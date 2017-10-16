using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Leetspeak.Models;
using System;

namespace Leetspeak.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/result")]
      public ActionResult Result()
      {
        LeetspeakGenerator newNum = new LeetspeakGenerator();
        List<string> result = newNum.GetResult((Request.Form["new-sentence"]));
        return View(result);
      }
  }
}
