using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class RecordPTR : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00005798 File Offset: 0x00003998
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00005848 File Offset: 0x00003A48
		public string DomainName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1335552264;
				short num2 = num;
				num = (short)780921096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141913088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)857931777;
				if (num != 0)
				{
				}
				num = (short)1639448576;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2094737910;
				short num2 = num;
				num = (short)1451895286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)702545920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)304218113;
				if (num != 0)
				{
				}
				num = (short)697696256;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000058FC File Offset: 0x00003AFC
		public override void Serialize(global::System.IO.Stream stream)
		{
			short num = (short)595318350;
			short num2 = num;
			num = (short)1871959630;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1231552512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2112880641;
			if (num != 0)
			{
			}
			num = (short)1875247104;
			if (num != 0)
			{
			}
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(base.NAME);
			stream.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
