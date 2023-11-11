using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITelefoneService, TelefoneService>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();
builder.Services.AddScoped<ICursoService, CursoService>();

var connOptions = builder.Configuration.GetConnectionString("connection"); 

builder.Services.AddDbContext<PlataformaContext>(op => op.UseOracle(connOptions));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

app.Run();
