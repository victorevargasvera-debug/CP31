using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x02000015 RID: 21
	internal abstract class InteractiveElement : global::Infragistics.VisualElement
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00006CDC File Offset: 0x00004EDC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00006CEE File Offset: 0x00004EEE
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.CursorTypeConverter))]
		public global::System.Windows.Input.Cursor Cursor
		{
			get
			{
				return (global::System.Windows.Input.Cursor)base.GetValue(global::Infragistics.InteractiveElement.CursorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.InteractiveElement.CursorProperty, value);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006CFC File Offset: 0x00004EFC
		private static void OnCursorChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.InteractiveElement)d).OnCursorChanged((global::System.Windows.Input.Cursor)e.OldValue, (global::System.Windows.Input.Cursor)e.NewValue);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006D21 File Offset: 0x00004F21
		protected virtual void OnCursorChanged(global::System.Windows.Input.Cursor oldValue, global::System.Windows.Input.Cursor newValue)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00006D23 File Offset: 0x00004F23
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00006D2B File Offset: 0x00004F2B
		public bool IsMouseOver
		{
			get
			{
				return this._isMouseOver;
			}
			private set
			{
				this._isMouseOver = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00006D34 File Offset: 0x00004F34
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00006D3C File Offset: 0x00004F3C
		public bool IsMouseCaptured
		{
			get
			{
				return this._isMouseCaptured;
			}
			private set
			{
				this._isMouseCaptured = value;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00006D45 File Offset: 0x00004F45
		public virtual void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006D47 File Offset: 0x00004F47
		public virtual void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this.IsMouseOver = true;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006D50 File Offset: 0x00004F50
		public virtual void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.IsMouseOver = false;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006D59 File Offset: 0x00004F59
		public virtual void OnMouseLeftButtonDown(global::System.Windows.Input.MouseEventArgs e)
		{
			this.IsMouseCaptured = true;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006D62 File Offset: 0x00004F62
		public virtual void OnMouseLeftButtonUp(global::System.Windows.Input.MouseEventArgs e)
		{
			this.IsMouseCaptured = false;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006D6B File Offset: 0x00004F6B
		public virtual void OnMouseLeftButtonDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006D6D File Offset: 0x00004F6D
		public virtual void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006D6F File Offset: 0x00004F6F
		public virtual void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006D71 File Offset: 0x00004F71
		public virtual void OnGotSelection(global::System.EventArgs e)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006D73 File Offset: 0x00004F73
		public virtual void OnLostSelection(global::System.EventArgs e)
		{
		}

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Windows.DependencyProperty CursorProperty = global::System.Windows.DependencyProperty.Register("Cursor", typeof(global::System.Windows.Input.Cursor), typeof(global::Infragistics.InteractiveElement), new global::System.Windows.PropertyMetadata(global::System.Windows.Input.Cursors.Arrow, new global::System.Windows.PropertyChangedCallback(global::Infragistics.InteractiveElement.OnCursorChanged)));

		// Token: 0x0400005F RID: 95
		private bool _isMouseOver;

		// Token: 0x04000060 RID: 96
		private bool _isMouseCaptured;
	}
}
