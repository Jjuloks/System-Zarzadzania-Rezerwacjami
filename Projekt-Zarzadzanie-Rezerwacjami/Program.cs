using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projekt_Zarzadzanie_Rezerwacjami.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Projekt_Zarzadzanie_RezerwacjamiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Projekt_Zarzadzanie_RezerwacjamiContext") ?? throw new InvalidOperationException("Connection string 'Projekt_Zarzadzanie_RezerwacjamiContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Apply EF migrations at startup (requires that migrations exist).
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Projekt_Zarzadzanie_RezerwacjamiContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
