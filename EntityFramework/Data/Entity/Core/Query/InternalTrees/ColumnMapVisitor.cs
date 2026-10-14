using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200038A RID: 906
	internal abstract class ColumnMapVisitor<TArgType>
	{
		// Token: 0x06002BF9 RID: 11257 RVA: 0x0008DD20 File Offset: 0x0008BF20
		protected void VisitList<TListType>(TListType[] columnMaps, TArgType arg) where TListType : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap
		{
			for (int i = 0; i < columnMaps.Length; i++)
			{
				columnMaps[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0008DD50 File Offset: 0x0008BF50
		protected void VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity discriminatedEntityIdentity = entityIdentity as global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity;
			if (discriminatedEntityIdentity != null)
			{
				this.VisitEntityIdentity(discriminatedEntityIdentity, arg);
				return;
			}
			this.VisitEntityIdentity((global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity)entityIdentity, arg);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x0008DD80 File Offset: 0x0008BF80
		protected virtual void VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity entityIdentity, TArgType arg)
		{
			entityIdentity.EntitySetColumnMap.Accept<TArgType>(this, arg);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys = entityIdentity.Keys;
			for (int i = 0; i < keys.Length; i++)
			{
				keys[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x0008DDBC File Offset: 0x0008BFBC
		protected virtual void VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity entityIdentity, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys = entityIdentity.Keys;
			for (int i = 0; i < keys.Length; i++)
			{
				keys[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0008DDE8 File Offset: 0x0008BFE8
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap nullSentinel = columnMap.NullSentinel;
			if (nullSentinel != null)
			{
				nullSentinel.Accept<TArgType>(this, arg);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = columnMap.Properties;
			for (int i = 0; i < properties.Length; i++)
			{
				properties[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0008DE28 File Offset: 0x0008C028
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, TArgType arg)
		{
			columnMap.Discriminator.Accept<TArgType>(this, arg);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] array = columnMap.ForeignKeys;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Accept<TArgType>(this, arg);
			}
			array = columnMap.Keys;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Accept<TArgType>(this, arg);
			}
			columnMap.Element.Accept<TArgType>(this, arg);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x0008DE90 File Offset: 0x0008C090
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, TArgType arg)
		{
			this.VisitEntityIdentity(columnMap.EntityIdentity, arg);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = columnMap.Properties;
			for (int i = 0; i < properties.Length; i++)
			{
				properties[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x0008DECC File Offset: 0x0008C0CC
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, TArgType arg)
		{
			columnMap.TypeDiscriminator.Accept<TArgType>(this, arg);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap typedColumnMap in columnMap.TypeChoices.Values)
			{
				typedColumnMap.Accept<TArgType>(this, arg);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = columnMap.Properties;
			for (int i = 0; i < properties.Length; i++)
			{
				properties[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x0008DF50 File Offset: 0x0008C150
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] typeDiscriminators = columnMap.TypeDiscriminators;
			for (int i = 0; i < typeDiscriminators.Length; i++)
			{
				typeDiscriminators[i].Accept<TArgType>(this, arg);
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap typedColumnMap in columnMap.TypeChoices.Values)
			{
				typedColumnMap.Accept<TArgType>(this, arg);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = columnMap.Properties;
			for (int i = 0; i < properties.Length; i++)
			{
				properties[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x0008DFE8 File Offset: 0x0008C1E8
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap nullSentinel = columnMap.NullSentinel;
			if (nullSentinel != null)
			{
				nullSentinel.Accept<TArgType>(this, arg);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = columnMap.Properties;
			for (int i = 0; i < properties.Length; i++)
			{
				properties[i].Accept<TArgType>(this, arg);
			}
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x0008E026 File Offset: 0x0008C226
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, TArgType arg)
		{
			this.VisitEntityIdentity(columnMap.EntityIdentity, arg);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0008E035 File Offset: 0x0008C235
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, TArgType arg)
		{
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x0008E038 File Offset: 0x0008C238
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, TArgType arg)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] array = columnMap.ForeignKeys;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Accept<TArgType>(this, arg);
			}
			array = columnMap.Keys;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Accept<TArgType>(this, arg);
			}
			columnMap.Element.Accept<TArgType>(this, arg);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0008E090 File Offset: 0x0008C290
		internal virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, TArgType arg)
		{
		}
	}
}
