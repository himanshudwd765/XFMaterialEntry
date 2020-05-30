using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFMaterialEntry.iOS.Effects;

[assembly: ResolutionGroupName("MaterialUI")]
[assembly: ExportEffect(typeof(EntryEffect), nameof(EntryEffect))]
namespace XFMaterialEntry.iOS.Effects
{
    public class EntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (this.Control != null)
            {
                if (this.Control is UITextField uITextField)
                {
                    uITextField.BorderStyle = UITextBorderStyle.None;
                }
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
