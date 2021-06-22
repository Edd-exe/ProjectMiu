using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MIUBlog.Business.Abstract;
using MIUBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIUBlog.WebUI.Controllers
{
    public class DetailsController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private IBlogService _blogService;
        private IProjectService _projectService;
        private IDiscussionService _discussionService;
        public DetailsController(UserManager<ApplicationUser> userManager, IBlogService blogService, IProjectService projectService, IDiscussionService discussionService)
        {
            _userManager = userManager;
            _projectService = projectService;
            _discussionService = discussionService;
            _blogService = blogService;
        }
        public async Task< IActionResult> Index( string name)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(name);
            List<Blog> blogs = _blogService.GetByUserId(user.Id);
            List<Discussion> discussions = _discussionService.GetByUserId(user.Id);
            List<Project> projects = _projectService.GetByUserId(user.Id);
            ViewBag.Blogs = blogs;
            ViewBag.Discussions = discussions;
            ViewBag.Projects = projects;

            return View();
        }
    }
}
