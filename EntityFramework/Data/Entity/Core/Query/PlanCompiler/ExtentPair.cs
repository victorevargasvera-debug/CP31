using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200033F RID: 831
	internal class ExtentPair
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x0007343C File Offset: 0x0007163C
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Left
		{
			get
			{
				return this.m_left;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x00073444 File Offset: 0x00071644
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Right
		{
			get
			{
				return this.m_right;
			}
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x0007344C File Offset: 0x0007164C
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair extentPair = obj as global::System.Data.Entity.Core.Query.PlanCompiler.ExtentPair;
			return extentPair != null && extentPair.Left.Equals(this.Left) && extentPair.Right.Equals(this.Right);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00073489 File Offset: 0x00071689
		public override int GetHashCode()
		{
			return this.Left.GetHashCode() << 4 ^ this.Right.GetHashCode();
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000734A4 File Offset: 0x000716A4
		internal ExtentPair(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase left, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase right)
		{
			this.m_left = left;
			this.m_right = right;
		}

		// Token: 0x04000DCD RID: 3533
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_left;

		// Token: 0x04000DCE RID: 3534
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_right;
	}
}
