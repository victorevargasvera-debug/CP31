using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000022 RID: 34
	internal abstract class ThumbNode : global::Infragistics.Group
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x000097BC File Offset: 0x000079BC
		public ThumbNode()
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000097C4 File Offset: 0x000079C4
		protected global::Infragistics.Controls.XamZoombar Zoombar
		{
			get
			{
				return this.View as global::Infragistics.Controls.XamZoombar;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000097D1 File Offset: 0x000079D1
		public void ClearChildren()
		{
			while (base.Children.Count > 0)
			{
				base.Children.RemoveAt(0);
			}
		}

		// Token: 0x060001CB RID: 459
		public abstract global::Infragistics.ShapeElement HitResizeThumb(global::System.Windows.Point point);

		// Token: 0x060001CC RID: 460
		public abstract void DoMove(global::System.Windows.Point offset);

		// Token: 0x060001CD RID: 461
		public abstract void DoResize(global::System.Windows.Point offset);

		// Token: 0x060001CE RID: 462 RVA: 0x000097F0 File Offset: 0x000079F0
		public virtual void Start()
		{
			if (this.Zoombar.Range == null)
			{
				return;
			}
			this.Zoombar.TempRange.Minimum = this.Zoombar.Range.Minimum;
			this.Zoombar.TempRange.Maximum = this.Zoombar.Range.Maximum;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000984C File Offset: 0x00007A4C
		public virtual void Finish(bool canceled)
		{
			if (!canceled)
			{
				global::Infragistics.Controls.Range range = this.Zoombar.TempRange.Clone();
				this.Zoombar.Range = range;
				return;
			}
			this.Zoombar.UpdateThumb();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009885 File Offset: 0x00007A85
		public override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.ChangeVisualState("MouseOver");
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00009899 File Offset: 0x00007A99
		public override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.ChangeVisualState("Normal");
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000098AD File Offset: 0x00007AAD
		public override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			this.ChangeVisualState("Pressed");
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000098C1 File Offset: 0x00007AC1
		public override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.IsMouseOver)
			{
				this.ChangeVisualState("MouseOver");
			}
			else
			{
				this.ChangeVisualState("Normal");
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000098EA File Offset: 0x00007AEA
		protected virtual void ChangeVisualState(string newState)
		{
		}

		// Token: 0x0400008B RID: 139
		private const string NormalState = "Normal";

		// Token: 0x0400008C RID: 140
		private const string MouseOverState = "MouseOver";

		// Token: 0x0400008D RID: 141
		private const string PressedState = "Pressed";
	}
}
