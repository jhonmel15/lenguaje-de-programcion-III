var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/", () =>
{

    return "hola esta es mi primera api";
});


    app.MapGet("/jhom-mel-berroa", () =>
    {
        return new
        {
            nombre = "Jhom Mel",
            apellido = "Berroa Ramirez",
            edad = 21,
            matricula = "LR-2024-00206",
            carrera = "Ingenieria de software",
            ciudad = "San pedro de macoris",
            pais = "Republica Dominicana"
        };
    });

app.Run();