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

builder.Services.AddDbContext<PlataformaContext>(op => op.UseSqlServer(connOptions));

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();
