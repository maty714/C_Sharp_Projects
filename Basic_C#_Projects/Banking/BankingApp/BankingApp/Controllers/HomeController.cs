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

        public ActionResult Login(string emailAddress, string password)
        {
            ViewBag.Message = "Your application description page.";

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
                    var customer = new Customer_Info();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.EmailAddress = emailAddress;
                    customer.userName = userName;
                    customer.Password = password;


                    var searchData = db.Customer_Info.Any(x => x.userName == userName);
                    if (!searchData)
                    {
                        db.Customer_Info.Add(customer); //this is where eveything we input is added, from here if you go to adminController, you will see how we set a variable to db.SignUps. This in turn will allow us to view the data through the admin view
                        db.SaveChanges(); //nothing will be saved to the database until we use this
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