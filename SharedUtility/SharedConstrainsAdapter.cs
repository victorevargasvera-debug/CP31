using System;
using System.Reflection;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using SharedUtility.Arguments;

namespace SharedUtility
{
	// Token: 0x0200000A RID: 10
	public class SharedConstrainsAdapter
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000035C0 File Offset: 0x000017C0
		public static bool CallConstraint(string Cons_ID, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily inProduct, string inVersion, global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			short num = (short)287703040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				object obj2;
				object obj4;
				for (;;)
				{
					IL_28:
					global::System.Reflection.MethodInfo methodInfo;
					object[] array3;
					switch (num2)
					{
					case 0:
						goto IL_26C;
					case 1:
						goto IL_1F5;
					case 2:
					{
						if (string.IsNullOrEmpty(inVersion))
						{
							num = (short)564985857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute productCPVersion = new global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute
						{
							Product = inProduct,
							Version = inVersion
						};
						global::System.Reflection.MethodInfo constraint = global::SharedUtility.SC_Manager.Instance.GetConstraint(Cons_ID, productCPVersion);
						num = (short)1121517575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_26C;
					case 4:
					{
						object[] array;
						object obj;
						if ((obj = array[1]) == null)
						{
							obj = global::Motorola.Common.CustomException.CommonErrorCode.None;
						}
						errorCode = (global::Motorola.Common.CustomException.CommonErrorCode)obj;
						num = (short)752025603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (methodInfo != null)
						{
							num = (short)2042363916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj2 = true;
						num = (short)1048182798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						object[] array2 = new object[2];
						array2[0] = args;
						object[] array = array2;
						global::System.Reflection.MethodInfo constraint;
						obj2 = constraint.Invoke(null, array);
						num = (short)1923678212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Reflection.MethodInfo constraint;
						if (constraint != null)
						{
							num = (short)1184366598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26C;
					}
					case 8:
						if (inProduct != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
						{
							num = (short)321454093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F5;
					case 9:
						goto IL_2FF;
					case 10:
					{
						num = (short)1115478864;
						short num3 = num;
						num = (short)749460304;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23D;
						default:
						{
							num = (short)1581842432;
							if (num != 0)
							{
							}
							object obj3;
							if ((obj3 = array3[1]) == null)
							{
								obj3 = global::Motorola.Common.CustomException.CommonErrorCode.None;
							}
							errorCode = (global::Motorola.Common.CustomException.CommonErrorCode)obj3;
							num = (short)247070720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 11:
						if ((obj4 = obj2) == null)
						{
							num = (short)1852440585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36D;
					case 12:
						goto IL_23D;
					case 13:
						num = (short)1609826305;
						if (num != 0)
						{
						}
						num = (short)821559298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_26C;
					}
					goto IL_6B;
					IL_1F5:
					methodInfo = global::SharedUtility.SC_Manager.Instance.a(Cons_ID);
					num = (short)1362755589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D:
					num = (short)2061828096;
					short num4 = num;
					object[] array4 = new object[2];
					array4[0] = args;
					array3 = array4;
					obj2 = methodInfo.Invoke(null, array3);
					num = (short)1616576522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26C:
					num = (short)1821376523;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2FF:
				obj4 = false;
				IL_36D:
				return (bool)obj4;
				IL_6B:
				errorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
				obj2 = null;
				num = (short)173801480;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
