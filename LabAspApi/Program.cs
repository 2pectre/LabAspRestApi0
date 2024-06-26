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
