using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B3 RID: 435
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryResultPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x0006BB5C File Offset: 0x00069D5C
		static SummaryResultPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0006BC16 File Offset: 0x00069E16
		public SummaryResultPresenter()
		{
			this.EnsureSummaryDataVersionTracker();
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0006BC24 File Offset: 0x00069E24
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.SummaryResultPresenterAutomationPeer(this);
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0006BC2C File Offset: 0x00069E2C
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0006BC3E File Offset: 0x00069E3E
		public bool IsCalculationPending
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.IsCalculationPendingProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.IsCalculationPendingPropertyKey, value);
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0006BC54 File Offset: 0x00069E54
		private static void OnSummaryResultChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultPresenter summaryResultPresenter = (global::Infragistics.Windows.DataPresenter.SummaryResultPresenter)obj;
			summaryResultPresenter._cachedSummaryResult = (global::Infragistics.Windows.DataPresenter.SummaryResult)e.NewValue;
			summaryResultPresenter.VerifyIsCalculationPending();
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0006BC80 File Offset: 0x00069E80
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0006BC88 File Offset: 0x00069E88
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryResult SummaryResult
		{
			get
			{
				return this._cachedSummaryResult;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.SummaryResultProperty, value);
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0006BC96 File Offset: 0x00069E96
		private void ClearSummaryDataVersionTracker()
		{
			if (this._summaryDataVersionTracker != null)
			{
				this._summaryDataVersionTracker.Deactivate();
				this._summaryDataVersionTracker = null;
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0006BCB4 File Offset: 0x00069EB4
		private void EnsureSummaryDataVersionTracker()
		{
			if (this._summaryDataVersionTracker == null)
			{
				this._summaryDataVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "SummaryResult.DataVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.RecalculateSummary), true)
				{
					ThrottleTime = 250,
					ThrottleFirstInvoke = true,
					AsynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Input
				};
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0006BD02 File Offset: 0x00069F02
		private void OnIsScrollingChanged()
		{
			if (this._summaryRecalcBypassed_scrolling)
			{
				this._summaryRecalcBypassed_scrolling = false;
				this._summaryRecalcBypassed_scrolling_pvt.Deactivate();
				this._summaryRecalcBypassed_scrolling_pvt = null;
				this.RecalculateSummary();
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0006BD2C File Offset: 0x00069F2C
		private void OnIsVisibleChangedHandler(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultPresenter summaryResultPresenter = (global::Infragistics.Windows.DataPresenter.SummaryResultPresenter)sender;
			if (summaryResultPresenter._summaryRecalcBypassed_recordDeactivated && (bool)e.NewValue)
			{
				summaryResultPresenter._summaryRecalcBypassed_recordDeactivated = false;
				summaryResultPresenter.IsVisibleChanged -= this.OnIsVisibleChangedHandler;
				summaryResultPresenter.RecalculateSummary();
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0006BD78 File Offset: 0x00069F78
		private void RecalculateSummary()
		{
			if (this._summaryRecalcBypassed_recordDeactivated || this._summaryRecalcBypassed_scrolling)
			{
				return;
			}
			if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetIsAutoSizeElement(this))
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = this.SummaryResult;
			if (summaryResult != null)
			{
				if (summaryResult.IsDirty(false))
				{
					global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = base.DataContext as global::Infragistics.Windows.DataPresenter.SummaryRecord;
					global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter summaryRecordPresenter = (summaryRecord != null) ? (summaryRecord.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter) : null;
					if (summaryRecordPresenter != null && summaryRecordPresenter.IsDeactivated)
					{
						this._summaryRecalcBypassed_recordDeactivated = true;
						base.IsVisibleChanged += this.OnIsVisibleChangedHandler;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = global::Infragistics.Windows.DataPresenter.GridUtilities.GetDataPresenter(summaryResult.FieldLayout);
					if (dataPresenter != null && dataPresenter.IsScrolling)
					{
						this._summaryRecalcBypassed_scrolling = true;
						this._summaryRecalcBypassed_scrolling_pvt = new global::Infragistics.Windows.Internal.PropertyValueTracker(dataPresenter, global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnIsScrollingChanged));
					}
					if (this._summaryRecalcBypassed_recordDeactivated || this._summaryRecalcBypassed_scrolling)
					{
						this.ClearSummaryDataVersionTracker();
						this.IsCalculationPending = true;
						return;
					}
				}
				summaryResult.EnsureCalculated();
				this.IsCalculationPending = false;
			}
			this.EnsureSummaryDataVersionTracker();
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0006BE68 File Offset: 0x0006A068
		private void VerifyIsCalculationPending()
		{
			global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult = this.SummaryResult;
			if (summaryResult != null && summaryResult.IsDirty(false))
			{
				this.IsCalculationPending = true;
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.IsCalculationPendingPropertyKey);
		}

		// Token: 0x040009B8 RID: 2488
		internal const int THROTTLE_TIME = 250;

		// Token: 0x040009B9 RID: 2489
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryDataVersionTracker;

		// Token: 0x040009BA RID: 2490
		private bool _summaryRecalcBypassed_recordDeactivated;

		// Token: 0x040009BB RID: 2491
		private bool _summaryRecalcBypassed_scrolling;

		// Token: 0x040009BC RID: 2492
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryRecalcBypassed_scrolling_pvt;

		// Token: 0x040009BD RID: 2493
		private global::Infragistics.Windows.DataPresenter.SummaryResult _cachedSummaryResult;

		// Token: 0x040009BE RID: 2494
		private static readonly global::System.Windows.DependencyPropertyKey IsCalculationPendingPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsCalculationPending", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), global::Infragistics.KnownBoxes.FalseBox, null);

		// Token: 0x040009BF RID: 2495
		public static readonly global::System.Windows.DependencyProperty IsCalculationPendingProperty = global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.IsCalculationPendingPropertyKey.DependencyProperty;

		// Token: 0x040009C0 RID: 2496
		public static readonly global::System.Windows.DependencyProperty SummaryResultProperty = global::System.Windows.DependencyProperty.Register("SummaryResult", typeof(global::Infragistics.Windows.DataPresenter.SummaryResult), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.OnSummaryResultChanged)));
	}
}
