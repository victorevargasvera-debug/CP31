using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FE RID: 254
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class XContainerWrapper : global::Newtonsoft.Json.Converters.XObjectWrapper
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x000333A3 File Offset: 0x000315A3
		private global::System.Xml.Linq.XContainer Container
		{
			get
			{
				return (global::System.Xml.Linq.XContainer)base.WrappedNode;
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000333B0 File Offset: 0x000315B0
		public XContainerWrapper(global::System.Xml.Linq.XContainer container) : base(container)
		{
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x000333BC File Offset: 0x000315BC
		public override global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> ChildNodes
		{
			get
			{
				if (this._childNodes == null)
				{
					if (!this.HasChildNodes)
					{
						this._childNodes = global::Newtonsoft.Json.Converters.XmlNodeConverter.EmptyChildNodes;
					}
					else
					{
						this._childNodes = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>();
						foreach (global::System.Xml.Linq.XNode node in this.Container.Nodes())
						{
							this._childNodes.Add(global::Newtonsoft.Json.Converters.XContainerWrapper.WrapNode(node));
						}
					}
				}
				return this._childNodes;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00033448 File Offset: 0x00031648
		protected virtual bool HasChildNodes
		{
			get
			{
				return this.Container.LastNode != null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00033458 File Offset: 0x00031658
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override global::Newtonsoft.Json.Converters.IXmlNode ParentNode
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				if (this.Container.Parent == null)
				{
					return null;
				}
				return global::Newtonsoft.Json.Converters.XContainerWrapper.WrapNode(this.Container.Parent);
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0003347C File Offset: 0x0003167C
		internal static global::Newtonsoft.Json.Converters.IXmlNode WrapNode(global::System.Xml.Linq.XObject node)
		{
			global::System.Xml.Linq.XDocument xdocument = node as global::System.Xml.Linq.XDocument;
			if (xdocument != null)
			{
				return new global::Newtonsoft.Json.Converters.XDocumentWrapper(xdocument);
			}
			global::System.Xml.Linq.XElement xelement = node as global::System.Xml.Linq.XElement;
			if (xelement != null)
			{
				return new global::Newtonsoft.Json.Converters.XElementWrapper(xelement);
			}
			global::System.Xml.Linq.XContainer xcontainer = node as global::System.Xml.Linq.XContainer;
			if (xcontainer != null)
			{
				return new global::Newtonsoft.Json.Converters.XContainerWrapper(xcontainer);
			}
			global::System.Xml.Linq.XProcessingInstruction xprocessingInstruction = node as global::System.Xml.Linq.XProcessingInstruction;
			if (xprocessingInstruction != null)
			{
				return new global::Newtonsoft.Json.Converters.XProcessingInstructionWrapper(xprocessingInstruction);
			}
			global::System.Xml.Linq.XText xtext = node as global::System.Xml.Linq.XText;
			if (xtext != null)
			{
				return new global::Newtonsoft.Json.Converters.XTextWrapper(xtext);
			}
			global::System.Xml.Linq.XComment xcomment = node as global::System.Xml.Linq.XComment;
			if (xcomment != null)
			{
				return new global::Newtonsoft.Json.Converters.XCommentWrapper(xcomment);
			}
			global::System.Xml.Linq.XAttribute xattribute = node as global::System.Xml.Linq.XAttribute;
			if (xattribute != null)
			{
				return new global::Newtonsoft.Json.Converters.XAttributeWrapper(xattribute);
			}
			global::System.Xml.Linq.XDocumentType xdocumentType = node as global::System.Xml.Linq.XDocumentType;
			if (xdocumentType != null)
			{
				return new global::Newtonsoft.Json.Converters.XDocumentTypeWrapper(xdocumentType);
			}
			return new global::Newtonsoft.Json.Converters.XObjectWrapper(node);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00033523 File Offset: 0x00031723
		public override global::Newtonsoft.Json.Converters.IXmlNode AppendChild(global::Newtonsoft.Json.Converters.IXmlNode newChild)
		{
			this.Container.Add(newChild.WrappedNode);
			this._childNodes = null;
			return newChild;
		}

		// Token: 0x040003F1 RID: 1009
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> _childNodes;
	}
}
