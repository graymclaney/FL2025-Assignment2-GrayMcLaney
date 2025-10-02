using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "base.html" }
});
app.UseStaticFiles();


app.UseStaticFiles();

// (Optional) keep a quick health endpoint
app.MapGet("/ping", () => "pong");

app.Run();
