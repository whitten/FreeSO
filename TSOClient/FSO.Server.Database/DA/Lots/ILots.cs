﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Database.DA.Lots
{
    public interface ILots
    {
        IEnumerable<DbLot> All(int shard_id);
        DbLot GetByLocation(int shard_id, uint location);
        DbLot GetByOwner(uint owner_id);
        DbLot Get(int id);
        uint Create(DbLot lot);

        void RenameLot(int id, string newName);

        List<DbLot> SearchExact(int shard_id, string name, int limit);
        List<DbLot> SearchWildcard(int shard_id, string name, int limit);
        
        void CreateLotServerTicket(DbLotServerTicket ticket);
        void DeleteLotServerTicket(string id);
        DbLotServerTicket GetLotServerTicket(string id);
    }
}