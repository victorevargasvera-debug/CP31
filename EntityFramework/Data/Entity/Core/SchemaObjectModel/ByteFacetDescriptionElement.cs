using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E4 RID: 740
	internal sealed class ByteFacetDescriptionElement : global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement
	{
		// Token: 0x0600234F RID: 9039 RVA: 0x000628C6 File Offset: 0x00060AC6
		public ByteFacetDescriptionElement(global::System.Data.Entity.Core.SchemaObjectModel.TypeElement type, string name) : base(type, name)
		{
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000628D0 File Offset: 0x00060AD0
		public override global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte);
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000628E0 File Offset: 0x00060AE0
		protected override void HandleDefaultAttribute(global::System.Xml.XmlReader reader)
		{
			byte b = 0;
			if (base.HandleByteAttribute(reader, ref b))
			{
				base.DefaultValue = b;
			}
		}
	}
}
