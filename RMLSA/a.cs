using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x02000005 RID: 5
	internal class a : global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.d
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002D0C File Offset: 0x00000F0C
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> a(global::Motorola.CommonCPS.Server.EntityModel.EntitlementList A_0, string A_1)
		{
			short num = (short)1940557197;
			short num2 = num;
			num = (short)1351912845;
			switch (num2 == num)
			{
			}
			num = (short)1016135681;
			if (num != 0)
			{
			}
			num = (short)1594359808;
			short num3 = num;
			num = (short)1896939520;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> a_ = base.a(A_0, A_1);
			return this.a(a_);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002DC8 File Offset: 0x00000FC8
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> A_0)
		{
			int a_ = 17;
			short num = (short)1230789364;
			short num2 = num;
			num = (short)1755142900;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)588906496;
				short num3 = num;
				num = (short)162136065;
				if (num != 0)
				{
				}
				num = (short)1176371200;
				if (num != 0)
				{
				}
				num = (short)757399552;
				switch (num)
				{
				}
				break;
			}
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense>.Enumerator enumerator = A_0.GetEnumerator())
			{
				num = (short)952238082;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)220069895;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1516634112;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.a.a a = new global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.a.a();
						a.a = enumerator.Current;
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense radioEntitledLicense = list.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense, bool>(a.b));
						num = (short)1467416580;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_115;
						}
						continue;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.a.a a;
						list.Add(a.a);
						num = (short)836239366;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense radioEntitledLicense;
						if (radioEntitledLicense == null)
						{
							num = (short)2112684035;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license = radioEntitledLicense.License;
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.a.a a;
						license.AID = license.AID + global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense.b("벆", a_) + a.a.License.AID;
						num = (short)110493701;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_240;
					}
					IL_16F:
					num = (short)1740701697;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_115:
					goto IL_16F;
				}
				IL_240:;
			}
			return list;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003044 File Offset: 0x00001244
		protected override global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense b(global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem A_0)
		{
			short num = (short)441039568;
			short num2 = num;
			num = (short)1267776208;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1420558336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)196739072;
			if (num != 0)
			{
			}
			num = (short)234356737;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense
			{
				ModelNumber = A_0.modelNumber,
				SourceFlashCode = A_0.currentFlashCode,
				TargetFlashCode = A_0.newFlashCode,
				AID = A_0.activationId
			};
		}

		// Token: 0x02000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new sealed class a
		{
			// Token: 0x06000021 RID: 33 RVA: 0x0000359C File Offset: 0x0000179C
			internal bool b(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense A_0)
			{
				short num = (short)798223791;
				short num2 = num;
				num = (short)1631251887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142226944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454557697;
				if (num != 0)
				{
				}
				num = (short)29818880;
				if (num != 0)
				{
				}
				return A_0.License.IsSameLicense(this.a.License);
			}

			// Token: 0x04000008 RID: 8
			public global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense a;
		}
	}
}
