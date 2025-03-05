using e.commerce.engineering.crosscutting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDependencies();

builder.Services.AddControllers();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
