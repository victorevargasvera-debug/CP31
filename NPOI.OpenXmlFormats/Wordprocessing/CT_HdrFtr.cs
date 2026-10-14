using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000116 RID: 278
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public class CT_HdrFtr
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x000187F8 File Offset: 0x000169F8
		public CT_HdrFtr()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00018818 File Offset: 0x00016A18
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr Parse(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HdrFtr ctObj, global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "p")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.p);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.proofErr);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.sdt);
				}
				else if (xmlNode.LocalName == "tbl")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.tbl);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.oMathPara);
				}
				else if (xmlNode.LocalName == "altChunk")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_AltChunk.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.altChunk);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlBlock.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXml);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ctObj.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ctObj.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.customXmlInsRangeEnd);
				}
			}
			return ctObj;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00018EE0 File Offset: 0x000170E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write(string.Format("<w:{0} ", nodeName));
			sw.Write("xmlns:wpc=\"http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas\" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" ");
			sw.Write("xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:wp14=\"http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing\" xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" ");
			sw.Write("xmlns:w10=\"urn:schemas-microsoft-com:office:word\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" ");
			sw.Write("xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\" xmlns:w15=\"http://schemas.microsoft.com/office/word/2012/wordml\" ");
			sw.Write("xmlns:wpg=\"http://schemas.microsoft.com/office/word/2010/wordprocessingGroup\" xmlns:wpi=\"http://schemas.microsoft.com/office/word/2010/wordprocessingInk\" xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\"");
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "customXmlMoveFromRangeEnd");
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
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00019338 File Offset: 0x00017538
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00019340 File Offset: 0x00017540
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00019349 File Offset: 0x00017549
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00019351 File Offset: 0x00017551
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8> ItemsElementName
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

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001935A File Offset: 0x0001755A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl GetTblArray(int i)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(i, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.tbl);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00019365 File Offset: 0x00017565
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl> GetTblList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.tbl);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001936F File Offset: 0x0001756F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P AddNewP()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.p);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00019379 File Offset: 0x00017579
		public void SetPArray(int i, global::NPOI.OpenXmlFormats.Wordprocessing.CT_P cT_P)
		{
			this.SetObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_P>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8.p, i, cT_P);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00019388 File Offset: 0x00017588
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type) where T : class
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

		// Token: 0x060007AA RID: 1962 RVA: 0x0001940C File Offset: 0x0001760C
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type)
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

		// Token: 0x060007AB RID: 1963 RVA: 0x00019474 File Offset: 0x00017674
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type) where T : class
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

		// Token: 0x060007AC RID: 1964 RVA: 0x000194E8 File Offset: 0x000176E8
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00019544 File Offset: 0x00017744
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type, int p, T obj) where T : class
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

		// Token: 0x060007AE RID: 1966 RVA: 0x000195F8 File Offset: 0x000177F8
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type, int p)
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

		// Token: 0x060007AF RID: 1967 RVA: 0x0001963C File Offset: 0x0001783C
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8 type, int p)
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

		// Token: 0x040006CE RID: 1742
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x040006CF RID: 1743
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType8> itemsElementNameField;
	}
}
