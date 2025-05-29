var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Despesa> despesas = new();

app.MapGet("/", () => "Hello World!");

app.MapGet("/despesas", () => despesas);

app.MapPost("/despesas", (Despesa novaDespesa) =>
{
    novaDespesa.Id = despesas.Count + 1;
    despesas.Add(novaDespesa);
    return Results.Created($"/despesas/{novaDespesa.Id}", novaDespesa);
});

// app.MapPut("/despesas/{id}", (int id, Despesa despesaAtualizada) =>
// {

// });

app.MapDelete("/despesas/{id}", (int id) =>
{
    var despesa = despesas.FirstOrDefault(d => d.Id == id);
    if (despesa is null) return Results.NotFound();

    despesas.Remove(despesa);
    return Results.NoContent();
});


app.Run();

record Despesa
{
    public int Id { get; set; }
    public string Descricao { get; set; } = "";
    public decimal Valor { get; set; }
    public bool Fixa { get; set; }
    public DateTime Data { get; set; }

}