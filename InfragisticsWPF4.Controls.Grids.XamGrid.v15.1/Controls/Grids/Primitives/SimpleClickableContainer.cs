using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001D9 RID: 473
	[global::System.Windows.Markup.ContentProperty("Child")]
	[global::System.Windows.TemplatePart(Name = "Border", Type = typeof(global::System.Windows.Controls.Border))]
	public class SimpleClickableContainer : global::System.Windows.Controls.Control
	{
		// Token: 0x06000C8C RID: 3212 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		static SimpleClickableContainer()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0002C52E File Offset: 0x0002A72E
		public SimpleClickableContainer()
		{
			base.SizeChanged += this.OnSizeChanged;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0002C548 File Offset: 0x0002A748
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0002C55A File Offset: 0x0002A75A
		public global::System.Windows.UIElement Child
		{
			get
			{
				return (global::System.Windows.UIElement)base.GetValue(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer.ChildProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer.ChildProperty, value);
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0002C568 File Offset: 0x0002A768
		private static void ChildChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer simpleClickableContainer = (global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer)obj;
			if (simpleClickableContainer._border != null)
			{
				simpleClickableContainer._border.Child = (e.NewValue as global::System.Windows.UIElement);
			}
			simpleClickableContainer._child = (e.NewValue as global::System.Windows.UIElement);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0002C5AD File Offset: 0x0002A7AD
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			this._fireClick = true;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0002C5C0 File Offset: 0x0002A7C0
		public override void OnApplyTemplate()
		{
			if (this._child != null && this._border != null)
			{
				this._border.Child = null;
			}
			base.OnApplyTemplate();
			this._border = (base.GetTemplateChild("Border") as global::System.Windows.Controls.Border);
			if (this._child != null && this._border != null)
			{
				this._border.Child = this._child;
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0002C626 File Offset: 0x0002A826
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this._fireClick = false;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0002C636 File Offset: 0x0002A836
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (this._fireClick)
			{
				this.OnSimpleClick();
			}
			this._fireClick = false;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0002C654 File Offset: 0x0002A854
		private void OnSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this._fireClick = false;
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000C96 RID: 3222 RVA: 0x0002C660 File Offset: 0x0002A860
		// (remove) Token: 0x06000C97 RID: 3223 RVA: 0x0002C698 File Offset: 0x0002A898
		public event global::System.EventHandler SimpleClick;

		// Token: 0x06000C98 RID: 3224 RVA: 0x0002C6CD File Offset: 0x0002A8CD
		protected virtual void OnSimpleClick()
		{
			if (this.SimpleClick != null)
			{
				this.SimpleClick(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000419 RID: 1049
		private bool _fireClick;

		// Token: 0x0400041A RID: 1050
		private global::System.Windows.Controls.Border _border;

		// Token: 0x0400041B RID: 1051
		private global::System.Windows.UIElement _child;

		// Token: 0x0400041C RID: 1052
		public static readonly global::System.Windows.DependencyProperty ChildProperty = global::System.Windows.DependencyProperty.Register("Child", typeof(global::System.Windows.UIElement), typeof(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.SimpleClickableContainer.ChildChanged)));
	}
}
