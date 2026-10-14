using System;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000260 RID: 608
	public class ProxyColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.TextColumnContentProvider
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0004981E File Offset: 0x00047A1E
		public override bool RemovePaddingDuringEditing
		{
			get
			{
				if (this._proxiedColumnContentProvider != null)
				{
					return this._proxiedColumnContentProvider.RemovePaddingDuringEditing;
				}
				return base.RemovePaddingDuringEditing;
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0004983A File Offset: 0x00047A3A
		public override void EditorRemoved()
		{
			this._editor = null;
			base.EditorRemoved();
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0004984C File Offset: 0x00047A4C
		protected internal override global::System.Windows.FrameworkElement ResolveDisplayElementInternal(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.ProxyColumn proxyColumn = (global::Infragistics.Controls.Grids.ProxyColumn)cell.Column;
			if (proxyColumn.ProxiedSource != null)
			{
				global::Infragistics.Controls.Grids.EditableColumn editableColumn = proxyColumn.ProxiedSource.Column as global::Infragistics.Controls.Grids.EditableColumn;
				if (editableColumn != null)
				{
					proxyColumn.EditorHorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
					proxyColumn.EditorVerticalContentAlignment = editableColumn.EditorVerticalContentAlignment;
					proxyColumn.HorizontalContentAlignment = editableColumn.HorizontalContentAlignment;
					proxyColumn.VerticalContentAlignment = editableColumn.VerticalContentAlignment;
				}
				if (this._proxiedColumnContentProvider == null)
				{
					this._proxiedColumnContentProvider = proxyColumn.ProxiedSource.Column.GenerateContentProvider();
				}
				global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = new global::Infragistics.Controls.Grids.Primitives.FilterRow((global::Infragistics.Controls.Grids.RowsManager)cell.Row.Manager);
				filterRow.SetData(cell.Row.Data);
				cell = new global::Infragistics.Controls.Grids.Primitives.ProxyFilterRowCell(filterRow, proxyColumn.ProxiedSource.Column);
				return this._proxiedColumnContentProvider.ResolveDisplayElementInternal(cell, cellBinding);
			}
			return base.ResolveDisplayElementInternal(cell, cellBinding);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00049924 File Offset: 0x00047B24
		protected internal override global::System.Windows.FrameworkElement ResolveEditorControlInternal(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			global::Infragistics.Controls.Grids.ProxyColumn proxyColumn = (global::Infragistics.Controls.Grids.ProxyColumn)cell.Column;
			global::Infragistics.Controls.Grids.EditableColumn editableColumn = proxyColumn.ProxiedSource.Column as global::Infragistics.Controls.Grids.EditableColumn;
			if (editableColumn != null)
			{
				proxyColumn.EditorHorizontalContentAlignment = editableColumn.EditorHorizontalContentAlignment;
				proxyColumn.EditorVerticalContentAlignment = editableColumn.EditorVerticalContentAlignment;
				proxyColumn.HorizontalContentAlignment = editableColumn.HorizontalContentAlignment;
				proxyColumn.VerticalContentAlignment = editableColumn.VerticalContentAlignment;
			}
			if (this._proxiedColumnContentProvider == null)
			{
				this._proxiedColumnContentProvider = proxyColumn.ProxiedSource.Column.GenerateContentProvider();
			}
			editorBinding = this._proxiedColumnContentProvider.ResolveEditorBinding(cell);
			global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = new global::Infragistics.Controls.Grids.Primitives.FilterRow((global::Infragistics.Controls.Grids.RowsManager)cell.Row.Manager);
			filterRow.SetData(cell.Row.Data);
			cell = new global::Infragistics.Controls.Grids.Primitives.ProxyFilterRowCell(filterRow, proxyColumn.ProxiedSource.Column);
			this._editor = this._proxiedColumnContentProvider.ResolveEditorControlInternal(cell, editorValue, availableWidth, availableHeight, editorBinding);
			return this._editor;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00049A08 File Offset: 0x00047C08
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::Infragistics.Controls.Grids.ProxyColumn proxyColumn = (global::Infragistics.Controls.Grids.ProxyColumn)cell.Column;
			if (this._proxiedColumnContentProvider == null)
			{
				this._proxiedColumnContentProvider = proxyColumn.ProxiedSource.Column.GenerateContentProvider();
			}
			return this._proxiedColumnContentProvider.ResolveValueFromEditor(cell);
		}

		// Token: 0x040005FF RID: 1535
		private global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase _proxiedColumnContentProvider;

		// Token: 0x04000600 RID: 1536
		private global::System.Windows.FrameworkElement _editor;
	}
}
