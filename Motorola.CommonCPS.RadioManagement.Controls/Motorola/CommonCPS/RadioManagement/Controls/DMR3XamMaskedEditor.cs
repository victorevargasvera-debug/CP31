using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200003D RID: 61
	public class DMR3XamMaskedEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		public DMR3XamMaskedEditor()
		{
			base.Mask = null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			int a_ = 7;
			short num = (short)1687486467;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				global::System.Windows.Input.Key key;
				switch (num2)
				{
				case 0:
					num = (short)1359347738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_312;
				case 2:
					goto IL_40E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 4:
					num = (short)1054867471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (num3 >= 34)
					{
						num = (short)659030016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40E;
				case 6:
					if (key != global::System.Windows.Input.Key.Right)
					{
						num = (short)1952120839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				case 7:
					num = (short)2014511120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1621098510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)839450648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_336;
				case 11:
					if (num3 >= 74)
					{
						num = (short)1811152900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
				case 12:
					goto IL_317;
				case 13:
					key = (global::System.Windows.Input.Key)global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.RealPInfo.GetValue(e, null);
					num = (short)925564951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (key != global::System.Windows.Input.Key.Left)
					{
						num = (short)1202520065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				case 15:
					if (num3 <= 83)
					{
						num = (short)1577713692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
				case 16:
					if (e.Key == global::System.Windows.Input.Key.Return)
					{
						num = (short)429654028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DA;
				case 17:
				{
					if (base.Text.Length < this.MaxLength)
					{
						num = (short)137822235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1028184813;
					short num4 = num;
					num = (short)1871108845;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_312;
					default:
						num = (short)1835204608;
						if (num != 0)
						{
						}
						num = (short)649920533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 18:
					if (key != global::System.Windows.Input.Key.Back)
					{
						num = (short)1128333321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				case 19:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.RealPInfo != null)
					{
						num = (short)2125987853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 20:
					goto IL_20C;
				case 21:
					if (base.SelectionLength > 0)
					{
						num = (short)2043478041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_257;
				case 22:
				{
					global::System.Type typeFromHandle = typeof(global::System.Windows.Input.KeyEventArgs);
					global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.RealPInfo = typeFromHandle.GetProperty(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춞쒠슢즤첨튪", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					num = (short)840171540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 23:
					goto IL_195;
				case 24:
					if (key != global::System.Windows.Input.Key.Delete)
					{
						num = (short)1435500552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				case 25:
					goto IL_190;
				case 26:
					if (num3 > 43)
					{
						num = (short)1382154242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44C;
				case 27:
					goto IL_491;
				case 28:
					goto IL_44C;
				}
				IL_A2:
				if (global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.RealPInfo == null)
				{
					num = (short)361693206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_20C;
				IL_CF:
				num = (short)1638268946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_195:
				num3 = (int)key;
				num = (short)2025979909;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20C:
				key = e.Key;
				num = (short)1333788691;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_312:
				num = (short)1758068742;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_317:
				base.OnPreviewKeyDown(e);
				num = (short)379977738;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_40E:
				num = (short)1328087051;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44C:
				num = (short)469041169;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_190:
			base.OnPreviewKeyDown(e);
			return;
			IL_257:
			e.Handled = true;
			return;
			IL_336:
			num = (short)602931201;
			if (num != 0)
			{
			}
			goto IL_4DA;
			IL_491:
			base.OnPreviewKeyDown(e);
			return;
			IL_4DA:
			num = (short)1548746752;
			short num5 = num;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000CB04 File Offset: 0x0000AD04
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		public int MaxLength
		{
			get
			{
				short num = (short)1520718951;
				short num2 = num;
				num = (short)487216231;
				switch (num2 == num)
				{
				}
				num = (short)312672256;
				short num3 = num;
				num = (short)1774256129;
				if (num != 0)
				{
				}
				num = (short)440139776;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.MaxLengthProperty);
			}
			set
			{
				short num = (short)1215313568;
				short num2 = num;
				num = (short)1809790624;
				switch (num2 == num)
				{
				}
				num = (short)762052608;
				short num3 = num;
				num = (short)825032705;
				if (num != 0)
				{
				}
				num = (short)1925709824;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.MaxLengthProperty, value);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000CC7C File Offset: 0x0000AE7C
		// Note: this type is marked as 'beforefieldinit'.
		static DMR3XamMaskedEditor()
		{
			int a_ = 19;
			short num = (short)363414552;
			short num2 = num;
			num = (short)1526744088;
			switch (num2 == num)
			{
			}
			num = (short)1028587520;
			short num3 = num;
			num = (short)1226964993;
			if (num != 0)
			{
			}
			num = (short)1771044864;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor.MaxLengthProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첬힮ﶰ횲\udbb4킶춸펺", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.DMR3XamMaskedEditor));
		}

		// Token: 0x04000010 RID: 16
		internal static global::System.Reflection.PropertyInfo RealPInfo;

		// Token: 0x04000011 RID: 17
		public static global::System.Windows.DependencyProperty MaxLengthProperty;
	}
}
