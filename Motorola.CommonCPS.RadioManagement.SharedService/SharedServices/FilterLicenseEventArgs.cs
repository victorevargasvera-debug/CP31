using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200007F RID: 127
	public class FilterLicenseEventArgs : global::System.EventArgs
	{
		// Token: 0x0600080D RID: 2061 RVA: 0x0006058C File Offset: 0x0005E78C
		public FilterLicenseEventArgs(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> originalLicenseList)
		{
			this.OriginalLicenseList = originalLicenseList;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x000605A8 File Offset: 0x0005E7A8
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00060654 File Offset: 0x0005E854
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> LicenseList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2104021476;
				short num2 = num;
				num = (short)348443108;
				switch (num2 == num)
				{
				}
				num = (short)390725632;
				short num3 = num;
				num = (short)875036673;
				if (num != 0)
				{
				}
				num = (short)595853312;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1778029234;
				short num2 = num;
				num = (short)523539122;
				switch (num2 == num)
				{
				}
				num = (short)1711407104;
				short num3 = num;
				num = (short)1649082368;
				if (num != 0)
				{
				}
				num = (short)1241579521;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00060704 File Offset: 0x0005E904
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x000607B4 File Offset: 0x0005E9B4
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> OriginalLicenseList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1668314584;
				short num2 = num;
				num = (short)1208841688;
				switch (num2 == num)
				{
				}
				num = (short)1103429632;
				short num3 = num;
				num = (short)1716453376;
				if (num != 0)
				{
				}
				num = (short)101646337;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)883483006;
				short num2 = num;
				num = (short)1082515838;
				switch (num2 == num)
				{
				}
				num = (short)65077248;
				short num3 = num;
				num = (short)490340353;
				if (num != 0)
				{
				}
				num = (short)2080243712;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> a;

		// Token: 0x040000C7 RID: 199
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> b;
	}
}
