using Android.Content;
using Android.Locations;
using Android.Runtime;

namespace MauiApp01;

public partial class NameDevice
{
    public partial string GetName()
    {
        var location = Android.App.Application.Context.GetSystemService(Context.LocationService).JavaCast<LocationManager>();
        return location.GnssHardwareModelName;
    }
}
