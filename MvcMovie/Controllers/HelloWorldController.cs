using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

//https://localhost:44379/HelloWorld

//ブラウザの要請を処理するクラス
namespace MvcMovie.Controllers
{
    //viewメソッドを呼ぶ
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View(); //ブラウザに表示される
        }

        //get: https://localhost:44379/HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //viewData:viewに送るデータを持っている
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;　//反復する回数

            return View();
        }
    }
}