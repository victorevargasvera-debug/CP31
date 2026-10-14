using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D6 RID: 214
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteTemplateBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00091ECC File Offset: 0x000900CC
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00091F78 File Offset: 0x00090178
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2045928077;
				short num2 = num;
				num = (short)834757261;
				switch (num2 == num)
				{
				}
				num = (short)1005977600;
				short num3 = num;
				num = (short)351338496;
				if (num != 0)
				{
				}
				num = (short)1456209921;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)832454672;
				short num2 = num;
				num = (short)1088176144;
				switch (num2 == num)
				{
				}
				num = (short)1831993344;
				short num3 = num;
				num = (short)1183776768;
				if (num != 0)
				{
				}
				num = (short)779747329;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00092028 File Offset: 0x00090228
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x000920D8 File Offset: 0x000902D8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)221184001;
				if (num != 0)
				{
				}
				num = (short)1730343676;
				short num2 = num;
				num = (short)560591612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)509804544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1630208000;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1946630669;
				short num2 = num;
				num = (short)429210125;
				switch (num2 == num)
				{
				}
				num = (short)90505216;
				short num3 = num;
				num = (short)217317377;
				if (num != 0)
				{
				}
				num = (short)1713242112;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00092188 File Offset: 0x00090388
		public DeleteTemplateBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.TemplateUuid = templateUuid;
			this.ValidateEntitySet = validateSet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteTemplate;
		}
	}
}
