using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000CB RID: 203
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateVAParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00090984 File Offset: 0x0008EB84
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00090A34 File Offset: 0x0008EC34
		public global::Motorola.CommonCPS.Server.EntityModel.Package VA
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)701443376;
				short num2 = num;
				num = (short)1033448752;
				switch (num2 == num)
				{
				}
				num = (short)213319681;
				if (num != 0)
				{
				}
				num = (short)1481441280;
				short num3 = num;
				num = (short)663814144;
				if (num != 0)
				{
				}
				return this.<VA>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1997909171;
				short num2 = num;
				num = (short)946711731;
				switch (num2 == num)
				{
				}
				num = (short)618463232;
				if (num != 0)
				{
				}
				num = (short)1569521664;
				short num3 = num;
				num = (short)184614913;
				if (num != 0)
				{
				}
				this.<VA>k__BackingField = value;
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00090AE4 File Offset: 0x0008ECE4
		public MigrateVAParameter(global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.VA = package;
			base.JobDescription = jobDescription;
		}
	}
}
