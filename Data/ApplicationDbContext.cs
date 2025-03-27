/*
using Microsoft.EntityFrameworkCore;
using StartupBBS.Models;

namespace StartupBBS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }  // Comment モデルをテーブルとして使用
    }
}



using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    // コンストラクタがデザイン時に使用される場合は、以下を追加
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=app.db"); // デザイン時の接続設定
        }
    }

    public DbSet<Comment> Comments { get; set; }
}
*/


using Microsoft.EntityFrameworkCore;
using StartupBBS.Models;


namespace StartupBBS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // デザイン時に使用する接続設定を追加
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db"); // SQLiteの接続設定（デザイン時）
            }
        }

        public DbSet<Comment> Comments { get; set; }
    }
}

