using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001FA RID: 506
	public class ConventionTypeConfiguration
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x00046D0B File Offset: 0x00044F0B
		internal ConventionTypeConfiguration(global::System.Type type, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) : this(type, null, null, modelConfiguration)
		{
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00046D17 File Offset: 0x00044F17
		internal ConventionTypeConfiguration(global::System.Type type, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) : this(type, entityTypeConfiguration, null, modelConfiguration)
		{
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00046D23 File Offset: 0x00044F23
		internal ConventionTypeConfiguration(global::System.Type type, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> complexTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) : this(type, null, complexTypeConfiguration, modelConfiguration)
		{
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00046D2F File Offset: 0x00044F2F
		private ConventionTypeConfiguration(global::System.Type type, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> complexTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._type = type;
			this._entityTypeConfiguration = entityTypeConfiguration;
			this._complexTypeConfiguration = complexTypeConfiguration;
			this._modelConfiguration = modelConfiguration;
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00046D54 File Offset: 0x00044F54
		public global::System.Type ClrType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00046D5C File Offset: 0x00044F5C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration HasEntitySetName(string entitySetName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasEntitySetName);
			if (this._entityTypeConfiguration != null && this._entityTypeConfiguration().EntitySetName == null)
			{
				this._entityTypeConfiguration().EntitySetName = entitySetName;
			}
			return this;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00046DA8 File Offset: 0x00044FA8
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration Ignore()
		{
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.IgnoreType);
			if (this._entityTypeConfiguration == null && this._complexTypeConfiguration == null)
			{
				this._modelConfiguration.Ignore(this._type);
			}
			return this;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00046DD3 File Offset: 0x00044FD3
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration IsComplexType()
		{
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.IsComplexType);
			if (this._entityTypeConfiguration == null && this._complexTypeConfiguration == null)
			{
				this._modelConfiguration.ComplexType(this._type);
			}
			return this;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00046E00 File Offset: 0x00045000
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration Ignore(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Reflection.PropertyInfo instanceProperty = this._type.GetInstanceProperty(propertyName);
			if (instanceProperty == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NoSuchProperty(propertyName, this._type.Name));
			}
			this.Ignore(instanceProperty);
			return this;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00046E50 File Offset: 0x00045050
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration Ignore(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.Ignore);
			if (propertyInfo != null)
			{
				if (this._entityTypeConfiguration != null)
				{
					this._entityTypeConfiguration().Ignore(propertyInfo);
				}
				if (this._complexTypeConfiguration != null)
				{
					this._complexTypeConfiguration().Ignore(propertyInfo);
				}
			}
			return this;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00046EAC File Offset: 0x000450AC
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration Property(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Reflection.PropertyInfo instanceProperty = this._type.GetInstanceProperty(propertyName);
			if (instanceProperty == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NoSuchProperty(propertyName, this._type.Name));
			}
			return this.Property(instanceProperty);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00046EF9 File Offset: 0x000450F9
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration Property(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			return this.Property(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo));
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00046F14 File Offset: 0x00045114
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration Property(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath)
		{
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.Property);
			global::System.Reflection.PropertyInfo propertyInfo = propertyPath.Last<global::System.Reflection.PropertyInfo>();
			if (!propertyInfo.IsValidEdmScalarProperty())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_NonScalarProperty(propertyPath));
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration propertyConfiguration = (this._entityTypeConfiguration != null) ? this._entityTypeConfiguration().Property(propertyPath, null) : ((this._complexTypeConfiguration != null) ? this._complexTypeConfiguration().Property(propertyPath, null) : null);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration(propertyInfo, () => propertyConfiguration);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00046FAC File Offset: 0x000451AC
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration NavigationProperty(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Reflection.PropertyInfo instanceProperty = this._type.GetInstanceProperty(propertyName);
			if (instanceProperty == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NoSuchProperty(propertyName, this._type.Name));
			}
			return this.NavigationProperty(instanceProperty);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00046FF9 File Offset: 0x000451F9
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration NavigationProperty(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			return this.NavigationProperty(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo));
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00047014 File Offset: 0x00045214
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration NavigationProperty(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath)
		{
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.NavigationProperty);
			global::System.Reflection.PropertyInfo propertyInfo = propertyPath.Last<global::System.Reflection.PropertyInfo>();
			if (!propertyInfo.IsValidEdmNavigationProperty())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_InvalidNavigationProperty(propertyPath));
			}
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration((this._entityTypeConfiguration != null) ? this._entityTypeConfiguration().Navigation(propertyInfo) : null, this._modelConfiguration);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00047070 File Offset: 0x00045270
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration HasKey(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Reflection.PropertyInfo instanceProperty = this._type.GetInstanceProperty(propertyName);
			if (instanceProperty == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NoSuchProperty(propertyName, this._type.Name));
			}
			return this.HasKey(instanceProperty);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000470C0 File Offset: 0x000452C0
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration HasKey(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasKey);
			if (this._entityTypeConfiguration != null && !this._entityTypeConfiguration().IsKeyConfigured)
			{
				this._entityTypeConfiguration().Key(propertyInfo);
			}
			return this;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004710C File Offset: 0x0004530C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration HasKey(global::System.Collections.Generic.IEnumerable<string> propertyNames)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<string>>(propertyNames, "propertyNames");
			global::System.Reflection.PropertyInfo[] keyProperties = propertyNames.Select(delegate(string n)
			{
				global::System.Reflection.PropertyInfo instanceProperty = this._type.GetInstanceProperty(n);
				if (instanceProperty == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.NoSuchProperty(n, this._type.Name));
				}
				return instanceProperty;
			}).ToArray<global::System.Reflection.PropertyInfo>();
			return this.HasKey(keyProperties);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00047144 File Offset: 0x00045344
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration HasKey(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> keyProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo>>(keyProperties, "keyProperties");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Reflection.PropertyInfo>(ref keyProperties, "keyProperties");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentEmpty<global::System.Reflection.PropertyInfo>(ref keyProperties, (string p) => global::System.Data.Entity.Resources.Strings.CollectionEmpty(p, "HasKey"), "keyProperties");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasKey);
			if (this._entityTypeConfiguration != null && !this._entityTypeConfiguration().IsKeyConfigured)
			{
				this._entityTypeConfiguration().Key(keyProperties);
			}
			return this;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000471CC File Offset: 0x000453CC
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.ToTable);
			if (this._entityTypeConfiguration != null && !this._entityTypeConfiguration().IsTableNameConfigured)
			{
				global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(tableName);
				this._entityTypeConfiguration().ToTable(databaseName.Name, databaseName.Schema);
			}
			return this;
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00047230 File Offset: 0x00045430
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.ToTable);
			if (this._entityTypeConfiguration != null && !this._entityTypeConfiguration().IsTableNameConfigured)
			{
				this._entityTypeConfiguration().ToTable(tableName, schemaName);
			}
			return this;
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00047284 File Offset: 0x00045484
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration HasTableAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasTableAnnotation);
			if (this._entityTypeConfiguration != null && !this._entityTypeConfiguration().Annotations.ContainsKey(name))
			{
				this._entityTypeConfiguration().SetAnnotation(name, value);
			}
			return this;
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000472DB File Offset: 0x000454DB
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration MapToStoredProcedures()
		{
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.MapToStoredProcedures);
			if (this._entityTypeConfiguration != null)
			{
				this._entityTypeConfiguration().MapToStoredProcedures();
			}
			return this;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00047300 File Offset: 0x00045500
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration MapToStoredProcedures(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration> modificationStoredProceduresConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration>>(modificationStoredProceduresConfigurationAction, "modificationStoredProceduresConfigurationAction");
			this.ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.MapToStoredProcedures);
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration conventionModificationStoredProceduresConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration(this._type);
			modificationStoredProceduresConfigurationAction(conventionModificationStoredProceduresConfiguration);
			this.MapToStoredProcedures(conventionModificationStoredProceduresConfiguration.Configuration);
			return this;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00047341 File Offset: 0x00045541
		internal void MapToStoredProcedures(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration modificationStoredProceduresConfiguration)
		{
			if (this._entityTypeConfiguration != null)
			{
				this._entityTypeConfiguration().MapToStoredProcedures(modificationStoredProceduresConfiguration, false);
			}
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00047360 File Offset: 0x00045560
		private void ValidateConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect aspect)
		{
			this._currentConfigurationAspect |= aspect;
			if (this._currentConfigurationAspect.HasFlag(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.IgnoreType) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspectsConflictingWithIgnoreType.Any((global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect ca) => this._currentConfigurationAspect.HasFlag(ca)))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_ConfigurationConflict_IgnoreType(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspectsConflictingWithIgnoreType.First((global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect ca) => this._currentConfigurationAspect.HasFlag(ca)), this._type.Name));
			}
			if (this._currentConfigurationAspect.HasFlag(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.IsComplexType) && global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspectsConflictingWithComplexType.Any((global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect ca) => this._currentConfigurationAspect.HasFlag(ca)))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_ConfigurationConflict_ComplexType(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspectsConflictingWithComplexType.First((global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect ca) => this._currentConfigurationAspect.HasFlag(ca)), this._type.Name));
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0004743E File Offset: 0x0004563E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00047446 File Offset: 0x00045646
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0004744F File Offset: 0x0004564F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00047457 File Offset: 0x00045657
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A9B RID: 2715
		private readonly global::System.Type _type;

		// Token: 0x04000A9C RID: 2716
		private readonly global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> _entityTypeConfiguration;

		// Token: 0x04000A9D RID: 2717
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration _modelConfiguration;

		// Token: 0x04000A9E RID: 2718
		private readonly global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> _complexTypeConfiguration;

		// Token: 0x04000A9F RID: 2719
		private global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect _currentConfigurationAspect;

		// Token: 0x04000AA0 RID: 2720
		private static readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect> ConfigurationAspectsConflictingWithIgnoreType = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect>
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.IsComplexType,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasEntitySetName,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.Ignore,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasKey,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.MapToStoredProcedures,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.NavigationProperty,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.Property,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.ToTable,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasTableAnnotation
		};

		// Token: 0x04000AA1 RID: 2721
		private static readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect> ConfigurationAspectsConflictingWithComplexType = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect>
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasEntitySetName,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasKey,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.MapToStoredProcedures,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.NavigationProperty,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.ToTable,
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration.ConfigurationAspect.HasTableAnnotation
		};

		// Token: 0x020008CA RID: 2250
		[global::System.Flags]
		private enum ConfigurationAspect : uint
		{
			// Token: 0x04002454 RID: 9300
			None = 0U,
			// Token: 0x04002455 RID: 9301
			HasEntitySetName = 1U,
			// Token: 0x04002456 RID: 9302
			HasKey = 2U,
			// Token: 0x04002457 RID: 9303
			IgnoreType = 4U,
			// Token: 0x04002458 RID: 9304
			Ignore = 8U,
			// Token: 0x04002459 RID: 9305
			IsComplexType = 16U,
			// Token: 0x0400245A RID: 9306
			MapToStoredProcedures = 32U,
			// Token: 0x0400245B RID: 9307
			Property = 64U,
			// Token: 0x0400245C RID: 9308
			NavigationProperty = 128U,
			// Token: 0x0400245D RID: 9309
			ToTable = 256U,
			// Token: 0x0400245E RID: 9310
			HasTableAnnotation = 512U
		}
	}
}
