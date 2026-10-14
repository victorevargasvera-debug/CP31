using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000058 RID: 88
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class JobStatisticConfig
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00049C10 File Offset: 0x00047E10
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00049CC0 File Offset: 0x00047EC0
		[global::System.ComponentModel.DataAnnotations.Key]
		[global::System.Runtime.Serialization.DataMember]
		public bool EnableJobLog
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)75630769;
				short num2 = num;
				num = (short)1850542257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1980563456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1214709761;
				if (num != 0)
				{
				}
				num = (short)354549760;
				if (num != 0)
				{
				}
				return this.<EnableJobLog>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)978650215;
				short num2 = num;
				num = (short)908788839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)611581952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)910229505;
				if (num != 0)
				{
				}
				num = (short)1870462976;
				if (num != 0)
				{
				}
				this.<EnableJobLog>k__BackingField = value;
			}
		}
	}
}
