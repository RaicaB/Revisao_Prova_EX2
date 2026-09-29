
var builder = WebApplication.CreateBuilder(args);

// Configuração da Injeção de Dependência
builder.Services.AddScoped<IProjetoRepository, ProjetoRepository>(); // Injeta repositório de projetos
builder.Services.AddScoped<IVisitaRepository, VisitaRepository>(); // Injeta repositório de visitas

builder.Services.AddControllers(); // Adiciona suporte a Controllers
var app = builder.Build();

app.MapControllers(); // Mapeia rotas dos controllers
app.Run(); // Executa aplicação
