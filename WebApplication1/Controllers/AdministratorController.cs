using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken()]
        [HttpPost]
        public ActionResult Login(Models.LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                var _admin = _adminService.Find(a => a.Account == loginVM.Account);
                if (_admin == null) ModelState.AddModelError("Account", "账号不存在");
                else if (Encryption.Sha256(loginVM.Password) != _admin.Password) ModelState.AddModelError("Password", "密码不正确");
                else
                {
                    _admin.LoginTime = System.DateTime.Now;
                    _admin.LoginIp = Request.UserHostAddress;
                    _adminService.Update(_admin);
                    Session.Add("Account", loginVM.Account);
                    Session.Add("Password", _admin.Password);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(loginVM);
        }
    }
}