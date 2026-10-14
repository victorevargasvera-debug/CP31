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
	// Token: 0x020002F9 RID: 761
	[global::System.Windows.TemplateVisualState(Name = "DragSource", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "GroupByArea", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "NotDragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "CellArea", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "HeaderArea", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "FieldChooser", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "SortAscending", GroupName = "SortStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Dragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "SortDescending", GroupName = "SortStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unsorted", GroupName = "SortStates")]
	public class LabelPresenter : global::Infragistics.Windows.DataPresenter.DataItemPresenter, global::Infragistics.Windows.Selection.ISelectableElement
	{
		// Token: 0x06002372 RID: 9074 RVA: 0x0009A78C File Offset: 0x0009898C
		static LabelPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.Instance));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Stretch, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.CoerceHorizontalContentAlignment)));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.CoerceVerticalContentAlignment)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x0009AB17 File Offset: 0x00098D17
		public override bool IsEditingAllowed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0009AB1A File Offset: 0x00098D1A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPresenterAutomationPeer(this);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0009AB22 File Offset: 0x00098D22
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0009AB2B File Offset: 0x00098D2B
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0009AB2D File Offset: 0x00098D2D
		protected override void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0009AB2F File Offset: 0x00098D2F
		protected override void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0009AB31 File Offset: 0x00098D31
		protected internal override bool CommitEditValue(object editedValue, out bool stayInEditMode)
		{
			stayInEditMode = false;
			return false;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0009AB37 File Offset: 0x00098D37
		protected override void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e)
		{
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0009AB3C File Offset: 0x00098D3C
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
				this.SortStatusInternal = base.Field.SortStatus;
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

		// Token: 0x0600237D RID: 9085 RVA: 0x0009AD0D File Offset: 0x00098F0D
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this._mouseClickedOnLabel = false;
			base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			base.OnLostMouseCapture(e);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0009AD30 File Offset: 0x00098F30
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

		// Token: 0x0600237F RID: 9087 RVA: 0x0009AE3B File Offset: 0x0009903B
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.ProcessMouseLeftButtonUpHelper(e, false);
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0009AE4C File Offset: 0x0009904C
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

		// Token: 0x06002381 RID: 9089 RVA: 0x0009AEF8 File Offset: 0x000990F8
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
					base.SetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusInternalProperty, field.SortStatus);
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

		// Token: 0x06002382 RID: 9090 RVA: 0x0009B0D7 File Offset: 0x000992D7
		protected override void OnQueryCursor(global::System.Windows.Input.QueryCursorEventArgs e)
		{
			if (this._mouseClickedOnLabel)
			{
				e.Handled = true;
			}
			base.OnQueryCursor(e);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0009B0EF File Offset: 0x000992EF
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0009B104 File Offset: 0x00099304
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

		// Token: 0x06002385 RID: 9093 RVA: 0x0009B16C File Offset: 0x0009936C
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

		// Token: 0x06002386 RID: 9094 RVA: 0x0009B350 File Offset: 0x00099550
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

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x0009B3B8 File Offset: 0x000995B8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility FilterButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0009B3CA File Offset: 0x000995CA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FixedButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityProperty);
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0009B3DC File Offset: 0x000995DC
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0009B3EE File Offset: 0x000995EE
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0009B3FC File Offset: 0x000995FC
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0009B40E File Offset: 0x0009960E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0009B421 File Offset: 0x00099621
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x0009B433 File Offset: 0x00099633
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x0600238F RID: 9103 RVA: 0x0009B448 File Offset: 0x00099648
		private static void OnIsInGroupByAreaChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = (global::Infragistics.Windows.DataPresenter.LabelPresenter)dependencyObject;
			labelPresenter.CoerceValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityProperty);
			labelPresenter.UpdateVisualStates();
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0009B46D File Offset: 0x0009966D
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x0009B47F File Offset: 0x0009967F
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x0009B492 File Offset: 0x00099692
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsPressed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedProperty);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0009B4A4 File Offset: 0x000996A4
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x0009B4B6 File Offset: 0x000996B6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0009B4C9 File Offset: 0x000996C9
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x0009B4DB File Offset: 0x000996DB
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

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0009B4E9 File Offset: 0x000996E9
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x0009B4FB File Offset: 0x000996FB
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

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0009B509 File Offset: 0x00099709
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusProperty);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x0009B51B File Offset: 0x0009971B
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x0009B52D File Offset: 0x0009972D
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

		// Token: 0x0600239C RID: 9116 RVA: 0x0009B540 File Offset: 0x00099740
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

		// Token: 0x0600239D RID: 9117 RVA: 0x0009B568 File Offset: 0x00099768
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

		// Token: 0x0600239E RID: 9118 RVA: 0x0009B590 File Offset: 0x00099790
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

		// Token: 0x0600239F RID: 9119 RVA: 0x0009B620 File Offset: 0x00099820
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
							if (field.PerformLabelClickAction())
							{
								eventArgs.Handled = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0009B6AC File Offset: 0x000998AC
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

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x0009B75C File Offset: 0x0009995C
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

		// Token: 0x0400113D RID: 4413
		private bool _mouseClickedOnLabel;

		// Token: 0x0400113E RID: 4414
		private global::System.Windows.Point _lastLeftButtonDownPoint;

		// Token: 0x0400113F RID: 4415
		private static readonly global::System.Windows.DependencyPropertyKey FilterButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FilterButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.CoerceFilterButtonVisibility)));

		// Token: 0x04001140 RID: 4416
		public static readonly global::System.Windows.DependencyProperty FilterButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.FilterButtonVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04001141 RID: 4417
		private static readonly global::System.Windows.DependencyPropertyKey FixedButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixedButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x04001142 RID: 4418
		public static readonly global::System.Windows.DependencyProperty FixedButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.FixedButtonVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04001143 RID: 4419
		public static readonly global::System.Windows.DependencyProperty InnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register("InnerBorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001144 RID: 4420
		public static readonly global::System.Windows.DependencyProperty IsDragSourceProperty = global::System.Windows.DependencyProperty.Register("IsDragSource", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001145 RID: 4421
		public static readonly global::System.Windows.DependencyProperty IsInFieldChooserProperty = global::System.Windows.DependencyProperty.Register("IsInFieldChooser", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001146 RID: 4422
		public static readonly global::System.Windows.DependencyProperty IsInGroupByAreaProperty = global::System.Windows.DependencyProperty.Register("IsInGroupByArea", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.LabelPresenter.OnIsInGroupByAreaChanged)));

		// Token: 0x04001147 RID: 4423
		private static readonly global::System.Windows.DependencyPropertyKey IsPressedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsPressed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001148 RID: 4424
		public static readonly global::System.Windows.DependencyProperty IsPressedProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.IsPressedPropertyKey.DependencyProperty;

		// Token: 0x04001149 RID: 4425
		public static readonly global::System.Windows.DependencyProperty IsSelectedInFieldChooserProperty = global::System.Windows.DependencyProperty.Register("IsSelectedInFieldChooser", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x0400114A RID: 4426
		public static readonly global::System.Windows.DependencyProperty LabelHighlightProperty = global::System.Windows.DependencyProperty.Register("LabelHighlight", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400114B RID: 4427
		public static readonly global::System.Windows.DependencyProperty OuterBorderBrushProperty = global::System.Windows.DependencyProperty.Register("OuterBorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400114C RID: 4428
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataItemPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x0400114D RID: 4429
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.LabelPresenter.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x0400114E RID: 4430
		private static readonly global::System.Windows.DependencyProperty SortStatusInternalProperty = global::System.Windows.DependencyProperty.Register("SortStatusInternal", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x020002FA RID: 762
		internal class LPContentTemplateSelector : global::System.Windows.Controls.DataTemplateSelector
		{
			// Token: 0x060023A2 RID: 9122 RVA: 0x0009B7AC File Offset: 0x000999AC
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

			// Token: 0x060023A3 RID: 9123 RVA: 0x0009B940 File Offset: 0x00099B40
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

			// Token: 0x060023A4 RID: 9124 RVA: 0x0009B980 File Offset: 0x00099B80
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

			// Token: 0x0400114F RID: 4431
			internal static readonly global::System.Windows.DataTemplate DataTemplateForImageSource;

			// Token: 0x04001150 RID: 4432
			internal static readonly global::System.Windows.DataTemplate DataTemplateForString;

			// Token: 0x04001151 RID: 4433
			internal static global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector Instance = new global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector();
		}
	}
}
