using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C4 RID: 1732
	public sealed class DbInsertCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
	{
		// Token: 0x06005108 RID: 20744 RVA: 0x00121A56 File Offset: 0x0011FC56
		internal DbInsertCommandTree()
		{
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00121A5E File Offset: 0x0011FC5E
		public DbInsertCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> setClauses, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression returning) : base(metadata, dataSpace, target)
		{
			this._setClauses = setClauses;
			this._returning = returning;
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x00121A79 File Offset: 0x0011FC79
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> SetClauses
		{
			get
			{
				return this._setClauses;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x00121A81 File Offset: 0x0011FC81
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Returning
		{
			get
			{
				return this._returning;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x00121A89 File Offset: 0x0011FC89
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind CommandTreeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x0600510D RID: 20749 RVA: 0x00121A8C File Offset: 0x0011FC8C
		internal override bool HasReader
		{
			get
			{
				return this.Returning != null;
			}
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00121A98 File Offset: 0x0011FC98
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			base.DumpStructure(dumper);
			dumper.Begin("SetClauses");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in this.SetClauses)
			{
				if (dbModificationClause != null)
				{
					dbModificationClause.DumpStructure(dumper);
				}
			}
			dumper.End("SetClauses");
			if (this.Returning != null)
			{
				dumper.Dump(this.Returning, "Returning");
			}
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00121B20 File Offset: 0x0011FD20
		internal override string PrintTree(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter printer)
		{
			return printer.Print(this);
		}

		// Token: 0x04001DAA RID: 7594
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> _setClauses;

		// Token: 0x04001DAB RID: 7595
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _returning;
	}
}
