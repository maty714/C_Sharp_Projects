using NewsLetter.Models;
using NewsLetter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetter.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        //this pulls info from the database
        public ActionResult Index()
        {
            //EVERYTHING BELOW IS USING ENTITY FRAMEWORK
            using (NewsletterEntities db = new NewsletterEntities()) //we want to use the using statement when using entity, once we do this, the connection is established through the use of that constructor in Newsletter.Context.cs
            {

                var signups = db.SignUps; //db has a property called SignUps which represents all our records in the database
                var signupVms = new List<SignupVm>(); //view models are considered best practice. this limits what can go to the view. We create a view model and transfer the information that we want the viewer to see
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }

            //BELOW IS CODE WE USE IF WE DO NOT WANT ENTITY FRAMEWORK

            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress from SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //       

            //        signups.Add(signup); //this is the list that we add signup to. remember this is an object so thats why we set all the properties

            //    }

            //    connection.Close();
            //}

            //var signupVms = new List<SignupVm>(); //view models are considered best practice. this limits what can go to the view. We create a view model and transfer the information that we want the viewer to see
            //foreach(var signup in signups)
            //{
            //    var signupVm = new SignupVm();
            //    signupVm.FirstName = signup.FirstName;
            //    signupVm.LastName = signup.LastName;
            //    signupVm.EmailAddress = signup.EmailAddress;
            //    signupVms.Add(signupVm);
            //}



            //return View(signupVms);
        }
    }
}