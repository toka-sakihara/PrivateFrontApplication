using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Systemsnow.Study.DummyAPI.Data;
using Systemsnow.Study.DummyAPI.Dto;

namespace Systemsnow.Study.DummyAPI.Controllers
{
    /// <summary>
    /// アカウント検索API
    /// </summary>
    [ApiController]
    [Route("account")]
    public class AccountSearchController : ControllerBase
    {
        private readonly AccountSqliteDbContext AccountSqliteDbContext;
        public AccountSearchController(AccountSqliteDbContext dbcontext)
        {
            this.AccountSqliteDbContext = dbcontext;
        }
        [HttpGet("{userId}")]
        public IActionResult searchAccountDataRequest(string userId)
        {
            var accountData = AccountSqliteDbContext.Account.Where(account => account.UserId == userId).FirstOrDefault() ?? null;
            if (accountData == null) { return NotFound(); }

            AccountSearchResponseDto responseDto = new AccountSearchResponseDto(accountData);
            return Ok(responseDto);
        }
    }
}
