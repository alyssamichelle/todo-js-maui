using Microsoft.JSInterop;

namespace TodoWrapper6;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
    }

    [JSInvokable]
    public static string GetDeviceInfo()
    {
        string deviceDetails = "Device Name: " + DeviceInfo.Name + " | Orientation: " + DeviceDisplay.MainDisplayInfo.Orientation;
        return deviceDetails;
    }

    //[JSInvokable]
    //private void ToggleShake()
    //{
    //    if (Accelerometer.Default.IsSupported)
    //    {
    //        if (!Accelerometer.Default.IsMonitoring)
    //        {
    //            // Turn on compass
    //            Accelerometer.Default.ShakeDetected += Accelerometer_ShakeDetected;
    //            Accelerometer.Default.Start(SensorSpeed.Game);
    //        }
    //        else
    //        {
    //            // Turn off compass
    //            Accelerometer.Default.Stop();
    //            Accelerometer.Default.ShakeDetected -= Accelerometer_ShakeDetected;
    //        }
    //    }
    //}

    //[JSInvokable]
    //private void Accelerometer_ShakeDetected(object sender, EventArgs e)
    //{
    //    // Update UI Label with a "shaked detected" notice, in a randomized color
    //    ShakeLabel.TextColor = new Color(Random.Shared.Next(256), Random.Shared.Next(256), Random.Shared.Next(256));
    //    ShakeLabel.Text = $"Shake detected";
    //}
}

