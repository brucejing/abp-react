﻿using Abp.MultiTenancy;
using Abp.React.Authorization.Users;

namespace Abp.React.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
