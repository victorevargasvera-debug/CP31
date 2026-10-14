using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200005D RID: 93
	public class GuiResultItem : global::Motorola.CommonCPS.RadioManagement.UIModels.RfGuiPath
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000288EC File Offset: 0x00026AEC
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000289A0 File Offset: 0x00026BA0
		public bool IsUnloadedSet
		{
			get
			{
				short num = (short)1061289985;
				if (num != 0)
				{
				}
				num = (short)761313769;
				short num2 = num;
				num = (short)2033695209;
				switch (num2 == num)
				{
				}
				num = (short)1983184896;
				short num3 = num;
				num = (short)1445724160;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1557069825;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)369033216;
						short num3 = num;
						num = (short)94896129;
						if (num != 0)
						{
						}
						num = (short)505207981;
						short num4 = num;
						num = (short)1260575917;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F2;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						this.a = value;
						num = (short)1056702464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					if (this.a == value)
					{
						return;
					}
					num = (short)1837105154;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F2:
				num = (short)1356595200;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x0400011F RID: 287
		private bool a;
	}
}
