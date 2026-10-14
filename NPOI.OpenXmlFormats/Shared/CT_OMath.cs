using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200067F RID: 1663
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OMath : global::NPOI.OpenXmlFormats.Shared.IOMathContainer
	{
		// Token: 0x060046FC RID: 18172 RVA: 0x000AA9E2 File Offset: 0x000A8BE2
		public CT_OMath()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x000AAA00 File Offset: 0x000A8C00
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x000AAA08 File Offset: 0x000A8C08
		[global::System.Xml.Serialization.XmlElement("acc", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Acc), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bar", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Bar), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("borderBox", typeof(global::NPOI.OpenXmlFormats.Shared.CT_BorderBox), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("box", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Box), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("d", typeof(global::NPOI.OpenXmlFormats.Shared.CT_D), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("eqArr", typeof(global::NPOI.OpenXmlFormats.Shared.CT_EqArr), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("f", typeof(global::NPOI.OpenXmlFormats.Shared.CT_F), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("func", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Func), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("groupChr", typeof(global::NPOI.OpenXmlFormats.Shared.CT_GroupChr), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("limLow", typeof(global::NPOI.OpenXmlFormats.Shared.CT_LimLow), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("limUpp", typeof(global::NPOI.OpenXmlFormats.Shared.CT_LimUpp), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("m", typeof(global::NPOI.OpenXmlFormats.Shared.CT_M), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("nary", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Nary), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("phant", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Phant), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("r", typeof(global::NPOI.OpenXmlFormats.Shared.CT_R), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("rad", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Rad), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sPre", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SPre), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sSub", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSub), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sSubSup", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSubSup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sSup", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSup), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
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

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x000AAA11 File Offset: 0x000A8C11
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x000AAA19 File Offset: 0x000A8C19
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8> ItemsElementName
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

		// Token: 0x06004701 RID: 18177 RVA: 0x000AAA24 File Offset: 0x000A8C24
		public static global::NPOI.OpenXmlFormats.Shared.CT_OMath Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OMath ct_OMath = new global::NPOI.OpenXmlFormats.Shared.CT_OMath();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "del")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.del);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "acc")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Acc.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.acc);
				}
				else if (xmlNode.LocalName == "bar")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Bar.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.bar);
				}
				else if (xmlNode.LocalName == "borderBox")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_BorderBox.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.borderBox);
				}
				else if (xmlNode.LocalName == "box")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Box.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.box);
				}
				else if (xmlNode.LocalName == "d")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_D.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.d);
				}
				else if (xmlNode.LocalName == "eqArr")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_EqArr.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.eqArr);
				}
				else if (xmlNode.LocalName == "f")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_F.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.f);
				}
				else if (xmlNode.LocalName == "func")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Func.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.func);
				}
				else if (xmlNode.LocalName == "groupChr")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_GroupChr.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.groupChr);
				}
				else if (xmlNode.LocalName == "limLow")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_LimLow.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.limLow);
				}
				else if (xmlNode.LocalName == "limUpp")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_LimUpp.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.limUpp);
				}
				else if (xmlNode.LocalName == "m")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_M.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.m);
				}
				else if (xmlNode.LocalName == "nary")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Nary.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.nary);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.oMathPara);
				}
				else if (xmlNode.LocalName == "phant")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Phant.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.phant);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_R.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.r);
				}
				else if (xmlNode.LocalName == "rad")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Rad.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.rad);
				}
				else if (xmlNode.LocalName == "sPre")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SPre.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.sPre);
				}
				else if (xmlNode.LocalName == "sSub")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSub.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.sSub);
				}
				else if (xmlNode.LocalName == "sSubSup")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSubSup.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.sSubSup);
				}
				else if (xmlNode.LocalName == "sSup")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSup.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.sSup);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_OMath.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_OMath.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.proofErr);
				}
			}
			return ct_OMath;
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x000AB42C File Offset: 0x000A962C
		public global::NPOI.OpenXmlFormats.Shared.CT_Acc AddNewAcc()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_Acc ct_Acc = new global::NPOI.OpenXmlFormats.Shared.CT_Acc();
			lock (this)
			{
				this.itemsField.Add(ct_Acc);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.acc);
			}
			return ct_Acc;
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000AB484 File Offset: 0x000A9684
		public global::NPOI.OpenXmlFormats.Shared.CT_F AddNewF()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_F ct_F = new global::NPOI.OpenXmlFormats.Shared.CT_F();
			lock (this)
			{
				this.itemsField.Add(ct_F);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.f);
			}
			return ct_F;
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x000AB4DC File Offset: 0x000A96DC
		public global::NPOI.OpenXmlFormats.Shared.CT_Nary AddNewNary()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_Nary ct_Nary = new global::NPOI.OpenXmlFormats.Shared.CT_Nary();
			lock (this)
			{
				this.itemsField.Add(ct_Nary);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.nary);
			}
			return ct_Nary;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x000AB534 File Offset: 0x000A9734
		public global::NPOI.OpenXmlFormats.Shared.CT_R AddNewR()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_R ct_R = new global::NPOI.OpenXmlFormats.Shared.CT_R();
			lock (this)
			{
				this.itemsField.Add(ct_R);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.r);
			}
			return ct_R;
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x000AB58C File Offset: 0x000A978C
		public global::NPOI.OpenXmlFormats.Shared.CT_Rad AddNewRad()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_Rad ct_Rad = new global::NPOI.OpenXmlFormats.Shared.CT_Rad();
			lock (this)
			{
				this.itemsField.Add(ct_Rad);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.rad);
			}
			return ct_Rad;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x000AB5E4 File Offset: 0x000A97E4
		public global::NPOI.OpenXmlFormats.Shared.CT_SSub AddNewSSub()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_SSub ct_SSub = new global::NPOI.OpenXmlFormats.Shared.CT_SSub();
			lock (this)
			{
				this.itemsField.Add(ct_SSub);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.sSub);
			}
			return ct_SSub;
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x000AB63C File Offset: 0x000A983C
		public global::NPOI.OpenXmlFormats.Shared.CT_SSup AddNewSSup()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_SSup ct_SSup = new global::NPOI.OpenXmlFormats.Shared.CT_SSup();
			lock (this)
			{
				this.itemsField.Add(ct_SSup);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8.sSup);
			}
			return ct_SSup;
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x000AB694 File Offset: 0x000A9894
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Acc)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Acc)obj).Write(sw, "acc");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Bar)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Bar)obj).Write(sw, "bar");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_BorderBox)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_BorderBox)obj).Write(sw, "borderBox");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Box)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Box)obj).Write(sw, "box");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_D)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_D)obj).Write(sw, "d");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_EqArr)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_EqArr)obj).Write(sw, "eqArr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_F)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_F)obj).Write(sw, "f");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Func)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Func)obj).Write(sw, "func");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_GroupChr)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_GroupChr)obj).Write(sw, "groupChr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_LimLow)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_LimLow)obj).Write(sw, "limLow");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_LimUpp)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_LimUpp)obj).Write(sw, "limUpp");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_M)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_M)obj).Write(sw, "m");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Nary)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Nary)obj).Write(sw, "nary");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Phant)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Phant)obj).Write(sw, "phant");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_R)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_R)obj).Write(sw, "r");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Rad)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Rad)obj).Write(sw, "rad");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_SPre)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_SPre)obj).Write(sw, "sPre");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_SSub)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_SSub)obj).Write(sw, "sSub");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_SSubSup)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_SSubSup)obj).Write(sw, "sSubSup");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_SSup)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_SSup)obj).Write(sw, "sSup");
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
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x04002C48 RID: 11336
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04002C49 RID: 11337
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType8> itemsElementNameField;
	}
}
