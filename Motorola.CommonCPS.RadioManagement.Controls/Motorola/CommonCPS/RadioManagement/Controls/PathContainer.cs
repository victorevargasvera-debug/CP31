using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000FD RID: 253
	public class PathContainer : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00073FC4 File Offset: 0x000721C4
		public PathContainer()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00073FE0 File Offset: 0x000721E0
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0007409C File Offset: 0x0007229C
		public string Text
		{
			get
			{
				short num = (short)2130706432;
				short num2 = num;
				num = (short)386201062;
				short num3 = num;
				num = (short)956233190;
				switch (num3 == num)
				{
				}
				num = (short)42663937;
				if (num != 0)
				{
				}
				num = (short)792264704;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.TextProperty);
			}
			set
			{
				short num = (short)129630208;
				short num2 = num;
				num = (short)812508175;
				short num3 = num;
				num = (short)1631446031;
				switch (num3 == num)
				{
				}
				num = (short)304152577;
				if (num != 0)
				{
				}
				num = (short)910229504;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.TextProperty, value);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00074150 File Offset: 0x00072350
		private static void SetText(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)601358336;
			switch (num)
			{
			default:
			{
				num = (short)1325072384;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer pathContainer;
					string text;
					string[] array;
					int num3;
					global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector arrowSelector;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 1:
					{
						global::System.Collections.Generic.List<string> list;
						if (pathContainer.Hierarchy.TryGetValue(text, out list))
						{
							num = (short)1731002375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28B;
					}
					case 2:
						return;
					case 3:
						goto IL_201;
					case 4:
					{
						if (array == null)
						{
							num = (short)1510080518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pathContainer.pc.Children.Clear();
						string[] array2 = array;
						num3 = 0;
						num = (short)820969475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)1122959360;
						short num4 = num;
						num = (short)586768815;
						short num5 = num;
						num = (short)24338863;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C1;
						default:
							goto IL_275;
						}
						break;
					}
					case 6:
						return;
					case 7:
						num = (short)704512001;
						if (num != 0)
						{
						}
						goto IL_C1;
					case 8:
					{
						string[] array2;
						if (num3 >= array2.Length)
						{
							num = (short)1103429634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = array2[num3];
						global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector pathSelector = new global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector();
						pathSelector.Label = text;
						pathContainer.pc.Children.Add(pathSelector);
						pathSelector.Command = pathContainer.Command;
						arrowSelector = new global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector();
						num = (short)746127361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_28B;
					case 10:
						goto IL_201;
					}
					IL_72:
					if (A_1.NewValue == null)
					{
						num = (short)1720647685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					pathContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer)A_0;
					array = global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.a((string)A_1.NewValue);
					num = (short)1081081860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1:
					arrowSelector.Choices = pathContainer.Hierarchy[text];
					arrowSelector.Command = pathContainer.Command;
					num = (short)971571209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_201:
					num = (short)622198792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					pathContainer.pc.Children.Add(arrowSelector);
					num3++;
					num = (short)473497610;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_275:
				num = (short)1359347712;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00074450 File Offset: 0x00072650
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00074508 File Offset: 0x00072708
		public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> Hierarchy
		{
			get
			{
				short num = (short)191561728;
				short num2 = num;
				num = (short)64657033;
				short num3 = num;
				num = (short)1513068169;
				switch (num3 == num)
				{
				}
				num = (short)207355905;
				if (num != 0)
				{
				}
				num = (short)2120286208;
				if (num != 0)
				{
				}
				return (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.HierarchyProperty);
			}
			set
			{
				short num = (short)2057306112;
				short num2 = num;
				num = (short)1999980339;
				short num3 = num;
				num = (short)476333875;
				switch (num3 == num)
				{
				}
				num = (short)401801217;
				if (num != 0)
				{
				}
				num = (short)2029453312;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.HierarchyProperty, value);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000745C0 File Offset: 0x000727C0
		private static void SetHierarchy(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num;
			if (A_1.NewValue == null)
			{
				for (;;)
				{
					num = (short)1878438831;
					short num2 = num;
					num = (short)1622324143;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_40;
					}
				}
				IL_40:
				num = (short)1433337857;
				if (num != 0)
				{
				}
				num = (short)1899954176;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)856096768;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer pathContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer)A_0;
			pathContainer.Hierarchy = (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>)A_1.NewValue;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0007468C File Offset: 0x0007288C
		private static string[] a(string A_0)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			string[] result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1C0;
				case 1:
					if (!string.IsNullOrEmpty(A_0))
					{
						num2 = (short)1323171845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_FF;
				case 3:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("貢", a_), global::System.StringComparison.CurrentCulture))
					{
						num2 = (short)1118896130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C2;
				case 4:
					if (string.IsNullOrEmpty(A_0.Trim()))
					{
						num2 = (short)724631553;
						if (num2 != 0)
						{
						}
						num2 = (short)2118057990;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1191444483;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)69893449;
					short num3 = num2;
					num2 = (short)771063113;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
					{
						num2 = (short)649265152;
						if (num2 != 0)
						{
						}
						num2 = (short)800063488;
						short num4 = num2;
						num2 = (short)180289540;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_19A;
				}
				goto IL_35;
				IL_FF:
				A_0 = A_0.Substring(1);
				num2 = (short)700907520;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_19A:
			return result;
			IL_1C0:
			IL_1C2:
			result = A_0.Split(new char[]
			{
				'/'
			});
			return result;
			IL_35:
			result = null;
			num2 = (short)1797062657;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00074870 File Offset: 0x00072A70
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00074928 File Offset: 0x00072B28
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				short num = (short)1381236736;
				short num2 = num;
				num = (short)1608676175;
				short num3 = num;
				num = (short)1370452815;
				switch (num3 == num)
				{
				}
				num = (short)360775681;
				if (num != 0)
				{
				}
				num = (short)493420544;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.CommandProperty);
			}
			set
			{
				short num = (short)1417150464;
				short num2 = num;
				num = (short)627988052;
				short num3 = num;
				num = (short)790124116;
				switch (num3 == num)
				{
				}
				num = (short)324796417;
				if (num != 0)
				{
				}
				num = (short)403701760;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.CommandProperty, value);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000749DC File Offset: 0x00072BDC
		private static void SetCommand(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1456865280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1275133952;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer pathContainer;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						goto IL_31E;
					case 2:
					{
						num = (short)1574642693;
						short num3 = num;
						num = (short)1028662277;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_305;
						default:
							goto IL_B0;
						}
						break;
					}
					case 3:
					{
						if (pathContainer.pc.Children == null)
						{
							num = (short)1711669252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = pathContainer.pc.Children.GetEnumerator();
						goto IL_305;
					}
					case 4:
						goto IL_2EF;
					}
					IL_59:
					if (A_1.NewValue == null)
					{
						num = (short)824115202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					pathContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer)A_0;
					pathContainer.Command = (global::System.Windows.Input.ICommand)A_1.NewValue;
					num = (short)43712515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					num = (short)1084489729;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B0:
				num = (short)1901527040;
				short num4 = num;
				num = (short)1901985792;
				if (num != 0)
				{
				}
				num = (short)27394049;
				if (num != 0)
				{
				}
				return;
				IL_2EF:
				return;
				IL_31E:
				try
				{
					num = (short)1678704641;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer pathContainer;
							global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector pathSelector;
							pathSelector.Command = pathContainer.Command;
							num = (short)2027421698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_138;
							}
							continue;
						case 3:
							num = (short)1000210437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1461321731;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector pathSelector = obj as global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector;
							num = (short)503382022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_1F5;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.PathSelector pathSelector;
							if (pathSelector != null)
							{
								num = (short)1317404672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_13A:
						num = (short)1032388612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_138:
						goto IL_13A;
					}
					IL_1F5:
					return;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_217;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_204:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)1581842433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26F;
						case 1:
							disposable.Dispose();
							num = (short)1269104642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_26D;
						}
						goto IL_217;
					}
					IL_26D:
					IL_26F:
					goto EndFinally_8;
					IL_217:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)307101696;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_204;
					EndFinally_8:;
				}
				return;
			}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00074D28 File Offset: 0x00072F28
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00074DE0 File Offset: 0x00072FE0
		public global::System.Windows.Input.ICommand ChooseCommand
		{
			get
			{
				short num = (short)964820992;
				short num2 = num;
				num = (short)1095661936;
				short num3 = num;
				num = (short)1881438576;
				switch (num3 == num)
				{
				}
				num = (short)1059717120;
				if (num != 0)
				{
				}
				num = (short)804585473;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.ChooseCommandProperty);
			}
			set
			{
				short num = (short)1221591040;
				short num2 = num;
				num = (short)869856737;
				short num3 = num;
				num = (short)380237281;
				switch (num3 == num)
				{
				}
				num = (short)957022209;
				if (num != 0)
				{
				}
				num = (short)1685782528;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.ChooseCommandProperty, value);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00074E94 File Offset: 0x00073094
		private static void SetChooseCommand(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1051066368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1302265856;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer pathContainer;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						goto IL_316;
					case 2:
					{
						num = (short)1700181616;
						short num3 = num;
						num = (short)1449768560;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2FE;
						default:
							goto IL_B2;
						}
						break;
					}
					case 3:
					{
						if (pathContainer.pc.Children == null)
						{
							num = (short)221708292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.IEnumerator enumerator = pathContainer.pc.Children.GetEnumerator();
						goto IL_2FE;
					}
					case 4:
						goto IL_2E8;
					}
					IL_59:
					if (A_1.NewValue == null)
					{
						num = (short)1511718914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					pathContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer)A_0;
					pathContainer.Command = (global::System.Windows.Input.ICommand)A_1.NewValue;
					num = (short)877199361;
					if (num != 0)
					{
					}
					num = (short)908132355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					num = (short)419102721;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B2:
				num = (short)1928527872;
				short num4 = num;
				num = (short)1528823808;
				if (num != 0)
				{
				}
				return;
				IL_2E8:
				return;
				IL_316:
				try
				{
					num = (short)1550057473;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer pathContainer;
							global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector arrowSelector;
							arrowSelector.Command = pathContainer.Command;
							num = (short)1787101186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_136;
							}
							continue;
						case 3:
							num = (short)1673003013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1949237251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector arrowSelector = obj as global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector;
							num = (short)1038221318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_1EE;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector arrowSelector;
							if (arrowSelector != null)
							{
								num = (short)1755840512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_138:
						num = (short)327024644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_136:
						goto IL_138;
					}
					IL_1EE:
					return;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_210;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1FD:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)2109014017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_267;
						case 1:
							disposable.Dispose();
							num = (short)190382082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_265;
						}
						goto IL_210;
					}
					IL_265:
					IL_267:
					goto EndFinally_8;
					IL_210:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)672137216;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1FD;
					EndFinally_8:;
				}
				return;
			}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000751CC File Offset: 0x000733CC
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00075288 File Offset: 0x00073488
		public global::System.Windows.Input.ICommand CommandParameter
		{
			get
			{
				short num = (short)977076224;
				short num2 = num;
				num = (short)381945634;
				short num3 = num;
				num = (short)1172768546;
				switch (num3 == num)
				{
				}
				num = (short)1786183681;
				if (num != 0)
				{
				}
				num = (short)1924005888;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.CommandParameterProperty);
			}
			set
			{
				short num = (short)1230372864;
				short num2 = num;
				num = (short)2047133265;
				short num3 = num;
				num = (short)1521862225;
				switch (num3 == num)
				{
				}
				num = (short)929038337;
				if (num != 0)
				{
				}
				num = (short)1721106432;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.CommandParameterProperty, value);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0007533C File Offset: 0x0007353C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num;
			while (this._contentLoaded)
			{
				num = (short)1027684390;
				short num2 = num;
				num = (short)757741606;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1090781184;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1451556864;
			short num3 = num;
			num = (short)228392961;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螧쎫\udaad\udfaf삱\udbb3\udab5\ud9b7钹ﾻ톽궿꿁ꯃꣅ诇髉鿋苏돑냓뿕럗韙뷛냝臟藡臣该跧蓩飫샭돯鷱髳苵諷闹郻跽㯿愁欃欅砇攉戋欍縏昑㬓挕欗缙減紝伟䰡倣吥䜧䘩弫ĭ䀯匱䀳帵嬷唹刻䨽ℿ⭁⩃⍅㩇摉㑋⽍㵏㹑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0007541C File Offset: 0x0007361C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId == 1)
			{
				short num = (short)944439297;
				if (num != 0)
				{
				}
				num = (short)673998408;
				short num2 = num;
				num = (short)1610901064;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1815543808;
					if (num != 0)
					{
					}
					num = (short)1082064896;
					short num3 = num;
					this.pc = (global::System.Windows.Controls.StackPanel)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000754E4 File Offset: 0x000736E4
		// Note: this type is marked as 'beforefieldinit'.
		static PathContainer()
		{
			int a_ = 2;
			short num = (short)1082458112;
			short num2 = num;
			num = (short)1891809743;
			short num3 = num;
			num = (short)108575183;
			switch (num3 == num)
			{
			}
			num = (short)48431104;
			if (num != 0)
			{
			}
			num = (short)1811283969;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.TextProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캙鍊풟", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.SetText)));
			global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.HierarchyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튙ﮝ튟쎡횣얥삧펩", a_), typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.SetHierarchy)));
			global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.CommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud999춟쎡쪣슥", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.SetCommand)));
			global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.ChooseCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud999쾟톡솣잧잩솫쾭\udeaf횱", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.SetChooseCommand)));
			global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer.CommandParameterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud999춟쎡쪣슥쮩\udeab쾭\uddafힱ삳펵쪷", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PathContainer), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000359 RID: 857
		public static readonly global::System.Windows.DependencyProperty TextProperty;

		// Token: 0x0400035A RID: 858
		public static readonly global::System.Windows.DependencyProperty HierarchyProperty;

		// Token: 0x0400035B RID: 859
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400035C RID: 860
		public static readonly global::System.Windows.DependencyProperty ChooseCommandProperty;

		// Token: 0x0400035D RID: 861
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty;

		// Token: 0x0400035E RID: 862
		internal global::System.Windows.Controls.StackPanel pc;

		// Token: 0x0400035F RID: 863
		private bool _contentLoaded;
	}
}
