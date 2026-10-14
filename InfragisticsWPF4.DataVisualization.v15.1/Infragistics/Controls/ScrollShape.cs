using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000021 RID: 33
	internal class ScrollShape : global::Infragistics.ShapeElement
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00009661 File Offset: 0x00007861
		public ScrollShape(global::System.Windows.FrameworkElement frameworkElement)
		{
			this.FrameworkElement = frameworkElement;
			base.FrameworkElements.Add(frameworkElement);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000967C File Offset: 0x0000787C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00009684 File Offset: 0x00007884
		public global::System.Windows.FrameworkElement FrameworkElement
		{
			get
			{
				return this._frameworkElement;
			}
			set
			{
				this._frameworkElement = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000968D File Offset: 0x0000788D
		private global::Infragistics.Controls.XamZoombar Zoombar
		{
			get
			{
				return this.View as global::Infragistics.Controls.XamZoombar;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000969A File Offset: 0x0000789A
		// (set) Token: 0x060001BF RID: 447 RVA: 0x000096A2 File Offset: 0x000078A2
		public bool MoveLeft
		{
			get
			{
				return this._moveLeft;
			}
			set
			{
				this._moveLeft = value;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000096AB File Offset: 0x000078AB
		protected override void ChangeFrameworkElementSettings(global::System.Windows.FrameworkElement frameworkElement)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000096AD File Offset: 0x000078AD
		public override void Render()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000096AF File Offset: 0x000078AF
		public override void Remove()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000096B4 File Offset: 0x000078B4
		public override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			this.ChangeVisualState("Pressed");
			double newValue = this.MoveLeft ? this.Zoombar.ActualMinimum : this.Zoombar.ActualMaximum;
			this.Zoombar.MoveTo(newValue, true);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00009701 File Offset: 0x00007901
		public override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseEventArgs e)
		{
			this.Zoombar.StopMove();
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

		// Token: 0x060001C5 RID: 453 RVA: 0x00009735 File Offset: 0x00007935
		public override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.ChangeVisualState("MouseOver");
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009749 File Offset: 0x00007949
		public override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.ChangeVisualState("Normal");
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009760 File Offset: 0x00007960
		private void ChangeVisualState(string newState)
		{
			foreach (global::System.Windows.FrameworkElement frameworkElement in base.FrameworkElements)
			{
				global::System.Windows.Controls.Control control = frameworkElement as global::System.Windows.Controls.Control;
				if (control != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control, newState, true);
				}
			}
		}

		// Token: 0x04000086 RID: 134
		private const string NormalState = "Normal";

		// Token: 0x04000087 RID: 135
		private const string MouseOverState = "MouseOver";

		// Token: 0x04000088 RID: 136
		private const string PressedState = "Pressed";

		// Token: 0x04000089 RID: 137
		private global::System.Windows.FrameworkElement _frameworkElement;

		// Token: 0x0400008A RID: 138
		private bool _moveLeft;
	}
}
