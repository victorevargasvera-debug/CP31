using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D9 RID: 1753
	public sealed class DbQueryCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree
	{
		// Token: 0x06005180 RID: 20864 RVA: 0x00123018 File Offset: 0x00121218
		public DbQueryCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query, bool validate, bool useDatabaseNullSemantics, bool disableFilterOverProjectionSimplificationForCustomFunctions) : base(metadata, dataSpace, useDatabaseNullSemantics, disableFilterOverProjectionSimplificationForCustomFunctions)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(query, "query");
			if (validate)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionValidator dbExpressionValidator = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionValidator(metadata, dataSpace);
				dbExpressionValidator.ValidateExpression(query, "query");
				this._parameters = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>((from paramInfo in dbExpressionValidator.Parameters
				select paramInfo.Value).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>());
			}
			this._query = query;
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00123096 File Offset: 0x00121296
		public DbQueryCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query, bool validate, bool useDatabaseNullSemantics) : this(metadata, dataSpace, query, validate, useDatabaseNullSemantics, false)
		{
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x001230A6 File Offset: 0x001212A6
		public DbQueryCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query, bool validate) : this(metadata, dataSpace, query, validate, true, false)
		{
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x001230B5 File Offset: 0x001212B5
		public DbQueryCommandTree(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query) : this(metadata, dataSpace, query, true, true, false)
		{
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x001230C3 File Offset: 0x001212C3
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Query
		{
			get
			{
				return this._query;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06005185 RID: 20869 RVA: 0x001230CB File Offset: 0x001212CB
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind CommandTreeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Query;
			}
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x001230CE File Offset: 0x001212CE
		internal override global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> GetParameters()
		{
			if (this._parameters == null)
			{
				this._parameters = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ParameterRetriever.GetParameters(this);
			}
			return from p in this._parameters
			select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(p.ParameterName, p.ResultType);
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0012310E File Offset: 0x0012130E
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			if (this.Query != null)
			{
				dumper.Dump(this.Query, "Query");
			}
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00123129 File Offset: 0x00121329
		internal override string PrintTree(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter printer)
		{
			return printer.Print(this);
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00123132 File Offset: 0x00121332
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree FromValidExpression(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query, bool useDatabaseNullSemantics, bool disableFilterOverProjectionSimplificationForCustomFunctions)
		{
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree(metadata, dataSpace, query, false, useDatabaseNullSemantics, disableFilterOverProjectionSimplificationForCustomFunctions);
		}

		// Token: 0x04001DC6 RID: 7622
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _query;

		// Token: 0x04001DC7 RID: 7623
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> _parameters;
	}
}
