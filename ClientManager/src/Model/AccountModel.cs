using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Systemsnow.Study.AccountManager.Data;
namespace Systemsnow.Study.AccountManager.Model
{
    public class AccountModel
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        [Required(ErrorMessage = "ユーザーIDは必須です。")]
        [MaxLength(16,ErrorMessage = "ユーザーIDは16文字以内で入力してください。")]
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [Required(ErrorMessage = "名前は必須です。")]
        [MaxLength(16, ErrorMessage = "名前は16文字以内で入力してください。")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 苗字
        /// </summary>
        [Required(ErrorMessage = "苗字は必須です。")]
        [JsonPropertyName("last_name")]
        [MaxLength(16, ErrorMessage = "苗字は16文字以内で入力してください。")]
        public string LastName { get; set; }

        /// <summary>
        /// ユーザーが興味を示したもの
        /// </summary>
        [JsonPropertyName("hobby")]
        public List<string> Hobby { get; set; }

        /// <summary>
        /// アカウントリストDto取得
        /// </summary>
        public AccountDto GetAccountDto()
        {
            return new AccountDto
            {
                UserId = this.UserId,
                FirstName= this.FirstName,
                LastName = this.LastName,
                Hobby = this.Hobby.ToArray()
            };
        }
    }
}
