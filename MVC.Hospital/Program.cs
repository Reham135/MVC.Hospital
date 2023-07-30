using Microsoft.EntityFrameworkCore;
using Hospital.DAL;
using Hospital.BL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment()) { 
    var connectionString= builder.Configuration.GetConnectionString("Hospital_Connection_String");
    builder.Services.AddDbContext<HospitalContext>(options =>
options.UseSqlServer(connectionString));
}
builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();  
builder.Services.AddScoped<IPatientsRepo, PatientsRepo>();  
builder.Services.AddScoped<IIssuesRepo, IssuesRepo>();  
builder.Services.AddScoped<IDoctorsManager, DoctorsManager>();
builder.Services.AddScoped<IPatientManager, PatientManager>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();   
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




 
