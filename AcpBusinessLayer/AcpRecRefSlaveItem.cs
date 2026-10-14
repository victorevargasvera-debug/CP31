using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AcpBusinessLayer
{
	// Token: 0x0200001E RID: 30
	[global::System.Diagnostics.DebuggerDisplay("Name={SlaveField.UIName}, ChildSection={ChildSectionId}")]
	public class AcpRecRefSlaveItem : global::System.IDisposable
	{
		// Token: 0x060002BB RID: 699 RVA: 0x00036DC0 File Offset: 0x00034FC0
		private AcpRecRefSlaveItem()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00036DD4 File Offset: 0x00034FD4
		public AcpRecRefSlaveItem(global::AcpBusinessLayer.AcpRecRefField slave, int childSectionId)
		{
			this.SlaveField = slave;
			this.ChildSectionId = childSectionId;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00036DF8 File Offset: 0x00034FF8
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00036EA8 File Offset: 0x000350A8
		internal global::AcpBusinessLayer.AcpRecRefField SlaveField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1702494208;
				short num2 = num;
				num = (short)1833973285;
				short num3 = num;
				num = (short)1101608485;
				switch (num3 == num)
				{
				}
				num = (short)1902968833;
				if (num != 0)
				{
				}
				num = (short)757465088;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2138832896;
				short num2 = num;
				num = (short)1930952705;
				if (num != 0)
				{
				}
				num = (short)664605660;
				short num3 = num;
				num = (short)1039406044;
				switch (num3 == num)
				{
				}
				num = (short)1530527744;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00036F5C File Offset: 0x0003515C
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0003700C File Offset: 0x0003520C
		internal int ChildSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)899481600;
				short num2 = num;
				num = (short)821150470;
				short num3 = num;
				num = (short)733987590;
				switch (num3 == num)
				{
				}
				num = (short)1974206465;
				if (num != 0)
				{
				}
				num = (short)1397817344;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1666842624;
				short num2 = num;
				num = (short)792259220;
				short num3 = num;
				num = (short)559999636;
				switch (num3 == num)
				{
				}
				num = (short)1645805568;
				if (num != 0)
				{
				}
				num = (short)607387649;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000370BC File Offset: 0x000352BC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)2042494977;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.a)
					{
						num = (short)1238958089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20E;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 2:
					this.b = true;
					num = (short)294715398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)2079916032;
					short num3 = num;
					goto IL_131;
				}
				case 4:
					if (disposing)
					{
						num = (short)1071382530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_131;
				case 5:
					goto IL_6D;
				case 6:
				{
					global::AcpBusinessLayer.AcpRecRefField slaveField = this.SlaveField;
					if (slaveField == null)
					{
						num = (short)415694851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					slaveField.Dispose();
					num = (short)1240072199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_131;
				case 8:
					goto IL_177;
				case 9:
				{
					num = (short)1957537517;
					short num4 = num;
					num = (short)1931192045;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)395247616;
						if (num != 0)
						{
						}
						num = (short)80412676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_4D:
				if (this.b)
				{
					num = (short)677314565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)498925568;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_131:
				this.a = true;
				num = (short)574160897;
				if (num != 0)
				{
				}
				num = (short)516030472;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6D:
			return;
			IL_177:
			IL_20E:
			this.b = false;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000372E0 File Offset: 0x000354E0
		public void Dispose()
		{
			short num = (short)1818492928;
			short num2 = num;
			num = (short)1910150182;
			short num3 = num;
			num = (short)401970214;
			switch (num3 == num)
			{
			}
			num = (short)48431104;
			if (num != 0)
			{
			}
			num = (short)16056321;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400008D RID: 141
		private bool a;

		// Token: 0x0400008E RID: 142
		private bool b;

		// Token: 0x0400008F RID: 143
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.AcpRecRefField c;

		// Token: 0x04000090 RID: 144
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int d;
	}
}
