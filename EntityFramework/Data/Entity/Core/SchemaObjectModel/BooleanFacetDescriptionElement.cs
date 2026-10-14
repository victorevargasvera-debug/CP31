using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E3 RID: 739
	internal sealed class BooleanFacetDescriptionElement : global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement
	{
		// Token: 0x0600234C RID: 9036 RVA: 0x00062886 File Offset: 0x00060A86
		public BooleanFacetDescriptionElement(global::System.Data.Entity.Core.SchemaObjectModel.TypeElement type, string name) : base(type, name)
		{
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x00062890 File Offset: 0x00060A90
		public override global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
			}
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000628A0 File Offset: 0x00060AA0
		protected override void HandleDefaultAttribute(global::System.Xml.XmlReader reader)
		{
			bool flag = false;
			if (base.HandleBoolAttribute(reader, ref flag))
			{
				base.DefaultValue = flag;
			}
		}
	}
}
