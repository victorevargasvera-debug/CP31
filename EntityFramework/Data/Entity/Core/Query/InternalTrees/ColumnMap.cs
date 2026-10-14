using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000387 RID: 903
	internal abstract class ColumnMap
	{
		// Token: 0x06002BD5 RID: 11221 RVA: 0x0008D0D1 File Offset: 0x0008B2D1
		internal ColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			this._type = type;
			this._name = name;
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x0008D0E7 File Offset: 0x0008B2E7
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x0008D0EF File Offset: 0x0008B2EF
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x0008D0F8 File Offset: 0x0008B2F8
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0008D100 File Offset: 0x0008B300
		internal string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x0008D109 File Offset: 0x0008B309
		internal bool IsNamed
		{
			get
			{
				return this._name != null;
			}
		}

		// Token: 0x06002BDB RID: 11227
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal abstract void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg);

		// Token: 0x06002BDC RID: 11228
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal abstract TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg);

		// Token: 0x04000EE9 RID: 3817
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _type;

		// Token: 0x04000EEA RID: 3818
		private string _name;

		// Token: 0x04000EEB RID: 3819
		internal const string DefaultColumnName = "Value";
	}
}
