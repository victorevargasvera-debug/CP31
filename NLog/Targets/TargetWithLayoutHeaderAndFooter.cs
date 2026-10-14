using System;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000055 RID: 85
	public abstract class TargetWithLayoutHeaderAndFooter : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00012E23 File Offset: 0x00011023
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00012E30 File Offset: 0x00011030
		[global::NLog.Config.RequiredParameter]
		public override global::NLog.Layouts.Layout Layout
		{
			get
			{
				return this.LHF.Layout;
			}
			set
			{
				if (value is global::NLog.Layouts.LayoutWithHeaderAndFooter)
				{
					base.Layout = value;
					return;
				}
				if (this.LHF == null)
				{
					this.LHF = new global::NLog.Layouts.LayoutWithHeaderAndFooter
					{
						Layout = value
					};
					return;
				}
				this.LHF.Layout = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00012E69 File Offset: 0x00011069
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00012E76 File Offset: 0x00011076
		public global::NLog.Layouts.Layout Footer
		{
			get
			{
				return this.LHF.Footer;
			}
			set
			{
				this.LHF.Footer = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00012E84 File Offset: 0x00011084
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00012E91 File Offset: 0x00011091
		public global::NLog.Layouts.Layout Header
		{
			get
			{
				return this.LHF.Header;
			}
			set
			{
				this.LHF.Header = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00012E9F File Offset: 0x0001109F
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00012EAC File Offset: 0x000110AC
		private global::NLog.Layouts.LayoutWithHeaderAndFooter LHF
		{
			get
			{
				return (global::NLog.Layouts.LayoutWithHeaderAndFooter)base.Layout;
			}
			set
			{
				base.Layout = value;
			}
		}
	}
}
