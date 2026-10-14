using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D9 RID: 217
	public class ShowTemplateVADetailInfomationCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x0004A4E4 File Offset: 0x000486E4
		public override bool CanExecute(params object[] paras)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase;
			short num;
			for (;;)
			{
				templateBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase);
				if (templateBase != null)
				{
					num = (short)1527774121;
					short num2 = num;
					num = (short)1236204457;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_6F;
					}
					break;
				}
				return false;
			}
			num = (short)1770389504;
			short num3 = num;
			IL_6F:
			num = (short)486539265;
			if (num != 0)
			{
			}
			num = (short)250937344;
			if (num != 0)
			{
			}
			return templateBase.ID != null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0004A5B0 File Offset: 0x000487B0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)838187639;
			short num2 = num;
			num = (short)1503902327;
			switch (num2 == num)
			{
			}
			num = (short)142671872;
			short num3 = num;
			num = (short)1794375681;
			if (num != 0)
			{
			}
			num = (short)96862208;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext showTemplateVAPacksContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext();
			new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>();
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase;
			showTemplateVAPacksContext.VAPacksDetailInfo = base.LocalService.GetTemplateVADetailInfo(templateBase.ID.Value);
			base.Interaction.ShowTemplateVAPacksDialog(showTemplateVAPacksContext);
			return null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0004A6B0 File Offset: 0x000488B0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(59383947 + A_1) + (global::System.IntPtr)28 + (global::System.IntPtr)73);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
