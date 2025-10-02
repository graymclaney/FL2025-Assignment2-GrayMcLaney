using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "base.html" }
});
app.UseStaticFiles();


// Serve everything in wwwroot (e.g., /base.html, /styles.css, images, JS)
app.UseStaticFiles();

// (Optional) keep a quick health endpoint
app.MapGet("/ping", () => "pong");

app.Run();
