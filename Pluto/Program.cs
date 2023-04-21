using Pluto.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMineralService, MineralService>();
builder.Services.AddScoped<IRockService, RockService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();