namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


     //       app.MapControllerRoute(
     //name: "r1",
     //pattern: "x/y/{id?}");
     //       //localhost:1234/x/y


     //       app.MapControllerRoute(
     //name: "r2",
     //pattern: "a/b/{id?}");
     //       //localhost:1234/a/b

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");
            //pattern: "{controller=Default}/{action=Index}/{id?}/{a?}/{b?}/{c?}");

            //localhost:1234/Default/Index/1
            //localhost:1234/Default/Index/1?a=100&b=200&c=300
            //localhost:1234/Default/Index/1?c=300
            //localhost:1234/Default/Index/1?b=200
            //localhost:1234/Default/Index/1?a=100&c=300
            //localhost:1234/Default/Index/1?&c=300&a=100


            app.Run();
        }
    }
}
