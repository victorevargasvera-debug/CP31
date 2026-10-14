using System;
using NLog.Config;

namespace NLog.Layouts
{
	// Token: 0x02000099 RID: 153
	[global::NLog.Config.NLogConfigurationItem]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class CsvColumn
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x00018889 File Offset: 0x00016A89
		public CsvColumn() : this(null, null)
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00018893 File Offset: 0x00016A93
		public CsvColumn(string name, global::NLog.Layouts.Layout layout)
		{
			this.Name = name;
			this.Layout = layout;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000188A9 File Offset: 0x00016AA9
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x000188B1 File Offset: 0x00016AB1
		public string Name { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000188BA File Offset: 0x00016ABA
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x000188C2 File Offset: 0x00016AC2
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout { get; set; }
	}
}
