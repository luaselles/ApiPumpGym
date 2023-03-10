using Pump.Api.Middlewares;
using Pump.Apllication;
using Pump.Infra.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conection = builder.Configuration.GetConnectionString("MysqlConnection");
builder.Services.AddInfraData(conection);
builder.Services.AddAplication();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<ExceptionHandlingMiddleware>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
