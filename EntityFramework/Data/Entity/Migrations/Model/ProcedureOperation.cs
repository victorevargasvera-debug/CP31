using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C4 RID: 196
	public abstract class ProcedureOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x0001FD17 File Offset: 0x0001DF17
		protected ProcedureOperation(string name, string bodySql, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._bodySql = bodySql;
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0001FD45 File Offset: 0x0001DF45
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0001FD4D File Offset: 0x0001DF4D
		public string BodySql
		{
			get
			{
				return this._bodySql;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0001FD55 File Offset: 0x0001DF55
		public virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.ParameterModel> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0001FD5D File Offset: 0x0001DF5D
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400087C RID: 2172
		private readonly string _name;

		// Token: 0x0400087D RID: 2173
		private readonly string _bodySql;

		// Token: 0x0400087E RID: 2174
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.ParameterModel> _parameters = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.ParameterModel>();
	}
}
