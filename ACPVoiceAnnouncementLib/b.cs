using System;
using System.IO;
using System.Text;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000022 RID: 34
	internal class b : global::System.IDisposable
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000C81C File Offset: 0x0000AA1C
		internal b(string A_0)
		{
			this.a = new global::System.IO.BinaryWriter(new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, global::System.IO.FileShare.None), global::System.Text.Encoding.ASCII);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000C848 File Offset: 0x0000AA48
		internal long a()
		{
			short num = (short)253865369;
			short num2 = num;
			num = (short)1488825753;
			switch (num2 == num)
			{
			}
			num = (short)267583489;
			if (num != 0)
			{
			}
			num = (short)106168320;
			if (num != 0)
			{
			}
			num = (short)668401664;
			short num3 = num;
			return this.a.BaseStream.Position;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000C900 File Offset: 0x0000AB00
		internal void a(long A_0)
		{
			short num = (short)517421953;
			short num2 = num;
			num = (short)1324563329;
			switch (num2 == num)
			{
			}
			num = (short)1926758401;
			if (num != 0)
			{
			}
			num = (short)1991049216;
			if (num != 0)
			{
			}
			num = (short)495124480;
			short num3 = num;
			this.a.BaseStream.Seek(A_0, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		internal void a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)1333181805;
			short num2 = num;
			num = (short)316587373;
			switch (num2 == num)
			{
			}
			num = (short)348454913;
			if (num != 0)
			{
			}
			num = (short)1470234624;
			if (num != 0)
			{
			}
			num = (short)917766144;
			short num3 = num;
			this.a.Write(A_0, 0, A_2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000CA74 File Offset: 0x0000AC74
		internal void a(uint A_0)
		{
			short num = (short)2087005715;
			short num2 = num;
			num = (short)1047997971;
			switch (num2 == num)
			{
			}
			num = (short)1798242305;
			if (num != 0)
			{
			}
			num = (short)896991232;
			if (num != 0)
			{
			}
			num = (short)39190528;
			short num3 = num;
			this.a.Write(A_0);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000CB28 File Offset: 0x0000AD28
		internal void a(ushort A_0)
		{
			short num = (short)1257024675;
			short num2 = num;
			num = (short)1180544163;
			switch (num2 == num)
			{
			}
			num = (short)1414266880;
			if (num != 0)
			{
			}
			num = (short)493158401;
			if (num != 0)
			{
			}
			num = (short)1477378048;
			short num3 = num;
			this.a.Write(A_0);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000CBDC File Offset: 0x0000ADDC
		internal void a(char[] A_0)
		{
			short num = (short)560590111;
			short num2 = num;
			num = (short)2065100063;
			switch (num2 == num)
			{
			}
			num = (short)261881856;
			if (num != 0)
			{
			}
			num = (short)45875201;
			if (num != 0)
			{
			}
			num = (short)765198336;
			short num3 = num;
			this.a.Write(A_0);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000CC90 File Offset: 0x0000AE90
		internal void a(string A_0)
		{
			short num = (short)502619494;
			short num2 = num;
			num = (short)1041194342;
			switch (num2 == num)
			{
			}
			num = (short)549847041;
			if (num != 0)
			{
			}
			num = (short)1642201088;
			if (num != 0)
			{
			}
			num = (short)2035941376;
			short num3 = num;
			this.a.Write(A_0.ToCharArray());
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000CD48 File Offset: 0x0000AF48
		internal void b()
		{
			short num = (short)952682407;
			short num2 = num;
			num = (short)2111686567;
			switch (num2 == num)
			{
			}
			num = (short)221773824;
			if (num != 0)
			{
			}
			num = (short)448397313;
			if (num != 0)
			{
			}
			num = (short)1335754752;
			short num3 = num;
			this.a.Flush();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		private void a(bool A_0)
		{
			short num = (short)216662017;
			if (num != 0)
			{
			}
			num = (short)1104084996;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)1356595206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A1;
				case 1:
					if (A_0)
					{
						num = (short)71434245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A1;
				case 2:
					num = (short)372244481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 5:
					num = (short)672530432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)989472851;
					short num3 = num;
					num = (short)783034451;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)38731776;
						if (num != 0)
						{
						}
						this.a.Close();
						num = (short)14417927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_1A1;
				}
				IL_6C:
				num = (short)1795096576;
				short num4 = num;
				if (!this.b)
				{
					num = (short)102563842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A1:
				this.b = true;
				num = (short)539492355;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		public void Dispose()
		{
			short num = (short)794258295;
			short num2 = num;
			num = (short)1155951479;
			switch (num2 == num)
			{
			}
			num = (short)2015035393;
			if (num != 0)
			{
			}
			num = (short)351010816;
			if (num != 0)
			{
			}
			num = (short)1301610496;
			short num3 = num;
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000D084 File Offset: 0x0000B284
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1682218462;
				short num2 = num;
				num = (short)1944296926;
				switch (num2 == num)
				{
				}
				num = (short)849084416;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)567672833;
			if (num != 0)
			{
			}
			num = (short)2095448064;
			short num3 = num;
		}

		// Token: 0x0400008F RID: 143
		private global::System.IO.BinaryWriter a;

		// Token: 0x04000090 RID: 144
		private bool b;
	}
}
