using Microsoft.EntityFrameworkCore;
using MusicWebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurar el DbContext con la cadena de conexión
builder.Services.AddDbContext<MusicContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MusicWebAppConnection")));

// Agregar servicios al contenedor
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar la canalización de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
