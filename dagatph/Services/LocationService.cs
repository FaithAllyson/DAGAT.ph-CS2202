using System;
using System.Device.Location;

namespace dagatph
{
    internal class LocationService
    {
        private GeoCoordinateWatcher watcher;
        public GeoCoordinate LastKnownLocation { get; private set; }

        public LocationService()
        {
            watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            watcher.PositionChanged += Watcher_PositionChanged;
            watcher.Start();
        }

        private void Watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            if (!e.Position.Location.IsUnknown)
            {
                LastKnownLocation = e.Position.Location;
            }
        }
    }
}