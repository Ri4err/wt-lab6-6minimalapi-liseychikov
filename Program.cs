using wt_lab6_6minimalapi_liseychikov.Data;
using wt_lab6_6minimalapi_liseychikov.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () => "Minimal API работает");

app.MapGet("/api/info", ()=>
{
    return new
    {
        Application = "Web Technologies",
        Technology = "ASP .NET Core Minimal API",
        Version = "1.0"
    };
});

app.MapGet("/api/tasks/{id}", (int id)=>
{
    var task = TaskList.Tasks.FirstOrDefault(x => x.Id == id);

    if (task == null)
        return Results.NotFound();
    return Results.Ok(task);
});

app.MapGet("/api/tasks", (string? search) =>
{
    var tasks = TaskList.Tasks.AsEnumerable();

    if (!string.IsNullOrWhiteSpace(search))
    {
        tasks = tasks.Where(x => x.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
    }

    return Results.Ok(tasks);
});

app.MapPost("/api/tasks", (TaskModel task) =>
{
    var newId = TaskList.Tasks.Count == 0 
        ? 1 
        : TaskList.Tasks.Max(x => x.Id) + 1;

    task.Id = newId;
    TaskList.Tasks.Add(task);
    return Results.Created($"/api/tasks/{task.Id}", task);
});

app.MapPut("/api/tasks/{id}", (int id, TaskModel updatedTask)=>
{
    var task = TaskList.Tasks.FirstOrDefault(x => x.Id == id);
    if (task == null)
    {
        return Results.NotFound();
    }
    task.Name = updatedTask.Name;
    task.Category = updatedTask.Category;
    task.Price = updatedTask.Price;
    task.IsAvaliable = updatedTask.IsAvaliable;

    return Results.Ok(task);
});

app.MapDelete("/api/tasks/{id}", (int id)=>
{
    var task = TaskList.Tasks.FirstOrDefault(x => x.Id == id);

    if (task == null)
        return Results.NotFound();

    TaskList.Tasks.Remove(task);

    return Results.NoContent();
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Run($"http://0.0.0.0:{port}");