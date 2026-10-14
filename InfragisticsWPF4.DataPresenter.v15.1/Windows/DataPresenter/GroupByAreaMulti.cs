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
	// Token: 0x0200017F RID: 383
	[global::System.Windows.StyleTypedProperty(Property = "FieldLayoutDescriptionTemplate", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_InsertionPoint", Type = typeof(global::System.Windows.FrameworkElement))]
	public class GroupByAreaMulti : global::Infragistics.Windows.DataPresenter.GroupByAreaBase
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x00070FAC File Offset: 0x0006F1AC
		static GroupByAreaMulti()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti)));
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000713E4 File Offset: 0x0006F5E4
		public GroupByAreaMulti() : base(null)
		{
			base.IsExpanded = true;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000713F4 File Offset: 0x0006F5F4
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

		// Token: 0x0600184C RID: 6220 RVA: 0x00071442 File Offset: 0x0006F642
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaMultiAutomationPeer(this);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0007144A File Offset: 0x0006F64A
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.SynchronizeFieldLayouts(true);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00071459 File Offset: 0x0006F659
		internal override void OnStyleVersionNumberChanged()
		{
			base.OnStyleVersionNumberChanged();
			this.SynchronizeFieldLayouts(false);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00071468 File Offset: 0x0006F668
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

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0007148F File Offset: 0x0006F68F
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x000714A1 File Offset: 0x0006F6A1
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x000714AF File Offset: 0x0006F6AF
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x000714C1 File Offset: 0x0006F6C1
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x000714CF File Offset: 0x0006F6CF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x000714FB File Offset: 0x0006F6FB
		public global::System.Windows.Controls.Orientation FieldLayoutOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOrientationProperty);
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00071510 File Offset: 0x0006F710
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

		// Token: 0x06001857 RID: 6231 RVA: 0x00071554 File Offset: 0x0006F754
		private static void OnFieldLayoutOffsetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null)
			{
				groupByAreaMulti.CalculateOffsets();
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00071571 File Offset: 0x0006F771
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00071583 File Offset: 0x0006F783
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

		// Token: 0x0600185A RID: 6234 RVA: 0x00071598 File Offset: 0x0006F798
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x000715DC File Offset: 0x0006F7DC
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x000715EE File Offset: 0x0006F7EE
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

		// Token: 0x0600185D RID: 6237 RVA: 0x00071604 File Offset: 0x0006F804
		private static object CoerceFieldOffsetX(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null && double.IsNaN((double)value))
			{
				return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldOffsetX;
			}
			return value;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00071630 File Offset: 0x0006F830
		private static void OnFieldOffsetChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null)
			{
				groupByAreaMulti.CalculateOffsets();
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0007164D File Offset: 0x0006F84D
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x0007165F File Offset: 0x0006F85F
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

		// Token: 0x06001861 RID: 6241 RVA: 0x00071674 File Offset: 0x0006F874
		private static object CoerceFieldOffsetY(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = target as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
			if (groupByAreaMulti != null && double.IsNaN((double)value))
			{
				return global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.DefaultFieldOffsetY;
			}
			return value;
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x0007169F File Offset: 0x0006F89F
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x000716B1 File Offset: 0x0006F8B1
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

		// Token: 0x06001864 RID: 6244 RVA: 0x000716C4 File Offset: 0x0006F8C4
		public static bool GetHasOffsetX(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXProperty);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000716D6 File Offset: 0x0006F8D6
		public static bool GetHasOffsetY(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYProperty);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000716E8 File Offset: 0x0006F8E8
		public static bool GetIsConnectorLineTarget(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsConnectorLineTargetProperty);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000716FA File Offset: 0x0006F8FA
		public static void SetIsConnectorLineTarget(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsConnectorLineTargetProperty, value);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0007170D File Offset: 0x0006F90D
		public static bool GetIsFirstInList(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListProperty);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0007171F File Offset: 0x0006F91F
		public static bool GetIsLastInList(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListProperty);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00071731 File Offset: 0x0006F931
		public static global::System.Windows.Thickness GetOffset(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Thickness)d.GetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OffsetProperty);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00071743 File Offset: 0x0006F943
		private static void OnOverallSortVersionChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.GroupByAreaMulti)target).SynchronizeFieldLayouts(false);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00071754 File Offset: 0x0006F954
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

		// Token: 0x0600186D RID: 6253 RVA: 0x000719E8 File Offset: 0x0006FBE8
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

		// Token: 0x0600186E RID: 6254 RVA: 0x00071A58 File Offset: 0x0006FC58
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

		// Token: 0x0600186F RID: 6255 RVA: 0x00071B5D File Offset: 0x0006FD5D
		private static bool GetHasOffset(double value)
		{
			return value < -0.5 || value > 0.5;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00071B7C File Offset: 0x0006FD7C
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

		// Token: 0x06001871 RID: 6257 RVA: 0x00071F40 File Offset: 0x00070140
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

		// Token: 0x06001872 RID: 6258 RVA: 0x00071F8C File Offset: 0x0007018C
		private static bool ValidateOffsetAllowNegative(object value)
		{
			if (!(value is double))
			{
				return false;
			}
			double d = (double)value;
			return double.IsNaN(d) || (!double.IsInfinity(d) && !double.IsPositiveInfinity(d) && !double.IsNegativeInfinity(d));
		}

		// Token: 0x040009F5 RID: 2549
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo> _fieldLayoutInfos;

		// Token: 0x040009F6 RID: 2550
		private global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfoCollection _readOnlyFieldLayoutInfos;

		// Token: 0x040009F7 RID: 2551
		private static readonly object DefaultFieldLayoutOffsetXFull = 24.0;

		// Token: 0x040009F8 RID: 2552
		private static readonly object DefaultFieldLayoutOffsetXCompact = 6.0;

		// Token: 0x040009F9 RID: 2553
		private static readonly object DefaultFieldLayoutOffsetYFull = 2.0;

		// Token: 0x040009FA RID: 2554
		private static readonly object DefaultFieldLayoutOffsetYCompact = 0.0;

		// Token: 0x040009FB RID: 2555
		private static readonly object DefaultFieldOffsetX = 6.0;

		// Token: 0x040009FC RID: 2556
		private static readonly object DefaultFieldOffsetY = 0.0;

		// Token: 0x040009FD RID: 2557
		public static readonly global::System.Windows.DependencyProperty ConnectorLinePenProperty = global::System.Windows.DependencyProperty.Register("ConnectorLinePen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040009FE RID: 2558
		public static readonly global::System.Windows.DependencyProperty FieldLayoutDescriptionTemplateProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutDescriptionTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040009FF RID: 2559
		private static readonly global::System.Windows.DependencyPropertyKey FieldLayoutOrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLayoutOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationHorizontalBox));

		// Token: 0x04000A00 RID: 2560
		public static readonly global::System.Windows.DependencyProperty FieldLayoutOrientationProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutOrientationPropertyKey.DependencyProperty;

		// Token: 0x04000A01 RID: 2561
		public static readonly global::System.Windows.DependencyProperty FieldLayoutOffsetXProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutOffsetX", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldLayoutOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldLayoutOffsetX)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffsetAllowNegative));

		// Token: 0x04000A02 RID: 2562
		public static readonly global::System.Windows.DependencyProperty FieldLayoutOffsetYProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutOffsetY", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldLayoutOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldLayoutOffsetY)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffset));

		// Token: 0x04000A03 RID: 2563
		public static readonly global::System.Windows.DependencyProperty FieldOffsetXProperty = global::System.Windows.DependencyProperty.Register("FieldOffsetX", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldOffsetX)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffsetAllowNegative));

		// Token: 0x04000A04 RID: 2564
		public static readonly global::System.Windows.DependencyProperty FieldOffsetYProperty = global::System.Windows.DependencyProperty.Register("FieldOffsetY", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnFieldOffsetChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.CoerceFieldOffsetY)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.ValidateOffset));

		// Token: 0x04000A05 RID: 2565
		private static readonly global::System.Windows.DependencyPropertyKey HasOffsetXPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("HasOffsetX", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A06 RID: 2566
		public static readonly global::System.Windows.DependencyProperty HasOffsetXProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetXPropertyKey.DependencyProperty;

		// Token: 0x04000A07 RID: 2567
		private static readonly global::System.Windows.DependencyPropertyKey HasOffsetYPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("HasOffsetY", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A08 RID: 2568
		public static readonly global::System.Windows.DependencyProperty HasOffsetYProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.HasOffsetYPropertyKey.DependencyProperty;

		// Token: 0x04000A09 RID: 2569
		public static readonly global::System.Windows.DependencyProperty IsConnectorLineTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsConnectorLineTarget", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A0A RID: 2570
		internal static readonly global::System.Windows.DependencyPropertyKey IsFirstInListPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFirstInList", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A0B RID: 2571
		public static readonly global::System.Windows.DependencyProperty IsFirstInListProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey.DependencyProperty;

		// Token: 0x04000A0C RID: 2572
		internal static readonly global::System.Windows.DependencyPropertyKey IsLastInListPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsLastInList", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A0D RID: 2573
		public static readonly global::System.Windows.DependencyProperty IsLastInListProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey.DependencyProperty;

		// Token: 0x04000A0E RID: 2574
		private static readonly global::System.Windows.DependencyPropertyKey OffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Offset", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));

		// Token: 0x04000A0F RID: 2575
		public static readonly global::System.Windows.DependencyProperty OffsetProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OffsetPropertyKey.DependencyProperty;

		// Token: 0x04000A10 RID: 2576
		internal static readonly global::System.Windows.DependencyProperty OverallSortVersionProperty = global::System.Windows.DependencyProperty.Register("OverallSortVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.OnOverallSortVersionChanged)));
	}
}
