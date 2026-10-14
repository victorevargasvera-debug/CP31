using System;
using System.ComponentModel;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000052 RID: 82
	public class ClearChildViewsRegionBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0000768D File Offset: 0x0000588D
		public static bool GetClearChildViews(global::System.Windows.DependencyObject target)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			return (bool)target.GetValue(global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior.ClearChildViewsProperty);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000076AD File Offset: 0x000058AD
		public static void SetClearChildViews(global::System.Windows.DependencyObject target, bool value)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			target.SetValue(global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior.ClearChildViewsProperty, value);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000076CE File Offset: 0x000058CE
		protected override void OnAttach()
		{
			base.Region.PropertyChanged += this.Region_PropertyChanged;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000076E8 File Offset: 0x000058E8
		private static void ClearChildViews(global::Microsoft.Practices.Prism.Regions.IRegion region)
		{
			foreach (object obj in region.Views)
			{
				global::System.Windows.DependencyObject dependencyObject = obj as global::System.Windows.DependencyObject;
				if (dependencyObject != null && global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior.GetClearChildViews(dependencyObject))
				{
					dependencyObject.ClearValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty);
				}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000774C File Offset: 0x0000594C
		private void Region_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "RegionManager" && base.Region.RegionManager == null)
			{
				global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior.ClearChildViews(base.Region);
			}
		}

		// Token: 0x0400008C RID: 140
		public const string BehaviorKey = "ClearChildViews";

		// Token: 0x0400008D RID: 141
		public static readonly global::System.Windows.DependencyProperty ClearChildViewsProperty = global::System.Windows.DependencyProperty.RegisterAttached("ClearChildViews", typeof(bool), typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior), new global::System.Windows.PropertyMetadata(false));
	}
}
