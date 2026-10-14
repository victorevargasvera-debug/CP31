using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200061F RID: 1567
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CalcPr
	{
		// Token: 0x06004428 RID: 17448 RVA: 0x000A2028 File Offset: 0x000A0228
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr ct_CalcPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcPr();
			ct_CalcPr.calcId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["calcId"]);
			if (node.Attributes["calcMode"] != null)
			{
				ct_CalcPr.calcMode = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode), node.Attributes["calcMode"].Value);
			}
			ct_CalcPr.fullCalcOnLoad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fullCalcOnLoad"]);
			if (node.Attributes["refMode"] != null)
			{
				ct_CalcPr.refMode = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode), node.Attributes["refMode"].Value);
			}
			ct_CalcPr.iterate = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["iterate"]);
			ct_CalcPr.iterateCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["iterateCount"]);
			ct_CalcPr.iterateDelta = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["iterateDelta"]);
			ct_CalcPr.fullPrecision = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fullPrecision"]);
			ct_CalcPr.calcCompleted = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["calcCompleted"]);
			ct_CalcPr.calcOnSave = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["calcOnSave"]);
			ct_CalcPr.concurrentCalc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["concurrentCalc"]);
			ct_CalcPr.concurrentManualCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["concurrentManualCount"]);
			ct_CalcPr.forceFullCalc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["forceFullCalc"]);
			return ct_CalcPr;
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x000A21EC File Offset: 0x000A03EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "calcId", this.calcId, false);
			if (this.calcMode != global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.auto)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "calcMode", this.calcMode.ToString());
			}
			if (this.fullCalcOnLoad)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fullCalcOnLoad", this.fullCalcOnLoad);
			}
			if (this.refMode != global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode.A1)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "refMode", this.refMode.ToString());
			}
			if (this.iterate)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iterate", this.iterate);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iterateDelta", this.iterateDelta);
			if (this.fullPrecision)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fullPrecision", this.fullPrecision);
			}
			if (this.calcCompleted)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "calcCompleted", this.calcCompleted);
			}
			if (this.calcOnSave)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "calcOnSave", this.calcOnSave);
			}
			if (this.concurrentCalc)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "concurrentCalc", this.concurrentCalc);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "concurrentManualCount", this.concurrentManualCount, false);
			if (this.forceFullCalc)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "forceFullCalc", this.forceFullCalc);
			}
			sw.Write("/>");
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x000A2348 File Offset: 0x000A0548
		public CT_CalcPr()
		{
			this.calcModeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.auto;
			this.fullCalcOnLoadField = false;
			this.refModeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode.A1;
			this.iterateField = false;
			this.iterateCountField = 100U;
			this.iterateDeltaField = 0.001;
			this.fullPrecisionField = true;
			this.calcCompletedField = true;
			this.calcOnSaveField = true;
			this.concurrentCalcField = true;
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x000A23AA File Offset: 0x000A05AA
		// (set) Token: 0x0600442C RID: 17452 RVA: 0x000A23B2 File Offset: 0x000A05B2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint calcId
		{
			get
			{
				return this.calcIdField;
			}
			set
			{
				this.calcIdField = value;
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600442D RID: 17453 RVA: 0x000A23BB File Offset: 0x000A05BB
		// (set) Token: 0x0600442E RID: 17454 RVA: 0x000A23C3 File Offset: 0x000A05C3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool calcIdSpecified
		{
			get
			{
				return this.calcIdFieldSpecified;
			}
			set
			{
				this.calcIdFieldSpecified = value;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600442F RID: 17455 RVA: 0x000A23CC File Offset: 0x000A05CC
		// (set) Token: 0x06004430 RID: 17456 RVA: 0x000A23D4 File Offset: 0x000A05D4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode.auto)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode calcMode
		{
			get
			{
				return this.calcModeField;
			}
			set
			{
				this.calcModeField = value;
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x000A23DD File Offset: 0x000A05DD
		// (set) Token: 0x06004432 RID: 17458 RVA: 0x000A23E5 File Offset: 0x000A05E5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool fullCalcOnLoad
		{
			get
			{
				return this.fullCalcOnLoadField;
			}
			set
			{
				this.fullCalcOnLoadField = value;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x000A23EE File Offset: 0x000A05EE
		// (set) Token: 0x06004434 RID: 17460 RVA: 0x000A23F6 File Offset: 0x000A05F6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode.A1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode refMode
		{
			get
			{
				return this.refModeField;
			}
			set
			{
				this.refModeField = value;
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06004435 RID: 17461 RVA: 0x000A23FF File Offset: 0x000A05FF
		// (set) Token: 0x06004436 RID: 17462 RVA: 0x000A2407 File Offset: 0x000A0607
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool iterate
		{
			get
			{
				return this.iterateField;
			}
			set
			{
				this.iterateField = value;
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x000A2410 File Offset: 0x000A0610
		// (set) Token: 0x06004438 RID: 17464 RVA: 0x000A2418 File Offset: 0x000A0618
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "100")]
		public uint iterateCount
		{
			get
			{
				return this.iterateCountField;
			}
			set
			{
				this.iterateCountField = value;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x000A2421 File Offset: 0x000A0621
		// (set) Token: 0x0600443A RID: 17466 RVA: 0x000A2429 File Offset: 0x000A0629
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0.001)]
		public double iterateDelta
		{
			get
			{
				return this.iterateDeltaField;
			}
			set
			{
				this.iterateDeltaField = value;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x000A2432 File Offset: 0x000A0632
		// (set) Token: 0x0600443C RID: 17468 RVA: 0x000A243A File Offset: 0x000A063A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool fullPrecision
		{
			get
			{
				return this.fullPrecisionField;
			}
			set
			{
				this.fullPrecisionField = value;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x000A2443 File Offset: 0x000A0643
		// (set) Token: 0x0600443E RID: 17470 RVA: 0x000A244B File Offset: 0x000A064B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool calcCompleted
		{
			get
			{
				return this.calcCompletedField;
			}
			set
			{
				this.calcCompletedField = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x000A2454 File Offset: 0x000A0654
		// (set) Token: 0x06004440 RID: 17472 RVA: 0x000A245C File Offset: 0x000A065C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool calcOnSave
		{
			get
			{
				return this.calcOnSaveField;
			}
			set
			{
				this.calcOnSaveField = value;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x000A2465 File Offset: 0x000A0665
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x000A246D File Offset: 0x000A066D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool concurrentCalc
		{
			get
			{
				return this.concurrentCalcField;
			}
			set
			{
				this.concurrentCalcField = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x000A2476 File Offset: 0x000A0676
		// (set) Token: 0x06004444 RID: 17476 RVA: 0x000A247E File Offset: 0x000A067E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint concurrentManualCount
		{
			get
			{
				return this.concurrentManualCountField;
			}
			set
			{
				this.concurrentManualCountField = value;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x000A2487 File Offset: 0x000A0687
		// (set) Token: 0x06004446 RID: 17478 RVA: 0x000A248F File Offset: 0x000A068F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool concurrentManualCountSpecified
		{
			get
			{
				return this.concurrentManualCountFieldSpecified;
			}
			set
			{
				this.concurrentManualCountFieldSpecified = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x000A2498 File Offset: 0x000A0698
		// (set) Token: 0x06004448 RID: 17480 RVA: 0x000A24A0 File Offset: 0x000A06A0
		[global::System.Xml.Serialization.XmlAttribute]
		public bool forceFullCalc
		{
			get
			{
				return this.forceFullCalcField;
			}
			set
			{
				this.forceFullCalcField = value;
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x000A24A9 File Offset: 0x000A06A9
		// (set) Token: 0x0600444A RID: 17482 RVA: 0x000A24B1 File Offset: 0x000A06B1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool forceFullCalcSpecified
		{
			get
			{
				return this.forceFullCalcFieldSpecified;
			}
			set
			{
				this.forceFullCalcFieldSpecified = value;
			}
		}

		// Token: 0x04002ACE RID: 10958
		private uint calcIdField;

		// Token: 0x04002ACF RID: 10959
		private bool calcIdFieldSpecified;

		// Token: 0x04002AD0 RID: 10960
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalcMode calcModeField;

		// Token: 0x04002AD1 RID: 10961
		private bool fullCalcOnLoadField;

		// Token: 0x04002AD2 RID: 10962
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_RefMode refModeField;

		// Token: 0x04002AD3 RID: 10963
		private bool iterateField;

		// Token: 0x04002AD4 RID: 10964
		private uint iterateCountField;

		// Token: 0x04002AD5 RID: 10965
		private double iterateDeltaField;

		// Token: 0x04002AD6 RID: 10966
		private bool fullPrecisionField;

		// Token: 0x04002AD7 RID: 10967
		private bool calcCompletedField;

		// Token: 0x04002AD8 RID: 10968
		private bool calcOnSaveField;

		// Token: 0x04002AD9 RID: 10969
		private bool concurrentCalcField;

		// Token: 0x04002ADA RID: 10970
		private uint concurrentManualCountField;

		// Token: 0x04002ADB RID: 10971
		private bool concurrentManualCountFieldSpecified;

		// Token: 0x04002ADC RID: 10972
		private bool forceFullCalcField;

		// Token: 0x04002ADD RID: 10973
		private bool forceFullCalcFieldSpecified;
	}
}
