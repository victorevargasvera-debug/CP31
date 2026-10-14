using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000BA RID: 186
	public abstract class ForeignKeyOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F69 RID: 3945 RVA: 0x0001F8BC File Offset: 0x0001DABC
		protected ForeignKeyOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		public string PrincipalTable
		{
			get
			{
				return this._principalTable;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._principalTable = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0001F8ED File Offset: 0x0001DAED
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0001F8F5 File Offset: 0x0001DAF5
		public string DependentTable
		{
			get
			{
				return this._dependentTable;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._dependentTable = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0001F90A File Offset: 0x0001DB0A
		public global::System.Collections.Generic.IList<string> DependentColumns
		{
			get
			{
				return this._dependentColumns;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0001F912 File Offset: 0x0001DB12
		public bool HasDefaultName
		{
			get
			{
				return string.Equals(this.Name, this.DefaultName, global::System.StringComparison.Ordinal);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0001F926 File Offset: 0x0001DB26
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0001F938 File Offset: 0x0001DB38
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0001F944 File Offset: 0x0001DB44
		internal string DefaultName
		{
			get
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "FK_{0}_{1}_{2}", new object[]
				{
					this.DependentTable,
					this.PrincipalTable,
					this.DependentColumns.Join(null, "_")
				}).RestrictTo(128);
			}
		}

		// Token: 0x04000866 RID: 2150
		private string _principalTable;

		// Token: 0x04000867 RID: 2151
		private string _dependentTable;

		// Token: 0x04000868 RID: 2152
		private readonly global::System.Collections.Generic.List<string> _dependentColumns = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000869 RID: 2153
		private string _name;
	}
}
