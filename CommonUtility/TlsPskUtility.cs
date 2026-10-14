using System;
using System.Text;

namespace CommonUtility
{
	// Token: 0x02000056 RID: 86
	public static class TlsPskUtility
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0002EF58 File Offset: 0x0002D158
		public static bool TryGetDefaultPsk(string pskId, out string defaultPsk)
		{
			int a_ = 14;
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)219354537;
						short num3 = num2;
						num2 = (short)901453225;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30;
						default:
							num2 = (short)1087307776;
							if (num2 != 0)
							{
							}
							if (!(pskId == global::CommonUtility.VersionUtility.b("績ᅀᭂᩄ͆ైൊᵌᱎᩐ扒", a_)))
							{
								num2 = (short)168034305;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_115;
						}
						break;
					}
					case 1:
						num2 = (short)619773954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!(pskId == global::CommonUtility.VersionUtility.b("績ᅀᭂᩄ͆ైൊᵌᱎᩐ慒", a_)))
						{
							num2 = (short)578945028;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_188;
					case 3:
						return false;
					case 4:
						num2 = (short)1254621187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D;
				}
				IL_115:
				defaultPsk = global::CommonUtility.VersionUtility.b("社祀穂籄نୈࡊౌ祎捐慒浔扖ᩘ὚摜潞坠兢剤剦⵨⹪屬幮䑰䁲䍴䍶㭸佺䭼", a_);
				return true;
				IL_188:
				defaultPsk = global::CommonUtility.VersionUtility.b("ܾ煀獂݄獆祈ࡊ籌౎ၐᅒ晔捖汘楚ᡜ桞╠卢剤幦全⽪幬幮䝰㉲䕴䙶䅸佺䭼", a_);
				return true;
			}
			IL_2D:
			defaultPsk = null;
			IL_30:
			num2 = (short)1555955713;
			if (num2 != 0)
			{
			}
			num2 = (short)1170538496;
			short num4 = num2;
			num2 = (short)2138439680;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0002F100 File Offset: 0x0002D300
		public static bool TryGetDefaultPsk(byte[] identityHintBytes, out string defaultPsk)
		{
			short num = (short)1116667904;
			short num2 = num;
			num = (short)1916241366;
			short num3 = num;
			num = (short)677086678;
			switch (num3 == num)
			{
			}
			num = (short)1384185856;
			if (num != 0)
			{
			}
			num = (short)1925054465;
			if (num != 0)
			{
			}
			return global::CommonUtility.TlsPskUtility.TryGetDefaultPsk(global::CommonUtility.TlsPskUtility.GetPskId(identityHintBytes), out defaultPsk);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0002F1B8 File Offset: 0x0002D3B8
		public static string GetPskId(byte[] identityHintBytes)
		{
			short num = (short)553517056;
			short num2 = num;
			num = (short)38076417;
			if (num != 0)
			{
			}
			num = (short)277554252;
			short num3 = num;
			num = (short)47785036;
			switch (num3 == num)
			{
			}
			num = (short)1437007872;
			if (num != 0)
			{
			}
			return global::System.Text.Encoding.ASCII.GetString(identityHintBytes);
		}
	}
}
