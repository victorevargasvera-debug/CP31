using System;
using System.ComponentModel;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000054 RID: 84
	public abstract class TargetWithLayout : global::NLog.Targets.Target
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x00012DF2 File Offset: 0x00010FF2
		protected TargetWithLayout()
		{
			this.Layout = "${longdate}|${level:uppercase=true}|${logger}|${message}";
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00012E0A File Offset: 0x0001100A
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00012E12 File Offset: 0x00011012
		[global::NLog.Config.RequiredParameter]
		[global::System.ComponentModel.DefaultValue("${longdate}|${level:uppercase=true}|${logger}|${message}")]
		public virtual global::NLog.Layouts.Layout Layout { get; set; }
	}
}
