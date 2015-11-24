using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Locations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Util;
using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android;

namespace FastPid2
{
    [Activity(Label = "FastPid", MainLauncher = true, Icon = "@drawable/icon")]

    public class MainActivity : Activity, IOnMapReadyCallback
    {

        private GoogleMap mMap;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            SetUpMap();

        }

        private void SetUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }
        public void OnMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;
        }

    }
}

