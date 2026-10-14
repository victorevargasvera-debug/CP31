using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C5 RID: 197
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateLPParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0008EE30 File Offset: 0x0008D030
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x0008EEE0 File Offset: 0x0008D0E0
		public global::Motorola.CommonCPS.Server.EntityModel.Package LP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2044081940;
				short num2 = num;
				num = (short)195901204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1790967808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1764032512;
				if (num != 0)
				{
				}
				num = (short)1782644737;
				if (num != 0)
				{
				}
				return this.<LP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)933790023;
				short num2 = num;
				num = (short)1365344583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1776943104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)178716673;
				if (num != 0)
				{
				}
				num = (short)1714946048;
				if (num != 0)
				{
				}
				this.<LP>k__BackingField = value;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0008EF90 File Offset: 0x0008D190
		public MigrateLPParameter(global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.LP = package;
			base.JobDescription = jobDescription;
		}
	}
}
