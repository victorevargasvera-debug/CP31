using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B4 RID: 180
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ApplyMVOBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0008B6C4 File Offset: 0x000898C4
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0008B774 File Offset: 0x00089974
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)331738275;
				short num2 = num;
				num = (short)2022239395;
				switch (num2 == num)
				{
				}
				num = (short)1529610241;
				if (num != 0)
				{
				}
				num = (short)2054029312;
				short num3 = num;
				num = (short)1713373184;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)229836966;
				short num2 = num;
				num = (short)706742438;
				switch (num2 == num)
				{
				}
				num = (short)704839681;
				if (num != 0)
				{
				}
				num = (short)119799808;
				short num3 = num;
				num = (short)394985472;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0008B828 File Offset: 0x00089A28
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0008B8D8 File Offset: 0x00089AD8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> DefaultValues
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1783843319;
				short num2 = num;
				num = (short)553667063;
				switch (num2 == num)
				{
				}
				num = (short)1267007489;
				if (num != 0)
				{
				}
				num = (short)838533120;
				short num3 = num;
				num = (short)1641873408;
				if (num != 0)
				{
				}
				return this.<DefaultValues>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1624011582;
				short num2 = num;
				num = (short)1280340798;
				switch (num2 == num)
				{
				}
				num = (short)926679041;
				if (num != 0)
				{
				}
				num = (short)257294336;
				short num3 = num;
				num = (short)1906376704;
				if (num != 0)
				{
				}
				this.<DefaultValues>k__BackingField = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0008B988 File Offset: 0x00089B88
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x0008BA38 File Offset: 0x00089C38
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySets
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)802149117;
				short num2 = num;
				num = (short)392680189;
				switch (num2 == num)
				{
				}
				num = (short)1555234817;
				if (num != 0)
				{
				}
				num = (short)594345984;
				short num3 = num;
				num = (short)1484914688;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySets>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1059801701;
				short num2 = num;
				num = (short)2093828709;
				switch (num2 == num)
				{
				}
				num = (short)1102970881;
				if (num != 0)
				{
				}
				num = (short)346554368;
				short num3 = num;
				num = (short)1367015424;
				if (num != 0)
				{
				}
				this.<ValidateEntitySets>k__BackingField = value;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0008BAE8 File Offset: 0x00089CE8
		public ApplyMVOBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> defaultValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSets) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.ValidateEntitySets = validateSets;
			this.DefaultValues = defaultValues;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyMVO;
		}
	}
}
