using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositories
{

    public class GroupsRepository : IGroupsRepository
    {
        private readonly TaskManagerContext _context;

        public GroupsRepository(TaskManagerContext context)
        {
            _context = context;
        }

        public IQueryable<GroupsModel> GetAllGroups()
            => _context.Groups;

        public GroupsModel Get(int groupId)
        => _context.Groups.SingleOrDefault(x => x.GroupID == groupId);

        public void Add(GroupsModel groups)
        {
            _context.Groups.Add(groups);
            _context.SaveChanges();
        }

        public void AddToGroup(int taskId, int groupId)
        {
            var result = _context.Tasks.SingleOrDefault(x => x.TaskId == taskId);
            var getId = _context.Groups.SingleOrDefault(x => x.GroupID == groupId);
            if (result != null && getId != null)
            {
                result.GroupID = getId.GroupID;
                _context.SaveChanges();
            }
        }
        public void Delete(int groupsId)
        {
            var result = _context.Groups.SingleOrDefault(x => x.GroupID == groupsId);
            if (result != null)
            {
                _context.Groups.Remove(result);
                _context.SaveChanges();
            }
        }
        public void Update(int groupsId, GroupsModel groups)
        {
            var result = _context.Groups.SingleOrDefault(x => x.GroupID == groupsId);
            if (result != null)
            {
                result.NameOfGroup = groups.NameOfGroup;
                _context.SaveChanges();
            }
        }
    }
}
