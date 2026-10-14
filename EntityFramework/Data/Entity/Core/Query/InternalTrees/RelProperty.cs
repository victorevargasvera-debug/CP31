using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D5 RID: 981
	internal sealed class RelProperty
	{
		// Token: 0x06002EBF RID: 11967 RVA: 0x00093ED6 File Offset: 0x000920D6
		internal RelProperty(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd)
		{
			this.m_relationshipType = relationshipType;
			this.m_fromEnd = fromEnd;
			this.m_toEnd = toEnd;
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x00093EF3 File Offset: 0x000920F3
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipType Relationship
		{
			get
			{
				return this.m_relationshipType;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x00093EFB File Offset: 0x000920FB
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember FromEnd
		{
			get
			{
				return this.m_fromEnd;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00093F03 File Offset: 0x00092103
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember ToEnd
		{
			get
			{
				return this.m_toEnd;
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00093F0C File Offset: 0x0009210C
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty = obj as global::System.Data.Entity.Core.Query.InternalTrees.RelProperty;
			return relProperty != null && this.Relationship.EdmEquals(relProperty.Relationship) && this.FromEnd.EdmEquals(relProperty.FromEnd) && this.ToEnd.EdmEquals(relProperty.ToEnd);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00093F5C File Offset: 0x0009215C
		public override int GetHashCode()
		{
			return this.ToEnd.Identity.GetHashCode();
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00093F70 File Offset: 0x00092170
		[global::System.Diagnostics.DebuggerNonUserCode]
		public override string ToString()
		{
			string[] array = new string[5];
			int num = 0;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType = this.m_relationshipType;
			array[num] = ((relationshipType != null) ? relationshipType.ToString() : null);
			array[1] = ":";
			int num2 = 2;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd = this.m_fromEnd;
			array[num2] = ((fromEnd != null) ? fromEnd.ToString() : null);
			array[3] = ":";
			int num3 = 4;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd = this.m_toEnd;
			array[num3] = ((toEnd != null) ? toEnd.ToString() : null);
			return string.Concat(array);
		}

		// Token: 0x04000FC3 RID: 4035
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipType m_relationshipType;

		// Token: 0x04000FC4 RID: 4036
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember m_fromEnd;

		// Token: 0x04000FC5 RID: 4037
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember m_toEnd;
	}
}
