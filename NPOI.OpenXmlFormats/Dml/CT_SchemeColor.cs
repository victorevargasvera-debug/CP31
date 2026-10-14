using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002BA RID: 698
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SchemeColor
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x0004C01E File Offset: 0x0004A21E
		public CT_SchemeColor()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform>();
			this.itemsValueField = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0004C03C File Offset: 0x0004A23C
		public global::NPOI.OpenXmlFormats.Dml.CT_PositiveFixedPercentage AddNewShade()
		{
			global::NPOI.OpenXmlFormats.Dml.CT_PositiveFixedPercentage result = new global::NPOI.OpenXmlFormats.Dml.CT_PositiveFixedPercentage();
			this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.shade);
			this.itemsValueField.Add(null);
			return result;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0004C05C File Offset: 0x0004A25C
		public static global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor ct_SchemeColor = new global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor();
			if (node.Attributes["val"] != null)
			{
				ct_SchemeColor.val = (global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal), node.Attributes["val"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alpha")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alpha);
				}
				else if (xmlNode.LocalName == "alphaMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaMod);
				}
				else if (xmlNode.LocalName == "alphaOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaOff);
				}
				else if (xmlNode.LocalName == "blue")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blue);
				}
				else if (xmlNode.LocalName == "blueMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueMod);
				}
				else if (xmlNode.LocalName == "blueOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueOff);
				}
				else if (xmlNode.LocalName == "comp")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.comp);
				}
				else if (xmlNode.LocalName == "gamma")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gamma);
				}
				else if (xmlNode.LocalName == "gray")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gray);
				}
				else if (xmlNode.LocalName == "green")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.green);
				}
				else if (xmlNode.LocalName == "greenMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenMod);
				}
				else if (xmlNode.LocalName == "greenOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenOff);
				}
				else if (xmlNode.LocalName == "hue")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hue);
				}
				else if (xmlNode.LocalName == "hueMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueMod);
				}
				else if (xmlNode.LocalName == "hueOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueOff);
				}
				else if (xmlNode.LocalName == "inv")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.inv);
				}
				else if (xmlNode.LocalName == "invGamma")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.invGamma);
				}
				else if (xmlNode.LocalName == "lum")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lum);
				}
				else if (xmlNode.LocalName == "lumMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumMod);
				}
				else if (xmlNode.LocalName == "lumOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumOff);
				}
				else if (xmlNode.LocalName == "red")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.red);
				}
				else if (xmlNode.LocalName == "redMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redMod);
				}
				else if (xmlNode.LocalName == "redOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redOff);
				}
				else if (xmlNode.LocalName == "sat")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.sat);
				}
				else if (xmlNode.LocalName == "satMod")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satMod);
				}
				else if (xmlNode.LocalName == "satOff")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satOff);
				}
				else if (xmlNode.LocalName == "shade")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.shade);
				}
				else if (xmlNode.LocalName == "tint")
				{
					ct_SchemeColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.tint);
				}
				if (xmlNode.Attributes["val"] != null)
				{
					ct_SchemeColor.itemsValueField.Add(xmlNode.Attributes["val"].Value);
				}
				else
				{
					ct_SchemeColor.itemsValueField.Add(null);
				}
			}
			return ct_SchemeColor;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0004C528 File Offset: 0x0004A728
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			if (this.ItemsElementName.Count > 0)
			{
				sw.Write(">");
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform eg_ColorTransform = this.itemsElementNameField[i];
					string text = this.itemsValueField[i];
					sw.Write(string.Format("<a:{0}", eg_ColorTransform));
					if (text != null)
					{
						sw.Write(" val=\"" + text + "\"");
					}
					sw.Write("/>");
				}
				sw.Write(string.Format("</a:{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x0004C608 File Offset: 0x0004A808
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x0004C610 File Offset: 0x0004A810
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform> ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0004C619 File Offset: 0x0004A819
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0004C621 File Offset: 0x0004A821
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04001539 RID: 5433
		private global::System.Collections.Generic.List<string> itemsValueField;

		// Token: 0x0400153A RID: 5434
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform> itemsElementNameField;

		// Token: 0x0400153B RID: 5435
		private global::NPOI.OpenXmlFormats.Dml.ST_SchemeColorVal valField;
	}
}
