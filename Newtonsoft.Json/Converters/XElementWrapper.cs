using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000101 RID: 257
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class XElementWrapper : global::Newtonsoft.Json.Converters.XContainerWrapper, global::Newtonsoft.Json.Converters.IXmlElement, global::Newtonsoft.Json.Converters.IXmlNode
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00033606 File Offset: 0x00031806
		private global::System.Xml.Linq.XElement Element
		{
			get
			{
				return (global::System.Xml.Linq.XElement)base.WrappedNode;
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00033613 File Offset: 0x00031813
		public XElementWrapper(global::System.Xml.Linq.XElement element) : base(element)
		{
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003361C File Offset: 0x0003181C
		public void SetAttributeNode(global::Newtonsoft.Json.Converters.IXmlNode attribute)
		{
			global::Newtonsoft.Json.Converters.XObjectWrapper xobjectWrapper = (global::Newtonsoft.Json.Converters.XObjectWrapper)attribute;
			this.Element.Add(xobjectWrapper.WrappedNode);
			this._attributes = null;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00033648 File Offset: 0x00031848
		public override global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> Attributes
		{
			get
			{
				if (this._attributes == null)
				{
					if (!this.Element.HasAttributes && !this.HasImplicitNamespaceAttribute(this.NamespaceUri))
					{
						this._attributes = global::Newtonsoft.Json.Converters.XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this._attributes = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>();
						foreach (global::System.Xml.Linq.XAttribute attribute in this.Element.Attributes())
						{
							this._attributes.Add(new global::Newtonsoft.Json.Converters.XAttributeWrapper(attribute));
						}
						string namespaceUri = this.NamespaceUri;
						if (this.HasImplicitNamespaceAttribute(namespaceUri))
						{
							this._attributes.Insert(0, new global::Newtonsoft.Json.Converters.XAttributeWrapper(new global::System.Xml.Linq.XAttribute("xmlns", namespaceUri)));
						}
					}
				}
				return this._attributes;
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0003371C File Offset: 0x0003191C
		private bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(namespaceUri))
			{
				global::Newtonsoft.Json.Converters.IXmlNode parentNode = this.ParentNode;
				if (namespaceUri != ((parentNode != null) ? parentNode.NamespaceUri : null) && global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(this.GetPrefixOfNamespace(namespaceUri)))
				{
					bool flag = false;
					if (this.Element.HasAttributes)
					{
						foreach (global::System.Xml.Linq.XAttribute xattribute in this.Element.Attributes())
						{
							if (xattribute.Name.LocalName == "xmlns" && global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xattribute.Name.NamespaceName) && xattribute.Value == namespaceUri)
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000337EC File Offset: 0x000319EC
		public override global::Newtonsoft.Json.Converters.IXmlNode AppendChild(global::Newtonsoft.Json.Converters.IXmlNode newChild)
		{
			global::Newtonsoft.Json.Converters.IXmlNode result = base.AppendChild(newChild);
			this._attributes = null;
			return result;
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000337FC File Offset: 0x000319FC
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00033809 File Offset: 0x00031A09
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override string Value
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this.Element.Value;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				this.Element.Value = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00033817 File Offset: 0x00031A17
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override string LocalName
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this.Element.Name.LocalName;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00033829 File Offset: 0x00031A29
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override string NamespaceUri
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this.Element.Name.NamespaceName;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0003383B File Offset: 0x00031A3B
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return this.Element.GetPrefixOfNamespace(namespaceUri);
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0003384E File Offset: 0x00031A4E
		public bool IsEmpty
		{
			get
			{
				return this.Element.IsEmpty;
			}
		}

		// Token: 0x040003F3 RID: 1011
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> _attributes;
	}
}
