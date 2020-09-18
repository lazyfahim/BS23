using BS.Data;
using BS.Membership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Membership.Repositories
{
    public interface IUserRepository : IRepository<User, int, MemberShipContext>
    {
        List<int> GetUserIdListOfProvidedRole(string roleNameNormalized);
    }
}
