using Google.Android.Material.Snackbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MauiApp1.Platforms.Android
{
    public class MessageTest : IMessage
    {
        public void ShowMessageAndCatchAction(string Message, Action<string> ToClick)
        {
            var Activity =(Activity)MainActivity.ActivityCurrent;
            //var view = Activity.FindViewById(Resource.Id.content);
            var view = Activity.FindViewById(global::Android.Resource.Id.Content); 
            Snackbar snackbar = Snackbar.Make(view, Message, Snackbar.LengthLong)
                .SetAction("Regresa", o =>
                {
                    ToClick.Invoke("Regresa, Toco el Snack");
                });
            snackbar.Show();
        }
    }
}
