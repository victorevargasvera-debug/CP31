using System;
using System.Collections.Generic;
using System.Reflection;

namespace NLog.Internal.Fakeables
{
	// Token: 0x02000148 RID: 328
	public interface IAppDomain
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000EBD RID: 3773
		string BaseDirectory { get; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000EBE RID: 3774
		string ConfigurationFile { get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000EBF RID: 3775
		global::System.Collections.Generic.IEnumerable<string> PrivateBinPath { get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000EC0 RID: 3776
		string FriendlyName { get; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000EC1 RID: 3777
		int Id { get; }

		// Token: 0x06000EC2 RID: 3778
		global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetAssemblies();

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000EC3 RID: 3779
		// (remove) Token: 0x06000EC4 RID: 3780
		event global::System.EventHandler<global::System.EventArgs> ProcessExit;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000EC5 RID: 3781
		// (remove) Token: 0x06000EC6 RID: 3782
		event global::System.EventHandler<global::System.EventArgs> DomainUnload;
	}
}
