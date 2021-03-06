using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace helloentity
{
    public class UserPermission : BaseEntity
    {
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? PermissionId { get; set; }
        public virtual Permission Permission { get; set;}
    }
}