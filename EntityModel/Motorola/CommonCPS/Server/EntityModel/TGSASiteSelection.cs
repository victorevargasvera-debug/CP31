using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200009D RID: 157
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class TGSASiteSelection : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00082038 File Offset: 0x00080238
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x000820E8 File Offset: 0x000802E8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid SystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1194688631;
				short num2 = num;
				num = (short)1682800759;
				switch (num2 == num)
				{
				}
				num = (short)465764353;
				if (num != 0)
				{
				}
				num = (short)163840000;
				if (num != 0)
				{
				}
				num = (short)1206714368;
				short num3 = num;
				return this.<SystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1903510728;
				short num2 = num;
				num = (short)405226696;
				switch (num2 == num)
				{
				}
				num = (short)118030336;
				if (num != 0)
				{
				}
				num = (short)1551564801;
				if (num != 0)
				{
				}
				num = (short)1929052160;
				short num3 = num;
				this.<SystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00082198 File Offset: 0x00080398
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00082248 File Offset: 0x00080448
		[global::System.Runtime.Serialization.DataMember]
		public string TGSASiteSelName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1026673843;
				short num2 = num;
				num = (short)677366963;
				switch (num2 == num)
				{
				}
				num = (short)1425866753;
				if (num != 0)
				{
				}
				num = (short)1472724992;
				if (num != 0)
				{
				}
				num = (short)907214848;
				short num3 = num;
				return this.<TGSASiteSelName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1121073071;
				short num2 = num;
				num = (short)1888106415;
				switch (num2 == num)
				{
				}
				num = (short)607518721;
				if (num != 0)
				{
				}
				num = (short)1111425024;
				if (num != 0)
				{
				}
				num = (short)1421737984;
				short num3 = num;
				this.<TGSASiteSelName>k__BackingField = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000822F8 File Offset: 0x000804F8
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x000823A8 File Offset: 0x000805A8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.SiteSelectionChangeType ChangeType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1180863229;
				short num2 = num;
				num = (short)818121469;
				switch (num2 == num)
				{
				}
				num = (short)677969921;
				if (num != 0)
				{
				}
				num = (short)590217216;
				if (num != 0)
				{
				}
				num = (short)501022720;
				short num3 = num;
				return this.<ChangeType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1076132919;
				short num2 = num;
				num = (short)317619255;
				switch (num2 == num)
				{
				}
				num = (short)772145152;
				if (num != 0)
				{
				}
				num = (short)1928790017;
				if (num != 0)
				{
				}
				num = (short)1928855552;
				short num3 = num;
				this.<ChangeType>k__BackingField = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00082458 File Offset: 0x00080658
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00082504 File Offset: 0x00080704
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASelSite> AvailableSites
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1867898707;
				short num2 = num;
				num = (short)1321066323;
				switch (num2 == num)
				{
				}
				num = (short)1920401409;
				if (num != 0)
				{
				}
				num = (short)153092096;
				if (num != 0)
				{
				}
				num = (short)444989440;
				short num3 = num;
				return this.<AvailableSites>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1590838083;
				short num2 = num;
				num = (short)1906131779;
				switch (num2 == num)
				{
				}
				num = (short)534380545;
				if (num != 0)
				{
				}
				num = (short)30932992;
				if (num != 0)
				{
				}
				num = (short)1498087424;
				short num3 = num;
				this.<AvailableSites>k__BackingField = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x000825B4 File Offset: 0x000807B4
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x00082664 File Offset: 0x00080864
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> TGSARecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1579811268;
				short num2 = num;
				num = (short)1201930692;
				switch (num2 == num)
				{
				}
				num = (short)458358784;
				if (num != 0)
				{
				}
				num = (short)834600961;
				if (num != 0)
				{
				}
				num = (short)928448512;
				short num3 = num;
				return this.<TGSARecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1943213862;
				short num2 = num;
				num = (short)1102976806;
				switch (num2 == num)
				{
				}
				num = (short)1540554753;
				if (num != 0)
				{
				}
				num = (short)638255104;
				if (num != 0)
				{
				}
				num = (short)998834176;
				short num3 = num;
				this.<TGSARecords>k__BackingField = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00082710 File Offset: 0x00080910
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x000827C0 File Offset: 0x000809C0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASelSite> TGSASelSites
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)127526739;
				short num2 = num;
				num = (short)572581715;
				switch (num2 == num)
				{
				}
				num = (short)1891631105;
				if (num != 0)
				{
				}
				num = (short)1222705152;
				if (num != 0)
				{
				}
				num = (short)539230208;
				short num3 = num;
				return this.<TGSASelSites>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1785942062;
				short num2 = num;
				num = (short)1458065454;
				switch (num2 == num)
				{
				}
				num = (short)1768292353;
				if (num != 0)
				{
				}
				num = (short)1701904384;
				if (num != 0)
				{
				}
				num = (short)810549248;
				short num3 = num;
				this.<TGSASelSites>k__BackingField = value;
			}
		}
	}
}
