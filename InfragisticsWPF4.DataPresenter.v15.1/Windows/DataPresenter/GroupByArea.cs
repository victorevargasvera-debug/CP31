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
	// Token: 0x02000316 RID: 790
	[global::System.Windows.TemplatePart(Name = "PART_AvailableFieldLabelsArea", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_GroupedFieldLabelsArea", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_InsertionPoint", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByArea : global::Infragistics.Windows.DataPresenter.GroupByAreaBase
	{
		// Token: 0x06002651 RID: 9809 RVA: 0x000AABEC File Offset: 0x000A8DEC
		static GroupByArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByArea)));
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000AACC4 File Offset: 0x000A8EC4
		public GroupByArea() : this(null)
		{
			base.IsExpanded = true;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000AACD4 File Offset: 0x000A8ED4
		internal GroupByArea(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000AACE4 File Offset: 0x000A8EE4
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyAvailableFieldLabelsArea();
			this.VerifyGroupedFieldLabelsArea();
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000AACF8 File Offset: 0x000A8EF8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaAutomationPeer(this);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000AAD00 File Offset: 0x000A8F00
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

		// Token: 0x06002657 RID: 9815 RVA: 0x000AADBE File Offset: 0x000A8FBE
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			if (this._reinitializeOperation == null)
			{
				this._reinitializeOperation = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ReinitializeAsync));
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x000AADEE File Offset: 0x000A8FEE
		public global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection AvailableFieldLabels
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.AvailableFieldLabelsProperty) as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000AAE00 File Offset: 0x000A9000
		public global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection GroupedFieldLabels
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByArea.GroupedFieldLabelsProperty) as global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection;
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000AAE12 File Offset: 0x000A9012
		internal global::System.Windows.Style GetDefaultGroupByFieldLabelStyle()
		{
			return base.TryFindResource(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)) as global::System.Windows.Style;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000AAE2C File Offset: 0x000A902C
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

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000AAE79 File Offset: 0x000A9079
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x000AAE8B File Offset: 0x000A908B
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000AAE9E File Offset: 0x000A909E
		private bool IsActive
		{
			get
			{
				return global::System.Windows.Media.VisualTreeHelper.GetParent(this) != null;
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000AAEAC File Offset: 0x000A90AC
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

		// Token: 0x06002660 RID: 9824 RVA: 0x000AAF48 File Offset: 0x000A9148
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

		// Token: 0x06002661 RID: 9825 RVA: 0x000AAFA0 File Offset: 0x000A91A0
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

		// Token: 0x06002662 RID: 9826 RVA: 0x000AB00C File Offset: 0x000A920C
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

		// Token: 0x06002663 RID: 9827 RVA: 0x000AB090 File Offset: 0x000A9290
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

		// Token: 0x06002664 RID: 9828 RVA: 0x000AB1A1 File Offset: 0x000A93A1
		private void OnExpanderBarAreaMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.IsExpanded = !base.IsExpanded;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000AB1B4 File Offset: 0x000A93B4
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
			bool flag5 = false;
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
									flag5 = true;
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
							flag5 = true;
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
							flag5 = true;
							if (groupingHelper.SortedFields.Count <= 0)
							{
								goto IL_2F8;
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
								goto IL_2F8;
							}
						}
						if (!groupByAreaFieldLabel.Field.IsGroupBy)
						{
							flag4 = true;
						}
					}
					IL_2F8:;
				}
			}
			finally
			{
				this._ignoreSortedFieldsChange = false;
				groupByAreaFieldLabel.Opacity = 1.0;
				if (!flag4 && flag5)
				{
					groupingHelper.RaiseGroupedEventHelper();
				}
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000AB518 File Offset: 0x000A9718
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

		// Token: 0x06002667 RID: 9831 RVA: 0x000AB83C File Offset: 0x000A9A3C
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
			this.SetDragPositionFlags(global::System.Windows.Input.Mouse.GetPosition(this));
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000AB948 File Offset: 0x000A9B48
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

		// Token: 0x06002669 RID: 9833 RVA: 0x000AB9B0 File Offset: 0x000A9BB0
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

		// Token: 0x0600266A RID: 9834 RVA: 0x000ABA00 File Offset: 0x000A9C00
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

		// Token: 0x0600266B RID: 9835 RVA: 0x000ABA94 File Offset: 0x000A9C94
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

		// Token: 0x0600266C RID: 9836 RVA: 0x000ABB18 File Offset: 0x000A9D18
		private void ReinitializeAsync()
		{
			this._reinitializeOperation = null;
			if (!this.IsActive)
			{
				return;
			}
			this.OnFieldLayoutInitialized();
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000ABB30 File Offset: 0x000A9D30
		private void SetDragPositionFlags(global::System.Windows.Point pointInGroupByAreaCoords)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(new global::System.Windows.Point(0.0, 0.0), this._groupedFieldLabelsArea, this), new global::System.Windows.Size(this._groupedFieldLabelsArea.ActualWidth, this._groupedFieldLabelsArea.ActualHeight));
			this._isFieldLabelDragOverGroupedListArea = rect.Contains(pointInGroupByAreaCoords);
			global::System.Windows.Rect rect2 = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.TransformPointToAncestorCoordinates(new global::System.Windows.Point(0.0, 0.0), this._availableFieldLabelsArea, this), new global::System.Windows.Size(this._availableFieldLabelsArea.ActualWidth, this._availableFieldLabelsArea.ActualHeight));
			this._isFieldLabelDragOverAvailableListArea = rect2.Contains(pointInGroupByAreaCoords);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x000ABBE3 File Offset: 0x000A9DE3
		private void UnhookFieldLabelDragEventListeners(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaFieldLabel)
		{
			groupByAreaFieldLabel.DragStarted -= this.OnGroupByAreaFieldLabelDragStarted;
			groupByAreaFieldLabel.DragDelta -= this.OnGroupByAreaFieldLabelDragDelta;
			groupByAreaFieldLabel.DragCompleted -= this.OnGroupByAreaFieldLabelDragCompleted;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000ABC1C File Offset: 0x000A9E1C
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

		// Token: 0x06002670 RID: 9840 RVA: 0x000ABCAC File Offset: 0x000A9EAC
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

		// Token: 0x06002671 RID: 9841 RVA: 0x000ABD18 File Offset: 0x000A9F18
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

		// Token: 0x040012FA RID: 4858
		private global::System.Windows.FrameworkElement _groupedFieldLabelsArea;

		// Token: 0x040012FB RID: 4859
		private global::System.Windows.FrameworkElement _availableFieldLabelsArea;

		// Token: 0x040012FC RID: 4860
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayoutWired;

		// Token: 0x040012FD RID: 4861
		private int _currentFieldLabelDragElementInsertAtIndex = -1;

		// Token: 0x040012FE RID: 4862
		private global::System.Windows.Vector _currentFieldLabelDragElementStartOffset;

		// Token: 0x040012FF RID: 4863
		private bool _isFieldLabelDragOverGroupedListArea;

		// Token: 0x04001300 RID: 4864
		private bool _isFieldLabelDragOverAvailableListArea;

		// Token: 0x04001301 RID: 4865
		private bool _ignoreSortedFieldsChange;

		// Token: 0x04001302 RID: 4866
		private int _lastGroupedFieldsCount;

		// Token: 0x04001303 RID: 4867
		private global::System.Windows.Threading.DispatcherOperation _reinitializeOperation;

		// Token: 0x04001304 RID: 4868
		private static readonly global::System.Windows.DependencyPropertyKey AvailableFieldLabelsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AvailableFieldLabels", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection), typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04001305 RID: 4869
		public static readonly global::System.Windows.DependencyProperty AvailableFieldLabelsProperty = global::Infragistics.Windows.DataPresenter.GroupByArea.AvailableFieldLabelsPropertyKey.DependencyProperty;

		// Token: 0x04001306 RID: 4870
		private static readonly global::System.Windows.DependencyPropertyKey GroupedFieldLabelsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("GroupedFieldLabels", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection), typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04001307 RID: 4871
		public static readonly global::System.Windows.DependencyProperty GroupedFieldLabelsProperty = global::Infragistics.Windows.DataPresenter.GroupByArea.GroupedFieldLabelsPropertyKey.DependencyProperty;

		// Token: 0x04001308 RID: 4872
		public static readonly global::System.Windows.DependencyProperty FieldLayoutTemplateVersionProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutTemplateVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByArea.OnFieldLayoutTemplateVersionChanged)));
	}
}
