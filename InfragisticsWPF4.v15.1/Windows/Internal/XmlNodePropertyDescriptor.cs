using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Schema;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001F4 RID: 500
	public class XmlNodePropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x00042351 File Offset: 0x00040551
		internal XmlNodePropertyDescriptor(string name) : this(name, name, false)
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0004235C File Offset: 0x0004055C
		internal XmlNodePropertyDescriptor(string name, string localName, bool treatAsList) : base(name, null)
		{
			this._isReadOnly = true;
			if (treatAsList)
			{
				this._useInnerText = false;
				this._type = typeof(global::System.Collections.IList);
			}
			else
			{
				this._useInnerText = true;
				this._type = typeof(string);
			}
			this._displayName = localName;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000423B4 File Offset: 0x000405B4
		public XmlNodePropertyDescriptor(global::System.Xml.XmlNode node) : base(node.Name, null)
		{
			this._isAttribute = (node is global::System.Xml.XmlAttribute);
			this._isReadOnly = node.IsReadOnly;
			this._schema = node.SchemaInfo;
			this._displayName = node.LocalName;
			if (node.HasChildNodes && (node.ChildNodes.Count > 1 || (node.ChildNodes.Count == 1 && node.FirstChild is global::System.Xml.XmlElement)))
			{
				this._type = typeof(global::System.Collections.IEnumerable);
				return;
			}
			if (this._schema != null)
			{
				if (this._schema.MemberType != null && this._schema.MemberType.Datatype != null)
				{
					this._type = this._schema.MemberType.Datatype.ValueType;
				}
				if (this._type == null && this._schema.SchemaType != null && this._schema.SchemaType.Datatype != null)
				{
					this._type = this._schema.SchemaType.Datatype.ValueType;
				}
			}
			if (this._type == null)
			{
				this._type = typeof(string);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000424EE File Offset: 0x000406EE
		public global::System.Xml.Schema.IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000424F6 File Offset: 0x000406F6
		public override global::System.Type ComponentType
		{
			get
			{
				return typeof(global::System.Xml.XmlNode);
			}
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00042502 File Offset: 0x00040702
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00042505 File Offset: 0x00040705
		public override string DisplayName
		{
			get
			{
				return this._displayName;
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00042510 File Offset: 0x00040710
		public override object GetValue(object component)
		{
			global::System.Xml.XmlNode xmlNode = component as global::System.Xml.XmlNode;
			if (xmlNode == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_2"));
			}
			object valueInternal = this.GetValueInternal(xmlNode, true);
			string text = valueInternal as string;
			if (valueInternal != null && text == null)
			{
				return valueInternal;
			}
			if (this._type == typeof(string))
			{
				return text;
			}
			if (this._type == typeof(bool))
			{
				return global::System.Xml.XmlConvert.ToBoolean(text);
			}
			if (this._type == typeof(byte))
			{
				return global::System.Xml.XmlConvert.ToByte(text);
			}
			if (this._type == typeof(char))
			{
				return global::System.Xml.XmlConvert.ToChar(text);
			}
			if (this._type == typeof(global::System.DateTime))
			{
				return global::System.Xml.XmlConvert.ToDateTime(text, global::System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
			}
			if (this._type == typeof(decimal))
			{
				return global::System.Xml.XmlConvert.ToDecimal(text);
			}
			if (this._type == typeof(double))
			{
				return global::System.Xml.XmlConvert.ToDouble(text);
			}
			if (this._type == typeof(global::System.Guid))
			{
				return global::System.Xml.XmlConvert.ToGuid(text);
			}
			if (this._type == typeof(short))
			{
				return global::System.Xml.XmlConvert.ToInt16(text);
			}
			if (this._type == typeof(int))
			{
				return global::System.Xml.XmlConvert.ToInt32(text);
			}
			if (this._type == typeof(long))
			{
				return global::System.Xml.XmlConvert.ToInt64(text);
			}
			if (this._type == typeof(sbyte))
			{
				return global::System.Xml.XmlConvert.ToSByte(text);
			}
			if (this._type == typeof(float))
			{
				return global::System.Xml.XmlConvert.ToSingle(text);
			}
			if (this._type == typeof(global::System.TimeSpan))
			{
				return global::System.Xml.XmlConvert.ToTimeSpan(text);
			}
			if (this._type == typeof(ushort))
			{
				return global::System.Xml.XmlConvert.ToUInt16(text);
			}
			if (this._type == typeof(uint))
			{
				return global::System.Xml.XmlConvert.ToUInt32(text);
			}
			if (this._type == typeof(ulong))
			{
				return global::System.Xml.XmlConvert.ToUInt64(text);
			}
			if (typeof(global::System.IConvertible).IsAssignableFrom(this._type))
			{
				return ((global::System.IConvertible)text).ToType(this._type, null);
			}
			return text;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000427BF File Offset: 0x000409BF
		public override global::System.Type PropertyType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000427C7 File Offset: 0x000409C7
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000427C9 File Offset: 0x000409C9
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000427CC File Offset: 0x000409CC
		public override bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000427D4 File Offset: 0x000409D4
		public override void SetValue(object component, object value)
		{
			global::System.Xml.XmlNode xmlNode = component as global::System.Xml.XmlNode;
			if (xmlNode == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_2"));
			}
			if (this._useInnerText)
			{
				throw new global::System.Data.ReadOnlyException();
			}
			string text = value as string;
			if (value != null && text == null)
			{
				if (value is bool)
				{
					text = global::System.Xml.XmlConvert.ToString((bool)value);
				}
				else if (value is byte)
				{
					text = global::System.Xml.XmlConvert.ToString((byte)value);
				}
				else if (value is char)
				{
					text = global::System.Xml.XmlConvert.ToString((char)value);
				}
				else if (value is global::System.DateTime)
				{
					text = global::System.Xml.XmlConvert.ToString((global::System.DateTime)value, global::System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
				}
				else if (value is decimal)
				{
					text = global::System.Xml.XmlConvert.ToString((decimal)value);
				}
				else if (value is double)
				{
					text = global::System.Xml.XmlConvert.ToString((double)value);
				}
				else if (value is global::System.Guid)
				{
					text = global::System.Xml.XmlConvert.ToString((global::System.Guid)value);
				}
				else if (value is short)
				{
					text = global::System.Xml.XmlConvert.ToString((short)value);
				}
				else if (value is int)
				{
					text = global::System.Xml.XmlConvert.ToString((int)value);
				}
				else if (value is long)
				{
					text = global::System.Xml.XmlConvert.ToString((long)value);
				}
				else if (value is sbyte)
				{
					text = global::System.Xml.XmlConvert.ToString((sbyte)value);
				}
				else if (value is float)
				{
					text = global::System.Xml.XmlConvert.ToString((float)value);
				}
				else if (value is global::System.TimeSpan)
				{
					text = global::System.Xml.XmlConvert.ToString((global::System.TimeSpan)value);
				}
				else if (value is ushort)
				{
					text = global::System.Xml.XmlConvert.ToString((ushort)value);
				}
				else if (value is uint)
				{
					text = global::System.Xml.XmlConvert.ToString((uint)value);
				}
				else if (value is ulong)
				{
					text = global::System.Xml.XmlConvert.ToString((ulong)value);
				}
				else
				{
					text = value.ToString();
				}
			}
			this.SetValueInternal(xmlNode, text, true);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000429AC File Offset: 0x00040BAC
		private object GetValueInternal(global::System.Xml.XmlNode node, bool useDefaultSource)
		{
			if (this._useInnerText)
			{
				return node.InnerText;
			}
			bool flag;
			if (useDefaultSource)
			{
				flag = this._isAttribute;
			}
			else
			{
				flag = !this._isAttribute;
			}
			if (flag)
			{
				global::System.Xml.XmlNode namedItem = node.Attributes.GetNamedItem(this.Name);
				if (namedItem != null)
				{
					return namedItem.InnerText;
				}
				if (useDefaultSource)
				{
					return this.GetValueInternal(node, false);
				}
				return null;
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Xml.XmlNode> list = (this._type == typeof(global::System.Collections.IList)) ? new global::System.Collections.Generic.List<global::System.Xml.XmlNode>() : null;
				for (global::System.Xml.XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
				{
					if (xmlNode.Name == this.Name)
					{
						if (list != null)
						{
							list.Add(xmlNode);
						}
						else
						{
							if (this._type == typeof(global::System.Collections.IEnumerable))
							{
								return xmlNode.ChildNodes;
							}
							return xmlNode.InnerText;
						}
					}
				}
				if (list != null)
				{
					return list;
				}
				if (useDefaultSource)
				{
					return this.GetValueInternal(node, false);
				}
				return null;
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00042A94 File Offset: 0x00040C94
		private void SetValueInternal(global::System.Xml.XmlNode node, string text, bool useDefaultSource)
		{
			bool flag;
			if (useDefaultSource)
			{
				flag = this._isAttribute;
			}
			else
			{
				flag = !this._isAttribute;
			}
			global::System.Xml.XmlNode xmlNode = null;
			string innerText = null;
			if (flag)
			{
				xmlNode = node.Attributes.GetNamedItem(this.Name);
			}
			else
			{
				for (global::System.Xml.XmlNode xmlNode2 = node.FirstChild; xmlNode2 != null; xmlNode2 = xmlNode2.NextSibling)
				{
					if (xmlNode2.Name == this.Name)
					{
						xmlNode = xmlNode2;
						break;
					}
				}
			}
			if (xmlNode == null && useDefaultSource)
			{
				this.SetValueInternal(node, text, false);
				return;
			}
			if (xmlNode != null)
			{
				try
				{
					innerText = xmlNode.InnerText;
					xmlNode.InnerText = text;
					if (xmlNode.OwnerDocument != null && xmlNode.OwnerDocument.Schemas.Count > 0)
					{
						xmlNode.OwnerDocument.Validate(new global::System.Xml.Schema.ValidationEventHandler(this.OnValidateChild), xmlNode);
					}
				}
				catch
				{
					xmlNode.InnerText = innerText;
					throw;
				}
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00042B6C File Offset: 0x00040D6C
		private void OnValidateChild(object sender, global::System.Xml.Schema.ValidationEventArgs e)
		{
			throw e.Exception;
		}

		// Token: 0x040009AD RID: 2477
		private global::System.Type _type;

		// Token: 0x040009AE RID: 2478
		private global::System.Xml.Schema.IXmlSchemaInfo _schema;

		// Token: 0x040009AF RID: 2479
		private bool _isReadOnly;

		// Token: 0x040009B0 RID: 2480
		private bool _isAttribute;

		// Token: 0x040009B1 RID: 2481
		private bool _useInnerText;

		// Token: 0x040009B2 RID: 2482
		private string _displayName;
	}
}
