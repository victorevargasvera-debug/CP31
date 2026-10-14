using System;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B4 RID: 692
	public class CellChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002205 RID: 8709 RVA: 0x000975B1 File Offset: 0x000957B1
		internal CellChangedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this._cell = cell;
			this._editor = editor;
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000975C7 File Offset: 0x000957C7
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000975CF File Offset: 0x000957CF
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x040010EE RID: 4334
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x040010EF RID: 4335
		private global::Infragistics.Windows.Editors.ValueEditor _editor;
	}
}
