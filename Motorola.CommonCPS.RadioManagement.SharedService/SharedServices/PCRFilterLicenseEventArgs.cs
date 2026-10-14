using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A3 RID: 163
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PCRFilterLicenseEventArgs : global::System.EventArgs
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x00074DDC File Offset: 0x00072FDC
		public PCRFilterLicenseEventArgs(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList)
		{
			this.EntitledLicenseList = licenseList;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00074DF8 File Offset: 0x00072FF8
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00074EAC File Offset: 0x000730AC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> EntitledLicenseList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2112902771;
				short num2 = num;
				num = (short)225597043;
				switch (num2 == num)
				{
				}
				num = (short)2024669184;
				short num3 = num;
				num = (short)979566592;
				if (num != 0)
				{
				}
				num = (short)1294532609;
				if (num != 0)
				{
				}
				return this.<EntitledLicenseList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1484785921;
				short num2 = num;
				num = (short)159123713;
				switch (num2 == num)
				{
				}
				num = (short)178716672;
				short num3 = num;
				num = (short)1156382721;
				if (num != 0)
				{
				}
				num = (short)1985806336;
				if (num != 0)
				{
				}
				this.<EntitledLicenseList>k__BackingField = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00074F60 File Offset: 0x00073160
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00075010 File Offset: 0x00073210
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrRadioEntitledLicenseSummary> LicenseSummaryList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1241024503;
				short num2 = num;
				num = (short)636651511;
				switch (num2 == num)
				{
				}
				num = (short)1674706944;
				short num3 = num;
				num = (short)955842561;
				if (num != 0)
				{
				}
				num = (short)152109056;
				if (num != 0)
				{
				}
				return this.<LicenseSummaryList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2136664010;
				short num2 = num;
				num = (short)1230563274;
				switch (num2 == num)
				{
				}
				num = (short)887226368;
				short num3 = num;
				num = (short)1564278785;
				if (num != 0)
				{
				}
				num = (short)853213184;
				if (num != 0)
				{
				}
				this.<LicenseSummaryList>k__BackingField = value;
			}
		}
	}
}
