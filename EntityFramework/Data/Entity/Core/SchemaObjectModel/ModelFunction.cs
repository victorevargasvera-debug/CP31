using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002FB RID: 763
	internal sealed class ModelFunction : global::System.Data.Entity.Core.SchemaObjectModel.Function
	{
		// Token: 0x0600244A RID: 9290 RVA: 0x00065C09 File Offset: 0x00063E09
		public ModelFunction(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
			this._isComposable = true;
			this._typeUsageBuilder = new global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder(this);
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x00065C25 File Offset: 0x00063E25
		public override global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x00065C2D File Offset: 0x00063E2D
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				if (this._typeUsageBuilder.TypeUsage == null)
				{
					return null;
				}
				if (base.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this._typeUsageBuilder.TypeUsage));
				}
				return this._typeUsageBuilder.TypeUsage;
			}
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00065C67 File Offset: 0x00063E67
		internal void ValidateAndSetTypeUsage(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			this._typeUsageBuilder.ValidateAndSetTypeUsage(scalar, false);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00065C76 File Offset: 0x00063E76
		internal void ValidateAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			this._typeUsageBuilder.ValidateAndSetTypeUsage(edmType, false);
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00065C85 File Offset: 0x00063E85
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "DefiningExpression"))
			{
				this.HandleDefiningExpressionElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Parameter"))
			{
				base.HandleParameterElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00065CC1 File Offset: 0x00063EC1
		protected override void HandleReturnTypeAttribute(global::System.Xml.XmlReader reader)
		{
			base.HandleReturnTypeAttribute(reader);
			this._isComposable = true;
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00065CD1 File Offset: 0x00063ED1
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			return base.HandleAttribute(reader) || this._typeUsageBuilder.HandleAttribute(reader);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00065CF0 File Offset: 0x00063EF0
		internal override void ResolveTopLevelNames()
		{
			if (base.UnresolvedReturnType != null && base.Schema.ResolveTypeName(this, base.UnresolvedReturnType, out this._type) && this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)
			{
				this._typeUsageBuilder.ValidateAndSetTypeUsage(this._type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType, false);
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in base.Parameters)
			{
				parameter.ResolveTopLevelNames();
			}
			if (base.ReturnTypeList != null)
			{
				base.ReturnTypeList[0].ResolveTopLevelNames();
			}
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00065D9C File Offset: 0x00063F9C
		private void HandleDefiningExpressionElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.FunctionCommandText functionCommandText = new global::System.Data.Entity.Core.SchemaObjectModel.FunctionCommandText(this);
			functionCommandText.Parse(reader);
			this._commandText = functionCommandText;
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00065DBE File Offset: 0x00063FBE
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateFacets(this, this._type, this._typeUsageBuilder);
			if (this._isRefType)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateRefType(this, this._type);
			}
		}

		// Token: 0x04000CEB RID: 3307
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder _typeUsageBuilder;
	}
}
