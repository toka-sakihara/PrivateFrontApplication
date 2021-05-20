using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systemsnow.Study.DummyAPI.Entity
{
    public class AccountEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// ユーザーID
        /// </summary>
        [Column("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [Column("first_name", TypeName = "varchar(16)")]

        public string FirstName { get; set; }

        /// <summary>
        /// 苗字
        /// </summary>
        [Column("last_name", TypeName = "varchar(16)")]
        public string LastName { get; set; }

        /// <summary>
        /// アカウント更新日時
        /// </summary>
        [Column("registration_date", TypeName = "datetime2(7)")]

        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// ユーザーが興味を示したもの(カンマ区切り)
        /// </summary>
#nullable enable
        [Column("hobby", TypeName = "varchar(256)")]
        public string? Hobby { get; set; }
    }
}
