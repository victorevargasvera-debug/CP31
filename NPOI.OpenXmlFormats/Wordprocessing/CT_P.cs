using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200015A RID: 346
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_P
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x000219F4 File Offset: 0x0001FBF4
		public CT_P()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType>();
			this.itemsField = new global::System.Collections.ArrayList();
			this.pPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr();
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00021A1D File Offset: 0x0001FC1D
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00021A25 File Offset: 0x0001FC25
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPr
		{
			get
			{
				return this.pPrField;
			}
			set
			{
				this.pPrField = value;
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00021A30 File Offset: 0x0001FC30
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_P Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_P();
			if (node.Attributes["w14:paraId"] != null)
			{
				ct_P.paraIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w14:paraId"]);
			}
			if (node.Attributes["w14:textId"] != null)
			{
				ct_P.textIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w14:textId"]);
			}
			ct_P.rsidRPr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidRPr"]);
			ct_P.rsidR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidR"]);
			ct_P.rsidDel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidDel"]);
			ct_P.rsidP = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidP"]);
			ct_P.rsidRDefault = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidRDefault"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pPr")
				{
					ct_P.pPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveTo);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.oMathPara);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.oMath);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXml);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.del);
				}
				else if (xmlNode.LocalName == "fldSimple")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.fldSimple);
				}
				else if (xmlNode.LocalName == "hyperlink")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.hyperlink);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.proofErr);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.sdt);
				}
				else if (xmlNode.LocalName == "smartTag")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.smartTag);
				}
				else if (xmlNode.LocalName == "subDoc")
				{
					ct_P.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager));
					ct_P.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.subDoc);
				}
			}
			return ct_P;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00022274 File Offset: 0x00020474
		public bool IsSetRsidR()
		{
			return this.rsidRField != null && this.rsidRField.Length != 0;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002228C File Offset: 0x0002048C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w14:paraId", this.paraIdField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w14:textId", this.textIdField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidR", this.rsidR);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidRPr", this.rsidRPr);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidRDefault", this.rsidRDefault);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidP", this.rsidP);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidDel", this.rsidDel);
			sw.Write(">");
			if (this.pPr != null && !this.pPr.IsEmpty)
			{
				this.pPr.Write(sw, "pPr");
			}
			int num = 0;
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveTo)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.commentRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.commentRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun)obj).Write(sw, "customXml");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlDelRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlDelRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlInsRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlInsRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.customXmlMoveToRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.del)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField)obj).Write(sw, "fldSimple");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1)obj).Write(sw, "hyperlink");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.ins)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveFrom)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveFrom");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.moveToRangeStart)
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)obj).Write(sw, "r");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun)obj).Write(sw, "sdt");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun)obj).Write(sw, "smartTag");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel)obj).Write(sw, "subDoc");
				}
				num++;
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000228A4 File Offset: 0x00020AA4
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x000228AC File Offset: 0x00020AAC
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("fldSimple", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("hyperlink", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("r", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("smartTag", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("subDoc", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel), Order = 1)]
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

		// Token: 0x060009BE RID: 2494 RVA: 0x000228B8 File Offset: 0x00020AB8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_R AddNewR()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_R();
			lock (this)
			{
				this.itemsField.Add(ct_R);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r);
			}
			return ct_R;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00022910 File Offset: 0x00020B10
		public global::NPOI.OpenXmlFormats.Shared.CT_OMath AddNewOMath()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_OMath ct_OMath = new global::NPOI.OpenXmlFormats.Shared.CT_OMath();
			lock (this)
			{
				this.itemsField.Add(ct_OMath);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.oMath);
			}
			return ct_OMath;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00022968 File Offset: 0x00020B68
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x00022970 File Offset: 0x00020B70
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType> ItemsElementName
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00022979 File Offset: 0x00020B79
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00022981 File Offset: 0x00020B81
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002298A File Offset: 0x00020B8A
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00022992 File Offset: 0x00020B92
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002299B File Offset: 0x00020B9B
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x000229A3 File Offset: 0x00020BA3
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000229AC File Offset: 0x00020BAC
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x000229B4 File Offset: 0x00020BB4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidP
		{
			get
			{
				return this.rsidPField;
			}
			set
			{
				this.rsidPField = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000229BD File Offset: 0x00020BBD
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x000229C5 File Offset: 0x00020BC5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidRDefault
		{
			get
			{
				return this.rsidRDefaultField;
			}
			set
			{
				this.rsidRDefaultField = value;
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000229CE File Offset: 0x00020BCE
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr AddNewPPr()
		{
			if (this.pPrField == null)
			{
				this.pPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr();
			}
			return this.pPrField;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000229E9 File Offset: 0x00020BE9
		public void SetRArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_R Run)
		{
			this.SetObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r, pos, Run);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000229F5 File Offset: 0x00020BF5
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_R InsertNewR(int pos)
		{
			return this.InsertNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r, pos);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00022A00 File Offset: 0x00020C00
		public int SizeOfRArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00022A0A File Offset: 0x00020C0A
		public void RemoveR(int pos)
		{
			this.RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r, pos);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00022A15 File Offset: 0x00020C15
		public global::System.Collections.Generic.IEnumerable<global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange> GetCommentRangeStartList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.commentRangeStart);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00022A1E File Offset: 0x00020C1E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1 AddNewHyperlink()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.hyperlink);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00022A28 File Offset: 0x00020C28
		public global::System.Collections.Generic.IEnumerable<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1> GetHyperlinkList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.hyperlink);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00022A34 File Offset: 0x00020C34
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type) where T : class
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

		// Token: 0x060009D5 RID: 2517 RVA: 0x00022AB8 File Offset: 0x00020CB8
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type)
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

		// Token: 0x060009D6 RID: 2518 RVA: 0x00022B20 File Offset: 0x00020D20
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type) where T : class
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

		// Token: 0x060009D7 RID: 2519 RVA: 0x00022B94 File Offset: 0x00020D94
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type, int p) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				int num = this.GetObjectIndex(type, p);
				if (num == -1)
				{
					num = 0;
				}
				this.itemsElementNameField.Insert(num, type);
				this.itemsField.Insert(num, t);
			}
			return t;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00022C00 File Offset: 0x00020E00
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00022C5C File Offset: 0x00020E5C
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type, int p, T obj) where T : class
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

		// Token: 0x060009DA RID: 2522 RVA: 0x00022D10 File Offset: 0x00020F10
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type, int p)
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

		// Token: 0x060009DB RID: 2523 RVA: 0x00022D54 File Offset: 0x00020F54
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType type, int p)
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

		// Token: 0x060009DC RID: 2524 RVA: 0x00022DC0 File Offset: 0x00020FC0
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R> GetRList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00022DCA File Offset: 0x00020FCA
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_R GetRArray(int pos)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R>(pos, global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.r);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00022DD5 File Offset: 0x00020FD5
		public int SizeOfBookmarkStartArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkStart);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00022DDE File Offset: 0x00020FDE
		public int SizeOfBookmarkEndArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkEnd);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00022DE7 File Offset: 0x00020FE7
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark GetBookmarkStartArray(int p)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark>(p, global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkStart);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00022DF1 File Offset: 0x00020FF1
		public global::System.Collections.Generic.IEnumerable<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark> GetBookmarkStartList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark>(global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType.bookmarkStart);
		}

		// Token: 0x04000986 RID: 2438
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr pPrField;

		// Token: 0x04000987 RID: 2439
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04000988 RID: 2440
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ParagraphItemsChoiceType> itemsElementNameField;

		// Token: 0x04000989 RID: 2441
		private byte[] rsidRPrField;

		// Token: 0x0400098A RID: 2442
		private byte[] rsidRField;

		// Token: 0x0400098B RID: 2443
		private byte[] rsidDelField;

		// Token: 0x0400098C RID: 2444
		private byte[] rsidPField;

		// Token: 0x0400098D RID: 2445
		private byte[] rsidRDefaultField;

		// Token: 0x0400098E RID: 2446
		private byte[] paraIdField;

		// Token: 0x0400098F RID: 2447
		private byte[] textIdField;
	}
}
