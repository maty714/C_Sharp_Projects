﻿using NewsLetter.Models;
using NewsLetter.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetter.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True; 
                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  //the private readonly helps protect the string

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]  //anytime we are using a post method, we need this above it
        public ActionResult SignUp(string firstName, string lastName, string emailAddress) //the variables in here match with the input "name" parameter in the index.cshtml file. MVC knows how to distinguish this through model binding
        {

           if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                


                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(@"FirstName", SqlDbType.VarChar);
                    command.Parameters.Add(@"LastName", SqlDbType.VarChar);
                    command.Parameters.Add(@"EmailAddress", SqlDbType.VarChar);

                    command.Parameters[@"FirstName"].Value = firstName;
                    command.Parameters[@"LastName"].Value = lastName;
                    command.Parameters[@"EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");

            }
        }
       
        public ActionResult Admin()
        {

            string queryString = @"SELECT Id, FirstName, LastName,SocialSecurityNumber, EmailAddress from SignUps";
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new NewsletterSignUp();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

                    signups.Add(signup); //this is the list that we add signup to. remember this is an object so thats why we set all the properties

                }

                connection.Close();
            }

            var signupVms = new List<SignupVm>(); //view models are considered best practice. this limits what can go to the view. We create a view model and transfer the information that we want the viewer to see
            foreach(var signup in signups)
            {
                var signupVm = new SignupVm();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;
                signupVms.Add(signupVm);
            }



            return View(signupVms);
        }
    }
}