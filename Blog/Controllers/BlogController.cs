using Blog.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        BlogRepository db = new BlogRepository();

        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Posts.GetAll());
        }


    }
}