using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000102 RID: 258
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class XmlNodeConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0003385B File Offset: 0x00031A5B
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00033863 File Offset: 0x00031A63
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string DeserializeRootElementName { [global::System.Runtime.CompilerServices.NullableContext(2)] get; [global::System.Runtime.CompilerServices.NullableContext(2)] set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0003386C File Offset: 0x00031A6C
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00033874 File Offset: 0x00031A74
		public bool WriteArrayAttribute { get; set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0003387D File Offset: 0x00031A7D
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00033885 File Offset: 0x00031A85
		public bool OmitRootObject { get; set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0003388E File Offset: 0x00031A8E
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00033896 File Offset: 0x00031A96
		public bool EncodeSpecialCharacters { get; set; }

		// Token: 0x06000D33 RID: 3379 RVA: 0x000338A0 File Offset: 0x00031AA0
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::Newtonsoft.Json.Converters.IXmlNode node = this.WrapXml(value);
			global::System.Xml.XmlNamespaceManager manager = new global::System.Xml.XmlNamespaceManager(new global::System.Xml.NameTable());
			this.PushParentNamespaces(node, manager);
			if (!this.OmitRootObject)
			{
				writer.WriteStartObject();
			}
			this.SerializeNode(writer, node, manager, !this.OmitRootObject);
			if (!this.OmitRootObject)
			{
				writer.WriteEndObject();
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00033900 File Offset: 0x00031B00
		private global::Newtonsoft.Json.Converters.IXmlNode WrapXml(object value)
		{
			global::System.Xml.Linq.XObject xobject = value as global::System.Xml.Linq.XObject;
			if (xobject != null)
			{
				return global::Newtonsoft.Json.Converters.XContainerWrapper.WrapNode(xobject);
			}
			global::System.Xml.XmlNode xmlNode = value as global::System.Xml.XmlNode;
			if (xmlNode != null)
			{
				return global::Newtonsoft.Json.Converters.XmlNodeWrapper.WrapNode(xmlNode);
			}
			throw new global::System.ArgumentException("Value must be an XML object.", "value");
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00033940 File Offset: 0x00031B40
		private void PushParentNamespaces(global::Newtonsoft.Json.Converters.IXmlNode node, global::System.Xml.XmlNamespaceManager manager)
		{
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> list = null;
			global::Newtonsoft.Json.Converters.IXmlNode xmlNode = node;
			while ((xmlNode = xmlNode.ParentNode) != null)
			{
				if (xmlNode.NodeType == global::System.Xml.XmlNodeType.Element)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>();
					}
					list.Add(xmlNode);
				}
			}
			if (list != null)
			{
				list.Reverse();
				foreach (global::Newtonsoft.Json.Converters.IXmlNode xmlNode2 in list)
				{
					manager.PushScope();
					foreach (global::Newtonsoft.Json.Converters.IXmlNode xmlNode3 in xmlNode2.Attributes)
					{
						if (xmlNode3.NamespaceUri == "http://www.w3.org/2000/xmlns/" && xmlNode3.LocalName != "xmlns")
						{
							manager.AddNamespace(xmlNode3.LocalName, xmlNode3.Value);
						}
					}
				}
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00033A38 File Offset: 0x00031C38
		private string ResolveFullName(global::Newtonsoft.Json.Converters.IXmlNode node, global::System.Xml.XmlNamespaceManager manager)
		{
			string text = (node.NamespaceUri == null || (node.LocalName == "xmlns" && node.NamespaceUri == "http://www.w3.org/2000/xmlns/")) ? null : manager.LookupPrefix(node.NamespaceUri);
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text))
			{
				return text + ":" + global::System.Xml.XmlConvert.DecodeName(node.LocalName);
			}
			return global::System.Xml.XmlConvert.DecodeName(node.LocalName);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00033AAC File Offset: 0x00031CAC
		private string GetPropertyName(global::Newtonsoft.Json.Converters.IXmlNode node, global::System.Xml.XmlNamespaceManager manager)
		{
			switch (node.NodeType)
			{
			case global::System.Xml.XmlNodeType.Element:
				if (node.NamespaceUri == "http://james.newtonking.com/projects/json")
				{
					return "$" + node.LocalName;
				}
				return this.ResolveFullName(node, manager);
			case global::System.Xml.XmlNodeType.Attribute:
				if (node.NamespaceUri == "http://james.newtonking.com/projects/json")
				{
					return "$" + node.LocalName;
				}
				return "@" + this.ResolveFullName(node, manager);
			case global::System.Xml.XmlNodeType.Text:
				return "#text";
			case global::System.Xml.XmlNodeType.CDATA:
				return "#cdata-section";
			case global::System.Xml.XmlNodeType.ProcessingInstruction:
				return "?" + this.ResolveFullName(node, manager);
			case global::System.Xml.XmlNodeType.Comment:
				return "#comment";
			case global::System.Xml.XmlNodeType.DocumentType:
				return "!" + this.ResolveFullName(node, manager);
			case global::System.Xml.XmlNodeType.Whitespace:
				return "#whitespace";
			case global::System.Xml.XmlNodeType.SignificantWhitespace:
				return "#significant-whitespace";
			case global::System.Xml.XmlNodeType.XmlDeclaration:
				return "?xml";
			}
			throw new global::Newtonsoft.Json.JsonSerializationException("Unexpected XmlNodeType when getting node name: " + node.NodeType.ToString());
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00033BE0 File Offset: 0x00031DE0
		private bool IsArray(global::Newtonsoft.Json.Converters.IXmlNode node)
		{
			foreach (global::Newtonsoft.Json.Converters.IXmlNode xmlNode in node.Attributes)
			{
				if (xmlNode.LocalName == "Array" && xmlNode.NamespaceUri == "http://james.newtonking.com/projects/json")
				{
					return global::System.Xml.XmlConvert.ToBoolean(xmlNode.Value);
				}
			}
			return false;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00033C64 File Offset: 0x00031E64
		private void SerializeGroupedNodes(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Converters.IXmlNode node, global::System.Xml.XmlNamespaceManager manager, bool writePropertyName)
		{
			int count = node.ChildNodes.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					string propertyName = this.GetPropertyName(node.ChildNodes[0], manager);
					this.WriteGroupedNodes(writer, manager, writePropertyName, node.ChildNodes, propertyName);
					return;
				}
				global::System.Collections.Generic.Dictionary<string, object> dictionary = null;
				string text = null;
				for (int i = 0; i < node.ChildNodes.Count; i++)
				{
					global::Newtonsoft.Json.Converters.IXmlNode xmlNode = node.ChildNodes[i];
					string propertyName2 = this.GetPropertyName(xmlNode, manager);
					object obj;
					if (dictionary == null)
					{
						if (text == null)
						{
							text = propertyName2;
						}
						else if (!(propertyName2 == text))
						{
							dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
							if (i > 1)
							{
								global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>(i);
								for (int j = 0; j < i; j++)
								{
									list.Add(node.ChildNodes[j]);
								}
								dictionary.Add(text, list);
							}
							else
							{
								dictionary.Add(text, node.ChildNodes[0]);
							}
							dictionary.Add(propertyName2, xmlNode);
						}
					}
					else if (!dictionary.TryGetValue(propertyName2, out obj))
					{
						dictionary.Add(propertyName2, xmlNode);
					}
					else
					{
						global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> list2 = obj as global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>;
						if (list2 == null)
						{
							list2 = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>
							{
								(global::Newtonsoft.Json.Converters.IXmlNode)obj
							};
							dictionary[propertyName2] = list2;
						}
						list2.Add(xmlNode);
					}
				}
				if (dictionary == null)
				{
					this.WriteGroupedNodes(writer, manager, writePropertyName, node.ChildNodes, text);
					return;
				}
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in dictionary)
				{
					global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> list3 = keyValuePair.Value as global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>;
					if (list3 != null)
					{
						this.WriteGroupedNodes(writer, manager, writePropertyName, list3, keyValuePair.Key);
					}
					else
					{
						this.WriteGroupedNodes(writer, manager, writePropertyName, (global::Newtonsoft.Json.Converters.IXmlNode)keyValuePair.Value, keyValuePair.Key);
					}
				}
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00033E4C File Offset: 0x0003204C
		private void WriteGroupedNodes(global::Newtonsoft.Json.JsonWriter writer, global::System.Xml.XmlNamespaceManager manager, bool writePropertyName, global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames)
		{
			if (groupedNodes.Count == 1 && !this.IsArray(groupedNodes[0]))
			{
				this.SerializeNode(writer, groupedNodes[0], manager, writePropertyName);
				return;
			}
			if (writePropertyName)
			{
				writer.WritePropertyName(elementNames);
			}
			writer.WriteStartArray();
			for (int i = 0; i < groupedNodes.Count; i++)
			{
				this.SerializeNode(writer, groupedNodes[i], manager, false);
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00033EC2 File Offset: 0x000320C2
		private void WriteGroupedNodes(global::Newtonsoft.Json.JsonWriter writer, global::System.Xml.XmlNamespaceManager manager, bool writePropertyName, global::Newtonsoft.Json.Converters.IXmlNode node, string elementNames)
		{
			if (!this.IsArray(node))
			{
				this.SerializeNode(writer, node, manager, writePropertyName);
				return;
			}
			if (writePropertyName)
			{
				writer.WritePropertyName(elementNames);
			}
			writer.WriteStartArray();
			this.SerializeNode(writer, node, manager, false);
			writer.WriteEndArray();
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00033EFC File Offset: 0x000320FC
		private void SerializeNode(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Converters.IXmlNode node, global::System.Xml.XmlNamespaceManager manager, bool writePropertyName)
		{
			switch (node.NodeType)
			{
			case global::System.Xml.XmlNodeType.Element:
				if (this.IsArray(node) && global::Newtonsoft.Json.Converters.XmlNodeConverter.AllSameName(node) && node.ChildNodes.Count > 0)
				{
					this.SerializeGroupedNodes(writer, node, manager, false);
					return;
				}
				manager.PushScope();
				foreach (global::Newtonsoft.Json.Converters.IXmlNode xmlNode in node.Attributes)
				{
					if (xmlNode.NamespaceUri == "http://www.w3.org/2000/xmlns/")
					{
						string prefix = (xmlNode.LocalName != "xmlns") ? global::System.Xml.XmlConvert.DecodeName(xmlNode.LocalName) : string.Empty;
						string value = xmlNode.Value;
						if (value == null)
						{
							throw new global::Newtonsoft.Json.JsonSerializationException("Namespace attribute must have a value.");
						}
						manager.AddNamespace(prefix, value);
					}
				}
				if (writePropertyName)
				{
					writer.WritePropertyName(this.GetPropertyName(node, manager));
				}
				if (!this.ValueAttributes(node.Attributes) && node.ChildNodes.Count == 1 && node.ChildNodes[0].NodeType == global::System.Xml.XmlNodeType.Text)
				{
					writer.WriteValue(node.ChildNodes[0].Value);
				}
				else if (node.ChildNodes.Count == 0 && node.Attributes.Count == 0)
				{
					if (((global::Newtonsoft.Json.Converters.IXmlElement)node).IsEmpty)
					{
						writer.WriteNull();
					}
					else
					{
						writer.WriteValue(string.Empty);
					}
				}
				else
				{
					writer.WriteStartObject();
					for (int i = 0; i < node.Attributes.Count; i++)
					{
						this.SerializeNode(writer, node.Attributes[i], manager, true);
					}
					this.SerializeGroupedNodes(writer, node, manager, true);
					writer.WriteEndObject();
				}
				manager.PopScope();
				return;
			case global::System.Xml.XmlNodeType.Attribute:
			case global::System.Xml.XmlNodeType.Text:
			case global::System.Xml.XmlNodeType.CDATA:
			case global::System.Xml.XmlNodeType.ProcessingInstruction:
			case global::System.Xml.XmlNodeType.Whitespace:
			case global::System.Xml.XmlNodeType.SignificantWhitespace:
				if (node.NamespaceUri == "http://www.w3.org/2000/xmlns/" && node.Value == "http://james.newtonking.com/projects/json")
				{
					return;
				}
				if (node.NamespaceUri == "http://james.newtonking.com/projects/json" && node.LocalName == "Array")
				{
					return;
				}
				if (writePropertyName)
				{
					writer.WritePropertyName(this.GetPropertyName(node, manager));
				}
				writer.WriteValue(node.Value);
				return;
			case global::System.Xml.XmlNodeType.Comment:
				if (writePropertyName)
				{
					writer.WriteComment(node.Value);
					return;
				}
				return;
			case global::System.Xml.XmlNodeType.Document:
			case global::System.Xml.XmlNodeType.DocumentFragment:
				this.SerializeGroupedNodes(writer, node, manager, writePropertyName);
				return;
			case global::System.Xml.XmlNodeType.DocumentType:
			{
				global::Newtonsoft.Json.Converters.IXmlDocumentType xmlDocumentType = (global::Newtonsoft.Json.Converters.IXmlDocumentType)node;
				writer.WritePropertyName(this.GetPropertyName(node, manager));
				writer.WriteStartObject();
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDocumentType.Name))
				{
					writer.WritePropertyName("@name");
					writer.WriteValue(xmlDocumentType.Name);
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDocumentType.Public))
				{
					writer.WritePropertyName("@public");
					writer.WriteValue(xmlDocumentType.Public);
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDocumentType.System))
				{
					writer.WritePropertyName("@system");
					writer.WriteValue(xmlDocumentType.System);
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDocumentType.InternalSubset))
				{
					writer.WritePropertyName("@internalSubset");
					writer.WriteValue(xmlDocumentType.InternalSubset);
				}
				writer.WriteEndObject();
				return;
			}
			case global::System.Xml.XmlNodeType.XmlDeclaration:
			{
				global::Newtonsoft.Json.Converters.IXmlDeclaration xmlDeclaration = (global::Newtonsoft.Json.Converters.IXmlDeclaration)node;
				writer.WritePropertyName(this.GetPropertyName(node, manager));
				writer.WriteStartObject();
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDeclaration.Version))
				{
					writer.WritePropertyName("@version");
					writer.WriteValue(xmlDeclaration.Version);
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDeclaration.Encoding))
				{
					writer.WritePropertyName("@encoding");
					writer.WriteValue(xmlDeclaration.Encoding);
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(xmlDeclaration.Standalone))
				{
					writer.WritePropertyName("@standalone");
					writer.WriteValue(xmlDeclaration.Standalone);
				}
				writer.WriteEndObject();
				return;
			}
			}
			throw new global::Newtonsoft.Json.JsonSerializationException("Unexpected XmlNodeType when serializing nodes: " + node.NodeType.ToString());
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00034304 File Offset: 0x00032504
		private static bool AllSameName(global::Newtonsoft.Json.Converters.IXmlNode node)
		{
			using (global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>.Enumerator enumerator = node.ChildNodes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.LocalName != node.LocalName)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00034368 File Offset: 0x00032568
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			if (tokenType != global::Newtonsoft.Json.JsonToken.StartObject)
			{
				if (tokenType == global::Newtonsoft.Json.JsonToken.Null)
				{
					return null;
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "XmlNodeConverter can only convert JSON that begins with an object.");
			}
			else
			{
				global::System.Xml.XmlNamespaceManager manager = new global::System.Xml.XmlNamespaceManager(new global::System.Xml.NameTable());
				global::Newtonsoft.Json.Converters.IXmlDocument xmlDocument = null;
				global::Newtonsoft.Json.Converters.IXmlNode xmlNode = null;
				if (typeof(global::System.Xml.Linq.XObject).IsAssignableFrom(objectType))
				{
					if (objectType != typeof(global::System.Xml.Linq.XContainer) && objectType != typeof(global::System.Xml.Linq.XDocument) && objectType != typeof(global::System.Xml.Linq.XElement) && objectType != typeof(global::System.Xml.Linq.XNode) && objectType != typeof(global::System.Xml.Linq.XObject))
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "XmlNodeConverter only supports deserializing XDocument, XElement, XContainer, XNode or XObject.");
					}
					xmlDocument = new global::Newtonsoft.Json.Converters.XDocumentWrapper(new global::System.Xml.Linq.XDocument());
					xmlNode = xmlDocument;
				}
				if (typeof(global::System.Xml.XmlNode).IsAssignableFrom(objectType))
				{
					if (objectType != typeof(global::System.Xml.XmlDocument) && objectType != typeof(global::System.Xml.XmlElement) && objectType != typeof(global::System.Xml.XmlNode))
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "XmlNodeConverter only supports deserializing XmlDocument, XmlElement or XmlNode.");
					}
					xmlDocument = new global::Newtonsoft.Json.Converters.XmlDocumentWrapper(new global::System.Xml.XmlDocument
					{
						XmlResolver = null
					});
					xmlNode = xmlDocument;
				}
				if (xmlDocument == null || xmlNode == null)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected type when converting XML: " + ((objectType != null) ? objectType.ToString() : null));
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(this.DeserializeRootElementName))
				{
					this.ReadElement(reader, xmlDocument, xmlNode, this.DeserializeRootElementName, manager);
				}
				else
				{
					reader.ReadAndAssert();
					this.DeserializeNode(reader, xmlDocument, manager, xmlNode);
				}
				if (objectType == typeof(global::System.Xml.Linq.XElement))
				{
					global::System.Xml.Linq.XElement xelement = (global::System.Xml.Linq.XElement)xmlDocument.DocumentElement.WrappedNode;
					xelement.Remove();
					return xelement;
				}
				if (objectType == typeof(global::System.Xml.XmlElement))
				{
					return xmlDocument.DocumentElement.WrappedNode;
				}
				return xmlDocument.WrappedNode;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00034530 File Offset: 0x00032730
		private void DeserializeValue(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::System.Xml.XmlNamespaceManager manager, string propertyName, global::Newtonsoft.Json.Converters.IXmlNode currentNode)
		{
			if (!this.EncodeSpecialCharacters)
			{
				if (propertyName == "#text")
				{
					currentNode.AppendChild(document.CreateTextNode(global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader)));
					return;
				}
				if (propertyName == "#cdata-section")
				{
					currentNode.AppendChild(document.CreateCDataSection(global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader)));
					return;
				}
				if (propertyName == "#whitespace")
				{
					currentNode.AppendChild(document.CreateWhitespace(global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader)));
					return;
				}
				if (propertyName == "#significant-whitespace")
				{
					currentNode.AppendChild(document.CreateSignificantWhitespace(global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader)));
					return;
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(propertyName) && propertyName[0] == '?')
				{
					this.CreateInstruction(reader, document, currentNode, propertyName);
					return;
				}
				if (string.Equals(propertyName, "!DOCTYPE", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.CreateDocumentType(reader, document, currentNode);
					return;
				}
			}
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartArray)
			{
				this.ReadArrayElements(reader, document, propertyName, currentNode, manager);
				return;
			}
			this.ReadElement(reader, document, currentNode, propertyName, manager);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00034638 File Offset: 0x00032838
		private void ReadElement(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, global::System.Xml.XmlNamespaceManager manager)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(propertyName))
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "XmlNodeConverter cannot convert JSON with an empty property name to XML.");
			}
			global::System.Collections.Generic.Dictionary<string, string> attributeNameValues = null;
			string elementPrefix = null;
			if (!this.EncodeSpecialCharacters)
			{
				attributeNameValues = (this.ShouldReadInto(reader) ? this.ReadAttributeElements(reader, manager) : null);
				elementPrefix = global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetPrefix(propertyName);
				if (propertyName.StartsWith('@'))
				{
					string text = propertyName.Substring(1);
					string prefix = global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetPrefix(text);
					global::Newtonsoft.Json.Converters.XmlNodeConverter.AddAttribute(reader, document, currentNode, propertyName, text, manager, prefix);
					return;
				}
				if (propertyName.StartsWith('$'))
				{
					if (propertyName == "$values")
					{
						propertyName = propertyName.Substring(1);
						elementPrefix = manager.LookupPrefix("http://james.newtonking.com/projects/json");
						this.CreateElement(reader, document, currentNode, propertyName, manager, elementPrefix, attributeNameValues);
						return;
					}
					if (propertyName == "$id" || propertyName == "$ref" || propertyName == "$type" || propertyName == "$value")
					{
						string attributeName = propertyName.Substring(1);
						string attributePrefix = manager.LookupPrefix("http://james.newtonking.com/projects/json");
						global::Newtonsoft.Json.Converters.XmlNodeConverter.AddAttribute(reader, document, currentNode, propertyName, attributeName, manager, attributePrefix);
						return;
					}
				}
			}
			else if (this.ShouldReadInto(reader))
			{
				reader.ReadAndAssert();
			}
			this.CreateElement(reader, document, currentNode, propertyName, manager, elementPrefix, attributeNameValues);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00034778 File Offset: 0x00032978
		private void CreateElement(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::Newtonsoft.Json.Converters.IXmlNode currentNode, string elementName, global::System.Xml.XmlNamespaceManager manager, [global::System.Runtime.CompilerServices.Nullable(2)] string elementPrefix, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			2
		})] global::System.Collections.Generic.Dictionary<string, string> attributeNameValues)
		{
			global::Newtonsoft.Json.Converters.IXmlElement xmlElement = this.CreateElement(elementName, document, elementPrefix, manager);
			currentNode.AppendChild(xmlElement);
			if (attributeNameValues != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in attributeNameValues)
				{
					string text = global::System.Xml.XmlConvert.EncodeName(keyValuePair.Key);
					string prefix = global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetPrefix(keyValuePair.Key);
					global::Newtonsoft.Json.Converters.IXmlNode attributeNode = (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(prefix)) ? document.CreateAttribute(text, manager.LookupNamespace(prefix) ?? string.Empty, keyValuePair.Value) : document.CreateAttribute(text, keyValuePair.Value);
					xmlElement.SetAttributeNode(attributeNode);
				}
			}
			switch (reader.TokenType)
			{
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
			{
				string text2 = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
				if (text2 != null)
				{
					xmlElement.AppendChild(document.CreateTextNode(text2));
					return;
				}
				return;
			}
			case global::Newtonsoft.Json.JsonToken.Null:
				return;
			case global::Newtonsoft.Json.JsonToken.EndObject:
				manager.RemoveNamespace(string.Empty, manager.DefaultNamespace);
				return;
			}
			manager.PushScope();
			this.DeserializeNode(reader, document, manager, xmlElement);
			manager.PopScope();
			manager.RemoveNamespace(string.Empty, manager.DefaultNamespace);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000348D8 File Offset: 0x00032AD8
		private static void AddAttribute(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName, string attributeName, global::System.Xml.XmlNamespaceManager manager, [global::System.Runtime.CompilerServices.Nullable(2)] string attributePrefix)
		{
			if (currentNode.NodeType == global::System.Xml.XmlNodeType.Document)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "JSON root object has property '{0}' that will be converted to an attribute. A root object cannot have any attribute properties. Consider specifying a DeserializeRootElementName.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, propertyName));
			}
			string text = global::System.Xml.XmlConvert.EncodeName(attributeName);
			string value = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
			global::Newtonsoft.Json.Converters.IXmlNode attributeNode = (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(attributePrefix)) ? document.CreateAttribute(text, manager.LookupNamespace(attributePrefix), value) : document.CreateAttribute(text, value);
			((global::Newtonsoft.Json.Converters.IXmlElement)currentNode).SetAttributeNode(attributeNode);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00034948 File Offset: 0x00032B48
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static string ConvertTokenToXmlValue(global::Newtonsoft.Json.JsonReader reader)
		{
			switch (reader.TokenType)
			{
			case global::Newtonsoft.Json.JsonToken.Integer:
			{
				object value = reader.Value;
				if (value is global::System.Numerics.BigInteger)
				{
					return ((global::System.Numerics.BigInteger)value).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}
				return global::System.Xml.XmlConvert.ToString(global::System.Convert.ToInt64(reader.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			case global::Newtonsoft.Json.JsonToken.Float:
			{
				object value = reader.Value;
				if (value is decimal)
				{
					decimal value2 = (decimal)value;
					return global::System.Xml.XmlConvert.ToString(value2);
				}
				value = reader.Value;
				if (value is float)
				{
					float value3 = (float)value;
					return global::System.Xml.XmlConvert.ToString(value3);
				}
				return global::System.Xml.XmlConvert.ToString(global::System.Convert.ToDouble(reader.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			case global::Newtonsoft.Json.JsonToken.String:
			{
				object value4 = reader.Value;
				if (value4 == null)
				{
					return null;
				}
				return value4.ToString();
			}
			case global::Newtonsoft.Json.JsonToken.Boolean:
				return global::System.Xml.XmlConvert.ToString(global::System.Convert.ToBoolean(reader.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			case global::Newtonsoft.Json.JsonToken.Null:
				return null;
			case global::Newtonsoft.Json.JsonToken.Date:
			{
				object value = reader.Value;
				if (value is global::System.DateTimeOffset)
				{
					global::System.DateTimeOffset value5 = (global::System.DateTimeOffset)value;
					return global::System.Xml.XmlConvert.ToString(value5);
				}
				global::System.DateTime value6 = global::System.Convert.ToDateTime(reader.Value, global::System.Globalization.CultureInfo.InvariantCulture);
				return global::System.Xml.XmlConvert.ToString(value6, global::Newtonsoft.Json.Utilities.DateTimeUtils.ToSerializationMode(value6.Kind));
			}
			case global::Newtonsoft.Json.JsonToken.Bytes:
				return global::System.Convert.ToBase64String((byte[])reader.Value);
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot get an XML string value from token type '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00034AC0 File Offset: 0x00032CC0
		private void ReadArrayElements(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, string propertyName, global::Newtonsoft.Json.Converters.IXmlNode currentNode, global::System.Xml.XmlNamespaceManager manager)
		{
			string prefix = global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetPrefix(propertyName);
			global::Newtonsoft.Json.Converters.IXmlElement xmlElement = this.CreateElement(propertyName, document, prefix, manager);
			currentNode.AppendChild(xmlElement);
			int num = 0;
			while (reader.Read() && reader.TokenType != global::Newtonsoft.Json.JsonToken.EndArray)
			{
				this.DeserializeValue(reader, document, manager, propertyName, xmlElement);
				num++;
			}
			if (this.WriteArrayAttribute)
			{
				this.AddJsonArrayAttribute(xmlElement, document);
			}
			if (num == 1 && this.WriteArrayAttribute)
			{
				foreach (global::Newtonsoft.Json.Converters.IXmlNode xmlNode in xmlElement.ChildNodes)
				{
					global::Newtonsoft.Json.Converters.IXmlElement xmlElement2 = xmlNode as global::Newtonsoft.Json.Converters.IXmlElement;
					if (xmlElement2 != null && xmlElement2.LocalName == propertyName)
					{
						this.AddJsonArrayAttribute(xmlElement2, document);
						break;
					}
				}
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00034B90 File Offset: 0x00032D90
		private void AddJsonArrayAttribute(global::Newtonsoft.Json.Converters.IXmlElement element, global::Newtonsoft.Json.Converters.IXmlDocument document)
		{
			element.SetAttributeNode(document.CreateAttribute("json:Array", "http://james.newtonking.com/projects/json", "true"));
			if (element is global::Newtonsoft.Json.Converters.XElementWrapper && element.GetPrefixOfNamespace("http://james.newtonking.com/projects/json") == null)
			{
				element.SetAttributeNode(document.CreateAttribute("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00034BE8 File Offset: 0x00032DE8
		private bool ShouldReadInto(global::Newtonsoft.Json.JsonReader reader)
		{
			switch (reader.TokenType)
			{
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Null:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
				return false;
			}
			return true;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00034C48 File Offset: 0x00032E48
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private global::System.Collections.Generic.Dictionary<string, string> ReadAttributeElements(global::Newtonsoft.Json.JsonReader reader, global::System.Xml.XmlNamespaceManager manager)
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = null;
			bool flag = false;
			while (!flag && reader.Read())
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment && tokenType != global::Newtonsoft.Json.JsonToken.EndObject)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected JsonToken: " + reader.TokenType.ToString());
					}
					flag = true;
				}
				else
				{
					string text = reader.Value.ToString();
					if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text))
					{
						char c = text[0];
						if (c != '$')
						{
							if (c == '@')
							{
								if (dictionary == null)
								{
									dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
								}
								text = text.Substring(1);
								reader.ReadAndAssert();
								string text2 = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
								dictionary.Add(text, text2);
								string prefix;
								if (this.IsNamespaceAttribute(text, out prefix))
								{
									manager.AddNamespace(prefix, text2);
								}
							}
							else
							{
								flag = true;
							}
						}
						else if (text == "$values" || text == "$id" || text == "$ref" || text == "$type" || text == "$value")
						{
							string text3 = manager.LookupPrefix("http://james.newtonking.com/projects/json");
							if (text3 == null)
							{
								if (dictionary == null)
								{
									dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
								}
								int? num = null;
								int? num2;
								for (;;)
								{
									string str = "json";
									num2 = num;
									if (manager.LookupNamespace(str + num2.ToString()) == null)
									{
										break;
									}
									num = new int?(num.GetValueOrDefault() + 1);
								}
								string str2 = "json";
								num2 = num;
								text3 = str2 + num2.ToString();
								dictionary.Add("xmlns:" + text3, "http://james.newtonking.com/projects/json");
								manager.AddNamespace(text3, "http://james.newtonking.com/projects/json");
							}
							if (text == "$values")
							{
								flag = true;
							}
							else
							{
								text = text.Substring(1);
								reader.ReadAndAssert();
								if (!global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsPrimitiveToken(reader.TokenType))
								{
									throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected JsonToken: " + reader.TokenType.ToString());
								}
								if (dictionary == null)
								{
									dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
								}
								object value = reader.Value;
								string text2 = (value != null) ? value.ToString() : null;
								dictionary.Add(text3 + ":" + text, text2);
							}
						}
						else
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00034EA0 File Offset: 0x000330A0
		private void CreateInstruction(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::Newtonsoft.Json.Converters.IXmlNode currentNode, string propertyName)
		{
			if (propertyName == "?xml")
			{
				string version = null;
				string encoding = null;
				string standalone = null;
				while (reader.Read() && reader.TokenType != global::Newtonsoft.Json.JsonToken.EndObject)
				{
					object value = reader.Value;
					string a = (value != null) ? value.ToString() : null;
					if (!(a == "@version"))
					{
						if (!(a == "@encoding"))
						{
							if (!(a == "@standalone"))
							{
								string str = "Unexpected property name encountered while deserializing XmlDeclaration: ";
								object value2 = reader.Value;
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, str + ((value2 != null) ? value2.ToString() : null));
							}
							reader.ReadAndAssert();
							standalone = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
						}
						else
						{
							reader.ReadAndAssert();
							encoding = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
						}
					}
					else
					{
						reader.ReadAndAssert();
						version = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
					}
				}
				global::Newtonsoft.Json.Converters.IXmlNode newChild = document.CreateXmlDeclaration(version, encoding, standalone);
				currentNode.AppendChild(newChild);
				return;
			}
			global::Newtonsoft.Json.Converters.IXmlNode newChild2 = document.CreateProcessingInstruction(propertyName.Substring(1), global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader));
			currentNode.AppendChild(newChild2);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00034FA0 File Offset: 0x000331A0
		private void CreateDocumentType(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::Newtonsoft.Json.Converters.IXmlNode currentNode)
		{
			string name = null;
			string publicId = null;
			string systemId = null;
			string internalSubset = null;
			while (reader.Read() && reader.TokenType != global::Newtonsoft.Json.JsonToken.EndObject)
			{
				object value = reader.Value;
				string a = (value != null) ? value.ToString() : null;
				if (!(a == "@name"))
				{
					if (!(a == "@public"))
					{
						if (!(a == "@system"))
						{
							if (!(a == "@internalSubset"))
							{
								string str = "Unexpected property name encountered while deserializing XmlDeclaration: ";
								object value2 = reader.Value;
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, str + ((value2 != null) ? value2.ToString() : null));
							}
							reader.ReadAndAssert();
							internalSubset = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
						}
						else
						{
							reader.ReadAndAssert();
							systemId = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
						}
					}
					else
					{
						reader.ReadAndAssert();
						publicId = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
					}
				}
				else
				{
					reader.ReadAndAssert();
					name = global::Newtonsoft.Json.Converters.XmlNodeConverter.ConvertTokenToXmlValue(reader);
				}
			}
			global::Newtonsoft.Json.Converters.IXmlNode newChild = document.CreateXmlDocumentType(name, publicId, systemId, internalSubset);
			currentNode.AppendChild(newChild);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00035094 File Offset: 0x00033294
		private global::Newtonsoft.Json.Converters.IXmlElement CreateElement(string elementName, global::Newtonsoft.Json.Converters.IXmlDocument document, [global::System.Runtime.CompilerServices.Nullable(2)] string elementPrefix, global::System.Xml.XmlNamespaceManager manager)
		{
			string text = this.EncodeSpecialCharacters ? global::System.Xml.XmlConvert.EncodeLocalName(elementName) : global::System.Xml.XmlConvert.EncodeName(elementName);
			string text2 = global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(elementPrefix) ? manager.DefaultNamespace : manager.LookupNamespace(elementPrefix);
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text2))
			{
				return document.CreateElement(text);
			}
			return document.CreateElement(text, text2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000350EC File Offset: 0x000332EC
		private void DeserializeNode(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Converters.IXmlDocument document, global::System.Xml.XmlNamespaceManager manager, global::Newtonsoft.Json.Converters.IXmlNode currentNode)
		{
			global::Newtonsoft.Json.JsonToken tokenType;
			for (;;)
			{
				tokenType = reader.TokenType;
				switch (tokenType)
				{
				case global::Newtonsoft.Json.JsonToken.StartConstructor:
				{
					string propertyName = reader.Value.ToString();
					while (reader.Read())
					{
						if (reader.TokenType == global::Newtonsoft.Json.JsonToken.EndConstructor)
						{
							break;
						}
						this.DeserializeValue(reader, document, manager, propertyName, currentNode);
					}
					goto IL_1AE;
				}
				case global::Newtonsoft.Json.JsonToken.PropertyName:
				{
					if (currentNode.NodeType == global::System.Xml.XmlNodeType.Document && document.DocumentElement != null)
					{
						goto Block_3;
					}
					string text = reader.Value.ToString();
					reader.ReadAndAssert();
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartArray)
					{
						int num = 0;
						while (reader.Read() && reader.TokenType != global::Newtonsoft.Json.JsonToken.EndArray)
						{
							this.DeserializeValue(reader, document, manager, text, currentNode);
							num++;
						}
						if (num != 1 || !this.WriteArrayAttribute)
						{
							goto IL_1AE;
						}
						string text2;
						string b;
						global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetQualifiedNameParts(text, out text2, out b);
						string b2 = global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text2) ? manager.DefaultNamespace : manager.LookupNamespace(text2);
						using (global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>.Enumerator enumerator = currentNode.ChildNodes.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Newtonsoft.Json.Converters.IXmlNode xmlNode = enumerator.Current;
								global::Newtonsoft.Json.Converters.IXmlElement xmlElement = xmlNode as global::Newtonsoft.Json.Converters.IXmlElement;
								if (xmlElement != null && xmlElement.LocalName == b && xmlElement.NamespaceUri == b2)
								{
									this.AddJsonArrayAttribute(xmlElement, document);
									break;
								}
							}
							goto IL_1AE;
						}
					}
					this.DeserializeValue(reader, document, manager, text, currentNode);
					goto IL_1AE;
				}
				case global::Newtonsoft.Json.JsonToken.Comment:
					currentNode.AppendChild(document.CreateComment((string)reader.Value));
					goto IL_1AE;
				}
				break;
				IL_1AE:
				if (!reader.Read())
				{
					return;
				}
			}
			if (tokenType - global::Newtonsoft.Json.JsonToken.EndObject > 1)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected JsonToken when deserializing node: " + reader.TokenType.ToString());
			}
			return;
			Block_3:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifying a DeserializeRootElementName.");
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000352C4 File Offset: 0x000334C4
		private bool IsNamespaceAttribute(string attributeName, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string prefix)
		{
			if (attributeName.StartsWith("xmlns", global::System.StringComparison.Ordinal))
			{
				if (attributeName.Length == 5)
				{
					prefix = string.Empty;
					return true;
				}
				if (attributeName[5] == ':')
				{
					prefix = attributeName.Substring(6, attributeName.Length - 6);
					return true;
				}
			}
			prefix = null;
			return false;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00035314 File Offset: 0x00033514
		private bool ValueAttributes(global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> c)
		{
			foreach (global::Newtonsoft.Json.Converters.IXmlNode xmlNode in c)
			{
				if (!(xmlNode.NamespaceUri == "http://james.newtonking.com/projects/json") && (!(xmlNode.NamespaceUri == "http://www.w3.org/2000/xmlns/") || !(xmlNode.Value == "http://james.newtonking.com/projects/json")))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00035398 File Offset: 0x00033598
		public override bool CanConvert(global::System.Type valueType)
		{
			if (valueType.AssignableToTypeName("System.Xml.Linq.XObject", false))
			{
				return this.IsXObject(valueType);
			}
			return valueType.AssignableToTypeName("System.Xml.XmlNode", false) && this.IsXmlNode(valueType);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000353C7 File Offset: 0x000335C7
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private bool IsXObject(global::System.Type valueType)
		{
			return typeof(global::System.Xml.Linq.XObject).IsAssignableFrom(valueType);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000353D9 File Offset: 0x000335D9
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private bool IsXmlNode(global::System.Type valueType)
		{
			return typeof(global::System.Xml.XmlNode).IsAssignableFrom(valueType);
		}

		// Token: 0x040003F4 RID: 1012
		internal static readonly global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.IXmlNode>();

		// Token: 0x040003F5 RID: 1013
		private const string TextName = "#text";

		// Token: 0x040003F6 RID: 1014
		private const string CommentName = "#comment";

		// Token: 0x040003F7 RID: 1015
		private const string CDataName = "#cdata-section";

		// Token: 0x040003F8 RID: 1016
		private const string WhitespaceName = "#whitespace";

		// Token: 0x040003F9 RID: 1017
		private const string SignificantWhitespaceName = "#significant-whitespace";

		// Token: 0x040003FA RID: 1018
		private const string DeclarationName = "?xml";

		// Token: 0x040003FB RID: 1019
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	}
}
