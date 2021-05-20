using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Systemsnow.Study.DummyAPI.Data;
using Systemsnow.Study.DummyAPI.Dto;
using Systemsnow.Study.DummyAPI.Entity;

namespace Systemsnow.Study.DummyAPI.Controllers
{
    /// <summary>
    /// アカウント作成API
    /// </summary>
    [ApiController]
    [Route("account")]
    public class AccountCreateController : ControllerBase
    {
        private readonly AccountSqliteDbContext AccountSqliteDbContext;
        public AccountCreateController(AccountSqliteDbContext dbcontext)
        {
            this.AccountSqliteDbContext = dbcontext;
        }
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult createAccountRequest([FromBody] AccountCreateRequestDto requestBody)
        {
            if (!TryValidateModel(requestBody))
            {
                return BadRequest(ModelState.SelectMany(model =>
                model.Value.Errors.Select(error => error.ErrorMessage)).ToList());
            }

            AccountEntity accountEntity = new AccountEntity()
            {
                UserId = requestBody.UserId,
                FirstName = requestBody.FirstName,
                LastName = requestBody.LastName,
                LastUpdate = DateTime.UtcNow,
                Hobby = string.Join(',', requestBody.Hobby)
            };
            AccountSqliteDbContext.Add(accountEntity);
            AccountSqliteDbContext.SaveChanges();
            return Created($"{Request.Path}/{requestBody.UserId}", null);
        }
    }
}
