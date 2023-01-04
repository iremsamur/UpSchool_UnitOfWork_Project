using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UpSchool_UOW_BusinessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Concrete;
using UpSchool_UOW_EntityLayer;
using UpSchool_UOW_PresentationLayer.Models;

namespace UpSchool_UOW_PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);
            
            value1.AccountBalance -= p.Amount;//girilen miktar kadar düşer
            value2.AccountBalance += p.Amount;//girilen miktar buna eklenir.ç Yani birinin gönderdiği para ondan eksilir diğerine o para geçer
            //multipupdate metodu bu sebeple kullanılır. Aynı anda çoklu
            //işlemi yapabilmek için
            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };
            _accountService.TMultiUpdate(modifiedAccounts);//aynı anda iiki tarafında hem parayı gönderen hem alan değerlerini güncellemeyi sağlar.



            return View();
        }
    }
}
