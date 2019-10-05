namespace DemoLabWindowsForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DemoLabWindowsForm.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoLabWindowsForm.Entities.DatVeOnlineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoLabWindowsForm.Entities.DatVeOnlineContext context)
        {
            context.HangGhes.AddOrUpdate(x => x.HangGheId,
                new HangGhe() {HangGheId = 1, TenHangGhe = "Hàng Đầu", GiaVe = 50000 },
                new HangGhe() {HangGheId = 2, TenHangGhe = "Hàng Hai", GiaVe = 70000 },
                new HangGhe() {HangGheId = 3, TenHangGhe = "Hàng Ba", GiaVe = 100000 }
            );
            context.Ghes.AddOrUpdate(x => x.GheId,
                new Ghe() { HangGheId = 1, TenGhe = "1" },
                new Ghe() { HangGheId = 1, TenGhe = "2" },
                new Ghe() { HangGheId = 1, TenGhe = "3" },
                new Ghe() { HangGheId = 1, TenGhe = "4" },
                new Ghe() { HangGheId = 1, TenGhe = "5" },
                new Ghe() { HangGheId = 2, TenGhe = "6" },
                new Ghe() { HangGheId = 2, TenGhe = "7" },
                new Ghe() { HangGheId = 2, TenGhe = "8" },
                new Ghe() { HangGheId = 2, TenGhe = "9" },
                new Ghe() { HangGheId = 2, TenGhe = "10" },
                new Ghe() { HangGheId = 3, TenGhe = "11" },
                new Ghe() { HangGheId = 3, TenGhe = "12" },
                new Ghe() { HangGheId = 3, TenGhe = "13" },
                new Ghe() { HangGheId = 3, TenGhe = "14" },
                new Ghe() { HangGheId = 3, TenGhe = "15" }
            );
            context.SaveChanges();
        }
    }
}
