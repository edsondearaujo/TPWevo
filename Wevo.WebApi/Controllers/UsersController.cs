using Wevo.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Wevo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(new List<User>()
            {
                new User
                {
                    Id = 1,
                    Nome = "Juarez",
                    Cpf = "514.956.817.13",
                    Email = "juarez@wevo.com",
                    Telefone = "61998569268",
                    Sexo = "Masculino",
                    DataNascimento = new DateTime(1995, 10, 18)
                }
            });
        }

        [HttpGet("{id}")]
        public string Get(int id) 
        {
            return "values";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
