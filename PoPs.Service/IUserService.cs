﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PoPs.Domain;

namespace PoPs.Service
{
    public interface IUserService
    {
        User GetUserById(int id);
    }
}
