using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200004C RID: 76
	public class Region : global::Microsoft.Practices.Prism.Regions.IRegion, global::Microsoft.Practices.Prism.Regions.INavigateAsync, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000229 RID: 553 RVA: 0x00006B92 File Offset: 0x00004D92
		public Region()
		{
			this.Behaviors = new global::Microsoft.Practices.Prism.Regions.RegionBehaviorCollection(this);
			this.sort = new global::System.Comparison<object>(global::Microsoft.Practices.Prism.Regions.Region.DefaultSortComparison);
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600022A RID: 554 RVA: 0x00006BB8 File Offset: 0x00004DB8
		// (remove) Token: 0x0600022B RID: 555 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00006C25 File Offset: 0x00004E25
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00006C2D File Offset: 0x00004E2D
		public global::Microsoft.Practices.Prism.Regions.IRegionBehaviorCollection Behaviors { get; private set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00006C36 File Offset: 0x00004E36
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00006C3E File Offset: 0x00004E3E
		public object Context
		{
			get
			{
				return this.context;
			}
			set
			{
				if (this.context != value)
				{
					this.context = value;
					this.OnPropertyChanged("Context");
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00006C5B File Offset: 0x00004E5B
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00006C64 File Offset: 0x00004E64
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name != null && this.name != value)
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.CannotChangeRegionNameException, new object[]
					{
						this.name
					}));
				}
				if (string.IsNullOrEmpty(value))
				{
					throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.RegionNameCannotBeEmptyException);
				}
				this.name = value;
				this.OnPropertyChanged("Name");
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public virtual global::Microsoft.Practices.Prism.Regions.IViewsCollection Views
		{
			get
			{
				if (this.views == null)
				{
					this.views = new global::Microsoft.Practices.Prism.Regions.ViewsCollection(this.ItemMetadataCollection, (global::Microsoft.Practices.Prism.Regions.ItemMetadata x) => true);
					this.views.SortComparison = this.sort;
				}
				return this.views;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00006D3C File Offset: 0x00004F3C
		public virtual global::Microsoft.Practices.Prism.Regions.IViewsCollection ActiveViews
		{
			get
			{
				if (this.activeViews == null)
				{
					this.activeViews = new global::Microsoft.Practices.Prism.Regions.ViewsCollection(this.ItemMetadataCollection, (global::Microsoft.Practices.Prism.Regions.ItemMetadata x) => x.IsActive);
					this.activeViews.SortComparison = this.sort;
				}
				return this.activeViews;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00006D96 File Offset: 0x00004F96
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00006D9E File Offset: 0x00004F9E
		public global::System.Comparison<object> SortComparison
		{
			get
			{
				return this.sort;
			}
			set
			{
				this.sort = value;
				if (this.activeViews != null)
				{
					this.activeViews.SortComparison = this.sort;
				}
				if (this.views != null)
				{
					this.views.SortComparison = this.sort;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00006DD9 File Offset: 0x00004FD9
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00006DE1 File Offset: 0x00004FE1
		public global::Microsoft.Practices.Prism.Regions.IRegionManager RegionManager
		{
			get
			{
				return this.regionManager;
			}
			set
			{
				if (this.regionManager != value)
				{
					this.regionManager = value;
					this.OnPropertyChanged("RegionManager");
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00006DFE File Offset: 0x00004FFE
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00006E2A File Offset: 0x0000502A
		public global::Microsoft.Practices.Prism.Regions.IRegionNavigationService NavigationService
		{
			get
			{
				if (this.regionNavigationService == null)
				{
					this.regionNavigationService = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.IRegionNavigationService>();
					this.regionNavigationService.Region = this;
				}
				return this.regionNavigationService;
			}
			set
			{
				this.regionNavigationService = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00006E33 File Offset: 0x00005033
		protected virtual global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Practices.Prism.Regions.ItemMetadata> ItemMetadataCollection
		{
			get
			{
				if (this.itemMetadataCollection == null)
				{
					this.itemMetadataCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Practices.Prism.Regions.ItemMetadata>();
				}
				return this.itemMetadataCollection;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00006E4E File Offset: 0x0000504E
		public global::Microsoft.Practices.Prism.Regions.IRegionManager Add(object view)
		{
			return this.Add(view, null, false);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00006E5C File Offset: 0x0000505C
		public global::Microsoft.Practices.Prism.Regions.IRegionManager Add(object view, string viewName)
		{
			if (string.IsNullOrEmpty(viewName))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.StringCannotBeNullOrEmpty, new object[]
				{
					"viewName"
				}));
			}
			return this.Add(view, viewName, false);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00006EA0 File Offset: 0x000050A0
		public virtual global::Microsoft.Practices.Prism.Regions.IRegionManager Add(object view, string viewName, bool createRegionManagerScope)
		{
			global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager = createRegionManagerScope ? this.RegionManager.CreateRegionManager() : this.RegionManager;
			this.InnerAdd(view, viewName, regionManager);
			return regionManager;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00006ED0 File Offset: 0x000050D0
		public virtual void Remove(object view)
		{
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadataOrThrow = this.GetItemMetadataOrThrow(view);
			this.ItemMetadataCollection.Remove(itemMetadataOrThrow);
			global::System.Windows.DependencyObject dependencyObject = view as global::System.Windows.DependencyObject;
			if (dependencyObject != null && global::Microsoft.Practices.Prism.Regions.RegionManager.GetRegionManager(dependencyObject) == this.RegionManager)
			{
				dependencyObject.ClearValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00006F18 File Offset: 0x00005118
		public virtual void Activate(object view)
		{
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadataOrThrow = this.GetItemMetadataOrThrow(view);
			if (!itemMetadataOrThrow.IsActive)
			{
				itemMetadataOrThrow.IsActive = true;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00006F3C File Offset: 0x0000513C
		public virtual void Deactivate(object view)
		{
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadataOrThrow = this.GetItemMetadataOrThrow(view);
			if (itemMetadataOrThrow.IsActive)
			{
				itemMetadataOrThrow.IsActive = false;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00006F7C File Offset: 0x0000517C
		public virtual object GetView(string viewName)
		{
			if (string.IsNullOrEmpty(viewName))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.StringCannotBeNullOrEmpty, new object[]
				{
					"viewName"
				}));
			}
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata = this.ItemMetadataCollection.FirstOrDefault((global::Microsoft.Practices.Prism.Regions.ItemMetadata x) => x.Name == viewName);
			if (itemMetadata != null)
			{
				return itemMetadata.Item;
			}
			return null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00006FEB File Offset: 0x000051EB
		public void RequestNavigate(global::System.Uri target, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			this.NavigationService.RequestNavigate(target, navigationCallback);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007028 File Offset: 0x00005228
		private void InnerAdd(object view, string viewName, global::Microsoft.Practices.Prism.Regions.IRegionManager scopedRegionManager)
		{
			if (this.ItemMetadataCollection.FirstOrDefault((global::Microsoft.Practices.Prism.Regions.ItemMetadata x) => x.Item == view) != null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.RegionViewExistsException);
			}
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata = new global::Microsoft.Practices.Prism.Regions.ItemMetadata(view);
			if (!string.IsNullOrEmpty(viewName))
			{
				if (this.ItemMetadataCollection.FirstOrDefault((global::Microsoft.Practices.Prism.Regions.ItemMetadata x) => x.Name == viewName) != null)
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Microsoft.Practices.Prism.Properties.Resources.RegionViewNameExistsException, new object[]
					{
						viewName
					}));
				}
				itemMetadata.Name = viewName;
			}
			global::System.Windows.DependencyObject dependencyObject = view as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.SetRegionManager(dependencyObject, scopedRegionManager);
			}
			this.ItemMetadataCollection.Add(itemMetadata);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007118 File Offset: 0x00005318
		private global::Microsoft.Practices.Prism.Regions.ItemMetadata GetItemMetadataOrThrow(object view)
		{
			if (view == null)
			{
				throw new global::System.ArgumentNullException("view");
			}
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata = this.ItemMetadataCollection.FirstOrDefault((global::Microsoft.Practices.Prism.Regions.ItemMetadata x) => x.Item == view);
			if (itemMetadata == null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.ViewNotInRegionException, "view");
			}
			return itemMetadata;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00007174 File Offset: 0x00005374
		private void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00007198 File Offset: 0x00005398
		public static int DefaultSortComparison(object x, object y)
		{
			if (x == null)
			{
				if (y == null)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				global::System.Type type = x.GetType();
				global::System.Type type2 = y.GetType();
				global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute x2 = type.GetCustomAttributes(typeof(global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute), true).FirstOrDefault<object>() as global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute;
				global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute y2 = type2.GetCustomAttributes(typeof(global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute), true).FirstOrDefault<object>() as global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute;
				return global::Microsoft.Practices.Prism.Regions.Region.ViewSortHintAttributeComparison(x2, y2);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00007201 File Offset: 0x00005401
		private static int ViewSortHintAttributeComparison(global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute x, global::Microsoft.Practices.Prism.Regions.ViewSortHintAttribute y)
		{
			if (x == null)
			{
				if (y == null)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				return string.Compare(x.Hint, y.Hint, global::System.StringComparison.Ordinal);
			}
		}

		// Token: 0x0400007A RID: 122
		private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Practices.Prism.Regions.ItemMetadata> itemMetadataCollection;

		// Token: 0x0400007B RID: 123
		private string name;

		// Token: 0x0400007C RID: 124
		private global::Microsoft.Practices.Prism.Regions.ViewsCollection views;

		// Token: 0x0400007D RID: 125
		private global::Microsoft.Practices.Prism.Regions.ViewsCollection activeViews;

		// Token: 0x0400007E RID: 126
		private object context;

		// Token: 0x0400007F RID: 127
		private global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager;

		// Token: 0x04000080 RID: 128
		private global::Microsoft.Practices.Prism.Regions.IRegionNavigationService regionNavigationService;

		// Token: 0x04000081 RID: 129
		private global::System.Comparison<object> sort;
	}
}
