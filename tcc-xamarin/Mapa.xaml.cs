using System;
using System.Collections.Generic;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace tccxamarin
{
    public partial class Mapa : ContentPage
    {
        public Mapa()
        {
            InitializeComponent();
            GetLocation();
        }

        public async void GetLocation()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;

            var position = await locator.GetPositionAsync();
            Position pos = new Position(position.Latitude, position.Longitude);
            map.MyLocationEnabled = true;
            MapSpan mapSpan = MapSpan.FromCenterAndRadius(pos, Distance.FromKilometers(0.444));
            map.MoveToRegion(mapSpan);
        }
    }
}
