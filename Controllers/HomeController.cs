using Microsoft.AspNetCore.Mvc;
using StartupBBS.Data;
using StartupBBS.Models;
using System.Linq;

namespace StartupBBS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: コメント一覧の表示
        public IActionResult Index()
        {
            var comments = _context.Comments.ToList();  // コメント一覧を取得
            return View(comments);
        }

        // POST: コメントの投稿
        [HttpPost]
        public IActionResult PostComment(string userName, string content)
        {
            var comment = new Comment
            {
                UserName    = userName,
                Content     = content,
                PostedAt    = DateTime.Now
            };

            _context.Comments.Add(comment);  // コメントをDBに追加
            _context.SaveChanges();  // 変更を保存

            return RedirectToAction("Index");  // コメント投稿後にトップページへリダイレクト
        }
    }
}

