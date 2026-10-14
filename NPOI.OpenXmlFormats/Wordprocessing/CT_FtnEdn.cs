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
	// Token: 0x02000120 RID: 288
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("endnote", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FtnEdn
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x00019C1C File Offset: 0x00017E1C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ct_FtnEdn = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn();
			if (node.Attributes["w:type"] != null)
			{
				ct_FtnEdn.type = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnEdn)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnEdn), node.Attributes["w:type"].Value);
			}
			ct_FtnEdn.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.ins);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.del);
				}
				else if (xmlNode.LocalName == "p")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.p);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.proofErr);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.sdt);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "tbl")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.tbl);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.oMathPara);
				}
				else if (xmlNode.LocalName == "altChunk")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.altChunk);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_FtnEdn.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock.Parse(xmlNode, namespaceManager));
					ct_FtnEdn.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXml);
				}
			}
			return ct_FtnEdn;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001A348 File Offset: 0x00018548
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:id", this.id);
			sw.Write(">");
			int num = 0;
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlDelRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.ins)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlDelRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlInsRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlInsRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveTo)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveToRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.customXmlMoveToRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.del)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj).Write(sw, "p");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj).Write(sw, "sdt");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveFrom)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveFrom");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj).Write(sw, "tbl");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.moveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk)obj).Write(sw, "altChunk");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.bookmarkEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.bookmarkStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.commentRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.commentRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock)obj).Write(sw, "customXml");
				}
				num++;
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x0001A8C8 File Offset: 0x00018AC8
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("altChunk", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("p", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("tbl", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl), Order = 0)]
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0001A8D1 File Offset: 0x00018AD1
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0001A8D9 File Offset: 0x00018AD9
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7> ItemsElementName
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0001A8E2 File Offset: 0x00018AE2
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x0001A8EA File Offset: 0x00018AEA
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnEdn type
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001A8F3 File Offset: 0x00018AF3
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0001A8FB File Offset: 0x00018AFB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeFieldSpecified;
			}
			set
			{
				this.typeFieldSpecified = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0001A904 File Offset: 0x00018B04
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0001A90C File Offset: 0x00018B0C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
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

		// Token: 0x060007DD RID: 2013 RVA: 0x0001A915 File Offset: 0x00018B15
		public void Set(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn note)
		{
			this.idField = note.idField;
			this.itemsElementNameField = note.itemsElementNameField;
			this.itemsField = note.itemsField;
			this.typeField = note.typeField;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001A948 File Offset: 0x00018B48
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7 type) where T : class
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

		// Token: 0x060007DF RID: 2015 RVA: 0x0001A9CC File Offset: 0x00018BCC
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7 type)
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

		// Token: 0x060007E0 RID: 2016 RVA: 0x0001AA34 File Offset: 0x00018C34
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7 type) where T : class
		{
			T result;
			lock (this)
			{
				int num = 0;
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					if (this.itemsElementNameField[i] == type)
					{
						if (num == p)
						{
							return this.itemsField[i] as T;
						}
						num++;
					}
				}
				result = default(T);
			}
			return result;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7 type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0001AB1C File Offset: 0x00018D1C
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7 type, T t) where T : class, new()
		{
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001AB70 File Offset: 0x00018D70
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P> GetPList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.p);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0001AB7A File Offset: 0x00018D7A
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl> GetTblList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.tbl);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0001AB84 File Offset: 0x00018D84
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl GetTblArray(int i)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(i, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.tbl);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001AB8F File Offset: 0x00018D8F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl AddNewTbl()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.tbl);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0001AB99 File Offset: 0x00018D99
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P AddNewP()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.p);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0001ABA3 File Offset: 0x00018DA3
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P AddNewP(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P paragraph)
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7.p, paragraph);
		}

		// Token: 0x040006FF RID: 1791
		private global::System.Collections.ArrayList itemsField = new global::System.Collections.ArrayList();

		// Token: 0x04000700 RID: 1792
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7> itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType7>();

		// Token: 0x04000701 RID: 1793
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnEdn typeField;

		// Token: 0x04000702 RID: 1794
		private bool typeFieldSpecified;

		// Token: 0x04000703 RID: 1795
		private string idField = string.Empty;
	}
}
