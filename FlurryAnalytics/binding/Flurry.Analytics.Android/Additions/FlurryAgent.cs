using System;

namespace Flurry.Analytics
{
	public partial class FlurryAgent
	{
		public static void SetGender(Gender gender)
		{
			FlurryAgent.SetGender(gender);
		}
	}

	public enum Gender
	{
		Male = 1,
		Female = 0,
		Unknown = -1
	}
	
	public class FlurryAgentEventsListener : Java.Lang.Object
	{
		public event EventHandler SessionStarted;

		public void OnSessionStarted()
		{
			var handler = SessionStarted;
			if (handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}
	}
}

