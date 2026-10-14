using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
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
	// Token: 0x02000021 RID: 33
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamComboEditor")]
	[global::System.Windows.Markup.ContentProperty("Value")]
	[global::System.Windows.StyleTypedProperty(Property = "ComboBoxStyle", StyleTargetType = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplatePart(Name = "PART_DropDownButton", Type = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Editable", GroupName = "EditStates")]
	[global::System.Windows.TemplateVisualState(Name = "Uneditable", GroupName = "EditStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Content", Type = typeof(global::System.Windows.FrameworkElement))]
	public class XamComboEditor : global::Infragistics.Windows.Editors.TextEditorBase, global::Infragistics.Windows.Editors.ISupportsSelectableText, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00007DD8 File Offset: 0x00005FD8
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
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000856C File Offset: 0x0000676C
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

		// Token: 0x060001D9 RID: 473 RVA: 0x000085B8 File Offset: 0x000067B8
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000085C2 File Offset: 0x000067C2
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060001DB RID: 475 RVA: 0x000085E6 File Offset: 0x000067E6
		// (remove) Token: 0x060001DC RID: 476 RVA: 0x000085F4 File Offset: 0x000067F4
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

		// Token: 0x060001DD RID: 477 RVA: 0x00008602 File Offset: 0x00006802
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000860C File Offset: 0x0000680C
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060001DF RID: 479 RVA: 0x00008627 File Offset: 0x00006827
		// (remove) Token: 0x060001E0 RID: 480 RVA: 0x00008635 File Offset: 0x00006835
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

		// Token: 0x060001E1 RID: 481 RVA: 0x00008643 File Offset: 0x00006843
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000864D File Offset: 0x0000684D
		internal void RaiseDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent;
			args.Source = this;
			this.OnDropDownOpened(args);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060001E3 RID: 483 RVA: 0x00008668 File Offset: 0x00006868
		// (remove) Token: 0x060001E4 RID: 484 RVA: 0x00008676 File Offset: 0x00006876
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

		// Token: 0x060001E5 RID: 485 RVA: 0x00008684 File Offset: 0x00006884
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000868E File Offset: 0x0000688E
		internal void RaiseDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent;
			args.Source = this;
			this.OnDropDownClosed(args);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001E7 RID: 487 RVA: 0x000086A9 File Offset: 0x000068A9
		// (remove) Token: 0x060001E8 RID: 488 RVA: 0x000086B7 File Offset: 0x000068B7
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000086C5 File Offset: 0x000068C5
		protected override global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter.DisplayTextConverter;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000086CC File Offset: 0x000068CC
		protected override global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter.Converter;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000086D3 File Offset: 0x000068D3
		internal override bool HasDropDown
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000086D6 File Offset: 0x000068D6
		internal override bool HasOpenDropDown
		{
			get
			{
				return this.IsDropDownOpen;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000086DE File Offset: 0x000068DE
		public override bool CanEditType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000086F0 File Offset: 0x000068F0
		public override bool CanRenderType(global::System.Type type)
		{
			return type == typeof(string);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00008704 File Offset: 0x00006904
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

		// Token: 0x060001F0 RID: 496 RVA: 0x00008748 File Offset: 0x00006948
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

		// Token: 0x060001F1 RID: 497 RVA: 0x000087BA File Offset: 0x000069BA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return orientation == global::System.Windows.Controls.Orientation.Horizontal;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000087C4 File Offset: 0x000069C4
		protected override string OnCoerceText(string text)
		{
			string result = base.OnCoerceText(text);
			this.OnCoerceValueProperty(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, text);
			return result;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000087E8 File Offset: 0x000069E8
		protected override object OnCoerceValue(object val)
		{
			object result = base.OnCoerceValue(val);
			this.OnCoerceValueProperty(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, val);
			return result;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000880A File Offset: 0x00006A0A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamComboEditorAutomationPeer(this);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008812 File Offset: 0x00006A12
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			this.InitializeComboBoxValue(false);
			base.OnEditModeStarted(args);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00008824 File Offset: 0x00006A24
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			global::System.Windows.Controls.ComboBox lastComboBox = this._lastComboBox;
			this._lastComboBox = (base.FocusSite as global::System.Windows.Controls.ComboBox);
			this.OnComboBoxChanged(lastComboBox);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00008858 File Offset: 0x00006A58
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

		// Token: 0x060001F8 RID: 504 RVA: 0x000088C0 File Offset: 0x00006AC0
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

		// Token: 0x060001F9 RID: 505 RVA: 0x00008928 File Offset: 0x00006B28
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

		// Token: 0x060001FA RID: 506 RVA: 0x0000895C File Offset: 0x00006B5C
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

		// Token: 0x060001FB RID: 507 RVA: 0x000089B0 File Offset: 0x00006BB0
		internal override void RaiseDropDownClosedIfPending()
		{
			if (this._isClosePending)
			{
				this._isClosePending = false;
				this.RaiseDropDownClosed(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000089CC File Offset: 0x00006BCC
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

		// Token: 0x060001FD RID: 509 RVA: 0x00008A80 File Offset: 0x00006C80
		protected override bool ValidateCurrentValue(out global::System.Exception error)
		{
			if (!base.ValidateCurrentValue(out error))
			{
				return false;
			}
			if (this.LimitToList && this.SelectedIndex < 0 && (!global::Infragistics.Windows.Editors.Utils.IsValueEmpty(base.Value) || !global::Infragistics.Windows.Editors.Utils.IsValueEmpty(base.Text)))
			{
				error = new global::System.Exception("Value must be one of the items in the drop-down.");
				return false;
			}
			return true;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00008AD4 File Offset: 0x00006CD4
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00008B1F File Offset: 0x00006D1F
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00008B31 File Offset: 0x00006D31
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00008B44 File Offset: 0x00006D44
		internal global::System.Windows.Controls.TextBox TextBox
		{
			get
			{
				return this._lastComboBoxTextBox;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00008B4C File Offset: 0x00006D4C
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.ComboBox ComboBox
		{
			get
			{
				return this._lastComboBox;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00008B54 File Offset: 0x00006D54
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00008B66 File Offset: 0x00006D66
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

		// Token: 0x06000205 RID: 517 RVA: 0x00008B74 File Offset: 0x00006D74
		private static void OnComboBoxStyleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Style style = (global::System.Windows.Style)e.NewValue;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00008B83 File Offset: 0x00006D83
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeComboBoxStyle()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty, this);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00008B90 File Offset: 0x00006D90
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetComboBoxStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00008B9D File Offset: 0x00006D9D
		protected virtual global::System.Windows.ResourceKey ComboBoxStyleKey
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorComboBoxStyleKey;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008BA4 File Offset: 0x00006DA4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::Infragistics.Windows.Editors.XamComboEditor GetComboEditor(global::System.Windows.DependencyObject element)
		{
			return (global::Infragistics.Windows.Editors.XamComboEditor)element.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorProperty);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00008BB6 File Offset: 0x00006DB6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public static void SetComboEditor(global::System.Windows.DependencyObject element, global::Infragistics.Windows.Editors.XamComboEditor value)
		{
			element.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorProperty, value);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public object DisplayValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueProperty);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00008BD1 File Offset: 0x00006DD1
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00008BE3 File Offset: 0x00006DE3
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

		// Token: 0x0600020E RID: 526 RVA: 0x00008BF8 File Offset: 0x00006DF8
		private static void OnDisplayValueSourceChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.InitializeComboBoxItemTemplateHelper();
			xamComboEditor.InitializeDisplayValue();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008C18 File Offset: 0x00006E18
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

		// Token: 0x06000210 RID: 528 RVA: 0x00008C83 File Offset: 0x00006E83
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayValueSource()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty, this);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008C90 File Offset: 0x00006E90
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayValueSource()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00008C9D File Offset: 0x00006E9D
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00008CAF File Offset: 0x00006EAF
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

		// Token: 0x06000214 RID: 532 RVA: 0x00008CC2 File Offset: 0x00006EC2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDropDownButtonDisplayMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty, this);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00008CCF File Offset: 0x00006ECF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDropDownButtonDisplayMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00008CDC File Offset: 0x00006EDC
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00008CEE File Offset: 0x00006EEE
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

		// Token: 0x06000218 RID: 536 RVA: 0x00008CFC File Offset: 0x00006EFC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDropDownButtonStyle()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty, this);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008D09 File Offset: 0x00006F09
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDropDownButtonStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00008D16 File Offset: 0x00006F16
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Visibility DropDownButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityProperty);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00008D28 File Offset: 0x00006F28
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00008D3A File Offset: 0x00006F3A
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

		// Token: 0x0600021D RID: 541 RVA: 0x00008D4D File Offset: 0x00006F4D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDropDownResizeMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty, this);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008D5A File Offset: 0x00006F5A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDropDownResizeMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00008D67 File Offset: 0x00006F67
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00008D79 File Offset: 0x00006F79
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06000221 RID: 545 RVA: 0x00008D8C File Offset: 0x00006F8C
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

		// Token: 0x06000222 RID: 546 RVA: 0x00008DD8 File Offset: 0x00006FD8
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00008E35 File Offset: 0x00007035
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00008E47 File Offset: 0x00007047
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

		// Token: 0x06000225 RID: 549 RVA: 0x00008E5A File Offset: 0x0000705A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsEditable()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty, this);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008E67 File Offset: 0x00007067
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsEditable()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00008E74 File Offset: 0x00007074
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00008E86 File Offset: 0x00007086
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

		// Token: 0x06000229 RID: 553 RVA: 0x00008E94 File Offset: 0x00007094
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

		// Token: 0x0600022A RID: 554 RVA: 0x00008F20 File Offset: 0x00007120
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

		// Token: 0x0600022B RID: 555 RVA: 0x00008F94 File Offset: 0x00007194
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

		// Token: 0x0600022C RID: 556 RVA: 0x00008FC5 File Offset: 0x000071C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsProvider()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty, this) && this._internalItemsProvider != this.ItemsProvider;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00008FE7 File Offset: 0x000071E7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsProvider()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsProviderProperty);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00008FF4 File Offset: 0x000071F4
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00009006 File Offset: 0x00007206
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000230 RID: 560 RVA: 0x00009014 File Offset: 0x00007214
		private static void OnItemsSourceChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.VerifyInternalItemsProvider(false, xamComboEditor.ItemsProvider);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00009038 File Offset: 0x00007238
		private void VerifyInternalItemsProvider(bool fromItemsProviderCoerced, global::Infragistics.Windows.Editors.ComboBoxItemsProvider currentItemsProvider)
		{
			global::System.Collections.IEnumerable itemsSource = this.ItemsSource;
			if ((!fromItemsProviderCoerced || currentItemsProvider == null) && this._internalItemsProvider != null && itemsSource != null && this._internalItemsProvider.ItemsSource == itemsSource)
			{
				return;
			}
			if (currentItemsProvider == null || currentItemsProvider == this._internalItemsProvider)
			{
				if (itemsSource != null)
				{
					this._internalItemsProvider = new global::Infragistics.Windows.Editors.ComboBoxItemsProvider
					{
						ValuePath = this.ValuePath,
						DisplayMemberPath = this.DisplayMemberPath,
						ItemsSource = itemsSource
					};
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

		// Token: 0x06000232 RID: 562 RVA: 0x000090DD File Offset: 0x000072DD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsSource()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty, this);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000090EA File Offset: 0x000072EA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsSource()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000090F7 File Offset: 0x000072F7
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00009109 File Offset: 0x00007309
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

		// Token: 0x06000236 RID: 566 RVA: 0x00009118 File Offset: 0x00007318
		private static void OnDisplayMemberPathChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			string displayMemberPath = (string)e.NewValue;
			if (xamComboEditor._internalItemsProvider != null)
			{
				xamComboEditor._internalItemsProvider.DisplayMemberPath = displayMemberPath;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000914D File Offset: 0x0000734D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayMemberPath()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty, this);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000915A File Offset: 0x0000735A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayMemberPath()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00009167 File Offset: 0x00007367
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00009179 File Offset: 0x00007379
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

		// Token: 0x0600023B RID: 571 RVA: 0x00009188 File Offset: 0x00007388
		private static void OnValuePathChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			string valuePath = (string)e.NewValue;
			if (xamComboEditor._internalItemsProvider != null)
			{
				xamComboEditor._internalItemsProvider.ValuePath = valuePath;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000091BD File Offset: 0x000073BD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValuePath()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty, this);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000091CA File Offset: 0x000073CA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValuePath()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000091D8 File Offset: 0x000073D8
		private static void OnLimitToListChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)d;
			xamComboEditor.ValidateCurrentValue();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000091F2 File Offset: 0x000073F2
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00009204 File Offset: 0x00007404
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00009217 File Offset: 0x00007417
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00009229 File Offset: 0x00007429
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

		// Token: 0x06000243 RID: 579 RVA: 0x0000923C File Offset: 0x0000743C
		private static bool ValidateMaxDropDownHeight(object objVal)
		{
			double num = (double)objVal;
			return num >= 0.0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000925F File Offset: 0x0000745F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxDropDownHeight()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty, this);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000926C File Offset: 0x0000746C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxDropDownHeight()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00009279 File Offset: 0x00007479
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000928B File Offset: 0x0000748B
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

		// Token: 0x06000248 RID: 584 RVA: 0x000092A0 File Offset: 0x000074A0
		private static bool ValidateMaxDropDownWidth(object objVal)
		{
			double num = (double)objVal;
			return num >= 0.0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000092C3 File Offset: 0x000074C3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxDropDownWidth()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty, this);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000092D0 File Offset: 0x000074D0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxDropDownWidth()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000092DD File Offset: 0x000074DD
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000092EF File Offset: 0x000074EF
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

		// Token: 0x0600024D RID: 589 RVA: 0x00009302 File Offset: 0x00007502
		private static bool ValidateMinDropDownWidth(object objVal)
		{
			double num = (double)objVal;
			return true;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000930C File Offset: 0x0000750C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinDropDownWidth()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty, this);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00009319 File Offset: 0x00007519
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinDropDownWidth()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00009326 File Offset: 0x00007526
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public double MinDropDownWidthResolved
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthResolvedProperty);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009338 File Offset: 0x00007538
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000093AB File Offset: 0x000075AB
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000093BD File Offset: 0x000075BD
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000093CB File Offset: 0x000075CB
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000093DD File Offset: 0x000075DD
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000093EB File Offset: 0x000075EB
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000093FD File Offset: 0x000075FD
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06000258 RID: 600 RVA: 0x00009410 File Offset: 0x00007610
		private static void OnSelectedIndexChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			int num = (int)e.NewValue;
			xamComboEditor.SyncValueProperties(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty, num);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009444 File Offset: 0x00007644
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000094B4 File Offset: 0x000076B4
		// (set) Token: 0x0600025B RID: 603 RVA: 0x000094C1 File Offset: 0x000076C1
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

		// Token: 0x0600025C RID: 604 RVA: 0x000094D0 File Offset: 0x000076D0
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

		// Token: 0x0600025D RID: 605 RVA: 0x00009528 File Offset: 0x00007728
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

		// Token: 0x0600025E RID: 606 RVA: 0x00009574 File Offset: 0x00007774
		protected virtual void OnSelectedItemChanged(object previousValue, object currentValue)
		{
			base.RaiseValuePropertyChangedEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<object>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.XamComboEditor.SelectedItemChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600025F RID: 607 RVA: 0x000095A2 File Offset: 0x000077A2
		// (remove) Token: 0x06000260 RID: 608 RVA: 0x000095B0 File Offset: 0x000077B0
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000095BE File Offset: 0x000077BE
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000095D9 File Offset: 0x000077D9
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000095EF File Offset: 0x000077EF
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00009610 File Offset: 0x00007810
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00009632 File Offset: 0x00007832
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00009653 File Offset: 0x00007853
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00009675 File Offset: 0x00007875
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.TextAlignment TextAlignmentResolved
		{
			get
			{
				return (global::System.Windows.TextAlignment)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.TextAlignmentResolvedProperty);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00009688 File Offset: 0x00007888
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

		// Token: 0x06000269 RID: 617 RVA: 0x000096D4 File Offset: 0x000078D4
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)dependencyObject;
			xamComboEditor.UpdateTextAlignmentResolved();
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000096F0 File Offset: 0x000078F0
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

		// Token: 0x0600026B RID: 619 RVA: 0x00009724 File Offset: 0x00007924
		private void ClearBypassNextComboTextChanged()
		{
			this._bypassNextComboTextChanged = false;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000972D File Offset: 0x0000792D
		private void InitializeCachedPropertyValues()
		{
			base.UpdateDropDownButtonVisibility();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00009738 File Offset: 0x00007938
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

		// Token: 0x0600026E RID: 622 RVA: 0x000097A0 File Offset: 0x000079A0
		private void InitializeComboBoxItemTemplateHelper()
		{
			global::System.Windows.Controls.ComboBox comboBox = this.ComboBox;
			if (!this._itemTemplateSetOnComboBox && comboBox != null && global::Infragistics.Windows.Editors.DisplayValueSource.Value == this.DisplayValueSource && comboBox.ItemTemplate == null)
			{
				comboBox.SetResourceReference(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty, global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueTemplateKey);
				this._itemTemplateSetOnComboBox = true;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000097E8 File Offset: 0x000079E8
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

		// Token: 0x06000270 RID: 624 RVA: 0x0000983C File Offset: 0x00007A3C
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

		// Token: 0x06000271 RID: 625 RVA: 0x00009900 File Offset: 0x00007B00
		private void OnComboBox_DropDownOpened(object sender, global::System.EventArgs e)
		{
			this.RaiseDropDownOpened(new global::System.Windows.RoutedEventArgs(global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent, this));
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00009913 File Offset: 0x00007B13
		private void OnComboBox_DropDownClosed(object sender, global::System.EventArgs e)
		{
			this.RaiseDropDownClosedIfPending();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000991C File Offset: 0x00007B1C
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
				}
				global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.ActualWidthProperty, global::System.Windows.Data.BindingMode.OneWay, comboBox);
				base.SetBinding(global::Infragistics.Windows.Editors.XamComboEditor.EditPortionWidthProperty, binding);
				this.InitializeComboBoxItemTemplateHelper();
			}
			this.InitializeComboBoxValue(true);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00009A9C File Offset: 0x00007C9C
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

		// Token: 0x06000275 RID: 629 RVA: 0x00009AF4 File Offset: 0x00007CF4
		private void OnTextBox_TextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			if (this._lastComboBoxTextBox != null && base.IsInEditMode && !base.IsReadOnly && (!this._bypassNextComboTextChanged || base.Text != this._lastComboBoxTextBox.Text))
			{
				this.OnValueChanged_SyncProperties(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.ComboBoxText, this._lastComboBoxTextBox.Text, false);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00009B4C File Offset: 0x00007D4C
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
			int selectedIndex = this.SelectedIndex;
			switch (source)
			{
			case global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Value:
				obj2 = value;
				if (itemsProvider != null)
				{
					num = itemsProvider.FindListItemFromDataValue(obj2, selectedIndex, out obj);
					if (num >= 0)
					{
						text = itemsProvider.GetDisplayText(obj, num);
					}
					else
					{
						text = itemsProvider.GetDisplayTextFromDataValue(value, selectedIndex);
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
				text = ((value != null) ? value.ToString() : string.Empty);
				num = ((itemsProvider == null) ? -1 : itemsProvider.FindListItemFromDisplayText(text, false, 0, selectedIndex, out obj));
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
				else
				{
					if (!this.LimitToList)
					{
						obj2 = (string.IsNullOrEmpty(text) ? null : value);
						value = obj2;
						return this.OnValueChanged_SyncPropertiesHelper(global::Infragistics.Windows.Editors.XamComboEditor.ValueChangeSource.Value, obj2);
					}
					flag2 = new bool?(false);
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

		// Token: 0x06000277 RID: 631 RVA: 0x00009EDC File Offset: 0x000080DC
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

		// Token: 0x06000278 RID: 632 RVA: 0x00009F54 File Offset: 0x00008154
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
			base.SetValue(prop, value);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00009FDA File Offset: 0x000081DA
		internal override void ToggleDropDown()
		{
			this.IsDropDownOpen = !this.IsDropDownOpen;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00009FEC File Offset: 0x000081EC
		private void RaiseAutomationExpandCollapseStateChanged(bool oldValue, bool newValue)
		{
			global::Infragistics.Windows.Automation.Peers.Editors.XamComboEditorAutomationPeer xamComboEditorAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.Editors.XamComboEditorAutomationPeer;
			if (xamComboEditorAutomationPeer != null)
			{
				xamComboEditorAutomationPeer.RaiseExpandCollapseStateChanged(oldValue, newValue);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000A010 File Offset: 0x00008210
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

		// Token: 0x0600027C RID: 636 RVA: 0x0000A084 File Offset: 0x00008284
		public void SelectAll()
		{
			this.SelectionStart = 0;
			this.SelectionLength = this.TextLength;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000A09C File Offset: 0x0000829C
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

		// Token: 0x0600027E RID: 638 RVA: 0x0000A0CC File Offset: 0x000082CC
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return global::Infragistics.Windows.Editors.ComboEditorCommands.NotACommand == routedCommand || (routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.Editors.ComboEditorCommands));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000A104 File Offset: 0x00008304
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(routedCommand, commandInfo.Parameter);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000A12C File Offset: 0x0000832C
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

		// Token: 0x0400007F RID: 127
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Controls.ComboBox _lastComboBox;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Controls.TextBox _lastComboBoxTextBox;

		// Token: 0x04000082 RID: 130
		private bool _inOnComboBoxSelectionChanged;

		// Token: 0x04000083 RID: 131
		private int _cachedSelectionStart;

		// Token: 0x04000084 RID: 132
		private int _cachedSelectionLength;

		// Token: 0x04000085 RID: 133
		private bool _isInitializingComboBox;

		// Token: 0x04000086 RID: 134
		private global::Infragistics.Windows.Editors.ComboBoxItemsProvider _internalItemsProvider;

		// Token: 0x04000087 RID: 135
		private bool _inOnValueChanged_SyncProperties;

		// Token: 0x04000088 RID: 136
		private bool _isClosePending;

		// Token: 0x04000089 RID: 137
		private bool _itemTemplateSetOnComboBox;

		// Token: 0x0400008A RID: 138
		private bool _selectedItemCoerced;

		// Token: 0x0400008B RID: 139
		private bool _selectedIndexCoerced;

		// Token: 0x0400008C RID: 140
		private static global::System.Windows.DependencyProperty s_IsTextSearchCaseSensitiveProperty;

		// Token: 0x0400008D RID: 141
		private bool _bypassNextComboTextChanged;

		// Token: 0x04000092 RID: 146
		private static readonly global::System.Windows.DependencyProperty EditPortionWidthProperty;

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty ComboBoxStyleProperty;

		// Token: 0x04000094 RID: 148
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static readonly global::System.Windows.DependencyProperty ComboEditorProperty;

		// Token: 0x04000095 RID: 149
		public static readonly global::System.Windows.ResourceKey ComboEditorComboBoxStyleKey;

		// Token: 0x04000096 RID: 150
		private static readonly global::System.Windows.DependencyPropertyKey DisplayValuePropertyKey;

		// Token: 0x04000097 RID: 151
		public static readonly global::System.Windows.DependencyProperty DisplayValueProperty;

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty DisplayValueSourceProperty;

		// Token: 0x04000099 RID: 153
		public static readonly global::System.Windows.ResourceKey DisplayValueTemplateKey;

		// Token: 0x0400009A RID: 154
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty;

		// Token: 0x0400009B RID: 155
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty;

		// Token: 0x0400009C RID: 156
		internal static readonly global::System.Windows.DependencyPropertyKey DropDownButtonVisibilityPropertyKey;

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty DropDownButtonVisibilityProperty;

		// Token: 0x0400009E RID: 158
		public static readonly global::System.Windows.DependencyProperty DropDownResizeModeProperty;

		// Token: 0x0400009F RID: 159
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty;

		// Token: 0x040000A0 RID: 160
		public static readonly global::System.Windows.DependencyProperty IsEditableProperty;

		// Token: 0x040000A1 RID: 161
		public static readonly global::System.Windows.DependencyProperty ItemsProviderProperty;

		// Token: 0x040000A2 RID: 162
		private global::Infragistics.Windows.Internal.PropertyValueTracker _itemsProviderVersionTracker;

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty;

		// Token: 0x040000A4 RID: 164
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty;

		// Token: 0x040000A5 RID: 165
		public static readonly global::System.Windows.DependencyProperty ValuePathProperty;

		// Token: 0x040000A6 RID: 166
		public static readonly global::System.Windows.DependencyProperty LimitToListProperty;

		// Token: 0x040000A7 RID: 167
		public static readonly global::System.Windows.DependencyProperty MaxDropDownHeightProperty;

		// Token: 0x040000A8 RID: 168
		public static readonly global::System.Windows.DependencyProperty MaxDropDownWidthProperty;

		// Token: 0x040000A9 RID: 169
		public static readonly global::System.Windows.DependencyProperty MinDropDownWidthProperty;

		// Token: 0x040000AA RID: 170
		private static readonly global::System.Windows.DependencyPropertyKey MinDropDownWidthResolvedPropertyKey;

		// Token: 0x040000AB RID: 171
		public static readonly global::System.Windows.DependencyProperty MinDropDownWidthResolvedProperty;

		// Token: 0x040000AC RID: 172
		public static readonly global::System.Windows.DependencyProperty PreDropDownAreaTemplateProperty;

		// Token: 0x040000AD RID: 173
		public static readonly global::System.Windows.DependencyProperty PostDropDownAreaTemplateProperty;

		// Token: 0x040000AE RID: 174
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty;

		// Token: 0x040000AF RID: 175
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty;

		// Token: 0x040000B1 RID: 177
		private static readonly global::System.Windows.DependencyPropertyKey TextAlignmentResolvedPropertyKey;

		// Token: 0x040000B2 RID: 178
		public static readonly global::System.Windows.DependencyProperty TextAlignmentResolvedProperty;

		// Token: 0x02000024 RID: 36
		internal class ComboBox_ItemsSourceWrapper : global::Infragistics.Windows.Editors.CollectionViewProxy, global::System.ComponentModel.ICollectionViewFactory
		{
			// Token: 0x060002B8 RID: 696 RVA: 0x0000A794 File Offset: 0x00008994
			internal ComboBox_ItemsSourceWrapper(global::Infragistics.Windows.Editors.XamComboEditor comboEditor, global::System.Windows.Data.CollectionView itemsSource) : base(itemsSource)
			{
				global::Infragistics.Windows.Editors.Utils.ValidateNull(comboEditor);
				this._comboEditor = comboEditor;
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000A7AC File Offset: 0x000089AC
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

			// Token: 0x060002BA RID: 698 RVA: 0x0000A7F8 File Offset: 0x000089F8
			global::System.ComponentModel.ICollectionView global::System.ComponentModel.ICollectionViewFactory.CreateView()
			{
				return this;
			}

			// Token: 0x040000BA RID: 186
			private global::Infragistics.Windows.Editors.XamComboEditor _comboEditor;
		}

		// Token: 0x02000025 RID: 37
		private enum ValueChangeSource
		{
			// Token: 0x040000BC RID: 188
			Value,
			// Token: 0x040000BD RID: 189
			Text,
			// Token: 0x040000BE RID: 190
			SelectedIndex,
			// Token: 0x040000BF RID: 191
			SelectedItem,
			// Token: 0x040000C0 RID: 192
			ComboBoxText,
			// Token: 0x040000C1 RID: 193
			ComboBoxSelectedIndex
		}
	}
}
