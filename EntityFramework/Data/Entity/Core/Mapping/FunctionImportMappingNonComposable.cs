using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200053A RID: 1338
	public sealed class FunctionImportMappingNonComposable : global::System.Data.Entity.Core.Mapping.FunctionImportMapping
	{
		// Token: 0x060041F3 RID: 16883 RVA: 0x000DE520 File Offset: 0x000DC720
		public FunctionImportMappingNonComposable(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping> resultMappings, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping) : base(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(functionImport, "functionImport"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(targetFunction, "targetFunction"))
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping>>(resultMappings, "resultMappings");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(containerMapping, "containerMapping");
			if (!resultMappings.Any<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection = (containerMapping.StorageMappingItemCollection != null) ? containerMapping.StorageMappingItemCollection.EdmItemCollection : new global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection(new global::System.Data.Entity.Core.Metadata.Edm.EdmModel(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, 3.0));
				this._internalResultMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB>(new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB[]
				{
					new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>(), itemCollection)
				});
				this.noExplicitResultMappings = true;
			}
			else
			{
				this._internalResultMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB>((from resultMapping in resultMappings
				select new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB(resultMapping.TypeMappings, containerMapping.StorageMappingItemCollection.EdmItemCollection)).ToArray<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB>());
				this.noExplicitResultMappings = false;
			}
			this._resultMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping>(resultMappings.ToList<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping>());
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x000DE614 File Offset: 0x000DC814
		internal FunctionImportMappingNonComposable(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>> structuralTypeMappingsList, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection) : base(functionImport, targetFunction)
		{
			if (structuralTypeMappingsList.Count == 0)
			{
				this._internalResultMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB>(new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB[]
				{
					new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>(), itemCollection)
				});
				this.noExplicitResultMappings = true;
				return;
			}
			this._internalResultMappings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB>((from structuralTypeMappings in structuralTypeMappingsList
			select new global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB(structuralTypeMappings, itemCollection)).ToArray<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB>());
			this.noExplicitResultMappings = false;
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x000DE694 File Offset: 0x000DC894
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB> InternalResultMappings
		{
			get
			{
				return this._internalResultMappings;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x000DE69C File Offset: 0x000DC89C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping> ResultMappings
		{
			get
			{
				return this._resultMappings;
			}
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x000DE6A4 File Offset: 0x000DC8A4
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._resultMappings);
			base.SetReadOnly();
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x000DE6B7 File Offset: 0x000DC8B7
		internal global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB GetResultMapping(int resultSetIndex)
		{
			if (this.noExplicitResultMappings)
			{
				return this.InternalResultMappings[0];
			}
			if (this.InternalResultMappings.Count <= resultSetIndex)
			{
				throw new global::System.ArgumentOutOfRangeException("resultSetIndex");
			}
			return this.InternalResultMappings[resultSetIndex];
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x000DE6F3 File Offset: 0x000DC8F3
		internal global::System.Collections.Generic.IList<string> GetDiscriminatorColumns(int resultSetIndex)
		{
			return this.GetResultMapping(resultSetIndex).DiscriminatorColumns;
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x000DE704 File Offset: 0x000DC904
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityType Discriminate(object[] discriminatorValues, int resultSetIndex)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB resultMapping = this.GetResultMapping(resultSetIndex);
			global::System.Collections.BitArray bitArray = new global::System.Collections.BitArray(resultMapping.MappedEntityTypes.Count, true);
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportNormalizedEntityTypeMapping functionImportNormalizedEntityTypeMapping in resultMapping.NormalizedEntityTypeMappings)
			{
				bool flag = true;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> columnConditions = functionImportNormalizedEntityTypeMapping.ColumnConditions;
				for (int i = 0; i < columnConditions.Count; i++)
				{
					if (columnConditions[i] != null && !columnConditions[i].ColumnValueMatchesCondition(discriminatorValues[i]))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					bitArray = bitArray.And(functionImportNormalizedEntityTypeMapping.ImpliedEntityTypes);
				}
				else
				{
					bitArray = bitArray.And(functionImportNormalizedEntityTypeMapping.ComplementImpliedEntityTypes);
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
			for (int j = 0; j < bitArray.Length; j++)
			{
				if (bitArray[j])
				{
					if (entityType != null)
					{
						throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataReaderUnableToDetermineType);
					}
					entityType = resultMapping.MappedEntityTypes[j];
				}
			}
			if (entityType == null)
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataReaderUnableToDetermineType);
			}
			return entityType;
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x000DE81C File Offset: 0x000DCA1C
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetExpectedTargetResultType(int resultSetIndex)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB resultMapping = this.GetResultMapping(resultSetIndex);
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.StructuralType> enumerable;
			if (resultMapping.NormalizedEntityTypeMappings.Count == 0)
			{
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType;
				global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(base.FunctionImport, resultSetIndex, out structuralType);
				enumerable = new global::System.Data.Entity.Core.Metadata.Edm.StructuralType[]
				{
					structuralType
				};
			}
			else
			{
				enumerable = resultMapping.MappedEntityTypes.Cast<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>();
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.StructuralType edmType in enumerable)
			{
				foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(edmType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)obj;
					dictionary[edmProperty.Name] = edmProperty.TypeUsage;
				}
			}
			foreach (string key in this.GetDiscriminatorColumns(resultSetIndex))
			{
				if (!dictionary.ContainsKey(key))
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage value = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetModelPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String), true, false);
					dictionary.Add(key, value);
				}
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.RowType(from c in dictionary
			select new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(c.Key, c.Value)))));
		}

		// Token: 0x040016DB RID: 5851
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportResultMapping> _resultMappings;

		// Token: 0x040016DC RID: 5852
		private readonly bool noExplicitResultMappings;

		// Token: 0x040016DD RID: 5853
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB> _internalResultMappings;
	}
}
