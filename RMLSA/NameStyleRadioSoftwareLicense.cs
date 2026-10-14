using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x02000009 RID: 9
	public class NameStyleRadioSoftwareLicense : global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003658 File Offset: 0x00001858
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00003708 File Offset: 0x00001908
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)938868737;
				if (num != 0)
				{
				}
				num = (short)1204092928;
				short num2 = num;
				num = (short)232596123;
				short num3 = num;
				num = (short)1568547483;
				switch (num3 == num)
				{
				}
				num = (short)512032768;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1289573755;
				short num2 = num;
				num = (short)1669289339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)790036480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109341696;
				if (num != 0)
				{
				}
				num = (short)443285505;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000037B8 File Offset: 0x000019B8
		public override bool IsSameLicense(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.NameStyleRadioSoftwareLicense nameStyleRadioSoftwareLicense;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (string.Equals(this.Name, nameStyleRadioSoftwareLicense.Name, global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)976420870;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_D5;
				case 2:
				{
					num2 = (short)1780875264;
					short num3 = num2;
					if (nameStyleRadioSoftwareLicense == null)
					{
						num2 = (short)81788932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14C;
				}
				case 3:
					if (!string.IsNullOrWhiteSpace(this.Notice))
					{
						num2 = (short)1523253249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					return false;
				case 5:
					if (this == nameStyleRadioSoftwareLicense)
					{
						num2 = (short)1843986439;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1893597185;
					if (num2 != 0)
					{
					}
					num2 = (short)642056192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)709361667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)648332201;
					short num4 = num2;
					num2 = (short)561628073;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						goto IL_1CF;
					}
					break;
				}
				}
				goto IL_30;
				IL_14C:
				num2 = (short)657850373;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_D5:
			return this.Notice == nameStyleRadioSoftwareLicense.Notice;
			IL_1CF:
			num2 = (short)1056833536;
			if (num2 != 0)
			{
			}
			return true;
			IL_30:
			nameStyleRadioSoftwareLicense = (license as global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.NameStyleRadioSoftwareLicense);
			num2 = (short)1118240770;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000039AC File Offset: 0x00001BAC
		public override bool CanValidateResponseByAID
		{
			get
			{
				short num = (short)1696936313;
				short num2 = num;
				num = (short)1153053049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76087296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1056243713;
				if (num != 0)
				{
				}
				num = (short)1862926336;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003A58 File Offset: 0x00001C58
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00003B04 File Offset: 0x00001D04
		public string Notice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1049506539;
				short num2 = num;
				num = (short)1344221931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)716701696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512360449;
				if (num != 0)
				{
				}
				num = (short)233111552;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)550478115;
				short num2 = num;
				num = (short)476487971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207762944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844627969;
				if (num != 0)
				{
				}
				num = (short)405012480;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new string b;
	}
}
