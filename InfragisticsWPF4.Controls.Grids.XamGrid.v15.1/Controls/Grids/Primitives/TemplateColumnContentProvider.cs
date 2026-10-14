using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000265 RID: 613
	public class TemplateColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x060013C3 RID: 5059 RVA: 0x0004A4E1 File Offset: 0x000486E1
		public TemplateColumnContentProvider()
		{
			this._cellObj = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0004A4F4 File Offset: 0x000486F4
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = (global::Infragistics.Controls.Grids.TemplateColumn)cell.Column;
			if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow && templateColumn.FilterItemTemplate != null && this._content == null)
			{
				this._content = (templateColumn.FilterItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			else if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow && templateColumn.AddNewRowItemTemplate != null && this._content == null)
			{
				this._content = (templateColumn.AddNewRowItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			else if (templateColumn.ItemTemplate != null && this._content == null)
			{
				this._content = (templateColumn.ItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			else if (templateColumn.ItemTemplate == null)
			{
				this._content = new global::System.Windows.Controls.ContentPresenter();
			}
			this._cellBinding = cellBinding;
			if (!base.IsToolTip)
			{
				if (cell.Control != null && cell.Control.Content != this._content)
				{
					cell.Control.Content = this._content;
				}
				if (cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.AddNewRow)
				{
					if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
					{
						this._isFilterRow = true;
					}
					else if (cellBinding == null && cell.GetType() == typeof(global::Infragistics.Controls.Grids.Cell))
					{
						cell.RaiseCellControlAttachedEvent();
					}
				}
			}
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			return this._content;
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0004A644 File Offset: 0x00048844
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			if (cellBinding != null && !base.IsToolTip && cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.AddNewRow && cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				if (((global::Infragistics.Controls.Grids.TemplateColumn)cell.Column).ItemTemplate == null && this._content is global::System.Windows.Controls.ContentPresenter)
				{
					this._content.SetBinding(global::System.Windows.Controls.ContentPresenter.ContentProperty, cellBinding);
					return;
				}
				this._cellObj.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, cellBinding);
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0004A6BC File Offset: 0x000488BC
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			if (this._isFilterRow)
			{
				if (((global::Infragistics.Controls.Grids.TemplateColumn)cell.Column).FilterItemTemplate != null)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterRowCell frc = (global::Infragistics.Controls.Grids.Primitives.FilterRowCell)cell;
					global::Infragistics.FilteringDataContext dataContext = new global::Infragistics.FilteringDataContext(frc);
					this._content.DataContext = dataContext;
				}
			}
			else if (cell.Control != null)
			{
				if (this._justReleased && this._cellObj.DataContext == cell.Control.DataContext)
				{
					this._cellObj.DataContext = null;
				}
				this._cellObj.DataContext = cell.Control.DataContext;
			}
			if (this._justReleased && this._cellBinding == null && cell.GetType() == typeof(global::Infragistics.Controls.Grids.Cell))
			{
				cell.RaiseCellControlAttachedEvent();
			}
			this._justReleased = false;
			base.AdjustDisplayElement(cell);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0004A784 File Offset: 0x00048984
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = (global::Infragistics.Controls.Grids.TemplateColumn)cell.Column;
			bool flag = cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow;
			bool flag2 = cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow;
			bool flag3 = false;
			if (templateColumn.EditorTemplateDirtyFlag != this._templateFlag || this._editor == null)
			{
				if (flag && templateColumn.FilterEditorTemplate != null && this._editor == null)
				{
					this._editor = (templateColumn.FilterEditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				else if (flag2 && templateColumn.AddNewRowEditorTemplate != null && this._editor == null)
				{
					this._editor = (templateColumn.AddNewRowEditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				else if (this._editor == null && templateColumn.EditorTemplate != null)
				{
					this._editor = (templateColumn.EditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				else if (this._editor == null && templateColumn.EditorTemplate == null)
				{
					this._editor = new global::Infragistics.Controls.Grids.Primitives.TemplateColumnEditorContentPresenter();
					flag3 = true;
				}
				else
				{
					this._editor = null;
				}
				this._templateFlag = templateColumn.EditorTemplateDirtyFlag;
			}
			if (this._editor != null)
			{
				if (flag && templateColumn.FilterEditorTemplate != null)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterRowCell frc = (global::Infragistics.Controls.Grids.Primitives.FilterRowCell)cell;
					global::Infragistics.FilteringDataContext dataContext = new global::Infragistics.FilteringDataContext(frc);
					this._editor.DataContext = dataContext;
				}
				else if (flag3 && editorBinding != null)
				{
					this._editor.SetBinding(global::System.Windows.Controls.ContentPresenter.ContentProperty, editorBinding);
				}
				else if (cell.Control != null)
				{
					cell.Control.DataContext = cell.Row.Data;
					global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._editor, cell.EditorStyleResolved);
				}
				else
				{
					global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._editor, cell.EditorStyleResolved);
				}
			}
			return this._editor;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0004A920 File Offset: 0x00048B20
		protected override global::System.Windows.FrameworkElement ApplyAddNewRowEditorTemplate(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			global::System.Windows.FrameworkElement frameworkElement = base.ApplyAddNewRowEditorTemplate(cell, editorValue, availableWidth, availableHeight, editorBinding);
			if (frameworkElement != null)
			{
				this._editor = frameworkElement;
			}
			return frameworkElement;
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0004A946 File Offset: 0x00048B46
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return cell.Value;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0004A94E File Offset: 0x00048B4E
		public override void EditorRemoved()
		{
			if (this._editor != null)
			{
				this._editor.Unloaded += this.Editor_Unloaded;
			}
			this._editor = null;
			this._content = null;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0004A980 File Offset: 0x00048B80
		private void Editor_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.DataContext = null;
				frameworkElement.Unloaded -= this.Editor_Unloaded;
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0004A9B0 File Offset: 0x00048BB0
		public override void ResetContent()
		{
			this._justReleased = true;
			if (this._cellObj != null)
			{
				this._cellObj.DataContext = null;
			}
			base.ResetContent();
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0004A9D3 File Offset: 0x00048BD3
		protected internal override void FocusEditor()
		{
			global::Infragistics.Controls.PresentationUtilities.Focus(this._editor);
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0004A9E1 File Offset: 0x00048BE1
		public override bool RemovePaddingDuringEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0004A9E4 File Offset: 0x00048BE4
		protected internal override bool CanResolveValueFromEditor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000608 RID: 1544
		private global::System.Windows.FrameworkElement _content;

		// Token: 0x04000609 RID: 1545
		private global::System.Windows.FrameworkElement _editor;

		// Token: 0x0400060A RID: 1546
		private global::Infragistics.Controls.Grids.Cell.CellValueObject _cellObj;

		// Token: 0x0400060B RID: 1547
		private int _templateFlag;

		// Token: 0x0400060C RID: 1548
		private bool _isFilterRow;

		// Token: 0x0400060D RID: 1549
		private bool _justReleased;

		// Token: 0x0400060E RID: 1550
		private global::System.Windows.Data.Binding _cellBinding;
	}
}
