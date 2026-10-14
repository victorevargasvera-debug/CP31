using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000043 RID: 67
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ChangedRecord
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000420E4 File Offset: 0x000402E4
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00042198 File Offset: 0x00040398
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2100494337;
				if (num != 0)
				{
				}
				num = (short)1255414799;
				short num2 = num;
				num = (short)500177935;
				switch (num2 == num)
				{
				}
				num = (short)1747779584;
				short num3 = num;
				num = (short)457900032;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)76218369;
				if (num != 0)
				{
				}
				num = (short)1099517736;
				short num2 = num;
				num = (short)254103336;
				switch (num2 == num)
				{
				}
				num = (short)515178496;
				short num3 = num;
				num = (short)1341194240;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0004224C File Offset: 0x0004044C
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000422F8 File Offset: 0x000404F8
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1042932074;
				short num2 = num;
				num = (short)1428808042;
				switch (num2 == num)
				{
				}
				num = (short)1909194753;
				if (num != 0)
				{
				}
				num = (short)1340014592;
				short num3 = num;
				num = (short)1913126912;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1498972378;
				short num2 = num;
				num = (short)374112474;
				switch (num2 == num)
				{
				}
				num = (short)36372480;
				if (num != 0)
				{
				}
				num = (short)1144455168;
				short num3 = num;
				num = (short)48496641;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000423A8 File Offset: 0x000405A8
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00042458 File Offset: 0x00040658
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, string> ProductFamilyVersions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1859827080;
				short num2 = num;
				num = (short)1016051080;
				switch (num2 == num)
				{
				}
				num = (short)666828801;
				if (num != 0)
				{
				}
				num = (short)1570177024;
				short num3 = num;
				num = (short)268107776;
				if (num != 0)
				{
				}
				return this.<ProductFamilyVersions>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1328676865;
				if (num != 0)
				{
				}
				num = (short)91052638;
				short num2 = num;
				num = (short)1921342046;
				switch (num2 == num)
				{
				}
				num = (short)1793589248;
				short num3 = num;
				num = (short)1625948160;
				if (num != 0)
				{
				}
				this.<ProductFamilyVersions>k__BackingField = value;
			}
		}
	}
}
