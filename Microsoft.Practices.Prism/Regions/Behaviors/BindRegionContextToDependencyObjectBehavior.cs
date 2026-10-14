using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000051 RID: 81
	public class BindRegionContextToDependencyObjectBehavior : global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000073F7 File Offset: 0x000055F7
		// (set) Token: 0x0600025F RID: 607 RVA: 0x000073FF File Offset: 0x000055FF
		public global::Microsoft.Practices.Prism.Regions.IRegion Region { get; set; }

		// Token: 0x06000260 RID: 608 RVA: 0x00007408 File Offset: 0x00005608
		public void Attach()
		{
			this.Region.Views.CollectionChanged += this.Views_CollectionChanged;
			this.Region.PropertyChanged += this.Region_PropertyChanged;
			global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior.SetContextToViews(this.Region.Views, this.Region.Context);
			this.AttachNotifyChangeEvent(this.Region.Views);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007474 File Offset: 0x00005674
		private static void SetContextToViews(global::System.Collections.IEnumerable views, object context)
		{
			foreach (object obj in views)
			{
				global::System.Windows.DependencyObject dependencyObject = obj as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::Microsoft.Practices.Prism.ObservableObject<object> observableContext = global::Microsoft.Practices.Prism.Regions.RegionContext.GetObservableContext(dependencyObject);
					observableContext.Value = context;
				}
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000074D8 File Offset: 0x000056D8
		private void AttachNotifyChangeEvent(global::System.Collections.IEnumerable views)
		{
			foreach (object obj in views)
			{
				global::System.Windows.DependencyObject dependencyObject = obj as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::Microsoft.Practices.Prism.ObservableObject<object> observableContext = global::Microsoft.Practices.Prism.Regions.RegionContext.GetObservableContext(dependencyObject);
					observableContext.PropertyChanged += this.ViewRegionContext_OnPropertyChangedEvent;
				}
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007548 File Offset: 0x00005748
		private void DetachNotifyChangeEvent(global::System.Collections.IEnumerable views)
		{
			foreach (object obj in views)
			{
				global::System.Windows.DependencyObject dependencyObject = obj as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::Microsoft.Practices.Prism.ObservableObject<object> observableContext = global::Microsoft.Practices.Prism.Regions.RegionContext.GetObservableContext(dependencyObject);
					observableContext.PropertyChanged -= this.ViewRegionContext_OnPropertyChangedEvent;
				}
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000075B8 File Offset: 0x000057B8
		private void ViewRegionContext_OnPropertyChangedEvent(object sender, global::System.ComponentModel.PropertyChangedEventArgs args)
		{
			if (args.PropertyName == "Value")
			{
				global::Microsoft.Practices.Prism.ObservableObject<object> observableObject = (global::Microsoft.Practices.Prism.ObservableObject<object>)sender;
				this.Region.Context = observableObject.Value;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000075F0 File Offset: 0x000057F0
		private void Views_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior.SetContextToViews(e.NewItems, this.Region.Context);
				this.AttachNotifyChangeEvent(e.NewItems);
				return;
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove && this.Region.Context != null)
			{
				this.DetachNotifyChangeEvent(e.OldItems);
				global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior.SetContextToViews(e.OldItems, null);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00007656 File Offset: 0x00005856
		private void Region_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Context")
			{
				global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior.SetContextToViews(this.Region.Views, this.Region.Context);
			}
		}

		// Token: 0x0400008A RID: 138
		public const string BehaviorKey = "ContextToDependencyObject";
	}
}
