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
	// Token: 0x0200006B RID: 107
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomXmlCell
	{
		// Token: 0x0600032F RID: 815 RVA: 0x000090C0 File Offset: 0x000072C0
		public CT_CustomXmlCell()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000090E0 File Offset: 0x000072E0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell ct_CustomXmlCell = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell();
			ct_CustomXmlCell.uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:uri"]);
			ct_CustomXmlCell.element = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:element"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlPr")
				{
					ct_CustomXmlCell.customXmlPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.sdt);
				}
				else if (xmlNode.LocalName == "tc")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc.Parse(xmlNode, namespaceManager, ct_CustomXmlCell));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.tc);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.permEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.proofErr);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.oMathPara);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXml);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_CustomXmlCell.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlCell.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27.customXmlInsRangeEnd);
				}
			}
			return ct_CustomXmlCell;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000979C File Offset: 0x0000799C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:uri", this.uri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:element", this.element);
			sw.Write(">");
			if (this.customXmlPr != null)
			{
				this.customXmlPr.Write(sw, "customXmlPr");
			}
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell)obj).Write(sw, "sdt");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc)obj).Write(sw, "tc");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)obj).Write(sw, "permEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
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
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)obj).Write(sw, "permStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj).Write(sw, "proofErr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell)obj).Write(sw, "customXml");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00009B9C File Offset: 0x00007D9C
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00009BA4 File Offset: 0x00007DA4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr customXmlPr
		{
			get
			{
				return this.customXmlPrField;
			}
			set
			{
				this.customXmlPrField = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00009BAD File Offset: 0x00007DAD
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00009BB5 File Offset: 0x00007DB5
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlCell), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 1)]
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
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtCell), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("tc", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc), Order = 1)]
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00009BBE File Offset: 0x00007DBE
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00009BC6 File Offset: 0x00007DC6
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27> ItemsElementName
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00009BCF File Offset: 0x00007DCF
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00009BD7 File Offset: 0x00007DD7
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string uri
		{
			get
			{
				return this.uriField;
			}
			set
			{
				this.uriField = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00009BE0 File Offset: 0x00007DE0
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string element
		{
			get
			{
				return this.elementField;
			}
			set
			{
				this.elementField = value;
			}
		}

		// Token: 0x0400029C RID: 668
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr customXmlPrField;

		// Token: 0x0400029D RID: 669
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x0400029E RID: 670
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType27> itemsElementNameField;

		// Token: 0x0400029F RID: 671
		private string uriField;

		// Token: 0x040002A0 RID: 672
		private string elementField;
	}
}
