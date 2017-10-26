package md57f9e14c35b67f8336d123a40328bf8b2;


public class OrientationListener
	extends android.view.OrientationEventListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onOrientationChanged:(I)V:GetOnOrientationChanged_IHandler\n" +
			"";
		mono.android.Runtime.register ("Plugin.DeviceOrientation.OrientationListener, Plugin.DeviceOrientation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OrientationListener.class, __md_methods);
	}


	public OrientationListener (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == OrientationListener.class)
			mono.android.TypeManager.Activate ("Plugin.DeviceOrientation.OrientationListener, Plugin.DeviceOrientation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public OrientationListener (android.content.Context p0, int p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == OrientationListener.class)
			mono.android.TypeManager.Activate ("Plugin.DeviceOrientation.OrientationListener, Plugin.DeviceOrientation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Hardware.SensorDelay, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public void onOrientationChanged (int p0)
	{
		n_onOrientationChanged (p0);
	}

	private native void n_onOrientationChanged (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
