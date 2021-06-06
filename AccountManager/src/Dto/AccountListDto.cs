using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Systemsnow.Study.AccountManager.Data
{
    public class AccountListDto
    {
        [JsonPropertyName("accounts")]
        public List<AccountDto> AccountList { get; set; }
    }

    public class AccountDto
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// ユーザーID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 苗字
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// アカウント更新日時
        /// </summary>
        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// ユーザーが興味を示したもの(カンマ区切り)
        /// </summary>

        [JsonPropertyName("hobby")]
        #nullable enable
        public string[]? Hobby { get; set; }
    }
}
