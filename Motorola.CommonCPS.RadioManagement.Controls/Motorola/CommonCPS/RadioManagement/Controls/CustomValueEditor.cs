using System;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Editors.Events;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000088 RID: 136
	public class CustomValueEditor : global::Infragistics.Windows.Editors.ValueEditor
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00036740 File Offset: 0x00034940
		public override bool CanEditType(global::System.Type type)
		{
			short num = (short)1212899817;
			short num2 = num;
			num = (short)80830953;
			switch (num2 == num)
			{
			}
			num = (short)1801781248;
			if (num != 0)
			{
			}
			num = (short)736493569;
			if (num != 0)
			{
			}
			num = (short)562429952;
			short num3 = num;
			return true;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000367EC File Offset: 0x000349EC
		public override bool CanRenderType(global::System.Type type)
		{
			short num = (short)1286917689;
			short num2 = num;
			num = (short)1523043897;
			switch (num2 == num)
			{
			}
			num = (short)482279425;
			if (num != 0)
			{
			}
			num = (short)212992000;
			if (num != 0)
			{
			}
			num = (short)1053556736;
			short num3 = num;
			return true;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00036898 File Offset: 0x00034A98
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			short num = (short)690957965;
			short num2 = num;
			num = (short)615263885;
			switch (num2 == num)
			{
			}
			num = (short)1507852289;
			if (num != 0)
			{
			}
			num = (short)1921646592;
			if (num != 0)
			{
			}
			num = (short)971046912;
			short num3 = num;
			base.OnEditModeStarting(args);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00036948 File Offset: 0x00034B48
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1751973889;
					if (num2 != 0)
					{
					}
					goto IL_D9;
				case 1:
				{
					num2 = (short)29949952;
					short num3 = num2;
					((global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)this.GetVisualChild(0)).SetFocus();
					num2 = (short)416612352;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					IL_38:
					if (this.GetVisualChild(0) is global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)
					{
						num2 = (short)1230766081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D9;
				}
				goto IL_1C;
				IL_D9:
				num2 = (short)516067620;
				short num4 = num2;
				num2 = (short)1117557028;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_38;
				default:
					goto IL_10E;
				}
			}
			IL_10E:
			num2 = (short)1209925632;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			base.OnEditModeStarted(args);
			num2 = (short)1819869186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
