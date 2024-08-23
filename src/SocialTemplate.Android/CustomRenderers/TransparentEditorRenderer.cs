using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SocialTemplate.Droid.CustomRenderers;
using SocialTemplate.CustomViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(TransparentEditor), typeof(TransparentEditorRenderer))]
namespace SocialTemplate.Droid.CustomRenderers
{
    public class TransparentEditorRenderer : EditorRenderer
    {
        public TransparentEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
        }

    }
}