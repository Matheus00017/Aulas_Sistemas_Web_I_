using Microsoft.Data.Sqlite;
using SQLitePCL;

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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

    string conexao = @"Data Source = teste.db";
    using var cone = new SqliteConnection(conexao);
    cone.Open();

    string sql = @"create table if not exists usuario (

        id integer primary key autoincrement,
        usuarios text unique,
        senha text,
        nome text
    )";
    using var frajola = new SqliteCommand(sql, cone); 

    frajola.ExecuteNonQuery();

















app.Run();
