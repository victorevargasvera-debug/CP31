using System;
using SSLMangrComp.ConnectionLayer;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002A RID: 42
	public static class PacketFactory
	{
		// Token: 0x0600010C RID: 268 RVA: 0x000101C0 File Offset: 0x0000E3C0
		public static global::SSLMangrComp.Packets.PacketBase GetPacket(byte[] data, ushort lengthbytes)
		{
			int a_ = 15;
			short num = (short)371851264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				byte b;
				global::SSLMangrComp.Packets.PacketBase result;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)433370332;
						short num3 = num;
						num = (short)1262400732;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A5;
						default:
						{
							num = (short)546242560;
							if (num != 0)
							{
							}
							num = (short)273743872;
							short num4 = num;
							if (b != 2)
							{
								num = (short)1024000003;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20D;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						try
						{
							return new global::SSLMangrComp.Packets.Notify(data, lengthbytes);
						}
						catch (global::System.Exception ex)
						{
							global::System.Console.Write(global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ࡀⵂ㍄♆╈≊⥌潎ὐ㱒⅔㹖㽘≚絜⽞`b๤ɦᵨ䭪Ὤ੮ተᩲʹቶᵸ婺睼畾얀ﺌ떎놐", a_) + ex.Message, global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("рㅂ㝄⡆㭈", a_));
							return null;
						}
						goto IL_14E;
					case 3:
						num = (short)2114256901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)583991297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1A5;
					case 6:
						if (b != 11)
						{
							num = (short)191037444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					case 7:
						num = (short)1539375105;
						if (num != 0)
						{
						}
						goto IL_14E;
					}
					goto IL_58;
					IL_14E:
					num = (short)936837126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A5:
					if (b != 4)
					{
						num = (short)118947847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_20D:
					num = (short)975306754;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EF:
				return new global::SSLMangrComp.Packets.KeepAlive
				{
					MessageID = data[(int)lengthbytes],
					DialogID = global::System.BitConverter.ToUInt16(data, (int)(lengthbytes + 1))
				};
				IL_58:
				result = null;
				b = data[(int)lengthbytes];
				num = (short)939327488;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}
	}
}
