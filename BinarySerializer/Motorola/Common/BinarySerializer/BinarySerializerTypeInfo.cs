using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.CompilerServices.a(0)]
	[global::System.Runtime.CompilerServices.b(2)]
	public class BinarySerializerTypeInfo : global::System.IEquatable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		public string Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1164939692;
				short num2 = num;
				num = (short)2084082092;
				switch (num2 == num)
				{
				}
				num = (short)1127546881;
				if (num != 0)
				{
				}
				num = (short)354222080;
				if (num != 0)
				{
				}
				num = (short)1291059200;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000CE70 File Offset: 0x0000B070
		public string Assembly
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)416134335;
				short num2 = num;
				num = (short)1596503231;
				switch (num2 == num)
				{
				}
				num = (short)2002190337;
				if (num != 0)
				{
				}
				num = (short)708509696;
				if (num != 0)
				{
				}
				num = (short)1151139840;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000CF24 File Offset: 0x0000B124
		public string AssemblyName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1052290717;
				short num2 = num;
				num = (short)693743261;
				switch (num2 == num)
				{
				}
				num = (short)545521664;
				if (num != 0)
				{
				}
				num = (short)77987841;
				if (num != 0)
				{
				}
				num = (short)1352663040;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		public BinarySerializerTypeInfo(string type, string assembly)
		{
			this.a = type;
			this.b = assembly;
			this.c = (this.a(assembly) ?? string.Empty);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000D010 File Offset: 0x0000B210
		public bool Equals(global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo other)
		{
			short num = (short)778371077;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					goto IL_C1;
				case 3:
					if (this.Type == other.Type)
					{
						num = (short)467468290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
				{
					num = (short)758632304;
					short num3 = num;
					num = (short)1727844208;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					case 1:
						break;
					default:
					{
						num = (short)688586752;
						short num4 = num;
						break;
					}
					}
					num = (short)2125660160;
					if (num != 0)
					{
					}
					if (this == other)
					{
						num = (short)960561153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1464139779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				goto IL_3D;
				IL_68:
				num = (short)1286144000;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				num = (short)1011613697;
				if (num != 0)
				{
				}
				if (other == null)
				{
					goto IL_68;
				}
				num = (short)812122116;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_C1:
			return this.AssemblyName == other.AssemblyName;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		public override bool Equals(object obj)
		{
			short num = (short)351076357;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					if (obj.GetType() != base.GetType())
					{
						num = (short)646381570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_174;
				case 4:
				{
					num = (short)1010878506;
					short num3 = num;
					num = (short)1073596458;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
					{
						num = (short)1538654208;
						short num4 = num;
						num = (short)194510849;
						if (num != 0)
						{
						}
						num = (short)64356352;
						if (num != 0)
						{
						}
						if (this == obj)
						{
							num = (short)569049089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1996029955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				goto IL_3D;
				IL_40:
				num = (short)40566784;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				if (obj == null)
				{
					goto IL_40;
				}
				num = (short)403177476;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_174:
			return this.Equals((global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo)obj);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000D338 File Offset: 0x0000B538
		public override int GetHashCode()
		{
			short num = (short)1285357569;
			if (num != 0)
			{
			}
			num = (short)170983425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 2:
					goto IL_7B;
				case 3:
					goto IL_120;
				}
				IL_5B:
				if (this.Type == null)
				{
					num = (short)1789591554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1905724784;
				short num3 = num;
				num = (short)374541680;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7B;
				case 1:
					break;
				default:
				{
					num = (short)1058734080;
					short num4 = num;
					break;
				}
				}
				num = (short)156368896;
				if (num != 0)
				{
				}
				num = (short)1593114627;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7B:
				num = (short)1599602688;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8F:
			int num5 = 0;
			goto IL_12D;
			IL_120:
			num5 = this.Type.GetHashCode();
			IL_12D:
			return num5 * 397 ^ ((this.AssemblyName != null) ? this.AssemblyName.GetHashCode() : 0);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000D494 File Offset: 0x0000B694
		[global::System.Runtime.CompilerServices.b(1)]
		public override string ToString()
		{
			int a_ = 17;
			short num = (short)115658596;
			short num2 = num;
			num = (short)2080690020;
			switch (num2 == num)
			{
			}
			num = (short)460259329;
			if (num != 0)
			{
			}
			num = (short)279445504;
			short num3 = num;
			num = (short)464650240;
			if (num != 0)
			{
			}
			return this.Type + global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("", a_) + (this.Assembly ?? global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("ﺯ蝹", a_)) + global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("", a_);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000D58C File Offset: 0x0000B78C
		private string a(string A_0)
		{
			short num = (short)197787653;
			int num2 = (int)((global::System.IntPtr)num);
			string[] array2;
			for (;;)
			{
				string[] array;
				switch (num2)
				{
				case 0:
					array = A_0.Split(new char[]
					{
						','
					});
					goto IL_157;
				case 1:
					if (array2 != null)
					{
						num = (short)1339490305;
						if (num != 0)
						{
						}
						num = (short)87490567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return A_0;
				case 2:
					goto IL_D5;
				case 3:
					return A_0;
				case 4:
					array = null;
					goto IL_157;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 6:
					if (array2.Length == 0)
					{
						num = (short)340000771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B6;
				case 7:
					num = (short)991232006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_46:
				num = (short)131750369;
				short num3 = num;
				num = (short)364075489;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D5:
					num = (short)625344516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1253376000;
					if (num != 0)
					{
					}
					if (A_0 == null)
					{
						num = (short)811991040;
						short num4 = num;
						num = (short)1271922690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)296288256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_157:
				array2 = array;
				num = (short)1374093313;
				num2 = (int)((global::System.IntPtr)num);
			}
			return A_0;
			IL_1B6:
			return array2[0];
		}

		// Token: 0x04000077 RID: 119
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x04000078 RID: 120
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;

		// Token: 0x04000079 RID: 121
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string c;
	}
}
