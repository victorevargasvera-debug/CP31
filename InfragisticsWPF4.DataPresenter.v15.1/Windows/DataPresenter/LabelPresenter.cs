using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000339 RID: 825
	[global::System.Windows.TemplateVisualState(Name = "Unsorted", GroupName = "SortStates")]
	[global::System.Windows.TemplateVisualState(Name = "NotDragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "SortDescending", GroupName = "SortStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Dragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "DragSource", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "CellArea", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "HeaderArea", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "FieldChooser", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "GroupByArea", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "SortAscending", GroupName = "SortStates")]
	public class LabelPresenter : global::Infragistics.Windows.DataPresenter.DataItemPresenter, global::Infragistics.Windows.Selection.ISelectableElement
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x000AE04C File Offset: 0x000AC24C
		static LabelPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.Instance));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Stretch, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.CoerceHorizontalContentAlignment)));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.CoerceVerticalContentAlignment)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000AE3D7 File Offset: 0x000AC5D7
		public override bool IsEditingAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000AE3DC File Offset: 0x000AC5DC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result;
			if (!double.IsPositiveInfinity(availableSize.Height))
			{
				result = base.MeasureOverride(new global::System.Windows.Size(availableSize.Width, double.PositiveInfinity));
				if (availableSize.Height < result.Height)
				{
					result = base.MeasureOverride(availableSize);
				}
			}
			else
			{
				result = base.MeasureOverride(availableSize);
			}
			return result;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000AE436 File Offset: 0x000AC636
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPresenterAutomationPeer(this);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000AE43E File Offset: 0x000AC63E
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000AE447 File Offset: 0x000AC647
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000AE449 File Offset: 0x000AC649
		protected override void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000AE44B File Offset: 0x000AC64B
		protected override void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000AE44D File Offset: 0x000AC64D
		protected internal override bool CommitEditValue(object editedValue, out bool stayInEditMode)
		{
			stayInEditMode = false;
			return false;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000AE453 File Offset: 0x000AC653
		protected override void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e)
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000AE458 File Offset: 0x000AC658
		protected override void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnFieldPropertyChanged(e);
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "LabelPresenterStyleResolved":
				base.InvalidateStyleSelector();
				return;
			case "CellContentAlignmentResolved":
			case "VisibilityResolved":
			{
				bool flag = this.IsInFieldChooser || base.DataContext is global::Infragistics.Windows.DataPresenter.FieldChooserEntry;
				bool isInGroupByArea = this.IsInGroupByArea;
				if (!flag && !isInGroupByArea)
				{
					if (e.PropertyName == "CellContentAlignmentResolved")
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty, base.Field.CellContentAlignmentResolved);
						return;
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, base.Field.VisibilityResolved);
					return;
				}
				break;
			}
			case "SortStatus":
			case "SortStatusGroupBy":
				this.SyncSortStatusWithField();
				return;
			case "Label":
				base.Content = base.Field.Label;
				return;
			case "FixedButtonVisibility":
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityPropertyKey, (base.Field == null || base.Field.FixedButtonVisibility == global::System.Windows.Visibility.Collapsed) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
				return;
			case "AllowRecordFilteringResolved":
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityPropertyKey, (base.Field == null || !base.Field.AllowRecordFilteringResolved || base.Field.Owner.FilterUITypeResolved != global::Infragistics.Windows.DataPresenter.FilterUIType.LabelIcons) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
				break;

				return;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000AE62E File Offset: 0x000AC82E
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this._mouseClickedOnLabel = false;
			base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000AE650 File Offset: 0x000AC850
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled && e.MouseDevice.Captured != this && e.ButtonState == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				this._mouseClickedOnLabel = true;
				this._lastLeftButtonDownPoint = e.GetPosition(this);
				base.CaptureMouse();
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field != null && field.Owner.DataPresenter != null)
				{
					if (this.IsInFieldChooser)
					{
						if (!base.IsKeyboardFocusWithin)
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.FocusTrivialAncestor(this);
						}
						global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), true);
						if (fieldChooser != null)
						{
							fieldChooser.SelectFieldHelper(field);
						}
						e.Handled = true;
						return;
					}
					switch (field.LabelClickActionResolved)
					{
					case global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing:
						if (global::Infragistics.Windows.DataPresenter.AllowFieldMoving.No != field.Owner.AllowFieldMovingResolved)
						{
							e.Handled = true;
						}
						break;
					case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnly:
					case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields:
					case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnlyTriState:
					case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFieldsTriState:
						e.Handled = true;
						return;
					case global::Infragistics.Windows.DataPresenter.LabelClickAction.SelectField:
						break;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000AE75B File Offset: 0x000AC95B
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.ProcessMouseLeftButtonUpHelper(e, false);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000AE76C File Offset: 0x000AC96C
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._mouseClickedOnLabel)
			{
				global::System.Windows.Point position = e.GetPosition(this);
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.Distance(position, this._lastLeftButtonDownPoint) >= 2.0 && this.StartDragHelper(e, true))
				{
					return;
				}
				bool flag = position.X >= 0.0 && position.Y >= 0.0 && position.X <= base.ActualWidth && position.Y <= base.ActualHeight;
				if (flag != this.IsPressed)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey, global::Infragistics.KnownBoxes.FromValue(flag));
				}
			}
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000AE818 File Offset: 0x000ACA18
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty)
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field != null)
				{
					global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignmentResolved = field.CellContentAlignmentResolved;
					base.CoerceValue(global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty);
					base.CoerceValue(global::System.Windows.Controls.Control.VerticalContentAlignmentProperty);
					base.CoerceValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
					base.CoerceValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityProperty);
					base.MinWidth = field.LabelMinWidthResolved;
					base.MinHeight = field.LabelMinHeightResolved;
					base.MaxWidth = field.LabelMaxWidthResolved;
					base.MaxHeight = field.LabelMaxHeightResolved;
					bool flag = this.IsInFieldChooser || base.DataContext is global::Infragistics.Windows.DataPresenter.FieldChooserEntry;
					bool isInGroupByArea = this.IsInGroupByArea;
					if (!flag && !isInGroupByArea)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, field.VisibilityResolved);
						base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty, cellContentAlignmentResolved);
					}
					this.SyncSortStatusWithField();
					base.SetValue(global::System.Windows.Controls.ContentControl.ContentProperty, field.Label);
					base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityPropertyKey, (field.FixedButtonVisibility == global::System.Windows.Visibility.Collapsed) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
					base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityPropertyKey, (!field.AllowRecordFilteringResolved || field.Owner.FilterUITypeResolved != global::Infragistics.Windows.DataPresenter.FilterUIType.LabelIcons) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
					if (cellContentAlignmentResolved == global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly && !flag && !isInGroupByArea)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
						if (owner != null && owner.IsHorizontal)
						{
							base.MinWidth = 0.0;
							base.Width = 0.0;
						}
						else
						{
							base.MinHeight = 0.0;
							base.Height = 0.0;
						}
					}
				}
				base.InvalidateStyleSelector();
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusPropertyKey, this.SortStatusInternal);
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000AE9E7 File Offset: 0x000ACBE7
		protected override void OnQueryCursor(global::System.Windows.Input.QueryCursorEventArgs e)
		{
			if (this._mouseClickedOnLabel)
			{
				e.Handled = true;
			}
			base.OnQueryCursor(e);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000AE9FF File Offset: 0x000ACBFF
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000AEA14 File Offset: 0x000ACC14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("LabelPresenter: ");
			if (base.Field != null)
			{
				stringBuilder.Append(base.Field.ToString());
				stringBuilder.Append(", ");
			}
			if (base.Content != null)
			{
				stringBuilder.Append(base.Content.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000AEA7C File Offset: 0x000ACC7C
		protected override void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (base.IsMouseOver)
			{
				if (this.IsPressed)
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"Pressed",
						"MouseOver",
						"Normal"
					});
				}
				else
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"MouseOver",
						"Normal"
					});
				}
			}
			else if (this.IsPressed)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"Pressed",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			if (base.IsDragIndicator)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Dragging", useTransitions);
			}
			else if (this.IsDragSource)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"DragSource",
					"NotDragging"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "NotDragging", useTransitions);
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (this.IsInFieldChooser)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FieldChooser", useTransitions);
			}
			else if (this.IsInGroupByArea)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "GroupByArea", useTransitions);
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
				if (fieldLayout != null && !fieldLayout.HasSeparateHeader)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "CellArea", useTransitions);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "HeaderArea", useTransitions);
				}
			}
			if (field != null && field.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Selected", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unselected", useTransitions);
			}
			string text = null;
			switch (this.SortStatus)
			{
			case global::Infragistics.Windows.Controls.SortStatus.NotSorted:
				text = "Unsorted";
				break;
			case global::Infragistics.Windows.Controls.SortStatus.Ascending:
				text = "SortAscending";
				break;
			case global::Infragistics.Windows.Controls.SortStatus.Descending:
				text = "SortDescending";
				break;
			}
			if (text != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, text, useTransitions);
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000AEC60 File Offset: 0x000ACE60
		private static object CoerceFilterButtonVisibility(global::System.Windows.DependencyObject target, object value)
		{
			if (object.Equals(global::System.Windows.Visibility.Visible, value))
			{
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = target as global::Infragistics.Windows.DataPresenter.LabelPresenter;
				if (labelPresenter != null && labelPresenter.IsInGroupByArea)
				{
					global::Infragistics.Windows.DataPresenter.Field field = labelPresenter.Field;
					if (field != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
						if (owner != null && owner.DataPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.RecordManager recordManager = owner.DataPresenter.RecordManager;
							if (recordManager == null || !recordManager.ContainsFieldLayout(owner))
							{
								return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
							}
						}
					}
				}
			}
			return value;
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000AECC8 File Offset: 0x000ACEC8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FilterButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000AECDA File Offset: 0x000ACEDA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FixedButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityProperty);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000AECEC File Offset: 0x000ACEEC
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x000AECFE File Offset: 0x000ACEFE
		public global::System.Windows.Media.Brush InnerBorderBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.InnerBorderBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.InnerBorderBrushProperty, value);
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000AED0C File Offset: 0x000ACF0C
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x000AED1E File Offset: 0x000ACF1E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsDragSource
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsDragSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsDragSourceProperty, value);
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x000AED31 File Offset: 0x000ACF31
		// (set) Token: 0x06002730 RID: 10032 RVA: 0x000AED43 File Offset: 0x000ACF43
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsInFieldChooser
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsInFieldChooserProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsInFieldChooserProperty, value);
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000AED58 File Offset: 0x000ACF58
		private static void OnIsInGroupByAreaChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if ((bool)e.NewValue)
			{
				dependencyObject.ClearValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty);
			}
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = (global::Infragistics.Windows.DataPresenter.LabelPresenter)dependencyObject;
			labelPresenter.CoerceValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
			labelPresenter.UpdateVisualStates();
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000AED96 File Offset: 0x000ACF96
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x000AEDA8 File Offset: 0x000ACFA8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsInGroupByArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsInGroupByAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsInGroupByAreaProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000AEDBB File Offset: 0x000ACFBB
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsPressed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedProperty);
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x000AEDCD File Offset: 0x000ACFCD
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x000AEDDF File Offset: 0x000ACFDF
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelectedInFieldChooser
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsSelectedInFieldChooserProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsSelectedInFieldChooserProperty, value);
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x000AEDF2 File Offset: 0x000ACFF2
		// (set) Token: 0x06002738 RID: 10040 RVA: 0x000AEE04 File Offset: 0x000AD004
		public global::System.Windows.Media.Brush LabelHighlight
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.LabelHighlightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.LabelHighlightProperty, value);
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x000AEE12 File Offset: 0x000AD012
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x000AEE24 File Offset: 0x000AD024
		public global::System.Windows.Media.Brush OuterBorderBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.OuterBorderBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.OuterBorderBrushProperty, value);
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x000AEE32 File Offset: 0x000AD032
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusProperty);
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000AEE44 File Offset: 0x000AD044
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x000AEE56 File Offset: 0x000AD056
		private global::Infragistics.Windows.Controls.SortStatus SortStatusInternal
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty, value);
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000AEE6C File Offset: 0x000AD06C
		private static object CoerceHorizontalContentAlignment(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = target as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (labelPresenter != null)
			{
				object defaultAlignment = labelPresenter.GetDefaultAlignment(false);
				if (defaultAlignment != null)
				{
					return defaultAlignment;
				}
			}
			return value;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000AEE94 File Offset: 0x000AD094
		private static object CoerceVerticalContentAlignment(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = target as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (labelPresenter != null)
			{
				object defaultAlignment = labelPresenter.GetDefaultAlignment(true);
				if (defaultAlignment != null)
				{
					return defaultAlignment;
				}
			}
			return value;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000AEEBC File Offset: 0x000AD0BC
		private object GetDefaultAlignment(bool verticalAlignment)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner == null)
			{
				return null;
			}
			global::System.Windows.ValueSource valueSource;
			if (verticalAlignment)
			{
				valueSource = global::System.Windows.DependencyPropertyHelper.GetValueSource(this, global::System.Windows.Controls.Control.VerticalContentAlignmentProperty);
			}
			else
			{
				valueSource = global::System.Windows.DependencyPropertyHelper.GetValueSource(this, global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty);
			}
			if (valueSource.BaseValueSource > global::System.Windows.BaseValueSource.Default)
			{
				return null;
			}
			if (owner.UseCellPresenters)
			{
				global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignmentResolved = field.CellContentAlignmentResolved;
				if (verticalAlignment)
				{
					if (verticalAlignment)
					{
						return global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.GetVerticalAlignmentLabel(cellContentAlignmentResolved);
					}
				}
				else if (!verticalAlignment)
				{
					return global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.GetHorizontalAlignmentLabel(cellContentAlignmentResolved);
				}
			}
			if (verticalAlignment)
			{
				return global::System.Windows.VerticalAlignment.Center;
			}
			return global::System.Windows.HorizontalAlignment.Stretch;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000AEF4C File Offset: 0x000AD14C
		private void ProcessMouseLeftButtonUpHelper(global::System.Windows.Input.MouseButtonEventArgs eventArgs, bool dragStarted)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			if (this._mouseClickedOnLabel)
			{
				this._mouseClickedOnLabel = false;
				base.ReleaseMouseCapture();
				if (eventArgs != null && !eventArgs.Handled && !dragStarted)
				{
					global::System.Windows.IInputElement directlyOver = eventArgs.MouseDevice.DirectlyOver;
					if (directlyOver is global::System.Windows.Media.Visual && ((global::System.Windows.Media.Visual)directlyOver).IsDescendantOf(this))
					{
						global::Infragistics.Windows.DataPresenter.Field field = base.Field;
						if (field != null)
						{
							if (this.IsInFieldChooser)
							{
								eventArgs.Handled = true;
								return;
							}
							if (field.PerformLabelClickAction(this.IsInGroupByArea))
							{
								eventArgs.Handled = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000AEFE0 File Offset: 0x000AD1E0
		private void SyncSortStatusWithField()
		{
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty);
				return;
			}
			if (this.IsInGroupByArea)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty, field.SortStatusGroupBy);
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty, field.SortStatus);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000AF038 File Offset: 0x000AD238
		internal bool StartDragHelper(global::System.Windows.Input.MouseEventArgs e, bool calledFromLabelPresenterMouseMove)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
			bool flag = dataPresenter != null && dataPresenter.GroupByAreaMode != global::Infragistics.Windows.DataPresenter.GroupByAreaMode.DefaultFieldLayoutOnly;
			if ((global::Infragistics.Windows.DataPresenter.AllowFieldMoving.No != field.Owner.AllowFieldMovingResolved || (flag && field.AllowGroupByResolved)) && dataPresenter != null && dataPresenter.EndEditMode(true, false))
			{
				if (calledFromLabelPresenterMouseMove)
				{
					this.ProcessMouseLeftButtonUpHelper(null, true);
				}
				global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = this.IsInFieldChooser ? ((global::Infragistics.Windows.DataPresenter.FieldChooser)global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), true)) : null;
				if ((fieldChooser != null) ? fieldChooser.CaptureMouse() : dataPresenter.CaptureMouse())
				{
					global::Infragistics.Windows.DataPresenter.FieldDragManager fieldDragManager = new global::Infragistics.Windows.DataPresenter.FieldDragManager(field, this, fieldChooser);
					fieldDragManager.StartDrag(e);
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x000AF0E8 File Offset: 0x000AD2E8
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field != null && field.Owner != null)
				{
					field.Owner.LastSelectableItemLabel = this;
				}
				if (field.LabelClickActionResolved != global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing)
				{
					return field;
				}
				if (field.Owner.HasSeparateHeader)
				{
					return null;
				}
				return base.DataContext as global::Infragistics.Windows.Selection.ISelectableItem;
			}
		}

		// Token: 0x04001357 RID: 4951
		private bool _mouseClickedOnLabel;

		// Token: 0x04001358 RID: 4952
		private global::System.Windows.Point _lastLeftButtonDownPoint;

		// Token: 0x04001359 RID: 4953
		private static readonly global::System.Windows.DependencyPropertyKey FilterButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FilterButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.CoerceFilterButtonVisibility)));

		// Token: 0x0400135A RID: 4954
		public static readonly global::System.Windows.DependencyProperty FilterButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityPropertyKey.DependencyProperty;

		// Token: 0x0400135B RID: 4955
		private static readonly global::System.Windows.DependencyPropertyKey FixedButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixedButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x0400135C RID: 4956
		public static readonly global::System.Windows.DependencyProperty FixedButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityPropertyKey.DependencyProperty;

		// Token: 0x0400135D RID: 4957
		public static readonly global::System.Windows.DependencyProperty InnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register("InnerBorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400135E RID: 4958
		public static readonly global::System.Windows.DependencyProperty IsDragSourceProperty = global::System.Windows.DependencyProperty.Register("IsDragSource", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x0400135F RID: 4959
		public static readonly global::System.Windows.DependencyProperty IsInFieldChooserProperty = global::System.Windows.DependencyProperty.Register("IsInFieldChooser", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001360 RID: 4960
		public static readonly global::System.Windows.DependencyProperty IsInGroupByAreaProperty = global::System.Windows.DependencyProperty.Register("IsInGroupByArea", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.OnIsInGroupByAreaChanged)));

		// Token: 0x04001361 RID: 4961
		private static readonly global::System.Windows.DependencyPropertyKey IsPressedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsPressed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001362 RID: 4962
		public static readonly global::System.Windows.DependencyProperty IsPressedProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey.DependencyProperty;

		// Token: 0x04001363 RID: 4963
		public static readonly global::System.Windows.DependencyProperty IsSelectedInFieldChooserProperty = global::System.Windows.DependencyProperty.Register("IsSelectedInFieldChooser", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04001364 RID: 4964
		public static readonly global::System.Windows.DependencyProperty LabelHighlightProperty = global::System.Windows.DependencyProperty.Register("LabelHighlight", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001365 RID: 4965
		public static readonly global::System.Windows.DependencyProperty OuterBorderBrushProperty = global::System.Windows.DependencyProperty.Register("OuterBorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001366 RID: 4966
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001367 RID: 4967
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x04001368 RID: 4968
		private static readonly global::System.Windows.DependencyProperty SortStatusInternalProperty = global::System.Windows.DependencyProperty.Register("SortStatusInternal", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x0200033A RID: 826
		internal class LPContentTemplateSelector : global::System.Windows.Controls.DataTemplateSelector
		{
			// Token: 0x06002745 RID: 10053 RVA: 0x000AF138 File Offset: 0x000AD338
			static LPContentTemplateSelector()
			{
				global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForString = new global::System.Windows.DataTemplate(typeof(string));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.TextBlock));
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				frameworkElementFactory.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, binding);
				binding = new global::System.Windows.Data.Binding();
				global::System.Windows.Data.RelativeSource relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), 1);
				binding.RelativeSource = relativeSource;
				binding.Path = new global::System.Windows.PropertyPath("Field.LabelTextAlignmentResolved", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				frameworkElementFactory.SetBinding(global::System.Windows.Controls.TextBlock.TextAlignmentProperty, binding);
				binding = new global::System.Windows.Data.Binding();
				relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), 1);
				binding.RelativeSource = relativeSource;
				binding.Path = new global::System.Windows.PropertyPath("Field.LabelTextTrimmingResolved", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				frameworkElementFactory.SetBinding(global::System.Windows.Controls.TextBlock.TextTrimmingProperty, binding);
				binding = new global::System.Windows.Data.Binding();
				relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), 1);
				binding.RelativeSource = relativeSource;
				binding.Path = new global::System.Windows.PropertyPath("Field.LabelTextWrappingResolved", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				frameworkElementFactory.SetBinding(global::System.Windows.Controls.TextBlock.TextWrappingProperty, binding);
				global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForString.VisualTree = frameworkElementFactory;
				global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForString.Seal();
				global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForImageSource = new global::System.Windows.DataTemplate(typeof(global::System.Windows.Media.ImageSource));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Image));
				binding = new global::System.Windows.Data.Binding();
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				frameworkElementFactory2.SetBinding(global::System.Windows.Controls.Image.SourceProperty, binding);
				global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForImageSource.VisualTree = frameworkElementFactory2;
				global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForImageSource.Seal();
			}

			// Token: 0x06002746 RID: 10054 RVA: 0x000AF2CC File Offset: 0x000AD4CC
			internal static global::System.Windows.DataTemplate SelectTemplateForImageSource(global::System.Windows.Media.ImageSource imageSource, global::System.Windows.Controls.ContentPresenter presenter)
			{
				if (presenter == null || imageSource == null)
				{
					return null;
				}
				object obj = presenter.TryFindResource(imageSource.GetType());
				if (obj is global::System.Windows.DataTemplate)
				{
					return null;
				}
				if (!imageSource.IsFrozen)
				{
					imageSource.Freeze();
				}
				return global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForImageSource;
			}

			// Token: 0x06002747 RID: 10055 RVA: 0x000AF30C File Offset: 0x000AD50C
			public override global::System.Windows.DataTemplate SelectTemplate(object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = container as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter == null)
				{
					return null;
				}
				if (item is string)
				{
					return global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.DataTemplateForString;
				}
				global::System.Windows.Media.ImageSource imageSource = item as global::System.Windows.Media.ImageSource;
				if (imageSource != null)
				{
					return global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.SelectTemplateForImageSource(imageSource, contentPresenter);
				}
				return null;
			}

			// Token: 0x04001369 RID: 4969
			internal static readonly global::System.Windows.DataTemplate DataTemplateForImageSource;

			// Token: 0x0400136A RID: 4970
			internal static readonly global::System.Windows.DataTemplate DataTemplateForString;

			// Token: 0x0400136B RID: 4971
			internal static global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector Instance = new global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector();
		}
	}
}
