using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace helloentity
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}