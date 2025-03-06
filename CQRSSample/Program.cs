using MediatR;
using Microsoft.EntityFrameworkCore;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Reflection;
using CQRSSample;
using CQRSSample.Repository;
using Microsoft.OpenApi.Models;
using CQRSSample.Models;

var builder = WebApplication.CreateBuilder(args);

// Ocelot configuration
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory());
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CQRSSample API", Version = "v1" });
});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
builder.Services.AddOcelot();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("SampleDb"));

// Register the IRepository and its implementation
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
builder.Services.AddScoped<IRepository<Organization>, OrganizationRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();

var app = builder.Build();

// Middleware configuration
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CQRSSample API v1");
        c.RoutePrefix = string.Empty;
        var url = "http://localhost:5000";
        Task.Run(() => OpenBrowser(url));
    });
}

app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

await app.UseOcelot();
await app.RunAsync();

static void OpenBrowser(string url)
{
    try
    {
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
    }
    catch { }
}