using VlearnBackend2.Contexts;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITelefoneService, TelefoneService>();
builder.Services.AddSingleton<IAlunoService, AlunoService>();
builder.Services.AddSingleton<ILoginService, LoginService>();
builder.Services.AddSingleton<IProfessorService, ProfessorService>();
builder.Services.AddSingleton<ICursoService, CursoService>();

builder.Services.AddDbContext<PlataformaContext>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();
