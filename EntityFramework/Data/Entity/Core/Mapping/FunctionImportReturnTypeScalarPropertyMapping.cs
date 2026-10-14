using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200053F RID: 1343
	public sealed class FunctionImportReturnTypeScalarPropertyMapping : global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping
	{
		// Token: 0x06004209 RID: 16905 RVA: 0x000DEBF3 File Offset: 0x000DCDF3
		public FunctionImportReturnTypeScalarPropertyMapping(string propertyName, string columnName) : this(global::System.Data.Entity.Utilities.Check.NotNull<string>(propertyName, "propertyName"), global::System.Data.Entity.Utilities.Check.NotNull<string>(columnName, "columnName"), global::System.Data.Entity.Core.Mapping.LineInfo.Empty)
		{
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x000DEC16 File Offset: 0x000DCE16
		internal FunctionImportReturnTypeScalarPropertyMapping(string propertyName, string columnName, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo) : base(lineInfo)
		{
			this._propertyName = propertyName;
			this._columnName = columnName;
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x000DEC2D File Offset: 0x000DCE2D
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x000DEC35 File Offset: 0x000DCE35
		internal override string CMember
		{
			get
			{
				return this.PropertyName;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x000DEC3D File Offset: 0x000DCE3D
		public string ColumnName
		{
			get
			{
				return this._columnName;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x000DEC45 File Offset: 0x000DCE45
		internal override string SColumn
		{
			get
			{
				return this.ColumnName;
			}
		}

		// Token: 0x040016E4 RID: 5860
		private readonly string _propertyName;

		// Token: 0x040016E5 RID: 5861
		private readonly string _columnName;
	}
}
