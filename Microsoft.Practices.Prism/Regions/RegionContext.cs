using System;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000073 RID: 115
	public static class RegionContext
	{
		// Token: 0x06000327 RID: 807 RVA: 0x00009160 File Offset: 0x00007360
		public static global::Microsoft.Practices.Prism.ObservableObject<object> GetObservableContext(global::System.Windows.DependencyObject view)
		{
			if (view == null)
			{
				throw new global::System.ArgumentNullException("view");
			}
			global::Microsoft.Practices.Prism.ObservableObject<object> observableObject = view.GetValue(global::Microsoft.Practices.Prism.Regions.RegionContext.ObservableRegionContextProperty) as global::Microsoft.Practices.Prism.ObservableObject<object>;
			if (observableObject == null)
			{
				observableObject = new global::Microsoft.Practices.Prism.ObservableObject<object>();
				view.SetValue(global::Microsoft.Practices.Prism.Regions.RegionContext.ObservableRegionContextProperty, observableObject);
			}
			return observableObject;
		}

		// Token: 0x040000B6 RID: 182
		private static readonly global::System.Windows.DependencyProperty ObservableRegionContextProperty = global::System.Windows.DependencyProperty.RegisterAttached("ObservableRegionContext", typeof(global::Microsoft.Practices.Prism.ObservableObject<object>), typeof(global::Microsoft.Practices.Prism.Regions.RegionContext), null);
	}
}
