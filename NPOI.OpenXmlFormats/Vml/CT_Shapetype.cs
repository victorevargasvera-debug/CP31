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
	// Token: 0x020001E7 RID: 487
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot("shapetype", Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Shapetype
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x0003E6F0 File Offset: 0x0003C8F0
		public static global::NPOI.OpenXmlFormats.Vml.CT_Shapetype Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Shapetype ct_Shapetype = new global::NPOI.OpenXmlFormats.Vml.CT_Shapetype();
			if (node.Attributes["stroked"] != null)
			{
				ct_Shapetype.stroked = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["stroked"]);
			}
			if (node.Attributes["filled"] != null)
			{
				ct_Shapetype.filled = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["filled"]);
			}
			if (node.Attributes["o:preferrelative"] != null)
			{
				ct_Shapetype.preferrelative = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["o:preferrelative"]);
			}
			ct_Shapetype.coordsize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["coordsize"]);
			if (node.Attributes["o:spt"] != null)
			{
				ct_Shapetype.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["o:spt"]);
			}
			ct_Shapetype.adj = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["adj"]);
			ct_Shapetype.path2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["path"]);
			ct_Shapetype.formulas = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas>();
			ct_Shapetype.handles = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles>();
			ct_Shapetype.fill = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill>();
			ct_Shapetype.shadow = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow>();
			ct_Shapetype.textbox = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox>();
			ct_Shapetype.textpath = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath>();
			ct_Shapetype.imagedata = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData>();
			ct_Shapetype.wrap = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap>();
			ct_Shapetype.anchorlock = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock>();
			ct_Shapetype.bordertop = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border>();
			ct_Shapetype.borderbottom = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border>();
			ct_Shapetype.borderleft = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border>();
			ct_Shapetype.borderright = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border>();
			ct_Shapetype.Clientdata = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData>();
			ct_Shapetype.textdata = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "stroke")
				{
					ct_Shapetype.stroke = global::NPOI.OpenXmlFormats.Vml.CT_Stroke.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "path")
				{
					ct_Shapetype.path = global::NPOI.OpenXmlFormats.Vml.CT_Path.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lock")
				{
					ct_Shapetype.@lock = global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formulas")
				{
					ct_Shapetype.formulas.Add(global::NPOI.OpenXmlFormats.Vml.CT_Formulas.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "handles")
				{
					ct_Shapetype.handles.Add(global::NPOI.OpenXmlFormats.Vml.CT_Handles.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "fill")
				{
					ct_Shapetype.fill.Add(global::NPOI.OpenXmlFormats.Vml.CT_Fill.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_Shapetype.shadow.Add(global::NPOI.OpenXmlFormats.Vml.CT_Shadow.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "textbox")
				{
					ct_Shapetype.textbox.Add(global::NPOI.OpenXmlFormats.Vml.CT_Textbox.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "textpath")
				{
					ct_Shapetype.textpath.Add(global::NPOI.OpenXmlFormats.Vml.CT_TextPath.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "imagedata")
				{
					ct_Shapetype.imagedata.Add(global::NPOI.OpenXmlFormats.Vml.CT_ImageData.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "wrap")
				{
					ct_Shapetype.wrap.Add(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "anchorlock")
				{
					ct_Shapetype.anchorlock.Add(new global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock());
				}
				else if (xmlNode.LocalName == "bordertop")
				{
					ct_Shapetype.bordertop.Add(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "borderbottom")
				{
					ct_Shapetype.borderbottom.Add(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "borderleft")
				{
					ct_Shapetype.borderleft.Add(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "borderright")
				{
					ct_Shapetype.borderright.Add(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "ClientData")
				{
					ct_Shapetype.Clientdata.Add(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "textdata")
				{
					ct_Shapetype.textdata.Add(global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Shapetype;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0003EBD0 File Offset: 0x0003CDD0
		public void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "stroked", this.stroked, true);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "filled", this.filled, true);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "o:preferrelative", this.preferrelative);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "coordsize", this.coordsize);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:spt", (double)this.spt);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "adj", this.adj);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "path", this.path2);
			sw.Write(">");
			if (this.stroke != null)
			{
				this.stroke.Write(sw, "stroke");
			}
			if (this.path != null)
			{
				this.path.Write(sw, "path");
			}
			if (this.textpath != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_TextPath ct_TextPath in this.textpath)
				{
					ct_TextPath.Write(sw, "textpath");
				}
			}
			if (this.formulas != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_Formulas ct_Formulas in this.formulas)
				{
					ct_Formulas.Write(sw, "formulas");
				}
			}
			if (this.handles != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_Handles ct_Handles in this.handles)
				{
					ct_Handles.Write(sw, "handles");
				}
			}
			if (this.fill != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_Fill ct_Fill in this.fill)
				{
					ct_Fill.Write(sw, "fill");
				}
			}
			if (this.shadow != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_Shadow ct_Shadow in this.shadow)
				{
					ct_Shadow.Write(sw, "shadow");
				}
			}
			if (this.@lock != null)
			{
				this.@lock.Write(sw, "lock");
			}
			if (this.textbox != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_Textbox ct_Textbox in this.textbox)
				{
					ct_Textbox.Write(sw, "textbox");
				}
			}
			if (this.imagedata != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_ImageData ct_ImageData in this.imagedata)
				{
					ct_ImageData.Write(sw, "imagedata");
				}
			}
			if (this.wrap != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap ct_Wrap in this.wrap)
				{
					ct_Wrap.Write(sw, "wrap");
				}
			}
			if (this.anchorlock != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock ct_AnchorLock in this.anchorlock)
				{
					sw.Write("<anchorlock/>");
				}
			}
			if (this.bordertop != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border ct_Border in this.bordertop)
				{
					ct_Border.Write(sw, "bordertop");
				}
			}
			if (this.borderbottom != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border ct_Border2 in this.borderbottom)
				{
					ct_Border2.Write(sw, "borderbottom");
				}
			}
			if (this.borderleft != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border ct_Border3 in this.borderleft)
				{
					ct_Border3.Write(sw, "borderleft");
				}
			}
			if (this.borderright != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border ct_Border4 in this.borderright)
				{
					ct_Border4.Write(sw, "borderright");
				}
			}
			if (this.Clientdata != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData ct_ClientData in this.Clientdata)
				{
					ct_ClientData.Write(sw, "ClientData");
				}
			}
			if (this.textdata != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel ct_Rel in this.textdata)
				{
					ct_Rel.Write(sw, "textdata");
				}
			}
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0003F174 File Offset: 0x0003D374
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0003F17C File Offset: 0x0003D37C
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x0003F185 File Offset: 0x0003D385
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x0003F18D File Offset: 0x0003D38D
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse filled
		{
			get
			{
				return this.filledField;
			}
			set
			{
				this.filledField = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0003F196 File Offset: 0x0003D396
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x0003F19E File Offset: 0x0003D39E
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse preferrelative
		{
			get
			{
				return this.preferrelativeField;
			}
			set
			{
				this.preferrelativeField = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0003F1A7 File Offset: 0x0003D3A7
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x0003F1AF File Offset: 0x0003D3AF
		[global::System.Xml.Serialization.XmlAttribute]
		public string coordsize
		{
			get
			{
				return this.coordsizeField;
			}
			set
			{
				this.coordsizeField = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public float spt
		{
			get
			{
				return this.sptField;
			}
			set
			{
				this.sptField = value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0003F1C9 File Offset: 0x0003D3C9
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x0003F1D1 File Offset: 0x0003D3D1
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

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003F1DA File Offset: 0x0003D3DA
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x0003F1E2 File Offset: 0x0003D3E2
		[global::System.Xml.Serialization.XmlElement("stroke")]
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0003F1EB File Offset: 0x0003D3EB
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x0003F1F3 File Offset: 0x0003D3F3
		[global::System.Xml.Serialization.XmlElement("formulas")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulas
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

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0003F1FC File Offset: 0x0003D3FC
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x0003F204 File Offset: 0x0003D404
		[global::System.Xml.Serialization.XmlElement("handles")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handles
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x0003F20D File Offset: 0x0003D40D
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x0003F215 File Offset: 0x0003D415
		[global::System.Xml.Serialization.XmlElement("fill")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fill
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

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x0003F21E File Offset: 0x0003D41E
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x0003F226 File Offset: 0x0003D426
		[global::System.Xml.Serialization.XmlElement("shadow")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadow
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

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x0003F22F File Offset: 0x0003D42F
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x0003F237 File Offset: 0x0003D437
		[global::System.Xml.Serialization.XmlElement("textbox")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textbox
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

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0003F240 File Offset: 0x0003D440
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x0003F248 File Offset: 0x0003D448
		[global::System.Xml.Serialization.XmlElement("textpath")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpath
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

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0003F251 File Offset: 0x0003D451
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x0003F259 File Offset: 0x0003D459
		[global::System.Xml.Serialization.XmlElement("imagedata")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedata
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

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0003F262 File Offset: 0x0003D462
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x0003F26A File Offset: 0x0003D46A
		[global::System.Xml.Serialization.XmlElement("wrap", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrap
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0003F273 File Offset: 0x0003D473
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0003F27B File Offset: 0x0003D47B
		[global::System.Xml.Serialization.XmlElement("anchorlock", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlock
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0003F284 File Offset: 0x0003D484
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x0003F28C File Offset: 0x0003D48C
		[global::System.Xml.Serialization.XmlElement("path")]
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0003F295 File Offset: 0x0003D495
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0003F29D File Offset: 0x0003D49D
		[global::System.Xml.Serialization.XmlElement("lock", Namespace = "urn:schemas-microsoft-com:office:office")]
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

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0003F2A6 File Offset: 0x0003D4A6
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0003F2AE File Offset: 0x0003D4AE
		[global::System.Xml.Serialization.XmlElement("bordertop", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertop
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

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003F2B7 File Offset: 0x0003D4B7
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0003F2BF File Offset: 0x0003D4BF
		[global::System.Xml.Serialization.XmlElement("borderbottom", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottom
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

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003F2C8 File Offset: 0x0003D4C8
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x0003F2D0 File Offset: 0x0003D4D0
		[global::System.Xml.Serialization.XmlElement("borderleft", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleft
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

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0003F2D9 File Offset: 0x0003D4D9
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0003F2E1 File Offset: 0x0003D4E1
		[global::System.Xml.Serialization.XmlElement("borderright", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderright
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

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0003F2EA File Offset: 0x0003D4EA
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0003F2F2 File Offset: 0x0003D4F2
		[global::System.Xml.Serialization.XmlElement("clientdata", Namespace = "urn:schemas-microsoft-com:office:excel")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> Clientdata
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0003F2FB File Offset: 0x0003D4FB
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x0003F303 File Offset: 0x0003D503
		[global::System.Xml.Serialization.XmlElement("textdata", Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdata
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0003F30C File Offset: 0x0003D50C
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x0003F314 File Offset: 0x0003D514
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0003F31D File Offset: 0x0003D51D
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x0003F325 File Offset: 0x0003D525
		[global::System.Xml.Serialization.XmlAttribute("path")]
		public string path2
		{
			get
			{
				return this.path1Field;
			}
			set
			{
				this.path1Field = value;
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0003F32E File Offset: 0x0003D52E
		public global::NPOI.OpenXmlFormats.Vml.CT_Stroke AddNewStroke()
		{
			this.strokeField = new global::NPOI.OpenXmlFormats.Vml.CT_Stroke();
			return this.strokeField;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0003F341 File Offset: 0x0003D541
		public global::NPOI.OpenXmlFormats.Vml.CT_Path AddNewPath()
		{
			this.pathField = new global::NPOI.OpenXmlFormats.Vml.CT_Path();
			return this.pathField;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0003F354 File Offset: 0x0003D554
		public global::NPOI.OpenXmlFormats.Vml.CT_Formulas AddNewFormulas()
		{
			if (this.formulasField == null)
			{
				this.formulasField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas>();
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Formulas ct_Formulas = new global::NPOI.OpenXmlFormats.Vml.CT_Formulas();
			this.formulasField.Add(ct_Formulas);
			return ct_Formulas;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0003F388 File Offset: 0x0003D588
		public global::NPOI.OpenXmlFormats.Vml.CT_TextPath AddNewTextpath()
		{
			if (this.textpathField == null)
			{
				this.textpathField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath>();
			}
			global::NPOI.OpenXmlFormats.Vml.CT_TextPath ct_TextPath = new global::NPOI.OpenXmlFormats.Vml.CT_TextPath();
			this.textpathField.Add(ct_TextPath);
			return ct_TextPath;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0003F3BC File Offset: 0x0003D5BC
		public global::NPOI.OpenXmlFormats.Vml.CT_Handles AddNewHandles()
		{
			if (this.handlesField == null)
			{
				this.handlesField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles>();
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Handles ct_Handles = new global::NPOI.OpenXmlFormats.Vml.CT_Handles();
			this.handlesField.Add(ct_Handles);
			return ct_Handles;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0003F3EF File Offset: 0x0003D5EF
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock AddNewLock()
		{
			return new global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock();
		}

		// Token: 0x04000EC6 RID: 3782
		private global::NPOI.OpenXmlFormats.Vml.CT_Path pathField;

		// Token: 0x04000EC7 RID: 3783
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulasField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas>();

		// Token: 0x04000EC8 RID: 3784
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handlesField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles>();

		// Token: 0x04000EC9 RID: 3785
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fillField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill>();

		// Token: 0x04000ECA RID: 3786
		private global::NPOI.OpenXmlFormats.Vml.CT_Stroke strokeField;

		// Token: 0x04000ECB RID: 3787
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadowField;

		// Token: 0x04000ECC RID: 3788
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textboxField;

		// Token: 0x04000ECD RID: 3789
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpathField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath>();

		// Token: 0x04000ECE RID: 3790
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedataField;

		// Token: 0x04000ECF RID: 3791
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrapField;

		// Token: 0x04000ED0 RID: 3792
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlockField;

		// Token: 0x04000ED1 RID: 3793
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Lock lockField;

		// Token: 0x04000ED2 RID: 3794
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertopField;

		// Token: 0x04000ED3 RID: 3795
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottomField;

		// Token: 0x04000ED4 RID: 3796
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleftField;

		// Token: 0x04000ED5 RID: 3797
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderrightField;

		// Token: 0x04000ED6 RID: 3798
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> clientDataField;

		// Token: 0x04000ED7 RID: 3799
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdataField;

		// Token: 0x04000ED8 RID: 3800
		private string adjField;

		// Token: 0x04000ED9 RID: 3801
		private string idField;

		// Token: 0x04000EDA RID: 3802
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse filledField = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;

		// Token: 0x04000EDB RID: 3803
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse strokedField = global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse.t;

		// Token: 0x04000EDC RID: 3804
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse preferrelativeField;

		// Token: 0x04000EDD RID: 3805
		private float sptField;

		// Token: 0x04000EDE RID: 3806
		private string coordsizeField;

		// Token: 0x04000EDF RID: 3807
		private string path1Field;
	}
}
