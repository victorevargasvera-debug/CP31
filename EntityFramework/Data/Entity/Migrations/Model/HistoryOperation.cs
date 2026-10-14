using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000BB RID: 187
	public class HistoryOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F73 RID: 3955 RVA: 0x0001F996 File Offset: 0x0001DB96
		public HistoryOperation(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> commandTrees, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>>(commandTrees, "commandTrees");
			if (!commandTrees.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CollectionEmpty("commandTrees", "HistoryOperation"));
			}
			this._commandTrees = commandTrees;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0001F9CF File Offset: 0x0001DBCF
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> CommandTrees
		{
			get
			{
				return this._commandTrees;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0001F9D7 File Offset: 0x0001DBD7
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400086A RID: 2154
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> _commandTrees;
	}
}
