using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication.Enties
{
    [Table("Accounts")]
    public class Account
    {
        [Column("id")]
        public string Id { get; set; }

        [Column("user_id")]
        public string UserId { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

    }


}