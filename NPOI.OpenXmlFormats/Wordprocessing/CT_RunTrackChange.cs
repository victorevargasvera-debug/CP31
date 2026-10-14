using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000143 RID: 323
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RunTrackChange : global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x0001E33A File Offset: 0x0001C53A
		public CT_RunTrackChange()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0001E358 File Offset: 0x0001C558
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange ct_RunTrackChange = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "func")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Func.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.func);
				}
				else if (xmlNode.LocalName == "sSubSup")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSubSup.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.sSubSup);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlInsRangeStart);
				}
				else if (xmlNode.LocalName == "acc")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Acc.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.acc);
				}
				else if (xmlNode.LocalName == "bar")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Bar.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.bar);
				}
				else if (xmlNode.LocalName == "borderBox")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_BorderBox.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.borderBox);
				}
				else if (xmlNode.LocalName == "box")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Box.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.box);
				}
				else if (xmlNode.LocalName == "d")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_D.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.d);
				}
				else if (xmlNode.LocalName == "eqArr")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_EqArr.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.eqArr);
				}
				else if (xmlNode.LocalName == "f")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_F.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.f);
				}
				else if (xmlNode.LocalName == "groupChr")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_GroupChr.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.groupChr);
				}
				else if (xmlNode.LocalName == "limLow")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_LimLow.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.limLow);
				}
				else if (xmlNode.LocalName == "m")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_M.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.m);
				}
				else if (xmlNode.LocalName == "nary")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Nary.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.nary);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.oMath);
				}
				else if (xmlNode.LocalName == "oMathPara")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.oMathPara);
				}
				else if (xmlNode.LocalName == "phant")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Phant.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.phant);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.r);
				}
				else if (xmlNode.LocalName == "rad")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_Rad.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.rad);
				}
				else if (xmlNode.LocalName == "sPre")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SPre.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.sPre);
				}
				else if (xmlNode.LocalName == "sSub")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSub.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.sSub);
				}
				else if (xmlNode.LocalName == "sSup")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_SSup.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.sSup);
				}
				else if (xmlNode.LocalName == "bookmarkEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.bookmarkEnd);
				}
				else if (xmlNode.LocalName == "bookmarkStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.bookmarkStart);
				}
				else if (xmlNode.LocalName == "commentRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.commentRangeEnd);
				}
				else if (xmlNode.LocalName == "commentRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.commentRangeStart);
				}
				else if (xmlNode.LocalName == "customXml")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXml);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlDelRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlDelRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlDelRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlInsRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlInsRangeEnd);
				}
				else if (xmlNode.LocalName == "limUpp")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Shared.CT_LimUpp.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.limUpp);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlMoveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveFromRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlMoveFromRangeStart);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlMoveToRangeEnd);
				}
				else if (xmlNode.LocalName == "customXmlMoveToRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.customXmlMoveToRangeStart);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.del);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.ins);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.moveFrom);
				}
				else if (xmlNode.LocalName == "moveFromRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.moveFromRangeEnd);
				}
				else if (xmlNode.LocalName == "moveFromRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.moveFromRangeStart);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.moveTo);
				}
				else if (xmlNode.LocalName == "moveToRangeEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.moveToRangeEnd);
				}
				else if (xmlNode.LocalName == "moveToRangeStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MoveBookmark.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.moveToRangeStart);
				}
				else if (xmlNode.LocalName == "permEnd")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Perm.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.permEnd);
				}
				else if (xmlNode.LocalName == "permStart")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PermStart.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.permStart);
				}
				else if (xmlNode.LocalName == "proofErr")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_ProofErr.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.proofErr);
				}
				else if (xmlNode.LocalName == "r")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_R.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.r);
				}
				else if (xmlNode.LocalName == "sdt")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.sdt);
				}
				else if (xmlNode.LocalName == "smartTag")
				{
					ct_RunTrackChange.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun.Parse(xmlNode, namespaceManager));
					ct_RunTrackChange.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.smartTag);
				}
			}
			return ct_RunTrackChange;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0001EE3C File Offset: 0x0001D03C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Shared.CT_Func)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_Func)obj).Write(sw, "func");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_SSubSup)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_SSubSup)obj).Write(sw, "sSubSup");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange)obj).Write(sw, "customXmlInsRangeStart");
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
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_GroupChr)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_GroupChr)obj).Write(sw, "groupChr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_LimLow)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_LimLow)obj).Write(sw, "limLow");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_R)obj).Write(sw, "r");
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
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun)obj).Write(sw, "customXml");
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
				else if (obj is global::NPOI.OpenXmlFormats.Shared.CT_LimUpp)
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_LimUpp)obj).Write(sw, "limUpp");
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
			}
			sw.Write(string.Format("</w:{0}", nodeName));
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0001F478 File Offset: 0x0001D678
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x0001F480 File Offset: 0x0001D680
		[global::System.Xml.Serialization.XmlElement("acc", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Acc), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bar", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Bar), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("borderBox", typeof(global::NPOI.OpenXmlFormats.Shared.CT_BorderBox), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("box", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Box), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("d", typeof(global::NPOI.OpenXmlFormats.Shared.CT_D), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("eqArr", typeof(global::NPOI.OpenXmlFormats.Shared.CT_EqArr), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("f", typeof(global::NPOI.OpenXmlFormats.Shared.CT_F), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("func", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Func), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("groupChr", typeof(global::NPOI.OpenXmlFormats.Shared.CT_GroupChr), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("limLow", typeof(global::NPOI.OpenXmlFormats.Shared.CT_LimLow), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("limUpp", typeof(global::NPOI.OpenXmlFormats.Shared.CT_LimUpp), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("m", typeof(global::NPOI.OpenXmlFormats.Shared.CT_M), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("nary", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Nary), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("oMath", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("oMathPara", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("phant", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Phant), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("r", typeof(global::NPOI.OpenXmlFormats.Shared.CT_R), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("rad", typeof(global::NPOI.OpenXmlFormats.Shared.CT_Rad), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sPre", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SPre), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sSub", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSub), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sSubSup", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSubSup), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sSup", typeof(global::NPOI.OpenXmlFormats.Shared.CT_SSup), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bookmarkStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Bookmark), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("commentRangeStart", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("customXml", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlRun), Order = 0)]
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
		[global::System.Xml.Serialization.XmlElement("sdt", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("smartTag", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SmartTagRun), Order = 0)]
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0001F489 File Offset: 0x0001D689
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x0001F491 File Offset: 0x0001D691
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6> ItemsElementName
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

		// Token: 0x060008C1 RID: 2241 RVA: 0x0001F49A File Offset: 0x0001D69A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange> GetInsList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_RunTrackChange>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.ins);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R> GetRList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_R>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6.r);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type) where T : class
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

		// Token: 0x060008C4 RID: 2244 RVA: 0x0001F534 File Offset: 0x0001D734
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type)
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

		// Token: 0x060008C5 RID: 2245 RVA: 0x0001F59C File Offset: 0x0001D79C
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type) where T : class
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

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001F610 File Offset: 0x0001D810
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type, int p) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				this.itemsElementNameField.Insert(objectIndex, type);
				this.itemsField.Insert(objectIndex, t);
			}
			return t;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001F674 File Offset: 0x0001D874
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type, int p, T obj) where T : class
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

		// Token: 0x060008C9 RID: 2249 RVA: 0x0001F784 File Offset: 0x0001D984
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type, int p)
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

		// Token: 0x060008CA RID: 2250 RVA: 0x0001F7C8 File Offset: 0x0001D9C8
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6 type, int p)
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

		// Token: 0x040007EE RID: 2030
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x040007EF RID: 2031
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType6> itemsElementNameField;
	}
}
