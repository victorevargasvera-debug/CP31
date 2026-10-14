using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C4 RID: 196
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0008ECB8 File Offset: 0x0008CEB8
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0008ED68 File Offset: 0x0008CF68
		public global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobContainer JobContainerInstence
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)5321018;
				short num2 = num;
				num = (short)314257722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047003136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174077441;
				if (num != 0)
				{
				}
				num = (short)389152768;
				if (num != 0)
				{
				}
				return this.<JobContainerInstence>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)56737445;
				short num2 = num;
				num = (short)1431879333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1218641920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479526912;
				if (num != 0)
				{
				}
				num = (short)1887305729;
				if (num != 0)
				{
				}
				this.<JobContainerInstence>k__BackingField = value;
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0008EE18 File Offset: 0x0008D018
		public MigrateJobParameter() : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
		}
	}
}
