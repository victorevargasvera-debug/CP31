using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000532 RID: 1330
	public sealed class FunctionImportComplexTypeMapping : global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping
	{
		// Token: 0x060041B5 RID: 16821 RVA: 0x000DCF52 File Offset: 0x000DB152
		public FunctionImportComplexTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.ComplexType returnType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> properties) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(returnType, "returnType"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>>(properties, "properties"), global::System.Data.Entity.Core.Mapping.LineInfo.Empty)
		{
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000DCF75 File Offset: 0x000DB175
		internal FunctionImportComplexTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.ComplexType returnType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> properties, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo) : base(properties, lineInfo)
		{
			this._returnType = returnType;
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x000DCF86 File Offset: 0x000DB186
		public global::System.Data.Entity.Core.Metadata.Edm.ComplexType ReturnType
		{
			get
			{
				return this._returnType;
			}
		}

		// Token: 0x040016C6 RID: 5830
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ComplexType _returnType;
	}
}
