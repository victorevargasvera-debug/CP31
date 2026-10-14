using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.PlanCompiler;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000388 RID: 904
	internal class ColumnMapCopier : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>
	{
		// Token: 0x06002BDD RID: 11229 RVA: 0x0008D114 File Offset: 0x0008B314
		private ColumnMapCopier()
		{
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x0008D11C File Offset: 0x0008B31C
		internal static global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Copy(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			return columnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapCopier._instance, replacementVarMap);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x0008D12C File Offset: 0x0008B32C
		private static global::System.Data.Entity.Core.Query.InternalTrees.Var GetReplacementVar(global::System.Data.Entity.Core.Query.InternalTrees.Var originalVar, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = originalVar;
			while (replacementVarMap.TryGetValue(var, out originalVar) && originalVar != var)
			{
				var = originalVar;
			}
			return var;
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x0008D150 File Offset: 0x0008B350
		internal TListType[] VisitList<TListType>(TListType[] tList, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap) where TListType : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap
		{
			TListType[] array = new TListType[tList.Length];
			for (int i = 0; i < tList.Length; i++)
			{
				array[i] = (TListType)((object)tList[i].Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap));
			}
			return array;
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x0008D194 File Offset: 0x0008B394
		protected override global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity entityIdentity, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap entitySetColumn = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)entityIdentity.EntitySetColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumns = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(entityIdentity.Keys, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity(entitySetColumn, entityIdentity.EntitySetMap, keyColumns);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x0008D1D0 File Offset: 0x0008B3D0
		protected override global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity entityIdentity, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumns = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(entityIdentity.Keys, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity(entityIdentity.EntitySet, keyColumns);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x0008D1F8 File Offset: 0x0008B3F8
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap simpleColumnMap = columnMap.NullSentinel;
			if (simpleColumnMap != null)
			{
				simpleColumnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)simpleColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap(columnMap.Type, columnMap.Name, properties, simpleColumnMap);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x0008D240 File Offset: 0x0008B440
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap elementMap = columnMap.Element.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap discriminator = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)columnMap.Discriminator.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.Keys, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] foreignKeys = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.ForeignKeys, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap(columnMap.Type, columnMap.Name, elementMap, keys, foreignKeys, discriminator, columnMap.DiscriminatorValue);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x0008D2A8 File Offset: 0x0008B4A8
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = base.VisitEntityIdentity(columnMap.EntityIdentity, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap(columnMap.Type, columnMap.Name, properties, entityIdentity);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0008D2E4 File Offset: 0x0008B4E4
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap typeDiscriminator = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)columnMap.TypeDiscriminator.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> dictionary = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap>(columnMap.TypeChoices.Comparer);
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap value = (global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap)keyValuePair.Value.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
				dictionary[keyValuePair.Key] = value;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] baseTypeColumns = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap(columnMap.Type, columnMap.Name, baseTypeColumns, typeDiscriminator, dictionary);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0008D39C File Offset: 0x0008B59C
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "unexpected MultipleDiscriminatorPolymorphicColumnMap in ColumnMapCopier");
			return null;
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0008D3AC File Offset: 0x0008B5AC
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap simpleColumnMap = columnMap.NullSentinel;
			if (simpleColumnMap != null)
			{
				simpleColumnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)simpleColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap(columnMap.Type, columnMap.Name, properties, simpleColumnMap);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0008D3F4 File Offset: 0x0008B5F4
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = base.VisitEntityIdentity(columnMap.EntityIdentity, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap(columnMap.Type, columnMap.Name, entityIdentity);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x0008D421 File Offset: 0x0008B621
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(columnMap.Type, columnMap.Name, columnMap.CommandId, columnMap.ColumnPos);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x0008D440 File Offset: 0x0008B640
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap elementMap = columnMap.Element.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap>(this, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.Keys, replacementVarMap);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] foreignKeys = this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.ForeignKeys, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(columnMap.Type, columnMap.Name, elementMap, keys, foreignKeys);
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x0008D48C File Offset: 0x0008B68C
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var replacementVar = global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapCopier.GetReplacementVar(columnMap.Var, replacementVarMap);
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(columnMap.Type, columnMap.Name, replacementVar);
		}

		// Token: 0x04000EEC RID: 3820
		private static readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapCopier _instance = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapCopier();
	}
}
