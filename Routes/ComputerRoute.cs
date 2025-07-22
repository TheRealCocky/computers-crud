using Microsoft.EntityFrameworkCore;

namespace Computer.Routes;
using Computer.Models;
using Microsoft.AspNetCore.Mvc;
using Computer.Data;
public static class ComputerRoute
{
    public static void ComputerRoutes(this WebApplication app)
    {
        var routes = app.MapGroup("computer");

        routes.MapPost("",
           async ([FromBody] ComputerModelDto dto, ComputerContext db) =>
            {
                var machine = new ComputerModel
                {
                    Name = dto.Name,
                    Model = dto.Model,
                    OS = dto.OS,
                    Processor = dto.Processor,
                    RAM = dto.RAM,
                    Storage = dto.Storage,
                    Graphics = dto.Graphics,
                    Display = dto.Display,
                    Audio = dto.Audio,
                    Wireless = dto.Wireless,
                    Battery = dto.Battery,
                    Weight = dto.Weight
                };
                db.Computers.Add(machine);
                await db.SaveChangesAsync();
                

                // Apenas retorna o objeto criado como JSON
                return Results.Ok(machine);
            });
        
        routes.MapGet("",
           async (ComputerContext db) =>
            {
               var computadores= await db.Computers.ToListAsync();
               return Results.Ok(computadores);

            });

        routes.MapPut("{Id}",
            async (Guid Id,ComputerContext db, ComputerModelDto dto) =>
            {
                var computador = await db.Computers.FindAsync(Id);
                if (computador == null)
                {
                    return Results.NotFound();
                }
                computador.Name = dto.Name;
                computador.Model = dto.Model;
                computador.OS = dto.OS;
                computador.Processor = dto.Processor;
                computador.RAM = dto.RAM;
                computador.Storage = dto.Storage;
                computador.Graphics = dto.Graphics;
                computador.Display = dto.Display;
                computador.Audio = dto.Audio;
                computador.Wireless = dto.Wireless;
                computador.Battery = dto.Battery;
                computador.Weight = dto.Weight;
                await db.SaveChangesAsync();
                return Results.Ok(computador);
            });

        routes.MapDelete("{Id}",
           async (Guid Id, ComputerContext db) =>
            {
                var computador = await db.Computers.FindAsync(Id);
                if (computador == null)
                {
                    return Results.NotFound();
                }
                db.Computers.Remove(computador);
                await db.SaveChangesAsync();
                return Results.Ok();
            });

    }
}