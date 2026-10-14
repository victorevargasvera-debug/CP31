using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001DF RID: 479
	[global::System.Serializable]
	public class ResolverSameConfigRelationship : global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverRelationship
	{
		// Token: 0x060017F8 RID: 6136 RVA: 0x00102C7C File Offset: 0x00100E7C
		public ResolverSameConfigRelationship()
		{
			base.RelationshipType = global::Motorola.CommonCPS.Server.CommonDBConstants.SetRelationshipType.SameConfig;
			this.RelatedSets = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00102CA4 File Offset: 0x00100EA4
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x00102D54 File Offset: 0x00100F54
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> RelatedSets
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1106600170;
				short num2 = num;
				num = (short)1684562154;
				switch (num2 == num)
				{
				}
				num = (short)1641807873;
				if (num != 0)
				{
				}
				num = (short)1786576896;
				if (num != 0)
				{
				}
				num = (short)1670905856;
				short num3 = num;
				return this.<RelatedSets>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)35801943;
				short num2 = num;
				num = (short)1284524887;
				switch (num2 == num)
				{
				}
				num = (short)1527971841;
				if (num != 0)
				{
				}
				num = (short)1956904960;
				if (num != 0)
				{
				}
				num = (short)1660223488;
				short num3 = num;
				this.<RelatedSets>k__BackingField = value;
			}
		}
	}
}
