using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Shared;
using NPOI.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001CB RID: 459
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Row
	{
		// Token: 0x06001185 RID: 4485 RVA: 0x0003A088 File Offset: 0x00038288
		public CT_Row()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0003A0A6 File Offset: 0x000382A6
		[global::System.Xml.Serialization.XmlIgnore]
		public object Parent
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0003A0B0 File Offset: 0x000382B0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager, object parent)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row ct_Row = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row();
			if (parent != null)
			{
				ct_Row.parent = parent;
			}
			if (node.Attributes["w14:paraId"] != null)
			{
				ct_Row.paraIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w14:paraId"]);
			}
			if (node.Attributes["w14:textId"] != null)
			{
				ct_Row.textIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w14:textId"]);
			}
			ct_Row.rsidRPr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidRPr"]);
			ct_Row.rsidR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidR"]);
			ct_Row.rsidDel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidDel"]);
			ct_Row.rsidTr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidTr"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tblPrEx")
				{
					ct_Row.tblPrEx = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trPr")
				{
					ct_Row.trPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.del);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.moveTo);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.oMathPara);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXml);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.proofErr);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell.Parse(xmlNode, namespaceManager));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.sdt);
				}
				else if (xmlNode.LocalName == "tc")
				{
					ct_Row.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc.Parse(xmlNode, namespaceManager, ct_Row));
					ct_Row.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.tc);
				}
			}
			return ct_Row;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0003A82C File Offset: 0x00038A2C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidR", this.rsidR);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidRPr", this.rsidRPr);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidDel", this.rsidDel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidTr", this.rsidTr);
			sw.Write(">");
			if (this.tblPrEx != null)
			{
				this.tblPrEx.Write(sw, "tblPrEx");
			}
			if (this.trPr != null)
			{
				this.trPr.Write(sw, "trPr");
			}
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell)obj).Write(sw, "customXml");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveFrom");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)obj).Write(sw, "permEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)obj).Write(sw, "permStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj).Write(sw, "proofErr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell)obj).Write(sw, "sdt");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc)obj).Write(sw, "tc");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0003AC68 File Offset: 0x00038E68
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row Copy()
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row
			{
				paraIdField = this.paraIdField.ToArray<byte>(),
				rsidRField = this.rsidRField.ToArray<byte>(),
				rsidDelField = this.rsidDelField.ToArray<byte>(),
				rsidRPrField = this.rsidRPrField.ToArray<byte>(),
				rsidTrField = this.rsidTrField.ToArray<byte>(),
				textIdField = this.textIdField.ToArray<byte>(),
				trPrField = this.trPrField.Copy<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr>(),
				tblPrExField = this.tblPrExField.Copy<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx>(),
				itemsElementNameField = this.itemsElementNameField.Copy<global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType>>(),
				itemsField = this.itemsField.Copy<global::System.Collections.ArrayList>()
			};
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0003AD24 File Offset: 0x00038F24
		public void RemoveTc(int pos)
		{
			this.RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.tc, pos);
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0003AD2F File Offset: 0x00038F2F
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0003AD37 File Offset: 0x00038F37
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx tblPrEx
		{
			get
			{
				return this.tblPrExField;
			}
			set
			{
				this.tblPrExField = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0003AD40 File Offset: 0x00038F40
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x0003AD48 File Offset: 0x00038F48
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPr
		{
			get
			{
				return this.trPrField;
			}
			set
			{
				this.trPrField = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0003AD51 File Offset: 0x00038F51
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0003AD59 File Offset: 0x00038F59
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell), Order = 2)]
		[global::System.Xml.Serialization.XmlElement("tc", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc), Order = 2)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public global::System.Collections.ArrayList Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0003AD62 File Offset: 0x00038F62
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0003AD6A File Offset: 0x00038F6A
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 3)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType> ItemsElementName
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0003AD73 File Offset: 0x00038F73
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0003AD7B File Offset: 0x00038F7B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidRPr
		{
			get
			{
				return this.rsidRPrField;
			}
			set
			{
				this.rsidRPrField = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0003AD84 File Offset: 0x00038F84
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0003AD8C File Offset: 0x00038F8C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidR
		{
			get
			{
				return this.rsidRField;
			}
			set
			{
				this.rsidRField = value;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0003AD95 File Offset: 0x00038F95
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0003AD9D File Offset: 0x00038F9D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidDel
		{
			get
			{
				return this.rsidDelField;
			}
			set
			{
				this.rsidDelField = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0003ADA6 File Offset: 0x00038FA6
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0003ADAE File Offset: 0x00038FAE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidTr
		{
			get
			{
				return this.rsidTrField;
			}
			set
			{
				this.rsidTrField = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0003ADB7 File Offset: 0x00038FB7
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0003ADBF File Offset: 0x00038FBF
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl Table
		{
			get
			{
				return this._table;
			}
			set
			{
				this._table = value;
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc> GetTcList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.tc);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0003ADD2 File Offset: 0x00038FD2
		public bool IsSetTrPr()
		{
			return this.trPrField != null && this.trPrField.Items.Count > 0;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0003ADF1 File Offset: 0x00038FF1
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr AddNewTrPr()
		{
			if (this.trPrField == null)
			{
				this.trPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr();
			}
			return this.trPrField;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0003AE0C File Offset: 0x0003900C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc AddNewTc()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.tc);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0003AE16 File Offset: 0x00039016
		public int SizeOfTcArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.tc);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0003AE20 File Offset: 0x00039020
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc GetTcArray(int p)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc>(p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType.tc);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0003AE2C File Offset: 0x0003902C
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type) where T : class
		{
			global::System.Collections.Generic.List<T> result;
			lock (this)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					if (this.itemsElementNameField[i] == type)
					{
						list.Add(this.itemsField[i] as T);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0003AEB0 File Offset: 0x000390B0
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type)
		{
			int result;
			lock (this)
			{
				int num = 0;
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					if (this.itemsElementNameField[i] == type)
					{
						num++;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0003AF18 File Offset: 0x00039118
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type) where T : class
		{
			T t;
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex < 0 || objectIndex >= this.itemsField.Count)
				{
					t = default(T);
					t = t;
				}
				else
				{
					t = (this.itemsField[objectIndex] as T);
				}
			}
			return t;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0003AF8C File Offset: 0x0003918C
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type, int p) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				this.itemsElementNameField.Insert(objectIndex, type);
				this.itemsField.Insert(objectIndex, t);
			}
			return t;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0003AFF0 File Offset: 0x000391F0
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0003B04C File Offset: 0x0003924C
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type, int p, T obj) where T : class
		{
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex >= 0 && objectIndex < this.itemsField.Count)
				{
					if (!(this.itemsField[objectIndex] is T))
					{
						throw new global::System.Exception(string.Format("object types are difference, itemsField[{0}] is {1}, and parameter obj is {2}", objectIndex, this.itemsField[objectIndex].GetType().Name, typeof(T).Name));
					}
					this.itemsField[objectIndex] = obj;
				}
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0003B100 File Offset: 0x00039300
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type, int p)
		{
			int result = -1;
			int num = 0;
			for (int i = 0; i < this.itemsElementNameField.Count; i++)
			{
				if (this.itemsElementNameField[i] == type)
				{
					if (num == p)
					{
						result = i;
						break;
					}
					num++;
				}
			}
			return result;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0003B144 File Offset: 0x00039344
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType type, int p)
		{
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex >= 0 && objectIndex < this.itemsField.Count)
				{
					this.itemsElementNameField.RemoveAt(objectIndex);
					this.itemsField.RemoveAt(objectIndex);
				}
			}
		}

		// Token: 0x04000D94 RID: 3476
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPrEx tblPrExField;

		// Token: 0x04000D95 RID: 3477
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr trPrField;

		// Token: 0x04000D96 RID: 3478
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04000D97 RID: 3479
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceTableRowType> itemsElementNameField;

		// Token: 0x04000D98 RID: 3480
		private byte[] rsidRPrField;

		// Token: 0x04000D99 RID: 3481
		private byte[] rsidRField;

		// Token: 0x04000D9A RID: 3482
		private byte[] rsidDelField;

		// Token: 0x04000D9B RID: 3483
		private byte[] rsidTrField;

		// Token: 0x04000D9C RID: 3484
		private byte[] paraIdField;

		// Token: 0x04000D9D RID: 3485
		private byte[] textIdField;

		// Token: 0x04000D9E RID: 3486
		private object parent;

		// Token: 0x04000D9F RID: 3487
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl _table;
	}
}
