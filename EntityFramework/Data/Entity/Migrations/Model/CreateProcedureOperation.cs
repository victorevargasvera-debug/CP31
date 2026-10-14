using System;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B2 RID: 178
	public class CreateProcedureOperation : global::System.Data.Entity.Migrations.Model.ProcedureOperation
	{
		// Token: 0x06000F38 RID: 3896 RVA: 0x0001F43D File Offset: 0x0001D63D
		public CreateProcedureOperation(string name, string bodySql, object anonymousArguments = null) : base(name, bodySql, anonymousArguments)
		{
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0001F448 File Offset: 0x0001D648
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(this.Name, null);
			}
		}
	}
}
