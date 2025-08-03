using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //middle ware
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<Catagory> catagories = new List<Catagory>();

app.MapGet("/", () => "Api is working fine.");

//Create => Create a Catagory => POST : /api/catagories
app.MapPost("/api/catagories", ([FromBody] Catagory catagorydata) =>
{
    var newCatagory = new Catagory
    {
        CatagoryId = Guid.NewGuid(),
        Name = catagorydata.Name,
        Description = catagorydata.Description,
        CreatedAt = DateTime.UtcNow,
    };
    catagories.Add(newCatagory);
    return Results.Created($"/api/catagories/{newCatagory.CatagoryId}", catagories);
});

//Read => Read a Catagory => GET :/api/catagories
app.MapGet("/api/catagories", () =>
{
    return Results.Ok(catagories);
});

//Delete => Delete a Catagory => Delete : /api/catagories
app.MapDelete("/api/catagories/{catagoryID}", (Guid catagoryID) =>
{
    var foundCatagory = catagories.FirstOrDefault(catagory => catagory.CatagoryId == catagoryID);
    if (foundCatagory == null)
    {
        return Results.NotFound("Catagory with this id does not exist.");
    }

    catagories.Remove(foundCatagory);
    return Results.Ok("Deleted Successfully!"); // <-- Return added here
});


app.MapPut("/api/catagories/{catagoryID}", (Guid catagoryID, [FromBody] Catagory catagoryData) =>
{
    var foundCatagory = catagories.FirstOrDefault(catagory => catagory.CatagoryId == catagoryID);
    if (foundCatagory == null)
    {
        return Results.NotFound("Catagory with this id does not exist.");
    }

    foundCatagory.Name = catagoryData.Name;
    foundCatagory.Description = catagoryData.Description;
    return Results.Ok("Catagory updated successfully."); 
});


app.Run();

public record Catagory
{
    public Guid CatagoryId {  get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }

}

//CRUD
//Create => Create a Catagory => POST : /api/catagories
//Read => Read a Catagory => GET : /api/catagories
//Update => Update a Catagory => PUT : /api/catagories
//Delete => Delete a Catagory => Delete : /api/catagories









