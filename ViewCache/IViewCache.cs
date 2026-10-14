using System;
using System.Collections.Generic;
using System.Data.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ViewCache
{
	// Token: 0x02000005 RID: 5
	public interface IViewCache
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9
		int LoadedCount { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10
		int TotalCount { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11
		global::System.TimeSpan? RemainTime { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12
		int LoadingState { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13
		int Speed { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14
		string LoadingError { get; }

		// Token: 0x0600000F RID: 15
		void StopDownloading();

		// Token: 0x06000010 RID: 16
		bool CanStopDownloading();

		// Token: 0x06000011 RID: 17
		void ItemChanged<V>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<V> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters) where V : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase;

		// Token: 0x06000012 RID: 18
		void Close();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000013 RID: 19
		// (remove) Token: 0x06000014 RID: 20
		event global::System.EventHandler ProcessingCompleted;

		// Token: 0x06000015 RID: 21
		bool IsTypeMatchViewCache(global::System.Type type);
	}
}
