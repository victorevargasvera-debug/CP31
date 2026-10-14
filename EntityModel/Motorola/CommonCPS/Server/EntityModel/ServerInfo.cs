using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000186 RID: 390
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ServerInfo
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000DFC10 File Offset: 0x000DDE10
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x000DFCC0 File Offset: 0x000DDEC0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ServerVersion ServerVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1495254140;
				short num2 = num;
				num = (short)173655164;
				switch (num2 == num)
				{
				}
				num = (short)960954368;
				if (num != 0)
				{
				}
				num = (short)1310916609;
				if (num != 0)
				{
				}
				num = (short)1631715328;
				short num3 = num;
				return this.<ServerVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1191182337;
				if (num != 0)
				{
				}
				num = (short)1458749552;
				short num2 = num;
				num = (short)1280360560;
				switch (num2 == num)
				{
				}
				num = (short)953942016;
				if (num != 0)
				{
				}
				num = (short)228720640;
				short num3 = num;
				this.<ServerVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x000DFD70 File Offset: 0x000DDF70
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x000DFE24 File Offset: 0x000DE024
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo MigrationRecord
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1673723905;
				if (num != 0)
				{
				}
				num = (short)480484022;
				short num2 = num;
				num = (short)1140300470;
				switch (num2 == num)
				{
				}
				num = (short)938672128;
				if (num != 0)
				{
				}
				num = (short)1379401728;
				short num3 = num;
				return this.<MigrationRecord>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)539696106;
				short num2 = num;
				num = (short)1923488746;
				switch (num2 == num)
				{
				}
				num = (short)240320513;
				if (num != 0)
				{
				}
				num = (short)1354366976;
				if (num != 0)
				{
				}
				num = (short)2133327872;
				short num3 = num;
				this.<MigrationRecord>k__BackingField = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000DFED4 File Offset: 0x000DE0D4
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x000DFF84 File Offset: 0x000DE184
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeVersionInfo DBUpgradeVersionInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)379198213;
				short num2 = num;
				num = (short)1845828357;
				switch (num2 == num)
				{
				}
				num = (short)1806303233;
				if (num != 0)
				{
				}
				num = (short)1449459712;
				if (num != 0)
				{
				}
				num = (short)139722752;
				short num3 = num;
				return this.<DBUpgradeVersionInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1549860865;
				if (num != 0)
				{
				}
				num = (short)56033001;
				short num2 = num;
				num = (short)2032074473;
				switch (num2 == num)
				{
				}
				num = (short)2144272384;
				if (num != 0)
				{
				}
				num = (short)1066663936;
				short num3 = num;
				this.<DBUpgradeVersionInfo>k__BackingField = value;
			}
		}
	}
}
