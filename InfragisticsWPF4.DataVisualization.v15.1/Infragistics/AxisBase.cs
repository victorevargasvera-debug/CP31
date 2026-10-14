using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x02000009 RID: 9
	public abstract class AxisBase : global::System.Windows.Controls.Control, global::System.IDisposable
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003416 File Offset: 0x00001616
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00003428 File Offset: 0x00001628
		public bool AutoRange
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.AxisBase.AutoRangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.AxisBase.AutoRangeProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000343B File Offset: 0x0000163B
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000344D File Offset: 0x0000164D
		public double ScrollScale
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.AxisBase.ScrollScaleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.AxisBase.ScrollScaleProperty, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003460 File Offset: 0x00001660
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003472 File Offset: 0x00001672
		public double ScrollPosition
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.AxisBase.ScrollPositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.AxisBase.ScrollPositionProperty, value);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003488 File Offset: 0x00001688
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.AxisBase axisBase = d as global::Infragistics.AxisBase;
			if (d != null)
			{
				axisBase.OnPropertyChanged(e);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000034A6 File Offset: 0x000016A6
		protected new virtual void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000034A8 File Offset: 0x000016A8
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000034B0 File Offset: 0x000016B0
		protected bool Disposed
		{
			get
			{
				return this._disposed;
			}
			set
			{
				this._disposed = value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000034BC File Offset: 0x000016BC
		~AxisBase()
		{
			this.Dispose(false);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000034EC File Offset: 0x000016EC
		protected virtual void Dispose(bool disposing)
		{
			this.Disposed = true;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000034F5 File Offset: 0x000016F5
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000018 RID: 24
		public static readonly global::System.Windows.DependencyProperty AutoRangeProperty = global::System.Windows.DependencyProperty.Register("AutoRange", typeof(bool), typeof(global::Infragistics.AxisBase), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.AxisBase.OnPropertyChanged)));

		// Token: 0x04000019 RID: 25
		public static readonly global::System.Windows.DependencyProperty ScrollScaleProperty = global::System.Windows.DependencyProperty.Register("ScrollScale", typeof(double), typeof(global::Infragistics.AxisBase), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.AxisBase.OnPropertyChanged)));

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty ScrollPositionProperty = global::System.Windows.DependencyProperty.Register("ScrollPosition", typeof(double), typeof(global::Infragistics.AxisBase), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.AxisBase.OnPropertyChanged)));

		// Token: 0x0400001B RID: 27
		private bool _disposed;
	}
}
