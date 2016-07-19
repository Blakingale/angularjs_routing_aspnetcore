using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using WebApplication12.Models;

namespace WebApplication12.controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MysqlConnector test = new MysqlConnector();
            return View(test);
        }
      
    }
}
