var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.Run(async (context) =>
{
    context.Response.ContentType = "text/html ; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/index.html");
});

//app.UseStaticFiles();

app.Run();
