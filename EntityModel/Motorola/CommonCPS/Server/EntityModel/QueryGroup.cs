using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000088 RID: 136
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class QueryGroup : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x06000A5A RID: 2650 RVA: 0x0006FB70 File Offset: 0x0006DD70
		public QueryGroup()
		{
			this.Queries = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary>();
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0006FB90 File Offset: 0x0006DD90
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0006FC44 File Offset: 0x0006DE44
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1835091269;
				short num2 = num;
				num = (short)260195653;
				switch (num2 == num)
				{
				}
				num = (short)455409664;
				short num3 = num;
				num = (short)2621441;
				if (num != 0)
				{
				}
				num = (short)893452288;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1974335488;
				short num2 = num;
				num = (short)967636992;
				switch (num2 == num)
				{
				}
				num = (short)68222976;
				short num3 = num;
				num = (short)1479213057;
				if (num != 0)
				{
				}
				num = (short)218824704;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0006FCF4 File Offset: 0x0006DEF4
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> Queries
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1560412161;
				if (num != 0)
				{
				}
				num = (short)476576818;
				short num2 = num;
				num = (short)1539505202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272105472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)493355008;
				if (num != 0)
				{
				}
				return this.<Queries>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)705133673;
				short num2 = num;
				num = (short)39222377;
				switch (num2 == num)
				{
				}
				num = (short)1160970240;
				short num3 = num;
				num = (short)2041053185;
				if (num != 0)
				{
				}
				num = (short)1683816448;
				if (num != 0)
				{
				}
				this.<Queries>k__BackingField = value;
			}
		}
	}
}
