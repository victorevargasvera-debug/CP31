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
	// Token: 0x0200001F RID: 31
	[global::System.Windows.TemplateVisualState(Name = "InvalidFocusedEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "Embedded", GroupName = "EmbeddedStates")]
	[global::System.Windows.TemplateVisualState(Name = "NotEmbedded", GroupName = "EmbeddedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplatePart(Name = "PART_FocusSite", Type = typeof(global::System.Windows.DependencyObject))]
	[global::System.Windows.TemplateVisualState(Name = "InvalidUnfocusedEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "ReadOnly", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	public abstract class ValueEditor : global::System.Windows.Controls.Control, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00005114 File Offset: 0x00003314
		static ValueEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeEnded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeEnding", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeStarted", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeStarting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeValidationError", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs>), typeof(global::Infragistics.Windows.Editors.ValueEditor));
			global::Infragistics.Windows.Editors.ValueEditor.InSyncTextWithValueProperty = global::System.Windows.DependencyProperty.Register("InSyncTextWithValue", typeof(string), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Editors.ValueEditor.AcceptsArrowKeysInEditModeProperty = global::System.Windows.DependencyProperty.Register("AcceptsArrowKeysInEditMode", typeof(bool?), typeof(global::Infragistics.Windows.Editors.ValueEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
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

		// Token: 0x060000FD RID: 253 RVA: 0x00005923 File Offset: 0x00003B23
		protected ValueEditor()
		{
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005934 File Offset: 0x00003B34
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000597A File Offset: 0x00003B7A
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyFocusSite();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000599B File Offset: 0x00003B9B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer(this);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000059A3 File Offset: 0x00003BA3
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (!this._settingFocusOnTemplateChange || this.IsInEditMode || this.IsAlwaysInEditMode)
			{
				base.OnGotFocus(e);
				return;
			}
			base.RaiseEvent(e);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000059CC File Offset: 0x00003BCC
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

		// Token: 0x06000103 RID: 259 RVA: 0x00005A04 File Offset: 0x00003C04
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

		// Token: 0x06000104 RID: 260 RVA: 0x00005A34 File Offset: 0x00003C34
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
							this._focusSelfInEndEditMode++;
							try
							{
								this.EndEditMode(false, false);
								goto IL_98;
							}
							finally
							{
								this._focusSelfInEndEditMode--;
							}
						}
						this.RevertValueBackToOriginalValue();
						IL_98:
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

		// Token: 0x06000105 RID: 261 RVA: 0x00005B48 File Offset: 0x00003D48
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005B57 File Offset: 0x00003D57
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				e.Handled = this.StartEditModeOnMouseDownHelper();
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005B84 File Offset: 0x00003D84
		protected override void OnPreviewLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this.IsInEditMode && (this._host == null || !this._host.BypassValidationOnLostFocus))
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

		// Token: 0x06000109 RID: 265 RVA: 0x00005BFC File Offset: 0x00003DFC
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.Controls.Control.TemplateProperty && base.IsKeyboardFocusWithin && !base.IsKeyboardFocused && this.IsFocusWithin)
			{
				try
				{
					this._settingFocusOnTemplateChange = true;
					base.Focus();
				}
				finally
				{
					this._settingFocusOnTemplateChange = false;
				}
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

		// Token: 0x0600010A RID: 266 RVA: 0x00005DEC File Offset: 0x00003FEC
		protected virtual void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeEnded(this, args);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00005DFE File Offset: 0x00003FFE
		internal void RaiseEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent;
			args.Source = this;
			this.OnEditModeEnded(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600010C RID: 268 RVA: 0x00005E19 File Offset: 0x00004019
		// (remove) Token: 0x0600010D RID: 269 RVA: 0x00005E27 File Offset: 0x00004027
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

		// Token: 0x0600010E RID: 270 RVA: 0x00005E35 File Offset: 0x00004035
		protected virtual void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeEnding(this, args);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005E47 File Offset: 0x00004047
		internal void RaiseEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent;
			args.Source = this;
			this.OnEditModeEnding(args);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000110 RID: 272 RVA: 0x00005E62 File Offset: 0x00004062
		// (remove) Token: 0x06000111 RID: 273 RVA: 0x00005E70 File Offset: 0x00004070
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

		// Token: 0x06000112 RID: 274 RVA: 0x00005E7E File Offset: 0x0000407E
		protected virtual void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeStarted(this, args);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005E90 File Offset: 0x00004090
		internal void RaiseEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent;
			args.Source = this;
			this.OnEditModeStarted(args);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000114 RID: 276 RVA: 0x00005EAB File Offset: 0x000040AB
		// (remove) Token: 0x06000115 RID: 277 RVA: 0x00005EB9 File Offset: 0x000040B9
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

		// Token: 0x06000116 RID: 278 RVA: 0x00005EC7 File Offset: 0x000040C7
		protected virtual void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeStarting(this, args);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005ED9 File Offset: 0x000040D9
		internal void RaiseEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent;
			args.Source = this;
			this.OnEditModeStarting(args);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000118 RID: 280 RVA: 0x00005EF4 File Offset: 0x000040F4
		// (remove) Token: 0x06000119 RID: 281 RVA: 0x00005F02 File Offset: 0x00004102
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

		// Token: 0x0600011A RID: 282 RVA: 0x00005F10 File Offset: 0x00004110
		protected virtual void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs args)
		{
			if (!this.RaiseEventHelper(args))
			{
				global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeValidationError(this, args);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005F22 File Offset: 0x00004122
		internal void RaiseEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent;
			args.Source = this;
			this.OnEditModeValidationError(args);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600011C RID: 284 RVA: 0x00005F3D File Offset: 0x0000413D
		// (remove) Token: 0x0600011D RID: 285 RVA: 0x00005F4B File Offset: 0x0000414B
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
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005F5C File Offset: 0x0000415C
		internal bool AcceptsArrowKeysInEditModeResolved
		{
			get
			{
				bool? acceptsArrowKeysInEditMode = this.AcceptsArrowKeysInEditMode;
				if (acceptsArrowKeysInEditMode != null)
				{
					return acceptsArrowKeysInEditMode.Value;
				}
				return this.AcceptsArrowKeysInEditModeDefault;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00005F88 File Offset: 0x00004188
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00005FC4 File Offset: 0x000041C4
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00005FE8 File Offset: 0x000041E8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006004 File Offset: 0x00004204
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

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006024 File Offset: 0x00004224
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00006055 File Offset: 0x00004255
		internal bool InternalIsInitialized
		{
			get
			{
				return this._initialized;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000605D File Offset: 0x0000425D
		internal bool InternalIsInitializing
		{
			get
			{
				return this._isInitializing;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00006065 File Offset: 0x00004265
		internal bool IsEditingAllowed
		{
			get
			{
				return this.Host == null || this.Host.IsEditingAllowed;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000607C File Offset: 0x0000427C
		internal global::System.Globalization.CultureInfo LanguageCultureInfo
		{
			get
			{
				return global::Infragistics.Windows.Utilities.GetLanguageCultureInfo(this);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00006084 File Offset: 0x00004284
		internal bool SyncingValueProperties
		{
			get
			{
				return this._syncingValueProperties > 0;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00006090 File Offset: 0x00004290
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000060AF File Offset: 0x000042AF
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000060C1 File Offset: 0x000042C1
		public bool? AcceptsArrowKeysInEditMode
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.AcceptsArrowKeysInEditModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.AcceptsArrowKeysInEditModeProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000060D4 File Offset: 0x000042D4
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000060E6 File Offset: 0x000042E6
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

		// Token: 0x0600012E RID: 302 RVA: 0x000060F9 File Offset: 0x000042F9
		private static void OnAlwaysValidateChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			bool? flag = (bool?)e.NewValue;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006108 File Offset: 0x00004308
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAlwaysValidate()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty, this);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006115 File Offset: 0x00004315
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAlwaysValidate()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00006122 File Offset: 0x00004322
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000612F File Offset: 0x0000432F
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

		// Token: 0x06000133 RID: 307 RVA: 0x00006140 File Offset: 0x00004340
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

		// Token: 0x06000134 RID: 308 RVA: 0x000061BC File Offset: 0x000043BC
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
		// (add) Token: 0x06000135 RID: 309 RVA: 0x00006205 File Offset: 0x00004405
		// (remove) Token: 0x06000136 RID: 310 RVA: 0x00006213 File Offset: 0x00004413
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

		// Token: 0x06000137 RID: 311 RVA: 0x00006224 File Offset: 0x00004424
		private static object OnCoerceValue(global::System.Windows.DependencyObject dependencyObject, object value)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			if (!valueEditor._initialized)
			{
				return value;
			}
			return valueEditor.OnCoerceValue(value);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006249 File Offset: 0x00004449
		protected virtual object OnCoerceValue(object val)
		{
			if (val != null && global::System.DBNull.Value != val && !this.ValueType.IsInstanceOfType(val))
			{
				val = global::Infragistics.CoreUtilities.ConvertDataValue(val, this.ValueType, this.FormatProviderResolved, this.Format);
			}
			return val;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000627F File Offset: 0x0000447F
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00006291 File Offset: 0x00004491
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000629F File Offset: 0x0000449F
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000062A7 File Offset: 0x000044A7
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

		// Token: 0x0600013D RID: 317 RVA: 0x000062B8 File Offset: 0x000044B8
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

		// Token: 0x0600013E RID: 318 RVA: 0x00006320 File Offset: 0x00004520
		protected virtual void OnTextChanged(string previousValue, string currentValue)
		{
			this.RaiseValuePropertyChangedEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.TextChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600013F RID: 319 RVA: 0x0000634E File Offset: 0x0000454E
		// (remove) Token: 0x06000140 RID: 320 RVA: 0x0000635C File Offset: 0x0000455C
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

		// Token: 0x06000141 RID: 321 RVA: 0x0000636C File Offset: 0x0000456C
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

		// Token: 0x06000142 RID: 322 RVA: 0x00006398 File Offset: 0x00004598
		protected virtual string OnCoerceText(string text)
		{
			return text;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000639B File Offset: 0x0000459B
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000063A3 File Offset: 0x000045A3
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

		// Token: 0x06000145 RID: 325 RVA: 0x000063B4 File Offset: 0x000045B4
		private static void OnValueTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::System.Type type = (global::System.Type)e.NewValue;
			valueEditor._cachedValueType = type;
			valueEditor.OnValueTypeChanged(type);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000063E4 File Offset: 0x000045E4
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

		// Token: 0x06000147 RID: 327 RVA: 0x0000640E File Offset: 0x0000460E
		public bool ShouldSerializeValueType()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, this);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000641B File Offset: 0x0000461B
		public void ResetValueType()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006428 File Offset: 0x00004628
		private static void OnValueConstraintChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::Infragistics.Windows.Editors.ValueConstraint newVal = (global::Infragistics.Windows.Editors.ValueConstraint)e.NewValue;
			valueEditor.InternalSetCachedValueConstraintHelper(newVal);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006450 File Offset: 0x00004650
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

		// Token: 0x0600014B RID: 331 RVA: 0x00006498 File Offset: 0x00004698
		internal virtual void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			this.RevalidateCurrentValue();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000064A0 File Offset: 0x000046A0
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000064A8 File Offset: 0x000046A8
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

		// Token: 0x0600014E RID: 334 RVA: 0x000064B6 File Offset: 0x000046B6
		public bool ShouldSerializeValueConstraint()
		{
			return null != this.ValueConstraint;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000064C4 File Offset: 0x000046C4
		public void ResetValueConstraint()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000064D4 File Offset: 0x000046D4
		private static void OnInvalidValueBehaviorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::Infragistics.Windows.Editors.InvalidValueBehavior cachedInvalidValueBehavior = (global::Infragistics.Windows.Editors.InvalidValueBehavior)e.NewValue;
			valueEditor._cachedInvalidValueBehavior = cachedInvalidValueBehavior;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000064FC File Offset: 0x000046FC
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00006504 File Offset: 0x00004704
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

		// Token: 0x06000153 RID: 339 RVA: 0x00006517 File Offset: 0x00004717
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInvalidValueBehavior()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty, this);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006524 File Offset: 0x00004724
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInvalidValueBehavior()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00006531 File Offset: 0x00004731
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00006543 File Offset: 0x00004743
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00006551 File Offset: 0x00004751
		public bool IsValueValid
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsValueValidProperty);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006563 File Offset: 0x00004763
		internal void SetIsValueValid(bool isValueValid, global::System.Exception error)
		{
			this.SetIsValueValid(isValueValid, (error != null) ? new global::Infragistics.Windows.Editors.ValidationErrorInfo(error) : null);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006578 File Offset: 0x00004778
		internal void SetIsValueValid(bool isValueValid, global::Infragistics.Windows.Editors.ValidationErrorInfo invalidValueErrorInfo)
		{
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsValueValidPropertyKey, global::Infragistics.KnownBoxes.FromValue(isValueValid));
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoPropertyKey, invalidValueErrorInfo);
			if (this._host != null)
			{
				this._host.OnValueValidated();
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000065AC File Offset: 0x000047AC
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000065FA File Offset: 0x000047FA
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00006602 File Offset: 0x00004802
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

		// Token: 0x0600015D RID: 349 RVA: 0x00006610 File Offset: 0x00004810
		protected virtual void OnEditTemplateChanged(global::System.Windows.Controls.ControlTemplate previousValue, global::System.Windows.Controls.ControlTemplate currentValue)
		{
			this.RaiseEventHelper(new global::System.Windows.RoutedPropertyChangedEventArgs<global::System.Windows.Controls.ControlTemplate>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditTemplateChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600015E RID: 350 RVA: 0x0000663F File Offset: 0x0000483F
		// (remove) Token: 0x0600015F RID: 351 RVA: 0x0000664D File Offset: 0x0000484D
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000665B File Offset: 0x0000485B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasValueChanged
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.HasValueChangedProperty);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000666D File Offset: 0x0000486D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Editors.ValidationErrorInfo InvalidValueErrorInfo
		{
			get
			{
				return (global::Infragistics.Windows.Editors.ValidationErrorInfo)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.InvalidValueErrorInfoProperty);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00006680 File Offset: 0x00004880
		internal bool IsNullable
		{
			get
			{
				global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = this.ValueConstraint;
				return valueConstraint == null || valueConstraint.Nullable == null || valueConstraint.Nullable.Value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000066B7 File Offset: 0x000048B7
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000066C9 File Offset: 0x000048C9
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000066DC File Offset: 0x000048DC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsEmbedded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedProperty);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000066EE File Offset: 0x000048EE
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFocusWithin
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006700 File Offset: 0x00004900
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00006757 File Offset: 0x00004957
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00006769 File Offset: 0x00004969
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

		// Token: 0x0600016A RID: 362 RVA: 0x0000677C File Offset: 0x0000497C
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)target;
			if (!object.Equals(valueEditor.GetValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty), e.NewValue))
			{
				valueEditor.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty, e.NewValue);
			}
			valueEditor.UpdateVisualStates();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000067C1 File Offset: 0x000049C1
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000067D3 File Offset: 0x000049D3
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

		// Token: 0x0600016D RID: 365 RVA: 0x000067E6 File Offset: 0x000049E6
		public bool ShouldSerializeIsReadOnly()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty, this);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000067F3 File Offset: 0x000049F3
		public void ResetIsReadOnly()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00006800 File Offset: 0x00004A00
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public object OriginalValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueEditor.OriginalValueProperty);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006810 File Offset: 0x00004A10
		private static void OnReadOnlyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)target;
			if (!object.Equals(valueEditor.GetValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty), e.NewValue))
			{
				valueEditor.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty, e.NewValue);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000684F File Offset: 0x00004A4F
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00006861 File Offset: 0x00004A61
		[global::System.Obsolete("This property has been obsoleted. Use 'IsReadOnly' property instead.", false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
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

		// Token: 0x06000173 RID: 371 RVA: 0x00006874 File Offset: 0x00004A74
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Obsolete("This method has been obsoleted. Use 'ShouldSerializeIsReadOnly' method instead.", false)]
		public bool ShouldSerializeReadOnly()
		{
			return false;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006877 File Offset: 0x00004A77
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Obsolete("This method has been obsoleted. Use 'ResetIsReadOnly' method instead.", false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetReadOnly()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.ReadOnlyProperty);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006884 File Offset: 0x00004A84
		private static void OnThemeChangedCallback(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			valueEditor.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000068B6 File Offset: 0x00004AB6
		protected virtual void OnThemeChanged(string newTheme, string oldTheme)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000068B8 File Offset: 0x00004AB8
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000068CA File Offset: 0x00004ACA
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.EditorsThemeTypeConverter))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000179 RID: 377 RVA: 0x000068D8 File Offset: 0x00004AD8
		private static void OnFormatProviderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			global::System.IFormatProvider cachedFormatProvider = (global::System.IFormatProvider)e.NewValue;
			valueEditor._cachedFormatProvider = cachedFormatProvider;
			valueEditor._cachedFormatProviderResolved = null;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00006907 File Offset: 0x00004B07
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000690F File Offset: 0x00004B0F
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

		// Token: 0x0600017C RID: 380 RVA: 0x0000691D File Offset: 0x00004B1D
		public bool ShouldSerializeFormatProvider()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty, this);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000692A File Offset: 0x00004B2A
		public void ResetFormatProvider()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006938 File Offset: 0x00004B38
		private static void OnFormatChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = (global::Infragistics.Windows.Editors.ValueEditor)dependencyObject;
			string cachedFormat = (string)e.NewValue;
			valueEditor._cachedFormat = cachedFormat;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00006960 File Offset: 0x00004B60
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00006968 File Offset: 0x00004B68
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

		// Token: 0x06000181 RID: 385 RVA: 0x00006978 File Offset: 0x00004B78
		public bool ShouldSerializeFormat()
		{
			string format = this.Format;
			return format != null && format.Length > 0;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000699A File Offset: 0x00004B9A
		public void ResetFormat()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueEditor.FormatProperty);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000069A7 File Offset: 0x00004BA7
		protected virtual bool AcceptsArrowKeysInEditModeDefault
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000069AA File Offset: 0x00004BAA
		protected virtual global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ValueEditorDefaultConverter.ValueToTextConverter;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000069B1 File Offset: 0x00004BB1
		protected global::System.Windows.DependencyObject FocusSite
		{
			get
			{
				return this._focusSite;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000069B9 File Offset: 0x00004BB9
		internal virtual bool HasDropDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000069BC File Offset: 0x00004BBC
		internal virtual bool HasOpenDropDown
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000069BF File Offset: 0x00004BBF
		public global::Infragistics.Windows.Editors.ValuePresenter Host
		{
			get
			{
				return this._host;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000069C7 File Offset: 0x00004BC7
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

		// Token: 0x0600018A RID: 394
		public abstract bool CanEditType(global::System.Type type);

		// Token: 0x0600018B RID: 395
		public abstract bool CanRenderType(global::System.Type type);

		// Token: 0x0600018C RID: 396 RVA: 0x000069E8 File Offset: 0x00004BE8
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
					if (this._focusSelfInEndEditMode > 0)
					{
						base.Focus();
					}
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

		// Token: 0x0600018D RID: 397 RVA: 0x00006B64 File Offset: 0x00004D64
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

		// Token: 0x0600018E RID: 398 RVA: 0x00006C6C File Offset: 0x00004E6C
		public void InitializeHostInfo(global::Infragistics.Windows.Editors.ValuePresenter host, object hostContext)
		{
			this._host = host;
			this._hostContext = hostContext;
			global::Infragistics.Windows.Editors.ValuePresenter host2 = this._host;
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.IsEmbeddedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._host != null));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006C9F File Offset: 0x00004E9F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public virtual bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return true;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00006CA4 File Offset: 0x00004EA4
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

		// Token: 0x06000191 RID: 401 RVA: 0x00006D94 File Offset: 0x00004F94
		public bool StartEditMode()
		{
			return this.StartEditMode(true);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006DA0 File Offset: 0x00004FA0
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

		// Token: 0x06000193 RID: 403 RVA: 0x00006E80 File Offset: 0x00005080
		public void ValidateCurrentValue()
		{
			this.RevalidateCurrentValue();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006E88 File Offset: 0x00005088
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual bool ValidateValue(object value, out global::System.Exception error)
		{
			return this.IsValueValidHelper(value, out error);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006E92 File Offset: 0x00005092
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool ConvertTextToValue(string text, out object value, out global::System.Exception error)
		{
			return this.ConvertTextToValueHelper(text, out value, out error);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006EA0 File Offset: 0x000050A0
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

		// Token: 0x06000197 RID: 407 RVA: 0x00006F18 File Offset: 0x00005118
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

		// Token: 0x06000198 RID: 408 RVA: 0x00006F74 File Offset: 0x00005174
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

		// Token: 0x06000199 RID: 409 RVA: 0x00006FA8 File Offset: 0x000051A8
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

		// Token: 0x0600019A RID: 410 RVA: 0x0000700F File Offset: 0x0000520F
		protected virtual void InitializeOriginalValueFromValue()
		{
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.OriginalValuePropertyKey, this.Value);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007022 File Offset: 0x00005222
		protected virtual void OnFocusSiteChanged()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007024 File Offset: 0x00005224
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

		// Token: 0x0600019D RID: 413 RVA: 0x000070B7 File Offset: 0x000052B7
		protected internal virtual void ProcessKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000070B9 File Offset: 0x000052B9
		protected virtual void RevertValueBackToOriginalValue()
		{
			global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, this.OriginalValue);
			this.SyncTextWithValue();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000070D3 File Offset: 0x000052D3
		protected void VerifyTemplateState()
		{
			base.CoerceValue(global::System.Windows.Controls.Control.TemplateProperty);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000070E0 File Offset: 0x000052E0
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

		// Token: 0x060001A1 RID: 417 RVA: 0x0000712E File Offset: 0x0000532E
		protected virtual bool ValidateCurrentValue(out global::System.Exception error)
		{
			return this.IsValueValidHelper(this.Value, out error);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007140 File Offset: 0x00005340
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

		// Token: 0x060001A3 RID: 419 RVA: 0x000072AC File Offset: 0x000054AC
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = target as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				valueEditor.UpdateVisualStates();
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000072C9 File Offset: 0x000054C9
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000072D2 File Offset: 0x000054D2
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

		// Token: 0x060001A6 RID: 422 RVA: 0x000072EF File Offset: 0x000054EF
		internal void BeginSyncValueProperties()
		{
			if (this._pendingPropertyChangedEvents == null)
			{
				this._pendingPropertyChangedEvents = new global::System.Collections.Generic.List<global::System.Windows.RoutedEventArgs>();
			}
			this._syncingValueProperties++;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007314 File Offset: 0x00005514
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

		// Token: 0x060001A8 RID: 424 RVA: 0x000073A0 File Offset: 0x000055A0
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.ValueEditor.GetString(name, null);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000073A9 File Offset: 0x000055A9
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000073B4 File Offset: 0x000055B4
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

		// Token: 0x060001AB RID: 427 RVA: 0x00007427 File Offset: 0x00005627
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

		// Token: 0x060001AC RID: 428 RVA: 0x00007462 File Offset: 0x00005662
		internal void RaiseValuePropertyChangedEvent(global::System.Windows.RoutedEventArgs e)
		{
			if (this.SyncingValueProperties && this._pendingPropertyChangedEvents != null)
			{
				this._pendingPropertyChangedEvents.Add(e);
				return;
			}
			this.RaiseEventHelper(e);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000748C File Offset: 0x0000568C
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

		// Token: 0x060001AE RID: 430 RVA: 0x000074DC File Offset: 0x000056DC
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

		// Token: 0x060001AF RID: 431 RVA: 0x0000754E File Offset: 0x0000574E
		internal void UpdateOriginalValue(object newOriginalValue)
		{
			base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.OriginalValuePropertyKey, this.OnCoerceValue(newOriginalValue));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007564 File Offset: 0x00005764
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

		// Token: 0x060001B1 RID: 433 RVA: 0x00007694 File Offset: 0x00005894
		internal bool CanShowErrorMessage()
		{
			global::System.Windows.DependencyObject dependencyObject = this;
			while (dependencyObject != null && !(dependencyObject is global::System.Windows.Controls.Page) && !(dependencyObject is global::System.Windows.Window))
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
			}
			return dependencyObject == null || ((global::System.Windows.UIElement)dependencyObject).IsVisible;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000076D0 File Offset: 0x000058D0
		private void InitializeCachedPropertyValues()
		{
			this._cachedEditTemplate = (global::System.Windows.Controls.ControlTemplate)global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty.GetMetadata(this).DefaultValue;
			this._cachedFormat = (string)global::Infragistics.Windows.Editors.ValueEditor.FormatProperty.GetMetadata(this).DefaultValue;
			this._cachedFormatProvider = (global::System.IFormatProvider)global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty.GetMetadata(this).DefaultValue;
			this._cachedInvalidValueBehavior = (global::Infragistics.Windows.Editors.InvalidValueBehavior)global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty.GetMetadata(this).DefaultValue;
			this.InternalSetCachedValueConstraintHelper((global::Infragistics.Windows.Editors.ValueConstraint)global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty.GetMetadata(this).DefaultValue);
			this._cachedValueType = (global::System.Type)global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.GetMetadata(this).DefaultValue;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007780 File Offset: 0x00005980
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
					error = new global::System.Exception(global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_EnteredValueEmpty"));
					return false;
				}
			}
			else if (!this.ValueType.IsInstanceOfType(value))
			{
				error = new global::System.Exception(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidValueType", new object[]
				{
					this.ValueType.Name,
					value.GetType().Name
				}));
				return false;
			}
			return true;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000783C File Offset: 0x00005A3C
		internal bool SyncTextWithValue()
		{
			global::System.Exception ex;
			return this.SyncTextWithValueHelper(this.Value, out ex, true);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007858 File Offset: 0x00005A58
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

		// Token: 0x060001B6 RID: 438 RVA: 0x000078E4 File Offset: 0x00005AE4
		private bool SyncValueWithText(object newValue, out global::System.Exception error)
		{
			this.BeginSyncValueProperties();
			bool result;
			try
			{
				object newValue2;
				if (this.ConvertTextToValue((string)newValue, out newValue2, out error))
				{
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, newValue2);
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

		// Token: 0x060001B7 RID: 439 RVA: 0x00007950 File Offset: 0x00005B50
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

		// Token: 0x060001B8 RID: 440 RVA: 0x000079A8 File Offset: 0x00005BA8
		private void ReFocus()
		{
			base.Focus();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000079B4 File Offset: 0x00005BB4
		private void RevalidateCurrentValue()
		{
			global::System.Exception error;
			bool isValueValid = this.ValidateCurrentValueHelper(out error);
			this.SetIsValueValid(isValueValid, error);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000079D4 File Offset: 0x00005BD4
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

		// Token: 0x060001BB RID: 443 RVA: 0x00007A64 File Offset: 0x00005C64
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

		// Token: 0x060001BC RID: 444 RVA: 0x00007A98 File Offset: 0x00005C98
		private bool ValidateCurrentValueHelper(out global::System.Exception error)
		{
			bool flag = this.ValidateCurrentValue(out error);
			if (flag && this._host != null)
			{
				return this._host.IsCurrentValueValid(out error);
			}
			return flag;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007AC8 File Offset: 0x00005CC8
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

		// Token: 0x060001BE RID: 446 RVA: 0x00007B08 File Offset: 0x00005D08
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

		// Token: 0x04000046 RID: 70
		private global::Infragistics.Windows.Editors.ValuePresenter _host;

		// Token: 0x04000047 RID: 71
		private object _hostContext;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.DependencyObject _focusSite;

		// Token: 0x04000049 RID: 73
		private bool _initialized;

		// Token: 0x0400004A RID: 74
		private bool _isInEditMode;

		// Token: 0x0400004B RID: 75
		internal bool _isEnteringEditMode;

		// Token: 0x0400004C RID: 76
		private int _syncingValueProperties;

		// Token: 0x0400004D RID: 77
		internal bool _isInEndEditMode;

		// Token: 0x0400004E RID: 78
		private global::System.Collections.Generic.List<global::System.Windows.RoutedEventArgs> _pendingPropertyChangedEvents;

		// Token: 0x0400004F RID: 79
		private bool _processingPendingPropertyChangedEvents;

		// Token: 0x04000050 RID: 80
		private global::System.IFormatProvider _cachedFormatProviderResolved;

		// Token: 0x04000051 RID: 81
		private bool _hasVisualStateGroups;

		// Token: 0x04000052 RID: 82
		private bool _isDisplayingErrorMsgDialog;

		// Token: 0x04000053 RID: 83
		private bool _isInitializing;

		// Token: 0x04000054 RID: 84
		private int _focusSelfInEndEditMode;

		// Token: 0x04000055 RID: 85
		private bool _settingFocusOnTemplateChange;

		// Token: 0x04000056 RID: 86
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type> g_defaultEditors;

		// Token: 0x04000057 RID: 87
		private bool _inSyncValueProperties;

		// Token: 0x0400005D RID: 93
		internal static readonly global::System.Windows.DependencyProperty InSyncTextWithValueProperty;

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Windows.DependencyProperty AcceptsArrowKeysInEditModeProperty;

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty AlwaysValidateProperty;

		// Token: 0x04000060 RID: 96
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x04000062 RID: 98
		public static readonly global::System.Windows.DependencyProperty TextProperty;

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty ValueTypeProperty;

		// Token: 0x04000065 RID: 101
		private global::System.Type _cachedValueType;

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty ValueConstraintProperty;

		// Token: 0x04000067 RID: 103
		private global::Infragistics.Windows.Editors.ValueConstraint _cachedValueConstraint;

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty InvalidValueBehaviorProperty;

		// Token: 0x04000069 RID: 105
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _cachedInvalidValueBehavior;

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty ValueToTextConverterProperty;

		// Token: 0x0400006B RID: 107
		private static readonly global::System.Windows.DependencyPropertyKey IsValueValidPropertyKey;

		// Token: 0x0400006C RID: 108
		public static readonly global::System.Windows.DependencyProperty IsValueValidProperty;

		// Token: 0x0400006D RID: 109
		public static readonly global::System.Windows.DependencyProperty EditTemplateProperty;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Controls.ControlTemplate _cachedEditTemplate;

		// Token: 0x04000070 RID: 112
		private static readonly global::System.Windows.DependencyPropertyKey HasValueChangedPropertyKey;

		// Token: 0x04000071 RID: 113
		public static readonly global::System.Windows.DependencyProperty HasValueChangedProperty;

		// Token: 0x04000072 RID: 114
		private static readonly global::System.Windows.DependencyPropertyKey InvalidValueErrorInfoPropertyKey;

		// Token: 0x04000073 RID: 115
		public static readonly global::System.Windows.DependencyProperty InvalidValueErrorInfoProperty;

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty IsAlwaysInEditModeProperty;

		// Token: 0x04000075 RID: 117
		private static readonly global::System.Windows.DependencyPropertyKey IsEmbeddedPropertyKey;

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty IsEmbeddedProperty;

		// Token: 0x04000077 RID: 119
		public static readonly global::System.Windows.DependencyProperty IsFocusWithinProperty;

		// Token: 0x04000078 RID: 120
		public static readonly global::System.Windows.DependencyProperty IsInEditModeProperty;

		// Token: 0x04000079 RID: 121
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x0400007A RID: 122
		protected static readonly global::System.Windows.DependencyPropertyKey OriginalValuePropertyKey;

		// Token: 0x0400007B RID: 123
		public static readonly global::System.Windows.DependencyProperty OriginalValueProperty;

		// Token: 0x0400007C RID: 124
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Obsolete("This property has been obsoleted. Use 'IsReadOnly' property instead.", false)]
		[global::System.ComponentModel.Browsable(false)]
		public static readonly global::System.Windows.DependencyProperty ReadOnlyProperty;

		// Token: 0x0400007D RID: 125
		public static readonly global::System.Windows.DependencyProperty ThemeProperty;

		// Token: 0x0400007E RID: 126
		public static readonly global::System.Windows.DependencyProperty FormatProviderProperty;

		// Token: 0x0400007F RID: 127
		private global::System.IFormatProvider _cachedFormatProvider;

		// Token: 0x04000080 RID: 128
		public static readonly global::System.Windows.DependencyProperty FormatProperty;

		// Token: 0x04000081 RID: 129
		private string _cachedFormat;
	}
}
