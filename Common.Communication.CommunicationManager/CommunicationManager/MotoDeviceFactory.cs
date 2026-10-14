using System;
using System.Collections.Generic;
using System.Linq;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000034 RID: 52
	public class MotoDeviceFactory
	{
		// Token: 0x06000127 RID: 295 RVA: 0x000180E0 File Offset: 0x000162E0
		public MotoDeviceFactory(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.IDeviceFactory> radioFactories)
		{
			this.a = radioFactories;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000180FC File Offset: 0x000162FC
		public bool CreateDevice(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList)
		{
			short num = (short)1972895744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.IDeviceFactory> enumerator;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (hwProfileList != null)
						{
							num = (short)1347682306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_11A;
					case 2:
					{
						string PID = hwProfileList[0].PID;
						num = (short)598867971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.IDeviceFactory> source = this.a;
						global::System.Func<global::Motorola.Common.Communication.IDeviceFactory, bool> predicate;
						if ((predicate = CS$<>8__locals1.<>9__0) == null)
						{
							predicate = (CS$<>8__locals1.<>9__0 = delegate(global::Motorola.Common.Communication.IDeviceFactory factory)
							{
								short num5 = (short)647969433;
								short num6 = num5;
								num5 = (short)759839385;
								switch (num6 == num5)
								{
								}
								num5 = (short)473300993;
								if (num5 != 0)
								{
								}
								num5 = (short)1009385472;
								short num7 = num5;
								num5 = (short)395706368;
								if (num5 != 0)
								{
								}
								return factory.IsSupport(CS$<>8__locals1.PID);
							});
						}
						enumerator = source.Where(predicate).GetEnumerator();
						num = (short)1600126977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3F;
				}
				IL_11A:
				num = (short)1241710592;
				short num3 = num;
				try
				{
					num = (short)1265041409;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)927727622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1605763077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_189;
							}
							continue;
						case 2:
							goto IL_1A3;
						case 3:
						{
							num = (short)331946906;
							short num4 = num;
							num = (short)2069633946;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E3;
							default:
								goto IL_26E;
							}
							break;
						}
						case 4:
							goto IL_1E3;
						case 5:
							if (enumerator.Current.CreateRadios(out radioList, hwProfileList))
							{
								num = (short)1421934596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							num = (short)167641091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
						IL_1E3:
						result = true;
						num = (short)681639938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E5:
						num = (short)1313472512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_189:
						goto IL_1E5;
					}
					IL_1A3:
					return result;
					IL_26E:
					num = (short)6094848;
					if (num != 0)
					{
					}
				}
				finally
				{
					num = (short)693239809;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)154075138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2B9;
							}
							continue;
						case 2:
							goto IL_2F0;
						}
						IL_2B9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)326303744;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2F0:;
				}
				return false;
				IL_3F:
				radioList = null;
				num = (short)1195507713;
				if (num != 0)
				{
				}
				num = (short)796721152;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0400004C RID: 76
		private readonly global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.IDeviceFactory> a;
	}
}
