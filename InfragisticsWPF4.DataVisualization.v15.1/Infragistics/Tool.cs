using System;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x0200001C RID: 28
	public class Tool : global::Infragistics.ITool
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00008FA3 File Offset: 0x000071A3
		protected Tool(global::Infragistics.InteractiveControl view)
		{
			this.View = view;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00008FB2 File Offset: 0x000071B2
		public virtual bool CanStart()
		{
			return false;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00008FB5 File Offset: 0x000071B5
		public virtual bool CanStart(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			return false;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008FB8 File Offset: 0x000071B8
		public virtual void Start()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008FBA File Offset: 0x000071BA
		public virtual void KeyDown()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008FBC File Offset: 0x000071BC
		public virtual void KeyUp()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008FBE File Offset: 0x000071BE
		public virtual void MouseMove()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008FC0 File Offset: 0x000071C0
		public virtual void MouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008FC2 File Offset: 0x000071C2
		public virtual void MouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008FC4 File Offset: 0x000071C4
		public virtual void OnMouseLeftButtonDoubleClick()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008FC6 File Offset: 0x000071C6
		public virtual void Stop()
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00008FC8 File Offset: 0x000071C8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00008FD0 File Offset: 0x000071D0
		public global::Infragistics.InteractiveControl View
		{
			get
			{
				return this._view;
			}
			private set
			{
				this._view = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00008FD9 File Offset: 0x000071D9
		public global::Infragistics.InputContext LastInput
		{
			get
			{
				return this._view.LastInput;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00008FE6 File Offset: 0x000071E6
		public void StopTool()
		{
			if (this.View.CurrentTool == this && this.View.ResizePoints.Count == 0)
			{
				this.View.ReleaseMouseCaptures();
				this.View.CurrentTool = null;
			}
		}

		// Token: 0x0400007B RID: 123
		private global::Infragistics.InteractiveControl _view;
	}
}
