using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Systemsnow.Study.DummyAPI.Data;

namespace Systemsnow.Study.DummyAPI.Controllers
{
    /// <summary>
    /// アカウント作成API
    /// </summary>
    [ApiController]
    [Route("account")]
    public class AccountDeleteController : ControllerBase
    {
        private readonly AccountSqliteDbContext AccountSqliteDbContext;
        public AccountDeleteController(AccountSqliteDbContext dbcontext)
        {
            this.AccountSqliteDbContext = dbcontext;
        }
        [HttpDelete("{userId}")]
        public IActionResult deleteAccountDataRequest(string userId)
        {
            var accountData = AccountSqliteDbContext.Account.Where(account => account.UserId == userId).FirstOrDefault() ?? null;
            if (accountData == null) { return NotFound(); }
            AccountSqliteDbContext.Remove(accountData);
            AccountSqliteDbContext.SaveChanges();
            return NoContent();
        }
    }
}
