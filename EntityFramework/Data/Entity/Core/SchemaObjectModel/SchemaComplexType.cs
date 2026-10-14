using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000311 RID: 785
	internal sealed class SchemaComplexType : global::System.Data.Entity.Core.SchemaObjectModel.StructuredType
	{
		// Token: 0x06002569 RID: 9577 RVA: 0x00069DF9 File Offset: 0x00067FF9
		internal SchemaComplexType(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				base.OtherContent.Add(base.Schema.SchemaSource);
			}
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00069E25 File Offset: 0x00068025
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (base.BaseType != null && !(base.BaseType is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidBaseType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidBaseTypeForNestedType(base.BaseType.FQName, this.FQName));
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00069E61 File Offset: 0x00068061
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "ValueAnnotation"))
			{
				this.SkipElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "TypeAnnotation"))
			{
				this.SkipElement(reader);
				return true;
			}
			return false;
		}
	}
}
