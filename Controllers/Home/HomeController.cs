using Microsoft.AspNetCore.Mvc;
using StudentAccount.Models;
using StudentAccount.Models.Home;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace StudentAccount.Controllers.Home
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string? _connectionString;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaulteConnection");
        }
        [HttpGet]
        public IActionResult Index()
        {
            //sqlとの接続
            using var con = new SqlConnection(_connectionString);

            //読み取り
            var sql = "select * from Lists";
            var commit = con.Query<Commoditys>(sql).ToList(); //タスクをリストとして取得する
            return View("Index", commit);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShouhinnAdd()
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
