using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000018 RID: 24
	public static class PropertyHelper
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public static void copyProperties(object fromObject, object toObject)
		{
			short num;
			try
			{
				num = (short)1139081216;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					int num4;
					global::System.Reflection.PropertyInfo[] properties;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							global::System.Reflection.PropertyInfo property;
							global::System.Reflection.PropertyInfo propertyInfo;
							property.SetValue(toObject, propertyInfo.GetValue(fromObject, null), null);
							num = (short)132907010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1203896327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)1627165505;
							short num3 = num;
							num = (short)1101108033;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_82;
							default:
								num = (short)1119485952;
								if (num != 0)
								{
								}
								goto IL_7E;
							}
							break;
						}
						case 3:
						{
							global::System.Reflection.PropertyInfo property;
							if (property != null)
							{
								num = (short)1151664129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7E;
						}
						case 4:
							goto IL_204;
						case 5:
							num = (short)610861060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (num4 >= properties.Length)
							{
								num = (short)1153564677;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Reflection.PropertyInfo propertyInfo = properties[num4];
							global::System.Reflection.PropertyInfo property = toObject.GetType().GetProperty(propertyInfo.Name);
							num = (short)1677131779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Reflection.PropertyInfo property;
							if (property.GetSetMethod(true) != null)
							{
								num = (short)2133000192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7E;
						}
						case 8:
							goto IL_16A;
						case 9:
							goto IL_16A;
						}
						goto IL_56;
						IL_82:
						num = (short)1473904649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7E:
						num4++;
						goto IL_82;
						IL_16A:
						num = (short)1825374214;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_204:
					break;
					IL_56:
					properties = fromObject.GetType().GetProperties();
					num4 = 0;
					num = (short)208011272;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)365756417;
			if (num != 0)
			{
			}
			num = (short)1474428928;
			short num5 = num;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000C164 File Offset: 0x0000A364
		public static string GetPropertyName<T>(global::System.Linq.Expressions.Expression<global::System.Func<T>> propertyExpression)
		{
			short num = (short)591396865;
			if (num != 0)
			{
			}
			num = (short)1341610674;
			short num2 = num;
			num = (short)629562034;
			switch (num2 == num)
			{
			}
			num = (short)1779040256;
			short num3 = num;
			num = (short)1036386304;
			if (num != 0)
			{
			}
			global::System.Linq.Expressions.MemberExpression memberExpression = propertyExpression.Body as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression == null)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			return memberExpression.Member.Name;
		}
	}
}
