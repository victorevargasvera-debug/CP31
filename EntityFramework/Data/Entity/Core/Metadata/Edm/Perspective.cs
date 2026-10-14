using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004EB RID: 1259
	internal abstract class Perspective
	{
		// Token: 0x06003EBE RID: 16062 RVA: 0x000D00AE File Offset: 0x000CE2AE
		internal Perspective(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace targetDataspace)
		{
			this._metadataWorkspace = metadataWorkspace;
			this._targetDataspace = targetDataspace;
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x000D00C4 File Offset: 0x000CE2C4
		internal virtual bool TryGetMember(global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, string memberName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmMember outMember)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(memberName, "memberName");
			outMember = null;
			return type.Members.TryGetValue(memberName, ignoreCase, out outMember);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x000D00E5 File Offset: 0x000CE2E5
		internal virtual bool TryGetEnumMember(global::System.Data.Entity.Core.Metadata.Edm.EnumType type, string memberName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EnumMember outMember)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(memberName, "memberName");
			outMember = null;
			return type.Members.TryGetValue(memberName, ignoreCase, out outMember);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x000D0106 File Offset: 0x000CE306
		internal virtual bool TryGetExtent(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, string extentName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase outSet)
		{
			return entityContainer.BaseEntitySets.TryGetValue(extentName, ignoreCase, out outSet);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x000D0118 File Offset: 0x000CE318
		internal virtual bool TryGetFunctionImport(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer, string functionImportName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			functionImport = null;
			if (ignoreCase)
			{
				functionImport = (from fi in entityContainer.FunctionImports
				where string.Equals(fi.Name, functionImportName, global::System.StringComparison.OrdinalIgnoreCase)
				select fi).SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();
			}
			else
			{
				functionImport = (from fi in entityContainer.FunctionImports
				where fi.Name == functionImportName
				select fi).SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();
			}
			return functionImport != null;
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x000D017F File Offset: 0x000CE37F
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.EntityContainer GetDefaultContainer()
		{
			return null;
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x000D0182 File Offset: 0x000CE382
		internal virtual bool TryGetEntityContainer(string name, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			return this.MetadataWorkspace.TryGetEntityContainer(name, ignoreCase, this.TargetDataspace, out entityContainer);
		}

		// Token: 0x06003EC5 RID: 16069
		internal abstract bool TryGetTypeByName(string fullName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage);

		// Token: 0x06003EC6 RID: 16070 RVA: 0x000D0198 File Offset: 0x000CE398
		internal bool TryGetFunctionByName(string namespaceName, string functionName, bool ignoreCase, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionOverloads)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(functionName, "functionName");
			string functionName2 = namespaceName + "." + functionName;
			global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection = this._metadataWorkspace.GetItemCollection(this._targetDataspace);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> list = (this._targetDataspace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace) ? ((global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)itemCollection).GetCTypeFunctions(functionName2, ignoreCase) : itemCollection.GetFunctions(functionName2, ignoreCase);
			if (this._targetDataspace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer;
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction;
				if ((list == null || list.Count == 0) && this.TryGetEntityContainer(namespaceName, false, out entityContainer) && this.TryGetFunctionImport(entityContainer, functionName, false, out edmFunction))
				{
					list = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction[]
					{
						edmFunction
					};
				}
				global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection2;
				if ((list == null || list.Count == 0) && this._metadataWorkspace.TryGetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, out itemCollection2))
				{
					list = ((global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)itemCollection2).GetCTypeFunctions(functionName2, ignoreCase);
				}
			}
			functionOverloads = ((list != null && list.Count > 0) ? list : null);
			return functionOverloads != null;
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x000D0279 File Offset: 0x000CE479
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this._metadataWorkspace;
			}
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x000D0281 File Offset: 0x000CE481
		internal virtual bool TryGetMappedPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			primitiveType = this._metadataWorkspace.GetMappedPrimitiveType(primitiveTypeKind, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			return primitiveType != null;
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x000D0297 File Offset: 0x000CE497
		internal global::System.Data.Entity.Core.Metadata.Edm.DataSpace TargetDataspace
		{
			get
			{
				return this._targetDataspace;
			}
		}

		// Token: 0x0400154E RID: 5454
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadataWorkspace;

		// Token: 0x0400154F RID: 5455
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace _targetDataspace;
	}
}
