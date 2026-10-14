using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B3 RID: 179
	public class CreateTableOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation, global::System.Data.Entity.Migrations.Model.IAnnotationTarget
	{
		// Token: 0x06000F3A RID: 3898 RVA: 0x0001F456 File Offset: 0x0001D656
		public CreateTableOperation(string name, object anonymousArguments = null) : this(name, null, anonymousArguments)
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0001F461 File Offset: 0x0001D661
		public CreateTableOperation(string name, global::System.Collections.Generic.IDictionary<string, object> annotations, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._annotations = (annotations ?? new global::System.Collections.Generic.Dictionary<string, object>());
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x0001F498 File Offset: 0x0001D698
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
		public virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.ColumnModel> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		public global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation PrimaryKey
		{
			get
			{
				return this._primaryKey;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation>(value, "value");
				this._primaryKey = value;
				this._primaryKey.Table = this.Name;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0001F4D6 File Offset: 0x0001D6D6
		public virtual global::System.Collections.Generic.IDictionary<string, object> Annotations
		{
			get
			{
				return this._annotations;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return new global::System.Data.Entity.Migrations.Model.DropTableOperation(this.Name, this.Annotations, (from c in this.Columns
				where c.Annotations.Count > 0
				select c).ToDictionary((global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.Name, (global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.Annotations.ToDictionary((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => a.Value.NewValue)), null);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0001F56C File Offset: 0x0001D76C
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0001F56F File Offset: 0x0001D76F
		bool global::System.Data.Entity.Migrations.Model.IAnnotationTarget.HasAnnotations
		{
			get
			{
				if (!this.Annotations.Any<global::System.Collections.Generic.KeyValuePair<string, object>>())
				{
					return this.Columns.SelectMany((global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.Annotations).Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>>();
				}
				return true;
			}
		}

		// Token: 0x04000856 RID: 2134
		private readonly string _name;

		// Token: 0x04000857 RID: 2135
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.ColumnModel> _columns = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.ColumnModel>();

		// Token: 0x04000858 RID: 2136
		private global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation _primaryKey;

		// Token: 0x04000859 RID: 2137
		private readonly global::System.Collections.Generic.IDictionary<string, object> _annotations;
	}
}
