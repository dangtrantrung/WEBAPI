using WEBAPI.EntitiesM;
using Microsoft.EntityFrameworkCore;
using System.Security.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyShopContext>(option =>
option.UseSqlServer (builder.Configuration.GetConnectionString("MyShop")));

/* builder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseKestrel(kestrelOptions =>
                {
                    kestrelOptions.ConfigureHttpsDefaults(httpsOptions =>
                    {
                        httpsOptions.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls13;
                    });
                });
            }); */

    builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ConfigureHttpsDefaults(listenOptions =>
    {
        // ...
         listenOptions.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls13;
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//dotnet ef dbcontext scaffold "Data Source=VPUB_NDTTRANG\SQLEXPRESS;Initial Catalog=MyShop;User ID=sa;Password=tr123" Microsoft.EntityFrameworkCore.SQLServer -o EntitiesM