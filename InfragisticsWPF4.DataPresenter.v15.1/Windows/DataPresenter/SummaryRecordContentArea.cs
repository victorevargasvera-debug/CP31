using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CC RID: 460
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordContentArea : global::System.Windows.Controls.Control
	{
		// Token: 0x06001B21 RID: 6945 RVA: 0x0007A16C File Offset: 0x0007836C
		static SummaryRecordContentArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0007A316 File Offset: 0x00078516
		public SummaryRecordContentArea()
		{
			this._summaryDefinitionsTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "SummaryRecord.FieldLayout.SummaryDefinitions.SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSummariesChanged), true);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0007A33C File Offset: 0x0007853C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.FrameworkElement.DataContextProperty == property)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordPropertyKey, e.NewValue as global::Infragistics.Windows.DataPresenter.SummaryRecord);
				this.OnSummariesChanged();
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0007A37D File Offset: 0x0007857D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryRecord SummaryRecord
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryRecord)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordProperty);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0007A38F File Offset: 0x0007858F
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x0007A3A1 File Offset: 0x000785A1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasSummariesInCellArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty, value);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0007A3B4 File Offset: 0x000785B4
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0007A3C6 File Offset: 0x000785C6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Visibility SummaryRecordHeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0007A3D9 File Offset: 0x000785D9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResultsCenter
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterProperty);
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0007A3EB File Offset: 0x000785EB
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResultsLeft
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftProperty);
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0007A3FD File Offset: 0x000785FD
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResultsRight
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightProperty);
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0007A410 File Offset: 0x00078610
		private void OnSummariesChanged()
		{
			global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = this.SummaryRecord;
			if (summaryRecord != null)
			{
				summaryRecord.VerifySummaryResults();
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftPropertyKey, summaryRecord.GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition.Left));
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterPropertyKey, summaryRecord.GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition.Center));
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightPropertyKey, summaryRecord.GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition.Right));
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty, summaryRecord.SummaryRecordHeaderVisibilityResolved);
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty, summaryRecord.HasFixedSummaryResults());
				summaryRecord.ClearSizeToContentManager();
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty);
			}
			object target = this._summaryDefinitionsTracker.Target;
			int num = (target is int) ? ((int)target) : -1;
			if (this._lastSummaryDefinitionCollection_Version != num)
			{
				this._lastSummaryDefinitionCollection_Version = num;
				global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel virtualizingSummaryCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel)global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel), true);
				if (virtualizingSummaryCellPanel != null)
				{
					virtualizingSummaryCellPanel.InvalidateMeasure();
				}
			}
		}

		// Token: 0x04000AE4 RID: 2788
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryDefinitionsTracker;

		// Token: 0x04000AE5 RID: 2789
		private int _lastSummaryDefinitionCollection_Version;

		// Token: 0x04000AE6 RID: 2790
		private static readonly global::System.Windows.DependencyPropertyKey SummaryRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryRecord", typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AE7 RID: 2791
		public static readonly global::System.Windows.DependencyProperty SummaryRecordProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordPropertyKey.DependencyProperty;

		// Token: 0x04000AE8 RID: 2792
		public static readonly global::System.Windows.DependencyProperty HasSummariesInCellAreaProperty = global::System.Windows.DependencyProperty.Register("HasSummariesInCellArea", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000AE9 RID: 2793
		public static readonly global::System.Windows.DependencyProperty SummaryRecordHeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("SummaryRecordHeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000AEA RID: 2794
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsCenterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResultsCenter", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AEB RID: 2795
		public static readonly global::System.Windows.DependencyProperty SummaryResultsCenterProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterPropertyKey.DependencyProperty;

		// Token: 0x04000AEC RID: 2796
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsLeftPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResultsLeft", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AED RID: 2797
		public static readonly global::System.Windows.DependencyProperty SummaryResultsLeftProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftPropertyKey.DependencyProperty;

		// Token: 0x04000AEE RID: 2798
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsRightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResultsRight", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AEF RID: 2799
		public static readonly global::System.Windows.DependencyProperty SummaryResultsRightProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightPropertyKey.DependencyProperty;
	}
}
