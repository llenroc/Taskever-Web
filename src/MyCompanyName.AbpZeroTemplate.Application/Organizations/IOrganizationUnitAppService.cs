﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Taskever.Organizations.Dto;

namespace Taskever.Organizations
{
    public interface IOrganizationUnitAppService : IApplicationService
    {
        Task<ListResultOutput<OrganizationUnitDto>> GetRootTree();

        Task<ListResultOutput<OrganizationUnitDto>> GetOUsIncludingChildren(long id);

        Task<ListResultOutput<OrganizationUnitDto>> GetOrganizationUnits();

        Task<PagedResultOutput<OrganizationUnitUserListDto>> GetOrganizationUnitUsers(GetOrganizationUnitUsersInput input);

        Task<OrganizationUnitDto> CreateOrganizationUnit(CreateOrganizationUnitInput input);

        Task<OrganizationUnitDto> UpdateOrganizationUnit(UpdateOrganizationUnitInput input);

        Task<OrganizationUnitDto> MoveOrganizationUnit(MoveOrganizationUnitInput input);

        Task DeleteOrganizationUnit(IdInput<long> input);

        Task AddUserToOrganizationUnit(UserToOrganizationUnitInput input);
        
        Task RemoveUserFromOrganizationUnit(UserToOrganizationUnitInput input);

        Task<bool> IsInOrganizationUnit(UserToOrganizationUnitInput input);
    }
}
