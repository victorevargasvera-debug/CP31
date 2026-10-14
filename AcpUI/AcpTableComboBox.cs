using System;
using System.Windows;
using System.Windows.Input;

namespace AcpUI
{
	// Token: 0x02000010 RID: 16
	public class AcpTableComboBox : global::AcpUI.AcpComboBox
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00013890 File Offset: 0x00011A90
		protected override void OnDropDownOpened(global::System.EventArgs e)
		{
			short num = (short)1557790720;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
				{
					num = (short)620470140;
					short num3 = num;
					num = (short)1482137468;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					case 1:
						goto IL_CF;
					}
					goto Block_2;
				}
				case 2:
					base.IsDropDownOpen = true;
					num = (short)1867120643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_12B;
				}
				IL_34:
				if (base.IsFocused)
				{
					num = (short)829554690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				base.IsDropDownOpen = false;
				num = (short)951123969;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)1986265088;
			short num4 = num;
			IL_CF:
			num = (short)1007419393;
			if (num != 0)
			{
			}
			num = (short)1187512320;
			if (num != 0)
			{
			}
			IL_12B:
			base.OnDropDownOpened(e);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000139D4 File Offset: 0x00011BD4
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)378424101;
			short num2 = num;
			num = (short)1693010725;
			switch (num2 == num)
			{
			}
			num = (short)1879441408;
			if (num != 0)
			{
			}
			num = (short)1891565568;
			short num3 = num;
			num = (short)637861889;
			if (num != 0)
			{
			}
			global::System.Windows.Input.Keyboard.Focus(this);
			base.OnGotFocus(e);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00013A8C File Offset: 0x00011C8C
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1055457282;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_89;
					case 1:
					{
						num = (short)2002879787;
						short num3 = num;
						num = (short)1126925611;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)110166016;
							if (num != 0)
							{
							}
							num = (short)1142882309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
						base.IsDropDownOpen = false;
						num = (short)1323630596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_84;
					case 5:
						if (e.Key == global::System.Windows.Input.Key.Return)
						{
							num = (short)2137849856;
							short num4 = num;
							num = (short)1982201856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C2;
					case 6:
						if (base.IsDropDownOpen)
						{
							num = (short)64815107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.IsDropDownOpen = true;
						num = (short)2098921479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1C0;
					}
					IL_45:
					if (e.Key != global::System.Windows.Input.Key.Space)
					{
						num = (short)4128769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_89:
					num = (short)698089473;
					if (num != 0)
					{
					}
					num = (short)79560710;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_84:
			IL_1C0:
			IL_1C2:
			new global::AcpUI.AcpTableTextBoxBase().AcpTableTextBox_PreviewKeyDown(null, e);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00013C68 File Offset: 0x00011E68
		private void AcpTableComboBox_MouseLeftButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1237712897;
			if (num != 0)
			{
			}
			num = (short)143363732;
			short num2 = num;
			num = (short)1681100436;
			switch (num2 == num)
			{
			}
			num = (short)1791885312;
			short num3 = num;
			num = (short)1263992832;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00013D14 File Offset: 0x00011F14
		private void AcpTableComboBox_PreviewMouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1278302571;
			short num2 = num;
			num = (short)1228167531;
			switch (num2 == num)
			{
			}
			num = (short)1635778561;
			if (num != 0)
			{
			}
			num = (short)1779105792;
			short num3 = num;
			num = (short)1419509760;
			if (num != 0)
			{
			}
		}
	}
}
