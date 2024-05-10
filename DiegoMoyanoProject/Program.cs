using AutoMapper;
using DiegoMoyanoProject.Mapper;
using DiegoMoyanoProject.Repository;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
CultureInfo.CurrentCulture = new CultureInfo("es-ES");
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(1200);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MapperProfile());
}).CreateMapper());
var CadenaDeConexion = "Data Source=DB/data.db;Cache=Shared";
builder.Configuration.GetConnectionString("SqliteConexion")!.ToString();
builder.Services.AddSingleton<string>(CadenaDeConexion);
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserDataRepository, UserDataRepository>();
builder.Services.AddScoped<IUserPdfRepository, UserPdfRepository>();
builder.Services.AddScoped<IEmailSender, EmailSender>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
