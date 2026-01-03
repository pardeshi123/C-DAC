namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.Run();

            app.Use(async  (context,next ) =>{
                await context.Response.WriteAsync("Hello this is our first MVC .net project");
                next(context);
            });
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Hello Hugh Jackman!!");
                next(context);
                await context.Response.WriteAsync("\nHow do you do!!");
              
            });
            app.Run(async (context) => {
                await context.Response.WriteAsync("Hello Hugh Jackman!!");
                await context.Response.WriteAsync("\nHow are you!!");
              
            });
            app.Run();
        }
    }
}
