using SocialTemplate.iOS.CustomRenderers;
using Foundation;
using SocialTemplate.CustomViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(TransparentEditor), typeof(TransparentEditorRenderer))]
namespace SocialTemplate.iOS.CustomRenderers
{
    public class TransparentEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                //Control.BorderStyle = UITextBorderStyle.None;
            }
        }

    }
}