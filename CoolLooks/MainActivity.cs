using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

using System;
using System.Collections.Generic;
using CoolLooks.Resources;

using SupportFragment = Android.Support.V4.App.Fragment;


namespace CoolLooks
{
    [Activity(Label = "CoolLooks", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {

        
        private ListView listV;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            

            listV = FindViewById<ListView>(Resource.Id.listFragment);
            RowAdapter listAdapter=new RowAdapter(this, contactList);
            
            listV.Adapter = listAdapter;
            listV.ItemClick += OpenDetails;

            var orientation = new DeviceOrientationImplementation();
            LinearLayout root = FindViewById<LinearLayout>(CoolLooks.Resource.Id.Root);
            switch (orientation.GetOrientation())
            {
                case DeviceOrientations.Undefined:
                    throw new Exception();
                    break;
                case DeviceOrientations.Landscape:
                    root.Orientation = Orientation.Vertical;
                    break;
                case DeviceOrientations.Portrait:
                    root.Orientation = Orientation.Horizontal;
                    break;
            }



            DetailFragment detailsFragment =new DetailFragment();
            
            var trans = SupportFragmentManager.BeginTransaction();
            trans.Replace(Resource.Id.DetailsRoot, detailsFragment, "Details");

            Fragments.MyListFragment listFragment = new Fragments.MyListFragment();

            var listTrans = SupportFragmentManager.BeginTransaction();
            trans.Replace(Resource.Id.ListRoot,listFragment,"List");
            
        }



       


    }
}


