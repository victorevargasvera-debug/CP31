using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002B6 RID: 694
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SRgbColor
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x0004AE02 File Offset: 0x00049002
		public CT_SRgbColor()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform>();
			this.itemsValueField = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0004AE20 File Offset: 0x00049020
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0004AE28 File Offset: 0x00049028
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x0004AE31 File Offset: 0x00049031
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0004AE39 File Offset: 0x00049039
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] val
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

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0004AE44 File Offset: 0x00049044
		public static global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor ct_SRgbColor = new global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor();
			ct_SRgbColor.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["val"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alpha")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alpha);
				}
				else if (xmlNode.LocalName == "alphaMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaMod);
				}
				else if (xmlNode.LocalName == "alphaOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaOff);
				}
				else if (xmlNode.LocalName == "blue")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blue);
				}
				else if (xmlNode.LocalName == "blueMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueMod);
				}
				else if (xmlNode.LocalName == "blueOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueOff);
				}
				else if (xmlNode.LocalName == "comp")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.comp);
				}
				else if (xmlNode.LocalName == "gamma")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gamma);
				}
				else if (xmlNode.LocalName == "gray")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gray);
				}
				else if (xmlNode.LocalName == "green")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.green);
				}
				else if (xmlNode.LocalName == "greenMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenMod);
				}
				else if (xmlNode.LocalName == "greenOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenOff);
				}
				else if (xmlNode.LocalName == "hue")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hue);
				}
				else if (xmlNode.LocalName == "hueMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueMod);
				}
				else if (xmlNode.LocalName == "hueOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueOff);
				}
				else if (xmlNode.LocalName == "inv")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.inv);
				}
				else if (xmlNode.LocalName == "invGamma")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.invGamma);
				}
				else if (xmlNode.LocalName == "lum")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lum);
				}
				else if (xmlNode.LocalName == "lumMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumMod);
				}
				else if (xmlNode.LocalName == "lumOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumOff);
				}
				else if (xmlNode.LocalName == "red")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.red);
				}
				else if (xmlNode.LocalName == "redMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redMod);
				}
				else if (xmlNode.LocalName == "redOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redOff);
				}
				else if (xmlNode.LocalName == "sat")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.sat);
				}
				else if (xmlNode.LocalName == "satMod")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satMod);
				}
				else if (xmlNode.LocalName == "satOff")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satOff);
				}
				else if (xmlNode.LocalName == "shade")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.shade);
				}
				else if (xmlNode.LocalName == "tint")
				{
					ct_SRgbColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.tint);
				}
				if (xmlNode.Attributes["val"] != null)
				{
					ct_SRgbColor.itemsValueField.Add(xmlNode.Attributes["val"].Value);
				}
				else
				{
					ct_SRgbColor.itemsValueField.Add(null);
				}
			}
			return ct_SRgbColor;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0004B2E8 File Offset: 0x000494E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
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

		// Token: 0x0400150E RID: 5390
		private global::System.Collections.Generic.List<string> itemsValueField;

		// Token: 0x0400150F RID: 5391
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform> itemsElementNameField;

		// Token: 0x04001510 RID: 5392
		private byte[] valField;
	}
}
