using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.Extractor
{
	// Token: 0x020000EC RID: 236
	public class XSSFExportToXml : global::System.Collections.Generic.IComparer<string>
	{
		// Token: 0x06000EA1 RID: 3745 RVA: 0x00032A4E File Offset: 0x00030C4E
		public XSSFExportToXml(global::NPOI.XSSF.UserModel.XSSFMap map)
		{
			this.map = map;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00032A5D File Offset: 0x00030C5D
		public void ExportToXML(global::System.IO.Stream os, bool validate)
		{
			this.ExportToXML(os, "UTF-8", validate);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00032A6C File Offset: 0x00030C6C
		private global::System.Xml.XmlDocument GetEmptyDocument()
		{
			return new global::System.Xml.XmlDocument();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00032A74 File Offset: 0x00030C74
		public void ExportToXML(global::System.IO.Stream os, string encoding, bool validate)
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell> relatedSingleXMLCell = this.map.GetRelatedSingleXMLCell();
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.XSSFTable> relatedTables = this.map.GetRelatedTables();
			string rootElement = this.map.GetCTMap().RootElement;
			global::System.Xml.XmlDocument emptyDocument = this.GetEmptyDocument();
			global::System.Xml.XmlElement newChild;
			if (this.IsNamespaceDeclared())
			{
				newChild = emptyDocument.CreateElement(rootElement, this.GetNamespace());
			}
			else
			{
				newChild = emptyDocument.CreateElement(rootElement);
			}
			emptyDocument.AppendChild(newChild);
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell>();
			global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::NPOI.XSSF.UserModel.XSSFTable>();
			foreach (global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell xssfsingleXmlCell in relatedSingleXMLCell)
			{
				list.Add(xssfsingleXmlCell.GetXpath());
				dictionary[xssfsingleXmlCell.GetXpath()] = xssfsingleXmlCell;
			}
			foreach (global::NPOI.XSSF.UserModel.XSSFTable xssftable in relatedTables)
			{
				string commonXpath = xssftable.GetCommonXpath();
				list.Add(commonXpath);
				dictionary2[commonXpath] = xssftable;
			}
			list.Sort(this);
			foreach (string text in list)
			{
				global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell xssfsingleXmlCell2;
				if (dictionary.ContainsKey(text))
				{
					xssfsingleXmlCell2 = dictionary[text];
				}
				else
				{
					xssfsingleXmlCell2 = null;
				}
				global::NPOI.XSSF.UserModel.XSSFTable xssftable2;
				if (dictionary2.ContainsKey(text))
				{
					xssftable2 = dictionary2[text];
				}
				else
				{
					xssftable2 = null;
				}
				if (!global::System.Text.RegularExpressions.Regex.IsMatch(text, ".*\\[.*"))
				{
					if (xssfsingleXmlCell2 != null)
					{
						global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)xssfsingleXmlCell2.GetReferencedCell();
						if (xssfcell != null)
						{
							global::System.Xml.XmlNode nodeByXPath = this.GetNodeByXPath(text, emptyDocument.FirstChild, emptyDocument, false);
							global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType xmlDataType = xssfsingleXmlCell2.GetXmlDataType();
							this.mapCellOnNode(xssfcell, nodeByXPath, xmlDataType);
						}
					}
					if (xssftable2 != null)
					{
						global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr> xmlColumnPrs = xssftable2.GetXmlColumnPrs();
						global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = xssftable2.GetXSSFSheet();
						int num = xssftable2.StartCellReference.Row + 1;
						int row = xssftable2.EndCellReference.Row;
						for (int i = num; i <= row; i++)
						{
							global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)xssfsheet.GetRow(i);
							global::System.Xml.XmlNode nodeByXPath2 = this.GetNodeByXPath(xssftable2.GetCommonXpath(), emptyDocument.FirstChild, emptyDocument, true);
							short col = xssftable2.StartCellReference.Col;
							for (int j = (int)col; j <= (int)xssftable2.EndCellReference.Col; j++)
							{
								global::NPOI.XSSF.UserModel.XSSFCell xssfcell2 = (global::NPOI.XSSF.UserModel.XSSFCell)xssfrow.GetCell(j);
								if (xssfcell2 != null)
								{
									global::NPOI.XSSF.UserModel.Helpers.XSSFXmlColumnPr xssfxmlColumnPr = xmlColumnPrs[j - (int)col];
									string localXPath = xssfxmlColumnPr.GetLocalXPath();
									global::System.Xml.XmlNode nodeByXPath3 = this.GetNodeByXPath(localXPath, nodeByXPath2, emptyDocument, false);
									global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType xmlDataType2 = xssfxmlColumnPr.GetXmlDataType();
									this.mapCellOnNode(xssfcell2, nodeByXPath3, xmlDataType2);
								}
							}
						}
					}
				}
			}
			bool flag = true;
			if (validate)
			{
				flag = this.IsValid(emptyDocument);
			}
			if (flag)
			{
				using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(os, new global::System.Xml.XmlWriterSettings
				{
					Indent = true,
					Encoding = global::System.Text.Encoding.GetEncoding(encoding)
				}))
				{
					emptyDocument.WriteTo(xmlWriter);
				}
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00006FBA File Offset: 0x000051BA
		private bool IsValid(global::System.Xml.XmlDocument xml)
		{
			return true;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00032DD8 File Offset: 0x00030FD8
		private void mapCellOnNode(global::NPOI.XSSF.UserModel.XSSFCell cell, global::System.Xml.XmlNode node, global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType outputDataType)
		{
			string text = "";
			switch (cell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				text += cell.GetRawValue();
				break;
			case global::NPOI.SS.UserModel.CellType.String:
				text = cell.StringCellValue;
				break;
			case global::NPOI.SS.UserModel.CellType.Formula:
				text = cell.StringCellValue;
				break;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				text += cell.BooleanCellValue.ToString();
				break;
			case global::NPOI.SS.UserModel.CellType.Error:
				text = cell.ErrorCellString;
				break;
			}
			if (node is global::System.Xml.XmlElement)
			{
				((global::System.Xml.XmlElement)node).InnerText = text;
				return;
			}
			node.Value = text;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00032E6D File Offset: 0x0003106D
		private string RemoveNamespace(string elementName)
		{
			if (!global::System.Text.RegularExpressions.Regex.IsMatch(elementName, ".*:.*"))
			{
				return elementName;
			}
			return elementName.Split(new char[]
			{
				':'
			})[1];
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00032E94 File Offset: 0x00031094
		private global::System.Xml.XmlNode GetNodeByXPath(string xpath, global::System.Xml.XmlNode rootNode, global::System.Xml.XmlDocument doc, bool CreateMultipleInstances)
		{
			string[] array = xpath.Split(new char[]
			{
				'/'
			});
			global::System.Xml.XmlNode xmlNode = rootNode;
			for (int i = 2; i < array.Length; i++)
			{
				string text = this.RemoveNamespace(array[i]);
				if (!text.StartsWith("@"))
				{
					global::System.Xml.XmlNodeList childNodes = xmlNode.ChildNodes;
					global::System.Xml.XmlNode xmlNode2 = null;
					if (!CreateMultipleInstances || i != array.Length - 1)
					{
						xmlNode2 = this.selectNode(text, childNodes);
					}
					if (xmlNode2 == null)
					{
						xmlNode2 = this.CreateElement(doc, xmlNode, text);
					}
					xmlNode = xmlNode2;
				}
				else
				{
					xmlNode = this.CreateAttribute(doc, xmlNode, text);
				}
			}
			return xmlNode;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00032F1C File Offset: 0x0003111C
		private global::System.Xml.XmlNode CreateAttribute(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNode currentNode, string axisName)
		{
			string name = axisName.Substring(1);
			global::System.Xml.XmlAttributeCollection attributes = currentNode.Attributes;
			global::System.Xml.XmlNode xmlNode = attributes.GetNamedItem(name);
			if (xmlNode == null)
			{
				xmlNode = doc.CreateAttribute(name);
				attributes.SetNamedItem(xmlNode);
			}
			return xmlNode;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00032F54 File Offset: 0x00031154
		private global::System.Xml.XmlNode CreateElement(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNode currentNode, string axisName)
		{
			global::System.Xml.XmlNode xmlNode;
			if (this.IsNamespaceDeclared())
			{
				xmlNode = doc.CreateElement(axisName, this.GetNamespace());
			}
			else
			{
				xmlNode = doc.CreateElement(axisName);
			}
			currentNode.AppendChild(xmlNode);
			return xmlNode;
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00032F8C File Offset: 0x0003118C
		private global::System.Xml.XmlNode selectNode(string axisName, global::System.Xml.XmlNodeList list)
		{
			global::System.Xml.XmlNode result = null;
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Xml.XmlNode xmlNode = list[i];
				if (xmlNode.Name.Equals(axisName))
				{
					result = xmlNode;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00032FC8 File Offset: 0x000311C8
		private bool IsNamespaceDeclared()
		{
			string @namespace = this.GetNamespace();
			return @namespace != null && !@namespace.Equals("");
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00032FEF File Offset: 0x000311EF
		private string GetNamespace()
		{
			return this.map.GetCTSchema().Namespace;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00033004 File Offset: 0x00031204
		public int Compare(string leftXpath, string rightXpath)
		{
			int result = 0;
			string schema = this.map.GetSchema();
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(schema);
			string[] array = leftXpath.Split(new char[]
			{
				'/'
			});
			string[] array2 = rightXpath.Split(new char[]
			{
				'/'
			});
			int num = (array.Length < array2.Length) ? array.Length : array2.Length;
			global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement;
			for (int i = 1; i < num; i++)
			{
				string text = array[i];
				string text2 = array2[i];
				if (text.Equals(text2))
				{
					xmlNode = this.GetComplexTypeForElement(text, xmlDocument.DocumentElement, xmlNode);
				}
				else
				{
					int num2 = this.IndexOfElementInComplexType(text, xmlNode);
					int num3 = this.IndexOfElementInComplexType(text2, xmlNode);
					if (num2 != -1 && num3 != -1)
					{
						if (num2 < num3)
						{
							result = -1;
						}
						if (num2 > num3)
						{
							result = 1;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000330E0 File Offset: 0x000312E0
		private int IndexOfElementInComplexType(string elementName, global::System.Xml.XmlNode complexType)
		{
			global::System.Xml.XmlNodeList childNodes = complexType.ChildNodes;
			int result = -1;
			for (int i = 0; i < childNodes.Count; i++)
			{
				global::System.Xml.XmlNode xmlNode = childNodes[i];
				if (xmlNode is global::System.Xml.XmlElement && xmlNode.LocalName.Equals("element") && xmlNode.Attributes.GetNamedItem("name").Value.Equals(this.RemoveNamespace(elementName)))
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00033154 File Offset: 0x00031354
		private global::System.Xml.XmlNode GetComplexTypeForElement(string elementName, global::System.Xml.XmlNode xmlSchema, global::System.Xml.XmlNode localComplexTypeRootNode)
		{
			global::System.Xml.XmlNode xmlNode = null;
			string value = this.RemoveNamespace(elementName);
			global::System.Xml.XmlNodeList childNodes = localComplexTypeRootNode.ChildNodes;
			string value2 = "";
			for (int i = 0; i < childNodes.Count; i++)
			{
				global::System.Xml.XmlNode xmlNode2 = childNodes[i];
				if (xmlNode2 is global::System.Xml.XmlElement && xmlNode2.LocalName.Equals("element") && xmlNode2.Attributes.GetNamedItem("name").Value.Equals(value))
				{
					global::System.Xml.XmlNode namedItem = xmlNode2.Attributes.GetNamedItem("type");
					if (namedItem != null)
					{
						value2 = namedItem.Value;
						break;
					}
				}
			}
			if (!"".Equals(value2))
			{
				global::System.Xml.XmlNodeList childNodes2 = xmlSchema.ChildNodes;
				for (int j = 0; j < childNodes2.Count; j++)
				{
					global::System.Xml.XmlNode xmlNode3 = childNodes[j];
					if (xmlNode3 is global::System.Xml.XmlElement && xmlNode3.LocalName.Equals("complexType") && xmlNode3.Attributes.GetNamedItem("name").Value.Equals(value2))
					{
						global::System.Xml.XmlNodeList childNodes3 = xmlNode3.ChildNodes;
						for (int k = 0; k < childNodes3.Count; k++)
						{
							global::System.Xml.XmlNode xmlNode4 = childNodes3[k];
							if (xmlNode4 is global::System.Xml.XmlElement && xmlNode4.LocalName.Equals("sequence"))
							{
								xmlNode = xmlNode4;
								break;
							}
						}
						if (xmlNode != null)
						{
							break;
						}
					}
				}
			}
			return xmlNode;
		}

		// Token: 0x0400045B RID: 1115
		private global::NPOI.XSSF.UserModel.XSSFMap map;
	}
}
