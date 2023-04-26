using BBEngineGRPC.Services;
using Microsoft.OpenApi.Models;
using BBEngineGRPC.Config;
using Microsoft.EntityFrameworkCore;
using BBEngineGRPC.Repositories.Interfaces;
using BBEngineGRPC.Repositories.Mysql;
using BBEngineGRPC.Usecase.Interfaces;
using BBEngineGRPC.Usecase;
using BBEngineGRPC.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Dependencies
builder.Services.AddGrpc();
builder.Services.AddGrpc().AddJsonTranscoding();
builder.Services.AddGrpcSwagger();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo{ Title = "gRPC Transcoding", Version = "v1" });
});
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = builder.Configuration.GetConnectionString("RedisCacheUrl"); });
//builder.Services.AddScoped<ICacheService, CacheService>();

//interface DB
builder.Services.AddScoped<IProducts, ProductDb>();

//interface Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

//interface UseCase
builder.Services.AddScoped<IProductUsecase, ProductUsecase>();

var app = builder.Build();

// Mapping gRPC Service
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ProductService>();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodStore API");
});

// Configure the HTTP request pipeline.
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
app.Run();
