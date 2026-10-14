using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F7 RID: 759
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x0009A510 File Offset: 0x00098710
		static HeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0009A5C6 File Offset: 0x000987C6
		public HeaderPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.HeaderPresenter.StyleSelectorHelper(this);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0009A5DA File Offset: 0x000987DA
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderPresenterAutomationPeer(this);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x0009A5E4 File Offset: 0x000987E4
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.Controls.ContentControl.ContentProperty)
			{
				this._fieldLayout = (base.Content as global::Infragistics.Windows.DataPresenter.FieldLayout);
				this._styleSelectorHelper.InvalidateStyle();
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.HeaderPresenter.InternalVersionProperty)
			{
				int internalVersion = this.InternalVersion;
				if (this._cachedVersion != internalVersion)
				{
					this._cachedVersion = internalVersion;
					if (this._versionInitialized)
					{
						this._styleSelectorHelper.InvalidateStyle();
					}
				}
				this._versionInitialized = true;
			}
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x0009A662 File Offset: 0x00098862
		public static global::Infragistics.Windows.DataPresenter.RecordManager GetRecordManager(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.RecordManager)d.GetValue(global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerProperty);
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0009A674 File Offset: 0x00098874
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0009A686 File Offset: 0x00098886
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.HeaderPresenter.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.HeaderPresenter.InternalVersionProperty, value);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0009A699 File Offset: 0x00098899
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0009A6A4 File Offset: 0x000988A4
		internal global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
		{
			get
			{
				return this._rp;
			}
			set
			{
				if (value != this._rp)
				{
					this._tracker = null;
					this._rp = value;
					if (this._rp != null)
					{
						this._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._rp, global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnRecordManagerChanged));
					}
					this.OnRecordManagerChanged();
				}
			}
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0009A6F8 File Offset: 0x000988F8
		private void OnRecordManagerChanged()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (this._rp != null) ? this._rp.RecordManagerForHeader : null;
			if (recordManager != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerPropertyKey, recordManager);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerPropertyKey);
		}

		// Token: 0x04001133 RID: 4403
		private int _cachedVersion;

		// Token: 0x04001134 RID: 4404
		private bool _versionInitialized;

		// Token: 0x04001135 RID: 4405
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04001136 RID: 4406
		private global::Infragistics.Windows.DataPresenter.HeaderPresenter.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04001137 RID: 4407
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x04001138 RID: 4408
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _rp;

		// Token: 0x04001139 RID: 4409
		internal static readonly global::System.Windows.DependencyPropertyKey RecordManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("RecordManager", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x0400113A RID: 4410
		public static readonly global::System.Windows.DependencyProperty RecordManagerProperty = global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerPropertyKey.DependencyProperty;

		// Token: 0x0400113B RID: 4411
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x020002F8 RID: 760
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06002370 RID: 9072 RVA: 0x0009A737 File Offset: 0x00098937
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.HeaderPresenter hp) : base(hp)
			{
				this._hp = hp;
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06002371 RID: 9073 RVA: 0x0009A748 File Offset: 0x00098948
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._hp == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._hp._fieldLayout;
					if (fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
						if (dataPresenter != null)
						{
							return dataPresenter.InternalHeaderPresenterStyleSelector.SelectStyle(fieldLayout, this._hp);
						}
					}
					return null;
				}
			}

			// Token: 0x0400113C RID: 4412
			private global::Infragistics.Windows.DataPresenter.HeaderPresenter _hp;
		}
	}
}
