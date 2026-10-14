using System;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200034F RID: 847
	internal class NestedPropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x060028A8 RID: 10408 RVA: 0x0007C90C File Offset: 0x0007AB0C
		internal NestedPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef innerProperty, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef outerProperty)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!(innerProperty is global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef), "innerProperty cannot be a NestedPropertyRef");
			this.m_inner = innerProperty;
			this.m_outer = outerProperty;
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x0007C938 File Offset: 0x0007AB38
		internal global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef OuterProperty
		{
			get
			{
				return this.m_outer;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x0007C940 File Offset: 0x0007AB40
		internal global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef InnerProperty
		{
			get
			{
				return this.m_inner;
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0007C948 File Offset: 0x0007AB48
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef nestedPropertyRef = obj as global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef;
			return nestedPropertyRef != null && this.m_inner.Equals(nestedPropertyRef.m_inner) && this.m_outer.Equals(nestedPropertyRef.m_outer);
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0007C985 File Offset: 0x0007AB85
		public override int GetHashCode()
		{
			return this.m_inner.GetHashCode() ^ this.m_outer.GetHashCode();
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0007C99E File Offset: 0x0007AB9E
		public override string ToString()
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef inner = this.m_inner;
			string str = (inner != null) ? inner.ToString() : null;
			string str2 = ".";
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef outer = this.m_outer;
			return str + str2 + ((outer != null) ? outer.ToString() : null);
		}

		// Token: 0x04000E29 RID: 3625
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef m_inner;

		// Token: 0x04000E2A RID: 3626
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef m_outer;
	}
}
