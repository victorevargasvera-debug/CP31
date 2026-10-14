using System;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000045 RID: 69
	public class DefaultDragHandler : global::Motorola.CommonCPS.RadioManagement.Controls.IDragSource
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		public bool CanStartDrag(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo dragInfo)
		{
			short num = (short)1408200712;
			short num2 = num;
			num = (short)879521800;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10B:
				num = (short)1640562691;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1981939713;
				if (num != 0)
				{
				}
				num = (short)58916864;
				if (num != 0)
				{
				}
				num = (short)429654016;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				case 1:
					return true;
				case 2:
					goto IL_CC;
				case 3:
				{
					num = (short)281608192;
					short num4 = num;
					if (dragInfo.VisualSource.IsVisible)
					{
						num = (short)1315766277;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 4:
					if (dragInfo.VisualSource.IsEnabled)
					{
						num = (short)148111361;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)824967172;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AD:
				if (dragInfo.VisualSource == null)
				{
					return false;
				}
				num = (short)248446978;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_CC:
			goto IL_10B;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000FD80 File Offset: 0x0000DF80
		public void DragCancelled()
		{
			short num = (short)1117999241;
			short num2 = num;
			num = (short)916082825;
			switch (num2 == num)
			{
			}
			num = (short)2001207297;
			if (num != 0)
			{
			}
			num = (short)1468399616;
			short num3 = num;
			num = (short)824836096;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000FE30 File Offset: 0x0000E030
		public void Dropped(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo dropInfo)
		{
			short num = (short)1492975617;
			if (num != 0)
			{
			}
			num = (short)537260734;
			short num2 = num;
			num = (short)1256190654;
			switch (num2 == num)
			{
			}
			num = (short)122617856;
			short num3 = num;
			num = (short)3211264;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		public virtual void StartDrag(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo dragInfo)
		{
			short num = (short)803752652;
			short num2 = num;
			num = (short)384584396;
			switch (num2 == num)
			{
			}
			num = (short)336134145;
			if (num != 0)
			{
			}
			num = (short)1800404992;
			short num3 = num;
			num = (short)1336016896;
			if (num != 0)
			{
			}
			this.a(dragInfo);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public bool TryCatchOccurredException(global::System.Exception exception)
		{
			short num = (short)446577688;
			short num2 = num;
			num = (short)1872706584;
			switch (num2 == num)
			{
			}
			num = (short)157351937;
			if (num != 0)
			{
			}
			num = (short)1184104448;
			short num3 = num;
			num = (short)132317184;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00010038 File Offset: 0x0000E238
		private void a(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo A_0)
		{
			short num = (short)194303183;
			short num2 = num;
			num = (short)2036192463;
			switch (num2 == num)
			{
			}
			num = (short)1941700608;
			if (num != 0)
			{
			}
			num = (short)414908416;
			short num3 = num;
			num = (short)1551106049;
			if (num != 0)
			{
			}
			this.b();
			this.a = new global::Motorola.CommonCPS.RadioManagement.Controls.DragWindow(A_0.DragItem);
			this.a.Show();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00010100 File Offset: 0x0000E300
		private void b()
		{
			short num;
			try
			{
				num = (short)1040520693;
				short num2 = num;
				num = (short)27268597;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AE:
					num = (short)1029767169;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)270336000;
					if (num != 0)
					{
					}
					num = (short)1279655936;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 1:
						goto IL_C6;
					case 2:
						goto IL_9A;
					case 3:
						goto IL_DC;
					}
					IL_7E:
					if (this.a != null)
					{
						num = (short)726335490;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C6:
					num = (short)1539833859;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_9A:
				this.a.Close();
				this.a = null;
				goto IL_AE;
				IL_DC:;
			}
			catch
			{
			}
			num = (short)1686634496;
			short num4 = num;
			num = (short)2116681729;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00010254 File Offset: 0x0000E454
		private void a()
		{
			short num;
			try
			{
				num = (short)1020543173;
				short num2 = num;
				num = (short)937181381;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AB:
					num = (short)1610547201;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)79101952;
					if (num != 0)
					{
					}
					num = (short)1765146624;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 1:
						goto IL_C3;
					case 2:
						goto IL_9E;
					case 3:
						goto IL_D7;
					}
					IL_81:
					if (this.a != null)
					{
						num = (short)33423362;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C3:
					num = (short)310640643;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_9E:
				this.a.UpdateWindowLocation();
				goto IL_AB;
				IL_D7:;
			}
			catch
			{
			}
			num = (short)364904448;
			short num4 = num;
			num = (short)1809907713;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000103A0 File Offset: 0x0000E5A0
		private DefaultDragHandler()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000103B4 File Offset: 0x0000E5B4
		public static global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler Instance
		{
			get
			{
				short num = (short)336582223;
				short num2 = num;
				num = (short)616748623;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1458307072;
					if (num != 0)
					{
					}
					num = (short)1335951361;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)546766848;
						short num4 = num;
						global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler.b = new global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler();
						num = (short)883425282;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						goto IL_10B;
					}
					IL_7C:
					num = (short)161218561;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler.b != null)
					{
						break;
					}
					num = (short)1108017152;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10B:
				return global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler.b;
			}
		}

		// Token: 0x04000020 RID: 32
		private global::Motorola.CommonCPS.RadioManagement.Controls.DragWindow a;

		// Token: 0x04000021 RID: 33
		private static global::Motorola.CommonCPS.RadioManagement.Controls.DefaultDragHandler b;
	}
}
