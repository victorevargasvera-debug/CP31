using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000046 RID: 70
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidUnfocusedEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidFocusedEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "ReadOnly", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	public abstract class ValueInput : global::System.Windows.Controls.Control, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		static ValueInput()
		{
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnVisualStatePropertyChanged)));
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000102A4 File Offset: 0x0000E4A4
		protected ValueInput()
		{
			this.ValueTypeResolved = this.DefaultValueType;
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000102BE File Offset: 0x0000E4BE
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyFocusSite();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000102DF File Offset: 0x0000E4DF
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.ValueInputAutomationPeer(this);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000102E7 File Offset: 0x0000E4E7
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!this._initialized)
			{
				this._initialized = true;
				this.DoInitialization();
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00010305 File Offset: 0x0000E505
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			this.OnIsFocusWithinChangedHelper(true);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00010315 File Offset: 0x0000E515
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.OnIsFocusWithinChangedHelper((bool)e.NewValue);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00010330 File Offset: 0x0000E530
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001033F File Offset: 0x0000E53F
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00010350 File Offset: 0x0000E550
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				bool flag = true;
				if (flag)
				{
					this.SetFocusToFocusSite();
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00010377 File Offset: 0x0000E577
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.UIElement.IsMouseOverProperty)
			{
				this.ProcessPropertyChanged(e);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002A0 RID: 672 RVA: 0x00010398 File Offset: 0x0000E598
		// (remove) Token: 0x060002A1 RID: 673 RVA: 0x000103D0 File Offset: 0x0000E5D0
		public event global::System.EventHandler<global::Infragistics.Controls.Editors.EditModeValidationErrorEventArgs> ValidationError;

		// Token: 0x060002A2 RID: 674 RVA: 0x00010405 File Offset: 0x0000E605
		protected void RaiseValidationError(global::Infragistics.Controls.Editors.EditModeValidationErrorEventArgs args)
		{
			if (this.ValidationError != null)
			{
				this.ValidationError(this, args);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001041C File Offset: 0x0000E61C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool AlwaysValidateResolved
		{
			get
			{
				bool? alwaysValidate = this.AlwaysValidate;
				return alwaysValidate != null && alwaysValidate.Value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00010444 File Offset: 0x0000E644
		internal global::System.Globalization.CultureInfo CultureInfoResolved
		{
			get
			{
				global::System.Globalization.CultureInfo cultureInfo = this.FormatProviderResolved as global::System.Globalization.CultureInfo;
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
				return global::Infragistics.Controls.Editors.Primitives.Utils.GetCultureInfo(this);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00010468 File Offset: 0x0000E668
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.IFormatProvider FormatProviderResolved
		{
			get
			{
				if (this._cachedFormatProviderResolved == null)
				{
					this._cachedFormatProviderResolved = this.InternalFormatProviderResolved;
				}
				return this._cachedFormatProviderResolved;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00010484 File Offset: 0x0000E684
		private global::System.IFormatProvider InternalFormatProviderResolved
		{
			get
			{
				global::System.IFormatProvider formatProvider = this.FormatProvider;
				if (formatProvider != null)
				{
					return formatProvider;
				}
				return global::Infragistics.Controls.Editors.Primitives.Utils.GetCultureInfo(this);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x000104A4 File Offset: 0x0000E6A4
		internal global::Infragistics.Controls.Editors.InvalidValueBehavior InvalidValueBehaviorResolved
		{
			get
			{
				global::Infragistics.Controls.Editors.InvalidValueBehavior invalidValueBehavior = this.InvalidValueBehavior;
				if (invalidValueBehavior == global::Infragistics.Controls.Editors.InvalidValueBehavior.Default && invalidValueBehavior == global::Infragistics.Controls.Editors.InvalidValueBehavior.Default)
				{
					invalidValueBehavior = global::Infragistics.Controls.Editors.InvalidValueBehavior.DisplayErrorMessage;
				}
				return invalidValueBehavior;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000104C1 File Offset: 0x0000E6C1
		internal bool InternalIsInitialized
		{
			get
			{
				return this._initialized;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000104C9 File Offset: 0x0000E6C9
		internal bool IsEditingAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000104CC File Offset: 0x0000E6CC
		internal bool SyncingValueProperties
		{
			get
			{
				return this._syncingValueProperties > 0;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000104D8 File Offset: 0x0000E6D8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::System.Windows.Data.IValueConverter ValueToTextConverterResolved
		{
			get
			{
				global::System.Windows.Data.IValueConverter valueConverter = this.ValueToTextConverter;
				if (valueConverter == null)
				{
					valueConverter = this.DefaultValueToTextConverter;
				}
				return valueConverter;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000104F7 File Offset: 0x0000E6F7
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00010509 File Offset: 0x0000E709
		[global::System.ComponentModel.Bindable(true)]
		public bool? AlwaysValidate
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.AlwaysValidateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.AlwaysValidateProperty, value);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001051C File Offset: 0x0000E71C
		private static void OnAlwaysValidateChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00010537 File Offset: 0x0000E737
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAlwaysValidate()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueInput.AlwaysValidateProperty);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00010544 File Offset: 0x0000E744
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAlwaysValidate()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.AlwaysValidateProperty);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00010554 File Offset: 0x0000E754
		private static void OnIsInEditModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)d;
			valueInput._cachedIsInEditMode = (bool)e.NewValue;
			valueInput.OnIsInEditModeChanged(valueInput._cachedIsInEditMode);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00010588 File Offset: 0x0000E788
		internal void VerifyIsInEditMode()
		{
			bool flag = this._considerInEditModeAttributes != null && this._considerInEditModeAttributes.Count > 0;
			if (this._cachedIsInEditMode != flag)
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.IsInEditModePropertyKey, flag);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x000105C9 File Offset: 0x0000E7C9
		internal bool IsInEditMode
		{
			get
			{
				return this._cachedIsInEditMode;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000105D1 File Offset: 0x0000E7D1
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000105DE File Offset: 0x0000E7DE
		[global::System.ComponentModel.Bindable(true)]
		public object Value
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueInput.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, value);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000105EC File Offset: 0x0000E7EC
		private static void OnValueChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			if (!valueInput._initialized)
			{
				return;
			}
			if (object.Equals(e.OldValue, e.NewValue))
			{
				return;
			}
			valueInput.BeginSyncValueProperties();
			try
			{
				valueInput.SyncValueProperties(e.Property, e.NewValue);
				valueInput.OnValueChanged(e.OldValue, e.NewValue);
			}
			finally
			{
				valueInput.EndSyncValueProperties();
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060002B7 RID: 695 RVA: 0x00010668 File Offset: 0x0000E868
		// (remove) Token: 0x060002B8 RID: 696 RVA: 0x000106A0 File Offset: 0x0000E8A0
		public event global::System.EventHandler<global::System.EventArgs> ValueChanged;

		// Token: 0x060002B9 RID: 697 RVA: 0x000106D5 File Offset: 0x0000E8D5
		protected virtual void OnValueChanged(object previousValue, object currentValue)
		{
			this.RaiseValuePropertyChangedEvent(new global::Infragistics.Controls.Editors.Primitives.RaiseEventDefinition<global::System.EventArgs>(this, this.ValueChanged, new global::System.EventArgs()));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000106F0 File Offset: 0x0000E8F0
		internal void CoerceValueHelper()
		{
			object value = this.Value;
			if (value != null && global::System.DBNull.Value != value && !this.ValueTypeResolved.IsInstanceOfType(value))
			{
				this.Value = global::Infragistics.CoreUtilities.ConvertDataValue(value, this.ValueTypeResolved, this.FormatProviderResolved, this.Format);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0001073B File Offset: 0x0000E93B
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0001074D File Offset: 0x0000E94D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public string Text
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.TextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.TextProperty, value);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001075C File Offset: 0x0000E95C
		private static void OnTextChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			if (!valueInput._initialized)
			{
				return;
			}
			valueInput.SyncValueProperties(e.Property, e.NewValue);
			valueInput.OnTextChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002BE RID: 702 RVA: 0x000107AC File Offset: 0x0000E9AC
		// (remove) Token: 0x060002BF RID: 703 RVA: 0x000107E4 File Offset: 0x0000E9E4
		public event global::System.EventHandler<global::System.EventArgs> TextChanged;

		// Token: 0x060002C0 RID: 704 RVA: 0x00010819 File Offset: 0x0000EA19
		protected virtual void OnTextChanged(string previousValue, string currentValue)
		{
			this.RaiseValuePropertyChangedEvent(new global::Infragistics.Controls.Editors.Primitives.RaiseEventDefinition<global::System.EventArgs>(this, this.TextChanged, new global::System.EventArgs()));
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00010834 File Offset: 0x0000EA34
		private static object OnCoerceText(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			string text = (string)valueAsObject;
			if (!valueInput._initialized)
			{
				return text;
			}
			return valueInput.OnCoerceText(text);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00010860 File Offset: 0x0000EA60
		protected virtual string OnCoerceText(string text)
		{
			return text;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00010863 File Offset: 0x0000EA63
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00010875 File Offset: 0x0000EA75
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Type ValueType
		{
			get
			{
				return (global::System.Type)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.ValueTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueTypeProperty, value);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00010884 File Offset: 0x0000EA84
		private static void OnValueTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			valueInput.ResolveValueType();
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000108A5 File Offset: 0x0000EAA5
		public bool ShouldSerializeValueType()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueInput.ValueTypeProperty);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000108B2 File Offset: 0x0000EAB2
		public void ResetValueType()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.ValueTypeProperty);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000108C0 File Offset: 0x0000EAC0
		private static void OnValueTypeNameChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)d;
			valueInput.ResolveValueType();
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000108E1 File Offset: 0x0000EAE1
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000108F3 File Offset: 0x0000EAF3
		public string ValueTypeName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.ValueTypeNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueTypeNameProperty, value);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00010904 File Offset: 0x0000EB04
		private static void OnValueTypeResolvedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)d;
			valueInput._cachedValueTypeResolved = (e.NewValue as global::System.Type);
			valueInput.OnValueTypeResolvedChanged(valueInput._cachedValueTypeResolved);
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00010940 File Offset: 0x0000EB40
		protected virtual void OnValueTypeResolvedChanged(global::System.Type newType)
		{
			if (this.InternalIsInitialized)
			{
				object value = this.Value;
				if (value != null)
				{
					this.CoerceValuePropertyHelper(global::Infragistics.Controls.Editors.ValueInput.ValueProperty);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0001096A File Offset: 0x0000EB6A
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00010972 File Offset: 0x0000EB72
		public global::System.Type ValueTypeResolved
		{
			get
			{
				return this._cachedValueTypeResolved;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueTypeResolvedPropertyKey, value);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00010980 File Offset: 0x0000EB80
		private static void OnValueConstraintChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = (global::Infragistics.Controls.Editors.ValueConstraint)e.NewValue;
			valueInput._cachedValueConstraint = valueConstraint;
			global::Infragistics.PropertyChangeListenerList.ManageListenerHelper<global::Infragistics.Controls.Editors.ValueConstraint>(ref valueInput._cachedValueConstraint, valueConstraint, valueInput, true);
			valueInput.ProcessPropertyChanged(e);
			valueInput.OnValueConstraintChanged(null);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000109C4 File Offset: 0x0000EBC4
		internal virtual void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			this.RevalidateCurrentValue();
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000109CC File Offset: 0x0000EBCC
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000109D4 File Offset: 0x0000EBD4
		public global::Infragistics.Controls.Editors.ValueConstraint ValueConstraint
		{
			get
			{
				return this._cachedValueConstraint;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueConstraintProperty, value);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000109E2 File Offset: 0x0000EBE2
		public bool ShouldSerializeValueConstraint()
		{
			return null != this.ValueConstraint;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000109F0 File Offset: 0x0000EBF0
		public void ResetValueConstraint()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.ValueConstraintProperty);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00010A00 File Offset: 0x0000EC00
		private static void OnInvalidValueBehaviorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			global::Infragistics.Controls.Editors.InvalidValueBehavior cachedInvalidValueBehavior = (global::Infragistics.Controls.Editors.InvalidValueBehavior)e.NewValue;
			valueInput._cachedInvalidValueBehavior = cachedInvalidValueBehavior;
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00010A2F File Offset: 0x0000EC2F
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00010A37 File Offset: 0x0000EC37
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.InvalidValueBehavior InvalidValueBehavior
		{
			get
			{
				return this._cachedInvalidValueBehavior;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.InvalidValueBehaviorProperty, value);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00010A4A File Offset: 0x0000EC4A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInvalidValueBehavior()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueInput.InvalidValueBehaviorProperty);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00010A57 File Offset: 0x0000EC57
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInvalidValueBehavior()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.InvalidValueBehaviorProperty);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00010A64 File Offset: 0x0000EC64
		private static void ValueToTextConverterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)d;
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00010A7F File Offset: 0x0000EC7F
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00010A91 File Offset: 0x0000EC91
		public global::System.Windows.Data.IValueConverter ValueToTextConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.ValueToTextConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueToTextConverterProperty, value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00010A9F File Offset: 0x0000EC9F
		public bool IsValueValid
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.IsValueValidProperty);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00010AB1 File Offset: 0x0000ECB1
		internal void SetIsValueValid(bool isValueValid, global::System.Exception error)
		{
			this.SetIsValueValid(isValueValid, (error != null) ? new global::Infragistics.Controls.Editors.ValidationErrorInfo(error) : null);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00010AC6 File Offset: 0x0000ECC6
		internal void SetIsValueValid(bool isValueValid, global::Infragistics.Controls.Editors.ValidationErrorInfo invalidValueErrorInfo)
		{
			base.SetValue(global::Infragistics.Controls.Editors.ValueInput.IsValueValidPropertyKey, global::Infragistics.KnownBoxes.FromValue(isValueValid));
			base.SetValue(global::Infragistics.Controls.Editors.ValueInput.InvalidValueErrorInfoPropertyKey, invalidValueErrorInfo);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00010AE5 File Offset: 0x0000ECE5
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasValueChanged
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.HasValueChangedProperty);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00010AF7 File Offset: 0x0000ECF7
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.ValidationErrorInfo InvalidValueErrorInfo
		{
			get
			{
				return (global::Infragistics.Controls.Editors.ValidationErrorInfo)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.InvalidValueErrorInfoProperty);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00010B0C File Offset: 0x0000ED0C
		internal bool IsNullable
		{
			get
			{
				global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = this.ValueConstraint;
				return valueConstraint == null || valueConstraint.Nullable == null || valueConstraint.Nullable.Value;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00010B44 File Offset: 0x0000ED44
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)target;
			valueInput.UpdateVisualStates();
			valueInput.OnIsReadOnlyChanged();
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00010B6B File Offset: 0x0000ED6B
		protected virtual void OnIsReadOnlyChanged()
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00010B6D File Offset: 0x0000ED6D
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00010B7F File Offset: 0x0000ED7F
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.ValueInput.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00010B92 File Offset: 0x0000ED92
		public bool ShouldSerializeIsReadOnly()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueInput.IsReadOnlyProperty);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00010B9F File Offset: 0x0000ED9F
		public void ResetIsReadOnly()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.IsReadOnlyProperty);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00010BAC File Offset: 0x0000EDAC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public object OriginalValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueInput.OriginalValueProperty);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00010BBC File Offset: 0x0000EDBC
		private static void OnFormatProviderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			global::System.IFormatProvider cachedFormatProvider = (global::System.IFormatProvider)e.NewValue;
			valueInput._cachedFormatProvider = cachedFormatProvider;
			valueInput._cachedFormatProviderResolved = null;
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00010BF2 File Offset: 0x0000EDF2
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00010BFA File Offset: 0x0000EDFA
		public global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._cachedFormatProvider;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty, value);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00010C08 File Offset: 0x0000EE08
		public bool ShouldSerializeFormatProvider()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00010C15 File Offset: 0x0000EE15
		public void ResetFormatProvider()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00010C24 File Offset: 0x0000EE24
		private static void OnFormatChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)dependencyObject;
			string cachedFormat = (string)e.NewValue;
			valueInput._cachedFormat = cachedFormat;
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00010C53 File Offset: 0x0000EE53
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public string Format
		{
			get
			{
				return this._cachedFormat;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.FormatProperty, value);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00010C6C File Offset: 0x0000EE6C
		public bool ShouldSerializeFormat()
		{
			string format = this.Format;
			return format != null && format.Length > 0;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00010C8E File Offset: 0x0000EE8E
		public void ResetFormat()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueInput.FormatProperty);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00010C9B File Offset: 0x0000EE9B
		protected virtual global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Controls.Editors.ValueInputDefaultConverter.ValueToTextConverter;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00010CA2 File Offset: 0x0000EEA2
		protected virtual global::System.Type DefaultValueType
		{
			get
			{
				return typeof(string);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00010CAE File Offset: 0x0000EEAE
		protected global::System.Windows.DependencyObject FocusSite
		{
			get
			{
				return this._focusSite;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00010CB6 File Offset: 0x0000EEB6
		internal virtual bool HasDropDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00010CB9 File Offset: 0x0000EEB9
		internal virtual bool HasOpenDropDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00010CBC File Offset: 0x0000EEBC
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00010CC5 File Offset: 0x0000EEC5
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x060002FB RID: 763
		public abstract bool CanEditType(global::System.Type type);

		// Token: 0x060002FC RID: 764
		public abstract bool CanRenderType(global::System.Type type);

		// Token: 0x060002FD RID: 765 RVA: 0x00010CCD File Offset: 0x0000EECD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public virtual bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return true;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00010CD0 File Offset: 0x0000EED0
		public void ValidateCurrentValue()
		{
			this.RevalidateCurrentValue();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00010CD8 File Offset: 0x0000EED8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual bool ValidateValue(object value, out global::System.Exception error)
		{
			return this.IsValueValidHelper(value, out error);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00010CE2 File Offset: 0x0000EEE2
		protected virtual void DoInitialization()
		{
			this.InitializeValueProperties();
		}

		// Token: 0x06000301 RID: 769
		protected abstract global::System.Windows.FrameworkElement GetFocusSite();

		// Token: 0x06000302 RID: 770 RVA: 0x00010CEC File Offset: 0x0000EEEC
		internal virtual void InitializeValueProperties()
		{
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsValuePropertySet(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, this))
			{
				this.CoerceValuePropertyHelper(global::Infragistics.Controls.Editors.ValueInput.ValueProperty);
				this.SyncValueProperties(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, this.Value);
				return;
			}
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsValuePropertySet(global::Infragistics.Controls.Editors.ValueInput.TextProperty, this))
			{
				this.CoerceValuePropertyHelper(global::Infragistics.Controls.Editors.ValueInput.TextProperty);
				this.SyncValueProperties(global::Infragistics.Controls.Editors.ValueInput.TextProperty, this.Text);
				return;
			}
			this.RevalidateCurrentValue();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00010D53 File Offset: 0x0000EF53
		public virtual void InitializeOriginalValueFromValue()
		{
			base.SetValue(global::Infragistics.Controls.Editors.ValueInput.OriginalValuePropertyKey, this.Value);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010D66 File Offset: 0x0000EF66
		protected virtual void OnFocusSiteChanged()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00010D68 File Offset: 0x0000EF68
		internal virtual void OnIsDropDownOpenChanged(bool isDropDownOpen)
		{
			if (this._wasTabStopDisabled)
			{
				base.SetCurrentValue(global::System.Windows.Controls.Control.IsTabStopProperty, global::Infragistics.KnownBoxes.FromValue(isDropDownOpen));
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00010D84 File Offset: 0x0000EF84
		internal virtual void OnIsInEditModeChanged(bool isInEditMode)
		{
			if (!isInEditMode)
			{
				if (this._wasTabStopDisabled)
				{
					this._wasTabStopDisabled = false;
					object obj = base.ReadLocalValue(global::System.Windows.Controls.Control.IsTabStopProperty);
					if (obj is bool && !(bool)obj)
					{
						base.SetCurrentValue(global::System.Windows.Controls.Control.IsTabStopProperty, global::Infragistics.KnownBoxes.TrueBox);
					}
				}
				global::Infragistics.Controls.Editors.EditModeValidationErrorEventArgs editModeValidationErrorEventArgs;
				bool flag;
				this.ValidateInputHelper(true, out editModeValidationErrorEventArgs, out flag);
			}
			if (isInEditMode && base.IsKeyboardFocusWithin && (this._lostFocusTracker == null || this._lostFocusTracker.ElementWithFocus != this._focusSite))
			{
				this.SetFocusToFocusSite();
			}
			this.UpdateVisualStates();
			if (isInEditMode && this.IsValueValid)
			{
				this.InitializeOriginalValueFromValue();
			}
			if (isInEditMode && base.IsTabStop)
			{
				base.SetCurrentValue(global::System.Windows.Controls.Control.IsTabStopProperty, global::Infragistics.KnownBoxes.FalseBox);
				this._wasTabStopDisabled = true;
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00010E3F File Offset: 0x0000F03F
		protected internal virtual void ProcessKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00010E48 File Offset: 0x0000F048
		public virtual void RevertValueBackToOriginalValue()
		{
			this.Value = this.OriginalValue;
			this.SyncValueProperties(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, this.Value);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00010E67 File Offset: 0x0000F067
		protected virtual bool ValidateFocusSite(object focusSite, out global::System.Exception errorMessage)
		{
			if (!(focusSite is global::System.Windows.Controls.Control))
			{
				errorMessage = new global::System.NotSupportedException("Focus site must be a Control.");
				return false;
			}
			errorMessage = null;
			return true;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00010E83 File Offset: 0x0000F083
		protected virtual bool ValidateCurrentValue(out global::System.Exception error)
		{
			return this.IsValueValidHelper(this.Value, out error);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00010E94 File Offset: 0x0000F094
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (this.IsReadOnly || !this.IsEditingAllowed)
			{
				if (base.IsMouseOver)
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"ReadOnly",
						"MouseOver",
						"Normal"
					});
				}
				else
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"ReadOnly",
						"Normal"
					});
				}
			}
			else if (base.IsMouseOver)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
			if (isKeyboardFocusWithin)
			{
				if (this.HasOpenDropDown)
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"FocusedDropDown",
						"Focused"
					});
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Focused", useTransitions);
				}
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfocused", useTransitions);
			}
			if (this.IsValueValid)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ValidEx", useTransitions);
				return;
			}
			if (isKeyboardFocusWithin)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "InvalidFocusedEx", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "InvalidUnfocusedEx", useTransitions);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00010FDC File Offset: 0x0000F1DC
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = target as global::Infragistics.Controls.Editors.ValueInput;
			if (valueInput != null)
			{
				valueInput.UpdateVisualStates();
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00010FF9 File Offset: 0x0000F1F9
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00011002 File Offset: 0x0000F202
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001101F File Offset: 0x0000F21F
		internal void BeginSyncValueProperties()
		{
			if (this._pendingPropertyChangedEvents == null)
			{
				this._pendingPropertyChangedEvents = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition>();
			}
			this._syncingValueProperties++;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00011044 File Offset: 0x0000F244
		internal void ConsiderIsInEditMode(string stateName, bool state)
		{
			if (state)
			{
				if (this._considerInEditModeAttributes == null)
				{
					this._considerInEditModeAttributes = new global::System.Collections.Generic.List<string>();
				}
				if (!this._considerInEditModeAttributes.Contains(stateName))
				{
					this._considerInEditModeAttributes.Add(stateName);
				}
			}
			else if (this._considerInEditModeAttributes != null)
			{
				this._considerInEditModeAttributes.Remove(stateName);
				if (this._considerInEditModeAttributes.Count == 0)
				{
					this._considerInEditModeAttributes = null;
				}
			}
			this.VerifyIsInEditMode();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000110B4 File Offset: 0x0000F2B4
		internal void EndSyncValueProperties()
		{
			this._syncingValueProperties--;
			if (!this.SyncingValueProperties && this._pendingPropertyChangedEvents != null && !this._processingPendingPropertyChangedEvents)
			{
				this._processingPendingPropertyChangedEvents = true;
				try
				{
					global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition> pendingPropertyChangedEvents = this._pendingPropertyChangedEvents;
					for (int i = 0; i < pendingPropertyChangedEvents.Count; i++)
					{
						this.RaiseEventHelper(pendingPropertyChangedEvents[i]);
					}
				}
				finally
				{
					this._pendingPropertyChangedEvents.Clear();
					this._pendingPropertyChangedEvents = null;
					this._processingPendingPropertyChangedEvents = false;
				}
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00011140 File Offset: 0x0000F340
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Editors.ValueInput.GetString(name, null);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00011149 File Offset: 0x0000F349
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00011154 File Offset: 0x0000F354
		internal bool HasValueChangedInternal(bool compareWithOriginalValue)
		{
			if (!this.HasValueChanged)
			{
				return false;
			}
			if (compareWithOriginalValue)
			{
				object originalValue = this.OriginalValue;
				object value = this.Value;
				bool flag = global::Infragistics.Controls.Editors.Primitives.Utils.IsValueEmpty(originalValue);
				bool flag2 = global::Infragistics.Controls.Editors.Primitives.Utils.IsValueEmpty(value);
				if ((flag && flag2) || global::Infragistics.Controls.Editors.Primitives.Utils.AreEqual(originalValue, value))
				{
					string a;
					global::System.Exception ex;
					this.ConvertValueToText(originalValue, out a, out ex);
					if (a == this.Text)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000111B8 File Offset: 0x0000F3B8
		internal static void OnProcessPropertyChangedCallback(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueInput valueInput = (global::Infragistics.Controls.Editors.ValueInput)d;
			valueInput.ProcessPropertyChanged(e);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000111D3 File Offset: 0x0000F3D3
		internal bool RaiseEventHelper(global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition args)
		{
			args.Raise();
			return true;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000111DC File Offset: 0x0000F3DC
		internal void RaiseValuePropertyChangedEvent(global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition e)
		{
			if (this.SyncingValueProperties && this._pendingPropertyChangedEvents != null)
			{
				this._pendingPropertyChangedEvents.Add(e);
				return;
			}
			this.RaiseEventHelper(e);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011204 File Offset: 0x0000F404
		internal void SetFocusToFocusSite()
		{
			if (this._focusSite != null)
			{
				global::System.Windows.Controls.Control control = this._focusSite as global::System.Windows.Controls.Control;
				if (control != null)
				{
					control.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
					return;
				}
				global::System.Windows.FrameworkContentElement frameworkContentElement = this._focusSite as global::System.Windows.FrameworkContentElement;
				if (frameworkContentElement != null)
				{
					frameworkContentElement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				}
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00011254 File Offset: 0x0000F454
		internal void ValidateInputHelper(bool fromLostFocus, out global::Infragistics.Controls.Editors.EditModeValidationErrorEventArgs eventArgs, out bool stayInEditMode)
		{
			eventArgs = null;
			stayInEditMode = false;
			if (!this._isInValidateInputHelper && !this.IsValueValid && (this.HasValueChangedInternal(true) || this.AlwaysValidateResolved))
			{
				this._isInValidateInputHelper = true;
				try
				{
					global::Infragistics.Controls.Editors.ValidationErrorInfo validationErrorInfo = this.InvalidValueErrorInfo;
					if (validationErrorInfo == null)
					{
						validationErrorInfo = new global::Infragistics.Controls.Editors.ValidationErrorInfo(new global::System.Exception(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_Exception_1")));
					}
					eventArgs = new global::Infragistics.Controls.Editors.EditModeValidationErrorEventArgs(this, validationErrorInfo.Exception, validationErrorInfo.ErrorMessage);
					this.RaiseValidationError(eventArgs);
					if (!this.IsValueValid)
					{
						switch (eventArgs.InvalidValueBehavior)
						{
						case global::Infragistics.Controls.Editors.InvalidValueBehavior.Default:
						case global::Infragistics.Controls.Editors.InvalidValueBehavior.DisplayErrorMessage:
							if (!string.IsNullOrEmpty(eventArgs.ErrorMessage) && this.CanShowErrorMessage())
							{
								global::Infragistics.Controls.Editors.Primitives.Utils.ShowMessageBox(this, eventArgs.ErrorMessage, global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_InvalidValue"), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
							}
							stayInEditMode = true;
							break;
						case global::Infragistics.Controls.Editors.InvalidValueBehavior.RetainValue:
							stayInEditMode = true;
							break;
						case global::Infragistics.Controls.Editors.InvalidValueBehavior.RevertValue:
							this.RevertValueBackToOriginalValue();
							break;
						}
					}
				}
				finally
				{
					this._isInValidateInputHelper = false;
				}
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00011358 File Offset: 0x0000F558
		internal bool CanShowErrorMessage()
		{
			global::System.Windows.UIElement uielement = global::Infragistics.Controls.PresentationUtilities.GetRootVisual(this) as global::System.Windows.UIElement;
			return uielement == null || uielement.IsVisible;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001137C File Offset: 0x0000F57C
		private void CoerceValuePropertyHelper(global::System.Windows.DependencyProperty property)
		{
			if (global::Infragistics.Controls.Editors.ValueInput.ValueProperty == property)
			{
				this.CoerceValueHelper();
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001138C File Offset: 0x0000F58C
		private void InitializeCachedPropertyValues()
		{
			this._cachedFormat = (string)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.ValueInput.FormatProperty);
			this._cachedFormatProvider = (global::System.IFormatProvider)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty);
			this._cachedInvalidValueBehavior = (global::Infragistics.Controls.Editors.InvalidValueBehavior)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.ValueInput.InvalidValueBehaviorProperty);
			this._cachedValueConstraint = (global::Infragistics.Controls.Editors.ValueConstraint)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.ValueInput.ValueConstraintProperty);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000113F4 File Offset: 0x0000F5F4
		private bool IsValueValidHelper(object value, out global::System.Exception error)
		{
			string text = null;
			error = null;
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = this.ValueConstraint;
			if (valueConstraint != null && !valueConstraint.Validate(value, this.ValueTypeResolved, global::Infragistics.Controls.Editors.ValueConstraintFlags.All, this.FormatProviderResolved, this.Format, ref text))
			{
				if (!string.IsNullOrEmpty(text))
				{
					error = new global::System.Exception(text);
				}
				return false;
			}
			if (value == null || global::System.DBNull.Value == value)
			{
				if (!this.IsNullable)
				{
					return false;
				}
			}
			else if (!this.ValueTypeResolved.IsInstanceOfType(value))
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0001146A File Offset: 0x0000F66A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool ConvertTextToValue(string text, out object value, out global::System.Exception error)
		{
			return this.ConvertTextToValueHelper(text, out value, out error);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00011478 File Offset: 0x0000F678
		internal virtual bool ConvertTextToValueHelper(string text, out object value, out global::System.Exception error)
		{
			error = null;
			value = null;
			try
			{
				value = this.ValueToTextConverterResolved.ConvertBack(text, this.ValueTypeResolved, this, this.FormatProviderResolved as global::System.Globalization.CultureInfo);
				if (value == null)
				{
					if (text != null && text.Length != 0)
					{
						error = global::Infragistics.Controls.Editors.Primitives.Utils.GetTextToValueConversionError(this.ValueTypeResolved, text);
						return false;
					}
					value = null;
				}
			}
			catch (global::System.Exception ex)
			{
				error = ex;
				return false;
			}
			return true;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool ConvertValueToText(object value, out string text, out global::System.Exception error)
		{
			error = null;
			text = null;
			try
			{
				text = (string)this.ValueToTextConverterResolved.Convert(value, typeof(string), this, this.FormatProviderResolved as global::System.Globalization.CultureInfo);
			}
			catch (global::System.Exception ex)
			{
				error = ex;
				return false;
			}
			return true;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001154C File Offset: 0x0000F74C
		internal void OnIsFocusWithinChangedHelper(bool gotFocus)
		{
			bool flag = false;
			if (gotFocus)
			{
				if (this._lostFocusTracker == null)
				{
					global::Infragistics.Controls.LostFocusTracker lostFocusTracker = new global::Infragistics.Controls.LostFocusTracker(this, new global::System.Action(this.OnLostFocusTrackerCallback));
					if (lostFocusTracker.IsActive)
					{
						this._lostFocusTracker = lostFocusTracker;
						flag = true;
					}
				}
			}
			else if (this._lostFocusTracker != null)
			{
				this._lostFocusTracker.Deactivate(false);
				this._lostFocusTracker = null;
				flag = true;
			}
			if (flag)
			{
				this.ConsiderIsInEditMode("IsKeyboardFocusWithin", gotFocus);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000115B8 File Offset: 0x0000F7B8
		private void OnLostFocusTrackerCallback()
		{
			this.OnIsFocusWithinChangedHelper(false);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000115C4 File Offset: 0x0000F7C4
		internal virtual void ProcessPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::Infragistics.Controls.Editors.ValueInput.ValueProperty)
			{
				if (!this.IsInEditMode)
				{
					this.InitializeOriginalValueFromValue();
					return;
				}
			}
			else if (property == global::Infragistics.Controls.Editors.ValueInput.IsReadOnlyProperty)
			{
				global::Infragistics.AutomationPeers.ValueInputAutomationPeer valueInputAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.AutomationPeers.ValueInputAutomationPeer;
				if (valueInputAutomationPeer != null)
				{
					valueInputAutomationPeer.RaiseReadOnlyPropertyChangedEvent((bool)e.OldValue, (bool)e.NewValue);
					return;
				}
			}
			else if (property == global::Infragistics.Controls.Editors.ValueInput.TextProperty)
			{
				global::Infragistics.AutomationPeers.ValueInputAutomationPeer valueInputAutomationPeer2 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.AutomationPeers.ValueInputAutomationPeer;
				if (valueInputAutomationPeer2 != null)
				{
					valueInputAutomationPeer2.RaiseValuePropertyChangedEvent((string)e.OldValue, (string)e.NewValue);
					return;
				}
			}
			else if (property == global::System.Windows.FrameworkElement.LanguageProperty || global::Infragistics.Controls.Editors.ValueInput.FormatProperty == property || global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty == property)
			{
				this._cachedFormatProviderResolved = null;
				this.SyncValueProperties(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, this.Value);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00011692 File Offset: 0x0000F892
		private void ResolveValueType()
		{
			this.ValueTypeResolved = global::Infragistics.TypeResolverUtilities.ResolveType(this, this.ValueType, this.ValueTypeName, this.DefaultValueType, "UnknownTypeName");
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000116B8 File Offset: 0x0000F8B8
		private void RevalidateCurrentValue()
		{
			global::System.Exception error;
			bool isValueValid = this.ValidateCurrentValueHelper(out error);
			this.SetIsValueValid(isValueValid, error);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000116D8 File Offset: 0x0000F8D8
		internal void SyncValueProperties(global::System.Windows.DependencyProperty prop, object newValue)
		{
			global::System.Exception error = null;
			if (this._initialized && !this._inSyncValueProperties)
			{
				this.BeginSyncValueProperties();
				this._inSyncValueProperties = true;
				try
				{
					bool flag = this.SyncValuePropertiesOverride(prop, newValue, out error);
					if (flag && !this.ValidateCurrentValueHelper(out error))
					{
						flag = false;
					}
					this.SetIsValueValid(flag, error);
				}
				finally
				{
					this._inSyncValueProperties = false;
					this.EndSyncValueProperties();
				}
			}
			if (this.IsInEditMode)
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.HasValueChangedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00011760 File Offset: 0x0000F960
		internal virtual bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			if (global::Infragistics.Controls.Editors.ValueInput.ValueProperty == prop)
			{
				string text;
				this.ConvertValueToText(newValue, out text, out error);
				this.Text = text;
			}
			else
			{
				if (global::Infragistics.Controls.Editors.ValueInput.TextProperty != prop)
				{
					error = new global::System.InvalidOperationException("This should only be called for Text and Value properties. Derived classes need to handle their own properties.");
					return false;
				}
				string text2 = (string)newValue;
				object value;
				this.ConvertTextToValueHelper(text2, out value, out error);
				this.Value = value;
			}
			return null == error;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000117C4 File Offset: 0x0000F9C4
		private bool ValidateCurrentValueHelper(out global::System.Exception error)
		{
			return this.ValidateCurrentValue(out error);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000117DC File Offset: 0x0000F9DC
		private void VerifyFocusSite()
		{
			global::System.Windows.DependencyObject focusSite = this.GetFocusSite();
			if (focusSite == null)
			{
				return;
			}
			global::System.Exception ex;
			if (!this.ValidateFocusSite(focusSite, out ex))
			{
				throw ex;
			}
			if (focusSite != this._focusSite)
			{
				this._focusSite = focusSite;
				this.OnFocusSiteChanged();
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00011817 File Offset: 0x0000FA17
		void global::Infragistics.ITypedPropertyChangeListener<object, string>.OnPropertyValueChanged(object dataItem, string property, object extraInfo)
		{
			if (this._cachedValueConstraint == dataItem)
			{
				this.OnValueConstraintChanged(property);
			}
		}

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.DependencyObject _focusSite;

		// Token: 0x040000F3 RID: 243
		private bool _initialized;

		// Token: 0x040000F4 RID: 244
		private int _syncingValueProperties;

		// Token: 0x040000F5 RID: 245
		internal bool _isInEndEditMode;

		// Token: 0x040000F6 RID: 246
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.IRaiseEventDefinition> _pendingPropertyChangedEvents;

		// Token: 0x040000F7 RID: 247
		private bool _processingPendingPropertyChangedEvents;

		// Token: 0x040000F8 RID: 248
		private global::System.IFormatProvider _cachedFormatProviderResolved;

		// Token: 0x040000F9 RID: 249
		private global::System.Type _cachedValueTypeResolved;

		// Token: 0x040000FA RID: 250
		private bool _hasVisualStateGroups;

		// Token: 0x040000FB RID: 251
		private bool _wasTabStopDisabled;

		// Token: 0x040000FC RID: 252
		private global::Infragistics.Controls.LostFocusTracker _lostFocusTracker;

		// Token: 0x040000FD RID: 253
		private global::System.Collections.Generic.List<string> _considerInEditModeAttributes;

		// Token: 0x040000FE RID: 254
		private bool _cachedIsInEditMode;

		// Token: 0x040000FF RID: 255
		private bool _isInValidateInputHelper;

		// Token: 0x04000100 RID: 256
		private bool _inSyncValueProperties;

		// Token: 0x04000102 RID: 258
		public static readonly global::System.Windows.DependencyProperty AlwaysValidateProperty = global::Infragistics.DependencyPropertyUtilities.Register("AlwaysValidate", typeof(bool?), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnAlwaysValidateChanged)));

		// Token: 0x04000103 RID: 259
		private static readonly global::System.Windows.DependencyPropertyKey IsInEditModePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsInEditMode", typeof(bool), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnIsInEditModeChanged));

		// Token: 0x04000104 RID: 260
		private static readonly global::System.Windows.DependencyProperty IsInEditModeProperty = global::Infragistics.Controls.Editors.ValueInput.IsInEditModePropertyKey.DependencyProperty;

		// Token: 0x04000105 RID: 261
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.DependencyPropertyUtilities.Register("Value", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnValueChanged), global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault | global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.Journal));

		// Token: 0x04000107 RID: 263
		public static readonly global::System.Windows.DependencyProperty TextProperty = global::Infragistics.DependencyPropertyUtilities.Register("Text", typeof(string), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnTextChanged), global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault));

		// Token: 0x04000109 RID: 265
		public static readonly global::System.Windows.DependencyProperty ValueTypeProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValueType", typeof(global::System.Type), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnValueTypeChanged)));

		// Token: 0x0400010A RID: 266
		public static readonly global::System.Windows.DependencyProperty ValueTypeNameProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValueTypeName", typeof(string), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnValueTypeNameChanged)));

		// Token: 0x0400010B RID: 267
		private static readonly global::System.Windows.DependencyPropertyKey ValueTypeResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ValueTypeResolved", typeof(global::System.Type), typeof(global::Infragistics.Controls.Editors.ValueInput), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnValueTypeResolvedChanged));

		// Token: 0x0400010C RID: 268
		public static readonly global::System.Windows.DependencyProperty ValueTypeResolvedProperty = global::Infragistics.Controls.Editors.ValueInput.ValueTypeResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400010D RID: 269
		public static readonly global::System.Windows.DependencyProperty ValueConstraintProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValueConstraint", typeof(global::Infragistics.Controls.Editors.ValueConstraint), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnValueConstraintChanged)));

		// Token: 0x0400010E RID: 270
		private global::Infragistics.Controls.Editors.ValueConstraint _cachedValueConstraint;

		// Token: 0x0400010F RID: 271
		public static readonly global::System.Windows.DependencyProperty InvalidValueBehaviorProperty = global::Infragistics.DependencyPropertyUtilities.Register("InvalidValueBehavior", typeof(global::Infragistics.Controls.Editors.InvalidValueBehavior), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.InvalidValueBehavior.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnInvalidValueBehaviorChanged)));

		// Token: 0x04000110 RID: 272
		private global::Infragistics.Controls.Editors.InvalidValueBehavior _cachedInvalidValueBehavior;

		// Token: 0x04000111 RID: 273
		public static readonly global::System.Windows.DependencyProperty ValueToTextConverterProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValueToTextConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Controls.Editors.ValueInput), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.ValueToTextConverterChanged));

		// Token: 0x04000112 RID: 274
		private static readonly global::System.Windows.DependencyPropertyKey IsValueValidPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsValueValid", typeof(bool), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnVisualStatePropertyChanged));

		// Token: 0x04000113 RID: 275
		public static readonly global::System.Windows.DependencyProperty IsValueValidProperty = global::Infragistics.Controls.Editors.ValueInput.IsValueValidPropertyKey.DependencyProperty;

		// Token: 0x04000114 RID: 276
		private static readonly global::System.Windows.DependencyPropertyKey HasValueChangedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("HasValueChanged", typeof(bool), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.KnownBoxes.FalseBox, null);

		// Token: 0x04000115 RID: 277
		public static readonly global::System.Windows.DependencyProperty HasValueChangedProperty = global::Infragistics.Controls.Editors.ValueInput.HasValueChangedPropertyKey.DependencyProperty;

		// Token: 0x04000116 RID: 278
		private static readonly global::System.Windows.DependencyPropertyKey InvalidValueErrorInfoPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("InvalidValueErrorInfo", typeof(global::Infragistics.Controls.Editors.ValidationErrorInfo), typeof(global::Infragistics.Controls.Editors.ValueInput), null, null);

		// Token: 0x04000117 RID: 279
		public static readonly global::System.Windows.DependencyProperty InvalidValueErrorInfoProperty = global::Infragistics.Controls.Editors.ValueInput.InvalidValueErrorInfoPropertyKey.DependencyProperty;

		// Token: 0x04000118 RID: 280
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsReadOnly", typeof(bool), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnIsReadOnlyChanged)));

		// Token: 0x04000119 RID: 281
		private static readonly global::System.Windows.DependencyPropertyKey OriginalValuePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("OriginalValue", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueInput), null, null);

		// Token: 0x0400011A RID: 282
		public static readonly global::System.Windows.DependencyProperty OriginalValueProperty = global::Infragistics.Controls.Editors.ValueInput.OriginalValuePropertyKey.DependencyProperty;

		// Token: 0x0400011B RID: 283
		public static readonly global::System.Windows.DependencyProperty FormatProviderProperty = global::Infragistics.DependencyPropertyUtilities.Register("FormatProvider", typeof(global::System.IFormatProvider), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnFormatProviderChanged)));

		// Token: 0x0400011C RID: 284
		private global::System.IFormatProvider _cachedFormatProvider;

		// Token: 0x0400011D RID: 285
		public static readonly global::System.Windows.DependencyProperty FormatProperty = global::Infragistics.DependencyPropertyUtilities.Register("Format", typeof(string), typeof(global::Infragistics.Controls.Editors.ValueInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnFormatChanged)));

		// Token: 0x0400011E RID: 286
		private string _cachedFormat;
	}
}
