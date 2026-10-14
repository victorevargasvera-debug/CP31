using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000020 RID: 32
	public class OperationInfo
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0001175C File Offset: 0x0000F95C
		public string OperationType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1854885862;
				short num2 = num;
				num = (short)2059489254;
				switch (num2 == num)
				{
				}
				num = (short)1361903617;
				if (num != 0)
				{
				}
				num = (short)1740308480;
				if (num != 0)
				{
				}
				num = (short)1916338176;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0001180C File Offset: 0x0000FA0C
		internal string StampName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1278606634;
				short num2 = num;
				num = (short)2112486698;
				switch (num2 == num)
				{
				}
				num = (short)845807617;
				if (num != 0)
				{
				}
				num = (short)493092864;
				if (num != 0)
				{
				}
				num = (short)2045902848;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000118BC File Offset: 0x0000FABC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0001196C File Offset: 0x0000FB6C
		internal global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationParameters Parameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1875626959;
				short num2 = num;
				num = (short)1333513167;
				switch (num2 == num)
				{
				}
				num = (short)129368065;
				if (num != 0)
				{
				}
				num = (short)628424704;
				if (num != 0)
				{
				}
				num = (short)1435828224;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1534095484;
				short num2 = num;
				num = (short)1332637820;
				switch (num2 == num)
				{
				}
				num = (short)1871642624;
				if (num != 0)
				{
				}
				num = (short)907018241;
				if (num != 0)
				{
				}
				num = (short)784531456;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00011A20 File Offset: 0x0000FC20
		public OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType type, string stampName = null) : this(type.ToString(), stampName)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00011A44 File Offset: 0x0000FC44
		public OperationInfo(string type, string stampName = null)
		{
			this.a = type;
			this.b = (string.IsNullOrEmpty(stampName) ? this.OperationType : stampName);
			this.Parameters = new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationParameters();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00011A84 File Offset: 0x0000FC84
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo AddOrUpdateParameter(string category, string value)
		{
			short num = (short)696778754;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)508887041;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_97;
				case 1:
					this.Parameters = new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationParameters();
					num = (short)16777216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				if (this.Parameters != null)
				{
					break;
				}
				num = (short)976945153;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_97:
			num = (short)704356278;
			short num3 = num;
			num = (short)156737462;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_97;
			case 1:
				break;
			default:
			{
				num = (short)1361182720;
				short num4 = num;
				break;
			}
			}
			num = (short)763887616;
			if (num != 0)
			{
			}
			category = global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo.FormatCategory(category);
			this.Parameters.AddOrUpdateParameter(category, value);
			return this;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo Fail(global::System.Exception ex)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return this;
				case 1:
				{
					num2 = (short)1500315649;
					if (num2 != 0)
					{
					}
					num2 = (short)1831002218;
					short num3 = num2;
					num2 = (short)1745870954;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return this;
					default:
					{
						num2 = (short)1051394048;
						if (num2 != 0)
						{
						}
						num2 = (short)875102208;
						short num4 = num2;
						this.AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("Ⅳᑥᩧթṫ⍭ᕯűݳ᝵ίό", a_), ex.Message).AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㝣ብ१३ݫ㩭ɯ፱ᝳ፵", a_), ex.StackTrace);
						num2 = (short)1310326784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (ex != null)
					{
						num2 = (short)554303489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return this;
				}
				goto IL_25;
			}
			return this;
			IL_25:
			this.AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ⵣᕥ㭧Ὡཫ൭ᕯűݳၵ൷ᙹ", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("≣ݥѧᥩ५", a_));
			num2 = (short)1876754434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00011D24 File Offset: 0x0000FF24
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo Success(string SuccessfulMessage = "", string FinalNotificationMessage = "")
		{
			int a_ = 3;
			short num = (short)454433440;
			short num2 = num;
			num = (short)303831712;
			switch (num2 == num)
			{
			}
			num = (short)696057856;
			if (num != 0)
			{
			}
			num = (short)1516961793;
			if (num != 0)
			{
			}
			num = (short)1537933312;
			short num3 = num;
			this.AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("Ṗ⩘࡚⡜㱞ɠ٢ᙤᑦཨṪŬ", a_), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("͖⭘⹚㡜", a_)).AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("іⱘ㡚㹜㩞በၢͤቦը♪࡬ᱮɰቲቴቶ", a_), SuccessfulMessage).AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᥖ㙘⽚㑜㥞ࡠbѤ፦hѪͬ≮ᑰrٴᙶṸṺ", a_), FinalNotificationMessage);
			return this;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00011E20 File Offset: 0x00010020
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo AddDeviceInfoToParameters(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 13;
			short num = (short)1357413286;
			short num2 = num;
			num = (short)387021734;
			switch (num2 == num)
			{
			}
			num = (short)1780613120;
			if (num != 0)
			{
			}
			num = (short)933756929;
			if (num != 0)
			{
			}
			num = (short)1183121408;
			short num3 = num;
			this.AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㉠٢ᝤ๦ࡨݪ⍬ᩮᱰᅲၴն", a_), deviceInfo.SerialNumber).AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ⱠౢŤɦը╪ᡬɮ፰ᙲݴ", a_), deviceInfo.ModelNumber + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㹠", a_) + deviceInfo.TanapaNumber).AddOrUpdateParameter(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("≠ౢŤɦᥨݪᡬ࡮❰ᙲݴѶၸᑺ፼", a_), deviceInfo.CodeplugVersion);
			return this;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00011F38 File Offset: 0x00010138
		public static string FormatCategory(string original)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			global::System.Text.RegularExpressions.Match match;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1F5;
				case 1:
					if (match != null)
					{
						num2 = (short)1437138947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 2:
					goto IL_66;
				case 3:
				{
					num2 = (short)1434572996;
					short num3 = num2;
					num2 = (short)1046468804;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)595787776;
						if (num2 != 0)
						{
						}
						num2 = (short)2086469632;
						short num4 = num2;
						num2 = (short)1518600196;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
				{
					if (!match.Success)
					{
						num2 = (short)1022820352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = text + match.Value + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䕤", a_);
					int num5 = match.Index + match.Length;
					num2 = (short)1796341766;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_66;
				case 6:
				{
					int num5;
					if (num5 < original.Length)
					{
						num2 = (short)374603783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					match = null;
					num2 = (short)595394565;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)1133838337;
					if (num2 != 0)
					{
					}
					int num5;
					original = original.Substring(num5);
					match = global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo.d.Match(original);
					num2 = (short)1479213058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_66;
				}
				goto IL_3D;
				IL_66:
				num2 = (short)1980628993;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1F5:
			IL_228:
			text = text.Trim();
			return text;
			IL_3D:
			text = string.Empty;
			match = global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo.d.Match(original);
			num2 = (short)317390856;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00012178 File Offset: 0x00010378
		public override bool Equals(object obj)
		{
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			short num;
			int num3;
			global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo;
			for (;;)
			{
				IL_0A:
				num = (short)1679894102;
				short num2 = num;
				num = (short)1397237334;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F7;
				default:
					num = (short)1557004289;
					if (num != 0)
					{
					}
					num = (short)1801388032;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_14A;
					case 1:
					{
						num = (short)679215104;
						short num4 = num;
						num = (short)1000472578;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.OperationType.Equals(operationInfo.OperationType))
						{
							num = (short)48824320;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (operationInfo != null)
						{
							num = (short)733413377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_91;
				}
			}
			IL_F7:
			return this.StampName.Equals(operationInfo.StampName);
			IL_14A:
			goto IL_F7;
			IL_91:
			operationInfo = (obj as global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo);
			num = (short)1579024387;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000122D4 File Offset: 0x000104D4
		public override int GetHashCode()
		{
			short num = (short)35575110;
			short num2 = num;
			num = (short)1322046790;
			switch (num2 == num)
			{
			}
			num = (short)1084751872;
			if (num != 0)
			{
			}
			num = (short)1684013057;
			if (num != 0)
			{
			}
			num = (short)1751121920;
			short num3 = num;
			return (-1824341477 * -1521134295 + this.OperationType.GetHashCode()) * -1521134295 + this.StampName.GetHashCode();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000123A8 File Offset: 0x000105A8
		// Note: this type is marked as 'beforefieldinit'.
		static OperationInfo()
		{
			int a_ = 18;
			short num = (short)1195537931;
			short num2 = num;
			num = (short)1328444939;
			switch (num2 == num)
			{
			}
			num = (short)1942618113;
			if (num != 0)
			{
			}
			num = (short)786235392;
			if (num != 0)
			{
			}
			num = (short)412942336;
			short num3 = num;
			global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo.d = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("乥㙧ㅩ൫䍭੯㍱女Ⱶ╷ٹ❻㽽굿\ud881\ud983꾅펇ꆋ쾏ꊑ릓꾕얗낙", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline);
		}

		// Token: 0x04000079 RID: 121
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x0400007A RID: 122
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;

		// Token: 0x0400007B RID: 123
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationParameters c;

		// Token: 0x0400007C RID: 124
		private static readonly global::System.Text.RegularExpressions.Regex d;

		// Token: 0x02000021 RID: 33
		public class CommonParameters
		{
			// Token: 0x0400007D RID: 125
			public const string CodeplugVersion = "CodeplugVersion";

			// Token: 0x0400007E RID: 126
			public const string SerialNumber = "SerialNumber";

			// Token: 0x0400007F RID: 127
			public const string FilePath = "FilePath";

			// Token: 0x04000080 RID: 128
			public const string ModelNumber = "ModelNumber";

			// Token: 0x04000081 RID: 129
			public const string RegionName = "RegionName";

			// Token: 0x04000082 RID: 130
			public const string IsSuccessful = "IsSuccessful";

			// Token: 0x04000083 RID: 131
			public const string StackTrace = "StackTrace";

			// Token: 0x04000084 RID: 132
			public const string ErrorMessage = "ErrorMessage";

			// Token: 0x04000085 RID: 133
			public const string FeatureDisplayName = "FeatureDisplayName";

			// Token: 0x04000086 RID: 134
			public const string TargetFirmware = "TargetFirmware";

			// Token: 0x04000087 RID: 135
			public const string TargetCodeplug = "TargetCodeplug";

			// Token: 0x04000088 RID: 136
			public const string SuccessfulMessage = "SuccessfulMessage";

			// Token: 0x04000089 RID: 137
			public const string NotificationMessage = "NotificationMessage";

			// Token: 0x0400008A RID: 138
			public const string ReportType = "ReportType";
		}
	}
}
