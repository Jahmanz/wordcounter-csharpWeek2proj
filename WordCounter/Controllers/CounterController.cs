using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class CounterController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
          return View();
      }

      [HttpPost("/")]
      public ActionResult Create()
      {
          RepeatCounter newRepeatCounter = new RepeatCounter (Request.Form["phrase"]);
          return View("Index");
        }

    }
  }
