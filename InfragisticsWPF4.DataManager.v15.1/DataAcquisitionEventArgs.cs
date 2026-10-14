using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Infragistics
{
	// Token: 0x02000028 RID: 40
	public class DataAcquisitionEventArgs : global::Infragistics.HandleableEventArgs
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000D268 File Offset: 0x0000B468
		public global::System.Collections.IList DataSource { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000D271 File Offset: 0x0000B471
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000D279 File Offset: 0x0000B479
		public bool EnablePaging { get; protected internal set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000D282 File Offset: 0x0000B482
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000D28A File Offset: 0x0000B48A
		public int PageSize { get; protected internal set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000D293 File Offset: 0x0000B493
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000D29B File Offset: 0x0000B49B
		public int CurrentPage { get; protected internal set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000D2AC File Offset: 0x0000B4AC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.SortContext> CurrentSort { get; protected internal set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000D2B5 File Offset: 0x0000B4B5
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000D2BD File Offset: 0x0000B4BD
		public global::Infragistics.GroupByContext GroupByContext { get; protected internal set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000D2C6 File Offset: 0x0000B4C6
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000D2CE File Offset: 0x0000B4CE
		public global::Infragistics.RecordFilterCollection Filters { get; protected internal set; }
	}
}
