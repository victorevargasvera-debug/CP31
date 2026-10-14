using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200000E RID: 14
	public class Codeplug : global::System.IDisposable
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000DF40 File Offset: 0x0000C140
		internal Codeplug(params global::Motorola.Acp.PackUnpack.Ish.Partition[] A_0)
		{
			int a_ = 2;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("漢좠힢첤좦잨\ud8aa", a_));
			}
			this.a = new global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection(this);
			foreach (global::Motorola.Acp.PackUnpack.Ish.Partition item in A_0)
			{
				this.a.Add(item);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		public Codeplug()
		{
			this.a = new global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection(this);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1131352865;
				short num2 = num;
				num = (short)222040865;
				switch (num2 == num)
				{
				}
				num = (short)486473728;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1711996929;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)763559936;
			short num3 = num;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000E090 File Offset: 0x0000C290
		public global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection Partitions
		{
			get
			{
				short num = (short)2021419227;
				short num2 = num;
				num = (short)277440731;
				switch (num2 == num)
				{
				}
				num = (short)1748762624;
				if (num != 0)
				{
				}
				num = (short)1887567873;
				if (num != 0)
				{
				}
				num = (short)59506688;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000E13C File Offset: 0x0000C33C
		void global::System.IDisposable.Dispose()
		{
			short num = (short)240451585;
			if (num != 0)
			{
			}
			num = (short)726152291;
			short num2 = num;
			num = (short)1630090339;
			switch (num2 == num)
			{
			}
			num = (short)704184320;
			if (num != 0)
			{
			}
			num = (short)923926528;
			short num3 = num;
			this.Dispose(true);
			this.a = null;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)282809523;
			short num2 = num;
			num = (short)1434080435;
			switch (num2 == num)
			{
			}
			num = (short)857604097;
			if (num != 0)
			{
			}
			num = (short)1133445120;
			if (num != 0)
			{
			}
			num = (short)1085210624;
			short num3 = num;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		internal global::Motorola.Acp.PackUnpack.Ish.Partition a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 8;
			short num = (short)358088706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_28C;
				case 1:
					goto IL_55;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (A_0 == null)
				{
					num = (short)1747582977;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)921305089;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = this.a.GetEnumerator();
					num = (short)1523056640;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_55:
			num = (short)966000640;
			short num3 = num;
			IL_22B:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튠쮢\udea6\ud9a8캪", a_));
			IL_28C:
			try
			{
				num = (short)356712448;
				num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Acp.PackUnpack.Ish.Partition result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C5;
						}
						continue;
					case 1:
					{
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						result = partition;
						num = (short)1462370308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_173;
					case 3:
						num = (short)116457474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_112;
					case 5:
					{
						global::Motorola.Acp.PackUnpack.Ish.Partition partition;
						if (partition.Layouts.a(A_0))
						{
							num = (short)1190199297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1721761795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Acp.PackUnpack.Ish.Partition partition = enumerator.Current;
						num = (short)1885339653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_C7:
					num = (short)1900609542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C5:
					goto IL_C7;
				}
				IL_112:
				return result;
				IL_173:
				goto IL_23F;
			}
			finally
			{
				for (;;)
				{
					num = (short)741670914;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_1DD;
						case 1:
							enumerator.Dispose();
							num = (short)57475072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1A9;
							}
							continue;
						}
						IL_1A9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)736690177;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1DF:
					num = (short)269728933;
					short num4 = num;
					num = (short)1764670629;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_214;
					}
					IL_1DD:
					goto IL_1DF;
				}
				IL_214:
				num = (short)2001666048;
				if (num != 0)
				{
				}
			}
			goto IL_22B;
			IL_23F:
			return null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000E554 File Offset: 0x0000C754
		internal global::Motorola.Acp.PackUnpack.Ish.IshType a(int A_0)
		{
			global::Motorola.Acp.PackUnpack.Ish.IshType ishType = null;
			global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.Partition> enumerator = this.a.GetEnumerator();
			short num;
			try
			{
				num = (short)1937506304;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 1:
						goto IL_109;
					case 2:
						goto IL_126;
					case 3:
						num = (short)31260673;
						if (num != 0)
						{
						}
						num = (short)2036727809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)1122369541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ishType = enumerator.Current.a(A_0);
						num = (short)896991238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1576861698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (ishType != null)
						{
							num = (short)415432707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_B6:
					num = (short)127205380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51:
					goto IL_B6;
				}
				IL_109:
				IL_126:;
			}
			finally
			{
				for (;;)
				{
					num = (short)1852440578;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_18F;
						case 1:
							enumerator.Dispose();
							num = (short)2113011712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_15B;
							}
							continue;
						}
						IL_15B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)860487681;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_191:
					num = (short)2099747055;
					short num3 = num;
					num = (short)1713936623;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1C6;
					}
					IL_18F:
					goto IL_191;
				}
				IL_1C6:
				num = (short)3932160;
				if (num != 0)
				{
				}
			}
			num = (short)1525153792;
			short num4 = num;
			return ishType;
		}

		// Token: 0x0400002E RID: 46
		private global::Motorola.Acp.PackUnpack.Ish.Collections.PartitionCollection a;
	}
}
