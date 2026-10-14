using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000AF RID: 175
	public class AlterTableOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation, global::System.Data.Entity.Migrations.Model.IAnnotationTarget
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x0001EE38 File Offset: 0x0001D038
		public AlterTableOperation(string name, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._annotations = (annotations ?? new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>());
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0001EE6F File Offset: 0x0001D06F
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0001EE77 File Offset: 0x0001D077
		public virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.ColumnModel> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0001EE7F File Offset: 0x0001D07F
		public virtual global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> Annotations
		{
			get
			{
				return this._annotations;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0001EE88 File Offset: 0x0001D088
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.AlterTableOperation alterTableOperation = new global::System.Data.Entity.Migrations.Model.AlterTableOperation(this.Name, this.Annotations.ToDictionary((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(a.Value.NewValue, a.Value.OldValue)), null);
				alterTableOperation._columns.AddRange(this._columns);
				return alterTableOperation;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0001EEFB File Offset: 0x0001D0FB
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0001EEFE File Offset: 0x0001D0FE
		bool global::System.Data.Entity.Migrations.Model.IAnnotationTarget.HasAnnotations
		{
			get
			{
				if (!this.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>())
				{
					return this.Columns.SelectMany((global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.Annotations).Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>();
				}
				return true;
			}
		}

		// Token: 0x0400084A RID: 2122
		private readonly string _name;

		// Token: 0x0400084B RID: 2123
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.ColumnModel> _columns = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.ColumnModel>();

		// Token: 0x0400084C RID: 2124
		private readonly global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> _annotations;
	}
}
