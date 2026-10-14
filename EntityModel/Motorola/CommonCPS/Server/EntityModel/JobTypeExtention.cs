using System;
using System.Reflection;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200010B RID: 267
	public static class JobTypeExtention
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x000A8B00 File Offset: 0x000A6D00
		public static bool IsMigirationJob(this global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			object[] customAttributes;
			global::System.Reflection.MemberInfo[] member;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_156;
				case 1:
					goto IL_11B;
				case 2:
					num2 = (short)110886915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (customAttributes.Length != 0)
					{
						num2 = (short)1323499520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (member != null)
					{
						num2 = (short)954335233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (customAttributes != null)
					{
						num2 = (short)1202585602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (member.Length != 0)
					{
						num2 = (short)144310279;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					customAttributes = member[0].GetCustomAttributes(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypeAttribute), false);
					num2 = (short)2008285189;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_156:
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypeAttribute)customAttributes[0]).Category == global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration;
			IL_30:
			member = typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.JobType).GetMember(jobType.ToString());
			num2 = (short)1984873275;
			short num3 = num2;
			num2 = (short)1094042427;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_11B:
				num2 = (short)645136390;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)986841089;
				if (num2 != 0)
				{
				}
				num2 = (short)1353252864;
				if (num2 != 0)
				{
				}
				num2 = (short)1035534336;
				short num4 = num2;
				num2 = (short)477364228;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
