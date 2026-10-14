using System;
using System.ComponentModel.DataAnnotations;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000131 RID: 305
	internal class EntityValidationContext
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x000351E8 File Offset: 0x000333E8
		public EntityValidationContext(global::System.Data.Entity.Internal.InternalEntityEntry entityEntry, global::System.ComponentModel.DataAnnotations.ValidationContext externalValidationContext)
		{
			this._entityEntry = entityEntry;
			this.ExternalValidationContext = externalValidationContext;
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000351FE File Offset: 0x000333FE
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x00035206 File Offset: 0x00033406
		public global::System.ComponentModel.DataAnnotations.ValidationContext ExternalValidationContext { get; private set; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0003520F File Offset: 0x0003340F
		public global::System.Data.Entity.Internal.InternalEntityEntry InternalEntity
		{
			get
			{
				return this._entityEntry;
			}
		}

		// Token: 0x040009B9 RID: 2489
		private readonly global::System.Data.Entity.Internal.InternalEntityEntry _entityEntry;
	}
}
