using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Reporting;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Themes.Internal;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200001E RID: 30
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplatePart(Name = "PART_FocusSite", Type = typeof(global::System.Windows.DependencyObject))]
	[global::System.Windows.TemplateVisualState(Name = "Embedded", GroupName = "EmbeddedStates")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidUnfocusedEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "ReadOnly", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "NotEmbedded", GroupName = "EmbeddedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidFocusedEx", GroupName = "ValidationStatesEx")]
	public abstract class ValueEditor : global::System.Windows.Controls.Control, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00005000 File Offset: 0x00003200
		static ValueEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeEnded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeEnding", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeStarted", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeStarting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeValidationError", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.InSyncTextWithValueProperty = global::System.Windows.DependencyProperty.Register("InSyncTextWithValue", typeof(string), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty = global::System.Windows.DependencyProperty.Register("AlwaysValidate", typeof(bool?), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnAlwaysValidateChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnValueChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.ValueEditor.OnCoerceValue)));
			global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ValueChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<object>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.TextProperty = global::System.Windows.DependencyProperty.Register("Text", typeof(string), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnTextChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.ValueEditor.OnCoerceText)));
			global::Infragistics.Windows.Editors.ValueEditor.TextChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("TextChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<string>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty = global::System.Windows.DependencyProperty.Register("ValueType", typeof(global::System.Type), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(string), global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnValueTypeChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty = global::System.Windows.DependencyProperty.Register("ValueConstraint", typeof(global::Infragistics.Windows.Editors.ValueConstraint), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnValueConstraintChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty = global::System.Windows.DependencyProperty.Register("InvalidValueBehavior", typeof(global::Infragistics.Windows.Editors.InvalidValueBehavior), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.InvalidValueBehavior.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnInvalidValueBehaviorChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.ValueToTextConverterProperty = global::System.Windows.DependencyProperty.Register("ValueToTextConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.Editors.ValueEditor.IsValueValidPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsValueValid", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.IsValueValidProperty = global::Infragistics.Windows.Editors.ValueEditor.IsValueValidPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty = global::System.Windows.DependencyProperty.Register("EditTemplate", typeof(global::System.Windows.Controls.ControlTemplate), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnEditTemplateChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.EditTemplateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditTemplateChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<global::System.Windows.Controls.ControlTemplate>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasValueChanged", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedProperty = global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("InvalidValueErrorInfo", typeof(global::Infragistics.Windows.Editors.ValidationErrorInfo), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoProperty = global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.ValueEditor.IsAlwaysInEditModeProperty = global::System.Windows.DependencyProperty.Register("IsAlwaysInEditMode", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsEmbedded", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedProperty = global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.ValueEditor.IsFocusWithinProperty = global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty = global::System.Windows.DependencyProperty.Register("IsInEditMode", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.ValueEditor.CoerceIsInEditMode)));
			global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnIsReadOnlyChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.OriginalValuePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("OriginalValue", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.Editors.ValueEditor.OriginalValueProperty = global::Infragistics.Windows.Editors.ValueEditor.OriginalValuePropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty = global::System.Windows.DependencyProperty.Register("ReadOnly", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnReadOnlyChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnThemeChangedCallback)));
			global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty = global::System.Windows.DependencyProperty.Register("FormatProvider", typeof(global::System.IFormatProvider), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnFormatProviderChanged)));
			global::Infragistics.Windows.Editors.ValueEditor.FormatProperty = global::System.Windows.DependencyProperty.Register("Format", typeof(string), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnFormatChanged)));
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.Editors.ValueEditor), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping,
				global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsGeneric.Locator>.Location.Grouping
			});
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(string), typeof(global::Infragistics.Windows.Editors.XamTextEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(bool), typeof(global::Infragistics.Windows.Editors.XamCheckEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(decimal), typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(double), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(float), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(byte), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(sbyte), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(short), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(ushort), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(int), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(uint), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(long), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::Infragistics.Windows.Editors.ValueEditor.RegisterDefaultEditorForType(typeof(ulong), typeof(global::Infragistics.Windows.Editors.XamNumericEditor), false);
			global::System.Windows.Controls.Control.TemplateProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.ValueEditor.OnCoerceTemplate)));
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnVisualStatePropertyChanged)));
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000057E6 File Offset: 0x000039E6
		protected ValueEditor()
		{
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000057F4 File Offset: 0x000039F4
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000583A File Offset: 0x00003A3A
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyFocusSite();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000585B File Offset: 0x00003A5B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer(this);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005863 File Offset: 0x00003A63
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (!this._initialized)
			{
				this._initialized = true;
				this.DoInitialization();
				if (this._host == null && this.IsAlwaysInEditMode)
				{
					this.StartEditMode(false);
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000589C File Offset: 0x00003A9C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				this.SetFocusToFocusSite();
			}
			this.UpdateVisualStates();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000058CC File Offset: 0x00003ACC
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			if (this._host != null && this._host.OnValueEditorKeyDown(e))
			{
				return;
			}
			this.ProcessKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			if (this._host == null)
			{
				global::System.Windows.Input.Key key = e.Key;
				if (key != global::System.Windows.Input.Key.Return)
				{
					if (key != global::System.Windows.Input.Key.Escape)
					{
						if (key != global::System.Windows.Input.Key.F2)
						{
							return;
						}
						if (!this.IsAlwaysInEditMode)
						{
							if (this.IsInEditMode)
							{
								base.Focus();
								this.EndEditMode(true, false);
							}
							else
							{
								this.StartEditMode();
							}
							e.Handled = true;
						}
					}
					else if (this.IsInEditMode)
					{
						if (!this.IsAlwaysInEditMode)
						{
							base.Focus();
							this.EndEditMode(false, false);
						}
						else
						{
							this.RevertValueBackToOriginalValue();
						}
						e.Handled = true;
						return;
					}
				}
				else if (!this.IsAlwaysInEditMode && this.IsInEditMode)
				{
					base.Focus();
					this.EndEditMode(true, false);
					e.Handled = true;
					return;
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000059B6 File Offset: 0x00003BB6
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000059C5 File Offset: 0x00003BC5
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000059D4 File Offset: 0x00003BD4
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				e.Handled = this.StartEditModeOnMouseDownHelper();
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000059F4 File Offset: 0x00003BF4
		protected override void OnPreviewLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this.IsInEditMode)
			{
				global::System.Windows.IInputElement oldFocus = e.OldFocus;
				global::System.Windows.DependencyObject dependencyObject = e.NewFocus as global::System.Windows.DependencyObject;
				if (dependencyObject != null && global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject) == global::System.Windows.Input.FocusManager.GetFocusScope(this) && !global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOf(this, dependencyObject))
				{
					global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs editModeValidationErrorEventArgs;
					bool flag;
					this.ValidateInputHelper(true, false, out editModeValidationErrorEventArgs, out flag);
					if (editModeValidationErrorEventArgs != null && flag)
					{
						e.Handled = true;
					}
				}
			}
			base.OnPreviewLostKeyboardFocus(e);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005A58 File Offset: 0x00003C58
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.Controls.Control.TemplateProperty && base.IsKeyboardFocusWithin && !base.IsKeyboardFocused && this.IsFocusWithin)
			{
				base.Focus();
			}
			base.OnPropertyChanged(e);
			if (property == global::System.Windows.FrameworkElement.StyleProperty)
			{
				this.VerifyTemplateState();
				return;
			}
			if (property == global::System.Windows.Controls.Control.TemplateProperty)
			{
				if (this._focusSite != null)
				{
					this._focusSite = null;
					this.OnFocusSiteChanged();
				}
				this.VerifyTemplateState();
				this.VerifyFocusSite();
				return;
			}
			if (property == global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty)
			{
				this.VerifyTemplateState();
				return;
			}
			if (property == global::Infragistics.Windows.Editors.ValueEditor.ValueProperty)
			{
				if (!this.IsInEditMode || (this.IsAlwaysInEditMode && !this.IsFocusWithin))
				{
					this.InitializeOriginalValueFromValue();
					return;
				}
			}
			else if (property == global::Infragistics.Windows.Editors.ValueEditor.IsAlwaysInEditModeProperty)
			{
				if (this._host == null && base.IsInitialized)
				{
					if (this.IsAlwaysInEditMode)
					{
						if (!this.IsInEditMode)
						{
							this.StartEditMode(false);
							return;
						}
					}
					else if (this.IsInEditMode && !this.IsFocusWithin)
					{
						this.EndEditMode(true, false);
						return;
					}
				}
			}
			else
			{
				if (property == global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty)
				{
					this.VerifyTemplateState();
					return;
				}
				if (property == global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty)
				{
					this.OnIsFocusWithinChanged((bool)e.NewValue);
					return;
				}
				if (property == global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty)
				{
					global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer valueEditorAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer;
					if (valueEditorAutomationPeer != null)
					{
						valueEditorAutomationPeer.RaiseReadOnlyPropertyChangedEvent((bool)e.OldValue, (bool)e.NewValue);
						return;
					}
				}
				else if (property == global::Infragistics.Windows.Editors.ValueEditor.TextProperty)
				{
					global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer valueEditorAutomationPeer2 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer;
					if (valueEditorAutomationPeer2 != null)
					{
						valueEditorAutomationPeer2.RaiseValuePropertyChangedEvent((string)e.OldValue, (string)e.NewValue);
						return;
					}
				}
				else if (property == global::System.Windows.FrameworkElement.LanguageProperty || global::Infragistics.Windows.Editors.ValueEditor.FormatProperty == property || global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty == property)
				{
					this._cachedFormatProviderResolved = null;
					this.SyncTextWithValue();
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005C25 File Offset: 0x00003E25
		protected virtual void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeEnded(this, args);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005C37 File Offset: 0x00003E37
		internal void RaiseEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent;
			args.Source = this;
			this.OnEditModeEnded(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000106 RID: 262 RVA: 0x00005C52 File Offset: 0x00003E52
		// (remove) Token: 0x06000107 RID: 263 RVA: 0x00005C60 File Offset: 0x00003E60
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs> EditModeEnded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent, value);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005C6E File Offset: 0x00003E6E
		protected virtual void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeEnding(this, args);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005C80 File Offset: 0x00003E80
		internal void RaiseEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent;
			args.Source = this;
			this.OnEditModeEnding(args);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600010A RID: 266 RVA: 0x00005C9B File Offset: 0x00003E9B
		// (remove) Token: 0x0600010B RID: 267 RVA: 0x00005CA9 File Offset: 0x00003EA9
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs> EditModeEnding
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent, value);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005CB7 File Offset: 0x00003EB7
		protected virtual void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeStarted(this, args);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005CC9 File Offset: 0x00003EC9
		internal void RaiseEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent;
			args.Source = this;
			this.OnEditModeStarted(args);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600010E RID: 270 RVA: 0x00005CE4 File Offset: 0x00003EE4
		// (remove) Token: 0x0600010F RID: 271 RVA: 0x00005CF2 File Offset: 0x00003EF2
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs> EditModeStarted
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent, value);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005D00 File Offset: 0x00003F00
		protected virtual void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeStarting(this, args);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005D12 File Offset: 0x00003F12
		internal void RaiseEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent;
			args.Source = this;
			this.OnEditModeStarting(args);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000112 RID: 274 RVA: 0x00005D2D File Offset: 0x00003F2D
		// (remove) Token: 0x06000113 RID: 275 RVA: 0x00005D3B File Offset: 0x00003F3B
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs> EditModeStarting
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent, value);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005D49 File Offset: 0x00003F49
		protected virtual void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeValidationError(this, args);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005D5B File Offset: 0x00003F5B
		internal void RaiseEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent;
			args.Source = this;
			this.OnEditModeValidationError(args);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000116 RID: 278 RVA: 0x00005D76 File Offset: 0x00003F76
		// (remove) Token: 0x06000117 RID: 279 RVA: 0x00005D84 File Offset: 0x00003F84
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs> EditModeValidationError
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00005D94 File Offset: 0x00003F94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
		public bool AlwaysValidateResolved
		{
			get
			{
				bool? alwaysValidate = this.AlwaysValidate;
				if (alwaysValidate != null)
				{
					return alwaysValidate.Value;
				}
				return this._host != null && this._host.AlwaysValidate;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00005DD0 File Offset: 0x00003FD0
		internal global::System.Globalization.CultureInfo CultureInfoResolved
		{
			get
			{
				global::System.Globalization.CultureInfo cultureInfo = this.FormatProviderResolved as global::System.Globalization.CultureInfo;
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
				return this.LanguageCultureInfo;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005DF4 File Offset: 0x00003FF4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00005E10 File Offset: 0x00004010
		private global::System.IFormatProvider InternalFormatProviderResolved
		{
			get
			{
				global::System.IFormatProvider formatProvider = this.FormatProvider;
				if (formatProvider != null)
				{
					return formatProvider;
				}
				return this.LanguageCultureInfo;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00005E30 File Offset: 0x00004030
		internal global::Infragistics.Windows.Editors.InvalidValueBehavior InvalidValueBehaviorResolved
		{
			get
			{
				global::Infragistics.Windows.Editors.InvalidValueBehavior invalidValueBehavior = this.InvalidValueBehavior;
				if (invalidValueBehavior == global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
				{
					if (this._host != null)
					{
						invalidValueBehavior = this._host.DefaultInvalidValueBehavior;
					}
					if (invalidValueBehavior == global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
					{
						invalidValueBehavior = global::Infragistics.Windows.Editors.InvalidValueBehavior.DisplayErrorMessage;
					}
				}
				return invalidValueBehavior;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00005E61 File Offset: 0x00004061
		internal bool InternalIsInitialized
		{
			get
			{
				return this._initialized;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005E69 File Offset: 0x00004069
		internal bool InternalIsInitializing
		{
			get
			{
				return this._isInitializing;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00005E71 File Offset: 0x00004071
		internal bool IsEditingAllowed
		{
			get
			{
				return this.Host == null || this.Host.IsEditingAllowed;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00005E88 File Offset: 0x00004088
		internal global::System.Globalization.CultureInfo LanguageCultureInfo
		{
			get
			{
				return global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00005E90 File Offset: 0x00004090
		internal bool SyncingValueProperties
		{
			get
			{
				return this._syncingValueProperties > 0;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00005E9C File Offset: 0x0000409C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00005EBB File Offset: 0x000040BB
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00005ECD File Offset: 0x000040CD
		[global::System.ComponentModel.Bindable(true)]
		public bool? AlwaysValidate
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty, value);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005EE0 File Offset: 0x000040E0
		private static void OnAlwaysValidateChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			bool? flag = (bool?)e.NewValue;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005EEF File Offset: 0x000040EF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAlwaysValidate()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty, this);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005EFC File Offset: 0x000040FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAlwaysValidate()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005F09 File Offset: 0x00004109
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00005F16 File Offset: 0x00004116
		[global::System.ComponentModel.Bindable(true)]
		public object Value
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, value);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005F24 File Offset: 0x00004124
		private static void OnValueChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			if (!valueEditor._initialized)
			{
				return;
			}
			if (object.Equals(e.OldValue, e.NewValue))
			{
				return;
			}
			valueEditor.BeginSyncValueProperties();
			try
			{
				valueEditor.SyncValueProperties(e.Property, e.NewValue);
				valueEditor.OnValueChanged(e.OldValue, e.NewValue);
			}
			finally
			{
				valueEditor.EndSyncValueProperties();
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005FA0 File Offset: 0x000041A0
		protected virtual void OnValueChanged(object previousValue, object currentValue)
		{
			if (this._host != null && !this._isEnteringEditMode)
			{
				this._host.OnValueChanged();
			}
			this.RaiseValuePropertyChangedEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<object>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600012C RID: 300 RVA: 0x00005FE9 File Offset: 0x000041E9
		// (remove) Token: 0x0600012D RID: 301 RVA: 0x00005FF7 File Offset: 0x000041F7
		public event global::System.Windows.RoutedPropertyChangedEventHandler<object> ValueChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent, value);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006008 File Offset: 0x00004208
		private static object OnCoerceValue(global::System.Windows.DependencyObject dependencyObject, object value)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			if (!valueEditor._initialized)
			{
				return value;
			}
			return valueEditor.OnCoerceValue(value);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000602D File Offset: 0x0000422D
		protected virtual object OnCoerceValue(object val)
		{
			if (val != null && global::System.DBNull.Value != val && !this.ValueType.IsInstanceOfType(val))
			{
				val = global::Infragistics.CoreUtilities.ConvertDataValue(val, this.ValueType, this.FormatProviderResolved, this.Format);
			}
			return val;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00006063 File Offset: 0x00004263
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00006075 File Offset: 0x00004275
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public string Text
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.TextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006083 File Offset: 0x00004283
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000608B File Offset: 0x0000428B
		internal string Text_CurrentValue
		{
			get
			{
				return this.Text;
			}
			set
			{
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.TextProperty, value);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000609C File Offset: 0x0000429C
		private static void OnTextChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			if (!valueEditor._initialized)
			{
				return;
			}
			string text = (string)e.NewValue;
			string text2 = (string)valueEditor.GetValue(global::Infragistics.Windows.Editors.ValueEditor.InSyncTextWithValueProperty);
			if (text2 == null || text != text2)
			{
				valueEditor.SyncValueProperties(e.Property, text);
			}
			valueEditor.OnTextChanged((string)e.OldValue, text);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006104 File Offset: 0x00004304
		protected virtual void OnTextChanged(string previousValue, string currentValue)
		{
			this.RaiseValuePropertyChangedEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.TextChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000136 RID: 310 RVA: 0x00006132 File Offset: 0x00004332
		// (remove) Token: 0x06000137 RID: 311 RVA: 0x00006140 File Offset: 0x00004340
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> TextChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.TextChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.TextChangedEvent, value);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006150 File Offset: 0x00004350
		private static object OnCoerceText(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			string text = (string)valueAsObject;
			if (!valueEditor._initialized)
			{
				return text;
			}
			return valueEditor.OnCoerceText(text);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000617C File Offset: 0x0000437C
		protected virtual string OnCoerceText(string text)
		{
			return text;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000617F File Offset: 0x0000437F
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00006187 File Offset: 0x00004387
		public global::System.Type ValueType
		{
			get
			{
				return this._cachedValueType;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, value);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006198 File Offset: 0x00004398
		private static void OnValueTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::System.Type type = (global::System.Type)e.NewValue;
			valueEditor._cachedValueType = type;
			valueEditor.OnValueTypeChanged(type);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000061C8 File Offset: 0x000043C8
		protected virtual void OnValueTypeChanged(global::System.Type newType)
		{
			if (this.InternalIsInitialized)
			{
				object value = this.Value;
				if (value != null)
				{
					base.CoerceValue(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty);
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000061F2 File Offset: 0x000043F2
		public bool ShouldSerializeValueType()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, this);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000061FF File Offset: 0x000043FF
		public void ResetValueType()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000620C File Offset: 0x0000440C
		private static void OnValueConstraintChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::Infragistics.Windows.Editors.ValueConstraint newVal = (global::Infragistics.Windows.Editors.ValueConstraint)e.NewValue;
			valueEditor.InternalSetCachedValueConstraintHelper(newVal);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006234 File Offset: 0x00004434
		private void InternalSetCachedValueConstraintHelper(global::Infragistics.Windows.Editors.ValueConstraint newVal)
		{
			global::Infragistics.Windows.Editors.ValueConstraint cachedValueConstraint = this._cachedValueConstraint;
			if (cachedValueConstraint != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(cachedValueConstraint, this, string.Empty);
			}
			this._cachedValueConstraint = newVal;
			if (newVal != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(newVal, this, string.Empty);
			}
			if (this._initialized)
			{
				this.OnValueConstraintChanged(null);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000627C File Offset: 0x0000447C
		internal virtual void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			this.RevalidateCurrentValue();
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006284 File Offset: 0x00004484
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000628C File Offset: 0x0000448C
		public global::Infragistics.Windows.Editors.ValueConstraint ValueConstraint
		{
			get
			{
				return this._cachedValueConstraint;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty, value);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000629A File Offset: 0x0000449A
		public bool ShouldSerializeValueConstraint()
		{
			return null != this.ValueConstraint;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000062A8 File Offset: 0x000044A8
		public void ResetValueConstraint()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000062B8 File Offset: 0x000044B8
		private static void OnInvalidValueBehaviorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::Infragistics.Windows.Editors.InvalidValueBehavior cachedInvalidValueBehavior = (global::Infragistics.Windows.Editors.InvalidValueBehavior)e.NewValue;
			valueEditor._cachedInvalidValueBehavior = cachedInvalidValueBehavior;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000062E0 File Offset: 0x000044E0
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000062E8 File Offset: 0x000044E8
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.InvalidValueBehavior InvalidValueBehavior
		{
			get
			{
				return this._cachedInvalidValueBehavior;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty, value);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000062FB File Offset: 0x000044FB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInvalidValueBehavior()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty, this);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006308 File Offset: 0x00004508
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInvalidValueBehavior()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006315 File Offset: 0x00004515
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00006327 File Offset: 0x00004527
		public global::System.Windows.Data.IValueConverter ValueToTextConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueToTextConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueToTextConverterProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006335 File Offset: 0x00004535
		public bool IsValueValid
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsValueValidProperty);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006347 File Offset: 0x00004547
		internal void SetIsValueValid(bool isValueValid, global::System.Exception error)
		{
			this.SetIsValueValid(isValueValid, (error != null) ? new global::Infragistics.Windows.Editors.ValidationErrorInfo(error) : null);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000635C File Offset: 0x0000455C
		internal void SetIsValueValid(bool isValueValid, global::Infragistics.Windows.Editors.ValidationErrorInfo invalidValueErrorInfo)
		{
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsValueValidPropertyKey, global::Infragistics.KnownBoxes.FromValue(isValueValid));
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoPropertyKey, invalidValueErrorInfo);
			if (this._host != null)
			{
				this._host.OnValueValidated();
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006390 File Offset: 0x00004590
		private static void OnEditTemplateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				global::System.Windows.Controls.ControlTemplate controlTemplate = (global::System.Windows.Controls.ControlTemplate)e.NewValue;
				if (controlTemplate != valueEditor._cachedEditTemplate)
				{
					global::System.Windows.Controls.ControlTemplate cachedEditTemplate = valueEditor._cachedEditTemplate;
					valueEditor._cachedEditTemplate = controlTemplate;
					valueEditor.CoerceValue(global::System.Windows.Controls.Control.TemplateProperty);
					valueEditor.OnEditTemplateChanged(cachedEditTemplate, controlTemplate);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000063DE File Offset: 0x000045DE
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000063E6 File Offset: 0x000045E6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ControlTemplate EditTemplate
		{
			get
			{
				return this._cachedEditTemplate;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, value);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000063F4 File Offset: 0x000045F4
		protected virtual void OnEditTemplateChanged(global::System.Windows.Controls.ControlTemplate previousValue, global::System.Windows.Controls.ControlTemplate currentValue)
		{
			this.RaiseEventHelper(new global::System.Windows.RoutedPropertyChangedEventArgs<global::System.Windows.Controls.ControlTemplate>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditTemplateChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000155 RID: 341 RVA: 0x00006423 File Offset: 0x00004623
		// (remove) Token: 0x06000156 RID: 342 RVA: 0x00006431 File Offset: 0x00004631
		public event global::System.Windows.RoutedPropertyChangedEventHandler<global::System.Windows.Controls.ControlTemplate> EditTemplateChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateChangedEvent, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000643F File Offset: 0x0000463F
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(false)]
		public bool HasValueChanged
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedProperty);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006451 File Offset: 0x00004651
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.ValidationErrorInfo InvalidValueErrorInfo
		{
			get
			{
				return (global::Infragistics.Windows.Editors.ValidationErrorInfo)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoProperty);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006464 File Offset: 0x00004664
		internal bool IsNullable
		{
			get
			{
				global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = this.ValueConstraint;
				return valueConstraint == null || valueConstraint.Nullable == null || valueConstraint.Nullable.Value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000649B File Offset: 0x0000469B
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000064AD File Offset: 0x000046AD
		[global::System.ComponentModel.Bindable(true)]
		public bool IsAlwaysInEditMode
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsAlwaysInEditModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsAlwaysInEditModeProperty, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000064C0 File Offset: 0x000046C0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsEmbedded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedProperty);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000064D2 File Offset: 0x000046D2
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsFocusWithin
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000064E4 File Offset: 0x000046E4
		private static object CoerceIsInEditMode(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null && value is bool)
			{
				if (valueEditor._isInEditMode != (bool)value)
				{
					if ((bool)value)
					{
						valueEditor.StartEditMode();
					}
					else
					{
						valueEditor.EndEditMode(true, false);
					}
				}
				return valueEditor._isInEditMode;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000653B File Offset: 0x0000473B
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000654D File Offset: 0x0000474D
		[global::System.ComponentModel.Bindable(true)]
		public bool IsInEditMode
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty, value);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006560 File Offset: 0x00004760
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)target;
			if (!object.Equals(valueEditor.GetValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty), e.NewValue))
			{
				valueEditor.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty, e.NewValue);
			}
			valueEditor.UpdateVisualStates();
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000065A5 File Offset: 0x000047A5
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000065B7 File Offset: 0x000047B7
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000065CA File Offset: 0x000047CA
		public bool ShouldSerializeIsReadOnly()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty, this);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000065D7 File Offset: 0x000047D7
		public void ResetIsReadOnly()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000065E4 File Offset: 0x000047E4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object OriginalValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.OriginalValueProperty);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000065F4 File Offset: 0x000047F4
		private static void OnReadOnlyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)target;
			if (!object.Equals(valueEditor.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty), e.NewValue))
			{
				valueEditor.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty, e.NewValue);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00006633 File Offset: 0x00004833
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00006645 File Offset: 0x00004845
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Obsolete("This property has been obsoleted. Use 'IsReadOnly' property instead.", false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool ReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty, value);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006658 File Offset: 0x00004858
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Obsolete("This method has been obsoleted. Use 'ShouldSerializeIsReadOnly' method instead.", false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeReadOnly()
		{
			return false;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000665B File Offset: 0x0000485B
		[global::System.Obsolete("This method has been obsoleted. Use 'ResetIsReadOnly' method instead.", false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public void ResetReadOnly()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006668 File Offset: 0x00004868
		private static void OnThemeChangedCallback(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			valueEditor.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000669A File Offset: 0x0000489A
		protected virtual void OnThemeChanged(string newTheme, string oldTheme)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000669C File Offset: 0x0000489C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x000066AE File Offset: 0x000048AE
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.EditorsThemeTypeConverter))]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ThemeProperty, value);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000066BC File Offset: 0x000048BC
		private static void OnFormatProviderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::System.IFormatProvider cachedFormatProvider = (global::System.IFormatProvider)e.NewValue;
			valueEditor._cachedFormatProvider = cachedFormatProvider;
			valueEditor._cachedFormatProviderResolved = null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000066EB File Offset: 0x000048EB
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000066F3 File Offset: 0x000048F3
		public global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._cachedFormatProvider;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty, value);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006701 File Offset: 0x00004901
		public bool ShouldSerializeFormatProvider()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty, this);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000670E File Offset: 0x0000490E
		public void ResetFormatProvider()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000671C File Offset: 0x0000491C
		private static void OnFormatChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			string cachedFormat = (string)e.NewValue;
			valueEditor._cachedFormat = cachedFormat;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00006744 File Offset: 0x00004944
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000674C File Offset: 0x0000494C
		public string Format
		{
			get
			{
				return this._cachedFormat;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.FormatProperty, value);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000675C File Offset: 0x0000495C
		public bool ShouldSerializeFormat()
		{
			string format = this.Format;
			return format != null && format.Length > 0;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000677E File Offset: 0x0000497E
		public void ResetFormat()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.FormatProperty);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000678B File Offset: 0x0000498B
		protected virtual global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ValueEditorDefaultConverter.ValueToTextConverter;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006792 File Offset: 0x00004992
		protected global::System.Windows.DependencyObject FocusSite
		{
			get
			{
				return this._focusSite;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000679A File Offset: 0x0000499A
		internal virtual bool HasDropDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000679D File Offset: 0x0000499D
		internal virtual bool HasOpenDropDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000067A0 File Offset: 0x000049A0
		public global::Infragistics.Windows.Editors.ValuePresenter Host
		{
			get
			{
				return this._host;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000067A8 File Offset: 0x000049A8
		protected bool SupportsAsyncOperations
		{
			get
			{
				if (this._host != null)
				{
					return this._host.SupportsAsyncOperations;
				}
				return !global::Infragistics.Windows.Reporting.ReportSection.GetIsInReport(this);
			}
		}

		// Token: 0x06000180 RID: 384
		public abstract bool CanEditType(global::System.Type type);

		// Token: 0x06000181 RID: 385
		public abstract bool CanRenderType(global::System.Type type);

		// Token: 0x06000182 RID: 386 RVA: 0x000067C8 File Offset: 0x000049C8
		public void EndEditMode(bool acceptChanges, bool force)
		{
			if (this._host == null && this.IsAlwaysInEditMode)
			{
				return;
			}
			if (!this._isInEditMode)
			{
				return;
			}
			if (this._isInEndEditMode)
			{
				return;
			}
			this._isInEndEditMode = true;
			try
			{
				global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs editModeEndingEventArgs = new global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs(acceptChanges, force);
				this.RaiseEditModeEnding(editModeEndingEventArgs);
				bool flag = this.HasValueChangedInternal(true);
				if (!editModeEndingEventArgs.Cancel && editModeEndingEventArgs.AcceptChanges && !this.IsValueValid && (flag || this.AlwaysValidateResolved))
				{
					global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs editModeValidationErrorEventArgs;
					bool flag2;
					this.ValidateInputHelper(false, editModeEndingEventArgs.Force, out editModeValidationErrorEventArgs, out flag2);
					if (flag2 && !editModeEndingEventArgs.Force)
					{
						editModeEndingEventArgs.Cancel = true;
					}
					else if (!this.IsValueValid)
					{
						editModeEndingEventArgs.AcceptChanges = false;
					}
				}
				if (!editModeEndingEventArgs.Cancel && flag)
				{
					if (!editModeEndingEventArgs.AcceptChanges)
					{
						this.RevertValueBackToOriginalValue();
					}
					else if (this._host != null)
					{
						bool flag3;
						this._host.CommitEditValue(this.Value, out flag3);
						if (flag3 && !editModeEndingEventArgs.Force)
						{
							editModeEndingEventArgs.Cancel = true;
						}
					}
				}
				if (editModeEndingEventArgs.Cancel && !editModeEndingEventArgs.Force)
				{
					if (this.IsFocusWithin)
					{
						this.SetFocusToFocusSite();
					}
				}
				else
				{
					this._isInEditMode = false;
					this.IsInEditMode = false;
					this.SyncTextWithValue();
					this.RaiseEditModeEnded(new global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs(editModeEndingEventArgs.AcceptChanges));
					base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
			}
			finally
			{
				this._isInEndEditMode = false;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006934 File Offset: 0x00004B34
		public static global::System.Type GetDefaultEditorForType(global::System.Type dataType)
		{
			if (dataType == null)
			{
				throw new global::System.ArgumentNullException("dataType");
			}
			global::System.Type result;
			lock (typeof(global::Infragistics.Windows.Editors.ValueEditor))
			{
				if (global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors == null)
				{
					result = null;
				}
				else if (global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors.ContainsKey(dataType))
				{
					result = global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors[dataType];
				}
				else
				{
					global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(dataType);
					if (null != underlyingType && dataType != underlyingType && global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors.ContainsKey(underlyingType))
					{
						result = global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors[underlyingType];
					}
					else if (typeof(global::System.Windows.Media.ImageSource).IsAssignableFrom(dataType))
					{
						result = null;
					}
					else
					{
						global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(dataType);
						if (converter != null && converter.CanConvertFrom(typeof(string)) && converter.CanConvertTo(typeof(string)))
						{
							result = typeof(global::Infragistics.Windows.Editors.XamTextEditor);
						}
						else
						{
							result = null;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006A3C File Offset: 0x00004C3C
		public void InitializeHostInfo(global::Infragistics.Windows.Editors.ValuePresenter host, object hostContext)
		{
			this._host = host;
			this._hostContext = hostContext;
			global::Infragistics.Windows.Editors.ValuePresenter host2 = this._host;
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._host != null));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006A6F File Offset: 0x00004C6F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public virtual bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return true;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006A74 File Offset: 0x00004C74
		public static void RegisterDefaultEditorForType(global::System.Type dataType, global::System.Type editorType, bool overlayExisting)
		{
			if (dataType == null)
			{
				throw new global::System.ArgumentNullException("dataType");
			}
			if (editorType == null)
			{
				throw new global::System.ArgumentNullException("editorType");
			}
			if (typeof(global::Infragistics.Windows.Editors.ValueEditor).IsAssignableFrom(dataType))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_6"), "dataType");
			}
			if (!typeof(global::Infragistics.Windows.Editors.ValueEditor).IsAssignableFrom(editorType))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_7"), "editorType");
			}
			lock (typeof(global::Infragistics.Windows.Editors.ValueEditor))
			{
				if (global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors == null)
				{
					global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type>();
				}
				if (global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors.ContainsKey(dataType))
				{
					if (overlayExisting)
					{
						global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors[dataType] = editorType;
					}
				}
				else
				{
					global::Infragistics.Windows.Editors.ValueEditor.g_defaultEditors.Add(dataType, editorType);
				}
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006B64 File Offset: 0x00004D64
		public bool StartEditMode()
		{
			return this.StartEditMode(true);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006B70 File Offset: 0x00004D70
		private bool StartEditMode(bool takeFocus)
		{
			if (this._isInEditMode)
			{
				return true;
			}
			if (!this.IsEditingAllowed)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs editModeStartingEventArgs = new global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs();
			this.RaiseEditModeStarting(editModeStartingEventArgs);
			if (editModeStartingEventArgs.Cancel)
			{
				return false;
			}
			this._isEnteringEditMode = true;
			try
			{
				this.InitializeOriginalValueFromValue();
				this._isInEditMode = true;
				this.IsInEditMode = true;
				this.SyncTextWithValue();
				if (this.AlwaysValidateResolved)
				{
					this.RevalidateCurrentValue();
				}
				base.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				if (takeFocus)
				{
					this.SetFocusToFocusSite();
				}
				if (this._host != null && this is global::Infragistics.Windows.Editors.ISupportsSelectableText && this._isInEditMode)
				{
					((global::Infragistics.Windows.Editors.ISupportsSelectableText)this).SelectAll();
				}
			}
			finally
			{
				this._isEnteringEditMode = false;
			}
			if (this._isInEditMode)
			{
				this.RaiseEditModeStarted(new global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs());
			}
			return true;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006C50 File Offset: 0x00004E50
		public void ValidateCurrentValue()
		{
			this.RevalidateCurrentValue();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006C58 File Offset: 0x00004E58
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual bool ValidateValue(object value, out global::System.Exception error)
		{
			return this.IsValueValidHelper(value, out error);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006C62 File Offset: 0x00004E62
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool ConvertTextToValue(string text, out object value, out global::System.Exception error)
		{
			return this.ConvertTextToValueHelper(text, out value, out error);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00006C70 File Offset: 0x00004E70
		internal virtual bool ConvertTextToValueHelper(string text, out object value, out global::System.Exception error)
		{
			error = null;
			value = null;
			try
			{
				value = this.ValueToTextConverterResolved.ConvertBack(text, this.ValueType, this, this.FormatProviderResolved as global::System.Globalization.CultureInfo);
				if (value == null)
				{
					if (text != null && text.Length != 0)
					{
						error = global::Infragistics.Windows.Editors.Utils.GetTextToValueConversionError(this.ValueType, text);
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

		// Token: 0x0600018D RID: 397 RVA: 0x00006CE8 File Offset: 0x00004EE8
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

		// Token: 0x0600018E RID: 398 RVA: 0x00006D44 File Offset: 0x00004F44
		protected virtual void DoInitialization()
		{
			this._isInitializing = true;
			try
			{
				this.InitializeValueProperties();
			}
			finally
			{
				this._isInitializing = false;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006D78 File Offset: 0x00004F78
		internal virtual void InitializeValueProperties()
		{
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, this))
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty);
				this.SyncValueProperties(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, this.Value);
				return;
			}
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, this))
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.ValueEditor.TextProperty);
				this.SyncValueProperties(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, this.Text);
				return;
			}
			this.RevalidateCurrentValue();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00006DDF File Offset: 0x00004FDF
		protected virtual void InitializeOriginalValueFromValue()
		{
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.OriginalValuePropertyKey, this.Value);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006DF2 File Offset: 0x00004FF2
		protected virtual void OnFocusSiteChanged()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006DF4 File Offset: 0x00004FF4
		protected virtual void OnIsFocusWithinChanged(bool gotFocus)
		{
			if (!gotFocus)
			{
				if (this._host == null && this.IsAlwaysInEditMode && this.IsInEditMode)
				{
					global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs editModeValidationErrorEventArgs;
					bool flag;
					this.ValidateInputHelper(true, false, out editModeValidationErrorEventArgs, out flag);
				}
				if (this._host == null && this.IsInEditMode && !this.IsAlwaysInEditMode)
				{
					this.EndEditMode(true, false);
					return;
				}
			}
			else
			{
				if (this._host == null && !this.IsInEditMode && !this._isEnteringEditMode)
				{
					this.StartEditMode();
					return;
				}
				if (this._host == null && this.IsInEditMode && this.IsAlwaysInEditMode)
				{
					this.InitializeOriginalValueFromValue();
				}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006E87 File Offset: 0x00005087
		protected internal virtual void ProcessKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006E89 File Offset: 0x00005089
		protected virtual void RevertValueBackToOriginalValue()
		{
			this.Value = this.OriginalValue;
			this.SyncTextWithValue();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006E9E File Offset: 0x0000509E
		protected void VerifyTemplateState()
		{
			base.CoerceValue(global::System.Windows.Controls.Control.TemplateProperty);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006EAC File Offset: 0x000050AC
		protected virtual bool ValidateFocusSite(object focusSite, out global::System.Exception errorMessage)
		{
			errorMessage = null;
			global::System.Windows.FrameworkElement frameworkElement = focusSite as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkContentElement frameworkContentElement = focusSite as global::System.Windows.FrameworkContentElement;
			if (frameworkElement == null && frameworkContentElement == null)
			{
				errorMessage = new global::System.NotSupportedException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_3", new object[]
				{
					focusSite.GetType().Name
				}));
				return false;
			}
			return true;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006EFA File Offset: 0x000050FA
		protected virtual bool ValidateCurrentValue(out global::System.Exception error)
		{
			return this.IsValueValidHelper(this.Value, out error);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006F0C File Offset: 0x0000510C
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
			if (this.IsEmbedded)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Embedded", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "NotEmbedded", useTransitions);
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

		// Token: 0x06000199 RID: 409 RVA: 0x00007078 File Offset: 0x00005278
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				valueEditor.UpdateVisualStates();
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007095 File Offset: 0x00005295
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000709E File Offset: 0x0000529E
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

		// Token: 0x0600019C RID: 412 RVA: 0x000070BB File Offset: 0x000052BB
		internal void BeginSyncValueProperties()
		{
			if (this._pendingPropertyChangedEvents == null)
			{
				this._pendingPropertyChangedEvents = new global::System.Collections.Generic.List<global::System.Windows.RoutedEventArgs>();
			}
			this._syncingValueProperties++;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000070E0 File Offset: 0x000052E0
		internal void EndSyncValueProperties()
		{
			this._syncingValueProperties--;
			if (!this.SyncingValueProperties && this._pendingPropertyChangedEvents != null && !this._processingPendingPropertyChangedEvents)
			{
				this._processingPendingPropertyChangedEvents = true;
				try
				{
					global::System.Collections.Generic.List<global::System.Windows.RoutedEventArgs> pendingPropertyChangedEvents = this._pendingPropertyChangedEvents;
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

		// Token: 0x0600019E RID: 414 RVA: 0x0000716C File Offset: 0x0000536C
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.ValueEditor.GetString(name, null);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007175 File Offset: 0x00005375
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007180 File Offset: 0x00005380
		internal bool HasValueChangedInternal(bool compareWithOriginalValue)
		{
			if (!this.HasValueChanged)
			{
				return false;
			}
			if (compareWithOriginalValue && (this._host != null || !this.IsAlwaysInEditMode))
			{
				object originalValue = this.OriginalValue;
				object value = this.Value;
				bool flag = global::Infragistics.Windows.Editors.Utils.IsValueEmpty(originalValue);
				bool flag2 = global::Infragistics.Windows.Editors.Utils.IsValueEmpty(value);
				if ((flag && flag2) || global::Infragistics.Windows.Editors.Utils.AreEqual(originalValue, value))
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

		// Token: 0x060001A1 RID: 417 RVA: 0x000071F3 File Offset: 0x000053F3
		internal bool RaiseEventHelper(global::System.Windows.RoutedEventArgs args)
		{
			if (this._host != null && this._host.ShouldSuppressEvent(args))
			{
				if (args.RoutedEvent == global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent)
				{
					this._host.OnEditorValueChanged(args);
				}
				return false;
			}
			base.RaiseEvent(args);
			return true;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000722E File Offset: 0x0000542E
		internal void RaiseValuePropertyChangedEvent(global::System.Windows.RoutedEventArgs e)
		{
			if (this.SyncingValueProperties && this._pendingPropertyChangedEvents != null)
			{
				this._pendingPropertyChangedEvents.Add(e);
				return;
			}
			this.RaiseEventHelper(e);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007258 File Offset: 0x00005458
		internal void SetFocusToFocusSite()
		{
			if (this._focusSite != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = this._focusSite as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
					return;
				}
				global::System.Windows.FrameworkContentElement frameworkContentElement = this._focusSite as global::System.Windows.FrameworkContentElement;
				if (frameworkContentElement != null)
				{
					frameworkContentElement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				}
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000072A8 File Offset: 0x000054A8
		internal bool StartEditModeOnMouseDownHelper()
		{
			if (base.Focusable && base.IsEnabled)
			{
				bool result = null == this._host;
				if ((this._host == null || this.IsInEditMode) && !base.IsKeyboardFocused && !base.IsKeyboardFocusWithin)
				{
					base.Focus();
				}
				if (this._host == null && this.IsFocusWithin && !this.IsInEditMode)
				{
					this.StartEditMode();
					result = true;
				}
				return result;
			}
			return false;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000731C File Offset: 0x0000551C
		internal void ValidateInputHelper(bool fromLostFocus, bool forceExitEditMode, out global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs eventArgs, out bool stayInEditMode)
		{
			eventArgs = null;
			if (this._isDisplayingErrorMsgDialog)
			{
				stayInEditMode = true;
				base.Dispatcher.BeginInvoke(new global::Infragistics.Windows.Editors.Utils.MethodInvoker(this.ReFocus), new object[0]);
				return;
			}
			stayInEditMode = false;
			if (!this.IsValueValid && (this.HasValueChangedInternal(true) || this.AlwaysValidateResolved))
			{
				global::Infragistics.Windows.Editors.ValidationErrorInfo validationErrorInfo = this.InvalidValueErrorInfo;
				if (validationErrorInfo == null)
				{
					validationErrorInfo = new global::Infragistics.Windows.Editors.ValidationErrorInfo(new global::System.Exception(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_Exception_1")));
				}
				eventArgs = new global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs(this, forceExitEditMode, validationErrorInfo.Exception, validationErrorInfo.ErrorMessage);
				this.RaiseEditModeValidationError(eventArgs);
				if (!this.IsValueValid)
				{
					switch (eventArgs.InvalidValueBehavior)
					{
					case global::Infragistics.Windows.Editors.InvalidValueBehavior.Default:
					case global::Infragistics.Windows.Editors.InvalidValueBehavior.DisplayErrorMessage:
						if (eventArgs.ErrorMessage != null && eventArgs.ErrorMessage.Length > 0 && this.CanShowErrorMessage())
						{
							this._isDisplayingErrorMsgDialog = true;
							try
							{
								global::Infragistics.Windows.Utilities.ShowMessageBox(this, eventArgs.ErrorMessage, global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_InvalidValue"), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
							}
							finally
							{
								this._isDisplayingErrorMsgDialog = false;
							}
						}
						stayInEditMode = true;
						return;
					case global::Infragistics.Windows.Editors.InvalidValueBehavior.RetainValue:
						stayInEditMode = true;
						return;
					case global::Infragistics.Windows.Editors.InvalidValueBehavior.RevertValue:
						this.RevertValueBackToOriginalValue();
						break;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000744C File Offset: 0x0000564C
		internal bool CanShowErrorMessage()
		{
			global::System.Windows.DependencyObject dependencyObject = this;
			while (dependencyObject != null && !(dependencyObject is global::System.Windows.Controls.Page) && !(dependencyObject is global::System.Windows.Window))
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
			}
			return dependencyObject == null || ((global::System.Windows.UIElement)dependencyObject).IsVisible;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007488 File Offset: 0x00005688
		private void InitializeCachedPropertyValues()
		{
			this._cachedEditTemplate = (global::System.Windows.Controls.ControlTemplate)global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty.GetMetadata(this).DefaultValue;
			this._cachedFormat = (string)global::Infragistics.Windows.Editors.ValueEditor.FormatProperty.GetMetadata(this).DefaultValue;
			this._cachedFormatProvider = (global::System.IFormatProvider)global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty.GetMetadata(this).DefaultValue;
			this._cachedInvalidValueBehavior = (global::Infragistics.Windows.Editors.InvalidValueBehavior)global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty.GetMetadata(this).DefaultValue;
			this.InternalSetCachedValueConstraintHelper((global::Infragistics.Windows.Editors.ValueConstraint)global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty.GetMetadata(this).DefaultValue);
			this._cachedValueType = (global::System.Type)global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.GetMetadata(this).DefaultValue;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007538 File Offset: 0x00005738
		private bool IsValueValidHelper(object value, out global::System.Exception error)
		{
			string text = null;
			error = null;
			global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = this.ValueConstraint;
			if (valueConstraint != null && !valueConstraint.Validate(value, this.ValueType, global::Infragistics.Windows.Editors.ValueConstraintFlags.All, this.FormatProviderResolved, this.Format, ref text))
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
			else if (!this.ValueType.IsInstanceOfType(value))
			{
				return false;
			}
			return true;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000075B0 File Offset: 0x000057B0
		internal bool SyncTextWithValue()
		{
			global::System.Exception ex;
			return this.SyncTextWithValueHelper(this.Value, out ex, true);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000075CC File Offset: 0x000057CC
		private bool SyncTextWithValueHelper(object newValue, out global::System.Exception error, bool syncDisplayText)
		{
			this.BeginSyncValueProperties();
			bool result;
			try
			{
				string text;
				if (this.ConvertValueToText(newValue, out text, out error))
				{
					base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.InSyncTextWithValueProperty, text);
					try
					{
						this.Text_CurrentValue = text;
					}
					finally
					{
						base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.InSyncTextWithValueProperty);
					}
					if (syncDisplayText)
					{
						global::Infragistics.Windows.Editors.TextEditorBase textEditorBase = this as global::Infragistics.Windows.Editors.TextEditorBase;
						if (textEditorBase != null && syncDisplayText)
						{
							textEditorBase.SyncDisplayText();
						}
					}
					result = true;
				}
				else
				{
					this.SetIsValueValid(false, error);
					result = false;
				}
			}
			finally
			{
				this.EndSyncValueProperties();
			}
			return result;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00007658 File Offset: 0x00005858
		private bool SyncValueWithText(object newValue, out global::System.Exception error)
		{
			this.BeginSyncValueProperties();
			bool result;
			try
			{
				object value;
				if (this.ConvertTextToValue((string)newValue, out value, out error))
				{
					base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, value);
					result = true;
				}
				else
				{
					this.SetIsValueValid(false, error);
					this.OnValueChanged(this.Value, this.Value);
					result = false;
				}
			}
			finally
			{
				this.EndSyncValueProperties();
			}
			return result;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000076C4 File Offset: 0x000058C4
		private static object OnCoerceTemplate(global::System.Windows.DependencyObject target, object value)
		{
			if (global::System.Windows.Controls.Control.TemplateProperty.DefaultMetadata.CoerceValueCallback != null)
			{
				value = global::System.Windows.Controls.Control.TemplateProperty.DefaultMetadata.CoerceValueCallback(target, value);
			}
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null && valueEditor.IsInEditMode && valueEditor.EditTemplate != null)
			{
				return valueEditor.EditTemplate;
			}
			return value;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000771C File Offset: 0x0000591C
		private void ReFocus()
		{
			base.Focus();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007728 File Offset: 0x00005928
		private void RevalidateCurrentValue()
		{
			global::System.Exception error;
			bool isValueValid = this.ValidateCurrentValueHelper(out error);
			this.SetIsValueValid(isValueValid, error);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007748 File Offset: 0x00005948
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
			if (this.IsInEditMode && !this._isEnteringEditMode)
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000077D8 File Offset: 0x000059D8
		internal virtual bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			if (global::Infragistics.Windows.Editors.ValueEditor.ValueProperty == prop)
			{
				return this.SyncTextWithValueHelper(newValue, out error, false);
			}
			if (global::Infragistics.Windows.Editors.ValueEditor.TextProperty == prop)
			{
				return this.SyncValueWithText(newValue, out error);
			}
			error = new global::System.InvalidOperationException("This should only be called for Text and Value properties. Derived classes need to handle their own properties.");
			return false;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000780C File Offset: 0x00005A0C
		private bool ValidateCurrentValueHelper(out global::System.Exception error)
		{
			bool flag = this.ValidateCurrentValue(out error);
			if (flag && this._host != null)
			{
				return this._host.IsCurrentValueValid(out error);
			}
			return flag;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000783C File Offset: 0x00005A3C
		private void VerifyFocusSite()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_FocusSite");
			if (templateChild == null)
			{
				return;
			}
			global::System.Exception ex;
			if (!this.ValidateFocusSite(templateChild, out ex))
			{
				throw ex;
			}
			if (templateChild != this._focusSite)
			{
				this._focusSite = templateChild;
				this.OnFocusSiteChanged();
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000787C File Offset: 0x00005A7C
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (typeof(global::System.ComponentModel.PropertyChangedEventManager) == managerType)
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null && sender == this._cachedValueConstraint)
				{
					this.OnValueConstraintChanged(propertyChangedEventArgs.PropertyName);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000042 RID: 66
		private global::Infragistics.Windows.Editors.ValuePresenter _host;

		// Token: 0x04000043 RID: 67
		private object _hostContext;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.DependencyObject _focusSite;

		// Token: 0x04000045 RID: 69
		private bool _initialized;

		// Token: 0x04000046 RID: 70
		private bool _isInEditMode;

		// Token: 0x04000047 RID: 71
		internal bool _isEnteringEditMode;

		// Token: 0x04000048 RID: 72
		private int _syncingValueProperties;

		// Token: 0x04000049 RID: 73
		internal bool _isInEndEditMode;

		// Token: 0x0400004A RID: 74
		private global::System.Collections.Generic.List<global::System.Windows.RoutedEventArgs> _pendingPropertyChangedEvents;

		// Token: 0x0400004B RID: 75
		private bool _processingPendingPropertyChangedEvents;

		// Token: 0x0400004C RID: 76
		private global::System.IFormatProvider _cachedFormatProviderResolved;

		// Token: 0x0400004D RID: 77
		private bool _hasVisualStateGroups;

		// Token: 0x0400004E RID: 78
		private bool _isDisplayingErrorMsgDialog;

		// Token: 0x0400004F RID: 79
		private bool _isInitializing;

		// Token: 0x04000050 RID: 80
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type> g_defaultEditors;

		// Token: 0x04000051 RID: 81
		private bool _inSyncValueProperties;

		// Token: 0x04000057 RID: 87
		internal static readonly global::System.Windows.DependencyProperty InSyncTextWithValueProperty;

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty AlwaysValidateProperty;

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty TextProperty;

		// Token: 0x0400005D RID: 93
		public static readonly global::System.Windows.DependencyProperty ValueTypeProperty;

		// Token: 0x0400005E RID: 94
		private global::System.Type _cachedValueType;

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty ValueConstraintProperty;

		// Token: 0x04000060 RID: 96
		private global::Infragistics.Windows.Editors.ValueConstraint _cachedValueConstraint;

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty InvalidValueBehaviorProperty;

		// Token: 0x04000062 RID: 98
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _cachedInvalidValueBehavior;

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty ValueToTextConverterProperty;

		// Token: 0x04000064 RID: 100
		private static readonly global::System.Windows.DependencyPropertyKey IsValueValidPropertyKey;

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty IsValueValidProperty;

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty EditTemplateProperty;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Controls.ControlTemplate _cachedEditTemplate;

		// Token: 0x04000069 RID: 105
		private static readonly global::System.Windows.DependencyPropertyKey HasValueChangedPropertyKey;

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty HasValueChangedProperty;

		// Token: 0x0400006B RID: 107
		private static readonly global::System.Windows.DependencyPropertyKey InvalidValueErrorInfoPropertyKey;

		// Token: 0x0400006C RID: 108
		public static readonly global::System.Windows.DependencyProperty InvalidValueErrorInfoProperty;

		// Token: 0x0400006D RID: 109
		public static readonly global::System.Windows.DependencyProperty IsAlwaysInEditModeProperty;

		// Token: 0x0400006E RID: 110
		private static readonly global::System.Windows.DependencyPropertyKey IsEmbeddedPropertyKey;

		// Token: 0x0400006F RID: 111
		public static readonly global::System.Windows.DependencyProperty IsEmbeddedProperty;

		// Token: 0x04000070 RID: 112
		public static readonly global::System.Windows.DependencyProperty IsFocusWithinProperty;

		// Token: 0x04000071 RID: 113
		public static readonly global::System.Windows.DependencyProperty IsInEditModeProperty;

		// Token: 0x04000072 RID: 114
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x04000073 RID: 115
		protected static readonly global::System.Windows.DependencyPropertyKey OriginalValuePropertyKey;

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty OriginalValueProperty;

		// Token: 0x04000075 RID: 117
		[global::System.Obsolete("This property has been obsoleted. Use 'IsReadOnly' property instead.", false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public static readonly global::System.Windows.DependencyProperty ReadOnlyProperty;

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty ThemeProperty;

		// Token: 0x04000077 RID: 119
		public static readonly global::System.Windows.DependencyProperty FormatProviderProperty;

		// Token: 0x04000078 RID: 120
		private global::System.IFormatProvider _cachedFormatProvider;

		// Token: 0x04000079 RID: 121
		public static readonly global::System.Windows.DependencyProperty FormatProperty;

		// Token: 0x0400007A RID: 122
		private string _cachedFormat;
	}
}
