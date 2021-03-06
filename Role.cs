using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace helloentity
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}