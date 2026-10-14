using System;
using System.Windows;
using System.Windows.Media;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000054 RID: 84
	public class CalendarResourceProvider : global::Infragistics.Controls.Primitives.ResourceProviderWithOverrides<global::Infragistics.Controls.Editors.CalendarResourceId>
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x00014740 File Offset: 0x00012940
		protected override object GetResource(global::Infragistics.Controls.Editors.CalendarResourceId id)
		{
			this.VerifyResources();
			object obj = base.GetResource(id);
			if (obj == null)
			{
				switch (id)
				{
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemBackgroundBrush:
					obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.ItemBackgroundBrush);
					break;
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush:
					break;
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodayBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemBackgroundBrush:
					obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemBackgroundBrush);
					break;
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodayForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemForegroundBrush:
					obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush);
					break;
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedItemBackgroundBrush:
				{
					object obj2;
					if ((obj2 = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemBackgroundBrush)) == null)
					{
						obj2 = (base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemBackgroundBrush) ?? base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemBackgroundBrush));
					}
					obj = obj2;
					break;
				}
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedItemForegroundBrush:
				{
					object obj3;
					if ((obj3 = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemForegroundBrush)) == null)
					{
						obj3 = (base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemForegroundBrush) ?? base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush));
					}
					obj = obj3;
					break;
				}
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedFocusedItemForegroundBrush:
				{
					object obj4;
					if ((obj4 = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemForegroundBrush)) == null)
					{
						obj4 = (base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemForegroundBrush) ?? base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush));
					}
					obj = obj4;
					break;
				}
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedFocusedItemBackgroundBrush:
				{
					object obj5;
					if ((obj5 = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemBackgroundBrush)) == null)
					{
						obj5 = (base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemBackgroundBrush) ?? base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemBackgroundBrush));
					}
					obj = obj5;
					break;
				}
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingMouseOverItemForegroundBrush:
					obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush);
					break;
				default:
					switch (id)
					{
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemBackgroundBrush:
						obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemBackgroundBrush);
						break;
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemForegroundBrush:
						obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.SelectedItemForegroundBrush);
						break;
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemBackgroundBrush:
						obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemBackgroundBrush);
						break;
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemForegroundBrush:
						obj = base.GetResource(global::Infragistics.Controls.Editors.CalendarResourceId.SelectedFocusedItemForegroundBrush);
						break;
					}
					break;
				}
			}
			return obj;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000148B0 File Offset: 0x00012AB0
		protected override bool IsResourceValid(global::Infragistics.Controls.Editors.CalendarResourceId id, object resource)
		{
			if (resource == null)
			{
				switch (id)
				{
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodayBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodayForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedItemForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingSelectedFocusedItemForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedItemBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedItemForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedFocusedItemForegroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingTodaySelectedFocusedItemBackgroundBrush:
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingMouseOverItemForegroundBrush:
					break;
				case global::Infragistics.Controls.Editors.CalendarResourceId.LeadingOrTrailingItemForegroundBrush:
					goto IL_5F;
				default:
					switch (id)
					{
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemBackgroundBrush:
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedItemForegroundBrush:
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemBackgroundBrush:
					case global::Infragistics.Controls.Editors.CalendarResourceId.TodaySelectedFocusedItemForegroundBrush:
						break;
					default:
						goto IL_5F;
					}
					break;
				}
				return true;
			}
			IL_5F:
			if (id > global::Infragistics.Controls.Editors.CalendarResourceId.ItemCorderRadius)
			{
				switch (id)
				{
				case global::Infragistics.Controls.Editors.CalendarResourceId.ScrollNextRepeatButtonStyle:
				case global::Infragistics.Controls.Editors.CalendarResourceId.ScrollPreviousRepeatButtonStyle:
					break;
				default:
					if (id != global::Infragistics.Controls.Editors.CalendarResourceId.TodayButtonStyle)
					{
						goto IL_B8;
					}
					break;
				}
				return resource is global::System.Windows.Style;
			}
			switch (id)
			{
			case global::Infragistics.Controls.Editors.CalendarResourceId.CalendarDayStyle:
			case global::Infragistics.Controls.Editors.CalendarResourceId.CalendarItemStyle:
				return resource == null || resource is global::System.Windows.Style;
			default:
				if (id == global::Infragistics.Controls.Editors.CalendarResourceId.ItemCorderRadius)
				{
					return resource is global::System.Windows.CornerRadius;
				}
				break;
			}
			IL_B8:
			return resource is global::System.Windows.Media.Brush;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001497E File Offset: 0x00012B7E
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00014986 File Offset: 0x00012B86
		public global::Infragistics.Controls.Editors.CalendarResourceSet ResourceSet
		{
			get
			{
				return this._resourceSet;
			}
			set
			{
				if (value != this._resourceSet)
				{
					this._resourceSet = value;
					this._resources = null;
					this.InvalidateResources();
					base.RaisePropertyChangedEvent("ResourceSet");
				}
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000149B0 File Offset: 0x00012BB0
		private static global::System.Windows.ResourceDictionary LoadResourceSet(string resourceSetName)
		{
			global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
			string resourcePath = string.Format("Themes/ResourceSets/ResourceSet_{0}.xaml", resourceSetName);
			global::System.Uri source = global::Infragistics.CoreUtilities.BuildEmbeddedResourceUri(typeof(global::Infragistics.Controls.Editors.CalendarResourceProvider).Assembly, resourcePath);
			resourceDictionary.Source = source;
			if (resourceSetName != "Generic")
			{
				resourceDictionary.MergedDictionaries.Add(global::Infragistics.Controls.Editors.CalendarResourceProvider.LoadResourceSet("Generic"));
			}
			global::System.Windows.FrameworkElement frameworkElement = new global::System.Windows.FrameworkElement();
			frameworkElement.Resources = resourceDictionary;
			return resourceDictionary;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00014A1C File Offset: 0x00012C1C
		private void VerifyResources()
		{
			if (base.DefaultResourcesHighContrast == null)
			{
				base.DefaultResourcesHighContrast = global::Infragistics.Controls.Editors.CalendarResourceProvider.LoadResourceSet("HighContrast");
			}
			if (this._resources == null)
			{
				this._resources = global::Infragistics.Controls.Editors.CalendarResourceProvider.LoadResourceSet(this.ResourceSet.ToString());
				base.DefaultResources = this._resources;
			}
		}

		// Token: 0x04000226 RID: 550
		private const string ResourceSetUriMask = "Themes/ResourceSets/ResourceSet_{0}.xaml";

		// Token: 0x04000227 RID: 551
		private global::System.Windows.ResourceDictionary _resources;

		// Token: 0x04000228 RID: 552
		private global::Infragistics.Controls.Editors.CalendarResourceSet _resourceSet;
	}
}
