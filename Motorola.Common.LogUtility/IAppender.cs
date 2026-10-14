using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000008 RID: 8
	public interface IAppender
	{
		// Token: 0x06000029 RID: 41
		void Close();

		// Token: 0x0600002A RID: 42
		void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e);

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43
		// (set) Token: 0x0600002C RID: 44
		string Name { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002D RID: 45
		bool IsEnabled { get; }
	}
}
