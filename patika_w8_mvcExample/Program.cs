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

            app.UseRouting(); // Uygulaman�n URL isteklerini y�nlendirmek i�in routing mekan�zmas�n� etkinle�tiri.

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();


            /**
             * CONTROLLER : Kullan�c�dan gelen isteklere yan�t veren s�n�fr�tr. Homecontroller'dan bir istek geldi�inde do�ru view'i d�ner.
             * ACT�ON : Controller s�n�flar� i�indeki methodlard�r.
             * MODEL : Veriyi temsil eder ve i� mant���n� ta��r.�rne�in, ExampleModel s�n�f� veritaban�ndaki bir tablonun yap�s�n� ifade eder
             * V�EW : Kullan�c�ya g�terilecek olan HTML sayfas�d�r. Razor kullan�larak dinamik i�erik olu�turulur
             * RAZOR : View dosyalar�na dinamik i�erik olu�turmak i�in kullan�lan �ablondur.
             * WWWROOT : uygulaman�n statik dosyalar�n�n tutuldu�u klas�rd�r.
             * builder.Build() : Uygulama yap�land�rmalar�n� tamamlar ve �al��t�rabilir bir uygulama nesnesi olu�turu
             * app.Run() : Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinler.
              
             */
        }
    }
}
