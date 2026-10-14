using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000135 RID: 309
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RubyContent
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x0001D31E File Offset: 0x0001B51E
		public CT_RubyContent()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0001D33C File Offset: 0x0001B53C
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0001D344 File Offset: 0x0001B544
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
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
		[global::System.Xml.Serialization.XmlElement("del", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ins", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFrom", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveTo", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("permEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("permStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("proofErr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("r", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R), Order = 0)]
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0001D34D File Offset: 0x0001B54D
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0001D355 File Offset: 0x0001B555
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16> ItemsElementName
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

		// Token: 0x06000896 RID: 2198 RVA: 0x0001D360 File Offset: 0x0001B560
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent ct_RubyContent = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "oMath")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.oMath);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.proofErr);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.permEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveTo);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveFrom);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.ins);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.commentRangeStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.bookmarkStart);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.oMathPara);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_RubyContent.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R.Parse(xmlNode, namespaceManager));
					ct_RubyContent.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.r);
				}
			}
			return ct_RubyContent;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0001D954 File Offset: 0x0001BB54
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			int num = 0;
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart)obj).Write(sw, "permStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj).Write(sw, "proofErr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm)obj).Write(sw, "permEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveToRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveTo)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveFrom)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveFrom");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.moveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlInsRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlInsRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlMoveToRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.del)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.ins)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlDelRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.customXmlDelRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.commentRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.commentRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16.bookmarkEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)obj).Write(sw, "r");
				}
				num++;
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x0400077F RID: 1919
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04000780 RID: 1920
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType16> itemsElementNameField;
	}
}
