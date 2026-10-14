using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Xml.Schema;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001C6 RID: 454
	public class XmlNodePropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x060010E0 RID: 4320 RVA: 0x0003CC11 File Offset: 0x0003AE11
		internal XmlNodePropertyDescriptor(string name) : this(name, name, false)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0003CC1C File Offset: 0x0003AE1C
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

		// Token: 0x060010E2 RID: 4322 RVA: 0x0003CC74 File Offset: 0x0003AE74
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0003CDAE File Offset: 0x0003AFAE
		public global::System.Xml.Schema.IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0003CDB6 File Offset: 0x0003AFB6
		public override global::System.Type ComponentType
		{
			get
			{
				return typeof(global::System.Xml.XmlNode);
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0003CDC2 File Offset: 0x0003AFC2
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0003CDC5 File Offset: 0x0003AFC5
		public override string DisplayName
		{
			get
			{
				return this._displayName;
			}
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0003CDD0 File Offset: 0x0003AFD0
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0003D07F File Offset: 0x0003B27F
		public override global::System.Type PropertyType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0003D087 File Offset: 0x0003B287
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0003D089 File Offset: 0x0003B289
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0003D08C File Offset: 0x0003B28C
		public override bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0003D094 File Offset: 0x0003B294
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

		// Token: 0x060010ED RID: 4333 RVA: 0x0003D26C File Offset: 0x0003B46C
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

		// Token: 0x060010EE RID: 4334 RVA: 0x0003D354 File Offset: 0x0003B554
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

		// Token: 0x060010EF RID: 4335 RVA: 0x0003D42C File Offset: 0x0003B62C
		private void OnValidateChild(object sender, global::System.Xml.Schema.ValidationEventArgs e)
		{
			throw e.Exception;
		}

		// Token: 0x0400086C RID: 2156
		private global::System.Type _type;

		// Token: 0x0400086D RID: 2157
		private global::System.Xml.Schema.IXmlSchemaInfo _schema;

		// Token: 0x0400086E RID: 2158
		private bool _isReadOnly;

		// Token: 0x0400086F RID: 2159
		private bool _isAttribute;

		// Token: 0x04000870 RID: 2160
		private bool _useInnerText;

		// Token: 0x04000871 RID: 2161
		private string _displayName;
	}
}
