using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Globalization;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005E0 RID: 1504
	public class EntityParameter : global::System.Data.Common.DbParameter, global::System.Data.IDbDataParameter, global::System.Data.IDataParameter
	{
		// Token: 0x06004975 RID: 18805 RVA: 0x00103DDE File Offset: 0x00101FDE
		public EntityParameter()
		{
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00103DE6 File Offset: 0x00101FE6
		public EntityParameter(string parameterName, global::System.Data.DbType dbType)
		{
			this.SetParameterNameWithValidation(parameterName, "parameterName");
			this.DbType = dbType;
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00103E01 File Offset: 0x00102001
		public EntityParameter(string parameterName, global::System.Data.DbType dbType, int size)
		{
			this.SetParameterNameWithValidation(parameterName, "parameterName");
			this.DbType = dbType;
			this.Size = size;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00103E23 File Offset: 0x00102023
		public EntityParameter(string parameterName, global::System.Data.DbType dbType, int size, string sourceColumn)
		{
			this.SetParameterNameWithValidation(parameterName, "parameterName");
			this.DbType = dbType;
			this.Size = size;
			this.SourceColumn = sourceColumn;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00103E50 File Offset: 0x00102050
		public EntityParameter(string parameterName, global::System.Data.DbType dbType, int size, global::System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, global::System.Data.DataRowVersion sourceVersion, object value)
		{
			this.SetParameterNameWithValidation(parameterName, "parameterName");
			this.DbType = dbType;
			this.Size = size;
			this.Direction = direction;
			this.IsNullable = isNullable;
			this.Precision = precision;
			this.Scale = scale;
			this.SourceColumn = sourceColumn;
			this.SourceVersion = sourceVersion;
			this.Value = value;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00103EB8 File Offset: 0x001020B8
		private EntityParameter(global::System.Data.Entity.Core.EntityClient.EntityParameter source) : this()
		{
			source.CloneHelper(this);
			global::System.ICloneable cloneable = this._value as global::System.ICloneable;
			if (cloneable != null)
			{
				this._value = cloneable.Clone();
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x00103EED File Offset: 0x001020ED
		// (set) Token: 0x0600497C RID: 18812 RVA: 0x00103EFE File Offset: 0x001020FE
		public override string ParameterName
		{
			get
			{
				return this._parameterName ?? "";
			}
			set
			{
				this.SetParameterNameWithValidation(value, "value");
			}
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00103F0C File Offset: 0x0010210C
		private void SetParameterNameWithValidation(string parameterName, string argumentName)
		{
			if (!string.IsNullOrEmpty(parameterName) && !global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree.IsValidParameterName(parameterName))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_InvalidParameterName(parameterName), argumentName);
			}
			this.PropertyChanging();
			this._parameterName = parameterName;
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x0600497E RID: 18814 RVA: 0x00103F38 File Offset: 0x00102138
		// (set) Token: 0x0600497F RID: 18815 RVA: 0x00103FB0 File Offset: 0x001021B0
		public override global::System.Data.DbType DbType
		{
			get
			{
				if (this._dbType == null)
				{
					if (this._edmType != null)
					{
						return global::System.Data.Entity.Core.EntityClient.EntityParameter.GetDbTypeFromEdm(this._edmType);
					}
					if (this._value == null)
					{
						return global::System.Data.DbType.String;
					}
					try
					{
						return global::System.Data.Entity.Core.Common.TypeHelpers.ConvertClrTypeToDbType(this._value.GetType());
					}
					catch (global::System.ArgumentException innerException)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotDeduceDbType, innerException);
					}
				}
				return this._dbType.Value;
			}
			set
			{
				this.PropertyChanging();
				this._dbType = new global::System.Data.DbType?(value);
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x00103FC4 File Offset: 0x001021C4
		// (set) Token: 0x06004981 RID: 18817 RVA: 0x00103FCC File Offset: 0x001021CC
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmType EdmType
		{
			get
			{
				return this._edmType;
			}
			set
			{
				if (value != null && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(value))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_EntityParameterEdmTypeNotScalar(value.FullName));
				}
				this.PropertyChanging();
				this._edmType = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x00103FF7 File Offset: 0x001021F7
		// (set) Token: 0x06004983 RID: 18819 RVA: 0x00104013 File Offset: 0x00102213
		public new virtual byte Precision
		{
			get
			{
				if (this._precision == null)
				{
					return 0;
				}
				return this._precision.Value;
			}
			set
			{
				this.PropertyChanging();
				this._precision = new byte?(value);
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x00104027 File Offset: 0x00102227
		// (set) Token: 0x06004985 RID: 18821 RVA: 0x00104043 File Offset: 0x00102243
		public new virtual byte Scale
		{
			get
			{
				if (this._scale == null)
				{
					return 0;
				}
				return this._scale.Value;
			}
			set
			{
				this.PropertyChanging();
				this._scale = new byte?(value);
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x00104057 File Offset: 0x00102257
		// (set) Token: 0x06004987 RID: 18823 RVA: 0x00104060 File Offset: 0x00102260
		public override object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (this._dbType == null && this._edmType == null)
				{
					global::System.Data.DbType dbType = global::System.Data.DbType.String;
					if (this._value != null)
					{
						dbType = global::System.Data.Entity.Core.Common.TypeHelpers.ConvertClrTypeToDbType(this._value.GetType());
					}
					global::System.Data.DbType dbType2 = global::System.Data.DbType.String;
					if (value != null)
					{
						dbType2 = global::System.Data.Entity.Core.Common.TypeHelpers.ConvertClrTypeToDbType(value.GetType());
					}
					if (dbType != dbType2)
					{
						this.PropertyChanging();
					}
				}
				this._value = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x001040C1 File Offset: 0x001022C1
		internal virtual bool IsDirty
		{
			get
			{
				return this._isDirty;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x001040C9 File Offset: 0x001022C9
		internal virtual bool IsDbTypeSpecified
		{
			get
			{
				return this._dbType != null;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x001040D6 File Offset: 0x001022D6
		internal virtual bool IsDirectionSpecified
		{
			get
			{
				return this._direction > (global::System.Data.ParameterDirection)0;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x001040E1 File Offset: 0x001022E1
		internal virtual bool IsIsNullableSpecified
		{
			get
			{
				return this._isNullable != null;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x001040EE File Offset: 0x001022EE
		internal virtual bool IsPrecisionSpecified
		{
			get
			{
				return this._precision != null;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x001040FB File Offset: 0x001022FB
		internal virtual bool IsScaleSpecified
		{
			get
			{
				return this._scale != null;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x00104108 File Offset: 0x00102308
		internal virtual bool IsSizeSpecified
		{
			get
			{
				return this._size != null;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x00104118 File Offset: 0x00102318
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x00104134 File Offset: 0x00102334
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		[global::System.Data.Entity.Core.EntityResCategory("DataCategory_Data")]
		[global::System.Data.Entity.Core.EntityResDescription("DbParameter_Direction")]
		public override global::System.Data.ParameterDirection Direction
		{
			get
			{
				global::System.Data.ParameterDirection direction = this._direction;
				if (direction == (global::System.Data.ParameterDirection)0)
				{
					return global::System.Data.ParameterDirection.Input;
				}
				return direction;
			}
			set
			{
				if (this._direction == value)
				{
					return;
				}
				if (value - global::System.Data.ParameterDirection.Input <= 2 || value == global::System.Data.ParameterDirection.ReturnValue)
				{
					this.PropertyChanging();
					this._direction = value;
					return;
				}
				string name = typeof(global::System.Data.ParameterDirection).Name;
				object name2 = typeof(global::System.Data.ParameterDirection).Name;
				int num = (int)value;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name2, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x00104199 File Offset: 0x00102399
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x001041B5 File Offset: 0x001023B5
		public override bool IsNullable
		{
			get
			{
				return this._isNullable == null || this._isNullable.Value;
			}
			set
			{
				this._isNullable = new bool?(value);
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x001041C4 File Offset: 0x001023C4
		// (set) Token: 0x06004994 RID: 18836 RVA: 0x00104200 File Offset: 0x00102400
		[global::System.Data.Entity.Core.EntityResCategory("DataCategory_Data")]
		[global::System.Data.Entity.Core.EntityResDescription("DbParameter_Size")]
		public override int Size
		{
			get
			{
				int num = (this._size != null) ? this._size.Value : 0;
				if (num == 0)
				{
					num = global::System.Data.Entity.Core.EntityClient.EntityParameter.ValueSize(this.Value);
				}
				return num;
			}
			set
			{
				if (this._size == null || this._size.Value != value)
				{
					if (value < -1)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidSizeValue(value.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					this.PropertyChanging();
					if (value == 0)
					{
						this._size = null;
						return;
					}
					this._size = new int?(value);
				}
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x00104268 File Offset: 0x00102468
		// (set) Token: 0x06004996 RID: 18838 RVA: 0x00104286 File Offset: 0x00102486
		[global::System.Data.Entity.Core.EntityResCategory("DataCategory_Update")]
		[global::System.Data.Entity.Core.EntityResDescription("DbParameter_SourceColumn")]
		public override string SourceColumn
		{
			get
			{
				string sourceColumn = this._sourceColumn;
				if (sourceColumn == null)
				{
					return string.Empty;
				}
				return sourceColumn;
			}
			set
			{
				this._sourceColumn = value;
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x0010428F File Offset: 0x0010248F
		// (set) Token: 0x06004998 RID: 18840 RVA: 0x00104297 File Offset: 0x00102497
		public override bool SourceColumnNullMapping
		{
			get
			{
				return this._sourceColumnNullMapping;
			}
			set
			{
				this._sourceColumnNullMapping = value;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x001042A0 File Offset: 0x001024A0
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x001042C0 File Offset: 0x001024C0
		[global::System.Data.Entity.Core.EntityResCategory("DataCategory_Update")]
		[global::System.Data.Entity.Core.EntityResDescription("DbParameter_SourceVersion")]
		public override global::System.Data.DataRowVersion SourceVersion
		{
			get
			{
				global::System.Data.DataRowVersion sourceVersion = this._sourceVersion;
				if (sourceVersion == (global::System.Data.DataRowVersion)0)
				{
					return global::System.Data.DataRowVersion.Current;
				}
				return sourceVersion;
			}
			set
			{
				if (value <= global::System.Data.DataRowVersion.Current)
				{
					if (value != global::System.Data.DataRowVersion.Original && value != global::System.Data.DataRowVersion.Current)
					{
						goto IL_32;
					}
				}
				else if (value != global::System.Data.DataRowVersion.Proposed && value != global::System.Data.DataRowVersion.Default)
				{
					goto IL_32;
				}
				this._sourceVersion = value;
				return;
				IL_32:
				string name = typeof(global::System.Data.DataRowVersion).Name;
				object name2 = typeof(global::System.Data.DataRowVersion).Name;
				int num = (int)value;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name2, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00104335 File Offset: 0x00102535
		public override void ResetDbType()
		{
			if (this._dbType != null || this._edmType != null)
			{
				this.PropertyChanging();
			}
			this._edmType = null;
			this._dbType = null;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00104365 File Offset: 0x00102565
		private void PropertyChanging()
		{
			this._isDirty = true;
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x0010436E File Offset: 0x0010256E
		private static int ValueSize(object value)
		{
			return global::System.Data.Entity.Core.EntityClient.EntityParameter.ValueSizeCore(value);
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00104376 File Offset: 0x00102576
		internal virtual global::System.Data.Entity.Core.EntityClient.EntityParameter Clone()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityParameter(this);
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00104380 File Offset: 0x00102580
		private void CloneHelper(global::System.Data.Entity.Core.EntityClient.EntityParameter destination)
		{
			destination._value = this._value;
			destination._direction = this._direction;
			destination._size = this._size;
			destination._sourceColumn = this._sourceColumn;
			destination._sourceVersion = this._sourceVersion;
			destination._sourceColumnNullMapping = this._sourceColumnNullMapping;
			destination._isNullable = this._isNullable;
			destination._parameterName = this._parameterName;
			destination._dbType = this._dbType;
			destination._edmType = this._edmType;
			destination._precision = this._precision;
			destination._scale = this._scale;
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00104420 File Offset: 0x00102620
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			if (!this.IsTypeConsistent)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_EntityParameterInconsistentEdmType(this._edmType.FullName, this._parameterName));
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (this._edmType != null)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(this._edmType);
			}
			else if (!global::System.Data.Entity.Core.Common.Internal.DbTypeMap.TryGetModelTypeUsage(this.DbType, out result))
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
				if (this.DbType != global::System.Data.DbType.Object || this.Value == null || !global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(this.Value.GetType(), out primitiveType) || (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(primitiveType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsHierarchyIdType(primitiveType)))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_UnsupportedDbType(this.DbType.ToString(), this.ParameterName));
				}
				result = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(primitiveType.PrimitiveTypeKind);
			}
			return result;
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x001044ED File Offset: 0x001026ED
		internal virtual void ResetIsDirty()
		{
			this._isDirty = false;
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x060049A2 RID: 18850 RVA: 0x001044F8 File Offset: 0x001026F8
		private bool IsTypeConsistent
		{
			get
			{
				if (this._edmType == null || this._dbType == null)
				{
					return true;
				}
				global::System.Data.DbType dbTypeFromEdm = global::System.Data.Entity.Core.EntityClient.EntityParameter.GetDbTypeFromEdm(this._edmType);
				global::System.Data.DbType? dbType;
				global::System.Data.DbType dbType2;
				if (dbTypeFromEdm == global::System.Data.DbType.String)
				{
					dbType = this._dbType;
					dbType2 = global::System.Data.DbType.String;
					if (!(dbType.GetValueOrDefault() == dbType2 & dbType != null))
					{
						dbType = this._dbType;
						dbType2 = global::System.Data.DbType.AnsiString;
						if (!(dbType.GetValueOrDefault() == dbType2 & dbType != null) && dbTypeFromEdm != global::System.Data.DbType.AnsiStringFixedLength)
						{
							return dbTypeFromEdm == global::System.Data.DbType.StringFixedLength;
						}
					}
					return true;
				}
				dbType = this._dbType;
				dbType2 = dbTypeFromEdm;
				return dbType.GetValueOrDefault() == dbType2 & dbType != null;
			}
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00104594 File Offset: 0x00102794
		private static global::System.Data.DbType GetDbTypeFromEdm(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type = global::System.Data.Entity.Core.Metadata.Edm.Helper.AsPrimitive(edmType);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(type))
			{
				return global::System.Data.DbType.Object;
			}
			global::System.Data.DbType result;
			if (global::System.Data.Entity.Core.Common.DbCommandDefinition.TryGetDbTypeFromPrimitiveType(type, out result))
			{
				return result;
			}
			return global::System.Data.DbType.AnsiString;
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x001045C0 File Offset: 0x001027C0
		private void ResetSize()
		{
			if (this._size != null)
			{
				this.PropertyChanging();
				this._size = null;
			}
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x001045E1 File Offset: 0x001027E1
		private bool ShouldSerializeSize()
		{
			return this._size != null && this._size.Value != 0;
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x00104600 File Offset: 0x00102800
		internal virtual void CopyTo(global::System.Data.Common.DbParameter destination)
		{
			this.CloneHelper((global::System.Data.Entity.Core.EntityClient.EntityParameter)destination);
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00104610 File Offset: 0x00102810
		internal virtual object CompareExchangeParent(object value, object comparand)
		{
			object parent = this._parent;
			if (comparand == parent)
			{
				this._parent = value;
			}
			return parent;
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x00104630 File Offset: 0x00102830
		internal virtual void ResetParent()
		{
			this._parent = null;
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00104639 File Offset: 0x00102839
		public override string ToString()
		{
			return this.ParameterName;
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00104644 File Offset: 0x00102844
		private static int ValueSizeCore(object value)
		{
			if (!global::System.Data.Entity.Core.EntityUtil.IsNull(value))
			{
				string text = value as string;
				if (text != null)
				{
					return text.Length;
				}
				byte[] array = value as byte[];
				if (array != null)
				{
					return array.Length;
				}
				char[] array2 = value as char[];
				if (array2 != null)
				{
					return array2.Length;
				}
				if (value is byte || value is char)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x040019F4 RID: 6644
		private string _parameterName;

		// Token: 0x040019F5 RID: 6645
		private global::System.Data.DbType? _dbType;

		// Token: 0x040019F6 RID: 6646
		private global::System.Data.Entity.Core.Metadata.Edm.EdmType _edmType;

		// Token: 0x040019F7 RID: 6647
		private byte? _precision;

		// Token: 0x040019F8 RID: 6648
		private byte? _scale;

		// Token: 0x040019F9 RID: 6649
		private bool _isDirty;

		// Token: 0x040019FA RID: 6650
		private object _value;

		// Token: 0x040019FB RID: 6651
		private object _parent;

		// Token: 0x040019FC RID: 6652
		private global::System.Data.ParameterDirection _direction;

		// Token: 0x040019FD RID: 6653
		private int? _size;

		// Token: 0x040019FE RID: 6654
		private string _sourceColumn;

		// Token: 0x040019FF RID: 6655
		private global::System.Data.DataRowVersion _sourceVersion;

		// Token: 0x04001A00 RID: 6656
		private bool _sourceColumnNullMapping;

		// Token: 0x04001A01 RID: 6657
		private bool? _isNullable;
	}
}
