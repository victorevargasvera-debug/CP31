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
	// Token: 0x020001D6 RID: 470
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryResultPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x06001C05 RID: 7173 RVA: 0x0007E924 File Offset: 0x0007CB24
		static SummaryResultPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0007E9DE File Offset: 0x0007CBDE
		public SummaryResultPresenter()
		{
			this.EnsureSummaryDataVersionTracker();
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0007E9EC File Offset: 0x0007CBEC
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.SummaryResultPresenterAutomationPeer(this);
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x0007E9F4 File Offset: 0x0007CBF4
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0007EA06 File Offset: 0x0007CC06
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

		// Token: 0x06001C0A RID: 7178 RVA: 0x0007EA1C File Offset: 0x0007CC1C
		private static void OnSummaryResultChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultPresenter summaryResultPresenter = (global::Infragistics.Windows.DataPresenter.SummaryResultPresenter)obj;
			summaryResultPresenter._cachedSummaryResult = (global::Infragistics.Windows.DataPresenter.SummaryResult)e.NewValue;
			summaryResultPresenter.VerifyIsCalculationPending();
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0007EA48 File Offset: 0x0007CC48
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x0007EA50 File Offset: 0x0007CC50
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x06001C0D RID: 7181 RVA: 0x0007EA5E File Offset: 0x0007CC5E
		private void ClearSummaryDataVersionTracker()
		{
			if (this._summaryDataVersionTracker != null)
			{
				this._summaryDataVersionTracker.Deactivate();
				this._summaryDataVersionTracker = null;
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0007EA7C File Offset: 0x0007CC7C
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

		// Token: 0x06001C0F RID: 7183 RVA: 0x0007EACA File Offset: 0x0007CCCA
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

		// Token: 0x06001C10 RID: 7184 RVA: 0x0007EAF4 File Offset: 0x0007CCF4
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

		// Token: 0x06001C11 RID: 7185 RVA: 0x0007EB40 File Offset: 0x0007CD40
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

		// Token: 0x06001C12 RID: 7186 RVA: 0x0007EC30 File Offset: 0x0007CE30
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

		// Token: 0x04000B86 RID: 2950
		internal const int THROTTLE_TIME = 250;

		// Token: 0x04000B87 RID: 2951
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryDataVersionTracker;

		// Token: 0x04000B88 RID: 2952
		private bool _summaryRecalcBypassed_recordDeactivated;

		// Token: 0x04000B89 RID: 2953
		private bool _summaryRecalcBypassed_scrolling;

		// Token: 0x04000B8A RID: 2954
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryRecalcBypassed_scrolling_pvt;

		// Token: 0x04000B8B RID: 2955
		private global::Infragistics.Windows.DataPresenter.SummaryResult _cachedSummaryResult;

		// Token: 0x04000B8C RID: 2956
		private static readonly global::System.Windows.DependencyPropertyKey IsCalculationPendingPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsCalculationPending", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), global::Infragistics.KnownBoxes.FalseBox, null);

		// Token: 0x04000B8D RID: 2957
		public static readonly global::System.Windows.DependencyProperty IsCalculationPendingProperty = global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.IsCalculationPendingPropertyKey.DependencyProperty;

		// Token: 0x04000B8E RID: 2958
		public static readonly global::System.Windows.DependencyProperty SummaryResultProperty = global::System.Windows.DependencyProperty.Register("SummaryResult", typeof(global::Infragistics.Windows.DataPresenter.SummaryResult), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter.OnSummaryResultChanged)));
	}
}
