using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200031D RID: 797
	internal sealed class SridFacetDescriptionElement : global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement
	{
		// Token: 0x060025E8 RID: 9704 RVA: 0x0006B68E File Offset: 0x0006988E
		public SridFacetDescriptionElement(global::System.Data.Entity.Core.SchemaObjectModel.TypeElement type, string name) : base(type, name)
		{
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x0006B698 File Offset: 0x00069898
		public override global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x0006B6A8 File Offset: 0x000698A8
		protected override void HandleDefaultAttribute(global::System.Xml.XmlReader reader)
		{
			if (reader.Value.Trim() == "Variable")
			{
				base.DefaultValue = global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.VariableValue;
				return;
			}
			int num = -1;
			if (base.HandleIntAttribute(reader, ref num))
			{
				base.DefaultValue = num;
			}
		}
	}
}
