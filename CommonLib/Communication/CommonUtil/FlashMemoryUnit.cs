using System;
using System.Globalization;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000035 RID: 53
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class FlashMemoryUnit : global::Motorola.Common.Communication.CommonUtil.IMemoryUnit
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0001A728 File Offset: 0x00018928
		public string Address
		{
			get
			{
				int a_ = 6;
				short num = (short)1430621666;
				short num2 = num;
				num = (short)1787596258;
				switch (num2 == num)
				{
				}
				num = (short)1999831040;
				short num3 = num;
				num = (short)799735809;
				if (num != 0)
				{
				}
				num = (short)528744448;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("焉㰋㐍吏⌑✓欕", a_), this._address);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0001A7F8 File Offset: 0x000189F8
		public uint Size
		{
			get
			{
				short num = (short)1898339723;
				short num2 = num;
				num = (short)1822317963;
				switch (num2 == num)
				{
				}
				num = (short)1894776832;
				short num3 = num;
				num = (short)367263744;
				if (num != 0)
				{
				}
				num = (short)1700724737;
				if (num != 0)
				{
				}
				return this._size;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0001A8A4 File Offset: 0x00018AA4
		public byte[] Data
		{
			get
			{
				short num = (short)418066296;
				short num2 = num;
				num = (short)559427448;
				switch (num2 == num)
				{
				}
				num = (short)2041315328;
				short num3 = num;
				num = (short)1821048832;
				if (num != 0)
				{
				}
				num = (short)1419378689;
				if (num != 0)
				{
				}
				return this._data;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001A950 File Offset: 0x00018B50
		public void ChargeUnit(string address, byte[] data, byte stuff, uint alignment)
		{
			short num = (short)1350303744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				for (;;)
				{
					IL_28:
					uint num3;
					int num4;
					uint num5;
					uint num7;
					switch (num2)
					{
					case 0:
						goto IL_329;
					case 1:
						try
						{
							this._address = (uint)global::System.Convert.ToInt32(address, global::System.Globalization.CultureInfo.InvariantCulture);
							goto IL_367;
						}
						catch
						{
							this.a();
							return;
						}
						goto IL_14E;
						IL_367:
						this._size = (uint)data.Length;
						num3 = 0U;
						num = (short)436338695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						if (data == null)
						{
							num = (short)1554120706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)986513409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						if ((long)num4 >= (long)((ulong)num3))
						{
							num = (short)1509097486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this._data[num4] = this._stuff;
						num4++;
						num = (short)1401552911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num5 >= this._size)
						{
							num = (short)1267466244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this._data[(int)num5] = this._stuff;
						num5 += 1U;
						num = (short)1790902280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this._alignment != 0U)
						{
							num = (short)1609760781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24F;
					case 8:
					{
						num = (short)219163157;
						short num6 = num;
						num = (short)365570581;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24F;
						default:
							num = (short)692912128;
							if (num != 0)
							{
							}
							goto IL_20D;
						}
						break;
					}
					case 9:
						if (this._alignment != 0U)
						{
							num = (short)765919243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_329;
					case 10:
						goto IL_20D;
					case 11:
						num7 = (this._alignment - this._size % this._alignment) % this._alignment;
						num = (short)1916731392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						num = (short)1445265408;
						short num8 = num;
						goto IL_24F;
					}
					case 13:
						num3 = (this._alignment - this._address % this._alignment) % this._alignment;
						num = (short)1680474124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_14E;
					case 15:
						goto IL_1CC;
					case 16:
						goto IL_1CC;
					}
					goto IL_73;
					IL_14E:
					num = (short)2076704769;
					if (num != 0)
					{
					}
					global::System.Array.Copy(data, 0L, this._data, (long)((ulong)num3), (long)data.Length);
					num5 = this._size - num7;
					num = (short)54394890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					num = (short)1610809349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D:
					num = (short)704905222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24F:
					this._size += num3;
					this._address -= num3;
					num7 = 0U;
					num = (short)1105526793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_329:
					this._size += num7;
					this._data = new byte[this._size];
					num4 = 0;
					num = (short)2062090256;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_73:
				this.a();
				this._stuff = stuff;
				this._alignment = alignment;
				num = (short)1023803395;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001AD84 File Offset: 0x00018F84
		public void ChargeUnit(string address, byte[] data)
		{
			short num = (short)875036673;
			if (num != 0)
			{
			}
			num = (short)1665648030;
			short num2 = num;
			num = (short)1348978078;
			switch (num2 == num)
			{
			}
			num = (short)1300824064;
			if (num != 0)
			{
			}
			num = (short)323551232;
			short num3 = num;
			this.ChargeUnit(address, data, byte.MaxValue, 2U);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001AE3C File Offset: 0x0001903C
		public bool IsOverlaped(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit otherUnit)
		{
			short num = (short)1106697124;
			short num2 = num;
			num = (short)1120132004;
			bool flag;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)56623104;
				if (num != 0)
				{
				}
				num = (short)1177550848;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)542965761;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					int num5;
					int num6;
					int num7;
					for (;;)
					{
						IL_9A:
						switch (num3)
						{
						case 0:
							return false;
						case 1:
							if (otherUnit == null)
							{
								num = (short)1510408197;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)628359172;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1E0;
						case 3:
						{
							num = (short)1844707328;
							short num4 = num;
							if (!flag)
							{
								num = (short)1437401088;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E2;
						}
						case 4:
							if (otherUnit.GetType() != base.GetType())
							{
								num = (short)1055784962;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 0;
							num6 = 0;
							num7 = 0;
							flag = this.a(global::System.Convert.ToInt32(this.Address, global::System.Globalization.CultureInfo.InvariantCulture), (int)this.Size, global::System.Convert.ToInt32(otherUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture), (int)otherUnit.Size, out num5, out num6, out num7);
							num = (short)1663696899;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							return flag;
						}
						goto IL_B9;
					}
					return false;
					IL_1E0:
					flag = true;
					return flag;
					IL_1E2:
					return !this.a(this.Data, (long)num5, otherUnit.Data, (long)num6, (long)num7);
					IL_B9:
					flag = false;
					num = (short)1640824833;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_9A;
				}
				}
				break;
			}
			}
			return flag;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001B048 File Offset: 0x00019248
		public global::Motorola.Common.Communication.CommonUtil.IMemoryUnit Clone()
		{
			short num = (short)2035875841;
			if (num != 0)
			{
			}
			num = (short)1326525582;
			short num2 = num;
			num = (short)231025806;
			switch (num2 == num)
			{
			}
			num = (short)1423769600;
			if (num != 0)
			{
			}
			num = (short)1418526720;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
			flashMemoryUnit._address = this._address;
			flashMemoryUnit._size = this._size;
			flashMemoryUnit._stuff = this._stuff;
			flashMemoryUnit._alignment = this._alignment;
			flashMemoryUnit._data = new byte[this._data.Length];
			global::System.Array.Copy(this._data, flashMemoryUnit._data, (long)((ulong)flashMemoryUnit._size));
			return flashMemoryUnit;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001B150 File Offset: 0x00019350
		public bool GetData(uint addr, uint size, out byte[] buffer)
		{
			short num = (short)543162371;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1351548929;
				if (num != 0)
				{
				}
				num = (short)245170176;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_13D;
				case 1:
					num = (short)732692482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_112;
				case 3:
				{
					num = (short)1629626568;
					short num4 = num;
					num = (short)151855304;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
						num = (short)1634598912;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D2;
						}
						continue;
					}
					break;
				}
				}
				IL_D2:
				if (addr >= this._address)
				{
					num = (short)1345060865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_112:
				if (addr + size <= this._address + this._size)
				{
					goto IL_13F;
				}
				num = (short)1684733952;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			buffer = null;
			return false;
			IL_13D:
			goto IL_F6;
			IL_13F:
			buffer = new byte[size];
			global::System.Array.Copy(this._data, (long)((ulong)(addr - this._address)), buffer, 0L, (long)((ulong)size));
			return true;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001B2C0 File Offset: 0x000194C0
		private bool a(byte[] A_0, long A_1, byte[] A_2, long A_3, long A_4)
		{
			for (;;)
			{
				IL_00:
				short num = (short)322174976;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_51;
				}
				int num3;
				int num5;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						return false;
					case 1:
					{
						num = (short)2066808104;
						short num4 = num;
						num = (short)881917224;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1272119296;
							if (num != 0)
							{
							}
							goto IL_145;
						}
						break;
					}
					case 2:
						return true;
					case 3:
						if (!checked(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit.a(A_0[(int)((global::System.IntPtr)(unchecked(A_1 + (long)num5)))], A_2[(int)((global::System.IntPtr)(unchecked(A_3 + (long)num5)))])))
						{
							num = (short)1930952704;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)414056453;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if ((long)num5 >= A_4)
						{
							num = (short)1675493378;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1343094787;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_145;
					}
					break;
					IL_145:
					num = (short)837615620;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_51:
				num5 = 0;
				num = (short)599392257;
				if (num != 0)
				{
				}
				num = (short)154730497;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			return false;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001B44C File Offset: 0x0001964C
		private static bool a(byte A_0, byte A_1)
		{
			short num = (short)1129685380;
			short num2 = num;
			num = (short)1683267972;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E1:
				goto IL_11B;
			default:
				num = (short)979828736;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9F;
				}
				break;
			}
			int num4;
			byte b;
			for (;;)
			{
				IL_55:
				num = (short)1233649664;
				short num3 = num;
				switch (num4)
				{
				case 0:
					goto IL_E1;
				case 1:
					num = (short)1265958918;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					if ((A_0 & b) == 0)
					{
						num = (short)632619009;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				case 5:
					if ((b = (byte)(b << 1)) <= 0)
					{
						num = (short)894500866;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B;
				case 6:
					if ((A_1 & b) != 0)
					{
						num = (short)1755316227;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				}
				goto IL_9F;
				IL_153:
				num = (short)1322713093;
				num4 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_9F:
			b = 1;
			num = (short)409206785;
			if (num != 0)
			{
			}
			num = (short)2147024896;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_55;
			IL_11B:
			num = (short)1895825412;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001B5E8 File Offset: 0x000197E8
		private void a()
		{
			short num = (short)246569134;
			short num2 = num;
			num = (short)801724590;
			switch (num2 == num)
			{
			}
			num = (short)110886912;
			if (num != 0)
			{
			}
			num = (short)1294204929;
			if (num != 0)
			{
			}
			num = (short)335806464;
			short num3 = num;
			this._address = 0U;
			this._size = 0U;
			this._data = null;
			this._stuff = byte.MaxValue;
			this._alignment = 2U;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001B6B8 File Offset: 0x000198B8
		private bool a(int A_0, int A_1, int A_2, int A_3, out int A_4, out int A_5, out int A_6)
		{
			short num = (short)1623851009;
			if (num != 0)
			{
			}
			num = (short)2066748366;
			short num2 = num;
			num = (short)741479374;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1731657728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1419444224;
			if (num != 0)
			{
			}
			A_4 = 0;
			A_5 = 0;
			A_6 = 0;
			int val = A_0 + A_1;
			int val2 = A_2 + A_3;
			int num4 = global::System.Math.Max(A_0, A_2);
			int num5 = global::System.Math.Min(val, val2);
			A_4 = global::System.Math.Abs(A_0 - num4);
			A_5 = global::System.Math.Abs(A_2 - num4);
			A_6 = num5 - num4;
			return num4 <= num5;
		}

		// Token: 0x04000146 RID: 326
		[global::System.Runtime.Serialization.DataMember]
		private uint _address;

		// Token: 0x04000147 RID: 327
		[global::System.Runtime.Serialization.DataMember]
		private uint _size;

		// Token: 0x04000148 RID: 328
		[global::System.Runtime.Serialization.DataMember]
		private byte[] _data;

		// Token: 0x04000149 RID: 329
		[global::System.Runtime.Serialization.DataMember]
		private byte _stuff = byte.MaxValue;

		// Token: 0x0400014A RID: 330
		[global::System.Runtime.Serialization.DataMember]
		private uint _alignment = 2U;
	}
}
