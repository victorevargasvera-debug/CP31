using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B3 RID: 179
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ApplyIPProgramSystemBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x06000CF1 RID: 3313 RVA: 0x0008B250 File Offset: 0x00089450
		public ApplyIPProgramSystemBatchJobParameter() : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0008B268 File Offset: 0x00089468
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x0008B318 File Offset: 0x00089518
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid IPProgramSystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1170913714;
				short num2 = num;
				num = (short)1849997746;
				switch (num2 == num)
				{
				}
				num = (short)1811742721;
				if (num != 0)
				{
				}
				num = (short)918290432;
				short num3 = num;
				num = (short)947847168;
				if (num != 0)
				{
				}
				return this.<IPProgramSystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)883912198;
				short num2 = num;
				num = (short)137457158;
				switch (num2 == num)
				{
				}
				num = (short)184549377;
				if (num != 0)
				{
				}
				num = (short)1167720448;
				short num3 = num;
				num = (short)72744960;
				if (num != 0)
				{
				}
				this.<IPProgramSystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0008B3C8 File Offset: 0x000895C8
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0008B478 File Offset: 0x00089678
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyIPProgramSystem RadioInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)639837762;
				short num2 = num;
				num = (short)1437738562;
				switch (num2 == num)
				{
				}
				num = (short)615120896;
				if (num != 0)
				{
				}
				num = (short)1839333376;
				short num3 = num;
				num = (short)1579024385;
				if (num != 0)
				{
				}
				return this.<RadioInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)846080328;
				short num2 = num;
				num = (short)677718344;
				switch (num2 == num)
				{
				}
				num = (short)718733313;
				if (num != 0)
				{
				}
				num = (short)226820096;
				short num3 = num;
				num = (short)1457848320;
				if (num != 0)
				{
				}
				this.<RadioInfo>k__BackingField = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0008B524 File Offset: 0x00089724
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0008B5D4 File Offset: 0x000897D4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2122186753;
				if (num != 0)
				{
				}
				num = (short)34911949;
				short num2 = num;
				num = (short)65976013;
				switch (num2 == num)
				{
				}
				num = (short)348520448;
				short num3 = num;
				num = (short)382074880;
				if (num != 0)
				{
				}
				return this.<ValidateSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1629367779;
				short num2 = num;
				num = (short)428879331;
				switch (num2 == num)
				{
				}
				num = (short)394330112;
				if (num != 0)
				{
				}
				num = (short)556138496;
				short num3 = num;
				num = (short)765591553;
				if (num != 0)
				{
				}
				this.<ValidateSet>k__BackingField = value;
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0008B684 File Offset: 0x00089884
		public ApplyIPProgramSystemBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid ipProgramSystemUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyIPProgramSystem radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.IPProgramSystemUuid = ipProgramSystemUuid;
			this.RadioInfo = radioInfo;
			this.ValidateSet = validateSet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyIPProgramSystem;
		}
	}
}
