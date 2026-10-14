using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000E0 RID: 224
	[global::Infragistics.Windows.Licensing.UltraLicense("XamTextEditor")]
	[global::System.Windows.Markup.ContentProperty("Value")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamTextEditor : global::Infragistics.Windows.Editors.TextEditorBase, global::Infragistics.Windows.Editors.ISupportsSelectableText
	{
		// Token: 0x06000A9F RID: 2719 RVA: 0x0002E15C File Offset: 0x0002C35C
		static XamTextEditor()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamTextEditor.OnHorizontalContentAlignmentChanged)));
			global::System.Windows.Documents.Block.TextAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamTextEditor.OnTextAlignmentChanged)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002E368 File Offset: 0x0002C568
		public XamTextEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamTextEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002E3B4 File Offset: 0x0002C5B4
		public override bool CanEditType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002E3C6 File Offset: 0x0002C5C6
		public override bool CanRenderType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return orientation == global::System.Windows.Controls.Orientation.Horizontal || global::System.Windows.TextWrapping.NoWrap != this.TextWrapping;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0002E3EC File Offset: 0x0002C5EC
		protected override bool ValidateFocusSite(object focusSite, out global::System.Exception errorMessage)
		{
			if (!base.ValidateFocusSite(focusSite, out errorMessage))
			{
				return false;
			}
			if (!(focusSite is global::System.Windows.Controls.TextBox))
			{
				errorMessage = new global::System.NotSupportedException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_5", new object[]
				{
					focusSite.GetType().Name
				}));
				return false;
			}
			return true;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0002E437 File Offset: 0x0002C637
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamTextEditorAutomationPeer(this);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0002E440 File Offset: 0x0002C640
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			if (this._lastTextBox != null)
			{
				this._lastTextBox.SelectionChanged -= this.OnTextBoxSelectionChanged;
				this._lastTextBox.TextChanged -= this.OnTextBoxTextChanged;
				this._lastTextBox = null;
			}
			this._lastTextBox = (base.FocusSite as global::System.Windows.Controls.TextBox);
			if (this._lastTextBox != null)
			{
				this._lastTextBox.SelectionStart = this._cachedSelectionStart;
				this._lastTextBox.SelectionLength = this._cachedSelectionLength;
				this._lastTextBox.SelectionChanged += this.OnTextBoxSelectionChanged;
				this._lastTextBox.TextChanged += this.OnTextBoxTextChanged;
				this.SyncTextBoxText();
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0002E4FF File Offset: 0x0002C6FF
		protected override void OnTextChanged(string previousValue, string currentValue)
		{
			base.OnTextChanged(previousValue, currentValue);
			this.SyncTextBoxText();
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002E50F File Offset: 0x0002C70F
		internal global::System.Windows.Controls.TextBox TextBox
		{
			get
			{
				return (global::System.Windows.Controls.TextBox)base.FocusSite;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002E51C File Offset: 0x0002C71C
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0002E52E File Offset: 0x0002C72E
		public bool AcceptsReturn
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.AcceptsReturnProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.AcceptsReturnProperty, value);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002E541 File Offset: 0x0002C741
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0002E553 File Offset: 0x0002C753
		public bool AcceptsTab
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.AcceptsTabProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.AcceptsTabProperty, value);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002E566 File Offset: 0x0002C766
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0002E578 File Offset: 0x0002C778
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.HorizontalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.HorizontalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0002E58C File Offset: 0x0002C78C
		private static void OnTextWrappingChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamTextEditor xamTextEditor = (global::Infragistics.Windows.Editors.XamTextEditor)dependencyObject;
			global::System.Windows.TextWrapping cachedTextWrapping = (global::System.Windows.TextWrapping)e.NewValue;
			xamTextEditor._cachedTextWrapping = cachedTextWrapping;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002E5B4 File Offset: 0x0002C7B4
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextWrapping TextWrapping
		{
			get
			{
				return this._cachedTextWrapping;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextWrappingProperty, value);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002E5CF File Offset: 0x0002C7CF
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0002E5E1 File Offset: 0x0002C7E1
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextAlignment TextAlignment
		{
			get
			{
				return (global::System.Windows.TextAlignment)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty, value);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		private void UpdateTextAlignmentResolved()
		{
			object obj = null;
			object obj2 = base.ReadLocalValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty);
			if (global::System.Windows.DependencyProperty.UnsetValue != obj2)
			{
				obj = obj2;
			}
			if (obj == null)
			{
				obj2 = base.ReadLocalValue(global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty);
				if (global::System.Windows.DependencyProperty.UnsetValue != obj2)
				{
					obj = global::Infragistics.Windows.Editors.Utils.ToTextAlignment((global::System.Windows.HorizontalAlignment)obj2);
				}
			}
			if (obj == null)
			{
				obj = base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty);
			}
			if (obj != null)
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentResolvedPropertyKey, obj);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentResolvedPropertyKey);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0002E66C File Offset: 0x0002C86C
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamTextEditor xamTextEditor = (global::Infragistics.Windows.Editors.XamTextEditor)dependencyObject;
			xamTextEditor.UpdateTextAlignmentResolved();
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002E688 File Offset: 0x0002C888
		private static void OnTextAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamTextEditor xamTextEditor = (global::Infragistics.Windows.Editors.XamTextEditor)dependencyObject;
			xamTextEditor.UpdateTextAlignmentResolved();
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002E6A2 File Offset: 0x0002C8A2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeTextAlignment()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty, this);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002E6AF File Offset: 0x0002C8AF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetTextAlignment()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty);
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002E6BC File Offset: 0x0002C8BC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.TextAlignment TextAlignmentResolved
		{
			get
			{
				return (global::System.Windows.TextAlignment)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentResolvedProperty);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002E6CE File Offset: 0x0002C8CE
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.VerticalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamTextEditor.VerticalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002E6F3 File Offset: 0x0002C8F3
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0002E714 File Offset: 0x0002C914
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SelectionStart
		{
			get
			{
				if (this.TextBox != null)
				{
					this._cachedSelectionStart = this.TextBox.SelectionStart;
				}
				return this._cachedSelectionStart;
			}
			set
			{
				this._cachedSelectionStart = value;
				if (this.TextBox != null)
				{
					this.TextBox.SelectionStart = this._cachedSelectionStart;
				}
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002E736 File Offset: 0x0002C936
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0002E757 File Offset: 0x0002C957
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int SelectionLength
		{
			get
			{
				if (this.TextBox != null)
				{
					this._cachedSelectionLength = this.TextBox.SelectionLength;
				}
				return this._cachedSelectionLength;
			}
			set
			{
				this._cachedSelectionLength = value;
				if (this.TextBox != null)
				{
					this.TextBox.SelectionLength = this._cachedSelectionLength;
				}
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002E77C File Offset: 0x0002C97C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int TextLength
		{
			get
			{
				string text = (this.TextBox != null) ? this.TextBox.Text : base.Text;
				if (text == null)
				{
					return 0;
				}
				return text.Length;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0002E7B0 File Offset: 0x0002C9B0
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0002E7CB File Offset: 0x0002C9CB
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public string SelectedText
		{
			get
			{
				if (this.TextBox == null)
				{
					return string.Empty;
				}
				return this.TextBox.SelectedText;
			}
			set
			{
				if (this.TextBox != null)
				{
					this.TextBox.SelectedText = value;
				}
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002E7E1 File Offset: 0x0002C9E1
		private void InitializeCachedPropertyValues()
		{
			this._cachedTextWrapping = (global::System.Windows.TextWrapping)global::Infragistics.Windows.Editors.XamTextEditor.TextWrappingProperty.GetMetadata(this).DefaultValue;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002E800 File Offset: 0x0002CA00
		internal void OnTextBoxSelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			bool inOnTextBoxSelectionChanged = this._inOnTextBoxSelectionChanged;
			this._inOnTextBoxSelectionChanged = true;
			try
			{
				global::System.Windows.Controls.TextBox textBox = this.TextBox;
				if (textBox != null)
				{
					this._cachedSelectionStart = textBox.SelectionStart;
					this._cachedSelectionLength = textBox.SelectionLength;
				}
			}
			finally
			{
				this._inOnTextBoxSelectionChanged = inOnTextBoxSelectionChanged;
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0002E858 File Offset: 0x0002CA58
		private void OnTextBoxTextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			if (!base.SyncingValueProperties)
			{
				global::System.Windows.Controls.TextBox lastTextBox = this._lastTextBox;
				if (lastTextBox != null)
				{
					base.Text_CurrentValue = lastTextBox.Text;
				}
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002E883 File Offset: 0x0002CA83
		private void SyncTextBoxText()
		{
			if (this._lastTextBox != null)
			{
				this._lastTextBox.Text = base.Text;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002E89E File Offset: 0x0002CA9E
		public void SelectAll()
		{
			this.SelectionStart = 0;
			this.SelectionLength = this.TextLength;
		}

		// Token: 0x040003B5 RID: 949
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Controls.TextBox _lastTextBox;

		// Token: 0x040003B7 RID: 951
		private bool _inOnTextBoxSelectionChanged;

		// Token: 0x040003B8 RID: 952
		private int _cachedSelectionStart;

		// Token: 0x040003B9 RID: 953
		private int _cachedSelectionLength;

		// Token: 0x040003BA RID: 954
		public static readonly global::System.Windows.DependencyProperty AcceptsReturnProperty = global::System.Windows.Input.KeyboardNavigation.AcceptsReturnProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamTextEditor));

		// Token: 0x040003BB RID: 955
		public static readonly global::System.Windows.DependencyProperty AcceptsTabProperty = global::System.Windows.DependencyProperty.Register("AcceptsTab", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003BC RID: 956
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityHiddenBox));

		// Token: 0x040003BD RID: 957
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty = global::System.Windows.DependencyProperty.Register("TextWrapping", typeof(global::System.Windows.TextWrapping), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextWrapping.NoWrap, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamTextEditor.OnTextWrappingChanged)));

		// Token: 0x040003BE RID: 958
		private global::System.Windows.TextWrapping _cachedTextWrapping;

		// Token: 0x040003BF RID: 959
		public static readonly global::System.Windows.DependencyProperty TextAlignmentProperty = global::System.Windows.Documents.Block.TextAlignmentProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamTextEditor));

		// Token: 0x040003C0 RID: 960
		private static readonly global::System.Windows.DependencyPropertyKey TextAlignmentResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TextAlignmentResolved", typeof(global::System.Windows.TextAlignment), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003C1 RID: 961
		public static readonly global::System.Windows.DependencyProperty TextAlignmentResolvedProperty = global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentResolvedPropertyKey.DependencyProperty;

		// Token: 0x040003C2 RID: 962
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityHiddenBox));
	}
}
