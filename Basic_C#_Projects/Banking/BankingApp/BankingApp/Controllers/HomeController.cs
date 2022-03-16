﻿using BankingApp.Models;
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
                    var customer = new Customer_Info();
                    string searchUser = db.Customer_Info.Where(x => x.userName == userName).ToString();
                    string searchPassword = db.Customer_Info.Where(x => x.userName == password).ToString();


                    if (searchUser == userName && searchPassword == password)
                    {
                        var account = new Customer_Account();
                        var firstName = account.FirstName;
                        var lastName = account.LastName;



                         
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