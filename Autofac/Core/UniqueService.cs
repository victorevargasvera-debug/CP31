using System;

namespace Autofac.Core
{
	// Token: 0x0200007B RID: 123
	public sealed class UniqueService : global::Autofac.Core.Service
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00008D86 File Offset: 0x00006F86
		public UniqueService() : this(global::System.Guid.NewGuid())
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008D93 File Offset: 0x00006F93
		public UniqueService(global::System.Guid id)
		{
			this._id = id;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00008DA4 File Offset: 0x00006FA4
		public override string Description
		{
			get
			{
				return this._id.ToString();
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00008DC8 File Offset: 0x00006FC8
		public override bool Equals(object obj)
		{
			global::Autofac.Core.UniqueService uniqueService = obj as global::Autofac.Core.UniqueService;
			return uniqueService != null && this._id == uniqueService._id;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00008DF8 File Offset: 0x00006FF8
		public override int GetHashCode()
		{
			return this._id.GetHashCode();
		}

		// Token: 0x0400009C RID: 156
		private readonly global::System.Guid _id;
	}
}
