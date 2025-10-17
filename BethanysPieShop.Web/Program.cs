using BethanysPieShop.Web.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();
var app = builder.Build();

//Midlleware
app.UseStaticFiles(); //als request binnenkomt en met file binnenkomt controle dat er zo een file is in de www

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //http request aanpakken en doorgeven aan de volgende maar try catch erond zetten als exception er is html pagina response geven
}

app.MapDefaultControllerRoute(); //standaard voor mvc 

app.Run();
