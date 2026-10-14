using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Xml;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000093 RID: 147
	internal class CustomizationsManager
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x0001BDA7 File Offset: 0x00019FA7
		internal CustomizationsManager(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			this._dataPresenter = dataPresenter;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001BDC5 File Offset: 0x00019FC5
		internal bool AreCustomizationsLoaded
		{
			get
			{
				return this._currentLoadedDocument != null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001BDD3 File Offset: 0x00019FD3
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo> FieldLayoutCustomizationInfos
		{
			get
			{
				if (this._fieldLayoutCustomizationInfos == null)
				{
					this._fieldLayoutCustomizationInfos = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo>(3);
				}
				return this._fieldLayoutCustomizationInfos;
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001BDF0 File Offset: 0x00019FF0
		internal bool ApplyCustomizations()
		{
			if (!this.AreCustomizationsLoaded)
			{
				return false;
			}
			if (this._allLoadedCustomizationsApplied)
			{
				return true;
			}
			if (this._dataPresenter.IsApplyingCustomizations)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_LoadCustomizationInProgress"));
			}
			this._dataPresenter.IsApplyingCustomizations = true;
			int num = 0;
			try
			{
				global::System.Xml.XmlNode xmlNode = this._currentLoadedDocument.SelectSingleNode("xamDataPresenter");
				if (xmlNode == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidCustomizationRootElement"));
				}
				new global::System.Version(xmlNode.Attributes["version"].Value);
				this._formatVersion = global::Infragistics.Windows.DataPresenter.CustomizationsManager.GetFormatVersion(xmlNode, 1.0);
				this._dataPresenter.OnBeforeApplyCustomizations();
				global::System.Xml.XmlNode xmlNode2 = xmlNode.SelectSingleNode("fieldLayouts");
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Xml.XmlNode> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Xml.XmlNode>();
				foreach (object obj in xmlNode2.SelectNodes("fieldLayout"))
				{
					global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)obj;
					string attribute = global::Infragistics.Windows.DataPresenter.GridUtilities.GetAttribute(xmlNode3, "fieldList");
					double formatVersion = global::Infragistics.Windows.DataPresenter.CustomizationsManager.GetFormatVersion(xmlNode3, this._formatVersion);
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] fieldList = (attribute != null) ? this.ParseFieldList(attribute) : null;
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutDescription = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription(this, global::Infragistics.Windows.DataPresenter.GridUtilities.GetAttribute(xmlNode3, "key"), fieldList, formatVersion);
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo fieldLayoutCustomizationInfo = this.GetFieldLayoutCustomizationInfo(fieldLayoutDescription, true);
					if (!fieldLayoutCustomizationInfo._customizationsApplied && fieldLayoutCustomizationInfo._fieldLayoutNode == null)
					{
						fieldLayoutCustomizationInfo._fieldLayoutNode = xmlNode3;
						fieldLayoutCustomizationInfo._nodeFormatVersion = formatVersion;
						string attribute2 = global::Infragistics.Windows.DataPresenter.GridUtilities.GetAttribute(xmlNode3, "ExcludeCustomizationsAttrib");
						global::Infragistics.Windows.DataPresenter.CustomizationType excludeCustomizations = global::Infragistics.Windows.DataPresenter.GridUtilities.ParseFlaggedEnumFromString<global::Infragistics.Windows.DataPresenter.CustomizationType>(attribute2, ", ");
						fieldLayoutCustomizationInfo._excludeCustomizations = excludeCustomizations;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout loadedFieldLayoutThatMatchesKey = this.GetLoadedFieldLayoutThatMatchesKey(fieldLayoutDescription);
					if (loadedFieldLayoutThatMatchesKey != null && loadedFieldLayoutThatMatchesKey.IsInitialized)
					{
						if (loadedFieldLayoutThatMatchesKey.ParentFieldLayoutKey == null)
						{
							global::System.Xml.XmlNode xmlNode4 = xmlNode3.SelectSingleNode("parentFieldLayout");
							if (xmlNode4 != null)
							{
								if (global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode4, "fieldList", null) == null)
								{
									string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode4, "key", null);
									if (text != null && text.Length > 0)
									{
										loadedFieldLayoutThatMatchesKey.ParentFieldLayoutKey = text;
									}
								}
								else if (!dictionary.ContainsKey(loadedFieldLayoutThatMatchesKey))
								{
									dictionary.Add(loadedFieldLayoutThatMatchesKey, xmlNode4);
								}
							}
						}
						if (!this.HasCustomizationsBeenAppliedToFieldLayout(fieldLayoutDescription))
						{
							string text2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode3, "parentFieldName", null);
							if (text2 != null && text2.Length > 0)
							{
								loadedFieldLayoutThatMatchesKey.ParentFieldName = text2;
							}
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription>();
							global::System.Xml.XmlNode xmlNode5 = xmlNode3.SelectSingleNode("sortedFields");
							if (xmlNode5 != null && !fieldLayoutCustomizationInfo.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.GroupingAndSorting))
							{
								foreach (object obj2 in xmlNode5.SelectNodes("sortedField"))
								{
									global::System.Xml.XmlNode node = (global::System.Xml.XmlNode)obj2;
									string fieldName = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, "fieldName", null);
									string extendedInfo = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, "extendedInfo", null);
									global::Infragistics.Windows.DataPresenter.Field matchingField = this.GetMatchingField(loadedFieldLayoutThatMatchesKey, fieldLayoutDescription, fieldName, extendedInfo);
									if (matchingField != null)
									{
										global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = new global::Infragistics.Windows.DataPresenter.FieldSortDescription();
										fieldSortDescription.Direction = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadEnumAttribute<global::System.ComponentModel.ListSortDirection>(node, "direction", global::System.ComponentModel.ListSortDirection.Ascending);
										fieldSortDescription.FieldName = fieldName;
										fieldSortDescription.IsGroupBy = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, "isGroupBy", false);
										if (matchingField != null)
										{
											fieldSortDescription.Field = matchingField;
										}
										list.Add(fieldSortDescription);
									}
									else
									{
										num++;
									}
								}
							}
							global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = loadedFieldLayoutThatMatchesKey.SortedFields;
							if (!global::Infragistics.Windows.DataPresenter.GridUtilities.IsSameSortCriteria(list, sortedFields))
							{
								sortedFields.BeginUpdate();
								sortedFields.Clear();
								sortedFields.AddRange(list);
								sortedFields.EndUpdate();
							}
							global::System.Xml.XmlNode xmlNode6 = xmlNode3.SelectSingleNode("fields");
							if (xmlNode6 != null)
							{
								global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = null;
								foreach (object obj3 in xmlNode6.SelectNodes("field"))
								{
									global::System.Xml.XmlNode xmlNode7 = (global::System.Xml.XmlNode)obj3;
									string fieldName2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "name", loadedFieldLayoutThatMatchesKey.Fields[0].Name);
									bool flag = fieldLayoutCustomizationInfo.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.FieldPosition);
									string extendedInfo2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "extendedInfo", null);
									global::Infragistics.Windows.DataPresenter.Field matchingField2 = this.GetMatchingField(loadedFieldLayoutThatMatchesKey, fieldLayoutDescription, fieldName2, extendedInfo2);
									if (matchingField2 != null)
									{
										global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = flag ? global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable : global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadEnumAttribute<global::Infragistics.Windows.DataPresenter.FixedFieldLocation>(xmlNode7, "FixedLocation", global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
										this.InitializeResizeInfo(xmlNode7, matchingField2, fieldLayoutCustomizationInfo);
										if (this._formatVersion >= 1.2)
										{
											matchingField2.Visibility = (flag ? global::System.Windows.Visibility.Visible : global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadEnumAttribute<global::System.Windows.Visibility>(xmlNode7, "Visibility", global::System.Windows.Visibility.Visible));
											matchingField2.IgnoreFieldVisibilityOverrides = (!flag && global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "IgnoreFieldVisibilityOverrides", false));
										}
										int num2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "row", -1);
										int num3 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "column", -1);
										int num4 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "rowSpan", 0);
										int num5 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "columnSpan", 0);
										if (num2 >= 0 && num3 >= 0 && num4 > 0 && num5 > 0 && !flag)
										{
											global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(num3, num2, num5, num4);
											if (this._formatVersion >= 1.2)
											{
												itemLayoutInfo.IsCollapsed = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "isCollapsedInLayout", false);
											}
											itemLayoutInfo._fixedLocation = fixedLocation;
											if (layoutInfo == null)
											{
												layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(loadedFieldLayoutThatMatchesKey);
											}
											layoutInfo[matchingField2] = itemLayoutInfo;
										}
										matchingField2.FixedLocation = fixedLocation;
									}
									else
									{
										num++;
									}
								}
								loadedFieldLayoutThatMatchesKey.SetFieldLayoutInfo(layoutInfo, false, false);
							}
							global::System.Xml.XmlNode filtersNode = xmlNode3.SelectSingleNode("recordFilters");
							this.LoadRecordFilters(loadedFieldLayoutThatMatchesKey, filtersNode, fieldLayoutCustomizationInfo);
							if (this._formatVersion >= 1.4)
							{
								this.LoadSummaries(loadedFieldLayoutThatMatchesKey, xmlNode3.SelectSingleNode("summaries"), fieldLayoutCustomizationInfo);
							}
							this.MarkFieldSizeAndPositionAsApplied(fieldLayoutDescription);
							this._dataPresenter.History.OnCustomizationsChanged(loadedFieldLayoutThatMatchesKey, global::Infragistics.Windows.DataPresenter.CustomizationType.All);
						}
						else
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Xml.XmlNode> keyValuePair in dictionary)
				{
					global::System.Xml.XmlNode value = keyValuePair.Value;
					global::Infragistics.Windows.DataPresenter.FieldLayout key = keyValuePair.Key;
					string text3 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(value, "fieldList", null);
					string key2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(value, "key", null);
					double formatVersion2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.GetFormatVersion(value, this._formatVersion);
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] fieldList2 = (text3 != null) ? this.ParseFieldList(text3) : null;
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription key3 = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription(this, key2, fieldList2, formatVersion2);
					global::Infragistics.Windows.DataPresenter.FieldLayout loadedFieldLayoutThatMatchesKey2 = this.GetLoadedFieldLayoutThatMatchesKey(key3);
					if (loadedFieldLayoutThatMatchesKey2 != null && loadedFieldLayoutThatMatchesKey2.Key != null)
					{
						global::Infragistics.Windows.DataPresenter.Field parentField = null;
						string parentFieldName = key.ParentFieldName;
						if (parentFieldName != null && parentFieldName.Length > 0)
						{
							int num6 = loadedFieldLayoutThatMatchesKey2.Fields.IndexOf(parentFieldName);
							if (num6 >= 0)
							{
								parentField = loadedFieldLayoutThatMatchesKey2.Fields[num6];
							}
						}
						key.InitializeParentInfo(loadedFieldLayoutThatMatchesKey2, parentField);
					}
				}
				global::System.Xml.XmlNode xmlNode8 = xmlNode.SelectSingleNode("CardViewSettings");
				if (xmlNode8 != null)
				{
					global::Infragistics.Windows.DataPresenter.CardView cardView = this._dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.CardView;
					if (cardView != null)
					{
						global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = cardView.ViewSettings;
						if (viewSettings != null)
						{
							double num7 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode8, "CardWidth", double.NaN);
							if (!double.IsNaN(num7))
							{
								viewSettings.CardWidth = num7;
							}
							num7 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode8, "CardHeight", double.NaN);
							if (!double.IsNaN(num7))
							{
								viewSettings.CardHeight = num7;
							}
						}
					}
				}
			}
			finally
			{
				this._dataPresenter.IsApplyingCustomizations = false;
				this._dataPresenter.OnAfterApplyCustomizations();
				this._allLoadedCustomizationsApplied = (num == 0);
			}
			return true;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0001C5D4 File Offset: 0x0001A7D4
		public void ClearCustomizations(global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayoutsIfAllocated = this._dataPresenter.FieldLayoutsIfAllocated;
			if (fieldLayoutsIfAllocated != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in fieldLayoutsIfAllocated)
				{
					this.ClearCustomizations(fieldLayout, customizations);
				}
			}
			if (this._fieldLayoutCustomizationInfos != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo> keyValuePair in this._fieldLayoutCustomizationInfos)
				{
					keyValuePair.Value._excludeCustomizations |= customizations;
				}
			}
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.CardViewSettings & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				global::Infragistics.Windows.DataPresenter.CardView cardView = this._dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.CardView;
				if (cardView != null)
				{
					global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = cardView.ViewSettings;
					if (viewSettings != null)
					{
						viewSettings.CardWidth = double.NaN;
						viewSettings.CardHeight = double.NaN;
					}
				}
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
		public void ClearCustomizations(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			fieldLayout.ClearCustomizations(customizations);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		public void LoadCustomizations(string customizations)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
				streamWriter.Write(customizations);
				streamWriter.Flush();
				memoryStream.Position = 0L;
				this.LoadCustomizations(memoryStream);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001C730 File Offset: 0x0001A930
		public void LoadCustomizations(global::System.IO.Stream stream)
		{
			using (global::System.IO.BufferedStream bufferedStream = new global::System.IO.BufferedStream(stream))
			{
				this._currentLoadedDocument = new global::System.Xml.XmlDocument();
				this._currentLoadedDocument.Load(bufferedStream);
			}
			this._fieldLayoutCustomizationInfos = null;
			this._allLoadedCustomizationsApplied = false;
			this.ApplyCustomizations();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001C78C File Offset: 0x0001A98C
		public string SaveCustomizations()
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				this.SaveCustomizations(memoryStream);
				memoryStream.Position = 0L;
				global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream);
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001C7DC File Offset: 0x0001A9DC
		public void SaveCustomizations(global::System.IO.Stream stream)
		{
			global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(stream, global::System.Text.Encoding.UTF8);
			xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
			this._formatVersion = 1.6;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("xamDataPresenter");
			xmlTextWriter.WriteAttributeString("version", "12.1.20121.2107");
			xmlTextWriter.WriteAttributeString("formatVersion", this._formatVersion.ToString());
			xmlTextWriter.WriteStartElement("fieldLayouts");
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._dataPresenter.FieldLayouts)
			{
				if (fieldLayout.IsInitialized)
				{
					this.WriteFieldLayoutStartTag(xmlTextWriter, fieldLayout);
					this.WriteParentFieldLayoutTag(xmlTextWriter, fieldLayout);
					if (fieldLayout.SortedFields.Count > 0)
					{
						xmlTextWriter.WriteStartElement("sortedFields");
						foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in fieldLayout.SortedFields)
						{
							xmlTextWriter.WriteStartElement("sortedField");
							global::Infragistics.Windows.DataPresenter.Field field = fieldSortDescription.Field;
							if (field != null)
							{
								xmlTextWriter.WriteAttributeString("extendedInfo", new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription(this, field).ToString());
							}
							global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "direction", fieldSortDescription.Direction);
							xmlTextWriter.WriteAttributeString("fieldName", fieldSortDescription.FieldName);
							global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "isGroupBy", fieldSortDescription.IsGroupBy);
							xmlTextWriter.WriteEndElement();
						}
						xmlTextWriter.WriteEndElement();
					}
					if (fieldLayout.Fields.Count > 0)
					{
						xmlTextWriter.WriteStartElement("fields");
						for (int i = 0; i < fieldLayout.Fields.Count; i++)
						{
							global::Infragistics.Windows.DataPresenter.Field field2 = fieldLayout.Fields[i];
							xmlTextWriter.WriteStartElement("field");
							xmlTextWriter.WriteAttributeString("name", field2.Name);
							xmlTextWriter.WriteAttributeString("extendedInfo", new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription(this, field2).ToString());
							global::Infragistics.Windows.DataPresenter.FixedFieldLocation actualFixedLocation = field2.ActualFixedLocation;
							if (actualFixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
							{
								global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "FixedLocation", actualFixedLocation);
							}
							global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfoIfAllocated = field2.ExplicitResizeInfoIfAllocated;
							if (explicitResizeInfoIfAllocated != null)
							{
								global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(xmlTextWriter, explicitResizeInfoIfAllocated);
							}
							if (this._formatVersion >= 1.2)
							{
								global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "Visibility", field2.Visibility);
								global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "IgnoreFieldVisibilityOverrides", field2.IgnoreFieldVisibilityOverrides);
							}
							global::Infragistics.Windows.DataPresenter.LayoutInfo fieldLayoutInfo = fieldLayout.GetFieldLayoutInfo(false, false);
							if (fieldLayoutInfo != null)
							{
								global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
								fieldLayoutInfo.TryGetValue(field2, out itemLayoutInfo);
								if (itemLayoutInfo != null)
								{
									global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "row", itemLayoutInfo.Row);
									global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "column", itemLayoutInfo.Column);
									global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "rowSpan", itemLayoutInfo.RowSpan);
									global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "columnSpan", itemLayoutInfo.ColumnSpan);
									if (this._formatVersion >= 1.2)
									{
										global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "isCollapsedInLayout", itemLayoutInfo.IsCollapsed);
									}
								}
							}
							xmlTextWriter.WriteEndElement();
						}
						xmlTextWriter.WriteEndElement();
					}
					this.SaveRecordFilters(xmlTextWriter, fieldLayout);
					if (this._formatVersion >= 1.4)
					{
						this.SaveSummaries(xmlTextWriter, fieldLayout);
					}
					xmlTextWriter.WriteEndElement();
				}
			}
			if (this._fieldLayoutCustomizationInfos != null && this._currentLoadedDocument != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo> keyValuePair in this._fieldLayoutCustomizationInfos)
				{
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo value = keyValuePair.Value;
					if (!value._customizationsApplied && value._fieldLayoutNode != null && global::Infragistics.Windows.DataPresenter.CustomizationType.All != (global::Infragistics.Windows.DataPresenter.CustomizationType.All & value._excludeCustomizations))
					{
						global::System.Xml.XmlNode fieldLayoutNode = value._fieldLayoutNode;
						fieldLayoutNode.Attributes.RemoveNamedItem("ExcludeCustomizationsAttrib");
						fieldLayoutNode.Attributes.RemoveNamedItem("formatVersion");
						if (value._excludeCustomizations != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
						{
							global::System.Xml.XmlAttribute xmlAttribute = this._currentLoadedDocument.CreateAttribute("ExcludeCustomizationsAttrib");
							xmlAttribute.Value = global::Infragistics.Windows.DataPresenter.GridUtilities.ToStringFromFlaggedEnum(value._excludeCustomizations, ", ");
							fieldLayoutNode.Attributes.Append(xmlAttribute);
						}
						if (value._nodeFormatVersion != this._formatVersion)
						{
							global::System.Xml.XmlAttribute xmlAttribute2 = this._currentLoadedDocument.CreateAttribute("formatVersion");
							xmlAttribute2.Value = value._nodeFormatVersion.ToString();
							fieldLayoutNode.Attributes.Append(xmlAttribute2);
						}
						fieldLayoutNode.WriteTo(xmlTextWriter);
					}
				}
			}
			xmlTextWriter.WriteEndElement();
			global::Infragistics.Windows.DataPresenter.CardView cardView = this._dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.CardView;
			if (cardView != null)
			{
				global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = cardView.ViewSettings;
				if (viewSettings != null && (!double.IsNaN(viewSettings.CardWidth) || !double.IsNaN(viewSettings.CardHeight)))
				{
					xmlTextWriter.WriteStartElement("CardViewSettings");
					if (!double.IsNaN(viewSettings.CardWidth))
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "CardWidth", viewSettings.CardWidth);
					}
					if (!double.IsNaN(viewSettings.CardHeight))
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(xmlTextWriter, "CardHeight", viewSettings.CardHeight);
					}
					xmlTextWriter.WriteEndElement();
				}
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Flush();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001CD40 File Offset: 0x0001AF40
		private static string ConstructFieldLayoutUniqueKey(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[");
			stringBuilder.Append(fieldLayout.DataPresenter.FieldLayouts.IndexOf(fieldLayout).ToString());
			stringBuilder.Append("]");
			for (int i = 0; i < fieldLayout.Fields.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fieldLayout.Fields[i];
				if (!string.IsNullOrEmpty(field.Name))
				{
					stringBuilder.Append(field.Name);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		private string ConstructFieldList(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = fl.Fields;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			int i = 0;
			int count = fields.Count;
			while (i < count)
			{
				list.Add(new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription(this, fields[i]).ToString());
				i++;
			}
			return global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldListPraser.ConstructList(list.ToArray(), true);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0001CE26 File Offset: 0x0001B026
		private static global::Infragistics.Windows.DataPresenter.Parser_ListOfItems FieldListPraser
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.CustomizationsManager.g_parser_ListOfItems == null)
				{
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.g_parser_ListOfItems = new global::Infragistics.Windows.DataPresenter.Parser_ListOfItems('"', '"', '\\', ',');
				}
				return global::Infragistics.Windows.DataPresenter.CustomizationsManager.g_parser_ListOfItems;
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001CE48 File Offset: 0x0001B048
		private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] ParseFieldList(string fieldList)
		{
			if (fieldList == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription>();
			string[] array = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldListPraser.ParseList(fieldList, false);
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.Parse(this, array[i]);
					if (fieldDescription != null)
					{
						list.Add(fieldDescription);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001CE98 File Offset: 0x0001B098
		private static bool DoesFieldExistInFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string fieldName)
		{
			return fieldLayout.Fields.IndexOf(fieldName) > -1;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo GetFieldLayoutCustomizationInfo(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutKey, bool allocateIfNecessary)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo fieldLayoutCustomizationInfo;
			this.FieldLayoutCustomizationInfos.TryGetValue(fieldLayoutKey, out fieldLayoutCustomizationInfo);
			if (fieldLayoutCustomizationInfo == null)
			{
				fieldLayoutCustomizationInfo = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo(fieldLayoutKey);
				this.FieldLayoutCustomizationInfos.Add(fieldLayoutKey, fieldLayoutCustomizationInfo);
			}
			return fieldLayoutCustomizationInfo;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001CEE0 File Offset: 0x0001B0E0
		private string GetFieldLayoutKey(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, double formatVersion)
		{
			string text = null;
			object key = fieldLayout.Key;
			if (key != null)
			{
				if (key is global::System.ComponentModel.ITypedList && formatVersion >= 1.1)
				{
					text = ((global::System.ComponentModel.ITypedList)key).GetListName(null);
				}
				else if (key is global::System.Type)
				{
					text = ((global::System.Type)key).Name;
				}
				else if (key.GetType() == typeof(global::System.Xml.XmlElement))
				{
					text = ((global::System.Xml.XmlElement)key).Name;
				}
				else if (global::System.ComponentModel.TypeDescriptor.GetConverter(key).CanConvertTo(typeof(string)))
				{
					text = global::System.Convert.ToString(key);
				}
			}
			if (text == null)
			{
				if (formatVersion >= 1.1)
				{
					text = string.Empty;
				}
				else
				{
					text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ConstructFieldLayoutUniqueKey(fieldLayout);
				}
			}
			return text;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001CF94 File Offset: 0x0001B194
		internal static double GetFormatVersion(global::System.Xml.XmlNode node, double defaultVersion)
		{
			string attribute = global::Infragistics.Windows.DataPresenter.GridUtilities.GetAttribute(node, "formatVersion");
			double result;
			if (string.IsNullOrEmpty(attribute) || !double.TryParse(attribute, out result))
			{
				result = defaultVersion;
			}
			return result;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
		private global::Infragistics.Windows.DataPresenter.FieldLayout GetLoadedFieldLayoutThatMatchesKey(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription key)
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._dataPresenter.FieldLayouts)
			{
				if (key.DoesFieldLayoutMatch(fieldLayout, false))
				{
					return fieldLayout;
				}
			}
			if (this._formatVersion >= 1.1 && this._formatVersion < 1.3)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 in this._dataPresenter.FieldLayouts)
				{
					if (key.DoesFieldLayoutMatch(fieldLayout2, true))
					{
						return fieldLayout2;
					}
				}
			}
			return null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001D090 File Offset: 0x0001B290
		private global::Infragistics.Windows.DataPresenter.Field GetMatchingField(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutDescription, string fieldName, string extendedInfo)
		{
			if (fieldLayoutDescription != null && !string.IsNullOrEmpty(extendedInfo))
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.Parse(this, extendedInfo);
				if (fieldDescription != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer in fieldLayoutDescription._criteriaComparers)
					{
						foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
						{
							if (fieldLayoutDescription.DoesFieldMatch(field, fieldDescription, comparer))
							{
								return field;
							}
						}
					}
					return null;
				}
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(fieldLayout, fieldName, false);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001D130 File Offset: 0x0001B330
		private bool HasCustomizationsBeenAppliedToFieldLayout(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutKey)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo fieldLayoutCustomizationInfo;
			return this.FieldLayoutCustomizationInfos.TryGetValue(fieldLayoutKey, out fieldLayoutCustomizationInfo) && fieldLayoutCustomizationInfo._customizationsApplied;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001D158 File Offset: 0x0001B358
		private void InitializeResizeInfo(global::System.Xml.XmlNode fieldNode, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo info)
		{
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfo = field.ExplicitResizeInfo;
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "cellWidth", "cellWidthAuto", false, true, info);
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "cellHeight", "cellHeightAuto", false, false, info);
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "labelWidth", "labelWidthAuto", true, true, info);
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "labelHeight", "labelHeightAuto", true, false, info);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		private void InitializeResizeInfo(global::System.Xml.XmlNode fieldNode, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo, string valueAttrib, string autoAttrib, bool label, bool width, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo info)
		{
			bool flag = info.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.FieldExtent);
			double num = flag ? double.NaN : global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(fieldNode, valueAttrib, double.NaN);
			bool flag2 = !flag && global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(fieldNode, autoAttrib, false);
			global::Infragistics.Windows.DataPresenter.Field field = resizeInfo.Field;
			bool flag3 = field.Owner != null && field.Owner.IsHorizontal;
			if (flag3 != width)
			{
				field._hasPendingInitialAutoSize = false;
			}
			global::Infragistics.Windows.DataPresenter.ItemSizeType type;
			if (!flag2)
			{
				type = global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = field.GetWidthOrHeight(width);
				if (flag3 != width && widthOrHeight.IsInitialAuto)
				{
					field._hasPendingInitialAutoSize = true;
				}
				if (widthOrHeight.IsAnyAuto)
				{
					global::Infragistics.Windows.DataPresenter.FieldSize resizeSize = field.GetResizeSize(label, width);
					if (resizeSize.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode)
					{
						num = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.Max(num, resizeSize.Value);
					}
					type = global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode;
				}
				else
				{
					type = global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldSize size = new global::Infragistics.Windows.DataPresenter.FieldSize(num, type);
			resizeInfo.SetSize(label, width, size);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		private void LoadRecordFilters(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Xml.XmlNode filtersNode, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo info)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
			if (fieldLayout.HasRecordFilters)
			{
				fieldLayout.RecordFilters.Clear();
			}
			if (filtersNode != null && !info.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.RecordFilters))
			{
				foreach (object obj in filtersNode.ChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
					object obj2;
					if (dataPresenterObjectSerializer.ParseElement(xmlNode as global::System.Xml.XmlElement, typeof(global::Infragistics.Windows.DataPresenter.RecordFilter), out obj2))
					{
						fieldLayout.RecordFilters.Add((global::Infragistics.Windows.DataPresenter.RecordFilter)obj2);
					}
				}
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001D358 File Offset: 0x0001B558
		private void LoadSummaries(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Xml.XmlNode summariesNode, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo info)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
			if (fieldLayout.SummaryDefinitionsIfAllocated != null)
			{
				fieldLayout.SummaryDefinitions.Clear();
			}
			if (summariesNode != null && !info.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.Summaries))
			{
				foreach (object obj in summariesNode.ChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
					object obj2;
					if (dataPresenterObjectSerializer.ParseElement(xmlNode as global::System.Xml.XmlElement, typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), out obj2))
					{
						fieldLayout.SummaryDefinitions.Add((global::Infragistics.Windows.DataPresenter.SummaryDefinition)obj2);
					}
				}
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001D400 File Offset: 0x0001B600
		private void MarkFieldSizeAndPositionAsApplied(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutKey)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo fieldLayoutCustomizationInfo = this.GetFieldLayoutCustomizationInfo(fieldLayoutKey, true);
			fieldLayoutCustomizationInfo._customizationsApplied = true;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001D41D File Offset: 0x0001B61D
		private static T ParseEnum<T>(string value)
		{
			return (T)((object)global::System.Enum.Parse(typeof(T), value, false));
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001D438 File Offset: 0x0001B638
		private static string ReadAttribute(global::System.Xml.XmlNode node, string name, string defaultValue)
		{
			global::System.Xml.XmlAttribute xmlAttribute = node.Attributes[name];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return defaultValue;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001D460 File Offset: 0x0001B660
		private static bool ReadAttribute(global::System.Xml.XmlNode node, string name, bool defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToBoolean(text);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001D484 File Offset: 0x0001B684
		private static int ReadAttribute(global::System.Xml.XmlNode node, string name, int defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToInt32(text);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
		private static global::System.DateTime ReadAttribute(global::System.Xml.XmlNode node, string name, global::System.DateTime defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToDateTime(text, global::System.Xml.XmlDateTimeSerializationMode.Local);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		private static double ReadAttribute(global::System.Xml.XmlNode node, string name, double defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToDouble(text);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		private static T ReadAttributeWithConverter<T>(global::System.Xml.XmlNode node, string name, T defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
			return (T)((object)converter.ConvertFromString(null, global::System.Globalization.CultureInfo.InvariantCulture, text));
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001D530 File Offset: 0x0001B730
		private static T ReadEnumAttribute<T>(global::System.Xml.XmlNode node, string name, T defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return (T)((object)global::System.Enum.Parse(defaultValue.GetType(), text));
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001D564 File Offset: 0x0001B764
		private void SaveRecordFilters(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (fieldLayout.HasRecordFilters)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = fieldLayout.RecordFilters;
				writer.WriteStartElement("recordFilters");
				global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
				foreach (global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter in recordFilters)
				{
					global::System.Xml.XmlElement xmlElement;
					if (recordFilter.HasConditions && dataPresenterObjectSerializer.SaveAsElement(recordFilter, typeof(global::Infragistics.Windows.DataPresenter.RecordFilter), out xmlElement))
					{
						xmlElement.WriteTo(writer);
					}
				}
				writer.WriteEndElement();
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
		private static void SaveResizeInfo(global::System.Xml.XmlTextWriter writer, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, false, true, "cellWidth", "cellWidthAuto");
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, false, false, "cellHeight", "cellHeightAuto");
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, true, true, "labelWidth", "labelWidthAuto");
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, true, false, "labelHeight", "labelHeightAuto");
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001D650 File Offset: 0x0001B850
		private static void SaveResizeInfo(global::System.Xml.XmlTextWriter writer, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo, bool label, bool width, string valueAttrib, string autoAttrib)
		{
			global::Infragistics.Windows.DataPresenter.FieldSize size = resizeInfo.GetSize(label, width);
			if (size.IsAuto)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, autoAttrib, true);
			}
			if (size.Type != global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, valueAttrib, size.Value, true);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001D694 File Offset: 0x0001B894
		private void SaveSummaries(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionsIfAllocated = fieldLayout.SummaryDefinitionsIfAllocated;
			if (summaryDefinitionsIfAllocated != null && summaryDefinitionsIfAllocated.Count > 0)
			{
				writer.WriteStartElement("summaries");
				global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
				foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition obj in summaryDefinitionsIfAllocated)
				{
					global::System.Xml.XmlElement xmlElement;
					if (dataPresenterObjectSerializer.SaveAsElement(obj, typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), out xmlElement))
					{
						xmlElement.WriteTo(writer);
					}
				}
				writer.WriteEndElement();
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001D720 File Offset: 0x0001B920
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, double value, bool dontWriteIfNaN)
		{
			if (dontWriteIfNaN && double.IsNaN(value))
			{
				return;
			}
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001D73B File Offset: 0x0001B93B
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, double value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001D74A File Offset: 0x0001B94A
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Enum value)
		{
			writer.WriteAttributeString(name, value.ToString());
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001D759 File Offset: 0x0001B959
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, int value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001D768 File Offset: 0x0001B968
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, bool value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001D777 File Offset: 0x0001B977
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Size value)
		{
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, name, value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Size)));
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001D79E File Offset: 0x0001B99E
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Rect value)
		{
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, name, value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Rect)));
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001D7C5 File Offset: 0x0001B9C5
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Point? value)
		{
			if (value != null)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, name, value.Value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Point)));
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001D7F2 File Offset: 0x0001B9F2
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, object value, global::System.ComponentModel.TypeConverter converter)
		{
			writer.WriteAttributeString(name, converter.ConvertToString(null, global::System.Globalization.CultureInfo.InvariantCulture, value));
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0001D808 File Offset: 0x0001BA08
		private static void WriteAttribute(global::System.Xml.XmlTextWriter writer, string name, global::System.DateTime dateTime)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(dateTime, global::System.Xml.XmlDateTimeSerializationMode.Utc));
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001D818 File Offset: 0x0001BA18
		private void WriteFieldLayoutStartTag(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			writer.WriteStartElement("fieldLayout");
			string parentFieldName = fieldLayout.ParentFieldName;
			if (parentFieldName != null && parentFieldName.Length > 0)
			{
				writer.WriteAttributeString("parentFieldName", parentFieldName);
			}
			writer.WriteAttributeString("key", this.GetFieldLayoutKey(fieldLayout, this._formatVersion));
			writer.WriteAttributeString("fieldList", this.ConstructFieldList(fieldLayout));
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001D87C File Offset: 0x0001BA7C
		private void WriteParentFieldLayoutTag(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = fieldLayout.ParentFieldLayout;
			if (parentFieldLayout == null)
			{
				return;
			}
			writer.WriteStartElement("parentFieldLayout");
			writer.WriteAttributeString("key", this.GetFieldLayoutKey(parentFieldLayout, this._formatVersion));
			writer.WriteAttributeString("fieldList", this.ConstructFieldList(parentFieldLayout));
			writer.WriteEndElement();
		}

		// Token: 0x0400020A RID: 522
		private const double LATEST_VERSION = 1.6;

		// Token: 0x0400020B RID: 523
		private const string RootTag = "xamDataPresenter";

		// Token: 0x0400020C RID: 524
		private const string FieldLayoutsTag = "fieldLayouts";

		// Token: 0x0400020D RID: 525
		private const string FieldLayoutTag = "fieldLayout";

		// Token: 0x0400020E RID: 526
		private const string SortedFieldsTag = "sortedFields";

		// Token: 0x0400020F RID: 527
		private const string SortedFieldTag = "sortedField";

		// Token: 0x04000210 RID: 528
		private const string FieldsTag = "fields";

		// Token: 0x04000211 RID: 529
		private const string FieldTag = "field";

		// Token: 0x04000212 RID: 530
		private const string ParentFieldLayoutTag = "parentFieldLayout";

		// Token: 0x04000213 RID: 531
		private const string CardViewSettingsTag = "CardViewSettings";

		// Token: 0x04000214 RID: 532
		private const string VersionAttrib = "version";

		// Token: 0x04000215 RID: 533
		private const string KeyAttrib = "key";

		// Token: 0x04000216 RID: 534
		private const string DirectionAttrib = "direction";

		// Token: 0x04000217 RID: 535
		private const string FieldNameAttrib = "fieldName";

		// Token: 0x04000218 RID: 536
		private const string IsGroupByAttrib = "isGroupBy";

		// Token: 0x04000219 RID: 537
		private const string ExtentAttrib = "extent";

		// Token: 0x0400021A RID: 538
		private const string NameAttrib = "name";

		// Token: 0x0400021B RID: 539
		private const string LabelWidthAttrib = "labelWidth";

		// Token: 0x0400021C RID: 540
		private const string LabelHeightAttrib = "labelHeight";

		// Token: 0x0400021D RID: 541
		private const string CellWidthAttrib = "cellWidth";

		// Token: 0x0400021E RID: 542
		private const string CellHeightAttrib = "cellHeight";

		// Token: 0x0400021F RID: 543
		private const string RowAttrib = "row";

		// Token: 0x04000220 RID: 544
		private const string ColumnAttrib = "column";

		// Token: 0x04000221 RID: 545
		private const string RowSpanAttrib = "rowSpan";

		// Token: 0x04000222 RID: 546
		private const string ColumnSpanAttrib = "columnSpan";

		// Token: 0x04000223 RID: 547
		private const string ParentFieldNameAttrib = "parentFieldName";

		// Token: 0x04000224 RID: 548
		private const string IsCollapsedInLayoutAttrib = "isCollapsedInLayout";

		// Token: 0x04000225 RID: 549
		private const string VisibilityAttrib = "Visibility";

		// Token: 0x04000226 RID: 550
		private const string FormatVersionAttrib = "formatVersion";

		// Token: 0x04000227 RID: 551
		private const string FieldListAttrib = "fieldList";

		// Token: 0x04000228 RID: 552
		private const string FieldExtendedInfo = "extendedInfo";

		// Token: 0x04000229 RID: 553
		private const string RecordFiltersTag = "recordFilters";

		// Token: 0x0400022A RID: 554
		private const string FixedLocationAttrib = "FixedLocation";

		// Token: 0x0400022B RID: 555
		private const string IgnoreFieldVisibilityOverrides = "IgnoreFieldVisibilityOverrides";

		// Token: 0x0400022C RID: 556
		private const string LabelWidthAutoAttrib = "labelWidthAuto";

		// Token: 0x0400022D RID: 557
		private const string LabelHeightAutoAttrib = "labelHeightAuto";

		// Token: 0x0400022E RID: 558
		private const string CellWidthAutoAttrib = "cellWidthAuto";

		// Token: 0x0400022F RID: 559
		private const string CellHeightAutoAttrib = "cellHeightAuto";

		// Token: 0x04000230 RID: 560
		private const string SummariesTag = "summaries";

		// Token: 0x04000231 RID: 561
		private const string ExcludeCustomizations = "ExcludeCustomizationsAttrib";

		// Token: 0x04000232 RID: 562
		private const string CardWidthAttrib = "CardWidth";

		// Token: 0x04000233 RID: 563
		private const string CardHeightAttrib = "CardHeight";

		// Token: 0x04000234 RID: 564
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000235 RID: 565
		private global::System.Xml.XmlDocument _currentLoadedDocument;

		// Token: 0x04000236 RID: 566
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo> _fieldLayoutCustomizationInfos;

		// Token: 0x04000237 RID: 567
		private bool _allLoadedCustomizationsApplied;

		// Token: 0x04000238 RID: 568
		private double _formatVersion = 1.6;

		// Token: 0x04000239 RID: 569
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.DataPresenter.Parser_ListOfItems g_parser_ListOfItems;

		// Token: 0x02000094 RID: 148
		private class FieldDescription
		{
			// Token: 0x06000741 RID: 1857 RVA: 0x0001D8CF File Offset: 0x0001BACF
			private FieldDescription()
			{
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x0001D8D7 File Offset: 0x0001BAD7
			internal FieldDescription(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string name, string typeName, bool isUnbound, string bindingPath)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(manager);
				this._manager = manager;
				this._name = name;
				this._typeName = typeName;
				this._isUnbound = isUnbound;
				this._bindingPath = bindingPath;
			}

			// Token: 0x06000743 RID: 1859 RVA: 0x0001D90C File Offset: 0x0001BB0C
			internal FieldDescription(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, global::Infragistics.Windows.DataPresenter.Field field)
			{
				this._manager = manager;
				this._name = field.Name;
				global::System.Type type = field.DataType;
				if (null != type)
				{
					type = global::Infragistics.CoreUtilities.GetUnderlyingType(field.DataType);
				}
				this._typeName = type.Name;
				global::Infragistics.Windows.DataPresenter.UnboundField unboundField = field as global::Infragistics.Windows.DataPresenter.UnboundField;
				this._isUnbound = (null != unboundField);
				if (unboundField != null)
				{
					global::System.Windows.PropertyPath bindingPath = unboundField.BindingPath;
					if (bindingPath != null)
					{
						this._bindingPath = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingPathString(bindingPath);
						return;
					}
					global::System.Windows.Data.BindingBase binding = unboundField.Binding;
					if (binding != null)
					{
						this._bindingPath = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingString(binding);
					}
				}
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x0001D99E File Offset: 0x0001BB9E
			private static string GetBindingPathString(global::System.Windows.PropertyPath bindingPath)
			{
				return (string)global::Infragistics.CoreUtilities.ConvertDataValue(bindingPath, typeof(string), global::System.Globalization.CultureInfo.InvariantCulture, null);
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x0001D9BC File Offset: 0x0001BBBC
			private static string GetBindingString(global::System.Windows.Data.BindingBase bindingBase)
			{
				global::System.Windows.Data.Binding binding = bindingBase as global::System.Windows.Data.Binding;
				if (binding != null)
				{
					if (binding.Path != null)
					{
						return "{" + global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingPathString(binding.Path) + "}";
					}
					if (binding.XPath != null)
					{
						return "{XPath=" + binding.XPath + "}";
					}
					return null;
				}
				else
				{
					int num = 0;
					global::System.Windows.Data.MultiBinding multiBinding = bindingBase as global::System.Windows.Data.MultiBinding;
					if (multiBinding != null)
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						stringBuilder.Append("{MultiBinding=");
						foreach (global::System.Windows.Data.BindingBase bindingBase2 in multiBinding.Bindings)
						{
							string bindingString = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingString(bindingBase2);
							if (bindingString != null)
							{
								num++;
								stringBuilder.Append(bindingString);
							}
						}
						if (num == 0)
						{
							return null;
						}
						stringBuilder.Append("}");
						return stringBuilder.ToString();
					}
					else
					{
						global::System.Windows.Data.PriorityBinding priorityBinding = bindingBase as global::System.Windows.Data.PriorityBinding;
						if (priorityBinding == null)
						{
							return null;
						}
						global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
						stringBuilder2.Append("{PriorityBinding=");
						foreach (global::System.Windows.Data.BindingBase bindingBase3 in priorityBinding.Bindings)
						{
							string bindingString2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingString(bindingBase3);
							if (bindingString2 != null)
							{
								num++;
								stringBuilder2.Append(bindingString2);
							}
						}
						if (num == 0)
						{
							return null;
						}
						stringBuilder2.Append("}");
						return stringBuilder2.ToString();
					}
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001DB38 File Offset: 0x0001BD38
			private static global::Infragistics.Windows.DataPresenter.Parser_ListOfItems Parser
			{
				get
				{
					if (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.g_parser_ListOfItems == null)
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.g_parser_ListOfItems = new global::Infragistics.Windows.DataPresenter.Parser_ListOfItems('"', '"', '\\', ';');
					}
					return global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.g_parser_ListOfItems;
				}
			}

			// Token: 0x06000747 RID: 1863 RVA: 0x0001DB58 File Offset: 0x0001BD58
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				this.ToString(stringBuilder);
				return stringBuilder.ToString();
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x0001DB78 File Offset: 0x0001BD78
			public void ToString(global::System.Text.StringBuilder sb)
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(this._name);
				if (this._isUnbound || "String" != this._typeName)
				{
					list.Add(this._typeName);
				}
				if (this._isUnbound)
				{
					list.Add("unbound");
					if (this._bindingPath != null)
					{
						list.Add(this._bindingPath);
					}
				}
				sb.Append(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.Parser.ConstructList(list.ToArray(), false));
			}

			// Token: 0x06000749 RID: 1865 RVA: 0x0001DBFC File Offset: 0x0001BDFC
			public static global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription Parse(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string val)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription();
				fieldDescription.ParseHelper(manager, val);
				return fieldDescription;
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x0001DC18 File Offset: 0x0001BE18
			private void ParseHelper(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string val)
			{
				this._manager = manager;
				string[] array = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.Parser.ParseList(val, false);
				if (array != null && array.Length >= 1)
				{
					this._name = array[0];
					if (array.Length >= 2)
					{
						this._typeName = array[1];
					}
					else
					{
						this._typeName = typeof(string).Name;
					}
					if (array.Length >= 3)
					{
						this._isUnbound = ("unbound" == array[2]);
					}
					if (array.Length >= 4)
					{
						this._bindingPath = array[3];
					}
				}
			}

			// Token: 0x0400023A RID: 570
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager _manager;

			// Token: 0x0400023B RID: 571
			internal string _name;

			// Token: 0x0400023C RID: 572
			internal string _typeName;

			// Token: 0x0400023D RID: 573
			internal bool _isUnbound;

			// Token: 0x0400023E RID: 574
			internal string _bindingPath;

			// Token: 0x0400023F RID: 575
			[global::System.ThreadStatic]
			private static global::Infragistics.Windows.DataPresenter.Parser_ListOfItems g_parser_ListOfItems;
		}

		// Token: 0x02000095 RID: 149
		private class FieldLayoutDescription
		{
			// Token: 0x0600074B RID: 1867 RVA: 0x0001DC9C File Offset: 0x0001BE9C
			internal FieldLayoutDescription(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string key, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] fieldList, double nodeFormatVersion)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(manager);
				this._nodeFormatVersion = nodeFormatVersion;
				this._manager = manager;
				this._key = key;
				this._fieldDescriptionComparer = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer(this, manager, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.All);
				this._fieldList = fieldList;
				this._criteriaComparers = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer[global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.g_criterias.Length];
				for (int i = 0; i < global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.g_criterias.Length; i++)
				{
					this._criteriaComparers[i] = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer(this, this._manager, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.g_criterias[i]);
				}
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x0001DD20 File Offset: 0x0001BF20
			public bool DoesFieldMatch(global::Infragistics.Windows.DataPresenter.Field testField, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription testFsd, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer)
			{
				if (this._cachedFsds == null)
				{
					this._cachedFsds = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription>();
				}
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription x;
				if (!this._cachedFsds.TryGetValue(testField, out x))
				{
					x = (this._cachedFsds[testField] = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription(this._manager, testField));
				}
				return comparer.Equals(x, testFsd);
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x0001DD72 File Offset: 0x0001BF72
			public override int GetHashCode()
			{
				if (this._key == null)
				{
					return 0;
				}
				return this._key.GetHashCode();
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x0001DD8C File Offset: 0x0001BF8C
			private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> ToNameMap(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> x)
			{
				global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> dictionary = null;
				int count = x.Count;
				if (count > 0)
				{
					dictionary = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription>();
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = x[i];
						string name = fieldDescription._name;
						if (string.IsNullOrEmpty(name))
						{
							dictionary = null;
							break;
						}
						dictionary[name] = fieldDescription;
					}
				}
				if (dictionary == null || dictionary.Count != count)
				{
					return null;
				}
				return dictionary;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
			private static bool AreEqual(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> x, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> y, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer)
			{
				bool flag;
				bool result;
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.IsSubsetOfHelper(x, y, comparer, out flag, out result);
				return result;
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x0001DE0C File Offset: 0x0001C00C
			private static bool IsSubsetOf(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> x, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> y, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer)
			{
				bool result;
				bool flag;
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.IsSubsetOfHelper(x, y, comparer, out result, out flag);
				return result;
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x0001DE28 File Offset: 0x0001C028
			private static void IsSubsetOfHelper(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> x, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> y, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer, out bool isSubset, out bool areEqual)
			{
				isSubset = (areEqual = false);
				int num = (x != null) ? x.Count : 0;
				int num2 = (y != null) ? y.Count : 0;
				if (num > num2)
				{
					return;
				}
				global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> dictionary = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.ToNameMap(x);
				global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> dictionary2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.ToNameMap(y);
				if (dictionary != null && dictionary2 != null)
				{
					for (int i = 0; i < num; i++)
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = x[i];
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription2;
						dictionary2.TryGetValue(fieldDescription._name, out fieldDescription2);
						if (fieldDescription2 == null || !comparer.Equals(fieldDescription, fieldDescription2))
						{
							return;
						}
					}
				}
				else
				{
					for (int j = 0; j < num; j++)
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription3 = x[j];
						if (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.IndexOf(y, x[j], comparer) < 0)
						{
							return;
						}
					}
				}
				isSubset = true;
				areEqual = (num == num2);
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
			private static int IndexOf(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> list, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription item, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer)
			{
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					if (comparer.Equals(list[i], item))
					{
						return i;
					}
					i++;
				}
				return -1;
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x0001DF1C File Offset: 0x0001C11C
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutDescription = obj as global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription;
				if (fieldLayoutDescription == null)
				{
					return false;
				}
				if (this._manager._formatVersion >= 1.1)
				{
					return this._key == fieldLayoutDescription._key && global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.AreEqual(this._fieldList, fieldLayoutDescription._fieldList, this._fieldDescriptionComparer);
				}
				return this._key == fieldLayoutDescription._key;
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x0001DF8C File Offset: 0x0001C18C
			public bool DoesFieldLayoutMatch(global::Infragistics.Windows.DataPresenter.FieldLayout fl, bool ignoreKeyCompare)
			{
				if (!ignoreKeyCompare && !(this._key == this._manager.GetFieldLayoutKey(fl, this._nodeFormatVersion)))
				{
					return false;
				}
				if (this._nodeFormatVersion >= 1.1)
				{
					global::Infragistics.Windows.DataPresenter.FieldCollection fields = fl.Fields;
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription>();
					foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
					{
						list.Add(new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription(this._manager, field));
					}
					foreach (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer in this._criteriaComparers)
					{
						if (this._fieldList != null && global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.IsSubsetOf(this._fieldList, list, comparer))
						{
							return true;
						}
					}
					return false;
				}
				return true;
			}

			// Token: 0x04000240 RID: 576
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager _manager;

			// Token: 0x04000241 RID: 577
			private string _key;

			// Token: 0x04000242 RID: 578
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] _fieldList;

			// Token: 0x04000243 RID: 579
			internal double _nodeFormatVersion;

			// Token: 0x04000244 RID: 580
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer _fieldDescriptionComparer;

			// Token: 0x04000245 RID: 581
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> _cachedFsds;

			// Token: 0x04000246 RID: 582
			internal readonly global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer[] _criteriaComparers;

			// Token: 0x04000247 RID: 583
			private static readonly global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria[] g_criterias = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria[]
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.All,
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.Name | global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.BindingPath | global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.IsUnbound
			};

			// Token: 0x02000096 RID: 150
			[global::System.Flags]
			internal enum FieldMatchCriteria
			{
				// Token: 0x04000249 RID: 585
				Name = 1,
				// Token: 0x0400024A RID: 586
				TypeName = 2,
				// Token: 0x0400024B RID: 587
				BindingPath = 4,
				// Token: 0x0400024C RID: 588
				IsUnbound = 8,
				// Token: 0x0400024D RID: 589
				All = 15
			}

			// Token: 0x02000097 RID: 151
			internal class FieldDescriptionEqualityComparer : global::System.Collections.IEqualityComparer
			{
				// Token: 0x06000756 RID: 1878 RVA: 0x0001E094 File Offset: 0x0001C294
				internal FieldDescriptionEqualityComparer(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria criteria)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(manager);
					this._manager = manager;
					this._fieldLayoutDescription = fieldLayoutDescription;
					this._criteria = criteria;
					this._formatVersion = ((this._fieldLayoutDescription != null) ? this._fieldLayoutDescription._nodeFormatVersion : this._manager._formatVersion);
				}

				// Token: 0x06000757 RID: 1879 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
				public bool Equals(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription x, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription y)
				{
					if (x == null || y == null)
					{
						return x == y;
					}
					if (this._formatVersion >= 1.1)
					{
						return ((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.Name & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0 || x._name == y._name) && ((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.TypeName & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0 || x._typeName == y._typeName) && (this._formatVersion < 1.6 || (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.BindingPath & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0 || global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(x._bindingPath, y._bindingPath, true)) && ((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.IsUnbound & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0 || x._isUnbound == y._isUnbound);
					}
					return x._name == y._name;
				}

				// Token: 0x06000758 RID: 1880 RVA: 0x0001E1AC File Offset: 0x0001C3AC
				public int GetHashCode(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription obj)
				{
					if (this._formatVersion >= 1.1)
					{
						return (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.Name & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._name)) ^ (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.TypeName & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._typeName)) ^ (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.BindingPath & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : ((this._formatVersion >= 1.6) ? global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._bindingPath) : 0)) ^ (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.IsUnbound & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : obj._isUnbound.GetHashCode());
					}
					return global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._name);
				}

				// Token: 0x06000759 RID: 1881 RVA: 0x0001E24D File Offset: 0x0001C44D
				private static int GetStringHashHelper(string s)
				{
					if (s == null)
					{
						return 0;
					}
					return s.GetHashCode();
				}

				// Token: 0x0600075A RID: 1882 RVA: 0x0001E25A File Offset: 0x0001C45A
				bool global::System.Collections.IEqualityComparer.Equals(object x, object y)
				{
					return this.Equals((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription)x, (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription)y);
				}

				// Token: 0x0600075B RID: 1883 RVA: 0x0001E26E File Offset: 0x0001C46E
				int global::System.Collections.IEqualityComparer.GetHashCode(object obj)
				{
					return this.GetHashCode((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription)obj);
				}

				// Token: 0x0400024E RID: 590
				private global::Infragistics.Windows.DataPresenter.CustomizationsManager _manager;

				// Token: 0x0400024F RID: 591
				private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription _fieldLayoutDescription;

				// Token: 0x04000250 RID: 592
				private double _formatVersion;

				// Token: 0x04000251 RID: 593
				private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria _criteria;
			}
		}

		// Token: 0x02000098 RID: 152
		private class FieldLayoutCustomizationInfo
		{
			// Token: 0x0600075C RID: 1884 RVA: 0x0001E27C File Offset: 0x0001C47C
			internal FieldLayoutCustomizationInfo(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription key)
			{
				this._key = key;
			}

			// Token: 0x0600075D RID: 1885 RVA: 0x0001E28B File Offset: 0x0001C48B
			internal bool ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
			{
				return customizationType == (customizationType & this._excludeCustomizations);
			}

			// Token: 0x04000252 RID: 594
			internal bool _customizationsApplied;

			// Token: 0x04000253 RID: 595
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription _key;

			// Token: 0x04000254 RID: 596
			internal global::Infragistics.Windows.DataPresenter.CustomizationType _excludeCustomizations;

			// Token: 0x04000255 RID: 597
			internal global::System.Xml.XmlNode _fieldLayoutNode;

			// Token: 0x04000256 RID: 598
			internal double _nodeFormatVersion;
		}
	}
}
