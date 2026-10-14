using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;
using NPOI.OpenXmlFormats.Vml.Office;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D4 RID: 468
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot("shape", Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shape
	{
		// Token: 0x060011F0 RID: 4592 RVA: 0x0003B960 File Offset: 0x00039B60
		public static global::NPOI.OpenXmlFormats.Vml.CT_Shape Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Shape ct_Shape = new global::NPOI.OpenXmlFormats.Vml.CT_Shape();
			ct_Shape.wrapcoords = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["wrapcoords"]);
			if (node.Attributes["stroked"] != null)
			{
				ct_Shape.stroked = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["stroked"]);
			}
			ct_Shape.spid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["o:spid"]);
			ct_Shape.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			ct_Shape.fillcolor = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["fillcolor"]);
			if (node.Attributes["o:insetmode"] != null)
			{
				ct_Shape.insetmode = (global::NPOI.OpenXmlFormats.Vml.Office.ST_InsetMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Office.ST_InsetMode), node.Attributes["o:insetmode"].Value);
			}
			ct_Shape.type = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["type"]);
			ct_Shape.adj = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["adj"]);
			ct_Shape.equationxml = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["equationxml"]);
			ct_Shape.style = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["style"]);
			ct_Shape.ClientData = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "textdata")
				{
					ct_Shape.textdata = global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "anchorlock")
				{
					ct_Shape.anchorlock = new global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock();
				}
				else if (xmlNode.LocalName == "borderright")
				{
					ct_Shape.borderright = global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "borderleft")
				{
					ct_Shape.borderleft = global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "borderbottom")
				{
					ct_Shape.borderbottom = global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bordertop")
				{
					ct_Shape.bordertop = global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "iscomment")
				{
					ct_Shape.iscomment = new global::NPOI.OpenXmlFormats.CT_Empty();
				}
				else if (xmlNode.LocalName == "stroke")
				{
					ct_Shape.stroke = global::NPOI.OpenXmlFormats.Vml.CT_Stroke.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wrap")
				{
					ct_Shape.wrap = global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textbox")
				{
					ct_Shape.textbox = global::NPOI.OpenXmlFormats.Vml.CT_Textbox.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fill")
				{
					ct_Shape.fill = global::NPOI.OpenXmlFormats.Vml.CT_Fill.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formulas")
				{
					ct_Shape.formulas = global::NPOI.OpenXmlFormats.Vml.CT_Formulas.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "handles")
				{
					ct_Shape.handles = global::NPOI.OpenXmlFormats.Vml.CT_Handles.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "imagedata")
				{
					ct_Shape.imagedata = global::NPOI.OpenXmlFormats.Vml.CT_ImageData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lock")
				{
					ct_Shape.@lock = global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_Shape.shadow = global::NPOI.OpenXmlFormats.Vml.CT_Shadow.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "path")
				{
					ct_Shape.path = global::NPOI.OpenXmlFormats.Vml.CT_Path.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "textpath")
				{
					ct_Shape.textpath = global::NPOI.OpenXmlFormats.Vml.CT_TextPath.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ClientData")
				{
					ct_Shape.ClientData.Add(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Shape;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0003BDC0 File Offset: 0x00039FC0
		public void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:spid", this.spid);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "style", this.style);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fillcolor", this.fillcolor);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "stroked", this.stroked);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "wrapcoords", this.wrapcoords);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:insetmode", this.insetmode.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "adj", this.adj);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "equationxml", this.equationxml);
			sw.Write(">");
			if (this.iscomment != null)
			{
				sw.Write("<iscomment/>");
			}
			if (this.stroke != null)
			{
				this.stroke.Write(sw, "stroke");
			}
			if (this.wrap != null)
			{
				this.wrap.Write(sw, "wrap");
			}
			if (this.fill != null)
			{
				this.fill.Write(sw, "fill");
			}
			if (this.formulas != null)
			{
				this.formulas.Write(sw, "formulas");
			}
			if (this.handles != null)
			{
				this.handles.Write(sw, "handles");
			}
			if (this.imagedata != null)
			{
				this.imagedata.Write(sw, "imagedata");
			}
			if (this.@lock != null)
			{
				this.@lock.Write(sw, "lock");
			}
			if (this.shadow != null)
			{
				this.shadow.Write(sw, "shadow");
			}
			if (this.path != null)
			{
				this.path.Write(sw, "path");
			}
			if (this.textpath != null)
			{
				this.textpath.Write(sw, "textpath");
			}
			if (this.textbox != null)
			{
				this.textbox.Write(sw, "textbox");
			}
			if (this.textdata != null)
			{
				this.textdata.Write(sw, "textdata");
			}
			if (this.anchorlock != null)
			{
				sw.Write("<w:anchorlock/>");
			}
			if (this.borderright != null)
			{
				this.borderright.Write(sw, "borderright");
			}
			if (this.borderleft != null)
			{
				this.borderleft.Write(sw, "borderleft");
			}
			if (this.borderbottom != null)
			{
				this.borderbottom.Write(sw, "borderbottom");
			}
			if (this.bordertop != null)
			{
				this.bordertop.Write(sw, "bordertop");
			}
			if (this.ClientData != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData ct_ClientData in this.ClientData)
				{
					ct_ClientData.Write(sw, "ClientData");
				}
			}
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0003C0BC File Offset: 0x0003A2BC
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
		[global::System.Xml.Serialization.XmlAttribute]
		public string wrapcoords
		{
			get
			{
				return this.wrapcoordsField;
			}
			set
			{
				this.wrapcoordsField = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0003C0CD File Offset: 0x0003A2CD
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0003C0D5 File Offset: 0x0003A2D5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t)]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse stroked
		{
			get
			{
				return this.strokedField;
			}
			set
			{
				this.strokedField = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0003C0DE File Offset: 0x0003A2DE
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0003C0E6 File Offset: 0x0003A2E6
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public string spid
		{
			get
			{
				return this.spidField;
			}
			set
			{
				this.spidField = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0003C0EF File Offset: 0x0003A2EF
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0003C0F7 File Offset: 0x0003A2F7
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0003C100 File Offset: 0x0003A300
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0003C108 File Offset: 0x0003A308
		[global::System.Xml.Serialization.XmlAttribute]
		public string fillcolor
		{
			get
			{
				return this.fillcolorField;
			}
			set
			{
				this.fillcolorField = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0003C111 File Offset: 0x0003A311
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0003C119 File Offset: 0x0003A319
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Office.ST_InsetMode.auto)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_InsetMode insetmode
		{
			get
			{
				return this.insetmodeField;
			}
			set
			{
				this.insetmodeField = value;
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0003C122 File Offset: 0x0003A322
		public global::NPOI.OpenXmlFormats.Vml.CT_Textbox AddNewTextbox()
		{
			this.textboxField = new global::NPOI.OpenXmlFormats.Vml.CT_Textbox();
			return this.textboxField;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0003C135 File Offset: 0x0003A335
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x0003C13D File Offset: 0x0003A33D
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
		public global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel textdata
		{
			get
			{
				return this.textdataField;
			}
			set
			{
				this.textdataField = value;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0003C146 File Offset: 0x0003A346
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0003C14E File Offset: 0x0003A34E
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock anchorlock
		{
			get
			{
				return this.anchorlockField;
			}
			set
			{
				this.anchorlockField = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0003C157 File Offset: 0x0003A357
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x0003C15F File Offset: 0x0003A35F
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border borderright
		{
			get
			{
				return this.borderrightField;
			}
			set
			{
				this.borderrightField = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0003C168 File Offset: 0x0003A368
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x0003C170 File Offset: 0x0003A370
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border borderleft
		{
			get
			{
				return this.borderleftField;
			}
			set
			{
				this.borderleftField = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0003C179 File Offset: 0x0003A379
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x0003C181 File Offset: 0x0003A381
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border borderbottom
		{
			get
			{
				return this.borderbottomField;
			}
			set
			{
				this.borderbottomField = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0003C18A File Offset: 0x0003A38A
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x0003C192 File Offset: 0x0003A392
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border bordertop
		{
			get
			{
				return this.bordertopField;
			}
			set
			{
				this.bordertopField = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0003C19B File Offset: 0x0003A39B
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x0003C1A3 File Offset: 0x0003A3A3
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
		public global::NPOI.OpenXmlFormats.CT_Empty iscomment
		{
			get
			{
				return this.iscommentField;
			}
			set
			{
				this.iscommentField = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0003C1AC File Offset: 0x0003A3AC
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Stroke stroke
		{
			get
			{
				return this.strokeField;
			}
			set
			{
				this.strokeField = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0003C1BD File Offset: 0x0003A3BD
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0003C1C5 File Offset: 0x0003A3C5
		[global::System.Xml.Serialization.XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap wrap
		{
			get
			{
				return this.wrapField;
			}
			set
			{
				this.wrapField = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0003C1CE File Offset: 0x0003A3CE
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0003C1D6 File Offset: 0x0003A3D6
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Textbox textbox
		{
			get
			{
				return this.textboxField;
			}
			set
			{
				this.textboxField = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0003C1DF File Offset: 0x0003A3DF
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0003C1E7 File Offset: 0x0003A3E7
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Fill fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0003C1F0 File Offset: 0x0003A3F0
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0003C1F8 File Offset: 0x0003A3F8
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Formulas formulas
		{
			get
			{
				return this.formulasField;
			}
			set
			{
				this.formulasField = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0003C201 File Offset: 0x0003A401
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x0003C209 File Offset: 0x0003A409
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Handles handles
		{
			get
			{
				return this.handlesField;
			}
			set
			{
				this.handlesField = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0003C212 File Offset: 0x0003A412
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x0003C21A File Offset: 0x0003A41A
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_ImageData imagedata
		{
			get
			{
				return this.imagedataField;
			}
			set
			{
				this.imagedataField = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0003C223 File Offset: 0x0003A423
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0003C22B File Offset: 0x0003A42B
		[global::System.Xml.Serialization.XmlElement(ElementName = "lock", Namespace = "urn:schemas-microsoft-com:office:office")]
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock @lock
		{
			get
			{
				return this.lockField;
			}
			set
			{
				this.lockField = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0003C234 File Offset: 0x0003A434
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x0003C23C File Offset: 0x0003A43C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Shadow shadow
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

		// Token: 0x0600121F RID: 4639 RVA: 0x0003C245 File Offset: 0x0003A445
		public global::NPOI.OpenXmlFormats.Vml.CT_Fill AddNewFill()
		{
			this.fillField = new global::NPOI.OpenXmlFormats.Vml.CT_Fill();
			return this.fillField;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0003C258 File Offset: 0x0003A458
		public global::NPOI.OpenXmlFormats.Vml.CT_Shadow AddNewShadow()
		{
			this.shadowField = new global::NPOI.OpenXmlFormats.Vml.CT_Shadow();
			return this.shadowField;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0003C26B File Offset: 0x0003A46B
		public global::NPOI.OpenXmlFormats.Vml.CT_Path AddNewPath()
		{
			this.pathField = new global::NPOI.OpenXmlFormats.Vml.CT_Path();
			return this.pathField;
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0003C27E File Offset: 0x0003A47E
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x0003C286 File Offset: 0x0003A486
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> ClientData
		{
			get
			{
				return this.clientDataField;
			}
			set
			{
				this.clientDataField = value;
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0003C28F File Offset: 0x0003A48F
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData GetClientDataArray(int index)
		{
			if (this.clientDataField == null)
			{
				return null;
			}
			return this.clientDataField[index];
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0003C2A7 File Offset: 0x0003A4A7
		public int sizeOfClientDataArray()
		{
			if (this.clientDataField == null)
			{
				return 0;
			}
			return this.clientDataField.Count;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0003C2C0 File Offset: 0x0003A4C0
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData AddNewClientData()
		{
			global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData ct_ClientData = new global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData();
			if (this.clientDataField == null)
			{
				this.clientDataField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData>();
			}
			this.clientDataField.Add(ct_ClientData);
			return ct_ClientData;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0003C2F3 File Offset: 0x0003A4F3
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x0003C2FB File Offset: 0x0003A4FB
		[global::System.Xml.Serialization.XmlAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0003C304 File Offset: 0x0003A504
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x0003C30C File Offset: 0x0003A50C
		[global::System.Xml.Serialization.XmlAttribute]
		public string adj
		{
			get
			{
				return this.adjField;
			}
			set
			{
				this.adjField = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0003C315 File Offset: 0x0003A515
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x0003C31D File Offset: 0x0003A51D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_Path path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0003C326 File Offset: 0x0003A526
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x0003C32E File Offset: 0x0003A52E
		[global::System.Xml.Serialization.XmlAttribute]
		public string equationxml
		{
			get
			{
				return this.equationxmlField;
			}
			set
			{
				this.equationxmlField = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0003C337 File Offset: 0x0003A537
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x0003C33F File Offset: 0x0003A53F
		[global::System.Xml.Serialization.XmlAttribute]
		public string style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0003C348 File Offset: 0x0003A548
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0003C350 File Offset: 0x0003A550
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.CT_TextPath textpath
		{
			get
			{
				return this.textpathField;
			}
			set
			{
				this.textpathField = value;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0003C359 File Offset: 0x0003A559
		public global::NPOI.OpenXmlFormats.Vml.CT_TextPath AddNewTextpath()
		{
			this.textpathField = new global::NPOI.OpenXmlFormats.Vml.CT_TextPath();
			return this.textpathField;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0003C36C File Offset: 0x0003A56C
		public int SizeOfClientDataArray()
		{
			if (this.clientDataField != null)
			{
				return this.clientDataField.Count;
			}
			return 0;
		}

		// Token: 0x04000DF1 RID: 3569
		private string typeField;

		// Token: 0x04000DF2 RID: 3570
		private string adjField;

		// Token: 0x04000DF3 RID: 3571
		private string styleField;

		// Token: 0x04000DF4 RID: 3572
		private global::NPOI.OpenXmlFormats.Vml.CT_Path pathField;

		// Token: 0x04000DF5 RID: 3573
		private string equationxmlField;

		// Token: 0x04000DF6 RID: 3574
		private string idField;

		// Token: 0x04000DF7 RID: 3575
		private string fillcolorField;

		// Token: 0x04000DF8 RID: 3576
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_InsetMode insetmodeField;

		// Token: 0x04000DF9 RID: 3577
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse strokedField;

		// Token: 0x04000DFA RID: 3578
		private string wrapcoordsField;

		// Token: 0x04000DFB RID: 3579
		private string spidField;

		// Token: 0x04000DFC RID: 3580
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap wrapField;

		// Token: 0x04000DFD RID: 3581
		private global::NPOI.OpenXmlFormats.Vml.CT_Fill fillField;

		// Token: 0x04000DFE RID: 3582
		private global::NPOI.OpenXmlFormats.Vml.CT_Formulas formulasField;

		// Token: 0x04000DFF RID: 3583
		private global::NPOI.OpenXmlFormats.Vml.CT_Handles handlesField;

		// Token: 0x04000E00 RID: 3584
		private global::NPOI.OpenXmlFormats.Vml.CT_ImageData imagedataField;

		// Token: 0x04000E01 RID: 3585
		private global::NPOI.OpenXmlFormats.Vml.CT_Stroke strokeField;

		// Token: 0x04000E02 RID: 3586
		private global::NPOI.OpenXmlFormats.Vml.CT_Shadow shadowField;

		// Token: 0x04000E03 RID: 3587
		private global::NPOI.OpenXmlFormats.Vml.CT_Textbox textboxField;

		// Token: 0x04000E04 RID: 3588
		private global::NPOI.OpenXmlFormats.Vml.CT_TextPath textpathField;

		// Token: 0x04000E05 RID: 3589
		private global::NPOI.OpenXmlFormats.CT_Empty iscommentField;

		// Token: 0x04000E06 RID: 3590
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock lockField;

		// Token: 0x04000E07 RID: 3591
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border bordertopField;

		// Token: 0x04000E08 RID: 3592
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border borderrightField;

		// Token: 0x04000E09 RID: 3593
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border borderleftField;

		// Token: 0x04000E0A RID: 3594
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border borderbottomField;

		// Token: 0x04000E0B RID: 3595
		private global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock anchorlockField;

		// Token: 0x04000E0C RID: 3596
		private global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel textdataField;

		// Token: 0x04000E0D RID: 3597
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> clientDataField;
	}
}
