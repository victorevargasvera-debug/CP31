using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000362 RID: 866
	internal class RelPropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x06002A1F RID: 10783 RVA: 0x0008853B File Offset: 0x0008673B
		internal RelPropertyRef(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty property)
		{
			this.m_property = property;
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x0008854A File Offset: 0x0008674A
		internal global::System.Data.Entity.Core.Query.InternalTrees.RelProperty Property
		{
			get
			{
				return this.m_property;
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00088554 File Offset: 0x00086754
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef relPropertyRef = obj as global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef;
			return relPropertyRef != null && this.m_property.Equals(relPropertyRef.m_property);
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x0008857E File Offset: 0x0008677E
		public override int GetHashCode()
		{
			return this.m_property.GetHashCode();
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x0008858B File Offset: 0x0008678B
		public override string ToString()
		{
			return this.m_property.ToString();
		}

		// Token: 0x04000E72 RID: 3698
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.RelProperty m_property;
	}
}
