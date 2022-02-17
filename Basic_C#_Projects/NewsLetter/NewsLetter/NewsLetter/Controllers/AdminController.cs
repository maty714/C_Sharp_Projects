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
            //EVERYTHING BELOW IS USING ENTITY FRAMEWORK and used to build the viewModels. We use view models incase what we pass to the view will change significantly in the future. This decouples the view from the datatbase. this decoupling makes it easier to maintain applications
            using (NewsletterEntities db = new NewsletterEntities()) //we want to use the using statement when using entity, once we do this, the connection is established through the use of that constructor in Newsletter.Context.cs
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();  //db has a property called SignUps which represents all our records in the database, in this situation, we are filtering anything where removed property is set to null
                var signups = (from c in db.SignUps //this way of filtering uses LINQ instead and does the same thing. REMEMBER this is how everything gets displayed in that list
                              where c.Removed == null
                              select c).ToList();

                //var signups = db.SignUps;
                var signupVms = new List<SignupVm>(); //view models are considered best practice. this limits what can go to the view. We create a view model and transfer the information that we want the viewer to see
                foreach (var signup in signups) //"signup" is now an object variable we need to loop through the signups that were added to db.SignUps in the homeController section. from there we can set these variables to the signupVM variable which is an instance of the class SignupVM. notice how the properties in SignupVM are the same as the properties in the SignUp class. 
                {                                       //this is because the SignUp class does the same thing here. it grabs the variables entered on the web page and sets them equal to the instance of the class SignUp. refer to HomeController and SignUp class
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm); //adding in the new object to the list that will be viewed by the admin
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

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id); //this finds based on primary key values
                signup.Removed = DateTime.Now; //this changes the removed property to the datetime, we will then filter out anything where the removed property is null and display those filtered values
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}