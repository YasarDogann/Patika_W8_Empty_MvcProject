namespace patika_w8_mvcExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting(); // Uygulamanýn URL isteklerini yönlendirmek için routing mekanýzmasýný etkinleþtiri.

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();


            /**
             * CONTROLLER : Kullanýcýdan gelen isteklere yanýt veren sýnýfrýtr. Homecontroller'dan bir istek geldiðinde doðru view'i döner.
             * ACTÝON : Controller sýnýflarý içindeki methodlardýr.
             * MODEL : Veriyi temsil eder ve iþ mantýðýný taþýr.Örneðin, ExampleModel sýnýfý veritabanýndaki bir tablonun yapýsýný ifade eder
             * VÝEW : Kullanýcýya göterilecek olan HTML sayfasýdýr. Razor kullanýlarak dinamik içerik oluþturulur
             * RAZOR : View dosyalarýna dinamik içerik oluþturmak için kullanýlan þablondur.
             * WWWROOT : uygulamanýn statik dosyalarýnýn tutulduðu klasördür.
             * builder.Build() : Uygulama yapýlandýrmalarýný tamamlar ve çalýþtýrabilir bir uygulama nesnesi oluþturu
             * app.Run() : Uygulamayý baþlatýr ve gelen HTTP isteklerini dinler.
              
             */
        }
    }
}
