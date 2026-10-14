using System;
using AcpBusinessLayer;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005ED RID: 1517
	public static class ConstraintHelper
	{
		// Token: 0x0600D0D1 RID: 53457 RVA: 0x00C38860 File Offset: 0x00C36A60
		public static global::AcpBusinessLayer.AcpField<T> GetField<T>(global::AcpCommonLib.IAcpFeatureSection target, string fieldName) where T : global::System.IComparable
		{
			short num = (short)1139729053;
			short num2 = num;
			num = (short)754901661;
			switch (num2 == num)
			{
			}
			num = (short)1440612353;
			if (num != 0)
			{
			}
			num = (short)103415808;
			if (num != 0)
			{
			}
			num = (short)1223032832;
			short num3 = num;
			return (global::AcpBusinessLayer.AcpField<T>)target[fieldName];
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x00C38914 File Offset: 0x00C36B14
		public static T GetFieldValueByLocation<T>(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.IAcpFeatureSection target, string fieldName) where T : global::System.IComparable
		{
			short num = (short)1112459436;
			short num2 = num;
			num = (short)1533003948;
			switch (num2 == num)
			{
			}
			num = (short)1873149953;
			if (num != 0)
			{
			}
			num = (short)1142554624;
			if (num != 0)
			{
			}
			num = (short)1137115136;
			short num3 = num;
			T result = default(T);
			global::ConstraintHelper.ConstraintHelper.GetField<T>(target, fieldName);
			return result;
		}
	}
}
