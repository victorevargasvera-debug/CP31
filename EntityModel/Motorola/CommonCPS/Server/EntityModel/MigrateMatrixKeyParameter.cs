using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C6 RID: 198
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateMatrixKeyParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0008EFB8 File Offset: 0x0008D1B8
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0008F068 File Offset: 0x0008D268
		public global::Motorola.CommonCPS.Server.EntityModel.MatrixKey matrixKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)449451548;
				short num2 = num;
				num = (short)1548621340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1475411968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950285825;
				if (num != 0)
				{
				}
				num = (short)111017984;
				if (num != 0)
				{
				}
				return this.<matrixKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1124401153;
				if (num != 0)
				{
				}
				num = (short)1283194880;
				short num2 = num;
				num = (short)1024388584;
				short num3 = num;
				num = (short)250211816;
				switch (num3 == num)
				{
				}
				num = (short)1439563776;
				if (num != 0)
				{
				}
				this.<matrixKey>k__BackingField = value;
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0008F118 File Offset: 0x0008D318
		public MigrateMatrixKeyParameter(global::Motorola.CommonCPS.Server.EntityModel.MatrixKey matrixkey, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.matrixKey = matrixkey;
			base.JobDescription = jobDescription;
		}
	}
}
