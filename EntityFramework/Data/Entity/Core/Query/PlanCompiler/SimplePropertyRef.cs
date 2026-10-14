using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000366 RID: 870
	internal class SimplePropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x06002A4C RID: 10828 RVA: 0x0008951C File Offset: 0x0008771C
		internal SimplePropertyRef(global::System.Data.Entity.Core.Metadata.Edm.EdmMember property)
		{
			this.m_property = property;
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0008952B File Offset: 0x0008772B
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember Property
		{
			get
			{
				return this.m_property;
			}
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00089534 File Offset: 0x00087734
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef simplePropertyRef = obj as global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef;
			return simplePropertyRef != null && global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(this.m_property.DeclaringType, simplePropertyRef.m_property.DeclaringType) && simplePropertyRef.m_property.Name.Equals(this.m_property.Name);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00089585 File Offset: 0x00087785
		public override int GetHashCode()
		{
			return this.m_property.Name.GetHashCode();
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00089597 File Offset: 0x00087797
		public override string ToString()
		{
			return this.m_property.Name;
		}

		// Token: 0x04000E92 RID: 3730
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember m_property;
	}
}
