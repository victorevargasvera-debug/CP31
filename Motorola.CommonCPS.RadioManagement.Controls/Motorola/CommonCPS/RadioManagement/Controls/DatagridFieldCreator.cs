using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Infragistics.Controls.Grids;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000087 RID: 135
	public class DatagridFieldCreator
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00033CFC File Offset: 0x00031EFC
		public static global::Infragistics.Windows.DataPresenter.Field GetUnboundField(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor fieldEditor)
		{
			int a_ = 8;
			short num = (short)1579789925;
			short num2 = num;
			num = (short)2006429285;
			switch (num2 == num)
			{
			}
			num = (short)1008795648;
			short num3 = num;
			num = (short)574881793;
			if (num != 0)
			{
			}
			num = (short)22937600;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮡솣쪥첧\ud9a9햭肯쾱", a_), fieldEditor.Name), global::System.Array.Empty<object>());
			global::Infragistics.Windows.DataPresenter.Field result = new global::Infragistics.Windows.DataPresenter.Field
			{
				Name = fieldEditor.Name,
				Label = fieldEditor.Label,
				Width = new global::Infragistics.Windows.DataPresenter.FieldLength?(fieldEditor.FieldWidth),
				BindingType = global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding,
				AlternateBinding = binding,
				HorizontalContentAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Stretch)
			};
			global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a(fieldEditor, ref result, true);
			return result;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00033E3C File Offset: 0x0003203C
		public static global::Infragistics.Windows.DataPresenter.Field GetUnboundField(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor fieldEditor, int startColumnIndex, bool IsEnable = true)
		{
			int a_ = 13;
			short num = (short)1783221586;
			short num2 = num;
			num = (short)118541650;
			switch (num2 == num)
			{
			}
			num = (short)1952841728;
			short num3 = num;
			num = (short)1311309825;
			if (num != 0)
			{
			}
			num = (short)1990852608;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캦첨잪즬\udcae좲薴쪶", a_), fieldEditor.Name), global::System.Array.Empty<object>());
			global::Infragistics.Windows.DataPresenter.Field result = new global::Infragistics.Windows.DataPresenter.Field
			{
				Name = fieldEditor.Name,
				Label = fieldEditor.Label,
				Width = new global::Infragistics.Windows.DataPresenter.FieldLength?(fieldEditor.FieldWidth),
				Column = startColumnIndex,
				BindingType = global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding,
				AlternateBinding = binding,
				HorizontalContentAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Stretch)
			};
			global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a(fieldEditor, ref result, IsEnable);
			return result;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00033F80 File Offset: 0x00032180
		internal static global::Infragistics.Windows.DataPresenter.Field a(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor A_0, bool A_1 = true)
		{
			int a_ = 15;
			short num = (short)1207423374;
			short num2 = num;
			num = (short)208064910;
			switch (num2 == num)
			{
			}
			num = (short)1408892928;
			short num3 = num;
			num = (short)1711800321;
			if (num != 0)
			{
			}
			num = (short)130088960;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삨캪솬쮮슰캴螶쒸", a_), A_0.Name), global::System.Array.Empty<object>());
			global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field
			{
				Name = A_0.Name,
				Label = A_0.Label,
				Width = new global::Infragistics.Windows.DataPresenter.FieldLength?(A_0.FieldWidth),
				BindingType = global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding,
				AlternateBinding = binding,
				HorizontalContentAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Stretch)
			};
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor));
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty, true);
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, A_0.VisibleIn);
			frameworkElementFactory.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_1);
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, true);
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좨\udfaa첬얰횲\ud8b4馶ﾸ튺\ud8bc펾ꗀ냂黄볆杻뛊郌", a_), field.Name), global::System.Array.Empty<object>())
			};
			frameworkElementFactory.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding2);
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			controlTemplate.VisualTree = frameworkElementFactory;
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate));
			style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욨쒪솬햰\udab2솴\ud8b6쮸\udcbc첾菀곂럄ꏆ곈맊駌꫎볐ꏒ맔뛖귘뻚鯜냞鏠럢諤韦뫨軪駬ꫮ闰髲致黶韸鳺", a_)]));
			field.EditAsType = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
			field.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
			field.Settings.EditorStyle = style;
			return field;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000341E4 File Offset: 0x000323E4
		internal static global::Infragistics.Windows.DataPresenter.Field a(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor A_0, string A_1)
		{
			int a_ = 18;
			short num = (short)135004161;
			if (num != 0)
			{
			}
			num = (short)216896505;
			short num2 = num;
			num = (short)721523705;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1611071488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1124073472;
			if (num != 0)
			{
			}
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슩햫\udead햯삱\ud8b3\udfb5횷톹僚\udabdꦿ뛁ꯃ듅鳇꿉ꇋ뻍볏돑ꃓ돕黗뗙껛諝迟鋡럣菥鳧꿩裫蟭蓯鯱髳釵", a_)]));
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("蒩", a_), global::System.Array.Empty<object>());
			global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field
			{
				Name = A_0.Name,
				Label = A_1,
				BindingType = global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding,
				AlternateBinding = binding,
				HorizontalContentAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Stretch)
			};
			field.EditAsType = typeof(object);
			field.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
			field.Settings.EditorStyle = style;
			return field;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00034360 File Offset: 0x00032560
		public static global::Infragistics.Windows.DataPresenter.Field GetUnboundFieldByFieldName(string fieldName, string fieldLabel, int startColumnIndex, int maxLength, bool IsEnable = true)
		{
			int a_ = 0;
			short num = (short)944913068;
			short num2 = num;
			num = (short)906640044;
			switch (num2 == num)
			{
			}
			num = (short)239337472;
			short num3 = num;
			num = (short)530448385;
			if (num != 0)
			{
			}
			num = (short)1636106240;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ude97鍊쒟톡ﾣ\udda5颧힩", a_), fieldName), global::System.Array.Empty<object>());
			global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field
			{
				Name = fieldName,
				Label = fieldLabel,
				Column = startColumnIndex,
				BindingType = global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding,
				AlternateBinding = binding
			};
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor));
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty, true);
			frameworkElementFactory.SetValue(global::System.Windows.UIElement.IsEnabledProperty, IsEnable);
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty, false);
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udc97ﮙﾝ횡솣쮥蚧얫쮭\udcaf횱잳쎷誹솻", a_), fieldName), global::System.Array.Empty<object>())
			};
			frameworkElementFactory.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding2);
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			controlTemplate.VisualTree = frameworkElementFactory;
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate));
			style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캟얡슥솧\udea9쎫\udcad펱잳ힷ좹\ud8bb\udbbd늿雁ꇃꯅ룇ꛉ귋뫍뗏", a_)]));
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)));
			field.EditAsType = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
			field.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
			field.Settings.EditorStyle = style;
			return field;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000345AC File Offset: 0x000327AC
		public static global::Infragistics.Windows.DataPresenter.Field GetUnboundPreloadFieldByFieldName(string fieldName, string fieldLabel, int startColumnIndex, int maxLength, bool IsEnable = true)
		{
			int a_ = 11;
			short num = (short)1671984675;
			short num2 = num;
			num = (short)1380218403;
			switch (num2 == num)
			{
			}
			num = (short)1157038080;
			short num3 = num;
			num = (short)2016083968;
			if (num != 0)
			{
			}
			num = (short)2033713153;
			if (num != 0)
			{
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힤슦얨쒪첬쮮\udab2킴\udbb6\uddb8좺쒾뻂飄", a_), fieldName), global::System.Array.Empty<object>());
			global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field
			{
				Name = fieldName,
				Label = fieldLabel,
				Column = startColumnIndex,
				BindingType = global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding,
				AlternateBinding = binding
			};
			global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor));
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty, true);
			frameworkElementFactory.SetValue(global::System.Windows.UIElement.IsEnabledProperty, IsEnable);
			frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty, false);
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒤펦좨\ud9ac쪮\udcb0鶲얶\udcb8ힺ튼\udebeꗀ藂계ꋆꗈ꿊뻌铎꫐꣔論", a_), fieldName), global::System.Array.Empty<object>())
			};
			frameworkElementFactory.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding2);
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			controlTemplate.VisualTree = frameworkElementFactory;
			style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor));
			frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty, true);
			frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, true);
			frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty, false);
			global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒤펦좨\ud9ac쪮\udcb0鶲얶\udcb8ힺ튼\udebeꗀ藂계ꋆꗈ꿊뻌铎꫐꣔論", a_), fieldName), global::System.Array.Empty<object>())
			};
			frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding3);
			global::System.Windows.Controls.ControlTemplate controlTemplate2 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
			controlTemplate2.VisualTree = frameworkElementFactory2;
			style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, controlTemplate2));
			field.Settings.EditorStyle = style;
			return field;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00034838 File Offset: 0x00032A38
		private static void a(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor A_0, ref global::Infragistics.Windows.DataPresenter.Field A_1, bool A_2 = true)
		{
			int a_ = 18;
			short num = (short)1395130368;
			switch (num)
			{
			default:
			{
				num = (short)1971650580;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.FrameworkElementFactory frameworkElementFactory;
				global::System.Windows.Style style2;
				for (;;)
				{
					global::System.Windows.Style style;
					switch (num2)
					{
					case 0:
					{
						num = (short)1393491968;
						short num3 = num;
						global::System.Windows.Data.Binding binding2;
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즫춭\udfaf삱킳颵ﲷ\udbb9좻\udfbd覿뛁ꇃꯅ뇉ﳋ돍", a_), binding2.Path.Path), global::System.Array.Empty<object>()),
							Converter = binding2.Converter,
							RelativeSource = new global::System.Windows.Data.RelativeSource
							{
								AncestorType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter)
							}
						};
						frameworkElementFactory.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.ContentTextProperty, binding);
						num = (short)987955221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)118030345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_130;
					case 3:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a.IsMatch((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask))
						{
							num = (short)831324172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					case 4:
						if ((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowDecimalEditor)
						{
							num = (short)1318387738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CFC;
					case 5:
						if (!(A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowHexEditor)
						{
							num = (short)191496193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CFC;
					case 6:
						if ((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).IsSortAsDecimal)
						{
							num = (short)1748172836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						style = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
						global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor));
						frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).VisibleIn);
						frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).Mask);
						frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.UpperCaseOnlyProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).UpperCaseOnly);
						frameworkElementFactory2.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
						frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty, false);
						frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.PlayButtonVisibleProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).PlayButtonVisible);
						global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
						};
						frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding3);
						global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
						controlTemplate.VisualTree = frameworkElementFactory2;
						style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate));
						num = (short)1162936351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1917190147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!(A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowOctEditor)
						{
							num = (short)835452958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CFC;
					case 10:
					{
						frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(A_0.GetType());
						A_0.SetPreviewModeProperties(frameworkElementFactory);
						global::System.Windows.Data.Binding binding2 = global::System.Windows.Data.BindingOperations.GetBinding(A_0, global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.ContentTextProperty);
						num = (short)1315045408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_33B;
					case 12:
						style2.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.TagProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask));
						num = (short)1138163740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_12B;
					case 14:
					{
						style2 = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
						global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor));
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).VisibleIn);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsStepIgnored);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).HexMask);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowDecimalEditor);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowHexEditor);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowOctEditor);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsHex);
						frameworkElementFactory3.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
						global::System.Windows.Data.Binding binding4 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
						};
						frameworkElementFactory3.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding4);
						global::System.Windows.Controls.ControlTemplate controlTemplate2 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
						controlTemplate2.VisualTree = frameworkElementFactory3;
						style2.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate2));
						num = (short)1962803204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_678;
					case 16:
						if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)
						{
							num = (short)86638614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1618477075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a.IsMatch((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).Mask))
						{
							num = (short)713031714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F3;
					case 18:
						goto IL_130;
					case 19:
						if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)
						{
							num = (short)1092419598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)477560859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_E0;
						}
						continue;
					case 21:
						goto IL_4E0;
					case 22:
						goto IL_11A1;
					case 23:
						if (A_0.IsPreviewModeSupport)
						{
							num = (short)96075786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1 = null;
						num = (short)1575551000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_5E6;
					case 25:
						goto IL_CF7;
					case 26:
						num = (short)1755774981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)
						{
							num = (short)609353735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)867368995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_5EB;
					case 29:
					{
						num = (short)1936292814;
						short num4 = num;
						num = (short)550337486;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33B;
						default:
							num = (short)1081016320;
							if (num != 0)
							{
							}
							if ((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask != null)
							{
								num = (short)2146369544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5EB;
						}
						break;
					}
					case 30:
						num = (short)1678376989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if ((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).Mask != null)
						{
							num = (short)1633878027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F3;
					case 32:
					{
						global::System.Windows.Data.Binding binding2;
						if (binding2 != null)
						{
							num = (short)1942290432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_108B;
					}
					case 33:
						goto IL_EA3;
					case 34:
						style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.FrameworkElement.TagProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).Mask));
						style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒩\ud9ab쎭햯삱\uddb3햵ﶷ\udeb9햻쪽꾿냁郃ꏅꗇ뫉ꃋ꿍꓏럑", a_)]));
						num = (short)1285881858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor)
						{
							num = (short)1187315737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1534590999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_1C0;
					}
					IL_E0:
					num = (short)758185985;
					if (num != 0)
					{
					}
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)
					{
						num = (short)1191641101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2014838800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_130:
					style.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)));
					A_1.EditAsType = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
					A_1.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
					A_1.Settings.EditorStyle = style;
					num = (short)42729478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33B:
					num = (short)848494609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EB:
					style2.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒩\ud9ab쎭햯삱\uddb3햵ﶷ\udeb9햻쪽꾿냁郃ꏅꗇ뫉ꃋ꿍꓏럑", a_)]));
					style2.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)));
					A_1.EditAsType = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
					A_1.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
					num = (short)881393679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CFC:
					global::System.Windows.FrameworkElementFactory frameworkElementFactory4 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor));
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsEditorOnlyProperty, true);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).VisibleIn);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsStepIgnored);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).HexMask);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowDecimalEditor);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowHexEditor);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowOctEditor);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsHex);
					frameworkElementFactory4.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
					frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, true);
					global::System.Windows.Data.Binding binding5 = new global::System.Windows.Data.Binding
					{
						Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
					};
					frameworkElementFactory4.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding5);
					global::System.Windows.Controls.ControlTemplate controlTemplate3 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
					controlTemplate3.VisualTree = frameworkElementFactory4;
					style2.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, controlTemplate3));
					num = (short)1984626721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F3:
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a9\ud8ab\udcad\ud9af\udcb1펳\udcb7펹좻톽늿諁ꗃ뗅談ꗉ뻋꫍뗏ꃑ胓돕뗗꫙냛뿝铟蟡", a_)]));
					num = (short)1409024018;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12B:
				global::System.Windows.Style style3 = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory5 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor));
				frameworkElementFactory5.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsEditorOnlyProperty, true);
				frameworkElementFactory5.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor).VisibleIn);
				frameworkElementFactory5.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsSortRequiredProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor).IsSortRequired);
				frameworkElementFactory5.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
				global::System.Windows.Data.Binding binding6 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory5.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding6);
				global::System.Windows.Controls.ControlTemplate controlTemplate4 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				controlTemplate4.VisualTree = frameworkElementFactory5;
				style3.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate4));
				style3.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a9\ud8ab\udcad\ud9af\udcb1펳\udcb7펹좻톽늿諁ꗃ뗅談ꗉ뻋꫍뗏ꃑ胓돕뗗꫙냛뿝铟蟡", a_)]));
				style3.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)));
				A_1.EditAsType = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
				A_1.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
				A_1.Settings.EditorStyle = style3;
				return;
				IL_1C0:
				A_1.Settings.SortComparer = new global::Motorola.CommonCPS.RadioManagement.Controls.DecimalComparer();
				return;
				IL_4E0:
				goto IL_108B;
				IL_5E6:
				return;
				IL_678:
				goto IL_EA5;
				IL_CF7:
				global::System.Windows.Style style4 = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory6 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor));
				frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsEditorOnlyProperty, true);
				frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor).VisibleIn);
				frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor).Mask);
				frameworkElementFactory6.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
				frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsShowingEyeButtonProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor).IsShowingEyeButton);
				global::System.Windows.Data.Binding binding7 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory6.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding7);
				global::System.Windows.Controls.ControlTemplate controlTemplate5 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				controlTemplate5.VisualTree = frameworkElementFactory6;
				style4.Setters.Add(new global::System.Windows.Setter(global::Infragistics.Windows.Editors.ValueEditor.EditTemplateProperty, controlTemplate5));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory7 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor));
				frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsEditorOnlyProperty, true);
				frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor).VisibleIn);
				frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor).Mask);
				frameworkElementFactory7.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
				frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, true);
				frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsShowingEyeButtonProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor).IsShowingEyeButton);
				global::System.Windows.Data.Binding binding8 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory7.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding8);
				global::System.Windows.Controls.ControlTemplate controlTemplate6 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				controlTemplate6.VisualTree = frameworkElementFactory7;
				style4.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, controlTemplate6));
				A_1.Settings.LabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
				A_1.Settings.EditorStyle = style4;
				return;
				IL_EA3:
				IL_EA5:
				A_1.Settings.EditorStyle = style2;
				A_1.Settings.SortComparer = new global::Motorola.CommonCPS.RadioManagement.Controls.RangeFieldComparer();
				return;
				IL_108B:
				global::System.Windows.Data.Binding binding9 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즫춭\udfaf삱킳颵ﲷ\udbb9좻\udfbd覿뛁ꇃꯅ賉ꗋꯍ볏뛑ꟓ跕ꏗꇛ菝", a_), A_1.Name), global::System.Array.Empty<object>()),
					RelativeSource = new global::System.Windows.Data.RelativeSource
					{
						AncestorType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter)
					}
				};
				frameworkElementFactory.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding9);
				global::System.Windows.DataTemplate dataTemplate = new global::System.Windows.DataTemplate();
				dataTemplate.VisualTree = frameworkElementFactory;
				global::System.Windows.Style style5 = new global::System.Windows.Style(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));
				style5.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.ContentControl.ContentTemplateProperty, dataTemplate));
				style5.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.BorderThicknessProperty, new global::System.Windows.Thickness(0.0)));
				A_1.Settings.CellValuePresenterStyle = style5;
				return;
				IL_11A1:
				global::System.Windows.Style style6 = new global::System.Windows.Style(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory8 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor));
				frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty, true);
				frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor).VisibleIn);
				frameworkElementFactory8.SetValue(global::System.Windows.UIElement.IsEnabledProperty, A_2);
				frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, true);
				global::System.Windows.Data.Binding binding10 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\udaad톯ﮱ삳펵햷钹請ힽꖿ껁ꃃ뗅鏇뇉ﳋ돍跏", a_), A_1.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory8.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding10);
				global::System.Windows.Controls.ControlTemplate controlTemplate7 = new global::System.Windows.Controls.ControlTemplate(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor));
				controlTemplate7.VisualTree = frameworkElementFactory8;
				style6.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, controlTemplate7));
				A_1.EditAsType = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
				A_1.EditorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.CustomValueEditor);
				A_1.Settings.EditorStyle = style6;
				return;
			}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00035A8C File Offset: 0x00033C8C
		public static global::Infragistics.Controls.Grids.UnboundColumn GetUnboundColumnByFieldEditor(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor fieldEditor, int startColumnIndex, bool isTopset, bool isEnable = true)
		{
			int a_ = 13;
			short num = (short)222035968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::Infragistics.Controls.Grids.UnboundColumn unboundColumn;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						num = (short)1588985856;
						short num3 = num;
						global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Control));
						frameworkElementFactory.SetValue(global::System.Windows.FrameworkElement.StyleProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좤슦\udba8첪좬풰\udfb2\ud9b4횸햺즼\udabe꿀럂蛄꣆ꟈ뿊뿌ꃎ뷐胒ꇔ껖뗘뻚", a_)]);
						num = (short)859701262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Control));
						frameworkElementFactory2.SetValue(global::System.Windows.FrameworkElement.StyleProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좤슦\udba8첪좬풰\udfb2\ud9b4횸햺즼\udabe꿀럂蛄꣆ꟈ뿊뿌ꃎ뷐胒ꇔ껖뗘뻚", a_)]);
						num = (short)1430126599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return unboundColumn;
					case 3:
						return unboundColumn;
					case 4:
						if (fieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)
						{
							num = (short)1938489344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)500170762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						unboundColumn.ValueConverterParameter = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udea4鞦풨힪횬麮첰", a_), isTopset ? global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦\udba8캪쎬\udbae횲솴", a_) : global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾦삨잪즬ﲮ풰잲", a_), fieldEditor.Name);
						num = (short)1897660432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (fieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)
						{
							num = (short)108920844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)509542404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬膮쪰莲좴馶ﾸ튺\ud8bc펾ꗀ냂黄볆뛊郌", a_), isTopset ? global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦\udba8캪쎬\udbae횲솴", a_) : global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾦삨잪즬ﲮ풰잲", a_), fieldEditor.Name), global::System.Array.Empty<object>())
						};
						global::System.Windows.FrameworkElementFactory frameworkElementFactory2;
						frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding);
						global::System.Windows.DataTemplate dataTemplate = new global::System.Windows.DataTemplate();
						dataTemplate.VisualTree = frameworkElementFactory2;
						dataTemplate.Seal();
						unboundColumn.MergedItemTemplate = dataTemplate;
						unboundColumn.ItemTemplate = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펦\udba8슪쎬좮ힲ\udcb4쎶횸즺寮\udebe뗀ꋂ釄ꋆ꓈믊ꇌ껎ꗐ뛒", a_)] as global::System.Windows.DataTemplate);
						global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor));
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty, true);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).VisibleIn);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.MaskProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).Mask);
						frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.UpperCaseOnlyProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).UpperCaseOnly);
						frameworkElementFactory3.SetValue(global::System.Windows.UIElement.IsEnabledProperty, isEnable);
						frameworkElementFactory3.SetValue(global::System.Windows.FrameworkElement.HeightProperty, 24.0);
						frameworkElementFactory3.SetValue(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(4.0, 0.0, 4.0, 0.0));
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬", a_), global::System.Array.Empty<object>())
						};
						frameworkElementFactory3.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding2);
						global::System.Windows.DataTemplate dataTemplate2 = new global::System.Windows.DataTemplate();
						dataTemplate2.VisualTree = frameworkElementFactory3;
						dataTemplate2.Seal();
						unboundColumn.EditorTemplate = dataTemplate2;
						num = (short)143523841;
						if (num != 0)
						{
						}
						num = (short)625147906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Windows.FrameworkElementFactory frameworkElementFactory4 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Control));
						frameworkElementFactory4.SetValue(global::System.Windows.FrameworkElement.StyleProperty, global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좤슦\udba8첪좬풰\udfb2\ud9b4횸햺즼\udabe꿀럂蛄꣆ꟈ뿊뿌ꃎ뷐胒ꇔ껖뗘뻚", a_)]);
						num = (short)1511456781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬膮쪰莲좴馶ﾸ튺\ud8bc펾ꗀ냂黄볆뛊郌", a_), isTopset ? global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦\udba8캪쎬\udbae횲솴", a_) : global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾦삨잪즬ﲮ풰잲", a_), fieldEditor.Name), global::System.Array.Empty<object>())
						};
						global::System.Windows.FrameworkElementFactory frameworkElementFactory5;
						frameworkElementFactory5.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding3);
						global::System.Windows.DataTemplate dataTemplate3 = new global::System.Windows.DataTemplate();
						dataTemplate3.VisualTree = frameworkElementFactory5;
						dataTemplate3.Seal();
						unboundColumn.MergedItemTemplate = dataTemplate3;
						global::System.Windows.FrameworkElementFactory frameworkElementFactory6 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor));
						frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty, true);
						frameworkElementFactory6.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor).VisibleIn);
						frameworkElementFactory6.SetValue(global::System.Windows.UIElement.IsEnabledProperty, isEnable);
						global::System.Windows.Data.Binding binding4 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬", a_), global::System.Array.Empty<object>())
						};
						frameworkElementFactory6.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding4);
						global::System.Windows.DataTemplate dataTemplate4 = new global::System.Windows.DataTemplate();
						dataTemplate4.VisualTree = frameworkElementFactory6;
						dataTemplate4.Seal();
						unboundColumn.ItemTemplate = dataTemplate4;
						num = (short)1727528963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (fieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)
						{
							num = (short)982777864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return unboundColumn;
					case 11:
						return unboundColumn;
					case 12:
					{
						global::System.Windows.FrameworkElementFactory frameworkElementFactory5 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor));
						frameworkElementFactory5.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory5.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, true);
						num = (short)634322953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Windows.Data.Binding binding5 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬膮쪰莲좴馶ﾸ튺\ud8bc펾ꗀ냂黄볆뛊郌", a_), isTopset ? global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦\udba8캪쎬\udbae횲솴", a_) : global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾦삨잪즬ﲮ풰잲", a_), fieldEditor.Name), global::System.Array.Empty<object>())
						};
						global::System.Windows.FrameworkElementFactory frameworkElementFactory4;
						frameworkElementFactory4.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding5);
						global::System.Windows.DataTemplate dataTemplate5 = new global::System.Windows.DataTemplate();
						dataTemplate5.VisualTree = frameworkElementFactory4;
						dataTemplate5.Seal();
						unboundColumn.MergedItemTemplate = dataTemplate5;
						unboundColumn.ItemTemplate = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펦\udba8슪쎬좮ힲ\udcb4쎶횸즺寮\udebe뗀ꋂ釄ꋆ꓈믊ꇌ껎ꗐ뛒", a_)] as global::System.Windows.DataTemplate);
						global::System.Windows.FrameworkElementFactory frameworkElementFactory7 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor));
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty, true);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).VisibleIn);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsStepIgnored);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).HexMask);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowDecimalEditor);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowHexEditor);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowOctEditor);
						frameworkElementFactory7.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsHex);
						frameworkElementFactory7.SetValue(global::System.Windows.UIElement.IsEnabledProperty, isEnable);
						frameworkElementFactory7.SetValue(global::System.Windows.FrameworkElement.HeightProperty, 24.0);
						frameworkElementFactory7.SetValue(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(4.0, 0.0, 4.0, 0.0));
						global::System.Windows.Data.Binding binding6 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬", a_), global::System.Array.Empty<object>())
						};
						frameworkElementFactory7.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding6);
						global::System.Windows.DataTemplate dataTemplate6 = new global::System.Windows.DataTemplate();
						dataTemplate6.VisualTree = frameworkElementFactory7;
						dataTemplate6.Seal();
						unboundColumn.EditorTemplate = dataTemplate6;
						num = (short)1908342795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::System.Windows.Data.Binding binding7 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬膮쪰莲좴馶ﾸ튺\ud8bc펾ꗀ냂黄볆뛊郌", a_), isTopset ? global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦\udba8캪쎬\udbae횲솴", a_) : global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾦삨잪즬ﲮ풰잲", a_), fieldEditor.Name), global::System.Array.Empty<object>())
						};
						global::System.Windows.FrameworkElementFactory frameworkElementFactory;
						frameworkElementFactory.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding7);
						global::System.Windows.DataTemplate dataTemplate7 = new global::System.Windows.DataTemplate();
						dataTemplate7.VisualTree = frameworkElementFactory;
						dataTemplate7.Seal();
						unboundColumn.MergedItemTemplate = dataTemplate7;
						unboundColumn.ItemTemplate = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펦\udba8슪쎬좮ힲ\udcb4쎶횸즺寮\udebe뗀ꋂ釄ꋆ꓈믊ꇌ껎ꗐ뛒", a_)] as global::System.Windows.DataTemplate);
						global::System.Windows.FrameworkElementFactory frameworkElementFactory8 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor));
						frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsEditorOnlyProperty, true);
						frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty, true);
						frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor).VisibleIn);
						frameworkElementFactory8.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsSortRequiredProperty, (fieldEditor as global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor).IsSortRequired);
						frameworkElementFactory8.SetValue(global::System.Windows.UIElement.IsEnabledProperty, isEnable);
						frameworkElementFactory8.SetValue(global::System.Windows.FrameworkElement.HeightProperty, 24.0);
						frameworkElementFactory8.SetValue(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(4.0, 0.0, 4.0, 0.0));
						global::System.Windows.Data.Binding binding8 = new global::System.Windows.Data.Binding
						{
							Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욦얨\udeaa좬", a_), global::System.Array.Empty<object>())
						};
						frameworkElementFactory8.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding8);
						global::System.Windows.DataTemplate dataTemplate8 = new global::System.Windows.DataTemplate();
						dataTemplate8.VisualTree = frameworkElementFactory8;
						dataTemplate8.Seal();
						unboundColumn.EditorTemplate = dataTemplate8;
						num = (short)1864499215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						return unboundColumn;
					case 16:
					{
						num = (short)317339245;
						short num4 = num;
						num = (short)275002989;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return unboundColumn;
						default:
							num = (short)2116878336;
							if (num != 0)
							{
							}
							if (fieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)
							{
								num = (short)1953562625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1233125382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_7B;
				}
				return unboundColumn;
				IL_7B:
				unboundColumn = new global::Infragistics.Controls.Grids.UnboundColumn
				{
					Key = fieldEditor.Name,
					HeaderText = fieldEditor.Label,
					VerticalContentAlignment = global::System.Windows.VerticalAlignment.Stretch,
					HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Stretch
				};
				unboundColumn.ValueConverter = new global::Motorola.CommonCPS.RadioManagement.Controls.UnboundColumnValueConverter();
				num = (short)1748107269;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00036664 File Offset: 0x00034864
		// Note: this type is marked as 'beforefieldinit'.
		static DatagridFieldCreator()
		{
			int a_ = 17;
			short num = (short)393869359;
			short num2 = num;
			num = (short)566229039;
			switch (num2 == num)
			{
			}
			num = (short)1242234881;
			if (num != 0)
			{
			}
			num = (short)1509425152;
			if (num != 0)
			{
			}
			num = (short)1714225152;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킪즬삮쒰톲\ud9b4튶膺閼銾ﻀ鿂ꇄ里ꯎ껒", a_));
		}

		// Token: 0x0400010D RID: 269
		private static readonly global::System.Text.RegularExpressions.Regex a;
	}
}
