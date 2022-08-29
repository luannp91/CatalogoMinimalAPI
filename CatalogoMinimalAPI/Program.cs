using CatalogoMinimalAPI.ApiEndpoints;
using CatalogoMinimalAPI.AppServicesExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddApiSwagger();
builder.AddPersistence();
builder.Services.AddCors();
builder.AddAuthenticationJwt();

var app = builder.Build();

//  Definindo os Endpoints

//  Endpoint para Login
app.MapAuthenticationEndpoints();

//  Endpoints Categorias
app.MapCategoryEndpoints();

//  Endpoints Produtos
app.MapProductsEndpoints();

//  Configure the HTTP request pipeline.
var environment = app.Environment;
app.UseExceptionHandling(environment).UseSwaggerMiddleware().UseAppCors();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.Run();