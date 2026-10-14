using System;

namespace ConstraintHelper
{
	// Token: 0x020005FA RID: 1530
	public static class AppMultiInstanceManager
	{
		// Token: 0x170068C7 RID: 26823
		// (get) Token: 0x0600D0F5 RID: 53493 RVA: 0x00C3C2B4 File Offset: 0x00C3A4B4
		// (set) Token: 0x0600D0F6 RID: 53494 RVA: 0x00C3C364 File Offset: 0x00C3A564
		public static int ParentRecsetPosition
		{
			get
			{
				short num = (short)279230505;
				short num2 = num;
				num = (short)216643625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403898368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1889992705;
				if (num != 0)
				{
				}
				num = (short)893386752;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.AppMultiInstanceManager.a;
			}
			set
			{
				int num;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							if (global::ConstraintHelper.AppMultiInstanceManager.AppMultiInstanceHelper == null)
							{
								return;
							}
							num2 = (short)87538569;
							short num3 = num2;
							num2 = (short)558087049;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_49;
							default:
							{
								num2 = (short)186515456;
								if (num2 != 0)
								{
								}
								num2 = (short)1718026240;
								short num4 = num2;
								num2 = (short)1575616513;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						case 1:
							global::ConstraintHelper.AppMultiInstanceManager.AppMultiInstanceHelper.ParentRecsetPosition = value;
							num2 = (short)1977876482;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							return;
						}
						goto IL_1C;
					}
					return;
				}
				IL_1C:
				num2 = (short)2020474881;
				if (num2 != 0)
				{
				}
				global::ConstraintHelper.AppMultiInstanceManager.a = value;
				IL_49:
				num2 = (short)1411055616;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170068C8 RID: 26824
		// (get) Token: 0x0600D0F7 RID: 53495 RVA: 0x00C3C490 File Offset: 0x00C3A690
		// (set) Token: 0x0600D0F8 RID: 53496 RVA: 0x00C3C540 File Offset: 0x00C3A740
		public static bool IsDynamicZoneChanged
		{
			get
			{
				short num = (short)1508015110;
				short num2 = num;
				num = (short)41122822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616445440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)830668801;
				if (num != 0)
				{
				}
				num = (short)1113849856;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.AppMultiInstanceManager.b;
			}
			set
			{
				short num = (short)1301413889;
				if (num != 0)
				{
				}
				int num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
						{
							if (global::ConstraintHelper.AppMultiInstanceManager.AppMultiInstanceHelper == null)
							{
								return;
							}
							num = (short)1330701381;
							short num3 = num;
							num = (short)322036805;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_49;
							default:
							{
								num = (short)45940736;
								if (num != 0)
								{
								}
								num = (short)1138950144;
								short num4 = num;
								num = (short)1339359233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							global::ConstraintHelper.AppMultiInstanceManager.AppMultiInstanceHelper.IsDynamicZoneChanged = value;
							num = (short)705888258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_43;
					}
					return;
				}
				IL_43:
				global::ConstraintHelper.AppMultiInstanceManager.b = value;
				IL_49:
				num = (short)1128923136;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x00C3C668 File Offset: 0x00C3A868
		static AppMultiInstanceManager()
		{
			short num = (short)1171863614;
			short num2 = num;
			num = (short)1761228862;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2023489536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)758579200;
			if (num != 0)
			{
			}
			num = (short)1302528001;
			if (num != 0)
			{
			}
			global::ConstraintHelper.AppMultiInstanceManager.a = 0;
			global::ConstraintHelper.AppMultiInstanceManager.b = false;
			global::ConstraintHelper.AppMultiInstanceManager.c = new global::ConstraintHelper.MultiInstanceHelper();
		}

		// Token: 0x170068C9 RID: 26825
		// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x00C3C728 File Offset: 0x00C3A928
		// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x00C3C7D8 File Offset: 0x00C3A9D8
		public static global::ConstraintHelper.MultiInstanceHelper AppMultiInstanceHelper
		{
			get
			{
				short num = (short)256657216;
				short num2 = num;
				num = (short)752109376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)604438528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1077477377;
				if (num != 0)
				{
				}
				num = (short)208076800;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.AppMultiInstanceManager.c;
			}
			private set
			{
				short num = (short)992317234;
				short num2 = num;
				num = (short)400396082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741015552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)766312448;
				if (num != 0)
				{
				}
				num = (short)1550450689;
				if (num != 0)
				{
				}
				global::ConstraintHelper.AppMultiInstanceManager.c = value;
			}
		}

		// Token: 0x040065E0 RID: 26080
		private static int a;

		// Token: 0x040065E1 RID: 26081
		private static bool b;

		// Token: 0x040065E2 RID: 26082
		private static global::ConstraintHelper.MultiInstanceHelper c;
	}
}
