using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CoolLooks
{
    public class Row
    {
        public string row { get; set; }
        public string details;



        public Row()
        {
            row = "Undefined";

            details = "Undefined";
        }
        public Row(string _row)
        {
            row = _row;

            details = "Undefined";
        }
        public Row(string _row, string _details)
        {
            row = _row;

            details = _details;
        }


    }
}