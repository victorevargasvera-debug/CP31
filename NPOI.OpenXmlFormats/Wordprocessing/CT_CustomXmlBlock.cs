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
	// Token: 0x02000069 RID: 105
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomXmlBlock
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00008578 File Offset: 0x00006778
		public CT_CustomXmlBlock()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00008596 File Offset: 0x00006796
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000859E File Offset: 0x0000679E
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

		// Token: 0x06000325 RID: 805 RVA: 0x000085A8 File Offset: 0x000067A8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock ct_CustomXmlBlock = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock();
			ct_CustomXmlBlock.uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:uri"]);
			ct_CustomXmlBlock.element = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:element"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "del")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.del);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.moveFrom);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.moveTo);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXml);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.oMath);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.ins);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "p")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.p);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.permEnd);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.proofErr);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.sdt);
				}
				else if (xmlNode.LocalName == "tbl")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.tbl);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.permStart);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_CustomXmlBlock.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_CustomXmlBlock.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26.oMathPara);
				}
			}
			return ct_CustomXmlBlock;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00008C78 File Offset: 0x00006E78
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:uri", this.uri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:element", this.element);
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveFrom");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock)obj).Write(sw, "customXml");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
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
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj).Write(sw, "p");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)obj).Write(sw, "permEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj).Write(sw, "proofErr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj).Write(sw, "sdt");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj).Write(sw, "tbl");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)obj).Write(sw, "permStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000907C File Offset: 0x0000727C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00009084 File Offset: 0x00007284
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock), Order = 1)]
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
		[global::System.Xml.Serialization.XmlElement("p", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("tbl", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl), Order = 1)]
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000908D File Offset: 0x0000728D
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00009095 File Offset: 0x00007295
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26> ItemsElementName
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000909E File Offset: 0x0000729E
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000090A6 File Offset: 0x000072A6
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000090AF File Offset: 0x000072AF
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000090B7 File Offset: 0x000072B7
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

		// Token: 0x04000279 RID: 633
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr customXmlPrField;

		// Token: 0x0400027A RID: 634
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x0400027B RID: 635
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType26> itemsElementNameField;

		// Token: 0x0400027C RID: 636
		private string uriField;

		// Token: 0x0400027D RID: 637
		private string elementField;
	}
}
