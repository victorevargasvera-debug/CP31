using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000CE RID: 206
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationRadioFeatureParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00090E1C File Offset: 0x0008F01C
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00090ECC File Offset: 0x0008F0CC
		public global::Motorola.CommonCPS.Server.EntityModel.RadioFeature RadioFeature
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1190584971;
				short num2 = num;
				num = (short)1397875339;
				switch (num2 == num)
				{
				}
				num = (short)1394212865;
				if (num != 0)
				{
				}
				num = (short)547749888;
				short num3 = num;
				num = (short)549453824;
				if (num != 0)
				{
				}
				return this.<RadioFeature>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1431306241;
				if (num != 0)
				{
				}
				num = (short)744105485;
				short num2 = num;
				num = (short)663889421;
				switch (num2 == num)
				{
				}
				num = (short)13041664;
				short num3 = num;
				num = (short)2023620608;
				if (num != 0)
				{
				}
				this.<RadioFeature>k__BackingField = value;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00090F7C File Offset: 0x0008F17C
		public MigrationRadioFeatureParameter(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature feature, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.RadioFeature = feature;
			base.JobDescription = jobDescription;
		}
	}
}
