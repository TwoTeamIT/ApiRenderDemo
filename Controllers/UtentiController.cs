using ApiRenderDemo.Entity;
using ApiRenderDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace ApiRenderDemo.Controllers
{

    //[ApiController]
    //[Route("api/[controller]")]
    //[SwaggerTag("Gruppo Utenti")]
    public static class UtentiController
    {

        public static void MapUserEndPoint(this IEndpointRouteBuilder app, IConfiguration configuration)
        {
            var groupUsers = app.MapGroup("/user").WithTags("Users");

            groupUsers.MapGet("/",()
                    => GetAll()
            ).WithName("GetAllUsers");

            groupUsers.MapGet("/byflag", ([FromQuery] bool enabled = false)
                    =>
            {
                return enabled ? GetAbilitati() : GetAll();
            }
            ).WithName("GetByFlag");

            groupUsers.MapGet("/active",()
                    => GetAbilitati()
            ).WithName("GetAbilitati");

            groupUsers.MapGet("/{id}", ([FromRoute] int id)
                    => GetById(id)
            ).WithName("GetById");

            groupUsers.MapPost("/",
                ([FromBody][Required] UserModel uModel)
                    => SaveOrUpdateUser(uModel)
            )
                .WithName("SaveOrUpdateSponsor");
        }

        /// <summary>
        /// Restituisce tutti gli utenti mock.
        /// </summary>

        private static IResult GetAll()
        {
            var utenti = UserEntity.GetMockUtenti();
            return Results.Ok(utenti);
        }

        /// <summary>
        /// Restituisce solo gli utenti abilitati.
        /// </summary>

        private static IResult GetAbilitati()
        {
            var utenti = UserEntity.GetMockUtenti().Where(u => u.Abilitato).ToList();
            return Results.Ok(utenti);
        }

        /// <summary>
        /// Restituisce un singolo utente per ID.
        /// </summary>

        private static IResult GetById(int id)
        {
            var utente = UserEntity.GetMockUtenti().FirstOrDefault(u => u.Id == id);
            if (utente == null)
                return Results.NotFound();
            return Results.Ok(utente);
        }

        private static IResult SaveOrUpdateUser(UserModel uModel)
        {
            return Results.Ok("Utente salvato con successo.");
        }
    }
}
