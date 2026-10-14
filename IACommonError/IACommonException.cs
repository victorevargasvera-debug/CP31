using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace IACustomException
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public sealed class IACommonException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public global::IACustomException.IACommonErrorCode ErrorCode
		{
			get
			{
				short num = (short)2092236801;
				if (num != 0)
				{
				}
				num = (short)864646373;
				short num2 = num;
				num = (short)1456501989;
				switch (num2 == num)
				{
				}
				num = (short)2065825792;
				short num3 = num;
				num = (short)99418112;
				if (num != 0)
				{
				}
				return this.errorCode;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000021C8 File Offset: 0x000003C8
		public global::IACustomException.IACommonExceptionData CommonExceptionData
		{
			get
			{
				short num = (short)1581148485;
				short num2 = num;
				num = (short)1087203653;
				switch (num2 == num)
				{
				}
				num = (short)902561793;
				if (num != 0)
				{
				}
				num = (short)1200226304;
				short num3 = num;
				num = (short)141361152;
				if (num != 0)
				{
				}
				return this.commonExceptionData;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002278 File Offset: 0x00000478
		private IACommonException(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002290 File Offset: 0x00000490
		public IACommonException(global::IACustomException.IACommonErrorCode errorID, global::System.Exception systemException) : base(systemException.Message, systemException)
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022B4 File Offset: 0x000004B4
		public IACommonException(global::IACustomException.IACommonErrorCode errorID) : base(errorID.ToString())
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022DC File Offset: 0x000004DC
		public IACommonException(global::IACustomException.IACommonExceptionData commonExceptionData) : base(commonExceptionData.ErrorCode.ToString())
		{
			this.errorCode = commonExceptionData.ErrorCode;
			this.commonExceptionData = commonExceptionData;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002318 File Offset: 0x00000518
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			short num = (short)1048117249;
			if (num != 0)
			{
			}
			num = (short)1690554736;
			short num2 = num;
			num = (short)774623600;
			switch (num2 == num)
			{
			}
			num = (short)1390346240;
			short num3 = num;
			num = (short)83034112;
			if (num != 0)
			{
			}
			info.AddValue(global::IACustomException.IAErrorCodeAttributes.b("鳘꧚꿜냞鏠ꫢꇤ훦", a_), this.errorCode);
			base.GetObjectData(info, context);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023F0 File Offset: 0x000005F0
		public IACommonException(string message, global::System.Exception ex) : base(message, ex)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002408 File Offset: 0x00000608
		public IACommonException()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000241C File Offset: 0x0000061C
		public IACommonException(string message) : base(message)
		{
			this.errorCode = global::IACustomException.IACommonErrorCode.GenericError;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002438 File Offset: 0x00000638
		public IACommonException(global::IACustomException.IACommonErrorCode errorID, string message) : base(message)
		{
			this.errorCode = errorID;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002454 File Offset: 0x00000654
		public IACommonException(global::IACustomException.IACommonErrorCode errorID, string message, global::System.Exception ex) : base(message, ex)
		{
			this.errorCode = errorID;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002470 File Offset: 0x00000670
		public static bool IsError(global::IACustomException.IACommonErrorCode errorCode)
		{
			short num = (short)1870266368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1228931073;
				if (num != 0)
				{
				}
				num = (short)1524695040;
				short num3 = num;
				bool result = true;
				global::System.Type typeFromHandle = typeof(global::IACustomException.IACommonErrorCode);
				string enumName = typeFromHandle.GetEnumName(errorCode);
				global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(enumName);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D5;
					}
					global::IACustomException.IAErrorCodeAttributes[] array3;
					for (;;)
					{
						IL_9A:
						switch (num2)
						{
						case 0:
							goto IL_1D7;
						case 1:
							goto IL_2B2;
						case 2:
							goto IL_2B2;
						case 3:
							result = false;
							num = (short)1376649226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_2CA;
						case 5:
						{
							int num4;
							global::IACustomException.IAErrorCodeAttributes[] array;
							if (num4 >= array.Length)
							{
								num = (short)991428615;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)697761801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							int num5;
							global::System.Reflection.MemberInfo[] array2;
							if (num5 >= array2.Length)
							{
								num = (short)443678721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array3 = (global::IACustomException.IAErrorCodeAttributes[])array2[num5].GetCustomAttributes(typeof(global::IACustomException.IAErrorCodeAttributes), false);
							num = (short)1980039176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)704577538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (array3 != null)
							{
								num = (short)45023232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B2;
						case 9:
						{
							int num4;
							global::IACustomException.IAErrorCodeAttributes[] array;
							if (array[num4].Retriable)
							{
								num = (short)920059907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B2;
						}
						case 10:
							goto IL_2B2;
						case 11:
							num = (short)965935110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)1022164997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
						IL_2B2:
						num = (short)1724841988;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D7:
					goto IL_145;
					IL_2CA:
					return result;
					IL_D5:
					num = (short)707199374;
					short num6 = num;
					num = (short)1565852046;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_145:
						global::IACustomException.IAErrorCodeAttributes[] array = array3;
						int num4 = 0;
						num = (short)1466105868;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_9A;
					}
					default:
					{
						num = (short)57671680;
						if (num != 0)
						{
						}
						global::System.Reflection.MemberInfo[] array2 = member;
						int num5 = 0;
						num = (short)412876811;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_9A;
					}
					}
				}
				catch
				{
				}
				return result;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		private global::IACustomException.IACommonErrorCode errorCode;

		// Token: 0x04000004 RID: 4
		private global::IACustomException.IACommonExceptionData commonExceptionData;
	}
}
