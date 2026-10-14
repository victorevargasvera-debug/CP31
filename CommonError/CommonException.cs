using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public sealed class CommonException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorCode
		{
			get
			{
				short num = (short)899671498;
				short num2 = num;
				num = (short)1756751306;
				switch (num2 == num)
				{
				}
				num = (short)1821507585;
				if (num != 0)
				{
				}
				num = (short)2006843392;
				if (num != 0)
				{
				}
				num = (short)2045771776;
				short num3 = num;
				return this.errorCode;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000021D0 File Offset: 0x000003D0
		public global::Motorola.Common.CustomException.CommonExceptionData CommonExceptionData
		{
			get
			{
				short num = (short)593591943;
				short num2 = num;
				num = (short)491683463;
				switch (num2 == num)
				{
				}
				num = (short)2011955201;
				if (num != 0)
				{
				}
				num = (short)971702272;
				if (num != 0)
				{
				}
				num = (short)1543045120;
				short num3 = num;
				return this.commonExceptionData;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002280 File Offset: 0x00000480
		private CommonException(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002298 File Offset: 0x00000498
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, global::System.Exception systemException) : base(systemException.Message, systemException)
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022BC File Offset: 0x000004BC
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID) : base(errorID.ToString())
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022E4 File Offset: 0x000004E4
		public CommonException(global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData) : base(commonExceptionData.ErrorCode.ToString())
		{
			this.errorCode = commonExceptionData.ErrorCode;
			this.commonExceptionData = commonExceptionData;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002320 File Offset: 0x00000520
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			short num = (short)962134017;
			if (num != 0)
			{
			}
			num = (short)1993895397;
			short num2 = num;
			num = (short)1014722021;
			switch (num2 == num)
			{
			}
			num = (short)57016320;
			if (num != 0)
			{
			}
			num = (short)962723840;
			short num3 = num;
			info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("鯝鋟郡诣铥ꇧ껩\uddeb", a_), this.errorCode);
			base.GetObjectData(info, context);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023F8 File Offset: 0x000005F8
		public CommonException(string message, global::System.Exception ex) : base(message, ex)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002410 File Offset: 0x00000610
		public CommonException()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002424 File Offset: 0x00000624
		public CommonException(string message) : base(message)
		{
			this.errorCode = global::Motorola.Common.CustomException.CommonErrorCode.GenericError;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002440 File Offset: 0x00000640
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, string message) : base(message)
		{
			this.errorCode = errorID;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000245C File Offset: 0x0000065C
		public CommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, string message, global::System.Exception ex) : base(message, ex)
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002478 File Offset: 0x00000678
		public static bool IsError(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			short num = (short)1104281600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1539768321;
				if (num != 0)
				{
				}
				bool result = true;
				global::System.Type typeFromHandle = typeof(global::Motorola.Common.CustomException.CommonErrorCode);
				string enumName = typeFromHandle.GetEnumName(errorCode);
				global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(enumName);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					int num5;
					global::System.Reflection.MemberInfo[] array3;
					for (;;)
					{
						IL_70:
						switch (num2)
						{
						case 0:
							num = (short)699858956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1DB;
						case 2:
							num = (short)670498820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.Common.CustomException.ErrorCodeAttributes[] array2;
							global::Motorola.Common.CustomException.ErrorCodeAttributes[] array = array2;
							int num3 = 0;
							num = (short)486998018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.Common.CustomException.ErrorCodeAttributes[] array;
							int num3;
							if (num3 >= array.Length)
							{
								num = (short)1018298368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1174926364;
							short num4 = num;
							num = (short)628421660;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1DB;
							default:
								num = (short)727777280;
								if (num != 0)
								{
								}
								num = (short)950665227;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							if (num5 >= array3.Length)
							{
								num = (short)1245184001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.CustomException.ErrorCodeAttributes[] array2 = (global::Motorola.Common.CustomException.ErrorCodeAttributes[])array3[num5].GetCustomAttributes(typeof(global::Motorola.Common.CustomException.ErrorCodeAttributes), false);
							num = (short)595918854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::Motorola.Common.CustomException.ErrorCodeAttributes[] array2;
							if (array2 != null)
							{
								num = (short)1026818051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28F;
						}
						case 7:
							goto IL_2A7;
						case 8:
							goto IL_28F;
						case 9:
							num = (short)485359621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result = false;
							num = (short)1337982984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::Motorola.Common.CustomException.ErrorCodeAttributes[] array;
							int num3;
							if (array[num3].Retriable)
							{
								num = (short)576389130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28F;
						}
						case 12:
							goto IL_28F;
						}
						goto IL_AB;
						IL_28F:
						num = (short)817496071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DB:
						goto IL_28F;
					}
					IL_2A7:
					goto IL_2AC;
					IL_AB:
					array3 = member;
					num5 = 0;
					num = (short)1622409225;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_70;
				}
				catch
				{
				}
				IL_2AC:
				num = (short)2105278464;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002778 File Offset: 0x00000978
		public static bool IsDBMigrationFatalError(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			object[] customAttributes;
			short num2;
			global::System.Reflection.MemberInfo[] member;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (customAttributes.Length != 0)
					{
						num2 = (short)1678508034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
				{
					num2 = (short)541634500;
					short num3 = num2;
					num2 = (short)1760735172;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)138870784;
						short num4 = num2;
						num2 = (short)1205010432;
						if (num2 != 0)
						{
						}
						customAttributes = member[0].GetCustomAttributes(typeof(global::Motorola.Common.CustomException.DBMigrationErrorAttribute), false);
						break;
					}
					}
					num2 = (short)1017708547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_E5;
				case 3:
					if (customAttributes != null)
					{
						num2 = (short)1301938181;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (member != null)
					{
						num2 = (short)774766599;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					num2 = (short)852492288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (member.Length != 0)
					{
						num2 = (short)1270546433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)1949302790;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_E5:
			return ((global::Motorola.Common.CustomException.DBMigrationErrorAttribute)customAttributes[0]).IsFatal;
			IL_30:
			num2 = (short)576847873;
			if (num2 != 0)
			{
			}
			member = typeof(global::Motorola.Common.CustomException.CommonErrorCode).GetMember(errorCode.ToString());
			num2 = (short)1676017668;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002974 File Offset: 0x00000B74
		public static bool IsBatchOpJobFatalError(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			object[] customAttributes;
			short num2;
			global::System.Reflection.MemberInfo[] member;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (customAttributes.Length != 0)
					{
						num2 = (short)1754202114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C6;
				case 1:
				{
					num2 = (short)2129447963;
					short num3 = num2;
					num2 = (short)171559963;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)237174784;
						if (num2 != 0)
						{
						}
						num2 = (short)1576140800;
						short num4 = num2;
						customAttributes = member[0].GetCustomAttributes(typeof(global::Motorola.Common.CustomException.BatchOperationErrorAttribute), false);
						break;
					}
					}
					num2 = (short)1301741571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_B8;
				case 3:
					if (customAttributes != null)
					{
						num2 = (short)2017394693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C6;
				case 4:
					if (member != null)
					{
						num2 = (short)830603271;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C6;
				case 5:
					num2 = (short)1863581696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (member.Length != 0)
					{
						num2 = (short)24379393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C6;
				case 7:
					num2 = (short)121831430;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_B8:
			return ((global::Motorola.Common.CustomException.BatchOperationErrorAttribute)customAttributes[0]).IsFatal;
			IL_1C6:
			num2 = (short)157483009;
			if (num2 != 0)
			{
			}
			return false;
			IL_30:
			member = typeof(global::Motorola.Common.CustomException.CommonErrorCode).GetMember(errorCode.ToString());
			num2 = (short)2124742660;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000003 RID: 3
		private global::Motorola.Common.CustomException.CommonErrorCode errorCode;

		// Token: 0x04000004 RID: 4
		private global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData;
	}
}
