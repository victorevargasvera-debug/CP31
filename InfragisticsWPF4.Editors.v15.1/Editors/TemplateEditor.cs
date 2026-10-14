using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000065 RID: 101
	[global::System.Windows.TemplatePart(Name = "PART_FocusBefore", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_FocusAfter", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TemplateEditor : global::Infragistics.Windows.Editors.ValueEditor
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x0001811C File Offset: 0x0001631C
		static TemplateEditor()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.TemplateEditor)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(object)));
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000182C7 File Offset: 0x000164C7
		public TemplateEditor()
		{
			base.SetValue(global::Infragistics.Windows.Editors.TemplateEditor.EditorPropertyKey, this);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000182DB File Offset: 0x000164DB
		public override bool CanEditType(global::System.Type type)
		{
			return true;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000182DE File Offset: 0x000164DE
		public override bool CanRenderType(global::System.Type type)
		{
			return true;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000182E1 File Offset: 0x000164E1
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return true;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000182E4 File Offset: 0x000164E4
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._focusBefore = (base.GetTemplateChild("PART_FocusBefore") as global::System.Windows.FrameworkElement);
			this._focusAfter = (base.GetTemplateChild("PART_FocusAfter") as global::System.Windows.FrameworkElement);
			if (!base.IsEmbedded)
			{
				if (this._focusBefore != null)
				{
					this._focusBefore.Visibility = global::System.Windows.Visibility.Collapsed;
				}
				if (this._focusAfter != null)
				{
					this._focusAfter.Visibility = global::System.Windows.Visibility.Collapsed;
				}
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00018354 File Offset: 0x00016554
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			if (this._focusSite != null)
			{
				this._focusSite.GotKeyboardFocus -= this.OnFocusSiteGotKeyboardFocus;
			}
			this._focusSite = (base.FocusSite as global::System.Windows.IInputElement);
			if (this._focusSite != null)
			{
				this._focusSite.GotKeyboardFocus += this.OnFocusSiteGotKeyboardFocus;
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000183B8 File Offset: 0x000165B8
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Tab && base.IsEmbedded)
			{
				bool next;
				if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.None)
				{
					next = true;
				}
				else
				{
					if (global::System.Windows.Input.Keyboard.Modifiers != global::System.Windows.Input.ModifierKeys.Shift)
					{
						return;
					}
					next = false;
				}
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
				if (global::Infragistics.Windows.Editors.TemplateEditor.MoveFocus(focusedElement, next) && focusedElement != global::System.Windows.Input.Keyboard.FocusedElement && global::System.Windows.Input.Keyboard.FocusedElement != this._focusBefore && global::System.Windows.Input.Keyboard.FocusedElement != this._focusAfter)
				{
					e.Handled = true;
				}
			}
			base.OnKeyDown(e);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001842D File Offset: 0x0001662D
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasDisplayDataTemplate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.TemplateEditor.HasDisplayDataTemplateProperty);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001843F File Offset: 0x0001663F
		private static void OnDisplayDataTemplateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.SetValue(global::Infragistics.Windows.Editors.TemplateEditor.HasDisplayDataTemplatePropertyKey, (e.NewValue != null) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00018461 File Offset: 0x00016661
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00018473 File Offset: 0x00016673
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate DisplayDataTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Editors.TemplateEditor.DisplayDataTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.TemplateEditor.DisplayDataTemplateProperty, value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00018481 File Offset: 0x00016681
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasEditDataTemplate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.TemplateEditor.HasEditDataTemplateProperty);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00018493 File Offset: 0x00016693
		private static void OnEditDataTemplateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.SetValue(global::Infragistics.Windows.Editors.TemplateEditor.HasEditDataTemplatePropertyKey, (e.NewValue != null) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000184B5 File Offset: 0x000166B5
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000184C7 File Offset: 0x000166C7
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate EditDataTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Editors.TemplateEditor.EditDataTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.TemplateEditor.EditDataTemplateProperty, value);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000184D5 File Offset: 0x000166D5
		public static global::Infragistics.Windows.Editors.TemplateEditor GetEditor(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Editors.TemplateEditor)d.GetValue(global::Infragistics.Windows.Editors.TemplateEditor.EditorProperty);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000184E7 File Offset: 0x000166E7
		private static bool MoveFocus(global::System.Windows.IInputElement src, bool next)
		{
			return global::Infragistics.Windows.Editors.TemplateEditor.MoveFocus(src, next ? global::System.Windows.Input.FocusNavigationDirection.Next : global::System.Windows.Input.FocusNavigationDirection.Previous);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000184F8 File Offset: 0x000166F8
		private static bool MoveFocus(global::System.Windows.IInputElement src, global::System.Windows.Input.FocusNavigationDirection direction)
		{
			global::System.Windows.FrameworkElement frameworkElement = src as global::System.Windows.FrameworkElement;
			global::System.Windows.Input.TraversalRequest request = new global::System.Windows.Input.TraversalRequest(direction);
			if (frameworkElement != null)
			{
				return frameworkElement.MoveFocus(request);
			}
			global::System.Windows.FrameworkContentElement frameworkContentElement = src as global::System.Windows.FrameworkContentElement;
			return frameworkContentElement != null && frameworkContentElement.MoveFocus(request);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00018534 File Offset: 0x00016734
		private void OnFocusSiteGotKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.NewFocus == this._focusSite)
			{
				global::System.Windows.Input.FocusNavigationDirection direction = (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Tab) && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Shift) ? global::System.Windows.Input.FocusNavigationDirection.Last : global::System.Windows.Input.FocusNavigationDirection.First;
				global::Infragistics.Windows.Editors.TemplateEditor.MoveFocus(this._focusSite, direction);
			}
		}

		// Token: 0x04000207 RID: 519
		private global::System.Windows.FrameworkElement _focusBefore;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.FrameworkElement _focusAfter;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.IInputElement _focusSite;

		// Token: 0x0400020A RID: 522
		private static readonly global::System.Windows.DependencyPropertyKey HasDisplayDataTemplatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasDisplayDataTemplate", typeof(bool), typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400020B RID: 523
		public static readonly global::System.Windows.DependencyProperty HasDisplayDataTemplateProperty = global::Infragistics.Windows.Editors.TemplateEditor.HasDisplayDataTemplatePropertyKey.DependencyProperty;

		// Token: 0x0400020C RID: 524
		public static readonly global::System.Windows.DependencyProperty DisplayDataTemplateProperty = global::System.Windows.DependencyProperty.Register("DisplayDataTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.TemplateEditor.OnDisplayDataTemplateChanged)));

		// Token: 0x0400020D RID: 525
		private static readonly global::System.Windows.DependencyPropertyKey HasEditDataTemplatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasEditDataTemplate", typeof(bool), typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty HasEditDataTemplateProperty = global::Infragistics.Windows.Editors.TemplateEditor.HasEditDataTemplatePropertyKey.DependencyProperty;

		// Token: 0x0400020F RID: 527
		public static readonly global::System.Windows.DependencyProperty EditDataTemplateProperty = global::System.Windows.DependencyProperty.Register("EditDataTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.TemplateEditor.OnEditDataTemplateChanged)));

		// Token: 0x04000210 RID: 528
		private static readonly global::System.Windows.DependencyPropertyKey EditorPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Editor", typeof(global::Infragistics.Windows.Editors.TemplateEditor), typeof(global::Infragistics.Windows.Editors.TemplateEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

		// Token: 0x04000211 RID: 529
		public static readonly global::System.Windows.DependencyProperty EditorProperty = global::Infragistics.Windows.Editors.TemplateEditor.EditorPropertyKey.DependencyProperty;
	}
}
