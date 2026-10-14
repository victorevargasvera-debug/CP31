using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001AB RID: 427
	public abstract class RecordPrefixArea : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06001773 RID: 6003 RVA: 0x00067993 File Offset: 0x00065B93
		public RecordPrefixArea()
		{
			this._styleSelectorHelper = this.CreateStyleSelectorHelper();
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000679A8 File Offset: 0x00065BA8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				global::Infragistics.Windows.DataPresenter.Record record = e.NewValue as global::Infragistics.Windows.DataPresenter.Record;
				if (record != this._record)
				{
					if (this._record != null)
					{
						this._record = null;
					}
					else
					{
						this._record = record;
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.RecordPropertyKey, this._record);
					return;
				}
			}
			else if (e.Property == global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty)
			{
				this.InitializeVersionInfo();
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00067A20 File Offset: 0x00065C20
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPrefixArea recordPrefixArea = target as global::Infragistics.Windows.DataPresenter.RecordPrefixArea;
			if (recordPrefixArea != null)
			{
				recordPrefixArea._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				recordPrefixArea.InitializeVersionInfo();
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x00067A4F File Offset: 0x00065C4F
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x00067A57 File Offset: 0x00065C57
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.FieldLayoutProperty, value);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00067A65 File Offset: 0x00065C65
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OrientationProperty);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00067A77 File Offset: 0x00065C77
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00067A7F File Offset: 0x00065C7F
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00067A91 File Offset: 0x00065C91
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty, value);
			}
		}

		// Token: 0x0600177C RID: 6012
		internal abstract global::Infragistics.Windows.Helpers.StyleSelectorHelperBase CreateStyleSelectorHelper();

		// Token: 0x0600177D RID: 6013 RVA: 0x00067AA4 File Offset: 0x00065CA4
		private void InitializeVersionInfo()
		{
			if (this._cachedFieldLayout != null && this._cachedFieldLayout.DataPresenter != null && this._cachedFieldLayout.StyleGenerator != null)
			{
				int internalVersion = this.InternalVersion;
				if (this._cachedVersion != internalVersion)
				{
					this._cachedVersion = internalVersion;
					if (this._versionInitialized)
					{
						this._styleSelectorHelper.InvalidateStyle();
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.FieldLayout.StyleGenerator.LogicalOrientation));
				}
				this._versionInitialized = true;
			}
		}

		// Token: 0x04000927 RID: 2343
		private int _cachedVersion;

		// Token: 0x04000928 RID: 2344
		private bool _versionInitialized;

		// Token: 0x04000929 RID: 2345
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x0400092A RID: 2346
		private global::Infragistics.Windows.Helpers.StyleSelectorHelperBase _styleSelectorHelper;

		// Token: 0x0400092B RID: 2347
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OnFieldLayoutChanged)));

		// Token: 0x0400092C RID: 2348
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x0400092D RID: 2349
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));

		// Token: 0x0400092E RID: 2350
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OrientationPropertyKey.DependencyProperty;

		// Token: 0x0400092F RID: 2351
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000930 RID: 2352
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.RecordPropertyKey.DependencyProperty;

		// Token: 0x04000931 RID: 2353
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(0));
	}
}
