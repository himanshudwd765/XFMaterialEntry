using System;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFMaterialEntry.Droid.Effects;

[assembly: ResolutionGroupName("MaterialUI")]
[assembly: ExportEffect(typeof(EntryEffect), nameof(EntryEffect))]
namespace XFMaterialEntry.Droid.Effects
{
    public class EntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (this.Control != null)
            {
                if(this.Control is EditText editText)
                {
                    editText.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
