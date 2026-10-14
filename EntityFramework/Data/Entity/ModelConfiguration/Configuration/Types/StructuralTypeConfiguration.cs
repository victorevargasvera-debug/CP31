using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Types
{
	// Token: 0x020001FF RID: 511
	internal abstract class StructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationBase
	{
		// Token: 0x06001B14 RID: 6932 RVA: 0x00048F7C File Offset: 0x0004717C
		internal static global::System.Type GetPropertyConfigurationType(global::System.Type propertyType)
		{
			propertyType.TryUnwrapNullableType(out propertyType);
			if (propertyType == typeof(string))
			{
				return typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration);
			}
			if (propertyType == typeof(decimal))
			{
				return typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration);
			}
			if (propertyType == typeof(global::System.DateTime) || propertyType == typeof(global::System.TimeSpan) || propertyType == typeof(global::System.DateTimeOffset))
			{
				return typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration);
			}
			if (propertyType == typeof(byte[]))
			{
				return typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration);
			}
			if (!propertyType.IsValueType() && !(propertyType == typeof(global::System.Data.Entity.Hierarchy.HierarchyId)) && !(propertyType == typeof(global::System.Data.Entity.Spatial.DbGeography)) && !(propertyType == typeof(global::System.Data.Entity.Spatial.DbGeometry)))
			{
				return typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration);
			}
			return typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0004907D File Offset: 0x0004727D
		internal StructuralTypeConfiguration()
		{
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0004909B File Offset: 0x0004729B
		internal StructuralTypeConfiguration(global::System.Type clrType)
		{
			this._clrType = clrType;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x000490C0 File Offset: 0x000472C0
		internal StructuralTypeConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration source)
		{
			source._primitivePropertyConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> c)
			{
				this._primitivePropertyConfigurations.Add(c.Key, c.Value.Clone());
			});
			this._ignoredProperties.AddRange(source._ignoredProperties);
			this._clrType = source._clrType;
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0004911D File Offset: 0x0004731D
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> ConfiguredProperties
		{
			get
			{
				return from p in this._primitivePropertyConfigurations.Keys
				select p.Last<global::System.Reflection.PropertyInfo>();
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0004914E File Offset: 0x0004734E
		internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> IgnoredProperties
		{
			get
			{
				return this._ignoredProperties;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x00049156 File Offset: 0x00047356
		internal global::System.Type ClrType
		{
			get
			{
				return this._clrType;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0004915E File Offset: 0x0004735E
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>> PrimitivePropertyConfigurations
		{
			get
			{
				return this._primitivePropertyConfigurations;
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00049166 File Offset: 0x00047366
		public void Ignore(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			this._ignoredProperties.Add(propertyInfo);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00049184 File Offset: 0x00047384
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Property(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts? overridableConfigurationParts = null)
		{
			return this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyPath, delegate()
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration)global::System.Activator.CreateInstance(global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration.GetPropertyConfigurationType(propertyPath.Last<global::System.Reflection.PropertyInfo>().PropertyType));
				if (overridableConfigurationParts != null)
				{
					primitivePropertyConfiguration.OverridableConfigurationParts = overridableConfigurationParts.Value;
				}
				return primitivePropertyConfiguration;
			});
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000491BD File Offset: 0x000473BD
		internal virtual void RemoveProperty(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath)
		{
			this._primitivePropertyConfigurations.Remove(propertyPath);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000491CC File Offset: 0x000473CC
		internal TPrimitivePropertyConfiguration Property<TPrimitivePropertyConfiguration>(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath, global::System.Func<TPrimitivePropertyConfiguration> primitivePropertyConfigurationCreator) where TPrimitivePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration;
			if (!this._primitivePropertyConfigurations.TryGetValue(propertyPath, out primitivePropertyConfiguration))
			{
				primitivePropertyConfiguration = primitivePropertyConfigurationCreator();
				primitivePropertyConfiguration.TypeConfiguration = this;
				this._primitivePropertyConfigurations.Add(propertyPath, primitivePropertyConfiguration);
			}
			return (TPrimitivePropertyConfiguration)((object)primitivePropertyConfiguration);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00049210 File Offset: 0x00047410
		internal void ConfigurePropertyMappings(global::System.Collections.Generic.IList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> propertyMappings, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, bool allowOverride = false)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> keyValuePair in this.PrimitivePropertyConfigurations)
			{
				global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = keyValuePair.Key;
				keyValuePair.Value.Configure(from pm in propertyMappings
				where propertyPath.Equals(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(from p in pm.Item1.PropertyPath.Skip(pm.Item1.PropertyPath.Count - propertyPath.Count)
				select p.GetClrPropertyInfo()))
				select pm, providerManifest, allowOverride, false);
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0004928C File Offset: 0x0004748C
		internal void ConfigureFunctionParameters(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> keyValuePair in this.PrimitivePropertyConfigurations)
			{
				global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = keyValuePair.Key;
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration value = keyValuePair.Value;
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters = from pb in parameterBindings.Where(delegate(global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb)
				{
					if (pb.MemberPath.AssociationSetEnd == null)
					{
						return propertyPath.Equals(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(from m in pb.MemberPath.Members.Skip(pb.MemberPath.Members.Count - propertyPath.Count)
						select m.GetClrPropertyInfo()));
					}
					return false;
				})
				select pb.Parameter;
				value.ConfigureFunctionParameters(parameters);
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0004932C File Offset: 0x0004752C
		internal void Configure(string structuralTypeName, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> dataModelAnnotations)
		{
			dataModelAnnotations.SetConfiguration(this);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> keyValuePair in this._primitivePropertyConfigurations)
			{
				global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath key = keyValuePair.Key;
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration value = keyValuePair.Value;
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration.Configure(structuralTypeName, properties, key, value);
			}
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00049398 File Offset: 0x00047598
		private static void Configure(string structuralTypeName, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> propertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration propertyConfiguration)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo().IsSameAs(propertyPath.First<global::System.Reflection.PropertyInfo>()));
			if (edmProperty == null)
			{
				throw global::System.Data.Entity.Resources.Error.PropertyNotFound(propertyPath.First<global::System.Reflection.PropertyInfo>().Name, structuralTypeName);
			}
			if (edmProperty.IsUnderlyingPrimitiveType)
			{
				propertyConfiguration.Configure(edmProperty);
				return;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration.Configure(edmProperty.ComplexType.Name, edmProperty.ComplexType.Properties, new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyPath.Skip(1)), propertyConfiguration);
		}

		// Token: 0x04000AB0 RID: 2736
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> _primitivePropertyConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>();

		// Token: 0x04000AB1 RID: 2737
		private readonly global::System.Collections.Generic.HashSet<global::System.Reflection.PropertyInfo> _ignoredProperties = new global::System.Collections.Generic.HashSet<global::System.Reflection.PropertyInfo>();

		// Token: 0x04000AB2 RID: 2738
		private readonly global::System.Type _clrType;
	}
}
