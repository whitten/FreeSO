﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Database.DA.Bans
{
    public interface IBans
    {
        DbBan GetByIP(string ip);
    }
}