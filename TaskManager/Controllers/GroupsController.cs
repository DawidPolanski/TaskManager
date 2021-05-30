using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskManager.Models;
using TaskManager.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TaskManager.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupsController(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }
        // GET: GroupsController

        public ActionResult Index()
        {
            return View();
        }

        // POST: GroupsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]


        // GET: GroupsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_groupsRepository.Get(id));
        }

        public ActionResult Create()
        {
            return View(new GroupsModel());
        }

        // POST: GroupsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GroupsModel groupsModel)
        {
            _groupsRepository.Update(id, groupsModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: GroupsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_groupsRepository.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GroupsModel groupsModel)
        {
            _groupsRepository.Add(groupsModel);
            return RedirectToAction(nameof(Index));
        }

        // POST: GroupsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, GroupsModel groupsModel)
        {
            _groupsRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
