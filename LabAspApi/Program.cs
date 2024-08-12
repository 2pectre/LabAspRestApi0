using System.Data;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddCors(options =>
// {
//     options.AddDefaultPolicy(builder =>
//     {
//         builder.WithOrigins("http://localhost:8080")
//                .AllowAnyHeader()
//                .AllowAnyMethod();
//     });
// });

builder.Services.AddControllers();
builder.Services.AddScoped<IDbConnection>(sp => new SqlConnection(
    builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}

//app.UseCors();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
