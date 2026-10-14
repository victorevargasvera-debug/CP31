using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000072 RID: 114
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Body
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00009E17 File Offset: 0x00008017
		public CT_Body()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00009E38 File Offset: 0x00008038
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body ct_Body = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Body();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "moveTo")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveTo);
				}
				else if (xmlNode.LocalName == "sectPr")
				{
					ct_Body.sectPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.oMathPara);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXml);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.oMath);
				}
				else if (xmlNode.LocalName == "altChunk")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.altChunk);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "p")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.p);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.proofErr);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.sdt);
				}
				else if (xmlNode.LocalName == "tbl")
				{
					ct_Body.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl.Parse(xmlNode, namespaceManager));
					ct_Body.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl);
				}
			}
			return ct_Body;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000A52C File Offset: 0x0000872C
		public int SizeOfPArray()
		{
			return this.itemsElementNameField.Count((global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType p) => p == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.p);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000A558 File Offset: 0x00008758
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			int num = 0;
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveTo)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveTo");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMathPara)obj).Write(sw, "oMathPara");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock)obj).Write(sw, "customXml");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_OMath)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OMath)obj).Write(sw, "oMath");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk)obj).Write(sw, "altChunk");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.bookmarkEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "bookmarkEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.bookmarkStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark)obj).Write(sw, "bookmarkStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.commentRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.commentRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "commentRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlDelRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlDelRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlDelRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlDelRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlInsRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlInsRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlInsRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.customXmlMoveToRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlMoveToRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.del)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "del");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.ins)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "ins");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveFrom)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange)obj).Write(sw, "moveFrom");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveFromRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveFromRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveFromRangeStart)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark)obj).Write(sw, "moveFromRangeStart");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveToRangeEnd)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange)obj).Write(sw, "moveToRangeEnd");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark && this.itemsElementNameField[num] == global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.moveToRangeStart)
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj).Write(sw, "tbl");
				}
				num++;
			}
			if (this.sectPr != null)
			{
				this.sectPr.Write(sw, "sectPr");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public void AddNewSectPr()
		{
			this.sectPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000AAC1 File Offset: 0x00008CC1
		public bool IsSetSectPr()
		{
			return this.sectPrField != null;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000AACC File Offset: 0x00008CCC
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0000AAD4 File Offset: 0x00008CD4
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
		[global::System.Xml.Serialization.XmlElement("del", Type = typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ins", Type = typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange), Order = 0)]
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

		// Token: 0x06000353 RID: 851 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P AddNewP()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_P ct_P = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_P();
			lock (this)
			{
				this.itemsField.Add(ct_P);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.p);
			}
			return ct_P;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000AB38 File Offset: 0x00008D38
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000AB40 File Offset: 0x00008D40
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType> ItemsElementName
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000AB49 File Offset: 0x00008D49
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000AB51 File Offset: 0x00008D51
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr sectPr
		{
			get
			{
				return this.sectPrField;
			}
			set
			{
				this.sectPrField = value;
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000AB5C File Offset: 0x00008D5C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl AddNewTbl()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ct_Tbl = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl();
			lock (this)
			{
				this.itemsField.Add(ct_Tbl);
				this.itemsElementNameField.Add(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl);
			}
			return ct_Tbl;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		public int sizeOfTblArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000ABBE File Offset: 0x00008DBE
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl> getTblArray()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl insertNewTbl(int paramInt)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000024E5 File Offset: 0x000006E5
		public void removeTbl(int paramInt)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl GetTblArray(int i)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(i, global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000ABD3 File Offset: 0x00008DD3
		public void SetTblArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl cT_Tbl)
		{
			this.SetObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl, pos, cT_Tbl);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000ABDF File Offset: 0x00008DDF
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl[] GetTblArray()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl).ToArray();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000ABEE File Offset: 0x00008DEE
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P GetPArray(int p)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(p, global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.p);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000ABF9 File Offset: 0x00008DF9
		public void RemoveP(int paraPos)
		{
			this.RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.p, paraPos);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000AC04 File Offset: 0x00008E04
		public void RemoveTbl(int tablePos)
		{
			this.RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.tbl, tablePos);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000AC0F File Offset: 0x00008E0F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock AddNewSdt()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.sdt);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000AC1C File Offset: 0x00008E1C
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type) where T : class
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

		// Token: 0x06000365 RID: 869 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type)
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

		// Token: 0x06000366 RID: 870 RVA: 0x0000AD08 File Offset: 0x00008F08
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type) where T : class
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

		// Token: 0x06000367 RID: 871 RVA: 0x0000AD7C File Offset: 0x00008F7C
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type, int p, T obj) where T : class
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

		// Token: 0x06000369 RID: 873 RVA: 0x0000AE8C File Offset: 0x0000908C
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type, int p)
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

		// Token: 0x0600036A RID: 874 RVA: 0x0000AED0 File Offset: 0x000090D0
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType type, int p)
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

		// Token: 0x0600036B RID: 875 RVA: 0x0000AF3C File Offset: 0x0000913C
		public void SetPArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_P cT_P)
		{
			this.SetObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType.p, pos, cT_P);
		}

		// Token: 0x040002DF RID: 735
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x040002E0 RID: 736
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.DocumentBodyItemChoiceType> itemsElementNameField;

		// Token: 0x040002E1 RID: 737
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr sectPrField;
	}
}
