using BankingApp.Models;
using BankingApp.ViewModels;
using Model1.Models;
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

            string loginError = "Invalid Username or Password";

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                
                try
                { 
                    using (BankDataEntities db = new BankDataEntities())
                    {
                        //takes input from login
                        var customer = new Customer_Info();
                        //var searchUser = db.Customer_Info.Where(x => x.userName == userName).Select(x => x.Id).FirstOrDefault();
                        //var searchPassword = db.Customer_Info.Where(x => x.Password == password).Select(x => x.Id).FirstOrDefault();
                        var userID = db.Customer_Info.Where(x => x.Password == password).Where(x => x.userName == userName).Select(x => x.Id).First();

                        //Creates a view modal to b
                        if (userID != 0) 
                        { 
                            
                            var users = (from c in db.Customer_Account
                                where c.Id == userID
                                select c ).ToList();

                            var userVM = new List<accountVM>();
                            foreach (var user in users)
                            {
                                var accountVM = new accountVM();
                                accountVM.firstName = user.FirstName;
                                accountVM.lastName = user.LastName;
                                userVM.Add(accountVM);
                            }
                            return View("~/Views/Home/userPage.cshtml",userVM);
                        }
                    }
                }

                catch (Exception)
                {
                    ViewBag.loginError = loginError;
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
                    

                    //Checks if a username already exists
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


        public ActionResult userPage()
        {
            return View();
        }
    }
}