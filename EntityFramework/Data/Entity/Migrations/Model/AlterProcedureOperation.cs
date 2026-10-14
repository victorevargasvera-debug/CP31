using System;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000AE RID: 174
	public class AlterProcedureOperation : global::System.Data.Entity.Migrations.Model.ProcedureOperation
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x0001EE26 File Offset: 0x0001D026
		public AlterProcedureOperation(string name, string bodySql, object anonymousArguments = null) : base(name, bodySql, anonymousArguments)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0001EE31 File Offset: 0x0001D031
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return global::System.Data.Entity.Migrations.Model.NotSupportedOperation.Instance;
			}
		}
	}
}
