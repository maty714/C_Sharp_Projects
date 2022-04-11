using BankingApp.Models;
using BankingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                
                using (BankDataEntities db = new BankDataEntities())
                {
                    //takes input from login
                    var customer = new Customer_Info();
                    var searchUser = db.Customer_Info.Where(x => x.userName == userName).Select(x => x.userName).FirstOrDefault();
                    var searchPassword = db.Customer_Info.Where(x => x.Password == password).Select(x => x.Password).FirstOrDefault();


                    if (searchUser == userName && searchPassword == password)
                    {
                        
                        //Creates a view modal to be used
                        var users = (from c in db.Customer_Account
                                    where c.userName == userName
                                    select c ).ToList();

                        var userVM = new List<accountVM>();
                        foreach (var user in users)
                        {
                            var accountVM = new accountVM();
                            accountVM.firstName = user.FirstName;
                            accountVM.lastName = user.LastName;
                        }
                        return View("~/Content_User/index.html");
                    }
                }
                



            }

            return View();
        }
        


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string firstName, string lastName, string emailAddress, string userName, string password)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {



                using (BankDataEntities db = new BankDataEntities())
                {

                    string errMessage = "This username is already taken";
                    
                    //adds customer to Customer_Info table
                    var customer = new Customer_Info();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.EmailAddress = emailAddress;
                    customer.userName = userName;
                    customer.Password = password;

                    //adds customer info to account table
                    var account = new Customer_Account();
                    account.Id = customer.Id;
                    account.FirstName = firstName;
                    account.LastName = lastName;
                    account.userName = userName;
                    


                    var searchData = db.Customer_Info.Any(x => x.userName == userName);
                    if (!searchData)
                    {
                        db.Customer_Info.Add(customer); 
                        db.Customer_Account.Add(account);
                        db.SaveChanges();

                        return View("~/Views/Home/Login.cshtml");
                    }
                    else
                    {                       
                        ViewBag.userNameError = errMessage;
                    }
                   
                }


                return View("~/Views/Home/Create.cshtml");
            }  
            

        }
    }
}