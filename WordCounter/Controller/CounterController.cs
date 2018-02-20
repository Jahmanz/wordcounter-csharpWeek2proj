using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;


namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {

    public ActionResult Index()
      {
    return new EmptyResult();
      }
      // [HttpGet("/")]
      // public ActionResult Index()
      // {
      //     List<Contact> allContacts = Contact.GetAll();
      //     return View(allContacts);
      // }
      //
      // [HttpGet("/new")]
      // public ActionResult CreateForm()
      // {
      //     return View();
      // }
      // [HttpGet("/{id}")]
      //   public ActionResult Details(int id)
      //   {
      //       Contact contact = Contact.Find(id);
      //       return View(contact);
      //   }
      //
      // [HttpPost("/")]
      // public ActionResult Create()
      // {
      //     Contact newContact = new Contact (Request.Form["contact-name"], Request.Form["contact-address"],Request.Form["contact-phone"]);
      //     List<Contact> allContacts = Contact.GetAll();
      //     return View("Index", allContacts);
      //   }
      //
      //   [HttpPost("/delete")]
      //   public ActionResult DeleteAll()
      //   {
      //       Contact.ClearAll();
      //       return View();
      //   }

    }
  }
