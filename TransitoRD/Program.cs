using TransitoRD.Core.Application;
using TransitoRD.Extensions;
using TransitoRD.Infrastucture.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddPersistenceInfrastructure(builder.Configuration);
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddPolitica();
builder.Services.AddSwaggerExtension();
builder.Services.AddApiVersioningExtension();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
