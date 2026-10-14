using System;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200001D RID: 29
	internal static class CloningMachine
	{
		// Token: 0x0600027F RID: 639 RVA: 0x0003A754 File Offset: 0x00038954
		internal static global::DevComponents.WpfRibbon.ButtonDropDown Clone(global::DevComponents.WpfRibbon.ButtonDropDown source, bool deepCopy)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
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
					if (deepCopy)
					{
						num2 = (short)130940929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_349;
				case 1:
					global::DevComponents.WpfRibbon.CloningMachine.CloneCollection(source.Items, buttonDropDown.Items);
					num2 = (short)1844969475;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_E4;
				case 3:
					goto IL_205;
				case 4:
					if (!(buttonDropDown.Command is global::DevComponents.WpfRibbon.ButtonDropDownCommand))
					{
						num2 = (short)1686110215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 5:
					num2 = (short)636682241;
					if (num2 != 0)
					{
					}
					buttonDropDown.IsEnabled = source.IsEnabled;
					num2 = (short)623902726;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_20A;
				case 7:
					buttonDropDown.Header = global::DevComponents.WpfRibbon.CloningMachine.XamlClone(source.Header);
					buttonDropDown.Image = global::DevComponents.WpfRibbon.CloningMachine.XamlClone(source.Image);
					buttonDropDown.ImageSmall = global::DevComponents.WpfRibbon.CloningMachine.XamlClone(source.ImageSmall);
					buttonDropDown.ImageSource = source.ImageSource;
					buttonDropDown.ImageSmallSource = source.ImageSmallSource;
					goto IL_174;
				case 8:
					if (source.Command == null)
					{
						num2 = (short)265486341;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20A;
				}
				goto IL_34;
				IL_E4:
				buttonDropDown.WrapLabel = source.WrapLabel;
				num2 = (short)1802240000;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_174:
				num2 = (short)1932853250;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20A:
				buttonDropDown.PartVisibility = source.PartVisibility;
				buttonDropDown.PopupPlacement = source.PopupPlacement;
				buttonDropDown.PopupType = source.PopupType;
				buttonDropDown.Role = source.Role;
				buttonDropDown.ContentExpands = source.ContentExpands;
				buttonDropDown.InlineExpand = source.InlineExpand;
				buttonDropDown.ToolTip = source.ToolTip;
				buttonDropDown.Command = source.Command;
				buttonDropDown.CommandTarget = source.CommandTarget;
				buttonDropDown.CommandParameter = source.CommandParameter;
				buttonDropDown.Tag = source.Tag;
				num2 = (short)129284243;
				short num3 = num2;
				num2 = (short)162838675;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_174;
				default:
				{
					num2 = (short)1830158336;
					short num4 = num2;
					num2 = (short)1973420032;
					if (num2 != 0)
					{
					}
					num2 = (short)2086666244;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			IL_205:
			IL_349:
			global::DevComponents.WpfRibbon.RoutedEventHandlerCloner.CopyHandlers(source, buttonDropDown, global::DevComponents.WpfRibbon.ButtonDropDown.ClickEvent);
			global::DevComponents.WpfRibbon.RoutedEventHandlerCloner.CopyHandlers(source, buttonDropDown, global::DevComponents.WpfRibbon.ButtonDropDown.CheckedEvent);
			global::DevComponents.WpfRibbon.RoutedEventHandlerCloner.CopyHandlers(source, buttonDropDown, global::DevComponents.WpfRibbon.ButtonDropDown.UncheckedEvent);
			global::DevComponents.WpfRibbon.RoutedEventHandlerCloner.CopyHandlers(source, buttonDropDown, global::DevComponents.WpfRibbon.ButtonDropDown.PopupOpenedEvent);
			global::DevComponents.WpfRibbon.RoutedEventHandlerCloner.CopyHandlers(source, buttonDropDown, global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent);
			return buttonDropDown;
			IL_34:
			buttonDropDown = new global::DevComponents.WpfRibbon.ButtonDropDown();
			buttonDropDown.Name = source.Name;
			buttonDropDown.Role = source.Role;
			buttonDropDown.ColorClass = source.ColorClass;
			buttonDropDown.ExpandPosition = source.ExpandPosition;
			buttonDropDown.ExpandVisibility = source.ExpandVisibility;
			buttonDropDown.ImagePosition = source.ImagePosition;
			buttonDropDown.InputGestureText = source.InputGestureText;
			buttonDropDown.IsCheckable = source.IsCheckable;
			buttonDropDown.IsChecked = source.IsChecked;
			num2 = (short)1868824584;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0003AAEC File Offset: 0x00038CEC
		internal static global::DevComponents.WpfRibbon.ButtonPanel Clone(global::DevComponents.WpfRibbon.ButtonPanel source, bool deepCopy)
		{
			short num = (short)1278768179;
			short num2 = num;
			num = (short)795309107;
			switch (num2 == num)
			{
			default:
			{
				num = (short)981925888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)134545408;
			if (num != 0)
			{
			}
			num = (short)2087190529;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonPanel buttonPanel = new global::DevComponents.WpfRibbon.ButtonPanel();
			buttonPanel.Name = source.Name;
			buttonPanel.Orientation = source.Orientation;
			buttonPanel.FixedWidth = source.FixedWidth;
			buttonPanel.FixedHeight = source.FixedHeight;
			global::DevComponents.WpfRibbon.CloningMachine.CloneCollection(source.Children, buttonPanel.Children);
			return buttonPanel;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0003ABE0 File Offset: 0x00038DE0
		internal static global::DevComponents.WpfRibbon.GroupPanel Clone(global::DevComponents.WpfRibbon.GroupPanel source, bool deepCopy)
		{
			short num = (short)523425766;
			short num2 = num;
			num = (short)406444006;
			switch (num2 == num)
			{
			default:
			{
				num = (short)405798912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1127743489;
			if (num != 0)
			{
			}
			num = (short)45219840;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.GroupPanel groupPanel = new global::DevComponents.WpfRibbon.GroupPanel();
			groupPanel.Name = source.Name;
			groupPanel.Orientation = source.Orientation;
			groupPanel.FixedWidth = source.FixedWidth;
			groupPanel.FixedHeight = source.FixedHeight;
			groupPanel.BorderBrush = source.BorderBrush;
			groupPanel.LightBorderBrush = source.LightBorderBrush;
			groupPanel.CornerRadius = source.CornerRadius;
			global::DevComponents.WpfRibbon.CloningMachine.CloneCollection(source.Children, groupPanel.Children);
			return groupPanel;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0003ACF4 File Offset: 0x00038EF4
		internal static object GetObjectCopy(object o, bool deepCopy)
		{
			short num = (short)1415315469;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10C;
				case 1:
					goto IL_148;
				case 2:
					if (o is global::System.Windows.Controls.Image)
					{
						num = (short)1986002944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D1;
				case 3:
					goto IL_2BD;
				case 4:
					goto IL_226;
				case 5:
					if (o is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)1101594625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)732758023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (o is global::DevComponents.WpfRibbon.ButtonPanel)
					{
						num = (short)1001062411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)408616961;
					if (num != 0)
					{
					}
					num = (short)101187593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					if (o is global::DevComponents.WpfRibbon.GroupPanel)
					{
						num = (short)917569540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1917676434;
					short num3 = num;
					num = (short)1053191058;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_226;
					default:
						num = (short)629800960;
						if (num != 0)
						{
						}
						num = (short)1859780614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_B2;
				case 9:
				{
					num = (short)1219297280;
					short num4 = num;
					if (o is global::DevComponents.WpfRibbon.RibbonBar)
					{
						num = (short)1283391491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1630339082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (o is string)
					{
						num = (short)1734475784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)122224642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_1E8;
				case 12:
					goto IL_78;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				if (o == null)
				{
					num = (short)1961623564;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)908132357;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_78:
			return null;
			IL_B2:
			return o.ToString();
			IL_10C:
			return global::DevComponents.WpfRibbon.CloningMachine.Clone((global::System.Windows.Controls.Image)o);
			IL_148:
			return global::DevComponents.WpfRibbon.CloningMachine.Clone((global::DevComponents.WpfRibbon.ButtonDropDown)o, deepCopy);
			IL_1E8:
			return global::DevComponents.WpfRibbon.CloningMachine.Clone((global::DevComponents.WpfRibbon.ButtonPanel)o, deepCopy);
			IL_226:
			return global::DevComponents.WpfRibbon.CloningMachine.Clone((global::DevComponents.WpfRibbon.GroupPanel)o, deepCopy);
			IL_2BD:
			return global::DevComponents.WpfRibbon.CloningMachine.Clone((global::DevComponents.WpfRibbon.RibbonBar)o, deepCopy);
			IL_2D1:
			return global::System.Windows.Markup.XamlReader.Load(global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(global::System.Windows.Markup.XamlWriter.Save(o))));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0003AFE8 File Offset: 0x000391E8
		internal static object Clone(global::System.Windows.Controls.Image image)
		{
			short num;
			try
			{
				return global::System.Windows.Markup.XamlReader.Load(global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(global::System.Windows.Markup.XamlWriter.Save(image)))) as global::System.Windows.Controls.Image;
			}
			catch
			{
				if (image.Source == null)
				{
					num = (short)538308652;
					short num2 = num;
					num = (short)1597435948;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)991952896;
						if (num != 0)
						{
						}
						throw;
					}
				}
			}
			num = (short)1597898753;
			if (num != 0)
			{
			}
			num = (short)721813504;
			short num3 = num;
			return new global::System.Windows.Controls.Image
			{
				Source = image.Source.CloneCurrentValue(),
				Margin = image.Margin,
				Stretch = image.Stretch,
				StretchDirection = image.StretchDirection,
				Width = image.Width,
				Height = image.Height,
				MinHeight = image.MinHeight,
				MinWidth = image.MinWidth
			};
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0003B13C File Offset: 0x0003933C
		internal static void CloneCollection(global::System.Windows.Controls.UIElementCollection source, global::System.Windows.Controls.UIElementCollection target)
		{
			global::System.Collections.IEnumerator enumerator = source.GetEnumerator();
			short num;
			try
			{
				num = (short)757727238;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							goto IL_7A;
						}
						break;
					}
					case 1:
					{
						global::System.Windows.UIElement uielement;
						target.Add(uielement);
						num = (short)1693646851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)974323717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)449786180;
						short num3 = num;
						num = (short)462172484;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7A;
						default:
						{
							num = (short)109182977;
							if (num != 0)
							{
							}
							num = (short)431357952;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)342360066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy((global::System.Windows.UIElement)enumerator.Current, true) as global::System.Windows.UIElement;
							num = (short)1660223488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						goto IL_17A;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					}
					goto IL_49;
					IL_7A:
					num = (short)1723400193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_93:
					num = (short)1878130692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49:
					goto IL_93;
				}
				IL_17A:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_198;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_186:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)340197377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1E9;
					case 2:
						if (disposable != null)
						{
							num = (short)1693843456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EB;
					}
					goto IL_198;
				}
				IL_1E9:
				IL_1EB:
				goto EndFinally_5;
				IL_198:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1680277506;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_186;
				EndFinally_5:;
			}
			num = (short)1404633088;
			short num4 = num;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0003B37C File Offset: 0x0003957C
		internal static void CloneCollection(global::System.Windows.Controls.ItemCollection source, global::System.Windows.Controls.ItemCollection target)
		{
			short num = (short)2103705601;
			if (num != 0)
			{
			}
			num = (short)879230976;
			short num2 = num;
			global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)source).GetEnumerator();
			try
			{
				num = (short)169148422;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						object objectCopy;
						if (objectCopy != null)
						{
							goto IL_BF;
						}
						break;
					}
					case 1:
					{
						object objectCopy;
						target.Add(objectCopy);
						num = (short)588906499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)135593989;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)217761531;
						short num4 = num;
						num = (short)1993459451;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BF;
						default:
						{
							num = (short)2134638592;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)541720578;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							object objectCopy = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy(enumerator.Current, true);
							num = (short)1955659776;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						goto IL_196;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					}
					goto IL_98;
					IL_BF:
					num = (short)782565377;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_D8:
					num = (short)1742995460;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_98:
					goto IL_D8;
				}
				IL_196:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_1B4;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1A2:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)748552193;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_205;
					case 2:
						if (disposable != null)
						{
							num = (short)1324941312;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_207;
					}
					goto IL_1B4;
				}
				IL_205:
				IL_207:
				goto EndFinally_5;
				IL_1B4:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)477233154;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_1A2;
				EndFinally_5:;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0003B5B0 File Offset: 0x000397B0
		internal static object XamlClone(object source)
		{
			short num = (short)926023685;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7F;
				case 1:
					goto IL_99;
				case 2:
					if (source is string)
					{
						num = (short)1239547908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)836501505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return source;
				case 4:
				{
					num = (short)2073020312;
					short num3 = num;
					num = (short)1123731352;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_99;
					default:
						goto IL_F6;
					}
					break;
				}
				case 5:
					num = (short)1718091777;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				IL_65:
				if (source == null)
				{
					num = (short)1942945792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)643694594;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_99:
				if (!source.GetType().IsValueType)
				{
					goto IL_182;
				}
				num = (short)663027715;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7F:
			return null;
			IL_F6:
			num = (short)1326579712;
			if (num != 0)
			{
			}
			num = (short)2034302976;
			short num4 = num;
			return source.ToString();
			IL_182:
			return global::System.Windows.Markup.XamlReader.Load(global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(global::System.Windows.Markup.XamlWriter.Save(source))));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0003B754 File Offset: 0x00039954
		internal static global::DevComponents.WpfRibbon.RibbonBar Clone(global::DevComponents.WpfRibbon.RibbonBar source, bool deepCopy)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_18F;
				case 1:
					return ribbonBar;
				case 2:
					if (deepCopy)
					{
						num2 = (short)1321271296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return ribbonBar;
				}
				goto IL_1C;
			}
			return ribbonBar;
			IL_1C:
			ribbonBar = new global::DevComponents.WpfRibbon.RibbonBar();
			ribbonBar.Name = source.Name;
			ribbonBar.Header = global::DevComponents.WpfRibbon.CloningMachine.XamlClone(source.Header);
			ribbonBar.DialogLauncherVisible = source.DialogLauncherVisible;
			ribbonBar.IsAutoSizeEnabled = source.IsAutoSizeEnabled;
			ribbonBar.ResizeOrderIndex = source.ResizeOrderIndex;
			ribbonBar.CollapsedHeader = global::DevComponents.WpfRibbon.CloningMachine.XamlClone(source.CollapsedHeader);
			ribbonBar.CollapsedImage = global::DevComponents.WpfRibbon.CloningMachine.XamlClone(source.CollapsedImage);
			ribbonBar.VerticalAlignment = source.VerticalAlignment;
			ribbonBar.HorizontalAlignment = source.HorizontalAlignment;
			ribbonBar.HorizontalContentAlignment = source.HorizontalContentAlignment;
			ribbonBar.VerticalContentAlignment = source.VerticalContentAlignment;
			global::DevComponents.WpfRibbon.RoutedEventHandlerCloner.CopyHandlers(source, ribbonBar, global::DevComponents.WpfRibbon.RibbonBar.LaunchDialogEvent);
			num2 = (short)699138049;
			if (num2 != 0)
			{
			}
			num2 = (short)806440747;
			short num3 = num2;
			num2 = (short)152653611;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_18F:
				global::DevComponents.WpfRibbon.CloningMachine.CloneCollection(source.Items, ribbonBar.Items);
				num2 = (short)709099521;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1084162048;
				short num4 = num2;
				num2 = (short)1407123456;
				if (num2 != 0)
				{
				}
				num2 = (short)1867644930;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
