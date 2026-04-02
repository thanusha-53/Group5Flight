using Group5Flight.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

// Configure DbContext
builder.Services.AddDbContext<AirBnBContext>(options =>
    options.UseSqlite("Data Source=Group5Flights.db")); // or UseSqlServer if you have SQL Server

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AirBnBContext>();

    // Check if Flights table is empty
    if (!context.Flights.Any())
    {
        // Add a sample airline
        var airline = new Airline
        {
            Name = "Delta",
            ImageName = "delta.png"
        };

        context.Airlines.Add(airline);
        context.SaveChanges(); // Save to generate Airline.Id

        // Add sample flights
        context.Flights.AddRange(
            new Flight
            {
                From = "Chicago",
                To = "New York",
                Date = DateTime.Today.AddDays(1),
                DepartureTime = DateTime.Today.AddDays(1).AddHours(10),
                ArrivalTime = DateTime.Today.AddDays(1).AddHours(13),
                CabinType = "Economy",
                Price = 200,
                Emission = "Low",
                AirlineId = airline.Id
            },
            new Flight
            {
                From = "Chicago",
                To = "Dallas",
                Date = DateTime.Today.AddDays(1),
                DepartureTime = DateTime.Today.AddDays(1).AddHours(10),
                ArrivalTime = DateTime.Today.AddDays(1).AddHours(13),
                CabinType = "Business",
                Price = 400,
                Emission = "Medium",
                AirlineId = airline.Id
            }
        );

        context.SaveChanges(); // Save flights
    }
}

// Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // session middleware goes here
app.UseAuthorization();

// Map routes
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();