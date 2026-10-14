using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000078 RID: 120
	public class RadioLicenseRadioSubViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000387 RID: 903 RVA: 0x00053F54 File Offset: 0x00052154
		public RadioLicenseRadioSubViewProvider(global::System.Guid radioUuid, int fType = 0)
		{
			this.a = radioUuid;
			this.b = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatureDetailsByRadio(this.a, 0);
			this.c = fType;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00053F90 File Offset: 0x00052190
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			int a_ = 8;
			short num = (short)321454080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				global::System.Diagnostics.Stopwatch stopwatch;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> list;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> enumerator;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						num = (short)2078932993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (length >= this.GetTotalCount())
						{
							stopwatch = new global::System.Diagnostics.Stopwatch();
							stopwatch.Start();
							global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> radioFeatureDetailsByRadio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatureDetailsByRadio(this.a, this.c);
							list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
							enumerator = radioFeatureDetailsByRadio.GetEnumerator();
							num = (short)1010892803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)22349172;
						short num3 = num;
						num = (short)385615220;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_66;
						default:
						{
							num = (short)1617297408;
							if (num != 0)
							{
							}
							num = (short)840892416;
							short num4 = num;
							num = (short)1469841412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_66;
					case 3:
						goto IL_CC;
					case 4:
						goto IL_17F;
					}
					goto IL_4D;
					IL_66:
					if (startIndex != 0)
					{
						goto IL_31B;
					}
					num = (short)1011417088;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CC:
				try
				{
					num = (short)2104754180;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1449787394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.ConvertLicenseSummaryToLicense(summary);
							num = (short)1649278979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_2AB;
						case 2:
							num = (short)1139802113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase;
							if (radioLicenseBase != null)
							{
								num = (short)1207762950;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_1E8;
							}
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase;
							list.Add(radioLicenseBase);
							num = (short)1223688197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1EA:
						num = (short)329646080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E8:
						goto IL_1EA;
					}
					IL_2AB:
					goto IL_181;
				}
				finally
				{
					num = (short)826867712;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2E2;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)596574210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_318;
						}
						IL_2E2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)976420865;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_318:;
				}
				goto IL_31B;
				IL_181:
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
				IL_17F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瀡䔣䈥䄧䔩怫䜭匯圱娳䔵崷根崻娽⤿ⵁᝃ㍅⩇᱉╋⭍❏ɑ♓㥕⹗㍙㡛㭝቟乡䑣੥൧ѩ୫ᩭᡯ剱䡳噵੷᭹᡻᝽ꊁﺉ曆ﲍ늑秊", a_));
				IL_31B:
				num = (short)39845889;
				if (num != 0)
				{
				}
				return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
				IL_4D:
				milliseconds = 0;
				num = (short)1813446658;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00054304 File Offset: 0x00052504
		public int GetTotalCount()
		{
			short num = (short)628129620;
			short num2 = num;
			num = (short)688160596;
			switch (num2 == num)
			{
			default:
			{
				num = (short)661651456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)162922496;
			if (num != 0)
			{
			}
			num = (short)1597571073;
			if (num != 0)
			{
			}
			return this.b.Count;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000543B8 File Offset: 0x000525B8
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase item)
		{
			short num = (short)2082300901;
			short num2 = num;
			num = (short)483419109;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1170407424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1971978240;
			if (num != 0)
			{
			}
			num = (short)1160839169;
			if (num != 0)
			{
			}
			item.Validator = null;
		}

		// Token: 0x040000A8 RID: 168
		private global::System.Guid a;

		// Token: 0x040000A9 RID: 169
		private global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> b;

		// Token: 0x040000AA RID: 170
		private int c;
	}
}
