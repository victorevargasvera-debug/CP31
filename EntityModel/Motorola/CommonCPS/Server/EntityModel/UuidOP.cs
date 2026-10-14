using System;
using MassTransit;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B9 RID: 441
	public static class UuidOP
	{
		// Token: 0x060016BF RID: 5823 RVA: 0x000F4C94 File Offset: 0x000F2E94
		public static global::System.Guid NewSqeuentialGuid()
		{
			short num = (short)1177265811;
			short num2 = num;
			num = (short)1553639059;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1545076736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)639631360;
			if (num != 0)
			{
			}
			num = (short)166723585;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.UuidOP.a(global::MassTransit.NewId.NextGuid());
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000F4D48 File Offset: 0x000F2F48
		public static bool IsNullOrEmpty(this global::System.Guid uuid)
		{
			short num = (short)971534937;
			short num2 = num;
			num = (short)1342599769;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1724317696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1850081280;
			if (num != 0)
			{
			}
			num = (short)91553793;
			if (num != 0)
			{
			}
			return uuid == global::System.Guid.Empty;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000F4E00 File Offset: 0x000F3000
		public static bool IsNullOrEmpty(this global::System.Guid? uuid)
		{
			short num = (short)1375141890;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			global::System.Guid empty;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					guid = uuid;
					empty = global::System.Guid.Empty;
					num = (short)1001062403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)158869720;
					short num3 = num;
					num = (short)597764312;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1559822336;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				case 3:
					num = (short)300154881;
					if (num != 0)
					{
					}
					if (guid == null)
					{
						num = (short)1500250112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)711065604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (guid == null)
					{
						num = (short)716505093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				case 5:
					goto IL_E3;
				}
				IL_88:
				if (uuid == null)
				{
					goto IL_15F;
				}
				num = (short)156368897;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_E3:
			return true;
			IL_14F:
			return guid.GetValueOrDefault() == empty;
			IL_15F:
			num = (short)326434816;
			short num4 = num;
			return true;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000F4F98 File Offset: 0x000F3198
		private static global::System.Guid a(global::System.Guid A_0)
		{
			short num = (short)397622934;
			short num2 = num;
			num = (short)327499414;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1991245824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2043084801;
			if (num != 0)
			{
			}
			num = (short)913702912;
			if (num != 0)
			{
			}
			byte[] array = A_0.ToByteArray();
			global::System.Array.Reverse(array, 0, 4);
			global::System.Array.Reverse(array, 4, 2);
			global::System.Array.Reverse(array, 6, 2);
			return new global::System.Guid(array);
		}
	}
}
