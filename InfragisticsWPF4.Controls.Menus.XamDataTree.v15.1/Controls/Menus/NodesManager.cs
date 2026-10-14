using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using Infragistics.DragDrop;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000021 RID: 33
	public class NodesManager : global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>, global::System.IComparable<global::Infragistics.Controls.Menus.NodesManager>
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000393C File Offset: 0x00001B3C
		internal NodesManager(int level, global::Infragistics.Controls.Menus.NodeLayout nodeLayout, global::Infragistics.Controls.Menus.XamDataTreeNode parentLayoutNode)
		{
			this.NodeLayout = nodeLayout;
			this._visibleChildManagers = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodesManager>();
			this._readOnlyVisibleChildManagers = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Menus.NodesManager>(this._visibleChildManagers);
			this.Level = level;
			this.ParentNode = parentLayoutNode;
			this._nodes = new global::Infragistics.Controls.Menus.XamDataTreeNodesCollection(this);
			this._cachedNodes = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Menus.XamDataTreeNode>();
			this._duplicateObjectValidator = new global::System.Collections.Generic.Dictionary<object, int>();
			this.EnsureDataManager();
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000039B3 File Offset: 0x00001BB3
		public global::Infragistics.Controls.Menus.XamDataTreeNodesCollection Nodes
		{
			get
			{
				return this._nodes;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000039BB File Offset: 0x00001BBB
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000039C3 File Offset: 0x00001BC3
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return this._itemSource;
			}
			protected internal set
			{
				if (this._itemSource != value)
				{
					this._itemSource = value;
					this.OnItemsSourceChanged();
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000039DB File Offset: 0x00001BDB
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000039E3 File Offset: 0x00001BE3
		public virtual global::Infragistics.Controls.Menus.XamDataTreeNode ParentNode { get; protected set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000039EC File Offset: 0x00001BEC
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000039F4 File Offset: 0x00001BF4
		public global::Infragistics.Controls.Menus.NodeLayout NodeLayout
		{
			get
			{
				return this._nodeLayout;
			}
			protected internal set
			{
				if (value != this.NodeLayout)
				{
					this._isDisposed = false;
					this.OnNodeLayoutAssigned(value);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003A0D File Offset: 0x00001C0D
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00003A15 File Offset: 0x00001C15
		public virtual int Level { get; protected internal set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003A1E File Offset: 0x00001C1E
		protected internal virtual global::Infragistics.DataManagerBase DataManager
		{
			get
			{
				this.EnsureDataManager();
				return this._dataManager;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003A2C File Offset: 0x00001C2C
		protected internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Menus.NodesManager> VisibleChildManagers
		{
			get
			{
				return this._readOnlyVisibleChildManagers;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003A34 File Offset: 0x00001C34
		protected virtual int DataCount
		{
			get
			{
				global::Infragistics.DataManagerBase dataManager = this.DataManager;
				if (dataManager != null)
				{
					return dataManager.RecordCount;
				}
				return 0;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003A53 File Offset: 0x00001C53
		protected internal virtual int FullNodeCount
		{
			get
			{
				if (this.NodeLayout != null && this.NodeLayout.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					return this.DataCount;
				}
				return 0;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003A73 File Offset: 0x00001C73
		protected global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Menus.XamDataTreeNode> CachedNodes
		{
			get
			{
				return this._cachedNodes;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003A7B File Offset: 0x00001C7B
		public void InvalidateNodes()
		{
			this.InvalidateNodes(true);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003A84 File Offset: 0x00001C84
		private void InvalidateNodes(bool unregister)
		{
			if (unregister)
			{
				this.UnregisterAllChildNodesManager();
				this.ClearNodes();
			}
			if (this.NodeLayout != null && this.NodeLayout.Tree != null)
			{
				this.NodeLayout.Tree.InvalidateScrollPanel(true, true);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003ABC File Offset: 0x00001CBC
		public void ClearCacheInformation()
		{
			if (this._cachedNodes != null)
			{
				this._cachedNodes.Clear();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003AD1 File Offset: 0x00001CD1
		public void ClearCacheInformation(object dataObject)
		{
			if (this._cachedNodes != null && this._cachedNodes.ContainsKey(dataObject))
			{
				this._cachedNodes.Remove(dataObject);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003AF8 File Offset: 0x00001CF8
		protected virtual global::Infragistics.Controls.Menus.XamDataTreeNode GetDataItem(int index)
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				object record = dataManager.GetRecord(index);
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
				if (record != null)
				{
					if (this._cachedNodes.ContainsKey(record))
					{
						if (!this._duplicateObjectValidator.ContainsKey(record))
						{
							xamDataTreeNode = this._cachedNodes[record];
							xamDataTreeNode.Manager = this;
							this._duplicateObjectValidator.Add(record, index);
							xamDataTreeNode.Index = index;
							if (xamDataTreeNode.IsExpanded)
							{
								this.RegisterChildNodesManager(xamDataTreeNode.ChildNodesManager);
							}
							return xamDataTreeNode;
						}
						return new global::Infragistics.Controls.Menus.XamDataTreeNode(index, this, record, false, null);
					}
					else
					{
						xamDataTreeNode = new global::Infragistics.Controls.Menus.XamDataTreeNode(index, this, record, false, null);
						this._cachedNodes.Add(record, xamDataTreeNode);
						this._duplicateObjectValidator.Add(record, index);
						if (xamDataTreeNode.IsExpanded)
						{
							this.RegisterChildNodesManager(xamDataTreeNode.ChildNodesManager);
						}
					}
				}
				else
				{
					xamDataTreeNode = new global::Infragistics.Controls.Menus.XamDataTreeNode(index, this, record, false, null);
				}
				if (xamDataTreeNode != null)
				{
					this.NodeLayout.Tree.OnInitializeNode(xamDataTreeNode);
					if (xamDataTreeNode.IsExpanded)
					{
						this.RegisterChildNodesManager(xamDataTreeNode.ChildNodesManager);
					}
				}
				return xamDataTreeNode;
			}
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003BF8 File Offset: 0x00001DF8
		protected virtual void OnItemsSourceChanged()
		{
			if (this._dataManager != null && this.NodeLayout != null)
			{
				global::Infragistics.Controls.Menus.XamDataTree tree = this.NodeLayout.Tree;
				if (tree != null)
				{
					if (tree.ActiveNode != this.ParentNode)
					{
						tree.ActiveNode = null;
					}
					if (this.ItemsSource != null)
					{
						global::System.Type left = global::Infragistics.DataManagerBase.ResolveItemType(this.ItemsSource);
						if (left == this._dataManager.CachedType)
						{
							this._dataManager.DataSource = null;
							this.UnhookDataManager(true, true);
							this.EnsureDataManager();
							this.InvalidateNodes();
							this.InvalidateData();
							this.FillManagerSelectedItemsBySelectedMemberPath();
							return;
						}
					}
					tree.ResetPanelNodes();
					this.UnhookDataManager(true, true);
					this.NodeLayout.IsInitialized = false;
					this.NodeLayout.DataFields = null;
					tree.InvalidateScrollPanel(true, true);
				}
			}
			else if (this.ItemsSource != null)
			{
				this.EnsureDataManager();
			}
			this.FillManagerSelectedItemsBySelectedMemberPath();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003CDC File Offset: 0x00001EDC
		protected virtual void EnsureDataManager()
		{
			if (this.ItemsSource == null)
			{
				if (this.ParentNode != null)
				{
					if (this.ParentNode.ItemsSource != null)
					{
						this.ItemsSource = this.ParentNode.ItemsSource;
					}
					else
					{
						object data = this.ParentNode.Data;
						if (data != null)
						{
							global::System.Reflection.PropertyInfo propertyInfo = this.NodeLayout.ResolvePropertyInfo(data);
							if (propertyInfo != null)
							{
								this.ItemsSource = (propertyInfo.GetValue(this.ParentNode.Data, null) as global::System.Collections.IEnumerable);
							}
							else
							{
								object obj = global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(this.NodeLayout.Key, data);
								this.ItemsSource = (obj as global::System.Collections.IEnumerable);
							}
							global::System.ComponentModel.INotifyPropertyChanged inpc = data as global::System.ComponentModel.INotifyPropertyChanged;
							this.AttachDetachPropertyChanged(inpc, true);
						}
					}
					if (this.ItemsSource != null && this._dataManager == null)
					{
						this.SetupDataManager();
						return;
					}
				}
			}
			else if (this._dataManager == null)
			{
				this.SetupDataManager();
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003DB5 File Offset: 0x00001FB5
		protected virtual void OnNodeLayoutAssigned(global::Infragistics.Controls.Menus.NodeLayout layout)
		{
			if (this._nodeLayout != null)
			{
				this._nodeLayout.UnSubscribeForNotifications(this);
			}
			this._nodeLayout = layout;
			if (this._nodeLayout != null)
			{
				this._nodeLayout.SubscribeForNotifications(this);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003DE8 File Offset: 0x00001FE8
		protected virtual void OnNodeLayoutPropertyChanged(global::Infragistics.Controls.Menus.NodeLayout layout, string propertyName)
		{
			if (propertyName != null)
			{
				if (global::<PrivateImplementationDetails>{73834E12-72FE-4800-9FEB-0636278CBE87}.$$method0x60000c3-1 == null)
				{
					global::<PrivateImplementationDetails>{73834E12-72FE-4800-9FEB-0636278CBE87}.$$method0x60000c3-1 = new global::System.Collections.Generic.Dictionary<string, int>(8)
					{
						{
							"IsDraggable",
							0
						},
						{
							"IsDropTarget",
							1
						},
						{
							"InvalidateData",
							2
						},
						{
							"IsEnabledMemberPathResolved",
							3
						},
						{
							"IsExpandedMemberPathResolved",
							4
						},
						{
							"CheckBoxMemberPathResolved",
							5
						},
						{
							"HeaderText",
							6
						},
						{
							"HeaderTemplate",
							7
						}
					};
				}
				int num;
				if (global::<PrivateImplementationDetails>{73834E12-72FE-4800-9FEB-0636278CBE87}.$$method0x60000c3-1.TryGetValue(propertyName, out num))
				{
					switch (num)
					{
					case 0:
					case 1:
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator = this.Nodes.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = enumerator.Current;
								xamDataTreeNode.RaiseNodeNotifyPropertyChanged(propertyName + "Resolved");
							}
							return;
						}
						break;
					case 2:
						break;
					case 3:
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator2 = this.Nodes.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = enumerator2.Current;
								xamDataTreeNode2.SetupIsEnabledBinding();
							}
							return;
						}
						goto IL_13C;
					case 4:
						goto IL_13C;
					case 5:
						goto IL_170;
					case 6:
					case 7:
						goto IL_1A4;
					default:
						return;
					}
					this.InvalidateData();
					return;
					IL_13C:
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator3 = this.Nodes.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3 = enumerator3.Current;
							xamDataTreeNode3.SetupIsExpandedBinding();
						}
						return;
					}
					IL_170:
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator4 = this.Nodes.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode4 = enumerator4.Current;
							xamDataTreeNode4.SetupCheckboxBinding();
						}
						return;
					}
					IL_1A4:
					if (this.NodeLayout != null && this.NodeLayout.Tree != null)
					{
						this.NodeLayout.Tree.InvalidateScrollPanel(true, true);
					}
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003FF4 File Offset: 0x000021F4
		protected virtual void OnChildNodeLayoutRemoved(global::Infragistics.Controls.Menus.NodeLayout layout)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003FF6 File Offset: 0x000021F6
		protected virtual void OnChildNodeLayoutAdded(global::Infragistics.Controls.Menus.NodeLayout layout)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003FF8 File Offset: 0x000021F8
		protected virtual void OnChildNodeLayoutVisibilityChanged(global::Infragistics.Controls.Menus.NodeLayout layout)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003FFA File Offset: 0x000021FA
		protected internal virtual void UnregisterNodesManager(bool removeNodeLayout, bool clearChildNodesManager, bool clearSelection)
		{
			this.UnhookDataManager(clearChildNodesManager, clearSelection);
			if (this._nodeLayout != null)
			{
				this._nodeLayout.UnSubscribeForNotifications(this);
				this._nodeLayout = null;
				this.ParentNode = null;
				this._isDisposed = true;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000402D File Offset: 0x0000222D
		protected internal void RegisterChildNodesManager(global::Infragistics.Controls.Menus.NodesManager manager)
		{
			if (!this.VisibleChildManagers.Contains(manager))
			{
				this._visibleChildManagers.Add(manager);
				if (!this._suppressVisibleChildManagersSorting)
				{
					this._visibleChildManagers.Sort();
				}
				manager.OnRegisteredAsVisibleChildManager();
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004062 File Offset: 0x00002262
		protected internal void UnregisterChildNodesManager(global::Infragistics.Controls.Menus.NodesManager manager)
		{
			if (this.VisibleChildManagers.Contains(manager))
			{
				this._visibleChildManagers.Remove(manager);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004080 File Offset: 0x00002280
		protected internal void UnregisterAllChildNodesManager()
		{
			for (int i = this.VisibleChildManagers.Count - 1; i >= 0; i--)
			{
				this.UnregisterChildNodesManager(this.VisibleChildManagers[i]);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000040B7 File Offset: 0x000022B7
		protected internal global::Infragistics.Controls.Menus.XamDataTreeNode ResolveNodeForIndex(int index)
		{
			if (index < 0 || index > this.FullNodeCount - 1)
			{
				return null;
			}
			return this.Nodes[index];
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000040D8 File Offset: 0x000022D8
		protected internal int ResolveIndexForNode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			int num = this.Nodes.IndexOf(node);
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000040FC File Offset: 0x000022FC
		protected void InvalidateData()
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				dataManager.Reset();
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000411C File Offset: 0x0000231C
		protected virtual void InitializeData()
		{
			if (this._dataManager != null)
			{
				global::Infragistics.Controls.Menus.NodeLayout nodeLayout = null;
				global::System.Type cachedType = this._dataManager.CachedType;
				if (this.NodeLayout == null)
				{
					return;
				}
				if (cachedType != null)
				{
					nodeLayout = this.NodeLayout.Tree.GlobalNodeLayouts.InternalFromKey(this.NodeLayout.Key);
					if (nodeLayout == null || nodeLayout.TargetTypeName != cachedType.Name)
					{
						nodeLayout = this.NodeLayout.Tree.GlobalNodeLayouts.InternalFromType(cachedType);
					}
				}
				if (nodeLayout == null)
				{
					nodeLayout = this.NodeLayout.Tree.GlobalNodeLayouts.InternalFromKey(this.NodeLayout.Key);
				}
				if (nodeLayout != null && this.NodeLayout != nodeLayout)
				{
					nodeLayout.Tree = this.NodeLayout.Tree;
					this.NodeLayout = nodeLayout;
				}
				global::Infragistics.Controls.Menus.NodeLayoutAssignedEventArgs nodeLayoutAssignedEventArgs = new global::Infragistics.Controls.Menus.NodeLayoutAssignedEventArgs();
				nodeLayoutAssignedEventArgs.NodeLayout = this.NodeLayout;
				nodeLayoutAssignedEventArgs.Level = this.Level;
				nodeLayoutAssignedEventArgs.DataType = cachedType;
				nodeLayoutAssignedEventArgs.Key = this.NodeLayout.Key;
				this.NodeLayout.Tree.OnNodeLayoutAssigned(nodeLayoutAssignedEventArgs);
				if (nodeLayoutAssignedEventArgs.NodeLayout != null && nodeLayoutAssignedEventArgs.NodeLayout != this.NodeLayout)
				{
					nodeLayoutAssignedEventArgs.NodeLayout.Tree = this.NodeLayout.Tree;
					this.NodeLayout = nodeLayoutAssignedEventArgs.NodeLayout;
				}
				if (!this.NodeLayout.Tree.GlobalNodeLayouts.Contains(this.NodeLayout))
				{
					this.NodeLayout.Tree.GlobalNodeLayouts.AddItemLocally(this.NodeLayout);
					this.NodeLayout.Tree.NodeLayoutAddedToGlobalNodeLayoutCollectionCount++;
				}
				if (!this.NodeLayout.IsInitialized)
				{
					this.NodeLayout.IsInitialized = true;
					global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> dataProperties = this._dataManager.GetDataProperties();
					this.NodeLayout.DataFields = dataProperties;
					global::Infragistics.Controls.Menus.GlobalNodeLayoutCollection globalNodeLayouts = this.NodeLayout.Tree.GlobalNodeLayouts;
					foreach (global::Infragistics.DataField dataField in dataProperties)
					{
						global::System.Type type = null;
						if (dataField.FieldType.IsGenericType)
						{
							global::System.Type[] genericArguments = dataField.FieldType.GetGenericArguments();
							if (!dataField.FieldType.IsSubclassOf(typeof(global::System.Delegate)) && genericArguments.Length > 0)
							{
								type = genericArguments[0];
							}
						}
						global::Infragistics.Controls.Menus.NodeLayout nodeLayout2 = null;
						if (type != null)
						{
							nodeLayout2 = globalNodeLayouts.InternalFromKey(dataField.Name);
							if (nodeLayout2 == null || nodeLayout2.TargetTypeName != type.Name)
							{
								nodeLayout2 = globalNodeLayouts.InternalFromType(type);
							}
						}
						if (nodeLayout2 == null)
						{
							nodeLayout2 = globalNodeLayouts.InternalFromKey(dataField.Name);
						}
						if (nodeLayout2 != null && this.NodeLayout.NodeLayouts[nodeLayout2.Key] == null)
						{
							this.NodeLayout.NodeLayouts.Add(nodeLayout2);
						}
					}
					global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>();
					foreach (global::Infragistics.DataField dataField2 in dataProperties)
					{
						collection.Add(dataField2.Name);
					}
					foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout3 in this.NodeLayout.NodeLayouts)
					{
						if (!nodeLayout3.Key.Contains("[") || !nodeLayout3.Key.Contains("]"))
						{
							string[] array = nodeLayout3.Key.Split(new char[]
							{
								'.'
							});
							if (array.Length > 0)
							{
								if (!collection.Contains(array[0]))
								{
									if (nodeLayout3 == null)
									{
										throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("LayoutCannotBeMappedToProperty"));
									}
									if (!nodeLayout3.IsDefinedGlobally && string.IsNullOrEmpty(nodeLayout3.TargetTypeName))
									{
										throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("LayoutNotGloballyDefined"));
									}
								}
								else
								{
									global::System.Type type2 = cachedType;
									foreach (string name in array)
									{
										global::System.Reflection.PropertyInfo property = type2.GetProperty(name);
										if (property == null && (nodeLayout3 == null || (!nodeLayout3.IsDefinedGlobally && string.IsNullOrEmpty(nodeLayout3.TargetTypeName))))
										{
											throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("LE_InvalidKey"));
										}
										if (property != null)
										{
											type2 = property.PropertyType;
										}
									}
								}
							}
						}
					}
				}
				if (this.NodeLayout != null && this.NodeLayout.Tree != null)
				{
					this.NodeLayout.Tree.InvalidateScrollPanel(true);
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000045F8 File Offset: 0x000027F8
		protected internal virtual global::Infragistics.Controls.Menus.XamDataTreeNode CreateItem(object data, global::Infragistics.DataManagerBase dataManager)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode result = null;
			if (dataManager != null)
			{
				if (data == null)
				{
					throw new global::System.NullReferenceException(global::Infragistics.SRDataTree.GetString("NullDataException"));
				}
				if (!this._dataManager.CachedType.IsAssignableFrom(data.GetType()))
				{
					throw new global::System.InvalidCastException(string.Format(global::Infragistics.SRDataTree.GetString("DataTypeMismatchExceptionVerbose"), data.GetType(), this._dataManager.CachedType));
				}
				result = new global::Infragistics.Controls.Menus.XamDataTreeNode(-1, this, data, false, null);
			}
			return result;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004668 File Offset: 0x00002868
		protected internal virtual global::Infragistics.Controls.Menus.XamDataTreeNode CreateItem()
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode result = null;
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				result = this.CreateItem(dataManager.GenerateNewObject(), dataManager);
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004690 File Offset: 0x00002890
		protected internal virtual global::Infragistics.Controls.Menus.XamDataTreeNode CreateItem(object data)
		{
			return this.CreateItem(data, this.DataManager);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000046A0 File Offset: 0x000028A0
		protected internal virtual void AddItem(global::Infragistics.Controls.Menus.XamDataTreeNode addedObject)
		{
			if (addedObject == null)
			{
				return;
			}
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager == null)
			{
				return;
			}
			if (addedObject.Manager != this)
			{
				addedObject.Manager = this;
			}
			if (addedObject.NodeLayout != this.NodeLayout && addedObject.Manager.DataManager.CachedType != this.DataManager.CachedType)
			{
				throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("LE_NodeLayout_InsertItem"));
			}
			global::Infragistics.Controls.Menus.XamDataTree tree = this.NodeLayout.Tree;
			dataManager.AddRecord(addedObject.Data);
			if (!this._cachedNodes.ContainsKey(addedObject.Data))
			{
				this._cachedNodes.Add(addedObject.Data, addedObject);
			}
			this.InvalidateNodes();
			int num = dataManager.ResolveIndexForRecord(addedObject.Data);
			if (num != -1)
			{
				addedObject = this.Nodes[num];
			}
			if (this.ParentNode != null)
			{
				this.ParentNode.ValidateParentCheckedState();
			}
			if (this.NodeLayout.Tree != null)
			{
				this.NodeLayout.Tree.InvalidateScrollPanel(true, false);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000047A0 File Offset: 0x000029A0
		protected internal virtual void InsertItem(int index, global::Infragistics.Controls.Menus.XamDataTreeNode insertedObject)
		{
			if (insertedObject == null)
			{
				return;
			}
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager == null)
			{
				return;
			}
			if (insertedObject.Manager != this)
			{
				insertedObject.Manager = this;
			}
			if (insertedObject.NodeLayout != this.NodeLayout && insertedObject.Manager.DataManager.CachedType != this.DataManager.CachedType)
			{
				throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("LE_NodeLayout_InsertItem"));
			}
			global::Infragistics.Controls.Menus.XamDataTree tree = this.NodeLayout.Tree;
			dataManager.InsertRecord(index, insertedObject.Data);
			insertedObject.UpdateLevel();
			if (!this._cachedNodes.ContainsKey(insertedObject.Data))
			{
				this._cachedNodes.Add(insertedObject.Data, insertedObject);
			}
			this.InvalidateNodes();
			insertedObject = this.Nodes[index];
			if (this.ParentNode != null)
			{
				this.ParentNode.ValidateParentCheckedState();
			}
			if (this.NodeLayout.Tree != null)
			{
				this.NodeLayout.Tree.InvalidateScrollPanel(true, false);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004896 File Offset: 0x00002A96
		protected bool RemoveItem(global::Infragistics.Controls.Menus.XamDataTreeNode removedObject)
		{
			return this.RemoveItem(removedObject, this.DataManager);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000048A8 File Offset: 0x00002AA8
		protected virtual bool RemoveItem(global::Infragistics.Controls.Menus.XamDataTreeNode removedObject, global::Infragistics.DataManagerBase manager)
		{
			if (removedObject == null)
			{
				return false;
			}
			if (removedObject.IsHeader)
			{
				return false;
			}
			global::Infragistics.Controls.Menus.XamDataTree tree = this.NodeLayout.Tree;
			manager.RemoveRecord(removedObject.Data);
			this._cachedNodes.Remove(removedObject.Data);
			removedObject.Manager = null;
			if (this.ParentNode != null)
			{
				this.ParentNode.ValidateParentCheckedState();
			}
			return true;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000490C File Offset: 0x00002B0C
		protected virtual void RemoveRange(global::System.Collections.Generic.IList<global::Infragistics.Controls.Menus.XamDataTreeNode> itemsToRemove)
		{
			if (itemsToRemove == null || itemsToRemove.Count == 0)
			{
				return;
			}
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode removedObject in itemsToRemove)
			{
				this.RemoveItem(removedObject, dataManager);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000496C File Offset: 0x00002B6C
		protected virtual void OnRegisteredAsVisibleChildManager()
		{
			if (this.NodeLayout != null && this.NodeLayout.Tree.EnsureNodeExpansion)
			{
				this.EnsureExpandedChildNodesAreRegistered();
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004990 File Offset: 0x00002B90
		protected internal void EnsureExpandedChildNodesAreRegistered()
		{
			bool doSuppress = this.SuppressVisibleChildManagersSorting(true);
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.Nodes)
			{
				if (xamDataTreeNode.IsExpanded)
				{
					this.RegisterChildNodesManager(xamDataTreeNode.ChildNodesManager);
				}
			}
			this.SuppressVisibleChildManagersSorting(doSuppress);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000049FC File Offset: 0x00002BFC
		internal bool SuppressVisibleChildManagersSorting(bool doSuppress)
		{
			bool suppressVisibleChildManagersSorting = this._suppressVisibleChildManagersSorting;
			this._suppressVisibleChildManagersSorting = doSuppress;
			if (!doSuppress && doSuppress != suppressVisibleChildManagersSorting)
			{
				this._visibleChildManagers.Sort();
			}
			return suppressVisibleChildManagersSorting;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004A2C File Offset: 0x00002C2C
		private void SetupDataManager()
		{
			this._dataManager = global::Infragistics.DataManagerBase.CreateDataManager(this.ItemsSource, null, true, true, true);
			if (this._dataManager != null)
			{
				this._dataManager.DataUpdated += this.DataManager_DataUpdated;
				this._dataManager.NewObjectGeneration += this.DataManager_NewObjectGeneration;
				this._dataManager.CollectionChanged += this.DataManager_CollectionChanged;
				this._dataManager.SuspendInvalidateDataSource = true;
				this.InitializeData();
				return;
			}
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this.ItemsSource as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null)
			{
				notifyCollectionChanged.CollectionChanged -= this.ItemsSource_CollectionChanged;
				notifyCollectionChanged.CollectionChanged += this.ItemsSource_CollectionChanged;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004AE4 File Offset: 0x00002CE4
		internal void UnhookDataManager(bool clearChildNodes, bool clearSelection)
		{
			this.AttachDetachPropertyChanged(false);
			if (clearChildNodes)
			{
				this.UnregisterNodeManagersForCachedNodes();
				this._cachedNodes.Clear();
			}
			this.InvalidateNodes();
			this.UnregisterAllChildNodesManager();
			if (this._dataManager != null)
			{
				this._dataManager.DetachWeekReferences();
				this._dataManager.CollectionChanged -= this.DataManager_CollectionChanged;
				this._dataManager.DataUpdated -= this.DataManager_DataUpdated;
				this._dataManager.NewObjectGeneration -= this.DataManager_NewObjectGeneration;
				this._dataManager = null;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004B78 File Offset: 0x00002D78
		private void AttachDetachPropertyChanged(bool attach)
		{
			int count = this._attachedPropertyChangedTargets.Count;
			for (int i = 0; i < count; i++)
			{
				((global::System.ComponentModel.INotifyPropertyChanged)this._attachedPropertyChangedTargets[i].Target).PropertyChanged -= this.ItemSource_PropertyChanged;
			}
			this._attachedPropertyChangedTargets.Clear();
			if (attach && this.ItemsSource != null)
			{
				foreach (object obj in this.ItemsSource)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = obj as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged != null)
					{
						global::System.WeakReference item = new global::System.WeakReference(notifyPropertyChanged);
						this._attachedPropertyChangedTargets.Add(item);
						notifyPropertyChanged.PropertyChanged += this.ItemSource_PropertyChanged;
					}
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004C54 File Offset: 0x00002E54
		private void AttachDetachPropertyChanged(global::System.ComponentModel.INotifyPropertyChanged inpc, bool attach)
		{
			if (inpc != null)
			{
				int count = this._attachedPropertyChangedTargets.Count;
				for (int i = 0; i < count; i++)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = (global::System.ComponentModel.INotifyPropertyChanged)this._attachedPropertyChangedTargets[i].Target;
					if (notifyPropertyChanged == inpc)
					{
						notifyPropertyChanged.PropertyChanged -= this.ItemSource_PropertyChanged;
						this._attachedPropertyChangedTargets.Remove(this._attachedPropertyChangedTargets[i]);
						break;
					}
				}
				if (attach)
				{
					global::System.WeakReference item = new global::System.WeakReference(inpc);
					this._attachedPropertyChangedTargets.Add(item);
					inpc.PropertyChanged += this.ItemSource_PropertyChanged;
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004CF0 File Offset: 0x00002EF0
		private void UnregisterNodeManagersForCachedNodes()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Controls.Menus.XamDataTreeNode> keyValuePair in this._cachedNodes)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode value = keyValuePair.Value;
				if (value.Manager == this)
				{
					if (value.NodeLayout != null && value.NodeLayout.Tree != null && value.NodeLayout.Tree.ActiveNode == value)
					{
						value.NodeLayout.Tree.ActiveNode = null;
					}
					value.UnregisterNodeManagers();
					value.Data = null;
					value.Manager = null;
				}
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004D9C File Offset: 0x00002F9C
		private void AttachListenerToParentNode()
		{
			if (this.ParentNode != null)
			{
				global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = this.ParentNode.Data as global::System.ComponentModel.INotifyPropertyChanged;
				if (notifyPropertyChanged != null)
				{
					this.AttachDetachPropertyChanged(notifyPropertyChanged, true);
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004DD0 File Offset: 0x00002FD0
		private void UpdateActiveDataItem()
		{
			if (this.NodeLayout != null && this.NodeLayout.Tree != null && this.NodeLayout.Tree.ActiveNode != null && this.NodeLayout == this.NodeLayout.Tree.ActiveNode.NodeLayout && !this.Nodes.Contains(this.NodeLayout.Tree.ActiveNode))
			{
				this.NodeLayout.Tree.SetActiveNodeByDataItem(this.Nodes, null, this.NodeLayout.Tree.ActiveNode.Data);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004E70 File Offset: 0x00003070
		private void RemoveSelectedItems(global::System.Collections.Generic.List<object> selectedItems)
		{
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.NodeLayout.Tree.SelectionSettings.SelectedNodes)
			{
				if (selectedItems.Contains(xamDataTreeNode.Data))
				{
					int index = this.NodeLayout.Tree.SelectionSettings.SelectedNodes.IndexOf(xamDataTreeNode);
					this.NodeLayout.Tree.SelectionSettings.SelectedNodes.InternalRemoveItemSilently(index);
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004F0C File Offset: 0x0000310C
		internal void FillManagerSelectedItemsBySelectedMemberPath()
		{
			if (this.DataManager != null && this.ItemsSource != null && this.NodeLayout != null && this.NodeLayout.Tree != null && !string.IsNullOrEmpty(this.NodeLayout.IsSelectedMemberPathResolved) && this.NodeLayout.Tree.IsMemberPathValidInType(this.NodeLayout.IsSelectedMemberPathResolved, this.DataManager.CachedTypedInfo))
			{
				this.NodeLayout.Tree.FillSelectedItemsBySelectedMemberPath(this.NodeLayout.IsSelectedMemberPathResolved, this.ItemsSource, this);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004F9A File Offset: 0x0000319A
		internal void ClearNodes()
		{
			this.Nodes.Clear();
			this._duplicateObjectValidator.Clear();
			this.AttachDetachPropertyChanged(false);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004FBC File Offset: 0x000031BC
		internal void RegisterCachedNode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (!this._cachedNodes.ContainsValue(node))
			{
				if (!this._cachedNodes.ContainsKey(node.Data))
				{
					this._cachedNodes.Add(node.Data, node);
					return;
				}
				this._cachedNodes[node.Data] = node;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005010 File Offset: 0x00003210
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> GetManagerNodesFromItems(global::System.Collections.Generic.List<object> items)
		{
			if (items == null || items.Count == 0)
			{
				return new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			}
			global::System.Collections.Generic.List<object> list = items.ToList<object>();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.Nodes)
			{
				if (list.Contains(xamDataTreeNode.Data))
				{
					list2.Add(xamDataTreeNode);
				}
				if (list2.Count<global::Infragistics.Controls.Menus.XamDataTreeNode>() == items.Count<object>())
				{
					break;
				}
			}
			return list2;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000050C8 File Offset: 0x000032C8
		internal void LoadItemNodeMap(global::Infragistics.Controls.Menus.DataItemNodeMap dataItemNodeMap, bool recursive, global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodes = null)
		{
			global::Infragistics.Controls.Menus.NodesManager.<>c__DisplayClass1 CS$<>8__locals1 = new global::Infragistics.Controls.Menus.NodesManager.<>c__DisplayClass1();
			CS$<>8__locals1.list = ((nodes != null) ? nodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>() : this.Nodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>());
			int count = CS$<>8__locals1.list.Count;
			int i;
			for (i = 0; i < count; i++)
			{
				dataItemNodeMap.CheckMap((CS$<>8__locals1.list[i] as global::Infragistics.Controls.Menus.XamDataTreeNode).Data, () => CS$<>8__locals1.list[i] as global::Infragistics.Controls.Menus.XamDataTreeNode);
				if (dataItemNodeMap._itemsRemainingToBeMapped < 1)
				{
					return;
				}
			}
			if (!recursive)
			{
				return;
			}
			foreach (object obj in CS$<>8__locals1.list)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = (global::Infragistics.Controls.Menus.XamDataTreeNode)obj;
				if (xamDataTreeNode.Nodes.Count > 0)
				{
					xamDataTreeNode.Manager.LoadItemNodeMap(dataItemNodeMap, recursive, xamDataTreeNode.Nodes);
					if (dataItemNodeMap._itemsRemainingToBeMapped < 1)
					{
						break;
					}
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000051F0 File Offset: 0x000033F0
		int global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.DataCount
		{
			get
			{
				return this.DataCount;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000051F8 File Offset: 0x000033F8
		global::Infragistics.Controls.Menus.XamDataTreeNode global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.GetDataItem(int index)
		{
			return this.GetDataItem(index);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005201 File Offset: 0x00003401
		global::Infragistics.Controls.Menus.XamDataTreeNode global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.CreateItem()
		{
			return this.CreateItem();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005209 File Offset: 0x00003409
		global::Infragistics.Controls.Menus.XamDataTreeNode global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.CreateItem(object dataItem)
		{
			return this.CreateItem(dataItem);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005212 File Offset: 0x00003412
		void global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.AddItem(global::Infragistics.Controls.Menus.XamDataTreeNode addedObject)
		{
			this.AddItem(addedObject);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000521B File Offset: 0x0000341B
		bool global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.RemoveItem(global::Infragistics.Controls.Menus.XamDataTreeNode removedObject)
		{
			return this.RemoveItem(removedObject);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005224 File Offset: 0x00003424
		void global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.RemoveRange(global::System.Collections.Generic.IList<global::Infragistics.Controls.Menus.XamDataTreeNode> itemsToRemove)
		{
			this.RemoveRange(itemsToRemove);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000522D File Offset: 0x0000342D
		void global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Menus.XamDataTreeNode>.InsertItem(int index, global::Infragistics.Controls.Menus.XamDataTreeNode insertedObject)
		{
			this.InsertItem(index, insertedObject);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005237 File Offset: 0x00003437
		private void DataManager_DataUpdated(object sender, global::System.EventArgs e)
		{
			this.InvalidateNodes();
			this.AttachListenerToParentNode();
			this.UpdateActiveDataItem();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000524C File Offset: 0x0000344C
		private void ItemsSource_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._dataManager = global::Infragistics.DataManagerBase.CreateDataManager(this.ItemsSource, null, true, true, true);
			if (this._dataManager != null)
			{
				global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this.ItemsSource as global::System.Collections.Specialized.INotifyCollectionChanged;
				if (notifyCollectionChanged != null)
				{
					notifyCollectionChanged.CollectionChanged -= this.ItemsSource_CollectionChanged;
				}
				this._dataManager.CollectionChanged += this.DataManager_CollectionChanged;
				this._dataManager.DataUpdated += this.DataManager_DataUpdated;
				this._dataManager.NewObjectGeneration += this.DataManager_NewObjectGeneration;
				this.InitializeData();
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000052E4 File Offset: 0x000034E4
		private void DataManager_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (!global::Infragistics.DragDrop.DragDropManager.IsDragging && this.NodeLayout != null && this.NodeLayout.Tree != null)
				{
					global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
					selectedNodesCollection.InternalAddRangeSilently(this.NodeLayout.Tree.SelectionSettings.SelectedNodes);
					if (e.OldItems != null && e.OldItems.Count > 0)
					{
						this.RemoveSelectedItems(e.OldItems.Cast<object>().ToList<object>());
					}
					bool flag = this.NodeLayout.Tree.IsMemberPathValidInType(this.NodeLayout.IsSelectedMemberPathResolved, this.DataManager.CachedTypedInfo);
					if (e.NewItems != null && e.NewItems.Count > 0 && flag)
					{
						global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> managerNodesFromItems = this.GetManagerNodesFromItems(e.NewItems.Cast<object>().ToList<object>());
						this.NodeLayout.Tree.EnsureNodeLayoutLoaded(managerNodesFromItems, null);
						this.FillManagerSelectedItemsBySelectedMemberPath();
					}
					if (selectedNodesCollection.Count > 0 && flag)
					{
						this.NodeLayout.Tree.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.NodeLayout.Tree.SelectionSettings.SelectedNodes);
					}
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this.UnregisterNodeManagersForCachedNodes();
				this._cachedNodes.Clear();
				this._duplicateObjectValidator.Clear();
				return;
			default:
				return;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005444 File Offset: 0x00003644
		private void ItemSource_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string[] array = this.NodeLayout.Key.Split(new char[]
			{
				'.'
			});
			if (e.PropertyName == array[array.Length - 1] || e.PropertyName == array[0] || this.NodeLayout.TargetTypeName != null)
			{
				object data = this.ParentNode.Data;
				if (data != null)
				{
					global::System.Reflection.PropertyInfo propertyInfo = this.NodeLayout.ResolvePropertyInfo(data);
					if (propertyInfo != null)
					{
						this.ItemsSource = (propertyInfo.GetValue(data, null) as global::System.Collections.IEnumerable);
					}
					else
					{
						object obj = global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(this.NodeLayout.Key, data);
						this.ItemsSource = (obj as global::System.Collections.IEnumerable);
					}
					global::System.ComponentModel.INotifyPropertyChanged inpc = data as global::System.ComponentModel.INotifyPropertyChanged;
					this.AttachDetachPropertyChanged(inpc, true);
				}
				if (this.ItemsSource != null)
				{
					this.SetupDataManager();
				}
				this.NodeLayout.Tree.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000552E File Offset: 0x0000372E
		internal void OnNodeLayoutPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!this._isDisposed)
			{
				this.OnNodeLayoutPropertyChanged((global::Infragistics.Controls.Menus.NodeLayout)sender, e.PropertyName);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000554A File Offset: 0x0000374A
		internal void NodeLayout_ChildNodeLayoutAdded(object sender, global::Infragistics.Controls.Menus.NodeLayoutEventArgs e)
		{
			this.OnChildNodeLayoutAdded(e.NodeLayout);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005558 File Offset: 0x00003758
		internal void NodeLayout_ChildNodeLayoutRemoved(object sender, global::Infragistics.Controls.Menus.NodeLayoutEventArgs e)
		{
			this.OnChildNodeLayoutRemoved(e.NodeLayout);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005566 File Offset: 0x00003766
		internal void NodeLayout_ChildNodeLayoutVisibilityChanged(object sender, global::Infragistics.Controls.Menus.NodeLayoutEventArgs e)
		{
			this.OnChildNodeLayoutVisibilityChanged(e.NodeLayout);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005574 File Offset: 0x00003774
		internal void NodeLayout_NodeLayoutDisposed(object sender, global::System.EventArgs e)
		{
			this.UnregisterNodesManager(true, true, true);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000557F File Offset: 0x0000377F
		private void DataManager_NewObjectGeneration(object sender, global::Infragistics.HandleableObjectGenerationEventArgs e)
		{
			this.NodeLayout.Tree.OnDataObjectRequested(e, this.NodeLayout, this.ParentNode);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000055A0 File Offset: 0x000037A0
		public int CompareTo(global::Infragistics.Controls.Menus.NodesManager other)
		{
			int num = this.ParentNode.Manager.NodeLayout.NodeLayouts.IndexOf(this.ParentNode.NodeLayout);
			int num2 = other.ParentNode.Manager.NodeLayout.NodeLayouts.IndexOf(other.ParentNode.NodeLayout);
			if (num == num2)
			{
				int index = this.ParentNode.Index;
				int index2 = other.ParentNode.Index;
				return index.CompareTo(index2);
			}
			return num.CompareTo(num2);
		}

		// Token: 0x0400003F RID: 63
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodesManager> _visibleChildManagers;

		// Token: 0x04000040 RID: 64
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Menus.NodesManager> _readOnlyVisibleChildManagers;

		// Token: 0x04000041 RID: 65
		private global::Infragistics.DataManagerBase _dataManager;

		// Token: 0x04000042 RID: 66
		private global::Infragistics.Controls.Menus.XamDataTreeNodesCollection _nodes;

		// Token: 0x04000043 RID: 67
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Menus.XamDataTreeNode> _cachedNodes;

		// Token: 0x04000044 RID: 68
		private global::System.Collections.Generic.Dictionary<object, int> _duplicateObjectValidator;

		// Token: 0x04000045 RID: 69
		private global::System.Collections.IEnumerable _itemSource;

		// Token: 0x04000046 RID: 70
		private global::Infragistics.Controls.Menus.NodeLayout _nodeLayout;

		// Token: 0x04000047 RID: 71
		private bool _isDisposed;

		// Token: 0x04000048 RID: 72
		private bool _suppressVisibleChildManagersSorting;

		// Token: 0x04000049 RID: 73
		private global::System.Collections.Generic.List<global::System.WeakReference> _attachedPropertyChangedTargets = new global::System.Collections.Generic.List<global::System.WeakReference>();
	}
}
