using System;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B0 RID: 1712
	public sealed class DbDeleteCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
	{
		// Token: 0x0600503F RID: 20543 RVA: 0x00121236 File Offset: 0x0011F436
		internal DbDeleteCommandTree()
		{
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x0012123E File Offset: 0x0011F43E
		public DbDeleteCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate) : base(metadata, dataSpace, target)
		{
			this._predicate = predicate;
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x00121251 File Offset: 0x0011F451
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Predicate
		{
			get
			{
				return this._predicate;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x00121259 File Offset: 0x0011F459
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind CommandTreeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Delete;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x0012125C File Offset: 0x0011F45C
		internal override bool HasReader
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x0012125F File Offset: 0x0011F45F
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			base.DumpStructure(dumper);
			if (this.Predicate != null)
			{
				dumper.Dump(this.Predicate, "Predicate");
			}
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00121281 File Offset: 0x0011F481
		internal override string PrintTree(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter printer)
		{
			return printer.Print(this);
		}

		// Token: 0x04001D54 RID: 7508
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _predicate;
	}
}
