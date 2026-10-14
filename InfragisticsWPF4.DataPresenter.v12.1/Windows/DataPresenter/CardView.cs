using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000047 RID: 71
	public class CardView : global::Infragistics.Windows.DataPresenter.ViewBase
	{
		// Token: 0x060002DC RID: 732 RVA: 0x0000B660 File Offset: 0x00009860
		static CardView()
		{
			global::System.ComponentModel.DependencyPropertyDescriptor dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromName("ItemStringFormat", typeof(global::System.Windows.Controls.ItemsControl), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));
			if (dependencyPropertyDescriptor != null)
			{
				global::Infragistics.Windows.DataPresenter.CardView.s_ItemStringFormatProperty = dependencyPropertyDescriptor.DependencyProperty;
				dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromName("ContentStringFormat", typeof(global::System.Windows.Controls.ContentControl), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));
				if (dependencyPropertyDescriptor != null)
				{
					global::Infragistics.Windows.DataPresenter.CardView.s_ContentStringFormatProperty = dependencyPropertyDescriptor.DependencyProperty;
				}
				dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromName("HeaderStringFormat", typeof(global::System.Windows.Controls.HeaderedContentControl), typeof(global::Infragistics.Windows.DataPresenter.CardViewCard));
				if (dependencyPropertyDescriptor != null)
				{
					global::Infragistics.Windows.DataPresenter.CardView.s_HeaderStringFormatProperty = dependencyPropertyDescriptor.DependencyProperty;
				}
				global::Infragistics.Windows.DataPresenter.CardView.s_BindingStringFormatInfo = typeof(global::System.Windows.Data.BindingBase).GetProperty("StringFormat");
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000B76F File Offset: 0x0000996F
		public CardView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000B788 File Offset: 0x00009988
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.CardView;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000B78B File Offset: 0x0000998B
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000B78E File Offset: 0x0000998E
		protected internal override int DefaultAutoArrangeMaxRows
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B791 File Offset: 0x00009991
		protected internal override bool DefaultAutoFit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000B794 File Offset: 0x00009994
		protected internal override global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000B798 File Offset: 0x00009998
		protected internal override global::Infragistics.Windows.DataPresenter.DataRecordSizingMode DefaultDataRecordSizingMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000B79B File Offset: 0x0000999B
		protected internal override global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000B79E File Offset: 0x0000999E
		protected internal override global::Infragistics.Windows.DataPresenter.LabelLocation DefaultLabelLocation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.InCells;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000B7A1 File Offset: 0x000099A1
		protected internal override bool DefaultShouldCollapseCards
		{
			get
			{
				return this.ViewSettings.ShouldCollapseCards;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000B7AE File Offset: 0x000099AE
		protected internal override bool DefaultShouldCollapseEmptyCells
		{
			get
			{
				return this.ViewSettings.ShouldCollapseEmptyCells;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000B7BB File Offset: 0x000099BB
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000B7BE File Offset: 0x000099BE
		public override double InterRecordSpacingX
		{
			get
			{
				if (this._viewSettings != null && this._viewSettings.AllowCardWidthResizing)
				{
					return this._viewSettings.InterCardSpacingX;
				}
				return base.InterRecordSpacingX;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000B7E7 File Offset: 0x000099E7
		public override double InterRecordSpacingY
		{
			get
			{
				if (this._viewSettings != null && this._viewSettings.AllowCardHeightResizing)
				{
					return this._viewSettings.InterCardSpacingY;
				}
				return base.InterRecordSpacingY;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000B810 File Offset: 0x00009A10
		protected internal override bool IsGroupBySupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000B813 File Offset: 0x00009A13
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return !double.IsNaN(this.ViewSettings.CardWidth);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000B828 File Offset: 0x00009A28
		protected internal override bool IsEmptyCellCollapsingSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000B82B File Offset: 0x00009A2B
		protected internal override bool IsFilterRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000B82E File Offset: 0x00009A2E
		protected internal override bool IsLogicalFieldHeightResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000B831 File Offset: 0x00009A31
		protected internal override bool IsLogicalFieldWidthResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000B834 File Offset: 0x00009A34
		protected internal override bool IsNestedPanelsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000B837 File Offset: 0x00009A37
		protected internal override bool IsPanningModeSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000B83A File Offset: 0x00009A3A
		protected internal override bool IsSummaryRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000B83D File Offset: 0x00009A3D
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CardViewPanel);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000B849 File Offset: 0x00009A49
		protected internal override global::System.Type RecordPresenterContainerType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CardViewCard);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000B855 File Offset: 0x00009A55
		protected internal override bool ShouldDisplayRecordSelectors
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000B858 File Offset: 0x00009A58
		protected internal override global::System.Windows.DependencyObject GetContainerForRecordPresenter(global::System.Windows.Controls.Panel panel)
		{
			return new global::Infragistics.Windows.DataPresenter.CardViewCard();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000B85F File Offset: 0x00009A5F
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.CardViewFieldLayoutTemplateGenerator(fieldLayout, new global::System.Windows.Controls.Orientation?(this.ViewSettings.Orientation), true);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000B878 File Offset: 0x00009A78
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged -= this.OnViewSettingsPropertyChanged;
					this.CachedHeaderPath = string.Empty;
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.CardViewSettings);
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged += this.OnViewSettingsPropertyChanged;
					this.CachedHeaderPath = this._viewSettings.HeaderPath;
				}
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000B914 File Offset: 0x00009B14
		protected internal override void PrepareContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::System.Windows.DependencyObject wrapper, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			if (recordPresenter != null)
			{
				this._dataPresenter = recordPresenter.DataPresenter;
			}
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = wrapper as global::Infragistics.Windows.DataPresenter.CardViewCard;
			cardViewCard.Content = recordPresenter;
			cardViewCard.View = this;
			cardViewCard.Panel = ((recordPresenter.DataPresenter != null) ? (recordPresenter.DataPresenter.CurrentPanel as global::Infragistics.Windows.DataPresenter.CardViewPanel) : null);
			cardViewCard.IsCollapsed = recordPresenter.Record.IsContainingCardCollapsedResolved;
			cardViewCard.Initialize(recordPresenter);
			this.SetupHeaderContent(cardViewCard, recordPresenter);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Source = this;
			binding.Path = new global::System.Windows.PropertyPath("ViewSettings.HeaderVisibility", new object[0]);
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			cardViewCard.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewCard.HeaderVisibilityProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Source = recordPresenter.Record;
			binding.Path = new global::System.Windows.PropertyPath("ShouldCollapseEmptyCellsResolved", new object[0]);
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			cardViewCard.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewCard.ShouldCollapseEmptyCellsProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Source = recordPresenter.Record;
			binding.Path = new global::System.Windows.PropertyPath("IsActive", new object[0]);
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			cardViewCard.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewCard.IsActiveProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Source = recordPresenter.Record;
			binding.Path = new global::System.Windows.PropertyPath("IsSelected", new object[0]);
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			cardViewCard.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewCard.IsSelectedProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Source = this;
			binding.Path = new global::System.Windows.PropertyPath("ViewSettings.CollapseCardButtonVisibility", new object[0]);
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			cardViewCard.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewCard.CollapseCardButtonVisibilityProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Source = this;
			binding.Path = new global::System.Windows.PropertyPath("ViewSettings.CollapseEmptyCellsButtonVisibility", new object[0]);
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			cardViewCard.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewCard.CollapseEmptyCellsButtonVisibilityProperty, binding);
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (!(value is global::Infragistics.Windows.DataPresenter.CardViewSettings))
			{
				return new global::Infragistics.Windows.DataPresenter.CardViewSettings();
			}
			return value;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000BAF5 File Offset: 0x00009CF5
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000BB10 File Offset: 0x00009D10
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CardViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null)
				{
					this._viewSettings = new global::Infragistics.Windows.DataPresenter.CardViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty, value);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000BB1E File Offset: 0x00009D1E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000BB3F File Offset: 0x00009D3F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty);
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000BB4C File Offset: 0x00009D4C
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000BB5E File Offset: 0x00009D5E
		internal string CachedHeaderPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CardView.CachedHeaderPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardView.CachedHeaderPathProperty, value);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000BB6C File Offset: 0x00009D6C
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (global::<PrivateImplementationDetails>{71941DAA-8CFD-4121-BD7F-0A50EDB9A71E}.$$method0x60002f3-1 == null)
				{
					global::<PrivateImplementationDetails>{71941DAA-8CFD-4121-BD7F-0A50EDB9A71E}.$$method0x60002f3-1 = new global::System.Collections.Generic.Dictionary<string, int>(17)
					{
						{
							"AllowCardWidthResizing",
							0
						},
						{
							"AllowCardHeightResizing",
							1
						},
						{
							"HeaderPath",
							2
						},
						{
							"AutoFitCards",
							3
						},
						{
							"CollapseCardButtonVisibility",
							4
						},
						{
							"CollapseEmptyCellsButtonVisibility",
							5
						},
						{
							"InterCardSpacingX",
							6
						},
						{
							"InterCardSpacingY",
							7
						},
						{
							"HeaderVisibility",
							8
						},
						{
							"MaxCardCols",
							9
						},
						{
							"MaxCardRows",
							10
						},
						{
							"Orientation",
							11
						},
						{
							"Padding",
							12
						},
						{
							"CardHeight",
							13
						},
						{
							"CardWidth",
							14
						},
						{
							"ShouldCollapseCards",
							15
						},
						{
							"ShouldCollapseEmptyCells",
							16
						}
					};
				}
				int num;
				if (global::<PrivateImplementationDetails>{71941DAA-8CFD-4121-BD7F-0A50EDB9A71E}.$$method0x60002f3-1.TryGetValue(propertyName, out num))
				{
					switch (num)
					{
					case 0:
					case 1:
						base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateRender));
						return;
					case 2:
						this.CachedHeaderPath = this.ViewSettings.HeaderPath;
						return;
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
						base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts));
						return;
					case 13:
					case 14:
						base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
						return;
					case 15:
						base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts));
						if (this._dataPresenter == null)
						{
							return;
						}
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._dataPresenter.ViewableRecords).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
								record.RaisePropertyChangedEventInternal("IsContainingCardCollapsedResolved");
							}
							return;
						}
						break;
					case 16:
						break;
					default:
						return;
					}
					base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts));
					if (this._dataPresenter != null)
					{
						foreach (global::Infragistics.Windows.DataPresenter.Record record2 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._dataPresenter.ViewableRecords))
						{
							record2.RaisePropertyChangedEventInternal("ShouldCollapseEmptyCellsResolved");
						}
					}
				}
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		private void SetupHeaderContent(global::Infragistics.Windows.DataPresenter.CardViewCard card, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			if (global::Infragistics.Windows.DataPresenter.CardView.s_ItemStringFormatProperty != null && global::Infragistics.Windows.DataPresenter.CardView.s_ContentStringFormatProperty != null && global::Infragistics.Windows.DataPresenter.CardView.s_HeaderStringFormatProperty != null)
			{
				string text = base.GetValue(global::Infragistics.Windows.DataPresenter.CardView.s_ItemStringFormatProperty) as string;
				if (text != null)
				{
					card.SetValue(global::Infragistics.Windows.DataPresenter.CardView.s_ContentStringFormatProperty, text);
					card.SetValue(global::Infragistics.Windows.DataPresenter.CardView.s_HeaderStringFormatProperty, text);
				}
			}
			card.ResolveHeader();
		}

		// Token: 0x040000B8 RID: 184
		private const double DEFAULT_ITEM_WIDTH = 200.0;

		// Token: 0x040000B9 RID: 185
		private const double DEFAULT_ITEM_HEIGHT = 200.0;

		// Token: 0x040000BA RID: 186
		private global::Infragistics.Windows.DataPresenter.CardViewSettings _viewSettings;

		// Token: 0x040000BB RID: 187
		internal static global::System.Windows.DependencyProperty s_ItemStringFormatProperty;

		// Token: 0x040000BC RID: 188
		internal static global::System.Windows.DependencyProperty s_ContentStringFormatProperty;

		// Token: 0x040000BD RID: 189
		internal static global::System.Windows.DependencyProperty s_HeaderStringFormatProperty;

		// Token: 0x040000BE RID: 190
		internal static global::System.Reflection.PropertyInfo s_BindingStringFormatInfo;

		// Token: 0x040000BF RID: 191
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040000C0 RID: 192
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), typeof(global::Infragistics.Windows.DataPresenter.CardView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardView.OnCoerceViewSettings)));

		// Token: 0x040000C1 RID: 193
		internal static readonly global::System.Windows.DependencyProperty CachedHeaderPathProperty = global::System.Windows.DependencyProperty.Register("CachedHeaderPath", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CardView), new global::System.Windows.FrameworkPropertyMetadata(string.Empty));
	}
}
