using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000CA RID: 202
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateTTSParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000907FC File Offset: 0x0008E9FC
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x000908AC File Offset: 0x0008EAAC
		public global::Motorola.CommonCPS.Server.EntityModel.Package TTS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)101122704;
				short num2 = num;
				num = (short)2037580432;
				switch (num2 == num)
				{
				}
				num = (short)1331494913;
				if (num != 0)
				{
				}
				num = (short)934477824;
				short num3 = num;
				num = (short)1489305600;
				if (num != 0)
				{
				}
				return this.<TTS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)616213109;
				short num2 = num;
				num = (short)274639477;
				switch (num2 == num)
				{
				}
				num = (short)256966657;
				if (num != 0)
				{
				}
				num = (short)1393426432;
				short num3 = num;
				num = (short)1225064448;
				if (num != 0)
				{
				}
				this.<TTS>k__BackingField = value;
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0009095C File Offset: 0x0008EB5C
		public MigrateTTSParameter(global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.TTS = package;
			base.JobDescription = jobDescription;
		}
	}
}
