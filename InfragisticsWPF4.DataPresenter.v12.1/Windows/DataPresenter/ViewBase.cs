using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000046 RID: 70
	public abstract class ViewBase : global::System.Windows.FrameworkContentElement
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002AD RID: 685
		protected internal abstract global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation { get; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002AE RID: 686
		protected internal abstract bool HasLogicalOrientation { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002AF RID: 687
		protected internal abstract global::System.Type ItemsPanelType { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000B579 File Offset: 0x00009779
		protected internal virtual bool AutoFitToRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000B57C File Offset: 0x0000977C
		protected internal virtual global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000B57F File Offset: 0x0000977F
		protected internal virtual int DefaultAutoArrangeMaxColumns
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000B582 File Offset: 0x00009782
		protected internal virtual int DefaultAutoArrangeMaxRows
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000B585 File Offset: 0x00009785
		protected internal virtual bool DefaultAutoFit
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000B588 File Offset: 0x00009788
		protected internal virtual global::Infragistics.Windows.DataPresenter.CellClickAction DefaultCellClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellClickAction.Default;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000B58B File Offset: 0x0000978B
		protected internal virtual global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000B58E File Offset: 0x0000978E
		protected internal virtual global::Infragistics.Windows.DataPresenter.DataRecordSizingMode DefaultDataRecordSizingMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000B591 File Offset: 0x00009791
		protected internal virtual global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Default;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000B594 File Offset: 0x00009794
		protected internal virtual global::Infragistics.Windows.DataPresenter.LabelLocation DefaultLabelLocation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.Default;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000B597 File Offset: 0x00009797
		protected internal virtual bool DefaultShouldCollapseCards
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000B59A File Offset: 0x0000979A
		protected internal virtual bool DefaultShouldCollapseEmptyCells
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000B59D File Offset: 0x0000979D
		protected internal virtual global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Auto;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000B5A0 File Offset: 0x000097A0
		public virtual double InterRecordSpacingX
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000B5AB File Offset: 0x000097AB
		public virtual double InterRecordSpacingY
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000B5B6 File Offset: 0x000097B6
		protected internal virtual bool IsAddNewRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000B5B9 File Offset: 0x000097B9
		protected internal virtual bool IsAutoFitHeightSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000B5BC File Offset: 0x000097BC
		protected internal virtual bool IsAutoFitWidthSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000B5BF File Offset: 0x000097BF
		protected internal virtual bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000B5C2 File Offset: 0x000097C2
		protected internal virtual bool IsEmptyCellCollapsingSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000B5C5 File Offset: 0x000097C5
		protected internal virtual bool IsLogicalFieldHeightResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000B5C8 File Offset: 0x000097C8
		protected internal virtual bool IsLogicalFieldWidthResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000B5CB File Offset: 0x000097CB
		protected internal virtual bool IsFilterRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000B5CE File Offset: 0x000097CE
		protected internal virtual bool IsFixedFieldsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000B5D1 File Offset: 0x000097D1
		protected internal virtual bool IsFixedRecordsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000B5D4 File Offset: 0x000097D4
		protected internal virtual bool IsFixingSupportedForNestedRecords
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000B5D7 File Offset: 0x000097D7
		protected internal virtual bool IsGroupBySupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000B5DA File Offset: 0x000097DA
		protected internal virtual bool IsNestedPanelsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000B5DD File Offset: 0x000097DD
		protected internal virtual bool IsPanningModeSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000B5E0 File Offset: 0x000097E0
		protected internal virtual bool IsSummaryRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000B5E3 File Offset: 0x000097E3
		protected internal virtual global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000B5E6 File Offset: 0x000097E6
		protected internal virtual global::System.Type RecordPresenterContainerType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000B5E9 File Offset: 0x000097E9
		protected internal virtual bool ShouldDisplayRecordSelectors
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000B5EC File Offset: 0x000097EC
		protected internal virtual global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Flat;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000B5EF File Offset: 0x000097EF
		protected internal virtual global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Auto;
			}
		}

		// Token: 0x060002D3 RID: 723
		protected internal abstract global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout);

		// Token: 0x060002D4 RID: 724 RVA: 0x0000B5F2 File Offset: 0x000097F2
		protected internal virtual global::System.Windows.DependencyObject GetContainerForRecordPresenter(global::System.Windows.Controls.Panel panel)
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B5F5 File Offset: 0x000097F5
		internal virtual global::Infragistics.Windows.DataPresenter.FixedFieldInfo GetFixedFieldInfo(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			return null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B5F8 File Offset: 0x000097F8
		protected internal virtual void PrepareContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::System.Windows.DependencyObject wrapper, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000B5FA File Offset: 0x000097FA
		protected virtual void OnViewStateChanged(global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000B603 File Offset: 0x00009803
		internal void RaiseViewStateChanged(global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.ViewBase.ViewStateChangedEvent;
			args.Source = this;
			this.OnViewStateChanged(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060002D9 RID: 729 RVA: 0x0000B61E File Offset: 0x0000981E
		// (remove) Token: 0x060002DA RID: 730 RVA: 0x0000B62C File Offset: 0x0000982C
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

		// Token: 0x060002DB RID: 731 RVA: 0x0000B63A File Offset: 0x0000983A
		// Note: this type is marked as 'beforefieldinit'.
		static ViewBase()
		{
			global::Infragistics.Windows.DataPresenter.ViewBase.ViewStateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ViewStateChanged", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.ViewBase));
		}
	}
}
