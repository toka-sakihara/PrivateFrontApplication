using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Systemsnow.Study.DummyAPI.Dto
{
    public class AccountUpdateRequestDto
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        [MaxLength(16)]
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [MaxLength(16)]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 苗字
        /// </summary>
        [MaxLength(16)]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// ユーザーが興味を示したもの
        /// </summary>
        [JsonPropertyName("hobby")]
        public List<string> Hobby { get; set; }
    }
}
