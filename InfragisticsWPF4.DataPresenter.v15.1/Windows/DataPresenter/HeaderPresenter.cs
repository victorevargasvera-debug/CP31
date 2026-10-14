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
	// Token: 0x02000337 RID: 823
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06002707 RID: 9991 RVA: 0x000ADDD0 File Offset: 0x000ABFD0
		static HeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000ADE86 File Offset: 0x000AC086
		public HeaderPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.HeaderPresenter.StyleSelectorHelper(this);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000ADE9A File Offset: 0x000AC09A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderPresenterAutomationPeer(this);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000ADEA4 File Offset: 0x000AC0A4
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

		// Token: 0x0600270B RID: 9995 RVA: 0x000ADF22 File Offset: 0x000AC122
		public static global::Infragistics.Windows.DataPresenter.RecordManager GetRecordManager(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.RecordManager)d.GetValue(global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerProperty);
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000ADF34 File Offset: 0x000AC134
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x000ADF46 File Offset: 0x000AC146
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

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x000ADF59 File Offset: 0x000AC159
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x000ADF64 File Offset: 0x000AC164
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

		// Token: 0x06002710 RID: 10000 RVA: 0x000ADFB8 File Offset: 0x000AC1B8
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

		// Token: 0x0400134D RID: 4941
		private int _cachedVersion;

		// Token: 0x0400134E RID: 4942
		private bool _versionInitialized;

		// Token: 0x0400134F RID: 4943
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04001350 RID: 4944
		private global::Infragistics.Windows.DataPresenter.HeaderPresenter.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04001351 RID: 4945
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x04001352 RID: 4946
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _rp;

		// Token: 0x04001353 RID: 4947
		internal static readonly global::System.Windows.DependencyPropertyKey RecordManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("RecordManager", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04001354 RID: 4948
		public static readonly global::System.Windows.DependencyProperty RecordManagerProperty = global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerPropertyKey.DependencyProperty;

		// Token: 0x04001355 RID: 4949
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x02000338 RID: 824
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06002711 RID: 10001 RVA: 0x000ADFF7 File Offset: 0x000AC1F7
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.HeaderPresenter hp) : base(hp)
			{
				this._hp = hp;
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06002712 RID: 10002 RVA: 0x000AE008 File Offset: 0x000AC208
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

			// Token: 0x04001356 RID: 4950
			private global::Infragistics.Windows.DataPresenter.HeaderPresenter _hp;
		}
	}
}
