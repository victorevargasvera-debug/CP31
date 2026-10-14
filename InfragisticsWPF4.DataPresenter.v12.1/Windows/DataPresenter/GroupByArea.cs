using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D7 RID: 727
	[global::System.Windows.TemplatePart(Name = "PART_AvailableFieldLabelsArea", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_InsertionPoint", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_GroupedFieldLabelsArea", Type = typeof(global::System.Windows.FrameworkElement))]
	public class GroupByArea : global::Infragistics.Windows.DataPresenter.GroupByAreaBase
	{
		// Token: 0x060022B2 RID: 8882 RVA: 0x0009737C File Offset: 0x0009557C
		static GroupByArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByArea)));
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00097454 File Offset: 0x00095654
		public GroupByArea() : this(null)
		{
			base.IsExpanded = true;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00097464 File Offset: 0x00095664
		internal GroupByArea(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00097474 File Offset: 0x00095674
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyAvailableFieldLabelsArea();
			this.VerifyGroupedFieldLabelsArea();
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00097488 File Offset: 0x00095688
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaAutomationPeer(this);
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00097490 File Offset: 0x00095690
		internal override void OnStyleVersionNumberChanged()
		{
			base.OnStyleVersionNumberChanged();
			if (!this.IsActive)
			{
				return;
			}
			if (this._fieldLayoutWired != null && this._fieldLayoutWired != base.DataPresenter.DefaultFieldLayout)
			{
				this.OnFieldLayoutInitialized();
			}
			if (base.DataPresenter != null && base.DataPresenter.DefaultFieldLayout != null && this.AvailableFieldLabels != null)
			{
				this.RefreshAvailableFieldLabels(base.DataPresenter.DefaultFieldLayout, this.AvailableFieldLabels, true);
				this.RefreshGroupedFieldLabels(base.DataPresenter.DefaultFieldLayout, this.GroupedFieldLabels, true);
				if (this.GroupedFieldLabels == null || this.GroupedFieldLabels.Count == 0 || this.GroupedFieldLabels.Count == 0)
				{
					this.OnShowPrompts();
					return;
				}
				this.OnHidePrompts();
			}
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0009754E File Offset: 0x0009574E
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			if (this._reinitializeOperation == null)
			{
				this._reinitializeOperation = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ReinitializeAsync));
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0009757E File Offset: 0x0009577E
		public global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection AvailableFieldLabels
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.AvailableFieldLabelsProperty) as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x00097590 File Offset: 0x00095790
		public global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection GroupedFieldLabels
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.GroupedFieldLabelsProperty) as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection;
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000975A2 File Offset: 0x000957A2
		internal global::System.Windows.Style GetDefaultGroupByFieldLabelStyle()
		{
			return base.TryFindResource(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)) as global::System.Windows.Style;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000975BC File Offset: 0x000957BC
		private static void OnFieldLayoutTemplateVersionChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByArea groupByArea = target as global::Infragistics.Windows.DataPresenter.GroupByArea;
			if (!groupByArea.IsActive)
			{
				return;
			}
			groupByArea.RefreshAvailableFieldLabels(groupByArea.DataPresenter.DefaultFieldLayout, groupByArea.AvailableFieldLabels, true);
			groupByArea.RefreshGroupedFieldLabels(groupByArea.DataPresenter.DefaultFieldLayout, groupByArea.GroupedFieldLabels, true);
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x00097609 File Offset: 0x00095809
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0009761B File Offset: 0x0009581B
		private int FieldLayoutTemplateVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.FieldLayoutTemplateVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.FieldLayoutTemplateVersionProperty, value);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x0009762E File Offset: 0x0009582E
		private bool IsActive
		{
			get
			{
				return global::System.Windows.Media.VisualTreeHelper.GetParent(this) != null;
			}
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0009763C File Offset: 0x0009583C
		private global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel CreateGroupByAreaFieldLabelFromField(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Style defaultStyle, bool forGroupedFieldsArea)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel = new global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel(this, field, defaultStyle);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("StyleVersionNumber");
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = this;
			groupByAreaFieldLabel.SetBinding(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel.StyleVersionNumberProperty, binding);
			if (!forGroupedFieldsArea)
			{
				binding = new global::System.Windows.Data.Binding("VisibilityResolved");
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = field;
				groupByAreaFieldLabel.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
			}
			groupByAreaFieldLabel.DragStarted += this.OnGroupByAreaFieldLabelDragStarted;
			groupByAreaFieldLabel.DragDelta += this.OnGroupByAreaFieldLabelDragDelta;
			groupByAreaFieldLabel.DragCompleted += this.OnGroupByAreaFieldLabelDragCompleted;
			return groupByAreaFieldLabel;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000976D8 File Offset: 0x000958D8
		private void InitializeAvailableFieldLabelsCollection()
		{
			if (base.DataPresenter == null || base.DataPresenter.DefaultFieldLayout == null)
			{
				return;
			}
			if (base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.AvailableFieldLabelsProperty) == null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = base.DataPresenter.DefaultFieldLayout;
				global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection groupByAreaFieldLabelCollection = global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection.Create();
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.AvailableFieldLabelsPropertyKey, groupByAreaFieldLabelCollection);
				this.RefreshAvailableFieldLabels(defaultFieldLayout, groupByAreaFieldLabelCollection, true);
			}
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00097730 File Offset: 0x00095930
		private void InitializeGroupedFieldLabelsCollection()
		{
			if (base.DataPresenter == null || base.DataPresenter.DefaultFieldLayout == null)
			{
				return;
			}
			if (base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.GroupedFieldLabelsProperty) == null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = base.DataPresenter.DefaultFieldLayout;
				global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection groupByAreaFieldLabelCollection = global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection.Create();
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.GroupedFieldLabelsPropertyKey, groupByAreaFieldLabelCollection);
				groupByAreaFieldLabelCollection.CollectionChanged += this.OnGroupedFieldsChanged;
				this.RefreshGroupedFieldLabels(defaultFieldLayout, groupByAreaFieldLabelCollection, true);
			}
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0009779C File Offset: 0x0009599C
		internal override void OnThemeChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<string> e)
		{
			base.OnThemeChanged(sender, e);
			if (!this.IsActive)
			{
				return;
			}
			this.RefreshAvailableFieldLabels(base.DataPresenter.DefaultFieldLayout, this.AvailableFieldLabels, true);
			this.RefreshGroupedFieldLabels(base.DataPresenter.DefaultFieldLayout, this.GroupedFieldLabels, true);
			if (this.GroupedFieldLabels == null || this.GroupedFieldLabels.Count == 0 || this.GroupedFieldLabels.Count == 0)
			{
				this.OnShowPrompts();
				return;
			}
			this.OnHidePrompts();
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00097820 File Offset: 0x00095A20
		internal override void OnFieldLayoutInitialized()
		{
			base.OnFieldLayoutInitialized();
			if (base.DataPresenter == null || base.DataPresenter.DefaultFieldLayout == null)
			{
				return;
			}
			if (!this.IsActive)
			{
				return;
			}
			this.InitializeAvailableFieldLabelsCollection();
			this.InitializeGroupedFieldLabelsCollection();
			this.RefreshAvailableFieldLabels(base.DataPresenter.DefaultFieldLayout, this.AvailableFieldLabels, true);
			this.RefreshGroupedFieldLabels(base.DataPresenter.DefaultFieldLayout, this.GroupedFieldLabels, true);
			this.InitializeGroupedFieldLabelsCollection();
			this.InitializeAvailableFieldLabelsCollection();
			if (this._fieldLayoutWired != base.DataPresenter.DefaultFieldLayout)
			{
				if (this._fieldLayoutWired != null)
				{
					this._fieldLayoutWired.SortedFields.CollectionChanged -= this.OnSortedFieldsChanged;
				}
				this._fieldLayoutWired = base.DataPresenter.DefaultFieldLayout;
				if (this._fieldLayoutWired != null)
				{
					this._fieldLayoutWired.SortedFields.CollectionChanged += this.OnSortedFieldsChanged;
				}
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("TemplateVersion");
			binding.Source = this._fieldLayoutWired;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			base.SetBinding(global::Infragistics.Windows.DataPresenter.GroupByArea.FieldLayoutTemplateVersionProperty, binding);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00097931 File Offset: 0x00095B31
		private void OnExpanderBarAreaMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.IsExpanded = !base.IsExpanded;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00097944 File Offset: 0x00095B44
		private void OnGroupByAreaFieldLabelDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel = sender as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel;
			if (groupByAreaFieldLabel == null)
			{
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			base.RemoveVisualChild(base.CurrentFieldLabelDragElement);
			base.CurrentFieldLabelDragElement = null;
			if (base.IsDragInsertionPointHighlighted)
			{
				this.OnHideInsertionPoint();
			}
			bool flag = !groupByAreaFieldLabel.Field.IsGroupBy && this._isFieldLabelDragOverGroupedListArea;
			bool flag2 = groupByAreaFieldLabel.Field.IsGroupBy && this._isFieldLabelDragOverGroupedListArea;
			bool flag3 = groupByAreaFieldLabel.Field.IsGroupBy && !this._isFieldLabelDragOverGroupedListArea;
			this._ignoreSortedFieldsChange = true;
			global::System.Windows.Style defaultGroupByFieldLabelStyle = this.GetDefaultGroupByFieldLabelStyle();
			global::Infragistics.Windows.DataPresenter.GroupingHelper groupingHelper = new global::Infragistics.Windows.DataPresenter.GroupingHelper(base.DataPresenter.DefaultFieldLayout);
			bool flag4 = false;
			try
			{
				global::Infragistics.Windows.DataPresenter.IViewPanelInfo dataPresenter = base.DataPresenter;
				if (dataPresenter != null && !dataPresenter.IsOkToScroll())
				{
					flag4 = true;
				}
				else
				{
					if (flag2)
					{
						if (this.GroupedFieldLabels.IndexOf(groupByAreaFieldLabel) != this._currentFieldLabelDragElementInsertAtIndex)
						{
							if (this.GroupedFieldLabels.IndexOf(groupByAreaFieldLabel) < this._currentFieldLabelDragElementInsertAtIndex)
							{
								this._currentFieldLabelDragElementInsertAtIndex--;
							}
							if (this._currentFieldLabelDragElementInsertAtIndex > -1 && this._currentFieldLabelDragElementInsertAtIndex != this.GroupedFieldLabels.IndexOf(groupByAreaFieldLabel) && this._currentFieldLabelDragElementInsertAtIndex <= this.GroupedFieldLabels.Count)
							{
								if (!groupingHelper.ProcessTryReGroup(groupByAreaFieldLabel.Field, this._currentFieldLabelDragElementInsertAtIndex))
								{
									flag4 = true;
								}
								else
								{
									this.GroupedFieldLabels.InternalRemove(groupByAreaFieldLabel, false);
									this.GroupedFieldLabels.InternalInsert(this._currentFieldLabelDragElementInsertAtIndex, groupByAreaFieldLabel, true);
									groupByAreaFieldLabel.OnAddedToGroupedList();
									groupingHelper.ProcessApplyReGroup(groupByAreaFieldLabel.Field, this._currentFieldLabelDragElementInsertAtIndex);
								}
							}
						}
					}
					else if (flag)
					{
						if (this._currentFieldLabelDragElementInsertAtIndex < 0 || this._currentFieldLabelDragElementInsertAtIndex > this.GroupedFieldLabels.Count)
						{
							flag4 = true;
						}
						else if (!groupingHelper.ProcessTryGrouping(groupByAreaFieldLabel.Field, this._currentFieldLabelDragElementInsertAtIndex))
						{
							flag4 = true;
						}
						else
						{
							groupByAreaFieldLabel.OnRemovedFromAvailableList();
							this.UnhookFieldLabelDragEventListeners(groupByAreaFieldLabel);
							this.AvailableFieldLabels.InternalRemove(groupByAreaFieldLabel, true);
							global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel2 = this.CreateGroupByAreaFieldLabelFromField(groupByAreaFieldLabel.Field, defaultGroupByFieldLabelStyle, true);
							this.GroupedFieldLabels.InternalInsert(this._currentFieldLabelDragElementInsertAtIndex, groupByAreaFieldLabel2, true);
							groupByAreaFieldLabel2.OnAddedToGroupedList();
							groupingHelper.ProcessApplyGrouping(groupByAreaFieldLabel.Field, this._currentFieldLabelDragElementInsertAtIndex);
						}
					}
					else
					{
						if (flag3)
						{
							if (!groupingHelper.ProcessTryUnGroup(groupByAreaFieldLabel.Field))
							{
								flag4 = true;
								return;
							}
							this.GroupedFieldLabels.InternalRemove(groupByAreaFieldLabel, true);
							this.UnhookFieldLabelDragEventListeners(groupByAreaFieldLabel);
							this._ignoreSortedFieldsChange = false;
							if (groupingHelper.SortedFields.Count <= 0)
							{
								goto IL_2EC;
							}
							groupingHelper.ProcessApplyUnGroup(groupByAreaFieldLabel.Field);
							using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> enumerator = this.AvailableFieldLabels.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel3 = enumerator.Current;
									if (groupByAreaFieldLabel3.Field == groupByAreaFieldLabel.Field)
									{
										groupByAreaFieldLabel3.OnAddedToAvailableList();
										break;
									}
								}
								goto IL_2EC;
							}
						}
						if (!groupByAreaFieldLabel.Field.IsGroupBy)
						{
							flag4 = true;
						}
					}
					IL_2EC:;
				}
			}
			finally
			{
				this._ignoreSortedFieldsChange = false;
				groupByAreaFieldLabel.Opacity = 1.0;
				if (!flag4)
				{
					groupingHelper.RaiseGroupedEventHelper();
				}
			}
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00097C98 File Offset: 0x00095E98
		private void OnGroupByAreaFieldLabelDragDelta(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel = sender as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel;
			if (groupByAreaFieldLabel == null)
			{
				return;
			}
			base.CurrentFieldLabelDragElementTransform.X = e.HorizontalChange;
			base.CurrentFieldLabelDragElementTransform.Y = e.VerticalChange;
			global::System.Windows.Point pointToTransform = new global::System.Windows.Point(e.HorizontalChange + this._currentFieldLabelDragElementStartOffset.X, e.VerticalChange + this._currentFieldLabelDragElementStartOffset.Y);
			global::System.Windows.Point dragPositionFlags = global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(pointToTransform, groupByAreaFieldLabel, this);
			this.SetDragPositionFlags(dragPositionFlags);
			double y = 0.0;
			if (!this._isFieldLabelDragOverGroupedListArea)
			{
				if (base.IsDragInsertionPointHighlighted)
				{
					this.OnHideInsertionPoint();
				}
				this._currentFieldLabelDragElementInsertAtIndex = -1;
				base.LastDragInsertionPointOffset = new global::System.Windows.Vector(double.PositiveInfinity, double.PositiveInfinity);
				return;
			}
			if (this.GroupedFieldLabels.Count < 1)
			{
				global::System.Windows.Vector vector = new global::System.Windows.Vector(0.0, y);
				if (vector != base.LastDragInsertionPointOffset)
				{
					base.InsertionPoint.RenderTransform = new global::System.Windows.Media.TranslateTransform(vector.X, vector.Y);
					this.OnShowInsertionPoint();
					base.LastDragInsertionPointOffset = new global::System.Windows.Vector(vector.X, vector.Y);
					this._currentFieldLabelDragElementInsertAtIndex = 0;
					return;
				}
			}
			else
			{
				bool flag = false;
				foreach (global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel2 in this.GroupedFieldLabels)
				{
					global::System.Windows.Rect rectInGroupByAreaCoordinates = groupByAreaFieldLabel2.RectInGroupByAreaCoordinates;
					if (dragPositionFlags.X < rectInGroupByAreaCoordinates.Left + rectInGroupByAreaCoordinates.Width / 2.0)
					{
						double num = base.InsertionPoint.ActualWidth;
						if (base.InsertionPoint is global::System.Windows.Shapes.Polygon)
						{
							num = ((global::System.Windows.Shapes.Polygon)base.InsertionPoint).RenderedGeometry.Bounds.Width - 3.0;
						}
						global::System.Windows.Vector vector2 = new global::System.Windows.Vector(rectInGroupByAreaCoordinates.X - num, y);
						if (vector2 != base.LastDragInsertionPointOffset)
						{
							if (base.LastDragInsertionPointOffset.X != double.PositiveInfinity)
							{
								this.OnHideInsertionPoint();
							}
							base.InsertionPoint.RenderTransform = new global::System.Windows.Media.TranslateTransform(vector2.X, vector2.Y);
							this.OnShowInsertionPoint();
							this._currentFieldLabelDragElementInsertAtIndex = this.GroupedFieldLabels.IndexOf(groupByAreaFieldLabel2);
							base.LastDragInsertionPointOffset = vector2;
						}
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					global::System.Windows.Rect rectInGroupByAreaCoordinates2 = this.GroupedFieldLabels[this.GroupedFieldLabels.Count - 1].RectInGroupByAreaCoordinates;
					global::System.Windows.Vector vector3 = new global::System.Windows.Vector(rectInGroupByAreaCoordinates2.X + rectInGroupByAreaCoordinates2.Width, y);
					if (vector3 != base.LastDragInsertionPointOffset)
					{
						if (base.LastDragInsertionPointOffset.X != double.PositiveInfinity)
						{
							this.OnHideInsertionPoint();
						}
						base.InsertionPoint.RenderTransform = new global::System.Windows.Media.TranslateTransform(vector3.X, vector3.Y);
						this.OnShowInsertionPoint();
						this._currentFieldLabelDragElementInsertAtIndex = this.GroupedFieldLabels.Count;
						base.LastDragInsertionPointOffset = vector3;
					}
				}
			}
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00097FBC File Offset: 0x000961BC
		private void OnGroupByAreaFieldLabelDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel = sender as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel;
			if (groupByAreaFieldLabel == null)
			{
				return;
			}
			global::System.Windows.Media.VisualBrush fill = new global::System.Windows.Media.VisualBrush(groupByAreaFieldLabel);
			base.CurrentFieldLabelDragElement.Fill = fill;
			base.CurrentFieldLabelDragElementTransform.X = 0.0;
			base.CurrentFieldLabelDragElementTransform.Y = 0.0;
			base.CurrentFieldLabelDragElement.Arrange(new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(new global::System.Windows.Point(0.0, 0.0), groupByAreaFieldLabel, this), new global::System.Windows.Size(groupByAreaFieldLabel.ActualWidth, groupByAreaFieldLabel.ActualHeight)));
			base.CurrentFieldLabelDragElement.Visibility = global::System.Windows.Visibility.Visible;
			groupByAreaFieldLabel.Opacity = 0.3;
			base.LastDragInsertionPointOffset = new global::System.Windows.Vector(double.PositiveInfinity, double.PositiveInfinity);
			this._currentFieldLabelDragElementStartOffset = new global::System.Windows.Vector(e.HorizontalOffset, e.VerticalOffset);
			this._currentFieldLabelDragElementInsertAtIndex = -1;
			base.IsDragInsertionPointHighlighted = false;
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaBase.FieldLabelDragInProgressPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000980BC File Offset: 0x000962BC
		private void OnGroupedFieldsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.GroupedFieldLabels.Count == 0 && this._lastGroupedFieldsCount > 0)
			{
				this.OnShowPrompts();
				this._lastGroupedFieldsCount = this.GroupedFieldLabels.Count;
				return;
			}
			if (this.GroupedFieldLabels.Count > 0 && this._lastGroupedFieldsCount == 0)
			{
				this.OnHidePrompts();
				this._lastGroupedFieldsCount = this.GroupedFieldLabels.Count;
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00098124 File Offset: 0x00096324
		private void OnSortedFieldsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._ignoreSortedFieldsChange)
			{
				if (!this.IsActive)
				{
					return;
				}
				this.RefreshAvailableFieldLabels(base.DataPresenter.DefaultFieldLayout, this.AvailableFieldLabels, true);
				this.RefreshGroupedFieldLabels(base.DataPresenter.DefaultFieldLayout, this.GroupedFieldLabels, true);
			}
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00098174 File Offset: 0x00096374
		private void RefreshAvailableFieldLabels(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection availableFieldLabels, bool notifyCollectionChanged)
		{
			global::System.Windows.Style defaultGroupByFieldLabelStyle = this.GetDefaultGroupByFieldLabelStyle();
			this.UnhookAllFieldLabelDragEventListeners(true, false);
			availableFieldLabels.InternalClear();
			if (fieldLayout != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
				{
					if (field.AllowGroupByResolved && field.IsVisibleInCellArea && !field.IsGroupBy)
					{
						global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel = this.CreateGroupByAreaFieldLabelFromField(field, defaultGroupByFieldLabelStyle, false);
						availableFieldLabels.InternalAdd(groupByAreaLabel);
					}
				}
			}
			if (notifyCollectionChanged)
			{
				availableFieldLabels.InternalReset();
			}
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00098208 File Offset: 0x00096408
		private void RefreshGroupedFieldLabels(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection groupedFieldLabels, bool notifyCollectionChanged)
		{
			global::System.Windows.Style defaultGroupByFieldLabelStyle = this.GetDefaultGroupByFieldLabelStyle();
			this.UnhookAllFieldLabelDragEventListeners(false, true);
			groupedFieldLabels.InternalClear();
			if (fieldLayout != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in fieldLayout.SortedFields)
				{
					if (fieldSortDescription.IsGroupBy)
					{
						groupedFieldLabels.InternalAdd(this.CreateGroupByAreaFieldLabelFromField(fieldSortDescription.Field, defaultGroupByFieldLabelStyle, true));
					}
				}
			}
			if (notifyCollectionChanged)
			{
				groupedFieldLabels.InternalReset();
			}
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0009828C File Offset: 0x0009648C
		private void ReinitializeAsync()
		{
			this._reinitializeOperation = null;
			if (!this.IsActive)
			{
				return;
			}
			this.OnFieldLayoutInitialized();
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000982A4 File Offset: 0x000964A4
		private void SetDragPositionFlags(global::System.Windows.Point pointInGroupByAreaCoords)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(new global::System.Windows.Point(0.0, 0.0), this._groupedFieldLabelsArea, this), new global::System.Windows.Size(this._groupedFieldLabelsArea.ActualWidth, this._groupedFieldLabelsArea.ActualHeight));
			this._isFieldLabelDragOverGroupedListArea = rect.Contains(pointInGroupByAreaCoords);
			global::System.Windows.Rect rect2 = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(new global::System.Windows.Point(0.0, 0.0), this._availableFieldLabelsArea, this), new global::System.Windows.Size(this._availableFieldLabelsArea.ActualWidth, this._availableFieldLabelsArea.ActualHeight));
			this._isFieldLabelDragOverAvailableListArea = rect2.Contains(pointInGroupByAreaCoords);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00098357 File Offset: 0x00096557
		private void UnhookFieldLabelDragEventListeners(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel)
		{
			groupByAreaFieldLabel.DragStarted -= this.OnGroupByAreaFieldLabelDragStarted;
			groupByAreaFieldLabel.DragDelta -= this.OnGroupByAreaFieldLabelDragDelta;
			groupByAreaFieldLabel.DragCompleted -= this.OnGroupByAreaFieldLabelDragCompleted;
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00098390 File Offset: 0x00096590
		private void UnhookAllFieldLabelDragEventListeners(bool unhookAvailableFieldLabels, bool unhookGroupedFieldLabels)
		{
			if (unhookAvailableFieldLabels)
			{
				foreach (global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel in this.AvailableFieldLabels)
				{
					this.UnhookFieldLabelDragEventListeners(groupByAreaFieldLabel);
				}
			}
			if (unhookGroupedFieldLabels)
			{
				foreach (global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel2 in this.GroupedFieldLabels)
				{
					this.UnhookFieldLabelDragEventListeners(groupByAreaFieldLabel2);
				}
			}
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00098420 File Offset: 0x00096620
		private void VerifyAvailableFieldLabelsArea()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_AvailableFieldLabelsArea");
			if (templateChild == null)
			{
				return;
			}
			global::System.Windows.FrameworkElement frameworkElement = templateChild as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_4", new object[]
				{
					"FrameworkElement",
					"PART_AvailableFieldLabelsArea",
					"GroupByArea",
					templateChild.GetType().Name
				}));
			}
			this._availableFieldLabelsArea = frameworkElement;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0009848C File Offset: 0x0009668C
		private void VerifyGroupedFieldLabelsArea()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_GroupedFieldLabelsArea");
			if (templateChild == null)
			{
				return;
			}
			global::System.Windows.FrameworkElement frameworkElement = templateChild as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_4", new object[]
				{
					"FrameworkElement",
					"PART_GroupedFieldLabelsArea",
					"GroupByArea",
					templateChild.GetType().Name
				}));
			}
			this._groupedFieldLabelsArea = frameworkElement;
		}

		// Token: 0x040010E1 RID: 4321
		private global::System.Windows.FrameworkElement _groupedFieldLabelsArea;

		// Token: 0x040010E2 RID: 4322
		private global::System.Windows.FrameworkElement _availableFieldLabelsArea;

		// Token: 0x040010E3 RID: 4323
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayoutWired;

		// Token: 0x040010E4 RID: 4324
		private int _currentFieldLabelDragElementInsertAtIndex = -1;

		// Token: 0x040010E5 RID: 4325
		private global::System.Windows.Vector _currentFieldLabelDragElementStartOffset;

		// Token: 0x040010E6 RID: 4326
		private bool _isFieldLabelDragOverGroupedListArea;

		// Token: 0x040010E7 RID: 4327
		private bool _isFieldLabelDragOverAvailableListArea;

		// Token: 0x040010E8 RID: 4328
		private bool _ignoreSortedFieldsChange;

		// Token: 0x040010E9 RID: 4329
		private int _lastGroupedFieldsCount;

		// Token: 0x040010EA RID: 4330
		private global::System.Windows.Threading.DispatcherOperation _reinitializeOperation;

		// Token: 0x040010EB RID: 4331
		private static readonly global::System.Windows.DependencyPropertyKey AvailableFieldLabelsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AvailableFieldLabels", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection), typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040010EC RID: 4332
		public static readonly global::System.Windows.DependencyProperty AvailableFieldLabelsProperty = global::Infragistics.Windows.DataPresenter.GroupByArea.AvailableFieldLabelsPropertyKey.DependencyProperty;

		// Token: 0x040010ED RID: 4333
		private static readonly global::System.Windows.DependencyPropertyKey GroupedFieldLabelsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("GroupedFieldLabels", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection), typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x040010EE RID: 4334
		public static readonly global::System.Windows.DependencyProperty GroupedFieldLabelsProperty = global::Infragistics.Windows.DataPresenter.GroupByArea.GroupedFieldLabelsPropertyKey.DependencyProperty;

		// Token: 0x040010EF RID: 4335
		public static readonly global::System.Windows.DependencyProperty FieldLayoutTemplateVersionProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutTemplateVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByArea.OnFieldLayoutTemplateVersionChanged)));
	}
}
