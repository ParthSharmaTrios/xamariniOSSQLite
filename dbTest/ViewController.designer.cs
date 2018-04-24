// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace dbTest
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addbtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton createbtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDbName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDbPath { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TFname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TFnumber { get; set; }

        [Action ("Addbtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Addbtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("Createbtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Createbtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addbtn != null) {
                addbtn.Dispose ();
                addbtn = null;
            }

            if (createbtn != null) {
                createbtn.Dispose ();
                createbtn = null;
            }

            if (lblDbName != null) {
                lblDbName.Dispose ();
                lblDbName = null;
            }

            if (lblDbPath != null) {
                lblDbPath.Dispose ();
                lblDbPath = null;
            }

            if (TFname != null) {
                TFname.Dispose ();
                TFname = null;
            }

            if (TFnumber != null) {
                TFnumber.Dispose ();
                TFnumber = null;
            }
        }
    }
}