using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000009 RID: 9
	[global::System.Serializable]
	public class Cps2Exception : global::System.Exception
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003164 File Offset: 0x00001364
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00003214 File Offset: 0x00001414
		public int ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)437846016;
				short num2 = num;
				num = (short)478704343;
				short num3 = num;
				num = (short)555905751;
				switch (num3 == num)
				{
				}
				num = (short)2125660161;
				if (num != 0)
				{
				}
				num = (short)194510848;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)241696768;
				short num2 = num;
				num = (short)1364427299;
				short num3 = num;
				num = (short)17662499;
				switch (num3 == num)
				{
				}
				num = (short)1965686785;
				if (num != 0)
				{
				}
				num = (short)469630976;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000032C4 File Offset: 0x000014C4
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00003370 File Offset: 0x00001570
		public string ResourceId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1476263936;
				short num2 = num;
				num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)1087037062;
				short num3 = num;
				num = (short)654958214;
				switch (num3 == num)
				{
				}
				num = (short)807796736;
				if (num != 0)
				{
				}
				return this.<ResourceId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)761462784;
				short num2 = num;
				num = (short)1661478269;
				short num3 = num;
				num = (short)1581655421;
				switch (num3 == num)
				{
				}
				num = (short)712507393;
				if (num != 0)
				{
				}
				num = (short)946798592;
				if (num != 0)
				{
				}
				this.<ResourceId>k__BackingField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000034D4 File Offset: 0x000016D4
		public string ResourceMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1410203648;
				short num2 = num;
				num = (short)1361821074;
				short num3 = num;
				num = (short)1036107154;
				switch (num3 == num)
				{
				}
				num = (short)2037710848;
				if (num != 0)
				{
				}
				num = (short)74842113;
				if (num != 0)
				{
				}
				return this.<ResourceMessage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)901185536;
				short num2 = num;
				num = (short)651034625;
				if (num != 0)
				{
				}
				num = (short)905966479;
				short num3 = num;
				num = (short)1689252751;
				switch (num3 == num)
				{
				}
				num = (short)1426849792;
				if (num != 0)
				{
				}
				this.<ResourceMessage>k__BackingField = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003638 File Offset: 0x00001838
		public string[] Parameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)937361408;
				short num2 = num;
				num = (short)745274085;
				short num3 = num;
				num = (short)1240857317;
				switch (num3 == num)
				{
				}
				num = (short)827785217;
				if (num != 0)
				{
				}
				num = (short)1432158208;
				if (num != 0)
				{
				}
				return this.<Parameters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)384237568;
				short num2 = num;
				num = (short)505718974;
				short num3 = num;
				num = (short)844212414;
				switch (num3 == num)
				{
				}
				num = (short)2117074945;
				if (num != 0)
				{
				}
				num = (short)1118306304;
				if (num != 0)
				{
				}
				this.<Parameters>k__BackingField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000036E8 File Offset: 0x000018E8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000379C File Offset: 0x0000199C
		public global::Motorola.Common.CustomException.CommonException CommonException
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1212088320;
				short num2 = num;
				num = (short)1416357700;
				short num3 = num;
				num = (short)1066526532;
				switch (num3 == num)
				{
				}
				num = (short)1942683649;
				if (num != 0)
				{
				}
				num = (short)1183514624;
				if (num != 0)
				{
				}
				return this.<CommonException>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1593573376;
				short num2 = num;
				num = (short)183190960;
				short num3 = num;
				num = (short)1755006384;
				switch (num3 == num)
				{
				}
				num = (short)181338113;
				if (num != 0)
				{
				}
				num = (short)1768423424;
				if (num != 0)
				{
				}
				this.<CommonException>k__BackingField = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003850 File Offset: 0x00001A50
		public override string Message
		{
			get
			{
				int a_ = 7;
				short num = (short)753336320;
				int num2 = (int)((global::System.IntPtr)num);
				string result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1640038401;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 1:
						num = (short)1279262725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						return result;
					case 4:
					{
						num = (short)1307901952;
						short num3 = num;
						goto IL_129;
					}
					case 5:
						if (!string.IsNullOrEmpty(this._refResourceId))
						{
							num = (short)61931524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.CustomException.ErrorCodeAttributes.b("菗慄ꟛ\udadf틡駣믥죧釩\uddeb鏭璘￱ﻳ践쫷蟹", a_), this.ErrorCode, this.ResourceId, this._message);
						num = (short)1794572291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6E:
					num = (short)756507961;
					short num4 = num;
					num = (short)1576559929;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1670971392;
						if (num != 0)
						{
						}
						if (this._refErrorCode < 0)
						{
							num = (short)378339329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_129:
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.CustomException.ErrorCodeAttributes.b("菗慄ꟛ\udadf틡駣믥죧釩\uddeb鏭璘꧱ퟳ践쫷샹쳻菽巿∁缃㔅甇̉ċЍ欏☑椓", a_), new object[]
					{
						this.ErrorCode,
						this.ResourceId,
						this._refErrorCode,
						this._refResourceId,
						this._message
					});
					num = (short)899612674;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003A64 File Offset: 0x00001C64
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00003B10 File Offset: 0x00001D10
		public bool ShowError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)852623360;
				short num2 = num;
				num = (short)2062680065;
				if (num != 0)
				{
				}
				num = (short)856953723;
				short num3 = num;
				num = (short)73405307;
				switch (num3 == num)
				{
				}
				num = (short)682885120;
				if (num != 0)
				{
				}
				return this.<ShowError>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1877803008;
				short num2 = num;
				num = (short)278147365;
				short num3 = num;
				num = (short)1357066533;
				switch (num3 == num)
				{
				}
				num = (short)249954305;
				if (num != 0)
				{
				}
				num = (short)1431044096;
				if (num != 0)
				{
				}
				this.<ShowError>k__BackingField = value;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003BC0 File Offset: 0x00001DC0
		protected Cps2Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(info, context);
			this.ErrorCode = (int)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("雒꟔ꗖ뛘꧚黜냞藠蛢", a_), typeof(int)) : null);
			this._refErrorCode = (int)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("賒꟔닖뿘黚꿜귞軠釢ꛤ裦跨軪", a_), typeof(int)) : null);
			this.ResourceId = (string)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("臒냔ꓖ뛘껚꿜볞蓠ꫢ臤", a_), typeof(string)) : null);
			this._refResourceId = (string)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("賒꟔닖뿘觚룜곞軠離韤蓦賨ꋪ觬", a_), typeof(string)) : null);
			this.ResourceMessage = (string)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("臒냔ꓖ뛘껚꿜볞蓠껢胤铦髨諪諬諮", a_), typeof(string)) : null);
			this.Parameters = (string[])((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("菒듔ꗖ룘뛚룜ꯞ蓠釢雤", a_), typeof(string[])) : null);
			this.CommonException = (global::Motorola.Common.CustomException.CommonException)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("郒뫔뫖듘듚돜髞駠胢胤韦鷨苪苬臮", a_), typeof(global::Motorola.Common.CustomException.CommonException)) : null);
			this._message = (string)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("賒룔닖꫘꣚볜룞蓠", a_), typeof(string)) : null);
			this.ShowError = (bool)((info != null) ? info.GetValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("胒뷔룖께黚꿜귞軠釢", a_), typeof(bool)) : null);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003DC0 File Offset: 0x00001FC0
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, Flags = global::System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			short num = (short)501678080;
			short num2 = num;
			num = (short)1606416826;
			short num3 = num;
			num = (short)445774266;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1546846208;
				if (num != 0)
				{
				}
				num = (short)1782448129;
				if (num != 0)
				{
				}
				if (info != null)
				{
					base.GetObjectData(info, context);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("駛곝鋟跡難ꗥ蟧軩觫", a_), this.ErrorCode);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("菛곝藟蓡ꇣ铥髧藩黫귭鿯雱釳", a_), this._refErrorCode);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("軛믝鏟跡釣铥诧迩ꗫ諭", a_), this.ResourceId);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("菛곝藟蓡뛣菥鯧藩駫鳭鏯韱뷳鋵", a_), this._refResourceId);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("軛믝鏟跡釣铥诧迩ꇫ语華臱闳釵鷷", a_), this.ResourceMessage);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("賛뿝鋟菡解菥鳧迩黫鷭", a_), this.Parameters);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("鿛뇝跟迡诣裥귧鋩迫语胯蛱鷳駵雷", a_), this.CommonException);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("菛돝藟釡韣蟥迧迩", a_), this._message);
					info.AddValue(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("进뛝迟闡ꇣ铥髧藩黫", a_), this.ShowError);
					return;
				}
				break;
			}
			throw new global::System.ArgumentNullException(global::Motorola.Common.CustomException.ErrorCodeAttributes.b("뗛냝蛟跡", a_));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003F80 File Offset: 0x00002180
		public Cps2Exception(global::Motorola.Common.CustomException.CommonException commonException)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(commonException.Message, commonException);
			this.CommonException = commonException;
			this.a(commonException.ErrorCode);
			string message = commonException.Message;
			global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData = commonException.CommonExceptionData;
			this.a(message, (commonExceptionData != null) ? commonExceptionData.Paramters : null);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003FE4 File Offset: 0x000021E4
		public Cps2Exception(global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode, string message = null, string[] parameters = null)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(message);
			this.a(commonErrorCode);
			this.a(message, parameters);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000401C File Offset: 0x0000221C
		public Cps2Exception(global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode, global::System.Exception innerException, string message = null, string[] parameters = null)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(message, innerException);
			this.a(commonErrorCode);
			this.a(message, parameters);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004058 File Offset: 0x00002258
		public Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes cps2ErrorCode, global::System.Exception innerException, string[] parameters = null)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(innerException.Message, innerException);
			global::Motorola.Common.CustomException.CommonException ex = innerException as global::Motorola.Common.CustomException.CommonException;
			if (ex == null)
			{
				this.a(cps2ErrorCode, true);
			}
			else
			{
				this.CommonException = ex;
				if (parameters == null)
				{
					global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData = ex.CommonExceptionData;
					parameters = ((commonExceptionData != null) ? commonExceptionData.Paramters : null);
				}
				this.a(ex.ErrorCode, true);
				this.a(cps2ErrorCode, false);
			}
			this.a(innerException.Message, parameters);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000040E8 File Offset: 0x000022E8
		public Cps2Exception(global::Motorola.Common.CustomException.Cps2ErrorCodes cps2ErrorCode, string message = null, string[] parameters = null)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(message);
			this.a(cps2ErrorCode, true);
			this.a(message, parameters);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004124 File Offset: 0x00002324
		public Cps2Exception(global::Motorola.Common.CustomException.PcrCps2ErrorCodes pcrCps2ErrorCode, global::System.Exception exception, string[] parameters = null)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(exception.Message, exception);
			global::Motorola.Common.CustomException.CommonException ex = exception as global::Motorola.Common.CustomException.CommonException;
			if (ex == null)
			{
				this.a(pcrCps2ErrorCode, true);
			}
			else
			{
				this.CommonException = ex;
				if (parameters == null)
				{
					global::Motorola.Common.CustomException.CommonExceptionData commonExceptionData = ex.CommonExceptionData;
					parameters = ((commonExceptionData != null) ? commonExceptionData.Paramters : null);
				}
				this.a(ex.ErrorCode, true);
				this.a(pcrCps2ErrorCode, false);
			}
			this.a(exception.Message, parameters);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000041B4 File Offset: 0x000023B4
		public Cps2Exception(global::Motorola.Common.CustomException.PcrCps2ErrorCodes pcrCps2ErrorCode, string message = null, string[] parameters = null)
		{
			this.<ErrorCode>k__BackingField = -1;
			this._refErrorCode = -1;
			this.<ShowError>k__BackingField = true;
			base..ctor(message);
			this.a(pcrCps2ErrorCode, true);
			this.a(message, parameters);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000041F0 File Offset: 0x000023F0
		public bool IsErrorCodeMached(global::Motorola.Common.CustomException.ErrorCodeType type, int errorCode)
		{
			short num = (short)2027225088;
			short num2 = num;
			num = (short)84369015;
			short num3 = num;
			num = (short)1226595959;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1512833025;
				if (num != 0)
				{
				}
				num = (short)1057751040;
				if (num != 0)
				{
				}
				num4 = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode(errorCode, type);
				if (num4 == this.ErrorCode)
				{
					return true;
				}
				break;
			}
			return num4 == this._refErrorCode;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000042B8 File Offset: 0x000024B8
		private void a(global::Motorola.Common.CustomException.CommonErrorCode A_0)
		{
			short num = (short)1509687296;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.CustomException.PcrCps2ErrorCodes a_;
			global::Motorola.Common.CustomException.Cps2ErrorCodes a_2;
			for (;;)
			{
				num = (short)967180289;
				if (num != 0)
				{
				}
				num = (short)2108293120;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 1:
				{
					num = (short)289658099;
					short num4 = num;
					num = (short)2116080883;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E0;
					}
					break;
				}
				case 2:
					if (global::Motorola.Common.CustomException.Cps2Exception._mapCommonAndPcrCps2ErrorCode.TryGetValue(A_0, out a_))
					{
						num = (short)1401421827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 3:
					goto IL_14D;
				}
				IL_84:
				if (global::Motorola.Common.CustomException.Cps2Exception._mapCommonAndCps2ErrorCode.TryGetValue(A_0, out a_2))
				{
					num = (short)1576009729;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1287585794;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E0:
			num = (short)893059072;
			if (num != 0)
			{
			}
			this.a(a_2, true);
			this.a(A_0, false);
			this.CommonException = null;
			return;
			IL_14D:
			this.a(a_, true);
			this.a(A_0, false);
			this.CommonException = null;
			return;
			IL_167:
			this.a(A_0, true);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004434 File Offset: 0x00002634
		private void a(global::Motorola.Common.CustomException.CommonErrorCode A_0, bool A_1)
		{
			short num = (short)1064566784;
			short num2 = num;
			num = (short)1039944779;
			short num3 = num;
			num = (short)788352075;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)807927808;
				if (num != 0)
				{
				}
				if (!A_1)
				{
					num = (short)1521418241;
					if (num != 0)
					{
					}
					this._refErrorCode = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode((int)A_0, global::Motorola.Common.CustomException.ErrorCodeType.Common);
					this._refResourceId = A_0.ToString();
					return;
				}
				break;
			}
			this.ErrorCode = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode((int)A_0, global::Motorola.Common.CustomException.ErrorCodeType.Common);
			this.ResourceId = A_0.ToString();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004524 File Offset: 0x00002724
		private void a(global::Motorola.Common.CustomException.Cps2ErrorCodes A_0, bool A_1)
		{
			short num = (short)1583153152;
			short num2 = num;
			num = (short)1758066525;
			short num3 = num;
			num = (short)1286928221;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)129499136;
				if (num != 0)
				{
				}
				num = (short)641138689;
				if (num != 0)
				{
				}
				if (!A_1)
				{
					this._refErrorCode = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode((int)A_0, global::Motorola.Common.CustomException.ErrorCodeType.Cps2AllPacs);
					this._refResourceId = A_0.ToString();
					return;
				}
				break;
			}
			this.ErrorCode = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode((int)A_0, global::Motorola.Common.CustomException.ErrorCodeType.Cps2AllPacs);
			this.ResourceId = A_0.ToString();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004614 File Offset: 0x00002814
		private void a(global::Motorola.Common.CustomException.PcrCps2ErrorCodes A_0, bool A_1)
		{
			if (!A_1)
			{
				short num = (short)238939066;
				short num2 = num;
				num = (short)195816378;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1067253761;
					if (num != 0)
					{
					}
					num = (short)143851520;
					short num3 = num;
					num = (short)1344077824;
					if (num != 0)
					{
					}
					this._refErrorCode = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode((int)A_0, global::Motorola.Common.CustomException.ErrorCodeType.Pcr);
					this._refResourceId = A_0.ToString();
					return;
				}
				}
			}
			this.ErrorCode = global::Motorola.Common.CustomException.Cps2Exception.CalculateErrorCode((int)A_0, global::Motorola.Common.CustomException.ErrorCodeType.Pcr);
			this.ResourceId = A_0.ToString();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004708 File Offset: 0x00002908
		private void a(string A_0 = null, string[] A_1 = null)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						try
						{
							this._message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, A_0, A_1);
							return;
						}
						catch
						{
							this._message = A_0;
							return;
						}
						goto IL_B8;
					case 1:
						if (A_1 != null)
						{
							num2 = (short)1583546368;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						goto IL_B8;
					case 3:
					{
						num2 = (short)31784960;
						short num3 = num2;
						if (!string.IsNullOrEmpty(A_0))
						{
							num2 = (short)1152778242;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
					IL_B8:
					num2 = (short)973549972;
					short num4 = num2;
					num2 = (short)1393111444;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num2 = (short)1479868417;
						if (num2 != 0)
						{
						}
						num2 = (short)309460992;
						if (num2 != 0)
						{
						}
						num2 = (short)1337786369;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_20:
				this._message = A_0;
				this.Parameters = A_1;
				num2 = (short)1630470147;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004888 File Offset: 0x00002A88
		public static int CalculateErrorCode(int errorCode, global::Motorola.Common.CustomException.ErrorCodeType type)
		{
			short num = (short)1949122239;
			short num2 = num;
			num = (short)200163007;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1307508736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1403518976;
			if (num != 0)
			{
			}
			num = (short)934084609;
			if (num != 0)
			{
			}
			int num4;
			global::Motorola.Common.CustomException.Cps2Exception._offsetOfErrorCodes.TryGetValue(type, out num4);
			return errorCode + num4;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004940 File Offset: 0x00002B40
		// Note: this type is marked as 'beforefieldinit'.
		static Cps2Exception()
		{
			short num = (short)519248700;
			short num2 = num;
			num = (short)1188830012;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1792212992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)632684545;
			if (num != 0)
			{
			}
			num = (short)724893696;
			if (num != 0)
			{
			}
			global::Motorola.Common.CustomException.Cps2Exception._offsetOfErrorCodes = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.CustomException.ErrorCodeType, int>
			{
				{
					global::Motorola.Common.CustomException.ErrorCodeType.Common,
					0
				},
				{
					global::Motorola.Common.CustomException.ErrorCodeType.Cps2AllPacs,
					1000000
				},
				{
					global::Motorola.Common.CustomException.ErrorCodeType.Pcr,
					1010000
				},
				{
					global::Motorola.Common.CustomException.ErrorCodeType.Astro,
					1020000
				}
			};
			global::Motorola.Common.CustomException.Cps2Exception._mapCommonAndCps2ErrorCode = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.CustomException.CommonErrorCode, global::Motorola.Common.CustomException.Cps2ErrorCodes>
			{
				{
					global::Motorola.Common.CustomException.CommonErrorCode.SPELLCHECK_FAILED_IN_COMPILE,
					global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_SpellCheck_Failed_In_Compile
				},
				{
					global::Motorola.Common.CustomException.CommonErrorCode.ValidateFieldsFailure,
					global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Validate_Fields_Failure
				},
				{
					global::Motorola.Common.CustomException.CommonErrorCode.CLI_FAILED_INITIALIZE_LICENSING,
					global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Cli_Failed_Initialize_Licensing
				},
				{
					global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Already_Registered,
					global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Device_Lic_Already_Registered
				},
				{
					global::Motorola.Common.CustomException.CommonErrorCode.CMDCPS_CRUNCHER_IMPORT_ARCHIVE_CONFIGMODE_FAILED,
					global::Motorola.Common.CustomException.Cps2ErrorCodes.CPS2_Import_Ctb_Archive_Failed
				}
			};
			global::Motorola.Common.CustomException.Cps2Exception._mapCommonAndPcrCps2ErrorCode = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.CustomException.CommonErrorCode, global::Motorola.Common.CustomException.PcrCps2ErrorCodes>
			{
				{
					global::Motorola.Common.CustomException.CommonErrorCode.RMC_Not_Support_PhoenixRadio,
					global::Motorola.Common.CustomException.PcrCps2ErrorCodes.CPS2_Phoenix_Radio_Not_Supported
				}
			};
		}

		// Token: 0x04000AFB RID: 2811
		private static readonly global::System.Collections.Generic.Dictionary<global::Motorola.Common.CustomException.ErrorCodeType, int> _offsetOfErrorCodes;

		// Token: 0x04000AFC RID: 2812
		private static readonly global::System.Collections.Generic.Dictionary<global::Motorola.Common.CustomException.CommonErrorCode, global::Motorola.Common.CustomException.Cps2ErrorCodes> _mapCommonAndCps2ErrorCode;

		// Token: 0x04000AFD RID: 2813
		private static readonly global::System.Collections.Generic.Dictionary<global::Motorola.Common.CustomException.CommonErrorCode, global::Motorola.Common.CustomException.PcrCps2ErrorCodes> _mapCommonAndPcrCps2ErrorCode;

		// Token: 0x04000AFF RID: 2815
		private int _refErrorCode;

		// Token: 0x04000B01 RID: 2817
		private string _refResourceId;

		// Token: 0x04000B05 RID: 2821
		private string _message;
	}
}
