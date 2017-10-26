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
using Java.Lang;

namespace CoolLooks.Resources
{
    public class RowAdapter : BaseAdapter<string>    
    {
        private List<Row> stList;
        private Context mContext;
        public override int Count => stList.Count;


        public RowAdapter(Context context, List<Row>st)
        {
            mContext = context;
            stList = st;
        }
        public override string this[int position]
        {
            get { return stList[position].row; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return stList[position].row;
        }
      
        public override long GetItemId(int position)
        {
            return position;
        }



        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

             if(row==null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listRow, null, false);
            }

            TextView textView = row.FindViewById<TextView>(Resource.Id.textView1);


            textView.Text = stList[position].row;

            return row;
        }



    }
}