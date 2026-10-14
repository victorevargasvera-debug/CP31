using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000022 RID: 34
	[global::System.Windows.TemplateVisualState(Name = "Uneditable", GroupName = "EditStates")]
	[global::System.Windows.Markup.ContentProperty("Value")]
	[global::System.Windows.StyleTypedProperty(Property = "ComboBoxStyle", StyleTargetType = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.Windows.TemplatePart(Name = "PART_Content", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamComboEditor")]
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplatePart(Name = "PART_DropDownButton", Type = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Editable", GroupName = "EditStates")]
	public class XamComboEditor : global::Infragistics.Windows.Editors.TextEditorBase, global::Infragistics.Windows.Editors.ISupportsSelectableText, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00008064 File Offset: 0x00006264
		static XamComboEditor()
		{
			global::Infragistics.Windows.Editors.XamComboEditor.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Editors.XamComboEditor));
			global::Infragistics.Windows.Editors.XamComboEditor.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Editors.XamComboEditor));
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownOpened", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.Editors.XamComboEditor));
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownClosed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.Editors.XamComboEditor));
			global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty = global::System.Windows.DependencyProperty.Register("EditPortionWidth", typeof(double), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));
			global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty = global::System.Windows.DependencyProperty.Register("ComboBoxStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnComboBoxStyleChanged), null));
			global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorProperty = global::System.Windows.DependencyProperty.Register("ComboEditor", typeof(global::Infragistics.Windows.Editors.XamComboEditor), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorComboBoxStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.XamComboEditor), "ComboEditorComboBoxStyleKey");
			global::Infragistics.Windows.Editors.XamComboEditor.DisplayValuePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplayValue", typeof(object), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueProperty = global::Infragistics.Windows.Editors.XamComboEditor.DisplayValuePropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty = global::System.Windows.DependencyProperty.Register("DisplayValueSource", typeof(global::Infragistics.Windows.Editors.DisplayValueSource), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.DisplayValueSource.DisplayText, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnDisplayValueSourceChanged)));
			global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.XamComboEditor), "DisplayValueTemplateKey");
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty = global::System.Windows.DependencyProperty.Register("DropDownButtonDisplayMode", typeof(global::Infragistics.Windows.Editors.DropDownButtonDisplayMode), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.DropDownButtonDisplayMode.MouseOver, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty = global::System.Windows.DependencyProperty.Register("DropDownButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DropDownButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty = global::System.Windows.DependencyProperty.Register("DropDownResizeMode", typeof(global::Infragistics.Windows.Controls.PopupResizeMode), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizeMode.Both, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.IsDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnIsDropDownOpenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnCoerceIsDropDownOpen)));
			global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty = global::System.Windows.DependencyProperty.Register("IsEditable", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueEditor.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty = global::System.Windows.DependencyProperty.Register("ItemsProvider", typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnItemsProviderChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnItemsProviderCoerced)));
			global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemsSourceProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnItemsSourceChanged)));
			global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayMemberPathProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnDisplayMemberPathChanged)));
			global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValuePathProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnValuePathChanged)));
			global::Infragistics.Windows.Editors.XamComboEditor.LimitToListProperty = global::System.Windows.DependencyProperty.Register("LimitToList", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnLimitToListChanged)));
			global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty = global::System.Windows.DependencyProperty.Register("MaxDropDownHeight", typeof(double), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ComboBox.MaxDropDownHeightProperty.DefaultMetadata.DefaultValue, global::System.Windows.FrameworkPropertyMetadataOptions.None, null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.ValidateMaxDropDownHeight));
			global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty = global::System.Windows.DependencyProperty.Register("MaxDropDownWidth", typeof(double), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, global::System.Windows.FrameworkPropertyMetadataOptions.None, null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.ValidateMaxDropDownWidth));
			global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty = global::System.Windows.DependencyProperty.Register("MinDropDownWidth", typeof(double), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.None, null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.ValidateMinDropDownWidth));
			global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("MinDropDownWidthResolved", typeof(double), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthResolvedProperty = global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthResolvedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.XamComboEditor.PreDropDownAreaTemplateProperty = global::System.Windows.DependencyProperty.Register("PreDropDownAreaTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty = global::System.Windows.DependencyProperty.Register("PostDropDownAreaTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty = global::System.Windows.DependencyProperty.Register("SelectedIndex", typeof(int), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(-1, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnSelectedIndexChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnCoerceSelectedIndex)));
			global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty = global::System.Windows.DependencyProperty.Register("SelectedItem", typeof(object), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnSelectedItemChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnCoerceSelectedItem)));
			global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedItemChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<object>), typeof(global::Infragistics.Windows.Editors.XamComboEditor));
			global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TextAlignmentResolved", typeof(global::System.Windows.TextAlignment), typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedProperty = global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(object)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamComboEditor.OnHorizontalContentAlignmentChanged)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamComboEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center));
			global::System.ComponentModel.DependencyPropertyDescriptor dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromName("IsTextSearchCaseSensitive", typeof(global::System.Windows.Controls.ComboBox), typeof(global::System.Windows.Controls.ComboBox));
			if (dependencyPropertyDescriptor != null)
			{
				global::Infragistics.Windows.Editors.XamComboEditor.s_IsTextSearchCaseSensitiveProperty = dependencyPropertyDescriptor.DependencyProperty;
			}
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamComboEditor));
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00008808 File Offset: 0x00006A08
		public XamComboEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamComboEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00008858 File Offset: 0x00006A58
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008862 File Offset: 0x00006A62
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060001E6 RID: 486 RVA: 0x00008886 File Offset: 0x00006A86
		// (remove) Token: 0x060001E7 RID: 487 RVA: 0x00008894 File Offset: 0x00006A94
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamComboEditor.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamComboEditor.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000088A2 File Offset: 0x00006AA2
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000088AC File Offset: 0x00006AAC
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060001EA RID: 490 RVA: 0x000088C7 File Offset: 0x00006AC7
		// (remove) Token: 0x060001EB RID: 491 RVA: 0x000088D5 File Offset: 0x00006AD5
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamComboEditor.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamComboEditor.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000088E3 File Offset: 0x00006AE3
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000088ED File Offset: 0x00006AED
		internal void RaiseDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent;
			args.Source = this;
			this.OnDropDownOpened(args);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00008908 File Offset: 0x00006B08
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00008916 File Offset: 0x00006B16
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropDownOpened
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent, value);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00008924 File Offset: 0x00006B24
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000892E File Offset: 0x00006B2E
		internal void RaiseDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent;
			args.Source = this;
			this.OnDropDownClosed(args);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001F2 RID: 498 RVA: 0x00008949 File Offset: 0x00006B49
		// (remove) Token: 0x060001F3 RID: 499 RVA: 0x00008957 File Offset: 0x00006B57
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropDownClosed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent, value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00008965 File Offset: 0x00006B65
		protected override global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter.DisplayTextConverter;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000896C File Offset: 0x00006B6C
		protected override global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter.Converter;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00008973 File Offset: 0x00006B73
		internal override bool HasDropDown
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00008976 File Offset: 0x00006B76
		internal override bool HasOpenDropDown
		{
			get
			{
				return this.IsDropDownOpen;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000897E File Offset: 0x00006B7E
		public override bool CanEditType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00008990 File Offset: 0x00006B90
		public override bool CanRenderType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000089A4 File Offset: 0x00006BA4
		internal override bool ConvertTextToValueHelper(string text, out object value, out global::System.Exception error)
		{
			if (!base.ConvertTextToValueHelper(text, out value, out error))
			{
				if (value == null)
				{
					global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = this.ItemsProvider;
					if (itemsProvider != null)
					{
						int selectedIndex = this.SelectedIndex;
						object obj;
						int num = itemsProvider.FindListItemFromDisplayText(text, false, 0, selectedIndex, out obj);
						if (num >= 0)
						{
							return true;
						}
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000089E8 File Offset: 0x00006BE8
		internal override void InitializeValueProperties()
		{
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, this) && this.SelectedIndex >= 0)
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty);
				base.SyncValueProperties(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, this.SelectedIndex);
				return;
			}
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty, this) && this.SelectedItem != null)
			{
				base.SyncValueProperties(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty, this.SelectedItem);
				return;
			}
			base.InitializeValueProperties();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00008A5A File Offset: 0x00006C5A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return orientation == global::System.Windows.Controls.Orientation.Horizontal;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008A64 File Offset: 0x00006C64
		protected override string OnCoerceText(string text)
		{
			string result = base.OnCoerceText(text);
			this.OnCoerceValueProperty(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, text);
			return result;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008A88 File Offset: 0x00006C88
		protected override object OnCoerceValue(object val)
		{
			object result = base.OnCoerceValue(val);
			this.OnCoerceValueProperty(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, val);
			return result;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008AAA File Offset: 0x00006CAA
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamComboEditorAutomationPeer(this);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00008AB2 File Offset: 0x00006CB2
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			this.InitializeComboBoxValue(false);
			base.OnEditModeStarted(args);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00008AC4 File Offset: 0x00006CC4
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			global::System.Windows.Controls.ComboBox lastComboBox = this._lastComboBox;
			this._lastComboBox = (base.FocusSite as global::System.Windows.Controls.ComboBox);
			this.OnComboBoxChanged(lastComboBox);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00008AF6 File Offset: 0x00006CF6
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			base.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00008B0C File Offset: 0x00006D0C
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (base.IsInEditMode && base.IsReadOnly)
			{
				global::System.Windows.Input.Key key = e.Key;
				switch (key)
				{
				case global::System.Windows.Input.Key.Prior:
				case global::System.Windows.Input.Key.Next:
				case global::System.Windows.Input.Key.End:
				case global::System.Windows.Input.Key.Home:
				case global::System.Windows.Input.Key.Left:
				case global::System.Windows.Input.Key.Up:
				case global::System.Windows.Input.Key.Right:
				case global::System.Windows.Input.Key.Down:
					break;
				default:
					if (key != global::System.Windows.Input.Key.F2 && key != global::System.Windows.Input.Key.Oem5)
					{
						goto IL_54;
					}
					break;
				}
				e.Handled = true;
			}
			IL_54:
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00008B74 File Offset: 0x00006D74
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.UIElement.IsMouseOverProperty == property || global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty == property || global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty == property)
			{
				base.UpdateDropDownButtonVisibility();
				return;
			}
			if (global::System.Windows.FrameworkElement.ActualWidthProperty == property || global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty == property || global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty == property)
			{
				this.UpdateMinDropDownWidthResolved();
				return;
			}
			if (global::Infragistics.Windows.Editors.TextEditorBase.DisplayTextProperty == property)
			{
				this.InitializeDisplayValue();
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00008BDC File Offset: 0x00006DDC
		protected override void SetVisualState(bool useTransitions)
		{
			base.SetVisualState(useTransitions);
			if (this.IsEditable && base.IsEditingAllowed)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Editable", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Uneditable", useTransitions);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00008C10 File Offset: 0x00006E10
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			error = null;
			global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource source;
			if (global::Infragistics.Windows.Editors.ValueEditor.ValueProperty == prop)
			{
				source = global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Value;
			}
			else if (global::Infragistics.Windows.Editors.ValueEditor.TextProperty == prop)
			{
				source = global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Text;
			}
			else if (global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty == prop)
			{
				source = global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.SelectedItem;
			}
			else
			{
				if (global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty != prop)
				{
					return base.SyncValuePropertiesOverride(prop, newValue, out error);
				}
				source = global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.SelectedIndex;
			}
			this.OnValueChanged_SyncProperties(source, newValue, true);
			return true;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008C64 File Offset: 0x00006E64
		internal override void RaiseDropDownClosedIfPending()
		{
			if (this._isClosePending)
			{
				this._isClosePending = false;
				this.RaiseDropDownClosed(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00008C80 File Offset: 0x00006E80
		internal override bool ShouldToggleDropDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			bool flag = false;
			if (!this.IsEditable)
			{
				global::System.Windows.DependencyObject dependencyObject;
				if ((dependencyObject = base.GetTemplateChild("PART_Content")) == null)
				{
					dependencyObject = (base.GetTemplateChild("PART_TextBlock") ?? base.GetTemplateChild("TextBlock"));
				}
				global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement = (global::Infragistics.Windows.Utilities.GetParent(frameworkElement) as global::System.Windows.FrameworkElement);
				}
				if (frameworkElement != null && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(frameworkElement, e))
				{
					flag = true;
				}
				else
				{
					global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
					if (comboBox != null)
					{
						if (comboBox.ActualWidth <= 0.0 || comboBox.ActualHeight <= 0.0)
						{
							base.UpdateLayout();
						}
						if (global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(comboBox, e))
						{
							flag = true;
						}
					}
				}
			}
			if (!flag)
			{
				flag = base.ShouldToggleDropDown(e);
			}
			return flag;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008D34 File Offset: 0x00006F34
		protected override bool ValidateCurrentValue(out global::System.Exception error)
		{
			if (!base.ValidateCurrentValue(out error))
			{
				return false;
			}
			if (this.LimitToList && this.SelectedIndex < 0 && (!global::Infragistics.Windows.Editors.Utils.IsValueEmpty(base.Value) || !global::Infragistics.Windows.Editors.Utils.IsValueEmpty(base.Text)))
			{
				error = new global::System.Exception(global::Infragistics.Windows.Editors.Utils.GetString("LMSG_ItemDoesNotExist", new object[]
				{
					base.Value
				}));
				return false;
			}
			return true;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008D9C File Offset: 0x00006F9C
		protected override bool ValidateFocusSite(object focusSite, out global::System.Exception errorMessage)
		{
			if (!base.ValidateFocusSite(focusSite, out errorMessage))
			{
				return false;
			}
			if (!(focusSite is global::System.Windows.Controls.ComboBox))
			{
				errorMessage = new global::System.NotSupportedException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_5", new object[]
				{
					focusSite.GetType().Name
				}));
				return false;
			}
			return true;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008DE8 File Offset: 0x00006FE8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ValidateValue(object value, out global::System.Exception error)
		{
			if (!base.ValidateValue(value, out error))
			{
				return false;
			}
			if (this.LimitToList && !global::Infragistics.Windows.Editors.Utils.IsValueEmpty(value))
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = this.ItemsProvider;
				object obj;
				if (itemsProvider == null || itemsProvider.FindListItemFromDataValue(value, -1, out obj) < 0)
				{
					error = new global::System.Exception(global::Infragistics.Windows.Editors.Utils.GetString("LMSG_ItemDoesNotExist", new object[]
					{
						value
					}));
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00008E48 File Offset: 0x00007048
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00008E5A File Offset: 0x0000705A
		private double EditPortionWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00008E6D File Offset: 0x0000706D
		internal global::System.Windows.Controls.TextBox TextBox
		{
			get
			{
				return this._lastComboBoxTextBox;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00008E75 File Offset: 0x00007075
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.ComboBox ComboBox
		{
			get
			{
				return this._lastComboBox;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00008E7D File Offset: 0x0000707D
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00008E8F File Offset: 0x0000708F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ComboBoxStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty, value);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00008E9D File Offset: 0x0000709D
		private static void OnComboBoxStyleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Style style = (global::System.Windows.Style)e.NewValue;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00008EAC File Offset: 0x000070AC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeComboBoxStyle()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty, this);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00008EB9 File Offset: 0x000070B9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetComboBoxStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00008EC6 File Offset: 0x000070C6
		protected virtual global::System.Windows.ResourceKey ComboBoxStyleKey
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorComboBoxStyleKey;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008ECD File Offset: 0x000070CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public static global::Infragistics.Windows.Editors.XamComboEditor GetComboEditor(global::System.Windows.DependencyObject element)
		{
			return (global::Infragistics.Windows.Editors.XamComboEditor)element.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorProperty);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00008EDF File Offset: 0x000070DF
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetComboEditor(global::System.Windows.DependencyObject element, global::Infragistics.Windows.Editors.XamComboEditor value)
		{
			element.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorProperty, value);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00008EED File Offset: 0x000070ED
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public object DisplayValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueProperty);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00008EFA File Offset: 0x000070FA
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00008F0C File Offset: 0x0000710C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.DisplayValueSource DisplayValueSource
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DisplayValueSource)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty, value);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00008F20 File Offset: 0x00007120
		private static void OnDisplayValueSourceChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.InitializeComboBoxItemTemplateHelper();
			xamComboEditor.InitializeDisplayValue();
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008F40 File Offset: 0x00007140
		private void InitializeDisplayValue()
		{
			global::Infragistics.Windows.Editors.DisplayValueSource displayValueSource = this.DisplayValueSource;
			if (global::Infragistics.Windows.Editors.DisplayValueSource.SelectedItem == displayValueSource || (this.SelectedItem is global::Infragistics.Windows.Editors.ComboBoxDataItem && string.IsNullOrEmpty(this.DisplayMemberPath)))
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValuePropertyKey, this.SelectedItem);
				return;
			}
			if (global::Infragistics.Windows.Editors.DisplayValueSource.Value == displayValueSource)
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValuePropertyKey, base.Value);
				return;
			}
			base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValuePropertyKey, base.DisplayText);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00008FAB File Offset: 0x000071AB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayValueSource()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty, this);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008FB8 File Offset: 0x000071B8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayValueSource()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00008FC5 File Offset: 0x000071C5
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00008FD7 File Offset: 0x000071D7
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.DropDownButtonDisplayMode DropDownButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DropDownButtonDisplayMode)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008FEA File Offset: 0x000071EA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDropDownButtonDisplayMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty, this);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008FF7 File Offset: 0x000071F7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDropDownButtonDisplayMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00009004 File Offset: 0x00007204
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00009016 File Offset: 0x00007216
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DropDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty, value);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00009024 File Offset: 0x00007224
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDropDownButtonStyle()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty, this);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00009031 File Offset: 0x00007231
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDropDownButtonStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000903E File Offset: 0x0000723E
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility DropDownButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityProperty);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00009050 File Offset: 0x00007250
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00009062 File Offset: 0x00007262
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.PopupResizeMode DropDownResizeMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PopupResizeMode)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty, value);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00009075 File Offset: 0x00007275
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDropDownResizeMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty, this);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00009082 File Offset: 0x00007282
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDropDownResizeMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000908F File Offset: 0x0000728F
		// (set) Token: 0x0600022D RID: 557 RVA: 0x000090A1 File Offset: 0x000072A1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.IsDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.IsDropDownOpenProperty, value);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000090B4 File Offset: 0x000072B4
		private static object OnCoerceIsDropDownOpen(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			bool flag = (bool)valueAsObject;
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			if (flag)
			{
				if (xamComboEditor.IsReadOnly)
				{
					return false;
				}
				xamComboEditor.StartEditMode();
				if (!xamComboEditor.IsInEditMode)
				{
					return false;
				}
			}
			return flag;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00009100 File Offset: 0x00007300
		private static void OnIsDropDownOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)d;
			bool flag = true.Equals(e.NewValue);
			if (flag)
			{
				xamComboEditor.RaiseDropDownClosedIfPending();
			}
			else
			{
				xamComboEditor._isClosePending = true;
			}
			bool flag2 = (bool)e.NewValue;
			bool oldValue = !flag2;
			xamComboEditor.RaiseAutomationExpandCollapseStateChanged(oldValue, flag2);
			xamComboEditor.CoerceValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000915D File Offset: 0x0000735D
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0000916F File Offset: 0x0000736F
		[global::System.ComponentModel.Bindable(true)]
		public bool IsEditable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty, value);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00009182 File Offset: 0x00007382
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsEditable()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty, this);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000918F File Offset: 0x0000738F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsEditable()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000919C File Offset: 0x0000739C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000091AE File Offset: 0x000073AE
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.ComboBoxItemsProvider ItemsProvider
		{
			get
			{
				return (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty, value);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000091BC File Offset: 0x000073BC
		private static void OnItemsProviderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)e.NewValue;
			xamComboEditor.VerifyInternalItemsProvider(false, comboBoxItemsProvider);
			xamComboEditor.InitializeComboBoxItemsSource(xamComboEditor.ComboBox);
			global::System.Windows.Threading.Dispatcher dispatcher = xamComboEditor.Dispatcher;
			if (dispatcher != null && xamComboEditor.SupportsAsyncOperations)
			{
				dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.Editors.Utils.MethodInvoker(xamComboEditor.OnItemsProviderItemsChanged));
			}
			else
			{
				xamComboEditor.OnItemsProviderItemsChanged();
			}
			if (comboBoxItemsProvider != null)
			{
				xamComboEditor._itemsProviderVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(comboBoxItemsProvider, global::Infragistics.Windows.Editors.ComboBoxItemsProvider.VersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(xamComboEditor.OnItemsProviderItemsChanged), true);
				return;
			}
			xamComboEditor._itemsProviderVersionTracker = null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00009248 File Offset: 0x00007448
		private void OnItemsProviderItemsChanged()
		{
			if (!global::Infragistics.Windows.Editors.Utils.IsValueEmpty(base.Value))
			{
				base.SyncValueProperties(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, base.Value);
				return;
			}
			if (!global::Infragistics.Windows.Editors.Utils.IsValueEmpty(base.Text))
			{
				base.SyncValueProperties(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, base.Text);
				return;
			}
			if (this._selectedItemCoerced)
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty);
				return;
			}
			if (this._selectedIndexCoerced)
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000092BC File Offset: 0x000074BC
		private static object OnItemsProviderCoerced(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.VerifyInternalItemsProvider(true, valueAsObject as global::Infragistics.Windows.Editors.ComboBoxItemsProvider);
			if (xamComboEditor._internalItemsProvider != null)
			{
				return xamComboEditor._internalItemsProvider;
			}
			return valueAsObject;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000092ED File Offset: 0x000074ED
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsProvider()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty, this) && this._internalItemsProvider != this.ItemsProvider;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000930F File Offset: 0x0000750F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsProvider()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000931C File Offset: 0x0000751C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000932E File Offset: 0x0000752E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty, value);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000933C File Offset: 0x0000753C
		private static void OnItemsSourceChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.VerifyInternalItemsProvider(false, xamComboEditor.ItemsProvider);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00009360 File Offset: 0x00007560
		private void VerifyInternalItemsProvider(bool fromItemsProviderCoerced, global::Infragistics.Windows.Editors.ComboBoxItemsProvider currentItemsProvider)
		{
			if (!base.IsInitialized)
			{
				return;
			}
			global::System.Collections.IEnumerable itemsSource = this.ItemsSource;
			if ((!fromItemsProviderCoerced || currentItemsProvider == null) && this._internalItemsProvider != null && itemsSource != null && this._internalItemsProvider.ItemsSource == itemsSource)
			{
				return;
			}
			if (currentItemsProvider == null || currentItemsProvider == this._internalItemsProvider)
			{
				if (itemsSource != null)
				{
					this._internalItemsProvider = this.CreateInternalItemsProvider();
					if (!fromItemsProviderCoerced)
					{
						base.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
						return;
					}
				}
				else
				{
					this._internalItemsProvider = null;
					if (!fromItemsProviderCoerced)
					{
						base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
						return;
					}
				}
			}
			else
			{
				this._internalItemsProvider = null;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000093EE File Offset: 0x000075EE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsSource()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty, this);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000093FB File Offset: 0x000075FB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsSource()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00009408 File Offset: 0x00007608
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000941A File Offset: 0x0000761A
		[global::System.ComponentModel.Bindable(true)]
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009428 File Offset: 0x00007628
		private static void OnDisplayMemberPathChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			string displayMemberPath = (string)e.NewValue;
			if (xamComboEditor._internalItemsProvider != null)
			{
				if (xamComboEditor.Host == null)
				{
					xamComboEditor._internalItemsProvider.DisplayMemberPath = displayMemberPath;
					return;
				}
				xamComboEditor._internalItemsProvider = null;
				xamComboEditor.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009478 File Offset: 0x00007678
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayMemberPath()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty, this);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009485 File Offset: 0x00007685
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayMemberPath()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00009492 File Offset: 0x00007692
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000094A4 File Offset: 0x000076A4
		[global::System.ComponentModel.Bindable(true)]
		public string ValuePath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty, value);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000094B4 File Offset: 0x000076B4
		private static void OnValuePathChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			string valuePath = (string)e.NewValue;
			if (xamComboEditor._internalItemsProvider != null)
			{
				if (xamComboEditor.Host == null)
				{
					xamComboEditor._internalItemsProvider.ValuePath = valuePath;
					return;
				}
				xamComboEditor._internalItemsProvider = null;
				xamComboEditor.CoerceValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009504 File Offset: 0x00007704
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValuePath()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty, this);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009511 File Offset: 0x00007711
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValuePath()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00009520 File Offset: 0x00007720
		private static void OnLimitToListChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)d;
			xamComboEditor.ValidateCurrentValue();
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000953A File Offset: 0x0000773A
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000954C File Offset: 0x0000774C
		public bool LimitToList
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.LimitToListProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.LimitToListProperty, value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000955F File Offset: 0x0000775F
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00009571 File Offset: 0x00007771
		[global::System.ComponentModel.Bindable(true)]
		public double MaxDropDownHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty, value);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00009584 File Offset: 0x00007784
		private static bool ValidateMaxDropDownHeight(object objVal)
		{
			double num = (double)objVal;
			return num >= 0.0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000095A7 File Offset: 0x000077A7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxDropDownHeight()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty, this);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000095B4 File Offset: 0x000077B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxDropDownHeight()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000095C1 File Offset: 0x000077C1
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000095D3 File Offset: 0x000077D3
		[global::System.ComponentModel.Bindable(true)]
		public double MaxDropDownWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty, value);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000095E8 File Offset: 0x000077E8
		private static bool ValidateMaxDropDownWidth(object objVal)
		{
			double num = (double)objVal;
			return num >= 0.0;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000960B File Offset: 0x0000780B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxDropDownWidth()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty, this);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009618 File Offset: 0x00007818
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxDropDownWidth()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00009625 File Offset: 0x00007825
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00009637 File Offset: 0x00007837
		[global::System.ComponentModel.Bindable(true)]
		public double MinDropDownWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty, value);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000964A File Offset: 0x0000784A
		private static bool ValidateMinDropDownWidth(object objVal)
		{
			double num = (double)objVal;
			return true;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009654 File Offset: 0x00007854
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinDropDownWidth()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty, this);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009661 File Offset: 0x00007861
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinDropDownWidth()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000966E File Offset: 0x0000786E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public double MinDropDownWidthResolved
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthResolvedProperty);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00009680 File Offset: 0x00007880
		internal void UpdateMinDropDownWidthResolved()
		{
			double num = this.MinDropDownWidth;
			if (0.0 == num)
			{
				double editPortionWidth = this.EditPortionWidth;
				if (editPortionWidth > 0.0)
				{
					num = editPortionWidth;
					global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
					if (comboBox != null)
					{
						global::System.Windows.Thickness margin = comboBox.Margin;
						num += margin.Left + margin.Right + 7.0;
					}
				}
			}
			base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthResolvedPropertyKey, num);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000096F3 File Offset: 0x000078F3
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00009705 File Offset: 0x00007905
		public global::System.Windows.DataTemplate PreDropDownAreaTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.PreDropDownAreaTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.PreDropDownAreaTemplateProperty, value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00009713 File Offset: 0x00007913
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00009725 File Offset: 0x00007925
		public global::System.Windows.DataTemplate PostDropDownAreaTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty, value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00009733 File Offset: 0x00007933
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00009745 File Offset: 0x00007945
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public int SelectedIndex
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, value);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009758 File Offset: 0x00007958
		private static void OnSelectedIndexChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			int num = (int)e.NewValue;
			xamComboEditor._preferredIndexToMatch = -1;
			xamComboEditor.SyncValueProperties(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, num);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009794 File Offset: 0x00007994
		private static object OnCoerceSelectedIndex(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			int num = (int)valueAsObject;
			bool selectedIndexCoerced = false;
			if (xamComboEditor.IsInitialized)
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = xamComboEditor.ItemsProvider;
				int num2 = (itemsProvider != null) ? itemsProvider.Items.Count : 0;
				if (num < 0 || num >= num2)
				{
					selectedIndexCoerced = (num >= 0);
					num = -1;
				}
			}
			xamComboEditor._selectedIndexCoerced = selectedIndexCoerced;
			xamComboEditor.OnCoerceValueProperty(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, num);
			return num;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00009804 File Offset: 0x00007A04
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00009811 File Offset: 0x00007A11
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedItem
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty, value);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00009820 File Offset: 0x00007A20
		private static void OnSelectedItemChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			object newValue = e.NewValue;
			xamComboEditor.BeginSyncValueProperties();
			try
			{
				xamComboEditor.SyncValueProperties(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty, newValue);
				xamComboEditor.OnSelectedItemChanged(e.OldValue, newValue);
			}
			finally
			{
				xamComboEditor.EndSyncValueProperties();
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00009878 File Offset: 0x00007A78
		private static object OnCoerceSelectedItem(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			object obj = valueAsObject;
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			bool selectedItemCoerced = false;
			if (obj != null)
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = xamComboEditor.ItemsProvider;
				if (itemsProvider == null || itemsProvider.GetItemIndex(obj) < 0)
				{
					obj = global::System.Windows.DependencyProperty.UnsetValue;
					selectedItemCoerced = true;
				}
			}
			xamComboEditor._selectedItemCoerced = selectedItemCoerced;
			xamComboEditor.OnCoerceValueProperty(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty, obj);
			return obj;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000098C4 File Offset: 0x00007AC4
		protected virtual void OnSelectedItemChanged(object previousValue, object currentValue)
		{
			base.RaiseValuePropertyChangedEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<object>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600026C RID: 620 RVA: 0x000098F2 File Offset: 0x00007AF2
		// (remove) Token: 0x0600026D RID: 621 RVA: 0x00009900 File Offset: 0x00007B00
		public event global::System.Windows.RoutedPropertyChangedEventHandler<object> SelectedItemChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemChangedEvent, value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000990E File Offset: 0x00007B0E
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00009929 File Offset: 0x00007B29
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000993F File Offset: 0x00007B3F
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00009960 File Offset: 0x00007B60
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00009982 File Offset: 0x00007B82
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000099A3 File Offset: 0x00007BA3
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000099C5 File Offset: 0x00007BC5
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextAlignment TextAlignmentResolved
		{
			get
			{
				return (global::System.Windows.TextAlignment)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedProperty);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000099D8 File Offset: 0x00007BD8
		private void UpdateTextAlignmentResolved()
		{
			object obj = base.ReadLocalValue(global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty);
			if (global::System.Windows.DependencyProperty.UnsetValue != obj)
			{
				global::System.Windows.TextAlignment textAlignment = global::Infragistics.Windows.Editors.Utils.ToTextAlignment((global::System.Windows.HorizontalAlignment)obj);
				base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedPropertyKey, textAlignment);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedPropertyKey);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00009A24 File Offset: 0x00007C24
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.UpdateTextAlignmentResolved();
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00009A40 File Offset: 0x00007C40
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

		// Token: 0x06000278 RID: 632 RVA: 0x00009A74 File Offset: 0x00007C74
		private void ClearBypassNextComboTextChanged()
		{
			this._bypassNextComboTextChanged = false;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00009A80 File Offset: 0x00007C80
		private global::Infragistics.Windows.Editors.ComboBoxItemsProvider CreateInternalItemsProvider()
		{
			global::System.Collections.IEnumerable itemsSource = this.ItemsSource;
			if (itemsSource == null)
			{
				return null;
			}
			if (base.Host == null)
			{
				return this.CreateAndInitializeNewItemsProvider();
			}
			if (global::Infragistics.Windows.Editors.XamComboEditor._ItemsProviderMap == null)
			{
				global::Infragistics.Windows.Editors.XamComboEditor._ItemsProviderMap = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey, global::Infragistics.Windows.Editors.ComboBoxItemsProvider>(false, true);
			}
			global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey key = new global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey(this.DisplayMemberPath, this.ValuePath, itemsSource);
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider;
			if (!global::Infragistics.Windows.Editors.XamComboEditor._ItemsProviderMap.TryGetValue(key, out comboBoxItemsProvider) || comboBoxItemsProvider == null)
			{
				comboBoxItemsProvider = this.CreateAndInitializeNewItemsProvider();
				global::Infragistics.Windows.Editors.XamComboEditor._ItemsProviderMap[key] = comboBoxItemsProvider;
			}
			return comboBoxItemsProvider;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00009AF8 File Offset: 0x00007CF8
		private global::Infragistics.Windows.Editors.ComboBoxItemsProvider CreateAndInitializeNewItemsProvider()
		{
			return new global::Infragistics.Windows.Editors.ComboBoxItemsProvider
			{
				DisplayMemberPath = this.DisplayMemberPath,
				ValuePath = this.ValuePath,
				ItemsSource = this.ItemsSource
			};
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00009B30 File Offset: 0x00007D30
		private void InitializeCachedPropertyValues()
		{
			base.UpdateDropDownButtonVisibility();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00009B38 File Offset: 0x00007D38
		private void InitializeComboBoxItemsSource(global::System.Windows.Controls.ComboBox comboBox)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = this.ItemsProvider;
			global::System.Windows.Controls.ItemCollection itemCollection = (itemsProvider != null) ? itemsProvider.Items : null;
			if (comboBox != null && comboBox.ItemsSource != itemCollection)
			{
				bool isInitializingComboBox = this._isInitializingComboBox;
				this._isInitializingComboBox = true;
				try
				{
					comboBox.ItemsSource = ((itemCollection != null) ? new global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper(this, itemCollection) : null);
				}
				finally
				{
					this._isInitializingComboBox = isInitializingComboBox;
				}
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00009BA0 File Offset: 0x00007DA0
		private void InitializeComboBoxItemTemplateHelper()
		{
			global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
			if (!this._itemTemplateSetOnComboBox && comboBox != null && global::Infragistics.Windows.Editors.DisplayValueSource.Value == this.DisplayValueSource && comboBox.ItemTemplate == null)
			{
				comboBox.SetResourceReference(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty, global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueTemplateKey);
				this._itemTemplateSetOnComboBox = true;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00009BE8 File Offset: 0x00007DE8
		private void OnCoerceValueProperty(global::System.Windows.DependencyProperty property, object value)
		{
			if (this._selectedItemCoerced && global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty != property)
			{
				this._selectedItemCoerced = false;
				this.SelectedItem = this.SelectedItem;
			}
			if (this._selectedIndexCoerced && global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty != property)
			{
				this._selectedIndexCoerced = false;
				this.SelectedIndex = this.SelectedIndex;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00009C3C File Offset: 0x00007E3C
		private void OnComboBox_SelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
			if (comboBox != null && base.IsInEditMode)
			{
				if (!base.IsReadOnly)
				{
					bool flag = false;
					int selectedIndex = comboBox.SelectedIndex;
					if (this._lastComboBoxTextBox != null && selectedIndex >= 0)
					{
						global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = this.ItemsProvider;
						if (itemsProvider != null)
						{
							string displayText = itemsProvider.GetDisplayText(comboBox.SelectedItem, selectedIndex);
							if (displayText != this._lastComboBoxTextBox.Text)
							{
								flag = true;
								this._preferredIndexToMatch = selectedIndex;
							}
						}
					}
					if (!flag)
					{
						this.OnValueChanged_SyncProperties(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxSelectedIndex, comboBox.SelectedIndex, false);
						if (!this._bypassNextComboTextChanged)
						{
							this._bypassNextComboTextChanged = true;
							base.Dispatcher.BeginInvoke(new global::Infragistics.Windows.Editors.Utils.MethodInvoker(this.ClearBypassNextComboTextChanged), new object[0]);
							return;
						}
					}
				}
				else
				{
					comboBox.SelectedIndex = this.SelectedIndex;
				}
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00009D07 File Offset: 0x00007F07
		private void OnComboBox_DropDownOpened(object sender, global::System.EventArgs e)
		{
			this.RaiseDropDownOpened(new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent, this));
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00009D1A File Offset: 0x00007F1A
		private void OnComboBox_DropDownClosed(object sender, global::System.EventArgs e)
		{
			this.RaiseDropDownClosedIfPending();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00009D24 File Offset: 0x00007F24
		private void OnComboBoxChanged(global::System.Windows.Controls.ComboBox oldComboBox)
		{
			global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
			if (oldComboBox != null)
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty);
				oldComboBox.SelectionChanged -= this.OnComboBox_SelectionChanged;
				oldComboBox.DropDownOpened -= this.OnComboBox_DropDownOpened;
				oldComboBox.DropDownClosed -= this.OnComboBox_DropDownClosed;
				if (this._itemTemplateSetOnComboBox)
				{
					this._itemTemplateSetOnComboBox = false;
					oldComboBox.ClearValue(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty);
				}
			}
			if (this._lastComboBoxTextBox != null)
			{
				this._lastComboBoxTextBox.SelectionChanged -= this.OnTextBox_SelectionChanged;
				this._lastComboBoxTextBox.TextChanged -= this.OnTextBox_TextChanged;
				if (this._imeEventHandler != null)
				{
					this._imeEventHandler.Unhook(this._lastComboBoxTextBox);
				}
				this._lastComboBoxTextBox = null;
			}
			if (comboBox != null)
			{
				comboBox.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, this.ComboBoxStyleKey);
				comboBox.ApplyTemplate();
				this.InitializeComboBoxItemsSource(comboBox);
				comboBox.SelectionChanged += this.OnComboBox_SelectionChanged;
				comboBox.DropDownOpened += this.OnComboBox_DropDownOpened;
				comboBox.DropDownClosed += this.OnComboBox_DropDownClosed;
				this._lastComboBoxTextBox = (global::Infragistics.Windows.Utilities.GetDescendantFromName(this, "PART_EditableTextBox") as global::System.Windows.Controls.TextBox);
				if (this._lastComboBoxTextBox != null)
				{
					this._lastComboBoxTextBox.SelectionChanged += this.OnTextBox_SelectionChanged;
					this._lastComboBoxTextBox.TextChanged += this.OnTextBox_TextChanged;
					if (this._imeEventHandler == null)
					{
						this._imeEventHandler = new global::Infragistics.Windows.Editors.XamComboEditor.ImeEventHandler(this);
					}
					this._imeEventHandler.Hook(this._lastComboBoxTextBox);
				}
				global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.ActualWidthProperty, global::System.Windows.Data.BindingMode.OneWay, comboBox);
				base.SetBinding(global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty, binding);
				this.InitializeComboBoxItemTemplateHelper();
			}
			this.InitializeComboBoxValue(true);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00009EE0 File Offset: 0x000080E0
		private void OnTextBox_SelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			bool inOnComboBoxSelectionChanged = this._inOnComboBoxSelectionChanged;
			this._inOnComboBoxSelectionChanged = true;
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
				this._inOnComboBoxSelectionChanged = inOnComboBoxSelectionChanged;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00009F38 File Offset: 0x00008138
		private void OnTextBox_TextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			this.ProcessTextBox_TextChanged();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00009F40 File Offset: 0x00008140
		private void ProcessTextBox_TextChanged()
		{
			if (this._lastComboBoxTextBox != null && base.IsInEditMode && !base.IsReadOnly && (!this._bypassNextComboTextChanged || base.Text != this._lastComboBoxTextBox.Text))
			{
				if (this._imeEventHandler != null && this._imeEventHandler._textInputPending)
				{
					this._imeEventHandler._bypassedOnTextChanged++;
					return;
				}
				this.OnValueChanged_SyncProperties(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText, this._lastComboBoxTextBox.Text, false);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00009FC4 File Offset: 0x000081C4
		private bool? OnValueChanged_SyncPropertiesHelper(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource source, object value)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider = this.ItemsProvider;
			object obj = null;
			int num = -1;
			string text = string.Empty;
			object obj2 = null;
			global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
			bool flag = false;
			bool? flag2 = null;
			int preferredIndex = this.SelectedIndex;
			if (this._preferredIndexToMatch >= 0 && (global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxSelectedIndex == source || global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText == source))
			{
				preferredIndex = this._preferredIndexToMatch;
				this._preferredIndexToMatch = -1;
			}
			switch (source)
			{
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Value:
				obj2 = value;
				if (itemsProvider != null)
				{
					num = itemsProvider.FindListItemFromDataValue(obj2, preferredIndex, out obj);
					if (num >= 0)
					{
						text = itemsProvider.GetDisplayText(obj, num);
					}
					else
					{
						text = itemsProvider.GetDisplayTextFromDataValue(value, preferredIndex);
					}
				}
				else
				{
					global::System.Exception ex;
					base.ConvertValueToText(value, out text, out ex);
				}
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Text:
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText:
				flag = (source == global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText && comboBox != null && !comboBox.IsTextSearchEnabled);
				text = ((value != null) ? value.ToString() : string.Empty);
				num = ((itemsProvider == null) ? -1 : itemsProvider.FindListItemFromDisplayText(text, false, 0, preferredIndex, out obj));
				if (num >= 0)
				{
					obj = itemsProvider.GetItemAtIndex(num);
					if (global::Infragistics.Windows.Editors.XamComboEditor.s_IsTextSearchCaseSensitiveProperty != null && this._lastComboBox != null && (bool)this._lastComboBox.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.s_IsTextSearchCaseSensitiveProperty))
					{
						string displayText = itemsProvider.GetDisplayText(obj, num);
						if (string.Compare(text, displayText, false) == 0)
						{
							obj2 = itemsProvider.GetDataValue(obj, num);
							text = displayText;
						}
						else
						{
							num = -1;
						}
					}
					else
					{
						obj2 = itemsProvider.GetDataValue(obj, num);
						text = itemsProvider.GetDisplayText(obj, num);
					}
				}
				else if (this.LimitToList)
				{
					flag2 = new bool?(false);
				}
				else
				{
					obj2 = (string.IsNullOrEmpty(text) ? null : value);
					value = obj2;
					if (global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText != source)
					{
						return this.OnValueChanged_SyncPropertiesHelper(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Value, obj2);
					}
				}
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.SelectedIndex:
				if (itemsProvider != null)
				{
					num = (int)value;
					if (num >= 0)
					{
						obj = itemsProvider.GetItemAtIndex(num);
						obj2 = itemsProvider.GetDataValue(obj, num);
						text = itemsProvider.GetDisplayText(obj, num);
					}
				}
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.SelectedItem:
				if (itemsProvider != null)
				{
					num = itemsProvider.GetItemIndex(value);
					if (num >= 0)
					{
						obj = value;
						obj2 = itemsProvider.GetDataValue(obj, num);
						text = itemsProvider.GetDisplayText(obj, num);
					}
				}
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxSelectedIndex:
				flag = true;
				if (comboBox != null && itemsProvider != null)
				{
					num = comboBox.SelectedIndex;
					if (num >= 0)
					{
						obj = itemsProvider.GetItemAtIndex(num);
						obj2 = itemsProvider.GetDataValue(obj, num);
						text = itemsProvider.GetDisplayText(obj, num);
					}
					else if (this._lastComboBoxTextBox != null && !string.IsNullOrEmpty(this._lastComboBoxTextBox.Text))
					{
						return this.OnValueChanged_SyncPropertiesHelper(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText, this._lastComboBoxTextBox.Text);
					}
				}
				break;
			}
			this.Sync_SetValueHelper(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, num, source);
			this.Sync_SetValueHelper(global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty, obj, source);
			if (flag2 ?? true)
			{
				this.Sync_SetValueHelper(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, obj2, source);
			}
			this.Sync_SetValueHelper(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, text, source);
			string value2 = text;
			string text2;
			global::System.Exception ex2;
			if ((base.ValueToDisplayTextConverter != null || (string.IsNullOrEmpty(value2) && (value == null || global::System.DBNull.Value == value))) && base.ConvertValueToDisplayText(obj2, out text2, out ex2))
			{
				value2 = text2;
			}
			base.SetValue(global::Infragistics.Windows.Editors.TextEditorBase.DisplayTextPropertyKey, value2);
			this.InitializeDisplayValue();
			if (!flag && comboBox != null)
			{
				if (num >= 0)
				{
					comboBox.SelectedIndex = num;
				}
				else
				{
					comboBox.Text = text;
					if (comboBox.SelectedIndex >= 0)
					{
						int selectionStart = this.SelectionStart;
						int selectionLength = this.SelectionLength;
						using (new global::Infragistics.Windows.Helpers.TempValueReplacement(comboBox, global::System.Windows.Controls.ItemsControl.IsTextSearchEnabledProperty, global::Infragistics.KnownBoxes.FalseBox))
						{
							comboBox.SelectedIndex = -1;
							comboBox.Text = text;
							if (!string.IsNullOrEmpty(text))
							{
								this.SelectionStart = global::System.Math.Min(text.Length, selectionStart);
								this.SelectionLength = selectionStart + global::System.Math.Min(text.Length, selectionLength - selectionStart);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000A390 File Offset: 0x00008590
		private void OnValueChanged_SyncProperties(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource source, object value, bool calledFromSyncValuePropertiesOverride)
		{
			if (this._inOnValueChanged_SyncProperties || this._isInitializingComboBox || !base.InternalIsInitialized)
			{
				return;
			}
			this._inOnValueChanged_SyncProperties = true;
			base.BeginSyncValueProperties();
			try
			{
				bool? flag = this.OnValueChanged_SyncPropertiesHelper(source, value);
				if (!calledFromSyncValuePropertiesOverride && flag != null && !flag.Value)
				{
					base.ValidateCurrentValue();
				}
			}
			finally
			{
				this._inOnValueChanged_SyncProperties = false;
				base.EndSyncValueProperties();
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000A408 File Offset: 0x00008608
		private void Sync_SetValueHelper(global::System.Windows.DependencyProperty prop, object value, global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource changeSource)
		{
			global::System.Windows.DependencyProperty dependencyProperty = null;
			switch (changeSource)
			{
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Value:
				dependencyProperty = global::Infragistics.Windows.Editors.ValueEditor.ValueProperty;
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Text:
				dependencyProperty = global::Infragistics.Windows.Editors.ValueEditor.TextProperty;
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.SelectedIndex:
				dependencyProperty = global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty;
				break;
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.SelectedItem:
				dependencyProperty = global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemProperty;
				break;
			}
			if (prop != null && (prop == dependencyProperty || base.InternalIsInitializing))
			{
				object value2 = base.GetValue(prop);
				if ((value != null && value.GetType().IsPrimitive) ? global::Infragistics.Windows.Editors.Utils.AreEqual(value, value2) : (value == value2))
				{
					return;
				}
			}
			global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, prop, value);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A48E File Offset: 0x0000868E
		internal override void ToggleDropDown()
		{
			this.IsDropDownOpen = !this.IsDropDownOpen;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A4A0 File Offset: 0x000086A0
		private void RaiseAutomationExpandCollapseStateChanged(bool oldValue, bool newValue)
		{
			global::Infragistics.Windows.Automation.Peers.Editors.XamComboEditorAutomationPeer xamComboEditorAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.Editors.XamComboEditorAutomationPeer;
			if (xamComboEditorAutomationPeer != null)
			{
				xamComboEditorAutomationPeer.RaiseExpandCollapseStateChanged(oldValue, newValue);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000A4C4 File Offset: 0x000086C4
		private void InitializeComboBoxValue(bool onlyUpdateWhenInEditMode)
		{
			bool isInitializingComboBox = this._isInitializingComboBox;
			this._isInitializingComboBox = true;
			try
			{
				if (!onlyUpdateWhenInEditMode || base.IsInEditMode)
				{
					global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
					if (comboBox != null)
					{
						if (this.SelectedIndex >= 0)
						{
							comboBox.SelectedIndex = this.SelectedIndex;
						}
						else
						{
							comboBox.SelectedIndex = -1;
							comboBox.Text = base.Text;
						}
					}
				}
			}
			finally
			{
				this._isInitializingComboBox = isInitializingComboBox;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000A538 File Offset: 0x00008738
		public void SelectAll()
		{
			this.SelectionStart = 0;
			this.SelectionLength = this.TextLength;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A550 File Offset: 0x00008750
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.Editors.ComboEditorStates comboEditorStates = (global::Infragistics.Windows.Editors.ComboEditorStates)0L;
			if (base.IsInEditMode)
			{
				comboEditorStates |= global::Infragistics.Windows.Editors.ComboEditorStates.IsInEditMode;
			}
			if (this.IsDropDownOpen)
			{
				comboEditorStates |= global::Infragistics.Windows.Editors.ComboEditorStates.IsDropDownOpen;
			}
			return (long)(comboEditorStates & (global::Infragistics.Windows.Editors.ComboEditorStates)statesToQuery);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000A580 File Offset: 0x00008780
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return global::Infragistics.Windows.Editors.ComboEditorCommands.NotACommand == routedCommand || (routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.Editors.ComboEditorCommands));
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A5B8 File Offset: 0x000087B8
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(routedCommand, commandInfo.Parameter);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000A5E0 File Offset: 0x000087E0
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamComboEditor>.IsMinimumStatePresentForCommand(this, command))
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(command);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.ModifierKeys modifiers2 = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Tab);
			bool flag = false;
			if (global::Infragistics.Windows.Editors.ComboEditorCommands.NotACommand == command)
			{
				flag = true;
			}
			else if (global::Infragistics.Windows.Editors.ComboEditorCommands.ToggleDropDown == command)
			{
				this.ToggleDropDown();
				flag = true;
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(command));
			}
			return flag;
		}

		// Token: 0x04000086 RID: 134
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Controls.ComboBox _lastComboBox;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Controls.TextBox _lastComboBoxTextBox;

		// Token: 0x04000089 RID: 137
		private bool _inOnComboBoxSelectionChanged;

		// Token: 0x0400008A RID: 138
		private int _cachedSelectionStart;

		// Token: 0x0400008B RID: 139
		private int _cachedSelectionLength;

		// Token: 0x0400008C RID: 140
		private bool _isInitializingComboBox;

		// Token: 0x0400008D RID: 141
		private global::Infragistics.Windows.Editors.ComboBoxItemsProvider _internalItemsProvider;

		// Token: 0x0400008E RID: 142
		private bool _inOnValueChanged_SyncProperties;

		// Token: 0x0400008F RID: 143
		private bool _isClosePending;

		// Token: 0x04000090 RID: 144
		private bool _itemTemplateSetOnComboBox;

		// Token: 0x04000091 RID: 145
		private bool _selectedItemCoerced;

		// Token: 0x04000092 RID: 146
		private bool _selectedIndexCoerced;

		// Token: 0x04000093 RID: 147
		private static global::System.Windows.DependencyProperty s_IsTextSearchCaseSensitiveProperty;

		// Token: 0x04000094 RID: 148
		private bool _bypassNextComboTextChanged;

		// Token: 0x04000095 RID: 149
		private global::Infragistics.Windows.Editors.XamComboEditor.ImeEventHandler _imeEventHandler;

		// Token: 0x04000096 RID: 150
		private int _preferredIndexToMatch = -1;

		// Token: 0x04000097 RID: 151
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey, global::Infragistics.Windows.Editors.ComboBoxItemsProvider> _ItemsProviderMap;

		// Token: 0x0400009C RID: 156
		private static readonly global::System.Windows.DependencyProperty EditPortionWidthProperty;

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty ComboBoxStyleProperty;

		// Token: 0x0400009E RID: 158
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public static readonly global::System.Windows.DependencyProperty ComboEditorProperty;

		// Token: 0x0400009F RID: 159
		public static readonly global::System.Windows.ResourceKey ComboEditorComboBoxStyleKey;

		// Token: 0x040000A0 RID: 160
		private static readonly global::System.Windows.DependencyPropertyKey DisplayValuePropertyKey;

		// Token: 0x040000A1 RID: 161
		public static readonly global::System.Windows.DependencyProperty DisplayValueProperty;

		// Token: 0x040000A2 RID: 162
		public static readonly global::System.Windows.DependencyProperty DisplayValueSourceProperty;

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.ResourceKey DisplayValueTemplateKey;

		// Token: 0x040000A4 RID: 164
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty;

		// Token: 0x040000A5 RID: 165
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty;

		// Token: 0x040000A6 RID: 166
		internal static readonly global::System.Windows.DependencyPropertyKey DropDownButtonVisibilityPropertyKey;

		// Token: 0x040000A7 RID: 167
		public static readonly global::System.Windows.DependencyProperty DropDownButtonVisibilityProperty;

		// Token: 0x040000A8 RID: 168
		public static readonly global::System.Windows.DependencyProperty DropDownResizeModeProperty;

		// Token: 0x040000A9 RID: 169
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty;

		// Token: 0x040000AA RID: 170
		public static readonly global::System.Windows.DependencyProperty IsEditableProperty;

		// Token: 0x040000AB RID: 171
		public static readonly global::System.Windows.DependencyProperty ItemsProviderProperty;

		// Token: 0x040000AC RID: 172
		private global::Infragistics.Windows.Internal.PropertyValueTracker _itemsProviderVersionTracker;

		// Token: 0x040000AD RID: 173
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty;

		// Token: 0x040000AE RID: 174
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty;

		// Token: 0x040000AF RID: 175
		public static readonly global::System.Windows.DependencyProperty ValuePathProperty;

		// Token: 0x040000B0 RID: 176
		public static readonly global::System.Windows.DependencyProperty LimitToListProperty;

		// Token: 0x040000B1 RID: 177
		public static readonly global::System.Windows.DependencyProperty MaxDropDownHeightProperty;

		// Token: 0x040000B2 RID: 178
		public static readonly global::System.Windows.DependencyProperty MaxDropDownWidthProperty;

		// Token: 0x040000B3 RID: 179
		public static readonly global::System.Windows.DependencyProperty MinDropDownWidthProperty;

		// Token: 0x040000B4 RID: 180
		private static readonly global::System.Windows.DependencyPropertyKey MinDropDownWidthResolvedPropertyKey;

		// Token: 0x040000B5 RID: 181
		public static readonly global::System.Windows.DependencyProperty MinDropDownWidthResolvedProperty;

		// Token: 0x040000B6 RID: 182
		public static readonly global::System.Windows.DependencyProperty PreDropDownAreaTemplateProperty;

		// Token: 0x040000B7 RID: 183
		public static readonly global::System.Windows.DependencyProperty PostDropDownAreaTemplateProperty;

		// Token: 0x040000B8 RID: 184
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty;

		// Token: 0x040000B9 RID: 185
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty;

		// Token: 0x040000BB RID: 187
		private static readonly global::System.Windows.DependencyPropertyKey TextAlignmentResolvedPropertyKey;

		// Token: 0x040000BC RID: 188
		public static readonly global::System.Windows.DependencyProperty TextAlignmentResolvedProperty;

		// Token: 0x02000025 RID: 37
		internal class ComboBox_ItemsSourceWrapper : global::Infragistics.Windows.Editors.CollectionViewProxy, global::System.ComponentModel.ICollectionViewFactory
		{
			// Token: 0x060002C8 RID: 712 RVA: 0x0000AC48 File Offset: 0x00008E48
			static ComboBox_ItemsSourceWrapper()
			{
				try
				{
					global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.ItemCollectionCollectionViewField = typeof(global::System.Windows.Controls.ItemCollection).GetField("_collectionView", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyType = global::System.Type.GetType("MS.Internal.Data.CollectionViewProxy, " + typeof(global::System.Windows.Data.CollectionView).Assembly.FullName, false);
					global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyIndexerField = ((global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyType == null) ? null : global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyType.GetField("_indexer", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic));
					global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.IndexedEnumerableType = global::System.Type.GetType("MS.Internal.Data.IndexedEnumerable, " + typeof(global::System.Windows.Data.CollectionView).Assembly.FullName, false);
					global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.InvalidateEnumeratorMethod = ((global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.IndexedEnumerableType == null) ? null : global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.IndexedEnumerableType.GetMethod("InvalidateEnumerator", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic));
				}
				catch (global::System.Exception)
				{
				}
				global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper._canInvalidateCollectionViewProxy = (global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.InvalidateEnumeratorMethod != null && global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyIndexerField != null && global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.ItemCollectionCollectionViewField != null);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0000AD50 File Offset: 0x00008F50
			internal ComboBox_ItemsSourceWrapper(global::Infragistics.Windows.Editors.XamComboEditor comboEditor, global::System.Windows.Data.CollectionView itemsSource) : base(itemsSource)
			{
				global::Infragistics.Windows.Editors.Utils.ValidateNull(comboEditor);
				this._comboEditor = comboEditor;
			}

			// Token: 0x060002CA RID: 714 RVA: 0x0000AD74 File Offset: 0x00008F74
			protected override void OnSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				bool isInitializingComboBox = this._comboEditor._isInitializingComboBox;
				this._comboEditor._isInitializingComboBox = true;
				try
				{
					base.OnSourceCollectionChanged(sender, e);
				}
				finally
				{
					this._comboEditor._isInitializingComboBox = false;
				}
			}

			// Token: 0x060002CB RID: 715 RVA: 0x0000ADC0 File Offset: 0x00008FC0
			protected override void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				if (this._comboEditor._lastComboBox != null)
				{
					this._combos.Add(this._comboEditor._lastComboBox);
				}
				foreach (global::System.Windows.Controls.ComboBox comboBox in this._combos)
				{
					global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.InvalidateEnumerator(comboBox.Items);
				}
				base.RaiseCollectionChanged(e);
			}

			// Token: 0x060002CC RID: 716 RVA: 0x0000AE3C File Offset: 0x0000903C
			private static void InvalidateEnumerator(global::System.Windows.Controls.ItemCollection ic)
			{
				if (global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper._canInvalidateCollectionViewProxy)
				{
					try
					{
						global::System.ComponentModel.ICollectionView collectionView = global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.ItemCollectionCollectionViewField.GetValue(ic) as global::System.ComponentModel.ICollectionView;
						if (collectionView != null && global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyType.IsAssignableFrom(collectionView.GetType()))
						{
							object value = global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.CollectionViewProxyIndexerField.GetValue(collectionView);
							if (value != null && global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.IndexedEnumerableType.IsAssignableFrom(value.GetType()))
							{
								global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper.InvalidateEnumeratorMethod.Invoke(value, null);
							}
						}
					}
					catch (global::System.MethodAccessException)
					{
						global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper._canInvalidateCollectionViewProxy = false;
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.Windows.Editors.XamComboEditor.ComboBox_ItemsSourceWrapper._canInvalidateCollectionViewProxy = false;
					}
				}
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000AED4 File Offset: 0x000090D4
			global::System.ComponentModel.ICollectionView global::System.ComponentModel.ICollectionViewFactory.CreateView()
			{
				return this;
			}

			// Token: 0x040000C4 RID: 196
			private global::Infragistics.Windows.Editors.XamComboEditor _comboEditor;

			// Token: 0x040000C5 RID: 197
			private static readonly global::System.Reflection.FieldInfo ItemCollectionCollectionViewField;

			// Token: 0x040000C6 RID: 198
			private static readonly global::System.Type CollectionViewProxyType;

			// Token: 0x040000C7 RID: 199
			private static readonly global::System.Reflection.FieldInfo CollectionViewProxyIndexerField;

			// Token: 0x040000C8 RID: 200
			private static readonly global::System.Type IndexedEnumerableType;

			// Token: 0x040000C9 RID: 201
			private static readonly global::System.Reflection.MethodInfo InvalidateEnumeratorMethod;

			// Token: 0x040000CA RID: 202
			private static bool _canInvalidateCollectionViewProxy;

			// Token: 0x040000CB RID: 203
			private global::Infragistics.Collections.WeakSet<global::System.Windows.Controls.ComboBox> _combos = new global::Infragistics.Collections.WeakSet<global::System.Windows.Controls.ComboBox>();
		}

		// Token: 0x02000026 RID: 38
		private class ImeEventHandler
		{
			// Token: 0x060002CE RID: 718 RVA: 0x0000AED7 File Offset: 0x000090D7
			internal ImeEventHandler(global::Infragistics.Windows.Editors.XamComboEditor editor)
			{
				this._editor = new global::System.WeakReference(editor);
			}

			// Token: 0x060002CF RID: 719 RVA: 0x0000AEEB File Offset: 0x000090EB
			private global::Infragistics.Windows.Editors.XamComboEditor GetEditorHelper()
			{
				return (global::Infragistics.Windows.Editors.XamComboEditor)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._editor);
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x0000AEFD File Offset: 0x000090FD
			internal void Hook(global::System.Windows.Controls.TextBox textBox)
			{
				global::System.Windows.Input.TextCompositionManager.AddPreviewTextInputStartHandler(textBox, new global::System.Windows.Input.TextCompositionEventHandler(this.OnTextBox_TextInputStart));
				global::System.Windows.Input.TextCompositionManager.AddPreviewTextInputHandler(textBox, new global::System.Windows.Input.TextCompositionEventHandler(this.OnTextBox_TextInput));
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000AF23 File Offset: 0x00009123
			internal void Unhook(global::System.Windows.Controls.TextBox textBox)
			{
				global::System.Windows.Input.TextCompositionManager.RemovePreviewTextInputStartHandler(textBox, new global::System.Windows.Input.TextCompositionEventHandler(this.OnTextBox_TextInputStart));
				global::System.Windows.Input.TextCompositionManager.RemovePreviewTextInputHandler(textBox, new global::System.Windows.Input.TextCompositionEventHandler(this.OnTextBox_TextInput));
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x0000AF4C File Offset: 0x0000914C
			internal void OnTextBox_TextInputStart(object sender, global::System.Windows.Input.TextCompositionEventArgs args)
			{
				global::Infragistics.Windows.Editors.XamComboEditor editorHelper = this.GetEditorHelper();
				if (editorHelper != null)
				{
					this._textInputPending = true;
				}
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000AF6C File Offset: 0x0000916C
			internal void OnTextBox_TextInput(object sender, global::System.Windows.Input.TextCompositionEventArgs args)
			{
				if (this._textInputPending)
				{
					this._textInputPending = false;
					global::Infragistics.Windows.Editors.XamComboEditor editorHelper = this.GetEditorHelper();
					if (editorHelper != null && this._bypassedOnTextChanged > 0)
					{
						this._bypassedOnTextChanged = 0;
						editorHelper.ProcessTextBox_TextChanged();
					}
				}
			}

			// Token: 0x040000CC RID: 204
			internal readonly global::System.WeakReference _editor;

			// Token: 0x040000CD RID: 205
			internal bool _textInputPending;

			// Token: 0x040000CE RID: 206
			internal int _bypassedOnTextChanged;
		}

		// Token: 0x02000027 RID: 39
		private struct ItemsProviderKey : global::System.IEquatable<global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey>
		{
			// Token: 0x060002D4 RID: 724 RVA: 0x0000AFA8 File Offset: 0x000091A8
			internal ItemsProviderKey(string displayMemberPath, string valuePath, global::System.Collections.IEnumerable itemsSource)
			{
				this._displayMemberPath = displayMemberPath;
				this._valuePath = valuePath;
				this._itemsSourceRef = new global::System.WeakReference(itemsSource);
				this._hashCode = itemsSource.GetHashCode();
				if (this._displayMemberPath != null)
				{
					this._hashCode ^= this._displayMemberPath.GetHashCode();
				}
				if (this._valuePath != null)
				{
					this._hashCode ^= this._valuePath.GetHashCode();
				}
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x0000B01B File Offset: 0x0000921B
			public override bool Equals(object obj)
			{
				return obj is global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey && this == (global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey)obj;
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000B038 File Offset: 0x00009238
			public override int GetHashCode()
			{
				return this._hashCode;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x0000B040 File Offset: 0x00009240
			public static bool operator ==(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey key1, global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey key2)
			{
				return key1._displayMemberPath == key2._displayMemberPath && key1._valuePath == key2._valuePath && key1.ItemsSource == key2.ItemsSource;
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000B07E File Offset: 0x0000927E
			public static bool operator !=(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey key1, global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey key2)
			{
				return !(key1 == key2);
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000B08A File Offset: 0x0000928A
			internal global::System.Collections.IEnumerable ItemsSource
			{
				get
				{
					return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._itemsSourceRef) as global::System.Collections.IEnumerable;
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x0000B09C File Offset: 0x0000929C
			public bool Equals(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderKey other)
			{
				return other == this;
			}

			// Token: 0x040000CF RID: 207
			internal readonly string _displayMemberPath;

			// Token: 0x040000D0 RID: 208
			internal readonly string _valuePath;

			// Token: 0x040000D1 RID: 209
			private int _hashCode;

			// Token: 0x040000D2 RID: 210
			private global::System.WeakReference _itemsSourceRef;
		}

		// Token: 0x02000028 RID: 40
		private enum ValueChangeSource
		{
			// Token: 0x040000D4 RID: 212
			Value,
			// Token: 0x040000D5 RID: 213
			Text,
			// Token: 0x040000D6 RID: 214
			SelectedIndex,
			// Token: 0x040000D7 RID: 215
			SelectedItem,
			// Token: 0x040000D8 RID: 216
			ComboBoxText,
			// Token: 0x040000D9 RID: 217
			ComboBoxSelectedIndex
		}
	}
}
