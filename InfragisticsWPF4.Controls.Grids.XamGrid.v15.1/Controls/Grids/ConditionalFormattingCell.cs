using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001F6 RID: 502
	public class ConditionalFormattingCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000E19 RID: 3609 RVA: 0x000349E1 File Offset: 0x00032BE1
		public ConditionalFormattingCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x000349F4 File Offset: 0x00032BF4
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.ConditionalStyle != null && base.Row.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					return this.ConditionalStyle;
				}
				if (this.Style != null)
				{
					return this.Style;
				}
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null)
				{
					if (row.ConditionalCellStyle != null && base.Row.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
					{
						return row.ConditionalCellStyle;
					}
					if (row.CellStyle != null)
					{
						return row.CellStyle;
					}
				}
				return base.Column.CellStyleResolved;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00034A8F File Offset: 0x00032C8F
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00034A98 File Offset: 0x00032C98
		public override global::System.Windows.Style Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				if (value != base.Style)
				{
					base.Style = value;
					global::System.Windows.Controls.ControlTemplate controlTemplateForConditionalFormatting = null;
					global::Infragistics.Controls.Grids.XamGrid.CloneStyleWithoutControlTemplate(value, out controlTemplateForConditionalFormatting);
					this.ControlTemplateForConditionalFormatting = controlTemplateForConditionalFormatting;
					if (base.Control != null && base.Control.IsCellLoaded)
					{
						this.Refresh();
					}
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00034AE2 File Offset: 0x00032CE2
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00034AEA File Offset: 0x00032CEA
		internal global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormatting { get; set; }

		// Token: 0x06000E1F RID: 3615 RVA: 0x00034AF3 File Offset: 0x00032CF3
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.ConditionalFormattingCellControl();
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00034AFA File Offset: 0x00032CFA
		protected internal override global::System.Windows.Data.IValueConverter CreateCellBindingConverter()
		{
			return new global::Infragistics.Controls.Grids.ConditionalFormattingCell.ConditionalFormattingCellBindingConverter();
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00034B01 File Offset: 0x00032D01
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
			if (base.Control != null)
			{
				base.Control.EnsureCurrentState();
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00034B1C File Offset: 0x00032D1C
		protected internal override void EnterEditMode(bool cellIsEditing)
		{
			this._displayContentPriorToEnterEditMode = this.DisplayContent;
			base.EnterEditMode(cellIsEditing);
			this.DisplayContent = true;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00034B38 File Offset: 0x00032D38
		protected internal override bool ExitEditMode(object newValue, bool editingCanceled, bool evaluateBindings)
		{
			bool flag = base.ExitEditMode(newValue, editingCanceled, evaluateBindings);
			if (flag)
			{
				this.DisplayContent = this._displayContentPriorToEnterEditMode;
			}
			return flag;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00034B60 File Offset: 0x00032D60
		protected internal override void ApplyStyle()
		{
			base.ApplyStyle();
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = base.Control as global::Infragistics.Controls.Grids.ConditionalFormattingCellControl;
			if (conditionalFormattingCellControl != null)
			{
				global::System.Windows.Controls.ControlTemplate controlTemplateForConditionalFormattingResolved = this.ControlTemplateForConditionalFormattingResolved;
				if (controlTemplateForConditionalFormattingResolved != base.Control.Template)
				{
					if (controlTemplateForConditionalFormattingResolved == null)
					{
						if (conditionalFormattingCellControl.CustomTemplateSet)
						{
							conditionalFormattingCellControl.ClearValue(global::System.Windows.Controls.Control.TemplateProperty);
							conditionalFormattingCellControl.CustomTemplateSet = false;
							return;
						}
					}
					else
					{
						if (conditionalFormattingCellControl.IsCellLoaded)
						{
							conditionalFormattingCellControl.Template = controlTemplateForConditionalFormattingResolved;
							conditionalFormattingCellControl.CustomTemplateSet = true;
							return;
						}
						conditionalFormattingCellControl.CustomTemplateToApply = controlTemplateForConditionalFormattingResolved;
					}
				}
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00034BD4 File Offset: 0x00032DD4
		public override void Refresh()
		{
			if (base.Control != null && !this.InCellConverter)
			{
				bool ignoreCellControlAttached = ((global::Infragistics.Controls.Grids.Row)base.Row).IgnoreCellControlAttached;
				((global::Infragistics.Controls.Grids.Row)base.Row).IgnoreCellControlAttached = true;
				base.Control.DataContext = null;
				base.Control.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
				((global::Infragistics.Controls.Grids.Row)base.Row).IgnoreCellControlAttached = ignoreCellControlAttached;
			}
			base.Refresh();
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00034C48 File Offset: 0x00032E48
		private static bool SouldChangeStyle(global::Infragistics.Controls.Grids.ConditionalFormattingCell cell, string cellColumnKey)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> cellScopedConditions = cell.Row.Manager.GetCellScopedConditions(cellColumnKey);
			if (cellScopedConditions.Count > 0)
			{
				return false;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> rowScopedConditions = cell.Row.Manager.GetRowScopedConditions();
			foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy in rowScopedConditions)
			{
				if (conditionalFormattingRuleProxy.RuleExecution == global::Infragistics.EvaluationStage.None)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00034CCC File Offset: 0x00032ECC
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00034CD4 File Offset: 0x00032ED4
		protected internal global::System.Windows.Style ConditionalStyle
		{
			get
			{
				return this._conditionalStyle;
			}
			set
			{
				if (value != null)
				{
					global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
					if (row != null)
					{
						row.ConditionalStyleDirty = true;
					}
				}
				this._conditionalStyle = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00034D01 File Offset: 0x00032F01
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00034D09 File Offset: 0x00032F09
		protected internal bool DisplayContent
		{
			get
			{
				return this._displayContent;
			}
			set
			{
				if (this._displayContent != value)
				{
					this._displayContent = value;
					this.EnsureCurrentState();
				}
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00034D24 File Offset: 0x00032F24
		internal global::System.Windows.Style StrippedCellStyleForConditionalFormattingResolved
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null && row.StrippedCellStyleForConditionalFormatting != null)
				{
					return row.StrippedCellStyleForConditionalFormatting;
				}
				return base.Column.StrippedCellStyleForConditionalFormattingResolved;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00034D6C File Offset: 0x00032F6C
		internal virtual global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormattingResolved
		{
			get
			{
				if (this.ConditionalStyleControlTemplate != null)
				{
					return this.ConditionalStyleControlTemplate;
				}
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null && row.ConditionalStyleControlTemplate != null)
				{
					return row.ConditionalStyleControlTemplate;
				}
				if (this.ControlTemplateForConditionalFormatting != null)
				{
					return this.ControlTemplateForConditionalFormatting;
				}
				if (row != null && row.ControlTemplateForConditionalFormatting != null)
				{
					return row.ControlTemplateForConditionalFormatting;
				}
				if (base.Column != null)
				{
					return base.Column.ControlTemplateForConditionalFormattingResolved;
				}
				return null;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00034DDC File Offset: 0x00032FDC
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00034DE4 File Offset: 0x00032FE4
		internal global::System.Windows.Controls.ControlTemplate ConditionalStyleControlTemplate { get; set; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00034DED File Offset: 0x00032FED
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00034DF5 File Offset: 0x00032FF5
		internal bool InCellConverter { get; set; }

		// Token: 0x06000E31 RID: 3633 RVA: 0x00034E00 File Offset: 0x00033000
		internal static void MergeRuleSetters(global::System.Windows.Style ruleStyle, global::System.Collections.Generic.IList<global::System.Windows.SetterBase> settersList, global::System.Collections.Generic.ISet<global::System.Windows.DependencyProperty> setDPs)
		{
			for (global::System.Windows.Style style = ruleStyle; style != null; style = style.BasedOn)
			{
				foreach (global::System.Windows.SetterBase setterBase in style.Setters)
				{
					if (setterBase is global::System.Windows.Setter)
					{
						global::System.Windows.Setter setter = (global::System.Windows.Setter)setterBase;
						if (setDPs.Add(setter.Property))
						{
							settersList.Add(setterBase);
						}
					}
					else
					{
						settersList.Add(setterBase);
					}
				}
			}
		}

		// Token: 0x04000496 RID: 1174
		private global::System.Windows.Style _conditionalStyle;

		// Token: 0x04000497 RID: 1175
		private bool _displayContentPriorToEnterEditMode;

		// Token: 0x04000498 RID: 1176
		private bool _displayContent = true;

		// Token: 0x020001F7 RID: 503
		internal class ConditionalFormattingCellBindingConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06000E32 RID: 3634 RVA: 0x00034E84 File Offset: 0x00033084
			internal static global::System.Windows.Style MergeSettersIntoSingleStyle(global::System.Collections.Generic.List<global::System.Windows.SetterBase> setters, global::System.Windows.Style basedOnStyle, out bool controlTemplateSet, out bool needApplyStyle, out global::System.Windows.Controls.ControlTemplate controlTemplate)
			{
				controlTemplateSet = false;
				controlTemplate = null;
				needApplyStyle = false;
				global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl));
				style.BasedOn = basedOnStyle;
				if (setters.Count > 0)
				{
					for (int i = setters.Count - 1; i >= 0; i--)
					{
						global::System.Windows.Setter setter = new global::System.Windows.Setter();
						global::System.Windows.Setter setter2 = (global::System.Windows.Setter)setters[i];
						setter.Property = setter2.Property;
						object obj = setter2.Value;
						if (obj is uint)
						{
							obj = obj.ToString();
						}
						if (obj is global::System.Windows.Controls.ControlTemplate)
						{
							controlTemplateSet = true;
							controlTemplate = (global::System.Windows.Controls.ControlTemplate)obj;
						}
						else
						{
							setter.Value = obj;
							style.Setters.Add(setter);
						}
					}
					needApplyStyle = true;
				}
				else if (basedOnStyle != null && basedOnStyle.Setters.Count > 0)
				{
					needApplyStyle = true;
				}
				return style;
			}

			// Token: 0x06000E33 RID: 3635 RVA: 0x00034F50 File Offset: 0x00033150
			public virtual object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = (global::Infragistics.Controls.Grids.Primitives.CellControlBase)parameter;
				global::Infragistics.Controls.Grids.ConditionalFormattingCell conditionalFormattingCell = (global::Infragistics.Controls.Grids.ConditionalFormattingCell)cellControlBase.Cell;
				if (conditionalFormattingCell == null)
				{
					return value;
				}
				if (conditionalFormattingCell != null)
				{
					bool flag = conditionalFormattingCell.Control == null;
					if (flag)
					{
						conditionalFormattingCell.Control = cellControlBase;
					}
					conditionalFormattingCell.InCellConverter = true;
					conditionalFormattingCell.Row.InCellConverter = true;
					if (!((global::Infragistics.Controls.Grids.Row)conditionalFormattingCell.Row).IgnoreCellControlAttached)
					{
						conditionalFormattingCell.RaiseCellControlAttachedEvent();
					}
					global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
					global::Infragistics.Controls.Grids.Column column = conditionalFormattingCell.Column;
					global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
					if (columnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting && !conditionalFormattingCell.IsEditing)
					{
						bool flag2 = conditionalFormattingCell.ConditionalStyle != null;
						conditionalFormattingCell.ConditionalStyle = null;
						global::Infragistics.Controls.Grids.Row row = (global::Infragistics.Controls.Grids.Row)conditionalFormattingCell.Row;
						global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> cellScopedConditions = conditionalFormattingCell.Row.Manager.GetCellScopedConditions(column.Key);
						global::System.Collections.Generic.List<global::System.Windows.SetterBase> list = new global::System.Collections.Generic.List<global::System.Windows.SetterBase>();
						global::System.Collections.Generic.HashSet<global::System.Windows.DependencyProperty> hashSet = new global::System.Collections.Generic.HashSet<global::System.Windows.DependencyProperty>();
						foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy in cellScopedConditions)
						{
							global::System.Windows.Style style = conditionalFormattingRuleProxy.EvaluateCondition(row.Data, value);
							if (style != null)
							{
								if (conditionalFormattingRuleProxy.Parent.StyleScope == global::Infragistics.Controls.Grids.StyleScope.Cell)
								{
									global::Infragistics.Controls.Grids.ConditionalFormattingCell.MergeRuleSetters(style, list, hashSet);
								}
								visibility = conditionalFormattingRuleProxy.Parent.CellValueVisibility;
								if (conditionalFormattingRuleProxy.Parent.IsTerminalRule)
								{
									break;
								}
							}
						}
						bool flag3 = false;
						global::System.Windows.Controls.ControlTemplate conditionalStyleControlTemplate = null;
						global::System.Windows.Style basedOnStyle;
						if (conditionalFormattingCell.Style != null)
						{
							basedOnStyle = conditionalFormattingCell.StrippedCellStyleForConditionalFormattingResolved;
						}
						else
						{
							if (global::Infragistics.Controls.Grids.ConditionalFormattingCell.SouldChangeStyle(conditionalFormattingCell, column.Key))
							{
								row.UpdateStyleBasedOnConditionalFormattingRules(null);
							}
							if (row.ConditionalCellStyle != null && conditionalFormattingCell.StrippedCellStyleForConditionalFormattingResolved != null)
							{
								foreach (global::System.Windows.SetterBase setterBase in row.ConditionalCellStyle.Setters)
								{
									if (setterBase is global::System.Windows.Setter)
									{
										hashSet.Add(((global::System.Windows.Setter)setterBase).Property);
									}
								}
								global::Infragistics.Controls.Grids.ConditionalFormattingCell.MergeRuleSetters(conditionalFormattingCell.StrippedCellStyleForConditionalFormattingResolved, list, hashSet);
							}
							basedOnStyle = ((row.ConditionalCellStyle != null) ? row.ConditionalCellStyle : conditionalFormattingCell.StrippedCellStyleForConditionalFormattingResolved);
						}
						global::System.Windows.Style style2 = global::Infragistics.Controls.Grids.ConditionalFormattingCell.ConditionalFormattingCellBindingConverter.MergeSettersIntoSingleStyle(list, basedOnStyle, out flag3, out flag2, out conditionalStyleControlTemplate);
						conditionalFormattingCell.ConditionalStyleControlTemplate = conditionalStyleControlTemplate;
						flag2 = (column.ForceUpdateRowStyle || (flag2 && !row.SkipApplyStyle));
						if (flag3 && conditionalFormattingCell.Control != null)
						{
							this.SetAndApplyConditionalStyle(conditionalFormattingCell, style2, flag2);
						}
						else
						{
							if (list.Count > 0)
							{
								conditionalFormattingCell.ConditionalStyle = style2;
							}
							if (flag2)
							{
								conditionalFormattingCell.ApplyStyle();
							}
						}
					}
					conditionalFormattingCell.DisplayContent = (visibility == global::System.Windows.Visibility.Visible);
					if (flag)
					{
						conditionalFormattingCell.Control = null;
					}
					global::Infragistics.Controls.Grids.Column resolveColumn = conditionalFormattingCell.ResolveColumn;
					if (resolveColumn.ValueConverter != null)
					{
						value = resolveColumn.ValueConverter.Convert(value, targetType, resolveColumn.ValueConverterParameter, culture);
					}
					else if (cellControlBase.ContentProvider != null)
					{
						value = cellControlBase.ContentProvider.ApplyFormatting(value, resolveColumn, culture);
					}
					if (value == null && !string.IsNullOrEmpty(resolveColumn.DataField.NullDisplayText))
					{
						value = resolveColumn.DataField.NullDisplayText;
					}
				}
				conditionalFormattingCell.InCellConverter = false;
				conditionalFormattingCell.Row.InCellConverter = false;
				conditionalFormattingCell.Column.ForceUpdateRowStyle = false;
				return value;
			}

			// Token: 0x06000E34 RID: 3636 RVA: 0x00035294 File Offset: 0x00033494
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = (global::Infragistics.Controls.Grids.Primitives.CellControlBase)parameter;
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)cellControlBase.Cell;
				if (cell != null)
				{
					global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
					if (resolveColumn.ValueConverter != null)
					{
						return resolveColumn.ValueConverter.ConvertBack(value, targetType, resolveColumn.ValueConverterParameter, culture);
					}
				}
				return value;
			}

			// Token: 0x06000E35 RID: 3637 RVA: 0x000352DD File Offset: 0x000334DD
			private void SetAndApplyConditionalStyle(global::Infragistics.Controls.Grids.ConditionalFormattingCell cell, global::System.Windows.Style generatedStyle, bool needApplyStyle)
			{
				cell.ConditionalStyle = generatedStyle;
				if (needApplyStyle)
				{
					cell.ApplyStyle();
				}
			}
		}
	}
}
