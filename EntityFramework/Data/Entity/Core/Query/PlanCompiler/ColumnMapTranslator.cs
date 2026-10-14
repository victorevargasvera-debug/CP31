using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000337 RID: 823
	internal class ColumnMapTranslator : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x00070F01 File Offset: 0x0006F101
		private ColumnMapTranslator()
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00070F0C File Offset: 0x0006F10C
		private static global::System.Data.Entity.Core.Query.InternalTrees.Var GetReplacementVar(global::System.Data.Entity.Core.Query.InternalTrees.Var originalVar, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> replacementVarMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = originalVar;
			while (replacementVarMap.TryGetValue(var, out originalVar) && originalVar != var)
			{
				var = originalVar;
			}
			return var;
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00070F2F File Offset: 0x0006F12F
		internal static global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Translate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			return columnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator._instance, translationDelegate);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00070F40 File Offset: 0x0006F140
		internal static global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Translate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMapToTranslate, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> varToColumnMap)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(columnMapToTranslate, delegate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap varRefColumnMap = columnMap as global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap;
				if (varRefColumnMap != null)
				{
					if (varToColumnMap.TryGetValue(varRefColumnMap.Var, out columnMap))
					{
						if (!columnMap.IsNamed && varRefColumnMap.IsNamed)
						{
							columnMap.Name = varRefColumnMap.Name;
						}
						if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(varRefColumnMap.Type.EdmType) && varRefColumnMap.Type.EdmType != columnMap.Type.EdmType)
						{
							columnMap.Type = varRefColumnMap.Type;
						}
					}
					else
					{
						columnMap = varRefColumnMap;
					}
				}
				return columnMap;
			});
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00070F6C File Offset: 0x0006F16C
		internal static global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Translate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMapToTranslate, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varToVarMap)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(columnMapToTranslate, delegate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap varRefColumnMap = columnMap as global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap;
				if (varRefColumnMap != null)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var replacementVar = global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.GetReplacementVar(varRefColumnMap.Var, varToVarMap);
					if (varRefColumnMap.Var != replacementVar)
					{
						columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(varRefColumnMap.Type, varRefColumnMap.Name, replacementVar);
					}
				}
				return columnMap;
			});
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00070F98 File Offset: 0x0006F198
		internal static global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Translate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMapToTranslate, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.KeyValuePair<int, int>> varToCommandColumnMap)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(columnMapToTranslate, delegate(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap varRefColumnMap = columnMap as global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap;
				if (varRefColumnMap != null)
				{
					global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair;
					if (!varToCommandColumnMap.TryGetValue(varRefColumnMap.Var, out keyValuePair))
					{
						throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UnknownVar, 1, varRefColumnMap.Var.Id);
					}
					columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap(varRefColumnMap.Type, varRefColumnMap.Name, keyValuePair.Key, keyValuePair.Value);
				}
				if (!columnMap.IsNamed)
				{
					columnMap.Name = "Value";
				}
				return columnMap;
			});
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00070FC4 File Offset: 0x0006F1C4
		private void VisitList<TResultType>(TResultType[] tList, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate) where TResultType : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap
		{
			for (int i = 0; i < tList.Length; i++)
			{
				tList[i] = (TResultType)((object)tList[i].Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate));
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00071000 File Offset: 0x0006F200
		protected override global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity entityIdentity, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap = entityIdentity.EntitySetColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate);
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(entityIdentity.Keys, translationDelegate);
			if (columnMap != entityIdentity.EntitySetColumnMap)
			{
				entityIdentity = new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity((global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)columnMap, entityIdentity.EntitySetMap, entityIdentity.Keys);
			}
			return entityIdentity;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0007104B File Offset: 0x0006F24B
		protected override global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity entityIdentity, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(entityIdentity.Keys, translationDelegate);
			return entityIdentity;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0007105C File Offset: 0x0006F25C
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap simpleColumnMap = columnMap.NullSentinel;
			if (simpleColumnMap != null)
			{
				simpleColumnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)translationDelegate(simpleColumnMap);
			}
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, translationDelegate);
			if (columnMap.NullSentinel != simpleColumnMap)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap(columnMap.Type, columnMap.Name, columnMap.Properties, simpleColumnMap);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000710B8 File Offset: 0x0006F2B8
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = columnMap.Discriminator.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate);
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.ForeignKeys, translationDelegate);
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.Keys, translationDelegate);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap3 = columnMap.Element.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate);
			if (columnMap2 != columnMap.Discriminator || columnMap3 != columnMap.Element)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap(columnMap.Type, columnMap.Name, columnMap3, columnMap.Keys, columnMap.ForeignKeys, (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)columnMap2, columnMap.DiscriminatorValue);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00071140 File Offset: 0x0006F340
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = base.VisitEntityIdentity(columnMap.EntityIdentity, translationDelegate);
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, translationDelegate);
			if (entityIdentity != columnMap.EntityIdentity)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap(columnMap.Type, columnMap.Name, columnMap.Properties, entityIdentity);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x00071194 File Offset: 0x0006F394
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = columnMap.TypeDiscriminator.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate);
			global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> dictionary = columnMap.TypeChoices;
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap typedColumnMap = (global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap)keyValuePair.Value.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate);
				if (typedColumnMap != keyValuePair.Value)
				{
					if (dictionary == columnMap.TypeChoices)
					{
						dictionary = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap>(columnMap.TypeChoices);
					}
					dictionary[keyValuePair.Key] = typedColumnMap;
				}
			}
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, translationDelegate);
			if (columnMap2 != columnMap.TypeDiscriminator || dictionary != columnMap.TypeChoices)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap(columnMap.Type, columnMap.Name, columnMap.Properties, (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)columnMap2, dictionary);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00071280 File Offset: 0x0006F480
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "unexpected MultipleDiscriminatorPolymorphicColumnMap in ColumnMapTranslator");
			return null;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00071290 File Offset: 0x0006F490
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap simpleColumnMap = columnMap.NullSentinel;
			if (simpleColumnMap != null)
			{
				simpleColumnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap)translationDelegate(simpleColumnMap);
			}
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, translationDelegate);
			if (columnMap.NullSentinel != simpleColumnMap)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap(columnMap.Type, columnMap.Name, columnMap.Properties, simpleColumnMap);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000712EC File Offset: 0x0006F4EC
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = base.VisitEntityIdentity(columnMap.EntityIdentity, translationDelegate);
			if (entityIdentity != columnMap.EntityIdentity)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap(columnMap.Type, columnMap.Name, entityIdentity);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0007132B File Offset: 0x0006F52B
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			return translationDelegate(columnMap);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00071334 File Offset: 0x0006F534
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.ForeignKeys, translationDelegate);
			this.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.Keys, translationDelegate);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = columnMap.Element.Accept<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate>(this, translationDelegate);
			if (columnMap2 != columnMap.Element)
			{
				columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(columnMap.Type, columnMap.Name, columnMap2, columnMap.Keys, columnMap.ForeignKeys);
			}
			return translationDelegate(columnMap);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00071399 File Offset: 0x0006F599
		internal override global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslatorTranslationDelegate translationDelegate)
		{
			return translationDelegate(columnMap);
		}

		// Token: 0x04000DAB RID: 3499
		private static readonly global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator _instance = new global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator();
	}
}
