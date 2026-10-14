using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002B8 RID: 696
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SystemColor
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x0004B9EC File Offset: 0x00049BEC
		public CT_SystemColor()
		{
			this.ItemsElementName = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform>();
			this.itemsValueField = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0004BA0C File Offset: 0x00049C0C
		public static global::NPOI.OpenXmlFormats.Dml.CT_SystemColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_SystemColor ct_SystemColor = new global::NPOI.OpenXmlFormats.Dml.CT_SystemColor();
			if (node.Attributes["val"] != null)
			{
				ct_SystemColor.val = (global::NPOI.OpenXmlFormats.Dml.ST_SystemColorVal)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_SystemColorVal), node.Attributes["val"].Value);
			}
			ct_SystemColor.lastClr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["lastClr"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alpha")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alpha);
				}
				else if (xmlNode.LocalName == "alphaMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaMod);
				}
				else if (xmlNode.LocalName == "alphaOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.alphaOff);
				}
				else if (xmlNode.LocalName == "blue")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blue);
				}
				else if (xmlNode.LocalName == "blueMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueMod);
				}
				else if (xmlNode.LocalName == "blueOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.blueOff);
				}
				else if (xmlNode.LocalName == "comp")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.comp);
				}
				else if (xmlNode.LocalName == "gamma")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gamma);
				}
				else if (xmlNode.LocalName == "gray")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.gray);
				}
				else if (xmlNode.LocalName == "green")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.green);
				}
				else if (xmlNode.LocalName == "greenMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenMod);
				}
				else if (xmlNode.LocalName == "greenOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.greenOff);
				}
				else if (xmlNode.LocalName == "hue")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hue);
				}
				else if (xmlNode.LocalName == "hueMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueMod);
				}
				else if (xmlNode.LocalName == "hueOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.hueOff);
				}
				else if (xmlNode.LocalName == "inv")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.inv);
				}
				else if (xmlNode.LocalName == "invGamma")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.invGamma);
				}
				else if (xmlNode.LocalName == "lum")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lum);
				}
				else if (xmlNode.LocalName == "lumMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumMod);
				}
				else if (xmlNode.LocalName == "lumOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.lumOff);
				}
				else if (xmlNode.LocalName == "red")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.red);
				}
				else if (xmlNode.LocalName == "redMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redMod);
				}
				else if (xmlNode.LocalName == "redOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.redOff);
				}
				else if (xmlNode.LocalName == "sat")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.sat);
				}
				else if (xmlNode.LocalName == "satMod")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satMod);
				}
				else if (xmlNode.LocalName == "satOff")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.satOff);
				}
				else if (xmlNode.LocalName == "shade")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.shade);
				}
				else if (xmlNode.LocalName == "tint")
				{
					ct_SystemColor.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform.tint);
				}
				if (xmlNode.Attributes["val"] != null)
				{
					ct_SystemColor.itemsValueField.Add(xmlNode.Attributes["val"].Value);
				}
				else
				{
					ct_SystemColor.itemsValueField.Add(null);
				}
			}
			return ct_SystemColor;
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0004BEF4 File Offset: 0x0004A0F4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lastClr", this.lastClr);
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
			sw.Write(string.Format("/>", nodeName));
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0004BFEB File Offset: 0x0004A1EB
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0004BFF3 File Offset: 0x0004A1F3
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

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0004BFFC File Offset: 0x0004A1FC
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0004C004 File Offset: 0x0004A204
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_SystemColorVal val
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

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x0004C00D File Offset: 0x0004A20D
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0004C015 File Offset: 0x0004A215
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] lastClr
		{
			get
			{
				return this.lastClrField;
			}
			set
			{
				this.lastClrField = value;
			}
		}

		// Token: 0x04001516 RID: 5398
		private global::System.Collections.Generic.List<string> itemsValueField;

		// Token: 0x04001517 RID: 5399
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.EG_ColorTransform> itemsElementNameField;

		// Token: 0x04001518 RID: 5400
		private global::NPOI.OpenXmlFormats.Dml.ST_SystemColorVal valField;

		// Token: 0x04001519 RID: 5401
		private byte[] lastClrField;
	}
}
