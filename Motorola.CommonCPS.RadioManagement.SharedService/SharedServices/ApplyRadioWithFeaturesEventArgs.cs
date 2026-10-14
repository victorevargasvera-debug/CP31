using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A6 RID: 166
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ApplyRadioWithFeaturesEventArgs : global::System.EventArgs
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x00075C0C File Offset: 0x00073E0C
		public ApplyRadioWithFeaturesEventArgs(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> radioLicenses, bool canUpgraded)
		{
			this.Radio = radio;
			this.RadioLicenses = radioLicenses;
			this.NewLicensesRequest = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>();
			this.CanUpgraded = canUpgraded;
			this.WarningCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00075C48 File Offset: 0x00073E48
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00075CF8 File Offset: 0x00073EF8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)441861870;
				short num2 = num;
				num = (short)1476740846;
				switch (num2 == num)
				{
				}
				num = (short)1254424576;
				short num3 = num;
				num = (short)840368129;
				if (num != 0)
				{
				}
				num = (short)1265565696;
				if (num != 0)
				{
				}
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1016204162;
				short num2 = num;
				num = (short)1552026498;
				switch (num2 == num)
				{
				}
				num = (short)1062404096;
				short num3 = num;
				num = (short)148373505;
				if (num != 0)
				{
				}
				num = (short)1257242624;
				if (num != 0)
				{
				}
				this.<Radio>k__BackingField = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00075DAC File Offset: 0x00073FAC
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00075E5C File Offset: 0x0007405C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> RadioLicenses
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1275248696;
				short num2 = num;
				num = (short)1560985656;
				switch (num2 == num)
				{
				}
				num = (short)1028390912;
				short num3 = num;
				num = (short)1542258688;
				if (num != 0)
				{
				}
				num = (short)535625729;
				if (num != 0)
				{
				}
				return this.<RadioLicenses>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1574900926;
				short num2 = num;
				num = (short)437589182;
				switch (num2 == num)
				{
				}
				num = (short)352583680;
				short num3 = num;
				num = (short)1057226752;
				if (num != 0)
				{
				}
				num = (short)11534337;
				if (num != 0)
				{
				}
				this.<RadioLicenses>k__BackingField = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00075F0C File Offset: 0x0007410C
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00075FB8 File Offset: 0x000741B8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> NewLicensesRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1634450984;
				short num2 = num;
				num = (short)2057616936;
				switch (num2 == num)
				{
				}
				num = (short)1166671872;
				short num3 = num;
				num = (short)389152769;
				if (num != 0)
				{
				}
				num = (short)570884096;
				if (num != 0)
				{
				}
				return this.<NewLicensesRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2086467659;
				short num2 = num;
				num = (short)336918603;
				switch (num2 == num)
				{
				}
				num = (short)259391488;
				short num3 = num;
				num = (short)807927809;
				if (num != 0)
				{
				}
				num = (short)1951662080;
				if (num != 0)
				{
				}
				this.<NewLicensesRequest>k__BackingField = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00076068 File Offset: 0x00074268
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00076118 File Offset: 0x00074318
		[global::System.Runtime.Serialization.DataMember]
		public bool CanUpgraded
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1537336422;
				short num2 = num;
				num = (short)1480516710;
				switch (num2 == num)
				{
				}
				num = (short)171835392;
				short num3 = num;
				num = (short)1331363840;
				if (num != 0)
				{
				}
				num = (short)1858994177;
				if (num != 0)
				{
				}
				return this.<CanUpgraded>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)824246273;
				if (num != 0)
				{
				}
				num = (short)766916802;
				short num2 = num;
				num = (short)155138242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421003264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644808704;
				if (num != 0)
				{
				}
				this.<CanUpgraded>k__BackingField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000761C8 File Offset: 0x000743C8
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00076278 File Offset: 0x00074478
		[global::System.Runtime.Serialization.DataMember]
		public bool AnyInvalid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1083196700;
				short num2 = num;
				num = (short)820528412;
				switch (num2 == num)
				{
				}
				num = (short)1573781504;
				short num3 = num;
				num = (short)375324673;
				if (num != 0)
				{
				}
				num = (short)1744502784;
				if (num != 0)
				{
				}
				return this.<AnyInvalid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)674420604;
				short num2 = num;
				num = (short)133683068;
				switch (num2 == num)
				{
				}
				num = (short)1291190272;
				short num3 = num;
				num = (short)254607361;
				if (num != 0)
				{
				}
				num = (short)461766656;
				if (num != 0)
				{
				}
				this.<AnyInvalid>k__BackingField = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0007632C File Offset: 0x0007452C
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x000763DC File Offset: 0x000745DC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode WarningCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1790168517;
				short num2 = num;
				num = (short)1402719685;
				switch (num2 == num)
				{
				}
				num = (short)1996161024;
				short num3 = num;
				num = (short)695140353;
				if (num != 0)
				{
				}
				num = (short)1369440256;
				if (num != 0)
				{
				}
				return this.<WarningCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1797160840;
				short num2 = num;
				num = (short)60850056;
				switch (num2 == num)
				{
				}
				num = (short)143196160;
				short num3 = num;
				num = (short)445448193;
				if (num != 0)
				{
				}
				num = (short)1820196864;
				if (num != 0)
				{
				}
				this.<WarningCode>k__BackingField = value;
			}
		}
	}
}
