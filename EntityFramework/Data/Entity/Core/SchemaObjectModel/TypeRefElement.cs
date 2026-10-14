using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000323 RID: 803
	internal class TypeRefElement : global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement
	{
		// Token: 0x06002629 RID: 9769 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		internal TypeRefElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement)
		{
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x0006C3CD File Offset: 0x0006A5CD
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Type"))
			{
				this.HandleTypeAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0006C3F4 File Offset: 0x0006A5F4
		protected void HandleTypeAttribute(global::System.Xml.XmlReader reader)
		{
			string text;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out text))
			{
				return;
			}
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.ValidateDottedName(base.Schema, reader, text))
			{
				return;
			}
			this._unresolvedType = text;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0006C42C File Offset: 0x0006A62C
		internal override bool ResolveNameAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			if (this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)
			{
				this._typeUsageBuilder.ValidateAndSetTypeUsage(this._type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType, false);
				this._typeUsage = this._typeUsageBuilder.TypeUsage;
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(this._type, this._type.Schema.ProviderManifest, convertedItemCache, newGlobalItems);
			if (edmType != null)
			{
				this._typeUsageBuilder.ValidateAndSetTypeUsage(edmType, false);
				this._typeUsage = this._typeUsageBuilder.TypeUsage;
			}
			return this._typeUsage != null;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0006C4BD File Offset: 0x0006A6BD
		internal override void WriteIdentity(global::System.Text.StringBuilder builder)
		{
			builder.Append(base.UnresolvedType);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0006C4CC File Offset: 0x0006A6CC
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			return this._typeUsage;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateFacets(this, this._type, this._typeUsageBuilder);
		}
	}
}
