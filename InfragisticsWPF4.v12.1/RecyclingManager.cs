using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000071 RID: 113
	public class RecyclingManager
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00012082 File Offset: 0x00010282
		public static global::Infragistics.RecyclingManager Manager
		{
			get
			{
				return global::Infragistics.RecyclingManager._manager;
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00012089 File Offset: 0x00010289
		private RecyclingManager()
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00012094 File Offset: 0x00010294
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

		// Token: 0x060004A4 RID: 1188 RVA: 0x000120D7 File Offset: 0x000102D7
		public bool AttachElement(global::Infragistics.ISupportRecycling obj, global::System.Windows.Controls.Panel parent)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(parent).AttachElement(obj);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000120E5 File Offset: 0x000102E5
		public bool ReleaseElement(global::Infragistics.ISupportRecycling obj, global::System.Windows.Controls.Panel parent)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseElement(obj);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000120F3 File Offset: 0x000102F3
		public void ReleaseAll(global::System.Windows.Controls.Panel parent)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAll();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00012100 File Offset: 0x00010300
		public void ReleaseAll(global::System.Windows.Controls.Panel parent, string id)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAll(id);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001210E File Offset: 0x0001030E
		public void ReleaseAll(global::System.Windows.Controls.Panel parent, global::System.Type t)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAll(t);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001211C File Offset: 0x0001031C
		internal void ReleaseAllAvailable(global::System.Windows.Controls.Panel parent)
		{
			global::Infragistics.RecyclingManager.GetRecycleInfo(parent).ReleaseAllAvailable();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001212C File Offset: 0x0001032C
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

		// Token: 0x060004AB RID: 1195 RVA: 0x00012158 File Offset: 0x00010358
		public global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> GetRecentlyAvailableElements(global::System.Windows.Controls.Panel panel, bool release)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(panel).GetRecentlyAvailableElements(release);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00012166 File Offset: 0x00010366
		public global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> GetAvailableElements(global::System.Windows.Controls.Panel panel)
		{
			return global::Infragistics.RecyclingManager.GetRecycleInfo(panel).GetAvailableElements();
		}

		// Token: 0x0400017B RID: 379
		private static global::Infragistics.RecyclingManager _manager = new global::Infragistics.RecyclingManager();

		// Token: 0x0400017C RID: 380
		private static readonly global::System.Windows.DependencyProperty RecycleInfoProperty = global::System.Windows.DependencyProperty.RegisterAttached("RecycleInfo", typeof(global::Infragistics.RecyclingManager.PanelInfo), typeof(global::Infragistics.RecyclingManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x02000072 RID: 114
		private class PanelInfo
		{
			// Token: 0x060004AE RID: 1198 RVA: 0x000121A8 File Offset: 0x000103A8
			internal PanelInfo(global::System.Windows.Controls.Panel panel)
			{
				this.Panel = panel;
				this._itemForContainer = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.ISupportRecycling>();
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x000121C4 File Offset: 0x000103C4
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

			// Token: 0x060004B0 RID: 1200 RVA: 0x000122EC File Offset: 0x000104EC
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

			// Token: 0x060004B1 RID: 1201 RVA: 0x000123AC File Offset: 0x000105AC
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

			// Token: 0x060004B2 RID: 1202 RVA: 0x00012468 File Offset: 0x00010668
			public global::Infragistics.ISupportRecycling ItemFromElement(global::System.Windows.FrameworkElement element)
			{
				global::Infragistics.ISupportRecycling result;
				this._itemForContainer.TryGetValue(element, out result);
				return result;
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x00012488 File Offset: 0x00010688
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

			// Token: 0x060004B4 RID: 1204 RVA: 0x000124BE File Offset: 0x000106BE
			private static void OnElementReleased(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element)
			{
				if (item != null)
				{
					item.IsDirty = false;
					item.AttachedElement = null;
					item.OnElementReleased(element);
				}
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x000124D8 File Offset: 0x000106D8
			public void ReleaseAll()
			{
				this.ReleaseAll<global::System.Type>(this._availableControlsSpecific);
				this.ReleaseAll<string>(this._availableIdentifierControlsSpecific);
				this.ReleaseAll<global::System.Type>(this._usedControlsSpecific);
				this.ReleaseAll<string>(this._usedIdentifierControlsSpecific);
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x0001250A File Offset: 0x0001070A
			public void ReleaseAll(string id)
			{
				this.ReleaseAll<string>(this._usedIdentifierControlsSpecific, id);
				this.ReleaseAll<string>(this._availableIdentifierControlsSpecific, id);
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x00012526 File Offset: 0x00010726
			public void ReleaseAll(global::System.Type t)
			{
				this.ReleaseAll<global::System.Type>(this._usedControlsSpecific, t);
				this.ReleaseAll<global::System.Type>(this._availableControlsSpecific, t);
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x00012544 File Offset: 0x00010744
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

			// Token: 0x060004B9 RID: 1209 RVA: 0x0001259C File Offset: 0x0001079C
			private void ReleaseAll<T>(global::System.Collections.Generic.Dictionary<T, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> dictionary, T key)
			{
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> elements;
				if (dictionary != null && dictionary.TryGetValue(key, out elements))
				{
					this.ReleaseAll(elements);
				}
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x000125C0 File Offset: 0x000107C0
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

			// Token: 0x060004BB RID: 1211 RVA: 0x0001269C File Offset: 0x0001089C
			internal void ReleaseAllAvailable()
			{
				this.ReleaseAll<global::System.Type>(this._availableControlsSpecific);
				this.ReleaseAll<string>(this._availableIdentifierControlsSpecific);
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x000126B8 File Offset: 0x000108B8
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

			// Token: 0x0400017D RID: 381
			private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _availableControlsSpecific;

			// Token: 0x0400017E RID: 382
			private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _usedControlsSpecific;

			// Token: 0x0400017F RID: 383
			private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _availableIdentifierControlsSpecific;

			// Token: 0x04000180 RID: 384
			private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>> _usedIdentifierControlsSpecific;

			// Token: 0x04000181 RID: 385
			private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _recentlyRecycled;

			// Token: 0x04000182 RID: 386
			private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.ISupportRecycling> _itemForContainer;

			// Token: 0x04000183 RID: 387
			internal readonly global::System.Windows.Controls.Panel Panel;
		}
	}
}
