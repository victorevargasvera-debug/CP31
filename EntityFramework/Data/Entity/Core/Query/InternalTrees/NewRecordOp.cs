using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003BF RID: 959
	internal sealed class NewRecordOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002DE2 RID: 11746 RVA: 0x00091613 File Offset: 0x0008F813
		internal NewRecordOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord, type)
		{
			this.m_fields = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(type).Properties);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00091634 File Offset: 0x0008F834
		internal NewRecordOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> fields) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord, type)
		{
			this.m_fields = fields;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00091646 File Offset: 0x0008F846
		private NewRecordOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord)
		{
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00091650 File Offset: 0x0008F850
		internal bool GetFieldPosition(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty field, out int fieldPosition)
		{
			fieldPosition = 0;
			for (int i = 0; i < this.m_fields.Count; i++)
			{
				if (this.m_fields[i] == field)
				{
					fieldPosition = i;
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x0009168B File Offset: 0x0008F88B
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> Properties
		{
			get
			{
				return this.m_fields;
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00091693 File Offset: 0x0008F893
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0009169D File Offset: 0x0008F89D
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F58 RID: 3928
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> m_fields;

		// Token: 0x04000F59 RID: 3929
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp();
	}
}
