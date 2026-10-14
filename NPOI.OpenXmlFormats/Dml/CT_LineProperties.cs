using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000295 RID: 661
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineProperties
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x00049168 File Offset: 0x00047368
		public static global::NPOI.OpenXmlFormats.Dml.CT_LineProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_LineProperties ct_LineProperties = new global::NPOI.OpenXmlFormats.Dml.CT_LineProperties();
			ct_LineProperties.w = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["w"]);
			if (node.Attributes["cap"] != null)
			{
				ct_LineProperties.cap = (global::NPOI.OpenXmlFormats.Dml.ST_LineCap)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_LineCap), node.Attributes["cap"].Value);
			}
			if (node.Attributes["cmpd"] != null)
			{
				ct_LineProperties.cmpd = (global::NPOI.OpenXmlFormats.Dml.ST_CompoundLine)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_CompoundLine), node.Attributes["cmpd"].Value);
			}
			if (node.Attributes["algn"] != null)
			{
				ct_LineProperties.algn = (global::NPOI.OpenXmlFormats.Dml.ST_PenAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PenAlignment), node.Attributes["algn"].Value);
			}
			ct_LineProperties.custDash = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_DashStop>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "noFill")
				{
					ct_LineProperties.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_LineProperties.solidFill = global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_LineProperties.gradFill = global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_LineProperties.pattFill = global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstDash")
				{
					ct_LineProperties.prstDash = global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "round")
				{
					ct_LineProperties.round = new global::NPOI.OpenXmlFormats.Dml.CT_LineJoinRound();
				}
				else if (xmlNode.LocalName == "bevel")
				{
					ct_LineProperties.bevel = new global::NPOI.OpenXmlFormats.Dml.CT_LineJoinBevel();
				}
				else if (xmlNode.LocalName == "miter")
				{
					ct_LineProperties.miter = global::NPOI.OpenXmlFormats.Dml.CT_LineJoinMiterProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "headEnd")
				{
					ct_LineProperties.headEnd = global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tailEnd")
				{
					ct_LineProperties.tailEnd = global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_LineProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "custDash")
				{
					ct_LineProperties.custDash.Add(global::NPOI.OpenXmlFormats.Dml.CT_DashStop.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_LineProperties;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00049464 File Offset: 0x00047664
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w", this.w);
			if (this.cap != global::NPOI.OpenXmlFormats.Dml.ST_LineCap.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cap", this.cap.ToString());
			}
			if (this.cmpd != global::NPOI.OpenXmlFormats.Dml.ST_CompoundLine.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cmpd", this.cmpd.ToString());
			}
			if (this.algn != global::NPOI.OpenXmlFormats.Dml.ST_PenAlignment.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			}
			sw.Write(">");
			if (this.noFill != null)
			{
				sw.Write("<a:noFill/>");
			}
			if (this.solidFill != null)
			{
				this.solidFill.Write(sw, "solidFill");
			}
			if (this.gradFill != null)
			{
				this.gradFill.Write(sw, "gradFill");
			}
			if (this.pattFill != null)
			{
				this.pattFill.Write(sw, "pattFill");
			}
			if (this.prstDash != null)
			{
				this.prstDash.Write(sw, "prstDash");
			}
			if (this.custDash != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_DashStop ct_DashStop in this.custDash)
				{
					ct_DashStop.Write(sw, "custDash");
				}
			}
			if (this.round != null)
			{
				sw.Write("<a:round/>");
			}
			if (this.bevel != null)
			{
				sw.Write("<a:bevel/>");
			}
			if (this.miter != null)
			{
				this.miter.Write(sw, "miter");
			}
			if (this.headEnd != null)
			{
				this.headEnd.Write(sw, "headEnd");
			}
			if (this.tailEnd != null)
			{
				this.tailEnd.Write(sw, "tailEnd");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00049678 File Offset: 0x00047878
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x00049680 File Offset: 0x00047880
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFill
		{
			get
			{
				return this.noFillField;
			}
			set
			{
				this.noFillField = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00049689 File Offset: 0x00047889
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x00049691 File Offset: 0x00047891
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill
		{
			get
			{
				return this.solidFillField;
			}
			set
			{
				this.solidFillField = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0004969A File Offset: 0x0004789A
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x000496A2 File Offset: 0x000478A2
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFill
		{
			get
			{
				return this.gradFillField;
			}
			set
			{
				this.gradFillField = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000496AB File Offset: 0x000478AB
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x000496B3 File Offset: 0x000478B3
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFill
		{
			get
			{
				return this.pattFillField;
			}
			set
			{
				this.pattFillField = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000496BC File Offset: 0x000478BC
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x000496C4 File Offset: 0x000478C4
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties prstDash
		{
			get
			{
				return this.prstDashField;
			}
			set
			{
				this.prstDashField = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000496CD File Offset: 0x000478CD
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x000496D5 File Offset: 0x000478D5
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_DashStop> custDash
		{
			get
			{
				return this.custDashField;
			}
			set
			{
				this.custDashField = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x000496DE File Offset: 0x000478DE
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x000496E6 File Offset: 0x000478E6
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineJoinRound round
		{
			get
			{
				return this.roundField;
			}
			set
			{
				this.roundField = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x000496EF File Offset: 0x000478EF
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x000496F7 File Offset: 0x000478F7
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineJoinBevel bevel
		{
			get
			{
				return this.bevelField;
			}
			set
			{
				this.bevelField = value;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00049700 File Offset: 0x00047900
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00049708 File Offset: 0x00047908
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineJoinMiterProperties miter
		{
			get
			{
				return this.miterField;
			}
			set
			{
				this.miterField = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00049711 File Offset: 0x00047911
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x00049719 File Offset: 0x00047919
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties headEnd
		{
			get
			{
				return this.headEndField;
			}
			set
			{
				this.headEndField = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00049722 File Offset: 0x00047922
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0004972A File Offset: 0x0004792A
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties tailEnd
		{
			get
			{
				return this.tailEndField;
			}
			set
			{
				this.tailEndField = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00049733 File Offset: 0x00047933
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0004973B File Offset: 0x0004793B
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x00049744 File Offset: 0x00047944
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0004974C File Offset: 0x0004794C
		[global::System.Xml.Serialization.XmlAttribute]
		public int w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x00049755 File Offset: 0x00047955
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0004975D File Offset: 0x0004795D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool wSpecified
		{
			get
			{
				return this.wFieldSpecified;
			}
			set
			{
				this.wFieldSpecified = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00049766 File Offset: 0x00047966
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0004976E File Offset: 0x0004796E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_LineCap cap
		{
			get
			{
				return this.capField;
			}
			set
			{
				this.capField = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00049777 File Offset: 0x00047977
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x00049782 File Offset: 0x00047982
		[global::System.Xml.Serialization.XmlIgnore]
		public bool capSpecified
		{
			get
			{
				return this.capField > global::NPOI.OpenXmlFormats.Dml.ST_LineCap.NONE;
			}
			set
			{
				this.capFieldSpecified = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0004978B File Offset: 0x0004798B
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x00049793 File Offset: 0x00047993
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_CompoundLine cmpd
		{
			get
			{
				return this.cmpdField;
			}
			set
			{
				this.cmpdField = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0004979C File Offset: 0x0004799C
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x000497A7 File Offset: 0x000479A7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool cmpdSpecified
		{
			get
			{
				return this.cmpdField > global::NPOI.OpenXmlFormats.Dml.ST_CompoundLine.NONE;
			}
			set
			{
				this.cmpdFieldSpecified = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x000497B0 File Offset: 0x000479B0
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x000497B8 File Offset: 0x000479B8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_PenAlignment algn
		{
			get
			{
				return this.algnField;
			}
			set
			{
				this.algnField = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000497C1 File Offset: 0x000479C1
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x000497CC File Offset: 0x000479CC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool algnSpecified
		{
			get
			{
				return this.algnField > global::NPOI.OpenXmlFormats.Dml.ST_PenAlignment.NONE;
			}
			set
			{
				this.algnFieldSpecified = value;
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000497D5 File Offset: 0x000479D5
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties AddNewSolidFill()
		{
			this.solidFillField = new global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties();
			return this.solidFillField;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000497E8 File Offset: 0x000479E8
		public bool IsSetSolidFill()
		{
			return this.solidFillField != null;
		}

		// Token: 0x0400141A RID: 5146
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x0400141B RID: 5147
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x0400141C RID: 5148
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x0400141D RID: 5149
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x0400141E RID: 5150
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetLineDashProperties prstDashField;

		// Token: 0x0400141F RID: 5151
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_DashStop> custDashField;

		// Token: 0x04001420 RID: 5152
		private global::NPOI.OpenXmlFormats.Dml.CT_LineJoinRound roundField;

		// Token: 0x04001421 RID: 5153
		private global::NPOI.OpenXmlFormats.Dml.CT_LineJoinBevel bevelField;

		// Token: 0x04001422 RID: 5154
		private global::NPOI.OpenXmlFormats.Dml.CT_LineJoinMiterProperties miterField;

		// Token: 0x04001423 RID: 5155
		private global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties headEndField;

		// Token: 0x04001424 RID: 5156
		private global::NPOI.OpenXmlFormats.Dml.CT_LineEndProperties tailEndField;

		// Token: 0x04001425 RID: 5157
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001426 RID: 5158
		private int wField;

		// Token: 0x04001427 RID: 5159
		private bool wFieldSpecified;

		// Token: 0x04001428 RID: 5160
		private global::NPOI.OpenXmlFormats.Dml.ST_LineCap capField;

		// Token: 0x04001429 RID: 5161
		private bool capFieldSpecified;

		// Token: 0x0400142A RID: 5162
		private global::NPOI.OpenXmlFormats.Dml.ST_CompoundLine cmpdField;

		// Token: 0x0400142B RID: 5163
		private bool cmpdFieldSpecified;

		// Token: 0x0400142C RID: 5164
		private global::NPOI.OpenXmlFormats.Dml.ST_PenAlignment algnField;

		// Token: 0x0400142D RID: 5165
		private bool algnFieldSpecified;
	}
}
