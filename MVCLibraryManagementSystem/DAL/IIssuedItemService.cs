﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCLibraryManagementSystem.Models;

namespace MVCLibraryManagementSystem.DAL
{
    public interface IIssuedItemService 
    {
        List<IssuedItem> GetAllIssuedItems();
        void Add(IssuedItem i);
        void Update(IssuedItem i);
        void Delete(int id);
        IssuedItem GetById(int? id);

        /// <summary>
        /// Get all Acc. Record instance available for issue, i.e those that have been returned, are not 
        /// reserved and have never been checked out.
        /// </summary>
        /// <returns>Acc. Records that aren't in the IssuedItems list</returns>
        IEnumerable<AccessionRecord> GetAllIssuableAccRecords();

        /// <summary>
        /// Returns a random Accession Record that can be issued to a member.
        /// </summary>
        /// <param name="itemid">Item ID of the Item you want to return an Accession Record for</param>
        /// <returns></returns>
        AccessionRecord GetRandomIssuableAccRecord(int itemid);
    }
}
