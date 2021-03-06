using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace helloentity
{
    public class Permission : BaseEntity
    {
        public string ObjectName { get; set; }
        public string Action { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }

    }
}