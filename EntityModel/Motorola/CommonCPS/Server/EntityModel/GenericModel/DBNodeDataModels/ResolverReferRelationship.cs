using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001DE RID: 478
	[global::System.Serializable]
	public class ResolverReferRelationship : global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverRelationship
	{
		// Token: 0x060017F5 RID: 6133 RVA: 0x00102AF0 File Offset: 0x00100CF0
		public ResolverReferRelationship()
		{
			base.RelationshipType = global::Motorola.CommonCPS.Server.CommonDBConstants.SetRelationshipType.Refer;
			this.ReferMappings = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.ReferMapping>();
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00102B18 File Offset: 0x00100D18
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00102BCC File Offset: 0x00100DCC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.ReferMapping> ReferMappings
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)931719700;
				short num2 = num;
				num = (short)1191635476;
				switch (num2 == num)
				{
				}
				num = (short)1537015809;
				if (num != 0)
				{
				}
				num = (short)1475149824;
				if (num != 0)
				{
				}
				num = (short)305922048;
				short num3 = num;
				return this.<ReferMappings>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1884946409;
				short num2 = num;
				num = (short)907411433;
				switch (num2 == num)
				{
				}
				num = (short)1359937536;
				if (num != 0)
				{
				}
				num = (short)517865473;
				if (num != 0)
				{
				}
				num = (short)1059520512;
				short num3 = num;
				this.<ReferMappings>k__BackingField = value;
			}
		}
	}
}
