using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000119 RID: 281
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportConvergeRadioFromCSVRequest : global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest
	{
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x000AFE94 File Offset: 0x000AE094
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x000AFF44 File Offset: 0x000AE144
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1440415744;
				short num2 = num;
				num = (short)1166886803;
				short num3 = num;
				num = (short)1529628563;
				switch (num3 == num)
				{
				}
				num = (short)1432879104;
				if (num != 0)
				{
				}
				num = (short)577699841;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1309933568;
				short num2 = num;
				num = (short)829261529;
				short num3 = num;
				num = (short)1971488473;
				switch (num3 == num)
				{
				}
				num = (short)1431240704;
				if (num != 0)
				{
				}
				num = (short)992346113;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x000AFFF4 File Offset: 0x000AE1F4
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x000B00A0 File Offset: 0x000AE2A0
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string IMEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1707933696;
				short num2 = num;
				num = (short)1558500895;
				short num3 = num;
				num = (short)548722207;
				switch (num3 == num)
				{
				}
				num = (short)659030016;
				if (num != 0)
				{
				}
				num = (short)721354753;
				if (num != 0)
				{
				}
				return this.<IMEI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)75956224;
				short num2 = num;
				num = (short)1408307801;
				short num3 = num;
				num = (short)336990809;
				switch (num3 == num)
				{
				}
				num = (short)498532353;
				if (num != 0)
				{
				}
				num = (short)891486208;
				if (num != 0)
				{
				}
				this.<IMEI>k__BackingField = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x000B0154 File Offset: 0x000AE354
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x000B0204 File Offset: 0x000AE404
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string ProductIdentifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1023279104;
				short num2 = num;
				num = (short)1975650006;
				short num3 = num;
				num = (short)813369046;
				switch (num3 == num)
				{
				}
				num = (short)1493958657;
				if (num != 0)
				{
				}
				num = (short)1134755840;
				if (num != 0)
				{
				}
				return this.<ProductIdentifier>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)652279808;
				short num2 = num;
				num = (short)1189412865;
				if (num != 0)
				{
				}
				num = (short)890832074;
				short num3 = num;
				num = (short)129041610;
				switch (num3 == num)
				{
				}
				num = (short)243859456;
				if (num != 0)
				{
				}
				this.<ProductIdentifier>k__BackingField = value;
			}
		}
	}
}
