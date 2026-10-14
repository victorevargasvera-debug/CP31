using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Internal;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive
{
	// Token: 0x02000206 RID: 518
	internal class PrimitivePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration
	{
		// Token: 0x06001B57 RID: 6999 RVA: 0x00049F8C File Offset: 0x0004818C
		public PrimitivePropertyConfiguration()
		{
			this.OverridableConfigurationParts = (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInCSpace | global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00049FA8 File Offset: 0x000481A8
		protected PrimitivePropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(source, "source");
			this.TypeConfiguration = source.TypeConfiguration;
			this.IsNullable = source.IsNullable;
			this.ConcurrencyMode = source.ConcurrencyMode;
			this.DatabaseGeneratedOption = source.DatabaseGeneratedOption;
			this.ColumnType = source.ColumnType;
			this.ColumnName = source.ColumnName;
			this.ParameterName = source.ParameterName;
			this.ColumnOrder = source.ColumnOrder;
			this.OverridableConfigurationParts = source.OverridableConfigurationParts;
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> item in source._annotations)
			{
				this._annotations.Add(item);
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0004A084 File Offset: 0x00048284
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration(this);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0004A08C File Offset: 0x0004828C
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0004A094 File Offset: 0x00048294
		public bool? IsNullable { get; set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0004A09D File Offset: 0x0004829D
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0004A0A5 File Offset: 0x000482A5
		public global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode? ConcurrencyMode { get; set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0004A0AE File Offset: 0x000482AE
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0004A0B6 File Offset: 0x000482B6
		public global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption? DatabaseGeneratedOption { get; set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0004A0BF File Offset: 0x000482BF
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0004A0C7 File Offset: 0x000482C7
		public string ColumnType { get; set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0004A0D0 File Offset: 0x000482D0
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0004A0D8 File Offset: 0x000482D8
		public string ColumnName { get; set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0004A0E1 File Offset: 0x000482E1
		public global::System.Collections.Generic.IDictionary<string, object> Annotations
		{
			get
			{
				return this._annotations;
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0004A0E9 File Offset: 0x000482E9
		public virtual void SetAnnotation(string name, object value)
		{
			if (!name.IsValidUndottedName())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.BadAnnotationName(name));
			}
			this._annotations[name] = value;
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0004A10C File Offset: 0x0004830C
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0004A114 File Offset: 0x00048314
		public string ParameterName { get; set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0004A11D File Offset: 0x0004831D
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0004A125 File Offset: 0x00048325
		public int? ColumnOrder { get; set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0004A12E File Offset: 0x0004832E
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0004A136 File Offset: 0x00048336
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts OverridableConfigurationParts { get; set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0004A13F File Offset: 0x0004833F
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0004A147 File Offset: 0x00048347
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration TypeConfiguration { get; set; }

		// Token: 0x06001B6E RID: 7022 RVA: 0x0004A150 File Offset: 0x00048350
		internal virtual void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			this.Clone().MergeWithExistingConfiguration(property, delegate(string errorMessage)
			{
				global::System.Reflection.PropertyInfo clrPropertyInfo = property.GetClrPropertyInfo();
				string p = (clrPropertyInfo == null) ? string.Empty : global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(clrPropertyInfo.DeclaringType).FullNameWithNesting();
				return global::System.Data.Entity.Resources.Error.ConflictingPropertyConfiguration(property.Name, p, errorMessage);
			}, true, false).ConfigureProperty(property);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0004A194 File Offset: 0x00048394
		private global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration MergeWithExistingConfiguration(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Func<string, global::System.Exception> getConflictException, bool inCSpace, bool fillFromExistingConfiguration)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = property.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration;
			if (primitivePropertyConfiguration == null)
			{
				return this;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts overridableConfigurationParts = inCSpace ? global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInCSpace : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace;
			if (primitivePropertyConfiguration.OverridableConfigurationParts.HasFlag(overridableConfigurationParts) || fillFromExistingConfiguration)
			{
				return primitivePropertyConfiguration.OverrideFrom(this, inCSpace);
			}
			string arg;
			if (this.OverridableConfigurationParts.HasFlag(overridableConfigurationParts) || primitivePropertyConfiguration.IsCompatible(this, inCSpace, out arg))
			{
				return this.OverrideFrom(primitivePropertyConfiguration, inCSpace);
			}
			throw getConflictException(arg);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0004A212 File Offset: 0x00048412
		private global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration OverrideFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration overridingConfiguration, bool inCSpace)
		{
			if (overridingConfiguration.GetType().IsAssignableFrom(base.GetType()))
			{
				this.MakeCompatibleWith(overridingConfiguration, inCSpace);
				this.FillFrom(overridingConfiguration, inCSpace);
				return this;
			}
			overridingConfiguration.FillFrom(this, inCSpace);
			return overridingConfiguration;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0004A244 File Offset: 0x00048444
		protected virtual void ConfigureProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			if (this.IsNullable != null)
			{
				property.Nullable = this.IsNullable.Value;
			}
			if (this.ConcurrencyMode != null)
			{
				property.ConcurrencyMode = this.ConcurrencyMode.Value;
			}
			if (this.DatabaseGeneratedOption != null)
			{
				property.SetStoreGeneratedPattern((global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)this.DatabaseGeneratedOption.Value);
				if (this.DatabaseGeneratedOption.Value == global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
				{
					property.Nullable = false;
				}
			}
			property.SetConfiguration(this);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0004A2DC File Offset: 0x000484DC
		internal void Configure(global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> propertyMappings, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, bool allowOverride = false, bool fillFromExistingConfiguration = false)
		{
			propertyMappings.Each(delegate(global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType> pm)
			{
				this.Configure(pm.Item1.ColumnProperty, pm.Item2, providerManifest, allowOverride, fillFromExistingConfiguration);
			});
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0004A31E File Offset: 0x0004851E
		internal void ConfigureFunctionParameters(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters)
		{
			parameters.Each(new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this.ConfigureParameterName));
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0004A334 File Offset: 0x00048534
		private void ConfigureParameterName(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter)
		{
			if (string.IsNullOrWhiteSpace(this.ParameterName) || string.Equals(this.ParameterName, parameter.Name, global::System.StringComparison.Ordinal))
			{
				return;
			}
			parameter.Name = this.ParameterName;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> ts = from p in parameter.DeclaringFunction.Parameters
			let configuration = p.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
			where p != parameter && string.Equals(this.ParameterName, p.Name, global::System.StringComparison.Ordinal) && (configuration == null || configuration.ParameterName == null)
			select p;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> renamedParameters = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>
			{
				parameter
			};
			ts.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter c)
			{
				c.Name = renamedParameters.UniquifyName(this.ParameterName);
				renamedParameters.Add(c);
			});
			parameter.SetConfiguration(this);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0004A42C File Offset: 0x0004862C
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, bool allowOverride = false, bool fillFromExistingConfiguration = false)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = this.Clone();
			if (allowOverride)
			{
				primitivePropertyConfiguration.OverridableConfigurationParts |= global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace;
			}
			primitivePropertyConfiguration.MergeWithExistingConfiguration(column, (string errorMessage) => global::System.Data.Entity.Resources.Error.ConflictingColumnConfiguration(column.Name, table.Name, errorMessage), false, fillFromExistingConfiguration).ConfigureColumn(column, table, providerManifest);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0004A494 File Offset: 0x00048694
		protected virtual void ConfigureColumn(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			this.ConfigureColumnName(column, table);
			this.ConfigureAnnotations(column);
			if (!string.IsNullOrWhiteSpace(this.ColumnType))
			{
				column.PrimitiveType = providerManifest.GetStoreTypeFromName(this.ColumnType);
			}
			if (this.ColumnOrder != null)
			{
				column.SetOrder(this.ColumnOrder.Value);
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = providerManifest.GetStoreTypes().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType t) => t.Name.Equals(column.TypeName, global::System.StringComparison.OrdinalIgnoreCase));
			if (primitiveType != null)
			{
				primitiveType.FacetDescriptions.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.FacetDescription f)
				{
					this.Configure(column, f);
				});
			}
			column.SetConfiguration(this);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0004A55C File Offset: 0x0004875C
		private void ConfigureColumnName(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			if (string.IsNullOrWhiteSpace(this.ColumnName) || string.Equals(this.ColumnName, column.Name, global::System.StringComparison.Ordinal))
			{
				return;
			}
			column.Name = this.ColumnName;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> ts = from c in table.Properties
			let configuration = c.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
			where c != column && string.Equals(this.ColumnName, c.GetPreferredName(), global::System.StringComparison.Ordinal) && (configuration == null || configuration.ColumnName == null)
			select c;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> renamedColumns = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>
			{
				column
			};
			ts.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c)
			{
				c.Name = renamedColumns.UniquifyName(this.ColumnName);
				renamedColumns.Add(c);
			});
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0004A63C File Offset: 0x0004883C
		private void ConfigureAnnotations(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this._annotations)
			{
				column.AddAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:" + keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0004A6A0 File Offset: 0x000488A0
		internal virtual void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription)
		{
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0004A6A4 File Offset: 0x000488A4
		internal virtual void CopyFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other)
		{
			if (this == other)
			{
				return;
			}
			this.ColumnName = other.ColumnName;
			this.ParameterName = other.ParameterName;
			this.ColumnOrder = other.ColumnOrder;
			this.ColumnType = other.ColumnType;
			this.ConcurrencyMode = other.ConcurrencyMode;
			this.DatabaseGeneratedOption = other.DatabaseGeneratedOption;
			this.IsNullable = other.IsNullable;
			this.OverridableConfigurationParts = other.OverridableConfigurationParts;
			this._annotations.Clear();
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in other._annotations)
			{
				this._annotations[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0004A774 File Offset: 0x00048974
		internal virtual void FillFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			if (this == other)
			{
				return;
			}
			if (inCSpace)
			{
				if (this.ConcurrencyMode == null)
				{
					this.ConcurrencyMode = other.ConcurrencyMode;
				}
				if (this.DatabaseGeneratedOption == null)
				{
					this.DatabaseGeneratedOption = other.DatabaseGeneratedOption;
				}
				if (this.IsNullable == null)
				{
					this.IsNullable = other.IsNullable;
				}
				if (!other.OverridableConfigurationParts.HasFlag(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInCSpace))
				{
					this.OverridableConfigurationParts &= ~global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInCSpace;
					return;
				}
			}
			else
			{
				if (this.ColumnName == null)
				{
					this.ColumnName = other.ColumnName;
				}
				if (this.ParameterName == null)
				{
					this.ParameterName = other.ParameterName;
				}
				if (this.ColumnOrder == null)
				{
					this.ColumnOrder = other.ColumnOrder;
				}
				if (this.ColumnType == null)
				{
					this.ColumnType = other.ColumnType;
				}
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in other._annotations)
				{
					if (this._annotations.ContainsKey(keyValuePair.Key))
					{
						global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation mergeableAnnotation = this._annotations[keyValuePair.Key] as global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation;
						if (mergeableAnnotation != null)
						{
							this._annotations[keyValuePair.Key] = mergeableAnnotation.MergeWith(keyValuePair.Value);
						}
					}
					else
					{
						this._annotations[keyValuePair.Key] = keyValuePair.Value;
					}
				}
				if (!other.OverridableConfigurationParts.HasFlag(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace))
				{
					this.OverridableConfigurationParts &= ~global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace;
				}
			}
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0004A934 File Offset: 0x00048B34
		internal virtual void MakeCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			if (this == other)
			{
				return;
			}
			if (inCSpace)
			{
				if (other.ConcurrencyMode != null)
				{
					this.ConcurrencyMode = null;
				}
				if (other.DatabaseGeneratedOption != null)
				{
					this.DatabaseGeneratedOption = null;
				}
				if (other.IsNullable != null)
				{
					this.IsNullable = null;
					return;
				}
			}
			else
			{
				if (other.ColumnName != null)
				{
					this.ColumnName = null;
				}
				if (other.ParameterName != null)
				{
					this.ParameterName = null;
				}
				if (other.ColumnOrder != null)
				{
					this.ColumnOrder = null;
				}
				if (other.ColumnType != null)
				{
					this.ColumnType = null;
				}
				foreach (string key in other._annotations.Keys)
				{
					if (this._annotations.ContainsKey(key))
					{
						global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation mergeableAnnotation = this._annotations[key] as global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation;
						if (mergeableAnnotation == null || !mergeableAnnotation.IsCompatibleWith(other._annotations[key]))
						{
							this._annotations.Remove(key);
						}
					}
				}
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0004AA8C File Offset: 0x00048C8C
		internal virtual bool IsCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace, out string errorMessage)
		{
			errorMessage = string.Empty;
			if (other == null || this == other)
			{
				return true;
			}
			bool flag = !inCSpace || this.IsCompatible<bool, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.IsNullable, other, ref errorMessage);
			bool flag2 = !inCSpace || this.IsCompatible<global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.ConcurrencyMode, other, ref errorMessage);
			bool flag3 = !inCSpace || this.IsCompatible<global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.DatabaseGeneratedOption, other, ref errorMessage);
			bool flag4 = inCSpace || this.IsCompatible<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.ColumnName, other, ref errorMessage);
			bool flag5 = inCSpace || this.IsCompatible<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.ParameterName, other, ref errorMessage);
			bool flag6 = inCSpace || this.IsCompatible<int, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.ColumnOrder, other, ref errorMessage);
			bool flag7 = inCSpace || this.IsCompatible<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration c) => c.ColumnType, other, ref errorMessage);
			bool flag8 = inCSpace || this.AnnotationsAreCompatible(other, ref errorMessage);
			return flag && flag2 && flag3 && flag4 && flag5 && flag6 && flag7 && flag8;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0004ACDC File Offset: 0x00048EDC
		private bool AnnotationsAreCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, ref string errorMessage)
		{
			bool result = true;
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this.Annotations)
			{
				if (other.Annotations.ContainsKey(keyValuePair.Key))
				{
					object value = keyValuePair.Value;
					object obj = other.Annotations[keyValuePair.Key];
					global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation mergeableAnnotation = value as global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation;
					if (mergeableAnnotation != null)
					{
						global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult compatibilityResult = mergeableAnnotation.IsCompatibleWith(obj);
						if (!compatibilityResult)
						{
							result = false;
							errorMessage = errorMessage + global::System.Environment.NewLine + "\t" + compatibilityResult.ErrorMessage;
						}
					}
					else if (!object.Equals(value, obj))
					{
						result = false;
						errorMessage = errorMessage + global::System.Environment.NewLine + "\t" + global::System.Data.Entity.Resources.Strings.ConflictingAnnotationValue(keyValuePair.Key, value.ToString(), obj.ToString());
					}
				}
			}
			return result;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0004ADD4 File Offset: 0x00048FD4
		protected bool IsCompatible<TProperty, TConfiguration>(global::System.Linq.Expressions.Expression<global::System.Func<TConfiguration, TProperty?>> propertyExpression, TConfiguration other, ref string errorMessage) where TProperty : struct where TConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TConfiguration, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<TConfiguration>(other, "other");
			global::System.Reflection.PropertyInfo propertyInfo = propertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			TProperty? tproperty = (TProperty?)propertyInfo.GetValue(this, null);
			TProperty? tproperty2 = (TProperty?)propertyInfo.GetValue(other, null);
			if (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration.IsCompatible<TProperty>(tproperty, tproperty2))
			{
				return true;
			}
			errorMessage = errorMessage + global::System.Environment.NewLine + "\t" + global::System.Data.Entity.Resources.Strings.ConflictingConfigurationValue(propertyInfo.Name, tproperty, propertyInfo.Name, tproperty2);
			return false;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0004AE64 File Offset: 0x00049064
		protected bool IsCompatible<TConfiguration>(global::System.Linq.Expressions.Expression<global::System.Func<TConfiguration, string>> propertyExpression, TConfiguration other, ref string errorMessage) where TConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TConfiguration, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<TConfiguration>(other, "other");
			global::System.Reflection.PropertyInfo propertyInfo = propertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			string text = (string)propertyInfo.GetValue(this, null);
			string text2 = (string)propertyInfo.GetValue(other, null);
			if (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration.IsCompatible(text, text2))
			{
				return true;
			}
			errorMessage = errorMessage + global::System.Environment.NewLine + "\t" + global::System.Data.Entity.Resources.Strings.ConflictingConfigurationValue(propertyInfo.Name, text, propertyInfo.Name, text2);
			return false;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0004AEE8 File Offset: 0x000490E8
		protected static bool IsCompatible<T>(T? thisConfiguration, T? other) where T : struct
		{
			return thisConfiguration == null || other == null || object.Equals(thisConfiguration.Value, other.Value);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0004AF1D File Offset: 0x0004911D
		protected static bool IsCompatible(string thisConfiguration, string other)
		{
			return thisConfiguration == null || other == null || object.Equals(thisConfiguration, other);
		}

		// Token: 0x04000ABE RID: 2750
		private readonly global::System.Collections.Generic.IDictionary<string, object> _annotations = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
