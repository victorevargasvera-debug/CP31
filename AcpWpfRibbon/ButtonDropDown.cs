using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000005 RID: 5
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_ButtonDropDownBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class ButtonDropDown : global::System.Windows.Controls.HeaderedItemsControl, global::System.Windows.Input.ICommandSource
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		static ButtonDropDown()
		{
			int a_ = 1;
			short num = (short)1999309049;
			short num2 = num;
			num = (short)1953368313;
			switch (num2 == num)
			{
			}
			num = (short)592576512;
			short num3 = num;
			num = (short)694484993;
			if (num != 0)
			{
			}
			num = (short)1315504128;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonDropDown._FixedSmallImageSize = new global::System.Windows.Size(16.0, 16.0);
			global::DevComponents.WpfRibbon.ButtonDropDown.ImageSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㙚㱜㡞Ѡぢ੤ቦ᭨ࡪ࡬", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnImageSourceChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.ImageSmallSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㙚㱜㡞Ѡぢࡤ٦ըݪ㹬nѰŲᙴቶ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnImageSmallSourceChanged)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.ButtonDropDown)));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonDropDown.ClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㝚㑜㱞੠", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
			global::DevComponents.WpfRibbon.ButtonDropDown.PreviewClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़⥚㡜⥞ࡠ٢ቤ⑦ըɪ๬Ѯ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
			global::DevComponents.WpfRibbon.ButtonDropDown.CheckedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㍚㡜㱞੠٢Ť", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
			global::DevComponents.WpfRibbon.ButtonDropDown.UncheckedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ౘ㕚㹜㝞Ѡb๤ɦ൨", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
			global::DevComponents.WpfRibbon.ButtonDropDown.PopupOpenedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㑚ⵜ⩞ᅠⱢᕤɦݨ๪६", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
			global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㑚ⵜ⩞ᅠ⁢।ࡦᩨ๪६", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), global::DevComponents.WpfRibbon.BasePopupControl.IsSelectedChangedEvent, new global::System.Windows.RoutedPropertyChangedEventHandler<bool>(global::DevComponents.WpfRibbon.ButtonDropDown.OnParentControlIsSelectedChanged));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), global::System.Windows.Input.AccessKeyManager.AccessKeyPressedEvent, new global::System.Windows.Input.AccessKeyPressedEventHandler(global::DevComponents.WpfRibbon.ButtonDropDown.OnAccessKeyPressed));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚൜ぞᅠᙢᕤ⡦ᥨ๪ͬ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnIsPopupOpenChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.ButtonDropDown.CoerceIsPopupOpen)));
			global::DevComponents.WpfRibbon.ButtonDropDown.RoleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୘㑚ㅜ㩞", a_), typeof(global::DevComponents.WpfRibbon.eButtonRole), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eButtonRole.SplitButton, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnRoleChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.PartVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㩚⽜⭞㝠੢ᙤ๦୨ɪŬٮհੲ", a_), typeof(global::DevComponents.WpfRibbon.eButtonPartVisibility), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageAndHeader, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsCheckableProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚Ṝ㝞Ѡb๤٦୨ݪ࡬", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsPressedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚൜ⵞѠၢᙤɦ൨", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsPressedProperty = global::DevComponents.WpfRibbon.ButtonDropDown.IsPressedPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ButtonDropDown.PopupPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㑚ⵜ⩞ᅠ㍢।٦੨๪l੮ὰݲ", a_), typeof(global::DevComponents.WpfRibbon.ePopupPlacement), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.ePopupPlacement.Right, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnPopupPlacementChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.PopupPlacementTargetProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㑚ⵜ⩞ᅠ㍢।٦੨๪l੮ὰݲⅴᙶ୸ᱺ᡼୾", a_), typeof(global::System.Windows.UIElement), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚ᕜ㙞٠ୢ।๦๨ͪᥬ੮ᕰ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnIsHighlightedChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedProperty = global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ButtonDropDown.IsCheckedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚Ṝ㝞Ѡb๤ɦ൨", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnIsCheckedChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.StaysOpenOnClickProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("੘⽚㱜♞በⱢᕤɦݨ⑪ͬⱮᵰᩲᙴᱶ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonDropDown.ImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㙚㱜㡞Ѡ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnImageChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.ImageSmallProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㙚㱜㡞Ѡぢࡤ٦ըݪ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnImageChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.UseSmallImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ౘ⡚㡜౞ౠɢ।୦⁨٪౬࡮ᑰ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnUseSmallImageChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.RenderImagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୘㹚㍜㭞ѠᅢⱤ੦ࡨ౪࡬", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonDropDown.RenderImageProperty = global::DevComponents.WpfRibbon.ButtonDropDown.RenderImagePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ButtonDropDown.CornerRadiusProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚⽜ㅞѠᅢ㝤٦൨ɪᡬᱮ", a_), typeof(global::System.Windows.CornerRadius), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(2.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.ButtonDropDown.ImagePositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㙚㱜㡞Ѡ㍢੤ᑦhὪѬnὰ", a_), typeof(global::DevComponents.WpfRibbon.eButtonImagePosition), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eButtonImagePosition.Left, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::DevComponents.WpfRibbon.ButtonDropDown.ExpandPositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᱘⍚ⵜ㹞འݢ㕤ࡦᩨɪᥬٮṰᵲ", a_), typeof(global::DevComponents.WpfRibbon.eExpandPosition), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eExpandPosition.Right, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnExpandPositionChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnIsSelectedChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupAnimationSuspendedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚൜ぞᅠᙢᕤ♦ݨɪl๮հᩲᩴ᥶⩸๺๼ཾ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonDropDown.ContentExpandsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚㍜⭞Ѡൢᅤ≦ᅨ᭪౬Ůᕰr", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚ᡜ❞ᅠɢ୤ͦ㽨ɪṬٮ፰ὲၴ", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisibleProperty = global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ButtonDropDown.ExpandVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᱘⍚ⵜ㹞འݢ㍤๦ᩨɪཬٮᵰᩲŴ๶", a_), typeof(global::DevComponents.WpfRibbon.eExpandVisibility), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eExpandVisibility.Auto, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnExpandVisibilityChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.CommandProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚ぜ㉞`ൢŤ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnCommandChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.CommandParameterProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚ぜ㉞`ൢŤ㝦ࡨᥪ౬ɮᑰݲၴն", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonDropDown.CommandTargetProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚ぜ㉞`ൢŤ㍦ࡨᥪ੬੮հ", a_), typeof(global::System.Windows.IInputElement), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ButtonDropDown.PopupTypeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़㑚ⵜ⩞ᅠ㝢ᱤᝦ౨", a_), typeof(global::DevComponents.WpfRibbon.eDropDownType), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eDropDownType.Popup, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnPopupTypeChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.InputGestureTextProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㕚ⵜ⩞ᕠ③dᑦᵨṪὬ੮╰ᙲ൴Ͷ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnInputGestureTextChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.ButtonDropDown.CoerceInputGestureText)));
			global::DevComponents.WpfRibbon.ButtonDropDown.ColorClassProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩘ㑚ㅜぞ፠⁢।٦ᩨᡪ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.RibbonColors.ButtonClass, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.ButtonDropDown.OptionGroupProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᙘ⭚⥜㙞๠ൢ≤ᕦ٨Ṫᵬ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(""));
			global::DevComponents.WpfRibbon.ButtonDropDown.WrapLabelProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๘⥚㱜⽞ⵠɢݤɦը", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.ButtonDropDown.InlineExpandProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ㕚ㅜ㙞འ٢⁤ὦᥨ੪ͬ୮", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonDropDown.OnInlineExpandChanged)));
			global::DevComponents.WpfRibbon.ButtonDropDown.FocusChangeKeepsPopupOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("὘㑚㹜⩞በ⁢൤٦ݨ౪࡬⑮ᑰᙲմѶ⥸ᑺർ੾첂", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsSimpleHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚๜㙞ౠ።।ɦⅨ๪౬୮ᑰŲ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsSimpleHeaderProperty = global::DevComponents.WpfRibbon.ButtonDropDown.IsSimpleHeaderPropertyKey.DependencyProperty;
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Controls.ToolTipService.IsEnabledProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.ButtonDropDown.CoerceToolTipIsEnabled)));
			global::DevComponents.WpfRibbon.ButtonDropDown.IsNestedMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၘ⡚፜㩞በᝢdͦ⑨๪ͬᩮ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonDropDown), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000FF84 File Offset: 0x0000E184
		public ButtonDropDown()
		{
			base.IsEnabledChanged += this.OnIsEnabledChanged;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000086 RID: 134 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		// (remove) Token: 0x06000087 RID: 135 RVA: 0x000100A4 File Offset: 0x0000E2A4
		[global::System.ComponentModel.Category("Behavior")]
		public event global::System.Windows.RoutedEventHandler Click
		{
			add
			{
				short num = (short)2129649684;
				short num2 = num;
				num = (short)1844961300;
				switch (num2 == num)
				{
				}
				num = (short)1066008576;
				short num3 = num;
				num = (short)4849665;
				if (num != 0)
				{
				}
				num = (short)1182793728;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.ButtonDropDown.ClickEvent, value);
			}
			remove
			{
				short num = (short)1849571129;
				short num2 = num;
				num = (short)518862649;
				switch (num2 == num)
				{
				}
				num = (short)249364480;
				short num3 = num;
				num = (short)899153921;
				if (num != 0)
				{
				}
				num = (short)979304448;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.ButtonDropDown.ClickEvent, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000088 RID: 136 RVA: 0x00010158 File Offset: 0x0000E358
		// (remove) Token: 0x06000089 RID: 137 RVA: 0x0001020C File Offset: 0x0000E40C
		[global::System.ComponentModel.Category("Behavior")]
		public event global::System.Windows.RoutedEventHandler PopupOpened
		{
			add
			{
				short num = (short)1392119888;
				short num2 = num;
				num = (short)1385107536;
				switch (num2 == num)
				{
				}
				num = (short)1204420608;
				short num3 = num;
				num = (short)1222311937;
				if (num != 0)
				{
				}
				num = (short)1334575104;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.ButtonDropDown.PopupOpenedEvent, value);
			}
			remove
			{
				short num = (short)1556034825;
				short num2 = num;
				num = (short)592327945;
				switch (num2 == num)
				{
				}
				num = (short)33488896;
				short num3 = num;
				num = (short)1118175232;
				if (num != 0)
				{
				}
				num = (short)401014785;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.ButtonDropDown.PopupOpenedEvent, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600008A RID: 138 RVA: 0x000102C0 File Offset: 0x0000E4C0
		// (remove) Token: 0x0600008B RID: 139 RVA: 0x00010378 File Offset: 0x0000E578
		[global::System.ComponentModel.Category("Behavior")]
		public event global::System.Windows.RoutedEventHandler PopupClosed
		{
			add
			{
				short num = (short)1746665473;
				if (num != 0)
				{
				}
				num = (short)921484624;
				short num2 = num;
				num = (short)931249488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)198508544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)900464640;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent, value);
			}
			remove
			{
				short num = (short)2026334948;
				short num2 = num;
				num = (short)756902628;
				switch (num2 == num)
				{
				}
				num = (short)1797980160;
				short num3 = num;
				num = (short)1754529793;
				if (num != 0)
				{
				}
				num = (short)1378746368;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600008C RID: 140 RVA: 0x00010430 File Offset: 0x0000E630
		// (remove) Token: 0x0600008D RID: 141 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[global::System.ComponentModel.Category("Behavior")]
		public event global::System.Windows.RoutedEventHandler Checked
		{
			add
			{
				short num = (short)1438384129;
				if (num != 0)
				{
				}
				num = (short)646253238;
				short num2 = num;
				num = (short)1740114614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1757413376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419233792;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.ButtonDropDown.CheckedEvent, value);
			}
			remove
			{
				short num = (short)1137235674;
				short num2 = num;
				num = (short)1382209242;
				switch (num2 == num)
				{
				}
				num = (short)660144128;
				short num3 = num;
				num = (short)1550385153;
				if (num != 0)
				{
				}
				num = (short)770768896;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.ButtonDropDown.CheckedEvent, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600008E RID: 142 RVA: 0x0001059C File Offset: 0x0000E79C
		// (remove) Token: 0x0600008F RID: 143 RVA: 0x00010654 File Offset: 0x0000E854
		[global::System.ComponentModel.Category("Behavior")]
		public event global::System.Windows.RoutedEventHandler Unchecked
		{
			add
			{
				short num = (short)684016599;
				short num2 = num;
				num = (short)2088453079;
				switch (num2 == num)
				{
				}
				num = (short)622395392;
				short num3 = num;
				num = (short)1256062977;
				if (num != 0)
				{
				}
				num = (short)830603264;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.ButtonDropDown.UncheckedEvent, value);
			}
			remove
			{
				short num = (short)1655438832;
				short num2 = num;
				num = (short)132447728;
				switch (num2 == num)
				{
				}
				num = (short)1411186688;
				short num3 = num;
				num = (short)53542913;
				if (num != 0)
				{
				}
				num = (short)1089404928;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.ButtonDropDown.UncheckedEvent, value);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00010704 File Offset: 0x0000E904
		private static void OnImageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1836646400;
						short num3 = num2;
						buttonDropDown.OnImageChanged(e.OldValue, e.NewValue);
						num2 = (short)1755047505;
						short num4 = num2;
						num2 = (short)332457553;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23;
						default:
							num2 = (short)1159004160;
							if (num2 != 0)
							{
							}
							num2 = (short)2055405570;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (d != null)
						{
							num2 = (short)1276706816;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						goto IL_F1;
					}
					goto IL_1C;
				}
				IL_F1:
				num2 = (short)1957691393;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_1C:
			buttonDropDown = (d as global::DevComponents.WpfRibbon.ButtonDropDown);
			IL_23:
			num2 = (short)644874241;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001082C File Offset: 0x0000EA2C
		private void OnImageChanged(object oldValue, object newValue)
		{
			short num = (short)345636866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FB;
				case 1:
					goto IL_82;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					num = (short)1897857028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.ImageFixedSize))
					{
						num = (short)1489895425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
				}
				IL_39:
				num = (short)1691680769;
				if (num != 0)
				{
				}
				if (oldValue is global::System.Windows.Controls.Image)
				{
					num = (short)1001586691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_FB;
				IL_82:
				global::System.Windows.Controls.Image image = oldValue as global::System.Windows.Controls.Image;
				image.MaxHeight = double.PositiveInfinity;
				image.MaxWidth = double.PositiveInfinity;
				num = (short)2134310912;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FB:
				num = (short)1088709738;
				short num3 = num;
				num = (short)1784505450;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_82;
				default:
					goto IL_131;
				}
			}
			IL_131:
			num = (short)605945856;
			if (num != 0)
			{
			}
			num = (short)987430912;
			short num4 = num;
			this.OnImageChanged();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000109B0 File Offset: 0x0000EBB0
		private void OnImageChanged()
		{
			short num = (short)2071986181;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_167;
				case 1:
					num = (short)1989017607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1CC;
				case 3:
					this.ImageFixedSize = global::DevComponents.WpfRibbon.ButtonDropDown._FixedSmallImageSize;
					num = (short)130154496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.ImageFixedSize))
					{
						num = (short)2097741830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					this.ImageFixedSize = default(global::System.Windows.Size);
					num = (short)1762263042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (this.ImageSmall == null)
					{
						goto IL_189;
					}
					goto IL_1CE;
				}
				IL_44:
				num = (short)710830693;
				short num3 = num;
				num = (short)144665189;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_189:
					num = (short)1049690115;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1578958848;
					short num4 = num;
					num = (short)1078919168;
					if (num != 0)
					{
					}
					if (this.UseSmallImage)
					{
						num = (short)354877441;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)189857793;
						if (num != 0)
						{
						}
						num = (short)852164612;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_167:
			IL_1CC:
			IL_1CE:
			this.UpdateRenderImage();
			this.UpdateImageEnabledState();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00010B98 File Offset: 0x0000ED98
		private void UpdateRenderImage()
		{
			short num = (short)1297154057;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					goto IL_1E1;
				case 1:
					if (this.ImageSmall == null)
					{
						num = (short)548667392;
						short num3 = num;
						num = (short)773062658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 2:
					num = (short)115867656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1524957194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1DC;
				case 5:
					goto IL_96;
				case 6:
					goto IL_24B;
				case 7:
					if (!string.IsNullOrEmpty(this.ImageSource))
					{
						num = (short)545390596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				case 8:
					if (!string.IsNullOrEmpty(this.ImageSmallSource))
					{
						num = (short)1806368768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19C;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 10:
					while (this.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num = (short)1489984707;
						short num4 = num;
						num = (short)682843331;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)974061568;
							if (num != 0)
							{
							}
							num = (short)870514693;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					goto IL_19C;
				case 11:
					if (!string.IsNullOrEmpty(this.ImageSmallSource))
					{
						num = (short)327221249;
						if (num != 0)
						{
						}
						num = (short)295370758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76;
				}
				IL_54:
				if (!this.UseSmallImage)
				{
					num = (short)229703683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_96:
				num = (short)584187905;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19C:
				num = (short)1993015303;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				num = (short)811532299;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_76:
			this.RenderImage = this.ImageSmall;
			return;
			IL_1DC:
			this.RenderImage = this.CreateImageFromImageSource(this.ImageSource);
			return;
			IL_24B:
			this.RenderImage = this.CreateImageFromImageSource(this.ImageSmallSource);
			return;
			IL_293:
			this.RenderImage = this.Image;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00010E44 File Offset: 0x0000F044
		protected virtual global::System.Windows.Controls.Image CreateImageFromImageSource(string imageSource)
		{
			short num = (short)1469253596;
			short num2 = num;
			num = (short)357566428;
			switch (num2 == num)
			{
			}
			num = (short)194510848;
			short num3 = num;
			num = (short)1751580673;
			if (num != 0)
			{
			}
			num = (short)563019776;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.Image
			{
				Source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(imageSource, global::System.UriKind.RelativeOrAbsolute)),
				Stretch = global::System.Windows.Media.Stretch.None
			};
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00010F08 File Offset: 0x0000F108
		private static void OnUseSmallImageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1169358849;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					buttonDropDown.OnImageChanged();
					num2 = (short)2098921474;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)1245446144;
					short num3 = num2;
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					if (buttonDropDown != null)
					{
						num2 = (short)688062464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)547589838;
			short num4 = num2;
			num2 = (short)942706382;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)2135621632;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = d as global::DevComponents.WpfRibbon.ButtonDropDown;
				break;
			}
			}
			num2 = (short)79691777;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00011024 File Offset: 0x0000F224
		private void UpdateImageEnabledState()
		{
			short num = (short)195362828;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					frameworkElement.Opacity = 1.0;
					num = (short)1059979265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_CE;
				case 2:
					num = (short)175833102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)667680773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (frameworkElement != null)
					{
						num = (short)1931018242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (frameworkElement.Opacity != 1.0)
					{
						num = (short)853803014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_C9;
				case 7:
					frameworkElement = (this.Image as global::System.Windows.FrameworkElement);
					num = (short)1170341896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1063379073;
					short num3 = num;
					num = (short)428793985;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_166;
					default:
						num = (short)2127888384;
						if (num != 0)
						{
						}
						if (base.IsEnabled)
						{
							num = (short)2045247498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						frameworkElement.Opacity = 0.3;
						num = (short)2092892171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					return;
				case 10:
					num = (short)1572339725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_CE;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 13:
					if (frameworkElement.Opacity != 1.0)
					{
						goto IL_166;
					}
					goto IL_CE;
				case 14:
				{
					num = (short)1141571584;
					short num4 = num;
					if (base.IsEnabled)
					{
						num = (short)553844739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkElement.Opacity = 0.3;
					num = (short)269680649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_61:
				if (this.Image is global::System.Windows.FrameworkElement)
				{
					num = (short)1746206727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_CE:
				frameworkElement = (this.ImageSmall as global::System.Windows.FrameworkElement);
				num = (short)1146552321;
				if (num != 0)
				{
				}
				num = (short)381943812;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_166:
				num = (short)926547968;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C9:
			frameworkElement.Opacity = 1.0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00011344 File Offset: 0x0000F544
		private void OnIsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1778122753;
			if (num != 0)
			{
			}
			num = (short)1328170392;
			short num2 = num;
			num = (short)895501720;
			switch (num2 == num)
			{
			default:
			{
				num = (short)439287808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)688521216;
			if (num != 0)
			{
			}
			this.UpdateEnabledState();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000113F4 File Offset: 0x0000F5F4
		private void UpdateEnabledState()
		{
			short num = (short)1884241824;
			short num2 = num;
			num = (short)1163214752;
			switch (num2 == num)
			{
			}
			num = (short)1122762752;
			short num3 = num;
			num = (short)133496833;
			if (num != 0)
			{
			}
			num = (short)103874560;
			if (num != 0)
			{
			}
			this.UpdateImageEnabledState();
			this.UpdateBorderRenderState();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public override void OnApplyTemplate()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.m_ImageFixedSize))
					{
						num2 = (short)780599297;
						if (num2 != 0)
						{
						}
						num2 = (short)31653888;
						short num3 = num2;
						num2 = (short)1364459521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39F;
				case 1:
					this.ImageFixedSize = this.m_ImageFixedSize;
					num2 = (short)130744323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					for (;;)
					{
						this.m_Popup.Closed -= this.InternalPopupClosed;
						this.m_Popup.Opened -= this.Popup_Opened;
						num2 = (short)923504128;
						short num4 = num2;
						num2 = (short)1945406976;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1D5;
						}
					}
					IL_1D5:
					num2 = (short)299237376;
					if (num2 != 0)
					{
					}
					num2 = (short)1408630790;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_228;
				case 4:
					num2 = (short)1665466368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					this.m_Popup.Closed += this.InternalPopupClosed;
					this.m_Popup.Opened += this.Popup_Opened;
					this.m_Popup.PlacementTarget = this;
					num2 = (short)542310409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_22D;
				case 7:
					if (this.m_ButtonImage != null)
					{
						num2 = (short)2119565316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39F;
				case 8:
					if (this.m_Popup != null)
					{
						num2 = (short)2088435714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22D;
				case 9:
					goto IL_363;
				case 10:
					if (this.m_Popup != null)
					{
						num2 = (short)858980357;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_363;
				}
				goto IL_45;
				IL_22D:
				this.m_Popup = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠㍢੤ᝦᱨ᭪", a_)) as global::System.Windows.Controls.Primitives.Popup);
				this.m_ButtonBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠Ⅲၤ፦ᵨѪͬ⭮Ͱᱲմ㍶ᙸ౺፼㵾ﮈ", a_)) as global::DevComponents.WpfRibbon.ButtonBorder);
				this.m_ButtonContent = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠Ⅲၤ፦ᵨѪͬⱮṰᵲŴቶ᝸ེ", a_)) as global::System.Windows.FrameworkElement);
				this.m_ButtonImage = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠Ⅲၤ፦ᵨѪͬ♮ᱰቲቴቶ", a_)) as global::System.Windows.FrameworkElement);
				this.m_ButtonExpand = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠Ⅲၤ፦ᵨѪͬ⩮॰Ͳᑴ᥶ᵸ", a_)) as global::System.Windows.FrameworkElement);
				this.m_ButtonExpandInline = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠Ⅲၤ፦ᵨѪͬ⩮॰Ͳᑴ᥶ᵸ㉺፼፾", a_)) as global::System.Windows.FrameworkElement);
				this.m_PopupContentControl = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠㍢੤ᝦᱨ᭪⹬nὰݲၴ᥶൸", a_)) as global::System.Windows.Controls.Control);
				this.m_AccessText = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅘ㹚㱜㭞Ѡᅢ⑤Ѧ੨๪Ṭᱮ╰ᙲ൴Ͷ", a_)) as global::System.Windows.Controls.AccessText);
				num2 = (short)1913913354;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_363:
				num2 = (short)664993799;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_228:
			IL_39F:
			this.UpdatePopupTypeTemplate();
			this.UpdateBorderBehavior();
			this.UpdateHeaderContentVisibility();
			this.UpdateBorderRenderState();
			this.UpdateExpandVisibility();
			return;
			IL_45:
			base.OnApplyTemplate();
			num2 = (short)147587080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00011874 File Offset: 0x0000FA74
		private void Popup_Opened(object sender, global::System.EventArgs e)
		{
			short num = (short)877975084;
			short num2 = num;
			num = (short)606590508;
			switch (num2 == num)
			{
			}
			num = (short)1562443776;
			short num3 = num;
			num = (short)708444161;
			if (num != 0)
			{
			}
			num = (short)1658388480;
			if (num != 0)
			{
			}
			this.UpdateKeyTipsState();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00011924 File Offset: 0x0000FB24
		protected override void OnHeaderChanged(object oldHeader, object newHeader)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_142;
				case 1:
					num2 = (short)1981087751;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1C9;
				case 3:
					this.IsSimpleHeader = true;
					num2 = (short)1433600000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.IsSimpleHeader)
					{
						num2 = (short)1032912897;
						if (num2 != 0)
						{
						}
						num2 = (short)1452474374;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CB;
				case 5:
				{
					num2 = (short)1835831420;
					short num3 = num2;
					num2 = (short)52727932;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)623902720;
						if (num2 != 0)
						{
						}
						if (newHeader is string)
						{
							num2 = (short)929955841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)442761220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					this.IsSimpleHeader = false;
					num2 = (short)491388930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)406519808;
					short num4 = num2;
					if (!this.IsSimpleHeader)
					{
						num2 = (short)1343750147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CB;
				}
				}
				goto IL_30;
			}
			IL_142:
			IL_1C9:
			IL_1CB:
			this.UpdateHeaderContentVisibility();
			return;
			IL_30:
			base.OnHeaderChanged(oldHeader, newHeader);
			num2 = (short)52494341;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00011B04 File Offset: 0x0000FD04
		private void UpdateHeaderContentVisibility()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::System.Windows.Visibility visibility;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1420558336;
					short num3 = num2;
					num2 = (short)846462985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (this.m_ButtonContent.Visibility != visibility)
					{
						num2 = (short)521469960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (this.m_ButtonContent != null)
					{
						num2 = (short)1570570245;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_B3;
				case 4:
					num2 = (short)110755841;
					if (num2 != 0)
					{
					}
					visibility = global::System.Windows.Visibility.Visible;
					num2 = (short)1493499907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)351862785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				case 7:
					if (base.Header != null)
					{
						num2 = (short)1964834816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B3;
				case 8:
				{
					num2 = (short)1631775766;
					short num4 = num2;
					num2 = (short)764668950;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)2026110976;
						if (num2 != 0)
						{
						}
						this.m_ButtonContent.Visibility = visibility;
						num2 = (short)1066336262;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					if (this.PartVisibility != global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageOnly)
					{
						num2 = (short)256376836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B3;
				}
				goto IL_38;
				IL_B3:
				num2 = (short)127795202;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			visibility = global::System.Windows.Visibility.Collapsed;
			num2 = (short)845545479;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00011D20 File Offset: 0x0000FF20
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1603272704;
			switch (num)
			{
			default:
			{
				num = (short)417923117;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.TextBlock textBlock;
					global::System.Windows.Media.FormattedText formattedText;
					double num4;
					int num6;
					double num8;
					global::System.Windows.Size desiredSize;
					switch (num2)
					{
					case 0:
						goto IL_6EC;
					case 1:
						num = (short)1880752136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.m_ButtonContent.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)783941660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E4;
					case 3:
						num = (short)761462819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_294;
					case 5:
						goto IL_857;
					case 6:
					{
						textBlock = (this.m_ButtonContent as global::System.Windows.Controls.TextBlock);
						formattedText = new global::System.Windows.Media.FormattedText((string)base.Header, global::System.Globalization.CultureInfo.CurrentCulture, textBlock.FlowDirection, new global::System.Windows.Media.Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch), textBlock.FontSize, textBlock.Foreground);
						formattedText.BuildGeometry(new global::System.Windows.Point(0.0, 0.0));
						double num3 = global::System.Math.Ceiling(formattedText.Height) * 2.0 + 2.0;
						num4 = global::System.Math.Ceiling(formattedText.MinWidth);
						double num5 = global::System.Math.Max(2.0, global::System.Math.Ceiling(formattedText.Width * 0.1));
						num6 = 0;
						num = (short)1402077201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Windows.Controls.Image image = (global::System.Windows.Controls.Image)this.Image;
						num = (short)1233059863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (this.IsSimpleHeader)
						{
							num = (short)763166720;
							short num7 = num;
							num = (short)1733951508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97E;
					case 9:
						goto IL_30B;
					case 10:
					{
						double num3;
						if (formattedText.Height > num3)
						{
							num = (short)1157103660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EC;
					}
					case 11:
						if (this.Image is global::System.Windows.Controls.Image)
						{
							num = (short)1100677127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_294;
					case 12:
					{
						double num3;
						if (formattedText.Height > num3)
						{
							num = (short)202047519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F8;
					}
					case 13:
						num = (short)689176614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::System.Windows.Controls.Image image;
						num8 = image.ActualWidth;
						num = (short)2137718788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (this.m_ButtonExpandInline != null)
						{
							num = (short)1372979232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_202;
					case 16:
						desiredSize = this.m_ButtonExpandInline.DesiredSize;
						num = (short)166985764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_5CA;
					case 18:
						if (num4 % 2.0 != 0.0)
						{
							num = (short)1395392546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB;
					case 19:
						goto IL_202;
					case 20:
					{
						string text = (string)base.Header;
						num = (short)441057307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (this.m_ImageFixedSize.Width > 0.0)
						{
							num = (short)889847813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)293666827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (!double.IsNaN(this.m_ButtonContent.Width))
						{
							num = (short)1613365273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97E;
					case 23:
					{
						global::System.Windows.Controls.Image image;
						if (image.IsArrangeValid)
						{
							num = (short)86179854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8 = 32.0;
						num = (short)1263796267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (num6 >= 11)
						{
							num = (short)1050148864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CA;
					case 25:
						num = (short)333774849;
						if (num != 0)
						{
						}
						this.m_ButtonContent.Width = double.NaN;
						num = (short)1695154222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)994836482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (this.WrapLabel)
						{
							num = (short)113311770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E4;
					case 28:
						num = (short)1370226721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_1C6;
					case 30:
						goto IL_615;
					case 31:
					{
						double num5;
						num4 += num5;
						num = (short)1724842025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						num = (short)2114388010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (this.ImagePosition != global::DevComponents.WpfRibbon.eButtonImagePosition.Top)
						{
							num = (short)961019907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 34:
						num4 += 1.0;
						num = (short)97189927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (this.ImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Bottom)
						{
							num = (short)1661927453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E4;
					case 36:
						if (desiredSize.Width == 0.0)
						{
							num = (short)1324744751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_615;
					case 37:
						goto IL_294;
					case 38:
					{
						string text;
						if (text.IndexOf(' ') > 0)
						{
							num = (short)2019360774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E4;
					}
					case 39:
						goto IL_2EB;
					case 40:
					{
						string text;
						if (text != null)
						{
							num = (short)2059141133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E4;
					}
					case 41:
						goto IL_3F8;
					case 42:
						if (this.m_ButtonExpandInline.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1371471888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_202;
					case 43:
						goto IL_294;
					case 44:
						num = (short)298319896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						switch (0)
						{
						case 0:
							goto IL_103;
						}
						continue;
					case 46:
						goto IL_3F3;
					case 47:
					{
						this.m_ButtonExpandInline.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
						num = (short)1734342045;
						short num9 = num;
						num = (short)902690205;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_857;
						default:
							num = (short)1571946496;
							if (num != 0)
							{
							}
							num = (short)782303262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_103:
					if (this.m_ButtonContent is global::System.Windows.Controls.TextBlock)
					{
						num = (short)1304494081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1C6:
					num = (short)613220392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_202:
					num = (short)141950994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_294:
					num4 = global::System.Math.Max(num4, num8 + 6.0);
					num = (short)2129264655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EB:
					textBlock.Width = num4;
					num = (short)425394185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F8:
					num6++;
					num = (short)1858011146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CA:
					formattedText.MaxTextWidth = num4;
					num = (short)1160249356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_615:
					double num10 = num4;
					desiredSize = this.m_ButtonExpandInline.DesiredSize;
					num4 = num10 + (desiredSize.Width + 2.0);
					num = (short)1153237011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EC:
					num4 = global::System.Math.Ceiling(formattedText.Width);
					num8 = 0.0;
					num = (short)1347092501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E4:
					num = (short)92274710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_857:
					num8 = this.m_ImageFixedSize.Width;
					num = (short)1990000677;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_30B:
				IL_3F3:
				IL_97E:
				return base.MeasureOverride(constraint);
			}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000126B4 File Offset: 0x000108B4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)912932531;
			short num2 = num;
			num = (short)2041855667;
			switch (num2 == num)
			{
			}
			num = (short)699203584;
			short num3 = num;
			num = (short)1968242689;
			if (num != 0)
			{
			}
			num = (short)1595736064;
			if (num != 0)
			{
			}
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			this.m_CommandBounds = global::System.Windows.Rect.Empty;
			this.m_ExpandBounds = global::System.Windows.Rect.Empty;
			global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
			if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton && this.m_ButtonExpand != null && (this.m_ButtonContent != null || this.m_ButtonImage != null) && (this.HasVisibleItems || this.ExpandVisibility == global::DevComponents.WpfRibbon.eExpandVisibility.Visible))
			{
				global::System.Windows.Rect rect2 = global::System.Windows.Rect.Empty;
				global::System.Windows.FrameworkElement frameworkElement;
				if (this.m_ButtonImage != null)
				{
					rect = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.m_ButtonImage);
					frameworkElement = (this.m_ButtonImage.Parent as global::System.Windows.FrameworkElement);
					if (frameworkElement != null && !global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Width) && !global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Height))
					{
						rect.Location = frameworkElement.TranslatePoint(rect.Location, this.m_ButtonBorder);
						rect2 = rect;
					}
				}
				global::System.Windows.Rect rect3 = global::System.Windows.Rect.Empty;
				if (this.m_ButtonContent != null)
				{
					rect = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.m_ButtonContent);
					frameworkElement = (this.m_ButtonContent.Parent as global::System.Windows.FrameworkElement);
					if (frameworkElement != null && !global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Width) && !global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Height))
					{
						rect.Location = frameworkElement.TranslatePoint(rect.Location, this.m_ButtonBorder);
						rect3 = rect;
					}
				}
				global::System.Windows.Rect rect4 = global::System.Windows.Rect.Empty;
				rect = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this.m_ButtonExpand);
				frameworkElement = (this.m_ButtonExpand.Parent as global::System.Windows.FrameworkElement);
				if (frameworkElement != null)
				{
					rect.Location = frameworkElement.TranslatePoint(rect.Location, this.m_ButtonBorder);
					rect4 = rect;
				}
				global::System.Windows.Rect innerContent = rect2;
				innerContent.Union(rect3);
				innerContent.Union(rect4);
				global::System.Windows.Size renderSize = this.m_ButtonBorder.RenderSize;
				if (this.ContentExpands && !rect2.IsEmpty && !rect3.IsEmpty)
				{
					global::System.Windows.Rect r = rect3;
					if (this.ImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Top)
					{
						r.Y += 2.0;
						r.Height -= 2.0;
					}
					r.Union(rect4);
					this.m_ExpandBounds = this.GetFullRectangle(r, innerContent, renderSize);
					this.m_CommandBounds = this.GetFullRectangle(rect2, innerContent, renderSize);
				}
				else
				{
					global::System.Windows.Rect r2 = rect2;
					r2.Union(rect3);
					this.m_ExpandBounds = this.GetFullRectangle(rect4, innerContent, renderSize);
					this.m_CommandBounds = this.GetFullRectangle(r2, innerContent, renderSize);
				}
				if (this.m_CommandBounds.Height > 0.0)
				{
					this.m_CommandBounds.Height = this.m_CommandBounds.Height + 3.0;
				}
				this.m_ButtonBorder.ExpandBounds = this.m_ExpandBounds;
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00012A1C File Offset: 0x00010C1C
		private global::System.Windows.Rect GetFullRectangle(global::System.Windows.Rect r, global::System.Windows.Rect innerContent, global::System.Windows.Size totalSize)
		{
			short num = (short)716308493;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_23B;
				case 1:
					num = (short)787283972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(innerContent.Bottom, r.Bottom))
					{
						num = (short)1304231937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23B;
				case 3:
					goto IL_17A;
				case 4:
					r.Height += totalSize.Height - innerContent.Height - (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(innerContent.Y, r.Y) ? 0.0 : innerContent.Y);
					num = (short)1844641792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(innerContent.Y, r.Y))
					{
						num = (short)953679878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return r;
				case 6:
					r.Y -= innerContent.Y;
					num = (short)1571356681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)860028928;
					short num3 = num;
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(innerContent.X, r.X))
					{
						goto IL_291;
					}
					goto IL_2EE;
				}
				case 8:
					r.X -= innerContent.X;
					r.Width += innerContent.X;
					num = (short)352649226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return r;
				case 10:
					goto IL_2EE;
				case 11:
					r.Width += totalSize.Width - innerContent.Width - (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(innerContent.X, r.X) ? 0.0 : innerContent.X);
					num = (short)1407385603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1866858507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				num = (short)445531293;
				short num4 = num;
				num = (short)1528054941;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_291:
					num = (short)385744904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)518193152;
					if (num != 0)
					{
					}
					num = (short)1126367233;
					if (num != 0)
					{
					}
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(innerContent.Right, r.Right))
					{
						num = (short)664338444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_17A:
				num = (short)362151938;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23B:
				num = (short)1399980039;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EE:
				num = (short)463142917;
				num2 = (int)((global::System.IntPtr)num);
			}
			return r;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00012D8C File Offset: 0x00010F8C
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			short num = (short)1817575427;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.PopupPlacement = global::DevComponents.WpfRibbon.ePopupPlacement.Right;
					num = (short)311951362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_113;
				case 2:
					goto IL_134;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				num = (short)953417729;
				if (num != 0)
				{
				}
				num = (short)2002431334;
				short num3 = num;
				num = (short)178236774;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1043070976;
					if (num != 0)
					{
					}
					if (this.GetParent() is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)1084096512;
						short num4 = num;
						num = (short)215416832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				this.PopupPlacement = global::DevComponents.WpfRibbon.ePopupPlacement.Bottom;
				num = (short)1788805121;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			IL_134:
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00012ED8 File Offset: 0x000110D8
		private void InternalPopupClosed(object source, global::System.EventArgs e)
		{
			short num = (short)504801617;
			short num2 = num;
			num = (short)60860753;
			switch (num2 == num)
			{
			}
			num = (short)2037317632;
			short num3 = num;
			num = (short)908132353;
			if (num != 0)
			{
			}
			num = (short)2029322240;
			if (num != 0)
			{
			}
			this.UpdateKeyTipsState();
			this.OnPopupClosed(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent, this));
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00012F98 File Offset: 0x00011198
		protected virtual void OnPopupClosed(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)957132547;
			short num2 = num;
			num = (short)271691523;
			switch (num2 == num)
			{
			}
			num = (short)559153152;
			short num3 = num;
			num = (short)707198977;
			if (num != 0)
			{
			}
			num = (short)2116878336;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00013048 File Offset: 0x00011248
		protected virtual void OnPopupOpened(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1460803612;
			short num2 = num;
			num = (short)173283356;
			switch (num2 == num)
			{
			}
			num = (short)2129068032;
			short num3 = num;
			num = (short)805568513;
			if (num != 0)
			{
			}
			num = (short)2125594624;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000130F8 File Offset: 0x000112F8
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			if (base.ItemsSource != null)
			{
				short num = (short)1058804526;
				short num2 = num;
				num = (short)554701614;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)219283456;
					if (num != 0)
					{
					}
					num = (short)137035777;
					if (num != 0)
					{
					}
					num = (short)1098579968;
					short num3 = num;
					break;
				}
				}
				return base.GetContainerForItemOverride();
			}
			return new global::DevComponents.WpfRibbon.ButtonDropDown();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000131B8 File Offset: 0x000113B8
		private static object CoerceToolTipIsEnabled(global::System.Windows.DependencyObject d, object value)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				IL_0A:
				global::DevComponents.WpfRibbon.BasePopupControl basePopupControl;
				switch (num)
				{
				case 0:
					goto IL_63;
				case 1:
					goto IL_115;
				case 2:
				{
					num2 = (short)669864949;
					short num3 = num2;
					num2 = (short)1543394293;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13A;
					default:
						num2 = (short)686227456;
						if (num2 != 0)
						{
						}
						if (basePopupControl.CurrentSelection != null)
						{
							num2 = (short)1538654209;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return value;
					}
					break;
				}
				case 3:
					goto IL_13A;
				case 4:
					num2 = (short)851902466;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (buttonDropDown.IsPopupOpen)
					{
						num2 = (short)1855193088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					basePopupControl = (buttonDropDown.Parent as global::DevComponents.WpfRibbon.BasePopupControl);
					num2 = (short)1063845891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_13A:
				num2 = (short)2008875008;
				short num4 = num2;
				if (basePopupControl == null)
				{
					return value;
				}
				num2 = (short)1823145988;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_63:
			num2 = (short)1404370945;
			if (num2 != 0)
			{
			}
			return false;
			IL_115:
			return false;
			IL_28:
			buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)d;
			num2 = (short)497942533;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00013358 File Offset: 0x00011558
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)618397697;
			if (num != 0)
			{
			}
			num = (short)1956025634;
			short num2 = num;
			num = (short)1003525410;
			switch (num2 == num)
			{
			default:
			{
				num = (short)312541184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1135017984;
			if (num != 0)
			{
			}
			base.OnMouseMove(e);
			this.UpdateInactiveButtonPart();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00013410 File Offset: 0x00011610
		private void UpdateInactiveButtonPart()
		{
			short num = (short)461963288;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)911278096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.m_ButtonBorder != null)
					{
						num = (short)1581449237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 2:
					num = (short)944963602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!this.IsPopupOpen)
					{
						num = (short)572653568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 4:
					if (this.m_ButtonImage != null)
					{
						num = (short)1592655881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 5:
					if (this.m_ButtonContent != null)
					{
						num = (short)1511456768;
						short num3 = num;
						num = (short)1851326475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 6:
					goto IL_2C7;
				case 7:
				{
					global::System.Windows.Point position;
					if (!this.m_CommandBounds.Contains(position))
					{
						num = (short)590348311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28D;
				}
				case 8:
					if (this.m_ButtonBorder != null)
					{
						num = (short)1947271182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					num = (short)316932106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.IsHighlighted)
					{
						num = (short)512360450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 11:
					num = (short)1827995652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)402745845;
					short num4 = num;
					num = (short)337930741;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1618542592;
						if (num != 0)
						{
						}
						num = (short)1414529025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_40C;
				case 14:
					this.m_ButtonBorder.MouseOverInactiveRect = global::System.Windows.Rect.Empty;
					num = (short)1947664390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_133;
				case 16:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
					{
						num = (short)567345164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 17:
				{
					global::System.Windows.Point position;
					global::System.Windows.Rect rect;
					if (rect.Contains(position))
					{
						num = (short)1090125843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				}
				case 18:
				{
					if (this.IsPopupOpen)
					{
						num = (short)1100283917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
					global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(this);
					num = (short)1076232209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					num = (short)16973825;
					if (num != 0)
					{
					}
					num = (short)978059286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)794230787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)2085224453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
				{
					global::System.Windows.Point position;
					if (!this.m_ExpandBounds.Contains(position))
					{
						num = (short)853409807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)885522439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 23:
					goto IL_F1;
				case 24:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				}
				IL_89:
				if (base.IsEnabled)
				{
					num = (short)627310612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_203:
				num = (short)247398408;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F1:
			this.m_ButtonBorder.MouseOverInactiveRect = this.m_CommandBounds;
			return;
			IL_133:
			this.m_ButtonBorder.MouseOverInactiveRect = this.m_ExpandBounds;
			return;
			IL_1A2:
			this.m_ButtonBorder.MouseOverInactiveRect = global::System.Windows.Rect.Empty;
			return;
			IL_28D:
			this.m_ButtonBorder.MouseOverInactiveRect = global::System.Windows.Rect.Empty;
			return;
			IL_2C7:
			return;
			IL_40C:
			this.m_ButtonBorder.MouseOverInactiveRect = this.m_CommandBounds;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000138BC File Offset: 0x00011ABC
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					global::System.Windows.Rect rect;
					switch (num)
					{
					case 0:
						if (!this.IsPopupOpen)
						{
							num2 = (short)1194917907;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_392;
					case 1:
						if (!global::DevComponents.WpfRibbon.RibbonWindow.SiziningWindowInProgress)
						{
							num2 = (short)48627729;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						num2 = (short)1008664584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (this.Role != global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
						{
							num2 = (short)915865604;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_453;
					case 4:
					{
						num2 = (short)1493499904;
						short num3 = num2;
						num2 = (short)664469511;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						num2 = (short)1187446796;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						num2 = (short)1918763021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (this.IsOnApplicationMenu)
						{
							num2 = (short)2055733273;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FB;
					case 8:
						if (base.Parent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num2 = (short)656343058;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_160;
					case 9:
						goto IL_392;
					case 10:
						return;
					case 11:
						this.SetupLivePreview();
						num2 = (short)753008650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						if (base.IsEnabled)
						{
							num2 = (short)521863179;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 13:
						if (!this.IsPopupOpen)
						{
							num2 = (short)1961623567;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FB;
					case 14:
						goto IL_FB;
					case 15:
						this.OpenOnHoverTimer();
						num2 = (short)1138098190;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 16:
						if (rect.Contains(e.GetPosition(this)))
						{
							num2 = (short)349306886;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FB;
					case 17:
						num2 = (short)98107414;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 18:
						((global::DevComponents.WpfRibbon.ButtonDropDown)base.Parent).ClearChildMouseHighlight();
						num2 = (short)1771372567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 19:
						num2 = (short)1207042049;
						if (num2 != 0)
						{
						}
						num2 = (short)1403322392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 20:
					{
						num2 = (short)569788939;
						short num4 = num2;
						num2 = (short)943147531;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_95;
						default:
							num2 = (short)1092943872;
							if (num2 != 0)
							{
							}
							goto IL_2E9;
						}
						break;
					}
					case 21:
						if (!global::DevComponents.WpfRibbon.RibbonWindow.SiziningWindowInProgress)
						{
							num2 = (short)385810434;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2E9;
					case 22:
						if (this.RaiseLivePreview)
						{
							num2 = (short)2096365573;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 23:
						goto IL_160;
					case 24:
						if (base.Parent is global::DevComponents.WpfRibbon.BasePopupControl)
						{
							num2 = (short)481034266;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_392;
					case 25:
						goto IL_453;
					case 26:
						base.CoerceValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty);
						num2 = (short)956891145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7C;
					IL_FB:
					num2 = (short)1076101120;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_160:
					base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedPropertyKey, true);
					num2 = (short)1992753172;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2E9:
					num2 = (short)1080426499;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_392:
					num2 = (short)1963458561;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_453:
					rect = new global::System.Windows.Rect(base.RenderSize);
					num2 = (short)762314768;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
			}
			IL_7C:
			base.OnMouseEnter(e);
			this.StopTimer(ref this.m_DelayPopupCloseTimer);
			this.UpdateIsPressed();
			IL_95:
			num2 = (short)767623189;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00013D94 File Offset: 0x00011F94
		protected virtual bool RaiseLivePreview
		{
			get
			{
				short num = (short)1134800710;
				short num2 = num;
				num = (short)312782662;
				switch (num2 == num)
				{
				}
				num = (short)606142464;
				short num3 = num;
				num = (short)1293156353;
				if (num != 0)
				{
				}
				num = (short)947388416;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.Ribbon.GetLivePreviewEnabled(this);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00013E40 File Offset: 0x00012040
		private bool IsOnApplicationMenu
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				global::System.Windows.DependencyObject parent;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return false;
					case 1:
						goto IL_11A;
					case 2:
						return true;
					case 3:
						goto IL_11A;
					case 4:
						if (parent == null)
						{
							num2 = (short)1143799808;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)723976197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
					{
						num2 = (short)439746560;
						short num3 = num2;
						if (!(parent is global::DevComponents.WpfRibbon.ApplicationMenu))
						{
							parent = global::System.Windows.LogicalTreeHelper.GetParent(parent);
							num2 = (short)80543747;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1017040951;
						short num4 = num2;
						num2 = (short)1153355831;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num2 = (short)1728118784;
							if (num2 != 0)
							{
							}
							num2 = (short)122028034;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_28;
					IL_11A:
					num2 = (short)1438187521;
					if (num2 != 0)
					{
					}
					num2 = (short)662110212;
					num = (int)((global::System.IntPtr)num2);
				}
				return true;
				IL_28:
				parent = base.Parent;
				num2 = (short)648085505;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00013FC8 File Offset: 0x000121C8
		private bool ShowLivePreviewImmediately
		{
			get
			{
				while (!(base.Parent is global::DevComponents.WpfRibbon.Gallery))
				{
					short num = (short)1050869761;
					if (num != 0)
					{
					}
					num = (short)1627123332;
					short num2 = num;
					num = (short)1829957252;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)452460544;
						if (num != 0)
						{
						}
						num = (short)540737536;
						short num3 = num;
						return true;
					}
					}
				}
				return ((global::DevComponents.WpfRibbon.Gallery)base.Parent).ImmediateLivePreview;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00014094 File Offset: 0x00012294
		private void SetupLivePreview()
		{
			short num = (short)1268645889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1A3;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					if (this.m_LivePreviewOpenTimer != null)
					{
						this.m_LivePreviewOpenTimer.Stop();
						num = (short)307429376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)30052824;
					short num3 = num;
					num = (short)1870959064;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
						num = (short)2067529728;
						if (num != 0)
						{
						}
						num = (short)1810890756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_5C;
				case 4:
					goto IL_174;
				case 5:
					goto IL_C5;
				}
				IL_3D:
				if (this.ShowLivePreviewImmediately)
				{
					num = (short)158859267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1699086336;
				short num4 = num;
				num = (short)1231880194;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_174:
				num = (short)1649016833;
				if (num != 0)
				{
				}
				this.m_LivePreviewOpenTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
				this.m_LivePreviewOpenTimer.Tick += this.TimerInvokeLivePreview;
				num = (short)78577669;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5C:
			this.InvokeLivePreview();
			return;
			IL_C5:
			IL_1A3:
			this.StartTimer(this.m_LivePreviewOpenTimer);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00014254 File Offset: 0x00012454
		private void InvokeLivePreview()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1F4;
				case 1:
					goto IL_128;
				case 2:
					if (base.Parent is global::DevComponents.WpfRibbon.Gallery)
					{
						num2 = (short)1860435972;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_128;
				case 3:
					if (!global::DevComponents.WpfRibbon.Ribbon.IsLivePreviewActive)
					{
						num2 = (short)1325727750;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F6;
				case 4:
					((global::DevComponents.WpfRibbon.Gallery)base.Parent).ImmediateLivePreview = true;
					goto IL_19C;
				case 5:
					if (base.Parent is global::System.Windows.FrameworkElement)
					{
						num2 = (short)1428029447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F6;
				case 6:
					num2 = (short)1497628673;
					if (num2 != 0)
					{
					}
					num2 = (short)642842629;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)142236368;
					short num3 = num2;
					num2 = (short)1746164432;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19C;
					default:
					{
						num2 = (short)1543503872;
						if (num2 != 0)
						{
						}
						num2 = (short)1262682112;
						short num4 = num2;
						global::DevComponents.WpfRibbon.Ribbon.SetIsLivePreviewActive(this, true);
						((global::System.Windows.FrameworkElement)base.Parent).MouseLeave += this.ParentMouseLeave;
						num2 = (short)824770560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_30;
				IL_128:
				num2 = (short)777125891;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_19C:
				num2 = (short)1613692929;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1F4:
			IL_1F6:
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.Ribbon.LivePreviewEvent, this));
			return;
			IL_30:
			this._RaiseUndoPreview = true;
			num2 = (short)1015676930;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00014468 File Offset: 0x00012668
		private void ParentMouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1819279360;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
				{
					num = (short)2039480320;
					short num3 = num;
					num = (short)1672740865;
					if (num != 0)
					{
					}
					num = (short)1138460862;
					short num4 = num;
					num = (short)391743678;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52;
					default:
						goto IL_10B;
					}
					break;
				}
				case 2:
					goto IL_52;
				}
				IL_30:
				if (global::DevComponents.WpfRibbon.Ribbon.IsLivePreviewActive)
				{
					num = (short)668401666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_52:
				((global::System.Windows.FrameworkElement)sender).MouseLeave -= this.ParentMouseLeave;
				global::DevComponents.WpfRibbon.Ribbon.SetIsLivePreviewActive(this, false);
				num = (short)1044774913;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			num = (short)151781376;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0001459C File Offset: 0x0001279C
		private void TimerInvokeLivePreview(object sender, global::System.EventArgs e)
		{
			short num = (short)68561935;
			short num2 = num;
			num = (short)1292839951;
			switch (num2 == num)
			{
			}
			num = (short)663420928;
			short num3 = num;
			num = (short)1826750465;
			if (num != 0)
			{
			}
			num = (short)831979520;
			if (num != 0)
			{
			}
			this.InvokeLivePreview();
			this.StopTimer(ref this.m_LivePreviewOpenTimer);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00014658 File Offset: 0x00012858
		private void OpenOnHoverTimer()
		{
			short num = (short)1330970625;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)446008942;
					short num3 = num;
					num = (short)2113572462;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CC;
					default:
						goto IL_119;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_A3;
				case 3:
					this.m_DelayPopupOpenTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
					this.m_DelayPopupOpenTimer.Tick += this.OnDelayPopupOpen;
					goto IL_CC;
				}
				IL_35:
				if (this.m_DelayPopupOpenTimer == null)
				{
					num = (short)1936261123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.m_DelayPopupOpenTimer.Stop();
				num = (short)1441595392;
				short num4 = num;
				num = (short)994639874;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC:
				num = (short)34078720;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			goto IL_131;
			IL_119:
			num = (short)620494848;
			if (num != 0)
			{
			}
			IL_131:
			num = (short)111149057;
			if (num != 0)
			{
			}
			this.StartTimer(this.m_DelayPopupOpenTimer);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000147CC File Offset: 0x000129CC
		private void CloseOnHoverTimer()
		{
			short num = (short)783482881;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)832333385;
					short num3 = num;
					num = (short)1278240329;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C5;
					default:
						goto IL_111;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_9C;
				case 3:
					this.m_DelayPopupCloseTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
					this.m_DelayPopupCloseTimer.Tick += this.OnDelayPopupClose;
					goto IL_C5;
				}
				IL_34:
				if (this.m_DelayPopupCloseTimer == null)
				{
					num = (short)1806237699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.m_DelayPopupCloseTimer.Stop();
				num = (short)2110586880;
				short num4 = num;
				num = (short)1772486658;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C5:
				num = (short)690814976;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9C:
			goto IL_151;
			IL_111:
			num = (short)781451265;
			if (num != 0)
			{
			}
			num = (short)1444675584;
			if (num != 0)
			{
			}
			IL_151:
			this.StartTimer(this.m_DelayPopupCloseTimer);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00014938 File Offset: 0x00012B38
		private void OnDelayPopupOpen(object sender, global::System.EventArgs e)
		{
			short num = (short)973144065;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1838939060;
					short num3 = num;
					num = (short)1323039668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C7;
					default:
						goto IL_112;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_98;
				case 3:
					this.OpenPopup();
					goto IL_C7;
				}
				IL_34:
				if (this.HasVisibleItems)
				{
					num = (short)1950679043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.IsSelected = true;
				num = (short)2023489536;
				short num4 = num;
				num = (short)83427330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C7:
				num = (short)1220345856;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_98:
			num = (short)1786314753;
			if (num != 0)
			{
			}
			goto IL_129;
			IL_112:
			num = (short)1163329536;
			if (num != 0)
			{
			}
			IL_129:
			this.StopTimer(ref this.m_DelayPopupOpenTimer);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00014A7C File Offset: 0x00012C7C
		private void OnDelayPopupClose(object sender, global::System.EventArgs e)
		{
			short num = (short)1352789423;
			short num2 = num;
			num = (short)116387247;
			switch (num2 == num)
			{
			}
			num = (short)68943872;
			short num3 = num;
			num = (short)1039990784;
			if (num != 0)
			{
			}
			num = (short)1733820417;
			if (num != 0)
			{
			}
			this.IsPopupOpen = false;
			this.StopTimer(ref this.m_DelayPopupCloseTimer);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00014B38 File Offset: 0x00012D38
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)209860623;
			short num2 = num;
			num = (short)1329346575;
			switch (num2 == num)
			{
			}
			num = (short)8060928;
			short num3 = num;
			num = (short)617480193;
			if (num != 0)
			{
			}
			num = (short)800194560;
			if (num != 0)
			{
			}
			base.OnMouseLeave(e);
			this.RemoveButtonHighlight();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00014BEC File Offset: 0x00012DEC
		private void RemoveButtonHighlight()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.IsPopupOpen)
					{
						num2 = (short)655163399;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FF;
				case 1:
					goto IL_1E5;
				case 2:
					goto IL_FF;
				case 3:
					if (this.IsHighlighted)
					{
						num2 = (short)1381892097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FF;
				case 4:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num2 = (short)2075131909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FF;
				case 5:
					num2 = (short)1476591619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this._RaiseUndoPreview)
					{
						num2 = (short)390725632;
						short num3 = num2;
						num2 = (short)140443657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					this.CloseOnHoverTimer();
					num2 = (short)1712455682;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return;
				case 9:
					base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.Ribbon.UndoLivePreviewEvent, this));
					this._RaiseUndoPreview = false;
					num2 = (short)1204879368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_FF:
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedPropertyKey, false);
				this.UpdateInactiveButtonPart();
				this.UpdateIsPressed();
				this.UpdateBorderRenderState();
				num2 = (short)370999302;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			this.StopTimer(ref this.m_LivePreviewOpenTimer);
			this.StopTimer(ref this.m_DelayPopupOpenTimer);
			num2 = (short)1175977985;
			if (num2 != 0)
			{
			}
			num2 = (short)588354839;
			short num4 = num2;
			num2 = (short)1777308951;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1E5:
				num2 = (short)2042691584;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)497942528;
				if (num2 != 0)
				{
				}
				num2 = (short)1580466180;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00014E54 File Offset: 0x00013054
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)2077556736;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1522335745;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 1:
				{
					num = (short)613759407;
					short num3 = num;
					num = (short)1017723311;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
						goto IL_10D;
					}
					break;
				}
				case 2:
					goto IL_7D;
				}
				IL_5C:
				if (!e.Handled)
				{
					num = (short)1603600386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_124;
				IL_7D:
				this.m_MouseDownPosition = e.GetPosition(this);
				this.HandleMouseDown(e);
				this.UpdateIsPressed();
				num = (short)1146486784;
				short num4 = num;
				num = (short)375586817;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			num = (short)1652752384;
			if (num != 0)
			{
			}
			IL_124:
			base.OnMouseLeftButtonDown(e);
			this.UpdateBorderRenderState();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00014F94 File Offset: 0x00013194
		private void StopTimer(ref global::System.Windows.Threading.DispatcherTimer timer)
		{
			short num = (short)933494784;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
				{
					num = (short)929366016;
					short num3 = num;
					num = (short)1932347777;
					short num4 = num;
					num = (short)883050881;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F;
					default:
						goto IL_CB;
					}
					break;
				}
				case 2:
					goto IL_4F;
				}
				IL_31:
				if (timer != null)
				{
					num = (short)1466826754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_4F:
				timer.Stop();
				timer = null;
				num = (short)1976565761;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CB:
			num = (short)948240385;
			if (num != 0)
			{
			}
			num = (short)1024524288;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000150AC File Offset: 0x000132AC
		private void StartTimer(global::System.Windows.Threading.DispatcherTimer timer)
		{
			short num = (short)304284745;
			short num2 = num;
			num = (short)169411657;
			switch (num2 == num)
			{
			}
			num = (short)571867136;
			short num3 = num;
			num = (short)522584065;
			if (num != 0)
			{
			}
			num = (short)598081536;
			if (num != 0)
			{
			}
			timer.Interval = global::System.TimeSpan.FromMilliseconds((double)global::System.Windows.SystemParameters.MenuShowDelay);
			timer.Start();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001516C File Offset: 0x0001336C
		private static void OnAccessKeyPressed(object sender, global::System.Windows.Input.AccessKeyPressedEventArgs e)
		{
			short num = (short)901251072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				bool flag;
				for (;;)
				{
					IL_27:
					global::System.Windows.DependencyObject dependencyObject;
					switch (num2)
					{
					case 0:
						goto IL_25F;
					case 1:
						if (e.Scope == null)
						{
							num = (short)1459224589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					case 2:
						if (global::System.Windows.Input.Mouse.Captured is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)1174143006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						e.Handled = true;
						num = (short)1547108371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)912654343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1763442704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)464584722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_25F;
					case 7:
					{
						global::System.Windows.UIElement uielement;
						if (global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(uielement) == buttonDropDown)
						{
							num = (short)647954442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B3;
					}
					case 8:
					{
						num = (short)1780583968;
						short num3 = num;
						num = (short)1045990944;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
							num = (short)1401159680;
							if (num != 0)
							{
							}
							flag = true;
							num = (short)617611276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						flag = true;
						num = (short)340328448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						flag = true;
						num = (short)564920326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (dependencyObject == null)
						{
							num = (short)1442185239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2025193487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_25F;
					case 13:
						num = (short)43253793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)924778516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (dependencyObject != buttonDropDown)
						{
							num = (short)1257570330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					case 16:
						if (!(global::System.Windows.Input.Mouse.Captured is global::DevComponents.WpfRibbon.BasePopupControl))
						{
							num = (short)1725104145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 17:
						num = (short)1255800833;
						if (num != 0)
						{
						}
						num = (short)1697906690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (global::System.Windows.Input.Mouse.Captured != null)
						{
							num = (short)85590020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 19:
						goto IL_25F;
					case 20:
						if (e.Target is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)834797577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					case 21:
						return;
					case 22:
						if (buttonDropDown.IsPopupOpen)
						{
							num = (short)362086408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					case 23:
						goto IL_25F;
					case 24:
						goto IL_34C;
					case 25:
						num = (short)1692729366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::System.Windows.UIElement uielement = dependencyObject as global::System.Windows.UIElement;
						num = (short)1958150175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (e.OriginalSource == buttonDropDown)
						{
							num = (short)464191513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					case 28:
						goto IL_34C;
					case 29:
						if (e.Target == null)
						{
							goto IL_E7;
						}
						num = (short)2112290817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_168;
					case 31:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)2090270723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B3;
					}
					case 32:
						if (flag)
						{
							num = (short)957218850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 33:
						if (e.Target != buttonDropDown)
						{
							num = (short)1365245966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CB;
					case 34:
						e.Scope = buttonDropDown;
						e.Handled = true;
						num = (short)451346453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
					IL_E7:
					num = (short)39714821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_168:
					e.Target = buttonDropDown;
					num = (short)889716763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B3:
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
					num = (short)973864988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25F:
					num = (short)1336999936;
					short num4 = num;
					num = (short)2058944544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34C:
					num = (short)1391722507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CB:
					dependencyObject = (e.Source as global::System.Windows.DependencyObject);
					num = (short)447545368;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_BA:
				buttonDropDown = (sender as global::DevComponents.WpfRibbon.ButtonDropDown);
				flag = false;
				num = (short)1942814749;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00015770 File Offset: 0x00013970
		protected override void OnAccessKey(global::System.Windows.Input.AccessKeyEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.DropDown)
					{
						num2 = (short)631439361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.InternalOnClick(true);
					goto IL_6A;
				case 1:
				{
					num2 = (short)2028142592;
					short num3 = num2;
					num2 = (short)384801706;
					short num4 = num2;
					num2 = (short)719952810;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						goto IL_E3;
					}
					break;
				}
				case 2:
					goto IL_7F;
				case 3:
					if (!e.IsMultiple)
					{
						num2 = (short)546308100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)1200816129;
					if (num2 != 0)
					{
					}
					num2 = (short)1201668096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_6A:
				num2 = (short)2114650114;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7F:
			return;
			IL_E3:
			num2 = (short)2049900544;
			if (num2 != 0)
			{
			}
			this.ClickHeader();
			return;
			IL_24:
			base.OnAccessKey(e);
			num2 = (short)1336082435;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000158E8 File Offset: 0x00013AE8
		[global::System.Security.SecurityCritical]
		internal void InternalOnClick(bool userInitiated)
		{
			switch (0)
			{
			case 0:
				goto IL_84;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
				switch (num)
				{
				case 0:
					num2 = (short)821297156;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					((global::DevComponents.WpfRibbon.ButtonDropDown)base.Parent).ShowKeyTips = false;
					num2 = (short)256639001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (((global::DevComponents.WpfRibbon.ButtonDropDown)base.Parent).ShowKeyTips)
					{
						num2 = (short)1379467265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 3:
					if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked))
					{
						num2 = (short)2013265941;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E3;
				case 4:
					if (applicationMenu.IsPopupOpen)
					{
						num2 = (short)1136197644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
					if (automationPeer != null)
					{
						num2 = (short)957743132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E3;
				}
				case 6:
					return;
				case 7:
					goto IL_3A4;
				case 8:
				{
					num2 = (short)2008023040;
					short num3 = num2;
					if (!this.StaysOpenOnClick)
					{
						num2 = (short)1285160967;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 9:
					applicationMenu = ((global::DevComponents.WpfRibbon.Backstage)base.Parent).ApplicationMenu;
					num2 = (short)1649344532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_3E3;
				case 11:
					if (base.Parent is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num2 = (short)1027145747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 12:
					num2 = (short)1827143688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (applicationMenu.ShowKeyTips)
					{
						num2 = (short)2078343186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A9;
				case 14:
					if (base.Parent is global::DevComponents.WpfRibbon.Backstage)
					{
						num2 = (short)1152516105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 15:
					if (applicationMenu != null)
					{
						num2 = (short)797442048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 16:
				{
					num2 = (short)1805385729;
					if (num2 != 0)
					{
					}
					if (this.IsCheckable)
					{
						goto IL_236;
					}
					num2 = (short)625776555;
					short num4 = num2;
					num2 = (short)1460705195;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A4;
					default:
						num2 = (short)2089943040;
						if (num2 != 0)
						{
						}
						num2 = (short)391315480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 17:
					goto IL_2F1;
				case 18:
					applicationMenu.ShowKeyTips = false;
					num2 = (short)67174423;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1043136514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (applicationMenu != null)
					{
						num2 = (short)11010075;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A9;
				case 21:
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this);
					num2 = (short)1542586373;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 22:
					if (this.IsInOptionGroup)
					{
						num2 = (short)999817242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2F1;
				case 23:
					goto IL_3A9;
				case 24:
					num2 = (short)848101398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					goto IL_173;
				case 26:
					goto IL_236;
				case 27:
					num2 = (short)1109983245;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
					automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked);
					num2 = (short)277807114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_84;
				IL_173:
				num2 = (short)1878327310;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_236:
				this.IsChecked = !this.IsChecked;
				num2 = (short)1238564881;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2F1:
				base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.PreviewClickEvent, this));
				num2 = (short)530644995;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A4:
				applicationMenu.IsPopupOpen = false;
				num2 = (short)1228537862;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A9:
				num2 = (short)1364721679;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3E3:
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::System.Windows.Threading.DispatcherOperationCallback(this.InvokeClickAfterRender), userInitiated);
				num2 = (short)370933771;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_84:
			this.StopTimer(ref this.m_LivePreviewOpenTimer);
			this._RaiseUndoPreview = false;
			global::DevComponents.WpfRibbon.Ribbon.SetIsLivePreviewActive(null, false);
			num2 = (short)1168703504;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00015E34 File Offset: 0x00014034
		private void FocusOrSelect()
		{
			short num = (short)1551106054;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedPropertyKey, true);
					num = (short)1525088261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)874066636;
					short num3 = num;
					num = (short)288961228;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_119;
					default:
						num = (short)673316864;
						if (num != 0)
						{
						}
						base.Focus();
						num = (short)433651714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_16C;
				case 3:
				{
					num = (short)2138963968;
					short num4 = num;
					num = (short)607059969;
					if (num != 0)
					{
					}
					if (this.IsSelected)
					{
						num = (short)1196556297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					this.IsSelected = true;
					num = (short)1202913287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 7:
					goto IL_119;
				case 8:
					if (!this.IsSelected)
					{
						num = (short)1211891716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A7;
				case 9:
					num = (short)340131850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!this.IsHighlighted)
					{
						num = (short)1749155840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_50:
				if (!base.IsKeyboardFocusWithin)
				{
					num = (short)443613185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_16C:
				num = (short)1656553480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A7:
				num = (short)1434255363;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_119:
				goto IL_1A7;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00016078 File Offset: 0x00014278
		[global::System.Security.SecurityCritical]
		private object InvokeClickAfterRender(object arg)
		{
			short num = (short)1788870657;
			if (num != 0)
			{
			}
			num = (short)1542213528;
			short num2 = num;
			num = (short)1985302424;
			switch (num2 == num)
			{
			}
			num = (short)1383268352;
			short num3 = num;
			num = (short)1097203712;
			if (num != 0)
			{
			}
			bool flag = (bool)arg;
			this.OnClick();
			global::DevComponents.WpfRibbon.ButtonDropDown.ExecuteCommand(this);
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0001613C File Offset: 0x0001433C
		protected virtual void OnClick()
		{
			short num = (short)1356614434;
			short num2 = num;
			num = (short)868698914;
			switch (num2 == num)
			{
			}
			num = (short)1903558657;
			if (num != 0)
			{
			}
			num = (short)1107951616;
			short num3 = num;
			num = (short)1837563904;
			if (num != 0)
			{
			}
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.ClickEvent, this));
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000161F4 File Offset: 0x000143F4
		internal static void ExecuteCommand(global::System.Windows.Input.ICommandSource commandSource)
		{
			short num = (short)1078722560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::System.Windows.Input.RoutedCommand routedCommand;
				object commandParameter;
				global::System.Windows.IInputElement inputElement;
				global::System.Windows.Input.ICommand command;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (routedCommand.CanExecute(commandParameter, inputElement))
						{
							num = (short)72089603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (inputElement == null)
						{
							num = (short)606142473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					case 2:
						if (global::System.Windows.Input.Keyboard.FocusedElement == null)
						{
							num = (short)1658126342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					case 3:
						goto IL_200;
					case 4:
					{
						command.Execute(commandParameter);
						num = (short)1777664000;
						short num3 = num;
						num = (short)1405550593;
						if (num != 0)
						{
						}
						num = (short)1293942797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)423231495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						inputElement = (commandSource as global::System.Windows.IInputElement);
						num = (short)1623392270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (inputElement != null)
						{
							num = (short)2105868303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 8:
					{
						if (routedCommand == null)
						{
							goto IL_135;
						}
						num = (short)1135352498;
						short num4 = num;
						num = (short)47323826;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1748369408;
							if (num != 0)
							{
							}
							num = (short)1063845893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)728498178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						commandParameter = commandSource.CommandParameter;
						inputElement = commandSource.CommandTarget;
						num = (short)831651841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (command != null)
						{
							num = (short)1361510410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (command.CanExecute(commandParameter))
						{
							num = (short)2073362436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						return;
					case 14:
						goto IL_278;
					case 15:
						num = (short)1911160832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E;
					IL_135:
					num = (short)1260126220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_278:
					routedCommand = (command as global::System.Windows.Input.RoutedCommand);
					num = (short)263192584;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_200:
				routedCommand.Execute(commandParameter, inputElement);
				return;
				IL_6E:
				command = commandSource.Command;
				num = (short)415170571;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0001652C File Offset: 0x0001472C
		protected virtual void HandleMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)2111832064;
			short num2 = num;
			num = (short)1457124949;
			short num3 = num;
			num = (short)1467217493;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_331:
				num = (short)1671757842;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)847118336;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_EF;
				}
				break;
			}
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					goto IL_2E1;
				case 1:
					if (this.Role != global::DevComponents.WpfRibbon.eButtonRole.DropDown)
					{
						num = (short)19267597;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_282;
				case 2:
					if (!this.m_ExpandBounds.IsEmpty)
					{
						num = (short)1366032398;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 3:
					if (rect.Contains(e.GetPosition(this)))
					{
						num = (short)1568473112;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 4:
					goto IL_282;
				case 5:
					goto IL_23E;
				case 6:
					if (this.IsPopupOpen)
					{
						num = (short)1102184453;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C3;
				case 7:
					if (base.IsEnabled)
					{
						num = (short)967835668;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 8:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num = (short)1043595286;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 9:
					if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
					{
						num = (short)801898515;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B4;
				case 10:
					goto IL_1FF;
				case 11:
					if (e.ChangedButton == global::System.Windows.Input.MouseButton.Right)
					{
						num = (short)1335099402;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 12:
					num = (short)1699086337;
					if (num != 0)
					{
					}
					num = (short)2075590658;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1577320456;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1695416343;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_3B4;
				case 16:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
					{
						num = (short)91684876;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 17:
					if (base.Parent is global::DevComponents.WpfRibbon.ApplicationMenu)
					{
						num = (short)1748828181;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C3;
				case 18:
					if (this.IsOnContextMenu)
					{
						num = (short)107085839;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 19:
					num = (short)1562312715;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)1870462979;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)559742982;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1036451865;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (!this.m_ExpandBounds.Contains(e.GetPosition(this)))
					{
						num = (short)1175388186;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_282;
				case 24:
					num = (short)1307705353;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (this.HasVisibleItems)
					{
						num = (short)248446980;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 26:
					goto IL_183;
				}
				goto IL_EF;
				IL_183:
				num = (short)1143668737;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_282:
				num = (short)1809121297;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C3:
				this.ClickHeader();
				num = (short)1399128064;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B4:
				num = (short)37421072;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1FF:
			goto IL_331;
			IL_23E:
			e.Handled = true;
			return;
			IL_2E1:
			IL_49D:
			e.Handled = true;
			return;
			IL_EF:
			rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			num = (short)1290600455;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000169E0 File Offset: 0x00014BE0
		private bool IsOnContextMenu
		{
			get
			{
				short num = (short)1927903410;
				short num2 = num;
				num = (short)1457354930;
				switch (num2 == num)
				{
				}
				num = (short)1437728768;
				if (num != 0)
				{
				}
				num = (short)1443364865;
				if (num != 0)
				{
				}
				num = (short)295895040;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00016A88 File Offset: 0x00014C88
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)876281866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Rect rect;
					if (rect.Contains(this.m_MouseDownPosition))
					{
						num = (short)296353804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
				}
				case 1:
					num = (short)968556564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::System.Windows.Point position;
					if (!this.m_CommandBounds.Contains(position))
					{
						num = (short)418775056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				}
				case 3:
					goto IL_29E;
				case 4:
					goto IL_1F9;
				case 5:
					goto IL_2BC;
				case 6:
					num = (short)693895169;
					if (num != 0)
					{
					}
					num = (short)1304297485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (base.IsEnabled)
					{
						num = (short)167837713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_462;
				case 8:
					goto IL_1AB;
				case 9:
					num = (short)946470912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 11:
					if (this.m_CommandBounds.IsEmpty)
					{
						num = (short)470417417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
				case 12:
					num = (short)67371022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)822804480;
					short num3 = num;
					if (this.m_CommandBounds.Contains(this.m_MouseDownPosition))
					{
						num = (short)940703759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C1;
				}
				case 14:
				{
					global::System.Windows.Rect rect;
					global::System.Windows.Point position;
					if (!rect.Contains(position))
					{
						num = (short)818741267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				}
				case 15:
					num = (short)1435566082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_2C1;
				case 17:
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
					global::System.Windows.Point position = e.GetPosition(this);
					num = (short)1265565704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					this.UpdateIsPressed();
					num = (short)226951190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_AF;
				case 20:
					if (!this.HasVisibleItems)
					{
						num = (short)2059403268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29E;
				case 21:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
					{
						num = (short)604766232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
				case 22:
					goto IL_21E;
				case 23:
					if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num = (short)819265537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29E;
				case 24:
				{
					num = (short)890682750;
					short num4 = num;
					num = (short)940883326;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AB;
					default:
						num = (short)1333592064;
						if (num != 0)
						{
						}
						num = (short)321519627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_88:
				if (!e.Handled)
				{
					num = (short)511115282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_21E;
				IL_AF:
				num = (short)892993559;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AB:
				if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
				{
					num = (short)355532806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2C1;
				IL_1F9:
				this.InternalOnClick(true);
				num = (short)858521603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21E:
				num = (short)539754503;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29E:
				e.Handled = true;
				num = (short)515244037;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C1:
				num = (short)1388052501;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2BC:
			IL_462:
			base.OnMouseLeftButtonUp(e);
			this.UpdateBorderRenderState();
			this.m_MouseDownPosition = new global::System.Windows.Point(double.MaxValue, double.MaxValue);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00016F24 File Offset: 0x00015124
		private void UpdateIsPressed()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.IsMouseOver)
					{
						num2 = (short)768016387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19D;
				case 1:
					goto IL_13B;
				case 2:
				{
					num2 = (short)837640549;
					short num3 = num2;
					num2 = (short)1835688293;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
					{
						num2 = (short)65667073;
						if (num2 != 0)
						{
						}
						num2 = (short)810352640;
						if (num2 != 0)
						{
						}
						num2 = (short)574881792;
						short num4 = num2;
						num2 = (short)1865678848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)536150017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num2 = (short)1669791746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19D;
				case 5:
					goto IL_162;
				}
				goto IL_28;
				IL_13B:
				if (!rect.Contains(global::System.Windows.Input.Mouse.GetPosition(this)))
				{
					goto IL_19D;
				}
				num2 = (short)1644232709;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_162:
			base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPressedPropertyKey, true);
			return;
			IL_19D:
			base.ClearValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPressedPropertyKey);
			return;
			IL_28:
			rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			num2 = (short)1754267652;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000170DC File Offset: 0x000152DC
		protected virtual global::DevComponents.WpfRibbon.eButtonRenderingState GetBorderRenderState()
		{
			short num = (short)1382164438;
			short num2 = num;
			num = (short)1921918934;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1F7:
				goto IL_318;
			default:
				num = (short)2144337920;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_F1;
				}
				break;
			}
			int num3;
			global::DevComponents.WpfRibbon.eButtonRenderingState result;
			for (;;)
			{
				IL_57:
				switch (num3)
				{
				case 0:
					goto IL_133;
				case 1:
				{
					if (this.IsOnApplicationMenu)
					{
						num = (short)1986789396;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1182072833;
					if (num != 0)
					{
					}
					global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
					num = (short)79560712;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (this.Role != global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num = (short)105971722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B3;
				case 3:
					if (!this.IsHighlighted)
					{
						num = (short)1626144792;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_318;
				case 4:
					result = global::DevComponents.WpfRibbon.eButtonRenderingState.Checked;
					num = (short)571277321;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::System.Windows.Rect rect;
					if (!rect.Contains(global::System.Windows.Input.Mouse.GetPosition(this)))
					{
						num = (short)1900675072;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BE;
				}
				case 6:
					return result;
				case 7:
					num = (short)1624571917;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.IsPopupOpen)
					{
						num = (short)865796110;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1466761244;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return result;
				case 10:
					num = (short)1474756609;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (base.IsKeyboardFocusWithin)
					{
						num = (short)2139422741;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)36634643;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					global::System.Windows.Rect rect;
					if (rect.Contains(global::System.Windows.Input.Mouse.GetPosition(this)))
					{
						num = (short)1139933210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C2;
				}
				case 13:
					if (base.IsMouseOver)
					{
						num = (short)2030960657;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C2;
				case 14:
					result = global::DevComponents.WpfRibbon.eButtonRenderingState.Expanded;
					num = (short)1464729631;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (!base.IsEnabled)
					{
						num = (short)903610384;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1004994562;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					result = global::DevComponents.WpfRibbon.eButtonRenderingState.Disabled;
					num = (short)852099078;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)905773068;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)389283851;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (this.IsChecked)
					{
						num = (short)1178075140;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 20:
					goto IL_3B3;
				case 21:
					goto IL_4BE;
				case 22:
					num = (short)1821638661;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (this.IsChecked)
					{
						num = (short)1039925283;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::DevComponents.WpfRibbon.eButtonRenderingState.Hover;
					num = (short)616759325;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)220528674;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_1F7;
				case 26:
				{
					num = (short)1891172352;
					short num4 = num;
					result = global::DevComponents.WpfRibbon.eButtonRenderingState.Pressed;
					num = (short)1015742496;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 27:
					return result;
				case 28:
					if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num = (short)1162084359;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C2;
				case 29:
					return result;
				case 30:
					return result;
				case 31:
					return result;
				case 32:
					return result;
				case 33:
					if (!this.IsHighlighted)
					{
						num = (short)888078354;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BE;
				case 34:
					if (this.IsPopupOpen)
					{
						num = (short)1256063001;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 35:
					result = global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover;
					num = (short)1104085022;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (base.IsMouseOver)
					{
						num = (short)112132118;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_133;
				}
				goto IL_F1;
				IL_133:
				num = (short)2029191201;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B3:
				new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
				num = (short)173277187;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BE:
				num = (short)318111767;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_5C2:
				num = (short)996016164;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_F1:
			result = global::DevComponents.WpfRibbon.eButtonRenderingState.Normal;
			num = (short)1649213455;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_57;
			IL_318:
			result = global::DevComponents.WpfRibbon.eButtonRenderingState.Hover;
			num = (short)1114636315;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_57;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000176EC File Offset: 0x000158EC
		private void UpdateBorderRenderState()
		{
			while (this.m_ButtonBorder == null)
			{
				short num = (short)670498817;
				if (num != 0)
				{
				}
				num = (short)501678080;
				short num2 = num;
				num = (short)1327377338;
				short num3 = num;
				num = (short)1026960314;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1657995264;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::DevComponents.WpfRibbon.eButtonRenderingState borderRenderState = this.GetBorderRenderState();
			this.SetButtonBorderState(borderRenderState);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000177B0 File Offset: 0x000159B0
		protected void SetButtonBorderState(global::DevComponents.WpfRibbon.eButtonRenderingState state)
		{
			short num = (short)468385792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					this.m_ButtonBorder.ButtonState = state;
					num = (short)373096450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F1;
				}
				IL_30:
				num = (short)106889216;
				short num3 = num;
				if (this.m_ButtonBorder.ButtonState == state)
				{
					return;
				}
				num = (short)2094787266;
				short num4 = num;
				num = (short)1311042242;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1998848000;
					if (num != 0)
					{
					}
					num = (short)285409281;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F1:
			num = (short)935526401;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000178D8 File Offset: 0x00015AD8
		public virtual void ClickHeader()
		{
			short num;
			for (;;)
			{
				num = (short)1172766724;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!(this.GetParent() is global::DevComponents.WpfRibbon.IPopupParentControl))
						{
							num = (short)467468290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)1427963909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_DE;
					case 3:
						this.SetPopupMode(false);
						num = (short)1662517248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 5:
						if (!this.IsNestedMenu)
						{
							num = (short)1383399427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						return;
					}
					IL_41:
					if (this.IsPopupOpen)
					{
						num = (short)1484259329;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.OpenPopup();
						num = (short)463273990;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_DE:
				num = (short)425300571;
				short num3 = num;
				num = (short)869569115;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_114;
				}
			}
			IL_114:
			num = (short)517275648;
			if (num != 0)
			{
			}
			num = (short)1698824193;
			if (num != 0)
			{
			}
			num = (short)1627455488;
			short num4 = num;
			this.IsPopupOpen = false;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00017A9C File Offset: 0x00015C9C
		protected virtual void SetPopupMode(bool popupMode)
		{
			short num = (short)911671296;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::DevComponents.WpfRibbon.IPopupParentControl popupParent;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					num = (short)903872515;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					if (popupParent != null)
					{
						goto IL_98;
					}
					return;
				case 3:
				{
					num = (short)1665847112;
					short num4 = num;
					num = (short)1275776840;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						num = (short)1844903936;
						if (num != 0)
						{
						}
						if (popupParent.IsPopupMode != popupMode)
						{
							num = (short)297795588;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					popupParent.IsPopupMode = popupMode;
					num = (short)1674248193;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_98:
				num = (short)107085824;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_4D:
			num = (short)1626144769;
			if (num != 0)
			{
			}
			popupParent = this.GetPopupParent();
			num = (short)897384450;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00017C04 File Offset: 0x00015E04
		internal global::DevComponents.WpfRibbon.IPopupParentControl GetPopupParent()
		{
			short num = (short)1758068744;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.ItemsControl itemsControl;
			global::System.Windows.DependencyObject parent;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (itemsControl is global::DevComponents.WpfRibbon.IPopupParentControl)
					{
						num = (short)1417019403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1686044673;
					if (num != 0)
					{
					}
					parent = base.Parent;
					num = (short)42926081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (parent != null)
					{
						num = (short)2102263813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_285;
				case 2:
					goto IL_125;
				case 3:
					goto IL_DE;
				case 4:
					if (parent is global::DevComponents.WpfRibbon.IPopupParentControl)
					{
						num = (short)1852309504;
						short num3 = num;
						num = (short)119078915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					parent = global::System.Windows.LogicalTreeHelper.GetParent(parent);
					num = (short)1398603786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_19F;
				case 6:
				{
					if (base.TemplatedParent is global::DevComponents.WpfRibbon.IPopupParentControl)
					{
						num = (short)1353515010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this);
					num = (short)1974403183;
					short num4 = num;
					num = (short)1612447855;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19F;
					default:
						num = (short)66977792;
						if (num != 0)
						{
						}
						num = (short)1950875648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_1E1;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 9:
					goto IL_7A;
				case 10:
					if (parent == null)
					{
						num = (short)1331298311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F;
				case 11:
					goto IL_274;
				}
				IL_55:
				if (base.Parent is global::DevComponents.WpfRibbon.IPopupParentControl)
				{
					num = (short)752287753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1099104262;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F:
				num = (short)218562564;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19F:
				goto IL_7F;
			}
			IL_7A:
			return base.Parent as global::DevComponents.WpfRibbon.IPopupParentControl;
			IL_DE:
			return parent as global::DevComponents.WpfRibbon.IPopupParentControl;
			IL_125:
			return base.TemplatedParent as global::DevComponents.WpfRibbon.IPopupParentControl;
			IL_1E1:
			goto IL_285;
			IL_274:
			return itemsControl as global::DevComponents.WpfRibbon.IPopupParentControl;
			IL_285:
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00017E98 File Offset: 0x00016098
		internal object GetParent()
		{
			short num = (short)1188167685;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.Parent != null)
					{
						num = (short)810221569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA;
				case 1:
				{
					num = (short)92345016;
					short num3 = num;
					num = (short)473961144;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						goto IL_1AE;
					}
					break;
				}
				case 2:
					goto IL_69;
				case 3:
					if (base.TemplatedParent is global::DevComponents.WpfRibbon.IPopupParentControl)
					{
						num = (short)1145503750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)211812352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)127205377;
					if (num != 0)
					{
					}
					if (base.Parent is global::DevComponents.WpfRibbon.IPopupParentControl)
					{
						num = (short)2000420871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)161742851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					goto IL_E0;
				case 7:
					goto IL_14C;
				}
				IL_44:
				if (!(base.Parent is global::DevComponents.WpfRibbon.ButtonDropDown))
				{
					num = (short)2046951426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1CC;
				IL_69:
				num = (short)1767309316;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E0:
			return base.TemplatedParent;
			IL_14C:
			num = (short)628490240;
			short num4 = num;
			goto IL_1CC;
			IL_1AE:
			num = (short)1397882880;
			if (num != 0)
			{
			}
			return base.Parent;
			IL_1CC:
			return base.Parent;
			IL_1DA:
			return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00018088 File Offset: 0x00016288
		internal bool OpenPopup()
		{
			short num = (short)1591017477;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!base.IsKeyboardFocusWithin)
					{
						num = (short)281411586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (this.HasVisibleItems)
					{
						num = (short)2058682376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
				{
					num = (short)177756309;
					short num3 = num;
					num = (short)2017745045;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DC;
					default:
						num = (short)1713897472;
						if (num != 0)
						{
						}
						this.FocusOrSelect();
						num = (short)51838979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return true;
				case 4:
					if (this.Role != global::DevComponents.WpfRibbon.eButtonRole.DropDown)
					{
						num = (short)585826311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 6:
					num = (short)1125908484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1815412736;
					short num4 = num;
					num = (short)425656321;
					if (num != 0)
					{
					}
					num = (short)478281729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_DC;
				}
				IL_4A:
				if (!this.IsPopupOpen)
				{
					num = (short)308150278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_DC:
				this.IsPopupOpen = true;
				num = (short)1450901504;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00018284 File Offset: 0x00016484
		protected virtual bool HasVisibleItems
		{
			get
			{
				short num = (short)1080688640;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					num = (short)1385365508;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)578093061;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)303824903;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										result = true;
										num = (short)842006534;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)460193796;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator.Current;
										num = (short)2146697219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										object obj;
										if (obj is global::System.Windows.UIElement)
										{
											num = (short)604176384;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										num = (short)477560840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_D6;
										}
										continue;
									case 6:
										goto IL_F0;
									case 7:
									{
										object obj;
										if (((global::System.Windows.UIElement)obj).Visibility != global::System.Windows.Visibility.Collapsed)
										{
											num = (short)1602813953;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										goto IL_1CA;
									}
									IL_133:
									num = (short)415891458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D6:
									goto IL_133;
								}
								IL_F0:
								return result;
								IL_1CA:
								return false;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1EC;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1D9:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1547829249;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_240;
									case 1:
										disposable.Dispose();
										num = (short)751370242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_23E;
									}
									goto IL_1EC;
								}
								IL_23E:
								IL_240:
								goto EndFinally_10;
								IL_1EC:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1274937344;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1D9;
								EndFinally_10:;
							}
							goto IL_241;
						case 1:
							num = (short)929234946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (base.ItemsSource != null)
							{
								num = (short)1308491781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F7;
						case 3:
							if (base.Items.Count > 0)
							{
								num = (short)1845559297;
								if (num != 0)
								{
								}
								num = (short)1969553414;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_61;
							}
							continue;
						case 5:
						{
							num = (short)612875927;
							short num3 = num;
							num = (short)1331674775;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_241;
							default:
								goto IL_29F;
							}
							break;
						}
						case 6:
							goto IL_241;
						}
						IL_61:
						if (base.Items.Count > 0)
						{
							num = (short)380895233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
						IL_241:
						enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)160432128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F7:
						num = (short)1734934528;
						short num4 = num;
						num = (short)1432223747;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_29F:
					num = (short)2062876672;
					if (num != 0)
					{
					}
					return true;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00018640 File Offset: 0x00016840
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool IsPressed
		{
			get
			{
				short num = (short)1934094844;
				short num2 = num;
				num = (short)1024913916;
				switch (num2 == num)
				{
				}
				num = (short)206241792;
				short num3 = num;
				num = (short)2066939904;
				if (num != 0)
				{
				}
				num = (short)775028737;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPressedProperty);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000186F8 File Offset: 0x000168F8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000187B4 File Offset: 0x000169B4
		public global::DevComponents.WpfRibbon.eButtonRole Role
		{
			get
			{
				short num = (short)1374532544;
				short num2 = num;
				num = (short)429306816;
				switch (num2 == num)
				{
				}
				num = (short)953155584;
				short num3 = num;
				num = (short)619970560;
				if (num != 0)
				{
				}
				num = (short)1533870081;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eButtonRole)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.RoleProperty);
			}
			set
			{
				short num = (short)544072912;
				short num2 = num;
				num = (short)1881859280;
				switch (num2 == num)
				{
				}
				num = (short)925761536;
				short num3 = num;
				num = (short)1196097537;
				if (num != 0)
				{
				}
				num = (short)1763049472;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.RoleProperty, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0001886C File Offset: 0x00016A6C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00018924 File Offset: 0x00016B24
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageAndHeader)]
		public global::DevComponents.WpfRibbon.eButtonPartVisibility PartVisibility
		{
			get
			{
				short num = (short)375981378;
				short num2 = num;
				num = (short)750912834;
				switch (num2 == num)
				{
				}
				num = (short)1264844800;
				short num3 = num;
				num = (short)1863974913;
				if (num != 0)
				{
				}
				num = (short)1783365632;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eButtonPartVisibility)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PartVisibilityProperty);
			}
			set
			{
				short num = (short)1621666333;
				short num2 = num;
				num = (short)1534437917;
				switch (num2 == num)
				{
				}
				num = (short)1279459328;
				short num3 = num;
				num = (short)1955266561;
				if (num != 0)
				{
				}
				num = (short)2105409536;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PartVisibilityProperty, value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000189E0 File Offset: 0x00016BE0
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00018A98 File Offset: 0x00016C98
		public global::DevComponents.WpfRibbon.eDropDownType PopupType
		{
			get
			{
				short num = (short)1697055245;
				short num2 = num;
				num = (short)88211981;
				switch (num2 == num)
				{
				}
				num = (short)185008128;
				short num3 = num;
				num = (short)739377153;
				if (num != 0)
				{
				}
				num = (short)1687552000;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eDropDownType)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PopupTypeProperty);
			}
			set
			{
				short num = (short)1376159180;
				short num2 = num;
				num = (short)2026997196;
				switch (num2 == num)
				{
				}
				num = (short)1232928768;
				short num3 = num;
				num = (short)553320448;
				if (num != 0)
				{
				}
				num = (short)1974468609;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PopupTypeProperty, value);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00018B50 File Offset: 0x00016D50
		private static void OnPopupTypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1333459433;
			short num2 = num;
			num = (short)1392703977;
			switch (num2 == num)
			{
			}
			num = (short)1491009536;
			short num3 = num;
			num = (short)1305935873;
			if (num != 0)
			{
			}
			num = (short)2123104256;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).UpdatePopupTypeTemplate();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00018C08 File Offset: 0x00016E08
		private void UpdatePopupTypeTemplate()
		{
			int a_ = 14;
			short num = (short)572063746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.PopupType == global::DevComponents.WpfRibbon.eDropDownType.Popup)
					{
						goto IL_155;
					}
					goto IL_171;
				case 1:
					return;
				case 2:
					num = (short)716242945;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 3:
					goto IL_16E;
				}
				IL_66:
				if (this.m_PopupContentControl != null)
				{
					num = (short)305528832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1569607940;
				short num3 = num;
				num = (short)1836732676;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)323289088;
					short num4 = num;
					num = (short)1250623488;
					if (num != 0)
					{
					}
					num = (short)1840054273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_155:
				num = (short)1231421443;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_16E:
			this.m_PopupContentControl.Template = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥ݧᩩᥫṭ⑯ୱѳ፵⡷ᕹ౻୽솁ﲇ揄", a_))) as global::System.Windows.Controls.ControlTemplate);
			return;
			IL_171:
			this.m_PopupContentControl.Template = (base.FindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙥ݧᩩᥫṭ⑯ୱѳ፵㕷όቻ୽썿", a_))) as global::System.Windows.Controls.ControlTemplate);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00018DBC File Offset: 0x00016FBC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00018E78 File Offset: 0x00017078
		[global::System.ComponentModel.Browsable(false)]
		public global::DevComponents.WpfRibbon.ePopupPlacement PopupPlacement
		{
			get
			{
				short num = (short)458493070;
				short num2 = num;
				num = (short)1116671118;
				switch (num2 == num)
				{
				}
				num = (short)817037312;
				short num3 = num;
				num = (short)1362558976;
				if (num != 0)
				{
				}
				num = (short)1219231745;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.ePopupPlacement)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PopupPlacementProperty);
			}
			set
			{
				short num = (short)115677262;
				short num2 = num;
				num = (short)857610318;
				switch (num2 == num)
				{
				}
				num = (short)1236992000;
				short num3 = num;
				num = (short)1122959361;
				if (num != 0)
				{
				}
				num = (short)1783889920;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PopupPlacementProperty, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00018F34 File Offset: 0x00017134
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00018FF0 File Offset: 0x000171F0
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.UIElement PopupPlacementTarget
		{
			get
			{
				short num = (short)775778209;
				short num2 = num;
				num = (short)1704488865;
				switch (num2 == num)
				{
				}
				num = (short)2038497280;
				short num3 = num;
				num = (short)421789697;
				if (num != 0)
				{
				}
				num = (short)1854472192;
				if (num != 0)
				{
				}
				return (global::System.Windows.UIElement)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PopupPlacementTargetProperty);
			}
			set
			{
				short num = (short)1319396738;
				short num2 = num;
				num = (short)1167877506;
				switch (num2 == num)
				{
				}
				num = (short)255459328;
				short num3 = num;
				num = (short)769523712;
				if (num != 0)
				{
				}
				num = (short)1105133569;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.PopupPlacementTargetProperty, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000190A8 File Offset: 0x000172A8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00019160 File Offset: 0x00017360
		public bool IsSimpleHeader
		{
			get
			{
				short num = (short)1081218003;
				short num2 = num;
				num = (short)548017107;
				switch (num2 == num)
				{
				}
				num = (short)873070592;
				short num3 = num;
				num = (short)81788928;
				if (num != 0)
				{
				}
				num = (short)565903361;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsSimpleHeaderProperty);
			}
			internal set
			{
				short num = (short)786859277;
				short num2 = num;
				num = (short)85493005;
				switch (num2 == num)
				{
				}
				num = (short)1686568960;
				short num3 = num;
				num = (short)1871970304;
				if (num != 0)
				{
				}
				num = (short)944963585;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsSimpleHeaderPropertyKey, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0001921C File Offset: 0x0001741C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000192D8 File Offset: 0x000174D8
		public bool IsNestedMenu
		{
			get
			{
				short num = (short)192067659;
				short num2 = num;
				num = (short)1412282443;
				switch (num2 == num)
				{
				}
				num = (short)1173487616;
				short num3 = num;
				num = (short)1762852865;
				if (num != 0)
				{
				}
				num = (short)557711360;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsNestedMenuProperty);
			}
			set
			{
				short num = (short)1270611319;
				short num2 = num;
				num = (short)1458175351;
				switch (num2 == num)
				{
				}
				num = (short)1225326592;
				short num3 = num;
				num = (short)1665007616;
				if (num != 0)
				{
				}
				num = (short)1726480385;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsNestedMenuProperty, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00019394 File Offset: 0x00017594
		public global::System.Windows.Visibility IsExpandVisible
		{
			get
			{
				short num = (short)1923350529;
				if (num != 0)
				{
				}
				num = (short)1966028585;
				short num2 = num;
				num = (short)1102198569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)371326976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963117056;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisibleProperty);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00019450 File Offset: 0x00017650
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00019504 File Offset: 0x00017704
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eExpandVisibility.Auto)]
		public global::DevComponents.WpfRibbon.eExpandVisibility ExpandVisibility
		{
			get
			{
				short num = (short)717029377;
				if (num != 0)
				{
				}
				num = (short)780073586;
				short num2 = num;
				num = (short)355596914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701052416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)711786496;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eExpandVisibility)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ExpandVisibilityProperty);
			}
			set
			{
				short num = (short)1124728833;
				if (num != 0)
				{
				}
				num = (short)2037277732;
				short num2 = num;
				num = (short)69755940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990000640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1585315840;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ExpandVisibilityProperty, value);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000195BC File Offset: 0x000177BC
		private static void OnExpandPositionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num;
			int num3;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					num = (short)703528960;
					short num2 = num;
					num = (short)1729953793;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						buttonDropDown.UpdateExpandVisibility();
						num = (short)877789186;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (buttonDropDown.IsSimpleHeader)
						{
							num = (short)262799360;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_CB;
					}
					goto IL_6E;
				}
				IL_CB:
				num = (short)191542660;
				short num4 = num;
				num = (short)1844295044;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_75;
				default:
					num = (short)1815543808;
					if (num != 0)
					{
					}
					break;
				}
				return;
			}
			}
			IL_6E:
			buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)d;
			IL_75:
			num = (short)665976833;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000196E4 File Offset: 0x000178E4
		private static void OnExpandVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1723398190;
			short num2 = num;
			num = (short)641005614;
			switch (num2 == num)
			{
			}
			num = (short)740032512;
			short num3 = num;
			num = (short)1042939905;
			if (num != 0)
			{
			}
			num = (short)1439170560;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).UpdateExpandVisibility();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00019798 File Offset: 0x00017998
		private static void OnInlineExpandChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)279386405;
			short num2 = num;
			num = (short)1289099557;
			switch (num2 == num)
			{
			}
			num = (short)935657472;
			short num3 = num;
			num = (short)1644560385;
			if (num != 0)
			{
			}
			num = (short)1448017920;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).UpdateExpandVisibility();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001984C File Offset: 0x00017A4C
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)254516561;
			short num2 = num;
			num = (short)1727372625;
			switch (num2 == num)
			{
			}
			num = (short)261029888;
			short num3 = num;
			num = (short)89915393;
			if (num != 0)
			{
			}
			num = (short)1405157376;
			if (num != 0)
			{
			}
			this.UpdateExpandVisibility();
			base.OnItemsChanged(e);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00019904 File Offset: 0x00017B04
		private bool IsUsingInlineExpand
		{
			get
			{
				short num = (short)517603328;
				short num2 = num;
				num = (short)1496449028;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_F4;
					case 1:
					{
						num = (short)209397593;
						short num4 = num;
						num = (short)496510809;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_178;
						default:
							num = (short)1963786240;
							if (num != 0)
							{
							}
							num = (short)1929969669;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_178;
					case 3:
						if (this.m_ButtonExpandInline != null)
						{
							num = (short)1361772544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 5:
						if (this.InlineExpand)
						{
							num = (short)1607663618;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_66:
					num = (short)1724973057;
					if (num != 0)
					{
					}
					if (this.IsSimpleHeader)
					{
						num = (short)2026110977;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_178:
					num = (short)1507917827;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F4:
				return this.ExpandPosition == global::DevComponents.WpfRibbon.eExpandPosition.Bottom;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00019A90 File Offset: 0x00017C90
		private void UpdateInlineExpandParent()
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			int num;
			short num2;
			global::System.Windows.Controls.TextBlock textBlock2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.m_AccessText != null)
					{
						num2 = (short)793247755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					global::System.Windows.Controls.TextBlock textBlock = null;
					global::System.Reflection.PropertyInfo property = this.m_AccessText.GetType().GetProperty(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅤɦᅨὪ⽬ͮṰၲṴ", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					num2 = (short)1148780562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::System.Reflection.PropertyInfo property;
					global::System.Windows.Controls.TextBlock textBlock = property.GetValue(this.m_AccessText, null) as global::System.Windows.Controls.TextBlock;
					num2 = (short)445448206;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1683488785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.m_ButtonExpandInline.Parent is global::System.Windows.Documents.InlineUIContainer)
					{
						num2 = (short)763363331;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CA;
				case 5:
					goto IL_1CA;
				case 6:
					num2 = (short)1073479684;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1E1;
				case 8:
					if (textBlock2 != null)
					{
						num2 = (short)2103967745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					goto IL_1CA;
				case 10:
				{
					global::System.Windows.Controls.TextBlock textBlock;
					textBlock.Inlines.Add(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer);
					num2 = (short)1953431564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
					num2 = (short)1088749581;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					return;
				case 13:
					num2 = (short)2038169601;
					if (num2 != 0)
					{
					}
					if (this.IsSimpleHeader)
					{
						num2 = (short)427360272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 14:
				{
					global::System.Windows.Controls.TextBlock textBlock;
					if (textBlock != null)
					{
						num2 = (short)1600847878;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 15:
					textBlock2.Inlines.Remove(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer);
					num2 = (short)409010185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					num2 = (short)2076377088;
					short num3 = num2;
					num2 = (short)1979843641;
					short num4 = num2;
					num2 = (short)1324745785;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E1;
					default:
						num2 = (short)1798176768;
						if (num2 != 0)
						{
						}
						num2 = (short)667877384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 17:
					if (textBlock2.Inlines.Contains(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer))
					{
						num2 = (short)896466959;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer).Child = null;
					new global::System.Windows.Documents.InlineUIContainer().Child = this.m_ButtonExpandInline;
					num2 = (short)86245381;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
				{
					global::System.Reflection.PropertyInfo property;
					if (property != null)
					{
						num2 = (short)722731010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_65;
				IL_1CA:
				num2 = (short)110624775;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E1:
				if (this.m_ButtonExpandInline.Parent == null)
				{
					break;
				}
				num2 = (short)2050031626;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_65:
			textBlock2 = (this.m_ButtonContent as global::System.Windows.Controls.TextBlock);
			num2 = (short)1329070080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00019EA0 File Offset: 0x000180A0
		private void AccessTextSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			short num = (short)1309958835;
			short num2 = num;
			num = (short)792158899;
			switch (num2 == num)
			{
			}
			num = (short)1260453888;
			short num3 = num;
			num = (short)91750400;
			if (num != 0)
			{
			}
			num = (short)247201793;
			if (num != 0)
			{
			}
			this.UpdateInlineExpandParent();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00019F50 File Offset: 0x00018150
		private void SetInlineExpandVisibility(global::System.Windows.Visibility v)
		{
			int a_ = 3;
			for (;;)
			{
				IL_09:
				short num = (short)1244987392;
				switch (num)
				{
				default:
				{
					num = (short)1097662470;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.Controls.TextBlock textBlock;
						switch (num2)
						{
						case 0:
							textBlock.Inlines.Remove(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer);
							(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer).Child = null;
							num = (short)1991311377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)525139970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (this.IsSimpleHeader)
							{
								num = (short)1792213014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							num = (short)1256783895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (textBlock != null)
							{
								num = (short)1118437376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 5:
						{
							num = (short)1104116615;
							short num3 = num;
							num = (short)181042055;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							case 1:
								break;
							default:
							{
								num = (short)1848377344;
								short num4 = num;
								break;
							}
							}
							num = (short)1892679680;
							if (num != 0)
							{
							}
							global::System.Windows.Controls.TextBlock textBlock2;
							textBlock2.Inlines.Add(this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer);
							num = (short)1492516882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							continue;
						case 7:
						{
							global::System.Windows.Documents.InlineUIContainer inlineUIContainer;
							textBlock.Inlines.Remove(inlineUIContainer);
							num = (short)358809620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							num = (short)1317535748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (this.m_ButtonExpandInline.Parent is global::System.Windows.Documents.InlineUIContainer)
							{
								num = (short)288227336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 10:
						{
							global::System.Windows.Controls.TextBlock textBlock2;
							global::System.Windows.Documents.InlineUIContainer inlineUIContainer;
							if (!textBlock2.Inlines.Contains(inlineUIContainer))
							{
								num = (short)1869217797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DF;
						}
						case 11:
						{
							global::System.Windows.Documents.InlineUIContainer inlineUIContainer;
							if (textBlock.Inlines.Contains(inlineUIContainer))
							{
								num = (short)1265303559;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_115;
						}
						case 12:
						{
							global::System.Reflection.PropertyInfo property;
							global::System.Windows.Controls.TextBlock textBlock2 = property.GetValue(this.m_AccessText, null) as global::System.Windows.Controls.TextBlock;
							num = (short)1527513109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::System.Windows.Documents.InlineUIContainer inlineUIContainer;
							if (inlineUIContainer == null)
							{
								num = (short)621936664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_231;
						}
						case 14:
							goto IL_231;
						case 15:
							if (v == global::System.Windows.Visibility.Visible)
							{
								num = (short)1795162115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)590610441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							return;
						case 17:
							goto IL_334;
						case 18:
							goto IL_110;
						case 19:
						{
							num = (short)253427713;
							if (num != 0)
							{
							}
							global::System.Reflection.PropertyInfo property;
							if (property != null)
							{
								num = (short)1409417228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 20:
							goto IL_115;
						case 21:
						{
							global::System.Windows.Controls.TextBlock textBlock2;
							if (textBlock2 != null)
							{
								num = (short)1535180825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 22:
						{
							global::System.Windows.Controls.TextBlock textBlock2 = null;
							global::System.Reflection.PropertyInfo property = this.m_AccessText.GetType().GetProperty(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཚ㡜❞ᕠⅢ।ࡦ੨j", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
							num = (short)233046035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if (this.m_AccessText != null)
							{
								num = (short)371064833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 24:
						{
							global::System.Windows.Documents.InlineUIContainer inlineUIContainer = new global::System.Windows.Documents.InlineUIContainer();
							inlineUIContainer.Child = this.m_ButtonExpandInline;
							num = (short)1792147470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
						{
							global::System.Windows.Documents.InlineUIContainer inlineUIContainer = this.m_ButtonExpandInline.Parent as global::System.Windows.Documents.InlineUIContainer;
							num = (short)617807883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_B5:
						if (this.m_ButtonExpandInline == null)
						{
							num = (short)2060714000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.m_ButtonExpandInline.Visibility = v;
						textBlock = (this.m_ButtonContent as global::System.Windows.Controls.TextBlock);
						num = (short)849739791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_115:
						num = (short)427032589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_231:
						num = (short)1646985226;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			return;
			IL_110:
			goto IL_3DF;
			IL_334:
			return;
			IL_3DF:
			this.m_AccessText.SizeChanged += this.AccessTextSizeChanged;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001A4BC File Offset: 0x000186BC
		private void UpdateExpandVisibility()
		{
			short num = (short)190447636;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.m_ButtonExpandInline != null)
					{
						num = (short)2034892819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46B;
				case 1:
					base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey, global::System.Windows.Visibility.Collapsed);
					num = (short)146538520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.IsExpandVisible == global::System.Windows.Visibility.Visible)
					{
						num = (short)808255489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_2E4;
				case 4:
					goto IL_425;
				case 5:
					num = (short)1748500481;
					if (num != 0)
					{
					}
					if (this.ExpandVisibility == global::DevComponents.WpfRibbon.eExpandVisibility.Visible)
					{
						num = (short)1071513628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E9;
				case 6:
					goto IL_578;
				case 7:
					if (this.IsUsingInlineExpand)
					{
						num = (short)1104674833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2050162688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.HasVisibleItems)
					{
						num = (short)1832386573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1409875979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1851064346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_46B;
				case 11:
					if (this.IsExpandVisible == global::System.Windows.Visibility.Visible)
					{
						num = (short)806158336;
						short num3 = num;
						num = (short)64159748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (this.ExpandVisibility == global::DevComponents.WpfRibbon.eExpandVisibility.Hidden)
					{
						num = (short)1303576590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)629538841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1001324560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_2A4;
				case 15:
					if (this.ExpandVisibility == global::DevComponents.WpfRibbon.eExpandVisibility.Hidden)
					{
						num = (short)934346773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					if (this.IsExpandVisible != global::System.Windows.Visibility.Visible)
					{
						num = (short)482082819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 17:
					base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey, global::System.Windows.Visibility.Collapsed);
					num = (short)324272140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey, global::System.Windows.Visibility.Collapsed);
					num = (short)631570455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.m_ButtonExpandInline.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1446248458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 21:
					num = (short)207486978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_466;
				case 23:
					if (this.HasVisibleItems)
					{
						num = (short)1589248006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A9;
				case 24:
					goto IL_351;
				case 25:
					if (this.ExpandVisibility == global::DevComponents.WpfRibbon.eExpandVisibility.Visible)
					{
						num = (short)1070071837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 26:
				{
					if (this.IsUsingInlineExpand)
					{
						num = (short)385482770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.SetInlineExpandVisibility(global::System.Windows.Visibility.Collapsed);
					num = (short)1130457432;
					short num4 = num;
					num = (short)1561291096;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51F;
					default:
						num = (short)667353088;
						if (num != 0)
						{
						}
						num = (short)1863516168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 27:
					if (this.IsExpandVisible != global::System.Windows.Visibility.Visible)
					{
						num = (short)316211222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E9;
				case 28:
					num = (short)1040121883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_129;
				}
				IL_9D:
				if (this.ExpandVisibility == global::DevComponents.WpfRibbon.eExpandVisibility.Auto)
				{
					num = (short)783613961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)923729927;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E9:
				num = (short)1297612815;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46B:
				num = (short)512688133;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_129:
			goto IL_51F;
			IL_2A4:
			this.m_ButtonExpandInline.Visibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_2E4:
			base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey, global::System.Windows.Visibility.Visible);
			return;
			IL_351:
			return;
			IL_3A9:
			this.SetInlineExpandVisibility(global::System.Windows.Visibility.Collapsed);
			return;
			IL_425:
			base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey, global::System.Windows.Visibility.Collapsed);
			return;
			IL_466:
			base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsExpandVisiblePropertyKey, global::System.Windows.Visibility.Visible);
			return;
			IL_51F:
			this.m_ButtonExpandInline.Visibility = global::System.Windows.Visibility.Visible;
			return;
			IL_578:
			this.SetInlineExpandVisibility(global::System.Windows.Visibility.Visible);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0001AA48 File Offset: 0x00018C48
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0001AB00 File Offset: 0x00018D00
		internal bool IsSelected
		{
			get
			{
				short num = (short)873668199;
				short num2 = num;
				num = (short)818355815;
				switch (num2 == num)
				{
				}
				num = (short)1831272448;
				if (num != 0)
				{
				}
				num = (short)1797586945;
				if (num != 0)
				{
				}
				num = (short)1015808000;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsSelectedProperty);
			}
			set
			{
				short num = (short)878786463;
				short num2 = num;
				num = (short)367933343;
				switch (num2 == num)
				{
				}
				num = (short)1860829184;
				if (num != 0)
				{
				}
				num = (short)328728577;
				if (num != 0)
				{
				}
				num = (short)1321271296;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsSelectedProperty, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0001ABBC File Offset: 0x00018DBC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0001AC74 File Offset: 0x00018E74
		public bool ContentExpands
		{
			get
			{
				short num = (short)56066655;
				short num2 = num;
				num = (short)927564383;
				switch (num2 == num)
				{
				}
				num = (short)1863319553;
				if (num != 0)
				{
				}
				num = (short)985137152;
				if (num != 0)
				{
				}
				num = (short)1580990464;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ContentExpandsProperty);
			}
			set
			{
				short num = (short)867361050;
				short num2 = num;
				num = (short)1072029978;
				switch (num2 == num)
				{
				}
				num = (short)1935802369;
				if (num != 0)
				{
				}
				num = (short)107085824;
				if (num != 0)
				{
				}
				num = (short)319422464;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ContentExpandsProperty, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0001AD2C File Offset: 0x00018F2C
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.Primitives.Popup Popup
		{
			get
			{
				short num = (short)1003457257;
				short num2 = num;
				num = (short)1324190441;
				switch (num2 == num)
				{
				}
				num = (short)1415380992;
				if (num != 0)
				{
				}
				num = (short)521076737;
				if (num != 0)
				{
				}
				num = (short)640614400;
				short num3 = num;
				return this.m_Popup;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0001ADDC File Offset: 0x00018FDC
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0001AE90 File Offset: 0x00019090
		protected global::DevComponents.WpfRibbon.ButtonDropDown HighlightedChild
		{
			get
			{
				short num = (short)1319113292;
				short num2 = num;
				num = (short)1845105228;
				switch (num2 == num)
				{
				}
				num = (short)1217658881;
				if (num != 0)
				{
				}
				num = (short)125763584;
				if (num != 0)
				{
				}
				num = (short)1738801152;
				short num3 = num;
				return this.m_HighlightedChild;
			}
			set
			{
				short num = (short)371064837;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)499112544;
						short num3 = num;
						num = (short)1103288928;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1463943168;
							if (num != 0)
							{
							}
							this.m_HighlightedChild.IsSelected = false;
							num = (short)257425409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1750728705;
						if (num != 0)
						{
						}
						goto IL_FE;
					case 2:
						return;
					case 3:
						if (this.m_HighlightedChild != null)
						{
							num = (short)927006724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.m_HighlightedChild.IsSelected = true;
						num = (short)689504258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1698627584;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					}
					}
					IL_68:
					if (this.m_HighlightedChild != null)
					{
						num = (short)1409482752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FE:
					this.m_HighlightedChild = value;
					num = (short)420282371;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001B02C File Offset: 0x0001922C
		private static void OnIsHighlightedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1754904281;
			short num2 = num;
			num = (short)360822489;
			switch (num2 == num)
			{
			}
			num = (short)1198522369;
			if (num != 0)
			{
			}
			num = (short)833814528;
			if (num != 0)
			{
			}
			num = (short)1424228352;
			short num3 = num;
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).OnIsHighlightedChanged();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001B0E4 File Offset: 0x000192E4
		private void OnIsHighlightedChanged()
		{
			short num = (short)1445106280;
			short num2 = num;
			num = (short)1767281256;
			switch (num2 == num)
			{
			}
			num = (short)1951203329;
			if (num != 0)
			{
			}
			num = (short)1468334080;
			if (num != 0)
			{
			}
			num = (short)1262026752;
			short num3 = num;
			this.UpdateBorderRenderState();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001B194 File Offset: 0x00019394
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)402360495;
			short num2 = num;
			num = (short)994216111;
			switch (num2 == num)
			{
			}
			num = (short)1069744129;
			if (num != 0)
			{
			}
			num = (short)1127350272;
			if (num != 0)
			{
			}
			num = (short)1246363648;
			short num3 = num;
			base.OnGotKeyboardFocus(e);
			this.UpdateBorderRenderState();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001B24C File Offset: 0x0001944C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1220673546;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!(((global::System.Windows.Controls.ContextMenu)global::System.Windows.Input.Keyboard.FocusedElement).Name == global::DevComponents.WpfRibbon.Ribbon.SysQatCustomizeContextMenu))
					{
						num2 = (short)1954086912;
						short num3 = num2;
						num2 = (short)940507148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_364;
				case 2:
				{
					num2 = (short)1028672906;
					short num4 = num2;
					num2 = (short)1016679818;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						num2 = (short)1132593152;
						if (num2 != 0)
						{
						}
						num2 = (short)2123956240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (this.GetParent() is global::DevComponents.WpfRibbon.IPopupParentControl)
					{
						num2 = (short)2070347785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_364;
				case 4:
					if (!this.FocusChangeKeepsPopupOpen)
					{
						num2 = (short)1625686016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_364;
				case 5:
					if (!(bool)e.NewValue)
					{
						num2 = (short)922746882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_364;
				case 6:
					goto IL_A0;
				case 7:
					num2 = (short)36896769;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (this.GetParent() is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num2 = (short)666042381;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1228537859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1238827013;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (global::System.Windows.Input.FocusManager.GetFocusedElement(this) == null)
					{
						num2 = (short)14548998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_364;
				case 11:
					num2 = (short)1622867972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_277;
				case 13:
					this.IsSelected = (bool)e.NewValue;
					num2 = (short)509083662;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_20B;
				case 15:
					goto IL_295;
				case 16:
					if (this.IsPopupOpen)
					{
						num2 = (short)994312203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_364;
				case 17:
					if (global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.Controls.ContextMenu)
					{
						num2 = (short)1887174663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_277;
				}
				goto IL_58;
				IL_A0:
				num2 = (short)691732497;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_277:
				this.IsPopupOpen = false;
				num2 = (short)381419535;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_20B:
			num2 = (short)1485701121;
			if (num2 != 0)
			{
			}
			IL_295:
			IL_364:
			this.UpdateBorderRenderState();
			return;
			IL_58:
			base.OnIsKeyboardFocusWithinChanged(e);
			num2 = (short)500629512;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001B5C4 File Offset: 0x000197C4
		protected virtual void UpdateKeyTipsState()
		{
			short num = (short)400359424;
			switch (num)
			{
			default:
			{
				num = (short)312213529;
				int num2 = (int)((global::System.IntPtr)num);
				bool showKeyTips;
				for (;;)
				{
					global::DevComponents.WpfRibbon.Ribbon parentRibbon;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.UIElement keyTipsParent;
						(keyTipsParent as global::DevComponents.WpfRibbon.ButtonDropDown).ShowKeyTips = true;
						num = (short)2087518220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.UIElement keyTipsParent2;
						global::DevComponents.WpfRibbon.Ribbon ribbon = keyTipsParent2 as global::DevComponents.WpfRibbon.Ribbon;
						num = (short)1605304351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_32C;
					case 3:
					{
						global::System.Windows.UIElement keyTipsParent2;
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab = keyTipsParent2 as global::DevComponents.WpfRibbon.RibbonTab;
						num = (short)183369733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)2087125018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
						if (ribbonTab.ParentRibbon != null)
						{
							num = (short)607846404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					}
					case 6:
					{
						global::System.Windows.UIElement keyTipsParent2;
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = keyTipsParent2 as global::DevComponents.WpfRibbon.ButtonDropDown;
						num = (short)1466630177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Windows.UIElement keyTipsParent;
						if (keyTipsParent is global::DevComponents.WpfRibbon.RibbonTab)
						{
							num = (short)1935802383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)658178064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Windows.UIElement keyTipsParent2 = this.GetKeyTipsParent();
						num = (short)1005649941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.UIElement keyTipsParent2;
						if (keyTipsParent2 is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)1543372806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					}
					case 10:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						ribbon.ShowKeyTips = false;
						showKeyTips = true;
						num = (short)1558839298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.UIElement keyTipsParent;
						if (keyTipsParent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)1394540544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E6;
					}
					case 12:
						goto IL_2E6;
					case 13:
						showKeyTips = false;
						num = (short)1845624851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_122;
					case 15:
					{
						num = (short)1234501632;
						short num3 = num;
						global::System.Windows.UIElement keyTipsParent;
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab2 = keyTipsParent as global::DevComponents.WpfRibbon.RibbonTab;
						parentRibbon = ribbonTab2.ParentRibbon;
						num = (short)1866268686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Windows.UIElement keyTipsParent;
						if (keyTipsParent is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)711196704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1883897867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_305;
					case 18:
						goto IL_2E6;
					case 19:
					{
						global::System.Windows.UIElement keyTipsParent2;
						if (keyTipsParent2 is global::DevComponents.WpfRibbon.RibbonTab)
						{
							num = (short)1344339971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1365442583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)863487318;
						short num4 = num;
						num = (short)1316734294;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_122;
						default:
							num = (short)2110849024;
							if (num != 0)
							{
							}
							if (this.ShowKeyTips)
							{
								num = (short)1280245782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 21:
					{
						global::System.Windows.UIElement keyTipsParent2;
						if (keyTipsParent2 != null)
						{
							num = (short)246808589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 22:
					{
						global::System.Windows.UIElement keyTipsParent = this.GetKeyTipsParent();
						num = (short)1217527809;
						if (num != 0)
						{
						}
						num = (short)894697479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Windows.UIElement keyTipsParent2;
						if (keyTipsParent2 is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)601817089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1617494025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_261;
					case 25:
						switch (0)
						{
						case 0:
							goto IL_D0;
						}
						continue;
					case 26:
					{
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
						if (ribbonTab.ParentRibbon.KeyTipsVisible)
						{
							num = (short)174063645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					}
					case 27:
						goto IL_175;
					case 28:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						buttonDropDown.ShowKeyTips = false;
						showKeyTips = true;
						num = (short)1885405208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						showKeyTips = true;
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
						ribbonTab.ParentRibbon.ShowKeyTips = false;
						num = (short)250019867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						global::DevComponents.WpfRibbon.RibbonTab ribbonTab2;
						parentRibbon.ShowKeyTipsForContext(ribbonTab2);
						num = (short)1642528786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon.KeyTipsVisible)
						{
							num = (short)1690435594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					}
					case 32:
					{
						global::System.Windows.UIElement keyTipsParent;
						(keyTipsParent as global::DevComponents.WpfRibbon.Ribbon).ShowKeyTips = true;
						num = (short)630194210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown.ShowKeyTips)
						{
							num = (short)2105212956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					}
					case 34:
						goto IL_2E6;
					}
					IL_D0:
					if (this.IsPopupOpen)
					{
						num = (short)598999048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)516947988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_122:
					if (parentRibbon != null)
					{
						num = (short)861601822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2E6:
					this.ShowKeyTips = false;
					num = (short)1850015761;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				this.ShowKeyTips = showKeyTips;
				return;
				IL_175:
				IL_261:
				goto IL_146;
				IL_305:
				return;
				IL_32C:
				goto IL_146;
			}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001BC10 File Offset: 0x00019E10
		protected virtual void OnShowKeyTipsChanged()
		{
			short num = (short)332070912;
			switch (num)
			{
			default:
			{
				num = (short)611516431;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Documents.AdornerLayer adornerLayer2;
				for (;;)
				{
					IL_3C:
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.UIElement elementForAdorning = this.GetElementForAdorning();
						num = (short)1217527809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.UIElement elementForAdorning;
						while (elementForAdorning != null)
						{
							num = (short)95953096;
							short num3 = num;
							num = (short)1702371528;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)926941184;
								if (num != 0)
								{
								}
								num = (short)1742471176;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_3C;
							}
						}
						goto IL_2C7;
					}
					case 2:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer;
						if (adornerLayer != null)
						{
							num = (short)1795293195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
					}
					case 3:
						goto IL_2F2;
					case 4:
						goto IL_360;
					case 5:
						if (this.m_KeyTipsAdorner != null)
						{
							num = (short)1597636624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::System.Windows.UIElement elementForAdorning2;
						if (elementForAdorning2 != null)
						{
							num = (short)601292809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
					{
						global::System.Windows.UIElement elementForAdorning2 = this.GetElementForAdorning();
						num = (short)318963713;
						if (num != 0)
						{
						}
						num = (short)1663434758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Windows.UIElement elementForAdorning;
						global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(elementForAdorning);
						num = (short)532742146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.UIElement elementForAdorning2;
						this.m_KeyTipsAdorner = new global::DevComponents.WpfRibbon.KeyTipsAdorner(elementForAdorning2);
						adornerLayer2 = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(elementForAdorning2);
						num = (short)1358495754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (adornerLayer2 != null)
						{
							num = (short)1074855940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer;
						adornerLayer.Remove(this.m_KeyTipsAdorner);
						num = (short)1522794508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2C7;
					case 13:
						if (this.m_Popup != null)
						{
							num = (short)1791361024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
					{
						num = (short)256704512;
						short num4 = num;
						this.m_ShowKeyTips = false;
						num = (short)579534865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 16:
						num = (short)1836056589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.m_Popup != null)
						{
							num = (short)237371399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_8B:
					if (this.m_ShowKeyTips)
					{
						num = (short)419102734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)465108997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C7:
					this.m_KeyTipsAdorner.ContextObject = null;
					this.m_KeyTipsAdorner = null;
					num = (short)65077251;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F2:
				return;
				IL_360:
				adornerLayer2.Add(this.m_KeyTipsAdorner);
				this.m_KeyTipsAdorner.ContextObject = this;
				this.m_ShowKeyTips = true;
				return;
			}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0001C070 File Offset: 0x0001A270
		internal bool ShowKeyTips
		{
			get
			{
				short num = (short)1096590673;
				short num2 = num;
				num = (short)1268294993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)175374336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330446336;
				if (num != 0)
				{
				}
				num = (short)1477967873;
				if (num != 0)
				{
				}
				return this.m_ShowKeyTips;
			}
			set
			{
				short num = (short)911671296;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)162398209;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 1:
					{
						num = (short)821324836;
						short num3 = num;
						num = (short)929131556;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_64;
						default:
							goto IL_FB;
						}
						break;
					}
					case 2:
					{
						this.m_ShowKeyTips = value;
						this.OnShowKeyTipsChanged();
						num = (short)1568210944;
						short num4 = num;
						num = (short)985137153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_58;
					IL_64:
					num = (short)168624130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58:
					if (this.m_ShowKeyTips != value)
					{
						goto IL_64;
					}
					return;
				}
				IL_FB:
				num = (short)735117312;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001C190 File Offset: 0x0001A390
		protected virtual global::System.Windows.UIElement GetElementForAdorning()
		{
			short num;
			global::System.Windows.UIElement result;
			for (;;)
			{
				num = (short)1950875648;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1889992705;
					if (num != 0)
					{
					}
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					try
					{
						num = (short)153944070;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								object obj;
								result = (obj as global::System.Windows.UIElement);
								num = (short)2074476546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								object obj;
								if (obj is global::System.Windows.UIElement)
								{
									num = (short)162005000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_13D;
							case 3:
								num = (short)660013063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)924188675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								num = (short)1361510401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								object obj;
								if (((global::System.Windows.UIElement)obj).Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)100401152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_A2;
								}
								continue;
							case 7:
								goto IL_19E;
							case 8:
								num = (short)59899909;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A4:
							num = (short)1927544836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A2:
							goto IL_A4;
						}
						IL_13D:
						goto IL_214;
						IL_19E:
						goto IL_55;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1C0;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1AD:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)62062594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_213;
							case 1:
								goto IL_211;
							case 2:
								disposable.Dispose();
								num = (short)217710593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C0;
						}
						IL_211:
						IL_213:
						goto EndFinally_6;
						IL_1C0:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)33751040;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1AD;
						EndFinally_6:;
					}
					IL_214:
					num = (short)856073519;
					short num3 = num;
					num = (short)857842991;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_24A;
					}
					break;
				}
				}
			}
			IL_55:
			return null;
			IL_24A:
			num = (short)816709632;
			short num4 = num;
			num = (short)438108160;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001C444 File Offset: 0x0001A644
		private global::System.Windows.UIElement GetKeyTipsParent()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.Windows.DependencyObject parent;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)69992448;
					short num3 = num2;
					goto IL_168;
				}
				case 1:
					num2 = (short)1895956481;
					if (num2 != 0)
					{
					}
					if (parent is global::DevComponents.WpfRibbon.Ribbon)
					{
						num2 = (short)312868874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1302593538;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (parent is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num2 = (short)965935110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)473169925;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_15C;
				case 4:
				{
					num2 = (short)1619980739;
					short num4 = num2;
					num2 = (short)1556541891;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)2074017792;
						if (num2 != 0)
						{
						}
						if (parent == null)
						{
							num2 = (short)118030344;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_121;
					}
					break;
				}
				case 5:
					if (parent != null)
					{
						num2 = (short)579731463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_168;
				case 6:
					goto IL_CD;
				case 7:
					parent = global::System.Windows.LogicalTreeHelper.GetParent(parent);
					num2 = (short)1334378496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1E8;
				case 9:
					goto IL_121;
				case 10:
					goto IL_252;
				case 11:
					if (parent is global::DevComponents.WpfRibbon.RibbonTab)
					{
						num2 = (short)165543939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)304611329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_121:
				num2 = (short)622854155;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_168:
				num2 = (short)1254817796;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_CD:
			return parent as global::System.Windows.UIElement;
			IL_15C:
			return parent as global::System.Windows.UIElement;
			IL_1E8:
			return null;
			IL_252:
			return parent as global::System.Windows.UIElement;
			IL_40:
			parent = base.Parent;
			num2 = (short)460914697;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)116834899;
			short num2 = num;
			num = (short)239452755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)950599680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1145896961;
			if (num != 0)
			{
			}
			num = (short)940441600;
			if (num != 0)
			{
			}
			base.OnLostFocus(e);
			this.UpdateBorderRenderState();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001C760 File Offset: 0x0001A960
		private static void OnIsPopupOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1232672743;
			short num2 = num;
			num = (short)1837438951;
			switch (num2 == num)
			{
			default:
			{
				num = (short)978321408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)306446337;
			if (num != 0)
			{
			}
			num = (short)1995177984;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)d;
			bool oldValue = (bool)e.OldValue;
			bool newValue = (bool)e.NewValue;
			buttonDropDown.OnIsPopupOpenChanged(oldValue, newValue);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001C830 File Offset: 0x0001AA30
		protected virtual void OnIsPopupOpenChanged(bool oldValue, bool newValue)
		{
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ButtonDropDownAutomationPeer buttonDropDownAutomationPeer;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.HighlightedChild != null)
						{
							num2 = (short)963641346;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)488243221;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_47A;
					case 2:
						num2 = (short)1055653905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_1D2;
					case 4:
						goto IL_20D;
					case 5:
						buttonDropDownAutomationPeer.ResetChildrenCache();
						buttonDropDownAutomationPeer.RaiseExpandCollapseAutomationEvent(oldValue, newValue);
						num2 = (short)1397161987;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (this.HighlightedChild != null)
						{
							num2 = (short)768475151;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_20D;
					case 7:
						if (!(base.Parent is global::DevComponents.WpfRibbon.ButtonEx))
						{
							num2 = (short)1368784916;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_52B;
					case 8:
						this.OnPopupClosed(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent, this));
						num2 = (short)1134559248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
						this.IsSelected = true;
						this.HighlightedChild = null;
						this.SetPopupMode(true);
						this.UpdatePopupPlacement();
						this.OnPopupOpened(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.PopupOpenedEvent, this));
						num2 = (short)10616833;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						num2 = (short)1398538254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						if (newValue)
						{
							num2 = (short)726728713;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)298844160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						goto IL_3E1;
					case 13:
						if (this.m_Popup == null)
						{
							num2 = (short)767164424;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_18D;
					case 14:
						if (this.GetParent() is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num2 = (short)1353252891;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_20D;
					case 15:
						num2 = (short)1173159964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 16:
						goto IL_18D;
					case 17:
						if (this.HighlightedChild.IsKeyboardFocusWithin)
						{
							num2 = (short)160890899;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_47F;
					case 18:
						goto IL_47F;
					case 19:
						base.Focus();
						num2 = (short)2066939922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 20:
						this.SetPopupMode(false);
						num2 = (short)1741488140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 21:
						if (base.IsKeyboardFocusWithin)
						{
							num2 = (short)1994784778;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_20D;
					case 22:
						if (this.GetParent() is global::DevComponents.WpfRibbon.IPopupParentControl)
						{
							num2 = (short)613548056;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_52B;
					case 23:
						this.HighlightedChild.IsPopupOpen = false;
						num2 = (short)1169227780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 24:
						num2 = (short)444727303;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 25:
						goto IL_20D;
					case 26:
						if (buttonDropDownAutomationPeer != null)
						{
							num2 = (short)634585093;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1D2;
					case 27:
						((global::DevComponents.WpfRibbon.ButtonDropDown)this.GetParent()).Focus();
						num2 = (short)941686809;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 28:
					{
						if (!this.HighlightedChild.IsPopupOpen)
						{
							goto IL_20D;
						}
						num2 = (short)1431463349;
						short num3 = num2;
						num2 = (short)952788405;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A8;
						default:
							num2 = (short)1045233664;
							if (num2 != 0)
							{
							}
							num2 = (short)74186775;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_84;
					IL_18D:
					num2 = (short)1195638806;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1D2:
					num2 = (short)776208395;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_20D:
					this.HighlightedChild = null;
					num2 = (short)1766457344;
					short num4 = num2;
					num2 = (short)2098135053;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_47F:
					num2 = (short)936640518;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_3E1:
				IL_47A:
				IL_52B:
				num2 = (short)1759248385;
				if (num2 != 0)
				{
				}
				base.CoerceValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty);
				this.UpdateBorderRenderState();
				this.UpdateInactiveButtonPart();
				return;
			}
			IL_84:
			this.StopTimer(ref this.m_DelayPopupOpenTimer);
			this.StopTimer(ref this.m_DelayPopupCloseTimer);
			buttonDropDownAutomationPeer = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::DevComponents.WpfRibbon.ButtonDropDownAutomationPeer);
			IL_A8:
			num2 = (short)1901854746;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
		protected virtual void UpdatePopupPlacement()
		{
			int a_ = 18;
			short num = (short)1047003140;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
				global::System.Windows.UIElement uielement;
				switch (num2)
				{
				case 0:
					if (applicationMenu.HasMruItems)
					{
						num = (short)936312840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 1:
					num = (short)236781568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (uielement != null)
					{
						num = (short)1046282241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 3:
					if (((global::DevComponents.WpfRibbon.ApplicationMenu)base.Parent).Items.Contains(this))
					{
						num = (short)91160583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 5:
				{
					num = (short)1400897537;
					if (num != 0)
					{
					}
					num = (short)774494736;
					short num3 = num;
					num = (short)53664272;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D6;
					default:
						num = (short)1948057600;
						if (num != 0)
						{
						}
						num = (short)1312751619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_265;
				case 7:
					goto IL_1D6;
				case 8:
					this.m_Popup.PlacementTarget = uielement;
					this.m_Popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
					this.m_Popup.Width = uielement.RenderSize.Width + 2.0;
					this.m_Popup.Height = uielement.RenderSize.Height + 3.0;
					this.m_Popup.HorizontalOffset = 1.0;
					num = (short)1903820806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				if (base.Parent is global::DevComponents.WpfRibbon.ApplicationMenu)
				{
					num = (short)508297221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D6:
				applicationMenu = (base.Parent as global::DevComponents.WpfRibbon.ApplicationMenu);
				uielement = (applicationMenu.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❩ṫ᭭㉯ᵱٳትᵷࡹ", a_)) as global::System.Windows.UIElement);
				num = (short)521142274;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_265:
			IL_267:
			num = (short)1387266048;
			short num4 = num;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001D044 File Offset: 0x0001B244
		private static void OnParentControlIsSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			short num = (short)598999056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2;
				switch (num2)
				{
				case 0:
					if (buttonDropDown.HighlightedChild == buttonDropDown2)
					{
						num = (short)1030488069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FD;
				case 1:
					buttonDropDown.HighlightedChild.IsPopupOpen = false;
					num = (short)5963796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)381538768;
					short num3 = num;
					num = (short)1872941520;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2EB;
					default:
						num = (short)582156288;
						if (num != 0)
						{
						}
						if (buttonDropDown.HighlightedChild.IsPopupOpen)
						{
							num = (short)1396899841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					}
					break;
				}
				case 3:
					num = (short)1237647382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2023882754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2EB;
				case 6:
					if (buttonDropDown2.GetParent() == buttonDropDown)
					{
						num = (short)755433480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FD;
				case 7:
					buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)sender;
					buttonDropDown2 = (e.OriginalSource as global::DevComponents.WpfRibbon.ButtonDropDown);
					num = (short)1802567690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1124597772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1364787219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (buttonDropDown2 != null)
					{
						num = (short)209256451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_1FD;
				case 12:
					if (buttonDropDown.HighlightedChild != null)
					{
						num = (short)260177924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				case 13:
					buttonDropDown.StopTimer(ref buttonDropDown.m_DelayPopupCloseTimer);
					num = (short)114753553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1312423942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					return;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 17:
				{
					num = (short)1252392960;
					short num4 = num;
					goto IL_3C8;
				}
				case 18:
					num = (short)1932787713;
					if (num != 0)
					{
					}
					goto IL_1FD;
				case 19:
					if (buttonDropDown.HighlightedChild == buttonDropDown2)
					{
						num = (short)172883981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C8;
				case 20:
					goto IL_AB;
				case 21:
					if (buttonDropDown.HighlightedChild != buttonDropDown2)
					{
						num = (short)479920142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FD;
				case 22:
					if (e.NewValue)
					{
						num = (short)1984036873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1896677376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_81:
				if (sender != e.OriginalSource)
				{
					num = (short)1590951943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AB:
				buttonDropDown.HighlightedChild = buttonDropDown2;
				num = (short)1494351890;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FD:
				e.Handled = true;
				num = (short)776470543;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EB:
				buttonDropDown.HighlightedChild = null;
				num = (short)472186891;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C8:
				num = (short)1384120341;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001D45C File Offset: 0x0001B65C
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)925550918;
					short num3 = num2;
					num2 = (short)41339206;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D7;
					default:
						num2 = (short)473759744;
						if (num2 != 0)
						{
						}
						goto IL_A8;
					}
					break;
				}
				case 1:
					buttonDropDown.IsPopupOpen = false;
					num2 = (short)83492864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if ((bool)e.OldValue)
					{
						num2 = (short)952172547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B0;
				case 3:
				{
					num2 = (short)766574592;
					short num4 = num2;
					num2 = (short)954007556;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (buttonDropDown.IsPopupOpen)
					{
						num2 = (short)293404673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A8;
				case 5:
					goto IL_D7;
				}
				goto IL_28;
				IL_A8:
				buttonDropDown.StopTimer(ref buttonDropDown.m_DelayPopupOpenTimer);
				buttonDropDown.StopTimer(ref buttonDropDown.m_DelayPopupCloseTimer);
				num2 = (short)2096824325;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D7:
			num2 = (short)844431361;
			if (num2 != 0)
			{
			}
			IL_1B0:
			buttonDropDown.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<bool>((bool)e.OldValue, (bool)e.NewValue, global::DevComponents.WpfRibbon.BasePopupControl.IsSelectedChangedEvent));
			return;
			IL_28:
			buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)d;
			buttonDropDown.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedPropertyKey, e.NewValue);
			num2 = (short)1532690434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0001D644 File Offset: 0x0001B844
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0001D700 File Offset: 0x0001B900
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsPopupOpen
		{
			get
			{
				short num = (short)859576389;
				short num2 = num;
				num = (short)1842944069;
				switch (num2 == num)
				{
				}
				num = (short)1650917376;
				short num3 = num;
				num = (short)703070209;
				if (num != 0)
				{
				}
				num = (short)406388736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupOpenProperty);
			}
			set
			{
				short num = (short)1333589104;
				short num2 = num;
				num = (short)88274032;
				switch (num2 == num)
				{
				}
				num = (short)1824129024;
				short num3 = num;
				num = (short)792788992;
				if (num != 0)
				{
				}
				num = (short)170196993;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupOpenProperty, value);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001D7BC File Offset: 0x0001B9BC
		private static object CoerceIsPopupOpen(global::System.Windows.DependencyObject d, object value)
		{
			short num = (short)1230569473;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_113;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
				{
					if (buttonDropDown.IsLoaded)
					{
						goto IL_118;
					}
					num = (short)1737558290;
					short num3 = num;
					num = (short)880216338;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1475346432;
						if (num != 0)
						{
						}
						num = (short)1193213953;
						if (num != 0)
						{
						}
						num = (short)1460273152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)d;
					num = (short)1832386562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				if (!(bool)value)
				{
					goto IL_118;
				}
				num = (short)1914568707;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_113:
			buttonDropDown.RegisterToOpenOnLoad();
			return false;
			IL_118:
			num = (short)1665859584;
			short num4 = num;
			return value;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001D90C File Offset: 0x0001BB0C
		private void RegisterToOpenOnLoad()
		{
			short num = (short)1854142926;
			short num2 = num;
			num = (short)454687182;
			switch (num2 == num)
			{
			}
			num = (short)786694144;
			short num3 = num;
			num = (short)322699265;
			if (num != 0)
			{
			}
			num = (short)669974528;
			if (num != 0)
			{
			}
			base.Loaded += this.OpenOnLoad;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		private void OpenOnLoad(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)535272090;
			short num2 = num;
			num = (short)15637146;
			switch (num2 == num)
			{
			}
			num = (short)1504772096;
			short num3 = num;
			num = (short)1094647809;
			if (num != 0)
			{
			}
			num = (short)1401421824;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Windows.Threading.DispatcherOperationCallback(delegate(object param)
			{
				short num4 = (short)1744535245;
				short num5 = num4;
				num4 = (short)264601293;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)501678080;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)2141323265;
				if (num4 != 0)
				{
				}
				num4 = (short)791609344;
				if (num4 != 0)
				{
				}
				base.CoerceValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupOpenProperty);
				return null;
			}));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001DA88 File Offset: 0x0001BC88
		private static void OnPopupPlacementChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1741571966;
			short num2 = num;
			num = (short)1937196926;
			switch (num2 == num)
			{
			}
			num = (short)792395776;
			short num3 = num;
			num = (short)1394671617;
			if (num != 0)
			{
			}
			num = (short)539688960;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001DB34 File Offset: 0x0001BD34
		private static void OnIsCheckedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1627119081;
			short num2 = num;
			num = (short)822926825;
			switch (num2 == num)
			{
			}
			num = (short)1167851520;
			short num3 = num;
			num = (short)1174339585;
			if (num != 0)
			{
			}
			num = (short)2003107840;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).OnIsCheckedChanged(e);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001DBEC File Offset: 0x0001BDEC
		private void OnIsCheckedChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)436076545;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_122;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_7E;
				case 3:
				{
					this.OnChecked(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.CheckedEvent));
					this.UpdateOptionGroupState();
					num = (short)1895278051;
					short num3 = num;
					num = (short)107128291;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)890109953;
						if (num != 0)
						{
						}
						num = (short)937230336;
						if (num != 0)
						{
						}
						num = (short)329842688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_34:
				if ((bool)e.NewValue)
				{
					num = (short)1569587203;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.OnUnchecked(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.UncheckedEvent));
					num = (short)1302331394;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7E:
			IL_122:
			num = (short)1985085440;
			short num4 = num;
			this.UpdateBorderRenderState();
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0001DD4C File Offset: 0x0001BF4C
		private bool IsInOptionGroup
		{
			get
			{
				int num;
				string optionGroup;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_102;
						case 1:
							if (optionGroup != null)
							{
								num2 = (short)2123169795;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return false;
						case 2:
						{
							if (!(optionGroup == ""))
							{
								goto IL_107;
							}
							num2 = (short)491560793;
							short num3 = num2;
							num2 = (short)490970969;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27;
							default:
								num2 = (short)790691840;
								if (num2 != 0)
								{
								}
								num2 = (short)720437249;
								if (num2 != 0)
								{
								}
								num2 = (short)1309868032;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 3:
							num2 = (short)95682562;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_20;
					}
					return false;
					IL_102:
					return false;
					IL_107:
					num2 = (short)1009319936;
					short num4 = num2;
					return true;
				}
				}
				IL_20:
				optionGroup = this.OptionGroup;
				IL_27:
				num2 = (short)90046465;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001DE8C File Offset: 0x0001C08C
		private void UpdateOptionGroupState()
		{
			short num = (short)638844929;
			if (num != 0)
			{
			}
			num = (short)722337792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1229389830;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerable enumerable;
					switch (num2)
					{
					case 0:
						goto IL_E0;
					case 1:
						if (base.Parent is global::System.Windows.Controls.ItemsControl)
						{
							num = (short)650248196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1241776131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_B8;
					case 3:
						if (base.Parent is global::System.Windows.Controls.Panel)
						{
							num = (short)1242169349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 4:
					{
						num = (short)467861504;
						short num3 = num;
						goto IL_472;
					}
					case 5:
						enumerable = ((global::System.Windows.Controls.Panel)base.Parent).Children;
						num = (short)625999872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_9B;
						}
						continue;
					case 7:
						goto IL_DB;
					case 8:
						return;
					case 9:
						goto IL_E0;
					case 10:
					{
						if (enumerable == null)
						{
							num = (short)342884360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = enumerable.GetEnumerator();
						num = (short)928055303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9B:
					if (!this.IsInOptionGroup)
					{
						num = (short)253231106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					string optionGroup = this.OptionGroup;
					enumerable = null;
					num = (short)29887045;
					short num4 = num;
					num = (short)1739328069;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_472;
					default:
						num = (short)24313856;
						if (num != 0)
						{
						}
						num = (short)366346241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E0:
					num = (short)1460666378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					enumerable = ((global::System.Windows.Controls.ItemsControl)base.Parent).Items;
					num = (short)2079588361;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B8:
				return;
				IL_DB:
				try
				{
					num = (short)1061289990;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							buttonDropDown.IsChecked = false;
							num = (short)253034507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							string optionGroup;
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.OptionGroup == optionGroup)
							{
								num = (short)1706950668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown != this)
							{
								num = (short)57081859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num = (short)1661009921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown.IsChecked)
							{
								num = (short)1357840384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_3B4;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_237;
							}
							continue;
						case 7:
							num = (short)643825666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)261619721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = enumerator.Current as global::DevComponents.WpfRibbon.ButtonDropDown;
							num = (short)1797783562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)1144651781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							if (buttonDropDown != null)
							{
								num = (short)161349639;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							num = (short)1734082564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_239:
						num = (short)929103880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_237:
						goto IL_239;
					}
					IL_3B4:
					return;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_3D6;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_3C3:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)1155399682;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42D;
						case 1:
							goto IL_42B;
						case 2:
							disposable.Dispose();
							num = (short)437649409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D6;
					}
					IL_42B:
					IL_42D:
					goto EndFinally_13;
					IL_3D6:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)469893120;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3C3;
					EndFinally_13:;
				}
				return;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001E384 File Offset: 0x0001C584
		private static void OnRoleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1516146833;
			short num2 = num;
			num = (short)670535825;
			switch (num2 == num)
			{
			}
			num = (short)1895366656;
			short num3 = num;
			num = (short)2039414785;
			if (num != 0)
			{
			}
			num = (short)1858535424;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).OnRoleChanged((global::DevComponents.WpfRibbon.eButtonRole)e.OldValue, (global::DevComponents.WpfRibbon.eButtonRole)e.NewValue);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001E450 File Offset: 0x0001C650
		private void OnRoleChanged(global::DevComponents.WpfRibbon.eButtonRole oldRole, global::DevComponents.WpfRibbon.eButtonRole newRole)
		{
			int a_ = 17;
			short num = (short)2069823490;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					IL_D9:
					num = (short)1671954432;
					short num3 = num;
					if (oldRole == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
					{
						num = (short)365363204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B;
				}
				case 1:
					goto IL_16B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
				{
					num = (short)100663297;
					if (num != 0)
					{
					}
					global::System.Windows.ComponentResourceKey resourceKey = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.ButtonDropDown), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⭨Ṫᥬ᭮Ṱᵲㅴնᙸ୺㥼ၾ좄ﺊ쒌ﮎﺒ", a_));
					base.Style = (global::System.Windows.Style)base.FindResource(resourceKey);
					num = (short)651362305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					base.Style = (global::System.Windows.Style)base.FindResource(typeof(global::DevComponents.WpfRibbon.ButtonDropDown));
					num = (short)391315461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_16B;
				}
				IL_45:
				if (newRole == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
				{
					num = (short)1210515459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)686555136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16B:
				num = (short)1510159004;
				short num4 = num;
				num = (short)31470236;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D9;
				default:
					goto IL_1A1;
				}
			}
			IL_1A1:
			num = (short)1821638656;
			if (num != 0)
			{
			}
			this.UpdateBorderBehavior();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001E61C File Offset: 0x0001C81C
		private void UpdateBorderBehavior()
		{
			short num = (short)748355590;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_72;
				case 1:
					num = (short)184352769;
					if (num != 0)
					{
					}
					this.m_ButtonBorder.Animation = true;
					num = (short)1337982976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1199964164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.m_ButtonBorder.Animation = false;
					num = (short)570949641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.m_ButtonBorder != null)
					{
						num = (short)1403125763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72;
				case 5:
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 7:
					if (this.m_ButtonBorder != null)
					{
						num = (short)1179516938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					if (this.m_ButtonBorder != null)
					{
						num = (short)1163001856;
						short num3 = num;
						num = (short)271515649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72;
				case 9:
					goto IL_72;
				case 10:
					this.m_ButtonBorder.RenderBorder = this.m_RenderBorder;
					num = (short)1657274373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_50:
				if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.MenuItem)
				{
					num = (short)891879426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1545917678;
				short num4 = num;
				num = (short)1546704110;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1267138560;
					if (num != 0)
					{
					}
					num = (short)739573768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_72:
				num = (short)844890119;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0001E870 File Offset: 0x0001CA70
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0001E920 File Offset: 0x0001CB20
		internal bool RenderBorder
		{
			get
			{
				short num = (short)183604719;
				short num2 = num;
				num = (short)523802095;
				switch (num2 == num)
				{
				}
				num = (short)490995712;
				short num3 = num;
				num = (short)1616773121;
				if (num != 0)
				{
				}
				num = (short)910360576;
				if (num != 0)
				{
				}
				return this.m_RenderBorder;
			}
			set
			{
				short num = (short)1524957185;
				if (num != 0)
				{
				}
				num = (short)1861717639;
				short num2 = num;
				num = (short)1358663303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)158531584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109707264;
				if (num != 0)
				{
				}
				this.m_RenderBorder = value;
				this.UpdateBorderBehavior();
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001E9D4 File Offset: 0x0001CBD4
		protected virtual void OnChecked(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)779213465;
			short num2 = num;
			num = (short)1230822041;
			switch (num2 == num)
			{
			}
			num = (short)505413632;
			short num3 = num;
			num = (short)1366294529;
			if (num != 0)
			{
			}
			num = (short)291700736;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001EA84 File Offset: 0x0001CC84
		protected virtual void OnUnchecked(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)107544966;
			short num2 = num;
			num = (short)290128262;
			switch (num2 == num)
			{
			}
			num = (short)430637056;
			short num3 = num;
			num = (short)676921345;
			if (num != 0)
			{
			}
			num = (short)1845493760;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0001EB34 File Offset: 0x0001CD34
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0001EBEC File Offset: 0x0001CDEC
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsCheckable
		{
			get
			{
				short num = (short)925805229;
				short num2 = num;
				num = (short)1899145901;
				switch (num2 == num)
				{
				}
				num = (short)1261174784;
				short num3 = num;
				num = (short)1898119168;
				if (num != 0)
				{
				}
				num = (short)1042153473;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsCheckableProperty);
			}
			set
			{
				short num = (short)1095696753;
				short num2 = num;
				num = (short)259654001;
				switch (num2 == num)
				{
				}
				num = (short)699269120;
				short num3 = num;
				num = (short)1510473729;
				if (num != 0)
				{
				}
				num = (short)783876096;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsCheckableProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0001ED64 File Offset: 0x0001CF64
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool IsChecked
		{
			get
			{
				short num = (short)2112684032;
				short num2 = num;
				num = (short)1465805583;
				short num3 = num;
				num = (short)231369487;
				switch (num3 == num)
				{
				}
				num = (short)886964225;
				if (num != 0)
				{
				}
				num = (short)1188560896;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsCheckedProperty);
			}
			set
			{
				short num = (short)484179968;
				short num2 = num;
				num = (short)758361721;
				short num3 = num;
				num = (short)855879289;
				switch (num3 == num)
				{
				}
				num = (short)1029308417;
				if (num != 0)
				{
				}
				num = (short)711852032;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsCheckedProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0001EE1C File Offset: 0x0001D01C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0001EED4 File Offset: 0x0001D0D4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public global::DevComponents.WpfRibbon.eExpandPosition ExpandPosition
		{
			get
			{
				short num = (short)1514405888;
				short num2 = num;
				num = (short)36285671;
				short num3 = num;
				num = (short)67546343;
				switch (num3 == num)
				{
				}
				num = (short)55443457;
				if (num != 0)
				{
				}
				num = (short)1177812992;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eExpandPosition)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ExpandPositionProperty);
			}
			set
			{
				short num = (short)41943040;
				short num2 = num;
				num = (short)348626638;
				short num3 = num;
				num = (short)462003918;
				switch (num3 == num)
				{
				}
				num = (short)1093599233;
				if (num != 0)
				{
				}
				num = (short)1406337024;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ExpandPositionProperty, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0001EF90 File Offset: 0x0001D190
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0001F04C File Offset: 0x0001D24C
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool WrapLabel
		{
			get
			{
				short num = (short)181534720;
				short num2 = num;
				num = (short)406099132;
				short num3 = num;
				num = (short)1421972668;
				switch (num3 == num)
				{
				}
				num = (short)1932853248;
				if (num != 0)
				{
				}
				num = (short)88932353;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.WrapLabelProperty);
			}
			set
			{
				short num = (short)1183776768;
				short num2 = num;
				num = (short)1833390813;
				short num3 = num;
				num = (short)27939549;
				switch (num3 == num)
				{
				}
				num = (short)1571356673;
				if (num != 0)
				{
				}
				num = (short)1893400576;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.WrapLabelProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0001F104 File Offset: 0x0001D304
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool InlineExpand
		{
			get
			{
				short num = (short)1527382016;
				short num2 = num;
				num = (short)81964289;
				short num3 = num;
				num = (short)930000129;
				switch (num3 == num)
				{
				}
				num = (short)1631584257;
				if (num != 0)
				{
				}
				num = (short)968032256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.InlineExpandProperty);
			}
			set
			{
				short num = (short)233897984;
				short num2 = num;
				num = (short)1876623361;
				if (num != 0)
				{
				}
				num = (short)273086498;
				short num3 = num;
				num = (short)781580322;
				switch (num3 == num)
				{
				}
				num = (short)1547698176;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.InlineExpandProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0001F278 File Offset: 0x0001D478
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0001F334 File Offset: 0x0001D534
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates whether popup is left open when input focus changes.")]
		public bool FocusChangeKeepsPopupOpen
		{
			get
			{
				short num = (short)207683584;
				short num2 = num;
				num = (short)287126933;
				short num3 = num;
				num = (short)938554773;
				switch (num3 == num)
				{
				}
				num = (short)1763049473;
				if (num != 0)
				{
				}
				num = (short)312672256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.FocusChangeKeepsPopupOpenProperty);
			}
			set
			{
				short num = (short)1461649408;
				short num2 = num;
				num = (short)2009350629;
				short num3 = num;
				num = (short)1404584421;
				switch (num3 == num)
				{
				}
				num = (short)454295552;
				if (num != 0)
				{
				}
				num = (short)487915521;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.FocusChangeKeepsPopupOpenProperty, value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object RenderImage
		{
			get
			{
				short num = (short)837943296;
				short num2 = num;
				num = (short)1622624972;
				short num3 = num;
				num = (short)1080838860;
				switch (num3 == num)
				{
				}
				num = (short)1662058497;
				if (num != 0)
				{
				}
				num = (short)987627520;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.RenderImageProperty);
			}
			internal set
			{
				short num = (short)1198063616;
				short num2 = num;
				num = (short)1534006737;
				short num3 = num;
				num = (short)1787106769;
				switch (num3 == num)
				{
				}
				num = (short)452001792;
				if (num != 0)
				{
				}
				num = (short)1445658625;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.RenderImagePropertyKey, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0001F560 File Offset: 0x0001D760
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0001F618 File Offset: 0x0001D818
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public object Image
		{
			get
			{
				short num = (short)1642135552;
				short num2 = num;
				num = (short)1921617736;
				short num3 = num;
				num = (short)164466504;
				switch (num3 == num)
				{
				}
				num = (short)129761281;
				if (num != 0)
				{
				}
				num = (short)156631040;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageProperty);
			}
			set
			{
				short num = (short)1905065984;
				short num2 = num;
				num = (short)609373334;
				short num3 = num;
				num = (short)1810975894;
				switch (num3 == num)
				{
				}
				num = (short)662634497;
				if (num != 0)
				{
				}
				num = (short)2024669184;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageProperty, value);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
		private static void OnImageSourceChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (buttonDropDown != null)
					{
						num2 = (short)1823080449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					buttonDropDown.OnImageSourceChanged((string)e.OldValue, (string)e.NewValue);
					num2 = (short)68878338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_100;
				}
				goto IL_1C;
			}
			IL_100:
			num2 = (short)1322713088;
			short num3 = num2;
			return;
			IL_1C:
			buttonDropDown = (o as global::DevComponents.WpfRibbon.ButtonDropDown);
			num2 = (short)776105560;
			short num4 = num2;
			num2 = (short)1140158040;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)629145600;
				if (num2 != 0)
				{
				}
				num2 = (short)1461059585;
				if (num2 != 0)
				{
				}
				num2 = (short)524550144;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001F808 File Offset: 0x0001DA08
		protected virtual void OnImageSourceChanged(string oldValue, string newValue)
		{
			short num = (short)1273888768;
			short num2 = num;
			num = (short)416049689;
			short num3 = num;
			num = (short)849373721;
			switch (num3 == num)
			{
			}
			num = (short)681181184;
			if (num != 0)
			{
			}
			num = (short)1615659009;
			if (num != 0)
			{
			}
			this.UpdateRenderImage();
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0001F8BC File Offset: 0x0001DABC
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0001F978 File Offset: 0x0001DB78
		public string ImageSource
		{
			get
			{
				short num = (short)474808320;
				short num2 = num;
				num = (short)1694624937;
				short num3 = num;
				num = (short)1544416425;
				switch (num3 == num)
				{
				}
				num = (short)125763585;
				if (num != 0)
				{
				}
				num = (short)1929641984;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageSourceProperty);
			}
			set
			{
				short num = (short)1281622016;
				short num2 = num;
				num = (short)1682473430;
				short num3 = num;
				num = (short)370508246;
				switch (num3 == num)
				{
				}
				num = (short)808976384;
				if (num != 0)
				{
				}
				num = (short)1889599489;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageSourceProperty, value);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001FA2C File Offset: 0x0001DC2C
		private static void OnImageSmallSourceChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)70909953;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				IL_31:
				int num2;
				switch (num2)
				{
				case 0:
					if (buttonDropDown != null)
					{
						num = (short)94568449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					buttonDropDown.OnImageSmallSourceChanged((string)e.OldValue, (string)e.NewValue);
					num = (short)759824386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_FA;
				}
				goto IL_43;
			}
			IL_FA:
			num = (short)420806656;
			short num3 = num;
			return;
			IL_43:
			buttonDropDown = (o as global::DevComponents.WpfRibbon.ButtonDropDown);
			num = (short)1386354814;
			short num4 = num;
			num = (short)1874794622;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num = (short)2144141312;
				if (num != 0)
				{
				}
				num = (short)300875776;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001FB60 File Offset: 0x0001DD60
		protected virtual void OnImageSmallSourceChanged(string oldValue, string newValue)
		{
			short num = (short)1339817984;
			short num2 = num;
			num = (short)1645690821;
			short num3 = num;
			num = (short)2087337925;
			switch (num3 == num)
			{
			}
			num = (short)1533870081;
			if (num != 0)
			{
			}
			num = (short)249102336;
			if (num != 0)
			{
			}
			this.UpdateRenderImage();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0001FC10 File Offset: 0x0001DE10
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		public string ImageSmallSource
		{
			get
			{
				short num = (short)38141952;
				short num2 = num;
				num = (short)1491140609;
				if (num != 0)
				{
				}
				num = (short)179007322;
				short num3 = num;
				num = (short)1380413274;
				switch (num3 == num)
				{
				}
				num = (short)450953216;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageSmallSourceProperty);
			}
			set
			{
				short num = (short)1156972544;
				short num2 = num;
				num = (short)872592510;
				short num3 = num;
				num = (short)1986442366;
				switch (num3 == num)
				{
				}
				num = (short)1229127680;
				if (num != 0)
				{
				}
				num = (short)1139081217;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageSmallSourceProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0001FD80 File Offset: 0x0001DF80
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0001FE34 File Offset: 0x0001E034
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public object ImageSmall
		{
			get
			{
				short num = (short)685834240;
				short num2 = num;
				num = (short)332398593;
				if (num != 0)
				{
				}
				num = (short)1846862539;
				short num3 = num;
				num = (short)1208148683;
				switch (num3 == num)
				{
				}
				num = (short)1499070464;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageSmallProperty);
			}
			set
			{
				short num = (short)949813248;
				short num2 = num;
				num = (short)857321008;
				short num3 = num;
				num = (short)1681239600;
				switch (num3 == num)
				{
				}
				num = (short)222167040;
				if (num != 0)
				{
				}
				num = (short)55640065;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImageSmallProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public bool UseSmallImage
		{
			get
			{
				short num = (short)782958592;
				short num2 = num;
				num = (short)1047182096;
				short num3 = num;
				num = (short)2130230032;
				switch (num3 == num)
				{
				}
				num = (short)1495072768;
				if (num != 0)
				{
				}
				num = (short)905773057;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.UseSmallImageProperty);
			}
			set
			{
				short num = (short)261095424;
				short num2 = num;
				num = (short)1617334327;
				short num3 = num;
				num = (short)254578743;
				switch (num3 == num)
				{
				}
				num = (short)2082734080;
				if (num != 0)
				{
				}
				num = (short)1848311809;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.UseSmallImageProperty, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00020060 File Offset: 0x0001E260
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00020118 File Offset: 0x0001E318
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public global::DevComponents.WpfRibbon.eButtonImagePosition ImagePosition
		{
			get
			{
				short num = (short)1488322560;
				short num2 = num;
				num = (short)635269812;
				short num3 = num;
				num = (short)1801941684;
				switch (num3 == num)
				{
				}
				num = (short)1824980993;
				if (num != 0)
				{
				}
				num = (short)1475084288;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eButtonImagePosition)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImagePositionProperty);
			}
			set
			{
				short num = (short)245366784;
				short num2 = num;
				num = (short)1642108725;
				short num3 = num;
				num = (short)716150581;
				switch (num3 == num)
				{
				}
				num = (short)176029697;
				if (num != 0)
				{
				}
				num = (short)81985536;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ImagePositionProperty, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000201D8 File Offset: 0x0001E3D8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool IsHighlighted
		{
			get
			{
				short num = (short)1162870784;
				short num2 = num;
				num = (short)348262207;
				short num3 = num;
				num = (short)1486425919;
				switch (num3 == num)
				{
				}
				num = (short)1516568577;
				if (num != 0)
				{
				}
				num = (short)1674706944;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsHighlightedProperty);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00020290 File Offset: 0x0001E490
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0002034C File Offset: 0x0001E54C
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Bindable(true)]
		public bool StaysOpenOnClick
		{
			get
			{
				short num = (short)1200816128;
				short num2 = num;
				num = (short)676946748;
				short num3 = num;
				num = (short)1462657852;
				switch (num3 == num)
				{
				}
				num = (short)1131085824;
				if (num != 0)
				{
				}
				num = (short)874381313;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.StaysOpenOnClickProperty);
			}
			set
			{
				short num = (short)323158016;
				short num2 = num;
				num = (short)2032658362;
				short num3 = num;
				num = (short)442492858;
				switch (num3 == num)
				{
				}
				num = (short)868810753;
				if (num != 0)
				{
				}
				num = (short)103743488;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.StaysOpenOnClickProperty, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00020404 File Offset: 0x0001E604
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000204C0 File Offset: 0x0001E6C0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsPopupAnimationSuspended
		{
			get
			{
				short num = (short)55902208;
				short num2 = num;
				num = (short)1401886305;
				short num3 = num;
				num = (short)979244641;
				switch (num3 == num)
				{
				}
				num = (short)1938292736;
				if (num != 0)
				{
				}
				num = (short)35389441;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupAnimationSuspendedProperty);
			}
			set
			{
				short num = (short)899678208;
				short num2 = num;
				num = (short)32374785;
				if (num != 0)
				{
				}
				num = (short)1112718088;
				short num3 = num;
				num = (short)125549320;
				switch (num3 == num)
				{
				}
				num = (short)266665984;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.IsPopupAnimationSuspendedProperty, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00020578 File Offset: 0x0001E778
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00020630 File Offset: 0x0001E830
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public string InputGestureText
		{
			get
			{
				short num = (short)1219493888;
				short num2 = num;
				num = (short)677042334;
				short num3 = num;
				num = (short)1582225566;
				switch (num3 == num)
				{
				}
				num = (short)1474428928;
				if (num != 0)
				{
				}
				num = (short)1886257153;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.InputGestureTextProperty);
			}
			set
			{
				short num = (short)1996554240;
				short num2 = num;
				num = (short)430139073;
				short num3 = num;
				num = (short)1930389185;
				switch (num3 == num)
				{
				}
				num = (short)405995521;
				if (num != 0)
				{
				}
				num = (short)1654063104;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.InputGestureTextProperty, value);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000206E8 File Offset: 0x0001E8E8
		private static void OnInputGestureTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1878917120;
			short num2 = num;
			num = (short)1984764621;
			short num3 = num;
			num = (short)115219149;
			switch (num3 == num)
			{
			}
			num = (short)1483931648;
			if (num != 0)
			{
			}
			num = (short)1599340545;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00020790 File Offset: 0x0001E990
		private static object CoerceInputGestureText(global::System.Windows.DependencyObject d, object value)
		{
			short num = (short)706281472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Windows.Input.RoutedCommand routedCommand;
				global::System.Windows.Input.KeyGesture keyGesture;
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (routedCommand != null)
						{
							num = (short)1828716555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					case 1:
					{
						global::System.Windows.Input.InputGestureCollection inputGestures;
						if (inputGestures.Count < 1)
						{
							num = (short)977272844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = 0;
						num = (short)377552902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1649672192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.Input.InputGestureCollection inputGestures;
						int num3;
						if (num3 >= inputGestures.Count)
						{
							num = (short)838336527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyGesture = (((global::System.Collections.IList)inputGestures)[num3] as global::System.Windows.Input.KeyGesture);
						goto IL_1FD;
					}
					case 4:
						goto IL_23C;
					case 5:
						if (string.IsNullOrEmpty((string)value))
						{
							num = (short)37879817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					case 6:
						goto IL_23C;
					case 7:
						num = (short)547356673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (buttonDropDown.InputGestureText == "")
						{
							num = (short)3276802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					case 9:
						num = (short)1215299592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (keyGesture != null)
						{
							num = (short)1715208206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)737476612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.Input.InputGestureCollection inputGestures = routedCommand.InputGestures;
						num = (short)903479309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)850422622;
						short num4 = num;
						num = (short)1287351134;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FD;
						default:
							goto IL_2F0;
						}
						break;
					}
					case 13:
					{
						global::System.Windows.Input.InputGestureCollection inputGestures;
						if (inputGestures != null)
						{
							num = (short)1699151879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					}
					case 14:
						goto IL_237;
					case 15:
						goto IL_278;
					}
					goto IL_70;
					IL_1FD:
					num = (short)324206602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23C:
					num = (short)608763907;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_237:
				num = (short)1252786176;
				short num5 = num;
				return keyGesture.GetDisplayStringForCulture(global::System.Globalization.CultureInfo.CurrentCulture);
				IL_278:
				return value;
				IL_2F0:
				num = (short)682098688;
				if (num != 0)
				{
				}
				return value;
				IL_70:
				num = (short)88866817;
				if (num != 0)
				{
				}
				buttonDropDown = (global::DevComponents.WpfRibbon.ButtonDropDown)d;
				routedCommand = (buttonDropDown.Command as global::System.Windows.Input.RoutedCommand);
				num = (short)1372520453;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00020AEC File Offset: 0x0001ECEC
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			short num = (short)1926496256;
			short num2 = num;
			num = (short)2081314210;
			short num3 = num;
			num = (short)1626232226;
			switch (num3 == num)
			{
			}
			num = (short)909312001;
			if (num != 0)
			{
			}
			num = (short)1258094592;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.ButtonDropDownAutomationPeer(this);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00020B98 File Offset: 0x0001ED98
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00020C48 File Offset: 0x0001EE48
		internal global::DevComponents.WpfRibbon.ElementAutoSizeBag AutoSizeBag
		{
			get
			{
				short num = (short)1413021696;
				short num2 = num;
				num = (short)1630535681;
				if (num != 0)
				{
				}
				num = (short)1819636822;
				short num3 = num;
				num = (short)1249277014;
				switch (num3 == num)
				{
				}
				num = (short)410189824;
				if (num != 0)
				{
				}
				return this.m_AutoSizeBag;
			}
			set
			{
				short num = (short)1333919744;
				short num2 = num;
				num = (short)347842288;
				short num3 = num;
				num = (short)945399536;
				switch (num3 == num)
				{
				}
				num = (short)397606912;
				if (num != 0)
				{
				}
				num = (short)1698168833;
				if (num != 0)
				{
				}
				this.m_AutoSizeBag = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		private global::System.Windows.Size ImageFixedSize
		{
			get
			{
				short num = (short)656474112;
				short num2 = num;
				num = (short)1486548377;
				short num3 = num;
				num = (short)754707865;
				switch (num3 == num)
				{
				}
				num = (short)2147024897;
				if (num != 0)
				{
				}
				num = (short)1925775360;
				if (num != 0)
				{
				}
				return this.m_ImageFixedSize;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				short num;
				for (;;)
				{
					IL_0A:
					num = (short)1492254721;
					if (num != 0)
					{
					}
					int num2;
					switch (num2)
					{
					case 0:
						if (this.m_ButtonImage != null)
						{
							num = (short)511705089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)773849092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1B3;
					case 3:
						goto IL_14A;
					case 4:
						goto IL_18C;
					}
					goto IL_4D;
				}
				IL_14A:
				return;
				IL_1B3:
				this.m_ButtonImage.MaxWidth = double.PositiveInfinity;
				this.m_ButtonImage.MaxHeight = double.PositiveInfinity;
				return;
				IL_4D:
				this.m_ImageFixedSize = value;
				num = (short)1931235164;
				short num3 = num;
				num = (short)983715676;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_18C:
					int num2;
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.m_ImageFixedSize))
					{
						num = (short)1614086146;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					this.m_ButtonImage.MaxWidth = this.m_ImageFixedSize.Width;
					this.m_ButtonImage.MaxHeight = this.m_ImageFixedSize.Height;
					num = (short)1823735811;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				default:
				{
					num = (short)1161494528;
					if (num != 0)
					{
					}
					num = (short)1994588160;
					short num4 = num;
					num = (short)2039021568;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00020F6C File Offset: 0x0001F16C
		internal bool HasImage
		{
			get
			{
				short num = (short)1250361344;
				short num2 = num;
				num = (short)2057218131;
				short num3 = num;
				num = (short)1542498387;
				switch (num3 == num)
				{
				}
				num = (short)2089615361;
				if (num != 0)
				{
				}
				num = (short)2080440320;
				if (num != 0)
				{
				}
				return this.m_ButtonImage != null;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0002101C File Offset: 0x0001F21C
		internal void OpenPopupWithKeyboard()
		{
			short num = (short)966918144;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
				{
					global::System.Windows.UIElement firstVisible = this.GetFirstVisible();
					num = (short)871104516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)363357182;
					short num3 = num;
					num = (short)164848638;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1990000641;
						if (num != 0)
						{
						}
						num = (short)679739392;
						if (num != 0)
						{
						}
						break;
					}
					global::System.Windows.UIElement firstVisible;
					firstVisible.Focus();
					num = (short)608174083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_77;
				case 4:
				{
					global::System.Windows.UIElement firstVisible;
					if (firstVisible != null)
					{
						num = (short)532283394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12A;
				}
				}
				IL_39:
				if (!this.OpenPopup())
				{
					break;
				}
				num = (short)2023882753;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_77:
			IL_12A:
			num = (short)975699968;
			short num4 = num;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0002117C File Offset: 0x0001F37C
		private global::System.Windows.UIElement GetFirstVisible()
		{
			short num = (short)45569165;
			short num2 = num;
			num = (short)1955812493;
			global::System.Windows.UIElement result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)206635009;
				if (num != 0)
				{
				}
				num = (short)1915682816;
				short num3 = num;
				num = (short)214237184;
				if (num != 0)
				{
				}
				num = (short)1480065024;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					try
					{
						num = (short)1950416898;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								num = (short)1163526149;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								object obj;
								result = (obj as global::System.Windows.UIElement);
								num = (short)664993799;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_116;
								}
								continue;
							case 3:
							{
								object obj;
								if (obj is global::System.Windows.UIElement)
								{
									num = (short)1807482886;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)420216832;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								num = (short)442630147;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_217;
							case 6:
								num = (short)1111162888;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_1B4;
							case 8:
							{
								object obj;
								if (((global::System.Windows.UIElement)obj).Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)94175233;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_118:
							num = (short)612106244;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_116:
							goto IL_118;
						}
						IL_1B4:
						break;
						IL_217:
						goto IL_C9;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_239;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_226:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)777650177;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_28C;
							case 1:
								disposable.Dispose();
								num = (short)142868482;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_28A;
							}
							goto IL_239;
						}
						IL_28A:
						IL_28C:
						break;
						IL_239:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1223426048;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_226;
					}
					break;
					IL_C9:
					return null;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00021434 File Offset: 0x0001F634
		private global::System.Windows.UIElement GetFocusedElement(global::System.Collections.IList items)
		{
			short num = (short)755171328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)109903873;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = items.GetEnumerator();
				global::System.Windows.UIElement result;
				try
				{
					num = (short)582877191;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.IsFocused)
							{
								num = (short)1116536836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_192;
						case 2:
							num = (short)746979329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::System.Windows.UIElement uielement;
							if (uielement != null)
							{
								num = (short)1705181192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::System.Windows.UIElement uielement;
							result = uielement;
							num = (short)472580101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_134;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)369491970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = enumerator.Current as global::System.Windows.UIElement;
							num = (short)1540947971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_9C;
							}
							continue;
						case 8:
							num = (short)1647312896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_9E:
						num = (short)1060765702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9C:
						goto IL_9E;
					}
					IL_134:
					goto IL_252;
					IL_192:
					goto IL_50;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1B4;
					}
					for (;;)
					{
						IL_1A1:
						switch (num2)
						{
						case 0:
							goto IL_206;
						case 1:
						{
							global::System.IDisposable disposable;
							if (disposable != null)
							{
								num = (short)681508866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_208;
						}
						case 2:
						{
							global::System.IDisposable disposable;
							disposable.Dispose();
							num = (short)610664448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_1B4;
					}
					IL_206:
					IL_208:
					num = (short)1263727731;
					short num3 = num;
					num = (short)1866200179;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_1B4:
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						num = (short)572915713;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1A1;
					}
					default:
						num = (short)543555584;
						if (num != 0)
						{
						}
						break;
					}
				}
				goto IL_252;
				IL_50:
				return null;
				IL_252:
				num = (short)2041905152;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000216D8 File Offset: 0x0001F8D8
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)164429824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1EF;
				}
				global::System.Windows.Input.Key key;
				bool flag;
				for (;;)
				{
					IL_28:
					int startIndex;
					global::System.Windows.UIElement uielement2;
					global::System.Windows.UIElement uielement3;
					int num3;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.IList generatedItems;
						if (!((global::System.Windows.UIElement)generatedItems[0]).IsFocused)
						{
							num = (short)278462519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8BC;
					}
					case 1:
					{
						global::System.Windows.UIElement uielement = this.FindNextItem(startIndex, (key == global::System.Windows.Input.Key.Up) ? -1 : 1);
						num = (short)2078474333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1069;
					case 3:
						goto IL_AAC;
					case 4:
						if (base.Parent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)634257492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CCA;
					case 5:
						key = global::System.Windows.Input.Key.Left;
						num = (short)370475115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (uielement2 != null)
						{
							num = (short)1945042979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1087;
					case 7:
						this.OpenPopupWithKeyboard();
						num = (short)296550402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (key == global::System.Windows.Input.Key.Right)
						{
							num = (short)1053294597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1118175254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.IsLastVisible(((global::DevComponents.WpfRibbon.ApplicationMenu)base.Parent).AppItems, this))
						{
							num = (short)507379774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E60;
					case 10:
						goto IL_1087;
					case 11:
						goto IL_1087;
					case 12:
						goto IL_1069;
					case 13:
						goto IL_6D2;
					case 14:
						if (this.Role == global::DevComponents.WpfRibbon.eButtonRole.SplitButton)
						{
							num = (short)194707561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F61;
					case 15:
						num = (short)231997441;
						if (num != 0)
						{
						}
						num = (short)826015829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1438384193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.IsPopupOpen)
						{
							num = (short)2077622336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BE;
					case 18:
						if (base.HasItems)
						{
							num = (short)14483564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F61;
					case 19:
						if (this.Role != global::DevComponents.WpfRibbon.eButtonRole.DropDown)
						{
							num = (short)1002504252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3C;
					case 20:
					{
						object parent;
						if (parent is global::DevComponents.WpfRibbon.IPopupParentControl)
						{
							num = (short)1375928417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D2;
					}
					case 21:
						goto IL_6D2;
					case 22:
						if (key == global::System.Windows.Input.Key.Left)
						{
							num = (short)924188696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 23:
						if (flag)
						{
							num = (short)1527906332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 24:
						key = global::System.Windows.Input.Key.Right;
						num = (short)976617561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)697958445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (uielement3 == null)
						{
							num = (short)865992734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC9;
					case 27:
						num3 = 0;
						goto IL_9F7;
					case 28:
						e.Handled = true;
						num = (short)2093678678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (uielement3 != null)
						{
							num = (short)35979347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)864354386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1456275510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1191510052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_CCA;
					case 33:
						goto IL_1069;
					case 34:
					{
						if (this.IsPopupOpen)
						{
							num = (short)779026520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object parent = this.GetParent();
						num = (short)575930411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						num = (short)114688004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (this.GetParent() is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)972947506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1087;
					case 37:
						if (this.GetParent() is global::System.Windows.Controls.ItemsControl)
						{
							num = (short)1658126351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.InternalOnClick(true);
						num = (short)1220083745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)1510080583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_AC9;
					case 40:
					{
						object parent;
						((global::DevComponents.WpfRibbon.ButtonDropDown)parent).IsPopupOpen = false;
						num = (short)1711013909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						if (key != global::System.Windows.Input.Key.Down)
						{
							num = (short)298385502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F1;
					case 42:
						num = (short)2114584637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						object parent;
						if (parent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)952172584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)488374292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						goto IL_977;
					case 45:
						if (this.HighlightedChild == null)
						{
							num = (short)2001338440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8BC;
					case 46:
						goto IL_1087;
					case 47:
						num = (short)1282998289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_C27;
					case 49:
						if (key != global::System.Windows.Input.Key.Tab)
						{
							num = (short)1568473168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F1;
					case 50:
						uielement2 = null;
						num = (short)1971650589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_AC9;
					case 52:
						uielement2 = (uielement3.PredictFocus((key == global::System.Windows.Input.Key.Down || key == global::System.Windows.Input.Key.Tab) ? global::System.Windows.Input.FocusNavigationDirection.Down : global::System.Windows.Input.FocusNavigationDirection.Up) as global::System.Windows.UIElement);
						num = (short)930676826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (key <= global::System.Windows.Input.Key.Return)
						{
							num = (short)6029421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)478740557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (!(uielement3 is global::DevComponents.WpfRibbon.ButtonDropDown))
						{
							num = (short)385744921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC9;
					case 55:
						num = (short)1568014431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (this.IsPopupOpen)
						{
							num = (short)504692839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC9;
					case 57:
					{
						if (this.IsLastVisible(((global::DevComponents.WpfRibbon.ApplicationMenu)base.Parent).MruItems, this))
						{
							goto IL_E41;
						}
						num = (short)1063977288;
						short num4 = num;
						num = (short)171245896;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BEB;
						default:
							num = (short)1387069440;
							if (num != 0)
							{
							}
							num = (short)776470630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 58:
						if (this.HighlightedChild != null)
						{
							num = (short)169869388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)729219099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (key != global::System.Windows.Input.Key.Up)
						{
							num = (short)2130182248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F1;
					case 60:
						num = (short)124190734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (this.HighlightedChild.IsFocused)
						{
							num = (short)1389690976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_977;
					case 62:
						goto IL_E41;
					case 63:
						num = (short)292552712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_2B4;
					case 65:
						if (!this.IsLastVisible(((global::DevComponents.WpfRibbon.ApplicationMenu)base.Parent).Items, this))
						{
							num = (short)1333919844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E41;
					case 66:
					{
						global::System.Windows.UIElement uielement;
						uielement.Focus();
						num = (short)712441923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						goto IL_AAC;
					case 68:
						if (key != global::System.Windows.Input.Key.Return)
						{
							num = (short)743374917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1011023891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)277151836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num = (short)1818624059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						if ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Alt) == global::System.Windows.Input.ModifierKeys.Alt)
						{
							num = (short)667156527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BE;
					case 72:
						num = (short)857079808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						if (this.HighlightedChild == null)
						{
							num = (short)1426653228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC9;
					case 74:
					{
						global::System.Collections.IList generatedItems;
						((global::System.Windows.UIElement)generatedItems[0]).Focus();
						flag = true;
						num = (short)1185480743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
						if (!flag)
						{
							num = (short)705101855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1087;
					case 76:
						num = (short)314638447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (key != global::System.Windows.Input.Key.Escape)
						{
							num = (short)856752198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1508114466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_1087;
					case 79:
						if (key == global::System.Windows.Input.Key.System)
						{
							num = (short)1514602534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BE;
					case 80:
					{
						num = (short)513212416;
						short num5 = num;
						num = (short)534511684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						goto IL_1069;
					case 82:
						goto IL_BEB;
					case 83:
						num = (short)501219380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						((global::DevComponents.WpfRibbon.ButtonDropDown)base.Parent).ClearChildMouseHighlight();
						num = (short)1880817696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (this.HasVisibleItems)
						{
							num = (short)1399783431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.InternalOnClick(true);
						num = (short)349372497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						return;
					case 87:
						if (this.HighlightedChild != null)
						{
							num = (short)1369571370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_939;
					case 88:
						this.IsPopupOpen = false;
						num = (short)1965883405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						goto IL_3E4;
					case 90:
						goto IL_C27;
					case 91:
						goto IL_6D2;
					case 92:
						goto IL_1087;
					case 93:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)1862598722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.HighlightedChild.Focus();
						num = (short)1352204291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						num = (short)2110914571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
					{
						global::System.Collections.IList generatedItems;
						if (((global::System.Windows.UIElement)generatedItems[0]).Focusable)
						{
							num = (short)1568538698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8BC;
					}
					case 96:
						goto IL_939;
					case 97:
						this.SetPopupMode(false);
						num = (short)504299611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (e.Handled)
						{
							num = (short)138674286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)878772325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						if (base.Parent is global::DevComponents.WpfRibbon.ApplicationMenu)
						{
							num = (short)1514012688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E60;
					case 100:
						num = (short)563019833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)1114374207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 102:
						num = (short)1278607369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
					{
						global::System.Collections.IList generatedItems = this.GetGeneratedItems();
						uielement3 = this.GetFocusedElement(generatedItems);
						num = (short)1800667162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
						num = (short)1590820905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						num = (short)1350434834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_1087;
					case 107:
						goto IL_3E4;
					case 108:
						goto IL_F3C;
					case 109:
						num = (short)400949297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						return;
					case 111:
					{
						global::System.Collections.IList generatedItems;
						num3 = generatedItems.IndexOf(this.HighlightedChild);
						goto IL_9F7;
					}
					}
					goto IL_1EF;
					IL_2BE:
					num = (short)1462304866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E4:
					num = (short)2137587765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D2:
					flag = true;
					num = (short)1781465134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F1:
					uielement3 = null;
					num = (short)2124218424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8BC:
					num = (short)1288372311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_939:
					num = (short)246415433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_977:
					num = (short)1284177978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F7:
					startIndex = num3;
					num = (short)677576705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AAC:
					flag = true;
					num = (short)1652621363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC9:
					num = (short)1018757195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BEB:
					uielement2 = (this.PredictFocus((key == global::System.Windows.Input.Key.Down || key == global::System.Windows.Input.Key.Tab) ? global::System.Windows.Input.FocusNavigationDirection.Down : global::System.Windows.Input.FocusNavigationDirection.Up) as global::System.Windows.UIElement);
					num = (short)2057830448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C27:
					num = (short)1533607942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CCA:
					num = (short)1554251875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E41:
					flag = false;
					num = (short)707657806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E60:
					uielement2.Focus();
					flag = true;
					num = (short)324796522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3C:
					this.OpenPopupWithKeyboard();
					num = (short)659816460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F61:
					num = (short)1578565669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1069:
					flag = true;
					num = (short)1619525642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1087:
					num = (short)1236008983;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B4:
				this.IsPopupOpen = false;
				return;
				IL_1EF:
				base.OnKeyDown(e);
				key = e.Key;
				flag = false;
				num = (short)1084489807;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000227C8 File Offset: 0x000209C8
		internal bool IsLastVisible(global::System.Collections.IList collection, global::System.Windows.UIElement element)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					goto IL_E0;
				case 2:
				{
					num2 = (short)1453850625;
					if (num2 != 0)
					{
					}
					if (num3 < 0)
					{
						num2 = (short)1732313092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1679687680;
					short num4 = num2;
					global::System.Windows.UIElement uielement = collection[num3] as global::System.Windows.UIElement;
					num2 = (short)330432519;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return true;
				case 4:
					goto IL_13E;
				case 5:
				{
					num2 = (short)1615980038;
					short num5 = num2;
					num2 = (short)604956166;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)563347456;
						if (num2 != 0)
						{
						}
						global::System.Windows.UIElement uielement;
						if (uielement == element)
						{
							num2 = (short)1496186883;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				case 6:
					num2 = (short)769720325;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					global::System.Windows.UIElement uielement;
					if (uielement.Visibility == global::System.Windows.Visibility.Visible)
					{
						num2 = (short)1817182214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3--;
					num2 = (short)2111700992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
				IL_E0:
				num2 = (short)537722882;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13E:
			return false;
			IL_30:
			num3 = collection.Count - 1;
			num2 = (short)1530331137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0002299C File Offset: 0x00020B9C
		private global::System.Windows.UIElement FindNextItem(int startIndex, int direction)
		{
			short num = (short)1688469504;
			switch (num)
			{
			default:
			{
				num = (short)622657536;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.UIElement uielement;
				for (;;)
				{
					int num3;
					global::System.Collections.IList generatedItems;
					int num4;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 1:
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)995033099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F3;
					case 2:
						num3 = startIndex;
						generatedItems = this.GetGeneratedItems();
						num4 = 0;
						num = (short)1643708420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_361;
					case 4:
						goto IL_238;
					case 5:
						num = (short)1705836545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_13B;
					case 7:
						num = (short)283967489;
						if (num != 0)
						{
						}
						num = (short)1676214282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (num3 >= generatedItems.Count)
						{
							num = (short)1753808912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1593835520;
						short num5 = num;
						num = (short)2009726989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_13B;
					case 10:
						if (uielement.IsEnabled)
						{
							num = (short)1415184389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F3;
					case 11:
						return uielement;
					case 12:
						if (num4 >= generatedItems.Count)
						{
							num = (short)3407886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 += direction;
						num = (short)778043400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (num3 < 0)
						{
							num = (short)7864323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					case 14:
						goto IL_275;
					case 15:
						goto IL_238;
					case 16:
						num3 = 0;
						num = (short)114032646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (uielement != null)
						{
							num = (short)1514078215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F3;
					}
					IL_8C:
					if (direction == 0)
					{
						goto IL_366;
					}
					num = (short)15427222;
					short num6 = num;
					num = (short)2061330070;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_361;
					default:
						num = (short)1623785472;
						if (num != 0)
						{
						}
						num = (short)1067843586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_13B:
					uielement = (generatedItems[num3] as global::System.Windows.UIElement);
					num = (short)765657105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F3:
					num4++;
					num = (short)1762525199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_238:
					num = (short)1228603404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_361:
					num3 = generatedItems.Count - 1;
					num = (short)1440743433;
					num2 = (int)((global::System.IntPtr)num);
				}
				return uielement;
				IL_275:
				IL_366:
				return null;
			}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00022D10 File Offset: 0x00020F10
		private global::System.Collections.IList GetGeneratedItems()
		{
			short num = (short)2005794816;
			short num2 = num;
			num = (short)1280311297;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)77725698;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 2:
				{
					if (!base.HasItems)
					{
						num = (short)284229636;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
					int num4 = 0;
					num = (short)1613037574;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::System.Collections.Generic.List<object> list;
					return list;
				}
				case 4:
					goto IL_112;
				case 5:
				{
					int num4;
					if (num4 >= base.Items.Count)
					{
						num = (short)1878130691;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<object> list;
					list.Add(base.ItemContainerGenerator.ContainerFromIndex(num4));
					num4++;
					num = (short)785252359;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					IL_D9:
					goto IL_117;
				case 7:
					goto IL_117;
				}
				IL_6D:
				if (base.ItemsSource != null)
				{
					num = (short)1944387584;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_117:
				num = (short)1004022742;
				short num5 = num;
				num = (short)634072022;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D9;
				default:
					num = (short)999161856;
					if (num != 0)
					{
					}
					num = (short)1180499969;
					if (num != 0)
					{
					}
					num = (short)1836056581;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_112:
			return base.Items;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00022EF0 File Offset: 0x000210F0
		protected virtual void ClearChildMouseHighlight()
		{
			short num = (short)1351221248;
			short num2 = num;
			num = (short)1899799005;
			short num3 = num;
			num = (short)343646685;
			switch (num3 == num)
			{
			}
			num = (short)1651965953;
			if (num != 0)
			{
			}
			num = (short)35258368;
			if (num != 0)
			{
			}
			this.ClearChildMouseHighlight(base.Items);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00022FA4 File Offset: 0x000211A4
		protected virtual void ClearChildMouseHighlight(global::System.Collections.IEnumerable col)
		{
			short num = (short)1942814721;
			if (num != 0)
			{
			}
			num = (short)1335885824;
			short num2 = num;
			global::System.Collections.IEnumerator enumerator = col.GetEnumerator();
			try
			{
				num = (short)366411778;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown != null)
						{
							num = (short)1034944520;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown.IsHighlighted)
						{
							num = (short)2088239107;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					case 3:
					{
						num = (short)1631803586;
						short num4 = num;
						num = (short)57039042;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
						{
							num = (short)1319501824;
							if (num != 0)
							{
							}
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
							buttonDropDown.RemoveButtonHighlight();
							num = (short)1667694598;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						goto IL_1D2;
					case 5:
						num = (short)1680539652;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (!enumerator.MoveNext())
						{
							goto IL_F7;
						}
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = enumerator.Current as global::DevComponents.WpfRibbon.ButtonDropDown;
						num = (short)370016256;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)471728129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DB:
					num = (short)1899233287;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F:
					goto IL_DB;
					IL_F7:
					num = (short)1623457797;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D2:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_1F0;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1DE:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)2120351745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_242;
					case 2:
						if (disposable != null)
						{
							num = (short)1734868992;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					}
					goto IL_1F0;
				}
				IL_242:
				IL_244:
				goto EndFinally_6;
				IL_1F0:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)455344130;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_1DE;
				EndFinally_6:;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00023214 File Offset: 0x00021414
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1997203719;
					short num2 = num;
					num = (short)1569843463;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)609681408;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (!e.Handled)
							{
								num = (short)207814657;
								if (num != 0)
								{
								}
								num = (short)1549402118;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							if (this.m_KeyTipsAdorner.ProcessTextInput(e))
							{
								num = (short)2141716483;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							num = (short)877461505;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							this.ShowKeyTips = false;
							num = (short)160169989;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1231618048;
							short num4 = num;
							if (this.m_KeyTipsAdorner != null)
							{
								num = (short)1736704002;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 5:
							return;
						case 6:
							num = (short)1372520452;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76;
					}
				}
				IL_76:
				base.OnTextInput(e);
				num = (short)274202624;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000233CC File Offset: 0x000215CC
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00023484 File Offset: 0x00021684
		[global::System.ComponentModel.DefaultValue("Button")]
		public string ColorClass
		{
			get
			{
				short num = (short)214695936;
				short num2 = num;
				num = (short)956918503;
				short num3 = num;
				num = (short)780561127;
				switch (num3 == num)
				{
				}
				num = (short)579862529;
				if (num != 0)
				{
				}
				num = (short)1167523840;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ColorClassProperty);
			}
			set
			{
				short num = (short)673775616;
				short num2 = num;
				num = (short)2103771137;
				if (num != 0)
				{
				}
				num = (short)1582600726;
				short num3 = num;
				num = (short)1520734742;
				switch (num3 == num)
				{
				}
				num = (short)321716224;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.ColorClassProperty, value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0002353C File Offset: 0x0002173C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000235F8 File Offset: 0x000217F8
		[global::System.ComponentModel.DefaultValue("")]
		public string OptionGroup
		{
			get
			{
				short num = (short)486080512;
				short num2 = num;
				num = (short)884782736;
				short num3 = num;
				num = (short)1079686800;
				switch (num3 == num)
				{
				}
				num = (short)636026880;
				if (num != 0)
				{
				}
				num = (short)1712783361;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.OptionGroupProperty);
			}
			set
			{
				short num = (short)1045561344;
				short num2 = num;
				num = (short)1995033517;
				short num3 = num;
				num = (short)1863044013;
				switch (num3 == num)
				{
				}
				num = (short)1654456321;
				if (num != 0)
				{
				}
				num = (short)1691680768;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.OptionGroupProperty, value);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000236B0 File Offset: 0x000218B0
		public virtual global::DevComponents.WpfRibbon.ButtonDropDown Copy(bool deepCopy)
		{
			short num = (short)784007168;
			short num2 = num;
			num = (short)757006006;
			short num3 = num;
			num = (short)1091239606;
			switch (num3 == num)
			{
			}
			num = (short)190054400;
			if (num != 0)
			{
			}
			num = (short)686817281;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.CloningMachine.Clone(this, deepCopy);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00023760 File Offset: 0x00021960
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0002381C File Offset: 0x00021A1C
		[global::System.ComponentModel.DefaultValue(2)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CornerRadiusConverter))]
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				short num = (short)1936982016;
				short num2 = num;
				num = (short)1245504445;
				short num3 = num;
				num = (short)1221649341;
				switch (num3 == num)
				{
				}
				num = (short)509018113;
				if (num != 0)
				{
				}
				num = (short)1360330752;
				if (num != 0)
				{
				}
				return (global::System.Windows.CornerRadius)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CornerRadiusProperty);
			}
			set
			{
				short num = (short)1936785408;
				short num2 = num;
				num = (short)2040005764;
				short num3 = num;
				num = (short)685114500;
				switch (num3 == num)
				{
				}
				num = (short)340918272;
				if (num != 0)
				{
				}
				num = (short)1392246785;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CornerRadiusProperty, value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000238DC File Offset: 0x00021ADC
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00023998 File Offset: 0x00021B98
		[global::System.ComponentModel.Category("Action")]
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				short num = (short)922091520;
				short num2 = num;
				num = (short)1959977000;
				short num3 = num;
				num = (short)838131752;
				switch (num3 == num)
				{
				}
				num = (short)98762753;
				if (num != 0)
				{
				}
				num = (short)38928384;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CommandProperty);
			}
			set
			{
				short num = (short)998244352;
				short num2 = num;
				num = (short)921769420;
				short num3 = num;
				num = (short)961156556;
				switch (num3 == num)
				{
				}
				num = (short)1789198336;
				if (num != 0)
				{
				}
				num = (short)1121976321;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CommandProperty, value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00023A4C File Offset: 0x00021C4C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00023B00 File Offset: 0x00021D00
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Action")]
		public object CommandParameter
		{
			get
			{
				short num = (short)1766391808;
				short num2 = num;
				num = (short)2080237794;
				short num3 = num;
				num = (short)104392930;
				switch (num3 == num)
				{
				}
				num = (short)210632705;
				if (num != 0)
				{
				}
				num = (short)925630464;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CommandParameterProperty);
			}
			set
			{
				short num = (short)446889984;
				short num2 = num;
				num = (short)772526681;
				short num3 = num;
				num = (short)1559220825;
				switch (num3 == num)
				{
				}
				num = (short)23003137;
				if (num != 0)
				{
				}
				num = (short)308674560;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CommandParameterProperty, value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00023BB8 File Offset: 0x00021DB8
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00023C70 File Offset: 0x00021E70
		[global::System.ComponentModel.Category("Action")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.IInputElement CommandTarget
		{
			get
			{
				short num = (short)1806237696;
				short num2 = num;
				num = (short)986929706;
				short num3 = num;
				num = (short)197417514;
				switch (num3 == num)
				{
				}
				num = (short)1651376129;
				if (num != 0)
				{
				}
				num = (short)1665597440;
				if (num != 0)
				{
				}
				return (global::System.Windows.IInputElement)base.GetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CommandTargetProperty);
			}
			set
			{
				short num = (short)870252544;
				short num2 = num;
				num = (short)192885867;
				short num3 = num;
				num = (short)1354773611;
				switch (num3 == num)
				{
				}
				num = (short)372899841;
				if (num != 0)
				{
				}
				num = (short)768212992;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonDropDown.CommandTargetProperty, value);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00023D28 File Offset: 0x00021F28
		private static void OnCommandChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2133393408;
			short num2 = num;
			num = (short)366041801;
			short num3 = num;
			num = (short)1523473097;
			switch (num3 == num)
			{
			}
			num = (short)730791936;
			if (num != 0)
			{
			}
			num = (short)528678913;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonDropDown)d).OnCommandChanged((global::System.Windows.Input.ICommand)e.OldValue, (global::System.Windows.Input.ICommand)e.NewValue);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00023DF4 File Offset: 0x00021FF4
		private void OnCommandChanged(global::System.Windows.Input.ICommand oldCommand, global::System.Windows.Input.ICommand newCommand)
		{
			short num = (short)1025095338;
			short num2 = num;
			num = (short)1239922346;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5F:
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				break;
			default:
				num = (short)722599936;
				if (num != 0)
				{
				}
				num = (short)1351286784;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_69:
				switch (num3)
				{
				case 0:
					goto IL_5F;
				case 1:
					goto IL_15F;
				case 2:
					if (newCommand != null)
					{
						num = (short)51118083;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					this.AddCommand(newCommand);
					num = (short)2066612228;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_E4;
				case 5:
					this.RemoveCommand(oldCommand);
					num = (short)1892614145;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_87;
			}
			IL_E4:
			return;
			IL_15F:
			goto IL_E6;
			IL_87:
			num = (short)791150592;
			short num4 = num;
			if (oldCommand != null)
			{
				num = (short)1364656133;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_69;
			}
			IL_E6:
			num = (short)2021457921;
			if (num != 0)
			{
			}
			num = (short)81657858;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_69;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00023F64 File Offset: 0x00022164
		private void RemoveCommand(global::System.Windows.Input.ICommand oldCommand)
		{
			short num = (short)2115108864;
			short num2 = num;
			num = (short)256442370;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)564920321;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
				{
					num = (short)800318933;
					short num4 = num;
					num = (short)1731519957;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
						num = (short)652214272;
						if (num != 0)
						{
						}
						oldCommand.CanExecuteChanged -= this.m_CanExecuteEventHandler;
						this.m_CanExecuteEventHandler = null;
						num = (short)1838415873;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_114;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				}
				IL_81:
				if (oldCommand == null)
				{
					break;
				}
				num = (short)450494464;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_114:
			IL_116:
			this.UpdateCanExecute();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00024090 File Offset: 0x00022290
		private void AddCommand(global::System.Windows.Input.ICommand newCommand)
		{
			short num = (short)1324744704;
			short num2 = num;
			num = (short)1360199682;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1917408139;
					short num4 = num;
					num = (short)81613707;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_120;
					default:
						num = (short)1843462145;
						if (num != 0)
						{
						}
						num = (short)1943011328;
						if (num != 0)
						{
						}
						this.m_CanExecuteEventHandler = new global::System.EventHandler(this.CanExecuteChanged);
						newCommand.CanExecuteChanged += this.m_CanExecuteEventHandler;
						num = (short)884473857;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_11E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				IL_5B:
				if (newCommand == null)
				{
					break;
				}
				num = (short)763559936;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_11E:
			IL_120:
			this.UpdateCanExecute();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000241C4 File Offset: 0x000223C4
		private void CanExecuteChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)544210944;
			short num2 = num;
			num = (short)631832250;
			short num3 = num;
			num = (short)1379729082;
			switch (num3 == num)
			{
			}
			num = (short)1812660224;
			if (num != 0)
			{
			}
			num = (short)1603403777;
			if (num != 0)
			{
			}
			this.UpdateCanExecute();
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00024274 File Offset: 0x00022474
		protected override bool IsEnabledCore
		{
			get
			{
				short num = (short)484022023;
				short num2 = num;
				num = (short)1705350919;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA;
				case 1:
					break;
				default:
				{
					num = (short)1066598400;
					short num3 = num;
					break;
				}
				}
				num = (short)1916338177;
				if (num != 0)
				{
				}
				num = (short)1399455744;
				if (num != 0)
				{
				}
				if (!base.IsEnabledCore)
				{
					return false;
				}
				IL_AA:
				return this.CanExecute;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00024334 File Offset: 0x00022534
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000243E8 File Offset: 0x000225E8
		private bool CanExecute
		{
			get
			{
				short num = (short)2050752512;
				short num2 = num;
				num = (short)1867779456;
				short num3 = num;
				num = (short)2096762240;
				switch (num3 == num)
				{
				}
				num = (short)2114387968;
				if (num != 0)
				{
				}
				num = (short)282656769;
				if (num != 0)
				{
				}
				return this.m_CanExecute;
			}
			set
			{
				short num = (short)685768704;
				short num2 = num;
				num = (short)1988034562;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)476082573;
						short num4 = num;
						num = (short)559247757;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)451084288;
							if (num != 0)
							{
							}
							this.m_CanExecute = value;
							base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
							num = (short)1073479681;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					num = (short)1889402881;
					if (num != 0)
					{
					}
					if (this.m_CanExecute == value)
					{
						break;
					}
					num = (short)1774190592;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0002450C File Offset: 0x0002270C
		protected virtual void UpdateCanExecute()
		{
			short num = (short)1472397312;
			switch (num)
			{
			default:
			{
				num = (short)1315504216;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender buttonDropDownCommandExtender;
					global::System.Windows.Controls.Image image;
					global::System.Windows.Controls.Image image2;
					global::System.Windows.IInputElement inputElement;
					object commandParameter;
					global::System.Windows.Input.RoutedCommand routedCommand;
					switch (num2)
					{
					case 0:
						if (buttonDropDownCommandExtender != null)
						{
							num = (short)2001403985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)145358857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_C49;
					case 2:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown != null)
						{
							num = (short)994508816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C49;
					}
					case 3:
						num = (short)1793392681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (buttonDropDownCommandExtender == null)
						{
							num = (short)1778581536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 5:
						if (!this.IsDesignMode)
						{
							num = (short)30146626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 6:
						num = (short)1608187930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_BA5;
					case 8:
						image = new global::System.Windows.Controls.Image();
						image.Width = global::DevComponents.WpfRibbon.ButtonDropDown._FixedSmallImageSize.Width;
						image.Height = global::DevComponents.WpfRibbon.ButtonDropDown._FixedSmallImageSize.Height;
						num = (short)631898126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.IsDesignMode)
						{
							num = (short)1530331142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 10:
						if (!((global::System.Windows.Threading.DispatcherObject)CS$<>8__locals1.cp).Dispatcher.CheckAccess())
						{
							num = (short)1939275862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AAC;
					case 11:
						if (this.ImageSmall is global::System.Windows.Controls.Image)
						{
							num = (short)2046361620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 12:
						goto IL_B69;
					case 13:
						if (this.ImagePosition != global::DevComponents.WpfRibbon.eButtonImagePosition.Left)
						{
							num = (short)1817378884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 14:
						goto IL_C16;
					case 15:
						goto IL_38E;
					case 16:
						num = (short)165871652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (CS$<>8__locals1.commandValueChanged)
						{
							num = (short)1481768967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (this.IsDesignMode)
						{
							num = (short)2138505265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						image2 = (this.Image as global::System.Windows.Controls.Image);
						num = (short)627703853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_1DA;
					case 20:
						num = (short)748748821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (((global::System.Windows.Controls.Image)this.ImageSmall).Source != buttonDropDownCommandExtender.ImageSmallSource)
						{
							num = (short)1898381331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 22:
						num = (short)1458765834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1024327753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (this.ImagePosition != global::DevComponents.WpfRibbon.eButtonImagePosition.Left)
						{
							num = (short)615645231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E;
					case 25:
						if (image == null)
						{
							num = (short)1866203144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C16;
					case 26:
						if (this.Image == null)
						{
							num = (short)1591017543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 27:
						num = (short)1450704909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						base.Header = buttonDropDownCommandExtender.Header;
						num = (short)9502775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)894369826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::DevComponents.WpfRibbon.ButtonDropDown;
						num = (short)443154508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::DevComponents.WpfRibbon.IButtonCommandParameter cp = this.CommandParameter as global::DevComponents.WpfRibbon.IButtonCommandParameter;
						bool commandValueChanged = false;
						bool commandIsChedked = false;
						num = (short)212074578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						num = (short)1272578098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (inputElement == null)
						{
							num = (short)732037185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BEA;
					case 34:
						if (this.Image is global::System.Windows.Controls.Image)
						{
							num = (short)211091479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_497;
					case 35:
						goto IL_D57;
					case 36:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown.IsPopupOpen)
						{
							num = (short)594018305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_593;
					}
					case 37:
						num = (short)303956020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)475660290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)1250492427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (this.Image != null)
						{
							num = (short)1165688861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_497;
					case 41:
						if (((global::System.Windows.Controls.Image)this.Image).Source != buttonDropDownCommandExtender.ImageSource)
						{
							num = (short)50724910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E;
					case 42:
						this.CanExecute = this.Command.CanExecute(commandParameter);
						num = (short)436469844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (this.ImageSmall != null)
						{
							num = (short)940965947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 44:
						if (base.Header != null)
						{
							num = (short)1898184731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE2;
					case 45:
						if (image2 == null)
						{
							num = (short)797311043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223;
					case 46:
						goto IL_497;
					case 47:
						goto IL_D2D;
					case 48:
						num = (short)1697579095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)795279361;
						if (num != 0)
						{
						}
						num = (short)1206190138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (this.Command != null)
						{
							num = (short)1798766655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 51:
						num = (short)1568014379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (buttonDropDownCommandExtender.ImageSource != null)
						{
							num = (short)1359020111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E;
					case 53:
						if (buttonDropDownCommandExtender.SyncImageSource)
						{
							num = (short)494141477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E;
					case 54:
						if (buttonDropDownCommandExtender.SyncHeader)
						{
							num = (short)1467351110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76C;
					case 55:
					{
						num = (short)1712455680;
						short num3 = num;
						goto IL_76C;
					}
					case 56:
						if (buttonDropDownCommandExtender.SyncImageSmallSource)
						{
							num = (short)799670320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 57:
						if (buttonDropDownCommandExtender.Header != (string)base.Header)
						{
							num = (short)342818844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76C;
					case 58:
						if (this.Image == null)
						{
							num = (short)256180286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E;
					case 59:
						num = (short)1074528328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_54C;
					case 61:
						goto IL_223;
					case 62:
						num = (short)950992976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						buttonDropDownCommandExtender = global::DevComponents.WpfRibbon.RibbonCommandManager.GetExender(this.Command);
						num = (short)634388557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)1304297496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						inputElement = this;
						num = (short)690552922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)1407189048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						image2 = new global::System.Windows.Controls.Image();
						image2.Stretch = global::System.Windows.Media.Stretch.None;
						num = (short)1547173949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_DE2;
					case 69:
						goto IL_54C;
					case 70:
						num = (short)1960968249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)1218379820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (this.ImageSmall is global::System.Windows.Controls.Image)
						{
							num = (short)1162018855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 73:
						if (this.Image is global::System.Windows.Controls.Image)
						{
							num = (short)141426691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E;
					case 74:
						goto IL_38E;
					case 75:
						if (routedCommand == null)
						{
							num = (short)1393819690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)24379425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (!this.IsDesignMode)
						{
							num = (short)186974246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_593;
					case 77:
						goto IL_3D1;
					case 78:
						goto IL_B69;
					case 79:
					{
						num = (short)430723628;
						short num4 = num;
						num = (short)878006828;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54C;
						default:
							num = (short)1391263744;
							if (num != 0)
							{
							}
							num = (short)198377512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 80:
						if (base.Header != null)
						{
							num = (short)686161984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2D;
					case 81:
						num = (short)674955318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						if (CS$<>8__locals1.cp is global::System.Windows.Threading.DispatcherObject)
						{
							num = (short)1914961942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AAC;
					case 83:
						goto IL_D57;
					case 84:
						goto IL_54C;
					case 85:
						return;
					case 86:
						((global::System.Windows.Threading.DispatcherObject)CS$<>8__locals1.cp).Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action<object>(delegate(object o)
						{
							short num5 = (short)1090935203;
							short num6 = num5;
							num5 = (short)1014323619;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)1535967232;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)233373697;
							if (num5 != 0)
							{
							}
							num5 = (short)615972864;
							if (num5 != 0)
							{
							}
							CS$<>8__locals1.commandValueChanged = CS$<>8__locals1.cp.ValueChanged;
							CS$<>8__locals1.commandIsChedked = CS$<>8__locals1.cp.IsChecked;
						}), null);
						num = (short)806551630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (buttonDropDownCommandExtender.ImageSmallSource != null)
						{
							num = (short)2040266803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D57;
					case 88:
						switch (0)
						{
						case 0:
							goto IL_1B1;
						}
						continue;
					case 89:
						if (this.CommandParameter is global::DevComponents.WpfRibbon.IButtonCommandParameter)
						{
							num = (short)1958019103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 90:
						goto IL_BEA;
					}
					IL_1B1:
					if (this.Command != null)
					{
						num = (short)1466564638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.CanExecute = true;
					num = (short)949026901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DA:
					image = (this.ImageSmall as global::System.Windows.Controls.Image);
					num = (short)130416665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_223:
					image2.Source = buttonDropDownCommandExtender.ImageSource;
					this.Image = image2;
					num = (short)469762063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38E:
					num = (short)2051407877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D1:
					num = (short)1535836160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_497:
					num = (short)1348730898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54C:
					buttonDropDownCommandExtender = (this.Command as global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender);
					num = (short)1275658244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_593:
					this.CanExecute = true;
					num = (short)540409925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76C:
					num = (short)1296760885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AAC:
					CS$<>8__locals1.commandValueChanged = CS$<>8__locals1.cp.ValueChanged;
					CS$<>8__locals1.commandIsChedked = CS$<>8__locals1.cp.IsChecked;
					num = (short)1813839884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B69:
					num = (short)1906114577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BEA:
					this.CanExecute = routedCommand.CanExecute(commandParameter, inputElement);
					num = (short)509411388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C16:
					image.Source = buttonDropDownCommandExtender.ImageSmallSource;
					this.ImageSmall = image;
					num = (short)96665683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C49:
					commandParameter = this.CommandParameter;
					inputElement = this.CommandTarget;
					routedCommand = (this.Command as global::System.Windows.Input.RoutedCommand);
					num = (short)164692043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D2D:
					this.Image = this.GetDesignTimeImageRepresentation();
					num = (short)579076170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D57:
					num = (short)2141519961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE2:
					this.Image = this.GetDesignTimeImageRepresentation();
					num = (short)601686051;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BA5:
				this.IsChecked = CS$<>8__locals1.commandIsChedked;
				CS$<>8__locals1.cp.ValueChanged = false;
				return;
			}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00025484 File Offset: 0x00023684
		private object GetDesignTimeImageRepresentation()
		{
			short num = (short)575733761;
			if (num != 0)
			{
			}
			num = (short)150798336;
			short num2 = num;
			num = (short)157753342;
			short num3 = num;
			num = (short)193535998;
			switch (num3 == num)
			{
			}
			num = (short)1492975616;
			if (num != 0)
			{
			}
			return new global::System.Windows.Shapes.Rectangle
			{
				Fill = global::System.Windows.Media.Brushes.CornflowerBlue,
				StrokeThickness = 1.0,
				Stroke = global::System.Windows.Media.Brushes.RoyalBlue,
				Width = 16.0,
				Height = 16.0
			};
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00025578 File Offset: 0x00023778
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1526598699;
				short num2 = num;
				num = (short)738921515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)972357632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568997377;
				if (num != 0)
				{
				}
				num = (short)1511587840;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly global::System.Windows.DependencyProperty ContentExpandsProperty;

		// Token: 0x04000030 RID: 48
		public static readonly global::System.Windows.DependencyProperty IsPressedProperty;

		// Token: 0x04000031 RID: 49
		private static readonly global::System.Windows.DependencyPropertyKey IsPressedPropertyKey;

		// Token: 0x04000032 RID: 50
		public static readonly global::System.Windows.DependencyProperty IsPopupOpenProperty;

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty RoleProperty;

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty PartVisibilityProperty;

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty FocusChangeKeepsPopupOpenProperty;

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty ColorClassProperty;

		// Token: 0x04000037 RID: 55
		public static readonly global::System.Windows.DependencyProperty IsHighlightedProperty;

		// Token: 0x04000038 RID: 56
		private static readonly global::System.Windows.DependencyPropertyKey IsHighlightedPropertyKey;

		// Token: 0x04000039 RID: 57
		public static readonly global::System.Windows.DependencyProperty IsCheckableProperty;

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty;

		// Token: 0x0400003B RID: 59
		public static readonly global::System.Windows.DependencyProperty ImageProperty;

		// Token: 0x0400003C RID: 60
		public static readonly global::System.Windows.DependencyProperty ImageSmallProperty;

		// Token: 0x0400003D RID: 61
		public static readonly global::System.Windows.DependencyProperty UseSmallImageProperty;

		// Token: 0x0400003E RID: 62
		public static readonly global::System.Windows.DependencyProperty RenderImageProperty;

		// Token: 0x0400003F RID: 63
		private static readonly global::System.Windows.DependencyPropertyKey RenderImagePropertyKey;

		// Token: 0x04000040 RID: 64
		public static readonly global::System.Windows.DependencyProperty WrapLabelProperty;

		// Token: 0x04000041 RID: 65
		public static readonly global::System.Windows.DependencyProperty InlineExpandProperty;

		// Token: 0x04000042 RID: 66
		public static readonly global::System.Windows.DependencyProperty ImagePositionProperty;

		// Token: 0x04000043 RID: 67
		public static readonly global::System.Windows.DependencyProperty ExpandPositionProperty;

		// Token: 0x04000044 RID: 68
		public static readonly global::System.Windows.DependencyProperty StaysOpenOnClickProperty;

		// Token: 0x04000045 RID: 69
		internal static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000046 RID: 70
		public static readonly global::System.Windows.DependencyProperty PopupPlacementProperty;

		// Token: 0x04000047 RID: 71
		public static readonly global::System.Windows.DependencyProperty PopupPlacementTargetProperty;

		// Token: 0x04000048 RID: 72
		public static readonly global::System.Windows.DependencyProperty IsPopupAnimationSuspendedProperty;

		// Token: 0x04000049 RID: 73
		public static readonly global::System.Windows.DependencyProperty InputGestureTextProperty;

		// Token: 0x0400004A RID: 74
		public static readonly global::System.Windows.DependencyProperty IsExpandVisibleProperty;

		// Token: 0x0400004B RID: 75
		private static readonly global::System.Windows.DependencyPropertyKey IsExpandVisiblePropertyKey;

		// Token: 0x0400004C RID: 76
		public static readonly global::System.Windows.DependencyProperty IsSimpleHeaderProperty;

		// Token: 0x0400004D RID: 77
		private static readonly global::System.Windows.DependencyPropertyKey IsSimpleHeaderPropertyKey;

		// Token: 0x0400004E RID: 78
		public static readonly global::System.Windows.DependencyProperty ExpandVisibilityProperty;

		// Token: 0x0400004F RID: 79
		public static readonly global::System.Windows.DependencyProperty PopupTypeProperty;

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty;

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty CommandTargetProperty;

		// Token: 0x04000058 RID: 88
		internal static readonly global::System.Windows.RoutedEvent PreviewClickEvent;

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty;

		// Token: 0x0400005A RID: 90
		public static readonly global::System.Windows.DependencyProperty OptionGroupProperty;

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty IsNestedMenuProperty;

		// Token: 0x0400005C RID: 92
		private const string PopupTemplateName = "PART_Popup";

		// Token: 0x0400005D RID: 93
		private const string ButtonBorderName = "PART_ButtonDropDownBorder";

		// Token: 0x0400005E RID: 94
		private const string ButtonImageName = "PART_ButtonImage";

		// Token: 0x0400005F RID: 95
		private const string ButtonContentName = "PART_ButtonContent";

		// Token: 0x04000060 RID: 96
		private const string ButtonExpandName = "PART_ButtonExpand";

		// Token: 0x04000061 RID: 97
		private const string MenuItemStyleKey = "ButtonDropDownMenuItem";

		// Token: 0x04000062 RID: 98
		private const string ButtonDropDownStyleKey = "ButtonDropDown";

		// Token: 0x04000063 RID: 99
		private const string PartPopupContent = "PART_PopupContent";

		// Token: 0x04000064 RID: 100
		private const string PartExpandInlineName = "PART_ButtonExpandInline";

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Controls.Primitives.Popup m_Popup;

		// Token: 0x04000066 RID: 102
		private global::DevComponents.WpfRibbon.ButtonBorder m_ButtonBorder;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.FrameworkElement m_ButtonImage;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.FrameworkElement m_ButtonContent;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.FrameworkElement m_ButtonExpand;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.FrameworkElement m_ButtonExpandInline;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Controls.Control m_PopupContentControl;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Rect m_ExpandBounds = global::System.Windows.Rect.Empty;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Rect m_CommandBounds = global::System.Windows.Rect.Empty;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Point m_MouseDownPosition = new global::System.Windows.Point(double.MaxValue, double.MaxValue);

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Threading.DispatcherTimer m_DelayPopupOpenTimer;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Threading.DispatcherTimer m_DelayPopupCloseTimer;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Threading.DispatcherTimer m_LivePreviewOpenTimer;

		// Token: 0x04000072 RID: 114
		private global::DevComponents.WpfRibbon.ElementAutoSizeBag m_AutoSizeBag;

		// Token: 0x04000073 RID: 115
		private bool m_RenderBorder = true;

		// Token: 0x04000074 RID: 116
		private static global::System.Windows.Size _FixedSmallImageSize;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Controls.AccessText m_AccessText;

		// Token: 0x04000076 RID: 118
		private bool _RaiseUndoPreview;

		// Token: 0x04000077 RID: 119
		private global::DevComponents.WpfRibbon.ButtonDropDown m_HighlightedChild;

		// Token: 0x04000078 RID: 120
		private bool m_ShowKeyTips;

		// Token: 0x04000079 RID: 121
		internal global::DevComponents.WpfRibbon.KeyTipsAdorner m_KeyTipsAdorner;

		// Token: 0x0400007A RID: 122
		public static readonly global::System.Windows.DependencyProperty ImageSourceProperty;

		// Token: 0x0400007B RID: 123
		public static readonly global::System.Windows.DependencyProperty ImageSmallSourceProperty;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Size m_ImageFixedSize;

		// Token: 0x0400007D RID: 125
		private global::System.EventHandler m_CanExecuteEventHandler;

		// Token: 0x0400007E RID: 126
		private bool m_CanExecute = true;
	}
}
