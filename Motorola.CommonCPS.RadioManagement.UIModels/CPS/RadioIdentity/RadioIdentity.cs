using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity
{
	// Token: 0x020000FE RID: 254
	public class RadioIdentity
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x000BCCB0 File Offset: 0x000BAEB0
		public RadioIdentity(string set, string fieldId, string pbaFieldId, global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType feature = global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType.None)
		{
			this.a = set;
			this.b = fieldId;
			this.d = pbaFieldId;
			this.c = feature;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x000BCCE0 File Offset: 0x000BAEE0
		public string Set
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)773783552;
				short num2 = num;
				num = (short)1266089985;
				if (num != 0)
				{
				}
				num = (short)2026191114;
				short num3 = num;
				num = (short)1250572554;
				switch (num3 == num)
				{
				}
				num = (short)1768882176;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x000BCD90 File Offset: 0x000BAF90
		public string FieldId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1378549760;
				short num2 = num;
				num = (short)911374737;
				short num3 = num;
				num = (short)963803537;
				switch (num3 == num)
				{
				}
				num = (short)1960902657;
				if (num != 0)
				{
				}
				num = (short)1113325568;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000BCE40 File Offset: 0x000BB040
		public global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType Feature
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)472252416;
				short num2 = num;
				num = (short)1735330293;
				short num3 = num;
				num = (short)630458869;
				switch (num3 == num)
				{
				}
				num = (short)442302464;
				if (num != 0)
				{
				}
				num = (short)521994241;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000BCEF4 File Offset: 0x000BB0F4
		public string PbaFieldId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)258080768;
				short num2 = num;
				num = (short)1726341382;
				short num3 = num;
				num = (short)1809047814;
				switch (num3 == num)
				{
				}
				num = (short)511639553;
				if (num != 0)
				{
				}
				num = (short)739311616;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x04000468 RID: 1128
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x04000469 RID: 1129
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;

		// Token: 0x0400046A RID: 1130
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.CPS.RadioIdentity.RadioIdentityFeatureType c;

		// Token: 0x0400046B RID: 1131
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string d;
	}
}
