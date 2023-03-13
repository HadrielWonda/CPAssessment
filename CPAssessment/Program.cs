using CPAssessment.Controllers;
using CPAssessment.Database;
using CPAssessment.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IApplicationFormDatabase, ApplicationFormDatabase>();
builder.Services.AddScoped<IApplicationFormService, ApplicationFormService>();

builder.Services.AddControllers();


var app = builder.Build();

///<summary>
/// Configure the HTTP request pipeline and additional middleware.
/// </summary>

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
