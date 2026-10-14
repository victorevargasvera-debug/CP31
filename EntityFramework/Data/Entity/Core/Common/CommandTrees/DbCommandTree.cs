using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006AB RID: 1707
	public abstract class DbCommandTree
	{
		// Token: 0x06005022 RID: 20514 RVA: 0x00120F7A File Offset: 0x0011F17A
		internal DbCommandTree()
		{
			this._useDatabaseNullSemantics = true;
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00120F89 File Offset: 0x0011F189
		internal DbCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, bool useDatabaseNullSemantics = true, bool disableFilterOverProjectionSimplificationForCustomFunctions = false)
		{
			if (!global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree.IsValidDataSpace(dataSpace))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_CommandTree_InvalidDataSpace, "dataSpace");
			}
			this._metadata = metadata;
			this._dataSpace = dataSpace;
			this._useDatabaseNullSemantics = useDatabaseNullSemantics;
			this._disableFilterOverProjectionSimplificationForCustomFunctions = disableFilterOverProjectionSimplificationForCustomFunctions;
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x00120FC6 File Offset: 0x0011F1C6
		public bool UseDatabaseNullSemantics
		{
			get
			{
				return this._useDatabaseNullSemantics;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x00120FCE File Offset: 0x0011F1CE
		public bool DisableFilterOverProjectionSimplificationForCustomFunctions
		{
			get
			{
				return this._disableFilterOverProjectionSimplificationForCustomFunctions;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x00120FD6 File Offset: 0x0011F1D6
		public global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> Parameters
		{
			get
			{
				return this.GetParameters();
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06005027 RID: 20519
		public abstract global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind CommandTreeKind { get; }

		// Token: 0x06005028 RID: 20520
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> GetParameters();

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06005029 RID: 20521 RVA: 0x00120FDE File Offset: 0x0011F1DE
		public virtual global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this._metadata;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x00120FE6 File Offset: 0x0011F1E6
		public virtual global::System.Data.Entity.Core.Metadata.Edm.DataSpace DataSpace
		{
			get
			{
				return this._dataSpace;
			}
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00120FF0 File Offset: 0x0011F1F0
		internal void Dump(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("DataSpace", this.DataSpace);
			dumper.Begin(base.GetType().Name, dictionary);
			dumper.Begin("Parameters", null);
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in this.Parameters)
			{
				dumper.Begin("Parameter", new global::System.Collections.Generic.Dictionary<string, object>
				{
					{
						"Name",
						keyValuePair.Key
					}
				});
				dumper.Dump(keyValuePair.Value, "ParameterType");
				dumper.End("Parameter");
			}
			dumper.End("Parameters");
			this.DumpStructure(dumper);
			dumper.End(base.GetType().Name);
		}

		// Token: 0x0600502C RID: 20524
		internal abstract void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper);

		// Token: 0x0600502D RID: 20525 RVA: 0x001210D4 File Offset: 0x0011F2D4
		public override string ToString()
		{
			return this.Print();
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x001210DC File Offset: 0x0011F2DC
		internal string Print()
		{
			return this.PrintTree(new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter());
		}

		// Token: 0x0600502F RID: 20527
		internal abstract string PrintTree(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter printer);

		// Token: 0x06005030 RID: 20528 RVA: 0x001210E9 File Offset: 0x0011F2E9
		internal static bool IsValidDataSpace(global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
		{
			return dataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace || global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace == dataSpace || global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace == dataSpace;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x001210F8 File Offset: 0x0011F2F8
		internal static bool IsValidParameterName(string name)
		{
			return !string.IsNullOrWhiteSpace(name) && name.IsValidUndottedName();
		}

		// Token: 0x04001D47 RID: 7495
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadata;

		// Token: 0x04001D48 RID: 7496
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace _dataSpace;

		// Token: 0x04001D49 RID: 7497
		private readonly bool _useDatabaseNullSemantics;

		// Token: 0x04001D4A RID: 7498
		private readonly bool _disableFilterOverProjectionSimplificationForCustomFunctions;
	}
}
