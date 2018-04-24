using System;
using SQLite;
using System.IO;
using UIKit;

namespace dbTest
{
    public partial class ViewController : UIViewController
    {
        partial void Addbtn_TouchUpInside(UIButton sender)
        {
            try{
                string nameFromView = TFname.Text;
                string phoneNumberFromView = TFnumber.Text;

                var contact = new Contact
                {
                    name = nameFromView,
                    phoneNumber = phoneNumberFromView
                };

                var db = new SQLiteConnection(DbPath);
                db.Insert(contact);
                lblDbName.Text = "Data Added successfullyt";


            }
            catch(Exception ex){
                
            }
        }

        partial void Createbtn_TouchUpInside(UIButton sender)
        {
            CreateDb();
        }

        public static string DbName = "Phonebook.db3";
        public static string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DbName);



        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }


        public void CreateDb(){
            
            try{

                var db = new SQLiteConnection(DbPath);
                db.CreateTable<Contact>();


                lblDbName.Text = "Your database is :" + DbName;
                lblDbPath.Text = DbPath;


            }
            catch(Exception ex){
                
            }

        }




        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
