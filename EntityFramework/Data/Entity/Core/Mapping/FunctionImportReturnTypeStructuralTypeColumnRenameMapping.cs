using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000541 RID: 1345
	internal class FunctionImportReturnTypeStructuralTypeColumnRenameMapping
	{
		// Token: 0x06004210 RID: 16912 RVA: 0x000DEC74 File Offset: 0x000DCE74
		internal FunctionImportReturnTypeStructuralTypeColumnRenameMapping(string defaultMemberName)
		{
			this._defaultMemberName = defaultMemberName;
			this._columnListForType = new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn>();
			this._columnListForIsTypeOfType = new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn>();
			this._renameCache = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn>(this.GetRename), global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>.Default);
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x000DECC0 File Offset: 0x000DCEC0
		internal string GetRename(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			global::System.Xml.IXmlLineInfo xmlLineInfo;
			return this.GetRename(type, out xmlLineInfo);
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x000DECD8 File Offset: 0x000DCED8
		internal string GetRename(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, out global::System.Xml.IXmlLineInfo lineInfo)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn functionImportReturnTypeStructuralTypeColumn = this._renameCache.Evaluate(type as global::System.Data.Entity.Core.Metadata.Edm.StructuralType);
			lineInfo = functionImportReturnTypeStructuralTypeColumn.LineInfo;
			return functionImportReturnTypeStructuralTypeColumn.ColumnName;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x000DED08 File Offset: 0x000DCF08
		private global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn GetRename(global::System.Data.Entity.Core.Metadata.Edm.StructuralType typeForRename)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn functionImportReturnTypeStructuralTypeColumn = this._columnListForType.FirstOrDefault((global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn t) => t.Type == typeForRename);
			if (functionImportReturnTypeStructuralTypeColumn != null)
			{
				return functionImportReturnTypeStructuralTypeColumn;
			}
			global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn functionImportReturnTypeStructuralTypeColumn2 = (from t in this._columnListForIsTypeOfType
			where t.Type == typeForRename
			select t).LastOrDefault<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn>();
			if (functionImportReturnTypeStructuralTypeColumn2 != null)
			{
				return functionImportReturnTypeStructuralTypeColumn2;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn> enumerable = from t in this._columnListForIsTypeOfType
			where t.Type.IsAssignableFrom(typeForRename)
			select t;
			if (enumerable.Count<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn>() == 0)
			{
				return new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn(this._defaultMemberName, typeForRename, false, null);
			}
			return global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping.GetLowestParentInHierarchy(enumerable);
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x000DED9C File Offset: 0x000DCF9C
		private static global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn GetLowestParentInHierarchy(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn> nodesInHierarchy)
		{
			global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn functionImportReturnTypeStructuralTypeColumn = null;
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn functionImportReturnTypeStructuralTypeColumn2 in nodesInHierarchy)
			{
				if (functionImportReturnTypeStructuralTypeColumn == null)
				{
					functionImportReturnTypeStructuralTypeColumn = functionImportReturnTypeStructuralTypeColumn2;
				}
				else if (functionImportReturnTypeStructuralTypeColumn.Type.IsAssignableFrom(functionImportReturnTypeStructuralTypeColumn2.Type))
				{
					functionImportReturnTypeStructuralTypeColumn = functionImportReturnTypeStructuralTypeColumn2;
				}
			}
			return functionImportReturnTypeStructuralTypeColumn;
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x000DEDFC File Offset: 0x000DCFFC
		internal void AddRename(global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn renamedColumn)
		{
			if (!renamedColumn.IsTypeOf)
			{
				this._columnListForType.Add(renamedColumn);
				return;
			}
			this._columnListForIsTypeOfType.Add(renamedColumn);
		}

		// Token: 0x040016EA RID: 5866
		private readonly global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn> _columnListForType;

		// Token: 0x040016EB RID: 5867
		private readonly global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn> _columnListForIsTypeOfType;

		// Token: 0x040016EC RID: 5868
		private readonly string _defaultMemberName;

		// Token: 0x040016ED RID: 5869
		private readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.StructuralType, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn> _renameCache;
	}
}
