using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C3 RID: 195
	public abstract class PrimaryKeyOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x0001FC56 File Offset: 0x0001DE56
		public static string BuildDefaultName(string table)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PK_{0}", new object[]
			{
				table
			}).RestrictTo(128);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0001FC87 File Offset: 0x0001DE87
		protected PrimaryKeyOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
			this.IsClustered = true;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0001FCA2 File Offset: 0x0001DEA2
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x0001FCAA File Offset: 0x0001DEAA
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0001FCBF File Offset: 0x0001DEBF
		public global::System.Collections.Generic.IList<string> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0001FCC7 File Offset: 0x0001DEC7
		public bool HasDefaultName
		{
			get
			{
				return string.Equals(this.Name, this.DefaultName, global::System.StringComparison.Ordinal);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x0001FCDB File Offset: 0x0001DEDB
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x0001FCED File Offset: 0x0001DEED
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

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0001FCF6 File Offset: 0x0001DEF6
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0001FCF9 File Offset: 0x0001DEF9
		internal string DefaultName
		{
			get
			{
				return global::System.Data.Entity.Migrations.Model.PrimaryKeyOperation.BuildDefaultName(this.Table);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0001FD06 File Offset: 0x0001DF06
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0001FD0E File Offset: 0x0001DF0E
		public bool IsClustered { get; set; }

		// Token: 0x04000878 RID: 2168
		private readonly global::System.Collections.Generic.List<string> _columns = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000879 RID: 2169
		private string _table;

		// Token: 0x0400087A RID: 2170
		private string _name;
	}
}
