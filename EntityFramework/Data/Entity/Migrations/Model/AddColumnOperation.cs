using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000AA RID: 170
	public class AddColumnOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation, global::System.Data.Entity.Migrations.Model.IAnnotationTarget
	{
		// Token: 0x06000F00 RID: 3840 RVA: 0x0001EB5F File Offset: 0x0001CD5F
		public AddColumnOperation(string table, global::System.Data.Entity.Migrations.Model.ColumnModel column, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ColumnModel>(column, "column");
			this._table = table;
			this._column = column;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0001EB8E File Offset: 0x0001CD8E
		public string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0001EB96 File Offset: 0x0001CD96
		public global::System.Data.Entity.Migrations.Model.ColumnModel Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return new global::System.Data.Entity.Migrations.Model.DropColumnOperation(this.Table, this.Column.Name, this.Column.Annotations.ToDictionary((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => a.Value.NewValue), null);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0001EC12 File Offset: 0x0001CE12
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0001EC15 File Offset: 0x0001CE15
		bool global::System.Data.Entity.Migrations.Model.IAnnotationTarget.HasAnnotations
		{
			get
			{
				return this.Column.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>();
			}
		}

		// Token: 0x04000842 RID: 2114
		private readonly string _table;

		// Token: 0x04000843 RID: 2115
		private readonly global::System.Data.Entity.Migrations.Model.ColumnModel _column;
	}
}
