using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using ASK.Interface;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A0 RID: 160
	public class RMCExportInterface : global::Motorola.CommonCPS.RadioManagement.SharedServices.IRMCExportInterface
	{
		// Token: 0x06000921 RID: 2337 RVA: 0x00066BF4 File Offset: 0x00064DF4
		static RMCExportInterface()
		{
			short num = (short)1600317107;
			short num2 = num;
			num = (short)283895475;
			switch (num2 == num)
			{
			}
			num = (short)413663233;
			if (num != 0)
			{
			}
			num = (short)1028587520;
			short num3 = num;
			num = (short)480641024;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.a = new global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface();
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00066CA8 File Offset: 0x00064EA8
		private RMCExportInterface()
		{
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000923 RID: 2339 RVA: 0x00066CBC File Offset: 0x00064EBC
		// (remove) Token: 0x06000924 RID: 2340 RVA: 0x00066DF4 File Offset: 0x00064FF4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> ImportDeviceEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
						{
							num2 = (short)780164279;
							short num3 = num2;
							num2 = (short)13393079;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)714473472;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)1764425728;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_5F;
							}
							break;
						}
						case 2:
							goto IL_5F;
						}
						break;
						IL_5F:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)329383936;
						short num4 = num2;
						num2 = (short)188743681;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					num2 = (short)1134362625;
					if (num2 != 0)
					{
					}
					eventHandler = this.b;
					num2 = (short)81133570;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_FA;
						case 1:
						{
							num2 = (short)2091974656;
							short num3 = num2;
							num2 = (short)1785785599;
							short num4 = num2;
							num2 = (short)558165247;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1292959744;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)1040384000;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39;
							}
							break;
						}
						case 2:
							goto IL_39;
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)1867317249;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.b;
					num2 = (short)359137282;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FA:
				num2 = (short)433389569;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000925 RID: 2341 RVA: 0x00066F28 File Offset: 0x00065128
		// (remove) Token: 0x06000926 RID: 2342 RVA: 0x0006705C File Offset: 0x0006525C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> ImportTemplateEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_FE;
						case 1:
						{
							num2 = (short)2106654720;
							short num3 = num2;
							num2 = (short)528325319;
							short num4 = num2;
							num2 = (short)1740610247;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)850198528;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)362217472;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_3B;
							}
							break;
						}
						case 2:
							goto IL_3B;
						}
						break;
						IL_3B:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>>(ref this.c, value2, eventHandler2);
						num2 = (short)542441473;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.c;
					num2 = (short)974520322;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FE:
				num2 = (short)790888449;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_FC;
						case 1:
						{
							num2 = (short)67305472;
							short num3 = num2;
							num2 = (short)509285297;
							short num4 = num2;
							num2 = (short)554701745;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2077425664;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)285802496;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39;
							}
							break;
						}
						case 2:
							goto IL_39;
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>>(ref this.c, value2, eventHandler2);
						num2 = (short)997392385;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.c;
					num2 = (short)883687426;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FC:
				num2 = (short)1726218241;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000927 RID: 2343 RVA: 0x00067190 File Offset: 0x00065390
		// (remove) Token: 0x06000928 RID: 2344 RVA: 0x000672CC File Offset: 0x000654CC
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> ExportDeviceEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
						{
							num2 = (short)510390037;
							short num3 = num2;
							num2 = (short)2077617941;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)689897472;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)11927552;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_61;
							}
							break;
						}
						case 2:
							goto IL_61;
						}
						break;
						IL_61:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs>>(ref this.d, value2, eventHandler2);
						num2 = (short)57278464;
						short num4 = num2;
						num2 = (short)1071382529;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					num2 = (short)2002321409;
					if (num2 != 0)
					{
					}
					eventHandler = this.d;
					num2 = (short)1671168002;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
						{
							num2 = (short)47448065;
							if (num2 != 0)
							{
							}
							num2 = (short)1589161684;
							short num3 = num2;
							num2 = (short)70364884;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2086731776;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)391970816;
									short num4 = num2;
									num2 = (short)980418560;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_3A;
							}
							break;
						}
						case 2:
							goto IL_3A;
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs>>(ref this.d, value2, eventHandler2);
						num2 = (short)1996619777;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.d;
					num2 = (short)1724055554;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000929 RID: 2345 RVA: 0x000673FC File Offset: 0x000655FC
		// (remove) Token: 0x0600092A RID: 2346 RVA: 0x0006752C File Offset: 0x0006572C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> ExportDVRSEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_D1;
						case 1:
							goto IL_3A;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_3A;
							}
							num2 = (short)729841894;
							short num3 = num2;
							num2 = (short)614760678;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1258815488;
								if (num2 != 0)
								{
								}
								num2 = (short)423886848;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs>>(ref this.e, value2, eventHandler2);
						num2 = (short)180027394;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.e;
					num2 = (short)982122497;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_D1:
				num2 = (short)2038956032;
				short num4 = num2;
				num2 = (short)2102263809;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)493581219;
							short num3 = num2;
							num2 = (short)2050061219;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)31981568;
								if (num2 != 0)
								{
								}
								num2 = (short)1754726401;
								if (num2 != 0)
								{
								}
								num2 = (short)1516568576;
								short num4 = num2;
								num2 = (short)526123008;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs>>(ref this.e, value2, eventHandler2);
						num2 = (short)964886530;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.e;
					num2 = (short)331087873;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x0600092B RID: 2347 RVA: 0x0006765C File Offset: 0x0006585C
		// (remove) Token: 0x0600092C RID: 2348 RVA: 0x00067794 File Offset: 0x00065994
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> EditTemplateEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							num2 = (short)1577058305;
							if (num2 != 0)
							{
							}
							goto IL_61;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_61;
							}
							num2 = (short)33345437;
							short num3 = num2;
							num2 = (short)1104269213;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)1438973952;
								if (num2 != 0)
								{
								}
								num2 = (short)483262464;
								short num4 = num2;
								num2 = (short)586809344;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_61:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs>>(ref this.f, value2, eventHandler2);
						num2 = (short)256770050;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.f;
					num2 = (short)580386817;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)2000345561;
							short num3 = num2;
							num2 = (short)264100313;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)2102001664;
								if (num2 != 0)
								{
								}
								num2 = (short)560136192;
								short num4 = num2;
								num2 = (short)587857920;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs>>(ref this.f, value2, eventHandler2);
						num2 = (short)81592321;
						if (num2 != 0)
						{
						}
						num2 = (short)965410818;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.f;
					num2 = (short)72155137;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x0600092D RID: 2349 RVA: 0x000678CC File Offset: 0x00065ACC
		// (remove) Token: 0x0600092E RID: 2350 RVA: 0x00067A00 File Offset: 0x00065C00
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> AstroCompatibilityCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							num2 = (short)2041053185;
							if (num2 != 0)
							{
							}
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)694686914;
							short num3 = num2;
							num2 = (short)1115100354;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)229703680;
								if (num2 != 0)
								{
								}
								num2 = (short)2142568448;
								short num4 = num2;
								num2 = (short)489947136;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs>>(ref this.g, value2, eventHandler2);
						num2 = (short)49348610;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.g;
					num2 = (short)1354629121;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_3A;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_3A;
							}
							num2 = (short)1645543425;
							if (num2 != 0)
							{
							}
							num2 = (short)1383699033;
							short num3 = num2;
							num2 = (short)1929220697;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)891879424;
								if (num2 != 0)
								{
								}
								num2 = (short)1288372224;
								short num4 = num2;
								num2 = (short)427425792;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs>>(ref this.g, value2, eventHandler2);
						num2 = (short)861667330;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.g;
					num2 = (short)1274085377;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x0600092F RID: 2351 RVA: 0x00067B38 File Offset: 0x00065D38
		// (remove) Token: 0x06000930 RID: 2352 RVA: 0x00067C6C File Offset: 0x00065E6C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> AstroWritingCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_61;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_61;
							}
							num2 = (short)1488747788;
							short num3 = num2;
							num2 = (short)1026522380;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)905379840;
								if (num2 != 0)
								{
								}
								num2 = (short)112132096;
								short num4 = num2;
								num2 = (short)948699136;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_61:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs>>(ref this.h, value2, eventHandler2);
						num2 = (short)2061959170;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					num2 = (short)1299185665;
					if (num2 != 0)
					{
					}
					eventHandler = this.h;
					num2 = (short)1921449985;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)1568846205;
							short num3 = num2;
							num2 = (short)1585492349;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)1148125185;
								if (num2 != 0)
								{
								}
								num2 = (short)1754398720;
								if (num2 != 0)
								{
								}
								num2 = (short)72155136;
								short num4 = num2;
								num2 = (short)1661206528;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs>>(ref this.h, value2, eventHandler2);
						num2 = (short)294649858;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.h;
					num2 = (short)1166213121;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000931 RID: 2353 RVA: 0x00067DA0 File Offset: 0x00065FA0
		// (remove) Token: 0x06000932 RID: 2354 RVA: 0x00067ED0 File Offset: 0x000660D0
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> AstroReadFlashKeyEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)1070197114;
							short num3 = num2;
							num2 = (short)790358394;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)2019753985;
								if (num2 != 0)
								{
								}
								num2 = (short)1459421184;
								if (num2 != 0)
								{
								}
								num2 = (short)868941824;
								short num4 = num2;
								num2 = (short)62128128;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>>(ref this.i, value2, eventHandler2);
						num2 = (short)919994370;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.i;
					num2 = (short)1629290497;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_3A;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_3A;
							}
							num2 = (short)1830278205;
							short num3 = num2;
							num2 = (short)1494406205;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)2084372481;
								if (num2 != 0)
								{
								}
								num2 = (short)689504256;
								if (num2 != 0)
								{
								}
								num2 = (short)389611520;
								short num4 = num2;
								num2 = (short)171966464;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>>(ref this.i, value2, eventHandler2);
						num2 = (short)247332866;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.i;
					num2 = (short)880279553;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000933 RID: 2355 RVA: 0x00068000 File Offset: 0x00066200
		// (remove) Token: 0x06000934 RID: 2356 RVA: 0x0006812C File Offset: 0x0006632C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> AstroValidateFlashKeyEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)1627944955;
							short num3 = num2;
							num2 = (short)433944571;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)1021050880;
								if (num2 != 0)
								{
								}
								num2 = (short)367198209;
								if (num2 != 0)
								{
								}
								num2 = (short)836173824;
								short num4 = num2;
								num2 = (short)1259601920;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>>(ref this.j, value2, eventHandler2);
						num2 = (short)2035679234;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.j;
					num2 = (short)469565441;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							num2 = (short)1531969537;
							if (num2 != 0)
							{
							}
							goto IL_62;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_62;
							}
							num2 = (short)1913934795;
							short num3 = num2;
							num2 = (short)886002635;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)1273102336;
								if (num2 != 0)
								{
								}
								num2 = (short)1505099776;
								short num4 = num2;
								num2 = (short)1356988416;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_62:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs>>(ref this.j, value2, eventHandler2);
						num2 = (short)1617231874;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.j;
					num2 = (short)1575813121;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000935 RID: 2357 RVA: 0x00068260 File Offset: 0x00066460
		// (remove) Token: 0x06000936 RID: 2358 RVA: 0x00068390 File Offset: 0x00066590
		public event global::System.EventHandler AstroReleaseFlashKeyEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_D2;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)1107958804;
							short num3 = num2;
							num2 = (short)498342932;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)212271104;
								if (num2 != 0)
								{
								}
								num2 = (short)1127219200;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.k, value2, eventHandler2);
						num2 = (short)979173378;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.k;
					num2 = (short)668860417;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_D2:
				num2 = (short)1103953920;
				short num4 = num2;
				num2 = (short)1903362049;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_D4;
						case 1:
							goto IL_3B;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_3B;
							}
							num2 = (short)440777795;
							short num3 = num2;
							num2 = (short)1199488067;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)391118848;
								if (num2 != 0)
								{
								}
								num2 = (short)1814953984;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						}
						break;
						IL_3B:
						eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.k, value2, eventHandler2);
						num2 = (short)2012741634;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.k;
					num2 = (short)573374465;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_D4:
				num2 = (short)1658126336;
				short num4 = num2;
				num2 = (short)1860108289;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000937 RID: 2359 RVA: 0x000684C4 File Offset: 0x000666C4
		// (remove) Token: 0x06000938 RID: 2360 RVA: 0x000685F4 File Offset: 0x000667F4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> AstroDecraseFlashKeyEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					short num = (short)337575937;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_43;
					}
					int num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> eventHandler;
					for (;;)
					{
						IL_31:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> eventHandler2;
						switch (num2)
						{
						case 0:
							return;
						case 1:
							goto IL_60;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_60;
							}
							num = (short)566365173;
							short num3 = num;
							num = (short)1896680437;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1872232448;
								if (num != 0)
								{
								}
								num = (short)885915648;
								short num4 = num;
								num = (short)1572405248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_60:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs>>(ref this.l, value2, eventHandler2);
						num = (short)678297602;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_43:
					eventHandler = this.l;
					num = (short)1813184513;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)329747664;
							short num3 = num2;
							num2 = (short)326929616;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)444989441;
								if (num2 != 0)
								{
								}
								num2 = (short)1559429120;
								if (num2 != 0)
								{
								}
								num2 = (short)1441136640;
								short num4 = num2;
								num2 = (short)789839872;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs>>(ref this.l, value2, eventHandler2);
						num2 = (short)580386818;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.l;
					num2 = (short)249888769;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000939 RID: 2361 RVA: 0x00068728 File Offset: 0x00066928
		// (remove) Token: 0x0600093A RID: 2362 RVA: 0x0006885C File Offset: 0x00066A5C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> AstroUpgradeCodeplugEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_D0;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)732096170;
							short num3 = num2;
							num2 = (short)721086122;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)496435200;
								if (num2 != 0)
								{
								}
								num2 = (short)404291584;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs>>(ref this.m, value2, eventHandler2);
						num2 = (short)1750466562;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.m;
					num2 = (short)1359216641;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_D0:
				num2 = (short)2039676928;
				short num4 = num2;
				num2 = (short)517079041;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_3A;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_3A;
							}
							num2 = (short)663574200;
							short num3 = num2;
							num2 = (short)1632917176;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)878051329;
								if (num2 != 0)
								{
								}
								num2 = (short)801767424;
								if (num2 != 0)
								{
								}
								num2 = (short)2008743936;
								short num4 = num2;
								num2 = (short)1716715520;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs>>(ref this.m, value2, eventHandler2);
						num2 = (short)988151810;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.m;
					num2 = (short)953090049;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600093B RID: 2363 RVA: 0x00068994 File Offset: 0x00066B94
		// (remove) Token: 0x0600093C RID: 2364 RVA: 0x00068AC8 File Offset: 0x00066CC8
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> AstroCheckHoptionEnableEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)417932813;
							short num3 = num2;
							num2 = (short)1571563021;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)912850945;
								if (num2 != 0)
								{
								}
								num2 = (short)1526988800;
								if (num2 != 0)
								{
								}
								num2 = (short)297009152;
								short num4 = num2;
								num2 = (short)194314240;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>>(ref this.n, value2, eventHandler2);
						num2 = (short)1677721602;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.n;
					num2 = (short)196345857;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)1442619495;
							short num3 = num2;
							num2 = (short)866623591;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)1471021056;
								if (num2 != 0)
								{
								}
								num2 = (short)315424769;
								if (num2 != 0)
								{
								}
								num2 = (short)1827209216;
								short num4 = num2;
								num2 = (short)2112618496;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>>(ref this.n, value2, eventHandler2);
						num2 = (short)799932418;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.n;
					num2 = (short)1786052609;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x0600093D RID: 2365 RVA: 0x00068BF8 File Offset: 0x00066DF8
		// (remove) Token: 0x0600093E RID: 2366 RVA: 0x00068D2C File Offset: 0x00066F2C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> AstroCheckIsConvOnlyEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					short num = (short)1578434561;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					int num2;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler;
					for (;;)
					{
						IL_30:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler2;
						switch (num2)
						{
						case 0:
							return;
						case 1:
							goto IL_60;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_60;
							}
							num = (short)2147259108;
							short num3 = num;
							num = (short)391090916;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1811873792;
								if (num != 0)
								{
								}
								num = (short)618332160;
								short num4 = num;
								num = (short)1453981696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_60:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>>(ref this.o, value2, eventHandler2);
						num = (short)1334902786;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_42:
					eventHandler = this.o;
					num = (short)1032323073;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)2112303323;
							short num3 = num2;
							num2 = (short)618803419;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)411041793;
								if (num2 != 0)
								{
								}
								num2 = (short)119406592;
								if (num2 != 0)
								{
								}
								num2 = (short)192086016;
								short num4 = num2;
								num2 = (short)1329856512;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_39:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs>>(ref this.o, value2, eventHandler2);
						num2 = (short)1610350594;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.o;
					num2 = (short)707723265;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600093F RID: 2367 RVA: 0x00068E5C File Offset: 0x0006705C
		// (remove) Token: 0x06000940 RID: 2368 RVA: 0x00068F94 File Offset: 0x00067194
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> AstroDecodeFlashCodeEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> eventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_39;
						case 2:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_39;
							}
							num2 = (short)1030584164;
							short num3 = num2;
							num2 = (short)1792440164;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1817378816;
								if (num2 != 0)
								{
								}
								num2 = (short)1886715904;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						}
						break;
						IL_39:
						num2 = (short)1906704384;
						short num4 = num2;
						num2 = (short)1528889345;
						if (num2 != 0)
						{
						}
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs>>(ref this.p, value2, eventHandler2);
						num2 = (short)736559106;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.p;
					num2 = (short)1811808257;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_113;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1233059840;
					short num3 = num2;
					num2 = (short)1440458959;
					short num4 = num2;
					num2 = (short)161523919;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_113:
						num2 = (short)1857028098;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)2019229697;
						if (num2 != 0)
						{
						}
						num2 = (short)208404480;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs>>(ref this.p, value2, eventHandler2);
						num2 = (short)1333526529;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.p;
				num2 = (short)1244200960;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000941 RID: 2369 RVA: 0x000690D0 File Offset: 0x000672D0
		// (remove) Token: 0x06000942 RID: 2370 RVA: 0x00069208 File Offset: 0x00067408
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> AstroDecodeLangageIndexToLpIDEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_3A;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_111;
						}
						goto IL_3A;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)306905088;
					short num3 = num2;
					num2 = (short)819381932;
					short num4 = num2;
					num2 = (short)118671020;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)973668354;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)816906241;
						if (num2 != 0)
						{
						}
						num2 = (short)1398538240;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs>>(ref this.q, value2, eventHandler2);
						num2 = (short)1215168513;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.q;
				num2 = (short)445120512;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1657077761;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> eventHandler;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						num = (short)693698560;
						short num3 = num;
						goto IL_87;
					}
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_10D;
						}
						goto IL_87;
					}
					case 2:
						return;
					}
					goto IL_42;
					IL_87:
					num = (short)441380192;
					short num4 = num;
					num = (short)905899360;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10D:
						num = (short)1303576578;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1937702912;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs>>(ref this.q, value2, eventHandler2);
						num = (short)1000603649;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_42:
				eventHandler = this.q;
				num = (short)1465778176;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000943 RID: 2371 RVA: 0x0006933C File Offset: 0x0006753C
		// (remove) Token: 0x06000944 RID: 2372 RVA: 0x00069474 File Offset: 0x00067674
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> AstroUpgradeWithLanugagePackIsSupportedCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_111;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1550254080;
					short num3 = num2;
					num2 = (short)619914480;
					short num4 = num2;
					num2 = (short)1867523312;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)1146159106;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)929824769;
						if (num2 != 0)
						{
						}
						num2 = (short)1500184576;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs>>(ref this.r, value2, eventHandler2);
						num2 = (short)1632567297;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.r;
				num2 = (short)1194459136;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_3A;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_EA;
						}
						goto IL_3A;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)1555759104;
					short num3 = num2;
					num2 = (short)2044133046;
					short num4 = num2;
					num2 = (short)840171190;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_EA:
						num2 = (short)444923905;
						if (num2 != 0)
						{
						}
						num2 = (short)942735362;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1859584000;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs>>(ref this.r, value2, eventHandler2);
						num2 = (short)67174401;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.r;
				num2 = (short)484048896;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000945 RID: 2373 RVA: 0x000695B0 File Offset: 0x000677B0
		// (remove) Token: 0x06000946 RID: 2374 RVA: 0x000696EC File Offset: 0x000678EC
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> AstroUpgradeFWVerCompatibleCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_E9;
						}
						goto IL_39;
					}
					case 2:
						goto IL_102;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)490995712;
					short num3 = num2;
					num2 = (short)1889470746;
					short num4 = num2;
					num2 = (short)1335560474;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_E9:
						num2 = (short)2039087106;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)652935168;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs>>(ref this.s, value2, eventHandler2);
						num2 = (short)1324417025;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				IL_102:
				num2 = (short)1562181633;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.s;
				num2 = (short)1765408768;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_111;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)217055232;
					short num3 = num2;
					num2 = (short)550174721;
					if (num2 != 0)
					{
					}
					num2 = (short)1243777314;
					short num4 = num2;
					num2 = (short)2014742818;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)721158146;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)896925696;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs>>(ref this.s, value2, eventHandler2);
						num2 = (short)2001338369;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.s;
				num2 = (short)1163198464;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000947 RID: 2375 RVA: 0x00069828 File Offset: 0x00067A28
		// (remove) Token: 0x06000948 RID: 2376 RVA: 0x00069960 File Offset: 0x00067B60
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> AnalysisPackageEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_3A;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_111;
						}
						goto IL_3A;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)901709824;
					short num3 = num2;
					num2 = (short)1112183271;
					short num4 = num2;
					num2 = (short)1900515815;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)1555234818;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1138229248;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs>>(ref this.t, value2, eventHandler2);
						num2 = (short)1251082241;
						if (num2 != 0)
						{
						}
						num2 = (short)1867448321;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.t;
				num2 = (short)1072300032;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						num2 = (short)1555496961;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_10E;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1062010880;
					short num3 = num2;
					num2 = (short)1013321691;
					short num4 = num2;
					num2 = (short)1097469915;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10E:
						num2 = (short)121372674;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)563609600;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs>>(ref this.t, value2, eventHandler2);
						num2 = (short)803078145;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.t;
				num2 = (short)619708416;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000949 RID: 2377 RVA: 0x00069A94 File Offset: 0x00067C94
		// (remove) Token: 0x0600094A RID: 2378 RVA: 0x00069BCC File Offset: 0x00067DCC
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> LanguagePackInfosEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						num2 = (short)791347201;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_10E;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1652817920;
					short num3 = num2;
					num2 = (short)715312825;
					short num4 = num2;
					num2 = (short)1876545209;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10E:
						num2 = (short)487784450;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)479330304;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs>>(ref this.u, value2, eventHandler2);
						num2 = (short)1590558721;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.u;
				num2 = (short)1114832896;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_110;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1018888192;
					short num3 = num2;
					num2 = (short)874717428;
					short num4 = num2;
					num2 = (short)330703092;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_110:
						num2 = (short)1502806018;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1898905601;
						if (num2 != 0)
						{
						}
						num2 = (short)1640038400;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs>>(ref this.u, value2, eventHandler2);
						num2 = (short)1697841153;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.u;
				num2 = (short)1719205888;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600094B RID: 2379 RVA: 0x00069D04 File Offset: 0x00067F04
		// (remove) Token: 0x0600094C RID: 2380 RVA: 0x00069E40 File Offset: 0x00068040
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> TTSLanguagePackInfosEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_3A;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_114;
						}
						goto IL_3A;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)403308544;
					short num3 = num2;
					num2 = (short)1603893979;
					short num4 = num2;
					num2 = (short)1436646107;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_114:
						num2 = (short)944701442;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)697040896;
						if (num2 != 0)
						{
						}
						num2 = (short)559349761;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs>>(ref this.v, value2, eventHandler2);
						num2 = (short)1592524801;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.v;
				num2 = (short)1819934720;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1105330177;
						if (num2 != 0)
						{
						}
						num2 = (short)449183744;
						short num3 = num2;
						goto IL_8C;
					}
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_114;
						}
						goto IL_8C;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_8C:
					num2 = (short)306474922;
					short num4 = num2;
					num2 = (short)286945194;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_114:
						num2 = (short)1696792578;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)2016215040;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs>>(ref this.v, value2, eventHandler2);
						num2 = (short)706150401;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.v;
				num2 = (short)995622912;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x0600094D RID: 2381 RVA: 0x00069F7C File Offset: 0x0006817C
		// (remove) Token: 0x0600094E RID: 2382 RVA: 0x0006A0B8 File Offset: 0x000682B8
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> AstroLanguagePackCompatibleCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1819475969;
						if (num2 != 0)
						{
						}
						num2 = (short)1499660288;
						short num3 = num2;
						goto IL_8C;
					}
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_113;
						}
						goto IL_8C;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_8C:
					num2 = (short)1799033759;
					short num4 = num2;
					num2 = (short)1899697055;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_113:
						num2 = (short)794951682;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)570490880;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs>>(ref this.w, value2, eventHandler2);
						num2 = (short)684589057;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.w;
				num2 = (short)343015424;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_10F;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)648806400;
					short num3 = num2;
					num2 = (short)423344577;
					short num4 = num2;
					num2 = (short)1238415809;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10F:
						num2 = (short)2033319938;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)680460288;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs>>(ref this.w, value2, eventHandler2);
						num2 = (short)706674689;
						if (num2 != 0)
						{
						}
						num2 = (short)2029846529;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.w;
				num2 = (short)102236160;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600094F RID: 2383 RVA: 0x0006A1F0 File Offset: 0x000683F0
		// (remove) Token: 0x06000950 RID: 2384 RVA: 0x0006A328 File Offset: 0x00068528
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> PcrLanguagePackCompatibleCheckHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1155203072;
						short num3 = num2;
						goto IL_89;
					}
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_111;
						}
						goto IL_89;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_89:
					num2 = (short)103225211;
					short num4 = num2;
					num2 = (short)946476923;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)1664286722;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)156762112;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs>>(ref this.x, value2, eventHandler2);
						num2 = (short)1868693505;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)1165230081;
				if (num2 != 0)
				{
				}
				eventHandler = this.x;
				num2 = (short)2066219008;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_3B;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_113;
						}
						goto IL_3B;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_3B:
					num2 = (short)1293484032;
					short num3 = num2;
					num2 = (short)1148434844;
					short num4 = num2;
					num2 = (short)229357980;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_113:
						num2 = (short)746455042;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)723058689;
						if (num2 != 0)
						{
						}
						num2 = (short)1666187264;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs>>(ref this.x, value2, eventHandler2);
						num2 = (short)340656129;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.x;
				num2 = (short)233701376;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000951 RID: 2385 RVA: 0x0006A464 File Offset: 0x00068664
		// (remove) Token: 0x06000952 RID: 2386 RVA: 0x0006A59C File Offset: 0x0006879C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> ModelTierEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_E9;
						}
						goto IL_39;
					}
					case 2:
						goto IL_100;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1553203200;
					short num3 = num2;
					num2 = (short)331928535;
					short num4 = num2;
					num2 = (short)234017751;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_E9:
						num2 = (short)1180631042;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1572077568;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs>>(ref this.y, value2, eventHandler2);
						num2 = (short)1428946945;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				IL_100:
				num2 = (short)574160897;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.y;
				num2 = (short)74711040;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_EC;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1543766016;
					short num3 = num2;
					num2 = (short)551349044;
					short num4 = num2;
					num2 = (short)1248979764;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_EC:
						num2 = (short)1932066817;
						if (num2 != 0)
						{
						}
						num2 = (short)1754005506;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)697040896;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs>>(ref this.y, value2, eventHandler2);
						num2 = (short)1347485697;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.y;
				num2 = (short)800129024;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06000953 RID: 2387 RVA: 0x0006A6D8 File Offset: 0x000688D8
		// (remove) Token: 0x06000954 RID: 2388 RVA: 0x0006A814 File Offset: 0x00068A14
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> AstroPINPasswordConvertEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_114;
						}
						goto IL_39;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)633798656;
					short num3 = num2;
					num2 = (short)1772256651;
					short num4 = num2;
					num2 = (short)1362132363;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_114:
						num2 = (short)1511653378;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1994063872;
						if (num2 != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs>>(ref this.z, value2, eventHandler2);
						num2 = (short)1307443201;
						if (num2 != 0)
						{
						}
						num2 = (short)936771585;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.z;
				num2 = (short)577896448;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1329201153;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> eventHandler;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						num = (short)1069940736;
						short num3 = num;
						goto IL_87;
					}
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_10E;
						}
						goto IL_87;
					}
					case 2:
						return;
					}
					goto IL_42;
					IL_87:
					num = (short)1575723652;
					short num4 = num;
					num = (short)1292345988;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10E:
						num = (short)29556738;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)306511872;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs>>(ref this.z, value2, eventHandler2);
						num = (short)295043073;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_42:
				eventHandler = this.z;
				num = (short)142606336;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000955 RID: 2389 RVA: 0x0006A94C File Offset: 0x00068B4C
		// (remove) Token: 0x06000956 RID: 2390 RVA: 0x0006AA80 File Offset: 0x00068C80
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> GetVAInsallationPathEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)815228843;
				short num2 = num;
				num = (short)1777559467;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_83:
					goto IL_85;
				default:
					num = (short)1069154304;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> eventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num = (short)1680801792;
							short num4 = num;
							num = (short)948502529;
							if (num != 0)
							{
							}
							num = (short)61931522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85;
					case 1:
						goto IL_83;
					case 2:
						return;
					}
					goto IL_66;
				}
				return;
				IL_66:
				eventHandler = this.aa;
				num = (short)1832255489;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_85:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs>>(ref this.aa, value2, eventHandler2);
				num = (short)43450368;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)2141605721;
				short num2 = num;
				num = (short)1752780633;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_83:
					goto IL_85;
				default:
					num = (short)2034761728;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> eventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
					{
						num = (short)2011889664;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)666173442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85;
					}
					case 1:
						goto IL_83;
					case 2:
						return;
					}
					goto IL_66;
				}
				return;
				IL_66:
				eventHandler = this.aa;
				num = (short)710934529;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_85:
				num = (short)1892876289;
				if (num != 0)
				{
				}
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs>>(ref this.aa, value2, eventHandler2);
				num = (short)36896768;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000957 RID: 2391 RVA: 0x0006ABB8 File Offset: 0x00068DB8
		// (remove) Token: 0x06000958 RID: 2392 RVA: 0x0006ACF4 File Offset: 0x00068EF4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> GetTTSInsallationPathEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1273777888;
				short num2 = num;
				num = (short)568610528;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_85:
					goto IL_87;
				default:
					num = (short)2096168960;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> eventHandler2;
				for (;;)
				{
					IL_56:
					switch (num3)
					{
					case 0:
					{
						num = (short)266665984;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1363673090;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_87;
					}
					case 1:
						goto IL_85;
					case 2:
						return;
					}
					goto IL_68;
				}
				return;
				IL_68:
				eventHandler = this.ab;
				num = (short)1472790529;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
				IL_87:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs>>(ref this.ab, value2, eventHandler2);
				num = (short)1961689089;
				if (num != 0)
				{
				}
				num = (short)741408768;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1942668524;
				short num2 = num;
				num = (short)621397228;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)429719553;
					if (num != 0)
					{
					}
					num = (short)525598720;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> eventHandler2;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
					{
						num = (short)1906704384;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1541079042;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_8F;
				}
				return;
				IL_8F:
				eventHandler = this.ab;
				num = (short)996933633;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
				IL_AC:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs>>(ref this.ab, value2, eventHandler2);
				num = (short)628752384;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000959 RID: 2393 RVA: 0x0006AE28 File Offset: 0x00069028
		// (remove) Token: 0x0600095A RID: 2394 RVA: 0x0006AF60 File Offset: 0x00069160
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> GetPcrCpsUserRegionHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)310106814;
				short num2 = num;
				num = (short)1225120446;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)275382272;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> eventHandler2;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
					{
						num = (short)215482368;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1605042178;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_67;
				}
				return;
				IL_67:
				eventHandler = this.ac;
				num = (short)14483457;
				if (num != 0)
				{
				}
				num = (short)930283521;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
				IL_AC:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs>>(ref this.ac, value2, eventHandler2);
				num = (short)777584640;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)2137903079;
				short num2 = num;
				num = (short)1530646503;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A8:
					goto IL_AA;
				default:
					num = (short)202571776;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> eventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
					{
						num = (short)2091057152;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)106430466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA;
					}
					case 1:
						goto IL_A8;
					case 2:
						return;
					}
					goto IL_66;
				}
				return;
				IL_66:
				num = (short)1316225025;
				if (num != 0)
				{
				}
				eventHandler = this.ac;
				num = (short)832307201;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_AA:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs>>(ref this.ac, value2, eventHandler2);
				num = (short)1730084864;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x0600095B RID: 2395 RVA: 0x0006B094 File Offset: 0x00069294
		// (remove) Token: 0x0600095C RID: 2396 RVA: 0x0006B1C0 File Offset: 0x000693C0
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> UpdatePcrFwDescriptionHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1243022932;
				short num2 = num;
				num = (short)2142766676;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_80:
					goto IL_82;
				default:
					num = (short)572391424;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> eventHandler2;
				for (;;)
				{
					IL_53:
					switch (num3)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num = (short)111542272;
							short num4 = num;
							num = (short)116391938;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					case 1:
						goto IL_80;
					case 2:
						goto IL_F7;
					}
					goto IL_65;
				}
				IL_F7:
				num = (short)1380450305;
				if (num != 0)
				{
				}
				return;
				IL_65:
				eventHandler = this.ad;
				num = (short)236781569;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
				IL_82:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs>>(ref this.ad, value2, eventHandler2);
				num = (short)1748041728;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)733496334;
				short num2 = num;
				num = (short)843531278;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AC:
					goto IL_AE;
				default:
					num = (short)520814592;
					if (num != 0)
					{
					}
					num = (short)939327489;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> eventHandler2;
				for (;;)
				{
					IL_7F:
					switch (num3)
					{
					case 0:
					{
						num = (short)1432748032;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)331546626;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					case 1:
						goto IL_AC;
					case 2:
						return;
					}
					goto IL_91;
				}
				return;
				IL_91:
				eventHandler = this.ad;
				num = (short)1559363585;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
				IL_AE:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs>>(ref this.ad, value2, eventHandler2);
				num = (short)1247608832;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x0600095D RID: 2397 RVA: 0x0006B2F8 File Offset: 0x000694F8
		// (remove) Token: 0x0600095E RID: 2398 RVA: 0x0006B42C File Offset: 0x0006962C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> FirmwareUpgradeIncludeEqualHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)721677731;
				short num2 = num;
				num = (short)466677155;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)1565065216;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8E;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> eventHandler2;
				for (;;)
				{
					IL_56:
					num = (short)635371521;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)1119944704;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1006436354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_8E;
				}
				return;
				IL_8E:
				eventHandler = this.ae;
				num = (short)254279681;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
				IL_AC:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs>>(ref this.ae, value2, eventHandler2);
				num = (short)1814626304;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1049382573;
				short num2 = num;
				num = (short)174280365;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AC:
					goto IL_AE;
				default:
					num = (short)1854603264;
					if (num != 0)
					{
					}
					num = (short)981925889;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> eventHandler2;
				for (;;)
				{
					IL_7E:
					switch (num3)
					{
					case 0:
					{
						num = (short)1988296704;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)416743426;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					case 1:
						goto IL_AC;
					case 2:
						return;
					}
					goto IL_90;
				}
				return;
				IL_90:
				eventHandler = this.ae;
				num = (short)411959297;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7E;
				IL_AE:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs>>(ref this.ae, value2, eventHandler2);
				num = (short)996016128;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600095F RID: 2399 RVA: 0x0006B560 File Offset: 0x00069760
		// (remove) Token: 0x06000960 RID: 2400 RVA: 0x0006B698 File Offset: 0x00069898
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> IsSameFWVersionUpgradeSupportedHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1086135280;
				short num2 = num;
				num = (short)1581915120;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AD:
					goto IL_AF;
				default:
					num = (short)1639448576;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> eventHandler2;
				for (;;)
				{
					IL_57:
					switch (num3)
					{
					case 0:
					{
						num = (short)1056571392;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1184301058;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF;
					}
					case 1:
						goto IL_AD;
					case 2:
						return;
					}
					goto IL_69;
				}
				return;
				IL_69:
				eventHandler = this.af;
				num = (short)2044788737;
				if (num != 0)
				{
				}
				num = (short)462487553;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_57;
				IL_AF:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs>>(ref this.af, value2, eventHandler2);
				num = (short)356777984;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)311644171;
				short num2 = num;
				num = (short)2039762955;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A9:
					goto IL_AB;
				default:
					num = (short)772997120;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> eventHandler2;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
					{
						num = (short)59441152;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)301924354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					}
					case 1:
						goto IL_A9;
					case 2:
						return;
					}
					goto IL_67;
				}
				return;
				IL_67:
				num = (short)243335169;
				if (num != 0)
				{
				}
				eventHandler = this.af;
				num = (short)900333569;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
				IL_AB:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs>>(ref this.af, value2, eventHandler2);
				num = (short)135266304;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000961 RID: 2401 RVA: 0x0006B7CC File Offset: 0x000699CC
		// (remove) Token: 0x06000962 RID: 2402 RVA: 0x0006B900 File Offset: 0x00069B00
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> AstroPop25EnabledEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1418787903;
				short num2 = num;
				num = (short)572259391;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A8:
					goto IL_AA;
				default:
					num = (short)87162880;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> eventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
					{
						num = (short)1837432832;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)122945538;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA;
					}
					case 1:
						goto IL_A8;
					case 2:
						return;
					}
					goto IL_66;
				}
				return;
				IL_66:
				num = (short)1419051009;
				if (num != 0)
				{
				}
				eventHandler = this.ag;
				num = (short)1862074369;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_AA:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs>>(ref this.ag, value2, eventHandler2);
				num = (short)242286592;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1898849998;
				short num2 = num;
				num = (short)2121541326;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_84:
					goto IL_86;
				default:
					num = (short)1634205696;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> eventHandler2;
				for (;;)
				{
					IL_57:
					switch (num3)
					{
					case 0:
					{
						num = (short)2056388609;
						if (num != 0)
						{
						}
						num = (short)1170931712;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)236322818;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86;
					}
					case 1:
						goto IL_84;
					case 2:
						return;
					}
					goto IL_69;
				}
				return;
				IL_69:
				eventHandler = this.ag;
				num = (short)998703105;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_57;
				IL_86:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs>>(ref this.ag, value2, eventHandler2);
				num = (short)1612316672;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000963 RID: 2403 RVA: 0x0006BA38 File Offset: 0x00069C38
		// (remove) Token: 0x06000964 RID: 2404 RVA: 0x0006BB68 File Offset: 0x00069D68
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> GetLicensedFeatureNameHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)754979628;
				short num2 = num;
				num = (short)68883244;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_82:
					goto IL_84;
				default:
					num = (short)1549664256;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> eventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num = (short)774832128;
							short num4 = num;
							num = (short)509345794;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84;
					case 1:
						goto IL_82;
					case 2:
						goto IL_F9;
					}
					goto IL_66;
				}
				IL_F9:
				num = (short)1096155137;
				if (num != 0)
				{
				}
				return;
				IL_66:
				eventHandler = this.ah;
				num = (short)94568449;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_84:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs>>(ref this.ah, value2, eventHandler2);
				num = (short)324993024;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1604790113;
				short num2 = num;
				num = (short)1711941473;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AB:
					goto IL_AD;
				default:
					num = (short)952303616;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> eventHandler2;
				for (;;)
				{
					IL_56:
					switch (num3)
					{
					case 0:
					{
						num = (short)1132986368;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1221197826;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD;
					}
					case 1:
						goto IL_AB;
					case 2:
						return;
					}
					goto IL_68;
				}
				return;
				IL_68:
				eventHandler = this.ah;
				num = (short)1712062465;
				if (num != 0)
				{
				}
				num = (short)894500865;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
				IL_AD:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs>>(ref this.ah, value2, eventHandler2);
				num = (short)1544814592;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000965 RID: 2405 RVA: 0x0006BCA0 File Offset: 0x00069EA0
		// (remove) Token: 0x06000966 RID: 2406 RVA: 0x0006BDD4 File Offset: 0x00069FD4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> AstroEncodeFlashCodeEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)937520488;
				short num2 = num;
				num = (short)424635752;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)59179009;
					if (num != 0)
					{
					}
					num = (short)2122579968;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8E;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> eventHandler2;
				for (;;)
				{
					IL_7C:
					switch (num3)
					{
					case 0:
					{
						num = (short)1694695424;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)447479810;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_8E;
				}
				return;
				IL_8E:
				eventHandler = this.ai;
				num = (short)1781334017;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
				IL_AC:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs>>(ref this.ai, value2, eventHandler2);
				num = (short)1588723712;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1413774933;
				short num2 = num;
				num = (short)1752202837;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AC:
					goto IL_AE;
				default:
					num = (short)180879360;
					if (num != 0)
					{
					}
					num = (short)171180033;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> eventHandler2;
				for (;;)
				{
					IL_7E:
					switch (num3)
					{
					case 0:
					{
						num = (short)1192230912;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1085734914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					case 1:
						goto IL_AC;
					case 2:
						return;
					}
					goto IL_90;
				}
				return;
				IL_90:
				eventHandler = this.ai;
				num = (short)722731009;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7E;
				IL_AE:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs>>(ref this.ai, value2, eventHandler2);
				num = (short)2029649920;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000967 RID: 2407 RVA: 0x0006BF08 File Offset: 0x0006A108
		// (remove) Token: 0x06000968 RID: 2408 RVA: 0x0006C040 File Offset: 0x0006A240
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> ParseFeatureCodeEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1122805858;
				short num2 = num;
				num = (short)385591394;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_83:
					goto IL_85;
				default:
					num = (short)2128281600;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> eventHandler2;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
					{
						num = (short)1282473985;
						if (num != 0)
						{
						}
						num = (short)1216282624;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)113377282;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85;
					}
					case 1:
						goto IL_83;
					case 2:
						return;
					}
					goto IL_67;
				}
				return;
				IL_67:
				eventHandler = this.aj;
				num = (short)635895809;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
				IL_85:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs>>(ref this.aj, value2, eventHandler2);
				num = (short)590413824;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1845190744;
				short num2 = num;
				num = (short)924344408;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)2118975489;
					if (num != 0)
					{
					}
					num = (short)1909391360;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8E;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> eventHandler2;
				for (;;)
				{
					IL_7C:
					switch (num3)
					{
					case 0:
					{
						num = (short)865206272;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)446955522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_8E;
				}
				return;
				IL_8E:
				eventHandler = this.aj;
				num = (short)194379777;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
				IL_AC:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs>>(ref this.aj, value2, eventHandler2);
				num = (short)196608000;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06000969 RID: 2409 RVA: 0x0006C174 File Offset: 0x0006A374
		// (remove) Token: 0x0600096A RID: 2410 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> ParseFeatureStatusEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)2088583766;
				short num2 = num;
				num = (short)835404374;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_83:
					goto IL_85;
				default:
					num = (short)422707200;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> eventHandler2;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num = (short)1064697856;
							short num4 = num;
							num = (short)419299330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85;
					case 1:
						goto IL_83;
					case 2:
						goto IL_FA;
					}
					goto IL_67;
				}
				IL_FA:
				num = (short)564920321;
				if (num != 0)
				{
				}
				return;
				IL_67:
				eventHandler = this.ak;
				num = (short)174063617;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
				IL_85:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs>>(ref this.ak, value2, eventHandler2);
				num = (short)2037710848;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1031235616;
				short num2 = num;
				num = (short)2065393696;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)1036648449;
					if (num != 0)
					{
					}
					num = (short)102891520;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> eventHandler2;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
					{
						num = (short)1085800448;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)1815805954;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					}
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_8F;
				}
				return;
				IL_8F:
				eventHandler = this.ak;
				num = (short)670171137;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
				IL_AC:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs>>(ref this.ak, value2, eventHandler2);
				num = (short)1757609984;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x0600096B RID: 2411 RVA: 0x0006C3D8 File Offset: 0x0006A5D8
		// (remove) Token: 0x0600096C RID: 2412 RVA: 0x0006C510 File Offset: 0x0006A710
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> FilterLicenseEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)349013265;
				short num2 = num;
				num = (short)537429265;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_83:
					num = (short)1618542593;
					if (num != 0)
					{
					}
					goto IL_AE;
				default:
					num = (short)1651245056;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> eventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
					{
						num = (short)388366336;
						short num4 = num;
						if (eventHandler == eventHandler2)
						{
							num = (short)760676354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					case 1:
						goto IL_83;
					case 2:
						return;
					}
					goto IL_66;
				}
				return;
				IL_66:
				eventHandler = this.al;
				num = (short)546439169;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_AE:
				eventHandler2 = eventHandler;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
				eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs>>(ref this.al, value2, eventHandler2);
				num = (short)1327235072;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)679477249;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)889454593;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1657404192;
						short num3 = num2;
						num2 = (short)1618541344;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_E8;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)721682432;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs>>(ref this.al, value2, eventHandler2);
					goto IL_57;
				}
				IL_E8:
				num2 = (short)1719468032;
				short num4 = num2;
				num2 = (short)2142961664;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.al;
				num2 = (short)526778370;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x0600096D RID: 2413 RVA: 0x0006C648 File Offset: 0x0006A848
		// (remove) Token: 0x0600096E RID: 2414 RVA: 0x0006C77C File Offset: 0x0006A97C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> PCRFilterLicenseEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1209270273;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					case 1:
					{
						num2 = (short)1091584359;
						short num3 = num2;
						num2 = (short)494944615;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C;
						default:
							goto IL_E7;
						}
						break;
					}
					case 2:
						num2 = (short)714473473;
						if (num2 != 0)
						{
						}
						goto IL_5F;
					}
					goto IL_1C;
					IL_7C:
					num2 = (short)1067122688;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5F:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs>>(ref this.am, value2, eventHandler2);
					goto IL_7C;
				}
				IL_E7:
				num2 = (short)2044985344;
				short num4 = num2;
				num2 = (short)1793458176;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.am;
				num2 = (short)2109538306;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1940389889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)954309706;
						short num3 = num2;
						num2 = (short)2013174858;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_BA;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)220987392;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs>>(ref this.am, value2, eventHandler2);
					goto IL_57;
				}
				IL_BA:
				num2 = (short)1838022657;
				if (num2 != 0)
				{
				}
				num2 = (short)2006974464;
				short num4 = num2;
				num2 = (short)848691200;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.am;
				num2 = (short)1909981186;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x0600096F RID: 2415 RVA: 0x0006C8B0 File Offset: 0x0006AAB0
		// (remove) Token: 0x06000970 RID: 2416 RVA: 0x0006C9E8 File Offset: 0x0006ABE8
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> GenerateLicenseFilterEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1561329665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1910536497;
						short num3 = num2;
						num2 = (short)827685169;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_E8;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)1346371585;
					if (num2 != 0)
					{
					}
					num2 = (short)985006080;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs>>(ref this.an, value2, eventHandler2);
					goto IL_57;
				}
				IL_E8:
				num2 = (short)1407451136;
				short num4 = num2;
				num2 = (short)790036480;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.an;
				num2 = (short)822738946;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)802750465;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					case 1:
					{
						num2 = (short)323431657;
						short num3 = num2;
						num2 = (short)1244146921;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C;
						default:
							goto IL_EA;
						}
						break;
					}
					case 2:
						num2 = (short)329515009;
						if (num2 != 0)
						{
						}
						goto IL_5F;
					}
					goto IL_1C;
					IL_7C:
					num2 = (short)1300234240;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5F:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs>>(ref this.an, value2, eventHandler2);
					goto IL_7C;
				}
				IL_EA:
				num2 = (short)317849600;
				short num4 = num2;
				num2 = (short)1536229376;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.an;
				num2 = (short)132907010;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000971 RID: 2417 RVA: 0x0006CB20 File Offset: 0x0006AD20
		// (remove) Token: 0x06000972 RID: 2418 RVA: 0x0006CC50 File Offset: 0x0006AE50
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> UpgradeTemplateByFeaturesEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)910360577;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)68878337;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1533165372;
						short num3 = num2;
						num2 = (short)2037923644;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_E6;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)630456320;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs>>(ref this.ao, value2, eventHandler2);
					goto IL_57;
				}
				IL_E6:
				num2 = (short)1513029632;
				short num4 = num2;
				num2 = (short)1563623424;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.ao;
				num2 = (short)2109931522;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1377042433;
					if (num != 0)
					{
					}
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> eventHandler2;
					switch (num2)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num = (short)1901658113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61;
					case 1:
					{
						num = (short)427715696;
						short num3 = num;
						num = (short)1367436400;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							goto IL_E9;
						}
						break;
					}
					case 2:
						goto IL_61;
					}
					goto IL_43;
					IL_7E:
					num = (short)1488584704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs>>(ref this.ao, value2, eventHandler2);
					goto IL_7E;
				}
				IL_E9:
				num = (short)577437696;
				short num4 = num;
				num = (short)2029060096;
				if (num != 0)
				{
				}
				return;
				IL_43:
				eventHandler = this.ao;
				num = (short)1218510850;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000973 RID: 2419 RVA: 0x0006CD84 File Offset: 0x0006AF84
		// (remove) Token: 0x06000974 RID: 2420 RVA: 0x0006CEB4 File Offset: 0x0006B0B4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> ApplyRadioWithFeaturesEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)292814849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3B;
					case 1:
					{
						num2 = (short)97111184;
						short num3 = num2;
						num2 = (short)2001390736;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_58;
						default:
							goto IL_BC;
						}
						break;
					}
					case 2:
						goto IL_3B;
					}
					goto IL_1C;
					IL_58:
					num2 = (short)202637312;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3B:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs>>(ref this.ap, value2, eventHandler2);
					goto IL_58;
				}
				IL_BC:
				num2 = (short)1779892225;
				if (num2 != 0)
				{
				}
				num2 = (short)1620246528;
				short num4 = num2;
				num2 = (short)334364672;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.ap;
				num2 = (short)1176174594;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1625882625;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					case 1:
					{
						num2 = (short)1123657647;
						short num3 = num2;
						num2 = (short)767403951;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C;
						default:
							goto IL_E7;
						}
						break;
					}
					case 2:
						goto IL_5F;
					}
					goto IL_1C;
					IL_7C:
					num2 = (short)692649984;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5F:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs>>(ref this.ap, value2, eventHandler2);
					goto IL_7C;
				}
				IL_E7:
				num2 = (short)1926103040;
				short num4 = num2;
				num2 = (short)307822592;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.ap;
				num2 = (short)231669761;
				if (num2 != 0)
				{
				}
				num2 = (short)1777795074;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000975 RID: 2421 RVA: 0x0006CFE8 File Offset: 0x0006B1E8
		// (remove) Token: 0x06000976 RID: 2422 RVA: 0x0006D118 File Offset: 0x0006B318
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> PopulateRadioFeaturesFromCodeplugEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)388628481;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3B;
					case 1:
					{
						num2 = (short)1966388047;
						short num3 = num2;
						num2 = (short)269202255;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_58;
						default:
							goto IL_BA;
						}
						break;
					}
					case 2:
						goto IL_3B;
					}
					goto IL_1C;
					IL_58:
					num2 = (short)511901696;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3B:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs>>(ref this.aq, value2, eventHandler2);
					goto IL_58;
				}
				IL_BA:
				num2 = (short)1457258496;
				if (num2 != 0)
				{
				}
				num2 = (short)1059782656;
				short num4 = num2;
				num2 = (short)1165164545;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.aq;
				num2 = (short)459931650;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)680919041;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_60;
					case 1:
					{
						num2 = (short)680776928;
						short num3 = num2;
						num2 = (short)1921897696;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_E8;
						}
						break;
					}
					case 2:
						num2 = (short)1934229505;
						if (num2 != 0)
						{
						}
						goto IL_60;
					}
					goto IL_1C;
					IL_7D:
					num2 = (short)1231814656;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_60:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs>>(ref this.aq, value2, eventHandler2);
					goto IL_7D;
				}
				IL_E8:
				num2 = (short)87228416;
				short num4 = num2;
				num2 = (short)1391591424;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.aq;
				num2 = (short)1240924162;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000977 RID: 2423 RVA: 0x0006D24C File Offset: 0x0006B44C
		// (remove) Token: 0x06000978 RID: 2424 RVA: 0x0006D37C File Offset: 0x0006B57C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> PopulateRadioFeaturesFromFlashCodeEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)905969665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1793343780;
						short num3 = num2;
						num2 = (short)1630290212;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_BB;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)5636096;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs>>(ref this.ar, value2, eventHandler2);
					goto IL_57;
				}
				IL_BB:
				num2 = (short)1620049921;
				if (num2 != 0)
				{
				}
				num2 = (short)1193934848;
				short num4 = num2;
				num2 = (short)933232640;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.ar;
				num2 = (short)108855298;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)275251201;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1375565650;
						short num3 = num2;
						num2 = (short)1363113810;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_BC;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)89063424;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs>>(ref this.ar, value2, eventHandler2);
					goto IL_57;
				}
				IL_BC:
				num2 = (short)107085825;
				if (num2 != 0)
				{
				}
				num2 = (short)1485832192;
				short num4 = num2;
				num2 = (short)497156096;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.ar;
				num2 = (short)757858306;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000979 RID: 2425 RVA: 0x0006D4B0 File Offset: 0x0006B6B0
		// (remove) Token: 0x0600097A RID: 2426 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> ParseRadioFeatureEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1432551425;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_61;
					case 1:
					{
						num2 = (short)1162387071;
						short num3 = num2;
						num2 = (short)1015914111;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							goto IL_E9;
						}
						break;
					}
					case 2:
						num2 = (short)2140340225;
						if (num2 != 0)
						{
						}
						goto IL_61;
					}
					goto IL_1C;
					IL_7E:
					num2 = (short)1678835712;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_61:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs>>(ref this.@as, value2, eventHandler2);
					goto IL_7E;
				}
				IL_E9:
				num2 = (short)315752448;
				short num4 = num2;
				num2 = (short)773718016;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.@as;
				num2 = (short)1224802306;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1968439297;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_61;
					case 1:
					{
						num2 = (short)1863868420;
						short num3 = num2;
						num2 = (short)1952407556;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							goto IL_E7;
						}
						break;
					}
					case 2:
						num2 = (short)1081278465;
						if (num2 != 0)
						{
						}
						goto IL_61;
					}
					goto IL_1C;
					IL_7E:
					num2 = (short)2026700800;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_61:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs>>(ref this.@as, value2, eventHandler2);
					goto IL_7E;
				}
				IL_E7:
				num2 = (short)1054539776;
				short num4 = num2;
				num2 = (short)1004666880;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.@as;
				num2 = (short)1367408642;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x0600097B RID: 2427 RVA: 0x0006D71C File Offset: 0x0006B91C
		// (remove) Token: 0x0600097C RID: 2428 RVA: 0x0006D850 File Offset: 0x0006BA50
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> AstroParseFlashCodeEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1261895681;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_60;
					case 1:
					{
						num2 = (short)1169564663;
						short num3 = num2;
						num2 = (short)955655159;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_E6;
						}
						break;
					}
					case 2:
						num2 = (short)198049793;
						if (num2 != 0)
						{
						}
						goto IL_60;
					}
					goto IL_1C;
					IL_7D:
					num2 = (short)2083192832;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_60:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs>>(ref this.at, value2, eventHandler2);
					goto IL_7D;
				}
				IL_E6:
				num2 = (short)804716544;
				short num4 = num2;
				num2 = (short)789643264;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.at;
				num2 = (short)1082458114;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)1517158401;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1888813057;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1319778610;
						short num3 = num2;
						num2 = (short)302922034;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_E6;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)1707212800;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs>>(ref this.at, value2, eventHandler2);
					goto IL_57;
				}
				IL_E6:
				num2 = (short)519110656;
				short num4 = num2;
				num2 = (short)308346880;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.at;
				num2 = (short)1498546178;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x0600097D RID: 2429 RVA: 0x0006D980 File Offset: 0x0006BB80
		// (remove) Token: 0x0600097E RID: 2430 RVA: 0x0006DAB4 File Offset: 0x0006BCB4
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> RadioCfsChangesInUpgradeEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1884880897;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 1:
					{
						num2 = (short)1932821198;
						short num3 = num2;
						num2 = (short)2026930894;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_E6;
						}
						break;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_7D:
					num2 = (short)1363017728;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					num2 = (short)1000079361;
					if (num2 != 0)
					{
					}
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs>>(ref this.au, value2, eventHandler2);
					goto IL_7D;
				}
				IL_E6:
				num2 = (short)194838528;
				short num4 = num2;
				num2 = (short)1598291968;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.au;
				num2 = (short)726335490;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)1645084673;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)441384961;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 1:
					{
						num2 = (short)1736789464;
						short num3 = num2;
						num2 = (short)284708312;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
							goto IL_E6;
						}
						break;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)688128000;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs>>(ref this.au, value2, eventHandler2);
					goto IL_56;
				}
				IL_E6:
				num2 = (short)1295581184;
				short num4 = num2;
				num2 = (short)1591934976;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.au;
				num2 = (short)1929641986;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x0600097F RID: 2431 RVA: 0x0006DBE8 File Offset: 0x0006BDE8
		// (remove) Token: 0x06000980 RID: 2432 RVA: 0x0006DD20 File Offset: 0x0006BF20
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> BindingServerLanguagePackEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)217841665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1892622903;
						short num3 = num2;
						num2 = (short)1618027063;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							goto IL_E7;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_7E:
					num2 = (short)618659840;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					num2 = (short)472776705;
					if (num2 != 0)
					{
					}
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs>>(ref this.av, value2, eventHandler2);
					goto IL_7E;
				}
				IL_E7:
				num2 = (short)224067584;
				short num4 = num2;
				num2 = (short)970719232;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.av;
				num2 = (short)732954626;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)887160833;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 1:
					{
						num2 = (short)974290955;
						short num3 = num2;
						num2 = (short)1551073291;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
							goto IL_E9;
						}
						break;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_56:
					num2 = (short)1969487873;
					if (num2 != 0)
					{
					}
					num2 = (short)1749352448;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs>>(ref this.av, value2, eventHandler2);
					goto IL_56;
				}
				IL_E9:
				num2 = (short)1681457152;
				short num4 = num2;
				num2 = (short)1709768704;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.av;
				num2 = (short)1408303106;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000981 RID: 2433 RVA: 0x0006DE54 File Offset: 0x0006C054
		// (remove) Token: 0x06000982 RID: 2434 RVA: 0x0006DF84 File Offset: 0x0006C184
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> IsFreonEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)458620929;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
					{
						num2 = (short)1760756996;
						short num3 = num2;
						num2 = (short)1224410372;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_BC;
						}
						break;
					}
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_57:
					num2 = (short)1909260288;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs>>(ref this.aw, value2, eventHandler2);
					goto IL_57;
				}
				IL_BC:
				num2 = (short)1974927360;
				if (num2 != 0)
				{
				}
				num2 = (short)1022754816;
				short num4 = num2;
				num2 = (short)1949630465;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.aw;
				num2 = (short)880148482;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)1688207360;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_DA;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)517931009;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DA;
						}
						break;
						IL_DA:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs>>(ref this.aw, value2, eventHandler2);
						num = (short)1017315330;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					num = (short)2040135681;
					if (num != 0)
					{
					}
					num = (short)1521298127;
					short num4 = num;
					num = (short)2040539855;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)45416448;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> eventHandler = this.aw;
						num = (short)1620508672;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000983 RID: 2435 RVA: 0x0006E0C0 File Offset: 0x0006C2C0
		// (remove) Token: 0x06000984 RID: 2436 RVA: 0x0006E1F8 File Offset: 0x0006C3F8
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> ASTROIndividualIdEditingCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)1006960640;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_B1;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)523370497;
								if (num != 0)
								{
								}
								num = (short)1402667009;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B1;
						}
						break;
						IL_B1:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs>>(ref this.ax, value2, eventHandler2);
						num = (short)43843586;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_45:
					num = (short)162755435;
					short num4 = num;
					num = (short)605647723;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1970733056;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> eventHandler = this.ax;
						num = (short)322371584;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)1277362176;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							num = (short)1519255553;
							if (num != 0)
							{
							}
							goto IL_DE;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)1744896001;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DE;
						}
						break;
						IL_DE:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs>>(ref this.ax, value2, eventHandler2);
						num = (short)1863188482;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					num = (short)592440529;
					short num4 = num;
					num = (short)1224666321;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)771686400;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> eventHandler = this.ax;
						num = (short)755433472;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000985 RID: 2437 RVA: 0x0006E338 File Offset: 0x0006C538
		// (remove) Token: 0x06000986 RID: 2438 RVA: 0x0006E470 File Offset: 0x0006C670
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> AstroASKRequirementEditingCheckEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)1294139392;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_B1;
						case 1:
							return;
						case 2:
							num = (short)1843855361;
							if (num != 0)
							{
							}
							if (eventHandler == eventHandler2)
							{
								num = (short)879099905;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B1;
						}
						break;
						IL_B1:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs>>(ref this.ay, value2, eventHandler2);
						num = (short)1362886658;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_45:
					num = (short)1230808724;
					short num4 = num;
					num = (short)208381588;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1201143808;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> eventHandler = this.ay;
						num = (short)890961920;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)1328414720;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_AE;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)308936705;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AE;
						}
						break;
						IL_AE:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs>>(ref this.ay, value2, eventHandler2);
						num = (short)1679949825;
						if (num != 0)
						{
						}
						num = (short)814153730;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_44:
					num = (short)1637150745;
					short num4 = num;
					num = (short)1575219225;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)101646336;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> eventHandler = this.ay;
						num = (short)1282080768;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000987 RID: 2439 RVA: 0x0006E5A4 File Offset: 0x0006C7A4
		// (remove) Token: 0x06000988 RID: 2440 RVA: 0x0006E6DC File Offset: 0x0006C8DC
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> AstroGetLoadedSysKeysEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)527171584;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_D6;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)277872641;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D6;
						}
						break;
						IL_D6:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs>>(ref this.az, value2, eventHandler2);
						num = (short)1920532482;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_44:
					num = (short)1623542835;
					short num4 = num;
					num = (short)1534676019;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1145831424;
						if (num != 0)
						{
						}
						num = (short)368508929;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> eventHandler = this.az;
						num = (short)1490550784;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)469565440;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_B4;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)26542081;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B4;
						}
						break;
						IL_B4:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs>>(ref this.az, value2, eventHandler2);
						num = (short)1280049153;
						if (num != 0)
						{
						}
						num = (short)248905730;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					num = (short)663770497;
					short num4 = num;
					num = (short)1205360001;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1957101568;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> eventHandler = this.az;
						num = (short)1196621824;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000989 RID: 2441 RVA: 0x0006E818 File Offset: 0x0006CA18
		// (remove) Token: 0x0600098A RID: 2442 RVA: 0x0006E94C File Offset: 0x0006CB4C
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> QueryUpdateRadioEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					short num = (short)1151533057;
					if (num != 0)
					{
					}
					num = (short)1514340352;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					for (;;)
					{
						IL_5A:
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_D3;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)1609367553;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D3;
						}
						break;
						IL_D3:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs>>(ref this.a0, value2, eventHandler2);
						num = (short)1504378882;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_6C:
					num = (short)2021540561;
					short num4 = num;
					num = (short)474301137;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1519976448;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> eventHandler = this.a0;
						num = (short)392888320;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_5A;
					}
					}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)2019557376;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_D8;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)192544769;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D8;
						}
						break;
						IL_D8:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs>>(ref this.a0, value2, eventHandler2);
						num = (short)828243970;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_46:
					num = (short)745479475;
					short num4 = num;
					num = (short)422059315;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)448135168;
						if (num != 0)
						{
						}
						num = (short)377487361;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> eventHandler = this.a0;
						num = (short)560398336;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x0600098B RID: 2443 RVA: 0x0006EA84 File Offset: 0x0006CC84
		// (remove) Token: 0x0600098C RID: 2444 RVA: 0x0006EBBC File Offset: 0x0006CDBC
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> ParseAchiveEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)766967808;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_D7;
						case 1:
							return;
						case 2:
							if (eventHandler == eventHandler2)
							{
								num = (short)52297729;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D7;
						}
						break;
						IL_D7:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>>(ref this.a1, value2, eventHandler2);
						num = (short)988020738;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_45:
					num = (short)449445889;
					if (num != 0)
					{
					}
					num = (short)1060462638;
					short num4 = num;
					num = (short)1101422638;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1511063552;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler = this.a1;
						num = (short)884277248;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					short num;
					for (;;)
					{
						IL_0A:
						num = (short)346947584;
						short num2 = num;
						int num3;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_B0;
						case 1:
							return;
						case 2:
							num = (short)1240858625;
							if (num != 0)
							{
							}
							if (eventHandler == eventHandler2)
							{
								num = (short)712704001;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B0;
						}
						break;
						IL_B0:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs>>(ref this.a1, value2, eventHandler2);
						num = (short)1900871682;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_44:
					num = (short)1323040650;
					short num4 = num;
					num = (short)201850762;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1352728576;
						if (num != 0)
						{
						}
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> eventHandler = this.a1;
						num = (short)1933246464;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_0A;
					}
					}
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0006ECF4 File Offset: 0x0006CEF4
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0006EDA4 File Offset: 0x0006CFA4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdateProgressToRMCDelegate UpdateProgressDelegate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)637992960;
				short num2 = num;
				num = (short)196608001;
				if (num != 0)
				{
				}
				num = (short)217827911;
				short num3 = num;
				num = (short)1550043719;
				switch (num3 == num)
				{
				}
				num = (short)759169024;
				if (num != 0)
				{
				}
				return this.a2;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)13762560;
				short num2 = num;
				num = (short)452285376;
				short num3 = num;
				num = (short)501437376;
				switch (num3 == num)
				{
				}
				num = (short)390070273;
				if (num != 0)
				{
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				this.a2 = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0006EE58 File Offset: 0x0006D058
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0006EF08 File Offset: 0x0006D108
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.SaveCodeplugToRMCDelegate SaveCodeplugDelegate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1352925184;
				short num2 = num;
				num = (short)524649348;
				short num3 = num;
				num = (short)2061271940;
				switch (num3 == num)
				{
				}
				num = (short)2072838144;
				if (num != 0)
				{
				}
				num = (short)670302209;
				if (num != 0)
				{
				}
				return this.a3;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1729232896;
				short num2 = num;
				num = (short)1961967220;
				short num3 = num;
				num = (short)1827290740;
				switch (num3 == num)
				{
				}
				num = (short)252968960;
				if (num != 0)
				{
				}
				num = (short)1200488449;
				if (num != 0)
				{
				}
				this.a3 = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0006EFBC File Offset: 0x0006D1BC
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x0006F06C File Offset: 0x0006D26C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.CheckForUnlimitedKeys CheckForUnlimitedEvtHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)723714048;
				short num2 = num;
				num = (short)785907713;
				if (num != 0)
				{
				}
				num = (short)337467061;
				short num3 = num;
				num = (short)110712501;
				switch (num3 == num)
				{
				}
				num = (short)574816256;
				if (num != 0)
				{
				}
				return this.a4;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)419561472;
				short num2 = num;
				num = (short)229759339;
				short num3 = num;
				num = (short)1638390123;
				switch (num3 == num)
				{
				}
				num = (short)1591803904;
				if (num != 0)
				{
				}
				num = (short)85131265;
				if (num != 0)
				{
				}
				this.a4 = value;
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0006F120 File Offset: 0x0006D320
		public static global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface GetInstance()
		{
			short num = (short)440008704;
			short num2 = num;
			num = (short)118555858;
			short num3 = num;
			num = (short)1039008978;
			switch (num3 == num)
			{
			}
			num = (short)1829765120;
			if (num != 0)
			{
			}
			num = (short)117833729;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.a;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0006F1D0 File Offset: 0x0006D3D0
		public void SendImportDeviceEvent(global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs args)
		{
			short num;
			for (;;)
			{
				num = (short)463732736;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_C8;
					case 2:
						this.b(this, args);
						num = (short)1193279489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)1115619328;
					short num3 = num;
					if (this.b == null)
					{
						break;
					}
					num = (short)582418433;
					if (num != 0)
					{
					}
					num = (short)215023618;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CA:
				num = (short)214401331;
				short num4 = num;
				num = (short)1739030835;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_101;
				}
				IL_C8:
				goto IL_CA;
			}
			IL_101:
			num = (short)1905721344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0006F2F4 File Offset: 0x0006D4F4
		public void SendExportDeviceEvent(byte[] codeplugFileContent, string firmwareVersion, string filePathName, global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)41353216;
			short num2 = num;
			num = (short)1157726749;
			short num3 = num;
			num = (short)300319261;
			switch (num3 == num)
			{
			}
			num = (short)701169664;
			if (num != 0)
			{
			}
			num = (short)1879900161;
			if (num != 0)
			{
			}
			global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler = this.d;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs(codeplugFileContent, firmwareVersion, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.PbaFile, filePathName, radio));
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0006F3BC File Offset: 0x0006D5BC
		public void SendExportDeviceFromTemplateEvent(byte[] templateFileContent, string filePathName, global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)1638662144;
			short num2 = num;
			num = (short)63861824;
			short num3 = num;
			num = (short)403600448;
			switch (num3 == num)
			{
			}
			num = (short)1288962049;
			if (num != 0)
			{
			}
			num = (short)1405485056;
			if (num != 0)
			{
			}
			global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler = this.d;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs(templateFileContent, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.CpdFile, filePathName, radio));
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0006F484 File Offset: 0x0006D684
		public void SendExportDeviceForRestoreEvent(byte[] codeplugFileContent, string filePathName)
		{
			short num = (short)1873583291;
			short num2 = num;
			num = (short)1656790203;
			switch (num2 == num)
			{
			}
			num = (short)686227456;
			short num3 = num;
			num = (short)525729793;
			if (num != 0)
			{
			}
			num = (short)2424832;
			if (num != 0)
			{
			}
			global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> eventHandler = this.d;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs(codeplugFileContent, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.PbaFile, filePathName, null, true));
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0006F54C File Offset: 0x0006D74C
		public void SendExportDVRSEvent(byte[] fileContent, string filePathName)
		{
			short num = (short)219217921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)523632641;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					goto IL_F6;
				}
				IL_59:
				if (this.e == null)
				{
					break;
				}
				num = (short)1937647455;
				short num3 = num;
				num = (short)111880031;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1315766272;
					if (num != 0)
					{
					}
					num = (short)757137408;
					short num4 = num;
					num = (short)1512046594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_F6:
				this.e(this, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs(fileContent, filePathName));
				num = (short)1463877632;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0006F67C File Offset: 0x0006D87C
		public void SendEditTemplateEvent(byte[] fileContent, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			short num = (short)857931777;
			if (num != 0)
			{
			}
			num = (short)461897728;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1134362624;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_3B;
				case 1:
				{
					num = (short)605087145;
					short num4 = num;
					num = (short)1891427753;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						num = (short)183762944;
						if (num != 0)
						{
						}
						this.f(this, new global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs(fileContent, radio, temp, null));
						num = (short)1880883202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_7F;
				IL_3B:
				switch (0)
				{
				case 0:
					IL_7F:
					if (this.f == null)
					{
						return;
					}
					num = (short)631570433;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0006F7A8 File Offset: 0x0006D9A8
		public void SendImportTemplateEvent(global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs args)
		{
			short num = (short)603717632;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)318111744;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
				{
					num = (short)731356121;
					short num4 = num;
					num = (short)1481874393;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)347602944;
						if (num != 0)
						{
						}
						this.c(this, args);
						num = (short)2097020930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_81;
				IL_14:
				num = (short)361365505;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_81:
					if (this.c == null)
					{
						return;
					}
					num = (short)1230110721;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
		public void UpdateProgress(int curValue)
		{
			short num = (short)1081671680;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2044526593;
				if (num != 0)
				{
				}
				num = (short)1327366144;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
				{
					num = (short)1154648289;
					short num4 = num;
					num = (short)933005537;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)768278528;
						if (num != 0)
						{
						}
						this.UpdateProgressDelegate(curValue);
						num = (short)904265730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_83;
				IL_14:
				switch (0)
				{
				case 0:
					IL_83:
					if (this.UpdateProgressDelegate == null)
					{
						return;
					}
					num = (short)2101805057;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0006F9F8 File Offset: 0x0006DBF8
		public global::Motorola.CommonCPS.Server.EntityModel.Template SaveCodeplugToServer(byte[] fileContent, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template templateObj)
		{
			short num = (short)532742144;
			int num2 = (int)((global::System.IntPtr)num);
			object obj;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 1:
				{
					num = (short)280890724;
					short num3 = num;
					num = (short)670371172;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)956825600;
						if (num != 0)
						{
						}
						obj = (this.SaveCodeplugDelegate(new object[]
						{
							fileContent,
							radio,
							templateObj
						}) as global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary);
						num = (short)530644994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)861077505;
					if (num != 0)
					{
					}
					if (obj is global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary)
					{
						num = (short)1959264261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1110310915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (obj is global::Motorola.CommonCPS.Server.EntityModel.Template)
					{
						num = (short)2097020932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				case 4:
					goto IL_94;
				case 5:
					goto IL_1AB;
				}
				IL_3E:
				if (this.SaveCodeplugDelegate == null)
				{
					goto IL_1B7;
				}
				num = (short)1457192961;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_94:
			num = (short)1467875328;
			short num4 = num;
			return obj as global::Motorola.CommonCPS.Server.EntityModel.Template;
			IL_1AB:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplate((obj as global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary).Uuid, true);
			IL_1B7:
			return null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0006FBC0 File Offset: 0x0006DDC0
		public bool IsNeedBindingServerLanguagePack(string firmwareVersion)
		{
			short num = (short)722885214;
			short num2 = num;
			num = (short)205412958;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)872284160;
				if (num != 0)
				{
				}
				if (this.av == null)
				{
					num = (short)509411329;
					if (num != 0)
					{
					}
					return false;
				}
				break;
			}
			num = (short)47448064;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs bindingServerLanguagePackEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs(firmwareVersion);
			this.av(this, bindingServerLanguagePackEventArgs);
			return bindingServerLanguagePackEventArgs.IsNeedBinding;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0006FC90 File Offset: 0x0006DE90
		public void ValidateAstroCompatibility(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug deviceCp, global::Motorola.CommonCPS.Server.EntityModel.Template templateCp, string targetModelnumber)
		{
			short num = (short)1542324224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
				{
					num = (short)1947758383;
					short num3 = num;
					num = (short)378957615;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
					{
						num = (short)1148780544;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs astroCompatibilityEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs(deviceCp, templateCp as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate, targetModelnumber);
						this.g(this, astroCompatibilityEventArgs);
						num = (short)1842020354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_31:
					num = (short)1587478528;
					short num4 = num;
					if (this.g == null)
					{
						return;
					}
					num = (short)1417740289;
					if (num != 0)
					{
					}
					num = (short)377028609;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0006FDC0 File Offset: 0x0006DFC0
		public int GetPcrCpsUserRegion()
		{
			short num = (short)912588800;
			short num2 = num;
			num = (short)1390665097;
			short num3 = num;
			num = (short)1279974793;
			int region;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)980484096;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs getPcrUserRegionArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs();
				try
				{
					num = (short)147456000;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						case 1:
							this.ac(this, getPcrUserRegionArgs);
							region = getPcrUserRegionArgs.Region;
							num = (short)2111242242;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_F0;
						}
						IL_AA:
						if (this.ac == null)
						{
							goto IL_F2;
						}
						num = (short)70189057;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_F0:
					break;
					IL_F2:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CPSDidntReturnRegion, global::Motorola.CommonCPS.ResourceRepository.Resources.CPSDidntReturnRegion, null);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.PcrCpsGetRegionFailed, ex);
				}
				break;
			}
			}
			num = (short)810680321;
			if (num != 0)
			{
			}
			return region;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0006FF24 File Offset: 0x0006E124
		public string AstroPINPasswordConvert(string source, bool encrypt)
		{
			short num = (short)1201405953;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs astroPINPasswordConvertEventArgs;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.z != null)
					{
						num = (short)525795331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_136;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					goto IL_C3;
				case 3:
					goto IL_12B;
				case 4:
					goto IL_9A;
				}
				IL_38:
				num = (short)1045558397;
				short num3 = num;
				num = (short)340194429;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12B:
					this.z(this, astroPINPasswordConvertEventArgs);
					num = (short)1019805698;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1874984960;
					if (num != 0)
					{
					}
					if (source == null)
					{
						num = (short)1446182916;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1660223489;
						if (num != 0)
						{
						}
						astroPINPasswordConvertEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs(source, encrypt);
						num = (short)2016149504;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_9A:
			return string.Empty;
			IL_C3:
			IL_136:
			num = (short)2042167296;
			short num4 = num;
			return astroPINPasswordConvertEventArgs.Target;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00070098 File Offset: 0x0006E298
		public void ValidateASTROIndividualIdEditing(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem sysRawData, global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp, string modelNumber, bool checkASKOnly = false)
		{
			short num = (short)353566721;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)939673064;
				short num3 = num;
				num = (short)1713391080;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1106837504;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_F3;
					case 1:
						goto IL_15;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs astroindividualIdEditingEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs(sysRawData, cp as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, modelNumber);
						this.ax(this, astroindividualIdEditingEventArgs);
						num = (short)919011328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A2;
				}
				IL_15:
				num = (short)60948481;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_A2:
					if (this.ax == null)
					{
						return;
					}
					num = (short)1309212674;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F3:
			num = (short)1303838720;
			short num4 = num;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000701C4 File Offset: 0x0006E3C4
		public void ValidateAstroASKRequirementEditing(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, string modelNumber)
		{
			short num = (short)215023617;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1525417222;
				short num3 = num;
				num = (short)269550854;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2086141952;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_F0;
					case 1:
						goto IL_14;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs astroASKRequirementEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs(cp, modelNumber);
						this.ay(this, astroASKRequirementEventArgs);
						num = (short)661323776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7A;
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_7A:
					num = (short)1524301825;
					if (num != 0)
					{
					}
					if (this.ay == null)
					{
						return;
					}
					num = (short)1567096834;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F0:
			num = (short)963510272;
			short num4 = num;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000702EC File Offset: 0x0006E4EC
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedASKs(bool isAttached = false)
		{
			short num = (short)443741724;
			short num2 = num;
			num = (short)232060444;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1107034113;
				if (num != 0)
				{
				}
				num = (short)444596224;
				if (num != 0)
				{
				}
				if (this.az == null)
				{
					num = (short)1177419776;
					short num3 = num;
					return new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs astroSystemKeyDataEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs();
			astroSystemKeyDataEventArgs.IsAttached = isAttached;
			this.az(this, astroSystemKeyDataEventArgs);
			return astroSystemKeyDataEventArgs.LoadedSysKeys;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000703C8 File Offset: 0x0006E5C8
		public void QueryUpdateRadio(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> devices, global::System.Collections.ObjectModel.ObservableCollection<bool> isOwnerSystemIDSupported)
		{
			short num = (short)1895956481;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1598887576;
				short num3 = num;
				num = (short)961091224;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1194917888;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_C9;
					case 1:
						goto IL_14;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs queryUpdateRadioEventArgs = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs(devices, isOwnerSystemIDSupported);
						this.a0(this, queryUpdateRadioEventArgs);
						num = (short)700121088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7A;
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_7A:
					if (this.a0 == null)
					{
						return;
					}
					num = (short)641925122;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C9:
			num = (short)2028797953;
			if (num != 0)
			{
			}
			num = (short)479789056;
			short num4 = num;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000704F0 File Offset: 0x0006E6F0
		public bool CheckForUnlimited()
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			short num;
			bool result;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)2131568862;
				short num2 = num;
				num = (short)1814571230;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)364052480;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						if (this.CheckForUnlimitedEvtHandler != null)
						{
							num = (short)1129316354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						result = this.CheckForUnlimitedEvtHandler(this, null);
						num = (short)805961729;
						if (num != 0)
						{
						}
						num = (short)1892089856;
						short num4 = num;
						num = (short)1960968192;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_68;
				}
			}
			return result;
			IL_68:
			result = false;
			num = (short)936443905;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0007061C File Offset: 0x0006E81C
		public bool CheckAstroPop25Enabled()
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs astroPop25EnabledEventArgs;
			for (;;)
			{
				IL_0A:
				num = (short)1182501984;
				short num2 = num;
				num = (short)1169656928;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_11C;
				default:
					num = (short)1629683712;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_11A;
					case 1:
						if (this.ag != null)
						{
							num = (short)984547330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 2:
					{
						this.ag(this, astroPop25EnabledEventArgs);
						num = (short)392429568;
						short num4 = num;
						num = (short)110952448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_65;
				}
			}
			IL_11A:
			IL_11C:
			return astroPop25EnabledEventArgs.Pop25Enabled;
			IL_65:
			astroPop25EnabledEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs();
			num = (short)887619585;
			if (num != 0)
			{
			}
			num = (short)724631553;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0007074C File Offset: 0x0006E94C
		public bool AstroCheckHoptionEnable(string flashcode, string hoption, string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs astrohoptionEnableEventArgs;
			for (;;)
			{
				IL_0A:
				num = (short)1784841812;
				short num2 = num;
				num = (short)929990228;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_126;
				default:
					num = (short)238092288;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_124;
					case 1:
						if (this.n != null)
						{
							num = (short)1347944450;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 2:
					{
						this.n(this, astrohoptionEnableEventArgs);
						num = (short)418906113;
						if (num != 0)
						{
						}
						num = (short)1035796480;
						short num4 = num;
						num = (short)1389494272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6A;
				}
			}
			IL_124:
			IL_126:
			return astrohoptionEnableEventArgs.IsEnable;
			IL_6A:
			astrohoptionEnableEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs(flashcode, hoption, modelNumber);
			num = (short)1777336321;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00070888 File Offset: 0x0006EA88
		public bool AstroCheckIsConvOnly(string flashcode, string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_66;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs astrohoptionEnableEventArgs;
			for (;;)
			{
				IL_0A:
				num = (short)967855906;
				short num2 = num;
				num = (short)646139682;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_11E;
				default:
					num = (short)793051136;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_11C;
					case 1:
						num = (short)344588289;
						if (num != 0)
						{
						}
						if (this.o != null)
						{
							num = (short)1937571842;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					case 2:
					{
						this.o(this, astrohoptionEnableEventArgs);
						num = (short)479854592;
						short num4 = num;
						num = (short)206176256;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_66;
				}
			}
			IL_11C:
			IL_11E:
			return astrohoptionEnableEventArgs.IsEnable;
			IL_66:
			astrohoptionEnableEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs(flashcode, null, modelNumber);
			num = (short)628883457;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000709BC File Offset: 0x0006EBBC
		public void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio dv, bool enableWritingProtect, int transportPreference, bool isWriteProtected, bool isRestoreJob, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			short num = (short)1971388417;
			if (num != 0)
			{
			}
			num = (short)244981821;
			short num2 = num;
			num = (short)2027298877;
			switch (num2 == num)
			{
			}
			num = (short)391708672;
			short num3 = num;
			num = (short)1031274496;
			if (num != 0)
			{
			}
			global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> collection = null;
			bool? flag = null;
			this.ValidateAstroWriting(dv, enableWritingProtect, transportPreference, isWriteProtected, isRestoreJob, out updatedCP, ref collection, ref flag);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00070A84 File Offset: 0x0006EC84
		public void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio dv, bool enableWritingProtect, int transportPreference, bool isWriteProtected, bool isRestoreJob, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs astroWritingEventArgs;
				switch (num)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						for (;;)
						{
							IL_B8:
							switch (num)
							{
							case 0:
								if (astroWritingEventArgs.IsUpdated)
								{
									num2 = (short)850919427;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_18B;
							case 1:
								goto IL_18B;
							case 2:
								goto IL_1A2;
							case 3:
								updatedCP = new global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest(astroWritingEventArgs.Device.WorkingCodeplug);
								num2 = (short)1792933889;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_CE;
							IL_18B:
							num2 = (short)2080636930;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1A2:
						return;
						IL_CE:
						this.h(this, astroWritingEventArgs);
						num2 = (short)2144696078;
						short num3 = num2;
						num2 = (short)389379854;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B8;
						default:
							num2 = (short)1432354816;
							if (num2 != 0)
							{
							}
							num2 = (short)1858863104;
							num = (int)((global::System.IntPtr)num2);
							goto IL_B8;
						}
					}
					finally
					{
						attachedASKs = astroWritingEventArgs.AttachedASKs;
						isSpecialKeyAttached = astroWritingEventArgs.IsSpecialKeyAttached;
					}
					goto IL_1BB;
				case 1:
					if (this.h != null)
					{
						num2 = (short)623771650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_1BB;
				}
				goto IL_1C;
				IL_1BB:
				astroWritingEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs(dv, enableWritingProtect, transportPreference, isWriteProtected, isRestoreJob, ref attachedASKs, ref isSpecialKeyAttached);
				num2 = (short)1267924992;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)1314455553;
			if (num2 != 0)
			{
			}
			num2 = (short)167837696;
			short num4 = num2;
			updatedCP = null;
			num2 = (short)2043609089;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00070C8C File Offset: 0x0006EE8C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo ReadFlashKey(string OldModelNumber, byte[] OldFlashCode)
		{
			short num = (short)1144612062;
			short num2 = num;
			num = (short)1988977886;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1304821761;
				if (num != 0)
				{
				}
				num = (short)1840644096;
				if (num != 0)
				{
				}
				if (this.i == null)
				{
					num = (short)1218838528;
					short num3 = num;
					return null;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs astroFlashKeyEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs(OldModelNumber, OldFlashCode);
			this.i(this, astroFlashKeyEventArgs);
			return astroFlashKeyEventArgs.KeyInfo;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00070D5C File Offset: 0x0006EF5C
		public bool ValidateFlashKey(string OldModelNumber, byte[] OldFlashCode)
		{
			short num = (short)666670620;
			short num2 = num;
			num = (short)666605084;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1992032257;
				if (num != 0)
				{
				}
				num = (short)402325504;
				if (num != 0)
				{
				}
				if (this.j == null)
				{
					num = (short)1372651520;
					short num3 = num;
					return false;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs astroFlashKeyEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs(OldModelNumber, OldFlashCode);
			this.j(this, astroFlashKeyEventArgs);
			return astroFlashKeyEventArgs.IsValid;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00070E30 File Offset: 0x0006F030
		public void AstroReleaseFlashKey()
		{
			short num = (short)1354563585;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)984446130;
				short num3 = num;
				num = (short)1009284274;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1227620352;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_C0;
					case 1:
						goto IL_14;
					case 2:
						this.k(this, null);
						num = (short)1466105856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_7B:
					if (this.k == null)
					{
						return;
					}
					num = (short)192544770;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C0:
			num = (short)529727489;
			if (num != 0)
			{
			}
			num = (short)2029846528;
			short num4 = num;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00070F50 File Offset: 0x0006F150
		public void DecreaseFlashKeyCount(string oldModelNumber, byte[] oldFlashCode, int decreaseCount)
		{
			short num = (short)1035534337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)926695833;
				short num3 = num;
				num = (short)1075724697;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1452670976;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_F3;
					case 1:
						goto IL_15;
					case 2:
					{
						num = (short)218103809;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs astroDecreaseKeyCountEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs(oldModelNumber, oldFlashCode, decreaseCount);
						this.l(this, astroDecreaseKeyCountEventArgs);
						num = (short)1546256384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7C;
				}
				IL_15:
				switch (0)
				{
				case 0:
					IL_7C:
					if (this.l == null)
					{
						return;
					}
					num = (short)1161756674;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F3:
			num = (short)1239678976;
			short num4 = num;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0007107C File Offset: 0x0006F27C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs AstroUpgradeCodeplug(byte[] flashCode, string iButtonSerialNumber, string modelNumber, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate sourceTemplate, byte[] codeplugFileContent, string radioHostVersion, global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware firmware, bool brefresh = false, global::ASK.Interface.ISystemKeyData systemID = null)
		{
			short num = (short)1385299969;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode data;
			for (;;)
			{
				num = (short)212446475;
				short num3 = num;
				num = (short)1702997259;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2111635456;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_160;
					case 1:
						goto IL_14;
					case 2:
						if (this.m != null)
						{
							num = (short)39583744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					}
					goto IL_A1;
				}
				IL_14:
				num = (short)1233715201;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_A1:
					data = new global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode
					{
						SourceTemplate = sourceTemplate,
						CpFileContent = codeplugFileContent,
						ModelNumber = modelNumber,
						FlashCode = flashCode,
						IButtonSerialNumber = iButtonSerialNumber,
						FirmwareVersion = ((firmware == null) ? null : firmware.PackageVersion),
						Firmware = firmware,
						bRefresh = brefresh,
						TargetTemplateCross712Upgrade = null,
						TargetTemplate = null,
						hOptionAdvancedKeyIDS = null,
						RadioHostVersion = radioHostVersion
					};
					num = (short)1362231298;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_160:
			num = (short)2025521152;
			short num4 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs result = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs(data, systemID);
			this.m(this, result);
			return result;
			IL_195:
			return null;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00071220 File Offset: 0x0006F420
		public string AstroDecodeFlashCode(byte[] flashCode)
		{
			short num = (short)1955201028;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)855395007;
				short num3 = num;
				num = (short)500714175;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)320667648;
					if (num != 0)
					{
					}
					num = (short)1001521152;
					short num4 = num;
					switch (num2)
					{
					case 0:
						goto IL_1C3;
					case 1:
						num = (short)1517944837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_170;
					case 3:
						if (flashCode.Length == 0)
						{
							num = (short)1201012736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_B6;
						}
						continue;
					case 5:
						if (flashCode != null)
						{
							num = (short)272236546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 6:
						goto IL_132;
					case 7:
						num = (short)1318715393;
						if (num != 0)
						{
						}
						if (this.p != null)
						{
							num = (short)2097158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					}
					IL_B6:
					if (flashCode != null)
					{
						num = (short)1297350657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
					IL_D2:
					num = (short)1433206791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_170:
				num = (short)58720259;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_132:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs astroDecodeFlashCodeEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs(flashCode);
			this.p(this, astroDecodeFlashCodeEventArgs);
			return astroDecodeFlashCodeEventArgs.DecodeFlashCode;
			IL_134:
			return string.Empty;
			IL_1C3:
			goto IL_134;
			IL_1C8:
			return string.Empty;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000713FC File Offset: 0x0006F5FC
		public byte[] AstroEncodeFlashCode(string flashCode)
		{
			short num = (short)300417024;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
					if (this.ai == null)
					{
						num = (short)699400194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12E;
				case 2:
					goto IL_12C;
				case 3:
					num = (short)208928769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_35;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_35:
					num = (short)1127481344;
					short num3 = num;
					num = (short)346348672;
					short num4 = num;
					num = (short)293592192;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)593297408;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(flashCode))
						{
							goto IL_F1;
						}
						num = (short)287768577;
						if (num != 0)
						{
						}
						num = (short)1833500675;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_F1:
			return null;
			IL_12C:
			goto IL_F1;
			IL_12E:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs astroEncodeFlashCodeEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs(flashCode);
			this.ai(this, astroEncodeFlashCodeEventArgs);
			return astroEncodeFlashCodeEventArgs.EncodeFlashCode;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00071554 File Offset: 0x0006F754
		public string AstroDecodeLanguageIndexToLPID(int? languageIndex)
		{
			short num = (short)835256320;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
				{
					num = (short)932970497;
					if (num != 0)
					{
					}
					if (this.q != null)
					{
						num = (short)764739586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)429778307;
					short num3 = num;
					num = (short)115991939;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					case 1:
						goto IL_13F;
					}
					goto Block_3;
				}
				case 2:
					goto IL_D6;
				case 3:
					goto IL_52;
				}
				goto IL_35;
				IL_15:
				switch (0)
				{
				case 0:
					IL_35:
					if (languageIndex == null)
					{
						num = (short)851971;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1522335745;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_52:
			return string.Empty;
			IL_D6:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs astroDecodeLanguageIndexToLPIDEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs(languageIndex.Value);
			this.q(this, astroDecodeLanguageIndexToLPIDEventArgs);
			return astroDecodeLanguageIndexToLPIDEventArgs.LanguagePackageID;
			Block_3:
			num = (short)946601984;
			short num4 = num;
			IL_13F:
			num = (short)1856962560;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x000716BC File Offset: 0x0006F8BC
		public bool CheckAstroUpgradeWithLanugagePackIsSupported(string radioFWVersion, string cvnFWVersion)
		{
			short num = (short)795468413;
			short num2 = num;
			num = (short)1216537213;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2045509632;
				if (num != 0)
				{
				}
				num = (short)1548812289;
				if (num != 0)
				{
				}
				if (this.q == null)
				{
					num = (short)497680384;
					short num3 = num;
					return false;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs astroUpgradeWithLanugagePackIsSupportedCheckEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs(radioFWVersion, cvnFWVersion);
			this.r(this, astroUpgradeWithLanugagePackIsSupportedCheckEventArgs);
			return astroUpgradeWithLanugagePackIsSupportedCheckEventArgs.IsSupported;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00071788 File Offset: 0x0006F988
		public bool CheckAstroUpgradeFWIsSupported(string cvnFWVersion, string codeplugVersion = null)
		{
			short num = (short)542091619;
			short num2 = num;
			num = (short)394897763;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)201261056;
				if (num != 0)
				{
				}
				num = (short)838795265;
				if (num != 0)
				{
				}
				if (this.q == null)
				{
					num = (short)1909784576;
					short num3 = num;
					return false;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs astroUpgradeFWCompatibleCheckEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs(cvnFWVersion);
			this.s(this, astroUpgradeFWCompatibleCheckEventArgs);
			return astroUpgradeFWCompatibleCheckEventArgs.IsCompatible;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0007185C File Offset: 0x0006FA5C
		public bool CheckIsSupportedLanguagePack(string fwVersion, int? templateLanguageIndex)
		{
			short num = (short)175702016;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1496121344;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					if (templateLanguageIndex != null)
					{
						num = (short)1616510978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_14C;
				case 3:
					num = (short)107282433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_84;
				IL_14:
				num = (short)625868801;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
				{
					IL_84:
					num = (short)1655326982;
					short num4 = num;
					num = (short)1778665734;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1331822592;
						if (num != 0)
						{
						}
						if (this.w == null)
						{
							return false;
						}
						num = (short)283705347;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_14C:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs astroLanguageCompatibleCheckEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs(fwVersion, templateLanguageIndex.Value);
			this.w(this, astroLanguageCompatibleCheckEventArgs);
			return astroLanguageCompatibleCheckEventArgs.IsCompatible;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000719B8 File Offset: 0x0006FBB8
		public bool CheckIsSupportedLanguagePack(string fwVersion, int? templateLanguageIndex, ref string stat)
		{
			short num = (short)457023748;
			short num2 = num;
			num = (short)177840388;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D0:
				num = (short)1154220032;
				short num3 = num;
				num = (short)836894722;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)420872192;
				if (num != 0)
				{
				}
				num = (short)2011365379;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_A3;
				case 1:
					goto IL_132;
				case 2:
					if (templateLanguageIndex != null)
					{
						num = (short)1609826305;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				}
				IL_82:
				if (this.w == null)
				{
					return false;
				}
				num = (short)264634368;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			goto IL_D0;
			IL_132:
			num = (short)1670709249;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs astroLanguageCompatibleCheckEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs(fwVersion, templateLanguageIndex.Value, true);
			this.w(this, astroLanguageCompatibleCheckEventArgs);
			stat = astroLanguageCompatibleCheckEventArgs.Stat;
			return astroLanguageCompatibleCheckEventArgs.IsCompatible;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00071B24 File Offset: 0x0006FD24
		public bool CheckAstroFWIsSupportedCurrentLanguagePack(string fwVersion, string lpCompatibleVerion, int? templateLanguageIndex)
		{
			int a_ = 7;
			short num = (short)525795330;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs astroLanguageCompatibleCheckEventArgs;
					if (astroLanguageCompatibleCheckEventArgs.IsCompatible)
					{
						num = (short)889651201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FC;
				}
				case 1:
					goto IL_E4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					continue;
				case 3:
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs astroLanguageCompatibleCheckEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs(fwVersion, templateLanguageIndex.Value);
					this.w(this, astroLanguageCompatibleCheckEventArgs);
					num = (short)163250176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.w != null)
					{
						num = (short)1403322371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					goto IL_7F;
				}
				IL_47:
				if (!new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뚝ﲟ욡辣瘟蚧좫薭鲱튵鎷鎹", a_)).Match(fwVersion).Success)
				{
					num = (short)705232901;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1235025924;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7F:
			throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateDirectMessageCommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceHasIncorrectFWVersion, fwVersion));
			IL_E4:
			return string.Compare(fwVersion, 1, lpCompatibleVerion, 1, 8, global::System.StringComparison.CurrentCulture) >= 0;
			IL_FC:
			num = (short)2108817408;
			short num3 = num;
			num = (short)1426980333;
			short num4 = num;
			num = (short)1977351661;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				num = (short)613548033;
				if (num != 0)
				{
				}
				num = (short)90505216;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00071D0C File Offset: 0x0006FF0C
		public bool AnslysisPCRModelNumber(string modelNumber)
		{
			if (this.y != null)
			{
				short num = (short)5673155;
				short num2 = num;
				num = (short)1338675395;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)548732928;
					short num3 = num;
					num = (short)1461780480;
					if (num != 0)
					{
					}
					num = (short)2124349441;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs modelTierEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs();
					modelTierEventArgs.ModelNumber = modelNumber;
					this.y(this, modelTierEventArgs);
					return modelTierEventArgs.SupportLanguagePack;
				}
				}
			}
			return false;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00071DE4 File Offset: 0x0006FFE4
		public string DownloadPackage(global::System.Guid packageUuids)
		{
			short num = (short)1190891027;
			short num2 = num;
			num = (short)582716947;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1908015104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)705757184;
			if (num != 0)
			{
			}
			num = (short)447021057;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).DownLoadAstroPackage(packageUuids);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00071E9C File Offset: 0x0007009C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType)
		{
			short num = (short)1259817996;
			short num2 = num;
			num = (short)957434892;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1815150592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1755316225;
			if (num != 0)
			{
			}
			num = (short)659881984;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListPackage(packageType, null);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00071F58 File Offset: 0x00070158
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> GetASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string compatibleVersion)
		{
			short num = (short)1092421415;
			short num2 = num;
			num = (short)687474471;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1595015168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1222574081;
			if (num != 0)
			{
			}
			num = (short)202309632;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack, compatibleVersion);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00072010 File Offset: 0x00070210
		public global::Motorola.CommonCPS.Server.EntityModel.Package AnalysisPackageInfo(string filePath)
		{
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Package result;
			try
			{
				num = (short)1949174458;
				short num2 = num;
				num = (short)1445792442;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_BF:
					num = (short)1083899906;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)441909248;
					if (num != 0)
					{
					}
					num = (short)1161035779;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_9C;
					case 1:
						goto IL_EF;
					case 2:
						goto IL_D3;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					IL_80:
					if (this.t != null)
					{
						num = (short)90112000;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						result = null;
						num = (short)1786576897;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_9C:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs analysisPackageEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs();
				analysisPackageEventArgs.filePath = filePath;
				this.t(this, analysisPackageEventArgs);
				result = analysisPackageEventArgs.PackageInfo;
				goto IL_BF;
				IL_D3:
				IL_EF:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo, ex);
			}
			num = (short)26148865;
			if (num != 0)
			{
			}
			num = (short)487063552;
			short num4 = num;
			return result;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0007218C File Offset: 0x0007038C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> AnalysisListPackageInfo(string filePath)
		{
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> result;
			try
			{
				num = (short)1153918776;
				short num2 = num;
				num = (short)937649976;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_BF:
					num = (short)1843068930;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1510932480;
					if (num != 0)
					{
					}
					num = (short)892207107;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_9C;
					case 1:
						goto IL_F3;
					case 2:
						goto IL_D3;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					IL_80:
					if (this.t != null)
					{
						num = (short)1152516096;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						result = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
						num = (short)728367105;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_9C:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs analysisPackageEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs();
				analysisPackageEventArgs.filePath = filePath;
				this.t(this, analysisPackageEventArgs);
				result = analysisPackageEventArgs.AstroFWPackageInfos;
				goto IL_BF;
				IL_D3:
				IL_F3:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo, ex);
			}
			num = (short)2089418753;
			if (num != 0)
			{
			}
			num = (short)1580924928;
			short num4 = num;
			return result;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00072308 File Offset: 0x00070508
		public bool CheckPcrLanguagePackCompatible(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily, string languagePackId, string codeplugVersion)
		{
			if (this.x != null)
			{
				short num = (short)1577729743;
				short num2 = num;
				num = (short)207175375;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2137718784;
					short num3 = num;
					num = (short)1518075904;
					if (num != 0)
					{
					}
					num = (short)327483393;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs pcrLanguagePackCompatibleCheckEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs();
					pcrLanguagePackCompatibleCheckEventArgs.LanguagePackFamily = languagePackFamily;
					pcrLanguagePackCompatibleCheckEventArgs.LanguagePackId = languagePackId;
					pcrLanguagePackCompatibleCheckEventArgs.CodeplugVersion = codeplugVersion;
					this.x(this, pcrLanguagePackCompatibleCheckEventArgs);
					return pcrLanguagePackCompatibleCheckEventArgs.IsCompatible;
				}
				}
			}
			return true;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000723EC File Offset: 0x000705EC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> LanguagePackInfos()
		{
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> result;
			try
			{
				num = (short)257817379;
				short num2 = num;
				num = (short)1244724003;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B7:
					num = (short)1037697026;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)889716736;
					if (num != 0)
					{
					}
					num = (short)60293123;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_9B;
					case 1:
						goto IL_E3;
					case 2:
						goto IL_CB;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					IL_7F:
					if (this.u != null)
					{
						num = (short)493879296;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						result = null;
						num = (short)1838088193;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_9B:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs listLpPackageEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs();
				this.u(this, listLpPackageEventArgs);
				result = listLpPackageEventArgs.LanguagePacks;
				goto IL_B7;
				IL_CB:
				IL_E3:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_RMCDidntFindPackageToImport, ex);
			}
			num = (short)1721106433;
			if (num != 0)
			{
			}
			num = (short)143523840;
			short num4 = num;
			return result;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00072558 File Offset: 0x00070758
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> TTSLanguagePackInfos()
		{
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> result;
			try
			{
				num = (short)702796705;
				short num2 = num;
				num = (short)1105777569;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B6:
					num = (short)1797718018;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1209139200;
					if (num != 0)
					{
					}
					num = (short)729219075;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_9A;
					case 1:
						goto IL_E3;
					case 2:
						goto IL_CB;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					IL_7E:
					if (this.v != null)
					{
						num = (short)525860864;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						result = null;
						num = (short)634060801;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_9A:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs listTTSLpPackageEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs();
				this.v(this, listTTSLpPackageEventArgs);
				result = listTTSLpPackageEventArgs.TTSLanguagePacks;
				goto IL_B6;
				IL_CB:
				goto IL_124;
				IL_E3:
				num = (short)1185546241;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_RMCDidntFindPackageToImport, ex);
			}
			IL_124:
			num = (short)506265600;
			short num4 = num;
			return result;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000726D0 File Offset: 0x000708D0
		public string GetVaInstallationPath()
		{
			short num;
			string result;
			try
			{
				num = (short)1169244073;
				short num2 = num;
				num = (short)1133723561;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B9:
					num = (short)1182859266;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2047016960;
					if (num != 0)
					{
					}
					num = (short)1733361667;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_9D;
					case 1:
						goto IL_F1;
					case 2:
						goto IL_CE;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					IL_80:
					if (this.aa != null)
					{
						num = (short)1880358912;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						result = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
						num = (short)1987510273;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_9D:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs getVAInstallationPathEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs();
				this.aa(this, getVAInstallationPathEventArgs);
				result = getVAInstallationPathEventArgs.VaPath;
				goto IL_B9;
				IL_CE:
				IL_F1:;
			}
			catch
			{
				result = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
			}
			num = (short)1042284545;
			if (num != 0)
			{
			}
			num = (short)1505296384;
			short num4 = num;
			return result;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0007283C File Offset: 0x00070A3C
		public string GetTTSInstallationPath()
		{
			short num;
			string result;
			try
			{
				num = (short)1924819888;
				short num2 = num;
				num = (short)1627220912;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D6:
					num = (short)1694629889;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1970470912;
					if (num != 0)
					{
					}
					num = (short)492306435;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs getTTSInstallationPathEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs();
						this.ab(this, getTTSInstallationPathEventArgs);
						result = getTTSInstallationPathEventArgs.ttsPath;
						num = (short)1438515202;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_EF;
					case 2:
						goto IL_CC;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					IL_7F:
					if (this.ab == null)
					{
						goto IL_CE;
					}
					num = (short)165675008;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_CC:
				goto IL_FC;
				IL_CE:
				result = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
				goto IL_D6;
				IL_EF:;
			}
			catch
			{
				result = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
			}
			IL_FC:
			num = (short)691077120;
			short num4 = num;
			num = (short)798883841;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000729A8 File Offset: 0x00070BA8
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadVAPackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)26738688;
			switch (num)
			{
			default:
			{
				num = (short)424345600;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						num = (short)43515905;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 1:
						try
						{
							num = (short)1672085505;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.Package result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1843527684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_D9;
									}
									continue;
								case 2:
									goto IL_175;
								case 3:
									goto IL_175;
								case 4:
									if (package.RMFile.Url != null)
									{
										num = (short)113049606;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_131;
								case 5:
									goto IL_1A2;
								case 6:
									text = package.RMFile.Url;
									num = (short)1765998594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_D9:
								if (package.RMFile != null)
								{
									num = (short)14417920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_131:
								text = null;
								num = (short)2121531395;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_175:
								package = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.CheckAndUploadOnePackage(text, package);
								result = package;
								num = (short)2083520517;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A2:
							return result;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
							throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
						}
						finally
						{
							try
							{
								num = (short)1499332609;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2B4;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_20D;
										}
										continue;
									case 2:
									{
										num = (short)33995170;
										short num3 = num;
										num = (short)1021032866;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_298;
										default:
											num = (short)113442816;
											if (num != 0)
											{
											}
											global::System.IO.File.Delete(text);
											num = (short)770048003;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_298;
									}
									IL_20D:
									if (string.IsNullOrEmpty(text))
									{
										num = (short)413138946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_29A:
									num = (short)373620736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_298:
									goto IL_29A;
								}
								IL_2B4:;
							}
							catch
							{
							}
						}
						goto IL_2BA;
					case 2:
						goto IL_92;
					}
					IL_77:
					if (package == null)
					{
						num = (short)1790443522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2BA:
					num = (short)859635712;
					short num4 = num;
					text = null;
					num = (short)375783425;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_92:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Package_NotExist_Error);
			}
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00072D10 File Offset: 0x00070F10
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadCACertificatePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1515847680;
			switch (num)
			{
			default:
			{
				num = (short)30343168;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1100021761;
					if (num != 0)
					{
					}
					string text;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					case 1:
						try
						{
							num = (short)100401153;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.Package result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)931921924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DC;
									}
									continue;
								case 2:
									goto IL_178;
								case 3:
									goto IL_178;
								case 4:
									if (package.RMFile.Url != null)
									{
										num = (short)518258694;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_136;
								case 5:
									goto IL_1A5;
								case 6:
									text = package.RMFile.Url;
									num = (short)616235010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_DC:
								if (package.RMFile != null)
								{
									num = (short)647364608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_136:
								text = null;
								num = (short)611319811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_178:
								package = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.CheckAndUploadOnePackage(text, package);
								result = package;
								num = (short)36634629;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A5:
							return result;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
							throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
						}
						finally
						{
							try
							{
								num = (short)921632769;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2B4;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_20F;
										}
										continue;
									case 2:
									{
										num = (short)1462027585;
										short num3 = num;
										num = (short)461292865;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_29A;
										default:
											num = (short)284033024;
											if (num != 0)
											{
											}
											global::System.IO.File.Delete(text);
											num = (short)277086211;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_29A;
									}
									IL_20F:
									if (string.IsNullOrEmpty(text))
									{
										num = (short)49872898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_29C:
									num = (short)1238499328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_29A:
									goto IL_29C;
								}
								IL_2B4:;
							}
							catch
							{
							}
						}
						goto IL_2BA;
					case 2:
						goto IL_94;
					}
					IL_79:
					if (package == null)
					{
						num = (short)2063859714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2BA:
					num = (short)661061632;
					short num4 = num;
					text = null;
					num = (short)139001857;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_94:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Package_NotExist_Error);
			}
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00073078 File Offset: 0x00071278
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadDVRSFilePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1341063168;
			switch (num)
			{
			default:
			{
				num = (short)1280180224;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 1:
						try
						{
							num = (short)1281949697;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.Package result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)649003012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B3;
									}
									continue;
								case 2:
									goto IL_150;
								case 3:
									goto IL_150;
								case 4:
									if (package.RMFile.Url != null)
									{
										num = (short)303955974;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_10C;
								case 5:
									goto IL_17D;
								case 6:
									text = package.RMFile.Url;
									num = (short)989855746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B3:
								if (package.RMFile != null)
								{
									num = (short)240386048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10C:
								text = null;
								num = (short)538312707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_150:
								package = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.CheckAndUploadOnePackage(text, package);
								result = package;
								num = (short)1835532293;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17D:
							return result;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
							throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
						}
						finally
						{
							try
							{
								num = (short)388694017;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_291;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1E7;
										}
										continue;
									case 2:
									{
										num = (short)310336932;
										short num3 = num;
										num = (short)1174560164;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_276;
										default:
											num = (short)1476198400;
											if (num != 0)
											{
											}
											global::System.IO.File.Delete(text);
											num = (short)412876803;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_276;
									}
									IL_1E7:
									if (string.IsNullOrEmpty(text))
									{
										num = (short)1587281922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_278:
									num = (short)388366336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_276:
									goto IL_278;
								}
								IL_291:;
							}
							catch
							{
							}
						}
						goto IL_297;
					case 2:
						goto IL_6C;
					}
					IL_50:
					if (package == null)
					{
						num = (short)1394671618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_297:
					text = null;
					num = (short)838926336;
					short num4 = num;
					num = (short)965541889;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6C:
				num = (short)614203393;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Package_NotExist_Error);
			}
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000733E4 File Offset: 0x000715E4
		public string UpdatePcrFwDescription(global::System.Collections.Generic.Dictionary<string, string> MapForDescription, string PcrFwDescription)
		{
			short num = (short)1374842091;
			short num2 = num;
			num = (short)808283371;
			string fwdescription;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return fwdescription;
			case 1:
				break;
			default:
			{
				num = (short)1136721920;
				short num3 = num;
				break;
			}
			}
			num = (short)1380712448;
			if (num != 0)
			{
			}
			num = (short)1073938432;
			switch (num)
			{
			default:
			{
				num = (short)589168641;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs updatePcrFwDescriptionArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs();
				updatePcrFwDescriptionArgs.MapForDescription = MapForDescription;
				updatePcrFwDescriptionArgs.FWDescription = PcrFwDescription;
				try
				{
					num = (short)642383873;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_164;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_103;
							}
							continue;
						case 2:
							this.ad(this, updatePcrFwDescriptionArgs);
							num = (short)1881604099;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_147;
						}
						IL_103:
						if (this.ad != null)
						{
							num = (short)1359020034;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_147:
						fwdescription = updatePcrFwDescriptionArgs.FWDescription;
						num = (short)2093809664;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_164:;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
				}
				break;
			}
			}
			return fwdescription;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00073594 File Offset: 0x00071794
		public bool IsFirmwareUpgradeIncludeEqual(int productFamily, string ModelNumber, string CFS)
		{
			while (this.ae == null)
			{
				short num = (short)2127762837;
				short num2 = num;
				num = (short)1829770645;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)845414400;
					short num3 = num;
					num = (short)811204609;
					if (num != 0)
					{
					}
					num = (short)1378680832;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs firmwareUpgradeIncludeEqualEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs(productFamily, ModelNumber, CFS);
			this.ae(this, firmwareUpgradeIncludeEqualEventArgs);
			return firmwareUpgradeIncludeEqualEventArgs.IsIncludeEqual;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00073668 File Offset: 0x00071868
		public bool IsSameFWVersionUpgradeSupported(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, byte[] codeplugContent)
		{
			short num;
			while (this.af == null)
			{
				num = (short)293718613;
				short num2 = num;
				num = (short)292473429;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)726401024;
					short num3 = num;
					break;
				}
				}
				num = (short)486277120;
				if (num != 0)
				{
				}
				return false;
			}
			num = (short)235405313;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs isSameFWVersionUpgradeSupportedEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs(codeplug, codeplugContent);
			this.af(this, isSameFWVersionUpgradeSupportedEventArgs);
			return isSameFWVersionUpgradeSupportedEventArgs.IsSupported;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00073738 File Offset: 0x00071938
		public T[] XMLToEntityCollections<T>(string xmlData)
		{
			short num = (short)1714814976;
			short num2 = num;
			num = (short)490536961;
			if (num != 0)
			{
			}
			num = (short)1604735766;
			short num3 = num;
			num = (short)1407537942;
			switch (num3 == num)
			{
			}
			num = (short)313393152;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.XMLToEntityCollections<T>(xmlData);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000737E8 File Offset: 0x000719E8
		public string EntityCollectionsToXML<T>(T[] obj)
		{
			short num = (short)697565184;
			short num2 = num;
			num = (short)435926447;
			short num3 = num;
			num = (short)1381676463;
			switch (num3 == num)
			{
			}
			num = (short)1234763776;
			if (num != 0)
			{
			}
			num = (short)1830486017;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.EntityCollectionsToXML<T>(obj);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00073898 File Offset: 0x00071A98
		public string GetLocalizedFeatureName(int featureNameTag)
		{
			short num = (short)1674444801;
			if (num != 0)
			{
			}
			num = (short)2039545856;
			short num2 = num;
			num = (short)2110808310;
			short num3 = num;
			num = (short)1192911094;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)81788928;
				if (num != 0)
				{
				}
				result = null;
				if (this.ah != null)
				{
					try
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs getLocalizedFeatureNameArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs
						{
							FeatureNameTag = featureNameTag
						};
						this.ah(this, getLocalizedFeatureNameArgs);
						result = getLocalizedFeatureNameArgs.LocalizedFeatureName;
					}
					catch (global::System.Exception)
					{
					}
				}
				break;
			}
			return result;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00073984 File Offset: 0x00071B84
		public string ParseFeatureCode(int featureCode, string modelNumber)
		{
			short num = (short)826605568;
			short num2 = num;
			num = (short)1612450575;
			short num3 = num;
			num = (short)342231823;
			switch (num3 == num)
			{
			}
			num = (short)1399914497;
			if (num != 0)
			{
			}
			num = (short)768475136;
			if (num != 0)
			{
			}
			global::RFResourceRepository.RFResourceHelperBase rfresourceHelperBase = global::RFResourceRepository.ASTROResourceHelper.Instance();
			global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs astro_OptionIDs = (global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs)featureCode;
			return rfresourceHelperBase.GetRFResourceValueByResourceID(astro_OptionIDs.ToString(), null);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00073A48 File Offset: 0x00071C48
		public string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus fs)
		{
			short num;
			for (;;)
			{
				num = (short)1426128897;
				if (num != 0)
				{
				}
				if (this.aj == null)
				{
					break;
				}
				num = (short)585568098;
				short num2 = num;
				num = (short)2074087266;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_9C;
				}
				goto Block_1;
			}
			return fs.ToString();
			Block_1:
			num = (short)1381302272;
			short num3 = num;
			IL_9C:
			num = (short)631898112;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs parseFeatureStatusEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs(fs);
			this.ak(this, parseFeatureStatusEventArgs);
			return parseFeatureStatusEventArgs.FeatureStatusDescription;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00073B24 File Offset: 0x00071D24
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> FilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> originalLicenseList)
		{
			while (this.al != null)
			{
				short num = (short)416088065;
				if (num != 0)
				{
				}
				num = (short)1723074206;
				short num2 = num;
				num = (short)1977353886;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1827602432;
					short num3 = num;
					break;
				}
				}
				num = (short)695009280;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs filterLicenseEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs(originalLicenseList);
				this.al(this, filterLicenseEventArgs);
				return filterLicenseEventArgs.LicenseList;
			}
			return originalLicenseList;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00073BF4 File Offset: 0x00071DF4
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrRadioEntitledLicenseSummary> PCRFilterLicenseList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList)
		{
			while (this.am != null)
			{
				short num = (short)1043772077;
				short num2 = num;
				num = (short)332378797;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2047148032;
					short num3 = num;
					num = (short)691929089;
					if (num != 0)
					{
					}
					num = (short)1549271040;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs pcrfilterLicenseEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs(licenseList);
					this.am(this, pcrfilterLicenseEventArgs);
					return pcrfilterLicenseEventArgs.LicenseSummaryList;
				}
				}
			}
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00073CC4 File Offset: 0x00071EC4
		public void HandleGlobalException(global::System.Exception ex)
		{
			short num = (short)1198325760;
			short num2 = num;
			num = (short)1018143760;
			short num3 = num;
			num = (short)1078502416;
			switch (num3 == num)
			{
			}
			num = (short)846921728;
			if (num != 0)
			{
			}
			num = (short)1640431617;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.Receive(ex, true, false, true);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00073D74 File Offset: 0x00071F74
		public global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter GenerateLicenseFilter(global::System.Collections.Generic.IList<string> selectedlicenseGroup, global::System.Collections.Generic.IList<string> newSelectedLicenseGroup, out global::System.Collections.Generic.IList<string> toUnselectedLicenseGroup)
		{
			short num;
			while (this.an != null)
			{
				num = (short)517205710;
				short num2 = num;
				num = (short)630910670;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1664221184;
					short num3 = num;
					break;
				}
				}
				num = (short)1376714752;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs generateLicenseFilterEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs(selectedlicenseGroup);
				this.an(this, generateLicenseFilterEventArgs);
				toUnselectedLicenseGroup = null;
				return generateLicenseFilterEventArgs.LicenseFilter;
			}
			num = (short)1831272449;
			if (num != 0)
			{
			}
			toUnselectedLicenseGroup = null;
			return null;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00073E48 File Offset: 0x00072048
		public global::Motorola.CommonCPS.Server.EntityModel.Template UpgradeTemplateByFeatures(global::Motorola.CommonCPS.Server.EntityModel.Template template, string sourceCFS, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioLicenses, out bool needUpgradeFirmware)
		{
			short num = (short)497090562;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs upgradeTemplateByFeaturesEventArgs;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2144010241;
					if (num != 0)
					{
					}
					if (upgradeTemplateByFeaturesEventArgs.Result == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num = (short)2085814275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)230440482;
					short num3 = num;
					num = (short)182074914;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
						goto IL_8E;
					}
					break;
				}
				case 1:
					upgradeTemplateByFeaturesEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs(template, sourceCFS, radioLicenses);
					this.ao(this, upgradeTemplateByFeaturesEventArgs);
					goto IL_FF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 3:
					goto IL_160;
				}
				IL_36:
				if (this.ao != null)
				{
					num = (short)284491777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_165;
				IL_FF:
				num = (short)148963328;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8E:
			num = (short)466092032;
			if (num != 0)
			{
			}
			num = (short)1358102528;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(upgradeTemplateByFeaturesEventArgs.Result);
			IL_160:
			needUpgradeFirmware = upgradeTemplateByFeaturesEventArgs.NeedUpgradeFirmware;
			return upgradeTemplateByFeaturesEventArgs.UpgradedTemplate;
			IL_165:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00073FC0 File Offset: 0x000721C0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> ApplyRadioWithFeatures(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> radioLicenses, out bool canUpgraded, out bool anyInvalid, out string warning)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs applyRadioWithFeaturesEventArgs;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CB;
				case 1:
					if (applyRadioWithFeaturesEventArgs.WarningCode != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1113653252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8C;
				case 2:
				{
					num2 = (short)371195904;
					short num3 = num2;
					num2 = (short)559296739;
					short num4 = num2;
					num2 = (short)49164515;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_93;
					default:
						num2 = (short)67633153;
						if (num2 != 0)
						{
						}
						num2 = (short)976617472;
						if (num2 != 0)
						{
						}
						canUpgraded = true;
						applyRadioWithFeaturesEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs(radio, radioLicenses, canUpgraded);
						this.ap(this, applyRadioWithFeaturesEventArgs);
						canUpgraded = applyRadioWithFeaturesEventArgs.CanUpgraded;
						anyInvalid = applyRadioWithFeaturesEventArgs.AnyInvalid;
						num2 = (short)629342209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (this.ap != null)
					{
						num2 = (short)2043674626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AB;
				case 4:
					goto IL_93;
				}
				goto IL_24;
				IL_93:
				warning = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(applyRadioWithFeaturesEventArgs.WarningCode.ToString());
				num2 = (short)1641218048;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8C:
			return applyRadioWithFeaturesEventArgs.NewLicensesRequest;
			IL_CB:
			goto IL_8C;
			IL_1AB:
			canUpgraded = false;
			anyInvalid = false;
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>();
			IL_24:
			warning = string.Empty;
			num2 = (short)1555693571;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00074184 File Offset: 0x00072384
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PopulateRadioFeaturesFromCodeplug(string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.Template template, out int cfsModelType)
		{
			cfsModelType = 0;
			if (this.aq != null)
			{
				short num;
				for (;;)
				{
					num = (short)655425536;
					short num2 = num;
					num = (short)534970369;
					if (num != 0)
					{
					}
					num = (short)698578138;
					short num3 = num;
					num = (short)1175155930;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_97;
					}
				}
				IL_97:
				num = (short)1238564864;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs populateRadioFeaturesFromCodeplugEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs();
				global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
				populateRadioFeaturesFromCodeplugEventArgs.ModelNumber = apxtemplate.ModelNumber;
				populateRadioFeaturesFromCodeplugEventArgs.AstroPurchasedFlashCode = apxtemplate.AstroPurchasedFlashCode;
				this.aq(this, populateRadioFeaturesFromCodeplugEventArgs);
				cfsModelType = populateRadioFeaturesFromCodeplugEventArgs.CfsModelType;
				return populateRadioFeaturesFromCodeplugEventArgs.featuresRequest;
			}
			return null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00074280 File Offset: 0x00072480
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs PopulateRadioFeaturesFromFlashCode(byte[] flashCode, string modelNumber)
		{
			short num;
			if (this.ar != null)
			{
				for (;;)
				{
					num = (short)591527936;
					short num2 = num;
					num = (short)148343986;
					short num3 = num;
					num = (short)1276087474;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				IL_6C:
				num = (short)2077622272;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs result = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs(flashCode, modelNumber);
				this.ar(this, result);
				return result;
			}
			num = (short)748355585;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00074350 File Offset: 0x00072550
		public void ParseRadioFeature(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary featureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicense)
		{
			if (this.@as != null)
			{
				short num;
				for (;;)
				{
					num = (short)1890189312;
					short num2 = num;
					num = (short)1144730662;
					short num3 = num;
					num = (short)1422406694;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6A;
					}
				}
				IL_6A:
				num = (short)2056192001;
				if (num != 0)
				{
				}
				num = (short)1818558464;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs parseRadioFeatureEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs(featureSummary, radioLicense);
				this.@as(this, parseRadioFeatureEventArgs);
				return;
			}
			radioLicense.FeatureName = string.Empty;
			radioLicense.FeatureStatus = string.Empty;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00074430 File Offset: 0x00072630
		public global::System.Collections.Generic.Dictionary<int, string> AstroParseFlashCode(string flashCode, string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<int, string> result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_F8;
				case 1:
					if (this.at != null)
					{
						num2 = (short)211156992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				}
				goto IL_1C;
			}
			IL_F8:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs astroParseFlashCodeEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs(flashCode, modelNumber);
			this.at(this, astroParseFlashCodeEventArgs);
			result = astroParseFlashCodeEventArgs.FeatureTagNameList;
			goto IL_116;
			IL_1C:
			num2 = (short)386072577;
			if (num2 != 0)
			{
			}
			result = new global::System.Collections.Generic.Dictionary<int, string>();
			num2 = (short)1476176759;
			short num3 = num2;
			num2 = (short)1143647095;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_116:
				num2 = (short)2049179650;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)732364800;
				short num4 = num2;
				num2 = (short)1940062208;
				if (num2 != 0)
				{
				}
				num2 = (short)1021509633;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00074570 File Offset: 0x00072770
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> RadioCfsChangesInUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			if (this.au != null)
			{
				short num;
				for (;;)
				{
					num = (short)874119168;
					short num2 = num;
					num = (short)775946241;
					if (num != 0)
					{
					}
					num = (short)356033764;
					short num3 = num;
					num = (short)865641700;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_91;
					}
				}
				IL_91:
				num = (short)491520000;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs radioCfsChangesInUpgradeEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs(radio, codeplug, template);
				this.au(this, radioCfsChangesInUpgradeEventArgs);
				return radioCfsChangesInUpgradeEventArgs.FeaturesChanges;
			}
			return null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00074644 File Offset: 0x00072844
		public void ParseArchiveToPBA(global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs args)
		{
			short num = (short)64225281;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.a1(this, args);
					num = (short)1990852609;
					if (num != 0)
					{
					}
					num = (short)1723138050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					return;
				}
				IL_30:
				if (this.a1 == null)
				{
					break;
				}
				num = (short)1355286296;
				short num3 = num;
				num = (short)1894909720;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1476001792;
					short num4 = num;
					num = (short)702742528;
					if (num != 0)
					{
					}
					num = (short)2033188864;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0007476C File Offset: 0x0007296C
		public bool IsFreon(string modelNumber)
		{
			if (this.aw != null)
			{
				short num;
				for (;;)
				{
					num = (short)392298496;
					short num2 = num;
					num = (short)1570334040;
					short num3 = num;
					num = (short)139355480;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6D;
					}
				}
				IL_6D:
				num = (short)315883521;
				if (num != 0)
				{
				}
				num = (short)2004287488;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs isFreonEventArgs = new global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs(modelNumber);
				this.aw(this, isFreonEventArgs);
				return isFreonEventArgs.IsFreon;
			}
			return false;
		}

		// Token: 0x04000114 RID: 276
		private static global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface a;

		// Token: 0x04000115 RID: 277
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> b;

		// Token: 0x04000116 RID: 278
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> c;

		// Token: 0x04000117 RID: 279
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDeviceEventArgs> d;

		// Token: 0x04000118 RID: 280
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ExportDVRSEventArgs> e;

		// Token: 0x04000119 RID: 281
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.DeviceEventArgs> f;

		// Token: 0x0400011A RID: 282
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroCompatibilityEventArgs> g;

		// Token: 0x0400011B RID: 283
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroWritingEventArgs> h;

		// Token: 0x0400011C RID: 284
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> i;

		// Token: 0x0400011D RID: 285
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroFlashKeyEventArgs> j;

		// Token: 0x0400011E RID: 286
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler k;

		// Token: 0x0400011F RID: 287
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecreaseKeyCountEventArgs> l;

		// Token: 0x04000120 RID: 288
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs> m;

		// Token: 0x04000121 RID: 289
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> n;

		// Token: 0x04000122 RID: 290
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROHoptionEnableEventArgs> o;

		// Token: 0x04000123 RID: 291
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeFlashCodeEventArgs> p;

		// Token: 0x04000124 RID: 292
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroDecodeLanguageIndexToLPIDEventArgs> q;

		// Token: 0x04000125 RID: 293
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs> r;

		// Token: 0x04000126 RID: 294
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeFWCompatibleCheckEventArgs> s;

		// Token: 0x04000127 RID: 295
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AnalysisPackageEventArgs> t;

		// Token: 0x04000128 RID: 296
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListLpPackageEventArgs> u;

		// Token: 0x04000129 RID: 297
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ListTTSLpPackageEventArgs> v;

		// Token: 0x0400012A RID: 298
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroLanguageCompatibleCheckEventArgs> w;

		// Token: 0x0400012B RID: 299
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PcrLanguagePackCompatibleCheckEventArgs> x;

		// Token: 0x0400012C RID: 300
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ModelTierEventArgs> y;

		// Token: 0x0400012D RID: 301
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPINPasswordConvertEventArgs> z;

		// Token: 0x0400012E RID: 302
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetVAInstallationPathEventArgs> aa;

		// Token: 0x0400012F RID: 303
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetTTSInstallationPathEventArgs> ab;

		// Token: 0x04000130 RID: 304
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetPcrUserRegionArgs> ac;

		// Token: 0x04000131 RID: 305
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdatePcrFwDescriptionArgs> ad;

		// Token: 0x04000132 RID: 306
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FirmwareUpgradeIncludeEqualEventArgs> ae;

		// Token: 0x04000133 RID: 307
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsSameFWVersionUpgradeSupportedEventArgs> af;

		// Token: 0x04000134 RID: 308
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroPop25EnabledEventArgs> ag;

		// Token: 0x04000135 RID: 309
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GetLocalizedFeatureNameArgs> ah;

		// Token: 0x04000136 RID: 310
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroEncodeFlashCodeEventArgs> ai;

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureCodeEventArgs> aj;

		// Token: 0x04000138 RID: 312
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseFeatureStatusEventArgs> ak;

		// Token: 0x04000139 RID: 313
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.FilterLicenseEventArgs> al;

		// Token: 0x0400013A RID: 314
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PCRFilterLicenseEventArgs> am;

		// Token: 0x0400013B RID: 315
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.GenerateLicenseFilterEventArgs> an;

		// Token: 0x0400013C RID: 316
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.UpgradeTemplateByFeaturesEventArgs> ao;

		// Token: 0x0400013D RID: 317
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ApplyRadioWithFeaturesEventArgs> ap;

		// Token: 0x0400013E RID: 318
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromCodeplugEventArgs> aq;

		// Token: 0x0400013F RID: 319
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.PopulateRadioFeaturesFromFlashCodeEventArgs> ar;

		// Token: 0x04000140 RID: 320
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ParseRadioFeatureEventArgs> @as;

		// Token: 0x04000141 RID: 321
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroParseFlashCodeEventArgs> at;

		// Token: 0x04000142 RID: 322
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioCfsChangesInUpgradeEventArgs> au;

		// Token: 0x04000143 RID: 323
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.BindingServerLanguagePackEventArgs> av;

		// Token: 0x04000144 RID: 324
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.IsFreonEventArgs> aw;

		// Token: 0x04000145 RID: 325
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROIndividualIdEditingEventArgs> ax;

		// Token: 0x04000146 RID: 326
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroASKRequirementEventArgs> ay;

		// Token: 0x04000147 RID: 327
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroSystemKeyDataEventArgs> az;

		// Token: 0x04000148 RID: 328
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS.QueryUpdateRadioEventArgs> a0;

		// Token: 0x04000149 RID: 329
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.SharedServices.OpenFileEventArgs> a1;

		// Token: 0x0400014A RID: 330
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.UpdateProgressToRMCDelegate a2;

		// Token: 0x0400014B RID: 331
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.SaveCodeplugToRMCDelegate a3;

		// Token: 0x0400014C RID: 332
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.CheckForUnlimitedKeys a4;

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060009DC RID: 2524
		public delegate bool CheckForUnlimitedKeys(object sender, global::System.EventArgs e);
	}
}
