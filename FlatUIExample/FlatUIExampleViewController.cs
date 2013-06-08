using System.Drawing;
using MonoTouch.UIKit;
using FlatUI;

namespace FlatUIExample
{
	public partial class FlatUIExampleViewController : UIViewController
	{
		public FlatUIExampleViewController () : base ("FlatUIExampleViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.White;
			View.AutosizesSubviews = true;

			// Perform any additional setup after loading the view, typically from a nib.
			var button = new FlatButton (new RectangleF (20, 20, 280, 43));
			button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			button.SetTitle ("SHOW ALERT");
			View.AddSubview (button);

			var progressView = new FlatProgressView(new Rectangle(20, 84, 280, 20));
			progressView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			progressView.Progress = .66f;
			View.AddSubview (progressView);

			var slider = new FlatSlider(new Rectangle(20, 114, 280, 20));
			slider.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			View.AddSubview (slider);
		}

	

	}
}

