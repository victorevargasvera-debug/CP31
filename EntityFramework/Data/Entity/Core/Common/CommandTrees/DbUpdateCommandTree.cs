using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E6 RID: 1766
	public sealed class DbUpdateCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
	{
		// Token: 0x060051BE RID: 20926 RVA: 0x001235EF File Offset: 0x001217EF
		internal DbUpdateCommandTree()
		{
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x001235F7 File Offset: 0x001217F7
		public DbUpdateCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> setClauses, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression returning) : base(metadata, dataSpace, target)
		{
			this._predicate = predicate;
			this._setClauses = setClauses;
			this._returning = returning;
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x0012361A File Offset: 0x0012181A
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> SetClauses
		{
			get
			{
				return this._setClauses;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x00123622 File Offset: 0x00121822
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Returning
		{
			get
			{
				return this._returning;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x0012362A File Offset: 0x0012182A
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Predicate
		{
			get
			{
				return this._predicate;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x00123632 File Offset: 0x00121832
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind CommandTreeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Update;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x00123635 File Offset: 0x00121835
		internal override bool HasReader
		{
			get
			{
				return this.Returning != null;
			}
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x00123640 File Offset: 0x00121840
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			base.DumpStructure(dumper);
			if (this.Predicate != null)
			{
				dumper.Dump(this.Predicate, "Predicate");
			}
			dumper.Begin("SetClauses", null);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in this.SetClauses)
			{
				if (dbModificationClause != null)
				{
					dbModificationClause.DumpStructure(dumper);
				}
			}
			dumper.End("SetClauses");
			dumper.Dump(this.Returning, "Returning");
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x001236D8 File Offset: 0x001218D8
		internal override string PrintTree(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter printer)
		{
			return printer.Print(this);
		}

		// Token: 0x04001DDC RID: 7644
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _predicate;

		// Token: 0x04001DDD RID: 7645
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _returning;

		// Token: 0x04001DDE RID: 7646
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> _setClauses;
	}
}
