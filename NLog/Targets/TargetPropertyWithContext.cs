using System;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000052 RID: 82
	[global::NLog.Config.NLogConfigurationItem]
	[global::NLog.Config.ThreadAgnostic]
	public class TargetPropertyWithContext
	{
		// Token: 0x06000740 RID: 1856 RVA: 0x0001262F File Offset: 0x0001082F
		public TargetPropertyWithContext() : this(null, null)
		{
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00012639 File Offset: 0x00010839
		public TargetPropertyWithContext(string name, global::NLog.Layouts.Layout layout)
		{
			this.Name = name;
			this.Layout = layout;
			this.IncludeEmptyValue = true;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00012656 File Offset: 0x00010856
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0001265E File Offset: 0x0001085E
		[global::NLog.Config.RequiredParameter]
		public string Name { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00012667 File Offset: 0x00010867
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0001266F File Offset: 0x0001086F
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00012678 File Offset: 0x00010878
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00012680 File Offset: 0x00010880
		public bool IncludeEmptyValue { get; set; }
	}
}
