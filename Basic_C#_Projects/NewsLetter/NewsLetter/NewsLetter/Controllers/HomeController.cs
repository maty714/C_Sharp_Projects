using NewsLetter.Models;
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
        //Use this connection string if you decide to not use Entity Framework code
        // private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True; 
        //        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  //the private readonly helps protect the string
        //
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]  //anytime we are using a post method, we need this above it
       
        //this puts information into the database
        
        public ActionResult SignUp(string firstName, string lastName, string emailAddress) //the variables in here match with the input "name" parameter in the index.cshtml file. MVC knows how to distinguish this through model binding
        {

           if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                //EVERYTHING BELOW IS USING ENTITY FRAMEWORK

                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup); //this is where eveything we input is added, from here if you go to adminController, you will see how we set a variable to db.SignUps. This in turn will allow us to view the data through the admin view
                    db.SaveChanges(); //nothing will be saved to the database until we use this
                }

                    //BELOW IS CODE WE USE IF WE DO NOT WANT ENTITY FRAMEWORK 

                    //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                    //                        (@FirstName, @LastName, @EmailAddress)";

                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                    //    SqlCommand command = new SqlCommand(queryString, connection);
                    //    command.Parameters.Add(@"FirstName", SqlDbType.VarChar);
                    //    command.Parameters.Add(@"LastName", SqlDbType.VarChar);
                    //    command.Parameters.Add(@"EmailAddress", SqlDbType.VarChar);

                    //    command.Parameters[@"FirstName"].Value = firstName;
                    //    command.Parameters[@"LastName"].Value = lastName;
                    //    command.Parameters[@"EmailAddress"].Value = emailAddress;

                    //    connection.Open();
                    //    command.ExecuteNonQuery();
                    //    connection.Close();
                    //}
                    return View("Success");

            }
        }
       

        
    }
}