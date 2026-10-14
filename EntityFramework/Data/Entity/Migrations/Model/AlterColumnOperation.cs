using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000AD RID: 173
	public class AlterColumnOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation, global::System.Data.Entity.Migrations.Model.IAnnotationTarget
	{
		// Token: 0x06000F0F RID: 3855 RVA: 0x0001ED68 File Offset: 0x0001CF68
		public AlterColumnOperation(string table, global::System.Data.Entity.Migrations.Model.ColumnModel column, bool isDestructiveChange, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ColumnModel>(column, "column");
			this._table = table;
			this._column = column;
			this._destructiveChange = isDestructiveChange;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0001ED9F File Offset: 0x0001CF9F
		public AlterColumnOperation(string table, global::System.Data.Entity.Migrations.Model.ColumnModel column, bool isDestructiveChange, global::System.Data.Entity.Migrations.Model.AlterColumnOperation inverse, object anonymousArguments = null) : this(table, column, isDestructiveChange, anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterColumnOperation>(inverse, "inverse");
			this._inverse = inverse;
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0001EDC1 File Offset: 0x0001CFC1
		public string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0001EDC9 File Offset: 0x0001CFC9
		public global::System.Data.Entity.Migrations.Model.ColumnModel Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0001EDD1 File Offset: 0x0001CFD1
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return this._inverse;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0001EDD9 File Offset: 0x0001CFD9
		public override bool IsDestructiveChange
		{
			get
			{
				return this._destructiveChange;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		bool global::System.Data.Entity.Migrations.Model.IAnnotationTarget.HasAnnotations
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.AlterColumnOperation alterColumnOperation = this.Inverse as global::System.Data.Entity.Migrations.Model.AlterColumnOperation;
				return this.Column.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>() || (alterColumnOperation != null && alterColumnOperation.Column.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>());
			}
		}

		// Token: 0x04000846 RID: 2118
		private readonly string _table;

		// Token: 0x04000847 RID: 2119
		private readonly global::System.Data.Entity.Migrations.Model.ColumnModel _column;

		// Token: 0x04000848 RID: 2120
		private readonly global::System.Data.Entity.Migrations.Model.AlterColumnOperation _inverse;

		// Token: 0x04000849 RID: 2121
		private readonly bool _destructiveChange;
	}
}
