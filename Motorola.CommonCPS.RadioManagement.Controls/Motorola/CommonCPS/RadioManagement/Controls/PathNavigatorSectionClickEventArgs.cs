using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000DF RID: 223
	public class PathNavigatorSectionClickEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x00063A20 File Offset: 0x00061C20
		public PathNavigatorSectionClickEventArgs(string sectionID, global::System.Windows.RoutedEvent routedEvent) : base(routedEvent)
		{
			this.SectionID = sectionID;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00063A3C File Offset: 0x00061C3C
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00063AE8 File Offset: 0x00061CE8
		public string SectionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1567600389;
				short num2 = num;
				num = (short)234598149;
				switch (num2 == num)
				{
				}
				num = (short)1742012417;
				if (num != 0)
				{
				}
				num = (short)1197015040;
				short num3 = num;
				num = (short)234094592;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1045900991;
				short num2 = num;
				num = (short)1280650943;
				switch (num2 == num)
				{
				}
				num = (short)125173761;
				if (num != 0)
				{
				}
				num = (short)844627968;
				short num3 = num;
				num = (short)2093940736;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x040002AB RID: 683
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
