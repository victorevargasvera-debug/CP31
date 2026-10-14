using System;
using System.IO;
using System.Text;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000021 RID: 33
	public class WaveFileReader : global::System.IDisposable
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000BE58 File Offset: 0x0000A058
		internal WaveFileReader(string A_0)
		{
			this.a = new global::System.IO.BinaryReader(new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read), global::System.Text.Encoding.ASCII);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000BE84 File Offset: 0x0000A084
		internal long a()
		{
			short num = (short)176291841;
			if (num != 0)
			{
			}
			num = (short)258877890;
			short num2 = num;
			num = (short)1630546370;
			switch (num2 == num)
			{
			}
			num = (short)339607552;
			if (num != 0)
			{
			}
			num = (short)504037376;
			short num3 = num;
			return this.a.BaseStream.Position;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000BF40 File Offset: 0x0000A140
		internal void a(long A_0)
		{
			short num = (short)1935634241;
			short num2 = num;
			num = (short)464809793;
			switch (num2 == num)
			{
			}
			num = (short)1526923265;
			if (num != 0)
			{
			}
			num = (short)1670709248;
			if (num != 0)
			{
			}
			num = (short)924188672;
			short num3 = num;
			this.a.BaseStream.Seek(A_0, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		internal string b()
		{
			short num = (short)2115026323;
			short num2 = num;
			num = (short)1600241043;
			switch (num2 == num)
			{
			}
			num = (short)1854996481;
			if (num != 0)
			{
			}
			num = (short)1831665664;
			if (num != 0)
			{
			}
			num = (short)1613627392;
			short num3 = num;
			return new string(this.a.ReadChars(4));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		internal void c()
		{
			short num = (short)1596352315;
			short num2 = num;
			num = (short)429483835;
			switch (num2 == num)
			{
			}
			num = (short)279183361;
			if (num != 0)
			{
			}
			num = (short)523501568;
			if (num != 0)
			{
			}
			num = (short)1402011648;
			short num3 = num;
			long offset = (long)((ulong)this.a.ReadUInt32());
			this.a.BaseStream.Seek(offset, global::System.IO.SeekOrigin.Current);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000C180 File Offset: 0x0000A380
		internal int a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)713878557;
			short num2 = num;
			num = (short)497609757;
			switch (num2 == num)
			{
			}
			num = (short)1406992385;
			if (num != 0)
			{
			}
			num = (short)1077084160;
			if (num != 0)
			{
			}
			num = (short)1919877120;
			short num3 = num;
			return this.a.Read(A_0, 0, A_2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000C238 File Offset: 0x0000A438
		internal uint d()
		{
			short num = (short)1174388365;
			short num2 = num;
			num = (short)557825677;
			switch (num2 == num)
			{
			}
			num = (short)1862533121;
			if (num != 0)
			{
			}
			num = (short)11075584;
			if (num != 0)
			{
			}
			num = (short)1580269568;
			short num3 = num;
			return this.a.ReadUInt32();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		internal ushort e()
		{
			short num = (short)1663334835;
			short num2 = num;
			num = (short)336689587;
			switch (num2 == num)
			{
			}
			num = (short)506200065;
			if (num != 0)
			{
			}
			num = (short)2067529728;
			if (num != 0)
			{
			}
			num = (short)1432158208;
			short num3 = num;
			return this.a.ReadUInt16();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		internal char[] a(int A_0)
		{
			short num = (short)1708740713;
			short num2 = num;
			num = (short)108023913;
			switch (num2 == num)
			{
			}
			num = (short)1458634753;
			if (num != 0)
			{
			}
			num = (short)1189543936;
			if (num != 0)
			{
			}
			num = (short)1335623680;
			short num3 = num;
			return this.a.ReadChars(A_0);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000C454 File Offset: 0x0000A654
		private void a(bool A_0)
		{
			short num = (short)5636100;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)1679622150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				case 1:
					if (A_0)
					{
						num = (short)1172176901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				case 2:
					num = (short)1387724801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					num = (short)2115567616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)354615297;
					if (num != 0)
					{
					}
					num = (short)1623976884;
					short num3 = num;
					num = (short)993782708;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1504378880;
						if (num != 0)
						{
						}
						this.a.Close();
						num = (short)857538567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_1A2;
				}
				IL_44:
				if (!this.b)
				{
					num = (short)635305984;
					short num4 = num;
					num = (short)1339752450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A2:
				this.b = true;
				num = (short)1588199427;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C624 File Offset: 0x0000A824
		public void Dispose()
		{
			short num = (short)74855144;
			short num2 = num;
			num = (short)432288488;
			switch (num2 == num)
			{
			}
			num = (short)199294977;
			if (num != 0)
			{
			}
			num = (short)231735296;
			if (num != 0)
			{
			}
			num = (short)225050624;
			short num3 = num;
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1029308417;
				if (num != 0)
				{
				}
				num = (short)589149178;
				short num2 = num;
				num = (short)1785443322;
				switch (num2 == num)
				{
				}
				num = (short)375128064;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1812267008;
			short num3 = num;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		internal static string f(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(430021806 + A_1) + (global::System.IntPtr)31 + (global::System.IntPtr)99);
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

		// Token: 0x0400008D RID: 141
		private global::System.IO.BinaryReader a;

		// Token: 0x0400008E RID: 142
		private bool b;
	}
}
