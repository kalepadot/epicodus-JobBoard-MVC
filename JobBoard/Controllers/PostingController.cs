using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class PostingController: Controller
  {
    [HttpPost("/posting")]
    public ActionResult Create(string company, string title, int salary)
    {
      Posting newPosting = new Posting(company, title, salary);
      return RedirectToAction("Index", newPosting);
    }
    [HttpGet("/posting")]
    public ActionResult Index()
    {
      List<Posting> allPostings = Posting.GetAll();
      return View(allPostings);
    }
  }
}