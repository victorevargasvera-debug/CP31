using System;
using System.Collections.Generic;
using System.Diagnostics;
using Gibraltar.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000190 RID: 400
	[global::System.Diagnostics.DebuggerDisplay("Id: {Id}, IsRunning: {IsRunning}")]
	internal class SessionFileInfo<T> where T : class
	{
		// Token: 0x060010B7 RID: 4279 RVA: 0x0002E6CC File Offset: 0x0002C8CC
		public SessionFileInfo(global::Gibraltar.Data.SessionHeader sessionHeader, T fileInfo, bool isNew)
		{
			this.m_SessionId = sessionHeader.Id;
			this.m_SessionHeader = sessionHeader;
			this.m_SessionHeader.IsNew = isNew;
			this.m_SessionFragments.Add(sessionHeader.FileSequence, fileInfo);
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0002E720 File Offset: 0x0002C920
		public global::System.Guid Id
		{
			get
			{
				return this.m_SessionId;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0002E728 File Offset: 0x0002C928
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0002E730 File Offset: 0x0002C930
		public bool IsRunning { get; set; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0002E73C File Offset: 0x0002C93C
		public global::Gibraltar.Data.SessionHeader Header
		{
			get
			{
				return this.m_SessionHeader;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x0002E744 File Offset: 0x0002C944
		public global::System.Collections.Generic.IList<T> Fragments
		{
			get
			{
				return this.m_SessionFragments.Values;
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0002E754 File Offset: 0x0002C954
		public void AddFragment(global::Gibraltar.Data.SessionHeader sessionHeader, T fileInfo, bool isNew)
		{
			global::System.Collections.Generic.SortedList<int, T> sessionFragments = this.m_SessionFragments;
			lock (sessionFragments)
			{
				if (!this.m_SessionFragments.ContainsKey(sessionHeader.FileSequence))
				{
					if (sessionHeader.FileSequence > this.m_SessionHeader.FileSequence)
					{
						sessionHeader.IsNew = this.m_SessionHeader.IsNew;
						this.m_SessionHeader = sessionHeader;
					}
					this.m_SessionHeader.IsNew = (this.m_SessionHeader.IsNew || isNew);
					this.m_SessionFragments.Add(sessionHeader.FileSequence, fileInfo);
				}
			}
		}

		// Token: 0x0400059D RID: 1437
		private readonly global::System.Guid m_SessionId;

		// Token: 0x0400059E RID: 1438
		private readonly global::System.Collections.Generic.SortedList<int, T> m_SessionFragments = new global::System.Collections.Generic.SortedList<int, T>();

		// Token: 0x0400059F RID: 1439
		private global::Gibraltar.Data.SessionHeader m_SessionHeader;
	}
}
