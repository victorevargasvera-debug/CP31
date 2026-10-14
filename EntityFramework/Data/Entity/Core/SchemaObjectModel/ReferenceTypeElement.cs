using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000305 RID: 773
	internal class ReferenceTypeElement : global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x000669C4 File Offset: 0x00064BC4
		internal ReferenceTypeElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement)
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x000669CD File Offset: 0x00064BCD
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Type"))
			{
				this.HandleTypeElementAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x000669F4 File Offset: 0x00064BF4
		protected void HandleTypeElementAttribute(global::System.Xml.XmlReader reader)
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

		// Token: 0x0600249B RID: 9371 RVA: 0x00066A29 File Offset: 0x00064C29
		internal override void WriteIdentity(global::System.Text.StringBuilder builder)
		{
			builder.Append("Ref(" + base.UnresolvedType + ")");
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00066A47 File Offset: 0x00064C47
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			return this._typeUsage;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00066A50 File Offset: 0x00064C50
		internal override bool ResolveNameAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			if (this._typeUsage == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType = new global::System.Data.Entity.Core.Metadata.Edm.RefType(((global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(this._type, this._type.Schema.ProviderManifest, convertedItemCache, newGlobalItems)) as global::System.Data.Entity.Core.Metadata.Edm.EntityType);
				refType.AddMetadataProperties(base.OtherContent);
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(refType);
			}
			return true;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00066AAB File Offset: 0x00064CAB
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateRefType(this, this._type);
		}
	}
}
