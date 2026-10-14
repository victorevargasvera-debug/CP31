using System;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Xml.XPath;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000536 RID: 1334
	public sealed class FunctionImportEntityTypeMappingConditionValue : global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition
	{
		// Token: 0x060041CA RID: 16842 RVA: 0x000DD124 File Offset: 0x000DB324
		public FunctionImportEntityTypeMappingConditionValue(string columnName, object value) : base(global::System.Data.Entity.Utilities.Check.NotNull<string>(columnName, "columnName"), global::System.Data.Entity.Core.Mapping.LineInfo.Empty)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			this._value = value;
			this._convertedValues = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, object>(new global::System.Func<global::System.Type, object>(this.GetConditionValue), null);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x000DD172 File Offset: 0x000DB372
		internal FunctionImportEntityTypeMappingConditionValue(string columnName, global::System.Xml.XPath.XPathNavigator columnValue, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo) : base(columnName, lineInfo)
		{
			this._xPathValue = columnValue;
			this._convertedValues = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, object>(new global::System.Func<global::System.Type, object>(this.GetConditionValue), null);
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x000DD19B File Offset: 0x000DB39B
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x000DD1A3 File Offset: 0x000DB3A3
		internal override global::System.Data.Entity.Core.Mapping.ValueCondition ConditionValue
		{
			get
			{
				return new global::System.Data.Entity.Core.Mapping.ValueCondition((this._value != null) ? this._value.ToString() : this._xPathValue.Value);
			}
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x000DD1CC File Offset: 0x000DB3CC
		internal override bool ColumnValueMatchesCondition(object columnValue)
		{
			if (columnValue == null || global::System.Convert.IsDBNull(columnValue))
			{
				return false;
			}
			global::System.Type type = columnValue.GetType();
			object y = this._convertedValues.Evaluate(type);
			return global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(columnValue, y);
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x000DD208 File Offset: 0x000DB408
		private object GetConditionValue(global::System.Type columnValueType)
		{
			return this.GetConditionValue(columnValueType, delegate()
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_UnsupportedType(this.ColumnName, columnValueType.FullName));
			}, delegate()
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ConditionValueTypeMismatch("FunctionImportMapping", this.ColumnName, columnValueType.FullName));
			});
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x000DD250 File Offset: 0x000DB450
		internal object GetConditionValue(global::System.Type columnValueType, global::System.Action handleTypeNotComparable, global::System.Action handleInvalidConditionValue)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			if (!global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(columnValueType, out primitiveType) || !global::System.Data.Entity.Core.Mapping.MappingItemLoader.IsTypeSupportedForCondition(primitiveType.PrimitiveTypeKind))
			{
				handleTypeNotComparable();
				return null;
			}
			if (this._value == null)
			{
				object result;
				try
				{
					result = this._xPathValue.ValueAs(columnValueType);
				}
				catch (global::System.FormatException)
				{
					handleInvalidConditionValue();
					result = null;
				}
				return result;
			}
			if (this._value.GetType() == columnValueType)
			{
				return this._value;
			}
			handleInvalidConditionValue();
			return null;
		}

		// Token: 0x040016CD RID: 5837
		private readonly object _value;

		// Token: 0x040016CE RID: 5838
		private readonly global::System.Xml.XPath.XPathNavigator _xPathValue;

		// Token: 0x040016CF RID: 5839
		private readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, object> _convertedValues;
	}
}
