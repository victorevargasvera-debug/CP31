using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002FE RID: 766
	internal sealed class OnOperation : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x06002465 RID: 9317 RVA: 0x00066065 File Offset: 0x00064265
		public OnOperation(global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd parentElement, global::System.Data.Entity.Core.SchemaObjectModel.Operation operation) : base(parentElement, null)
		{
			this.Operation = operation;
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x00066076 File Offset: 0x00064276
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x0006607E File Offset: 0x0006427E
		public global::System.Data.Entity.Core.SchemaObjectModel.Operation Operation { get; private set; }

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x00066087 File Offset: 0x00064287
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x0006608F File Offset: 0x0006428F
		public global::System.Data.Entity.Core.SchemaObjectModel.Action Action { get; private set; }

		// Token: 0x0600246A RID: 9322 RVA: 0x00066098 File Offset: 0x00064298
		protected override bool ProhibitAttribute(string namespaceUri, string localName)
		{
			if (base.ProhibitAttribute(namespaceUri, localName))
			{
				return true;
			}
			if (namespaceUri == null)
			{
				localName == "Name";
				return false;
			}
			return false;
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000660B8 File Offset: 0x000642B8
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Action"))
			{
				this.HandleActionAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000660DC File Offset: 0x000642DC
		private void HandleActionAttribute(global::System.Xml.XmlReader reader)
		{
			string text = reader.Value.Trim();
			if (text != null)
			{
				if (text == "None")
				{
					this.Action = global::System.Data.Entity.Core.SchemaObjectModel.Action.None;
					return;
				}
				if (text == "Cascade")
				{
					this.Action = global::System.Data.Entity.Core.SchemaObjectModel.Action.Cascade;
					return;
				}
			}
			base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidAction, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.InvalidAction(reader.Value, this.ParentElement.FQName));
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x00066144 File Offset: 0x00064344
		private new global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd ParentElement
		{
			get
			{
				return (global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd)base.ParentElement;
			}
		}
	}
}
