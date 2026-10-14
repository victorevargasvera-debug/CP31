using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace AcpCryptoLib
{
	// Token: 0x02000003 RID: 3
	public class AcpAssemblyIdentityValidator
	{
		// Token: 0x06000004 RID: 4
		[global::System.Runtime.InteropServices.DllImport("mscoree.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern bool StrongNameSignatureVerificationEx(string A_0, bool A_1, ref bool A_2);

		// Token: 0x06000005 RID: 5 RVA: 0x000031BC File Offset: 0x000013BC
		public void Write(string Input_str)
		{
			int a_ = 3;
			short num = (short)278683083;
			short num2 = num;
			num = (short)2103074251;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)346423297;
				if (num != 0)
				{
				}
				num = (short)615251968;
				if (num != 0)
				{
				}
				global::System.Reflection.Assembly callingAssembly = global::System.Reflection.Assembly.GetCallingAssembly();
				global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
				global::System.Console.WriteLine(callingAssembly.FullName);
				if (!this.ValidateAssemblyIdentities(executingAssembly, callingAssembly))
				{
					global::System.Console.WriteLine(global::AcpCryptoLib.XmlEncryptionUtil.b("䄁攃樅搇漉縋⸍砏猑朓㘕瘗甙㰛洝吟倡䬣䠥伧਩戫伭崯圱", a_));
					return;
				}
				num = (short)980156416;
				short num3 = num;
				break;
			}
			}
			global::System.Console.WriteLine(global::AcpCryptoLib.XmlEncryptionUtil.b("䄁攃樅搇漉縋⸍昏猑砓缕簗笙栛笝䐟ȡ圣匥䬧䤩䤫崭䌯吱䄳娵吷䌹", a_));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000032B8 File Offset: 0x000014B8
		public bool ValidateAssemblyIdentities(global::System.Reflection.Assembly execAssm, global::System.Reflection.Assembly caller)
		{
			short num = (short)948174848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				bool result;
				global::System.Security.Policy.StrongName strongName;
				global::System.Security.Policy.StrongName strongName2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)177668100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)2055667713;
						if (num != 0)
						{
						}
						result = this.a(execAssm, caller);
						num = (short)1963589637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)856064601;
						short num3 = num;
						num = (short)88113753;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_108;
						default:
						{
							num = (short)1135149056;
							if (num != 0)
							{
							}
							bool flag;
							if (global::AcpCryptoLib.AcpAssemblyIdentityValidator.StrongNameSignatureVerificationEx(caller.Location, true, ref flag))
							{
								num = (short)1855258630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 3:
						if (this.a(execAssm, out strongName))
						{
							num = (short)370933760;
							short num4 = num;
							num = (short)574423040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (this.a(caller, out strongName2))
						{
							num = (short)808386568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						return result;
					case 6:
						num = (short)193527815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.b(execAssm, caller))
						{
							num = (short)215482369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
					{
						bool flag = false;
						goto IL_108;
					}
					}
					goto IL_53;
					IL_108:
					num = (short)1714290690;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_53:
				result = false;
				strongName = null;
				strongName2 = null;
				num = (short)312279043;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000034F0 File Offset: 0x000016F0
		private bool a(global::System.Reflection.Assembly A_0, out global::System.Security.Policy.StrongName A_1)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				global::System.Collections.IEnumerator hostEnumerator;
				switch (num)
				{
				case 0:
					goto IL_123;
				case 1:
					if (hostEnumerator.Current.GetType().FullName == global::AcpCryptoLib.XmlEncryptionUtil.b("叿笁眃爅洇有∋崍甏焑愓搕焗渙攛〝瀟䴡䠣伥䬧匩ȫ紭䐯䀱嬳堵強琹崻匽┿", a_))
					{
						num2 = (short)361299973;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_123;
				case 2:
					if (A_0 != null)
					{
						num2 = (short)697499651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_162;
				case 3:
					goto IL_FC;
				case 4:
					goto IL_162;
				case 5:
					A_1 = (global::System.Security.Policy.StrongName)hostEnumerator.Current;
					result = true;
					num2 = (short)1386151942;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_162;
				case 7:
					if (!hostEnumerator.MoveNext())
					{
						num2 = (short)708182020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)152895489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_39;
				IL_FC:
				hostEnumerator = A_0.Evidence.GetHostEnumerator();
				num2 = (short)1634336768;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_162:
				num2 = (short)747896832;
				short num3 = num2;
				num2 = (short)1009758175;
				short num4 = num2;
				num2 = (short)1168551903;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FC;
				default:
					goto IL_1C2;
				}
				IL_123:
				num2 = (short)2036203527;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C2:
			num2 = (short)824377345;
			if (num2 != 0)
			{
			}
			num2 = (short)928186368;
			if (num2 != 0)
			{
			}
			return result;
			IL_39:
			A_1 = null;
			result = false;
			num2 = (short)612040706;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00003700 File Offset: 0x00001900
		private bool b(global::System.Reflection.Assembly A_0, global::System.Reflection.Assembly A_1)
		{
			short num = (short)469630976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				byte[] publicKeyToken;
				byte[] publicKeyToken2;
				bool result;
				for (;;)
				{
					IL_28:
					int num4;
					switch (num2)
					{
					case 0:
					{
						num = (short)342203919;
						short num3 = num;
						num = (short)106929679;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AE;
						default:
							num = (short)1932263424;
							if (num != 0)
							{
							}
							goto IL_B3;
						}
						break;
					}
					case 1:
						goto IL_AE;
					case 2:
						if (num4 >= publicKeyToken.Length)
						{
							num = (short)563740681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1772945411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (publicKeyToken[num4] != publicKeyToken2[num4])
						{
							num = (short)2141650948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)794427392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						result = false;
						num = (short)1473970182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (publicKeyToken.Length == publicKeyToken2.Length)
						{
							num = (short)282591233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)781778952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_20E;
					case 7:
						goto IL_1F1;
					case 8:
						goto IL_1B3;
					case 9:
						num = (short)43450375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_B3;
					}
					goto IL_5B;
					IL_AE:
					num4 = 0;
					num = (short)2026110986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B3:
					num = (short)48103426;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B3:
				IL_1F1:
				return result;
				IL_20E:
				num = (short)1486815233;
				if (num != 0)
				{
				}
				num = (short)780206080;
				short num5 = num;
				return result;
				IL_5B:
				publicKeyToken = A_0.GetName().GetPublicKeyToken();
				publicKeyToken2 = A_1.GetName().GetPublicKeyToken();
				result = true;
				num = (short)751304709;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003970 File Offset: 0x00001B70
		private bool a(global::System.Reflection.Assembly A_0, global::System.Reflection.Assembly A_1)
		{
			short num = (short)1350959104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				byte[] publicKey;
				byte[] publicKey2;
				bool result;
				for (;;)
				{
					IL_27:
					int num4;
					switch (num2)
					{
					case 0:
					{
						num = (short)1131869909;
						short num3 = num;
						num = (short)1983772373;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AE;
						default:
							num = (short)617152512;
							if (num != 0)
							{
							}
							goto IL_DA;
						}
						break;
					}
					case 1:
						goto IL_AE;
					case 2:
						if (num4 >= publicKey.Length)
						{
							num = (short)31719433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1173618691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (publicKey[num4] != publicKey2[num4])
						{
							num = (short)365953028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1385234432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						result = false;
						num = (short)1206386694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (publicKey.Length == publicKey2.Length)
						{
							num = (short)656539649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1970405384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_236;
					case 7:
						goto IL_21A;
					case 8:
						goto IL_1DB;
					case 9:
						num = (short)105775111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_DA;
					}
					goto IL_5A;
					IL_AE:
					num = (short)180158465;
					if (num != 0)
					{
					}
					num4 = 0;
					num = (short)1867055114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DA:
					num = (short)1267728386;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DB:
				IL_21A:
				return result;
				IL_236:
				num = (short)27525120;
				short num5 = num;
				return result;
				IL_5A:
				publicKey = A_0.GetName().GetPublicKey();
				publicKey2 = A_1.GetName().GetPublicKey();
				result = true;
				num = (short)1445724165;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
