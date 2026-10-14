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
		// Token: 0x060002F8 RID: 760 RVA: 0x0000C098 File Offset: 0x0000A298
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

		// Token: 0x060002F9 RID: 761 RVA: 0x0000C1A7 File Offset: 0x0000A3A7
		public CardView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.CardView;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000C1C3 File Offset: 0x0000A3C3
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000C1C6 File Offset: 0x0000A3C6
		protected internal override int DefaultAutoArrangeMaxRows
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000C1C9 File Offset: 0x0000A3C9
		protected internal override bool DefaultAutoFit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		protected internal override global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		protected internal override global::Infragistics.Windows.DataPresenter.DataRecordSizingMode DefaultDataRecordSizingMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000C1D3 File Offset: 0x0000A3D3
		protected internal override global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		protected internal override global::Infragistics.Windows.DataPresenter.LabelLocation DefaultLabelLocation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.InCells;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000C1D9 File Offset: 0x0000A3D9
		protected internal override bool DefaultShouldCollapseCards
		{
			get
			{
				return this.ViewSettings.ShouldCollapseCards;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000C1E6 File Offset: 0x0000A3E6
		protected internal override bool DefaultShouldCollapseEmptyCells
		{
			get
			{
				return this.ViewSettings.ShouldCollapseEmptyCells;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000C1F3 File Offset: 0x0000A3F3
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000C1F6 File Offset: 0x0000A3F6
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000C21F File Offset: 0x0000A41F
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000C248 File Offset: 0x0000A448
		protected internal sealed override bool IsCrossLevelSelectionSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000C24B File Offset: 0x0000A44B
		protected internal override bool IsGroupBySupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000C24E File Offset: 0x0000A44E
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return !double.IsNaN(this.ViewSettings.CardWidth);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000C263 File Offset: 0x0000A463
		protected internal override bool IsEmptyCellCollapsingSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000C266 File Offset: 0x0000A466
		protected internal override bool IsFilterRecordSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000C269 File Offset: 0x0000A469
		protected internal override bool IsLogicalFieldHeightResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000C26C File Offset: 0x0000A46C
		protected internal override bool IsLogicalFieldWidthResizingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000C26F File Offset: 0x0000A46F
		protected internal override bool IsNestedPanelsSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000C272 File Offset: 0x0000A472
		protected internal override bool IsPanningModeSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000C275 File Offset: 0x0000A475
		protected internal override bool IsSummaryRecordSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000C278 File Offset: 0x0000A478
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CardViewPanel);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000C284 File Offset: 0x0000A484
		protected internal override global::System.Type RecordPresenterContainerType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.CardViewCard);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000C290 File Offset: 0x0000A490
		protected internal override bool ShouldDisplayRecordSelectors
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000C293 File Offset: 0x0000A493
		protected internal override global::System.Windows.DependencyObject GetContainerForRecordPresenter(global::System.Windows.Controls.Panel panel, global::Infragistics.Windows.DataPresenter.Record record)
		{
			return new global::Infragistics.Windows.DataPresenter.CardViewCard();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000C29A File Offset: 0x0000A49A
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.CardViewFieldLayoutTemplateGenerator(fieldLayout, new global::System.Windows.Controls.Orientation?(this.ViewSettings.Orientation), true);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
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

		// Token: 0x06000317 RID: 791 RVA: 0x0000C350 File Offset: 0x0000A550
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

		// Token: 0x06000318 RID: 792 RVA: 0x0000C520 File Offset: 0x0000A720
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (!(value is global::Infragistics.Windows.DataPresenter.CardViewSettings))
			{
				return new global::Infragistics.Windows.DataPresenter.CardViewSettings();
			}
			return value;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000C531 File Offset: 0x0000A731
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000C54C File Offset: 0x0000A74C
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

		// Token: 0x0600031B RID: 795 RVA: 0x0000C55A File Offset: 0x0000A75A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000C57B File Offset: 0x0000A77B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000C588 File Offset: 0x0000A788
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000C59A File Offset: 0x0000A79A
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

		// Token: 0x0600031F RID: 799 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (global::<PrivateImplementationDetails>{7DBDF509-2AF2-4141-9B69-36E942A1F09D}.$$method0x600030c-1 == null)
				{
					global::<PrivateImplementationDetails>{7DBDF509-2AF2-4141-9B69-36E942A1F09D}.$$method0x600030c-1 = new global::System.Collections.Generic.Dictionary<string, int>(17)
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
				if (global::<PrivateImplementationDetails>{7DBDF509-2AF2-4141-9B69-36E942A1F09D}.$$method0x600030c-1.TryGetValue(propertyName, out num))
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

		// Token: 0x06000320 RID: 800 RVA: 0x0000C80C File Offset: 0x0000AA0C
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

		// Token: 0x040000CB RID: 203
		private const double DEFAULT_ITEM_WIDTH = 200.0;

		// Token: 0x040000CC RID: 204
		private const double DEFAULT_ITEM_HEIGHT = 200.0;

		// Token: 0x040000CD RID: 205
		private global::Infragistics.Windows.DataPresenter.CardViewSettings _viewSettings;

		// Token: 0x040000CE RID: 206
		internal static global::System.Windows.DependencyProperty s_ItemStringFormatProperty;

		// Token: 0x040000CF RID: 207
		internal static global::System.Windows.DependencyProperty s_ContentStringFormatProperty;

		// Token: 0x040000D0 RID: 208
		internal static global::System.Windows.DependencyProperty s_HeaderStringFormatProperty;

		// Token: 0x040000D1 RID: 209
		internal static global::System.Reflection.PropertyInfo s_BindingStringFormatInfo;

		// Token: 0x040000D2 RID: 210
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040000D3 RID: 211
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), typeof(global::Infragistics.Windows.DataPresenter.CardView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardView.OnCoerceViewSettings)));

		// Token: 0x040000D4 RID: 212
		internal static readonly global::System.Windows.DependencyProperty CachedHeaderPathProperty = global::System.Windows.DependencyProperty.Register("CachedHeaderPath", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CardView), new global::System.Windows.FrameworkPropertyMetadata(string.Empty));
	}
}
