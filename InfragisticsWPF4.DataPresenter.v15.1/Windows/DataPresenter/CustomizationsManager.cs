using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml;
using Infragistics.Windows.DataPresenter.Calculations;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000099 RID: 153
	internal class CustomizationsManager
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x0001EA93 File Offset: 0x0001CC93
		internal CustomizationsManager(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			this._dataPresenter = dataPresenter;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0001EAB1 File Offset: 0x0001CCB1
		internal bool AreCustomizationsLoaded
		{
			get
			{
				return this._currentLoadedDocument != null;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0001EABF File Offset: 0x0001CCBF
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

		// Token: 0x06000798 RID: 1944 RVA: 0x0001EADC File Offset: 0x0001CCDC
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
							bool flag = false;
							bool flag2 = false;
							if (this._formatVersion > 1.7 && this._dataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.GridView)
							{
								string y = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode3, "orientation", null);
								global::System.Windows.Controls.Orientation? orientation = null;
								if (global::System.StringComparer.CurrentCultureIgnoreCase.Compare("Vertical", y) == 0)
								{
									orientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Vertical);
								}
								else if (global::System.StringComparer.CurrentCultureIgnoreCase.Compare("Horizontal", y) == 0)
								{
									orientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Horizontal);
								}
								flag = (orientation != null && orientation.Value != this._dataPresenter.CurrentViewInternal.LogicalOrientation);
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
									bool flag3 = fieldLayoutCustomizationInfo.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.FieldPosition);
									string extendedInfo2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "extendedInfo", null);
									global::Infragistics.Windows.DataPresenter.Field matchingField2 = this.GetMatchingField(loadedFieldLayoutThatMatchesKey, fieldLayoutDescription, fieldName2, extendedInfo2);
									if (matchingField2 != null)
									{
										global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation = flag3 ? global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable : global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadEnumAttribute<global::Infragistics.Windows.DataPresenter.FixedFieldLocation>(xmlNode7, "FixedLocation", global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
										this.InitializeResizeInfo(xmlNode7, matchingField2, fieldLayoutCustomizationInfo);
										if (this._formatVersion >= 1.2)
										{
											matchingField2.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.VisibilityProperty, global::Infragistics.KnownBoxes.FromValue(flag3 ? global::System.Windows.Visibility.Visible : global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadEnumAttribute<global::System.Windows.Visibility>(xmlNode7, "Visibility", global::System.Windows.Visibility.Visible)));
											matchingField2.IgnoreFieldVisibilityOverrides = (!flag3 && global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "IgnoreFieldVisibilityOverrides", false));
										}
										int num2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "row", -1);
										int num3 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "column", -1);
										int num4 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "rowSpan", 0);
										int num5 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "columnSpan", 0);
										if (num2 >= 0 && num3 >= 0 && num4 > 0 && num5 > 0 && !flag3)
										{
											global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(num3, num2, num5, num4);
											if (this._formatVersion >= 1.2)
											{
												itemLayoutInfo.IsCollapsed = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(xmlNode7, "isCollapsedInLayout", false);
											}
											itemLayoutInfo._fixedLocation = fixedFieldLocation;
											if (layoutInfo == null)
											{
												layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(loadedFieldLayoutThatMatchesKey);
											}
											layoutInfo[matchingField2] = itemLayoutInfo;
											flag2 = true;
										}
										matchingField2.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty, fixedFieldLocation);
										if (this._formatVersion >= 1.7)
										{
											this.LoadCalculationSettings(xmlNode7, matchingField2);
										}
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
							if (flag && flag2)
							{
								loadedFieldLayoutThatMatchesKey.FlipFieldPositions();
							}
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

		// Token: 0x06000799 RID: 1945 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
		public void ClearCustomizations(global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayoutsIfAllocated = this._dataPresenter.FieldLayoutsIfAllocated;
			if (fieldLayoutsIfAllocated != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in fieldLayoutsIfAllocated)
				{
					this.ClearCustomizations(fieldLayout, customizations);
				}
				if ((global::Infragistics.Windows.DataPresenter.CustomizationType.RecordFilters & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
				{
					bool flag = false;
					foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 in fieldLayoutsIfAllocated)
					{
						if (fieldLayout2.RecordFilterScopeResolvedDefault != global::Infragistics.Windows.DataPresenter.RecordFilterScope.AllRecords)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager recordManagerIfAllocated = this._dataPresenter.RecordManagerIfAllocated;
						if (recordManagerIfAllocated != null)
						{
							recordManagerIfAllocated.ClearFilters();
						}
					}
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

		// Token: 0x0600079A RID: 1946 RVA: 0x0001F510 File Offset: 0x0001D710
		public void ClearCustomizations(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			fieldLayout.ClearCustomizations(customizations);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0001F51C File Offset: 0x0001D71C
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

		// Token: 0x0600079C RID: 1948 RVA: 0x0001F570 File Offset: 0x0001D770
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

		// Token: 0x0600079D RID: 1949 RVA: 0x0001F5CC File Offset: 0x0001D7CC
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

		// Token: 0x0600079E RID: 1950 RVA: 0x0001F61C File Offset: 0x0001D81C
		public void SaveCustomizations(global::System.IO.Stream stream)
		{
			global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(stream, global::System.Text.Encoding.UTF8);
			xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
			this._formatVersion = 1.8;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("xamDataPresenter");
			xmlTextWriter.WriteAttributeString("version", "15.1.20151.2008");
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
							if (this._formatVersion >= 1.7)
							{
								this.SaveCalculationSettings(xmlTextWriter, field2);
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

		// Token: 0x0600079F RID: 1951 RVA: 0x0001FB98 File Offset: 0x0001DD98
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

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001FC28 File Offset: 0x0001DE28
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001FC7E File Offset: 0x0001DE7E
		private static global::Infragistics.ListParser FieldListPraser
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.CustomizationsManager.g_parser_ListOfItems == null)
				{
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.g_parser_ListOfItems = new global::Infragistics.ListParser('"', '"', '\\', ',');
				}
				return global::Infragistics.Windows.DataPresenter.CustomizationsManager.g_parser_ListOfItems;
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
		private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] ParseFieldList(string fieldList)
		{
			if (fieldList == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription>();
			global::System.Collections.Generic.IList<string> list2 = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldListPraser.ParseList(fieldList, false);
			if (list2 != null)
			{
				for (int i = 0; i < list2.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.Parse(this, list2[i]);
					if (fieldDescription != null)
					{
						list.Add(fieldDescription);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001FCF7 File Offset: 0x0001DEF7
		private static bool DoesFieldExistInFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string fieldName)
		{
			return fieldLayout.Fields.IndexOf(fieldName) > -1;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001FD08 File Offset: 0x0001DF08
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

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001FD3C File Offset: 0x0001DF3C
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

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
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

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001FE20 File Offset: 0x0001E020
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

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001FEEC File Offset: 0x0001E0EC
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

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001FF8C File Offset: 0x0001E18C
		private bool HasCustomizationsBeenAppliedToFieldLayout(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutKey)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo fieldLayoutCustomizationInfo;
			return this.FieldLayoutCustomizationInfos.TryGetValue(fieldLayoutKey, out fieldLayoutCustomizationInfo) && fieldLayoutCustomizationInfo._customizationsApplied;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		private void InitializeResizeInfo(global::System.Xml.XmlNode fieldNode, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo info)
		{
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfo = field.ExplicitResizeInfo;
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "cellWidth", "cellWidthAuto", false, true, info);
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "cellHeight", "cellHeightAuto", false, false, info);
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "labelWidth", "labelWidthAuto", true, true, info);
			this.InitializeResizeInfo(fieldNode, explicitResizeInfo, "labelHeight", "labelHeightAuto", true, false, info);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0002001C File Offset: 0x0001E21C
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

		// Token: 0x060007AC RID: 1964 RVA: 0x0002010C File Offset: 0x0001E30C
		private void LoadCalculationSettings(global::System.Xml.XmlNode fieldNode, global::Infragistics.Windows.DataPresenter.Field field)
		{
			field.CalculationSettings = null;
			global::System.Xml.XmlElement xmlElement = fieldNode.SelectSingleNode(global::Infragistics.Windows.DataPresenter.Field.CalculationSettingsProperty.Name) as global::System.Xml.XmlElement;
			if (xmlElement != null)
			{
				xmlElement = (xmlElement.FirstChild as global::System.Xml.XmlElement);
			}
			if (xmlElement != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
				object value;
				if (dataPresenterObjectSerializer.ParseElement(xmlElement, global::Infragistics.Windows.DataPresenter.Field.CalculationSettingsProperty.PropertyType, out value))
				{
					field.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.CalculationSettingsProperty, value);
				}
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00020170 File Offset: 0x0001E370
		private void LoadRecordFilters(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Xml.XmlNode filtersNode, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo info)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
			if (fieldLayout.HasRecordFilters)
			{
				fieldLayout.RecordFilters.Clear();
			}
			if (filtersNode != null && !info.ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType.RecordFilters))
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
				{
					dataPresenterObjectSerializer.RegisterFieldTypeForAttributeParsing(field);
				}
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

		// Token: 0x060007AE RID: 1966 RVA: 0x00020260 File Offset: 0x0001E460
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

		// Token: 0x060007AF RID: 1967 RVA: 0x00020308 File Offset: 0x0001E508
		private void MarkFieldSizeAndPositionAsApplied(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutKey)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo fieldLayoutCustomizationInfo = this.GetFieldLayoutCustomizationInfo(fieldLayoutKey, true);
			fieldLayoutCustomizationInfo._customizationsApplied = true;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00020325 File Offset: 0x0001E525
		private static T ParseEnum<T>(string value)
		{
			return (T)((object)global::System.Enum.Parse(typeof(T), value, false));
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00020340 File Offset: 0x0001E540
		private static string ReadAttribute(global::System.Xml.XmlNode node, string name, string defaultValue)
		{
			global::System.Xml.XmlAttribute xmlAttribute = node.Attributes[name];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return defaultValue;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00020368 File Offset: 0x0001E568
		private static bool ReadAttribute(global::System.Xml.XmlNode node, string name, bool defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToBoolean(text);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002038C File Offset: 0x0001E58C
		private static int ReadAttribute(global::System.Xml.XmlNode node, string name, int defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToInt32(text);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000203B0 File Offset: 0x0001E5B0
		private static global::System.DateTime ReadAttribute(global::System.Xml.XmlNode node, string name, global::System.DateTime defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToDateTime(text, global::System.Xml.XmlDateTimeSerializationMode.Local);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000203D4 File Offset: 0x0001E5D4
		private static double ReadAttribute(global::System.Xml.XmlNode node, string name, double defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToDouble(text);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000203F8 File Offset: 0x0001E5F8
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

		// Token: 0x060007B7 RID: 1975 RVA: 0x00020438 File Offset: 0x0001E638
		private static T ReadEnumAttribute<T>(global::System.Xml.XmlNode node, string name, T defaultValue)
		{
			string text = global::Infragistics.Windows.DataPresenter.CustomizationsManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return (T)((object)global::System.Enum.Parse(defaultValue.GetType(), text));
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002046C File Offset: 0x0001E66C
		private void SaveCalculationSettings(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field.CalculationSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer dataPresenterObjectSerializer = new global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer();
				global::System.Xml.XmlElement xmlElement;
				if (dataPresenterObjectSerializer.SaveAsElement(field.CalculationSettings, typeof(global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings), out xmlElement))
				{
					writer.WriteStartElement(global::Infragistics.Windows.DataPresenter.Field.CalculationSettingsProperty.Name);
					xmlElement.WriteTo(writer);
					writer.WriteEndElement();
				}
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000204C0 File Offset: 0x0001E6C0
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

		// Token: 0x060007BA RID: 1978 RVA: 0x00020550 File Offset: 0x0001E750
		private static void SaveResizeInfo(global::System.Xml.XmlTextWriter writer, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo)
		{
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, false, true, "cellWidth", "cellWidthAuto");
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, false, false, "cellHeight", "cellHeightAuto");
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, true, true, "labelWidth", "labelWidthAuto");
			global::Infragistics.Windows.DataPresenter.CustomizationsManager.SaveResizeInfo(writer, resizeInfo, true, false, "labelHeight", "labelHeightAuto");
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000205AC File Offset: 0x0001E7AC
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

		// Token: 0x060007BC RID: 1980 RVA: 0x000205F0 File Offset: 0x0001E7F0
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

		// Token: 0x060007BD RID: 1981 RVA: 0x0002067C File Offset: 0x0001E87C
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, double value, bool dontWriteIfNaN)
		{
			if (dontWriteIfNaN && double.IsNaN(value))
			{
				return;
			}
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00020697 File Offset: 0x0001E897
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, double value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000206A6 File Offset: 0x0001E8A6
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Enum value)
		{
			writer.WriteAttributeString(name, value.ToString());
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000206B5 File Offset: 0x0001E8B5
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, int value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000206C4 File Offset: 0x0001E8C4
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, bool value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000206D3 File Offset: 0x0001E8D3
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Size value)
		{
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, name, value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Size)));
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000206FA File Offset: 0x0001E8FA
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Rect value)
		{
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, name, value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Rect)));
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00020721 File Offset: 0x0001E921
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Point? value)
		{
			if (value != null)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.WriteAttribute(writer, name, value.Value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Point)));
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002074E File Offset: 0x0001E94E
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, object value, global::System.ComponentModel.TypeConverter converter)
		{
			writer.WriteAttributeString(name, converter.ConvertToString(null, global::System.Globalization.CultureInfo.InvariantCulture, value));
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00020764 File Offset: 0x0001E964
		private static void WriteAttribute(global::System.Xml.XmlTextWriter writer, string name, global::System.DateTime dateTime)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(dateTime, global::System.Xml.XmlDateTimeSerializationMode.Utc));
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00020774 File Offset: 0x0001E974
		private void WriteFieldLayoutStartTag(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			writer.WriteStartElement("fieldLayout");
			string parentFieldName = fieldLayout.ParentFieldName;
			if (parentFieldName != null && parentFieldName.Length > 0)
			{
				writer.WriteAttributeString("parentFieldName", parentFieldName);
			}
			writer.WriteAttributeString("key", this.GetFieldLayoutKey(fieldLayout, this._formatVersion));
			if (this._formatVersion > 1.7 && this._dataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.GridView)
			{
				writer.WriteAttributeString("orientation", this._dataPresenter.CurrentViewInternal.LogicalOrientation.ToString());
			}
			writer.WriteAttributeString("fieldList", this.ConstructFieldList(fieldLayout));
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00020820 File Offset: 0x0001EA20
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

		// Token: 0x0400024E RID: 590
		private const double LATEST_VERSION = 1.8;

		// Token: 0x0400024F RID: 591
		private const string RootTag = "xamDataPresenter";

		// Token: 0x04000250 RID: 592
		private const string FieldLayoutsTag = "fieldLayouts";

		// Token: 0x04000251 RID: 593
		private const string FieldLayoutTag = "fieldLayout";

		// Token: 0x04000252 RID: 594
		private const string SortedFieldsTag = "sortedFields";

		// Token: 0x04000253 RID: 595
		private const string SortedFieldTag = "sortedField";

		// Token: 0x04000254 RID: 596
		private const string FieldsTag = "fields";

		// Token: 0x04000255 RID: 597
		private const string FieldTag = "field";

		// Token: 0x04000256 RID: 598
		private const string ParentFieldLayoutTag = "parentFieldLayout";

		// Token: 0x04000257 RID: 599
		private const string CardViewSettingsTag = "CardViewSettings";

		// Token: 0x04000258 RID: 600
		private const string VersionAttrib = "version";

		// Token: 0x04000259 RID: 601
		private const string KeyAttrib = "key";

		// Token: 0x0400025A RID: 602
		private const string DirectionAttrib = "direction";

		// Token: 0x0400025B RID: 603
		private const string FieldNameAttrib = "fieldName";

		// Token: 0x0400025C RID: 604
		private const string IsGroupByAttrib = "isGroupBy";

		// Token: 0x0400025D RID: 605
		private const string ExtentAttrib = "extent";

		// Token: 0x0400025E RID: 606
		private const string NameAttrib = "name";

		// Token: 0x0400025F RID: 607
		private const string LabelWidthAttrib = "labelWidth";

		// Token: 0x04000260 RID: 608
		private const string LabelHeightAttrib = "labelHeight";

		// Token: 0x04000261 RID: 609
		private const string CellWidthAttrib = "cellWidth";

		// Token: 0x04000262 RID: 610
		private const string CellHeightAttrib = "cellHeight";

		// Token: 0x04000263 RID: 611
		private const string RowAttrib = "row";

		// Token: 0x04000264 RID: 612
		private const string ColumnAttrib = "column";

		// Token: 0x04000265 RID: 613
		private const string RowSpanAttrib = "rowSpan";

		// Token: 0x04000266 RID: 614
		private const string ColumnSpanAttrib = "columnSpan";

		// Token: 0x04000267 RID: 615
		private const string ParentFieldNameAttrib = "parentFieldName";

		// Token: 0x04000268 RID: 616
		private const string IsCollapsedInLayoutAttrib = "isCollapsedInLayout";

		// Token: 0x04000269 RID: 617
		private const string VisibilityAttrib = "Visibility";

		// Token: 0x0400026A RID: 618
		private const string OrientationAttrib = "orientation";

		// Token: 0x0400026B RID: 619
		private const string FormatVersionAttrib = "formatVersion";

		// Token: 0x0400026C RID: 620
		private const string FieldListAttrib = "fieldList";

		// Token: 0x0400026D RID: 621
		private const string FieldExtendedInfo = "extendedInfo";

		// Token: 0x0400026E RID: 622
		private const string RecordFiltersTag = "recordFilters";

		// Token: 0x0400026F RID: 623
		private const string FixedLocationAttrib = "FixedLocation";

		// Token: 0x04000270 RID: 624
		private const string IgnoreFieldVisibilityOverrides = "IgnoreFieldVisibilityOverrides";

		// Token: 0x04000271 RID: 625
		private const string LabelWidthAutoAttrib = "labelWidthAuto";

		// Token: 0x04000272 RID: 626
		private const string LabelHeightAutoAttrib = "labelHeightAuto";

		// Token: 0x04000273 RID: 627
		private const string CellWidthAutoAttrib = "cellWidthAuto";

		// Token: 0x04000274 RID: 628
		private const string CellHeightAutoAttrib = "cellHeightAuto";

		// Token: 0x04000275 RID: 629
		private const string SummariesTag = "summaries";

		// Token: 0x04000276 RID: 630
		private const string ExcludeCustomizations = "ExcludeCustomizationsAttrib";

		// Token: 0x04000277 RID: 631
		private const string CardWidthAttrib = "CardWidth";

		// Token: 0x04000278 RID: 632
		private const string CardHeightAttrib = "CardHeight";

		// Token: 0x04000279 RID: 633
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x0400027A RID: 634
		private global::System.Xml.XmlDocument _currentLoadedDocument;

		// Token: 0x0400027B RID: 635
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutCustomizationInfo> _fieldLayoutCustomizationInfos;

		// Token: 0x0400027C RID: 636
		private bool _allLoadedCustomizationsApplied;

		// Token: 0x0400027D RID: 637
		private double _formatVersion = 1.8;

		// Token: 0x0400027E RID: 638
		[global::System.ThreadStatic]
		private static global::Infragistics.ListParser g_parser_ListOfItems;

		// Token: 0x0200009A RID: 154
		private class FieldDescription
		{
			// Token: 0x060007C9 RID: 1993 RVA: 0x00020873 File Offset: 0x0001EA73
			private FieldDescription()
			{
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x0002087B File Offset: 0x0001EA7B
			internal FieldDescription(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string name, string typeName, bool isUnbound, string bindingPath)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(manager);
				this._manager = manager;
				this._name = name;
				this._typeName = typeName;
				this._isUnbound = isUnbound;
				this._bindingPath = bindingPath;
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x000208B0 File Offset: 0x0001EAB0
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
				this._isUnbound = (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding);
				if (this._isUnbound)
				{
					global::System.Windows.PropertyPath propertyPath = field.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingPathProperty) as global::System.Windows.PropertyPath;
					if (propertyPath != null)
					{
						this._bindingPath = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingPathString(propertyPath);
						return;
					}
					global::System.Windows.Data.BindingBase alternateBinding = field.AlternateBinding;
					if (alternateBinding != null)
					{
						this._bindingPath = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.GetBindingString(alternateBinding);
					}
				}
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x0002094F File Offset: 0x0001EB4F
			private static string GetBindingPathString(global::System.Windows.PropertyPath bindingPath)
			{
				return (string)global::Infragistics.CoreUtilities.ConvertDataValue(bindingPath, typeof(string), global::System.Globalization.CultureInfo.InvariantCulture, null);
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x0002096C File Offset: 0x0001EB6C
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

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x00020AE8 File Offset: 0x0001ECE8
			private static global::Infragistics.ListParser Parser
			{
				get
				{
					if (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.g_parser_ListOfItems == null)
					{
						global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.g_parser_ListOfItems = new global::Infragistics.ListParser('"', '"', '\\', ';');
					}
					return global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.g_parser_ListOfItems;
				}
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x00020B08 File Offset: 0x0001ED08
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				this.ToString(stringBuilder);
				return stringBuilder.ToString();
			}

			// Token: 0x060007D0 RID: 2000 RVA: 0x00020B28 File Offset: 0x0001ED28
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

			// Token: 0x060007D1 RID: 2001 RVA: 0x00020BAC File Offset: 0x0001EDAC
			public static global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription Parse(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string val)
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription fieldDescription = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription();
				fieldDescription.ParseHelper(manager, val);
				return fieldDescription;
			}

			// Token: 0x060007D2 RID: 2002 RVA: 0x00020BC8 File Offset: 0x0001EDC8
			private void ParseHelper(global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, string val)
			{
				this._manager = manager;
				global::System.Collections.Generic.IList<string> list = global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription.Parser.ParseList(val, false);
				if (list != null && list.Count >= 1)
				{
					this._name = list[0];
					if (list.Count >= 2)
					{
						this._typeName = list[1];
					}
					else
					{
						this._typeName = typeof(string).Name;
					}
					if (list.Count >= 3)
					{
						this._isUnbound = ("unbound" == list[2]);
					}
					if (list.Count >= 4)
					{
						this._bindingPath = list[3];
					}
				}
			}

			// Token: 0x0400027F RID: 639
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager _manager;

			// Token: 0x04000280 RID: 640
			internal string _name;

			// Token: 0x04000281 RID: 641
			internal string _typeName;

			// Token: 0x04000282 RID: 642
			internal bool _isUnbound;

			// Token: 0x04000283 RID: 643
			internal string _bindingPath;

			// Token: 0x04000284 RID: 644
			[global::System.ThreadStatic]
			private static global::Infragistics.ListParser g_parser_ListOfItems;
		}

		// Token: 0x0200009B RID: 155
		private class FieldLayoutDescription
		{
			// Token: 0x060007D3 RID: 2003 RVA: 0x00020C68 File Offset: 0x0001EE68
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

			// Token: 0x060007D4 RID: 2004 RVA: 0x00020CEC File Offset: 0x0001EEEC
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

			// Token: 0x060007D5 RID: 2005 RVA: 0x00020D3E File Offset: 0x0001EF3E
			public override int GetHashCode()
			{
				if (this._key == null)
				{
					return 0;
				}
				return this._key.GetHashCode();
			}

			// Token: 0x060007D6 RID: 2006 RVA: 0x00020D58 File Offset: 0x0001EF58
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

			// Token: 0x060007D7 RID: 2007 RVA: 0x00020DBC File Offset: 0x0001EFBC
			private static bool AreEqual(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> x, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> y, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer)
			{
				bool flag;
				bool result;
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.IsSubsetOfHelper(x, y, comparer, out flag, out result);
				return result;
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x00020DD8 File Offset: 0x0001EFD8
			private static bool IsSubsetOf(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> x, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> y, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer comparer)
			{
				bool result;
				bool flag;
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.IsSubsetOfHelper(x, y, comparer, out result, out flag);
				return result;
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x00020DF4 File Offset: 0x0001EFF4
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

			// Token: 0x060007DA RID: 2010 RVA: 0x00020EB4 File Offset: 0x0001F0B4
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

			// Token: 0x060007DB RID: 2011 RVA: 0x00020EE8 File Offset: 0x0001F0E8
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

			// Token: 0x060007DC RID: 2012 RVA: 0x00020F58 File Offset: 0x0001F158
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

			// Token: 0x04000285 RID: 645
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager _manager;

			// Token: 0x04000286 RID: 646
			private string _key;

			// Token: 0x04000287 RID: 647
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription[] _fieldList;

			// Token: 0x04000288 RID: 648
			internal double _nodeFormatVersion;

			// Token: 0x04000289 RID: 649
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer _fieldDescriptionComparer;

			// Token: 0x0400028A RID: 650
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription> _cachedFsds;

			// Token: 0x0400028B RID: 651
			internal readonly global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer[] _criteriaComparers;

			// Token: 0x0400028C RID: 652
			private static readonly global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria[] g_criterias = new global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria[]
			{
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.All,
				global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.Name | global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.BindingPath | global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.IsUnbound
			};

			// Token: 0x0200009C RID: 156
			[global::System.Flags]
			internal enum FieldMatchCriteria
			{
				// Token: 0x0400028E RID: 654
				Name = 1,
				// Token: 0x0400028F RID: 655
				TypeName = 2,
				// Token: 0x04000290 RID: 656
				BindingPath = 4,
				// Token: 0x04000291 RID: 657
				IsUnbound = 8,
				// Token: 0x04000292 RID: 658
				All = 15
			}

			// Token: 0x0200009D RID: 157
			internal class FieldDescriptionEqualityComparer : global::System.Collections.IEqualityComparer
			{
				// Token: 0x060007DE RID: 2014 RVA: 0x00021060 File Offset: 0x0001F260
				internal FieldDescriptionEqualityComparer(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription fieldLayoutDescription, global::Infragistics.Windows.DataPresenter.CustomizationsManager manager, global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria criteria)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(manager);
					this._manager = manager;
					this._fieldLayoutDescription = fieldLayoutDescription;
					this._criteria = criteria;
					this._formatVersion = ((this._fieldLayoutDescription != null) ? this._fieldLayoutDescription._nodeFormatVersion : this._manager._formatVersion);
				}

				// Token: 0x060007DF RID: 2015 RVA: 0x000210B4 File Offset: 0x0001F2B4
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

				// Token: 0x060007E0 RID: 2016 RVA: 0x00021178 File Offset: 0x0001F378
				public int GetHashCode(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription obj)
				{
					if (this._formatVersion >= 1.1)
					{
						return (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.Name & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._name)) ^ (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.TypeName & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._typeName)) ^ (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.BindingPath & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : ((this._formatVersion >= 1.6) ? global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._bindingPath) : 0)) ^ (((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria.IsUnbound & this._criteria) == (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria)0) ? 0 : obj._isUnbound.GetHashCode());
					}
					return global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldDescriptionEqualityComparer.GetStringHashHelper(obj._name);
				}

				// Token: 0x060007E1 RID: 2017 RVA: 0x00021219 File Offset: 0x0001F419
				private static int GetStringHashHelper(string s)
				{
					if (s == null)
					{
						return 0;
					}
					return s.GetHashCode();
				}

				// Token: 0x060007E2 RID: 2018 RVA: 0x00021226 File Offset: 0x0001F426
				bool global::System.Collections.IEqualityComparer.Equals(object x, object y)
				{
					return this.Equals((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription)x, (global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription)y);
				}

				// Token: 0x060007E3 RID: 2019 RVA: 0x0002123A File Offset: 0x0001F43A
				int global::System.Collections.IEqualityComparer.GetHashCode(object obj)
				{
					return this.GetHashCode((global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldDescription)obj);
				}

				// Token: 0x04000293 RID: 659
				private global::Infragistics.Windows.DataPresenter.CustomizationsManager _manager;

				// Token: 0x04000294 RID: 660
				private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription _fieldLayoutDescription;

				// Token: 0x04000295 RID: 661
				private double _formatVersion;

				// Token: 0x04000296 RID: 662
				private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription.FieldMatchCriteria _criteria;
			}
		}

		// Token: 0x0200009E RID: 158
		private class FieldLayoutCustomizationInfo
		{
			// Token: 0x060007E4 RID: 2020 RVA: 0x00021248 File Offset: 0x0001F448
			internal FieldLayoutCustomizationInfo(global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription key)
			{
				this._key = key;
			}

			// Token: 0x060007E5 RID: 2021 RVA: 0x00021257 File Offset: 0x0001F457
			internal bool ExcludeCustomization(global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
			{
				return customizationType == (customizationType & this._excludeCustomizations);
			}

			// Token: 0x04000297 RID: 663
			internal bool _customizationsApplied;

			// Token: 0x04000298 RID: 664
			private global::Infragistics.Windows.DataPresenter.CustomizationsManager.FieldLayoutDescription _key;

			// Token: 0x04000299 RID: 665
			internal global::Infragistics.Windows.DataPresenter.CustomizationType _excludeCustomizations;

			// Token: 0x0400029A RID: 666
			internal global::System.Xml.XmlNode _fieldLayoutNode;

			// Token: 0x0400029B RID: 667
			internal double _nodeFormatVersion;
		}
	}
}
