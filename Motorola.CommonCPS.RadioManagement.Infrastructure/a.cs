using System;
using Infragistics.Windows.DataPresenter.Events;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000004 RID: 4
	internal static class a
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002674 File Offset: 0x00000874
		internal static object[] a(global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs A_0)
		{
			short num = (short)1728643072;
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
				bool flag;
				string text2;
				for (;;)
				{
					IL_28:
					string text;
					switch (num2)
					{
					case 0:
					{
						if (!flag)
						{
							num = (short)469893129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)391920212;
						short num3 = num;
						num = (short)848247380;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_378;
						default:
							num = (short)1205075968;
							if (num != 0)
							{
							}
							num = (short)991166465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1FC;
					case 2:
						goto IL_419;
					case 3:
					{
						int? num4 = (int?)A_0.Cell.Value;
						int? num5 = (int?)A_0.Editor.Value;
						num = (short)271122448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_C6;
					case 5:
						if (A_0.Editor.Value is int?)
						{
							num = (short)867237891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6;
					case 6:
						if (A_0.Cell.Value is string)
						{
							num = (short)1667366930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)20709391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_14A;
					case 8:
						if (!(A_0.Cell.Value is string))
						{
							num = (short)493944842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14A;
					case 9:
						goto IL_FD;
					case 10:
					{
						num = (short)437452800;
						short num6 = num;
						num = (short)172883969;
						if (num != 0)
						{
						}
						string empty = string.Empty;
						num = (short)1848901639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_C6;
					case 12:
						num = (short)784662533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text = string.Empty;
						num = (short)743899138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_378;
					case 15:
						if (A_0.Cell.Value is int?)
						{
							num = (short)1502871564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6;
					case 16:
					{
						int? num4;
						int? num5;
						if (num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null))
						{
							num = (short)139395086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6;
					}
					case 17:
						if (text == null)
						{
							num = (short)18153485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 18:
						num = (short)1300168712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_C6:
					num = (short)1104936960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14A:
					text = (A_0.Editor.Value as string);
					num = (short)1544749073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_378:
					flag = false;
					num = (short)2118975492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					text2 = text;
					num = (short)591200267;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FD:
				A_0.AcceptChanges = false;
				return null;
				IL_1FC:
				object[] array = new object[3];
				array[0] = A_0.Cell.Record.DataItem;
				array[1] = A_0.Cell.Field.Name;
				int num7 = 2;
				string text3;
				if ((text3 = text2) == null)
				{
					text3 = A_0.Editor.Value;
				}
				array[num7] = text3;
				return array;
				IL_7B:
				text2 = null;
				flag = true;
				num = (short)431030278;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
