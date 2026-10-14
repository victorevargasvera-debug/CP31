using System;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000044 RID: 68
	[global::NLog.Config.NLogConfigurationItem]
	public class MethodCallParameter
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x000103EA File Offset: 0x0000E5EA
		public MethodCallParameter()
		{
			this.ParameterType = typeof(string);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00010402 File Offset: 0x0000E602
		public MethodCallParameter(global::NLog.Layouts.Layout layout)
		{
			this.ParameterType = typeof(string);
			this.Layout = layout;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00010421 File Offset: 0x0000E621
		public MethodCallParameter(string parameterName, global::NLog.Layouts.Layout layout)
		{
			this.ParameterType = typeof(string);
			this.Name = parameterName;
			this.Layout = layout;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00010447 File Offset: 0x0000E647
		public MethodCallParameter(string name, global::NLog.Layouts.Layout layout, global::System.Type type)
		{
			this.ParameterType = type;
			this.Name = name;
			this.Layout = layout;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00010464 File Offset: 0x0000E664
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x0001046C File Offset: 0x0000E66C
		public string Name { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00010475 File Offset: 0x0000E675
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x0001047D File Offset: 0x0000E67D
		public global::System.Type Type
		{
			get
			{
				return this.ParameterType;
			}
			set
			{
				this.ParameterType = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00010486 File Offset: 0x0000E686
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x0001048E File Offset: 0x0000E68E
		public global::System.Type ParameterType { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00010497 File Offset: 0x0000E697
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0001049F File Offset: 0x0000E69F
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout { get; set; }
	}
}
