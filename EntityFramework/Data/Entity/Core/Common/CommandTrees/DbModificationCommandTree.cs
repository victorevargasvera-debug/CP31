using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006CF RID: 1743
	public abstract class DbModificationCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree
	{
		// Token: 0x0600514E RID: 20814 RVA: 0x00122CBA File Offset: 0x00120EBA
		internal DbModificationCommandTree()
		{
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00122CC2 File Offset: 0x00120EC2
		internal DbModificationCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target) : base(metadata, dataSpace, true, false)
		{
			this._target = target;
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x00122CD5 File Offset: 0x00120ED5
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Target
		{
			get
			{
				return this._target;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06005151 RID: 20817
		internal abstract bool HasReader { get; }

		// Token: 0x06005152 RID: 20818 RVA: 0x00122CDD File Offset: 0x00120EDD
		internal override global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> GetParameters()
		{
			if (this._parameters == null)
			{
				this._parameters = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ParameterRetriever.GetParameters(this);
			}
			return from p in this._parameters
			select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(p.ParameterName, p.ResultType);
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00122D1D File Offset: 0x00120F1D
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			if (this.Target != null)
			{
				dumper.Dump(this.Target, "Target");
			}
		}

		// Token: 0x04001DBA RID: 7610
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _target;

		// Token: 0x04001DBB RID: 7611
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> _parameters;
	}
}
