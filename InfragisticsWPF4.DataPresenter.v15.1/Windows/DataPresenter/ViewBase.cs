using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000046 RID: 70
	public abstract class ViewBase : global::System.Windows.FrameworkContentElement
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002C4 RID: 708
		protected internal abstract global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002C5 RID: 709
		protected internal abstract bool HasLogicalOrientation { get; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002C6 RID: 710
		protected internal abstract global::System.Type ItemsPanelType { get; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000BF8D File Offset: 0x0000A18D
		protected internal virtual bool AutoFitToRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000BF90 File Offset: 0x0000A190
		protected internal virtual global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000BF93 File Offset: 0x0000A193
		protected internal virtual int DefaultAutoArrangeMaxColumns
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000BF96 File Offset: 0x0000A196
		protected internal virtual int DefaultAutoArrangeMaxRows
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000BF99 File Offset: 0x0000A199
		protected internal virtual bool DefaultAutoFit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000BF9C File Offset: 0x0000A19C
		protected internal virtual global::Infragistics.Windows.DataPresenter.CellClickAction DefaultCellClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellClickAction.Default;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000BF9F File Offset: 0x0000A19F
		protected internal virtual global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000BFA2 File Offset: 0x0000A1A2
		protected internal virtual global::Infragistics.Windows.DataPresenter.DataRecordSizingMode DefaultDataRecordSizingMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000BFA5 File Offset: 0x0000A1A5
		protected internal virtual global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Default;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		protected internal virtual global::Infragistics.Windows.DataPresenter.LabelLocation DefaultLabelLocation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.Default;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000BFAB File Offset: 0x0000A1AB
		protected internal virtual bool DefaultShouldCollapseCards
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000BFAE File Offset: 0x0000A1AE
		protected internal virtual bool DefaultShouldCollapseEmptyCells
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000BFB1 File Offset: 0x0000A1B1
		protected internal virtual global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Auto;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		public virtual double InterRecordSpacingX
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000BFBF File Offset: 0x0000A1BF
		public virtual double InterRecordSpacingY
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000BFCA File Offset: 0x0000A1CA
		protected internal virtual bool IsAddNewRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000BFCD File Offset: 0x0000A1CD
		protected internal virtual bool IsAutoFitHeightSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		protected internal virtual bool IsAutoFitWidthSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000BFD3 File Offset: 0x0000A1D3
		protected internal virtual bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
		protected internal virtual bool IsCrossLevelSelectionSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000BFD9 File Offset: 0x0000A1D9
		protected internal virtual bool IsEmptyCellCollapsingSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		protected internal virtual bool IsLogicalFieldHeightResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000BFDF File Offset: 0x0000A1DF
		protected internal virtual bool IsLogicalFieldWidthResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000BFE2 File Offset: 0x0000A1E2
		protected internal virtual bool IsFilterRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000BFE5 File Offset: 0x0000A1E5
		protected internal virtual bool IsFixedFieldsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		protected internal virtual bool IsFixedRecordsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000BFEB File Offset: 0x0000A1EB
		protected internal virtual bool IsFixingSupportedForNestedRecords
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000BFEE File Offset: 0x0000A1EE
		protected internal virtual bool IsGroupBySupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000BFF1 File Offset: 0x0000A1F1
		protected internal virtual bool IsNestedPanelsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		protected internal virtual bool IsPanningModeSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000BFF7 File Offset: 0x0000A1F7
		protected internal virtual bool IsSummaryRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000BFFA File Offset: 0x0000A1FA
		internal virtual bool IsTreeView
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000BFFD File Offset: 0x0000A1FD
		internal virtual double LevelIndentationResolved
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000C008 File Offset: 0x0000A208
		protected internal virtual global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000C00B File Offset: 0x0000A20B
		protected internal virtual global::System.Type RecordPresenterContainerType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000C00E File Offset: 0x0000A20E
		protected internal virtual bool ShouldDisplayRecordSelectors
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000C011 File Offset: 0x0000A211
		protected internal virtual global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Flat;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000C014 File Offset: 0x0000A214
		protected internal virtual global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Auto;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000C017 File Offset: 0x0000A217
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000C01F File Offset: 0x0000A21F
		internal bool IsForExport { get; set; }

		// Token: 0x060002EF RID: 751
		protected internal abstract global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout);

		// Token: 0x060002F0 RID: 752 RVA: 0x0000C028 File Offset: 0x0000A228
		protected internal virtual global::System.Windows.DependencyObject GetContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::Infragistics.Windows.DataPresenter.Record record)
		{
			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000C02B File Offset: 0x0000A22B
		internal virtual global::Infragistics.Windows.DataPresenter.FixedFieldInfo GetFixedFieldInfo(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000C02E File Offset: 0x0000A22E
		protected internal virtual void PrepareContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::System.Windows.DependencyObject wrapper, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000C030 File Offset: 0x0000A230
		protected virtual void OnViewStateChanged(global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000C039 File Offset: 0x0000A239
		internal void RaiseViewStateChanged(global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.ViewBase.ViewStateChangedEvent;
			args.Source = this;
			this.OnViewStateChanged(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060002F5 RID: 757 RVA: 0x0000C054 File Offset: 0x0000A254
		// (remove) Token: 0x060002F6 RID: 758 RVA: 0x0000C062 File Offset: 0x0000A262
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs> ViewStateChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.ViewBase.ViewStateChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.ViewBase.ViewStateChangedEvent, value);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000C070 File Offset: 0x0000A270
		// Note: this type is marked as 'beforefieldinit'.
		static ViewBase()
		{
			global::Infragistics.Windows.DataPresenter.ViewBase.ViewStateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ViewStateChanged", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.ViewBase));
		}
	}
}
