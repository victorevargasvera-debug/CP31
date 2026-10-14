using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using authAES;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.Communication.Utils;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public class AstroCpsSequenceManager : global::Motorola.Common.Communication.IshHandler.CpsFileSequenceManagerBase, global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.ISequenceManager, global::Motorola.Common.Communication.IFwdl, global::Motorola.Common.Communication.IUpdatesMacAddress, global::Motorola.Common.Communication.IRadioParamSupport, global::Motorola.Common.Communication.IQueryRadioStatus, global::Motorola.Common.Communication.IIshBlockSupport, global::Motorola.Common.Communication.IDifferentialWritable, global::Motorola.Common.Communication.ILanguagePackSupport, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00009050 File Offset: 0x00007250
		protected global::Motorola.Common.Communication.IMessageExecutor RcmpWrapper
		{
			get
			{
				short num = (short)1699291001;
				short num2 = num;
				num = (short)36970361;
				switch (num2 == num)
				{
				}
				num = (short)1031995392;
				if (num != 0)
				{
				}
				num = (short)1070465024;
				short num3 = num;
				num = (short)1814495233;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000090FC File Offset: 0x000072FC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00009224 File Offset: 0x00007424
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			get
			{
				short num = (short)706150401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_111;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						this.ReadExtendedDeviceInfo();
						num = (short)977928192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)1838826244;
					short num3 = num;
					num = (short)899760900;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_113;
					default:
					{
						num = (short)1223557120;
						short num4 = num;
						num = (short)2099707904;
						if (num != 0)
						{
						}
						num = (short)359464961;
						if (num != 0)
						{
						}
						if (this.c != null)
						{
							goto IL_113;
						}
						num = (short)1745420290;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_111:
				IL_113:
				return this.c;
			}
			set
			{
				short num = (short)268667290;
				short num2 = num;
				num = (short)350980506;
				switch (num2 == num)
				{
				}
				num = (short)728629249;
				if (num != 0)
				{
				}
				num = (short)699006976;
				short num3 = num;
				num = (short)1874591744;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000092DC File Offset: 0x000074DC
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00009388 File Offset: 0x00007588
		public bool DifferentialWriteCapableRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1578030361;
				short num2 = num;
				num = (short)339924249;
				switch (num2 == num)
				{
				}
				num = (short)1782317057;
				if (num != 0)
				{
				}
				num = (short)793444352;
				short num3 = num;
				num = (short)731381760;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1808129765;
				short num2 = num;
				num = (short)254074597;
				switch (num2 == num)
				{
				}
				num = (short)1957494785;
				if (num != 0)
				{
				}
				num = (short)357957632;
				short num3 = num;
				num = (short)742195200;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00009438 File Offset: 0x00007638
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000094E8 File Offset: 0x000076E8
		protected global::Motorola.Common.Communication.RadioParams ExtendedRadioParam
		{
			get
			{
				short num = (short)558455708;
				short num2 = num;
				num = (short)1717918620;
				switch (num2 == num)
				{
				}
				num = (short)288096257;
				if (num != 0)
				{
				}
				num = (short)1489895424;
				short num3 = num;
				num = (short)1025572864;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1125831404;
				short num2 = num;
				num = (short)932631276;
				switch (num2 == num)
				{
				}
				num = (short)1158086656;
				if (num != 0)
				{
				}
				num = (short)164888576;
				short num3 = num;
				num = (short)1707999233;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00009598 File Offset: 0x00007798
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00009648 File Offset: 0x00007848
		public global::Motorola.Common.Communication.Rcmp.XcmpComponentSession SessionCommandReply
		{
			get
			{
				short num = (short)1241441101;
				short num2 = num;
				num = (short)1718084429;
				switch (num2 == num)
				{
				}
				num = (short)1281556481;
				if (num != 0)
				{
				}
				num = (short)996474880;
				short num3 = num;
				num = (short)75628544;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)550697729;
				short num2 = num;
				num = (short)876542721;
				switch (num2 == num)
				{
				}
				num = (short)1328545793;
				if (num != 0)
				{
				}
				num = (short)908132352;
				if (num != 0)
				{
				}
				num = (short)256245760;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000096F8 File Offset: 0x000078F8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000097A8 File Offset: 0x000079A8
		public global::Motorola.Common.Communication.CommonUtil.SessionParameter SessionParam
		{
			get
			{
				short num = (short)210379205;
				short num2 = num;
				num = (short)402661829;
				switch (num2 == num)
				{
				}
				num = (short)2010251264;
				if (num != 0)
				{
				}
				num = (short)997851137;
				if (num != 0)
				{
				}
				num = (short)1245904896;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)557010734;
				short num2 = num;
				num = (short)1704480558;
				switch (num2 == num)
				{
				}
				num = (short)28704769;
				if (num != 0)
				{
				}
				num = (short)2003959808;
				if (num != 0)
				{
				}
				num = (short)1514405888;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000985C File Offset: 0x00007A5C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00009908 File Offset: 0x00007B08
		private global::Motorola.Common.Communication.IshHandler.CommonIshHandler IshHandler
		{
			get
			{
				short num = (short)989470703;
				short num2 = num;
				num = (short)1212882927;
				switch (num2 == num)
				{
				}
				num = (short)910295041;
				if (num != 0)
				{
				}
				num = (short)1151139840;
				if (num != 0)
				{
				}
				num = (short)743636992;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)452132865;
				if (num != 0)
				{
				}
				num = (short)1180094948;
				short num2 = num;
				num = (short)69587428;
				switch (num2 == num)
				{
				}
				num = (short)590282752;
				if (num != 0)
				{
				}
				num = (short)328859648;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000099B8 File Offset: 0x00007BB8
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00009A68 File Offset: 0x00007C68
		private protected new global::Motorola.Common.Communication.IshHandler.IOController IOController
		{
			protected get
			{
				short num = (short)1462252071;
				short num2 = num;
				num = (short)1049702951;
				switch (num2 == num)
				{
				}
				num = (short)1687486465;
				if (num != 0)
				{
				}
				num = (short)629407744;
				if (num != 0)
				{
				}
				num = (short)1186856960;
				short num3 = num;
				return this.i;
			}
			private set
			{
				short num = (short)478609409;
				if (num != 0)
				{
				}
				num = (short)1021864002;
				short num2 = num;
				num = (short)945055810;
				switch (num2 == num)
				{
				}
				num = (short)586547200;
				if (num != 0)
				{
				}
				num = (short)1440481280;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00009B18 File Offset: 0x00007D18
		public AstroCpsSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam)
		{
			this.a = rcmpWrapper;
			this.f = new global::Motorola.Common.Communication.RadioParams();
			if (rcmpWrapper is global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)
			{
				this.j = 1368;
			}
			else
			{
				this.j = 1368;
			}
			if (sessionParam != null)
			{
				this.e = sessionParam;
			}
			else
			{
				this.e = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, null);
			}
			this.IshHandler = new global::Motorola.Common.Communication.IshHandler.CommonIshHandler(rcmpWrapper, this.j);
			this.IOController = new global::Motorola.Common.Communication.IshHandler.IOController(rcmpWrapper, this.j, false);
			base.IOController = this.IOController;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00009BC8 File Offset: 0x00007DC8
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)830462942;
			short num2 = num;
			num = (short)2043272158;
			switch (num2 == num)
			{
			}
			num = (short)1534853120;
			if (num != 0)
			{
			}
			num = (short)725221377;
			if (num != 0)
			{
			}
			num = (short)960692224;
			short num3 = num;
			return true;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00009C74 File Offset: 0x00007E74
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00009D24 File Offset: 0x00007F24
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)451280897;
				if (num != 0)
				{
				}
				num = (short)1810320727;
				short num2 = num;
				num = (short)619466071;
				switch (num2 == num)
				{
				}
				num = (short)87556096;
				if (num != 0)
				{
				}
				num = (short)1151991808;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)152152842;
				short num2 = num;
				num = (short)862235402;
				switch (num2 == num)
				{
				}
				num = (short)198967297;
				if (num != 0)
				{
				}
				num = (short)1000931328;
				if (num != 0)
				{
				}
				num = (short)1030094848;
				short num3 = num;
				this.n = value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00009DD4 File Offset: 0x00007FD4
		public virtual void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)88408068;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
					{
						num = (short)54067201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)358547458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1E9;
				case 2:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)369950728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)
					{
						num = (short)1964572679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 5:
					goto IL_1A5;
				case 6:
				{
					num = (short)1102903698;
					short num3 = num;
					num = (short)1614477714;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A5;
					case 1:
						break;
					default:
					{
						num = (short)1978335232;
						short num4 = num;
						break;
					}
					}
					num = (short)1195573248;
					if (num != 0)
					{
					}
					num = (short)1451556867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					this.UnlockRadioPartition(212);
					num = (short)1115291648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.EnterWriteProgramMode();
					num = (short)1273364485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4A:
				num = (short)12320769;
				if (num != 0)
				{
				}
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
				{
					break;
				}
				num = (short)1966211078;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A5:
			return;
			IL_1E9:
			this.EnterReadProgramMode();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00009FD0 File Offset: 0x000081D0
		public virtual void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)827981827;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13D;
				case 1:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)190054402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)607911937;
					if (num != 0)
					{
					}
					num = (short)1237632361;
					short num3 = num;
					num = (short)472237417;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)89456640;
						if (num != 0)
						{
						}
						num = (short)543293447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 4:
					return;
				case 5:
					goto IL_62;
				case 6:
				{
					uint num4 = 0U;
					this.a(global::Motorola.Common.Communication.UpdateControlAction.RadioValidateCodeplug, out num4);
					num = (short)55967744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					num = (short)1000800256;
					short num5 = num;
					if (!pendingDeploy)
					{
						num = (short)142147590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				}
				}
				IL_44:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					num = (short)1058996229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)250871809;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13D:
				this.ExitWriteProgramMode();
				num = (short)2087518212;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_62:
			this.ExitReadProgramMode();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000A19C File Offset: 0x0000839C
		public bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 7;
			short num = (short)1918763008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				bool result;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						if (this.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1514078210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2042282861;
						short num3 = num;
						num = (short)720159597;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_145;
						default:
						{
							num = (short)862126080;
							if (num != 0)
							{
							}
							num = (short)1224736768;
							short num4 = num;
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("돶郸鷺鯼髾猀昂欄猆怈樊愌堎挐稒愔爖娘稚洜縞䌠伢䀤甦䠨伪䐬䀮ᄰาᔴ", a_) + this.DifferentialWriteCapableRadio.ToString(), global::System.Array.Empty<object>());
							num = (short)518389765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						num = (short)1874722825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_372;
					case 3:
						num = (short)1522270218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_289;
					case 5:
						goto IL_248;
					case 6:
						if (this.SessionParam.PreviousSessionID > 0)
						{
							num = (short)611254275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 7:
						num = (short)1911160840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
						{
							num = (short)396361732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
						{
							num = (short)409665543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_289;
					case 10:
						if (this.SessionParam.ArchiveSession)
						{
							goto IL_145;
						}
						return result;
					}
					goto IL_64;
					IL_145:
					num = (short)2068643841;
					if (num != 0)
					{
					}
					num = (short)2119696385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_289:
					ushort num5;
					ushort num6;
					this.IOController.ComponentSession(7, sessionID, this.SessionParam.PreviousSessionID, out num5, out num6);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗶ듸\udbfa근跾搀甂氄栆簈砊ⴌ導琐怒昔縖瘘甚吜嬞ĠḢԤ", a_) + this.SessionParam.PreviousSessionID.ToString(), global::System.Array.Empty<object>());
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗶ듸\udbfa뻼諾猀焂怄椆紈⬊希樎成怒簔砖眘刚夜㼞ᰠ̢", a_) + sessionID.ToString(), global::System.Array.Empty<object>());
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗶ飸鿺铼郾℀䀂瀄甆笈渊挌笎ㄐ䀒瀔搖樘爚爜焞栠朢Ԥᨦन", a_) + num6.ToString(), global::System.Array.Empty<object>());
					num = (short)2114650112;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_248:
				return result;
				IL_372:
				this.DifferentialWriteCapableRadio = true;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("돶郸鷺鯼髾猀昂欄猆怈樊愌堎挐稒愔爖娘稚洜縞䌠伢䀤甦䠨伪䐬䀮ᄰาᔴ", a_) + this.DifferentialWriteCapableRadio.ToString(), global::System.Array.Empty<object>());
				return true;
				IL_64:
				result = false;
				num = (short)1085079558;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000A524 File Offset: 0x00008724
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			short num = (short)393984412;
			short num2 = num;
			num = (short)1846720924;
			switch (num2 == num)
			{
			}
			num = (short)180420609;
			if (num != 0)
			{
			}
			num = (short)1741160448;
			if (num != 0)
			{
			}
			num = (short)1826226176;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			global::Motorola.Common.Communication.Utils.InfoMapper.MapBasicDeviceInfo(this.h(), deviceInfo);
			deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			return deviceInfo;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000A5E8 File Offset: 0x000087E8
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			short num = (short)1476031973;
			short num2 = num;
			num = (short)542471653;
			switch (num2 == num)
			{
			}
			num = (short)1280442368;
			if (num != 0)
			{
			}
			num = (short)317915137;
			if (num != 0)
			{
			}
			num = (short)926547968;
			short num3 = num;
			global::Motorola.Common.Communication.RadioParams radioData = this.g();
			global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
			global::Motorola.Common.Communication.Utils.InfoMapper.MapExtendedDeviceInfo(radioData, astroDeviceInfo);
			astroDeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			this.c = astroDeviceInfo;
			return astroDeviceInfo;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000A6B4 File Offset: 0x000088B4
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)1885863937;
			if (num != 0)
			{
			}
			num = (short)1816723458;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
					num = (short)608567301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_125;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 3:
				{
					num = (short)1522977540;
					short num3 = num;
					num = (short)237554436;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14B;
					default:
					{
						num = (short)1484521472;
						if (num != 0)
						{
						}
						num = (short)644284416;
						short num4 = num;
						this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)705167361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					if (this.ProgressIndicator != null)
					{
						goto IL_14B;
					}
					goto IL_192;
				case 5:
					goto IL_123;
				}
				IL_63:
				if (this.ProgressIndicator != null)
				{
					num = (short)1564475395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_125:
				codeplug = this.ReadRadioCodeplug();
				num = (short)2056912900;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14B:
				num = (short)1211498496;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_123:
			IL_192:
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject.SetCodeplug(codeplug);
			global::Motorola.Common.Communication.RadioParams radioParams = this.g();
			pbaObject.CodeplugData.CPVersion = radioParams.CodeplugVersion;
			this.UpdateWiFiPasswordAfterRead(pbaObject);
			this.UpdateExternalDataModemPasswordAfterRead(pbaObject);
			return pbaObject;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000A888 File Offset: 0x00008A88
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, string pcrNewPassword, bool hostedDepotOperation, int? userDefersAllowed)
		{
			short num = (short)1236024993;
			short num2 = num;
			num = (short)409157281;
			switch (num2 == num)
			{
			}
			num = (short)1670774785;
			if (num != 0)
			{
			}
			num = (short)989331456;
			if (num != 0)
			{
			}
			num = (short)97648640;
			short num3 = num;
			return this.WriteDevice(pbaObject, sessionId, pcrNewPassword, hostedDepotOperation);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000A93C File Offset: 0x00008B3C
		public virtual global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			short num = (short)871268630;
			short num2 = num;
			num = (short)516325654;
			switch (num2 == num)
			{
			}
			num = (short)1893072897;
			if (num != 0)
			{
			}
			num = (short)14548992;
			if (num != 0)
			{
			}
			num = (short)932315136;
			short num3 = num;
			new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] buffer = writePBA.SerializeToBytes();
			this.ValidateCodeplugVersion(writePBA);
			this.WriteValidation(writePBA);
			this.WriteRadioCodeplug(writePBA, false, false);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000AA18 File Offset: 0x00008C18
		protected void ValidateCodeplugVersion(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			int a_ = 12;
			short num = (short)1573388288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				string cpversion;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						string text = this.IOController.QueryCodeplugVersion();
						int num3 = (int)global::System.Convert.ToInt16(text.Substring(1, 2), 10);
						int num4 = (int)global::System.Convert.ToInt16(cpversion.Substring(1, 2), 10);
						int num5 = (int)global::System.Convert.ToInt16(text.Substring(4, 2), 10);
						int num6 = (int)global::System.Convert.ToInt16(cpversion.Substring(4, 2), 10);
						num = (short)955908098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num3;
						int num4;
						if (num4 != num3)
						{
							return;
						}
						num = (short)1953351176;
						short num7 = num;
						num = (short)357811720;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20E;
						default:
						{
							num = (short)1702297600;
							if (num != 0)
							{
							}
							num = (short)1879506944;
							short num8 = num;
							num = (short)956497924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						int num3;
						int num4;
						if (num4 >= num3)
						{
							num = (short)1895366659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E;
					}
					case 3:
						num = (short)575143937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1703870471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!writePBA.IsRetoreJob)
						{
							num = (short)695795718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)1616314376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						int num5;
						int num6;
						if (num6 < num5)
						{
							num = (short)836894729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
						if (cpversion.StartsWith(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("껻", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)730726400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_10B;
					}
					goto IL_5F;
				}
				IL_10B:
				IL_20E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CPVersionVerifyFailed);
				IL_5F:
				cpversion = writePBA.CodeplugData.CPVersion;
				num = (short)2098266113;
				if (num != 0)
				{
				}
				num = (short)1058865157;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		public virtual void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			short num = (short)442695682;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)1512112133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_127;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
				{
					num = (short)211733945;
					short num3 = num;
					num = (short)173591993;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_150;
					default:
					{
						num = (short)225902592;
						if (num != 0)
						{
						}
						num = (short)1176436737;
						if (num != 0)
						{
						}
						num = (short)1262551040;
						short num4 = num;
						this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
						num = (short)2060058625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					if (this.ProgressIndicator != null)
					{
						goto IL_150;
					}
					return;
				case 5:
					return;
				}
				IL_3C:
				if (this.ProgressIndicator != null)
				{
					num = (short)402456579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_127:
				this.WriteRadioCodeplug(writePBA, true, false);
				num = (short)1021509636;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_150:
				num = (short)2101149696;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000AE6C File Offset: 0x0000906C
		public virtual void DepotForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			short num = (short)1052442626;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)230883328;
					short num3 = num;
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num = (short)1725693957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_109;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
				{
					num = (short)722591476;
					short num4 = num;
					num = (short)585948916;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_154;
					default:
						num = (short)292487168;
						if (num != 0)
						{
						}
						this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
						num = (short)1056702465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (this.ProgressIndicator != null)
					{
						goto IL_154;
					}
					goto IL_1A5;
				case 5:
					goto IL_104;
				}
				IL_3D:
				if (this.ProgressIndicator != null)
				{
					num = (short)551223299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_109:
				this.UpdateOobeBeforeWrite(writePBA);
				this.UpdatePINPasswordBeforeWrite(writePBA);
				this.UpdateWiFiPasswordBeforeWrite(writePBA);
				this.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
				this.UpdateMacAddressBeforeWrite(writePBA);
				this.WriteRadioCodeplug(writePBA, true, true);
				num = (short)135462916;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_154:
				num = (short)293470208;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_104:
			IL_1A5:
			num = (short)1294073857;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000B048 File Offset: 0x00009248
		public void UpdateSerialNumber(string serialNumber)
		{
			int a_ = 1;
			short num = (short)1696727041;
			if (num != 0)
			{
			}
			num = (short)279799568;
			short num2 = num;
			num = (short)530540304;
			switch (num2 == num)
			{
			}
			num = (short)1507983360;
			if (num != 0)
			{
			}
			num = (short)1546387456;
			short num3 = num;
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(serialNumber + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("", a_));
			this.IOController.UpdateSerialNumber(bytes);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000B124 File Offset: 0x00009324
		public void FactoryReset()
		{
			short num = (short)1003417784;
			short num2 = num;
			num = (short)500887736;
			switch (num2 == num)
			{
			}
			num = (short)2119761921;
			if (num != 0)
			{
			}
			num = (short)1315438592;
			if (num != 0)
			{
			}
			num = (short)422117376;
			short num3 = num;
			this.IOController.FactoryReset();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000B1DC File Offset: 0x000093DC
		public void UpdateMACAddress(byte[] macAddress)
		{
			short num = (short)1922007961;
			short num2 = num;
			num = (short)332235673;
			switch (num2 == num)
			{
			}
			num = (short)1531838465;
			if (num != 0)
			{
			}
			num = (short)447741952;
			if (num != 0)
			{
			}
			num = (short)1154809856;
			short num3 = num;
			this.IOController.UpdateMACAddress(macAddress);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000B294 File Offset: 0x00009494
		public bool SetFWDLConfig(ushort tg, string version)
		{
			int a_ = 6;
			short num = (short)1157470745;
			short num2 = num;
			num = (short)1389271577;
			switch (num2 == num)
			{
			}
			num = (short)1224146944;
			if (num != 0)
			{
			}
			num = (short)1078460417;
			if (num != 0)
			{
			}
			num = (short)1597046784;
			short num3 = num;
			bool flag = this.IOController.SetDownLoadTGVersion(tg, version);
			if (!flag)
			{
				string format = string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("냵꿷뻹냻\udefd䏿洁樃怅愇洉Ⰻ䴍缏缑礓眕瘗縙㰛砝䄟䬡䠣䌥䰧਩䨫䄭䈯ሱ怳焵ȷᨹ䜻฽㴿扁╃⡅ⱇ橉ੋ❍≏㽑⍓㝕⩗㽙籛࡝՟ၡᝣཥݧѩ噫乭୯䍱ॳ", a_), tg, version);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_FWDL_Xcmp_SetupCommand_Failed);
			}
			return flag;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000B390 File Offset: 0x00009590
		public void UpdateIMEType(byte ime)
		{
			short num = (short)1689845760;
			short num2 = num;
			num = (short)237084531;
			short num3 = num;
			num = (short)2095882099;
			switch (num3 == num)
			{
			}
			num = (short)954466305;
			if (num != 0)
			{
			}
			num = (short)1413545984;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000B440 File Offset: 0x00009640
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			short num = (short)2066808832;
			short num2 = num;
			num = (short)1678442497;
			if (num != 0)
			{
			}
			num = (short)499858711;
			short num3 = num;
			num = (short)1557150999;
			switch (num3 == num)
			{
			}
			num = (short)863961088;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000B4F0 File Offset: 0x000096F0
		public void UnkillRadio(byte[] authenticationValue)
		{
			short num = (short)796262400;
			short num2 = num;
			num = (short)356188161;
			if (num != 0)
			{
			}
			num = (short)1853843669;
			short num3 = num;
			num = (short)700147925;
			switch (num3 == num)
			{
			}
			num = (short)123011072;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000B5A0 File Offset: 0x000097A0
		public byte[] ReadUnkillChallengeValue()
		{
			short num = (short)900005888;
			short num2 = num;
			num = (short)1927811776;
			short num3 = num;
			num = (short)1851855552;
			switch (num3 == num)
			{
			}
			num = (short)1573453825;
			if (num != 0)
			{
			}
			num = (short)1812594688;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B64C File Offset: 0x0000984C
		public void CBIProgramme()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E4;
				case 1:
					if (this != null)
					{
						num2 = (short)121569280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
			}
			IL_E4:
			num2 = (short)816447488;
			short num3 = num2;
			goto IL_110;
			IL_1C:
			num2 = (short)131946535;
			short num4 = num2;
			num2 = (short)1666275367;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_110:
				this.IOController.ResetRadio();
				num2 = (short)1341915138;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)880869376;
				if (num2 != 0)
				{
				}
				byte[] serailNumber = new byte[]
				{
					200,
					212,
					221,
					157,
					162,
					204,
					132,
					209,
					157,
					175,
					0
				};
				this.IOController.UpdateSerialNumber(serailNumber);
				num2 = (short)122748929;
				if (num2 != 0)
				{
				}
				num2 = (short)1281884161;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B790 File Offset: 0x00009990
		protected void WriteValidation(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (pbaObject.ValidationInfos.Count > 0)
					{
						num2 = (short)1483276296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (validateItemsToRead.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
					{
						num2 = (short)1309540361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E0;
				case 2:
					num2 = (short)517144576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1774583808;
					short num3 = num2;
					goto IL_E0;
				}
				case 4:
					if (validateItemsToRead != null)
					{
						num2 = (short)812908549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E0;
				case 5:
					num2 = (short)921698305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (pbaObject.ValidationInfos != null)
					{
						goto IL_102;
					}
					return;
				case 7:
					return;
				case 8:
					global::Motorola.Common.Communication.IshHandler.Validator.ValidateInfos(pbaObject.ValidationInfos, this.ReadExtendedDeviceInfo(), new global::Motorola.Common.Communication.n());
					num2 = (short)227016711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)1195421041;
					short num4 = num2;
					num2 = (short)49130865;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
					{
						num2 = (short)1889796096;
						if (num2 != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = this.ReadIshItems(validateItemsToRead);
						ishItemCollection = this.a(ishItemCollection);
						global::Motorola.Common.Communication.IshHandler.Validator.ValidateFields(pbaObject.ValidationFields, ishItemCollection);
						num2 = (short)210042883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_38;
				IL_E0:
				num2 = (short)1866989574;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_102:
				num2 = (short)2074476546;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(pbaObject.ValidationFields);
			num2 = (short)314638337;
			if (num2 != 0)
			{
			}
			num2 = (short)461176836;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0)
		{
			short num = (short)1628504065;
			if (num != 0)
			{
			}
			num = (short)957087744;
			switch (num)
			{
			default:
			{
				num = (short)1307639808;
				short num2 = num;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)333316098;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data.Length > 2)
							{
								num = (short)1786511365;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)983302147;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)158821983;
							short num4 = num;
							num = (short)890138207;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E8;
							default:
								num = (short)203161600;
								if (num != 0)
								{
								}
								num = (short)1676673024;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_BF;
							}
							continue;
						case 3:
							goto IL_1E8;
						case 4:
							goto IL_202;
						case 5:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							value.Data = value.Data.Take(value.Data.Length - 2).ToArray<byte>();
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							ishItemCollection.Add(keyValuePair.Key, value);
							num = (short)517472262;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_15C:
						num = (short)1049624577;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_BF:
						goto IL_15C;
						IL_1E8:
						num = (short)1867382788;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_202:;
				}
				finally
				{
					num = (short)1789132801;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1654652930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_236;
							}
							continue;
						case 2:
							goto IL_26B;
						}
						IL_236:
						if (enumerator == null)
						{
							break;
						}
						num = (short)817364992;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_26B:;
				}
				return ishItemCollection;
			}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			short num = (short)1955987456;
			switch (num)
			{
			default:
			{
				num = (short)1283325957;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list;
					switch (num2)
					{
					case 0:
						if (this.ProgressIndicator != null)
						{
							num = (short)2127691785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					case 1:
						goto IL_180;
					case 2:
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
						num = (short)1198260227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator = blockList.GetEnumerator();
							goto IL_23A;
							try
							{
								for (;;)
								{
									IL_23A:
									num = (short)685375488;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_275;
											}
											continue;
										case 1:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1747058692;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											object obj = enumerator.Current;
											list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
											num = (short)1739653123;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_34A;
										case 3:
											goto IL_2F8;
										case 4:
											num = (short)1765539842;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_275;
										IL_2F8:
										num = (short)1236926465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_275:
										num = (short)1860215250;
										short num3 = num;
										num = (short)597795282;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_23A;
										default:
											num = (short)948699136;
											if (num != 0)
											{
											}
											goto IL_2F8;
										}
									}
								}
								IL_34A:;
							}
							finally
							{
								num = (short)1825046529;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)295174145;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1953759234;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_381;
										}
										continue;
									case 2:
										goto IL_3DF;
									}
									IL_381:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1449394176;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3DF:;
							}
							goto IL_E9;
						}
						catch (global::System.InvalidCastException systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
						}
						goto IL_3F2;
						IL_E9:
						num = (short)558432264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)156172288;
						short num4 = num;
						goto IL_91;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 6:
						num = (short)1594032138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)1624309764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.ProgressIndicator != null)
						{
							num = (short)996933639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91;
					case 9:
						this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
						num = (short)1845493761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (blockList.Any<T>())
						{
							num = (short)1013317634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F2;
					}
					IL_71:
					if (blockList != null)
					{
						num = (short)1876951046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F2;
					IL_91:
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
					num = (short)1834418176;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_180:
				IL_221:
				pbaObject.SetCodeplug(codeplug);
				this.UpdateWiFiPasswordAfterRead(pbaObject);
				return pbaObject;
				IL_3F2:
				throw new global::System.ArgumentNullException();
			}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		public virtual global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			short num = (short)1582891008;
			short num2 = num;
			num = (short)932364736;
			short num3 = num;
			num = (short)282968512;
			switch (num3 == num)
			{
			}
			num = (short)1684799489;
			if (num != 0)
			{
			}
			num = (short)797507584;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C150 File Offset: 0x0000A350
		public virtual void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)1789132800;
			short num2 = num;
			num = (short)1577976773;
			short num3 = num;
			num = (short)2102920133;
			switch (num3 == num)
			{
			}
			num = (short)1630273536;
			if (num != 0)
			{
			}
			num = (short)1111621633;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000C200 File Offset: 0x0000A400
		public virtual void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)1966866432;
			short num2 = num;
			num = (short)1518674209;
			short num3 = num;
			num = (short)615653665;
			switch (num3 == num)
			{
			}
			num = (short)1001652225;
			if (num != 0)
			{
			}
			num = (short)1156513792;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public virtual global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			short num = (short)297664512;
			short num2 = num;
			num = (short)889126535;
			short num3 = num;
			num = (short)185204359;
			switch (num3 == num)
			{
			}
			num = (short)265814017;
			if (num != 0)
			{
			}
			num = (short)1402994688;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C360 File Offset: 0x0000A560
		public virtual void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)2041577472;
			short num2 = num;
			num = (short)1579675652;
			short num3 = num;
			num = (short)796323844;
			switch (num3 == num)
			{
			}
			num = (short)1905000448;
			if (num != 0)
			{
			}
			num = (short)1844838401;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000C410 File Offset: 0x0000A610
		public virtual void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			short num = (short)1689780224;
			short num2 = num;
			num = (short)1438592559;
			short num3 = num;
			num = (short)188689967;
			switch (num3 == num)
			{
			}
			num = (short)768278529;
			if (num != 0)
			{
			}
			num = (short)1097269248;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			short num = (short)86966272;
			short num2 = num;
			num = (short)1407221614;
			short num3 = num;
			num = (short)1512144750;
			switch (num3 == num)
			{
			}
			num = (short)1895759873;
			if (num != 0)
			{
			}
			num = (short)1111031808;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C570 File Offset: 0x0000A770
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)17007628;
			short num2 = num;
			num = (short)1092846604;
			switch (num2 == num)
			{
			}
			num = (short)1854734336;
			short num3 = num;
			num = (short)1540751361;
			if (num != 0)
			{
			}
			num = (short)913965056;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C620 File Offset: 0x0000A820
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)675395310;
			short num2 = num;
			num = (short)1150269166;
			switch (num2 == num)
			{
			}
			num = (short)1259864064;
			short num3 = num;
			num = (short)1155072001;
			if (num != 0)
			{
			}
			num = (short)1910046720;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			short num = (short)1712108861;
			short num2 = num;
			num = (short)902804797;
			switch (num2 == num)
			{
			}
			num = (short)1294860288;
			short num3 = num;
			num = (short)1491533825;
			if (num != 0)
			{
			}
			num = (short)550043648;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000C77C File Offset: 0x0000A97C
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			short num = (short)624501576;
			short num2 = num;
			num = (short)411509576;
			switch (num2 == num)
			{
			}
			num = (short)1904148480;
			short num3 = num;
			num = (short)2003435521;
			if (num != 0)
			{
			}
			num = (short)1040515072;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000C82C File Offset: 0x0000AA2C
		protected virtual global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			short num = (short)527503064;
			short num2 = num;
			num = (short)1480330968;
			switch (num2 == num)
			{
			}
			num = (short)289931264;
			short num3 = num;
			num = (short)85524481;
			if (num != 0)
			{
			}
			num = (short)1283588096;
			if (num != 0)
			{
			}
			return this.IshHandler.ReadIshItems(ishHeaders, null);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		protected virtual void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite, bool hostedDepotOperation)
		{
			int a_ = 15;
			short num = (short)1493762048;
			switch (num)
			{
			default:
			{
				num = (short)120061981;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					uint a_2;
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
					switch (num2)
					{
					case 0:
					{
						uint num3;
						this.ProgressIndicator.UpdateProgress(num3 / 100.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
						num = (short)201457700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_625;
					case 2:
						goto IL_21B;
					case 3:
						this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
						num = (short)666566678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						uint num3;
						if (num3 < 50U)
						{
							num = (short)1648754707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Threading.Thread.Sleep(1000);
						num = (short)682623000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num4 > 65)
						{
							num = (short)1687617556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귾怀朂氄栆⤈椊氌氎稐琒朔砖氘甚礜㼞䐠儢䐤否䰨太ബ崮䐰崲嬴帶圸尺", a_), global::System.Array.Empty<object>());
						num = (short)1736704004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_4BE;
					case 7:
						if (this.ProgressIndicator != null)
						{
							num = (short)183828503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						return;
					case 9:
						if (hostedDepotOperation)
						{
							num = (short)801898508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 10:
						num = (short)1122631701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)138412063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						this.UpdateOobeBeforeWrite(writePBA);
						this.UpdatePINPasswordBeforeWrite(writePBA);
						this.UpdateWiFiPasswordBeforeWrite(writePBA);
						this.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
						this.UpdateMacAddressBeforeWrite(writePBA);
						num = (short)1969684510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						this.a(a_2);
						num = (short)951058464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (this.ProgressIndicator != null)
						{
							num = (short)1002373137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					case 15:
						this.ProgressIndicator.UpdateProgress(0.2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
						num = (short)93847577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						uint num5;
						this.a(global::Motorola.Common.Communication.UpdateControlAction.RadioCodeplugActive, out num5);
						a_2 = num5;
						num = (short)1405091854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)331874341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
						num = (short)1146355718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						global::System.Threading.Thread.Sleep(5000);
						num = (short)1208680486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_316;
					case 21:
						writePBA.CodeplugData.DataPartitions.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.AstroCpsSequenceManager.<>c.<>9.a));
						this.UpdateOobeBeforeWrite(writePBA);
						this.UpdatePINPasswordBeforeWrite(writePBA);
						this.UpdateWiFiPasswordBeforeWrite(writePBA);
						this.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
						num = (short)669581314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_161;
					case 23:
						this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
						num = (short)836567074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_161;
					case 25:
						goto IL_76D;
					case 26:
						if (!forceWrite)
						{
							num = (short)1263403021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_350;
					case 27:
					{
						uint num3;
						if (num3 == 100U)
						{
							num = (short)11403304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_625;
					}
					case 28:
					{
						uint num5;
						bool flag = this.a(global::Motorola.Common.Communication.UpdateControlAction.RadioUpdateCodeplug, out num5) != 0;
						uint num3 = num5;
						if (!flag)
						{
							num = (short)808976395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6DD;
					}
					case 29:
						switch (0)
						{
						case 0:
							goto IL_F5;
						}
						continue;
					case 30:
						goto IL_1AB;
					case 31:
					{
						uint num5;
						if (num5 == 100U)
						{
							num = (short)1667498000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6DD;
					}
					case 32:
						goto IL_350;
					case 33:
						if (this.ProgressIndicator != null)
						{
							num = (short)685703183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					case 34:
						return;
					case 35:
						if (this.ProgressIndicator != null)
						{
							num = (short)1817837568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D6;
					case 36:
						goto IL_74C;
					case 37:
						if (this.ProgressIndicator.CurrentStatus == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP)
						{
							num = (short)227868675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					case 38:
						goto IL_161;
					case 39:
						if (this.ProgressIndicator != null)
						{
							num = (short)932249618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					case 40:
						num = (short)2074214439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						if (codeplugInIshItemCollection.Count <= 0)
						{
							num = (short)962134024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num5 = 255U;
						a_2 = 255U;
						num4 = 0;
						uint num3 = 0U;
						num = (short)1076756481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_F5:
					if (forceWrite)
					{
						goto IL_21B;
					}
					num = (short)986996571;
					short num6 = num;
					num = (short)262561627;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_74C;
					default:
						num = (short)639631360;
						if (num != 0)
						{
						}
						num = (short)846659594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_161:
					num = (short)1477181467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					codeplugInIshItemCollection = writePBA.GetCodeplugInIshItemCollection();
					num = (short)46006313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B:
					num = (short)437387265;
					if (num != 0)
					{
					}
					num = (short)967573513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D6:
					num4++;
					num = (short)571801605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74C:
					goto IL_2D6;
					IL_350:
					num = (short)1223819297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BE:
					uint a_3 = this.c(a_2);
					this.b(a_3);
					num = (short)843513882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_625:
					num = (short)113442844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6DD:
					num = (short)530776099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76D:
					num = (short)1937965056;
					short num7 = num;
					this.IshHandler.WriteIshItems(codeplugInIshItemCollection, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, 0.8), true);
					num = (short)1803812871;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_316:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_BackgroundEraseTimeout);
			}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000D10C File Offset: 0x0000B30C
		private int a(global::Motorola.Common.Communication.UpdateControlAction A_0, out uint A_1)
		{
			short num = (short)1452408833;
			if (num != 0)
			{
			}
			num = (short)738193849;
			short num2 = num;
			num = (short)160690617;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2102853632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1745485824;
			if (num != 0)
			{
			}
			int result = 0;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(A_0);
			this.RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				uint value = (uint)xcmpRadioUpdateControl.Value;
				A_1 = value;
				return result;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public bool ResetPassword(byte[] resetBytes)
		{
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.PasswordReset, resetBytes);
			this.RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				short num;
				for (;;)
				{
					num = (short)1119092737;
					if (num != 0)
					{
					}
					num = (short)312829405;
					short num2 = num;
					num = (short)1265722845;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_80;
					}
				}
				IL_80:
				num = (short)102825984;
				short num3 = num;
				num = (short)1747714048;
				if (num != 0)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		protected void UnlockRadioPartition(byte partition)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey rcmpReadRadioKey;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (partition < 255)
					{
						num2 = (short)42795014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					byte[] array = global::Motorola.Common.Communication.m.a(rcmpReadRadioKey.RadioKey);
					if (array.Length > this.j)
					{
						goto Block_3;
					}
					global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity = new global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity(array);
					this.RcmpWrapper.SendAndReceiveMessage(rcmpUnlockSecurity);
					num2 = (short)1023148039;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1E8;
				case 3:
					goto IL_284;
				case 4:
					num2 = (short)1232207872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (partition > 0)
					{
						num2 = (short)1238630404;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
				{
					num2 = (short)170839326;
					short num3 = num2;
					num2 = (short)931187998;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_231;
					default:
					{
						num2 = (short)1733689344;
						if (num2 != 0)
						{
						}
						global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition = new global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition(partition);
						this.RcmpWrapper.SendAndReceiveMessage(rcmpIshUnlockPartition);
						num2 = (short)612302856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 7:
				{
					global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity;
					if (rcmpUnlockSecurity.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)500695043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1617166341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition;
					if (rcmpIshUnlockPartition.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)149815298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 9:
				{
					num2 = (short)26214401;
					if (num2 != 0)
					{
					}
					num2 = (short)1552613376;
					short num4 = num2;
					if (rcmpReadRadioKey.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1723072522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1200422913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					goto IL_D1;
				}
				goto IL_3C;
			}
			IL_D1:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			Block_3:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_TooLongRadioKey);
			IL_1E8:
			IL_231:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			IL_284:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			IL_3C:
			rcmpReadRadioKey = new global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey();
			this.RcmpWrapper.SendAndReceiveMessage(rcmpReadRadioKey);
			num2 = (short)1736179721;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000D564 File Offset: 0x0000B764
		protected virtual void EnterReadProgramMode()
		{
			short num = (short)1641987733;
			short num2 = num;
			num = (short)1688321685;
			switch (num2 == num)
			{
			}
			num = (short)751370240;
			short num3 = num;
			num = (short)585367552;
			if (num != 0)
			{
			}
			num = (short)829161473;
			if (num != 0)
			{
			}
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000D61C File Offset: 0x0000B81C
		protected virtual void ExitReadProgramMode()
		{
			short num = (short)1881380471;
			short num2 = num;
			num = (short)425891447;
			switch (num2 == num)
			{
			}
			num = (short)1843724288;
			short num3 = num;
			num = (short)1733492737;
			if (num != 0)
			{
			}
			num = (short)85786624;
			if (num != 0)
			{
			}
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		protected virtual void EnterWriteProgramMode()
		{
			short num = (short)1577475534;
			short num2 = num;
			num = (short)1886150094;
			switch (num2 == num)
			{
			}
			num = (short)1164509184;
			short num3 = num;
			num = (short)1934753793;
			if (num != 0)
			{
			}
			num = (short)183500800;
			if (num != 0)
			{
			}
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000D788 File Offset: 0x0000B988
		protected virtual void ExitWriteProgramMode()
		{
			short num = (short)656971155;
			short num2 = num;
			num = (short)1265603987;
			switch (num2 == num)
			{
			}
			num = (short)477954048;
			short num3 = num;
			num = (short)992542721;
			if (num != 0)
			{
			}
			num = (short)1191313408;
			if (num != 0)
			{
			}
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000D83C File Offset: 0x0000BA3C
		protected void EnterProgramMode()
		{
			short num = (short)1722352947;
			short num2 = num;
			num = (short)552404275;
			switch (num2 == num)
			{
			}
			num = (short)356974592;
			short num3 = num;
			num = (short)52756481;
			if (num != 0)
			{
			}
			num = (short)249102336;
			if (num != 0)
			{
			}
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
		protected void ExitProgramMode()
		{
			short num = (short)308806744;
			short num2 = num;
			num = (short)592708696;
			switch (num2 == num)
			{
			}
			num = (short)1281818624;
			short num3 = num;
			num = (short)1498415105;
			if (num != 0)
			{
			}
			num = (short)273547264;
			if (num != 0)
			{
			}
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		private global::Motorola.Common.Communication.RadioParams h()
		{
			short num = (short)311989233;
			short num2 = num;
			num = (short)219059185;
			switch (num2 == num)
			{
			}
			num = (short)1260257280;
			short num3 = num;
			num = (short)689373184;
			if (num != 0)
			{
			}
			num = (short)1494351873;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.RadioParams result = this.e();
			if (!this.c())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000DA70 File Offset: 0x0000BC70
		private global::Motorola.Common.Communication.RadioParams g()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.Common.Communication.RadioParams radioParams;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.ExtendedRadioParam = radioParams;
					num2 = (short)1997930498;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_C5;
				case 2:
					if (!this.a(radioParams.Uuid))
					{
						num2 = (short)247267332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				case 3:
					if (!this.c())
					{
						num2 = (short)610402305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				case 4:
					goto IL_115;
				case 5:
				{
					if (this.DifferentialWriteCapableRadio)
					{
						num2 = (short)581959680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1694302208;
					short num3 = num2;
					num2 = (short)526450691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			IL_C5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			IL_115:
			num2 = (short)1632567297;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			IL_14A:
			num2 = (short)1579561228;
			short num4 = num2;
			num2 = (short)905064716;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_115;
			default:
				num2 = (short)898498560;
				if (num2 != 0)
				{
				}
				return radioParams;
			}
			IL_28:
			radioParams = this.d();
			num2 = (short)890044421;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000DC14 File Offset: 0x0000BE14
		protected global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadRadioCodeplug()
		{
			short num = (short)359923712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<ushort> list;
				global::System.Collections.Generic.List<byte> list2;
				for (;;)
				{
					IL_1D:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					byte b;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							num = (short)423886848;
							short num3 = num;
							goto IL_17D;
						}
						case 1:
						{
							ushort num4;
							if (num4 >= 2044)
							{
								num = (short)1991573507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							list.Add(num4);
							num4 += 1;
							num = (short)78381060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (b >= 214)
							{
								num = (short)170917895;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							list2.Add(b);
							b += 2;
							num = (short)543424518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1B8;
						case 4:
						{
							num = (short)454806421;
							short num5 = num;
							num = (short)1224461205;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)1377959936;
								if (num != 0)
								{
								}
								goto IL_17D;
							}
							break;
						}
						case 5:
							goto IL_1BA;
						case 6:
							num = (short)1853489153;
							if (num != 0)
							{
							}
							goto IL_1BA;
						case 7:
						{
							list = new global::System.Collections.Generic.List<ushort>();
							ushort num4 = 0;
							num = (short)456261632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
						IL_17D:
						num = (short)1793261569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BA:
						num = (short)1715470338;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4E:
					b = 208;
					list2 = new global::System.Collections.Generic.List<byte>();
					num = (short)905314309;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				IL_1B8:
				return this.IshHandler.ReadCodeplug(list2.ToArray(), this.ProgressIndicator, list);
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000DE34 File Offset: 0x0000C034
		private static global::System.Collections.Generic.Dictionary<global::System.Guid, string> f()
		{
			int a_ = 0;
			short num = (short)494896597;
			short num2 = num;
			num = (short)1681688021;
			switch (num2 == num)
			{
			}
			num = (short)1258094593;
			if (num != 0)
			{
			}
			num = (short)1006370816;
			short num3 = num;
			num = (short)1049886720;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.Dictionary<global::System.Guid, string> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
			string a_2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷯鷱胳駵諷闹郻鿽⻿䄁欃欅攇攉戋‍匏紑礓笕洗琙甛紝䄟嘡䴣䤥䘧Щ漫席䌯愱儳䜵䴷弹刻崽┿ཁ╃⡅⥇ⵉ⥋㱍ᑏ㍑⁓㝕癗≙ㅛ㉝", a_);
			string a_3 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뷯鷱胳駵諷闹郻鿽⻿䄁欃欅攇攉戋‍匏紑礓笕洗琙甛紝䄟嘡䴣䤥䘧Щ漫席䌯搱儳䐵䰷弹䐻洽┿㍁ㅃ⍅♇⥉⥋͍ㅏ㱑㕓ㅕ㵗⡙ᡛ㽝ᑟ͡䩣ṥէ٩", a_);
			global::Motorola.Common.Communication.AstroCpsSequenceManager.a(dictionary, a_2);
			global::Motorola.Common.Communication.AstroCpsSequenceManager.a(dictionary, a_3);
			return dictionary;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000DF18 File Offset: 0x0000C118
		private static void a(global::System.Collections.Generic.Dictionary<global::System.Guid, string> A_0, string A_1)
		{
			int a_ = 10;
			short num = (short)970260480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(A_1);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					global::System.Xml.XmlNodeList xmlNodeList;
					for (;;)
					{
						IL_3E:
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1127350276;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_223;
									case 1:
										num = (short)728236043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										string value;
										A_0.Add(new global::System.Guid(xmlAttribute.Value), value);
										num = (short)1342111753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										string value = string.Empty;
										num = (short)1621622791;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_120;
										}
										continue;
									case 5:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										string value = xmlAttribute2.Value;
										num = (short)237305856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										if (!A_0.ContainsKey(new global::System.Guid(xmlAttribute.Value)))
										{
											num = (short)1377828866;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										if (xmlAttribute2 != null)
										{
											num = (short)1077608453;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_223;
									}
									case 8:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)746782721;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("곹鷻鋽痿朁", a_)];
										global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes[global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뻹駻跽揿瀁洃瘅簇按挋怍", a_)];
										num = (short)1925840906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										if (xmlAttribute != null)
										{
											num = (short)80609283;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
										goto IL_2C8;
									}
									IL_14D:
									num = (short)283443208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_120:
									goto IL_14D;
									IL_223:
									num = (short)639369222;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2C8:
								goto IL_41D;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_2EA;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2D7:
									switch (num2)
									{
									case 0:
									{
										num = (short)546189937;
										short num3 = num;
										num = (short)525349489;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_30E;
										default:
											num = (short)220987392;
											if (num != 0)
											{
											}
											disposable.Dispose();
											num = (short)910688258;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										if (disposable != null)
										{
											goto IL_30E;
										}
										goto IL_394;
									case 2:
										goto IL_392;
									}
									goto IL_2EA;
									IL_30E:
									num = (short)425459712;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_392:
								IL_394:
								goto EndFinally_11;
								IL_2EA:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1842085889;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2D7;
								EndFinally_11:;
							}
							goto IL_395;
						case 1:
							if (xmlNodeList != null)
							{
								num = (short)1231486978;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_395;
						case 2:
						{
							global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
							num = (short)1304887296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_3AF;
						}
						goto IL_55;
						IL_395:
						num = (short)1672347651;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3AF:
					goto IL_41D;
					IL_55:
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(manifestResourceStream);
					xmlNodeList = xmlDocument.SelectNodes(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("맹賻跽叿朁甃猅洇搉漋欍崏猑稓眕缗缙減娝䄟嘡䔣थ笧弩尫席弯䀱䀳匵尷漹䤻圽␿แⵃ㕅㱇敉᥋㭍㥏㙑", a_));
					num = (short)1721368577;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3E;
				}
				finally
				{
					num = (short)669122561;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)manifestResourceStream).Dispose();
							num = (short)1955790850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3E3;
							}
							continue;
						case 2:
							goto IL_41A;
						}
						IL_3E3:
						if (manifestResourceStream == null)
						{
							break;
						}
						num = (short)511311872;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_41A:;
				}
				IL_41D:
				num = (short)1744240640;
				short num4 = num;
				num = (short)1105985537;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		private global::Motorola.Common.Communication.RadioParams e()
		{
			short num = (short)691666944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B2;
				}
				global::Motorola.Common.Communication.RadioParams radioParams;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber;
				global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2;
				global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation rcmpBigEndianHexVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3;
				global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation4;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber;
				global::Motorola.Common.Communication.Rcmp.RcmpHexVersionInformation rcmpHexVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)1664352256;
						short num3 = num;
						radioParams.SerialNumber = rcmpReadWriteSerialNumber.SerialNumber;
						num = (short)1941176342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1191769359;
						short num4 = num;
						num = (short)1665332495;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_70A;
						default:
							num = (short)1396178944;
							if (num != 0)
							{
							}
							if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								num = (short)213385221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6A5;
						}
						break;
					}
					case 2:
						if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)336003076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C1;
					case 3:
						goto IL_319;
					case 4:
						radioParams.BBFBundleVersion = rcmpVersionInformation.VersionInformation.TrimEnd(this.b);
						num = (short)1244790808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						radioParams.DownloadPercent = (ushort)xcmpRadioUpdateControl.Value;
						num = (short)463732754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						radioParams.PendingBbfBundleVersion = rcmpVersionInformation2.VersionInformation.TrimEnd(this.b);
						num = (short)162004995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)309264410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						radioParams.IsTlsPskCompatible = true;
						radioParams.TlsPskPortNumber = rcmpBigEndianHexVersionInformation.VersionInformation.ToString();
						num = (short)1612775455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						radioParams.PsdtVersion = rcmpVersionInformation3.VersionInformation.TrimEnd(this.b);
						num = (short)1834811412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (rcmpReadUUID.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)583532572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F0;
					case 11:
						num = (short)1937965088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						radioParams.CodeplugVersion = rcmpVersionInformation4.VersionInformation.TrimEnd(this.b);
						num = (short)127729671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						radioParams.ModelNumber = rcmpReadWriteModelNumber.ModelNumber;
						num = (short)1469906965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_53E;
					case 15:
						radioParams.CodeplugSessionID = rcmpHexVersionInformation.VersionInformation;
						num = (short)412876814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1686241303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						radioParams.HostVersion = rcmpVersionInformation5.VersionInformation.TrimEnd(this.b);
						goto IL_70A;
					case 18:
						goto IL_6A5;
					case 19:
						if (rcmpReadWriteModelNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)42336269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					case 20:
						num = (short)1918894110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1272512522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)2028797953;
						if (num != 0)
						{
						}
						num = (short)350421011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (rcmpVersionInformation4.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1469972492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48A;
					case 24:
						goto IL_3C1;
					case 25:
						if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1246429184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E7;
					case 26:
						if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1117323273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_387;
					case 27:
						if (rcmpBigEndianHexVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1438973960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioParams;
					case 28:
						radioParams.Uuid = new global::System.Guid(rcmpReadUUID.UUID);
						num = (short)1141374992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (rcmpHexVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)668794895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 30:
						if (rcmpVersionInformation5.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1530134545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					case 31:
						goto IL_485;
					case 32:
						if (rcmpVersionInformation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1092091910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_319;
					}
					goto IL_B2;
					IL_319:
					num = (short)771293213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C1:
					num = (short)1514209281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53E:
					num = (short)235339778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A5:
					num = (short)1849294875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70A:
					num = (short)585039883;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_387:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_485:
				return radioParams;
				IL_48A:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_4E5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_4F0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_620:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_6E7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_B2:
				radioParams = null;
				global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
				rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteModelNumber);
				rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber);
				rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
				xcmpSuperBundle.AddRcmpMessage(rcmpReadUUID);
				rcmpVersionInformation4 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation4);
				rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation3);
				rcmpVersionInformation5 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation5);
				rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PendingBBFBundleVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation2);
				rcmpHexVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugSessionID);
				xcmpSuperBundle.AddRcmpMessage(rcmpHexVersionInformation);
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.BBFBundleVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation);
				xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.GetDownloadProgress);
				xcmpSuperBundle.AddRcmpMessage(xcmpRadioUpdateControl);
				rcmpBigEndianHexVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.TlsPskPortNumber);
				xcmpSuperBundle.AddRcmpMessage(rcmpBigEndianHexVersionInformation);
				xcmpSuperBundle.ReadTimeout = 15000;
				this.RcmpWrapper.SendAndReceiveMessage(xcmpSuperBundle);
				radioParams = new global::Motorola.Common.Communication.RadioParams();
				num = (short)181665817;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000EB40 File Offset: 0x0000CD40
		private global::Motorola.Common.Communication.RadioParams d()
		{
			short num = (short)1485373440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				global::Motorola.Common.Communication.RadioParams radioParams;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				char[] trimChars;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation4;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation5;
				global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation rcmpBigEndianHexVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation6;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation7;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation8;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation9;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation10;
				global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						radioParams.MaceHardwareType = rcmpVersionInformation.VersionInformation.TrimEnd(trimChars);
						num = (short)1168769043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1933574144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98B;
					case 2:
						if (string.IsNullOrEmpty(radioParams.OptBrdHardwareType))
						{
							num = (short)217579554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 3:
						radioParams.BBFBundleVersion = rcmpVersionInformation2.VersionInformation.TrimEnd(trimChars);
						num = (short)1461714961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1431437322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64B;
					case 5:
						goto IL_6EA;
					case 6:
						if (rcmpVersionInformation4.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)586285084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DA;
					case 7:
						goto IL_416;
					case 8:
						if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)2111897613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 9:
						radioParams.MaceHardwareVersion = rcmpVersionInformation5.VersionInformation.TrimEnd(trimChars);
						num = (short)2114650124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						radioParams.OptBrdHwHostVersion = rcmpVersionInformation3.VersionInformation.TrimEnd(trimChars);
						num = (short)2126905359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (rcmpBigEndianHexVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1715208215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioParams;
					case 12:
						goto IL_457;
					case 13:
						radioParams.ESerialNumber = rcmpReadWriteSerialNumber.SerialRawBytes;
						num = (short)1708458015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						radioParams.OptBoardName = rcmpVersionInformation6.VersionInformation.TrimEnd(trimChars);
						num = (short)1233190917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_64B;
					case 16:
						goto IL_567;
					case 17:
						num = (short)693108737;
						if (num != 0)
						{
						}
						goto IL_917;
					case 18:
						goto IL_524;
					case 19:
						goto IL_98B;
					case 20:
						if (rcmpVersionInformation7.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)460324885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D5;
					case 21:
						radioParams.ConBrdHwHostVersion = rcmpVersionInformation7.VersionInformation.TrimEnd(trimChars);
						num = (short)888602659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (rcmpVersionInformation6.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)88997902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EA;
					case 23:
						radioParams.IsTlsPskCompatible = true;
						radioParams.TlsPskPortNumber = rcmpBigEndianHexVersionInformation.VersionInformation.ToString();
						num = (short)938278948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_7DA;
					case 25:
					{
						num = (short)1696661357;
						short num3 = num;
						num = (short)1302527853;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6EA;
						default:
						{
							num = (short)1828913152;
							if (num != 0)
							{
							}
							num = (short)942407680;
							short num4 = num;
							radioParams.ConBrdHardwareType = rcmpVersionInformation8.VersionInformation.TrimEnd(trimChars);
							num = (short)292945936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 26:
						radioParams.OptBrdHardwareType = rcmpVersionInformation9.VersionInformation.TrimEnd(trimChars);
						num = (short)2048262146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (rcmpVersionInformation8.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)244973593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_567;
					case 28:
						radioParams.OptBrdFlashImageType = rcmpVersionInformation4.VersionInformation.TrimEnd(trimChars);
						radioParams.OptBrdHwHostVersion = rcmpVersionInformation10.VersionInformation.TrimEnd(trimChars);
						num = (short)121962520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (rcmpVersionInformation9.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)539426842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 30:
						if (rcmpVersionInformation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1476132867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_917;
					case 31:
						goto IL_3A2;
					case 32:
						if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)138280993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_524;
					case 33:
						radioParams.DefaultGatewayNetworkAttachmentValue = rcmpRadioStatus.Status[0].ToString();
						num = (short)1237123090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						radioParams.OptBrdHwNotPresentFlag = true;
						num = (short)1773731847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_8D5;
					case 36:
						return radioParams;
					case 37:
						if (rcmpVersionInformation5.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)958726153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_457;
					}
					goto IL_C6;
					IL_3A2:
					num = (short)692715521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_416:
					num = (short)31653910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_457:
					num = (short)245366816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_524:
					num = (short)155320331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_567:
					num = (short)1468465172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64B:
					num = (short)278003718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EA:
					num = (short)1076625412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7DA:
					num = (short)403832859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D5:
					num = (short)1415643144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_917:
					num = (short)882114589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98B:
					num = (short)375980069;
					num2 = (int)((global::System.IntPtr)num);
				}
				return radioParams;
				IL_C6:
				radioParams = null;
				global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteModelNumber);
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber2 = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber2);
				global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
				xcmpSuperBundle.AddRcmpMessage(rcmpReadUUID);
				rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.DefaultGatewayNetworkAttachment);
				xcmpSuperBundle.AddRcmpMessage(rcmpRadioStatus);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation11 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation11);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation12 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation12);
				rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.BBFBundleVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation2);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation13 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.TuneVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation13);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation14 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashBootAppVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation14);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation15 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.DspSoftwareVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation15);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation16 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceFlashVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation16);
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation17 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation17);
				rcmpVersionInformation6 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardName);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation6);
				rcmpVersionInformation9 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardHardwareType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation9);
				rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardMainAppVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation3);
				rcmpVersionInformation10 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardFlashImageVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation10);
				rcmpVersionInformation4 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardFlashImageType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation4);
				rcmpVersionInformation8 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConsoletteBrdHwType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation8);
				rcmpVersionInformation7 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConsoletteBrdHostVer);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation7);
				rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadESN, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber);
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceHardwareType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation);
				rcmpVersionInformation5 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceHardwareVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation5);
				rcmpBigEndianHexVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.TlsPskPortNumber);
				xcmpSuperBundle.AddRcmpMessage(rcmpBigEndianHexVersionInformation);
				xcmpSuperBundle.ReadTimeout = 15000;
				this.RcmpWrapper.SendAndReceiveMessage(xcmpSuperBundle);
				radioParams = new global::Motorola.Common.Communication.RadioParams();
				trimChars = new char[]
				{
					'\0',
					' ',
					'\r',
					'\n'
				};
				radioParams.SerialNumber = rcmpReadWriteSerialNumber2.SerialNumber;
				radioParams.ModelNumber = rcmpReadWriteModelNumber.ModelNumber;
				radioParams.Uuid = new global::System.Guid(rcmpReadUUID.UUID);
				radioParams.CodeplugVersion = rcmpVersionInformation11.VersionInformation.TrimEnd(trimChars);
				radioParams.HostVersion = rcmpVersionInformation12.VersionInformation.TrimEnd(trimChars);
				radioParams.TuneVersion = rcmpVersionInformation13.VersionInformation.TrimEnd(trimChars);
				radioParams.BootAppVersion = rcmpVersionInformation14.VersionInformation.TrimEnd(trimChars);
				radioParams.DspVersion = rcmpVersionInformation15.VersionInformation.TrimEnd(trimChars);
				radioParams.MaceFlashVersion = rcmpVersionInformation16.VersionInformation.TrimEnd(trimChars);
				radioParams.PsdtVersion = rcmpVersionInformation17.VersionInformation.TrimEnd(trimChars);
				num = (short)969736222;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000F51C File Offset: 0x0000D71C
		private bool c()
		{
			short num = (short)1954807808;
			switch (num)
			{
			default:
			{
				byte[] array = this.IOController.QueryRadioUUID();
				global::System.Guid guid = new global::System.Guid(array);
				bool result;
				using (global::System.Collections.Generic.Dictionary<global::System.Guid, string>.KeyCollection.Enumerator enumerator = global::Motorola.Common.Communication.AstroCpsSequenceManager.k.Value.Keys.GetEnumerator())
				{
					num = (short)2045313025;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_132;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E1;
							}
							continue;
						case 2:
						{
							num = (short)294242590;
							short num3 = num;
							num = (short)1916324126;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_132;
							default:
								num = (short)327876608;
								if (num != 0)
								{
								}
								result = true;
								num = (short)1023737860;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_1DA;
						case 4:
							goto IL_1BF;
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)225312774;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)156434432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)171245571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E3:
						num = (short)1084227589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_132:
						if (enumerator.Current == guid)
						{
							num = (short)355729410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E1:
						goto IL_E3;
					}
					IL_1BF:
					return result;
					IL_1DA:
					goto IL_48;
				}
				return result;
				IL_48:
				num = (short)683016192;
				short num4 = num;
				num = (short)1096679425;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000F734 File Offset: 0x0000D934
		private bool a(global::System.Guid A_0)
		{
			short num = (short)1245773825;
			if (num != 0)
			{
			}
			bool result;
			using (global::System.Collections.Generic.Dictionary<global::System.Guid, string>.KeyCollection.Enumerator enumerator = global::Motorola.Common.Communication.AstroCpsSequenceManager.k.Value.Keys.GetEnumerator())
			{
				num = (short)914489345;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_CB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 2:
					{
						num = (short)933688624;
						short num3 = num;
						num = (short)1245181232;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CB;
						default:
							num = (short)2080309248;
							if (num != 0)
							{
							}
							result = true;
							num = (short)1200750596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_171;
					case 4:
						goto IL_158;
					case 5:
						if (!enumerator.MoveNext())
						{
							num = (short)1484849158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)896073728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1734279171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_81:
					num = (short)668139525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB:
					if (enumerator.Current == A_0)
					{
						num = (short)1378484226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7F:
					goto IL_81;
				}
				IL_158:
				goto IL_184;
				IL_171:
				return false;
			}
			IL_184:
			num = (short)412745728;
			short num4 = num;
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000F90C File Offset: 0x0000DB0C
		internal string j()
		{
			short num = (short)2025848833;
			if (num != 0)
			{
			}
			num = (short)1823735808;
			switch (num)
			{
			default:
			{
				num = (short)1330380800;
				short num2 = num;
				byte[] array = this.IOController.QueryRadioUUID();
				global::System.Guid guid = new global::System.Guid(array);
				string value;
				using (global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator = global::Motorola.Common.Communication.AstroCpsSequenceManager.k.Value.GetEnumerator())
				{
					num = (short)302776321;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair;
						switch (num3)
						{
						case 0:
							if (keyValuePair.Key == guid)
							{
								num = (short)285540354;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 2:
							value = keyValuePair.Value;
							num = (short)54132740;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1E9;
						case 4:
							goto IL_1CF;
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)340393990;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_160;
						case 6:
						{
							num = (short)12385688;
							short num4 = num;
							num = (short)1405091224;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_160;
							default:
								num = (short)1067843584;
								if (num != 0)
								{
								}
								num = (short)807665667;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_DF:
						num = (short)988938245;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DD:
						goto IL_DF;
						IL_160:
						keyValuePair = enumerator.Current;
						num = (short)476119040;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1CF:
					return value;
					IL_1E9:
					goto IL_94;
				}
				return value;
				IL_94:
				return string.Empty;
			}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000FB34 File Offset: 0x0000DD34
		private uint c(uint A_0)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			string psdtSrcSectionId;
			string psdtTgtSectionId;
			short num2;
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_8B;
				case 1:
					psdtSrcSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("믷꫹꿻볽", a_);
					psdtTgtSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("믷꫹꿻볽", a_);
					num2 = (short)1062600704;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (A_0 == 2U)
					{
						num2 = (short)438042630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1267400709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_8B;
				case 4:
					goto IL_14F;
				case 5:
					num2 = (short)973471745;
					if (num2 != 0)
					{
					}
					if (A_0 == 1U)
					{
						num2 = (short)1591476225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8B;
				case 6:
					psdtSrcSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("믷꫹꿻뿽", a_);
					psdtTgtSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("믷꫹꿻뿽", a_);
					num2 = (short)199950339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)1321664512;
					short num3 = num2;
					if (xcmpPsdtAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1369899012;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_235;
				}
				}
				goto IL_39;
				IL_8B:
				xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.GetStartAddress, psdtSrcSectionId, psdtTgtSectionId);
				this.RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
				num2 = (short)1969261363;
				short num4 = num2;
				num2 = (short)1154779955;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_39;
				default:
					num2 = (short)1951399936;
					if (num2 != 0)
					{
					}
					num2 = (short)2002780167;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_14F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
			IL_235:
			return xcmpPsdtAccess.PsdtAddress;
			IL_39:
			psdtSrcSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뛷뗹닻믽", a_);
			psdtTgtSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뛷뗹닻믽", a_);
			num2 = (short)1573453826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		private int b(uint A_0)
		{
			short num = (short)884342785;
			if (num != 0)
			{
			}
			num = (short)1721106432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				int result;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						goto IL_226;
					case 1:
						goto IL_1F3;
					case 2:
					{
						if (A_0 > 33554432U)
						{
							num = (short)1810169857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[1024];
						array = global::Motorola.Common.Communication.AstroCpsSequenceManager.q;
						byte[] bytes = global::System.BitConverter.GetBytes(A_0);
						array[2] = bytes[3];
						array[3] = bytes[2];
						global::Motorola.Common.Communication.Rcmp.CustomRcmpMessage customRcmpMessage = new global::Motorola.Common.Communication.Rcmp.CustomRcmpMessage(array);
						this.RcmpWrapper.SendAndReceiveMessage(customRcmpMessage);
						byte[] replyBuffer = customRcmpMessage.ReplyBuffer;
						num = (short)362151941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						byte[] array;
						byte[] replyBuffer;
						if (replyBuffer[7] == array[6])
						{
							num = (short)29556736;
							short num3 = num;
							num = (short)1612578823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F8;
					}
					case 4:
						if (A_0 < 1U)
						{
							num = (short)1585053705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)822673410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						byte[] replyBuffer;
						if (replyBuffer[0] == 130)
						{
							num = (short)877527046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F8;
					}
					case 6:
						num = (short)207290371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)270139400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						byte[] array;
						byte[] replyBuffer;
						if (replyBuffer[8] == array[7])
						{
							num = (short)1917124618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F8;
					}
					case 9:
						goto IL_109;
					case 10:
						result = 1;
						num = (short)1960509440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
				}
				IL_109:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_1F3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				IL_1F8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
				IL_226:
				return result;
				IL_83:
				result = 0;
				num = (short)1295917975;
				short num4 = num;
				num = (short)1067525015;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)1765867520;
					if (num != 0)
					{
					}
					num = (short)1754464260;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_50;
				}
				break;
			}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00010040 File Offset: 0x0000E240
		private int a(uint A_0)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess;
			short num2;
			string psdtSrcSectionId;
			string psdtTgtSectionId;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (xcmpPsdtAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1078198274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18D;
				case 1:
					goto IL_B2;
				case 2:
				{
					num2 = (short)1570701741;
					short num3 = num2;
					num2 = (short)1540882861;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C7;
					default:
						goto IL_137;
					}
					break;
				}
				case 3:
					if (A_0 == 2U)
					{
						num2 = (short)398262273;
						if (num2 != 0)
						{
						}
						num2 = (short)1372979204;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B2;
				case 4:
					psdtSrcSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꫸뻺뻼뷾", a_);
					psdtTgtSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꫸뻺뻼뻾", a_);
					num2 = (short)2024144897;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2D;
				IL_C7:
				num2 = (short)385613824;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_B2:
				xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Copy, psdtSrcSectionId, psdtTgtSectionId);
				this.RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
				goto IL_C7;
			}
			IL_137:
			num2 = (short)695205888;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
			IL_18D:
			num2 = (short)1825964032;
			short num4 = num2;
			return (int)xcmpPsdtAccess.ReplyResult;
			IL_2D:
			psdtSrcSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꫸뻺뻼뻾", a_);
			psdtTgtSectionId = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꫸뻺뻼뷾", a_);
			num2 = (short)656474115;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001020C File Offset: 0x0000E40C
		private static byte[] b()
		{
			int a_ = 14;
			short num = (short)1187840000;
			switch (num)
			{
			default:
			{
				num = (short)1492779009;
				if (num != 0)
				{
				}
				string filePath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("돽旿瘁攃戅椇縉洋", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뿽叿嘁嘃䤅", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("돽懿愁漃漅昇欉笋儍吏嘑崓娕䰗㐙漛氝䔟䄡", a_));
				global::Motorola.Common.Communication.Srecord srecord = new global::Motorola.Common.Communication.Srecord();
				byte[] array;
				try
				{
					srecord.LoadSrecordData(filePath, global::Motorola.Common.Communication.AstroCpsSequenceManager.o, true);
					int num2 = 0;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.SrecData> enumerator = srecord.DataRecords.GetEnumerator();
					try
					{
						num = (short)142737411;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)328335361;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_169;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_EE;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1933967360;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.SrecData srecData = enumerator.Current;
								num2 += (int)srecData.DataLen;
								num = (short)391708674;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_F0:
							num = (short)472317956;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_EE:
							goto IL_F0;
						}
						IL_169:
						goto IL_375;
					}
					finally
					{
						num = (short)692977666;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_20A;
							case 1:
								goto IL_229;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A1;
								}
								continue;
							}
							IL_1A1:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1853339094;
							short num4 = num;
							num = (short)2080814550;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1628897280;
								if (num != 0)
								{
								}
								num = (short)574554112;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_20A:
							enumerator.Dispose();
							num = (short)1156841473;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_229:;
					}
					int num5;
					try
					{
						IL_22C:
						num = (short)874840067;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1671430146;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.SrecData srecData2 = enumerator.Current;
								global::System.Array.Copy(srecData2.GetData(), 0L, array, (long)num5, (long)((ulong)srecData2.DataLen));
								num5 += (int)srecData2.DataLen;
								num = (short)2144665604;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_302;
							case 2:
								num = (short)207945729;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_267;
								}
								continue;
							}
							IL_2B0:
							num = (short)1451950080;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_267:
							goto IL_2B0;
						}
						IL_302:
						goto IL_442;
					}
					finally
					{
						num = (short)729808898;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)552992769;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_372;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_33A;
								}
								continue;
							}
							IL_33A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1316159488;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_372:;
					}
					IL_375:
					array = new byte[num2 + global::Motorola.Common.Communication.AstroCpsSequenceManager.p.Length + 2];
					global::System.Array.Copy(global::Motorola.Common.Communication.AstroCpsSequenceManager.p, array, global::Motorola.Common.Communication.AstroCpsSequenceManager.p.Length);
					array[global::Motorola.Common.Communication.AstroCpsSequenceManager.p.Length] = (byte)(num2 >> 8);
					array[global::Motorola.Common.Communication.AstroCpsSequenceManager.p.Length + 1] = (byte)(num2 & 255);
					num5 = global::Motorola.Common.Communication.AstroCpsSequenceManager.p.Length + 2;
					enumerator = srecord.DataRecords.GetEnumerator();
					goto IL_22C;
				}
				finally
				{
					num = (short)951713794;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)srecord).Dispose();
							num = (short)1035206657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_43F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_408;
							}
							continue;
						}
						IL_408:
						if (srecord == null)
						{
							break;
						}
						num = (short)1997602816;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_43F:;
				}
				IL_442:
				num = (short)1994784768;
				short num6 = num;
				return array;
			}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000106D0 File Offset: 0x0000E8D0
		protected void UpdatePINPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)1841364992;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
					for (;;)
					{
						IL_30:
						string targetPwdHead;
						string encryptedPwd;
						string targetPwdTail;
						switch (num2)
						{
						case 0:
							goto IL_362;
						case 1:
						{
							string text;
							if (text.Length > 4)
							{
								num = (short)865337357;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							targetPwdHead = text;
							num = (short)1242890243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_227;
						case 3:
							goto IL_277;
						case 4:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("圁球戅椇縉椋帍夏少䐓眕欗椙欛焝刟䘡昣䌥丧䔩師䬭术䀱崳䈵崷ᨹ弻嘽┿⅁⽃晅㱇≉⥋湍㉏㹑㭓㕕㍗穙㩛㽝य़๡䡣䙥ŧṩ䱫ɭὯᵱέյ塷᡹᥻幽ꊁﲍﮑ歹뢗춙풟잡蒣횥즧\udea9쒫", a_), global::System.Array.Empty<object>());
							num = (short)1968308226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_3BC;
						case 6:
							goto IL_3A2;
						case 7:
							for (;;)
							{
								num = (short)903894211;
								short num3 = num;
								num = (short)57496771;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_2D5;
								}
							}
							IL_2D5:
							num = (short)1190592512;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("䰁愃焅⠇変椋洍攏怑紓戕愗㨙䰛缝刟嘡䴣別䄧䔩䈫อ䜯嬱䀳帵ᠷ丹吻嬽怿ⵁ⡃≅桇ⱉ╋㱍㵏║㕓⑕㵗癙籛੝⡟⭡㝣䙥Ⅷ㥩䱫⽭偯㭱㩳⁵㥷㙹㕻㩽ꁿ킁얃슅솇얉ꊋ", a_), global::System.Array.Empty<object>());
							num = (short)1500774400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_3A2;
						case 9:
							if (!this.a())
							{
								num = (short)720437255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_362;
						case 10:
							if (!global::Motorola.Common.Communication.CodeplugParseHelper.IsPINPSWBlockExist(pbaToWrite))
							{
								num = (short)558891012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							encryptedPwd = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPassword(pbaToWrite);
							num = (short)1395261456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_277;
						case 12:
							num = (short)1986002953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							string text;
							targetPwdHead = text.Substring(0, 4);
							targetPwdTail = text.Substring(4);
							num = (short)1740832779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							string text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
							num = (short)766115841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							if (encryptedPwd != global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("㈁㐃㘅㠇㨉㰋㸍‏∑␓☕⠗⨙Ⱋ⸝ဟሡᐣᘥᠧᨩᰫḭ/ȱгص࠷ਹ఻฽瀿牁瑃癅硇穉籋繍恏扑摓晕桗橙汛湝偟剡呣噥塧婩屫幭䁯䉱䑳䙵䡷䩹䱻乽끿늁뒃뚅뢇몉벋뺍ꂏꊑ꒓ꚕꢗꪙ겛꺝邟銡钣隥颧骩鲫麭肯花蒳蚵袷誹費躽", a_))
							{
								num = (short)770572302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						case 16:
							if (global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPasswordFlag(pbaObject))
							{
								num = (short)849149964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							targetPwdHead = string.Empty;
							targetPwdTail = string.Empty;
							num = (short)903741455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B;
						IL_277:
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteClearPassword(pbaToWrite, targetPwdHead, targetPwdTail);
						num = (short)287047688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_362:
						string encryptedPwd2 = global::authAES.AESCryptography.AESEncrypt(global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd), (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteEncryptPassword(pbaToWrite, encryptedPwd2);
						num = (short)1944780806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A2:
						num = (short)877002757;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_227:
					IL_3BC:
					break;
					IL_7B:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
					list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 903, 0));
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.SetCodeplug(codeplug);
					num = (short)1170800650;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("圁球戅椇縉椋帍夏少䐓眕欗椙欛焝刟䘡昣䌥丧䔩師䬭术䀱崳䈵崷ᨹ娻弽⤿⹁⅃≅桇㵉╋㩍㡏桑瑓ⵕ桗❙", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			num = (short)2146435073;
			if (num != 0)
			{
			}
			num = (short)32047104;
			short num4 = num;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00010B34 File Offset: 0x0000ED34
		protected void UpdatePINPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)1592786944;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					string encryptedPwd;
					for (;;)
					{
						IL_30:
						string text;
						switch (num2)
						{
						case 0:
							if (global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPasswordFlag(pbaForRead))
							{
								num = (short)1826816013;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_436;
						case 1:
							goto IL_44E;
						case 2:
							if (!this.a())
							{
								num = (short)363790350;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3EF;
						case 3:
							if (global::Motorola.Common.Communication.CodeplugParseHelper.IsPINPSWBlockExist(pbaForRead))
							{
								num = (short)987627539;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뫸铺郼鋾琀洂氄搆栈缊搌怎缐䰒䘔爖栘渚砜焞䈠䘢栤䘦䜨䨪䨬䨮䌰氲琴䐶䴸䤺刼怾ࡀⵂ㍄♆╈≊⥌၎ᑐ㵒㙔╖⁘⭚⥜㙞๠ൢ㩤㝦ࡨᡪṬᡮṰŲᅴ⡶㽸᝺ᱼ᡾궀ꎂﺊ놐ﺖ뮚쒠莢쾤좦쮨說責", a_), global::System.Array.Empty<object>());
							num = (short)862191631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1ED;
						case 5:
							if (!global::Motorola.Common.Communication.AstroCpsSequenceManager.a(text))
							{
								num = (short)168820745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1ED;
						case 6:
							num = (short)668794881;
							if (num != 0)
							{
							}
							text = string.Empty;
							num = (short)276824081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!global::Motorola.Common.Communication.AstroCpsSequenceManager.a(text))
							{
								num = (short)714473493;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1ED;
						case 8:
							text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
							num = (short)1401683988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
							num = (short)1603062909;
							short num3 = num;
							num = (short)558681213;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)528351232;
								if (num != 0)
								{
								}
								num = (short)347799559;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							if (global::Motorola.Common.Communication.CodeplugParseHelper.ReadOutOfBoxExperienceFlag(pbaForRead))
							{
								num = (short)614858760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::authAES.AESCryptography.AESDecrypt(encryptedPwd, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
							num = (short)895746053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_436;
						case 12:
							text = global::authAES.AESCryptography.AESDecrypt(encryptedPwd, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
							num = (short)257163282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)730857475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("럸黺諼\udffe刀昂昄爆笈戊礌瘎ㄐ䌒琔攖洘爚検瘞丠䴢Ԥ倦䀨弪䔬༮䔰嬲倴᜶嘸场夼Ἶ❀⩂㝄⩆㹈⩊㽌⩎結獒Ŕὖၘ࡚絜ᙞ㉠䍢⑤䝦⁨╪㭬⹮㵰㩲ㅴ坶⭸㩺㥼㙾캀궂", a_), global::System.Array.Empty<object>());
							num = (short)1446379536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_436;
						case 16:
							goto IL_3EF;
						case 17:
							goto IL_1ED;
						case 18:
							if (!global::Motorola.Common.Communication.AstroCpsSequenceManager.a(text))
							{
								num = (short)884801542;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1ED;
						case 19:
							num = (short)654573570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (!global::Motorola.Common.Communication.AstroCpsSequenceManager.a(text))
							{
								num = (short)428933132;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1ED;
						case 21:
							text = string.Empty;
							num = (short)1573847044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F;
						IL_1ED:
						string encryptedPwd2 = global::authAES.AESCryptography.AESEncryptWithDefKey(text);
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteEncryptPassword(pbaForRead, encryptedPwd2);
						num = (short)37552139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3EF:
						text = string.Empty;
						num = (short)197525514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_436:
						num = (short)50200577;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_44E:
					break;
					IL_8F:
					encryptedPwd = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPassword(pbaForRead);
					num = (short)1747714048;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("곸诺駼黾甀昂唄丆䜈嬊氌簎成搒稔攖紘娚笜欞䐠儢眤䈦䠨伪ബ䤮倰娲头制崸ᬺ䨼嘾㕀⭂罄杆㉈筊が", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			num = (short)193921024;
			short num4 = num;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00011004 File Offset: 0x0000F204
		private static bool a(string pwd)
		{
			int a_ = 10;
			short num = (short)2017853441;
			if (num != 0)
			{
			}
			num = (short)630541981;
			short num2 = num;
			num = (short)1578323613;
			switch (num2 == num)
			{
			}
			num = (short)1173880832;
			if (num != 0)
			{
			}
			num = (short)569180160;
			short num3 = num;
			return new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓹꟻ컽ⷿ㬁䔃⬅切欉ℋ琍䰏㈑䠓㬕䐗ㄙ䀛ㄝ簟ࠡ砣ԥ琧఩瀫ଭ氯ᘱ椳䴵࠷ᘹ฻฽㴿晁", a_)).IsMatch(pwd);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000110D0 File Offset: 0x0000F2D0
		protected void UpdateWiFiPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 14;
			short num;
			try
			{
				num = (short)444617447;
				short num2 = num;
				num = (short)1818448615;
				switch (num2 == num)
				{
				}
				num = (short)1352400896;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateWiFiEncryptPassword(pbaToWrite, global::authAES.AESCryptography.CIPHER_DEF_KEY, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯽烿昁攃爅洇崉攋䠍礏䈑甓攕欗洙猛氝䐟怡䄣䀥䜧堩䤫礭䈯嬱䀳匵ᠷ尹崻圽ⰿ❁⁃晅㽇⍉㡋♍橏牑⽓晕╗", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_WiFi_Password_Fail);
			}
			num = (short)1491468289;
			if (num != 0)
			{
			}
			num = (short)642973696;
			short num3 = num;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000111E8 File Offset: 0x0000F3E8
		protected void UpdateWiFiPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)269174425;
				short num2 = num;
				num = (short)1038239385;
				switch (num2 == num)
				{
				}
				num = (short)563937280;
				if (num != 0)
				{
				}
				bool outOfBoxExperience = global::Motorola.Common.Communication.CodeplugParseHelper.ReadOutOfBoxExperienceFlag(pbaForRead);
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateWiFiEncryptPassword(pbaForRead, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, global::authAES.AESCryptography.CIPHER_DEF_KEY, outOfBoxExperience);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("圁球戅椇縉椋复礏向紓䘕礗椙漛椝伟倡䀣朥丧帩䤫尭戯圱唳刵ᠷ尹崻圽ⰿ❁⁃晅㽇⍉㡋♍橏牑⽓晕╗", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_WiFi_Password_Fail);
			}
			num = (short)1125449729;
			if (num != 0)
			{
			}
			num = (short)177274880;
			short num3 = num;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00011304 File Offset: 0x0000F504
		protected void UpdateOobeBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)589973932;
				short num2 = num;
				num = (short)125454764;
				switch (num2 == num)
				{
				}
				num = (short)1566048256;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateOutOfBoxExperienceFlagToFalse(pba);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("吀猂愄昆紈渊䈌税攐尒猔唖瘘挚堜朞儠䘢圤並䰨䔪丬䨮眰弲吴倶洸吺笼帾ⵀあ⁄杆⽈⩊⑌⍎㑐㝒畔⁖じ⽚㕜敞䅠ᡢ啤ᩦ", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Update_Oobe_Field_Fail);
			}
			num = (short)638386177;
			if (num != 0)
			{
			}
			num = (short)1323958272;
			short num3 = num;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00011400 File Offset: 0x0000F600
		protected void UpdateExternalDataModemPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)245377029;
				short num2 = num;
				num = (short)873211909;
				switch (num2 == num)
				{
				}
				num = (short)1425276928;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateExternalDataModemEncryptPassword(pbaToWrite, global::authAES.AESCryptography.CIPHER_DEF_KEY, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓰ菲釴零跸黺룼蟾甀昂眄椆栈朊䤌渎攐爒堔砖紘縚瀜伞䀠倢嘤倦䘨太䤬洮吰唲娴䔶尸氺似嘾㕀♂敄ⅆ⡈≊⅌⩎㕐獒≔㹖ⵘ㍚杜罞᩠卢ᡤ", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_External_Data_Modem_Password_Fail);
			}
			num = (short)379256833;
			if (num != 0)
			{
			}
			num = (short)94502912;
			short num3 = num;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00011510 File Offset: 0x0000F710
		protected void UpdateExternalDataModemPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			int a_ = 2;
			short num;
			try
			{
				num = (short)1805103570;
				short num2 = num;
				num = (short)1992274386;
				switch (num2 == num)
				{
				}
				num = (short)1041891328;
				if (num != 0)
				{
				}
				bool outOfBoxExperience = global::Motorola.Common.Communication.CodeplugParseHelper.ReadOutOfBoxExperienceFlag(pbaForRead);
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateExternalDataModemEncryptPassword(pbaForRead, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, global::authAES.AESCryptography.CIPHER_DEF_KEY, outOfBoxExperience);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꟱蓳鋵駷軹駻믽磿瘁愃琅昇欉怋䨍焏昑甓嬕眗縙礛猝瀟䌡圣唥弧䔩師䨭焯吱䀳匵䨷根夻弽␿扁≃❅ⅇ♉⥋⩍灏║㵓≕し恙籛╝偟ὡ", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_External_Data_Modem_Password_Fail);
			}
			num = (short)447545345;
			if (num != 0)
			{
			}
			num = (short)1721761792;
			short num3 = num;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001162C File Offset: 0x0000F82C
		protected void UpdateMacAddressBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)302108015;
				short num2 = num;
				num = (short)619105647;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AB;
				default:
					num = (short)370933760;
					if (num != 0)
					{
					}
					num = (short)451543040;
					num3 = (int)num;
					switch (num3)
					{
					default:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						break;
					}
					break;
				}
				byte[] array;
				int num4;
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
				for (;;)
				{
					IL_7C:
					switch (num3)
					{
					case 0:
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteMacAddress(pbaToWrite, array, num4);
						num = (short)2041249799;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (array != null)
						{
							num = (short)2021785609;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20F;
					case 2:
						goto IL_15A;
					case 3:
						if (array != null)
						{
							num = (short)1915551744;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 4:
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteMacAddress(pbaToWrite, array, num4);
						num = (short)1312555010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_276;
					case 6:
						if (array != null)
						{
							num = (short)890830852;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 7:
						goto IL_25E;
					case 8:
						goto IL_20F;
					case 9:
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteMacAddress(pbaToWrite, array, num4);
						num = (short)1951793160;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
					IL_15A:
					num4 = 206;
					array = this.a(pbaObject, num4, 6);
					num = (short)1850081283;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_20F:
					num4 = 200;
					array = this.a(pbaObject, num4, 6);
					num = (short)348913670;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_25E:
					num = (short)1648295941;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_276:
				goto IL_2A4;
				IL_AB:
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
				list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 900, 0));
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
				pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject.SetCodeplug(codeplug);
				num4 = 163;
				array = this.a(pbaObject, num4, 6);
				num = (short)583598081;
				if (num != 0)
				{
				}
				num = (short)1121452033;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귷諹飻鿽瓿朁䤃朅欇䬉栋樍戏眑朓攕娗缙稛焝刟䜡猣吥䄧帩䤫อ嘯匱崳娵崷帹᰻䤽⤿㙁ⱃ籅桇ㅉ籋㍍", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			IL_2A4:
			num = (short)1153040384;
			short num5 = num;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00011924 File Offset: 0x0000FB24
		private byte[] a(global::Motorola.Common.Communication.Pba.PbaObject A_0, int A_1, int A_2)
		{
			short num = (short)1379663872;
			switch (num)
			{
			default:
			{
				num = (short)1311965185;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				byte[] array = null;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)203620354;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							array = new byte[A_2];
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							global::System.Array.Copy(value.Data, A_1, array, 0, A_2);
							num = (short)848822280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1204551686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 3:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)753467399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1139277825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)1828519945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)1419378698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_222;
						case 7:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data.Length > A_1 + A_2)
							{
								num = (short)1052049408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data != null)
							{
								num = (short)464519173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 900)
							{
								num = (short)1725693955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_EF:
						num = (short)94765060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6:
						goto IL_EF;
					}
					IL_222:;
				}
				finally
				{
					for (;;)
					{
						IL_227:
						num = (short)1207959554;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2DF;
							case 1:
								enumerator.Dispose();
								num = (short)2129264640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_25A;
								}
								continue;
							}
							IL_25A:
							num = (short)976123073;
							short num3 = num;
							num = (short)340030657;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_227;
							default:
								num = (short)663027712;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_2E1;
								}
								num = (short)2040201217;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
					}
					IL_2DF:
					IL_2E1:;
				}
				num = (short)1728118784;
				short num4 = num;
				return array;
			}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011C5C File Offset: 0x0000FE5C
		private bool a()
		{
			int a_ = 12;
			short num = (short)488258237;
			short num2 = num;
			num = (short)462174909;
			switch (num2 == num)
			{
			}
			num = (short)1525940225;
			if (num != 0)
			{
			}
			num = (short)1180041216;
			if (num != 0)
			{
			}
			num = (short)1217658880;
			short num3 = num;
			return global::Motorola.Common.Communication.n.a(this.ExtendedDeviceInfo.SoftwareVersion, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("룻컽㣿Ⰱ㰃㌅☇㨉㰋", a_)) > 0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00011D30 File Offset: 0x0000FF30
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			short num = (short)448048569;
			short num2 = num;
			num = (short)1160818105;
			switch (num2 == num)
			{
			}
			num = (short)1404764160;
			if (num != 0)
			{
			}
			num = (short)633077761;
			if (num != 0)
			{
			}
			num = (short)253493248;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		public byte QueryRadioUpdateStatus()
		{
			short num = (short)1761007417;
			short num2 = num;
			num = (short)281794361;
			switch (num2 == num)
			{
			}
			num = (short)1363935233;
			if (num != 0)
			{
			}
			num = (short)1520828416;
			if (num != 0)
			{
			}
			num = (short)1180499968;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011E98 File Offset: 0x00010098
		public void ReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs)
		{
			short num = (short)1652359168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2015035393;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = new global::System.Collections.ArrayList(paramPairs.RadioParameters.Keys).GetEnumerator();
				try
				{
					num = (short)1386086402;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.CommonUtil.RadioParameterType key;
						object value;
						switch (num2)
						{
						case 0:
							goto IL_CD;
						case 1:
							num = (short)1891762186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B1;
							}
							continue;
						case 4:
							switch (key)
							{
							case global::Motorola.Common.Communication.CommonUtil.RadioParameterType.Region:
							case global::Motorola.Common.Communication.CommonUtil.RadioParameterType.TanapaNumber:
								goto IL_CD;
							case global::Motorola.Common.Communication.CommonUtil.RadioParameterType.ModelNumber:
								value = this.IOController.QueryRadioModelNumber();
								num = (short)2093154304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.CommonUtil.RadioParameterType.CodeplugVersion:
								value = this.IOController.QueryCodeplugVersion();
								num = (short)1031929863;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.Common.Communication.CommonUtil.RadioParameterType.FirmwareVersion:
								value = this.IOController.QuerySoftwareVersion().TrimEnd(this.b);
								num = (short)1845297161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)1955004417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)486866952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							key = (global::Motorola.Common.Communication.CommonUtil.RadioParameterType)enumerator.Current;
							value = null;
							num = (short)1637810180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_232;
						case 7:
							goto IL_CD;
						case 8:
							num = (short)372178950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_CD;
						case 10:
							goto IL_CD;
						}
						goto IL_B1;
						IL_CD:
						paramPairs.RadioParameters[key] = value;
						num = (short)1642397699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_187:
						num = (short)13369349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B1:
						goto IL_187;
					}
					IL_232:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_254;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_241:
						switch (num2)
						{
						case 0:
						{
							num = (short)2018155447;
							short num3 = num;
							num = (short)1228512183;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_270;
							default:
								goto IL_2DF;
							}
							break;
						}
						case 1:
							disposable.Dispose();
							num = (short)586547200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_270;
						}
						goto IL_254;
						IL_270:
						if (disposable == null)
						{
							goto IL_2F7;
						}
						num = (short)2052915201;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2DF:
					num = (short)2005860352;
					if (num != 0)
					{
					}
					IL_2F7:
					goto EndFinally_6;
					IL_254:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)522780674;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_241;
					EndFinally_6:;
				}
				num = (short)1219887104;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000121E4 File Offset: 0x000103E4
		// Note: this type is marked as 'beforefieldinit'.
		static AstroCpsSequenceManager()
		{
			short num = (short)396317738;
			short num2 = num;
			num = (short)1891914794;
			switch (num2 == num)
			{
			}
			num = (short)1708654593;
			if (num != 0)
			{
			}
			num = (short)217120768;
			short num3 = num;
			num = (short)1667170304;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AstroCpsSequenceManager.k = new global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Guid, string>>(new global::System.Func<global::System.Collections.Generic.Dictionary<global::System.Guid, string>>(global::Motorola.Common.Communication.AstroCpsSequenceManager.f), global::System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
			global::Motorola.Common.Communication.AstroCpsSequenceManager.o = 65536;
			global::Motorola.Common.Communication.AstroCpsSequenceManager.p = new byte[]
			{
				2,
				2,
				0,
				158,
				0,
				0
			};
			global::Motorola.Common.Communication.AstroCpsSequenceManager.q = new byte[]
			{
				2,
				2,
				0,
				158,
				0,
				0,
				4,
				44,
				67,
				83,
				68,
				88,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				0,
				0,
				64,
				0,
				byte.MaxValue,
				195,
				161,
				209,
				0,
				0,
				0,
				3,
				82,
				8,
				0,
				17,
				67,
				80,
				71,
				88,
				0,
				0,
				0,
				48,
				85,
				67,
				76,
				88,
				0,
				0,
				3,
				212,
				83,
				69,
				67,
				88,
				0,
				0,
				4,
				32,
				0,
				232,
				byte.MaxValue,
				byte.MaxValue,
				3,
				232,
				4,
				137,
				15,
				159,
				0,
				0,
				15,
				158,
				0,
				0,
				15,
				157,
				0,
				0,
				15,
				156,
				0,
				0,
				15,
				155,
				0,
				0,
				15,
				154,
				0,
				0,
				15,
				153,
				0,
				0,
				15,
				152,
				0,
				0,
				15,
				151,
				0,
				0,
				15,
				150,
				0,
				0,
				15,
				149,
				0,
				0,
				15,
				148,
				0,
				0,
				15,
				147,
				0,
				0,
				15,
				146,
				0,
				0,
				15,
				145,
				0,
				0,
				15,
				144,
				0,
				0,
				15,
				143,
				0,
				0,
				15,
				142,
				0,
				0,
				15,
				141,
				0,
				0,
				15,
				140,
				0,
				0,
				15,
				139,
				0,
				0,
				15,
				138,
				0,
				0,
				15,
				137,
				0,
				0,
				15,
				136,
				0,
				0,
				15,
				135,
				0,
				0,
				15,
				134,
				7,
				209,
				15,
				133,
				7,
				209,
				15,
				132,
				7,
				209,
				15,
				131,
				7,
				209,
				15,
				130,
				7,
				209,
				15,
				129,
				7,
				209,
				15,
				128,
				7,
				209,
				15,
				127,
				7,
				209,
				15,
				109,
				0,
				0,
				15,
				108,
				0,
				0,
				15,
				107,
				0,
				0,
				15,
				106,
				0,
				0,
				15,
				105,
				0,
				0,
				15,
				104,
				0,
				0,
				15,
				103,
				0,
				0,
				15,
				102,
				0,
				0,
				15,
				84,
				0,
				36,
				15,
				83,
				0,
				50,
				15,
				82,
				0,
				byte.MaxValue,
				15,
				81,
				0,
				byte.MaxValue,
				15,
				80,
				0,
				0,
				15,
				79,
				0,
				0,
				15,
				78,
				0,
				0,
				15,
				77,
				0,
				0,
				15,
				76,
				0,
				0,
				15,
				75,
				0,
				0,
				15,
				74,
				0,
				0,
				15,
				73,
				0,
				0,
				15,
				72,
				0,
				0,
				15,
				71,
				0,
				0,
				15,
				70,
				0,
				0,
				15,
				69,
				0,
				0,
				15,
				68,
				0,
				0,
				15,
				67,
				0,
				0,
				15,
				66,
				0,
				0,
				15,
				65,
				0,
				0,
				15,
				64,
				0,
				0,
				15,
				63,
				0,
				3,
				15,
				62,
				0,
				0,
				15,
				61,
				0,
				0,
				15,
				60,
				0,
				0,
				15,
				59,
				0,
				8,
				15,
				58,
				0,
				0,
				15,
				57,
				0,
				0,
				15,
				56,
				0,
				0,
				15,
				55,
				1,
				244,
				15,
				54,
				2,
				158,
				15,
				53,
				0,
				0,
				15,
				52,
				0,
				0,
				15,
				51,
				0,
				0,
				15,
				50,
				0,
				1,
				15,
				49,
				0,
				1,
				15,
				48,
				0,
				5,
				15,
				47,
				0,
				5,
				15,
				46,
				0,
				2,
				15,
				45,
				0,
				5,
				15,
				44,
				0,
				9,
				15,
				43,
				0,
				0,
				15,
				42,
				0,
				4,
				15,
				41,
				0,
				5,
				15,
				40,
				0,
				2,
				15,
				39,
				0,
				6,
				15,
				38,
				0,
				1,
				15,
				37,
				0,
				byte.MaxValue,
				15,
				36,
				1,
				169,
				15,
				35,
				0,
				byte.MaxValue,
				15,
				34,
				0,
				0,
				15,
				33,
				0,
				byte.MaxValue,
				15,
				32,
				0,
				byte.MaxValue,
				15,
				31,
				0,
				0,
				15,
				30,
				0,
				byte.MaxValue,
				15,
				29,
				1,
				149,
				15,
				28,
				0,
				96,
				15,
				27,
				0,
				96,
				15,
				26,
				0,
				0,
				15,
				25,
				0,
				96,
				15,
				24,
				0,
				96,
				15,
				23,
				0,
				96,
				15,
				22,
				0,
				0,
				15,
				21,
				1,
				44,
				15,
				20,
				0,
				0,
				15,
				19,
				0,
				50,
				15,
				18,
				0,
				0,
				15,
				17,
				1,
				244,
				15,
				16,
				1,
				244,
				15,
				15,
				2,
				117,
				15,
				14,
				1,
				244,
				15,
				13,
				0,
				0,
				15,
				12,
				0,
				200,
				15,
				11,
				0,
				200,
				15,
				10,
				0,
				0,
				15,
				9,
				0,
				200,
				15,
				8,
				1,
				144,
				15,
				7,
				0,
				200,
				15,
				6,
				0,
				0,
				15,
				5,
				0,
				200,
				15,
				4,
				0,
				0,
				15,
				3,
				0,
				200,
				15,
				2,
				0,
				0,
				15,
				1,
				0,
				200,
				15,
				0,
				0,
				0,
				14,
				byte.MaxValue,
				0,
				200,
				14,
				254,
				2,
				88,
				14,
				253,
				0,
				200,
				14,
				252,
				0,
				0,
				14,
				251,
				0,
				200,
				14,
				250,
				0,
				0,
				14,
				249,
				0,
				200,
				14,
				248,
				0,
				0,
				14,
				247,
				1,
				44,
				14,
				246,
				1,
				144,
				14,
				245,
				1,
				44,
				14,
				244,
				1,
				214,
				14,
				243,
				1,
				44,
				14,
				242,
				1,
				133,
				14,
				241,
				0,
				byte.MaxValue,
				14,
				240,
				1,
				169,
				14,
				239,
				0,
				1,
				14,
				238,
				1,
				144,
				14,
				237,
				1,
				144,
				14,
				236,
				1,
				144,
				14,
				235,
				1,
				144,
				14,
				234,
				1,
				144,
				14,
				233,
				1,
				144,
				14,
				215,
				0,
				36,
				14,
				214,
				0,
				1,
				14,
				213,
				7,
				208,
				14,
				212,
				10,
				234,
				14,
				211,
				0,
				0,
				14,
				210,
				0,
				0,
				14,
				209,
				0,
				7,
				14,
				208,
				0,
				7,
				14,
				207,
				0,
				7,
				14,
				206,
				0,
				7,
				14,
				205,
				0,
				7,
				14,
				204,
				0,
				7,
				14,
				186,
				0,
				0,
				14,
				185,
				0,
				1,
				14,
				184,
				0,
				1,
				14,
				183,
				0,
				0,
				14,
				182,
				0,
				0,
				14,
				181,
				0,
				9,
				14,
				180,
				0,
				0,
				14,
				179,
				0,
				0,
				14,
				178,
				0,
				10,
				14,
				177,
				0,
				0,
				14,
				176,
				0,
				0,
				14,
				175,
				0,
				0,
				14,
				174,
				0,
				0,
				14,
				173,
				0,
				0,
				14,
				172,
				0,
				0,
				14,
				171,
				0,
				0,
				14,
				170,
				0,
				0,
				14,
				152,
				0,
				50,
				14,
				151,
				0,
				0,
				14,
				150,
				0,
				50,
				14,
				149,
				0,
				0,
				14,
				148,
				0,
				1,
				14,
				146,
				0,
				50,
				14,
				145,
				0,
				16,
				14,
				144,
				0,
				0,
				14,
				143,
				0,
				0,
				14,
				142,
				0,
				0,
				14,
				141,
				0,
				0,
				14,
				140,
				0,
				0,
				14,
				139,
				0,
				0,
				14,
				138,
				0,
				0,
				14,
				137,
				0,
				0,
				14,
				136,
				0,
				0,
				14,
				135,
				0,
				0,
				14,
				134,
				0,
				0,
				14,
				133,
				0,
				0,
				14,
				132,
				0,
				0,
				14,
				131,
				0,
				0,
				14,
				130,
				0,
				0,
				14,
				129,
				0,
				0,
				14,
				128,
				0,
				30,
				14,
				127,
				0,
				0,
				14,
				126,
				0,
				0,
				14,
				125,
				0,
				0,
				14,
				124,
				0,
				0,
				14,
				123,
				0,
				0,
				14,
				122,
				0,
				0,
				14,
				121,
				0,
				0,
				14,
				120,
				0,
				0,
				14,
				119,
				0,
				0,
				14,
				118,
				0,
				0,
				14,
				117,
				0,
				0,
				14,
				116,
				2,
				243,
				14,
				115,
				0,
				13,
				14,
				114,
				0,
				0,
				14,
				113,
				0,
				50,
				14,
				112,
				0,
				0,
				14,
				111,
				0,
				0,
				14,
				110,
				0,
				4,
				14,
				109,
				0,
				0,
				14,
				108,
				0,
				4,
				14,
				107,
				0,
				0,
				14,
				106,
				0,
				0,
				14,
				105,
				0,
				byte.MaxValue,
				14,
				104,
				0,
				0,
				14,
				103,
				0,
				byte.MaxValue,
				14,
				102,
				0,
				0,
				14,
				98,
				0,
				5,
				14,
				99,
				0,
				50,
				14,
				91,
				0,
				0,
				0,
				18,
				byte.MaxValue,
				byte.MaxValue,
				0,
				0,
				0,
				0,
				19,
				135,
				39,
				17,
				19,
				134,
				39,
				17,
				19,
				133,
				39,
				17,
				19,
				132,
				39,
				17,
				19,
				131,
				39,
				17,
				19,
				130,
				39,
				17,
				19,
				129,
				39,
				17,
				19,
				128,
				39,
				17,
				19,
				110,
				39,
				17,
				19,
				109,
				39,
				17,
				19,
				108,
				39,
				17,
				19,
				107,
				39,
				17,
				19,
				106,
				39,
				17,
				19,
				105,
				39,
				17,
				19,
				104,
				39,
				17,
				19,
				103,
				39,
				17,
				19,
				85,
				0,
				10,
				0,
				2,
				byte.MaxValue,
				byte.MaxValue,
				3,
				132,
				3,
				135,
				3,
				231,
				0,
				10
			};
		}

		// Token: 0x0400001A RID: 26
		private global::Motorola.Common.Communication.IMessageExecutor a;

		// Token: 0x0400001B RID: 27
		private char[] b = new char[]
		{
			'\0',
			' ',
			'\r',
			'\n'
		};

		// Token: 0x0400001C RID: 28
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo c;

		// Token: 0x0400001D RID: 29
		private global::Motorola.Common.Communication.Rcmp.XcmpComponentSession d;

		// Token: 0x0400001E RID: 30
		private global::Motorola.Common.Communication.CommonUtil.SessionParameter e;

		// Token: 0x0400001F RID: 31
		private global::Motorola.Common.Communication.RadioParams f;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;

		// Token: 0x04000021 RID: 33
		private global::Motorola.Common.Communication.IshHandler.CommonIshHandler h;

		// Token: 0x04000022 RID: 34
		private global::Motorola.Common.Communication.IshHandler.IOController i;

		// Token: 0x04000023 RID: 35
		private int j;

		// Token: 0x04000024 RID: 36
		private static readonly global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Guid, string>> k;

		// Token: 0x04000025 RID: 37
		private const int l = 1;

		// Token: 0x04000026 RID: 38
		private const int m = 2;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.IProgressIndicator n;

		// Token: 0x04000028 RID: 40
		private static readonly int o;

		// Token: 0x04000029 RID: 41
		private static readonly byte[] p;

		// Token: 0x0400002A RID: 42
		private static readonly byte[] q;

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000A5 RID: 165
		private delegate void a(double A_0);
	}
}
