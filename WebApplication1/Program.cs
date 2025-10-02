var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

// Serve files from wwwroot
app.UseStaticFiles();

// Optional: if you want hitting "/" to load a default file automatically.
// app.UseDefaultFiles(); // looks for index.html, default.html, etc.

app.Run();
