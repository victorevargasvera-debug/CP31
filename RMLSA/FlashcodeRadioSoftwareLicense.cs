using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x02000003 RID: 3
	public class FlashcodeRadioSoftwareLicense : global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)933493964;
				short num2 = num;
				num = (short)1658584268;
				switch (num2 == num)
				{
				}
				num = (short)454361089;
				if (num != 0)
				{
				}
				num = (short)995753984;
				short num3 = num;
				num = (short)1025638400;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)895029176;
				short num2 = num;
				num = (short)2113343416;
				switch (num2 == num)
				{
				}
				num = (short)268304385;
				if (num != 0)
				{
				}
				num = (short)1983250432;
				short num3 = num;
				num = (short)805699584;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000232C File Offset: 0x0000052C
		public string SourceFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1332500075;
				short num2 = num;
				num = (short)799233643;
				switch (num2 == num)
				{
				}
				num = (short)2067005440;
				if (num != 0)
				{
				}
				num = (short)100073472;
				short num3 = num;
				num = (short)325451777;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1380165138;
				short num2 = num;
				num = (short)1682286098;
				switch (num2 == num)
				{
				}
				num = (short)364183553;
				if (num != 0)
				{
				}
				num = (short)1132331008;
				short num3 = num;
				num = (short)1806893056;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023DC File Offset: 0x000005DC
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000248C File Offset: 0x0000068C
		public string TargetFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2009344832;
				short num2 = num;
				num = (short)275983168;
				switch (num2 == num)
				{
				}
				num = (short)399114241;
				if (num != 0)
				{
				}
				num = (short)2042888192;
				short num3 = num;
				num = (short)928776192;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)337870689;
				short num2 = num;
				num = (short)1695776609;
				switch (num2 == num)
				{
				}
				num = (short)1449394177;
				if (num != 0)
				{
				}
				num = (short)460193792;
				short num3 = num;
				num = (short)829685760;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002538 File Offset: 0x00000738
		public override bool IsSameLicense(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license)
		{
			int num;
			global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense flashcodeRadioSoftwareLicense;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (string.Equals(this.SourceFlashCode, flashcodeRadioSoftwareLicense.SourceFlashCode, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num2 = (short)1468268545;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 1:
						goto IL_AE;
					case 2:
						if (string.Equals(this.ModelNumber, flashcodeRadioSoftwareLicense.ModelNumber, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num2 = (short)441450501;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 3:
						return false;
					case 4:
						return true;
					case 5:
					{
						num2 = (short)992739328;
						short num3 = num2;
						num2 = (short)312111882;
						short num4 = num2;
						num2 = (short)1583969034;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							num2 = (short)966656000;
							if (num2 != 0)
							{
							}
							num2 = (short)877658112;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 6:
						if (flashcodeRadioSoftwareLicense == null)
						{
							num2 = (short)2085879811;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)227147783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (this == flashcodeRadioSoftwareLicense)
						{
							num2 = (short)1601568772;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)708575234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30;
				}
				return false;
				IL_AE:
				num2 = (short)1513226241;
				if (num2 != 0)
				{
				}
				return string.Equals(this.TargetFlashCode, flashcodeRadioSoftwareLicense.TargetFlashCode, global::System.StringComparison.OrdinalIgnoreCase);
			}
			IL_30:
			flashcodeRadioSoftwareLicense = (license as global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense);
			IL_37:
			num2 = (short)249495558;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000272C File Offset: 0x0000092C
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> GenerateActivationInfo()
		{
			int a_ = 2;
			short num = (short)1080885248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				int num3;
				string[] array;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> list;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_B3;
					case 1:
					{
						if (num3 < array.Length)
						{
							num = (short)1258029056;
							short num4 = num;
							string aid = array[num3];
							global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation item = base.GenerateActivationInfo(aid);
							list.Add(item);
							num3++;
							num = (short)1887764480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1084450637;
						short num5 = num;
						num = (short)511207245;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_89;
						default:
							num = (short)1312096256;
							if (num != 0)
							{
							}
							num = (short)415629315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_89;
					case 3:
						return list;
					}
					goto IL_47;
					IL_B3:
					num = (short)723451905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89:
					num = (short)1411579905;
					if (num != 0)
					{
					}
					goto IL_B3;
				}
				return list;
				IL_47:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation>();
				array = base.AID.Split(new string[]
				{
					global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense.b("䍷", a_)
				}, global::System.StringSplitOptions.RemoveEmptyEntries);
				num3 = 0;
				num = (short)319291394;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000028D0 File Offset: 0x00000AD0
		public override bool CanValidateResponseByAID
		{
			get
			{
				short num = (short)890610597;
				short num2 = num;
				num = (short)400532389;
				switch (num2 == num)
				{
				}
				num = (short)855965697;
				if (num != 0)
				{
				}
				num = (short)400359424;
				short num3 = num;
				num = (short)1992163328;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x04000003 RID: 3
		internal const string a = ";";

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new string b;

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;
	}
}
