using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Controls.Menus;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Editors.Events;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200009C RID: 156
	public class RMTreeComboEditor : global::Infragistics.Windows.Editors.XamTextEditor
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0003E290 File Offset: 0x0003C490
		static RMTreeComboEditor()
		{
			int a_ = 10;
			short num = (short)1000275969;
			if (num != 0)
			{
			}
			num = (short)680562029;
			short num2 = num;
			num = (short)790203757;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2105475072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1820393472;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.CurrentGroupProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톣풥\udaa7쾩슫\udaad삱\udbb3쎵좷", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.ItemsSourceProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킣쎥얧\ud9a9ﾫ솭얯삱ힳ펵", a_), typeof(global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.NodeLayoutsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣슥춧춫힭\udfaf잱삳억", a_), typeof(global::Infragistics.Controls.Menus.NodeLayoutCollection), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor), new global::System.Windows.PropertyMetadata(new global::Infragistics.Controls.Menus.NodeLayoutCollection(), new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.OnNodeLayoutsChanged)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor)));
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0003E3FC File Offset: 0x0003C5FC
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group CurrentGroup
		{
			get
			{
				short num = (short)1822829599;
				short num2 = num;
				num = (short)991964191;
				switch (num2 == num)
				{
				}
				num = (short)1441660928;
				short num3 = num;
				num = (short)1161691137;
				if (num != 0)
				{
				}
				num = (short)593887232;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.CurrentGroupProperty);
			}
			set
			{
				short num = (short)933236288;
				short num2 = num;
				num = (short)2021264960;
				switch (num2 == num)
				{
				}
				num = (short)1180565504;
				short num3 = num;
				num = (short)758972417;
				if (num != 0)
				{
				}
				num = (short)1492320256;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.CurrentGroupProperty, value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0003E56C File Offset: 0x0003C76C
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0003E624 File Offset: 0x0003C824
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				short num = (short)533026112;
				short num2 = num;
				num = (short)814634304;
				switch (num2 == num)
				{
				}
				num = (short)598081536;
				short num3 = num;
				num = (short)785055745;
				if (num != 0)
				{
				}
				num = (short)1567424512;
				if (num != 0)
				{
				}
				return (global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.ItemsSourceProperty);
			}
			set
			{
				short num = (short)2026503470;
				short num2 = num;
				num = (short)1846017326;
				switch (num2 == num)
				{
				}
				num = (short)207421440;
				short num3 = num;
				num = (short)1917845505;
				if (num != 0)
				{
				}
				num = (short)920453120;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.ItemsSourceProperty, value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0003E6D8 File Offset: 0x0003C8D8
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0003E794 File Offset: 0x0003C994
		public global::Infragistics.Controls.Menus.NodeLayoutCollection NodeLayouts
		{
			get
			{
				short num = (short)845750103;
				short num2 = num;
				num = (short)239673175;
				switch (num2 == num)
				{
				}
				num = (short)6094848;
				short num3 = num;
				num = (short)748093441;
				if (num != 0)
				{
				}
				num = (short)1422262272;
				if (num != 0)
				{
				}
				return (global::Infragistics.Controls.Menus.NodeLayoutCollection)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.NodeLayoutsProperty);
			}
			set
			{
				short num = (short)395182081;
				if (num != 0)
				{
				}
				num = (short)1195261458;
				short num2 = num;
				num = (short)1627012626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)914292736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)552861696;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.NodeLayoutsProperty, value);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0003E848 File Offset: 0x0003CA48
		private static void OnNodeLayoutsChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1774059521;
			if (num != 0)
			{
			}
			num = (short)1375523114;
			short num2 = num;
			num = (short)1444073770;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2077032448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1460273152;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor rmtreeComboEditor = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor;
			rmtreeComboEditor.b();
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0003E900 File Offset: 0x0003CB00
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1325072384;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.NodeLayout> enumerator;
				global::Infragistics.Controls.Menus.XamDataTree xamDataTree;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1770848257;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)599982083;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Infragistics.Controls.Menus.NodeLayout item = enumerator.Current;
								xamDataTree.GlobalNodeLayouts.Add(item);
								num = (short)1568014338;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_118;
								}
								continue;
							case 3:
								num = (short)1058734081;
								if (num != 0)
								{
								}
								num = (short)130547716;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1B6;
							}
							IL_145:
							num = (short)1333198848;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_118:
							goto IL_145;
						}
						IL_1B6:
						return;
					}
					finally
					{
						num = (short)150798336;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1EB;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1729822722;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_221;
							}
							IL_1EB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1247870977;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_221:;
					}
					goto IL_224;
				case 1:
					if (this.NodeLayouts != null)
					{
						num = (short)1263796226;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)958922755;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (xamDataTree != null)
					{
						num = (short)1528037380;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_224;
				}
				goto IL_4D;
				IL_224:
				xamDataTree.GlobalNodeLayouts.Clear();
				enumerator = this.NodeLayouts.GetEnumerator();
				num = (short)1810235392;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			for (;;)
			{
				IL_4D:
				global::Infragistics.Controls.Menus.XamDataTree xamDataTree = this.a();
				num = (short)1953997450;
				short num4 = num;
				num = (short)465937034;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8A;
				}
			}
			IL_8A:
			num = (short)1523056640;
			if (num != 0)
			{
			}
			num = (short)1062666241;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		private global::Infragistics.Controls.Menus.XamDataTree a()
		{
			int a_ = 10;
			short num = (short)1814125325;
			short num2 = num;
			num = (short)71785229;
			switch (num2 == num)
			{
			}
			num = (short)1052901376;
			short num3 = num;
			num = (short)1718288385;
			if (num != 0)
			{
			}
			num = (short)1047396352;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ControlTemplate editTemplate = base.EditTemplate;
			return (global::Infragistics.Controls.Menus.XamDataTree)((editTemplate != null) ? editTemplate.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횣즥\ud8a7쎫\ud9ad\udeaf욳펵\uddb7", a_), this) : null);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0003EC88 File Offset: 0x0003CE88
		private global::Infragistics.Controls.Menus.XamDataTreeNode a(global::Infragistics.Controls.Menus.XamDataTreeNodesCollection A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_1)
		{
			short num = (short)550749821;
			short num2 = num;
			num = (short)125093501;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_DE;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1483472896;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.<>c__DisplayClass16_0 CS$<>8__locals1;
			for (;;)
			{
				IL_C3:
				switch (num4)
				{
				case 0:
				{
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator = A_0.Where(new global::System.Func<global::Infragistics.Controls.Menus.XamDataTreeNode, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.<>c.<>9.a)).GetEnumerator();
					num = (short)771555332;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (xamDataTreeNode != null)
					{
						num = (short)1712324610;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 2:
					return xamDataTreeNode;
				case 3:
					goto IL_2EB;
				case 4:
					try
					{
						num = (short)2081751043;
						num4 = (int)((global::System.IntPtr)num);
						global::Infragistics.Controls.Menus.XamDataTreeNode result;
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_1E2;
							case 1:
								if (xamDataTreeNode != null)
								{
									num = (short)2009923588;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1314062341;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = enumerator.Current;
								xamDataTreeNode = this.a(xamDataTreeNode2.Nodes, CS$<>8__locals1.a);
								num = (short)1219493889;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_178;
								}
								continue;
							case 4:
								result = xamDataTreeNode;
								num = (short)1468203008;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)1133641734;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_23E;
							}
							IL_1E7:
							num = (short)402128898;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_178:
							goto IL_1E7;
						}
						IL_1E2:
						return result;
						IL_23E:
						goto IL_2D1;
					}
					finally
					{
						num = (short)544079872;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator;
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_276;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)558432258;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2AB;
							}
							IL_276:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2001928193;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2AB:;
					}
					goto IL_2AE;
					IL_2D1:
					num = (short)422838275;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_DE;
				IL_2AE:
				num = (short)66650112;
				num4 = (int)((global::System.IntPtr)num);
			}
			return xamDataTreeNode;
			IL_2EB:
			return null;
			IL_5F:
			num = (short)239403009;
			if (num != 0)
			{
			}
			num = (short)1265434624;
			if (num != 0)
			{
			}
			num = (short)1810300928;
			num4 = (int)num;
			switch (num4)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_DE;
				}
				goto IL_C3;
			}
			IL_DE:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.<>c__DisplayClass16_0();
			CS$<>8__locals1.a = A_1;
			xamDataTreeNode = A_0.FirstOrDefault(new global::System.Func<global::Infragistics.Controls.Menus.XamDataTreeNode, bool>(CS$<>8__locals1.b));
			num = (short)1387921409;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_C3;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
		private void a(global::Infragistics.Controls.Menus.XamDataTreeNode A_0)
		{
			short num = (short)1737752576;
			short num2 = num;
			num = (short)1939352035;
			short num3 = num;
			num = (short)852699619;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_87:
				num = (short)1114767361;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				break;
			default:
				num = (short)289144832;
				if (num != 0)
				{
				}
				num = (short)976551936;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_B8:
				switch (num4)
				{
				case 0:
					goto IL_87;
				case 1:
					return;
				case 3:
					if (A_0 == null)
					{
						num = (short)629932033;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_0.IsExpanded = true;
					A_0 = A_0.Manager.ParentNode;
					num = (short)521338882;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_CE;
			}
			return;
			IL_CE:
			num = (short)214499331;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_B8;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0003F11C File Offset: 0x0003D31C
		public override void OnApplyTemplate()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				global::System.Windows.Controls.Primitives.ToggleButton toggleButton;
				object obj;
				switch (num)
				{
				case 0:
					if (!base.IsInEditMode)
					{
						num2 = (short)646643713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)1738407937;
					if (num2 != 0)
					{
					}
					num2 = (short)1524432902;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (toggleButton != null)
					{
						num2 = (short)776011780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					toggleButton.Click += this.ToggleButtonContentMode_Click;
					num2 = (short)963903491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					obj = null;
					goto IL_163;
				case 6:
				{
					global::System.Windows.Controls.ControlTemplate template = base.Template;
					if (template == null)
					{
						num2 = (short)1055064069;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					obj = template.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욨첪쪬쎮풰살쎶춸풺펼ﲾ껀귂뇄ꋆꟈ뿊背ꃎ뗐뛒", a_), this);
					goto IL_163;
				}
				}
				goto IL_35;
				IL_163:
				toggleButton = (global::System.Windows.Controls.Primitives.ToggleButton)obj;
				num2 = (short)1247215618;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_35:
			num2 = (short)1312882688;
			short num3 = num2;
			num2 = (short)1233731776;
			short num4 = num2;
			num2 = (short)991117504;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			default:
			{
				num2 = (short)480968704;
				if (num2 != 0)
				{
				}
				base.OnApplyTemplate();
				num2 = (short)1252917248;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0003F2F4 File Offset: 0x0003D4F4
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			short num = (short)956872539;
			short num2 = num;
			num = (short)1392883547;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AE:
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				break;
			case 1:
				goto IL_5C;
			default:
			{
				num = (short)621150208;
				short num3 = num;
				goto IL_5C;
			}
			}
			int num4;
			for (;;)
			{
				IL_B8:
				switch (num4)
				{
				case 0:
					goto IL_AE;
				case 1:
					goto IL_108;
				case 2:
					goto IL_125;
				case 3:
					base.OnEditModeStarting(args);
					num = (short)1738276866;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_CE;
			}
			IL_108:
			IL_125:
			base.OnEditModeStarting(args);
			return;
			IL_5C:
			num = (short)957153280;
			if (num != 0)
			{
			}
			num = (short)832700417;
			if (num != 0)
			{
			}
			num = (short)1471676416;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_B8;
			IL_CE:
			if (!base.IsReadOnly)
			{
				num = (short)1152581635;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_B8;
			}
			args.Cancel = true;
			num = (short)411697153;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_B8;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0003F430 File Offset: 0x0003D630
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			int a_ = 17;
			short num = (short)1236402177;
			if (num != 0)
			{
			}
			num = (short)473552918;
			short num2 = num;
			num = (short)1843124246;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1904607232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)671481856;
			if (num != 0)
			{
			}
			base.OnEditModeStarted(args);
			this.b();
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = this.a();
			xamDataTree.Loaded += this.Tree_Loaded;
			global::System.Windows.Controls.ControlTemplate editTemplate = base.EditTemplate;
			global::System.Windows.Controls.TextBox textBox = (global::System.Windows.Controls.TextBox)((editTemplate != null) ? editTemplate.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾪쒬\udbaeﲰ\udcb2톴튶\udeba얼쮾菀곂뷄", a_), this) : null);
			textBox.PreviewMouseUp += this.EditModeTextBox_PreviewMouseUp;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0003F548 File Offset: 0x0003D748
		private void Tree_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.<>c__DisplayClass21_0 CS$<>8__locals1;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
				switch (num)
				{
				case 0:
					goto IL_8E;
				case 1:
					if (CS$<>8__locals1.a.Nodes != null)
					{
						num2 = (short)484638724;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16C;
				case 2:
					goto IL_16C;
				case 3:
					if (xamDataTreeNode != null)
					{
						num2 = (short)1008533504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16C;
				case 4:
					xamDataTreeNode = this.a(CS$<>8__locals1.a.Nodes, this.CurrentGroup);
					CS$<>8__locals1.a.SelectionSettings.SelectedNodes.Clear();
					num2 = (short)1316814851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.CurrentGroup != null)
					{
						num2 = (short)320471046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16C;
				case 6:
					num2 = (short)1792802817;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_8E:
				this.a(xamDataTreeNode);
				CS$<>8__locals1.a.SelectionSettings.SelectedNodes.Add(xamDataTreeNode);
				num2 = (short)2064908290;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_16C:
				num2 = (short)1067919561;
				short num3 = num2;
				num2 = (short)258418889;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8E;
				case 1:
					goto IL_1CC;
				}
				break;
			}
			num2 = (short)2053636096;
			short num4 = num2;
			IL_1CC:
			num2 = (short)128843777;
			if (num2 != 0)
			{
			}
			num2 = (short)1339686912;
			if (num2 != 0)
			{
			}
			CS$<>8__locals1.a.NodeExpansionChanging += CS$<>8__locals1.b;
			CS$<>8__locals1.a.SelectedNodesCollectionChanged += this.DropDownTree_SelectedNodesCollectionChanged;
			return;
			IL_2C:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor.<>c__DisplayClass21_0();
			CS$<>8__locals1.a = (global::Infragistics.Controls.Menus.XamDataTree)A_0;
			CS$<>8__locals1.a.SelectedNodesCollectionChanged -= this.DropDownTree_SelectedNodesCollectionChanged;
			num2 = (short)1061814277;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0003F78C File Offset: 0x0003D98C
		private void EditModeTextBox_PreviewMouseUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)1501364225;
			if (num != 0)
			{
			}
			num = (short)1043486831;
			short num2 = num;
			num = (short)473716847;
			switch (num2 == num)
			{
			default:
			{
				num = (short)214630400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)592576512;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)base.EditTemplate.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪤힦\udca8\udbaa", a_), this);
			popup.IsOpen = !popup.IsOpen;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0003F86C File Offset: 0x0003DA6C
		private void DropDownTree_SelectedNodesCollectionChanged(object A_0, global::Infragistics.Controls.Menus.NodeSelectionEventArgs A_1)
		{
			int a_ = 2;
			short num = (short)1026752512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)679149569;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3;
				for (;;)
				{
					IL_58:
					object obj;
					object obj2;
					switch (num2)
					{
					case 0:
					{
						global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = A_1.OriginalSelectedNodes.FirstOrDefault<global::Infragistics.Controls.Menus.XamDataTreeNode>();
						if (xamDataTreeNode == null)
						{
							num = (short)404160516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = xamDataTreeNode.Data;
						goto IL_163;
					}
					case 1:
						obj2 = null;
						goto IL_1B1;
					case 2:
						if (base.IsInEditMode)
						{
							num = (short)1965686787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_22B;
					case 4:
						obj = null;
						goto IL_163;
					case 5:
					{
						global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = A_1.CurrentSelectedNodes.FirstOrDefault<global::Infragistics.Controls.Menus.XamDataTreeNode>();
						if (xamDataTreeNode2 == null)
						{
							num = (short)1223884801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj2 = xamDataTreeNode2.Data;
						goto IL_1B1;
					}
					case 6:
						return;
					case 7:
					{
						if (xamDataTreeNode3 == null)
						{
							num = (short)781320200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1293525553;
						short num3 = num;
						num = (short)667460145;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22B;
						default:
							num = (short)330432512;
							if (num != 0)
							{
							}
							num = (short)44957696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						return;
					}
					goto IL_83;
					IL_163:
					object oldValue = obj;
					num = (short)37617669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B1:
					object newValue = obj2;
					global::System.Windows.RoutedPropertyChangedEventArgs<object> e = new global::System.Windows.RoutedPropertyChangedEventArgs<object>(oldValue, newValue);
					this.SelectedItemChanged(this, e);
					num = (short)2002583552;
					short num4 = num;
					num = (short)1931673602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B:
					global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)base.EditTemplate.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪙햟튡", a_), this);
					popup.IsOpen = false;
					num = (short)2001862662;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_83:
				global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)A_0;
				xamDataTreeNode3 = xamDataTree.SelectionSettings.SelectedNodes[0];
				num = (short)529793031;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0003FAEC File Offset: 0x0003DCEC
		private void ToggleButtonContentMode_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1863122949;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Controls.Primitives.Popup popup;
				object obj;
				switch (num2)
				{
				case 0:
					goto IL_FE;
				case 1:
					if (popup != null)
					{
						num = (short)660865028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
				case 2:
				{
					global::System.Windows.Controls.ControlTemplate editTemplate = base.EditTemplate;
					if (editTemplate == null)
					{
						num = (short)1720582147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = editTemplate.FindName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛킟힡풣", a_), this);
					goto IL_103;
				}
				case 3:
					obj = null;
					goto IL_103;
				case 4:
					popup.IsOpen = true;
					num = (short)347013120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)518914049;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 6:
					return;
				}
				IL_70:
				if (!base.StartEditMode())
				{
					num = (short)1526464518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)609484802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_103:
				popup = (global::System.Windows.Controls.Primitives.Popup)obj;
				num = (short)1524505016;
				short num3 = num;
				num = (short)312154552;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FE;
				default:
					num = (short)1605107712;
					if (num != 0)
					{
					}
					num = (short)4128769;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return;
			IL_FE:
			IL_18A:
			num = (short)1345847296;
			short num4 = num;
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060003DD RID: 989 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
		// (remove) Token: 0x060003DE RID: 990 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		public event global::System.Windows.RoutedPropertyChangedEventHandler<object> SelectedItemChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				IL_0A:
				short num = (short)44171265;
				if (num != 0)
				{
				}
				int num2;
				global::System.Windows.RoutedPropertyChangedEventHandler<object> routedPropertyChangedEventHandler;
				switch (num2)
				{
				case 0:
					goto IL_E1;
				case 1:
					return;
				case 2:
					break;
				default:
				{
					IL_44:
					routedPropertyChangedEventHandler = this.SelectedItemChanged;
					num = (short)466852212;
					short num3 = num;
					num = (short)1865914740;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						num = (short)1172307968;
						if (num != 0)
						{
						}
						num = (short)1369964546;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					break;
				}
				}
				IL_AD:
				global::System.Windows.RoutedPropertyChangedEventHandler<object> routedPropertyChangedEventHandler2 = routedPropertyChangedEventHandler;
				global::System.Windows.RoutedPropertyChangedEventHandler<object> value2 = (global::System.Windows.RoutedPropertyChangedEventHandler<object>)global::System.Delegate.Combine(routedPropertyChangedEventHandler2, value);
				routedPropertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.Windows.RoutedPropertyChangedEventHandler<object>>(ref this.SelectedItemChanged, value2, routedPropertyChangedEventHandler2);
				num = (short)1781006336;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
				IL_E1:
				num = (short)1902313472;
				short num4 = num;
				if (routedPropertyChangedEventHandler == routedPropertyChangedEventHandler2)
				{
					num = (short)456785921;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				goto IL_AD;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1396113409;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				IL_31:
				int num2;
				global::System.Windows.RoutedPropertyChangedEventHandler<object> routedPropertyChangedEventHandler;
				switch (num2)
				{
				case 0:
					goto IL_DF;
				case 1:
					return;
				case 2:
					break;
				default:
				{
					IL_43:
					routedPropertyChangedEventHandler = this.SelectedItemChanged;
					num = (short)1042619000;
					short num3 = num;
					num = (short)1138236024;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DF;
					default:
						num = (short)1422852096;
						if (num != 0)
						{
						}
						num = (short)1403846658;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					}
					break;
				}
				}
				IL_AB:
				global::System.Windows.RoutedPropertyChangedEventHandler<object> routedPropertyChangedEventHandler2 = routedPropertyChangedEventHandler;
				global::System.Windows.RoutedPropertyChangedEventHandler<object> value2 = (global::System.Windows.RoutedPropertyChangedEventHandler<object>)global::System.Delegate.Remove(routedPropertyChangedEventHandler2, value);
				routedPropertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.Windows.RoutedPropertyChangedEventHandler<object>>(ref this.SelectedItemChanged, value2, routedPropertyChangedEventHandler2);
				num = (short)1289158656;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
				IL_DF:
				num = (short)872022016;
				short num4 = num;
				if (routedPropertyChangedEventHandler == routedPropertyChangedEventHandler2)
				{
					num = (short)683409409;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				goto IL_AB;
			}
		}

		// Token: 0x04000149 RID: 329
		public static readonly global::System.Windows.DependencyProperty CurrentGroupProperty;

		// Token: 0x0400014A RID: 330
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty;

		// Token: 0x0400014B RID: 331
		public static readonly global::System.Windows.DependencyProperty NodeLayoutsProperty;
	}
}
