using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002EB RID: 747
	internal sealed class EntityContainerEntitySetDefiningQuery : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060023A3 RID: 9123 RVA: 0x00063DBC File Offset: 0x00061FBC
		public EntityContainerEntitySetDefiningQuery(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x00063DC6 File Offset: 0x00061FC6
		public string Query
		{
			get
			{
				return this._query;
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00063DCE File Offset: 0x00061FCE
		protected override bool HandleText(global::System.Xml.XmlReader reader)
		{
			this._query = reader.Value;
			return true;
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00063DDD File Offset: 0x00061FDD
		internal override void Validate()
		{
			base.Validate();
			if (string.IsNullOrEmpty(this._query))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EmptyDefiningQuery, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EmptyDefiningQuery);
			}
		}

		// Token: 0x04000C28 RID: 3112
		private string _query;
	}
}
