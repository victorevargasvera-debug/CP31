using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000BF RID: 191
	public class MoveProcedureOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x0001FAF2 File Offset: 0x0001DCF2
		public MoveProcedureOperation(string name, string newSchema, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._newSchema = newSchema;
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0001FB15 File Offset: 0x0001DD15
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0001FB1D File Offset: 0x0001DD1D
		public virtual string NewSchema
		{
			get
			{
				return this._newSchema;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0001FB28 File Offset: 0x0001DD28
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(this._name);
				return new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(new global::System.Data.Entity.Utilities.DatabaseName(databaseName.Name, this.NewSchema).ToString(), databaseName.Schema, null);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0001FB63 File Offset: 0x0001DD63
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400086F RID: 2159
		private readonly string _name;

		// Token: 0x04000870 RID: 2160
		private readonly string _newSchema;
	}
}
