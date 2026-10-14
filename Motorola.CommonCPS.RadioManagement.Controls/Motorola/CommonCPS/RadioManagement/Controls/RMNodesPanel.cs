using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using Infragistics.Controls.Menus.Primitives;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000065 RID: 101
	public class RMNodesPanel : global::Infragistics.Controls.Menus.Primitives.NodesPanel
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00022EBC File Offset: 0x000210BC
		private void c()
		{
			short num = (short)789052198;
			short num2 = num;
			num = (short)897514278;
			switch (num2 == num)
			{
			}
			num = (short)1778515969;
			if (num != 0)
			{
			}
			num = (short)1953562624;
			short num3 = num;
			num = (short)296026112;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNodesPanel.<BugFixForTreeReflushIssues>d__5 <BugFixForTreeReflushIssues>d__;
			<BugFixForTreeReflushIssues>d__.b = global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
			<BugFixForTreeReflushIssues>d__.c = this;
			<BugFixForTreeReflushIssues>d__.a = -1;
			<BugFixForTreeReflushIssues>d__.b.Start<global::Motorola.CommonCPS.RadioManagement.Controls.RMNodesPanel.<BugFixForTreeReflushIssues>d__5>(ref <BugFixForTreeReflushIssues>d__);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00022F90 File Offset: 0x00021190
		private void b()
		{
			short num = (short)1184301059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)230621185;
					if (num != 0)
					{
					}
					num = (short)926860125;
					short num3 = num;
					num = (short)1337443165;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						goto IL_1A2;
					}
					break;
				}
				case 1:
					this.a();
					num = (short)1415512064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					base.UpdateScrollInfo(this.totalNodeCountOfLastTime, this.finalWidthOfLastTime);
					num = (short)165281798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 4:
					goto IL_77;
				case 5:
					if (this.totalNodeCountOfLastTime != this.totalNodeCountOfPreLastTime)
					{
						num = (short)258539522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 6:
					goto IL_79;
				case 7:
					if (this.totalNodeCountOfLastTime < this.totalNodeCountOfPreLastTime)
					{
						num = (short)1878261761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					num = (short)1160708096;
					short num4 = num;
					num = (short)966721541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (this.totalNodeCountOfLastTime > 0)
					{
						num = (short)851640328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_4D:
				if (this.finalWidthOfLastTime > 0.0)
				{
					num = (short)1807482884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_77:
				num = (short)197394441;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_79:
				num = (short)1512636423;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A2:
			num = (short)140378112;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000231C4 File Offset: 0x000213C4
		protected override void UpdateScrollInfo(int totalNodeCount, double finalWidth)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1283391488;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_204;
				case 1:
					this.totalNodeCountOfPreLastTime = this.totalNodeCountOfLastTime;
					this.totalNodeCountOfLastTime = totalNodeCount;
					this.isUpdatingScrollInfoManually = true;
					base.Tree.Dispatcher.BeginInvoke(new global::Motorola.CommonCPS.RadioManagement.Controls.RMNodesPanel.EmptyDelegate(this.c), global::System.Windows.Threading.DispatcherPriority.Background, global::System.Array.Empty<object>());
					num = (short)1055850496;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.finalWidthOfLastTime = finalWidth;
					num = (short)1963851777;
					if (num != 0)
					{
					}
					num = (short)1090584582;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.totalNodeCountOfLastTime > 0)
					{
						num = (short)606535684;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				case 4:
					goto IL_12C;
				case 5:
					if (!this.isUpdatingScrollInfoManually)
					{
						num = (short)1950089218;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				case 6:
					goto IL_A3;
				case 7:
					if (!this.isUpdatingScrollInfoManually)
					{
						num = (short)1457258497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				case 8:
					this.a();
					num = (short)717291525;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (totalNodeCount == this.totalNodeCountOfLastTime)
					{
						num = (short)38273032;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				}
				goto IL_60;
				IL_A3:
				num = (short)563609607;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_12C:
				num = (short)925302793;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_204:
				num = (short)682637753;
				short num4 = num;
				num = (short)707279289;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12C;
				default:
					goto IL_239;
				}
			}
			IL_239:
			num = (short)462684160;
			if (num != 0)
			{
			}
			return;
			IL_60:
			base.UpdateScrollInfo(totalNodeCount, finalWidth);
			num = (short)1347092483;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00023420 File Offset: 0x00021620
		private void a()
		{
			short num = (short)31195136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						double value;
						double num3 = this.a(value);
						double maximum;
						double obj = this.a(maximum);
						num = (short)1753874439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						double num3;
						double obj;
						if (num3.Equals(obj))
						{
							num = (short)751697929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						if (verticalScrollBar != null)
						{
							num = (short)219611142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						double value;
						double maximum;
						if (!value.Equals(maximum))
						{
							num = (short)1114636288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						goto IL_226;
					case 5:
						num = (short)1153171468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)834207748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						double num3;
						if (!num3.Equals(0.0))
						{
							num = (short)576716810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
						goto IL_1DF;
					case 9:
						verticalScrollBar.Maximum = verticalScrollBar.Value;
						num = (short)1470693387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)393456088;
						short num4 = num;
						num = (short)1443670488;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_226;
						default:
							num = (short)603324416;
							if (num != 0)
							{
							}
							num = (short)1223098369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						goto IL_209;
					case 12:
					{
						num = (short)2113929217;
						if (num != 0)
						{
						}
						if (!verticalScrollBar.IsEnabled)
						{
							num = (short)1794048008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double value = verticalScrollBar.Value;
						double maximum = verticalScrollBar.Maximum;
						num = (short)1311637504;
						short num5 = num;
						num = (short)46006275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_62;
					IL_226:
					if (!verticalScrollBar.IsVisible)
					{
						break;
					}
					num = (short)158466053;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DF:
				return;
				IL_209:
				return;
				IL_62:
				verticalScrollBar = base.ScrollInfo.VerticalScrollBar;
				num = (short)420347906;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00023708 File Offset: 0x00021908
		private double a(double A_0)
		{
			short num = (short)1119280136;
			short num2 = num;
			num = (short)384228360;
			switch (num2 == num)
			{
			}
			num = (short)1259208705;
			if (num != 0)
			{
			}
			num = (short)482869248;
			short num3 = num;
			num = (short)1475739648;
			if (num != 0)
			{
			}
			return A_0 - global::System.Math.Floor(A_0);
		}

		// Token: 0x04000095 RID: 149
		private bool isUpdatingScrollInfoManually;

		// Token: 0x04000096 RID: 150
		private int totalNodeCountOfLastTime = -1;

		// Token: 0x04000097 RID: 151
		private int totalNodeCountOfPreLastTime = -1;

		// Token: 0x04000098 RID: 152
		private double finalWidthOfLastTime = -1.0;

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate void EmptyDelegate();
	}
}
