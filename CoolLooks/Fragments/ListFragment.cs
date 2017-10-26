using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

using CoolLooks.Resources;

namespace CoolLooks.Fragments
{
    public class MyListFragment : Android.Support.V4.App.Fragment
    {

        private ListView listV;
        private List<Row> contactList;
        public MyListFragment()
        {

        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.ListFragment, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            contactList = new List<Row> { new Row("Undef1", "undef1"), new Row("Undef2", "undef2"), new Row("Undef3", "undef3") };

            listV = View.FindViewById<ListView>(Resource.Id.listFragment);


            RowAdapter listAdapter = new RowAdapter(Context, contactList);

            listV.Adapter = listAdapter;
            listV.ItemClick += OpenDetails;

        }

        private void OpenDetails(object sender, AdapterView.ItemClickEventArgs e)
        {
            TextView clickedTV = FindViewById<TextView>(Resource.Id.detailsText);
            clickedTV.Text = contactList[e.Position].details + " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        }
    }
}