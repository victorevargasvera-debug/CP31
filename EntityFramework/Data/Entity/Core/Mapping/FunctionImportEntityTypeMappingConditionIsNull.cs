using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000535 RID: 1333
	public sealed class FunctionImportEntityTypeMappingConditionIsNull : global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition
	{
		// Token: 0x060041C5 RID: 16837 RVA: 0x000DD0C7 File Offset: 0x000DB2C7
		public FunctionImportEntityTypeMappingConditionIsNull(string columnName, bool isNull) : this(global::System.Data.Entity.Utilities.Check.NotNull<string>(columnName, "columnName"), isNull, global::System.Data.Entity.Core.Mapping.LineInfo.Empty)
		{
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x000DD0E0 File Offset: 0x000DB2E0
		internal FunctionImportEntityTypeMappingConditionIsNull(string columnName, bool isNull, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo) : base(columnName, lineInfo)
		{
			this._isNull = isNull;
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x000DD0F1 File Offset: 0x000DB2F1
		public bool IsNull
		{
			get
			{
				return this._isNull;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x000DD0F9 File Offset: 0x000DB2F9
		internal override global::System.Data.Entity.Core.Mapping.ValueCondition ConditionValue
		{
			get
			{
				if (!this.IsNull)
				{
					return global::System.Data.Entity.Core.Mapping.ValueCondition.IsNotNull;
				}
				return global::System.Data.Entity.Core.Mapping.ValueCondition.IsNull;
			}
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x000DD10E File Offset: 0x000DB30E
		internal override bool ColumnValueMatchesCondition(object columnValue)
		{
			return (columnValue == null || global::System.Convert.IsDBNull(columnValue)) == this.IsNull;
		}

		// Token: 0x040016CC RID: 5836
		private readonly bool _isNull;
	}
}
