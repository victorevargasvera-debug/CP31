using System;
using System.Linq;
using System.Windows;
using System.Windows.Interactivity;

namespace Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree
{
	// Token: 0x0200013A RID: 314
	public static class CustomRightMouseDown
	{
		// Token: 0x0600098A RID: 2442 RVA: 0x0009DEE4 File Offset: 0x0009C0E4
		public static void SetActivate(global::System.Windows.UIElement element, bool value)
		{
			short num = (short)1035862016;
			short num2 = num;
			num = (short)1797948983;
			short num3 = num;
			num = (short)1760790071;
			switch (num3 == num)
			{
			}
			num = (short)629997568;
			if (num != 0)
			{
			}
			num = (short)1354235905;
			if (num != 0)
			{
			}
			element.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.ActivateProperty, value);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0009DFA0 File Offset: 0x0009C1A0
		public static bool GetActivate(global::System.Windows.UIElement element)
		{
			short num = (short)77266944;
			short num2 = num;
			num = (short)697219345;
			short num3 = num;
			num = (short)10008849;
			switch (num3 == num)
			{
			}
			num = (short)1606877184;
			if (num != 0)
			{
			}
			num = (short)1827733505;
			if (num != 0)
			{
			}
			return (bool)element.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.ActivateProperty);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0009E05C File Offset: 0x0009C25C
		public static void SetSelect(global::System.Windows.UIElement element, bool value)
		{
			short num = (short)1321402368;
			short num2 = num;
			num = (short)1122762753;
			if (num != 0)
			{
			}
			num = (short)1726892044;
			short num3 = num;
			num = (short)675301388;
			switch (num3 == num)
			{
			}
			num = (short)447938560;
			if (num != 0)
			{
			}
			element.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.SelectProperty, value);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0009E114 File Offset: 0x0009C314
		public static bool GetSelect(global::System.Windows.UIElement element)
		{
			short num = (short)468058112;
			short num2 = num;
			num = (short)22411416;
			short num3 = num;
			num = (short)1928263832;
			switch (num3 == num)
			{
			}
			num = (short)140443649;
			if (num != 0)
			{
			}
			num = (short)1639186432;
			if (num != 0)
			{
			}
			return (bool)element.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.SelectProperty);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0009E1CC File Offset: 0x0009C3CC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)1497497600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_84;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour customRightMouseDownBehaviour;
				bool flag;
				global::System.Windows.Interactivity.BehaviorCollection behaviors;
				for (;;)
				{
					IL_31:
					string name;
					switch (num2)
					{
					case 0:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삤쮦첨좪\ud9ac", a_)))
						{
							num = (short)4587523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						customRightMouseDownBehaviour.Select = (bool)A_1.NewValue;
						goto IL_301;
					case 1:
						goto IL_336;
					case 2:
						goto IL_376;
					case 3:
						num = (short)260440065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (flag)
						{
							num = (short)1160708105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33B;
					case 5:
						goto IL_1BE;
					case 6:
						if (!(name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욤펦삨\uddaa첬\udbae풰", a_)))
						{
							num = (short)1509687308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						customRightMouseDownBehaviour.Activate = (bool)A_1.NewValue;
						num = (short)848429069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (customRightMouseDownBehaviour.CanBeDetached)
						{
							num = (short)466157584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33B;
					case 8:
						goto IL_2EA;
					case 9:
						num = (short)1368915975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)623640576;
						short num3 = num;
						if (customRightMouseDownBehaviour == null)
						{
							num = (short)1888944139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					}
					case 11:
						customRightMouseDownBehaviour = new global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour();
						num = (short)2098397189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)508362752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_376;
					case 14:
						if (!customRightMouseDownBehaviour.CanBeDetached)
						{
							num = (short)1066598417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						if (!flag)
						{
							num = (short)240123922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						goto IL_254;
					case 17:
					{
						behaviors.Add(customRightMouseDownBehaviour);
						num = (short)1554616521;
						short num4 = num;
						num = (short)966365385;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_301;
						default:
							num = (short)497745920;
							if (num != 0)
							{
							}
							num = (short)1631977473;
							if (num != 0)
							{
							}
							num = (short)204734472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						num = (short)924254222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_84;
					IL_1BE:
					name = A_1.Property.Name;
					num = (short)997261318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_301:
					num = (short)1888485378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33B:
					num = (short)373096463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_376:
					num = (short)1099628548;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_254:
				behaviors.Remove(customRightMouseDownBehaviour);
				return;
				IL_2EA:
				return;
				IL_336:
				throw new global::System.NotSupportedException(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒤쪦첨讪邬辮", a_) + A_1.Property.Name);
				IL_84:
				behaviors = global::System.Windows.Interactivity.Interaction.GetBehaviors(A_0);
				customRightMouseDownBehaviour = behaviors.OfType<global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour>().SingleOrDefault<global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour>();
				flag = (customRightMouseDownBehaviour != null);
				num = (short)88145930;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0009E5DC File Offset: 0x0009C7DC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRightMouseDown()
		{
			int a_ = 19;
			short num = (short)201606085;
			short num2 = num;
			num = (short)472138693;
			switch (num2 == num)
			{
			}
			num = (short)1639645185;
			if (num != 0)
			{
			}
			num = (short)994181120;
			short num3 = num;
			num = (short)1920598016;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.ActivateProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캬\udbae\ud8b0얲풴쎶\udcb8", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.SelectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좬쎮풰킲솴", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDown.a)));
		}

		// Token: 0x04000461 RID: 1121
		private const string a = "Activate";

		// Token: 0x04000462 RID: 1122
		private const string b = "Select";

		// Token: 0x04000463 RID: 1123
		public static readonly global::System.Windows.DependencyProperty ActivateProperty;

		// Token: 0x04000464 RID: 1124
		public static readonly global::System.Windows.DependencyProperty SelectProperty;
	}
}
