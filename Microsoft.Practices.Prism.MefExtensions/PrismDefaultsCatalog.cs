using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Linq;

namespace Microsoft.Practices.Prism.MefExtensions
{
	// Token: 0x0200000C RID: 12
	internal class PrismDefaultsCatalog : global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public PrismDefaultsCatalog(global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition> parts)
		{
			if (parts == null)
			{
				throw new global::System.ArgumentNullException("parts");
			}
			this.parts = parts;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002DE5 File Offset: 0x00000FE5
		public override global::System.Linq.IQueryable<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts
		{
			get
			{
				return this.parts.AsQueryable<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition>();
			}
		}

		// Token: 0x04000016 RID: 22
		private readonly global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition> parts;
	}
}
