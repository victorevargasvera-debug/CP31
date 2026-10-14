using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000472 RID: 1138
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class EdmRelationshipAttribute : global::System.Attribute
	{
		// Token: 0x060037B5 RID: 14261 RVA: 0x000B5904 File Offset: 0x000B3B04
		public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity role1Multiplicity, global::System.Type role1Type, string role2Name, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity role2Multiplicity, global::System.Type role2Type)
		{
			this._relationshipNamespaceName = relationshipNamespaceName;
			this._relationshipName = relationshipName;
			this._role1Name = role1Name;
			this._role1Multiplicity = role1Multiplicity;
			this._role1Type = role1Type;
			this._role2Name = role2Name;
			this._role2Multiplicity = role2Multiplicity;
			this._role2Type = role2Type;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x000B5954 File Offset: 0x000B3B54
		public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity role1Multiplicity, global::System.Type role1Type, string role2Name, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity role2Multiplicity, global::System.Type role2Type, bool isForeignKey)
		{
			this._relationshipNamespaceName = relationshipNamespaceName;
			this._relationshipName = relationshipName;
			this._role1Name = role1Name;
			this._role1Multiplicity = role1Multiplicity;
			this._role1Type = role1Type;
			this._role2Name = role2Name;
			this._role2Multiplicity = role2Multiplicity;
			this._role2Type = role2Type;
			this._isForeignKey = isForeignKey;
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x000B59AC File Offset: 0x000B3BAC
		public string RelationshipNamespaceName
		{
			get
			{
				return this._relationshipNamespaceName;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000B59B4 File Offset: 0x000B3BB4
		public string RelationshipName
		{
			get
			{
				return this._relationshipName;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x000B59BC File Offset: 0x000B3BBC
		public string Role1Name
		{
			get
			{
				return this._role1Name;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x000B59C4 File Offset: 0x000B3BC4
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity Role1Multiplicity
		{
			get
			{
				return this._role1Multiplicity;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x000B59CC File Offset: 0x000B3BCC
		public global::System.Type Role1Type
		{
			get
			{
				return this._role1Type;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x000B59D4 File Offset: 0x000B3BD4
		public string Role2Name
		{
			get
			{
				return this._role2Name;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x000B59DC File Offset: 0x000B3BDC
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity Role2Multiplicity
		{
			get
			{
				return this._role2Multiplicity;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x000B59E4 File Offset: 0x000B3BE4
		public global::System.Type Role2Type
		{
			get
			{
				return this._role2Type;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x000B59EC File Offset: 0x000B3BEC
		public bool IsForeignKey
		{
			get
			{
				return this._isForeignKey;
			}
		}

		// Token: 0x040012D6 RID: 4822
		private readonly string _relationshipNamespaceName;

		// Token: 0x040012D7 RID: 4823
		private readonly string _relationshipName;

		// Token: 0x040012D8 RID: 4824
		private readonly string _role1Name;

		// Token: 0x040012D9 RID: 4825
		private readonly string _role2Name;

		// Token: 0x040012DA RID: 4826
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity _role1Multiplicity;

		// Token: 0x040012DB RID: 4827
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity _role2Multiplicity;

		// Token: 0x040012DC RID: 4828
		private readonly global::System.Type _role1Type;

		// Token: 0x040012DD RID: 4829
		private readonly global::System.Type _role2Type;

		// Token: 0x040012DE RID: 4830
		private readonly bool _isForeignKey;
	}
}
