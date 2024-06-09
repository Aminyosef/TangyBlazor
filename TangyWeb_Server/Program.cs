using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Tangy_DataAccess.Data;
using TangyWeb_Server.Data;
using Tangy_Business.Mapper;
using Tangy_DataAccess;
using Tangy_Business.Repository.IRepository;
using Tangy_Business.Repository;
using TangyWeb_Server.Service.IService;
using Syncfusion.Blazor;


Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzMxNDU0NkAzMjM1MmUzMDJlMzBuc1VzU1ZRc25TWmdsRUhtek5hdXFieWxBZVRwa2N3NTJSekJtZWp2Uk84PQ==;MzMxNDU0N0AzMjM1MmUzMDJlMzBDQ2Z0aWI2M01Cc3lkRzUrN3dFVmt2M3FzZWZDZlJaZXRUanlGUlErYXE0PQ==");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddDbContext<ApplicationDbContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IProductPriceRepository,ProductRepository>();
builder.Services.AddScoped<IFileUpload, FileUpload>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
