using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000016 RID: 22
	public class DataArea : global::System.IDisposable
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x000109A8 File Offset: 0x0000EBA8
		internal DataArea() : this(new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream())
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000109C0 File Offset: 0x0000EBC0
		internal DataArea(global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_0)
		{
			int a_ = 13;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풣장쮧솩즫쪭펱삳ힵ", a_));
			}
			this.a = A_0;
			this.b = new global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00010A08 File Offset: 0x0000EC08
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)2073556418;
				short num2 = num;
				num = (short)444724674;
				switch (num2 == num)
				{
				}
				num = (short)36962304;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)375914497;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1295646720;
			short num3 = num;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		internal global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream PackedData
		{
			get
			{
				short num = (short)375168067;
				short num2 = num;
				num = (short)593468483;
				switch (num2 == num)
				{
				}
				num = (short)1945042945;
				if (num != 0)
				{
				}
				num = (short)2084503552;
				short num3 = num;
				num = (short)1280180224;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00010B80 File Offset: 0x0000ED80
		protected void Dispose(bool disposing)
		{
			short num = (short)675020801;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!disposing)
					{
						return;
					}
					num = (short)425167500;
					short num3 = num;
					num = (short)1152223884;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1602551808;
						if (num != 0)
						{
						}
						num = (short)1221328898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)253362177;
					if (num != 0)
					{
					}
					num = (short)265355264;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				}
				case 2:
					this.a.Dispose();
					this.a = null;
					num = (short)198246404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					return;
				}
				IL_88:
				if (this.c)
				{
					num = (short)1236926467;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)50200576;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00010CE4 File Offset: 0x0000EEE4
		internal global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection UnpackedData
		{
			get
			{
				short num = (short)1644185830;
				short num2 = num;
				num = (short)389236966;
				switch (num2 == num)
				{
				}
				num = (short)142606336;
				if (num != 0)
				{
				}
				num = (short)1709441024;
				short num3 = num;
				num = (short)1769734145;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00010D90 File Offset: 0x0000EF90
		public void Dispose()
		{
			short num = (short)2128595754;
			short num2 = num;
			num = (short)1655163690;
			switch (num2 == num)
			{
			}
			num = (short)1388904449;
			if (num != 0)
			{
			}
			num = (short)102694912;
			short num3 = num;
			num = (short)944046080;
			if (num != 0)
			{
			}
			this.Dispose(true);
			this.c = true;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400003A RID: 58
		private global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream a;

		// Token: 0x0400003B RID: 59
		private global::Motorola.Acp.PackUnpack.Ish.Collections.FieldCollection b;

		// Token: 0x0400003C RID: 60
		private bool c;
	}
}
