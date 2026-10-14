using System;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000302 RID: 770
	internal abstract class Property : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x06002487 RID: 9351 RVA: 0x00066853 File Offset: 0x00064A53
		internal Property(global::System.Data.Entity.Core.SchemaObjectModel.StructuredType parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002488 RID: 9352
		public abstract global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type { get; }

		// Token: 0x06002489 RID: 9353 RVA: 0x00066860 File Offset: 0x00064A60
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
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
			}
			return false;
		}
	}
}
