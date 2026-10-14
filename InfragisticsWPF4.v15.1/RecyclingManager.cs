using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000088 RID: 136
	public class RecyclingManager
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001489A File Offset: 0x00012A9A
		public static global::Infragistics.RecyclingManager Manager
		{
			get
			{
				return global::Infragistics.RecyclingManager._manager;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000148A1 File Offset: 0x00012AA1
		private RecyclingManager()
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000148AC File Offset: 0x00012AAC
		private static global::Infragistics.RecyclingManager.PanelInfo GetRecycleInfo(global::System.Windows.Controls.Panel panel)
		{
			if (panel == null)
			{
				throw new global::System.ArgumentNullException("panel");
			}
			global::Infragistics.RecyclingManager.PanelInfo panelInfo = (global::Infragistics.RecyclingManager.PanelInfo)panel.GetValue(global::Infragistics.RecyclingManager.RecycleInfoProperty);
			if (panelInfo == null)
			{
				panelInfo = new global::Infragistics.RecyclingManager.PanelInfo(panel);
				panel.SetValue(global::Infragistics.RecyclingManager.RecycleInfoProperty, panelInfo);
			}
			return panelInfo;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000148EF File Offset: 0x00012AEF
		public bool AttachElement(global::Infragistics.ISupportRecycling obj, global::System.Windows.Controls.Panel parent)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(parent).AttachElement(obj);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000148FD File Offset: 0x00012AFD
		public bool ReleaseElement(global::Infragistics.ISupportRecycling obj, global::System.Windows.Controls.Panel parent)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseElement(obj);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001490B File Offset: 0x00012B0B
		public void ReleaseAll(global::System.Windows.Controls.Panel parent)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAll();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00014918 File Offset: 0x00012B18
		public void ReleaseAll(global::System.Windows.Controls.Panel parent, string id)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAll(id);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00014926 File Offset: 0x00012B26
		public void ReleaseAll(global::System.Windows.Controls.Panel parent, global::System.Type t)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAll(t);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00014934 File Offset: 0x00012B34
		internal void ReleaseAllAvailable(global::System.Windows.Controls.Panel parent)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAllAvailable();
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00014944 File Offset: 0x00012B44
		public global::Infragistics.ISupportRecycling ItemFromElement(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.Controls.Panel panel = global::System.Windows.Media.VisualTreeHelper.GetParent(element) as global::System.Windows.Controls.Panel;
			global::Infragistics.ISupportRecycling result = null;
			if (panel != null)
			{
				result = global::Infragistics.RecyclingManager.GetRecycleInfo(panel).ItemFromElement(element);
			}
			return result;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00014970 File Offset: 0x00012B70
		public global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> GetRecentlyAvailableElements(global::System.Windows.Controls.Panel panel, bool release)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(panel).GetRecentlyAvailableElements(release);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001497E File Offset: 0x00012B7E
		public global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> GetAvailableElements(global::System.Windows.Controls.Panel panel)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(panel).GetAvailableElements();
		}

		// Token: 0x040001EC RID: 492
		private static global::Infragistics.RecyclingManager _manager = new global::Infragistics.RecyclingManager();

		// Token: 0x040001ED RID: 493
		private static readonly global::System.Windows.DependencyProperty RecycleInfoProperty = global::System.Windows.DependencyProperty.RegisterAttached("RecycleInfo", typeof(global::Infragistics.RecyclingManager.PanelInfo), typeof(global::Infragistics.RecyclingManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x02000089 RID: 137
		private class PanelInfo
		{
			// Token: 0x0600056F RID: 1391 RVA: 0x000149C0 File Offset: 0x00012BC0
			internal PanelInfo(global::System.Windows.Controls.Panel panel)
			{
				this.Panel = panel;
				this._itemForContainer = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.ISupportRecycling>();
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x000149DC File Offset: 0x00012BDC
			public bool AttachElement(global::Infragistics.ISupportRecycling obj)
			{
				bool flag = false;
				if (obj.AttachedElement == null)
				{
					global::System.Windows.FrameworkElement frameworkElement = null;
					global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> availableElements = null;
					global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> usedElements = null;
					global::System.Type recyclingElementType = obj.RecyclingElementType;
					if (recyclingElementType != null)
					{
						if (this._availableControlsSpecific != null)
						{
							this._availableControlsSpecific.TryGetValue(recyclingElementType, out availableElements);
						}
						if (this._usedControlsSpecific == null)
						{
							this._usedControlsSpecific = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>>();
						}
						if (!this._usedControlsSpecific.TryGetValue(recyclingElementType, out usedElements))
						{
							usedElements = (this._usedControlsSpecific[recyclingElementType] = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>());
						}
					}
					else
					{
						string recyclingIdentifier = obj.RecyclingIdentifier;
						if (recyclingIdentifier == null)
						{
							return false;
						}
						if (this._availableIdentifierControlsSpecific != null)
						{
							this._availableIdentifierControlsSpecific.TryGetValue(recyclingIdentifier, out availableElements);
						}
						if (this._usedIdentifierControlsSpecific == null)
						{
							this._usedIdentifierControlsSpecific = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>>();
						}
						if (!this._usedIdentifierControlsSpecific.TryGetValue(recyclingIdentifier, out usedElements))
						{
							usedElements = (this._usedIdentifierControlsSpecific[recyclingIdentifier] = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>());
						}
					}
					flag = this.AttachElement(obj, availableElements, usedElements, out frameworkElement);
					this._itemForContainer[frameworkElement] = obj;
					obj.AttachedElement = frameworkElement;
					obj.OnElementAttached(frameworkElement);
					global::Infragistics.IRecyclableElementHost recyclableElementHost = this.Panel as global::Infragistics.IRecyclableElementHost;
					if (recyclableElementHost != null)
					{
						recyclableElementHost.OnElementAttached(obj, frameworkElement, flag);
					}
				}
				return flag;
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00014B04 File Offset: 0x00012D04
			private bool AttachElement(global::Infragistics.ISupportRecycling item, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> availableElements, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> usedElements, out global::System.Windows.FrameworkElement element)
			{
				global::Infragistics.IRecyclableElement recyclableElement;
				if (availableElements != null)
				{
					int num = availableElements.Count - 1;
					for (int i = num; i >= 0; i--)
					{
						element = availableElements[i];
						recyclableElement = (element as global::Infragistics.IRecyclableElement);
						if (recyclableElement == null || !recyclableElement.DelayRecycling)
						{
							if (i < num)
							{
								availableElements[i] = availableElements[num];
							}
							availableElements.RemoveAt(num);
							if (this._recentlyRecycled != null)
							{
								this._recentlyRecycled.Remove(element);
							}
							usedElements.Add(element);
							return false;
						}
					}
				}
				element = item.CreateInstanceOfRecyclingElement();
				recyclableElement = (element as global::Infragistics.IRecyclableElement);
				if (recyclableElement != null)
				{
					recyclableElement.OwnerPanel = this.Panel;
				}
				usedElements.Add(element);
				this.Panel.Children.Add(element);
				return true;
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x00014BC4 File Offset: 0x00012DC4
			internal global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> GetAvailableElements()
			{
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				if (this._availableControlsSpecific != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> keyValuePair in this._availableControlsSpecific)
					{
						list.AddRange(keyValuePair.Value);
					}
				}
				if (this._availableIdentifierControlsSpecific != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> keyValuePair2 in this._availableIdentifierControlsSpecific)
					{
						list.AddRange(keyValuePair2.Value);
					}
				}
				return list;
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x00014C80 File Offset: 0x00012E80
			public global::Infragistics.ISupportRecycling ItemFromElement(global::System.Windows.FrameworkElement element)
			{
				global::Infragistics.ISupportRecycling result;
				this._itemForContainer.TryGetValue(element, out result);
				return result;
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x00014CA0 File Offset: 0x00012EA0
			internal global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> GetRecentlyAvailableElements(bool release)
			{
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				if (this._recentlyRecycled != null)
				{
					list.AddRange(this._recentlyRecycled);
					if (release)
					{
						this._recentlyRecycled.Clear();
					}
				}
				return list;
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x00014CD6 File Offset: 0x00012ED6
			private static void OnElementReleased(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element)
			{
				if (item != null)
				{
					item.IsDirty = false;
					item.AttachedElement = null;
					item.OnElementReleased(element);
				}
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00014CF0 File Offset: 0x00012EF0
			public void ReleaseAll()
			{
				this.ReleaseAll<global::System.Type>(this._availableControlsSpecific);
				this.ReleaseAll<string>(this._availableIdentifierControlsSpecific);
				this.ReleaseAll<global::System.Type>(this._usedControlsSpecific);
				this.ReleaseAll<string>(this._usedIdentifierControlsSpecific);
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00014D22 File Offset: 0x00012F22
			public void ReleaseAll(string id)
			{
				this.ReleaseAll<string>(this._usedIdentifierControlsSpecific, id);
				this.ReleaseAll<string>(this._availableIdentifierControlsSpecific, id);
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00014D3E File Offset: 0x00012F3E
			public void ReleaseAll(global::System.Type t)
			{
				this.ReleaseAll<global::System.Type>(this._usedControlsSpecific, t);
				this.ReleaseAll<global::System.Type>(this._availableControlsSpecific, t);
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00014D5C File Offset: 0x00012F5C
			private void ReleaseAll<T>(global::System.Collections.Generic.Dictionary<T, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> dictionary)
			{
				if (dictionary != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<T, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> keyValuePair in dictionary)
					{
						this.ReleaseAll(keyValuePair.Value);
					}
				}
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00014DB4 File Offset: 0x00012FB4
			private void ReleaseAll<T>(global::System.Collections.Generic.Dictionary<T, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> dictionary, T key)
			{
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> elements;
				if (dictionary != null && dictionary.TryGetValue(key, out elements))
				{
					this.ReleaseAll(elements);
				}
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00014DD8 File Offset: 0x00012FD8
			private void ReleaseAll(global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> elements)
			{
				global::System.Windows.Controls.UIElementCollection children = this.Panel.Children;
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>(elements);
				foreach (global::System.Windows.FrameworkElement frameworkElement in list)
				{
					global::Infragistics.ISupportRecycling supportRecycling;
					if (this._itemForContainer.TryGetValue(frameworkElement, out supportRecycling))
					{
						this._itemForContainer.Remove(frameworkElement);
					}
					if (this._recentlyRecycled != null)
					{
						this._recentlyRecycled.Remove(frameworkElement);
					}
					elements.Remove(frameworkElement);
					children.Remove(frameworkElement);
					global::Infragistics.IRecyclableElement recyclableElement = frameworkElement as global::Infragistics.IRecyclableElement;
					if (recyclableElement != null)
					{
						recyclableElement.OwnerPanel = null;
					}
					if (supportRecycling != null)
					{
						global::Infragistics.RecyclingManager.PanelInfo.OnElementReleased(supportRecycling, frameworkElement);
					}
					global::Infragistics.IRecyclableElementHost recyclableElementHost = this.Panel as global::Infragistics.IRecyclableElementHost;
					if (recyclableElementHost != null)
					{
						recyclableElementHost.OnElementReleased(supportRecycling, frameworkElement, true);
					}
				}
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00014EB4 File Offset: 0x000130B4
			internal void ReleaseAllAvailable()
			{
				this.ReleaseAll<global::System.Type>(this._availableControlsSpecific);
				this.ReleaseAll<string>(this._availableIdentifierControlsSpecific);
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x00014ED0 File Offset: 0x000130D0
			public bool ReleaseElement(global::Infragistics.ISupportRecycling obj)
			{
				global::System.Windows.FrameworkElement attachedElement = obj.AttachedElement;
				if (attachedElement != null && obj.OnElementReleasing(attachedElement))
				{
					global::System.Type recyclingElementType = obj.RecyclingElementType;
					global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = null;
					global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list2 = null;
					bool flag = obj.IsDirty;
					global::Infragistics.IRecyclableElementHost recyclableElementHost = this.Panel as global::Infragistics.IRecyclableElementHost;
					if (!flag && recyclableElementHost != null)
					{
						flag = recyclableElementHost.ShouldRemove(obj, attachedElement);
					}
					if (recyclingElementType != null)
					{
						if (this._usedControlsSpecific != null && this._usedControlsSpecific.TryGetValue(recyclingElementType, out list) && !flag)
						{
							global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> dictionary = this._availableControlsSpecific;
							if (dictionary == null)
							{
								dictionary = (this._availableControlsSpecific = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>>());
							}
							if (!dictionary.TryGetValue(recyclingElementType, out list2))
							{
								list2 = (dictionary[recyclingElementType] = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>());
							}
						}
					}
					else
					{
						string recyclingIdentifier = obj.RecyclingIdentifier;
						if (this._usedIdentifierControlsSpecific != null && this._usedIdentifierControlsSpecific.TryGetValue(recyclingIdentifier, out list) && !flag)
						{
							global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> dictionary2 = this._availableIdentifierControlsSpecific;
							if (dictionary2 == null)
							{
								dictionary2 = (this._availableIdentifierControlsSpecific = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>>());
							}
							if (!dictionary2.TryGetValue(recyclingIdentifier, out list2))
							{
								list2 = (dictionary2[recyclingIdentifier] = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>());
							}
						}
					}
					if (list != null)
					{
						int num = list.IndexOf(attachedElement);
						if (num >= 0)
						{
							int num2 = list.Count - 1;
							if (num < num2)
							{
								list[num] = list[num2];
							}
							list.RemoveAt(num2);
							if (!flag)
							{
								list2.Add(attachedElement);
							}
							else
							{
								global::Infragistics.IRecyclableElement recyclableElement = attachedElement as global::Infragistics.IRecyclableElement;
								if (recyclableElement != null)
								{
									recyclableElement.OwnerPanel = null;
								}
								this.Panel.Children.Remove(attachedElement);
							}
						}
						this._itemForContainer.Remove(attachedElement);
						global::Infragistics.RecyclingManager.PanelInfo.OnElementReleased(obj, attachedElement);
						if (!flag)
						{
							global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list3 = this._recentlyRecycled;
							if (list3 == null)
							{
								list3 = (this._recentlyRecycled = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>());
							}
							list3.Add(attachedElement);
						}
						if (recyclableElementHost != null)
						{
							recyclableElementHost.OnElementReleased(obj, attachedElement, flag);
						}
						return true;
					}
				}
				return false;
			}

			// Token: 0x040001EE RID: 494
			private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _availableControlsSpecific;

			// Token: 0x040001EF RID: 495
			private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _usedControlsSpecific;

			// Token: 0x040001F0 RID: 496
			private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _availableIdentifierControlsSpecific;

			// Token: 0x040001F1 RID: 497
			private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _usedIdentifierControlsSpecific;

			// Token: 0x040001F2 RID: 498
			private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _recentlyRecycled;

			// Token: 0x040001F3 RID: 499
			private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.ISupportRecycling> _itemForContainer;

			// Token: 0x040001F4 RID: 500
			internal readonly global::System.Windows.Controls.Panel Panel;
		}
	}
}
