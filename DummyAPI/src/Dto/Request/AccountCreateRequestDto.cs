using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Systemsnow.Study.DummyAPI.Dto
{
    public class AccountCreateRequestDto
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        [Required]
        [MinLength(1), MaxLength(16)]
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [Required]
        [MinLength(1), MaxLength(16)]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 苗字
        /// </summary>
        [Required]
        [JsonPropertyName("last_name")]
        [MinLength(1), MaxLength(16)]
        public string LastName { get; set; }

        /// <summary>
        /// ユーザーが興味を示したもの
        /// </summary>
        [JsonPropertyName("hobby")]
        public List<string> Hobby { get; set; }
    }
}
