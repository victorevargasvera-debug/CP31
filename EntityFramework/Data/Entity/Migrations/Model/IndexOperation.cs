using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000BD RID: 189
	public abstract class IndexOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x0001F9DA File Offset: 0x0001DBDA
		public static string BuildDefaultName(global::System.Collections.Generic.IEnumerable<string> columns)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<string>>(columns, "columns");
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "IX_{0}", new object[]
			{
				columns.Join(null, "_")
			}).RestrictTo(128);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0001FA16 File Offset: 0x0001DC16
		protected IndexOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0001FA2A File Offset: 0x0001DC2A
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x0001FA32 File Offset: 0x0001DC32
		public string Table
		{
			get
			{
				return this._table;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._table = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0001FA47 File Offset: 0x0001DC47
		public global::System.Collections.Generic.IList<string> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0001FA4F File Offset: 0x0001DC4F
		public bool HasDefaultName
		{
			get
			{
				return string.Equals(this.Name, this.DefaultName, global::System.StringComparison.Ordinal);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x0001FA63 File Offset: 0x0001DC63
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x0001FA75 File Offset: 0x0001DC75
		public string Name
		{
			get
			{
				return this._name ?? this.DefaultName;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0001FA7E File Offset: 0x0001DC7E
		internal string DefaultName
		{
			get
			{
				return global::System.Data.Entity.Migrations.Model.IndexOperation.BuildDefaultName(this.Columns);
			}
		}

		// Token: 0x0400086B RID: 2155
		private string _table;

		// Token: 0x0400086C RID: 2156
		private readonly global::System.Collections.Generic.List<string> _columns = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400086D RID: 2157
		private string _name;
	}
}
