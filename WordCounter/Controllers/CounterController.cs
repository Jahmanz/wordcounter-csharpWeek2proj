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

      [HttpPost("/new")]
      public ActionResult Details()
      {
        string word = (Request.Form["phrase"]);
        RepeatCounter newRepeatCounter = new RepeatCounter();

          return View("Index", word);
        }

    }
  }
