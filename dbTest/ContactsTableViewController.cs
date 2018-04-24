using Foundation;
using System;
using UIKit;
using System.Collections;
using System.Collections.Generic;
using SQLite;
using System.IO;
using System.Linq;


namespace dbTest
{
    public partial class ContactsTableViewController : UITableViewController
    {
         List<Contact> contacts;


        public ContactsTableViewController (IntPtr handle) : base (handle)
        {


        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            contacts = new List<Contact>();
		}


		public override void ViewDidAppear(bool animated)
		{
            base.ViewDidAppear(animated);

            contacts = Read(ViewController.DbPath);
            TableView.ReloadData();
                                     
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            var cell = tableView.DequeueReusableCell("contactsCell", indexPath);

            var data = contacts[indexPath.Row];

            cell.TextLabel.Text = data.name;
            cell.DetailTextLabel.Text = data.phoneNumber;

            return cell;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
            return contacts.Count;
		}


        public List<Contact> Read(string db_path){

            List<Contact> contacts = new List<Contact>();
                using (var conn = new SQLite.SQLiteConnection(db_path))
            {
                contacts = conn.Table<Contact>().ToList();
            }

            return contacts;
        }
	}
}