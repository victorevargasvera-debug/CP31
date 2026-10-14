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
	// Token: 0x0200026C RID: 620
	public class Row : global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase, global::Infragistics.IBindableItem, global::Infragistics.ISelectableObject
	{
		// Token: 0x06001439 RID: 5177 RVA: 0x0004B7F8 File Offset: 0x000499F8
		protected internal Row(int index, global::Infragistics.Controls.Grids.RowsManager manager, object data) : base(manager)
		{
			base.Data = data;
			base.Index = index;
			if (manager != null && manager.ColumnLayout != null)
			{
				this._identifer = manager.ColumnLayout.Key + "_" + manager.ColumnLayout.Level.ToString();
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0004B854 File Offset: 0x00049A54
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0004B8AF File Offset: 0x00049AAF
		protected internal override global::Infragistics.Controls.Grids.RowsManagerBase ChildRowsManager
		{
			get
			{
				if (this._childRowsManager == null)
				{
					global::Infragistics.Controls.Grids.RowsManagerBase manager = base.Manager;
					if (manager.ColumnLayout != null && manager.ColumnLayout.Grid != null && manager.Level < manager.ColumnLayout.Grid.MaxDepth)
					{
						this._childRowsManager = new global::Infragistics.Controls.Grids.ChildBandRowsManager(this);
					}
				}
				return this._childRowsManager;
			}
			set
			{
				this._childRowsManager = (value as global::Infragistics.Controls.Grids.ChildBandRowsManager);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0004B8C0 File Offset: 0x00049AC0
		public override bool HasChildren
		{
			get
			{
				if (this.ChildRowsManager != null)
				{
					global::Infragistics.Controls.Grids.Primitives.RowBaseCollection rows = this.ChildRowsManager.Rows;
					foreach (object obj in rows)
					{
						global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = (global::Infragistics.Controls.Grids.Primitives.ChildBand)obj;
						if (((global::Infragistics.Controls.Grids.RowsManager)childBand.ChildRowsManager).ChildrenShouldBeDisplayedResolved)
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0004B940 File Offset: 0x00049B40
		public override bool IsAlternateRow
		{
			get
			{
				return this.ColumnLayout != null && this.ColumnLayout.IsAlternateRowsEnabledResolved && base.Index % 2 != 0;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0004B967 File Offset: 0x00049B67
		public virtual global::Infragistics.Controls.Grids.Primitives.ChildBandCollection ChildBands
		{
			get
			{
				if (this.ChildRowsManager != null)
				{
					return (global::Infragistics.Controls.Grids.Primitives.ChildBandCollection)this.ChildRowsManager.Rows.ActualCollection;
				}
				return new global::Infragistics.Controls.Grids.Primitives.ChildBandCollection();
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0004B98C File Offset: 0x00049B8C
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0004B994 File Offset: 0x00049B94
		public bool IsSelected
		{
			get
			{
				return this._isSelected;
			}
			set
			{
				if (this.ColumnLayout != null)
				{
					if (value)
					{
						this.ColumnLayout.Grid.SelectRow(this, global::Infragistics.Controls.Grids.InvokeAction.Code);
						return;
					}
					this.ColumnLayout.Grid.UnselectRow(this);
				}
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0004B9C6 File Offset: 0x00049BC6
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x0004B9D0 File Offset: 0x00049BD0
		public global::System.Windows.Style CellStyle
		{
			get
			{
				return this._cellStyle;
			}
			set
			{
				this._cellStyle = value;
				global::System.Windows.Controls.ControlTemplate controlTemplateForConditionalFormatting = null;
				this.StrippedCellStyleForConditionalFormatting = global::Infragistics.Controls.Grids.XamGrid.CloneStyleWithoutControlTemplate(value, out controlTemplateForConditionalFormatting);
				this.ControlTemplateForConditionalFormatting = controlTemplateForConditionalFormatting;
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null && this.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this.Cells)
					{
						global::Infragistics.Controls.Grids.ConditionalFormattingCell conditionalFormattingCell = cellBase as global::Infragistics.Controls.Grids.ConditionalFormattingCell;
						if (conditionalFormattingCell != null)
						{
							conditionalFormattingCell.ConditionalStyle = null;
							conditionalFormattingCell.Refresh();
						}
					}
				}
				this.ColumnLayout.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0004BA88 File Offset: 0x00049C88
		public global::Infragistics.Controls.Grids.RowBase ParentRow
		{
			get
			{
				return base.Manager.ParentRow;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0004BA95 File Offset: 0x00049C95
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.DataRow;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0004BA98 File Offset: 0x00049C98
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x0004BAA0 File Offset: 0x00049CA0
		protected internal global::System.Windows.Style ConditionalCellStyle { get; set; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0004BAA9 File Offset: 0x00049CA9
		protected internal override global::Infragistics.Controls.Grids.EditingType AllowEditing
		{
			get
			{
				return this.ColumnLayout.EditingSettings.AllowEditingResolved;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0004BABB File Offset: 0x00049CBB
		protected internal override bool AllowKeyboardNavigation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0004BABE File Offset: 0x00049CBE
		protected internal override bool AllowSelection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0004BAC1 File Offset: 0x00049CC1
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0004BAC9 File Offset: 0x00049CC9
		protected internal bool ConditionalStyleDirty { get; set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0004BAD2 File Offset: 0x00049CD2
		protected internal virtual bool CanBeDeleted
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0004BAD5 File Offset: 0x00049CD5
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0004BADD File Offset: 0x00049CDD
		internal global::System.Windows.Style StrippedCellStyleForConditionalFormatting { get; set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0004BAE6 File Offset: 0x00049CE6
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0004BAEE File Offset: 0x00049CEE
		internal global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormatting { get; set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0004BAF7 File Offset: 0x00049CF7
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0004BAFF File Offset: 0x00049CFF
		internal global::System.Windows.Controls.ControlTemplate ConditionalStyleControlTemplate { get; set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0004BB08 File Offset: 0x00049D08
		internal bool ContainsChildBandRowsManager
		{
			get
			{
				return this._childRowsManager != null;
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0004BB18 File Offset: 0x00049D18
		public virtual void Delete()
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = base.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				global::Infragistics.Controls.Grids.RowCollection rowCollection = rowsManager.Rows.ActualCollection as global::Infragistics.Controls.Grids.RowCollection;
				if (rowCollection != null)
				{
					rowCollection.Remove(this);
				}
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0004BB50 File Offset: 0x00049D50
		protected internal virtual void SetSelected(bool isSelected)
		{
			this._isSelected = isSelected;
			this.OnPropertyChanged("IsSelected");
			if (this.ColumnLayout != null)
			{
				this.ColumnLayout.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0004BB80 File Offset: 0x00049D80
		protected internal override object GetCellValue(global::Infragistics.Controls.Grids.Column column)
		{
			object result = null;
			if (base.Data != null && column.Key != null)
			{
				global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
				global::System.Windows.Data.Binding binding = null;
				if (column.Key != null && column.DataType != null)
				{
					if (column is global::Infragistics.Controls.Grids.UnboundColumn)
					{
						binding = new global::System.Windows.Data.Binding();
					}
					else
					{
						binding = new global::System.Windows.Data.Binding(column.Key);
					}
					binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
				}
				if (binding != null)
				{
					binding.Mode = global::System.Windows.Data.BindingMode.OneTime;
					binding.Source = base.Data;
					binding.Converter = column.ValueConverter;
					binding.ConverterParameter = column.ValueConverterParameter;
					cellValueObject.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
					result = cellValueObject.Value;
				}
			}
			return result;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0004BC30 File Offset: 0x00049E30
		internal void UpdateStyleBasedOnConditionalFormattingRules(object cellValue = null)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> rowScopedConditions = base.Manager.GetRowScopedConditions();
			global::System.Collections.Generic.List<global::System.Windows.SetterBase> list = new global::System.Collections.Generic.List<global::System.Windows.SetterBase>();
			global::System.Collections.Generic.HashSet<global::System.Windows.DependencyProperty> setDPs = new global::System.Collections.Generic.HashSet<global::System.Windows.DependencyProperty>();
			foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy in rowScopedConditions)
			{
				global::System.Windows.Style style = conditionalFormattingRuleProxy.EvaluateCondition(base.Data, (cellValue != null) ? cellValue : this.Cells[conditionalFormattingRuleProxy.Parent.Column].Value);
				if (style != null)
				{
					global::Infragistics.Controls.Grids.ConditionalFormattingCell.MergeRuleSetters(style, list, setDPs);
					if (conditionalFormattingRuleProxy.Parent.IsTerminalRule)
					{
						break;
					}
				}
			}
			if (list.Count > 0)
			{
				global::System.Windows.Controls.ControlTemplate conditionalStyleControlTemplate = null;
				global::System.Windows.Style basedOnStyle = (this.CellStyle != null) ? this.CellStyle : this.ColumnLayout.CellStyleResolved;
				bool flag;
				bool flag2;
				global::System.Windows.Style conditionalCellStyle = global::Infragistics.Controls.Grids.ConditionalFormattingCell.ConditionalFormattingCellBindingConverter.MergeSettersIntoSingleStyle(list, basedOnStyle, out flag, out flag2, out conditionalStyleControlTemplate);
				this.ConditionalStyleControlTemplate = conditionalStyleControlTemplate;
				this.ConditionalCellStyle = conditionalCellStyle;
				return;
			}
			this.ConditionalCellStyle = null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0004BD28 File Offset: 0x00049F28
		protected override bool OnElementReleasing(global::Infragistics.Controls.Grids.Primitives.CellsPanel element)
		{
			if (this.ColumnLayout != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = this.ColumnLayout.Grid;
				if (grid != null && (element.Row == grid.CurrentEditRow || (grid.CurrentEditCell != null && grid.CurrentEditCell.Row == this)))
				{
					return false;
				}
			}
			return base.OnElementReleasing(element);
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0004BD79 File Offset: 0x00049F79
		protected internal override global::Infragistics.Controls.Grids.RowHoverType ResolveRowHover
		{
			get
			{
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
				{
					return this.ColumnLayout.Grid.RowHover;
				}
				return base.ResolveRowHover;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0004BDA7 File Offset: 0x00049FA7
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0004BDAA File Offset: 0x00049FAA
		protected override string RecyclingIdentifier
		{
			get
			{
				return this._identifer + "_" + this.RowType.ToString();
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0004BDCC File Offset: 0x00049FCC
		protected override void OnElementAttached(global::Infragistics.Controls.Grids.Primitives.CellsPanel element)
		{
			this.UpdateStyleBasedOnConditionalFormattingRules(null);
			base.OnElementAttached(element);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0004BDDC File Offset: 0x00049FDC
		protected override void OnElementReleased(global::Infragistics.Controls.Grids.Primitives.CellsPanel element)
		{
			base.OnElementReleased(element);
			if (this.ConditionalStyleDirty)
			{
				for (int i = 0; i < this.Cells.Count; i++)
				{
					global::Infragistics.Controls.Grids.ConditionalFormattingCell conditionalFormattingCell = this.Cells[i] as global::Infragistics.Controls.Grids.ConditionalFormattingCell;
					if (conditionalFormattingCell != null)
					{
						conditionalFormattingCell.ConditionalStyle = null;
						conditionalFormattingCell.DisplayContent = true;
					}
				}
			}
			this.ConditionalStyleDirty = false;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0004BE38 File Offset: 0x0004A038
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0004BE40 File Offset: 0x0004A040
		protected virtual bool IsDataBound { get; set; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0004BE49 File Offset: 0x0004A049
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x0004BE51 File Offset: 0x0004A051
		bool global::Infragistics.IBindableItem.IsDataBound
		{
			get
			{
				return this.IsDataBound;
			}
			set
			{
				this.IsDataBound = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0004BE5A File Offset: 0x0004A05A
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0004BE62 File Offset: 0x0004A062
		bool global::Infragistics.ISelectableObject.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
			set
			{
				this.IsSelected = value;
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0004BE6B File Offset: 0x0004A06B
		void global::Infragistics.ISelectableObject.SetSelected(bool isSelected)
		{
			this.SetSelected(isSelected);
		}

		// Token: 0x04000632 RID: 1586
		private global::Infragistics.Controls.Grids.ChildBandRowsManager _childRowsManager;

		// Token: 0x04000633 RID: 1587
		private bool _isSelected;

		// Token: 0x04000634 RID: 1588
		private global::System.Windows.Style _cellStyle;

		// Token: 0x04000635 RID: 1589
		private string _identifer;
	}
}
