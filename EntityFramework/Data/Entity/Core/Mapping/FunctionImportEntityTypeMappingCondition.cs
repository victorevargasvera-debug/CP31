using System;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000534 RID: 1332
	public abstract class FunctionImportEntityTypeMappingCondition : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060041C0 RID: 16832 RVA: 0x000DD09C File Offset: 0x000DB29C
		internal FunctionImportEntityTypeMappingCondition(string columnName, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo)
		{
			this._columnName = columnName;
			this.LineInfo = lineInfo;
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x000DD0B2 File Offset: 0x000DB2B2
		public string ColumnName
		{
			get
			{
				return this._columnName;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060041C2 RID: 16834
		internal abstract global::System.Data.Entity.Core.Mapping.ValueCondition ConditionValue { get; }

		// Token: 0x060041C3 RID: 16835
		internal abstract bool ColumnValueMatchesCondition(object columnValue);

		// Token: 0x060041C4 RID: 16836 RVA: 0x000DD0BA File Offset: 0x000DB2BA
		public override string ToString()
		{
			return this.ConditionValue.ToString();
		}

		// Token: 0x040016CA RID: 5834
		private readonly string _columnName;

		// Token: 0x040016CB RID: 5835
		internal readonly global::System.Data.Entity.Core.Mapping.LineInfo LineInfo;
	}
}
