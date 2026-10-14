using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002F6 RID: 758
	internal sealed class IntegerFacetDescriptionElement : global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement
	{
		// Token: 0x0600242A RID: 9258 RVA: 0x0006594D File Offset: 0x00063B4D
		public IntegerFacetDescriptionElement(global::System.Data.Entity.Core.SchemaObjectModel.TypeElement type, string name) : base(type, name)
		{
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x00065957 File Offset: 0x00063B57
		public override global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00065968 File Offset: 0x00063B68
		protected override void HandleDefaultAttribute(global::System.Xml.XmlReader reader)
		{
			int num = -1;
			if (base.HandleIntAttribute(reader, ref num))
			{
				base.DefaultValue = num;
			}
		}
	}
}
