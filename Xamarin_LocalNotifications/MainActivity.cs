using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Xamarin_LocalNotifications
{
    [Activity(Label = "Xamarin_LocalNotifications", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        NotificationManager manager;
        Notification myNotification;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // SET NOTIFICATION
            Notification.Builder myBuilder = new Notification.Builder(this);
            myBuilder.SetContentTitle("Who is the most crazy pony?");
            myBuilder.SetContentText("Pinkie Pie!");
            myBuilder.SetSmallIcon(Resource.Drawable.pony_icon);

            // BUILD THE NOTIFICATION
            myNotification = myBuilder.Build();

            // SET THE NOTIFICATION MANAGER
            manager = GetSystemService(Context.NotificationService) as NotificationManager;

            // AND FINALY - NOTIFY!
            Button myBtn = FindViewById<Button>(Resource.Id.button1);
            myBtn.Click += NotifyOnClick;
        }

        private void NotifyOnClick(object sender, System.EventArgs e)
        {
            manager.Notify(0,myNotification);
        }
    }
}

