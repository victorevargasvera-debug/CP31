using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B4 RID: 180
	public class DropColumnOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation, global::System.Data.Entity.Migrations.Model.IAnnotationTarget
	{
		// Token: 0x06000F44 RID: 3908 RVA: 0x0001F5AF File Offset: 0x0001D7AF
		public DropColumnOperation(string table, string name, object anonymousArguments = null) : this(table, name, null, null, anonymousArguments)
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0001F5BC File Offset: 0x0001D7BC
		public DropColumnOperation(string table, string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, object anonymousArguments = null) : this(table, name, removedAnnotations, null, anonymousArguments)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0001F5CA File Offset: 0x0001D7CA
		public DropColumnOperation(string table, string name, global::System.Data.Entity.Migrations.Model.AddColumnOperation inverse, object anonymousArguments = null) : this(table, name, null, inverse, anonymousArguments)
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		public DropColumnOperation(string table, string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, global::System.Data.Entity.Migrations.Model.AddColumnOperation inverse, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._table = table;
			this._name = name;
			this._removedAnnotations = (removedAnnotations ?? new global::System.Collections.Generic.Dictionary<string, object>());
			this._inverse = inverse;
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0001F62B File Offset: 0x0001D82B
		public string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0001F633 File Offset: 0x0001D833
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0001F63B File Offset: 0x0001D83B
		public global::System.Collections.Generic.IDictionary<string, object> RemovedAnnotations
		{
			get
			{
				return this._removedAnnotations;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x0001F643 File Offset: 0x0001D843
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return this._inverse;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0001F64B File Offset: 0x0001D84B
		public override bool IsDestructiveChange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0001F650 File Offset: 0x0001D850
		bool global::System.Data.Entity.Migrations.Model.IAnnotationTarget.HasAnnotations
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.AddColumnOperation addColumnOperation = this.Inverse as global::System.Data.Entity.Migrations.Model.AddColumnOperation;
				return this.RemovedAnnotations.Any<global::System.Collections.Generic.KeyValuePair<string, object>>() || (addColumnOperation != null && ((global::System.Data.Entity.Migrations.Model.IAnnotationTarget)addColumnOperation).HasAnnotations);
			}
		}

		// Token: 0x0400085A RID: 2138
		private readonly string _table;

		// Token: 0x0400085B RID: 2139
		private readonly string _name;

		// Token: 0x0400085C RID: 2140
		private readonly global::System.Data.Entity.Migrations.Model.AddColumnOperation _inverse;

		// Token: 0x0400085D RID: 2141
		private readonly global::System.Collections.Generic.IDictionary<string, object> _removedAnnotations;
	}
}
