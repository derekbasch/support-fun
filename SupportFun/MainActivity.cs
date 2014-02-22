using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace SupportFun
{
	[Activity (Label = "SupportFun", MainLauncher = true)]
	public class MainActivity : FragmentActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

//			// add map fragment to frame layout
//			var mapFragment = new SupportMapFragment ();
//			var fragmentTx = this.SupportFragmentManager.BeginTransaction ();
//			fragmentTx.Add (Android.Resource.Id.Content, mapFragment);
//			fragmentTx.Commit ();


			this.SupportFragmentManager.BeginTransaction ().
			Replace (Resource.Id.content, new Fragment1()).
			Commit ();


			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += (sender, e) => {
				this.SupportFragmentManager.BeginTransaction ().
				Replace (Resource.Id.content, new Fragment2()).
				Commit ();
			};
		}
	}

	public class Fragment1 : Android.Support.V4.App.Fragment {

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate (Resource.Layout.Frag1, null);
		}
	}

	public class Fragment2 : Android.Support.V4.App.Fragment {

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate (Resource.Layout.Frag2, null);
		}
	}
}
	


