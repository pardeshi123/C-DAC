namespace WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();



            var app = builder.Build();


            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=demo}/{action=index}/{Id?}"

                );

            app.MapControllerRoute(
                name: "Admin",
                pattern: "{controller=Admin}/{action= index}/{username?}"
                );

            app.MapControllerRoute(
                name: "Home",
                pattern: "{controller=Home}/{action= index}/{password?}"


                );

           

            app.Run();
        }
    }
}
