using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001BE RID: 446
	public class GridViewSettings : global::Infragistics.Windows.Controls.ViewSettingsBase
	{
		// Token: 0x06001A39 RID: 6713 RVA: 0x000728BD File Offset: 0x00070ABD
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x000728BF File Offset: 0x00070ABF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Reset()
		{
			this.ResetOrientation();
			this.ResetHeightInInfiniteContainers();
			this.ResetWidthInInfiniteContainers();
			this.ResetUseNestedPanels();
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000728D9 File Offset: 0x00070AD9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return this.ShouldSerializeHeightInInfiniteContainers() || this.ShouldSerializeOrientation() || this.ShouldSerializeUseNestedPanels() || this.ShouldSerializeWidthInInfiniteContainers();
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000728FB File Offset: 0x00070AFB
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0007290D File Offset: 0x00070B0D
		public double HeightInInfiniteContainers
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.HeightInInfiniteContainersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.HeightInInfiniteContainersProperty, value);
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00072920 File Offset: 0x00070B20
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeightInInfiniteContainers()
		{
			return !double.IsNaN(this.HeightInInfiniteContainers);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00072930 File Offset: 0x00070B30
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeightInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.HeightInInfiniteContainersProperty);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0007293D File Offset: 0x00070B3D
		private static bool OnValidateOrientation(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Controls.Orientation), value))
			{
				throw new global::System.ArgumentException();
			}
			return true;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00072958 File Offset: 0x00070B58
		private static void OnOrientationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)dependencyObject;
			global::System.Windows.Controls.Orientation cachedOrientation = (global::System.Windows.Controls.Orientation)e.NewValue;
			gridViewSettings._cachedOrientation = cachedOrientation;
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x00072980 File Offset: 0x00070B80
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x00072988 File Offset: 0x00070B88
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return this._cachedOrientation;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.OrientationProperty, value);
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0007299B File Offset: 0x00070B9B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOrientation()
		{
			return this.Orientation != (global::System.Windows.Controls.Orientation)global::Infragistics.Windows.DataPresenter.GridViewSettings.OrientationProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000729BC File Offset: 0x00070BBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOrientation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.OrientationProperty);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x000729C9 File Offset: 0x00070BC9
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x000729DB File Offset: 0x00070BDB
		public double WidthInInfiniteContainers
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.WidthInInfiniteContainersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.WidthInInfiniteContainersProperty, value);
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000729EE File Offset: 0x00070BEE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWidthInInfiniteContainers()
		{
			return !double.IsNaN(this.WidthInInfiniteContainers);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x000729FE File Offset: 0x00070BFE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWidthInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.WidthInInfiniteContainersProperty);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00072A0C File Offset: 0x00070C0C
		private static void OnUseNestedPanelsChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)dependencyObject;
			bool cachedUseNestedPanels = (bool)e.NewValue;
			gridViewSettings._cachedUseNestedPanels = cachedUseNestedPanels;
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00072A34 File Offset: 0x00070C34
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x00072A3C File Offset: 0x00070C3C
		public bool UseNestedPanels
		{
			get
			{
				return this._cachedUseNestedPanels;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty, value);
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00072A4F File Offset: 0x00070C4F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseNestedPanels()
		{
			return this.UseNestedPanels != (bool)global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00072A70 File Offset: 0x00070C70
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseNestedPanels()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00072A80 File Offset: 0x00070C80
		internal void EnumeratePropertiesWithNonDefaultValues(global::System.ComponentModel.PropertyChangedEventHandler callback)
		{
			global::System.Windows.LocalValueEnumerator localValueEnumerator = base.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (!object.Equals(localValueEntry.Property.DefaultMetadata.DefaultValue, localValueEntry.Value))
				{
					callback(this, new global::System.ComponentModel.PropertyChangedEventArgs(localValueEntry.Property.Name));
				}
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00072ADE File Offset: 0x00070CDE
		private static bool ValidatePositiveDouble(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value > 0.0);
		}

		// Token: 0x04000AE0 RID: 2784
		public static readonly global::System.Windows.DependencyProperty HeightInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("HeightInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.ValidatePositiveDouble));

		// Token: 0x04000AE1 RID: 2785
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.OnOrientationChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.OnValidateOrientation));

		// Token: 0x04000AE2 RID: 2786
		private global::System.Windows.Controls.Orientation _cachedOrientation = global::System.Windows.Controls.Orientation.Vertical;

		// Token: 0x04000AE3 RID: 2787
		public static readonly global::System.Windows.DependencyProperty WidthInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("WidthInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.ValidatePositiveDouble));

		// Token: 0x04000AE4 RID: 2788
		public static readonly global::System.Windows.DependencyProperty UseNestedPanelsProperty = global::System.Windows.DependencyProperty.Register("UseNestedPanels", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.OnUseNestedPanelsChanged)));

		// Token: 0x04000AE5 RID: 2789
		private bool _cachedUseNestedPanels = (bool)global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty.DefaultMetadata.DefaultValue;
	}
}
