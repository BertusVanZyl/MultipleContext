using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace TwoContexts.TEST
{
    public interface ITESTAppservice : IApplicationService
    {
        string Test();
    }
}
