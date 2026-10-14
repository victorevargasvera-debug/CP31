using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000652 RID: 1618
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OMathArg : global::NPOI.OpenXmlFormats.Shared.IOMathContainer
	{
		// Token: 0x06004575 RID: 17781 RVA: 0x000A582E File Offset: 0x000A3A2E
		public CT_OMathArg()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x000A584C File Offset: 0x000A3A4C
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x000A5854 File Offset: 0x000A3A54
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArgPr argPr
		{
			get
			{
				return this.argPrField;
			}
			set
			{
				this.argPrField = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x000A585D File Offset: 0x000A3A5D
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x000A5865 File Offset: 0x000A3A65
		[global::System.Xml.Serialization.XmlElement("acc", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Acc), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bar", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Bar), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("borderBox", typeof(global::NPOI.OpenXmlFormats.Shared.CT_BorderBox), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("box", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Box), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("d", typeof(global::NPOI.OpenXmlFormats.Shared.CT_D), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("eqArr", typeof(global::NPOI.OpenXmlFormats.Shared.CT_EqArr), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("f", typeof(global::NPOI.OpenXmlFormats.Shared.CT_F), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("func", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Func), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("groupChr", typeof(global::NPOI.OpenXmlFormats.Shared.CT_GroupChr), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("limLow", typeof(global::NPOI.OpenXmlFormats.Shared.CT_LimLow), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("limUpp", typeof(global::NPOI.OpenXmlFormats.Shared.CT_LimUpp), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("m", typeof(global::NPOI.OpenXmlFormats.Shared.CT_M), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("nary", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Nary), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("phant", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Phant), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("r", typeof(global::NPOI.OpenXmlFormats.Shared.CT_R), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("rad", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Rad), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sPre", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SPre), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sSub", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSub), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sSubSup", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSubSup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sSup", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 1)]
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

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x000A586E File Offset: 0x000A3A6E
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x000A5876 File Offset: 0x000A3A76
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7> ItemsElementName
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

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x000A587F File Offset: 0x000A3A7F
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x000A5887 File Offset: 0x000A3A87
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPr
		{
			get
			{
				return this.ctrlPrField;
			}
			set
			{
				this.ctrlPrField = value;
			}
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x000A5890 File Offset: 0x000A3A90
		public static global::NPOI.OpenXmlFormats.Shared.CT_OMathArg Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OMathArg ct_OMathArg = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "argPr")
				{
					ct_OMathArg.argPr = global::NPOI.OpenXmlFormats.Shared.CT_OMathArgPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "borderBox")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_BorderBox.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.borderBox);
				}
				else if (xmlNode.LocalName == "acc")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Acc.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.acc);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.proofErr);
				}
				else if (xmlNode.LocalName == "d")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_D.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.d);
				}
				else if (xmlNode.LocalName == "eqArr")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_EqArr.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.eqArr);
				}
				else if (xmlNode.LocalName == "f")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_F.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.f);
				}
				else if (xmlNode.LocalName == "func")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Func.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.func);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "groupChr")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_GroupChr.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.groupChr);
				}
				else if (xmlNode.LocalName == "limLow")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_LimLow.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.limLow);
				}
				else if (xmlNode.LocalName == "limUpp")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_LimUpp.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.limUpp);
				}
				else if (xmlNode.LocalName == "m")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_M.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.m);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.permStart);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.oMathPara);
				}
				else if (xmlNode.LocalName == "phant")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Phant.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.phant);
				}
				else if (xmlNode.LocalName == "bar")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Bar.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.bar);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_R.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.r);
				}
				else if (xmlNode.LocalName == "rad")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Rad.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.rad);
				}
				else if (xmlNode.LocalName == "sPre")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SPre.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.sPre);
				}
				else if (xmlNode.LocalName == "sSub")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSub.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.sSub);
				}
				else if (xmlNode.LocalName == "sSubSup")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSubSup.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.sSubSup);
				}
				else if (xmlNode.LocalName == "sSup")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSup.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.sSup);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.commentRangeStart);
				}
				else if (xmlNode.LocalName == "nary")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Nary.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.nary);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.ins);
				}
				else if (xmlNode.LocalName == "box")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Box.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.box);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_OMathArg.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_OMathArg.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.permEnd);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_OMathArg.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_OMathArg;
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x000A62E0 File Offset: 0x000A44E0
		public global::NPOI.OpenXmlFormats.Shared.CT_Acc AddNewAcc()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_Acc ct_Acc = new global::NPOI.OpenXmlFormats.Shared.CT_Acc();
			lock (this)
			{
				this.itemsField.Add(ct_Acc);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.acc);
			}
			return ct_Acc;
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x000A6338 File Offset: 0x000A4538
		public global::NPOI.OpenXmlFormats.Shared.CT_F AddNewF()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_F ct_F = new global::NPOI.OpenXmlFormats.Shared.CT_F();
			lock (this)
			{
				this.itemsField.Add(ct_F);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.f);
			}
			return ct_F;
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000A6390 File Offset: 0x000A4590
		public global::NPOI.OpenXmlFormats.Shared.CT_Nary AddNewNary()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_Nary ct_Nary = new global::NPOI.OpenXmlFormats.Shared.CT_Nary();
			lock (this)
			{
				this.itemsField.Add(ct_Nary);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.nary);
			}
			return ct_Nary;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x000A63E8 File Offset: 0x000A45E8
		public global::NPOI.OpenXmlFormats.Shared.CT_R AddNewR()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_R ct_R = new global::NPOI.OpenXmlFormats.Shared.CT_R();
			lock (this)
			{
				this.itemsField.Add(ct_R);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.r);
			}
			return ct_R;
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000A6440 File Offset: 0x000A4640
		public global::NPOI.OpenXmlFormats.Shared.CT_Rad AddNewRad()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_Rad ct_Rad = new global::NPOI.OpenXmlFormats.Shared.CT_Rad();
			lock (this)
			{
				this.itemsField.Add(ct_Rad);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.rad);
			}
			return ct_Rad;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x000A6498 File Offset: 0x000A4698
		public global::NPOI.OpenXmlFormats.Shared.CT_SSub AddNewSSub()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_SSub ct_SSub = new global::NPOI.OpenXmlFormats.Shared.CT_SSub();
			lock (this)
			{
				this.itemsField.Add(ct_SSub);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.sSub);
			}
			return ct_SSub;
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x000A64F0 File Offset: 0x000A46F0
		public global::NPOI.OpenXmlFormats.Shared.CT_SSup AddNewSSup()
		{
			global::NPOI.OpenXmlFormats.Shared.CT_SSup ct_SSup = new global::NPOI.OpenXmlFormats.Shared.CT_SSup();
			lock (this)
			{
				this.itemsField.Add(ct_SSup);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7.sSup);
			}
			return ct_SSup;
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x000A6548 File Offset: 0x000A4748
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.argPr != null)
			{
				this.argPr.Write(sw, "argPr");
			}
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_BorderBox)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_BorderBox)obj).Write(sw, "borderBox");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Acc)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Acc)obj).Write(sw, "acc");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj).Write(sw, "proofErr");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)obj).Write(sw, "permStart");
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
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Bar)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Bar)obj).Write(sw, "bar");
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
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Nary)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Nary)obj).Write(sw, "nary");
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
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Box)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Box)obj).Write(sw, "box");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)obj).Write(sw, "permEnd");
				}
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x04002B9A RID: 11162
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArgPr argPrField;

		// Token: 0x04002B9B RID: 11163
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04002B9C RID: 11164
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.ItemsChoiceType7> itemsElementNameField;

		// Token: 0x04002B9D RID: 11165
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
