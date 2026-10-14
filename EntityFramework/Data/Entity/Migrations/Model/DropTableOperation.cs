using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B9 RID: 185
	public class DropTableOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation, global::System.Data.Entity.Migrations.Model.IAnnotationTarget
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x0001F7DF File Offset: 0x0001D9DF
		public DropTableOperation(string name, object anonymousArguments = null) : this(name, null, null, null, anonymousArguments)
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0001F7EC File Offset: 0x0001D9EC
		public DropTableOperation(string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> removedColumnAnnotations, object anonymousArguments = null) : this(name, removedAnnotations, removedColumnAnnotations, null, anonymousArguments)
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0001F7FA File Offset: 0x0001D9FA
		public DropTableOperation(string name, global::System.Data.Entity.Migrations.Model.CreateTableOperation inverse, object anonymousArguments = null) : this(name, null, null, inverse, anonymousArguments)
		{
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0001F808 File Offset: 0x0001DA08
		public DropTableOperation(string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> removedColumnAnnotations, global::System.Data.Entity.Migrations.Model.CreateTableOperation inverse, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._removedAnnotations = (removedAnnotations ?? new global::System.Collections.Generic.Dictionary<string, object>());
			this._removedColumnAnnotations = (removedColumnAnnotations ?? new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IDictionary<string, object>>());
			this._inverse = inverse;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0001F858 File Offset: 0x0001DA58
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0001F860 File Offset: 0x0001DA60
		public virtual global::System.Collections.Generic.IDictionary<string, object> RemovedAnnotations
		{
			get
			{
				return this._removedAnnotations;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0001F868 File Offset: 0x0001DA68
		public global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> RemovedColumnAnnotations
		{
			get
			{
				return this._removedColumnAnnotations;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0001F870 File Offset: 0x0001DA70
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return this._inverse;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0001F878 File Offset: 0x0001DA78
		public override bool IsDestructiveChange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0001F87C File Offset: 0x0001DA7C
		bool global::System.Data.Entity.Migrations.Model.IAnnotationTarget.HasAnnotations
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = this.Inverse as global::System.Data.Entity.Migrations.Model.CreateTableOperation;
				return this.RemovedAnnotations.Any<global::System.Collections.Generic.KeyValuePair<string, object>>() || this.RemovedColumnAnnotations.Any<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IDictionary<string, object>>>() || (createTableOperation != null && ((global::System.Data.Entity.Migrations.Model.IAnnotationTarget)createTableOperation).HasAnnotations);
			}
		}

		// Token: 0x04000862 RID: 2146
		private readonly string _name;

		// Token: 0x04000863 RID: 2147
		private readonly global::System.Data.Entity.Migrations.Model.CreateTableOperation _inverse;

		// Token: 0x04000864 RID: 2148
		private readonly global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> _removedColumnAnnotations;

		// Token: 0x04000865 RID: 2149
		private readonly global::System.Collections.Generic.IDictionary<string, object> _removedAnnotations;
	}
}
