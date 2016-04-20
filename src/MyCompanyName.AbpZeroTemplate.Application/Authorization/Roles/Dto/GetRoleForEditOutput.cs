using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Taskever.Authorization.Dto;

namespace Taskever.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput : IOutputDto
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}