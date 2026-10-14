using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D4 RID: 212
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteRadioBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00091A48 File Offset: 0x0008FC48
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00091AF8 File Offset: 0x0008FCF8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1076127454;
				short num2 = num;
				num = (short)590767838;
				switch (num2 == num)
				{
				}
				num = (short)923467776;
				short num3 = num;
				num = (short)1931870209;
				if (num != 0)
				{
				}
				num = (short)556007424;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2011303359;
				short num2 = num;
				num = (short)1871777215;
				switch (num2 == num)
				{
				}
				num = (short)1715273728;
				short num3 = num;
				num = (short)360710145;
				if (num != 0)
				{
				}
				num = (short)222429184;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00091BA4 File Offset: 0x0008FDA4
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00091C58 File Offset: 0x0008FE58
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)626407445;
				short num2 = num;
				num = (short)156514325;
				switch (num2 == num)
				{
				}
				num = (short)288161792;
				short num3 = num;
				num = (short)1351024641;
				if (num != 0)
				{
				}
				num = (short)480313344;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1743783673;
				short num2 = num;
				num = (short)619448057;
				switch (num2 == num)
				{
				}
				num = (short)1376845824;
				short num3 = num;
				num = (short)1031077889;
				if (num != 0)
				{
				}
				num = (short)1978597376;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00091D08 File Offset: 0x0008FF08
		public DeleteRadioBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.ValidateEntitySet = validateSet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteRadios;
		}
	}
}
