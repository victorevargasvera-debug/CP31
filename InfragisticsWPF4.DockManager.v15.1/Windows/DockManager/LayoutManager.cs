using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000075 RID: 117
	internal static class LayoutManager
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x00015B24 File Offset: 0x00013D24
		public static void LoadLayout(global::Infragistics.Windows.DockManager.XamDockManager dockManager, string layout)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
				streamWriter.Write(layout);
				streamWriter.Flush();
				memoryStream.Position = 0L;
				global::Infragistics.Windows.DockManager.LayoutManager.LoadLayout(dockManager, memoryStream);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00015B78 File Offset: 0x00013D78
		public static void LoadLayout(global::Infragistics.Windows.DockManager.XamDockManager dockManager, global::System.IO.Stream stream)
		{
			if (dockManager.IsLoadingLayout)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutInProgress"));
			}
			dockManager.OnBeforeLoadLayoutProcess();
			dockManager.IsLoadingLayout = true;
			bool canChangeActivePane = dockManager.ActivePane != null;
			global::Infragistics.Windows.Helpers.GroupTempValueReplacement groupTempValueReplacement = new global::Infragistics.Windows.Helpers.GroupTempValueReplacement();
			try
			{
				using (global::System.IO.BufferedStream bufferedStream = new global::System.IO.BufferedStream(stream))
				{
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(bufferedStream);
					global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode("xamDockManager");
					if (xmlNode == null)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutInvalidRootElement", new object[]
						{
							"xamDockManager"
						}));
					}
					new global::System.Version(xmlNode.Attributes["version"].Value);
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.ContentPane> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.ContentPane>();
					global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
					foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in global::Infragistics.Windows.DockManager.DockManagerUtilities.GetAllPanes(dockManager, global::Infragistics.Windows.DockManager.PaneFilterFlags.All))
					{
						if (!string.IsNullOrEmpty(contentPane.Name))
						{
							dictionary.Add(contentPane.Name, contentPane);
						}
						list.Add(contentPane);
					}
					global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> oldOrder = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>(dockManager.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder));
					dockManager.OnBeforeLoadLayout();
					global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo parseInfo = new global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo(dockManager);
					global::System.Xml.XmlNode xmlNode2 = xmlNode.SelectSingleNode("contentPanes");
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo> dictionary2 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo>();
					foreach (object obj in xmlNode2.SelectNodes("contentPane"))
					{
						global::System.Xml.XmlNode xmlNode3 = (global::System.Xml.XmlNode)obj;
						string value = xmlNode3.Attributes["name"].Value;
						string serializationId = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode3, "serializationId", null);
						global::Infragistics.Windows.DockManager.ContentPane newPane;
						if (!dictionary.TryGetValue(value, out newPane))
						{
							global::Infragistics.Windows.DockManager.ContentPane contentPane2 = new global::Infragistics.Windows.DockManager.ContentPane();
							contentPane2.Name = value;
							contentPane2.SerializationId = serializationId;
							global::Infragistics.Windows.DockManager.Events.InitializePaneContentEventArgs initializePaneContentEventArgs = new global::Infragistics.Windows.DockManager.Events.InitializePaneContentEventArgs(contentPane2);
							dockManager.RaiseInitializePaneContent(initializePaneContentEventArgs);
							if (initializePaneContentEventArgs.NewPane != null)
							{
								if (global::System.Windows.LogicalTreeHelper.GetParent(initializePaneContentEventArgs.NewPane) != null || global::System.Windows.Media.VisualTreeHelper.GetParent(initializePaneContentEventArgs.NewPane) != null)
								{
									throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_NewPaneCannotHaveParent"));
								}
								if (contentPane2.Content != null || contentPane2 != initializePaneContentEventArgs.NewPane)
								{
									newPane = initializePaneContentEventArgs.NewPane;
								}
							}
						}
						if (newPane != null)
						{
							if (dictionary2.ContainsKey(newPane))
							{
								throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_PaneAlreadyReferencedInLayout"));
							}
							global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo contentPaneInfo = new global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo();
							contentPaneInfo.Pane = newPane;
							contentPaneInfo.SerializationId = serializationId;
							global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)255;
							global::System.Windows.Visibility visibility2 = global::Infragistics.Windows.DockManager.LayoutManager.ReadEnumAttribute<global::System.Windows.Visibility>(xmlNode3, "visibility", visibility);
							if (visibility2 == visibility)
							{
								visibility2 = (global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode3, "isClosed", false) ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
							}
							contentPaneInfo.Visibility = visibility2;
							contentPaneInfo.Location = global::Infragistics.Windows.DockManager.LayoutManager.ReadEnumAttribute<global::Infragistics.Windows.DockManager.PaneLocation>(xmlNode3, "location", global::Infragistics.Windows.DockManager.PaneLocation.Unknown);
							contentPaneInfo.UnpinnedOrder = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode3, "unpinnedOrder", 0);
							contentPaneInfo.LastActivatedTime = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode3, "lastActivatedTime", global::System.DateTime.MinValue);
							contentPaneInfo.LastFloatingSize = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Size>(xmlNode3, "lastFloatingSize", global::System.Windows.Size.Empty);
							contentPaneInfo.LastFloatingWindowRect = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Rect>(xmlNode3, "lastFloatingWindowRect", global::System.Windows.Rect.Empty);
							contentPaneInfo.FlyoutExtent = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode3, "flyoutExtent", double.NaN);
							contentPaneInfo.LastFloatingPoint = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Point?>(xmlNode3, "lastFloatingLocation", null);
							if (contentPaneInfo.Location == global::Infragistics.Windows.DockManager.PaneLocation.Unknown)
							{
								throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutInvalidPaneLocation", new object[]
								{
									value
								}));
							}
							if (contentPaneInfo.Location == global::Infragistics.Windows.DockManager.PaneLocation.Document && !dockManager.HasDocumentContentHost)
							{
								throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutNoDocumentContentHost", new object[]
								{
									value
								}));
							}
							try
							{
								contentPaneInfo.LastDockableState = global::Infragistics.Windows.DockManager.LayoutManager.ReadEnumAttribute<global::Infragistics.Windows.DockManager.DockableState>(xmlNode3, "lastDockableState", global::Infragistics.Windows.DockManager.DockableState.Floating);
							}
							catch
							{
								switch (contentPaneInfo.Location)
								{
								case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
								case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
									contentPaneInfo.LastDockableState = global::Infragistics.Windows.DockManager.DockableState.Floating;
									break;
								default:
									contentPaneInfo.LastDockableState = global::Infragistics.Windows.DockManager.DockableState.Docked;
									break;
								}
							}
							parseInfo.LoadedPanes.Add(value, contentPaneInfo);
							dictionary2.Add(newPane, contentPaneInfo);
						}
						else
						{
							parseInfo.LoadedPanes.Add(value, null);
						}
					}
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo> keyValuePair in parseInfo.LoadedPanes)
					{
						global::Infragistics.Windows.DockManager.ContentPane contentPane3 = (keyValuePair.Value != null) ? keyValuePair.Value.Pane : null;
						if (contentPane3 != null)
						{
							global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement, contentPane3);
							dockManager.ClosePaneHelper(contentPane3, global::Infragistics.Windows.DockManager.PaneCloseAction.RemovePane, false);
							contentPane3.IsPinned = true;
							contentPane3.ClearValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty);
						}
					}
					global::System.Xml.XmlNode xmlNode4 = xmlNode.SelectSingleNode("panes");
					if (xmlNode4 != null)
					{
						global::System.Xml.XmlNodeList xmlNodeList = xmlNode4.SelectNodes("splitPane");
						foreach (object obj2 in xmlNodeList)
						{
							global::System.Xml.XmlNode xmlNode5 = (global::System.Xml.XmlNode)obj2;
							global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.LayoutManager.ReadEnumAttribute<global::Infragistics.Windows.DockManager.PaneLocation>(xmlNode5, "location", global::Infragistics.Windows.DockManager.PaneLocation.Unknown);
							switch (paneLocation)
							{
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
							case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
							case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
							{
								parseInfo.CurrentLocation = paneLocation;
								global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.LayoutManager.LoadSplitPane(xmlNode5, parseInfo);
								if (splitPane != null)
								{
									global::Infragistics.Windows.DockManager.InitialPaneLocation initialLocation = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetInitialLocation(paneLocation);
									global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(splitPane, initialLocation);
									switch (paneLocation)
									{
									case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
									case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
									case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
									case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
									{
										double num = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode5, "extent", double.NaN);
										if (!double.IsNaN(num))
										{
											if (paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.DockedRight || paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft)
											{
												splitPane.Width = num;
											}
											else
											{
												splitPane.Height = num;
											}
										}
										else
										{
											splitPane.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
											splitPane.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
										}
										break;
									}
									case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
									case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
									{
										global::System.Windows.Size value2 = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Size>(xmlNode5, "floatingSize", global::System.Windows.Size.Empty);
										global::System.Windows.Point value3 = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Point>(xmlNode5, "floatingLocation", default(global::System.Windows.Point));
										global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingLocation(splitPane, new global::System.Windows.Point?(value3));
										if (!value2.IsEmpty)
										{
											global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane, value2);
										}
										else
										{
											splitPane.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.FloatingSizeProperty);
										}
										break;
									}
									}
									dockManager.Panes.Add(splitPane);
									switch (paneLocation)
									{
									case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
									case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
									{
										global::System.Windows.WindowState windowState = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.WindowState>(xmlNode5, "windowState", global::System.Windows.WindowState.Normal);
										global::System.Windows.Rect restoreBounds = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Rect>(xmlNode5, "restoreBounds", global::System.Windows.Rect.Empty);
										bool restoreToMaximized = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(xmlNode5, "restoreToMaximized", false);
										global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(splitPane);
										if (toolWindow != null)
										{
											toolWindow.WindowState = windowState;
											if (windowState != global::System.Windows.WindowState.Normal)
											{
												toolWindow.SetRestoreBounds(restoreBounds);
											}
											if (windowState == global::System.Windows.WindowState.Minimized)
											{
												toolWindow.RestoreToMaximized = restoreToMaximized;
											}
										}
										break;
									}
									}
									splitPane.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.FromValue(paneLocation));
								}
								break;
							}
							}
						}
					}
					global::System.Xml.XmlNode xmlNode6 = xmlNode.SelectSingleNode("documents");
					if (xmlNode6 != null && dockManager.HasDocumentContentHost)
					{
						dockManager.DocumentContentHost.RootSplitterOrientation = global::Infragistics.Windows.DockManager.LayoutManager.ParseEnum<global::System.Windows.Controls.Orientation>(xmlNode6.Attributes["splitterOrientation"].Value);
						global::System.Xml.XmlNodeList xmlNodeList2 = xmlNode6.SelectNodes("splitPane");
						if (xmlNodeList2 != null)
						{
							global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.SplitPane> panes = dockManager.DocumentContentHost.Panes;
							parseInfo.CurrentLocation = global::Infragistics.Windows.DockManager.PaneLocation.Document;
							foreach (object obj3 in xmlNodeList2)
							{
								global::System.Xml.XmlNode paneNode = (global::System.Xml.XmlNode)obj3;
								global::Infragistics.Windows.DockManager.SplitPane splitPane2 = global::Infragistics.Windows.DockManager.LayoutManager.LoadSplitPane(paneNode, parseInfo);
								if (splitPane2 != null)
								{
									panes.Add(splitPane2);
								}
							}
						}
					}
					global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo>[] array = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo>[4];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo>();
					}
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo> keyValuePair2 in parseInfo.LoadedPanes)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo value4 = keyValuePair2.Value;
						global::Infragistics.Windows.DockManager.ContentPane contentPane4 = (value4 != null) ? value4.Pane : null;
						if (contentPane4 != null)
						{
							switch (value4.Location)
							{
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
							case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
								if (contentPane4.PlacementInfo.DockedEdgePlaceholder == null)
								{
									throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutPanePositionNotFound", new object[]
									{
										contentPane4.Name,
										value4.Location
									}));
								}
								contentPane4.PlacementInfo.DockedContainer.InsertContentPane(null, contentPane4);
								break;
							case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
								if (contentPane4.PlacementInfo.FloatingDockablePlaceholder == null)
								{
									throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutPanePositionNotFound", new object[]
									{
										contentPane4.Name,
										value4.Location
									}));
								}
								contentPane4.PlacementInfo.FloatingDockablePlaceholder.Container.InsertContentPane(null, contentPane4);
								break;
							case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
								if (contentPane4.PlacementInfo.FloatingOnlyPlaceholder == null)
								{
									throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutPanePositionNotFound", new object[]
									{
										contentPane4.Name,
										value4.Location
									}));
								}
								contentPane4.PlacementInfo.FloatingOnlyPlaceholder.Container.InsertContentPane(null, contentPane4);
								break;
							case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
							{
								if (contentPane4.PlacementInfo.DockedEdgePlaceholder == null)
								{
									throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutPanePositionNotFound", new object[]
									{
										contentPane4.Name,
										value4.Location
									}));
								}
								contentPane4.PlacementInfo.DockedContainer.InsertContentPane(null, contentPane4);
								global::System.Windows.Controls.Dock dockedSide = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedSide(contentPane4.PaneLocation);
								array[(int)dockedSide].Add(new global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo(contentPane4, value4.UnpinnedOrder));
								contentPane4.IsPinned = false;
								if (!double.IsNaN(value4.FlyoutExtent))
								{
									global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.SetFlyoutExtent(contentPane4, value4.FlyoutExtent);
								}
								else
								{
									contentPane4.ClearValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutExtentProperty);
								}
								dockManager.ProcessPinnedState(contentPane4, contentPane4.PaneLocation, false);
								break;
							}
							case global::Infragistics.Windows.DockManager.PaneLocation.Document:
								if (contentPane4.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Document)
								{
									throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutPanePositionNotFound", new object[]
									{
										contentPane4.Name,
										value4.Location
									}));
								}
								break;
							}
							if (contentPane4.LastActivatedTime < value4.LastActivatedTime)
							{
								contentPane4.LastActivatedTime = value4.LastActivatedTime;
							}
							contentPane4.LastFloatingSize = value4.LastFloatingSize;
							contentPane4.LastFloatingWindowRect = value4.LastFloatingWindowRect;
							contentPane4.LastFloatingLocation = value4.LastFloatingPoint;
							contentPane4.PlacementInfo.VerifyLastDockableContainer(value4.LastDockableState);
							contentPane4.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.FromValue(value4.Visibility));
						}
					}
					dockManager.ActivePaneManager.RefreshActivePaneSortOrder(oldOrder);
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j].Count > 1)
						{
							global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo unpinnedTabAreaInfo = dockManager.GetUnpinnedTabAreaInfo((global::System.Windows.Controls.Dock)j);
							unpinnedTabAreaInfo.SortPanes(array[j]);
						}
					}
				}
			}
			finally
			{
				dockManager.IsLoadingLayout = false;
				groupTempValueReplacement.Dispose();
				dockManager.ActivePaneManager.ResetActivePanesAfterLoad(canChangeActivePane);
				dockManager.OnAfterLoadLayout();
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000167D4 File Offset: 0x000149D4
		public static string SaveLayout(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::Infragistics.Windows.DockManager.LayoutManager.SaveLayout(dockManager, memoryStream);
				memoryStream.Position = 0L;
				global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream);
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00016824 File Offset: 0x00014A24
		public static void SaveLayout(global::Infragistics.Windows.DockManager.XamDockManager dockManager, global::System.IO.Stream stream)
		{
			dockManager.OnBeforeSaveLayout();
			global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(stream, global::System.Text.Encoding.UTF8);
			xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("xamDockManager");
			xmlTextWriter.WriteAttributeString("version", "15.1.20151.2008");
			xmlTextWriter.WriteStartElement("contentPanes");
			global::Infragistics.Windows.DockManager.LayoutManager.SerializationInfo serializationInfo = new global::Infragistics.Windows.DockManager.LayoutManager.SerializationInfo();
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dockManager.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder))
			{
				if (contentPane.SaveInLayout)
				{
					xmlTextWriter.WriteStartElement("contentPane");
					if (string.IsNullOrEmpty(contentPane.Name) || serializationInfo.NamedPanes.ContainsKey(contentPane.Name))
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_SaveLayoutPaneNameMissing"));
					}
					serializationInfo.NamedPanes.Add(contentPane.Name, contentPane);
					xmlTextWriter.WriteAttributeString("name", contentPane.Name);
					global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "location", contentPane.PaneLocation);
					if (contentPane.PlacementInfo.DockableContainer != contentPane.PlacementInfo.CurrentContainer && contentPane.PlacementInfo.DockableContainer != null)
					{
						global::Infragistics.Windows.DockManager.DockableState dockableState = global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(contentPane.PlacementInfo.DockableContainer.PaneLocation) ? global::Infragistics.Windows.DockManager.DockableState.Docked : global::Infragistics.Windows.DockManager.DockableState.Floating;
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "lastDockableState", dockableState);
					}
					if (!contentPane.LastFloatingSize.IsEmpty)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "lastFloatingSize", contentPane.LastFloatingSize);
					}
					if (!contentPane.LastFloatingWindowRect.IsEmpty)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "lastFloatingWindowRect", contentPane.LastFloatingWindowRect);
					}
					global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "lastFloatingLocation", contentPane.LastFloatingLocation);
					if (contentPane.LastActivatedTime != global::System.DateTime.MinValue)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "lastActivatedTime", contentPane.LastActivatedTime);
					}
					if (!string.IsNullOrEmpty(contentPane.SerializationId))
					{
						xmlTextWriter.WriteAttributeString("serializationId", contentPane.SerializationId);
					}
					if (contentPane.Visibility != global::System.Windows.Visibility.Visible)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "visibility", contentPane.Visibility);
					}
					if (!contentPane.IsPinned)
					{
						global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = contentPane.PlacementInfo.CurrentContainer;
						global::Infragistics.Windows.DockManager.UnpinnedTabArea unpinnedTabArea = (currentContainer != null) ? (currentContainer.ContainerElement as global::Infragistics.Windows.DockManager.UnpinnedTabArea) : null;
						if (unpinnedTabArea != null)
						{
							global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "unpinnedOrder", unpinnedTabArea.Items.IndexOf(contentPane));
						}
						if (!double.IsNaN(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.GetFlyoutExtent(contentPane)))
						{
							global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(xmlTextWriter, "flyoutExtent", global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.GetFlyoutExtent(contentPane));
						}
					}
					xmlTextWriter.WriteEndElement();
				}
			}
			xmlTextWriter.WriteEndElement();
			if (serializationInfo.NamedPanes.Count > 0)
			{
				if (dockManager.Panes.Count > 0)
				{
					xmlTextWriter.WriteStartElement("panes");
					foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane in dockManager.Panes)
					{
						if (serializationInfo.ShouldSerialize(splitPane))
						{
							global::Infragistics.Windows.DockManager.LayoutManager.WriteSplitPane(xmlTextWriter, splitPane, true, serializationInfo);
						}
					}
					xmlTextWriter.WriteEndElement();
				}
				if (dockManager.DocumentContentHost != null)
				{
					xmlTextWriter.WriteStartElement("documents");
					xmlTextWriter.WriteAttributeString("splitterOrientation", dockManager.DocumentContentHost.RootSplitterOrientation.ToString());
					foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane2 in dockManager.DocumentContentHost.Panes)
					{
						if (serializationInfo.ShouldSerialize(splitPane2))
						{
							global::Infragistics.Windows.DockManager.LayoutManager.WriteSplitPane(xmlTextWriter, splitPane2, false, serializationInfo);
						}
					}
					xmlTextWriter.WriteEndElement();
				}
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Flush();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00016BF8 File Offset: 0x00014DF8
		private static object[] GetItems(global::System.Collections.IList list)
		{
			object[] array = new object[list.Count];
			list.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00016C1C File Offset: 0x00014E1C
		private static global::System.Windows.FrameworkElement LoadContentPane(global::System.Xml.XmlNode paneNode, global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo parseInfo)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(paneNode, "name", null);
			if (text == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutMissingName"));
			}
			global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo contentPaneInfo;
			if (!parseInfo.LoadedPanes.TryGetValue(text, out contentPaneInfo))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_LoadLayoutUndefinedContentPane", new object[]
				{
					text
				}));
			}
			if (contentPaneInfo == null || contentPaneInfo.Pane == null)
			{
				return null;
			}
			global::System.Windows.FrameworkElement frameworkElement;
			if (parseInfo.CurrentLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				frameworkElement = contentPaneInfo.Pane;
			}
			else
			{
				global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = new global::Infragistics.Windows.DockManager.ContentPanePlaceholder();
				contentPanePlaceholder.Initialize(contentPaneInfo.Pane);
				contentPaneInfo.Pane.PlacementInfo.StorePlaceholder(contentPanePlaceholder, parseInfo.CurrentLocation);
				frameworkElement = contentPanePlaceholder;
			}
			global::System.Windows.Size value = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Size>(paneNode, "relativeSize", global::System.Windows.Size.Empty);
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(frameworkElement, value);
			}
			return frameworkElement;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00016CE8 File Offset: 0x00014EE8
		private static global::Infragistics.Windows.DockManager.SplitPane LoadSplitPane(global::System.Xml.XmlNode paneNode, global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo parseInfo)
		{
			string name = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(paneNode, "name", string.Empty);
			global::System.Windows.Size relativeSize = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Size>(paneNode, "relativeSize", global::System.Windows.Size.Empty);
			global::System.Windows.Controls.Orientation orientation = global::Infragistics.Windows.DockManager.LayoutManager.ReadEnumAttribute<global::System.Windows.Controls.Orientation>(paneNode, "splitterOrientation", global::Infragistics.Windows.DockManager.LayoutManager.DefaultSplitterOrientation);
			global::Infragistics.Windows.DockManager.SplitPane orCreateSplitPane = parseInfo.GetOrCreateSplitPane(name, relativeSize, orientation);
			object[] items = global::Infragistics.Windows.DockManager.LayoutManager.GetItems(orCreateSplitPane.Panes);
			foreach (object obj in paneNode.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				global::System.Windows.FrameworkElement frameworkElement = null;
				if (xmlNode.Name == "contentPane")
				{
					if (parseInfo.CurrentLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidDocumentSplitPaneChild"));
					}
					frameworkElement = global::Infragistics.Windows.DockManager.LayoutManager.LoadContentPane(xmlNode, parseInfo);
				}
				else if (xmlNode.Name == "tabGroup")
				{
					frameworkElement = global::Infragistics.Windows.DockManager.LayoutManager.LoadTabGroupPane(xmlNode, parseInfo);
				}
				else if (xmlNode.Name == "splitPane")
				{
					frameworkElement = global::Infragistics.Windows.DockManager.LayoutManager.LoadSplitPane(xmlNode, parseInfo);
				}
				if (frameworkElement != null)
				{
					orCreateSplitPane.Panes.Add(frameworkElement);
				}
			}
			if (orCreateSplitPane.Panes.Count == 0 && !global::Infragistics.Windows.DockManager.DockManagerUtilities.ShouldPreventPaneRemoval(orCreateSplitPane))
			{
				return null;
			}
			parseInfo.ReorderOriginalItems(items, orCreateSplitPane, orCreateSplitPane.Panes);
			return orCreateSplitPane;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00016E44 File Offset: 0x00015044
		private static global::Infragistics.Windows.DockManager.TabGroupPane LoadTabGroupPane(global::System.Xml.XmlNode paneNode, global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo parseInfo)
		{
			string name = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(paneNode, "name", string.Empty);
			global::System.Windows.Size relativeSize = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttributeWithConverter<global::System.Windows.Size>(paneNode, "relativeSize", global::System.Windows.Size.Empty);
			global::Infragistics.Windows.DockManager.TabGroupPane orCreateTabGroup = parseInfo.GetOrCreateTabGroup(name, relativeSize);
			int count = orCreateTabGroup.Items.Count;
			object[] items = global::Infragistics.Windows.DockManager.LayoutManager.GetItems(orCreateTabGroup.Items);
			foreach (object obj in paneNode.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				global::System.Windows.FrameworkElement frameworkElement = null;
				if (xmlNode.Name == "contentPane")
				{
					frameworkElement = global::Infragistics.Windows.DockManager.LayoutManager.LoadContentPane(xmlNode, parseInfo);
				}
				if (frameworkElement != null)
				{
					orCreateTabGroup.Items.Add(frameworkElement);
				}
			}
			int num = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(paneNode, "selectedIndex", -1);
			num += count;
			orCreateTabGroup.SelectedIndex = global::System.Math.Max(-1, global::System.Math.Min(orCreateTabGroup.Items.Count - 1, num));
			if (orCreateTabGroup.Items.Count == 0 && !global::Infragistics.Windows.DockManager.DockManagerUtilities.ShouldPreventPaneRemoval(orCreateTabGroup))
			{
				return null;
			}
			object item = (orCreateTabGroup.SelectedIndex >= 0) ? orCreateTabGroup.Items[orCreateTabGroup.SelectedIndex] : global::System.Windows.DependencyProperty.UnsetValue;
			if (parseInfo.ReorderOriginalItems(items, orCreateTabGroup, orCreateTabGroup.Items))
			{
				orCreateTabGroup.SelectedIndex = orCreateTabGroup.Items.IndexOf(item);
			}
			return orCreateTabGroup;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00016FA8 File Offset: 0x000151A8
		internal static T ParseEnum<T>(string value)
		{
			return (T)((object)global::System.Enum.Parse(typeof(T), value, false));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00016FC0 File Offset: 0x000151C0
		private static string ReadAttribute(global::System.Xml.XmlNode node, string name, string defaultValue)
		{
			global::System.Xml.XmlAttribute xmlAttribute = node.Attributes[name];
			if (xmlAttribute != null)
			{
				return xmlAttribute.Value;
			}
			return defaultValue;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00016FE8 File Offset: 0x000151E8
		private static bool ReadAttribute(global::System.Xml.XmlNode node, string name, bool defaultValue)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToBoolean(text);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001700C File Offset: 0x0001520C
		private static int ReadAttribute(global::System.Xml.XmlNode node, string name, int defaultValue)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToInt32(text);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00017030 File Offset: 0x00015230
		private static global::System.DateTime ReadAttribute(global::System.Xml.XmlNode node, string name, global::System.DateTime defaultValue)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToDateTime(text, global::System.Xml.XmlDateTimeSerializationMode.Local);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00017054 File Offset: 0x00015254
		private static double ReadAttribute(global::System.Xml.XmlNode node, string name, double defaultValue)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return global::System.Xml.XmlConvert.ToDouble(text);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00017078 File Offset: 0x00015278
		private static T ReadAttributeWithConverter<T>(global::System.Xml.XmlNode node, string name, T defaultValue)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
			return (T)((object)converter.ConvertFromString(null, global::System.Globalization.CultureInfo.InvariantCulture, text));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000170B8 File Offset: 0x000152B8
		private static T ReadEnumAttribute<T>(global::System.Xml.XmlNode node, string name, T defaultValue)
		{
			string text = global::Infragistics.Windows.DockManager.LayoutManager.ReadAttribute(node, name, null);
			if (text == null)
			{
				return defaultValue;
			}
			return (T)((object)global::System.Enum.Parse(defaultValue.GetType(), text));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000170EB File Offset: 0x000152EB
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, double value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000170FA File Offset: 0x000152FA
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Enum value)
		{
			writer.WriteAttributeString(name, value.ToString());
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00017109 File Offset: 0x00015309
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, int value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00017118 File Offset: 0x00015318
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, bool value)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(value));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00017127 File Offset: 0x00015327
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Size value)
		{
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, name, value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Size)));
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001714E File Offset: 0x0001534E
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Rect value)
		{
			if (!value.IsEmpty)
			{
				global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, name, value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Rect)));
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00017175 File Offset: 0x00015375
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, global::System.Windows.Point? value)
		{
			if (value != null)
			{
				global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, name, value.Value, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.Windows.Point)));
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000171A2 File Offset: 0x000153A2
		private static void WriteAttribute(global::System.Xml.XmlWriter writer, string name, object value, global::System.ComponentModel.TypeConverter converter)
		{
			writer.WriteAttributeString(name, converter.ConvertToString(null, global::System.Globalization.CultureInfo.InvariantCulture, value));
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000171B8 File Offset: 0x000153B8
		private static void WriteAttribute(global::System.Xml.XmlTextWriter writer, string name, global::System.DateTime dateTime)
		{
			writer.WriteAttributeString(name, global::System.Xml.XmlConvert.ToString(dateTime, global::System.Xml.XmlDateTimeSerializationMode.Utc));
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000171C8 File Offset: 0x000153C8
		private static void WriteContentPane(global::System.Xml.XmlWriter writer, global::System.Windows.FrameworkElement child, global::Infragistics.Windows.DockManager.LayoutManager.SerializationInfo info)
		{
			writer.WriteStartElement("contentPane");
			string value = (child is global::Infragistics.Windows.DockManager.ContentPanePlaceholder) ? ((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)child).Pane.Name : child.Name;
			writer.WriteAttributeString("name", value);
			global::Infragistics.Windows.DockManager.LayoutManager.WriteRelativeSize(writer, child);
			writer.WriteEndElement();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001721C File Offset: 0x0001541C
		private static void WriteSplitPane(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DockManager.SplitPane pane, bool isRootDmPane, global::Infragistics.Windows.DockManager.LayoutManager.SerializationInfo info)
		{
			writer.WriteStartElement("splitPane");
			if (!string.IsNullOrEmpty(pane.Name))
			{
				if (info.NamedSplits.ContainsKey(pane.Name))
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_MultipleContainersWithSameName", new object[]
					{
						typeof(global::Infragistics.Windows.DockManager.SplitPane),
						pane.Name
					}));
				}
				info.NamedSplits.Add(pane.Name, pane);
				writer.WriteAttributeString("name", pane.Name);
			}
			writer.WriteAttributeString("splitterOrientation", pane.SplitterOrientation.ToString());
			if (isRootDmPane)
			{
				global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane);
				global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "location", paneLocation);
				switch (paneLocation)
				{
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				{
					double widthToSerialize = pane.WidthToSerialize;
					if (!double.IsNaN(widthToSerialize))
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "extent", widthToSerialize);
					}
					break;
				}
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				{
					double heightToSerialize = pane.HeightToSerialize;
					if (!double.IsNaN(heightToSerialize))
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "extent", heightToSerialize);
					}
					break;
				}
				case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
				{
					global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "floatingLocation", global::Infragistics.Windows.DockManager.XamDockManager.GetFloatingLocation(pane));
					global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "floatingSize", global::Infragistics.Windows.DockManager.XamDockManager.GetFloatingSize(pane));
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(pane);
					if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "windowState", toolWindow.WindowState);
						global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "restoreBounds", toolWindow.GetRestoreBounds());
						if (toolWindow.WindowState == global::System.Windows.WindowState.Minimized && toolWindow.RestoreToMaximized)
						{
							global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "restoreToMaximized", true);
						}
					}
					break;
				}
				}
			}
			else
			{
				global::Infragistics.Windows.DockManager.LayoutManager.WriteRelativeSize(writer, pane);
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement in pane.Panes)
			{
				if (info.ShouldSerialize(frameworkElement))
				{
					if (frameworkElement is global::Infragistics.Windows.DockManager.ContentPane || frameworkElement is global::Infragistics.Windows.DockManager.ContentPanePlaceholder)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteContentPane(writer, frameworkElement, info);
					}
					else if (frameworkElement is global::Infragistics.Windows.DockManager.SplitPane)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteSplitPane(writer, (global::Infragistics.Windows.DockManager.SplitPane)frameworkElement, false, info);
					}
					else if (frameworkElement is global::Infragistics.Windows.DockManager.TabGroupPane)
					{
						global::Infragistics.Windows.DockManager.LayoutManager.WriteTabGroup(writer, (global::Infragistics.Windows.DockManager.TabGroupPane)frameworkElement, info);
					}
				}
			}
			writer.WriteEndElement();
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001746C File Offset: 0x0001566C
		private static void WriteRelativeSize(global::System.Xml.XmlWriter writer, global::System.Windows.FrameworkElement element)
		{
			global::System.ComponentModel.PropertyDescriptor propertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty, element.GetType());
			if (propertyDescriptor == null || propertyDescriptor.ShouldSerializeValue(element))
			{
				global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "relativeSize", global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(element));
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000174A8 File Offset: 0x000156A8
		private static void WriteTabGroup(global::System.Xml.XmlWriter writer, global::Infragistics.Windows.DockManager.TabGroupPane group, global::Infragistics.Windows.DockManager.LayoutManager.SerializationInfo info)
		{
			writer.WriteStartElement("tabGroup");
			if (!string.IsNullOrEmpty(group.Name))
			{
				if (info.NamedTabGroups.ContainsKey(group.Name))
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_MultipleContainersWithSameName", new object[]
					{
						typeof(global::Infragistics.Windows.DockManager.TabGroupPane),
						group.Name
					}));
				}
				info.NamedTabGroups.Add(group.Name, group);
				writer.WriteAttributeString("name", group.Name);
			}
			int num = group.SelectedIndex;
			for (int i = 0; i <= num; i++)
			{
				if (!info.ShouldSerialize(group.Items[i]))
				{
					num--;
				}
			}
			global::Infragistics.Windows.DockManager.LayoutManager.WriteAttribute(writer, "selectedIndex", num);
			global::Infragistics.Windows.DockManager.LayoutManager.WriteRelativeSize(writer, group);
			foreach (object obj in ((global::System.Collections.IEnumerable)group.Items))
			{
				if (info.ShouldSerialize(obj) && (obj is global::Infragistics.Windows.DockManager.ContentPane || obj is global::Infragistics.Windows.DockManager.ContentPanePlaceholder))
				{
					global::Infragistics.Windows.DockManager.LayoutManager.WriteContentPane(writer, obj as global::System.Windows.FrameworkElement, info);
				}
			}
			writer.WriteEndElement();
		}

		// Token: 0x0400028F RID: 655
		private const string RootTag = "xamDockManager";

		// Token: 0x04000290 RID: 656
		private const string ContentPanesTag = "contentPanes";

		// Token: 0x04000291 RID: 657
		private const string ContentPaneTag = "contentPane";

		// Token: 0x04000292 RID: 658
		private const string PanesTag = "panes";

		// Token: 0x04000293 RID: 659
		private const string DocumentsTag = "documents";

		// Token: 0x04000294 RID: 660
		private const string SplitPaneTag = "splitPane";

		// Token: 0x04000295 RID: 661
		private const string TabGroupPaneTag = "tabGroup";

		// Token: 0x04000296 RID: 662
		private const string VersionAttrib = "version";

		// Token: 0x04000297 RID: 663
		private const string UnpinnedOrderAttrib = "unpinnedOrder";

		// Token: 0x04000298 RID: 664
		private const string IsClosedAttrib = "isClosed";

		// Token: 0x04000299 RID: 665
		private const string NameAttrib = "name";

		// Token: 0x0400029A RID: 666
		private const string LocationAttrib = "location";

		// Token: 0x0400029B RID: 667
		private const string LastDockableStateAttrib = "lastDockableState";

		// Token: 0x0400029C RID: 668
		private const string SerializationIdAttrib = "serializationId";

		// Token: 0x0400029D RID: 669
		private const string SplitterOrientationAttrib = "splitterOrientation";

		// Token: 0x0400029E RID: 670
		private const string ExtentAttrib = "extent";

		// Token: 0x0400029F RID: 671
		private const string FloatingLocationAttrib = "floatingLocation";

		// Token: 0x040002A0 RID: 672
		private const string FloatingSizeAttrib = "floatingSize";

		// Token: 0x040002A1 RID: 673
		private const string RelativeSizeAttrib = "relativeSize";

		// Token: 0x040002A2 RID: 674
		private const string SelectedIndexAttrib = "selectedIndex";

		// Token: 0x040002A3 RID: 675
		private const string LastActivatedTimeAttrib = "lastActivatedTime";

		// Token: 0x040002A4 RID: 676
		private const string LastFloatingSizeAttrib = "lastFloatingSize";

		// Token: 0x040002A5 RID: 677
		private const string LastFloatingWindowRectAttrib = "lastFloatingWindowRect";

		// Token: 0x040002A6 RID: 678
		private const string LastFloatingLocationAttrib = "lastFloatingLocation";

		// Token: 0x040002A7 RID: 679
		private const string FlyoutExtentAttrib = "flyoutExtent";

		// Token: 0x040002A8 RID: 680
		private const string FloatingWindowStateAttrib = "windowState";

		// Token: 0x040002A9 RID: 681
		private const string FloatingRestoreBoundsAttrib = "restoreBounds";

		// Token: 0x040002AA RID: 682
		private const string FloatingRestoreToMaximizedAttrib = "restoreToMaximized";

		// Token: 0x040002AB RID: 683
		private const string VisibilityAttrib = "visibility";

		// Token: 0x040002AC RID: 684
		private static readonly global::System.Windows.Controls.Orientation DefaultSplitterOrientation = (global::System.Windows.Controls.Orientation)global::Infragistics.Windows.DockManager.SplitPane.SplitterOrientationProperty.DefaultMetadata.DefaultValue;

		// Token: 0x02000076 RID: 118
		private class ContentPaneInfo
		{
			// Token: 0x040002AD RID: 685
			internal global::Infragistics.Windows.DockManager.ContentPane Pane;

			// Token: 0x040002AE RID: 686
			internal string SerializationId;

			// Token: 0x040002AF RID: 687
			internal global::Infragistics.Windows.DockManager.PaneLocation Location;

			// Token: 0x040002B0 RID: 688
			internal int UnpinnedOrder;

			// Token: 0x040002B1 RID: 689
			internal global::System.Windows.Visibility Visibility;

			// Token: 0x040002B2 RID: 690
			internal global::Infragistics.Windows.DockManager.DockableState LastDockableState;

			// Token: 0x040002B3 RID: 691
			internal global::System.DateTime LastActivatedTime = global::System.DateTime.MinValue;

			// Token: 0x040002B4 RID: 692
			internal global::System.Windows.Size LastFloatingSize = global::System.Windows.Size.Empty;

			// Token: 0x040002B5 RID: 693
			internal global::System.Windows.Point? LastFloatingPoint = null;

			// Token: 0x040002B6 RID: 694
			internal global::System.Windows.Rect LastFloatingWindowRect = global::System.Windows.Rect.Empty;

			// Token: 0x040002B7 RID: 695
			internal double FlyoutExtent = double.NaN;
		}

		// Token: 0x02000077 RID: 119
		private class ParseInfo
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x00017633 File Offset: 0x00015833
			internal ParseInfo(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
			{
				this._dockManager = dockManager;
				this._loadedPanes = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo>();
				this.InitializeOriginalPanes();
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x00017653 File Offset: 0x00015853
			// (set) Token: 0x06000420 RID: 1056 RVA: 0x0001765B File Offset: 0x0001585B
			internal global::Infragistics.Windows.DockManager.PaneLocation CurrentLocation
			{
				get
				{
					return this._currentLocation;
				}
				set
				{
					this._currentLocation = value;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x06000421 RID: 1057 RVA: 0x00017664 File Offset: 0x00015864
			internal global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo> LoadedPanes
			{
				get
				{
					return this._loadedPanes;
				}
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x0001766C File Offset: 0x0001586C
			private static bool CompareItems(object item1, object item2)
			{
				if (object.ReferenceEquals(item1, item2))
				{
					return true;
				}
				if ((item1 is global::Infragistics.Windows.DockManager.ContentPane || item1 is global::Infragistics.Windows.DockManager.ContentPanePlaceholder) && (item2 is global::Infragistics.Windows.DockManager.ContentPane || item2 is global::Infragistics.Windows.DockManager.ContentPanePlaceholder))
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane = (item1 as global::Infragistics.Windows.DockManager.ContentPane) ?? ((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)item1).Pane;
					global::Infragistics.Windows.DockManager.ContentPane contentPane2 = (item2 as global::Infragistics.Windows.DockManager.ContentPane) ?? ((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)item2).Pane;
					return contentPane == contentPane2;
				}
				return false;
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x000176D8 File Offset: 0x000158D8
			private static int FindSiblingItem(object originalItem, global::System.Collections.IList currentList)
			{
				int i = 0;
				int count = currentList.Count;
				while (i < count)
				{
					if (global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo.CompareItems(originalItem, currentList[i]))
					{
						return i;
					}
					i++;
				}
				return -1;
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x0001770C File Offset: 0x0001590C
			internal global::Infragistics.Windows.DockManager.TabGroupPane GetOrCreateTabGroup(string name, global::System.Windows.Size relativeSize)
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = null;
				bool flag = !string.IsNullOrEmpty(name);
				if (flag && this._originalTabGroups.TryGetValue(name, out tabGroupPane))
				{
					if (tabGroupPane != null)
					{
						global::Infragistics.Windows.DockManager.IPaneContainer parentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(tabGroupPane);
						if (parentPane != null)
						{
							parentPane.RemovePane(tabGroupPane);
							global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(parentPane);
						}
					}
					this._originalTabGroups[name] = null;
				}
				if (tabGroupPane == null)
				{
					tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(this._dockManager);
					if (flag && name != tabGroupPane.Name)
					{
						tabGroupPane.Name = name;
					}
				}
				if (relativeSize != global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(tabGroupPane))
				{
					if (relativeSize.IsEmpty)
					{
						tabGroupPane.ClearValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty);
					}
					else
					{
						global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(tabGroupPane, relativeSize);
					}
				}
				return tabGroupPane;
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x000177B4 File Offset: 0x000159B4
			internal global::Infragistics.Windows.DockManager.SplitPane GetOrCreateSplitPane(string name, global::System.Windows.Size relativeSize, global::System.Windows.Controls.Orientation orientation)
			{
				global::Infragistics.Windows.DockManager.SplitPane splitPane = null;
				bool flag = !string.IsNullOrEmpty(name);
				if (flag && this._originalSplitPanes.TryGetValue(name, out splitPane))
				{
					if (splitPane != null)
					{
						global::Infragistics.Windows.DockManager.IPaneContainer parentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(splitPane);
						if (parentPane != null)
						{
							parentPane.RemovePane(splitPane);
							global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(parentPane);
						}
					}
					this._originalSplitPanes[name] = null;
				}
				if (splitPane == null)
				{
					splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(this._dockManager);
					if (flag && name != splitPane.Name)
					{
						splitPane.Name = name;
					}
				}
				if (relativeSize != global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(splitPane))
				{
					if (relativeSize.IsEmpty)
					{
						splitPane.ClearValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty);
					}
					else
					{
						global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(splitPane, relativeSize);
					}
				}
				if (orientation != splitPane.SplitterOrientation)
				{
					splitPane.SetValue(global::Infragistics.Windows.DockManager.SplitPane.SplitterOrientationProperty, global::Infragistics.KnownBoxes.FromValue(orientation));
				}
				return splitPane;
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00017878 File Offset: 0x00015A78
			private void InitializeOriginalPanes()
			{
				this._originalSplitPanes = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.SplitPane>();
				this._originalTabGroups = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.TabGroupPane>();
				this._siblingPanes = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Collections.Generic.List<object>>();
				foreach (global::Infragistics.Windows.DockManager.SplitPane pane in this._dockManager.Panes)
				{
					this.InitializeOriginalPanes(pane);
				}
				if (this._dockManager.HasDocumentContentHost)
				{
					foreach (global::Infragistics.Windows.DockManager.SplitPane pane2 in this._dockManager.DocumentContentHost.Panes)
					{
						this.InitializeOriginalPanes(pane2);
					}
				}
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00017940 File Offset: 0x00015B40
			private void InitializeOriginalPanes(global::Infragistics.Windows.DockManager.SplitPane pane)
			{
				if (!string.IsNullOrEmpty(pane.Name))
				{
					this._originalSplitPanes.Add(pane.Name, pane);
				}
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				foreach (global::System.Windows.FrameworkElement frameworkElement in pane.Panes)
				{
					list.Add(frameworkElement);
					global::Infragistics.Windows.DockManager.SplitPane splitPane = frameworkElement as global::Infragistics.Windows.DockManager.SplitPane;
					if (splitPane != null)
					{
						this.InitializeOriginalPanes(splitPane);
					}
					else
					{
						global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = frameworkElement as global::Infragistics.Windows.DockManager.TabGroupPane;
						if (tabGroupPane != null)
						{
							if (!string.IsNullOrEmpty(tabGroupPane.Name))
							{
								this._originalTabGroups.Add(tabGroupPane.Name, tabGroupPane);
							}
							global::System.Collections.Generic.List<object> list2 = new global::System.Collections.Generic.List<object>();
							foreach (object item in ((global::System.Collections.IEnumerable)tabGroupPane.Items))
							{
								list2.Add(item);
							}
							this._siblingPanes.Add(tabGroupPane, list2);
						}
					}
				}
				this._siblingPanes.Add(pane, list);
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00017A68 File Offset: 0x00015C68
			internal bool ReorderOriginalItems(object[] originalItems, global::System.Windows.FrameworkElement parent, global::System.Collections.IList currentItems)
			{
				global::System.Collections.Generic.List<object> originalSiblingList;
				return originalItems != null && originalItems.Length > 0 && this._siblingPanes.TryGetValue(parent, out originalSiblingList) && global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo.ReorderOriginalItems(originalItems, originalSiblingList, currentItems);
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x00017A98 File Offset: 0x00015C98
			private static bool ReorderOriginalItems(object[] originalItems, global::System.Collections.Generic.List<object> originalSiblingList, global::System.Collections.IList currentItems)
			{
				bool result = false;
				foreach (object obj in originalItems)
				{
					int num = originalSiblingList.IndexOf(obj);
					int num2 = currentItems.IndexOf(obj);
					if (num2 >= 0 && num >= 0)
					{
						bool flag = false;
						int j = num - 1;
						while (j >= 0)
						{
							object originalItem = originalSiblingList[j];
							int num3 = global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo.FindSiblingItem(originalItem, currentItems);
							if (num3 >= 0)
							{
								if (num2 > num3)
								{
									num3++;
								}
								if (num3 == num2)
								{
									flag = true;
									break;
								}
								currentItems.RemoveAt(num2);
								currentItems.Insert(num3, obj);
								result = true;
								flag = true;
								break;
							}
							else
							{
								j--;
							}
						}
						if (!flag)
						{
							int k = num + 1;
							while (k < originalSiblingList.Count)
							{
								object originalItem2 = originalSiblingList[k];
								int num4 = global::Infragistics.Windows.DockManager.LayoutManager.ParseInfo.FindSiblingItem(originalItem2, currentItems);
								if (num4 >= 0)
								{
									if (num2 < num4)
									{
										num4--;
									}
									if (num4 != num2)
									{
										currentItems.RemoveAt(num2);
										currentItems.Insert(num4, obj);
										result = true;
										break;
									}
									break;
								}
								else
								{
									k++;
								}
							}
						}
					}
				}
				return result;
			}

			// Token: 0x040002B8 RID: 696
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.LayoutManager.ContentPaneInfo> _loadedPanes;

			// Token: 0x040002B9 RID: 697
			private global::Infragistics.Windows.DockManager.PaneLocation _currentLocation;

			// Token: 0x040002BA RID: 698
			private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

			// Token: 0x040002BB RID: 699
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.TabGroupPane> _originalTabGroups;

			// Token: 0x040002BC RID: 700
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.SplitPane> _originalSplitPanes;

			// Token: 0x040002BD RID: 701
			private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Collections.Generic.List<object>> _siblingPanes;
		}

		// Token: 0x02000078 RID: 120
		private class SerializationInfo
		{
			// Token: 0x0600042A RID: 1066 RVA: 0x00017B98 File Offset: 0x00015D98
			internal SerializationInfo()
			{
				this._namedPanes = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.ContentPane>();
				this._namedSplits = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.SplitPane>();
				this._namedTabGroups = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.TabGroupPane>();
				this._shouldSerializeStates = new global::System.Collections.Generic.Dictionary<object, bool>();
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x00017BCC File Offset: 0x00015DCC
			internal global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.ContentPane> NamedPanes
			{
				get
				{
					return this._namedPanes;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x00017BD4 File Offset: 0x00015DD4
			internal global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.SplitPane> NamedSplits
			{
				get
				{
					return this._namedSplits;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x00017BDC File Offset: 0x00015DDC
			internal global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.TabGroupPane> NamedTabGroups
			{
				get
				{
					return this._namedTabGroups;
				}
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x00017BE4 File Offset: 0x00015DE4
			private bool ShouldSerialize(global::Infragistics.Windows.DockManager.SplitPane pane)
			{
				if (global::Infragistics.Windows.DockManager.DockManagerUtilities.ShouldPreventPaneRemoval(pane))
				{
					return true;
				}
				foreach (global::System.Windows.FrameworkElement item in pane.Panes)
				{
					if (this.ShouldSerialize(item))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00017C44 File Offset: 0x00015E44
			internal bool ShouldSerialize(object item)
			{
				bool flag;
				if (!this._shouldSerializeStates.TryGetValue(item, out flag))
				{
					if (item is global::Infragistics.Windows.DockManager.TabGroupPane)
					{
						flag = this.ShouldSerialize((global::Infragistics.Windows.DockManager.TabGroupPane)item);
					}
					else if (item is global::Infragistics.Windows.DockManager.ContentPane)
					{
						flag = this.ShouldSerialize((global::Infragistics.Windows.DockManager.ContentPane)item);
					}
					else if (item is global::Infragistics.Windows.DockManager.ContentPanePlaceholder)
					{
						flag = this.ShouldSerialize((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)item);
					}
					else
					{
						flag = (item is global::Infragistics.Windows.DockManager.SplitPane && this.ShouldSerialize((global::Infragistics.Windows.DockManager.SplitPane)item));
					}
					this._shouldSerializeStates.Add(item, flag);
				}
				return flag;
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00017CD0 File Offset: 0x00015ED0
			private bool ShouldSerialize(global::Infragistics.Windows.DockManager.TabGroupPane tabGroup)
			{
				if (global::Infragistics.Windows.DockManager.DockManagerUtilities.ShouldPreventPaneRemoval(tabGroup))
				{
					return true;
				}
				foreach (object item in ((global::System.Collections.IEnumerable)tabGroup.Items))
				{
					if (this.ShouldSerialize(item))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00017D38 File Offset: 0x00015F38
			private bool ShouldSerialize(global::Infragistics.Windows.DockManager.ContentPane pane)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane;
				return this._namedPanes.TryGetValue(pane.Name, out contentPane) && pane == contentPane;
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00017D60 File Offset: 0x00015F60
			private bool ShouldSerialize(global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
			{
				return this.ShouldSerialize(placeholder.Pane);
			}

			// Token: 0x040002BE RID: 702
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.ContentPane> _namedPanes;

			// Token: 0x040002BF RID: 703
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.SplitPane> _namedSplits;

			// Token: 0x040002C0 RID: 704
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DockManager.TabGroupPane> _namedTabGroups;

			// Token: 0x040002C1 RID: 705
			private global::System.Collections.Generic.Dictionary<object, bool> _shouldSerializeStates;
		}
	}
}
