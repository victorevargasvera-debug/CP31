using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A2 RID: 418
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Tbl
	{
		// Token: 0x06000FBA RID: 4026 RVA: 0x00032C7C File Offset: 0x00030E7C
		public CT_Tbl()
		{
			this.items1ElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType>();
			this.items1Field = new global::System.Collections.ArrayList();
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00032CB0 File Offset: 0x00030EB0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ct_Tbl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "tblPr")
				{
					ct_Tbl.tblPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tblGrid")
				{
					ct_Tbl.tblGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_Tbl.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.sdt);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRow.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXml);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.commentRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.proofErr);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.oMath);
				}
				else if (xmlNode.LocalName == "tr")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row.Parse(xmlNode, namespaceManager, ct_Tbl));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.oMathPara);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_Tbl.Items1.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Tbl.Items1ElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.commentRangeEnd);
				}
			}
			return ct_Tbl;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000336C0 File Offset: 0x000318C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)
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
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
			}
			if (this.tblPr != null)
			{
				this.tblPr.Write(sw, "tblPr");
			}
			if (this.tblGrid != null)
			{
				this.tblGrid.Write(sw, "tblGrid");
			}
			foreach (object obj2 in this.Items1)
			{
				if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow)obj2).Write(sw, "sdt");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRow)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRow)obj2).Write(sw, "customXml");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj2).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj2).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj2).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj2).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj2).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj2).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj2).Write(sw, "del");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj2).Write(sw, "ins");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj2).Write(sw, "moveFrom");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj2).Write(sw, "moveFromRangeEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj2).Write(sw, "commentRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj2).Write(sw, "moveTo");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj2).Write(sw, "moveToRangeEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj2).Write(sw, "moveToRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)obj2).Write(sw, "permEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)obj2).Write(sw, "permStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj2).Write(sw, "proofErr");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj2).Write(sw, "oMath");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row)obj2).Write(sw, "tr");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj2).Write(sw, "moveFromRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj2).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj2).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj2).Write(sw, "oMathPara");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj2).Write(sw, "bookmarkEnd");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj2).Write(sw, "bookmarkStart");
				}
				else if (obj2 is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj2).Write(sw, "commentRangeEnd");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00033CD4 File Offset: 0x00031ED4
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x00033CDC File Offset: 0x00031EDC
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 0)]
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

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00033CE5 File Offset: 0x00031EE5
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x00033CED File Offset: 0x00031EED
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30> ItemsElementName
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

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x00033CF6 File Offset: 0x00031EF6
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x00033CFE File Offset: 0x00031EFE
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr tblPr
		{
			get
			{
				return this.tblPrField;
			}
			set
			{
				this.tblPrField = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00033D07 File Offset: 0x00031F07
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x00033D0F File Offset: 0x00031F0F
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid tblGrid
		{
			get
			{
				return this.tblGridField;
			}
			set
			{
				this.tblGridField = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00033D18 File Offset: 0x00031F18
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00033D20 File Offset: 0x00031F20
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 4)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 4)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRow), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRow), Order = 4)]
		[global::System.Xml.Serialization.XmlElement("tr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row), Order = 4)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("Items1ElementName")]
		public global::System.Collections.ArrayList Items1
		{
			get
			{
				return this.items1Field;
			}
			set
			{
				this.items1Field = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00033D29 File Offset: 0x00031F29
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00033D31 File Offset: 0x00031F31
		[global::System.Xml.Serialization.XmlElement("Items1ElementName", Order = 5)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType> Items1ElementName
		{
			get
			{
				return this.items1ElementNameField;
			}
			set
			{
				this.items1ElementNameField = value;
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00033D3C File Offset: 0x00031F3C
		public void Set(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl table)
		{
			this.items1ElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType>(table.Items1ElementName);
			this.items1Field = new global::System.Collections.ArrayList(table.items1Field);
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30>(table.itemsElementNameField);
			this.itemsField = new global::System.Collections.ArrayList(table.itemsField);
			this.tblGridField = table.tblGridField;
			this.tblPrField = table.tblPrField;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00033DA5 File Offset: 0x00031FA5
		public void RemoveTr(int pos)
		{
			this.RemoveItems1(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr, pos);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00033DB0 File Offset: 0x00031FB0
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row InsertNewTr(int pos)
		{
			return this.InsertNewItems1<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr, pos);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00033DBB File Offset: 0x00031FBB
		public void SetTrArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row cT_Row)
		{
			this.SetItems1Array<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr, pos, cT_Row);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00033DC7 File Offset: 0x00031FC7
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row AddNewTr()
		{
			return this.AddNewItems1<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00033DD1 File Offset: 0x00031FD1
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr AddNewTblPr()
		{
			if (this.tblPrField == null)
			{
				this.tblPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr();
			}
			return this.tblPrField;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00033DEC File Offset: 0x00031FEC
		public int SizeOfTrArray()
		{
			return this.SizeOfItems1Array(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00033DF6 File Offset: 0x00031FF6
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row GetTrArray(int p)
		{
			return this.GetItems1Array<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row>(p, global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00033E01 File Offset: 0x00032001
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row> GetTrList()
		{
			return this.GetItems1List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType.tr);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00033E0C File Offset: 0x0003200C
		private global::System.Collections.Generic.List<T> GetItems1List<T>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type) where T : class
		{
			global::System.Collections.Generic.List<T> result;
			lock (this)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
				for (int i = 0; i < this.items1ElementNameField.Count; i++)
				{
					if (this.items1ElementNameField[i] == type)
					{
						list.Add(this.items1Field[i] as T);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00033E90 File Offset: 0x00032090
		private int SizeOfItems1Array(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type)
		{
			int result;
			lock (this)
			{
				int num = 0;
				for (int i = 0; i < this.items1ElementNameField.Count; i++)
				{
					if (this.items1ElementNameField[i] == type)
					{
						num++;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00033EF8 File Offset: 0x000320F8
		private T GetItems1Array<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type) where T : class
		{
			T t;
			lock (this)
			{
				int items1Index = this.GetItems1Index(type, p);
				if (items1Index < 0 || items1Index >= this.items1Field.Count)
				{
					t = default(T);
					t = t;
				}
				else
				{
					t = (this.items1Field[items1Index] as T);
				}
			}
			return t;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00033F6C File Offset: 0x0003216C
		private T InsertNewItems1<T>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type, int p) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				int items1Index = this.GetItems1Index(type, p);
				this.items1ElementNameField.Insert(items1Index, type);
				this.items1Field.Insert(items1Index, t);
			}
			return t;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00033FD0 File Offset: 0x000321D0
		private T AddNewItems1<T>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.items1ElementNameField.Add(type);
				this.items1Field.Add(t);
			}
			return t;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0003402C File Offset: 0x0003222C
		private void SetItems1Array<T>(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type, int p, T obj) where T : class
		{
			lock (this)
			{
				int items1Index = this.GetItems1Index(type, p);
				if (items1Index >= 0 && items1Index < this.items1Field.Count)
				{
					if (!(this.items1Field[items1Index] is T))
					{
						throw new global::System.Exception(string.Format("object types are difference, itemsField[{0}] is {1}, and parameter obj is {2}", items1Index, this.items1Field[items1Index].GetType().Name, typeof(T).Name));
					}
					this.items1Field[items1Index] = obj;
				}
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000340E0 File Offset: 0x000322E0
		private int GetItems1Index(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type, int p)
		{
			int result = -1;
			int num = 0;
			for (int i = 0; i < this.items1ElementNameField.Count; i++)
			{
				if (this.items1ElementNameField[i] == type)
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

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00034124 File Offset: 0x00032324
		private void RemoveItems1(global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType type, int p)
		{
			lock (this)
			{
				int items1Index = this.GetItems1Index(type, p);
				if (items1Index >= 0 && items1Index < this.items1Field.Count)
				{
					this.items1ElementNameField.RemoveAt(items1Index);
					this.items1Field.RemoveAt(items1Index);
				}
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00034190 File Offset: 0x00032390
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid AddNewTblGrid()
		{
			this.tblGrid = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid();
			return this.tblGrid;
		}

		// Token: 0x04000CBD RID: 3261
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04000CBE RID: 3262
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType30> itemsElementNameField;

		// Token: 0x04000CBF RID: 3263
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblPr tblPrField;

		// Token: 0x04000CC0 RID: 3264
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid tblGridField;

		// Token: 0x04000CC1 RID: 3265
		private global::System.Collections.ArrayList items1Field;

		// Token: 0x04000CC2 RID: 3266
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.Items1ChoiceType> items1ElementNameField;
	}
}
