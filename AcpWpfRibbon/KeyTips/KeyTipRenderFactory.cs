using System;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000CF RID: 207
	internal static class KeyTipRenderFactory
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x000C5B48 File Offset: 0x000C3D48
		public static global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer GetRenderer(object o)
		{
			short num = (short)1392312322;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (o is global::DevComponents.WpfRibbon.ApplicationMenu)
					{
						num = (short)1668284425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)354156552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1854865408;
					short num3 = num;
					num = (short)1486563340;
					short num4 = num;
					num = (short)2066556940;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						goto IL_CD;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 3:
					if (o is global::DevComponents.WpfRibbon.RibbonBar)
					{
						num = (short)313524231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_132;
				case 4:
					goto IL_194;
				case 5:
					num = (short)390660097;
					if (num != 0)
					{
					}
					if (o is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)1531510788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_224;
				case 6:
					goto IL_219;
				case 7:
					goto IL_1D6;
				case 8:
					if (o is global::DevComponents.WpfRibbon.RibbonTab)
					{
						num = (short)1419051014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1654587395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_12D;
				}
				IL_4C:
				if (o is global::DevComponents.WpfRibbon.Ribbon)
				{
					num = (short)638844929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1528627200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_132:
				num = (short)333447173;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			num = (short)103677952;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_RibbonKeyTipRenderer;
			IL_12D:
			return global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_AppMenuKeyTipRenderer;
			IL_194:
			return global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_ButtonPopupKeyTipRenderer;
			IL_1D6:
			return global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_RibbonBarKeyTipRenderer;
			IL_219:
			return global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_RibbonTabKeyTipRenderer;
			IL_224:
			return null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000C5D7C File Offset: 0x000C3F7C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyTipRenderFactory()
		{
			short num = (short)382599169;
			if (num != 0)
			{
			}
			num = (short)94255910;
			short num2 = num;
			num = (short)250297126;
			switch (num2 == num)
			{
			}
			num = (short)1335820288;
			if (num != 0)
			{
			}
			num = (short)716177408;
			short num3 = num;
			global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_RibbonKeyTipRenderer = new global::DevComponents.WpfRibbon.KeyTips.RibbonKeyTipRenderer();
			global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_RibbonTabKeyTipRenderer = new global::DevComponents.WpfRibbon.KeyTips.RibbonTabKeyTipRenderer();
			global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_RibbonBarKeyTipRenderer = new global::DevComponents.WpfRibbon.KeyTips.RibbonBarKeyTipRenderer();
			global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_ButtonPopupKeyTipRenderer = new global::DevComponents.WpfRibbon.KeyTips.ButtonPopupKeyRenderer();
			global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderFactory.m_AppMenuKeyTipRenderer = new global::DevComponents.WpfRibbon.KeyTips.AppMenuKeyTipRenderer();
		}

		// Token: 0x04000757 RID: 1879
		private static global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer m_RibbonKeyTipRenderer;

		// Token: 0x04000758 RID: 1880
		private static global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer m_RibbonTabKeyTipRenderer;

		// Token: 0x04000759 RID: 1881
		private static global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer m_RibbonBarKeyTipRenderer;

		// Token: 0x0400075A RID: 1882
		private static global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer m_ButtonPopupKeyTipRenderer;

		// Token: 0x0400075B RID: 1883
		private static global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer m_AppMenuKeyTipRenderer;
	}
}
