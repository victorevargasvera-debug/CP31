using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x02000351 RID: 849
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot("anchor", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Anchor
	{
		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00058121 File Offset: 0x00056321
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00058129 File Offset: 0x00056329
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Point2D simplePos
		{
			get
			{
				return this.simplePosField;
			}
			set
			{
				this.simplePosField = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x00058132 File Offset: 0x00056332
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x0005813A File Offset: 0x0005633A
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosH positionH
		{
			get
			{
				return this.positionHField;
			}
			set
			{
				this.positionHField = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00058143 File Offset: 0x00056343
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x0005814B File Offset: 0x0005634B
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosV positionV
		{
			get
			{
				return this.positionVField;
			}
			set
			{
				this.positionVField = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00058154 File Offset: 0x00056354
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x0005815C File Offset: 0x0005635C
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D extent
		{
			get
			{
				return this.extentField;
			}
			set
			{
				this.extentField = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x00058165 File Offset: 0x00056365
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x0005816D File Offset: 0x0005636D
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtent
		{
			get
			{
				return this.effectExtentField;
			}
			set
			{
				this.effectExtentField = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x00058176 File Offset: 0x00056376
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x0005817E File Offset: 0x0005637E
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapNone wrapNone
		{
			get
			{
				return this.wrapNoneField;
			}
			set
			{
				this.wrapNoneField = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x00058187 File Offset: 0x00056387
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x0005818F File Offset: 0x0005638F
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTight wrapTight
		{
			get
			{
				return this.wrapTightField;
			}
			set
			{
				this.wrapTightField = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x00058198 File Offset: 0x00056398
		// (set) Token: 0x06002192 RID: 8594 RVA: 0x000581A0 File Offset: 0x000563A0
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTopBottom wrapTopAndBottom
		{
			get
			{
				return this.wrapTopAndBottomField;
			}
			set
			{
				this.wrapTopAndBottomField = value;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000581A9 File Offset: 0x000563A9
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x000581B1 File Offset: 0x000563B1
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapSquare wrapSquare
		{
			get
			{
				return this.wrapSquareField;
			}
			set
			{
				this.wrapSquareField = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000581BA File Offset: 0x000563BA
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x000581C2 File Offset: 0x000563C2
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapThrough wrapThrough
		{
			get
			{
				return this.wrapThroughField;
			}
			set
			{
				this.wrapThroughField = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x000581CB File Offset: 0x000563CB
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x000581D3 File Offset: 0x000563D3
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps docPr
		{
			get
			{
				return this.docPrField;
			}
			set
			{
				this.docPrField = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x000581DC File Offset: 0x000563DC
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x000581E4 File Offset: 0x000563E4
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties cNvGraphicFramePr
		{
			get
			{
				return this.cNvGraphicFramePrField;
			}
			set
			{
				this.cNvGraphicFramePrField = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x000581ED File Offset: 0x000563ED
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x000581F5 File Offset: 0x000563F5
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphic
		{
			get
			{
				return this.graphicField;
			}
			set
			{
				this.graphicField = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000581FE File Offset: 0x000563FE
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x00058206 File Offset: 0x00056406
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distT
		{
			get
			{
				return this.distTField;
			}
			set
			{
				this.distTField = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x0005820F File Offset: 0x0005640F
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x00058217 File Offset: 0x00056417
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distTSpecified
		{
			get
			{
				return this.distTFieldSpecified;
			}
			set
			{
				this.distTFieldSpecified = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x00058220 File Offset: 0x00056420
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x00058228 File Offset: 0x00056428
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distB
		{
			get
			{
				return this.distBField;
			}
			set
			{
				this.distBField = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00058231 File Offset: 0x00056431
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00058239 File Offset: 0x00056439
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distBSpecified
		{
			get
			{
				return this.distBFieldSpecified;
			}
			set
			{
				this.distBFieldSpecified = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00058242 File Offset: 0x00056442
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x0005824A File Offset: 0x0005644A
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distL
		{
			get
			{
				return this.distLField;
			}
			set
			{
				this.distLField = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00058253 File Offset: 0x00056453
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x0005825B File Offset: 0x0005645B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distLSpecified
		{
			get
			{
				return this.distLFieldSpecified;
			}
			set
			{
				this.distLFieldSpecified = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00058264 File Offset: 0x00056464
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x0005826C File Offset: 0x0005646C
		[global::System.Xml.Serialization.XmlAttribute]
		public uint distR
		{
			get
			{
				return this.distRField;
			}
			set
			{
				this.distRField = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00058275 File Offset: 0x00056475
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x0005827D File Offset: 0x0005647D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool distRSpecified
		{
			get
			{
				return this.distRFieldSpecified;
			}
			set
			{
				this.distRFieldSpecified = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00058286 File Offset: 0x00056486
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x0005828E File Offset: 0x0005648E
		[global::System.Xml.Serialization.XmlAttribute("simplePos")]
		public bool simplePos1
		{
			get
			{
				return this.simplePos1Field;
			}
			set
			{
				this.simplePos1Field = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00058297 File Offset: 0x00056497
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x0005829F File Offset: 0x0005649F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool simplePos1Specified
		{
			get
			{
				return this.simplePos1FieldSpecified;
			}
			set
			{
				this.simplePos1FieldSpecified = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x000582A8 File Offset: 0x000564A8
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x000582B0 File Offset: 0x000564B0
		[global::System.Xml.Serialization.XmlAttribute]
		public uint relativeHeight
		{
			get
			{
				return this.relativeHeightField;
			}
			set
			{
				this.relativeHeightField = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000582B9 File Offset: 0x000564B9
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x000582C1 File Offset: 0x000564C1
		[global::System.Xml.Serialization.XmlAttribute]
		public bool behindDoc
		{
			get
			{
				return this.behindDocField;
			}
			set
			{
				this.behindDocField = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000582CA File Offset: 0x000564CA
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x000582D2 File Offset: 0x000564D2
		[global::System.Xml.Serialization.XmlAttribute]
		public bool locked
		{
			get
			{
				return this.lockedField;
			}
			set
			{
				this.lockedField = value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x000582DB File Offset: 0x000564DB
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x000582E3 File Offset: 0x000564E3
		[global::System.Xml.Serialization.XmlAttribute]
		public bool layoutInCell
		{
			get
			{
				return this.layoutInCellField;
			}
			set
			{
				this.layoutInCellField = value;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x000582EC File Offset: 0x000564EC
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x000582F4 File Offset: 0x000564F4
		[global::System.Xml.Serialization.XmlAttribute]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x000582FD File Offset: 0x000564FD
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00058305 File Offset: 0x00056505
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hiddenSpecified
		{
			get
			{
				return this.hiddenFieldSpecified;
			}
			set
			{
				this.hiddenFieldSpecified = value;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0005830E File Offset: 0x0005650E
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00058316 File Offset: 0x00056516
		[global::System.Xml.Serialization.XmlAttribute]
		public bool allowOverlap
		{
			get
			{
				return this.allowOverlapField;
			}
			set
			{
				this.allowOverlapField = value;
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00058320 File Offset: 0x00056520
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor ct_Anchor = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Anchor();
			ct_Anchor.distT = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["distT"]);
			ct_Anchor.distB = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["distB"]);
			ct_Anchor.distL = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["distL"]);
			ct_Anchor.distR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["distR"]);
			ct_Anchor.simplePos1 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["simplePos"]);
			ct_Anchor.relativeHeight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["relativeHeight"]);
			ct_Anchor.behindDoc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["behindDoc"]);
			ct_Anchor.locked = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["locked"]);
			ct_Anchor.layoutInCell = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["layoutInCell"]);
			ct_Anchor.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			ct_Anchor.allowOverlap = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["allowOverlap"]);
			if (node.Attributes["wp14:anchorId"] != null)
			{
				ct_Anchor.anchorIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["wp14:anchorId"]);
			}
			if (node.Attributes["wp14:editId"] != null)
			{
				ct_Anchor.editIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["wp14:editId"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "simplePos")
				{
					ct_Anchor.simplePos = global::NPOI.OpenXmlFormats.Dml.CT_Point2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "positionH")
				{
					ct_Anchor.positionH = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosH.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "positionV")
				{
					ct_Anchor.positionV = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosV.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extent")
				{
					ct_Anchor.extent = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wrapSquare")
				{
					ct_Anchor.wrapSquare = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapSquare.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wrapNone")
				{
					ct_Anchor.wrapNone = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapNone();
				}
				else if (xmlNode.LocalName == "effectExtent")
				{
					ct_Anchor.effectExtent = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wrapTopAndBottom")
				{
					ct_Anchor.wrapTopAndBottom = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTopBottom.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "docPr")
				{
					ct_Anchor.docPr = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cNvGraphicFramePr")
				{
					ct_Anchor.cNvGraphicFramePr = global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "graphic")
				{
					ct_Anchor.graphic = global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Anchor;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00058690 File Offset: 0x00056890
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distT", this.distT, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distB", this.distB, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distL", this.distL, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "distR", this.distR, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "simplePos", this.simplePos1);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "relativeHeight", this.relativeHeight, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "behindDoc", this.behindDoc);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "locked", this.locked);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "layoutInCell", this.layoutInCell);
			if (!this.hidden)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "allowOverlap", this.allowOverlap);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "wp14:anchorId", this.anchorIdField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "wp14:editId", this.editIdField);
			sw.Write(">");
			if (this.simplePos != null)
			{
				this.simplePos.Write(sw, "simplePos");
			}
			if (this.positionH != null)
			{
				this.positionH.Write(sw, "positionH");
			}
			if (this.positionV != null)
			{
				this.positionV.Write(sw, "positionV");
			}
			if (this.extent != null)
			{
				this.extent.Write(sw, "extent");
			}
			if (this.effectExtent != null)
			{
				this.effectExtent.Write(sw, "effectExtent");
			}
			if (this.wrapTopAndBottom != null)
			{
				this.wrapTopAndBottom.Write(sw, "wrapTopAndBottom");
			}
			if (this.wrapSquare != null)
			{
				this.wrapSquare.Write(sw, "wrapSquare");
			}
			if (this.wrapNone != null)
			{
				this.wrapNone.Write(sw, "wrapNone");
			}
			if (this.docPr != null)
			{
				this.docPr.Write(sw, "docPr");
			}
			if (this.cNvGraphicFramePr != null)
			{
				this.cNvGraphicFramePr.Write(sw, "cNvGraphicFramePr");
			}
			if (this.graphic != null)
			{
				this.graphic.Write(sw, "graphic");
			}
			sw.Write(string.Format("</wp:{0}>", nodeName));
		}

		// Token: 0x04001999 RID: 6553
		private global::NPOI.OpenXmlFormats.Dml.CT_Point2D simplePosField;

		// Token: 0x0400199A RID: 6554
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosH positionHField;

		// Token: 0x0400199B RID: 6555
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PosV positionVField;

		// Token: 0x0400199C RID: 6556
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_PositiveSize2D extentField;

		// Token: 0x0400199D RID: 6557
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_EffectExtent effectExtentField;

		// Token: 0x0400199E RID: 6558
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualDrawingProps docPrField;

		// Token: 0x0400199F RID: 6559
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties cNvGraphicFramePrField;

		// Token: 0x040019A0 RID: 6560
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject graphicField;

		// Token: 0x040019A1 RID: 6561
		private uint distTField;

		// Token: 0x040019A2 RID: 6562
		private bool distTFieldSpecified;

		// Token: 0x040019A3 RID: 6563
		private uint distBField;

		// Token: 0x040019A4 RID: 6564
		private bool distBFieldSpecified;

		// Token: 0x040019A5 RID: 6565
		private uint distLField;

		// Token: 0x040019A6 RID: 6566
		private bool distLFieldSpecified;

		// Token: 0x040019A7 RID: 6567
		private uint distRField;

		// Token: 0x040019A8 RID: 6568
		private bool distRFieldSpecified;

		// Token: 0x040019A9 RID: 6569
		private bool simplePos1Field;

		// Token: 0x040019AA RID: 6570
		private bool simplePos1FieldSpecified;

		// Token: 0x040019AB RID: 6571
		private uint relativeHeightField;

		// Token: 0x040019AC RID: 6572
		private bool behindDocField;

		// Token: 0x040019AD RID: 6573
		private bool lockedField;

		// Token: 0x040019AE RID: 6574
		private bool layoutInCellField;

		// Token: 0x040019AF RID: 6575
		private bool hiddenField;

		// Token: 0x040019B0 RID: 6576
		private bool hiddenFieldSpecified;

		// Token: 0x040019B1 RID: 6577
		private bool allowOverlapField;

		// Token: 0x040019B2 RID: 6578
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapNone wrapNoneField;

		// Token: 0x040019B3 RID: 6579
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTight wrapTightField;

		// Token: 0x040019B4 RID: 6580
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapTopBottom wrapTopAndBottomField;

		// Token: 0x040019B5 RID: 6581
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapSquare wrapSquareField;

		// Token: 0x040019B6 RID: 6582
		private global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_WrapThrough wrapThroughField;

		// Token: 0x040019B7 RID: 6583
		private byte[] anchorIdField;

		// Token: 0x040019B8 RID: 6584
		private byte[] editIdField;
	}
}
