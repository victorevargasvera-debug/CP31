using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000093 RID: 147
	public class RMListBoxFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00039804 File Offset: 0x00037A04
		public RMListBoxFieldEditor()
		{
			this.InitializeComponent();
			base.DataContextChanged += this.RMListBoxFieldEditor_DataContextChanged;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00039830 File Offset: 0x00037A30
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter SetPresenter
		{
			get
			{
				short num = (short)595744187;
				short num2 = num;
				num = (short)1420318139;
				switch (num2 == num)
				{
				}
				num = (short)388956161;
				if (num != 0)
				{
				}
				num = (short)1285357568;
				short num3 = num;
				num = (short)308805632;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.SetPresenterProperty);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000398EC File Offset: 0x00037AEC
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000399A4 File Offset: 0x00037BA4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory EmbeddedSetCategory
		{
			get
			{
				short num = (short)1161247920;
				short num2 = num;
				num = (short)260848816;
				switch (num2 == num)
				{
				}
				num = (short)775553024;
				if (num != 0)
				{
				}
				num = (short)1657405440;
				short num3 = num;
				num = (short)23265281;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.EmbeddedSetCategoryProperty);
			}
			set
			{
				short num = (short)1773042743;
				short num2 = num;
				num = (short)1215593527;
				switch (num2 == num)
				{
				}
				num = (short)2085158913;
				if (num != 0)
				{
				}
				num = (short)1886322688;
				short num3 = num;
				num = (short)1063911424;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.EmbeddedSetCategoryProperty, value);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00039A58 File Offset: 0x00037C58
		public void RMListBoxFieldEditor_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1035446724;
			short num2 = num;
			num = (short)1067690436;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_142:
				if (!base.IsLoaded)
				{
					base.Loaded += this.RMListBoxFieldEditor_Loaded;
					return;
				}
				num = (short)2121859075;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)331939841;
				if (num != 0)
				{
				}
				num = (short)1320026112;
				if (num != 0)
				{
				}
				num = (short)923009026;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					if (!(base.DataContext is global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField))
					{
						num = (short)83099653;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField = (global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)base.DataContext;
					this.a(collectionField);
					this.EmbeddedSetCategory = collectionField.SetCategory;
					this.EmbeddedSetCategory.SelectedSets.Clear();
					num = (short)228065280;
					short num4 = num;
					num = (short)107413505;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_142;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 3:
					goto IL_161;
				case 4:
					num = (short)1902116864;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1B7;
				}
				IL_AF:
				if (base.DataContext == null)
				{
					goto IL_163;
				}
				num = (short)119537668;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_161:
			this.a();
			return;
			IL_163:
			this.EmbeddedSetCategory = null;
			base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.SetPresenterProperty, null);
			return;
			IL_1B7:
			goto IL_163;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00039C38 File Offset: 0x00037E38
		private void RMListBoxFieldEditor_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)169829766;
			short num2 = num;
			num = (short)584410502;
			switch (num2 == num)
			{
			}
			num = (short)1704984576;
			if (num != 0)
			{
			}
			num = (short)563150848;
			short num3 = num;
			num = (short)1016987649;
			if (num != 0)
			{
			}
			this.a();
			base.Loaded -= this.RMListBoxFieldEditor_Loaded;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00039CF8 File Offset: 0x00037EF8
		private void a()
		{
			short num = (short)633659074;
			short num2 = num;
			num = (short)1790107330;
			switch (num2 == num)
			{
			}
			num = (short)471728129;
			if (num != 0)
			{
			}
			num = (short)1131020288;
			short num3 = num;
			num = (short)1848311808;
			if (num != 0)
			{
			}
			base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.SetPresenterProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b(this));
			this.SetPresenter.AddEmbeddedSetCommand.RaiseCanExecuteChanged();
			this.SetPresenter.DeleteEmbeddedSetsForListBoxCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00039DD0 File Offset: 0x00037FD0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField A_0)
		{
			int a_ = 4;
			short num;
			for (;;)
			{
				num = (short)443416576;
				switch (num)
				{
				default:
				{
					num = (short)594372786;
					short num2 = num;
					num = (short)1493199026;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5C;
					}
					break;
				}
				}
			}
			IL_5C:
			num = (short)1252196352;
			if (num != 0)
			{
			}
			num = (short)1610481664;
			short num3 = num;
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Border));
			frameworkElementFactory.SetValue(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(25.0, 2.0, 0.0, 2.0));
			frameworkElementFactory.SetValue(global::System.Windows.Controls.Border.BorderThicknessProperty, new global::System.Windows.Thickness(0.0, 1.0, 0.0, 0.0));
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
			{
				Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.IsValidToBroderBrushConverter(),
				Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햛쎡좣쾥첧", a_), global::System.Array.Empty<object>())
			};
			frameworkElementFactory.SetBinding(global::System.Windows.Controls.Border.BorderBrushProperty, binding);
			global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Grid));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.RowDefinition));
			frameworkElementFactory3.SetValue(global::System.Windows.Controls.RowDefinition.HeightProperty, global::System.Windows.GridLength.Auto);
			global::System.Windows.FrameworkElementFactory frameworkElementFactory4 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.RowDefinition));
			frameworkElementFactory4.SetValue(global::System.Windows.Controls.RowDefinition.HeightProperty, new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Star));
			frameworkElementFactory2.AppendChild(frameworkElementFactory3);
			frameworkElementFactory2.AppendChild(frameworkElementFactory4);
			global::System.Windows.FrameworkElementFactory frameworkElementFactory5 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Button));
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
			{
				RelativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor), 1),
				Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ풟횣쎥\udba7쾩슫\udaad햯삱骳\uddb7횹\ud9bb쪽ꖿ蟁꧃꓅귇껉꣋ꯍ듏臑뇓ꋕꯗ鳙돛곝곟诡韣鋥ꫧ藩铫귭鿯鿱駳韵雷黹", a_), global::System.Array.Empty<object>())
			};
			frameworkElementFactory5.SetBinding(global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty, binding2);
			global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding
			{
				Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.SetToSetCategoryConverter(),
				Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("늛", a_), global::System.Array.Empty<object>())
			};
			frameworkElementFactory5.SetBinding(global::System.Windows.Controls.Primitives.ButtonBase.CommandParameterProperty, binding3);
			frameworkElementFactory5.SetValue(global::System.Windows.Controls.Grid.RowProperty, 0);
			frameworkElementFactory5.SetValue(global::System.Windows.Controls.Control.PaddingProperty, new global::System.Windows.Thickness(0.0));
			frameworkElementFactory5.SetValue(global::System.Windows.FrameworkElement.MarginProperty, new global::System.Windows.Thickness(2.0, 2.0, 0.0, 0.0));
			frameworkElementFactory5.SetValue(global::System.Windows.FrameworkElement.WidthProperty, 32.0);
			frameworkElementFactory5.SetValue(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, global::System.Windows.HorizontalAlignment.Left);
			global::System.Windows.Style value = base.TryFindResource(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ude9b풟횡쮣좥쾩삫쮭쒯ힱ습솷횹\ud9bb", a_)) as global::System.Windows.Style;
			frameworkElementFactory5.SetValue(global::System.Windows.FrameworkElement.StyleProperty, value);
			frameworkElementFactory2.AppendChild(frameworkElementFactory5);
			global::System.Windows.FrameworkElementFactory frameworkElementFactory6 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ItemsControl));
			frameworkElementFactory6.SetValue(global::System.Windows.Controls.Grid.RowProperty, 1);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> fieldEditorList = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.GetSetEditor(A_0.SetCategory.Name, A_0.SetCategory.TelePortMode, false).GetFieldEditorList();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>.Enumerator enumerator = fieldEditorList.GetEnumerator())
			{
				num = (short)1946681347;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::System.Windows.FrameworkElementFactory frameworkElementFactory7;
						frameworkElementFactory6.AppendChild(frameworkElementFactory7);
						num = (short)409731073;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1362100228;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor a_2 = enumerator.Current;
						global::System.Windows.FrameworkElementFactory frameworkElementFactory7 = this.a(a_2);
						num = (short)2115305477;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3C6;
						}
						continue;
					case 4:
						num = (short)1018429446;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Windows.FrameworkElementFactory frameworkElementFactory7;
						if (frameworkElementFactory7 != null)
						{
							num = (short)437583872;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_4B2;
					}
					IL_40C:
					num = (short)1457913857;
					if (num != 0)
					{
					}
					num = (short)841940994;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C6:
					goto IL_40C;
				}
				IL_4B2:;
			}
			frameworkElementFactory2.AppendChild(frameworkElementFactory6);
			global::System.Windows.DataTemplate dataTemplate = new global::System.Windows.DataTemplate();
			frameworkElementFactory.AppendChild(frameworkElementFactory2);
			dataTemplate.VisualTree = frameworkElementFactory;
			dataTemplate.Seal();
			this.iclSets.ItemTemplate = dataTemplate;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0003A2F0 File Offset: 0x000384F0
		private global::System.Windows.FrameworkElementFactory a(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor A_0)
		{
			int a_ = 9;
			short num = (short)1893728256;
			switch (num)
			{
			default:
			{
				num = (short)853147654;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_25B;
					case 1:
						goto IL_4A4;
					case 2:
						goto IL_21A;
					case 3:
						if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)
						{
							num = (short)654376960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)213319684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1163329536;
						short num3 = num;
						num = (short)1195221575;
						short num4 = num;
						num = (short)903062087;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4A4;
						default:
							num = (short)840433665;
							if (num != 0)
							{
							}
							num = (short)310444032;
							if (num != 0)
							{
							}
							if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)
							{
								num = (short)1966014466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1382285317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)
						{
							num = (short)582025217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_533;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 7:
						goto IL_8E;
					}
					IL_6D:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)
					{
						num = (short)914620423;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1584463875;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_8E:
				global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor));
				frameworkElementFactory.SetValue(global::System.Windows.FrameworkElement.TagProperty, A_0.Name);
				frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).VisibleIn);
				frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).Mask);
				frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.UpperCaseOnlyProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor).UpperCaseOnly);
				frameworkElementFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty, A_0.Label);
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪢삤쮦춨\ud8aa풮膰캲", a_), A_0.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding);
				return frameworkElementFactory;
				IL_21A:
				global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor));
				frameworkElementFactory2.SetValue(global::System.Windows.FrameworkElement.TagProperty, A_0.Name);
				frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor).VisibleIn);
				frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsSortRequiredProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor).IsSortRequired);
				frameworkElementFactory2.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty, A_0.Label);
				global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪢삤쮦춨\ud8aa풮膰캲", a_), A_0.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding2);
				return frameworkElementFactory2;
				IL_25B:
				global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor));
				frameworkElementFactory3.SetValue(global::System.Windows.FrameworkElement.TagProperty, A_0.Name);
				frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor).VisibleIn);
				frameworkElementFactory3.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty, A_0.Label);
				global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪢삤쮦춨\ud8aa풮膰캲", a_), A_0.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory3.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding3);
				return frameworkElementFactory3;
				IL_4A4:
				global::System.Windows.FrameworkElementFactory frameworkElementFactory4 = new global::System.Windows.FrameworkElementFactory(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor));
				frameworkElementFactory4.SetValue(global::System.Windows.FrameworkElement.TagProperty, A_0.Name);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).VisibleIn);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).Mask);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsStepIgnored);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).HexMask);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowDecimalEditor);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowHexEditor);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).ShowOctEditor);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty, (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor).IsHex);
				frameworkElementFactory4.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty, A_0.Label);
				global::System.Windows.Data.Binding binding4 = new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪢삤쮦춨\ud8aa풮膰캲", a_), A_0.Name), global::System.Array.Empty<object>())
				};
				frameworkElementFactory4.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding4);
				return frameworkElementFactory4;
				IL_533:
				return null;
			}
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0003A834 File Offset: 0x00038A34
		public void SetActiveRow(string activeSetID)
		{
			short num = (short)1319573589;
			short num2 = num;
			num = (short)1982273621;
			switch (num2 == num)
			{
			}
			num = (short)1658191872;
			short num3 = num;
			num = (short)1408499713;
			if (num != 0)
			{
			}
			num = (short)711852032;
			if (num != 0)
			{
			}
			this.SetActiveField(activeSetID, null);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0003A8E4 File Offset: 0x00038AE4
		public void SetActiveField(string activeSetID, string activeFieldName)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.<>c__DisplayClass14_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.<>c__DisplayClass14_0();
			CS$<>8__locals1.a = this;
			CS$<>8__locals1.b = activeSetID;
			CS$<>8__locals1.c = activeFieldName;
			this.rarsetEditor.IsExpanded = true;
			if (this.iclSets.IsLoaded)
			{
				short num = (short)1365575685;
				short num2 = num;
				num = (short)442632197;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)97714177;
					if (num != 0)
					{
					}
					num = (short)1843331072;
					if (num != 0)
					{
					}
					num = (short)1215561728;
					short num3 = num;
					break;
				}
				}
				this.a(CS$<>8__locals1.b, CS$<>8__locals1.c);
				return;
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.d), new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.e), new global::System.Windows.RoutedEventHandler(CS$<>8__locals1.d));
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0003AA00 File Offset: 0x00038C00
		private void a(string A_0, string A_1)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.<>c__DisplayClass15_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.<>c__DisplayClass15_0();
			CS$<>8__locals1.a = A_0;
			CS$<>8__locals1.c = this;
			CS$<>8__locals1.d = A_1;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set item = this.EmbeddedSetCategory.Sets.First(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, bool>(CS$<>8__locals1.e));
			CS$<>8__locals1.b = (this.iclSets.ItemContainerGenerator.ContainerFromItem(item) as global::System.Windows.FrameworkElement);
			if (CS$<>8__locals1.b.IsLoaded)
			{
				short num = (short)1961097651;
				short num2 = num;
				num = (short)455276979;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1126432769;
					if (num != 0)
					{
					}
					num = (short)637665280;
					if (num != 0)
					{
					}
					num = (short)852361216;
					short num3 = num;
					break;
				}
				}
				this.a(CS$<>8__locals1.d, CS$<>8__locals1.b);
				return;
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.e), new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.f), new global::System.Windows.RoutedEventHandler(CS$<>8__locals1.e));
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0003AB50 File Offset: 0x00038D50
		private void a(string A_0, global::System.Windows.FrameworkElement A_1)
		{
			short num = (short)1448869888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1390673920;
				short num3 = num;
				num = (short)1510211585;
				if (num != 0)
				{
				}
				global::System.Windows.Controls.ItemsControl itemsControl = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.FindChildByName<global::System.Windows.Controls.ItemsControl>(A_1, "");
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)itemsControl.Items).GetEnumerator();
				try
				{
					num = (short)1144061961;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
						switch (num2)
						{
						case 0:
							if (rmfieldEditor.Tag != null)
							{
								num = (short)200867850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							num = (short)2059599872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (rmfieldEditor.Tag.ToString() == A_0)
							{
								num = (short)1584005128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							if (A_0 != null)
							{
								num = (short)674562049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_198;
						case 4:
							goto IL_27E;
						case 5:
							goto IL_1CA;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)1213267975;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							rmfieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor)enumerator.Current;
							num = (short)1462239235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1293418500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							num = (short)61213718;
							short num4 = num;
							num = (short)1672023062;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27E;
							default:
								num = (short)1432027136;
								if (num != 0)
								{
								}
								goto IL_198;
							}
							break;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_DC;
							}
							continue;
						case 10:
							num = (short)1022033922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_115:
						num = (short)1583153158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DC:
						goto IL_115;
						IL_198:
						global::System.Windows.Controls.ItemsControl a_ = this.SetPresenter.q();
						this.SetPresenter.a(rmfieldEditor, a_);
						num = (short)1369702405;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1CA:
					IL_27E:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_29D;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_28A:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)651296769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2F3;
						case 2:
							if (disposable != null)
							{
								num = (short)1077149696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F5;
						}
						goto IL_29D;
					}
					IL_2F3:
					IL_2F5:
					goto EndFinally_8;
					IL_29D:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1037107202;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28A;
					EndFinally_8:;
				}
				return;
			}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0003AE70 File Offset: 0x00039070
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 5;
			if (this._contentLoaded)
			{
				short num = (short)2089335103;
				short num2 = num;
				num = (short)532855103;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)331284480;
					if (num != 0)
					{
					}
					num = (short)337969153;
					if (num != 0)
					{
					}
					num = (short)2034696192;
					short num3 = num;
					break;
				}
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("늜튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺ﺼ鋀韄ꛆ귈ꋊꋌ苎냐뷒듔냖볘뛚룜뇞闠췢ꛤ裦蟨鿪鿬胮鷰胲컴银雸雺跼郾漀昂欄猆☈縊縌樎挐瀒稔礖洘椚爜猞删ఢ䌤並䰨䜪䤬䨮唰娲䄴堶䬸䠺ሼ䴾ⱀ⽂ⱄ㑆㵈⥊≌㝎㝐㩒ご㭖㵘㹚㥜㙞ᕠౢᝤ䥦ᅨ੪lͮ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0003AF58 File Offset: 0x00039158
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1720655757;
			short num2 = num;
			num = (short)2114592653;
			switch (num2 == num)
			{
			}
			num = (short)918421504;
			short num3 = num;
			num = (short)1030094848;
			if (num != 0)
			{
			}
			num = (short)729350145;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0003B00C File Offset: 0x0003920C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)997064706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)408785172;
				short num3 = num;
				num = (short)261787924;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_130;
				default:
				{
					num = (short)1778122752;
					if (num != 0)
					{
					}
					num = (short)433061888;
					short num4 = num;
					num = (short)1791492097;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)327680001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_130;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					IL_CD:
					switch (connectionId)
					{
					case 1:
						goto IL_13F;
					case 2:
						goto IL_10B;
					case 3:
						goto IL_FE;
					case 4:
						goto IL_132;
					default:
						num = (short)1113260032;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_FE:
			this.iclSets = (global::System.Windows.Controls.ItemsControl)target;
			return;
			IL_10B:
			this.rarsetEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor)target;
			return;
			IL_130:
			this._contentLoaded = true;
			return;
			IL_132:
			this.btnAdd = (global::System.Windows.Controls.Button)target;
			return;
			IL_13F:
			this.borderInvalid = (global::System.Windows.Controls.Border)target;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0003B16C File Offset: 0x0003936C
		// Note: this type is marked as 'beforefieldinit'.
		static RMListBoxFieldEditor()
		{
			int a_ = 14;
			short num = (short)1045283363;
			short num2 = num;
			num = (short)98877987;
			switch (num2 == num)
			{
			}
			num = (short)173015040;
			short num3 = num;
			num = (short)1998979073;
			if (num != 0)
			{
			}
			num = (short)2114584576;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.SetPresenterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춧\udea9ﲫ\udcad햯솱톳\ud8b5첷\udfb9캻", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor.EmbeddedSetCategoryProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얧좩즫쪭풯ힱ킳\uddb7캹ﾻ\udfbd뒿ꟁꏃ꧅뫇돉", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListBoxFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x0400011D RID: 285
		public static readonly global::System.Windows.DependencyProperty SetPresenterProperty;

		// Token: 0x0400011E RID: 286
		public static readonly global::System.Windows.DependencyProperty EmbeddedSetCategoryProperty;

		// Token: 0x0400011F RID: 287
		internal global::System.Windows.Controls.Border borderInvalid;

		// Token: 0x04000120 RID: 288
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor rarsetEditor;

		// Token: 0x04000121 RID: 289
		internal global::System.Windows.Controls.ItemsControl iclSets;

		// Token: 0x04000122 RID: 290
		internal global::System.Windows.Controls.Button btnAdd;

		// Token: 0x04000123 RID: 291
		private bool _contentLoaded;
	}
}
