using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000313 RID: 787
	[global::System.Diagnostics.DebuggerDisplay("Name={Name}")]
	internal abstract class SchemaElement
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x00069E9D File Offset: 0x0006809D
		internal int LineNumber
		{
			get
			{
				return this._lineNumber;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x00069EA5 File Offset: 0x000680A5
		internal int LinePosition
		{
			get
			{
				return this._linePosition;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x00069EAD File Offset: 0x000680AD
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x00069EB5 File Offset: 0x000680B5
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x00069EBE File Offset: 0x000680BE
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x00069EC6 File Offset: 0x000680C6
		internal global::System.Data.Entity.Core.SchemaObjectModel.DocumentationElement Documentation { get; set; }

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x00069ECF File Offset: 0x000680CF
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00069ED7 File Offset: 0x000680D7
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement ParentElement { get; private set; }

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x00069EE0 File Offset: 0x000680E0
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x00069EE8 File Offset: 0x000680E8
		internal global::System.Data.Entity.Core.SchemaObjectModel.Schema Schema
		{
			get
			{
				return this._schema;
			}
			set
			{
				this._schema = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x00069EF1 File Offset: 0x000680F1
		public virtual string FQName
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00069EF9 File Offset: 0x000680F9
		public virtual string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00069F01 File Offset: 0x00068101
		public global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> OtherContent
		{
			get
			{
				if (this._otherContent == null)
				{
					this._otherContent = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>();
				}
				return this._otherContent;
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00069F1C File Offset: 0x0006811C
		internal virtual void Validate()
		{
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00069F1E File Offset: 0x0006811E
		internal void AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, int lineNumber, int linePosition, object message)
		{
			this.AddError(errorCode, severity, this.SchemaLocation, lineNumber, linePosition, message);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00069F34 File Offset: 0x00068134
		internal void AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, global::System.Xml.XmlReader reader, object message)
		{
			int lineNumber;
			int linePosition;
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.GetPositionInfo(reader, out lineNumber, out linePosition);
			this.AddError(errorCode, severity, this.SchemaLocation, lineNumber, linePosition, message);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00069F5D File Offset: 0x0006815D
		internal void AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, object message)
		{
			this.AddError(errorCode, severity, this.SchemaLocation, this.LineNumber, this.LinePosition, message);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00069F7A File Offset: 0x0006817A
		internal void AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement element, object message)
		{
			this.AddError(errorCode, severity, element.Schema.Location, element.LineNumber, element.LinePosition, message);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00069FA0 File Offset: 0x000681A0
		internal void Parse(global::System.Xml.XmlReader reader)
		{
			this.GetPositionInfo(reader);
			bool flag = !reader.IsEmptyElement;
			bool flag2 = reader.MoveToFirstAttribute();
			while (flag2)
			{
				this.ParseAttribute(reader);
				flag2 = reader.MoveToNextAttribute();
			}
			this.HandleAttributesComplete();
			bool flag3 = !flag;
			bool flag4 = false;
			while (!flag3)
			{
				if (flag4)
				{
					flag4 = false;
					reader.Skip();
					if (reader.EOF)
					{
						break;
					}
				}
				else if (!reader.Read())
				{
					break;
				}
				switch (reader.NodeType)
				{
				case global::System.Xml.XmlNodeType.Element:
					flag4 = this.ParseElement(reader);
					continue;
				case global::System.Xml.XmlNodeType.Text:
				case global::System.Xml.XmlNodeType.CDATA:
				case global::System.Xml.XmlNodeType.SignificantWhitespace:
					this.ParseText(reader);
					continue;
				case global::System.Xml.XmlNodeType.EntityReference:
				case global::System.Xml.XmlNodeType.DocumentType:
					flag4 = true;
					continue;
				case global::System.Xml.XmlNodeType.ProcessingInstruction:
				case global::System.Xml.XmlNodeType.Comment:
				case global::System.Xml.XmlNodeType.Notation:
				case global::System.Xml.XmlNodeType.Whitespace:
				case global::System.Xml.XmlNodeType.XmlDeclaration:
					continue;
				case global::System.Xml.XmlNodeType.EndElement:
					flag3 = true;
					continue;
				}
				this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedXmlNodeType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.UnexpectedXmlNodeType(reader.NodeType));
				flag4 = true;
			}
			this.HandleChildElementsComplete();
			if (reader.EOF && reader.Depth > 0)
			{
				this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.MalformedXml, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, 0, 0, global::System.Data.Entity.Resources.Strings.MalformedXml(this.LineNumber, this.LinePosition));
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0006A0DC File Offset: 0x000682DC
		internal void GetPositionInfo(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.GetPositionInfo(reader, out this._lineNumber, out this._linePosition);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x0006A0F0 File Offset: 0x000682F0
		internal static void GetPositionInfo(global::System.Xml.XmlReader reader, out int lineNumber, out int linePosition)
		{
			global::System.Xml.IXmlLineInfo xmlLineInfo = reader as global::System.Xml.IXmlLineInfo;
			if (xmlLineInfo != null && xmlLineInfo.HasLineInfo())
			{
				lineNumber = xmlLineInfo.LineNumber;
				linePosition = xmlLineInfo.LinePosition;
				return;
			}
			lineNumber = 0;
			linePosition = 0;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0006A126 File Offset: 0x00068326
		internal virtual void ResolveTopLevelNames()
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0006A128 File Offset: 0x00068328
		internal virtual void ResolveSecondLevelNames()
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x0006A12C File Offset: 0x0006832C
		internal SchemaElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver = null)
		{
			this._resolver = (resolver ?? global::System.Data.Entity.DbConfiguration.DependencyResolver);
			if (parentElement != null)
			{
				this.ParentElement = parentElement;
				for (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement = parentElement; schemaElement != null; schemaElement = schemaElement.ParentElement)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.Schema schema = schemaElement as global::System.Data.Entity.Core.SchemaObjectModel.Schema;
					if (schema != null)
					{
						this.Schema = schema;
						break;
					}
				}
				if (this.Schema == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.AllElementsMustBeInSchema);
				}
			}
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x0006A18D File Offset: 0x0006838D
		internal SchemaElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement, string name, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver = null) : this(parentElement, resolver)
		{
			this._name = name;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0006A19E File Offset: 0x0006839E
		protected virtual void HandleAttributesComplete()
		{
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x0006A1A0 File Offset: 0x000683A0
		protected virtual void HandleChildElementsComplete()
		{
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0006A1A4 File Offset: 0x000683A4
		protected string HandleUndottedNameAttribute(global::System.Xml.XmlReader reader, string field)
		{
			string result = field;
			global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetUndottedName(this.Schema, reader, out result);
			return result;
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0006A1C4 File Offset: 0x000683C4
		protected global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string> HandleDottedNameAttribute(global::System.Xml.XmlReader reader, string field)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string> returnValue = new global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string>();
			string value;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetDottedName(this.Schema, reader, out value))
			{
				return returnValue;
			}
			returnValue.Value = value;
			return returnValue;
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x0006A1F4 File Offset: 0x000683F4
		internal bool HandleIntAttribute(global::System.Xml.XmlReader reader, ref int field)
		{
			int num;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetInt(this.Schema, reader, out num))
			{
				return false;
			}
			field = num;
			return true;
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0006A218 File Offset: 0x00068418
		internal bool HandleByteAttribute(global::System.Xml.XmlReader reader, ref byte field)
		{
			byte b;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetByte(this.Schema, reader, out b))
			{
				return false;
			}
			field = b;
			return true;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0006A23C File Offset: 0x0006843C
		internal bool HandleBoolAttribute(global::System.Xml.XmlReader reader, ref bool field)
		{
			bool flag;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetBool(this.Schema, reader, out flag))
			{
				return false;
			}
			field = flag;
			return true;
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x0006A25F File Offset: 0x0006845F
		protected virtual void SkipThroughElement(global::System.Xml.XmlReader reader)
		{
			this.Parse(reader);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x0006A268 File Offset: 0x00068468
		protected virtual void SkipElement(global::System.Xml.XmlReader reader)
		{
			using (global::System.Xml.XmlReader xmlReader = reader.ReadSubtree())
			{
				while (xmlReader.Read())
				{
				}
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0006A2A0 File Offset: 0x000684A0
		protected string SchemaLocation
		{
			get
			{
				if (this.Schema != null)
				{
					return this.Schema.Location;
				}
				return null;
			}
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x0006A2B7 File Offset: 0x000684B7
		protected virtual bool HandleText(global::System.Xml.XmlReader reader)
		{
			return false;
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x0006A2BA File Offset: 0x000684BA
		internal virtual global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			throw global::System.Data.Entity.Resources.Error.NotImplemented();
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x0006A2C1 File Offset: 0x000684C1
		private void HandleDocumentationElement(global::System.Xml.XmlReader reader)
		{
			this.Documentation = new global::System.Data.Entity.Core.SchemaObjectModel.DocumentationElement(this);
			this.Documentation.Parse(reader);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x0006A2DB File Offset: 0x000684DB
		protected virtual void HandleNameAttribute(global::System.Xml.XmlReader reader)
		{
			this.Name = this.HandleUndottedNameAttribute(reader, this.Name);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x0006A2F0 File Offset: 0x000684F0
		private void AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, string sourceLocation, int lineNumber, int linePosition, object message)
		{
			string text = message as string;
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError error;
			if (text != null)
			{
				error = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(text, (int)errorCode, severity, sourceLocation, lineNumber, linePosition);
			}
			else
			{
				global::System.Exception ex = message as global::System.Exception;
				if (ex != null)
				{
					error = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(ex.Message, (int)errorCode, severity, sourceLocation, lineNumber, linePosition, ex);
				}
				else
				{
					error = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(message.ToString(), (int)errorCode, severity, sourceLocation, lineNumber, linePosition);
				}
			}
			this.Schema.AddError(error);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x0006A35C File Offset: 0x0006855C
		private void ParseAttribute(global::System.Xml.XmlReader reader)
		{
			string namespaceURI = reader.NamespaceURI;
			if (namespaceURI == "http://schemas.microsoft.com/ado/2009/02/edm/annotation" && reader.LocalName == "UseStrongSpatialTypes" && !this.ProhibitAttribute(namespaceURI, reader.LocalName) && this.HandleAttribute(reader))
			{
				return;
			}
			if (!this.Schema.IsParseableXmlNamespace(namespaceURI, true))
			{
				this.AddOtherContent(reader);
				return;
			}
			if (!this.ProhibitAttribute(namespaceURI, reader.LocalName) && this.HandleAttribute(reader))
			{
				return;
			}
			if ((reader.SchemaInfo == null || reader.SchemaInfo.Validity != global::System.Xml.Schema.XmlSchemaValidity.Invalid) && (string.IsNullOrEmpty(namespaceURI) || this.Schema.IsParseableXmlNamespace(namespaceURI, true)))
			{
				this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedXmlAttribute, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.UnexpectedXmlAttribute(reader.Name));
			}
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x0006A41B File Offset: 0x0006861B
		protected virtual bool ProhibitAttribute(string namespaceUri, string localName)
		{
			return false;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0006A41E File Offset: 0x0006861E
		internal static bool CanHandleAttribute(global::System.Xml.XmlReader reader, string localName)
		{
			return reader.NamespaceURI.Length == 0 && reader.LocalName == localName;
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0006A43B File Offset: 0x0006863B
		protected virtual bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Name"))
			{
				this.HandleNameAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0006A454 File Offset: 0x00068654
		private bool AddOtherContent(global::System.Xml.XmlReader reader)
		{
			int lineNumber;
			int linePosition;
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.GetPositionInfo(reader, out lineNumber, out linePosition);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty property;
			if (reader.NodeType == global::System.Xml.XmlNodeType.Element)
			{
				if (this._schema.SchemaVersion == 1.0 || this._schema.SchemaVersion == 1.1)
				{
					return true;
				}
				if (this._schema.SchemaVersion >= 2.0 && reader.NamespaceURI == "http://schemas.microsoft.com/ado/2006/04/codegeneration")
				{
					this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NoCodeGenNamespaceInStructuralAnnotation, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, lineNumber, linePosition, global::System.Data.Entity.Resources.Strings.NoCodeGenNamespaceInStructuralAnnotation("http://schemas.microsoft.com/ado/2006/04/codegeneration"));
					return true;
				}
				using (global::System.Xml.XmlReader xmlReader = reader.ReadSubtree())
				{
					xmlReader.Read();
					using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xmlReader.ReadOuterXml()))
					{
						global::System.Xml.Linq.XElement xelement = global::System.Xml.Linq.XElement.Load(stringReader);
						property = global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CreateMetadataPropertyFromXmlElement(xelement.Name.NamespaceName, xelement.Name.LocalName, xelement);
						goto IL_11F;
					}
				}
			}
			if (reader.NamespaceURI == "http://www.w3.org/2000/xmlns/")
			{
				return true;
			}
			property = this.CreateMetadataPropertyFromXmlAttribute(reader.NamespaceURI, reader.LocalName, reader.Value);
			IL_11F:
			if (!this.OtherContent.Exists((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty mp) => mp.Identity == property.Identity))
			{
				this.OtherContent.Add(property);
			}
			else
			{
				this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, lineNumber, linePosition, global::System.Data.Entity.Resources.Strings.DuplicateAnnotation(property.Identity, this.FQName));
			}
			return false;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0006A5EC File Offset: 0x000687EC
		internal static global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty CreateMetadataPropertyFromXmlElement(string xmlNamespaceUri, string elementName, global::System.Xml.Linq.XElement value)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty.CreateAnnotation(xmlNamespaceUri + ":" + elementName, value);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0006A600 File Offset: 0x00068800
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty CreateMetadataPropertyFromXmlAttribute(string xmlNamespaceUri, string attributeName, string value)
		{
			global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer> service = this._resolver.GetService(attributeName);
			object value2 = (service == null) ? value : service().Deserialize(attributeName, value);
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty.CreateAnnotation(xmlNamespaceUri + ":" + attributeName, value2);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0006A640 File Offset: 0x00068840
		private bool ParseElement(global::System.Xml.XmlReader reader)
		{
			string namespaceURI = reader.NamespaceURI;
			if (!this.Schema.IsParseableXmlNamespace(namespaceURI, true) && this.ParentElement != null)
			{
				return this.AddOtherContent(reader);
			}
			if (this.HandleElement(reader))
			{
				return false;
			}
			if (string.IsNullOrEmpty(namespaceURI) || this.Schema.IsParseableXmlNamespace(reader.NamespaceURI, false))
			{
				this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedXmlElement, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.UnexpectedXmlElement(reader.Name));
			}
			return true;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0006A6B0 File Offset: 0x000688B0
		protected bool CanHandleElement(global::System.Xml.XmlReader reader, string localName)
		{
			return reader.NamespaceURI == this.Schema.SchemaXmlNamespace && reader.LocalName == localName;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x0006A6D8 File Offset: 0x000688D8
		protected virtual bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (this.CanHandleElement(reader, "Documentation"))
			{
				this.HandleDocumentationElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x0006A6F2 File Offset: 0x000688F2
		private void ParseText(global::System.Xml.XmlReader reader)
		{
			if (this.HandleText(reader))
			{
				return;
			}
			if (reader.Value == null || reader.Value.Trim().Length != 0)
			{
				this.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.TextNotAllowed, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.TextNotAllowed(reader.Value));
			}
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0006A72D File Offset: 0x0006892D
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void AssertReaderConsidersSchemaInvalid(global::System.Xml.XmlReader reader)
		{
		}

		// Token: 0x04000D33 RID: 3379
		internal const string XmlNamespaceNamespace = "http://www.w3.org/2000/xmlns/";

		// Token: 0x04000D34 RID: 3380
		private global::System.Data.Entity.Core.SchemaObjectModel.Schema _schema;

		// Token: 0x04000D35 RID: 3381
		private int _lineNumber;

		// Token: 0x04000D36 RID: 3382
		private int _linePosition;

		// Token: 0x04000D37 RID: 3383
		private string _name;

		// Token: 0x04000D38 RID: 3384
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> _otherContent;

		// Token: 0x04000D39 RID: 3385
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _resolver;

		// Token: 0x04000D3A RID: 3386
		protected const int MaxValueVersionComponent = 32767;
	}
}
