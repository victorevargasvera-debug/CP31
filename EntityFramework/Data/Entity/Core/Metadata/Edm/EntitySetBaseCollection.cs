using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004BB RID: 1211
	internal sealed class EntitySetBaseCollection : global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x000C5FFC File Offset: 0x000C41FC
		internal EntitySetBaseCollection(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer) : this(entityContainer, null)
		{
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x000C6006 File Offset: 0x000C4206
		internal EntitySetBaseCollection(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> items) : base(items)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(entityContainer, "entityContainer");
			this._entityContainer = entityContainer;
		}

		// Token: 0x17000BB2 RID: 2994
		public override global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase this[int index]
		{
			get
			{
				return base[index];
			}
			set
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
			}
		}

		// Token: 0x17000BB3 RID: 2995
		public override global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase this[string identity]
		{
			get
			{
				return base[identity];
			}
			set
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
			}
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x000C604C File Offset: 0x000C424C
		public override void Add(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(item, "item");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBaseCollection.ThrowIfItHasEntityContainer(item, "item");
			base.Add(item);
			item.ChangeEntityContainerWithoutCollectionFixup(this._entityContainer);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x000C6078 File Offset: 0x000C4278
		private static void ThrowIfItHasEntityContainer(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, string argumentName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(entitySet, argumentName);
			if (entitySet.EntityContainer != null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntitySetInAnotherContainer, argumentName);
			}
		}

		// Token: 0x040014A7 RID: 5287
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityContainer _entityContainer;
	}
}
