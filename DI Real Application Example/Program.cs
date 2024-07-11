using DI_Real_Application_Example.DI_Service;
using DI_Real_Application_Example.Service;
using DI_Real_Application_Example.StudentServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Register services with DI container
builder.Services.AddScoped<IDIEmailService, DIEmailService>();
// If you need Science students, pass the ScienceStudents class object.
// This registers ScienceStudents as the implementation of IStudents.
builder.Services.AddScoped<IStudents, MathStudents>();

// If you need Math students, uncomment the following line and comment the above line.
// builder.Services.AddScoped<IStudents, ScienceStudents>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
