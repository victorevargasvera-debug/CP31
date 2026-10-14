using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006BE RID: 1726
	public sealed class DbFunctionCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree
	{
		// Token: 0x060050E6 RID: 20710 RVA: 0x001217C0 File Offset: 0x0011F9C0
		public DbFunctionCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> parameters) : base(metadata, dataSpace, true, false)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(edmFunction, "edmFunction");
			this._edmFunction = edmFunction;
			this._resultType = resultType;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			if (parameters != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in parameters)
				{
					list.Add(keyValuePair.Key);
					list2.Add(keyValuePair.Value);
				}
			}
			this._parameterNames = new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(list);
			this._parameterTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(list2);
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x0012186C File Offset: 0x0011FA6C
		public global::System.Data.Entity.Core.Metadata.Edm.EdmFunction EdmFunction
		{
			get
			{
				return this._edmFunction;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x00121874 File Offset: 0x0011FA74
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResultType
		{
			get
			{
				return this._resultType;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060050E9 RID: 20713 RVA: 0x0012187C File Offset: 0x0011FA7C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind CommandTreeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Function;
			}
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x0012187F File Offset: 0x0011FA7F
		internal override global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> GetParameters()
		{
			int num;
			for (int idx = 0; idx < this._parameterNames.Count; idx = num + 1)
			{
				yield return new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(this._parameterNames[idx], this._parameterTypes[idx]);
				num = idx;
			}
			yield break;
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x0012188F File Offset: 0x0011FA8F
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			if (this.EdmFunction != null)
			{
				dumper.Dump(this.EdmFunction);
			}
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x001218A5 File Offset: 0x0011FAA5
		internal override string PrintTree(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter printer)
		{
			return printer.Print(this);
		}

		// Token: 0x04001D9B RID: 7579
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction _edmFunction;

		// Token: 0x04001D9C RID: 7580
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _resultType;

		// Token: 0x04001D9D RID: 7581
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<string> _parameterNames;

		// Token: 0x04001D9E RID: 7582
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> _parameterTypes;
	}
}
