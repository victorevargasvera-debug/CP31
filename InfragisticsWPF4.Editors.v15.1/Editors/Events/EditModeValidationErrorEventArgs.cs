using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000BF RID: 191
	public class EditModeValidationErrorEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000A69 RID: 2665 RVA: 0x0002F70A File Offset: 0x0002D90A
		public EditModeValidationErrorEventArgs(global::Infragistics.Windows.Editors.ValueEditor editor, bool forceExitEditMode, global::System.Exception exception, string errorMessage)
		{
			this._editor = editor;
			this._forceExitEditMode = forceExitEditMode;
			this._exception = exception;
			this._errorMessage = errorMessage;
			this._invalidValueBehavior = editor.InvalidValueBehaviorResolved;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002F73B File Offset: 0x0002D93B
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002F743 File Offset: 0x0002D943
		public bool ForceExitEditMode
		{
			get
			{
				return this._forceExitEditMode;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002F74B File Offset: 0x0002D94B
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0002F753 File Offset: 0x0002D953
		public global::Infragistics.Windows.Editors.InvalidValueBehavior InvalidValueBehavior
		{
			get
			{
				return this._invalidValueBehavior;
			}
			set
			{
				this._invalidValueBehavior = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002F75C File Offset: 0x0002D95C
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x0002F764 File Offset: 0x0002D964
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
			set
			{
				this._errorMessage = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002F76D File Offset: 0x0002D96D
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x040003B5 RID: 949
		private global::Infragistics.Windows.Editors.ValueEditor _editor;

		// Token: 0x040003B6 RID: 950
		private bool _forceExitEditMode;

		// Token: 0x040003B7 RID: 951
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _invalidValueBehavior;

		// Token: 0x040003B8 RID: 952
		private string _errorMessage;

		// Token: 0x040003B9 RID: 953
		private global::System.Exception _exception;
	}
}
