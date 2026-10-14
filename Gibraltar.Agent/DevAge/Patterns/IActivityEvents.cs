using System;

namespace DevAge.Patterns
{
	// Token: 0x020002BF RID: 703
	internal interface IActivityEvents
	{
		// Token: 0x06002288 RID: 8840
		void ActivityStarted(global::DevAge.Patterns.IActivity sender);

		// Token: 0x06002289 RID: 8841
		void ActivityCompleted(global::DevAge.Patterns.IActivity sender);

		// Token: 0x0600228A RID: 8842
		void ActivityException(global::DevAge.Patterns.IActivity sender, global::System.Exception exception);
	}
}
