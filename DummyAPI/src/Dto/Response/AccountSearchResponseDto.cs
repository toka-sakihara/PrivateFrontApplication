using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Systemsnow.Study.DummyAPI.Entity;

namespace Systemsnow.Study.DummyAPI.Dto
{
    public class AccountSearchResponseDto
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="accountEntity"></param>
        public AccountSearchResponseDto(AccountEntity accountEntity)
        {
            this.Id = accountEntity.Id;
            this.UserId = accountEntity.UserId;
            this.FirstName = accountEntity.FirstName;
            this.LastName = accountEntity.LastName;
            this.LastUpdate = accountEntity.LastUpdate;
            this.Hobby = accountEntity.Hobby.Split(',').ToList();
        }

        /// <summary>
        /// ID
        /// </summary>
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        /// <summary>
        /// ユーザーID
        /// </summary>
        [JsonPropertyName("user_id")]

        public string UserId { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 苗字
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        [JsonPropertyName("last_update")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// ユーザーの趣味
        /// </summary>
        [JsonPropertyName("hobby")]
        public IList<string> Hobby { get; set; }
    }

    public class AccountAllSearchResponseDto
    {
        [JsonPropertyName("accounts")]
        public List<AccountSearchResponseDto> Accounts { get; set; }
    }
}
