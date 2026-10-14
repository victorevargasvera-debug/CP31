using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E6 RID: 742
	internal sealed class DocumentationElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x00062C4B File Offset: 0x00060E4B
		public DocumentationElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x00062C60 File Offset: 0x00060E60
		public global::System.Data.Entity.Core.Metadata.Edm.Documentation MetadataDocumentation
		{
			get
			{
				this._metdataDocumentation.SetReadOnly();
				return this._metdataDocumentation;
			}
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00062C73 File Offset: 0x00060E73
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "Summary"))
			{
				this.HandleSummaryElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "LongDescription"))
			{
				this.HandleLongDescriptionElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00062CAF File Offset: 0x00060EAF
		protected override bool HandleText(global::System.Xml.XmlReader reader)
		{
			if (!string.IsNullOrWhiteSpace(reader.Value))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedXmlElement, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDocumentationBothTextAndStructure);
			}
			return true;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00062CD0 File Offset: 0x00060ED0
		private void HandleSummaryElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TextElement textElement = new global::System.Data.Entity.Core.SchemaObjectModel.TextElement(this);
			textElement.Parse(reader);
			this._metdataDocumentation.Summary = textElement.Value;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00062CFC File Offset: 0x00060EFC
		private void HandleLongDescriptionElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TextElement textElement = new global::System.Data.Entity.Core.SchemaObjectModel.TextElement(this);
			textElement.Parse(reader);
			this._metdataDocumentation.LongDescription = textElement.Value;
		}

		// Token: 0x04000C17 RID: 3095
		private readonly global::System.Data.Entity.Core.Metadata.Edm.Documentation _metdataDocumentation = new global::System.Data.Entity.Core.Metadata.Edm.Documentation();
	}
}
