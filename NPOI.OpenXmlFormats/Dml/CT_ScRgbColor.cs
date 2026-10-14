using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002B4 RID: 692
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ScRgbColor
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x0004A7E1 File Offset: 0x000489E1
		public CT_ScRgbColor()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform>();
			this.itemsValueField = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0004A800 File Offset: 0x00048A00
		public static global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor ct_ScRgbColor = new global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor();
			ct_ScRgbColor.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["r"]);
			ct_ScRgbColor.g = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["g"]);
			ct_ScRgbColor.b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["b"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alpha")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alpha);
				}
				else if (xmlNode.LocalName == "alphaMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaMod);
				}
				else if (xmlNode.LocalName == "alphaOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaOff);
				}
				else if (xmlNode.LocalName == "blue")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blue);
				}
				else if (xmlNode.LocalName == "blueMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueMod);
				}
				else if (xmlNode.LocalName == "blueOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueOff);
				}
				else if (xmlNode.LocalName == "comp")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.comp);
				}
				else if (xmlNode.LocalName == "gamma")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gamma);
				}
				else if (xmlNode.LocalName == "gray")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gray);
				}
				else if (xmlNode.LocalName == "green")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.green);
				}
				else if (xmlNode.LocalName == "greenMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenMod);
				}
				else if (xmlNode.LocalName == "greenOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenOff);
				}
				else if (xmlNode.LocalName == "hue")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hue);
				}
				else if (xmlNode.LocalName == "hueMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueMod);
				}
				else if (xmlNode.LocalName == "hueOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueOff);
				}
				else if (xmlNode.LocalName == "inv")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.inv);
				}
				else if (xmlNode.LocalName == "invGamma")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.invGamma);
				}
				else if (xmlNode.LocalName == "lum")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lum);
				}
				else if (xmlNode.LocalName == "lumMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumMod);
				}
				else if (xmlNode.LocalName == "lumOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumOff);
				}
				else if (xmlNode.LocalName == "red")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.red);
				}
				else if (xmlNode.LocalName == "redMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redMod);
				}
				else if (xmlNode.LocalName == "redOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redOff);
				}
				else if (xmlNode.LocalName == "sat")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.sat);
				}
				else if (xmlNode.LocalName == "satMod")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satMod);
				}
				else if (xmlNode.LocalName == "satOff")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satOff);
				}
				else if (xmlNode.LocalName == "shade")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.shade);
				}
				else if (xmlNode.LocalName == "tint")
				{
					ct_ScRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.tint);
				}
				if (xmlNode.Attributes["val"] != null)
				{
					ct_ScRgbColor.itemsValueField.Add(xmlNode.Attributes["val"].Value);
				}
				else
				{
					ct_ScRgbColor.itemsValueField.Add(null);
				}
			}
			return ct_ScRgbColor;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0004ACDC File Offset: 0x00048EDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "g", this.g, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", this.b, true);
			sw.Write(">");
			if (this.ItemsElementName != null)
			{
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
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0004ADBE File Offset: 0x00048FBE
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0004ADC6 File Offset: 0x00048FC6
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

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0004ADCF File Offset: 0x00048FCF
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0004ADD7 File Offset: 0x00048FD7
		[global::System.Xml.Serialization.XmlAttribute]
		public int r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0004ADE0 File Offset: 0x00048FE0
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0004ADE8 File Offset: 0x00048FE8
		[global::System.Xml.Serialization.XmlAttribute]
		public int g
		{
			get
			{
				return this.gField;
			}
			set
			{
				this.gField = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0004ADF1 File Offset: 0x00048FF1
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0004ADF9 File Offset: 0x00048FF9
		[global::System.Xml.Serialization.XmlAttribute]
		public int b
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

		// Token: 0x040014EC RID: 5356
		private global::System.Collections.Generic.List<string> itemsValueField;

		// Token: 0x040014ED RID: 5357
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform> itemsElementNameField;

		// Token: 0x040014EE RID: 5358
		private int rField;

		// Token: 0x040014EF RID: 5359
		private int gField;

		// Token: 0x040014F0 RID: 5360
		private int bField;
	}
}
