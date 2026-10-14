using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EE RID: 238
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class XmlDocumentWrapper : global::Newtonsoft.Json.Converters.XmlNodeWrapper, global::Newtonsoft.Json.Converters.IXmlDocument, global::Newtonsoft.Json.Converters.IXmlNode
	{
		// Token: 0x06000C88 RID: 3208 RVA: 0x00032B96 File Offset: 0x00030D96
		public XmlDocumentWrapper(global::System.Xml.XmlDocument document) : base(document)
		{
			this._document = document;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00032BA6 File Offset: 0x00030DA6
		public global::Newtonsoft.Json.Converters.IXmlNode CreateComment([global::System.Runtime.CompilerServices.Nullable(2)] string data)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateComment(data));
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00032BB9 File Offset: 0x00030DB9
		public global::Newtonsoft.Json.Converters.IXmlNode CreateTextNode([global::System.Runtime.CompilerServices.Nullable(2)] string text)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateTextNode(text));
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00032BCC File Offset: 0x00030DCC
		public global::Newtonsoft.Json.Converters.IXmlNode CreateCDataSection([global::System.Runtime.CompilerServices.Nullable(2)] string data)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateCDataSection(data));
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00032BDF File Offset: 0x00030DDF
		public global::Newtonsoft.Json.Converters.IXmlNode CreateWhitespace([global::System.Runtime.CompilerServices.Nullable(2)] string text)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateWhitespace(text));
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00032BF2 File Offset: 0x00030DF2
		public global::Newtonsoft.Json.Converters.IXmlNode CreateSignificantWhitespace([global::System.Runtime.CompilerServices.Nullable(2)] string text)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateSignificantWhitespace(text));
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00032C05 File Offset: 0x00030E05
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public global::Newtonsoft.Json.Converters.IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return new global::Newtonsoft.Json.Converters.XmlDeclarationWrapper(this._document.CreateXmlDeclaration(version, encoding, standalone));
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00032C1A File Offset: 0x00030E1A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public global::Newtonsoft.Json.Converters.IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return new global::Newtonsoft.Json.Converters.XmlDocumentTypeWrapper(this._document.CreateDocumentType(name, publicId, systemId, null));
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00032C30 File Offset: 0x00030E30
		public global::Newtonsoft.Json.Converters.IXmlNode CreateProcessingInstruction(string target, [global::System.Runtime.CompilerServices.Nullable(2)] string data)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateProcessingInstruction(target, data));
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00032C44 File Offset: 0x00030E44
		public global::Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName)
		{
			return new global::Newtonsoft.Json.Converters.XmlElementWrapper(this._document.CreateElement(elementName));
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00032C57 File Offset: 0x00030E57
		public global::Newtonsoft.Json.Converters.IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return new global::Newtonsoft.Json.Converters.XmlElementWrapper(this._document.CreateElement(qualifiedName, namespaceUri));
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00032C6B File Offset: 0x00030E6B
		public global::Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string name, [global::System.Runtime.CompilerServices.Nullable(2)] string value)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateAttribute(name))
			{
				Value = value
			};
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00032C85 File Offset: 0x00030E85
		public global::Newtonsoft.Json.Converters.IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [global::System.Runtime.CompilerServices.Nullable(2)] string value)
		{
			return new global::Newtonsoft.Json.Converters.XmlNodeWrapper(this._document.CreateAttribute(qualifiedName, namespaceUri))
			{
				Value = value
			};
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00032CA0 File Offset: 0x00030EA0
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Converters.IXmlElement DocumentElement
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				if (this._document.DocumentElement == null)
				{
					return null;
				}
				return new global::Newtonsoft.Json.Converters.XmlElementWrapper(this._document.DocumentElement);
			}
		}

		// Token: 0x040003E8 RID: 1000
		private readonly global::System.Xml.XmlDocument _document;
	}
}
