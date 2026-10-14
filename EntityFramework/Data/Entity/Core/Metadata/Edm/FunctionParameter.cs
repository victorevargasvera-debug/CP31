using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C8 RID: 1224
	public sealed class FunctionParameter : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem
	{
		// Token: 0x06003C91 RID: 15505 RVA: 0x000C80E7 File Offset: 0x000C62E7
		internal FunctionParameter()
		{
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x000C80FA File Offset: 0x000C62FA
		internal FunctionParameter(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode parameterMode)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
			this._name = name;
			this._typeUsage = typeUsage;
			base.SetParameterMode(parameterMode);
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x000C813A File Offset: 0x000C633A
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06003C94 RID: 15508 RVA: 0x000C813E File Offset: 0x000C633E
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ParameterMode, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.ParameterMode Mode
		{
			get
			{
				return base.GetParameterMode();
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x000C8146 File Offset: 0x000C6346
		string global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem.Identity
		{
			get
			{
				return this.Identity;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06003C96 RID: 15510 RVA: 0x000C814E File Offset: 0x000C634E
		internal override string Identity
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x000C8156 File Offset: 0x000C6356
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x000C815E File Offset: 0x000C635E
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this.SetName(value);
			}
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x000C8174 File Offset: 0x000C6374
		private void SetName(string name)
		{
			this._name = name;
			if (this.DeclaringFunction == null)
			{
				return;
			}
			((this.Mode == global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue) ? this.DeclaringFunction.ReturnParameters.Source : this.DeclaringFunction.Parameters.Source).InvalidateCache();
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06003C9A RID: 15514 RVA: 0x000C81C1 File Offset: 0x000C63C1
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsage;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x000C81C9 File Offset: 0x000C63C9
		public string TypeName
		{
			get
			{
				return this.TypeUsage.EdmType.Name;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06003C9C RID: 15516 RVA: 0x000C81DC File Offset: 0x000C63DC
		public bool IsMaxLengthConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x000C8210 File Offset: 0x000C6410
		public int? MaxLength
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet))
				{
					return null;
				}
				return facet.Value as int?;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x000C8254 File Offset: 0x000C6454
		public bool IsMaxLength
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet) && facet.IsUnbounded;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x000C8284 File Offset: 0x000C6484
		public bool IsPrecisionConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("Precision", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06003CA0 RID: 15520 RVA: 0x000C82B8 File Offset: 0x000C64B8
		public byte? Precision
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("Precision", false, out facet))
				{
					return null;
				}
				return facet.Value as byte?;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x000C82FC File Offset: 0x000C64FC
		public bool IsScaleConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("Scale", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06003CA2 RID: 15522 RVA: 0x000C8330 File Offset: 0x000C6530
		public byte? Scale
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("Scale", false, out facet))
				{
					return null;
				}
				return facet.Value as byte?;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x000C8371 File Offset: 0x000C6571
		public global::System.Data.Entity.Core.Metadata.Edm.EdmFunction DeclaringFunction
		{
			get
			{
				return this._declaringFunction.Value;
			}
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x000C837E File Offset: 0x000C657E
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x000C8386 File Offset: 0x000C6586
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x000C8396 File Offset: 0x000C6596
		public static global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter Create(string name, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode parameterMode)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(edmType, "edmType");
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, global::System.Data.Entity.Core.Metadata.Edm.FacetValues.NullFacetValues), parameterMode);
			functionParameter.SetReadOnly();
			return functionParameter;
		}

		// Token: 0x040014D9 RID: 5337
		internal static global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, global::System.Data.Entity.Core.Metadata.Edm.SafeLink<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> DeclaringFunctionLinker = (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter fp) => fp._declaringFunction;

		// Token: 0x040014DA RID: 5338
		private readonly global::System.Data.Entity.Core.Metadata.Edm.SafeLink<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _declaringFunction = new global::System.Data.Entity.Core.Metadata.Edm.SafeLink<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();

		// Token: 0x040014DB RID: 5339
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;

		// Token: 0x040014DC RID: 5340
		private string _name;
	}
}
