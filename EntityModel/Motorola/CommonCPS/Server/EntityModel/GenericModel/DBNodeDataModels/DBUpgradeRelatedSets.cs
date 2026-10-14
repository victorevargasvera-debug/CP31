using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001E1 RID: 481
	[global::System.Serializable]
	public class DBUpgradeRelatedSets
	{
		// Token: 0x06001802 RID: 6146 RVA: 0x0010324C File Offset: 0x0010144C
		public DBUpgradeRelatedSets()
		{
			this.RelatedSets = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0010326C File Offset: 0x0010146C
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0010331C File Offset: 0x0010151C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> RelatedSets
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1807446731;
				short num2 = num;
				num = (short)120091339;
				switch (num2 == num)
				{
				}
				num = (short)1560215553;
				if (num != 0)
				{
				}
				num = (short)1704329216;
				if (num != 0)
				{
				}
				num = (short)77463552;
				short num3 = num;
				return this.<RelatedSets>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1855119776;
				short num2 = num;
				num = (short)785113504;
				switch (num2 == num)
				{
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				num = (short)560529409;
				if (num != 0)
				{
				}
				num = (short)439877632;
				short num3 = num;
				this.<RelatedSets>k__BackingField = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x001033CC File Offset: 0x001015CC
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x0010347C File Offset: 0x0010167C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.SetRelationshipType RelatedType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2038241635;
				short num2 = num;
				num = (short)1835866467;
				switch (num2 == num)
				{
				}
				num = (short)2145517569;
				if (num != 0)
				{
				}
				num = (short)418185216;
				if (num != 0)
				{
				}
				num = (short)242024448;
				short num3 = num;
				return this.<RelatedType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)10158081;
				if (num != 0)
				{
				}
				num = (short)1065147036;
				short num2 = num;
				num = (short)10082972;
				switch (num2 == num)
				{
				}
				num = (short)1192755200;
				if (num != 0)
				{
				}
				num = (short)685637632;
				short num3 = num;
				this.<RelatedType>k__BackingField = value;
			}
		}
	}
}
