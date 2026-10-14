using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000193 RID: 403
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordSelectorNumber : global::System.Windows.Controls.Control
	{
		// Token: 0x06001970 RID: 6512 RVA: 0x000755CC File Offset: 0x000737CC
		static RecordSelectorNumber()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.OnDataContextChanged)));
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x000756E4 File Offset: 0x000738E4
		public RecordSelectorNumber()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.StyleSelectorHelper(this);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00075710 File Offset: 0x00073910
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (this._cachedFieldLayout == null || this._cachedFieldLayout.RecordSelectorNumberTypeResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None)
			{
				return base.MeasureOverride(constraint);
			}
			global::System.Windows.Size constraint2 = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			if (this._forceMeasure)
			{
				if (double.IsInfinity(this._lastMeasureWidth))
				{
					constraint2.Width = 2147483647.0;
				}
				else
				{
					constraint2.Width = this._lastMeasureWidth - 1.0;
				}
				this._forceMeasure = false;
			}
			this._lastMeasureWidth = constraint2.Width;
			global::System.Windows.Size size = base.MeasureOverride(constraint2);
			if (this._cachedFieldLayout != null)
			{
				global::System.Windows.Thickness margin = base.Margin;
				global::System.Windows.Size desiredSize = size;
				desiredSize.Width += margin.Left + margin.Right;
				desiredSize.Height += margin.Top + margin.Bottom;
				this._cachedFieldLayout.TemplateDataRecordCache.OnRecordSelectorNumberMeasure(this._record, desiredSize);
			}
			return size;
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00075814 File Offset: 0x00073A14
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelectorNumber recordSelectorNumber = target as global::Infragistics.Windows.DataPresenter.RecordSelectorNumber;
			if (recordSelectorNumber != null)
			{
				recordSelectorNumber._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0007583D File Offset: 0x00073A3D
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x00075845 File Offset: 0x00073A45
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.FieldLayoutProperty, value);
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00075853 File Offset: 0x00073A53
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0007585B File Offset: 0x00073A5B
		public string RecordNumber
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.RecordNumberProperty);
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00075870 File Offset: 0x00073A70
		private void InitializeVersionInfo()
		{
			if (this._cachedFieldLayout != null && this._cachedFieldLayout.DataPresenter != null && this._cachedFieldLayout.StyleGenerator != null && this._cachedFieldLayout.RecordSelectorNumberTypeResolved != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None)
			{
				global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), true) as global::Infragistics.Windows.DataPresenter.RecordSelector;
				if (recordSelector != null)
				{
					int internalVersion = recordSelector.InternalVersion;
					if (this._cachedVersion != internalVersion)
					{
						this._cachedVersion = internalVersion;
						this._styleSelectorHelper.InvalidateStyle();
					}
				}
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000758EC File Offset: 0x00073AEC
		private static void OnDataContextChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelectorNumber recordSelectorNumber = target as global::Infragistics.Windows.DataPresenter.RecordSelectorNumber;
			recordSelectorNumber._record = (e.NewValue as global::Infragistics.Windows.DataPresenter.DataRecord);
			recordSelectorNumber._tracker = null;
			if (recordSelectorNumber._record != null)
			{
				recordSelectorNumber.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.RecordPropertyKey, recordSelectorNumber._record);
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = recordSelectorNumber._record.FieldLayout;
				recordSelectorNumber._forceMeasure = (e.OldValue != null);
				recordSelectorNumber.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.FieldLayoutProperty, fieldLayout);
				if (fieldLayout != null && fieldLayout.RecordSelectorNumberTypeResolved != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None)
				{
					recordSelectorNumber._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(recordSelectorNumber._record.DataPresenter, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordNumberVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(recordSelectorNumber.OnNumberVersionChanged));
				}
				recordSelectorNumber.RefreshRecordNumber();
				recordSelectorNumber.InitializeVersionInfo();
				return;
			}
			recordSelectorNumber.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.FieldLayoutProperty, null);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000759A9 File Offset: 0x00073BA9
		private void OnNumberVersionChanged()
		{
			this.RefreshRecordNumber();
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000759B4 File Offset: 0x00073BB4
		private void RefreshRecordNumber()
		{
			string value = null;
			if (this._record != null)
			{
				value = this._record.RecordSelectorNumber;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.RecordNumberPropertyKey, value);
		}

		// Token: 0x04000A69 RID: 2665
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000A6A RID: 2666
		private global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04000A6B RID: 2667
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x04000A6C RID: 2668
		private int _cachedVersion = -1;

		// Token: 0x04000A6D RID: 2669
		private double _lastMeasureWidth = double.PositiveInfinity;

		// Token: 0x04000A6E RID: 2670
		private bool _forceMeasure;

		// Token: 0x04000A6F RID: 2671
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.OnFieldLayoutChanged)));

		// Token: 0x04000A70 RID: 2672
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04000A71 RID: 2673
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A72 RID: 2674
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.RecordPropertyKey.DependencyProperty;

		// Token: 0x04000A73 RID: 2675
		private static readonly global::System.Windows.DependencyPropertyKey RecordNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordNumber", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x04000A74 RID: 2676
		public static readonly global::System.Windows.DependencyProperty RecordNumberProperty = global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.RecordNumberPropertyKey.DependencyProperty;

		// Token: 0x02000194 RID: 404
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x0600197C RID: 6524 RVA: 0x000759E3 File Offset: 0x00073BE3
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber rs) : base(rs)
			{
				this._rsn = rs;
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x0600197D RID: 6525 RVA: 0x000759F4 File Offset: 0x00073BF4
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._rsn == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._rsn.FieldLayout;
					if (fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
						if (dataPresenter != null)
						{
							return dataPresenter.InternalRecordSelectorNumberStyleSelector.SelectStyle(this._rsn.DataContext, this._rsn);
						}
					}
					return null;
				}
			}

			// Token: 0x04000A75 RID: 2677
			private global::Infragistics.Windows.DataPresenter.RecordSelectorNumber _rsn;
		}
	}
}
