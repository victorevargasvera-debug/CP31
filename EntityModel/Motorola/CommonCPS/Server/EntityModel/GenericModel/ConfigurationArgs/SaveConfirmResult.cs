using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs
{
	// Token: 0x020001F4 RID: 500
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SaveConfirmResult
	{
		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0010ACB0 File Offset: 0x00108EB0
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0010AD5C File Offset: 0x00108F5C
		[global::System.Runtime.Serialization.DataMember]
		public bool CanToSave
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)110297089;
				if (num != 0)
				{
				}
				num = (short)1973222550;
				short num2 = num;
				num = (short)1487010966;
				switch (num2 == num)
				{
				}
				num = (short)1078525952;
				short num3 = num;
				num = (short)1232994304;
				if (num != 0)
				{
				}
				return this.<CanToSave>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2024472577;
				if (num != 0)
				{
				}
				num = (short)747195227;
				short num2 = num;
				num = (short)429280091;
				switch (num2 == num)
				{
				}
				num = (short)1028915200;
				short num3 = num;
				num = (short)1742798848;
				if (num != 0)
				{
				}
				this.<CanToSave>k__BackingField = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0010AE0C File Offset: 0x0010900C
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0010AEBC File Offset: 0x001090BC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary, global::Motorola.CommonCPS.Server.CommonDBConstants.ConfigurationStatus>> ImpactedConfigurations
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)93192193;
				if (num != 0)
				{
				}
				num = (short)984268270;
				short num2 = num;
				num = (short)1658306030;
				switch (num2 == num)
				{
				}
				num = (short)159973376;
				short num3 = num;
				num = (short)1925251072;
				if (num != 0)
				{
				}
				return this.<ImpactedConfigurations>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1240399873;
				if (num != 0)
				{
				}
				num = (short)1226680641;
				short num2 = num;
				num = (short)715565377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371471872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125332480;
				if (num != 0)
				{
				}
				this.<ImpactedConfigurations>k__BackingField = value;
			}
		}
	}
}
