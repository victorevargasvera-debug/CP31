using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000506 RID: 1286
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "font")]
	[global::System.Serializable]
	public class CT_Font
	{
		// Token: 0x060036D6 RID: 14038 RVA: 0x00088AD4 File Offset: 0x00086CD4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font ct_Font = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font();
			ct_Font.charset = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty>();
			ct_Font.family = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty>();
			ct_Font.b = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty>();
			ct_Font.i = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty>();
			ct_Font.strike = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty>();
			ct_Font.color = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color>();
			ct_Font.sz = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize>();
			ct_Font.u = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty>();
			ct_Font.vertAlign = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty>();
			ct_Font.scheme = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "outline")
				{
					ct_Font.outline = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_Font.shadow = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "condense")
				{
					ct_Font.condense = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extend")
				{
					ct_Font.extend = global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "name")
				{
					ct_Font.name = global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "charset")
				{
					ct_Font.charset.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "family")
				{
					ct_Font.family.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_Font.b.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "i")
				{
					ct_Font.i.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "strike")
				{
					ct_Font.strike.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_Font.color.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "sz")
				{
					ct_Font.sz.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "u")
				{
					ct_Font.u.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "vertAlign")
				{
					ct_Font.vertAlign.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "scheme")
				{
					ct_Font.scheme.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Font;
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00088DF4 File Offset: 0x00086FF4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			if (this.b != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty in this.b)
				{
					ct_BooleanProperty.Write(sw, "b");
				}
			}
			if (this.i != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty2 in this.i)
				{
					ct_BooleanProperty2.Write(sw, "i");
				}
			}
			if (this.strike != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty3 in this.strike)
				{
					ct_BooleanProperty3.Write(sw, "strike");
				}
			}
			if (this.condense != null)
			{
				this.condense.Write(sw, "condense");
			}
			if (this.extend != null)
			{
				this.extend.Write(sw, "extend");
			}
			if (this.outline != null)
			{
				this.outline.Write(sw, "outline");
			}
			if (this.shadow != null)
			{
				this.shadow.Write(sw, "shadow");
			}
			if (this.u != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty ct_UnderlineProperty in this.u)
				{
					ct_UnderlineProperty.Write(sw, "u");
				}
			}
			if (this.vertAlign != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty ct_VerticalAlignFontProperty in this.vertAlign)
				{
					ct_VerticalAlignFontProperty.Write(sw, "vertAlign");
				}
			}
			if (this.sz != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize ct_FontSize in this.sz)
				{
					ct_FontSize.Write(sw, "sz");
				}
			}
			if (this.color != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color in this.color)
				{
					ct_Color.Write(sw, "color");
				}
			}
			if (this.name != null)
			{
				this.name.Write(sw, "name");
			}
			if (this.family != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty in this.family)
				{
					ct_IntProperty.Write(sw, "family");
				}
			}
			if (this.charset != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty2 in this.charset)
				{
					ct_IntProperty2.Write(sw, "charset");
				}
			}
			if (this.scheme != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme ct_FontScheme in this.scheme)
				{
					ct_FontScheme.Write(sw, "scheme");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000891B8 File Offset: 0x000873B8
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x000891C0 File Offset: 0x000873C0
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x000891C9 File Offset: 0x000873C9
		public int sizeOfNameArray()
		{
			if (this.nameField == null)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000891D6 File Offset: 0x000873D6
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName AddNewName()
		{
			this.nameField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName();
			return this.nameField;
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x000891E9 File Offset: 0x000873E9
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x000891F1 File Offset: 0x000873F1
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty> charset
		{
			get
			{
				return this.charsetField;
			}
			set
			{
				this.charsetField = value;
			}
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x000891FA File Offset: 0x000873FA
		public int sizeOfCharsetArray()
		{
			if (this.charsetField == null)
			{
				return 0;
			}
			return this.charsetField.Count;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00089214 File Offset: 0x00087414
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty AddNewCharset()
		{
			if (this.charsetField == null)
			{
				this.charsetField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty();
			this.charsetField.Add(ct_IntProperty);
			return ct_IntProperty;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00089247 File Offset: 0x00087447
		public void SetCharsetArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty value)
		{
			this.charsetField[index] = value;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00089256 File Offset: 0x00087456
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty GetCharsetArray(int index)
		{
			return this.charsetField[index];
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x00089264 File Offset: 0x00087464
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x0008926C File Offset: 0x0008746C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty> family
		{
			get
			{
				return this.familyField;
			}
			set
			{
				this.familyField = value;
			}
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00089275 File Offset: 0x00087475
		public int sizeOfFamilyArray()
		{
			if (this.familyField == null)
			{
				return 0;
			}
			return this.familyField.Count;
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x0008928C File Offset: 0x0008748C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty AddNewFamily()
		{
			if (this.familyField == null)
			{
				this.familyField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty();
			this.familyField.Add(ct_IntProperty);
			return ct_IntProperty;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x000892BF File Offset: 0x000874BF
		public void SetFamilyArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty value)
		{
			this.familyField[index] = value;
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x000892CE File Offset: 0x000874CE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty GetFamilyArray(int index)
		{
			return this.familyField[index];
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x000892DC File Offset: 0x000874DC
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x000892E4 File Offset: 0x000874E4
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x000892ED File Offset: 0x000874ED
		public int SizeOfBArray()
		{
			if (this.bField == null)
			{
				return 0;
			}
			return this.bField.Count;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00089304 File Offset: 0x00087504
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewB()
		{
			if (this.bField == null)
			{
				this.bField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			this.bField.Add(ct_BooleanProperty);
			return ct_BooleanProperty;
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00089337 File Offset: 0x00087537
		public void SetBArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty value)
		{
			this.bField[index] = value;
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x000892E4 File Offset: 0x000874E4
		public void SetBArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> array)
		{
			this.bField = array;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00089346 File Offset: 0x00087546
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetBArray(int index)
		{
			return this.bField[index];
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x00089354 File Offset: 0x00087554
		// (set) Token: 0x060036F0 RID: 14064 RVA: 0x0008935C File Offset: 0x0008755C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00089365 File Offset: 0x00087565
		public int sizeOfIArray()
		{
			if (this.iField == null)
			{
				return 0;
			}
			return this.iField.Count;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0008937C File Offset: 0x0008757C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewI()
		{
			if (this.iField == null)
			{
				this.iField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			this.iField.Add(ct_BooleanProperty);
			return ct_BooleanProperty;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x000893AF File Offset: 0x000875AF
		public void SetIArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty value)
		{
			this.iField[index] = value;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x0008935C File Offset: 0x0008755C
		public void SetIArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> array)
		{
			this.iField = array;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000893BE File Offset: 0x000875BE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetIArray(int index)
		{
			return this.iField[index];
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x000893CC File Offset: 0x000875CC
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x000893D4 File Offset: 0x000875D4
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> strike
		{
			get
			{
				return this.strikeField;
			}
			set
			{
				this.strikeField = value;
			}
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x000893DD File Offset: 0x000875DD
		public int sizeOfStrikeArray()
		{
			if (this.strikeField == null)
			{
				return 0;
			}
			return this.strikeField.Count;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000893F4 File Offset: 0x000875F4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewStrike()
		{
			if (this.strikeField == null)
			{
				this.strikeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			this.strikeField.Add(ct_BooleanProperty);
			return ct_BooleanProperty;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00089427 File Offset: 0x00087627
		public void SetStrikeArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty value)
		{
			this.strikeField[index] = value;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x000893D4 File Offset: 0x000875D4
		public void SetStrikeArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> array)
		{
			this.strikeField = array;
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00089436 File Offset: 0x00087636
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetStrikeArray(int index)
		{
			return this.strikeField[index];
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x00089444 File Offset: 0x00087644
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x0008944C File Offset: 0x0008764C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00089455 File Offset: 0x00087655
		public int sizeOfOutlineArray()
		{
			if (this.outlineField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00089462 File Offset: 0x00087662
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewOutline()
		{
			this.outlineField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.outlineField;
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00089475 File Offset: 0x00087675
		public void SetOutlineArray(global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty[] array)
		{
			this.outlineField = ((array.Length != 0) ? array[0] : null);
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00089487 File Offset: 0x00087687
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetOutlineArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.outlineField;
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x0008949D File Offset: 0x0008769D
		// (set) Token: 0x06003704 RID: 14084 RVA: 0x000894A5 File Offset: 0x000876A5
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x000894AE File Offset: 0x000876AE
		public int sizeOfShadowArray()
		{
			if (this.shadowField == null)
			{
				return 0;
			}
			if (this.shadowField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x000894C5 File Offset: 0x000876C5
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewShadow()
		{
			this.shadowField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.shadowField;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x000894D8 File Offset: 0x000876D8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetShadowArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.shadowField;
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x000894EE File Offset: 0x000876EE
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x000894F6 File Offset: 0x000876F6
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty condense
		{
			get
			{
				return this.condenseField;
			}
			set
			{
				this.condenseField = value;
			}
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x000894FF File Offset: 0x000876FF
		public int sizeOfCondenseArray()
		{
			if (this.condenseField == null)
			{
				return 0;
			}
			if (this.condenseField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00089516 File Offset: 0x00087716
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewCondense()
		{
			this.condenseField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.condenseField;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00089529 File Offset: 0x00087729
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetCondenseArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.condenseField;
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x0008953F File Offset: 0x0008773F
		// (set) Token: 0x0600370E RID: 14094 RVA: 0x00089547 File Offset: 0x00087747
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty extend
		{
			get
			{
				return this.extendField;
			}
			set
			{
				this.extendField = value;
			}
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00089550 File Offset: 0x00087750
		public int sizeOfExtendArray()
		{
			if (this.extendField != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x0008955D File Offset: 0x0008775D
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty AddNewExtend()
		{
			this.extendField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
			return this.extendField;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00089570 File Offset: 0x00087770
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty GetExtendArray(int index)
		{
			if (index != 0)
			{
				throw new global::System.IndexOutOfRangeException("Only an index of 0 is supported");
			}
			return this.extendField;
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x00089586 File Offset: 0x00087786
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x0008958E File Offset: 0x0008778E
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00089597 File Offset: 0x00087797
		public int sizeOfColorArray()
		{
			if (this.colorField == null)
			{
				return 0;
			}
			return this.colorField.Count;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x000895AE File Offset: 0x000877AE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color GetColorArray(int index)
		{
			return this.colorField[index];
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x000895BC File Offset: 0x000877BC
		public void SetColorArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color value)
		{
			this.colorField[index] = value;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0008958E File Offset: 0x0008778E
		public void SetColorArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> array)
		{
			this.colorField = array;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x000895CC File Offset: 0x000877CC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color AddNewColor()
		{
			if (this.colorField == null)
			{
				this.colorField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color();
			this.colorField.Add(ct_Color);
			return ct_Color;
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x000895FF File Offset: 0x000877FF
		// (set) Token: 0x0600371A RID: 14106 RVA: 0x00089607 File Offset: 0x00087807
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize> sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
			}
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00089610 File Offset: 0x00087810
		public int sizeOfSzArray()
		{
			if (this.szField == null)
			{
				return 0;
			}
			return this.szField.Count;
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00089628 File Offset: 0x00087828
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize AddNewSz()
		{
			if (this.szField == null)
			{
				this.szField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize ct_FontSize = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize();
			this.szField.Add(ct_FontSize);
			return ct_FontSize;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0008965B File Offset: 0x0008785B
		public void SetSzArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize value)
		{
			this.szField[index] = value;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00089607 File Offset: 0x00087807
		public void SetSzArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize> array)
		{
			this.szField = array;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x0008966A File Offset: 0x0008786A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize GetSzArray(int index)
		{
			return this.szField[index];
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x00089678 File Offset: 0x00087878
		// (set) Token: 0x06003721 RID: 14113 RVA: 0x00089680 File Offset: 0x00087880
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty> u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x00089689 File Offset: 0x00087889
		public int sizeOfUArray()
		{
			if (this.uField == null)
			{
				return 0;
			}
			return this.uField.Count;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x000896A0 File Offset: 0x000878A0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty AddNewU()
		{
			if (this.uField == null)
			{
				this.uField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty ct_UnderlineProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty();
			this.uField.Add(ct_UnderlineProperty);
			return ct_UnderlineProperty;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x000896D3 File Offset: 0x000878D3
		public void SetUArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty value)
		{
			if (this.uField[index] != null)
			{
				this.uField[index] = value;
				return;
			}
			this.uField.Insert(index, value);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00089680 File Offset: 0x00087880
		public void SetUArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty> array)
		{
			this.uField = array;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x000896FE File Offset: 0x000878FE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty GetUArray(int index)
		{
			return this.uField[index];
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x0008970C File Offset: 0x0008790C
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x00089714 File Offset: 0x00087914
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty> vertAlign
		{
			get
			{
				return this.vertAlignField;
			}
			set
			{
				this.vertAlignField = value;
			}
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0008971D File Offset: 0x0008791D
		public int sizeOfVertAlignArray()
		{
			if (this.vertAlignField == null)
			{
				return 0;
			}
			return this.vertAlignField.Count;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00089734 File Offset: 0x00087934
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty AddNewVertAlign()
		{
			if (this.vertAlignField == null)
			{
				this.vertAlignField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty ct_VerticalAlignFontProperty = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty();
			this.vertAlignField.Add(ct_VerticalAlignFontProperty);
			return ct_VerticalAlignFontProperty;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00089767 File Offset: 0x00087967
		public void SetVertAlignArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty value)
		{
			this.vertAlignField[index] = value;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00089714 File Offset: 0x00087914
		public void SetVertAlignArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty> array)
		{
			this.vertAlignField = array;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00089776 File Offset: 0x00087976
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty GetVertAlignArray(int index)
		{
			return this.vertAlignField[index];
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x00089784 File Offset: 0x00087984
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x0008978C File Offset: 0x0008798C
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme> scheme
		{
			get
			{
				return this.schemeField;
			}
			set
			{
				this.schemeField = value;
			}
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00089795 File Offset: 0x00087995
		public int sizeOfSchemeArray()
		{
			if (this.schemeField == null)
			{
				return 0;
			}
			return this.schemeField.Count;
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x000897AC File Offset: 0x000879AC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme AddNewScheme()
		{
			if (this.schemeField == null)
			{
				this.schemeField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme ct_FontScheme = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme();
			this.schemeField.Add(ct_FontScheme);
			return ct_FontScheme;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x000897DF File Offset: 0x000879DF
		public void SetSchemeArray(int index, global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme value)
		{
			this.schemeField[index] = value;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x000897EE File Offset: 0x000879EE
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme GetSchemeArray(int index)
		{
			return this.schemeField[index];
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000897FC File Offset: 0x000879FC
		public override string ToString()
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
				this.Write(streamWriter, "font");
				streamWriter.Flush();
				memoryStream.Position = 0L;
				result = new global::System.IO.StreamReader(memoryStream).ReadToEnd();
			}
			return result;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0008985C File Offset: 0x00087A5C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font Clone()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font ct_Font = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font();
			if (this.name != null)
			{
				ct_Font.AddNewName().val = this.name.val;
			}
			if (this.charset != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty in this.charset)
				{
					ct_Font.AddNewCharset().val = ct_IntProperty.val;
				}
			}
			if (this.family != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty2 in this.family)
				{
					ct_Font.AddNewFamily().val = ct_IntProperty2.val;
				}
			}
			if (this.b != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty in this.b)
				{
					ct_Font.AddNewB().val = ct_BooleanProperty.val;
				}
			}
			if (this.i != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty2 in this.i)
				{
					ct_Font.AddNewI().val = ct_BooleanProperty2.val;
				}
			}
			if (this.strike != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty3 in this.strike)
				{
					ct_Font.AddNewStrike().val = ct_BooleanProperty3.val;
				}
			}
			if (this.outline != null)
			{
				ct_Font.outline = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
				ct_Font.outline.val = this.outline.val;
			}
			if (this.shadow != null)
			{
				ct_Font.shadow = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
				ct_Font.shadow.val = this.shadow.val;
			}
			if (this.condense != null)
			{
				ct_Font.condense = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
				ct_Font.condense.val = this.condense.val;
			}
			if (this.extend != null)
			{
				ct_Font.extend = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty();
				ct_Font.extend.val = this.extend.val;
			}
			if (this.color != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color in this.color)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color2 = ct_Font.AddNewColor();
					ct_Color2.theme = ct_Color.theme;
					ct_Color2.themeSpecified = ct_Color.themeSpecified;
					ct_Color2.rgb = ct_Color.rgb;
					ct_Color2.rgbSpecified = ct_Color.rgbSpecified;
					ct_Color2.tint = ct_Color.tint;
					ct_Color2.tintSpecified = ct_Color.tintSpecified;
					ct_Color2.auto = ct_Color.auto;
					ct_Color2.autoSpecified = ct_Color.autoSpecified;
				}
			}
			if (this.sz != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize ct_FontSize in this.sz)
				{
					ct_Font.AddNewSz().val = ct_FontSize.val;
				}
			}
			if (this.u != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty ct_UnderlineProperty in this.u)
				{
					ct_Font.AddNewU().val = ct_UnderlineProperty.val;
				}
			}
			if (this.vertAlign != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty ct_VerticalAlignFontProperty in this.vertAlign)
				{
					ct_Font.AddNewVertAlign().val = ct_VerticalAlignFontProperty.val;
				}
			}
			if (this.scheme != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme ct_FontScheme in this.scheme)
				{
					ct_Font.AddNewScheme().val = ct_FontScheme.val;
				}
			}
			return ct_Font;
		}

		// Token: 0x040023F8 RID: 9208
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName nameField;

		// Token: 0x040023F9 RID: 9209
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty> charsetField;

		// Token: 0x040023FA RID: 9210
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty> familyField;

		// Token: 0x040023FB RID: 9211
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> bField;

		// Token: 0x040023FC RID: 9212
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> iField;

		// Token: 0x040023FD RID: 9213
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty> strikeField;

		// Token: 0x040023FE RID: 9214
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty outlineField;

		// Token: 0x040023FF RID: 9215
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty shadowField;

		// Token: 0x04002400 RID: 9216
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty condenseField;

		// Token: 0x04002401 RID: 9217
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty extendField;

		// Token: 0x04002402 RID: 9218
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color> colorField;

		// Token: 0x04002403 RID: 9219
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize> szField;

		// Token: 0x04002404 RID: 9220
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty> uField;

		// Token: 0x04002405 RID: 9221
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty> vertAlignField;

		// Token: 0x04002406 RID: 9222
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme> schemeField;
	}
}
