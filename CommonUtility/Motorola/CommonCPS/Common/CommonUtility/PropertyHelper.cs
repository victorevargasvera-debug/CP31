using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000012 RID: 18
	public static class PropertyHelper
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00008B58 File Offset: 0x00006D58
		public static void copyProperties(object fromObject, object toObject)
		{
			short num;
			try
			{
				num = (short)71565312;
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
					int num3;
					global::System.Reflection.PropertyInfo[] properties;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							global::System.Reflection.PropertyInfo property;
							if (property != null)
							{
								num = (short)1223557127;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7E;
						}
						case 1:
							goto IL_11F;
						case 2:
						{
							global::System.Reflection.PropertyInfo property;
							if (property.GetSetMethod(true) != null)
							{
								num = (short)1373700105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7E;
						}
						case 3:
							goto IL_C7;
						case 4:
							goto IL_207;
						case 5:
						{
							if (num3 >= properties.Length)
							{
								num = (short)1966800904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Reflection.PropertyInfo propertyInfo = properties[num3];
							global::System.Reflection.PropertyInfo property = toObject.GetType().GetProperty(propertyInfo.Name);
							num = (short)1586561024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_11F;
						case 7:
							num = (short)1642725378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							num = (short)1740574780;
							short num4 = num;
							num = (short)1402933308;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C7;
							default:
								num = (short)1937899520;
								if (num != 0)
								{
								}
								num = (short)364183556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::System.Reflection.PropertyInfo property;
							global::System.Reflection.PropertyInfo propertyInfo;
							property.SetValue(toObject, propertyInfo.GetValue(fromObject, null), null);
							num = (short)598212611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_56;
						IL_7E:
						num3++;
						num = (short)616497153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_7E;
						IL_11F:
						num = (short)1843724293;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_207:
					break;
					IL_56:
					properties = fromObject.GetType().GetProperties();
					num3 = 0;
					num = (short)1665531910;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1160839168;
			short num5 = num;
			num = (short)1776943105;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public static string GetPropertyName<T>(global::System.Linq.Expressions.Expression<global::System.Func<T>> propertyExpression)
		{
			short num = (short)580048820;
			short num2 = num;
			num = (short)1738659764;
			switch (num2 == num)
			{
			}
			num = (short)1010499584;
			if (num != 0)
			{
			}
			num = (short)577765376;
			short num3 = num;
			num = (short)1015152641;
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
