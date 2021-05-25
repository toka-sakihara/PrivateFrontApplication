using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Systemsnow.Study.DummyAPI.Data;
using Systemsnow.Study.DummyAPI.Dto;
using Systemsnow.Study.DummyAPI.Entity;

namespace Systemsnow.Study.DummyAPI.Controllers
{
    /// <summary>
    /// アカウント更新API
    /// </summary>
    [ApiController]
    [Route("account")]
    public class AccountUpdateController : ControllerBase
    {
        private readonly AccountSqliteDbContext AccountSqliteDbContext;
        public AccountUpdateController(AccountSqliteDbContext dbcontext)
        {
            this.AccountSqliteDbContext = dbcontext;
        }
        [HttpPut("{userId}")]
        [Consumes("application/json")]
        public IActionResult createAccountRequest([FromBody] AccountUpdateRequestDto requestBody, string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) return BadRequest("UserId is Required");
            // 不要な可能性あり
            ModelState.Clear();
            if (!TryValidateModel(requestBody))
            {
                return BadRequest(ModelState.SelectMany(model =>
                model.Value.Errors.Select(error => error.ErrorMessage)).ToList());
            }

            AccountEntity accountEntity = AccountSqliteDbContext.Account.Where(account => account.UserId == userId).FirstOrDefault() ?? null;
            if (accountEntity == null) return NotFound();
            if (requestBody.UserId != null) accountEntity.UserId = requestBody.UserId;
            if (requestBody.FirstName != null) accountEntity.FirstName = requestBody.FirstName;
            if (requestBody.LastName != null) accountEntity.LastName = requestBody.LastName;
            accountEntity.LastUpdate = DateTime.UtcNow;
            if (requestBody.Hobby != null) accountEntity.Hobby = string.Join(',', requestBody.Hobby);
            AccountSqliteDbContext.SaveChanges();

            Response.Headers.Add("location", $"{Request.Path}/{accountEntity.UserId}");
            return NoContent();
        }
    }
}
