using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200009A RID: 154
	public static class RibbonCommandManager
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x000A6C68 File Offset: 0x000A4E68
		public static void Connect(global::System.Windows.Input.ICommand command, global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender extender)
		{
			short num = (short)1252458497;
			if (num != 0)
			{
			}
			num = (short)931183814;
			short num2 = num;
			num = (short)1613741254;
			switch (num2 == num)
			{
			default:
			{
				num = (short)441319424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1159790592;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonCommandManager.m_Commands[command] = extender;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		public static void Disconnect(global::System.Windows.Input.ICommand command, global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender extender)
		{
			short num = (short)1055451024;
			short num2 = num;
			num = (short)1135142800;
			switch (num2 == num)
			{
			}
			num = (short)1218969600;
			short num3 = num;
			num = (short)752812033;
			if (num != 0)
			{
			}
			num = (short)1257439232;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonCommandManager.m_Commands.Remove(command);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000A6DCC File Offset: 0x000A4FCC
		public static global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender GetExender(global::System.Windows.Input.ICommand command)
		{
			short num = (short)1608201174;
			short num2 = num;
			num = (short)1758213078;
			switch (num2 == num)
			{
			}
			num = (short)1588789248;
			short num3 = num;
			num = (short)1684996097;
			if (num != 0)
			{
			}
			num = (short)2144600064;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender result = null;
			global::DevComponents.WpfRibbon.RibbonCommandManager.m_Commands.TryGetValue(command, out result);
			return result;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000A6E84 File Offset: 0x000A5084
		public static void ClearCommands()
		{
			short num = (short)1768103066;
			short num2 = num;
			num = (short)1893080218;
			switch (num2 == num)
			{
			}
			num = (short)1711734784;
			short num3 = num;
			num = (short)1903886337;
			if (num != 0)
			{
			}
			num = (short)1690107904;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonCommandManager.m_Commands.Clear();
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000A6F38 File Offset: 0x000A5138
		// Note: this type is marked as 'beforefieldinit'.
		static RibbonCommandManager()
		{
			short num = (short)1656194511;
			short num2 = num;
			num = (short)1427932623;
			switch (num2 == num)
			{
			}
			num = (short)572391424;
			short num3 = num;
			num = (short)122028032;
			if (num != 0)
			{
			}
			num = (short)1715404801;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonCommandManager.m_Commands = new global::System.Collections.Generic.Dictionary<global::System.Windows.Input.ICommand, global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender>();
		}

		// Token: 0x0400065F RID: 1631
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.Input.ICommand, global::DevComponents.WpfRibbon.IButtonDropDownCommandExtender> m_Commands;
	}
}
