using Microsoft.AspNetCore.Mvc;
using ExampleProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExampleProject.Controllers
{
  public class ExamplesController : Controller
  {
    private readonly ExampleProjectContext _db;

    public ExamplesController(ExampleProjectContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Example> model = _db.Examples.ToList();
      return View(model);
    }
  }
}