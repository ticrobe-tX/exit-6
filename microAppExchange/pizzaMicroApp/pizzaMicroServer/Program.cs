using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("somePolicy", builder =>
    {
        builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("somePolicy");

app.MapGet("/menuForTheDayAsync", async () =>
{
    try
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();

        var stringTask = client.GetStringAsync("http://localhost:30000/api/pizzas");
        return Results.Ok(JsonSerializer.Deserialize<Object>(await stringTask));
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message, null, StatusCodes.Status500InternalServerError);
    }
});

app.Run();
