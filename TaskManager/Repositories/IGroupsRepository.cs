using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface IGroupsRepository
    { 
        GroupsModel Get(int groupId);
        void Add(GroupsModel groups);
        void Update(int groupsId, GroupsModel groups);
        void Delete(int groupsId);
        IQueryable<GroupsModel> GetAllGroups();
    }
}
