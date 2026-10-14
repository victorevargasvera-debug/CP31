using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E5 RID: 485
	public class GridViewSettings : global::Infragistics.Windows.DataPresenter.GridViewSettingsBase
	{
		// Token: 0x06001E47 RID: 7751 RVA: 0x000864FE File Offset: 0x000846FE
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00086500 File Offset: 0x00084700
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Reset()
		{
			base.Reset();
			this.ResetOrientation();
			this.ResetHeightInInfiniteContainers();
			this.ResetWidthInInfiniteContainers();
			this.ResetUseNestedPanels();
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00086520 File Offset: 0x00084720
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return base.ShouldSerialize() || this.ShouldSerializeHeightInInfiniteContainers() || this.ShouldSerializeOrientation() || this.ShouldSerializeUseNestedPanels() || this.ShouldSerializeWidthInInfiniteContainers();
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0008654A File Offset: 0x0008474A
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0008655C File Offset: 0x0008475C
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

		// Token: 0x06001E4C RID: 7756 RVA: 0x0008656F File Offset: 0x0008476F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeightInInfiniteContainers()
		{
			return !double.IsNaN(this.HeightInInfiniteContainers);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0008657F File Offset: 0x0008477F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeightInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.HeightInInfiniteContainersProperty);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0008658C File Offset: 0x0008478C
		private static bool OnValidateOrientation(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Controls.Orientation), value))
			{
				throw new global::System.ArgumentException();
			}
			return true;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000865A8 File Offset: 0x000847A8
		private static void OnOrientationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)dependencyObject;
			global::System.Windows.Controls.Orientation cachedOrientation = (global::System.Windows.Controls.Orientation)e.NewValue;
			gridViewSettings._cachedOrientation = cachedOrientation;
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x000865D0 File Offset: 0x000847D0
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x000865D8 File Offset: 0x000847D8
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

		// Token: 0x06001E52 RID: 7762 RVA: 0x000865EB File Offset: 0x000847EB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOrientation()
		{
			return this.Orientation != (global::System.Windows.Controls.Orientation)global::Infragistics.Windows.DataPresenter.GridViewSettings.OrientationProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0008660C File Offset: 0x0008480C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOrientation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.OrientationProperty);
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00086619 File Offset: 0x00084819
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x0008662B File Offset: 0x0008482B
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

		// Token: 0x06001E56 RID: 7766 RVA: 0x0008663E File Offset: 0x0008483E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWidthInInfiniteContainers()
		{
			return !double.IsNaN(this.WidthInInfiniteContainers);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0008664E File Offset: 0x0008484E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWidthInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.WidthInInfiniteContainersProperty);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0008665C File Offset: 0x0008485C
		private static void OnUseNestedPanelsChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)dependencyObject;
			bool cachedUseNestedPanels = (bool)e.NewValue;
			gridViewSettings._cachedUseNestedPanels = cachedUseNestedPanels;
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00086684 File Offset: 0x00084884
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0008668C File Offset: 0x0008488C
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x0008669F File Offset: 0x0008489F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseNestedPanels()
		{
			return this.UseNestedPanels != (bool)global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000866C0 File Offset: 0x000848C0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseNestedPanels()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000866D0 File Offset: 0x000848D0
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

		// Token: 0x06001E5E RID: 7774 RVA: 0x0008672E File Offset: 0x0008492E
		private static bool ValidatePositiveDouble(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value > 0.0);
		}

		// Token: 0x04000CCA RID: 3274
		public static readonly global::System.Windows.DependencyProperty HeightInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("HeightInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.ValidatePositiveDouble));

		// Token: 0x04000CCB RID: 3275
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.OnOrientationChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.OnValidateOrientation));

		// Token: 0x04000CCC RID: 3276
		private global::System.Windows.Controls.Orientation _cachedOrientation = global::System.Windows.Controls.Orientation.Vertical;

		// Token: 0x04000CCD RID: 3277
		public static readonly global::System.Windows.DependencyProperty WidthInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("WidthInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.ValidatePositiveDouble));

		// Token: 0x04000CCE RID: 3278
		public static readonly global::System.Windows.DependencyProperty UseNestedPanelsProperty = global::System.Windows.DependencyProperty.Register("UseNestedPanels", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridViewSettings.OnUseNestedPanelsChanged)));

		// Token: 0x04000CCF RID: 3279
		private bool _cachedUseNestedPanels = (bool)global::Infragistics.Windows.DataPresenter.GridViewSettings.UseNestedPanelsProperty.DefaultMetadata.DefaultValue;
	}
}
