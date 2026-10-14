using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002B7 RID: 695
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HslColor
	{
		// Token: 0x06001BB5 RID: 7093 RVA: 0x0004B3BA File Offset: 0x000495BA
		public CT_HslColor()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform>();
			this.itemsValueField = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0004B3D8 File Offset: 0x000495D8
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0004B3E0 File Offset: 0x000495E0
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
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

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0004B3E9 File Offset: 0x000495E9
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x0004B3F1 File Offset: 0x000495F1
		[global::System.Xml.Serialization.XmlAttribute]
		public int hue
		{
			get
			{
				return this.hueField;
			}
			set
			{
				this.hueField = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0004B3FA File Offset: 0x000495FA
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0004B402 File Offset: 0x00049602
		[global::System.Xml.Serialization.XmlAttribute]
		public int sat
		{
			get
			{
				return this.satField;
			}
			set
			{
				this.satField = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0004B40B File Offset: 0x0004960B
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0004B413 File Offset: 0x00049613
		[global::System.Xml.Serialization.XmlAttribute]
		public int lum
		{
			get
			{
				return this.lumField;
			}
			set
			{
				this.lumField = value;
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0004B41C File Offset: 0x0004961C
		public static global::NPOI.OpenXmlFormats.Dml.CT_HslColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_HslColor ct_HslColor = new global::NPOI.OpenXmlFormats.Dml.CT_HslColor();
			ct_HslColor.hue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["hue"]);
			ct_HslColor.sat = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sat"]);
			ct_HslColor.lum = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lum"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alpha")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alpha);
				}
				else if (xmlNode.LocalName == "alphaMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaMod);
				}
				else if (xmlNode.LocalName == "alphaOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaOff);
				}
				else if (xmlNode.LocalName == "blue")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blue);
				}
				else if (xmlNode.LocalName == "blueMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueMod);
				}
				else if (xmlNode.LocalName == "blueOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueOff);
				}
				else if (xmlNode.LocalName == "comp")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.comp);
				}
				else if (xmlNode.LocalName == "gamma")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gamma);
				}
				else if (xmlNode.LocalName == "gray")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gray);
				}
				else if (xmlNode.LocalName == "green")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.green);
				}
				else if (xmlNode.LocalName == "greenMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenMod);
				}
				else if (xmlNode.LocalName == "greenOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenOff);
				}
				else if (xmlNode.LocalName == "hue")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hue);
				}
				else if (xmlNode.LocalName == "hueMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueMod);
				}
				else if (xmlNode.LocalName == "hueOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueOff);
				}
				else if (xmlNode.LocalName == "inv")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.inv);
				}
				else if (xmlNode.LocalName == "invGamma")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.invGamma);
				}
				else if (xmlNode.LocalName == "lum")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lum);
				}
				else if (xmlNode.LocalName == "lumMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumMod);
				}
				else if (xmlNode.LocalName == "lumOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumOff);
				}
				else if (xmlNode.LocalName == "red")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.red);
				}
				else if (xmlNode.LocalName == "redMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redMod);
				}
				else if (xmlNode.LocalName == "redOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redOff);
				}
				else if (xmlNode.LocalName == "sat")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.sat);
				}
				else if (xmlNode.LocalName == "satMod")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satMod);
				}
				else if (xmlNode.LocalName == "satOff")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satOff);
				}
				else if (xmlNode.LocalName == "shade")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.shade);
				}
				else if (xmlNode.LocalName == "tint")
				{
					ct_HslColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.tint);
				}
				if (xmlNode.Attributes["val"] != null)
				{
					ct_HslColor.itemsValueField.Add(xmlNode.Attributes["val"].Value);
				}
				else
				{
					ct_HslColor.itemsValueField.Add(null);
				}
			}
			return ct_HslColor;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0004B8F8 File Offset: 0x00049AF8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hue", this.hue);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sat", this.sat);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lum", this.lum);
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

		// Token: 0x04001511 RID: 5393
		private global::System.Collections.Generic.List<string> itemsValueField;

		// Token: 0x04001512 RID: 5394
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform> itemsElementNameField;

		// Token: 0x04001513 RID: 5395
		private int hueField;

		// Token: 0x04001514 RID: 5396
		private int satField;

		// Token: 0x04001515 RID: 5397
		private int lumField;
	}
}
