using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200039A RID: 922
	internal class DiscriminatedCollectionColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap
	{
		// Token: 0x06002CE8 RID: 11496 RVA: 0x0008F391 File Offset: 0x0008D591
		internal DiscriminatedCollectionColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap elementMap, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] foreignKeys, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap discriminator, object discriminatorValue) : base(type, name, elementMap, keys, foreignKeys)
		{
			this.m_discriminator = discriminator;
			this.m_discriminatorValue = discriminatorValue;
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x0008F3B0 File Offset: 0x0008D5B0
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap Discriminator
		{
			get
			{
				return this.m_discriminator;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x0008F3B8 File Offset: 0x0008D5B8
		internal object DiscriminatorValue
		{
			get
			{
				return this.m_discriminatorValue;
			}
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0008F3C0 File Offset: 0x0008D5C0
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0008F3CA File Offset: 0x0008D5CA
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0008F3D4 File Offset: 0x0008D5D4
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "M{{{0}}}", new object[]
			{
				base.Element
			});
		}

		// Token: 0x04000F16 RID: 3862
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap m_discriminator;

		// Token: 0x04000F17 RID: 3863
		private readonly object m_discriminatorValue;
	}
}
