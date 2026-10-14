using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000EC RID: 236
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamTextEditor")]
	[global::System.Windows.Markup.ContentProperty("Value")]
	public class XamTextEditor : global::Infragistics.Windows.Editors.TextEditorBase, global::Infragistics.Windows.Editors.ISupportsSelectableText
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x00030284 File Offset: 0x0002E484
		static XamTextEditor()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamTextEditor.OnHorizontalContentAlignmentChanged)));
			global::System.Windows.Documents.Block.TextAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamTextEditor.OnTextAlignmentChanged)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamTextEditor));
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003049C File Offset: 0x0002E69C
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

		// Token: 0x06000B24 RID: 2852 RVA: 0x000304E8 File Offset: 0x0002E6E8
		public override bool CanEditType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000304FA File Offset: 0x0002E6FA
		public override bool CanRenderType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0003050C File Offset: 0x0002E70C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return orientation == global::System.Windows.Controls.Orientation.Horizontal || global::System.Windows.TextWrapping.NoWrap != this.TextWrapping;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00030520 File Offset: 0x0002E720
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

		// Token: 0x06000B28 RID: 2856 RVA: 0x0003056B File Offset: 0x0002E76B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamTextEditorAutomationPeer(this);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00030574 File Offset: 0x0002E774
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			if (this._lastTextBox != null)
			{
				this._lastTextBox.SelectionChanged -= this.OnTextBoxSelectionChanged;
				if (this._textBoxTextPvt != null)
				{
					this._textBoxTextPvt.Deactivate();
					this._textBoxTextPvt = null;
				}
				this._lastTextBox = null;
			}
			this._lastTextBox = (base.FocusSite as global::System.Windows.Controls.TextBox);
			if (this._lastTextBox != null)
			{
				this._lastTextBox.SelectionStart = this._cachedSelectionStart;
				this._lastTextBox.SelectionLength = this._cachedSelectionLength;
				this._lastTextBox.SelectionChanged += this.OnTextBoxSelectionChanged;
				this._textBoxTextPvt = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._lastTextBox, global::System.Windows.Controls.TextBox.TextProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnTextBoxTextChanged));
				this.SyncTextBoxText();
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00030641 File Offset: 0x0002E841
		protected override void OnTextChanged(string previousValue, string currentValue)
		{
			base.OnTextChanged(previousValue, currentValue);
			this.SyncTextBoxText();
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00030651 File Offset: 0x0002E851
		internal global::System.Windows.Controls.TextBox TextBox
		{
			get
			{
				return (global::System.Windows.Controls.TextBox)base.FocusSite;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0003065E File Offset: 0x0002E85E
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00030670 File Offset: 0x0002E870
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00030683 File Offset: 0x0002E883
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00030695 File Offset: 0x0002E895
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000306A8 File Offset: 0x0002E8A8
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x000306BA File Offset: 0x0002E8BA
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

		// Token: 0x06000B32 RID: 2866 RVA: 0x000306D0 File Offset: 0x0002E8D0
		private static void OnTextWrappingChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamTextEditor xamTextEditor = (global::Infragistics.Windows.Editors.XamTextEditor)dependencyObject;
			global::System.Windows.TextWrapping cachedTextWrapping = (global::System.Windows.TextWrapping)e.NewValue;
			xamTextEditor._cachedTextWrapping = cachedTextWrapping;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000306F8 File Offset: 0x0002E8F8
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00030700 File Offset: 0x0002E900
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00030713 File Offset: 0x0002E913
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00030725 File Offset: 0x0002E925
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

		// Token: 0x06000B37 RID: 2871 RVA: 0x00030738 File Offset: 0x0002E938
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

		// Token: 0x06000B38 RID: 2872 RVA: 0x000307B0 File Offset: 0x0002E9B0
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamTextEditor xamTextEditor = (global::Infragistics.Windows.Editors.XamTextEditor)dependencyObject;
			xamTextEditor.UpdateTextAlignmentResolved();
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000307CC File Offset: 0x0002E9CC
		private static void OnTextAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamTextEditor xamTextEditor = (global::Infragistics.Windows.Editors.XamTextEditor)dependencyObject;
			xamTextEditor.UpdateTextAlignmentResolved();
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000307E6 File Offset: 0x0002E9E6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeTextAlignment()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty, this);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000307F3 File Offset: 0x0002E9F3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetTextAlignment()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00030800 File Offset: 0x0002EA00
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.TextAlignment TextAlignmentResolved
		{
			get
			{
				return (global::System.Windows.TextAlignment)base.GetValue(global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentResolvedProperty);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00030812 File Offset: 0x0002EA12
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00030824 File Offset: 0x0002EA24
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00030837 File Offset: 0x0002EA37
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00030858 File Offset: 0x0002EA58
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0003087A File Offset: 0x0002EA7A
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0003089B File Offset: 0x0002EA9B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000308C0 File Offset: 0x0002EAC0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000308F4 File Offset: 0x0002EAF4
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x0003090F File Offset: 0x0002EB0F
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

		// Token: 0x06000B46 RID: 2886 RVA: 0x00030925 File Offset: 0x0002EB25
		private void InitializeCachedPropertyValues()
		{
			this._cachedTextWrapping = (global::System.Windows.TextWrapping)global::Infragistics.Windows.Editors.XamTextEditor.TextWrappingProperty.GetMetadata(this).DefaultValue;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00030944 File Offset: 0x0002EB44
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

		// Token: 0x06000B48 RID: 2888 RVA: 0x0003099C File Offset: 0x0002EB9C
		private void OnTextBoxTextChanged()
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

		// Token: 0x06000B49 RID: 2889 RVA: 0x000309C7 File Offset: 0x0002EBC7
		private void SyncTextBoxText()
		{
			if (this._lastTextBox != null)
			{
				this._lastTextBox.Text = base.Text;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000309E2 File Offset: 0x0002EBE2
		public void SelectAll()
		{
			this.SelectionStart = 0;
			this.SelectionLength = this.TextLength;
		}

		// Token: 0x040003EE RID: 1006
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x040003EF RID: 1007
		private global::System.Windows.Controls.TextBox _lastTextBox;

		// Token: 0x040003F0 RID: 1008
		private bool _inOnTextBoxSelectionChanged;

		// Token: 0x040003F1 RID: 1009
		private int _cachedSelectionStart;

		// Token: 0x040003F2 RID: 1010
		private int _cachedSelectionLength;

		// Token: 0x040003F3 RID: 1011
		private global::Infragistics.Windows.Internal.PropertyValueTracker _textBoxTextPvt;

		// Token: 0x040003F4 RID: 1012
		public static readonly global::System.Windows.DependencyProperty AcceptsReturnProperty = global::System.Windows.Input.KeyboardNavigation.AcceptsReturnProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamTextEditor));

		// Token: 0x040003F5 RID: 1013
		public static readonly global::System.Windows.DependencyProperty AcceptsTabProperty = global::System.Windows.DependencyProperty.Register("AcceptsTab", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003F6 RID: 1014
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityHiddenBox));

		// Token: 0x040003F7 RID: 1015
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty = global::System.Windows.DependencyProperty.Register("TextWrapping", typeof(global::System.Windows.TextWrapping), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextWrapping.NoWrap, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamTextEditor.OnTextWrappingChanged)));

		// Token: 0x040003F8 RID: 1016
		private global::System.Windows.TextWrapping _cachedTextWrapping;

		// Token: 0x040003F9 RID: 1017
		public static readonly global::System.Windows.DependencyProperty TextAlignmentProperty = global::System.Windows.Documents.Block.TextAlignmentProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamTextEditor));

		// Token: 0x040003FA RID: 1018
		private static readonly global::System.Windows.DependencyPropertyKey TextAlignmentResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TextAlignmentResolved", typeof(global::System.Windows.TextAlignment), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003FB RID: 1019
		public static readonly global::System.Windows.DependencyProperty TextAlignmentResolvedProperty = global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentResolvedPropertyKey.DependencyProperty;

		// Token: 0x040003FC RID: 1020
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Editors.XamTextEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityHiddenBox));
	}
}
