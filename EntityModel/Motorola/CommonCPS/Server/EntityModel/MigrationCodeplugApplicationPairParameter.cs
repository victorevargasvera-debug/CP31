using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000CC RID: 204
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationCodeplugApplicationPairParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00090B0C File Offset: 0x0008ED0C
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00090BBC File Offset: 0x0008EDBC
		public global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.PBBApplication> CodeplugApplicationPair
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1642659841;
				if (num != 0)
				{
				}
				num = (short)342293309;
				short num2 = num;
				num = (short)325647165;
				switch (num2 == num)
				{
				}
				num = (short)1586429952;
				short num3 = num;
				num = (short)1512701952;
				if (num != 0)
				{
				}
				return this.<CodeplugApplicationPair>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1598335450;
				short num2 = num;
				num = (short)1507830234;
				switch (num2 == num)
				{
				}
				num = (short)668991489;
				if (num != 0)
				{
				}
				num = (short)1594753024;
				short num3 = num;
				num = (short)1228275712;
				if (num != 0)
				{
				}
				this.<CodeplugApplicationPair>k__BackingField = value;
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00090C6C File Offset: 0x0008EE6C
		public MigrationCodeplugApplicationPairParameter(global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.PBBApplication> kvp, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.CodeplugApplicationPair = kvp;
			base.JobDescription = jobDescription;
		}
	}
}
