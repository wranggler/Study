using HomeWork9.Models;
using HomeWork9.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork9.Controllers
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
            var list = new List<StudentsView>();

            string server = "localhost";
            string database = "homework7";
            string login = "root";
            string pass = "root";
            string sqlConnect = "Database=" + database + ";Datasource=" + server + ";user=" + login + ";Password=" + pass;
            MySqlConnection connect = new MySqlConnection(sqlConnect);
            connect.Open();
            string sql = "select * from students";
            MySqlCommand query = new MySqlCommand(sql, connect);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                StudentsView stud = new StudentsView();
                stud.Id = (int)reader["student_id"];
                stud.FIO = (string)reader["fio"];
                list.Add(stud);
            }

            reader.Close();
            connect.Close();
            return View(list);
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
    }
}
