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
	// Token: 0x02000065 RID: 101
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomXmlRun
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00006C5C File Offset: 0x00004E5C
		public CT_CustomXmlRun()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00006C7A File Offset: 0x00004E7A
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00006C82 File Offset: 0x00004E82
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00006C8B File Offset: 0x00004E8B
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00006C93 File Offset: 0x00004E93
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00006C9C File Offset: 0x00004E9C
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24> ItemsElementName
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00006CAD File Offset: 0x00004EAD
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00006CB5 File Offset: 0x00004EB5
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00006CBE File Offset: 0x00004EBE
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00006CC6 File Offset: 0x00004EC6
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

		// Token: 0x06000313 RID: 787 RVA: 0x00006CD0 File Offset: 0x00004ED0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun ct_CustomXmlRun = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun();
			ct_CustomXmlRun.uri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:uri"]);
			ct_CustomXmlRun.element = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:element"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.bookmarkStart);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.moveTo);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.oMath);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.del);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "fldSimple")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.fldSimple);
				}
				else if (xmlNode.LocalName == "hyperlink")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.hyperlink);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.customXml);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.permStart);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.r);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.sdt);
				}
				else if (xmlNode.LocalName == "smartTag")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.smartTag);
				}
				else if (xmlNode.LocalName == "subDoc")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.subDoc);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.proofErr);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.commentRangeStart);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_CustomXmlRun.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_CustomXmlRun.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24.oMathPara);
				}
			}
			return ct_CustomXmlRun;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00007444 File Offset: 0x00005644
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:uri", this.uri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:element", this.element);
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
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
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField)obj).Write(sw, "fldSimple");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1)obj).Write(sw, "hyperlink");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun)obj).Write(sw, "customXml");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr)obj).Write(sw, "proofErr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x0400022D RID: 557
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr customXmlPrField;

		// Token: 0x0400022E RID: 558
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x0400022F RID: 559
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType24> itemsElementNameField;

		// Token: 0x04000230 RID: 560
		private string uriField;

		// Token: 0x04000231 RID: 561
		private string elementField;
	}
}
