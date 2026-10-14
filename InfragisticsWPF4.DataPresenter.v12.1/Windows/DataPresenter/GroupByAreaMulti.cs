using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Automation.Peers.DataPresenter;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000163 RID: 355
	[global::System.Windows.TemplatePart(Name = "PART_InsertionPoint", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.StyleTypedProperty(Property = "FieldLayoutDescriptionTemplate", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByAreaMulti : global::Infragistics.Windows.DataPresenter.GroupByAreaBase
	{
		// Token: 0x060014D0 RID: 5328 RVA: 0x0005F008 File Offset: 0x0005D208
		static GroupByAreaMulti()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti)));
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0005F440 File Offset: 0x0005D640
		public GroupByAreaMulti() : base(null)
		{
			base.IsExpanded = true;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0005F450 File Offset: 0x0005D650
		internal override void InitializeDataPresenter(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			base.InitializeDataPresenter(dataPresenter);
			if (dataPresenter == null)
			{
				if (this._fieldLayoutInfos != null)
				{
					this._fieldLayoutInfos.Clear();
				}
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OverallSortVersionProperty);
				return;
			}
			base.SetBinding(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OverallSortVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OverallSortVersionProperty, global::System.Windows.Data.BindingMode.OneWay, dataPresenter));
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0005F49E File Offset: 0x0005D69E
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaMultiAutomationPeer(this);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0005F4A6 File Offset: 0x0005D6A6
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.SynchronizeFieldLayouts(true);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0005F4B5 File Offset: 0x0005D6B5
		internal override void OnStyleVersionNumberChanged()
		{
			base.OnStyleVersionNumberChanged();
			this.SynchronizeFieldLayouts(false);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0005F4C4 File Offset: 0x0005D6C4
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			base.OnVisualParentChanged(oldParent);
			if (global::System.Windows.Media.VisualTreeHelper.GetParent(this) == null)
			{
				this.ClearFieldLayoutInfo();
				return;
			}
			if (base.IsInitialized)
			{
				this.SynchronizeFieldLayouts(false);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0005F4EB File Offset: 0x0005D6EB
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0005F4FD File Offset: 0x0005D6FD
		public global::System.Windows.Media.Pen ConnectorLinePen
		{
			get
			{
				return (global::System.Windows.Media.Pen)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ConnectorLinePenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ConnectorLinePenProperty, value);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0005F50B File Offset: 0x0005D70B
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0005F51D File Offset: 0x0005D71D
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate FieldLayoutDescriptionTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutDescriptionTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutDescriptionTemplateProperty, value);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0005F52B File Offset: 0x0005D72B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfoCollection FieldLayoutGroupByInfos
		{
			get
			{
				if (this._fieldLayoutInfos == null)
				{
					this._fieldLayoutInfos = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo>();
					this._readOnlyFieldLayoutInfos = new global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfoCollection(this._fieldLayoutInfos);
				}
				return this._readOnlyFieldLayoutInfos;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0005F557 File Offset: 0x0005D757
		public global::System.Windows.Controls.Orientation FieldLayoutOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOrientationProperty);
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0005F56C File Offset: 0x0005D76C
		private static object CoerceFieldLayoutOffsetX(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null && double.IsNaN((double)value))
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = groupByAreaMulti.DataPresenter;
				if (dataPresenter != null)
				{
					if (dataPresenter.GroupByAreaMode == global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsCompact)
					{
						return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldLayoutOffsetXCompact;
					}
					return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldLayoutOffsetXFull;
				}
			}
			return value;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
		private static void OnFieldLayoutOffsetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null)
			{
				groupByAreaMulti.CalculateOffsets();
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0005F5CD File Offset: 0x0005D7CD
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0005F5DF File Offset: 0x0005D7DF
		public double FieldLayoutOffsetX
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOffsetXProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOffsetXProperty, value);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005F5F4 File Offset: 0x0005D7F4
		private static object CoerceFieldLayoutOffsetY(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null && double.IsNaN((double)value))
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = groupByAreaMulti.DataPresenter;
				if (dataPresenter != null)
				{
					if (dataPresenter.GroupByAreaMode == global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsCompact)
					{
						return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldLayoutOffsetYCompact;
					}
					return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldLayoutOffsetYFull;
				}
			}
			return value;
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0005F638 File Offset: 0x0005D838
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x0005F64A File Offset: 0x0005D84A
		public double FieldLayoutOffsetY
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOffsetYProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOffsetYProperty, value);
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005F660 File Offset: 0x0005D860
		private static object CoerceFieldOffsetX(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null && double.IsNaN((double)value))
			{
				return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldOffsetX;
			}
			return value;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0005F68C File Offset: 0x0005D88C
		private static void OnFieldOffsetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null)
			{
				groupByAreaMulti.CalculateOffsets();
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0005F6A9 File Offset: 0x0005D8A9
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x0005F6BB File Offset: 0x0005D8BB
		public double FieldOffsetX
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldOffsetXProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldOffsetXProperty, value);
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0005F6D0 File Offset: 0x0005D8D0
		private static object CoerceFieldOffsetY(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null && double.IsNaN((double)value))
			{
				return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldOffsetY;
			}
			return value;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0005F6FB File Offset: 0x0005D8FB
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x0005F70D File Offset: 0x0005D90D
		public double FieldOffsetY
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldOffsetYProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldOffsetYProperty, value);
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0005F720 File Offset: 0x0005D920
		public static bool GetHasOffsetX(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXProperty);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0005F732 File Offset: 0x0005D932
		public static bool GetHasOffsetY(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYProperty);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0005F744 File Offset: 0x0005D944
		public static bool GetIsConnectorLineTarget(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsConnectorLineTargetProperty);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0005F756 File Offset: 0x0005D956
		public static void SetIsConnectorLineTarget(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsConnectorLineTargetProperty, value);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0005F769 File Offset: 0x0005D969
		public static bool GetIsFirstInList(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListProperty);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0005F77B File Offset: 0x0005D97B
		public static bool GetIsLastInList(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListProperty);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0005F78D File Offset: 0x0005D98D
		public static global::System.Windows.Thickness GetOffset(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Thickness)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OffsetProperty);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0005F79F File Offset: 0x0005D99F
		private static void OnOverallSortVersionChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.GroupByAreaMulti)target).SynchronizeFieldLayouts(false);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0005F7B0 File Offset: 0x0005D9B0
		private void CalculateOffsets()
		{
			if (base.DataPresenter == null)
			{
				return;
			}
			int num = (this._fieldLayoutInfos != null) ? this._fieldLayoutInfos.Count : 0;
			if (num == 0)
			{
				return;
			}
			bool flag = this.FieldLayoutOrientation == global::System.Windows.Controls.Orientation.Vertical;
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOffsetXProperty);
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOffsetYProperty);
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldOffsetXProperty);
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldOffsetYProperty);
			double fieldOffsetX = this.FieldOffsetX;
			double fieldOffsetY = this.FieldOffsetY;
			double fieldLayoutOffsetX = this.FieldLayoutOffsetX;
			double fieldLayoutOffsetY = this.FieldLayoutOffsetY;
			bool hasOffset = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.GetHasOffset(fieldOffsetX);
			bool hasOffset2 = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.GetHasOffset(fieldOffsetY);
			bool hasOffset3 = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.GetHasOffset(fieldLayoutOffsetX);
			bool hasOffset4 = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.GetHasOffset(fieldLayoutOffsetY);
			double num2 = 0.0;
			for (int i = 0; i < num; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo = this._fieldLayoutInfos[i];
				double left = (i == 0) ? 0.0 : (flag ? (fieldLayoutOffsetX * (double)fieldLayoutGroupByInfo.FieldLayout.NestingDepth) : fieldLayoutOffsetX);
				double num3 = num2;
				if (i > 0)
				{
					num3 += fieldLayoutOffsetY;
				}
				fieldLayoutGroupByInfo.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OffsetPropertyKey, new global::System.Windows.Thickness(left, num3, 0.0, 0.0));
				if (i == 0)
				{
					fieldLayoutGroupByInfo.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					fieldLayoutGroupByInfo.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey);
				}
				if (i == num - 1)
				{
					fieldLayoutGroupByInfo.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					fieldLayoutGroupByInfo.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey);
				}
				if (hasOffset3)
				{
					fieldLayoutGroupByInfo.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					fieldLayoutGroupByInfo.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXPropertyKey);
				}
				if (hasOffset4)
				{
					fieldLayoutGroupByInfo.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					fieldLayoutGroupByInfo.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYPropertyKey);
				}
				if (!flag)
				{
					num2 = num3;
				}
				left = fieldOffsetX;
				num3 = 0.0;
				int count = fieldLayoutGroupByInfo.GroupByFields.Count;
				for (int j = 0; j < count; j++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldLayoutGroupByInfo.GroupByFields[j];
					field.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OffsetPropertyKey, new global::System.Windows.Thickness(left, num3, 0.0, 0.0));
					if (hasOffset)
					{
						field.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						field.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXPropertyKey);
					}
					if (hasOffset2)
					{
						field.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						field.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYPropertyKey);
					}
					num3 += fieldOffsetY;
					left = fieldOffsetX;
				}
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0005FA44 File Offset: 0x0005DC44
		private void ClearFieldLayoutInfo()
		{
			if (this._fieldLayoutInfos == null || this._fieldLayoutInfos.Count == 0)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo in this._fieldLayoutInfos)
			{
				fieldLayoutGroupByInfo.InitializeFieldLayout(null, false);
			}
			this._fieldLayoutInfos.Clear();
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0005FAB4 File Offset: 0x0005DCB4
		private static int CompareFieldLayouts(global::Infragistics.Windows.DataPresenter.FieldLayout x, global::Infragistics.Windows.DataPresenter.FieldLayout y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout rootFieldLayout = x.RootFieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayout rootFieldLayout2 = y.RootFieldLayout;
			if (rootFieldLayout != rootFieldLayout2)
			{
				if (rootFieldLayout.Index >= rootFieldLayout2.Index)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (x == rootFieldLayout)
				{
					return -1;
				}
				if (y == rootFieldLayout2)
				{
					return 1;
				}
				int nestingDepth;
				int num = nestingDepth = x.NestingDepth;
				int nestingDepth2;
				int num2 = nestingDepth2 = y.NestingDepth;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = x;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = y;
				while (fieldLayout2 != null && fieldLayout != null && fieldLayout.ParentFieldLayout != fieldLayout2.ParentFieldLayout)
				{
					if (num < num2)
					{
						fieldLayout2 = fieldLayout2.ParentFieldLayout;
						num2--;
					}
					else
					{
						fieldLayout = fieldLayout.ParentFieldLayout;
						num--;
					}
				}
				if (fieldLayout == null)
				{
					return -1;
				}
				if (fieldLayout2 == null)
				{
					return 1;
				}
				global::Infragistics.Windows.DataPresenter.Field parentField = fieldLayout.ParentField;
				global::Infragistics.Windows.DataPresenter.Field parentField2 = fieldLayout2.ParentField;
				if (parentField == null || parentField2 == null || parentField == parentField2)
				{
					if (nestingDepth != nestingDepth2)
					{
						if (nestingDepth >= nestingDepth2)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						if (fieldLayout.Index >= fieldLayout2.Index)
						{
							return 1;
						}
						return -1;
					}
				}
				else
				{
					if (parentField.Index >= parentField2.Index)
					{
						return 1;
					}
					return -1;
				}
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0005FBB9 File Offset: 0x0005DDB9
		private static bool GetHasOffset(double value)
		{
			return value < -0.5 || value > 0.5;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0005FBD8 File Offset: 0x0005DDD8
		private void SynchronizeFieldLayouts(bool calledFromApplyTemplate)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter == null || !dataPresenter.IsInitialized)
			{
				return;
			}
			switch (dataPresenter.GroupByAreaMode)
			{
			case global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsCompact:
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOrientationPropertyKey, global::Infragistics.KnownBoxes.OrientationHorizontalBox);
				goto IL_59;
			case global::Infragistics.Windows.DataPresenter.GroupByAreaMode.DefaultFieldLayoutOnly:
				this.ClearFieldLayoutInfo();
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOrientationPropertyKey, global::Infragistics.KnownBoxes.OrientationVerticalBox);
			IL_59:
			bool flag = dataPresenter.GroupByAreaMode == global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsCompact;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>();
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = dataPresenter.DefaultFieldLayout;
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in dataPresenter.FieldLayouts)
			{
				bool flag2 = false;
				if (fieldLayout.ParentFieldLayoutKey == null)
				{
					flag2 = (fieldLayout.IsInitialRecordLoaded || fieldLayout == defaultFieldLayout);
				}
				else
				{
					bool hasGroupBySortFields = fieldLayout.HasGroupBySortFields;
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = fieldLayout.ParentFieldLayout;
					global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.FieldLayout> stack = hasGroupBySortFields ? new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.FieldLayout>() : null;
					while (fieldLayout2 != null)
					{
						if (!hasGroupBySortFields)
						{
							hasGroupBySortFields = fieldLayout2.HasGroupBySortFields;
							stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.FieldLayout>();
						}
						if (hasGroupBySortFields)
						{
							stack.Push(fieldLayout2);
						}
						global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = fieldLayout2.ParentFieldLayout;
						if (parentFieldLayout == null)
						{
							flag2 = (fieldLayout2 == defaultFieldLayout || (fieldLayout2.IsInitialRecordLoaded && fieldLayout2.ParentFieldLayoutKey == null));
							break;
						}
						fieldLayout2 = parentFieldLayout;
					}
					if (flag2 && stack != null && !flag)
					{
						while (stack.Count > 0)
						{
							fieldLayout2 = stack.Pop();
							if (!list.Contains(fieldLayout2))
							{
								list.Add(fieldLayout2);
							}
						}
					}
				}
				if (flag2 && fieldLayout.HasGroupBySortFields && !list.Contains(fieldLayout))
				{
					list.Add(fieldLayout);
				}
			}
			int count = list.Count;
			int count2 = this.FieldLayoutGroupByInfos.Count;
			list.Sort(new global::System.Comparison<global::Infragistics.Windows.DataPresenter.FieldLayout>(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CompareFieldLayouts));
			if (count == count2)
			{
				bool flag3 = true;
				for (int i = 0; i < count; i++)
				{
					if (list[i] != this._fieldLayoutInfos[i].FieldLayout)
					{
						flag3 = false;
						break;
					}
				}
				if (flag3)
				{
					foreach (global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo in this.FieldLayoutGroupByInfos)
					{
						fieldLayoutGroupByInfo.SynchronizeGroupByFields(false);
					}
					this.CalculateOffsets();
					if (calledFromApplyTemplate && count2 != 0)
					{
						this.OnHidePrompts();
					}
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo[] array = (count2 > 0) ? new global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo[count2] : null;
			if (array != null)
			{
				this._fieldLayoutInfos.CopyTo(array, 0);
			}
			this._fieldLayoutInfos.BeginUpdate();
			this._fieldLayoutInfos.Clear();
			for (int j = 0; j < count; j++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout3 = list[j];
				global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo2 = null;
				for (int k = 0; k < count2; k++)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo fieldLayoutGroupByInfo3 = array[k];
					if (fieldLayoutGroupByInfo3 != null && fieldLayout3 == fieldLayoutGroupByInfo3.FieldLayout)
					{
						fieldLayoutGroupByInfo2 = fieldLayoutGroupByInfo3;
						array[k] = null;
						break;
					}
				}
				if (fieldLayoutGroupByInfo2 == null)
				{
					fieldLayoutGroupByInfo2 = new global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo();
					global::System.Windows.Data.BindingOperations.SetBinding(fieldLayoutGroupByInfo2, global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionTemplateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutDescriptionTemplateProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				}
				fieldLayoutGroupByInfo2.InitializeFieldLayout(fieldLayout3, count > 1 || fieldLayout3.ParentFieldLayout != null);
				this._fieldLayoutInfos.Add(fieldLayoutGroupByInfo2);
			}
			this.CalculateOffsets();
			this._fieldLayoutInfos.EndUpdate();
			if (!calledFromApplyTemplate)
			{
				if (count2 == 0)
				{
					if (this._fieldLayoutInfos.Count > 0)
					{
						this.OnHidePrompts();
						return;
					}
				}
				else if (this._fieldLayoutInfos.Count == 0)
				{
					this.OnShowPrompts();
				}
				return;
			}
			if (this._fieldLayoutInfos.Count == 0)
			{
				this.OnShowPrompts();
				return;
			}
			this.OnHidePrompts();
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0005FF9C File Offset: 0x0005E19C
		private static bool ValidateOffset(object value)
		{
			if (!(value is double))
			{
				return false;
			}
			double num = (double)value;
			if (double.IsNaN(num))
			{
				return true;
			}
			if (double.IsInfinity(num) || double.IsPositiveInfinity(num) || double.IsNegativeInfinity(num))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(num);
			return true;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0005FFE8 File Offset: 0x0005E1E8
		private static bool ValidateOffsetAllowNegative(object value)
		{
			if (!(value is double))
			{
				return false;
			}
			double d = (double)value;
			return double.IsNaN(d) || (!double.IsInfinity(d) && !double.IsPositiveInfinity(d) && !double.IsNegativeInfinity(d));
		}

		// Token: 0x04000840 RID: 2112
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo> _fieldLayoutInfos;

		// Token: 0x04000841 RID: 2113
		private global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfoCollection _readOnlyFieldLayoutInfos;

		// Token: 0x04000842 RID: 2114
		private static readonly object DefaultFieldLayoutOffsetXFull = 24.0;

		// Token: 0x04000843 RID: 2115
		private static readonly object DefaultFieldLayoutOffsetXCompact = 6.0;

		// Token: 0x04000844 RID: 2116
		private static readonly object DefaultFieldLayoutOffsetYFull = 2.0;

		// Token: 0x04000845 RID: 2117
		private static readonly object DefaultFieldLayoutOffsetYCompact = 0.0;

		// Token: 0x04000846 RID: 2118
		private static readonly object DefaultFieldOffsetX = 6.0;

		// Token: 0x04000847 RID: 2119
		private static readonly object DefaultFieldOffsetY = 0.0;

		// Token: 0x04000848 RID: 2120
		public static readonly global::System.Windows.DependencyProperty ConnectorLinePenProperty = global::System.Windows.DependencyProperty.Register("ConnectorLinePen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000849 RID: 2121
		public static readonly global::System.Windows.DependencyProperty FieldLayoutDescriptionTemplateProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutDescriptionTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400084A RID: 2122
		private static readonly global::System.Windows.DependencyPropertyKey FieldLayoutOrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLayoutOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationHorizontalBox));

		// Token: 0x0400084B RID: 2123
		public static readonly global::System.Windows.DependencyProperty FieldLayoutOrientationProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOrientationPropertyKey.DependencyProperty;

		// Token: 0x0400084C RID: 2124
		public static readonly global::System.Windows.DependencyProperty FieldLayoutOffsetXProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutOffsetX", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldLayoutOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldLayoutOffsetX)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffsetAllowNegative));

		// Token: 0x0400084D RID: 2125
		public static readonly global::System.Windows.DependencyProperty FieldLayoutOffsetYProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutOffsetY", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldLayoutOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldLayoutOffsetY)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffset));

		// Token: 0x0400084E RID: 2126
		public static readonly global::System.Windows.DependencyProperty FieldOffsetXProperty = global::System.Windows.DependencyProperty.Register("FieldOffsetX", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldOffsetX)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffsetAllowNegative));

		// Token: 0x0400084F RID: 2127
		public static readonly global::System.Windows.DependencyProperty FieldOffsetYProperty = global::System.Windows.DependencyProperty.Register("FieldOffsetY", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldOffsetY)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffset));

		// Token: 0x04000850 RID: 2128
		private static readonly global::System.Windows.DependencyPropertyKey HasOffsetXPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("HasOffsetX", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000851 RID: 2129
		public static readonly global::System.Windows.DependencyProperty HasOffsetXProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXPropertyKey.DependencyProperty;

		// Token: 0x04000852 RID: 2130
		private static readonly global::System.Windows.DependencyPropertyKey HasOffsetYPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("HasOffsetY", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000853 RID: 2131
		public static readonly global::System.Windows.DependencyProperty HasOffsetYProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYPropertyKey.DependencyProperty;

		// Token: 0x04000854 RID: 2132
		public static readonly global::System.Windows.DependencyProperty IsConnectorLineTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsConnectorLineTarget", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000855 RID: 2133
		internal static readonly global::System.Windows.DependencyPropertyKey IsFirstInListPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFirstInList", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000856 RID: 2134
		public static readonly global::System.Windows.DependencyProperty IsFirstInListProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey.DependencyProperty;

		// Token: 0x04000857 RID: 2135
		internal static readonly global::System.Windows.DependencyPropertyKey IsLastInListPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsLastInList", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000858 RID: 2136
		public static readonly global::System.Windows.DependencyProperty IsLastInListProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey.DependencyProperty;

		// Token: 0x04000859 RID: 2137
		private static readonly global::System.Windows.DependencyPropertyKey OffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Offset", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));

		// Token: 0x0400085A RID: 2138
		public static readonly global::System.Windows.DependencyProperty OffsetProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OffsetPropertyKey.DependencyProperty;

		// Token: 0x0400085B RID: 2139
		internal static readonly global::System.Windows.DependencyProperty OverallSortVersionProperty = global::System.Windows.DependencyProperty.Register("OverallSortVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnOverallSortVersionChanged)));
	}
}
