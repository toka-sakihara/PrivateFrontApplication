using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Systemsnow.Study.DummyAPI.Data;
using Systemsnow.Study.DummyAPI.Dto;
using Systemsnow.Study.DummyAPI.Entity;
namespace Systemsnow.Study.DummyAPI.Controllers
{
    /// <summary>
    /// アカウント全取得API
    /// </summary>
    [ApiController]
    [Route("account")]
    [Produces("application/json")]
    public class AccountAllSearchController : ControllerBase
    {
        private readonly AccountSqliteDbContext AccountSqliteDbContext;
        public AccountAllSearchController(AccountSqliteDbContext dbcontext)
        {
            this.AccountSqliteDbContext = dbcontext;
        }

        [HttpGet]
        public IActionResult searchAllAccountDataRequest()
        {
            var accountDataList = AccountSqliteDbContext.Account;
            List<AccountSearchResponseDto> accountList = new List<AccountSearchResponseDto>();
            foreach (AccountEntity account in accountDataList)
            {
                accountList.Add(new AccountSearchResponseDto(account));
            }
            AccountAllSearchResponseDto response = new AccountAllSearchResponseDto() { Accounts = accountList };
            return Ok(response);
        }
    }
}
