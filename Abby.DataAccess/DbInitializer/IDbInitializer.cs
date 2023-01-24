﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.DbInitializer
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}
