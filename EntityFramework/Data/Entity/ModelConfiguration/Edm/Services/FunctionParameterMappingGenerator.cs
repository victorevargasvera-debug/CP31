using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Mapping.Update.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x02000176 RID: 374
	internal class FunctionParameterMappingGenerator : global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator
	{
		// Token: 0x060016CC RID: 5836 RVA: 0x0003B616 File Offset: 0x00039816
		public FunctionParameterMappingGenerator(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : base(providerManifest)
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0003B61F File Offset: 0x0003981F
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> Generate(global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator modificationOperator, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath, bool useOriginalValues = false)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = properties.GetEnumerator())
			{
				global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__1;
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.ModelConfiguration.Edm.Services.FunctionParameterMappingGenerator.<>c__DisplayClass1_1 CS$<>8__locals2 = new global::System.Data.Entity.ModelConfiguration.Edm.Services.FunctionParameterMappingGenerator.<>c__DisplayClass1_1();
					CS$<>8__locals2.property = enumerator.Current;
					if (CS$<>8__locals2.property.IsComplexType && propertyPath.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.IsComplexType && p.ComplexType == CS$<>8__locals2.property.ComplexType))
					{
						throw global::System.Data.Entity.Resources.Error.CircularComplexTypeHierarchy();
					}
					propertyPath.Add(CS$<>8__locals2.property);
					if (CS$<>8__locals2.property.IsComplexType)
					{
						foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in this.Generate(modificationOperator, CS$<>8__locals2.property.ComplexType.Properties, columnMappings, propertyPath, useOriginalValues))
						{
							yield return modificationFunctionParameterBinding;
						}
						global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> enumerator2 = null;
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? storeGeneratedPattern = CS$<>8__locals2.property.GetStoreGeneratedPattern();
						global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern2 = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity;
						if (!(storeGeneratedPattern.GetValueOrDefault() == storeGeneratedPattern2 & storeGeneratedPattern != null) || modificationOperator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert)
						{
							global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate;
							if ((predicate = <>9__1) == null)
							{
								predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder cm) => cm.PropertyPath.SequenceEqual(propertyPath)));
							}
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnProperty = columnMappings.First(predicate).ColumnProperty;
							storeGeneratedPattern = CS$<>8__locals2.property.GetStoreGeneratedPattern();
							storeGeneratedPattern2 = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed;
							if (!(storeGeneratedPattern.GetValueOrDefault() == storeGeneratedPattern2 & storeGeneratedPattern != null) && (modificationOperator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete || CS$<>8__locals2.property.IsKeyMember))
							{
								yield return new global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding(new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(columnProperty.Name, columnProperty.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In), new global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath(propertyPath, null), !useOriginalValues);
							}
							if (modificationOperator != global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert && CS$<>8__locals2.property.ConcurrencyMode == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed)
							{
								yield return new global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding(new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(columnProperty.Name + "_Original", columnProperty.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In), new global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath(propertyPath, null), false);
							}
							columnProperty = null;
						}
					}
					propertyPath.Remove(CS$<>8__locals2.property);
					CS$<>8__locals2 = null;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0003B654 File Offset: 0x00039854
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> Generate(global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> iaFkProperties, bool useOriginalValues = false)
		{
			return from iaFkProperty in iaFkProperties
			let functionParameter = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(iaFkProperty.Item2.Name, iaFkProperty.Item2.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In)
			select new global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding(functionParameter, iaFkProperty.Item1, !useOriginalValues);
		}
	}
}
