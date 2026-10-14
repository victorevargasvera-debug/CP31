using System;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000471 RID: 1137
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	public sealed class EdmRelationshipNavigationPropertyAttribute : global::System.Data.Entity.Core.Objects.DataClasses.EdmPropertyAttribute
	{
		// Token: 0x060037B1 RID: 14257 RVA: 0x000B58CE File Offset: 0x000B3ACE
		public EdmRelationshipNavigationPropertyAttribute(string relationshipNamespaceName, string relationshipName, string targetRoleName)
		{
			this._relationshipNamespaceName = relationshipNamespaceName;
			this._relationshipName = relationshipName;
			this._targetRoleName = targetRoleName;
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x000B58EB File Offset: 0x000B3AEB
		public string RelationshipNamespaceName
		{
			get
			{
				return this._relationshipNamespaceName;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x000B58F3 File Offset: 0x000B3AF3
		public string RelationshipName
		{
			get
			{
				return this._relationshipName;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x000B58FB File Offset: 0x000B3AFB
		public string TargetRoleName
		{
			get
			{
				return this._targetRoleName;
			}
		}

		// Token: 0x040012D3 RID: 4819
		private readonly string _relationshipNamespaceName;

		// Token: 0x040012D4 RID: 4820
		private readonly string _relationshipName;

		// Token: 0x040012D5 RID: 4821
		private readonly string _targetRoleName;
	}
}
