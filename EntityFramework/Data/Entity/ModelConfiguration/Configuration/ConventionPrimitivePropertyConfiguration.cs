using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F8 RID: 504
	public class ConventionPrimitivePropertyConfiguration
	{
		// Token: 0x06001A61 RID: 6753 RVA: 0x00046028 File Offset: 0x00044228
		internal ConventionPrimitivePropertyConfiguration(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> configuration)
		{
			this._propertyInfo = propertyInfo;
			this._configuration = configuration;
			this._binaryConfiguration = new global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration>(() => this._configuration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration);
			this._dateTimeConfiguration = new global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(() => this._configuration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration);
			this._decimalConfiguration = new global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>(() => this._configuration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration);
			this._lengthConfiguration = new global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration>(() => this._configuration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration);
			this._stringConfiguration = new global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration>(() => this._configuration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration);
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x000460BC File Offset: 0x000442BC
		public virtual global::System.Reflection.PropertyInfo ClrPropertyInfo
		{
			get
			{
				return this._propertyInfo;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000460C4 File Offset: 0x000442C4
		internal global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000460CC File Offset: 0x000442CC
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasColumnName(string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			if (this._configuration() != null && this._configuration().ColumnName == null)
			{
				this._configuration().ColumnName = columnName;
			}
			return this;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0004610C File Offset: 0x0004430C
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasColumnAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			if (this._configuration() != null && !this._configuration().Annotations.ContainsKey(name))
			{
				this._configuration().SetAnnotation(name, value);
			}
			return this;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0004615D File Offset: 0x0004435D
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasParameterName(string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			if (this._configuration() != null && this._configuration().ParameterName == null)
			{
				this._configuration().ParameterName = parameterName;
			}
			return this;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0004619C File Offset: 0x0004439C
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasColumnOrder(int columnOrder)
		{
			if (columnOrder < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("columnOrder");
			}
			if (this._configuration() != null && this._configuration().ColumnOrder == null)
			{
				this._configuration().ColumnOrder = new int?(columnOrder);
			}
			return this;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x000461F6 File Offset: 0x000443F6
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasColumnType(string columnType)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnType, "columnType");
			if (this._configuration() != null && this._configuration().ColumnType == null)
			{
				this._configuration().ColumnType = columnType;
			}
			return this;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00046235 File Offset: 0x00044435
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsConcurrencyToken()
		{
			return this.IsConcurrencyToken(true);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00046240 File Offset: 0x00044440
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsConcurrencyToken(bool concurrencyToken)
		{
			if (this._configuration() != null && this._configuration().ConcurrencyMode == null)
			{
				this._configuration().ConcurrencyMode = new global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode?(concurrencyToken ? global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed : global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None);
			}
			return this;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00046294 File Offset: 0x00044494
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasDatabaseGeneratedOption(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption databaseGeneratedOption)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption), databaseGeneratedOption))
			{
				throw new global::System.ArgumentOutOfRangeException("databaseGeneratedOption");
			}
			if (this._configuration() != null && this._configuration().DatabaseGeneratedOption == null)
			{
				this._configuration().DatabaseGeneratedOption = new global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption?(databaseGeneratedOption);
			}
			return this;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00046304 File Offset: 0x00044504
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsOptional()
		{
			if (this._configuration() != null && this._configuration().IsNullable == null)
			{
				if (!this._propertyInfo.PropertyType.IsNullable())
				{
					global::System.Type declaringType = this._propertyInfo.DeclaringType;
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_NonNullableProperty(((declaringType != null) ? declaringType.ToString() : null) + "." + this._propertyInfo.Name, this._propertyInfo.PropertyType.Name));
				}
				this._configuration().IsNullable = new bool?(true);
			}
			return this;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x000463AC File Offset: 0x000445AC
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsRequired()
		{
			if (this._configuration() != null && this._configuration().IsNullable == null)
			{
				this._configuration().IsNullable = new bool?(false);
			}
			return this;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000463F7 File Offset: 0x000445F7
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsUnicode()
		{
			return this.IsUnicode(true);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00046400 File Offset: 0x00044600
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsUnicode(bool unicode)
		{
			if (this._configuration() != null)
			{
				if (this._stringConfiguration.Value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_IsUnicodeNonString(this._propertyInfo.Name));
				}
				if (this._stringConfiguration.Value.IsUnicode == null)
				{
					this._stringConfiguration.Value.IsUnicode = new bool?(unicode);
				}
			}
			return this;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00046470 File Offset: 0x00044670
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsFixedLength()
		{
			if (this._configuration() != null)
			{
				if (this._lengthConfiguration.Value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_NonLength(this._propertyInfo.Name));
				}
				if (this._lengthConfiguration.Value.IsFixedLength == null)
				{
					this._lengthConfiguration.Value.IsFixedLength = new bool?(true);
				}
			}
			return this;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000464E0 File Offset: 0x000446E0
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsVariableLength()
		{
			if (this._configuration() != null)
			{
				if (this._lengthConfiguration.Value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_NonLength(this._propertyInfo.Name));
				}
				if (this._lengthConfiguration.Value.IsFixedLength == null)
				{
					this._lengthConfiguration.Value.IsFixedLength = new bool?(false);
				}
			}
			return this;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00046550 File Offset: 0x00044750
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasMaxLength(int maxLength)
		{
			if (maxLength < 1)
			{
				throw new global::System.ArgumentOutOfRangeException("maxLength");
			}
			if (this._configuration() != null)
			{
				if (this._lengthConfiguration.Value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_NonLength(this._propertyInfo.Name));
				}
				if (this._lengthConfiguration.Value.MaxLength == null && this._lengthConfiguration.Value.IsMaxLength == null)
				{
					this._lengthConfiguration.Value.MaxLength = new int?(maxLength);
					if (this._lengthConfiguration.Value.IsFixedLength == null)
					{
						this._lengthConfiguration.Value.IsFixedLength = new bool?(false);
					}
				}
			}
			return this;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0004661C File Offset: 0x0004481C
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsMaxLength()
		{
			if (this._configuration() != null)
			{
				if (this._lengthConfiguration.Value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_NonLength(this._propertyInfo.Name));
				}
				if (this._lengthConfiguration.Value.IsMaxLength == null && this._lengthConfiguration.Value.MaxLength == null)
				{
					this._lengthConfiguration.Value.IsMaxLength = new bool?(true);
				}
			}
			return this;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000466A4 File Offset: 0x000448A4
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasPrecision(byte value)
		{
			if (this._configuration() != null)
			{
				if (this._dateTimeConfiguration.Value == null)
				{
					if (this._decimalConfiguration.Value != null)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_DecimalNoScale(this._propertyInfo.Name));
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_HasPrecisionNonDateTime(this._propertyInfo.Name));
				}
				else if (this._dateTimeConfiguration.Value.Precision == null)
				{
					this._dateTimeConfiguration.Value.Precision = new byte?(value);
				}
			}
			return this;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00046738 File Offset: 0x00044938
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration HasPrecision(byte precision, byte scale)
		{
			if (this._configuration() != null)
			{
				if (this._decimalConfiguration.Value == null)
				{
					if (this._dateTimeConfiguration.Value != null)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_DateTimeScale(this._propertyInfo.Name));
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_HasPrecisionNonDecimal(this._propertyInfo.Name));
				}
				else if (this._decimalConfiguration.Value.Precision == null && this._decimalConfiguration.Value.Scale == null)
				{
					this._decimalConfiguration.Value.Precision = new byte?(precision);
					this._decimalConfiguration.Value.Scale = new byte?(scale);
				}
			}
			return this;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000467FC File Offset: 0x000449FC
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsRowVersion()
		{
			if (this._configuration() != null)
			{
				if (this._binaryConfiguration.Value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightPrimitivePropertyConfiguration_IsRowVersionNonBinary(this._propertyInfo.Name));
				}
				if (this._binaryConfiguration.Value.IsRowVersion == null)
				{
					this._binaryConfiguration.Value.IsRowVersion = new bool?(true);
				}
			}
			return this;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004686C File Offset: 0x00044A6C
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration IsKey()
		{
			if (this._configuration() != null)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = this._configuration().TypeConfiguration as global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration;
				if (entityTypeConfiguration != null && !entityTypeConfiguration.IsKeyConfigured)
				{
					entityTypeConfiguration.Key(this.ClrPropertyInfo);
				}
			}
			return this;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000468B4 File Offset: 0x00044AB4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000468BC File Offset: 0x00044ABC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000468C5 File Offset: 0x00044AC5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000468CD File Offset: 0x00044ACD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A91 RID: 2705
		private readonly global::System.Reflection.PropertyInfo _propertyInfo;

		// Token: 0x04000A92 RID: 2706
		private readonly global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> _configuration;

		// Token: 0x04000A93 RID: 2707
		private readonly global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration> _binaryConfiguration;

		// Token: 0x04000A94 RID: 2708
		private readonly global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration> _dateTimeConfiguration;

		// Token: 0x04000A95 RID: 2709
		private readonly global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration> _decimalConfiguration;

		// Token: 0x04000A96 RID: 2710
		private readonly global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration> _lengthConfiguration;

		// Token: 0x04000A97 RID: 2711
		private readonly global::System.Lazy<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration> _stringConfiguration;
	}
}
