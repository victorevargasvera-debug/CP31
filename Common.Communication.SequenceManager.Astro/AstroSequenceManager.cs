using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using authAES;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public abstract class AstroSequenceManager : global::Motorola.Common.Communication.ISequenceManager, global::Motorola.Common.Communication.IIshBlockSupport
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00007D14 File Offset: 0x00005F14
		protected global::Motorola.Common.Communication.IMessageExecutor RcmpWrapper
		{
			get
			{
				short num = (short)1070792705;
				if (num != 0)
				{
				}
				num = (short)505609812;
				short num2 = num;
				num = (short)716504660;
				switch (num2 == num)
				{
				}
				num = (short)1672740864;
				short num3 = num;
				num = (short)1465843712;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00007DC4 File Offset: 0x00005FC4
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00007E70 File Offset: 0x00006070
		protected global::Motorola.Common.Communication.IshHandler.IOController IOController
		{
			get
			{
				short num = (short)1117631007;
				short num2 = num;
				num = (short)639873567;
				switch (num2 == num)
				{
				}
				num = (short)1671692289;
				if (num != 0)
				{
				}
				num = (short)1397161984;
				if (num != 0)
				{
				}
				num = (short)417202176;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1835278333;
				short num2 = num;
				num = (short)1484464125;
				switch (num2 == num)
				{
				}
				num = (short)1517617152;
				if (num != 0)
				{
				}
				num = (short)515833857;
				if (num != 0)
				{
				}
				num = (short)1414463488;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00007F20 File Offset: 0x00006120
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00007FD4 File Offset: 0x000061D4
		protected global::Motorola.Common.Communication.IshHandler.CommonIshHandler IshHandler
		{
			get
			{
				short num = (short)1115815937;
				if (num != 0)
				{
				}
				num = (short)520087024;
				short num2 = num;
				num = (short)943121904;
				switch (num2 == num)
				{
				}
				num = (short)599392256;
				if (num != 0)
				{
				}
				num = (short)595197952;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)2098818168;
				short num2 = num;
				num = (short)735865976;
				switch (num2 == num)
				{
				}
				num = (short)1778843648;
				if (num != 0)
				{
				}
				num = (short)1227882497;
				if (num != 0)
				{
				}
				num = (short)408682496;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00008088 File Offset: 0x00006288
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00008138 File Offset: 0x00006338
		protected bool IsRadioManagementOperation
		{
			get
			{
				short num = (short)414068721;
				short num2 = num;
				num = (short)1837772785;
				switch (num2 == num)
				{
				}
				num = (short)1263468545;
				if (num != 0)
				{
				}
				num = (short)2003632128;
				if (num != 0)
				{
				}
				num = (short)411107328;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)1305870337;
				if (num != 0)
				{
				}
				num = (short)9628386;
				short num2 = num;
				num = (short)245295842;
				switch (num2 == num)
				{
				}
				num = (short)1283457024;
				if (num != 0)
				{
				}
				num = (short)771227648;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000081E8 File Offset: 0x000063E8
		public AstroSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam)
		{
			this.c = rcmpWrapper;
			this.g = new global::Motorola.Common.Communication.RadioParams();
			if (sessionParam != null)
			{
				this.m_SessionParameter = sessionParam;
			}
			else
			{
				this.m_SessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, null);
			}
			this.h = this.m_SessionParameter.ArchiveSession;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00008254 File Offset: 0x00006454
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00008304 File Offset: 0x00006504
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)687862929;
				short num2 = num;
				num = (short)306836625;
				switch (num2 == num)
				{
				}
				num = (short)610795520;
				if (num != 0)
				{
				}
				num = (short)180813825;
				if (num != 0)
				{
				}
				num = (short)1129709568;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)225229554;
				short num2 = num;
				num = (short)898415346;
				switch (num2 == num)
				{
				}
				num = (short)158793729;
				if (num != 0)
				{
				}
				num = (short)1299382272;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000083B8 File Offset: 0x000065B8
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000084DC File Offset: 0x000066DC
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			get
			{
				short num = (short)1190264834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2135767559;
						short num3 = num;
						num = (short)1800419847;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
						{
							num = (short)1440612352;
							if (num != 0)
							{
							}
							num = (short)602800128;
							short num4 = num;
							num = (short)1566769153;
							if (num != 0)
							{
							}
							this.ReadExtendedDeviceInfo();
							num = (short)1538719745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_10E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					goto IL_32;
					IL_3D:
					num = (short)1762918400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32:
					if (this.a == null)
					{
						goto IL_3D;
					}
					break;
				}
				IL_10E:
				return this.a;
			}
			set
			{
				short num = (short)656829743;
				short num2 = num;
				num = (short)1400859951;
				switch (num2 == num)
				{
				}
				num = (short)897974273;
				if (num != 0)
				{
				}
				num = (short)2119237632;
				if (num != 0)
				{
				}
				num = (short)731512832;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000858C File Offset: 0x0000678C
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
					goto IL_1C1;
				case 1:
				{
					global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity;
					if (rcmpUnlockSecurity.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1297547269;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)805765126;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					byte[] array = global::Motorola.Common.Communication.af.a(rcmpReadRadioKey.RadioKey);
					if (array.Length > this.m_MaxTransportPacketSize)
					{
						goto Block_3;
					}
					global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity = new global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity(array);
					this.RcmpWrapper.SendAndReceiveMessage(rcmpUnlockSecurity);
					num2 = (short)1723858945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1706229767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition;
					if (rcmpIshUnlockPartition.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						goto IL_26D;
					}
					num2 = (short)511442945;
					if (num2 != 0)
					{
					}
					num2 = (short)1369590030;
					short num3 = num2;
					num2 = (short)1894402318;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					default:
						num2 = (short)1454374912;
						if (num2 != 0)
						{
						}
						num2 = (short)899612672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_25D;
				case 6:
					if (partition > 0)
					{
						num2 = (short)82771971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26D;
				case 7:
					if (partition < 255)
					{
						num2 = (short)1861025802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26D;
				case 8:
					if (rcmpReadRadioKey.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1748500489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)167182338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_7E;
				case 10:
				{
					global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition = new global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition(partition);
					this.RcmpWrapper.SendAndReceiveMessage(rcmpIshUnlockPartition);
					num2 = (short)944766980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_3C;
			}
			IL_7E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			IL_BF:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			Block_3:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_TooLongRadioKey);
			IL_1C1:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			IL_25D:
			goto IL_BF;
			IL_26D:
			num2 = (short)1530658816;
			short num4 = num2;
			return;
			IL_3C:
			rcmpReadRadioKey = new global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey();
			this.RcmpWrapper.SendAndReceiveMessage(rcmpReadRadioKey);
			num2 = (short)1755906056;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00008830 File Offset: 0x00006A30
		protected virtual void EnterReadProgramMode()
		{
			short num = (short)495740720;
			short num2 = num;
			num = (short)1965516592;
			switch (num2 == num)
			{
			}
			num = (short)1770258432;
			if (num != 0)
			{
			}
			num = (short)668925953;
			if (num != 0)
			{
			}
			num = (short)958070784;
			short num3 = num;
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000088E4 File Offset: 0x00006AE4
		protected virtual void ExitReadProgramMode()
		{
			short num = (short)946786155;
			short num2 = num;
			num = (short)1101188971;
			switch (num2 == num)
			{
			}
			num = (short)758448129;
			if (num != 0)
			{
			}
			num = (short)1796014080;
			if (num != 0)
			{
			}
			num = (short)2139029504;
			short num3 = num;
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000899C File Offset: 0x00006B9C
		protected virtual void EnterWriteProgramMode()
		{
			short num = (short)720306177;
			if (num != 0)
			{
			}
			num = (short)937485826;
			short num2 = num;
			num = (short)557770242;
			switch (num2 == num)
			{
			}
			num = (short)1738407936;
			if (num != 0)
			{
			}
			num = (short)1487208448;
			short num3 = num;
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00008A50 File Offset: 0x00006C50
		protected virtual void ExitWriteProgramMode()
		{
			short num = (short)1890975819;
			short num2 = num;
			num = (short)1013317707;
			switch (num2 == num)
			{
			}
			num = (short)862322689;
			if (num != 0)
			{
			}
			num = (short)1450115072;
			if (num != 0)
			{
			}
			num = (short)1270022144;
			short num3 = num;
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00008B04 File Offset: 0x00006D04
		protected void EnterProgramMode()
		{
			short num = (short)1276742628;
			short num2 = num;
			num = (short)1628408804;
			switch (num2 == num)
			{
			}
			num = (short)1140719616;
			if (num != 0)
			{
			}
			num = (short)133234689;
			if (num != 0)
			{
			}
			num = (short)2118123520;
			short num3 = num;
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00008BBC File Offset: 0x00006DBC
		protected void ExitProgramMode()
		{
			short num = (short)655294465;
			if (num != 0)
			{
			}
			num = (short)771816922;
			short num2 = num;
			num = (short)595459546;
			switch (num2 == num)
			{
			}
			num = (short)1785331712;
			if (num != 0)
			{
			}
			num = (short)1496252416;
			short num3 = num;
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00008C74 File Offset: 0x00006E74
		public virtual void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)143261697;
			if (num != 0)
			{
			}
			num = (short)1960968198;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.EnterWriteProgramMode();
					num = (short)655032321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1796265602;
					short num3 = num;
					num = (short)173725314;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						goto IL_15E;
					}
					break;
				}
				case 2:
					if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)
					{
						goto IL_EE;
					}
					return;
				case 3:
					goto IL_1E0;
				case 4:
					this.UnlockRadioPartition(212);
					num = (short)1898053637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
					{
						num = (short)1930690563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1579417608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 7:
					num = (short)1230307330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)1534918656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_71:
				if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
				{
					num = (short)428802055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_EE:
				num = (short)139591684;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_15E:
			num = (short)1766916096;
			short num4 = num;
			num = (short)1381629952;
			if (num != 0)
			{
			}
			return;
			IL_1E0:
			this.EnterReadProgramMode();
		}

		// Token: 0x06000038 RID: 56
		public abstract void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy);

		// Token: 0x06000039 RID: 57 RVA: 0x00008E68 File Offset: 0x00007068
		private static global::System.Collections.Generic.Dictionary<global::System.Guid, string> e()
		{
			int a_ = 4;
			short num = (short)396492801;
			if (num != 0)
			{
			}
			num = (short)893109159;
			short num2 = num;
			num = (short)2116535207;
			switch (num2 == num)
			{
			}
			num = (short)1643249664;
			if (num != 0)
			{
			}
			num = (short)1491730432;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<global::System.Guid, string> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
			string a_2 = global::Motorola.Common.Communication.Crc32.c("튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺鎼ﲾ껀껂꣄닆ꟈꋊ껌껎ꗐ뫒뫔맖飚규곞닠蛢铤鋦賨藪軬諮볰鋲鯴零黸黺迼믾怀眂搄⤆焈昊愌", a_);
			string a_3 = global::Motorola.Common.Communication.Crc32.c("튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺鎼ﲾ껀껂꣄닆ꟈꋊ껌껎ꗐ뫒뫔맖飚규곞럠蛢韤鏦賨鏪뻬諮胰蛲郴駶髸黺냼黾漀戂戄戆笈伊氌笎瀐㴒洔稖甘", a_);
			global::Motorola.Common.Communication.AstroSequenceManager.a(dictionary, a_2);
			global::Motorola.Common.Communication.AstroSequenceManager.a(dictionary, a_3);
			return dictionary;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00008F48 File Offset: 0x00007148
		private static void a(global::System.Collections.Generic.Dictionary<global::System.Guid, string> A_0, string A_1)
		{
			int a_ = 18;
			short num = (short)942538752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)913440769;
				if (num != 0)
				{
				}
				global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(A_1);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					global::System.Xml.XmlNodeList xmlNodeList;
					for (;;)
					{
						IL_65:
						switch (num2)
						{
						case 0:
							goto IL_388;
						case 1:
							try
							{
								num = (short)1315110921;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										if (!A_0.ContainsKey(new global::System.Guid(xmlAttribute.Value)))
										{
											num = (short)1599602695;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										if (xmlAttribute != null)
										{
											num = (short)224788483;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										string value = xmlAttribute2.Value;
										num = (short)1784086534;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										string value = string.Empty;
										num = (short)906756100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::System.Xml.XmlAttribute xmlAttribute2;
										if (xmlAttribute2 != null)
										{
											num = (short)1446969346;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_24D;
									}
									case 5:
										goto IL_2F5;
									case 6:
										goto IL_24D;
									case 7:
									{
										global::System.Xml.XmlAttribute xmlAttribute;
										string value;
										A_0.Add(new global::System.Guid(xmlAttribute.Value), value);
										num = (short)970719242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)825950219;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::Motorola.Common.Communication.Crc32.c("ﮬ캮\uddb0욲킴", a_)];
										global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes[global::Motorola.Common.Communication.Crc32.c("쪮슰킲잴\udeb6즸쾺풼킾꿀", a_)];
										num = (short)695205889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										switch (0)
										{
										case 0:
											goto IL_149;
										}
										continue;
									case 11:
										num = (short)1436745733;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_175:
									num = (short)1954545672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_149:
									goto IL_175;
									IL_24D:
									num = (short)23003136;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2F5:
								goto IL_44A;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_317;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_304:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)1259864065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_36C;
									case 2:
										if (disposable != null)
										{
											num = (short)373555200;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_36E;
									}
									goto IL_317;
								}
								IL_36C:
								IL_36E:
								goto EndFinally_11;
								IL_317:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)796983298;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_304;
								EndFinally_11:;
							}
							goto IL_36F;
						case 2:
							if (xmlNodeList != null)
							{
								num = (short)1200816131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_36F;
						case 3:
						{
							global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
							num = (short)549519361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_7C;
						IL_36F:
						num = (short)180879360;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_388:
					goto IL_44A;
					IL_7C:
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(manifestResourceStream);
					xmlNodeList = xmlDocument.SelectNodes(global::Motorola.Common.Communication.Crc32.c("\udfae슰킴욶첸\udeba펼\udcbe꓀軂꓄꧆꣈곊꣌뷎闐닒ꇔ뛖裚꣜꿞釠賢韤鏦賨迪룬髮飰韲맴黶諸迺틼꫾琀樂愄", a_));
					num = (short)1650851842;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_65;
				}
				finally
				{
					num = (short)130088962;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)567739384;
							short num3 = num;
							num = (short)64947192;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3C5;
							default:
								num = (short)1644036096;
								if (num != 0)
								{
								}
								((global::System.IDisposable)manifestResourceStream).Dispose();
								num = (short)30670849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_447;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3BF;
							}
							continue;
						}
						goto IL_3BF;
						IL_3C5:
						num = (short)1948975104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3BF:
						if (manifestResourceStream != null)
						{
							goto IL_3C5;
						}
						break;
					}
					IL_447:;
				}
				IL_44A:
				num = (short)302055424;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000093FC File Offset: 0x000075FC
		private global::Motorola.Common.Communication.RadioParams d()
		{
			short num = (short)2029125632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BE;
				}
				global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber;
				global::Motorola.Common.Communication.RadioParams radioParams;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2;
				global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation rcmpBigEndianHexVersionInformation;
				global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation4;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation5;
				global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber;
				global::Motorola.Common.Communication.Rcmp.RcmpHexVersionInformation rcmpHexVersionInformation;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1906835457;
							if (num != 0)
							{
							}
							num = (short)1328873475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77E;
					case 1:
						goto IL_45F;
					case 2:
						if (rcmpReadWriteModelNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)471007248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52A;
					case 3:
						radioParams.DefaultGatewayNetworkAttachmentValue = rcmpRadioStatus.Status[0].ToString();
						num = (short)641269792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)443940879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_5AE;
					case 6:
						num = (short)486866946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1704263706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_727;
					case 8:
						num = (short)872546317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						radioParams.CodeplugVersion = rcmpVersionInformation2.VersionInformation.TrimEnd(this.b);
						num = (short)1266941982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1649016860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1100708862;
						short num3 = num;
						num = (short)1257995262;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_584;
						default:
							num = (short)1788346368;
							if (num != 0)
							{
							}
							radioParams.IsTlsPskCompatible = true;
							radioParams.TlsPskPortNumber = rcmpBigEndianHexVersionInformation.VersionInformation.ToString();
							num = (short)2050949121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						radioParams.DownloadPercent = (ushort)xcmpRadioUpdateControl.Value;
						num = (short)1385562146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)706347022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 14:
						radioParams.HostVersion = rcmpVersionInformation3.VersionInformation.TrimEnd(this.b);
						num = (short)1673723939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (rcmpVersionInformation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1110048777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_622;
					case 16:
						radioParams.ModelNumber = rcmpReadWriteModelNumber.ModelNumber;
						num = (short)1175650314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (rcmpVersionInformation4.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)501940245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 18:
						if (rcmpVersionInformation5.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1298595859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BF;
					case 19:
						radioParams.PendingBbfBundleVersion = rcmpVersionInformation5.VersionInformation.TrimEnd(this.b);
						num = (short)1885798431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						radioParams.Uuid = new global::System.Guid(rcmpReadUUID.UUID);
						num = (short)1260847108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						radioParams.BBFBundleVersion = rcmpVersionInformation4.VersionInformation.TrimEnd(this.b);
						num = (short)1570832406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_56B;
					case 23:
						radioParams.SerialNumber = rcmpReadWriteSerialNumber.SerialNumber;
						num = (short)1663107078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (rcmpHexVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)623247385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AE;
					case 25:
						radioParams.CodeplugSessionID = rcmpHexVersionInformation.VersionInformation;
						num = (short)1303117829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						radioParams.PsdtVersion = rcmpVersionInformation.VersionInformation.TrimEnd(this.b);
						num = (short)2036793352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (rcmpBigEndianHexVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1067974667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioParams;
					case 28:
						if (rcmpReadUUID.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)44564500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B;
					case 29:
						goto IL_584;
					case 30:
						num = (short)707723271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_2BF;
					case 32:
						goto IL_77E;
					case 33:
						if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1746403351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_773;
					case 34:
						goto IL_376;
					case 35:
						num = (short)500760594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
					IL_2BF:
					num = (short)1835728920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_376:
					num = (short)420216832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_584:
					if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1061879820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_376;
					IL_56B:
					num = (short)379191325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AE:
					num = (short)1335820305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77E:
					num = (short)766705691;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_36B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_45F:
				num = (short)264503296;
				short num4 = num;
				return radioParams;
				IL_52A:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_622:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_727:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_773:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_BE:
				radioParams = null;
				global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
				rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteModelNumber);
				rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber);
				rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.DefaultGatewayNetworkAttachment);
				xcmpSuperBundle.AddRcmpMessage(rcmpRadioStatus);
				rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
				xcmpSuperBundle.AddRcmpMessage(rcmpReadUUID);
				rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation2);
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation);
				rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation3);
				rcmpVersionInformation5 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PendingBBFBundleVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation5);
				rcmpHexVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugSessionID);
				xcmpSuperBundle.AddRcmpMessage(rcmpHexVersionInformation);
				rcmpVersionInformation4 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.BBFBundleVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation4);
				xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction.GetDownloadProgress);
				xcmpSuperBundle.AddRcmpMessage(xcmpRadioUpdateControl);
				rcmpBigEndianHexVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.TlsPskPortNumber);
				xcmpSuperBundle.AddRcmpMessage(rcmpBigEndianHexVersionInformation);
				xcmpSuperBundle.ReadTimeout = 15000;
				this.RcmpWrapper.SendAndReceiveMessage(xcmpSuperBundle);
				radioParams = new global::Motorola.Common.Communication.RadioParams();
				num = (short)335020065;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00009C00 File Offset: 0x00007E00
		private bool c()
		{
			short num;
			for (;;)
			{
				num = (short)196214784;
				short num2 = num;
				num = (short)572784640;
				switch (num)
				{
				default:
				{
					num = (short)1802305257;
					short num3 = num;
					num = (short)676003561;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7F;
					}
					break;
				}
				}
			}
			IL_7F:
			num = (short)455802880;
			if (num != 0)
			{
			}
			byte[] array = this.IOController.QueryRadioUUID();
			global::System.Guid guid = new global::System.Guid(array);
			bool result;
			using (global::System.Collections.Generic.Dictionary<global::System.Guid, string>.KeyCollection.Enumerator enumerator = global::Motorola.Common.Communication.AstroSequenceManager.f.Value.Keys.GetEnumerator())
			{
				num = (short)1532887044;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_1D8;
					case 1:
						if (enumerator.Current == guid)
						{
							num = (short)1165033478;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)479330307;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2115239937;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)601620480;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_12C;
						}
						continue;
					case 5:
						goto IL_1BE;
					case 6:
						result = true;
						num = (short)1708130309;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_12E:
					num = (short)1566048258;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_12C:
					goto IL_12E;
				}
				IL_1BE:
				return result;
				IL_1D8:
				goto IL_C0;
			}
			return result;
			IL_C0:
			num = (short)1534328833;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00009E0C File Offset: 0x0000800C
		private static void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.RadioParams A_1)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1894645775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_367;
				case 2:
					goto IL_2C5;
				case 3:
					goto IL_367;
				case 4:
				{
					global::System.Version version;
					A_0.RadioStorage = ((version.CompareTo(new global::System.Version(global::Motorola.Common.Communication.Crc32.c("醠関认邦馨薪鶬龮", a_))) >= 0) ? global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem : global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw);
					num2 = (short)1297088522;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)819724306;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					global::System.Version version = new global::System.Version(A_1.PsdtVersion.Remove(0, 1));
					num2 = (short)1722810372;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_367;
				case 8:
				{
					global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue;
					switch (networkAttachmentValue)
					{
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.NoDefaultGateway:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.OneG:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.TwoG:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.ThreeG:
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.WiFi:
						goto IL_41A;
					case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.FourG:
						A_0.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE;
						num2 = (short)922353671;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)647757829;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					if (A_1.PsdtVersion.Length > 0)
					{
						num2 = (short)838860806;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_47C;
				case 10:
					goto IL_47A;
				case 11:
					goto IL_367;
				case 12:
					if (A_0.ConnectionInfo == null)
					{
						num2 = (short)1472331789;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C5;
				case 13:
					A_0.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
					num2 = (short)1754071042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
				{
					A_0.ConnectionInfo.Location = A_1.TlsPskPortNumber;
					A_0.ConnectionInfo.IsTlsPskCompatible = true;
					num2 = (short)164888576;
					short num3 = num2;
					num2 = (short)1600978960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
					goto IL_41A;
				case 16:
					goto IL_1B8;
				case 17:
					if (!string.IsNullOrEmpty(A_1.DefaultGatewayNetworkAttachmentValue))
					{
						num2 = (short)195756052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_296;
				case 18:
				{
					global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue;
					if (networkAttachmentValue != global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.LMR)
					{
						num2 = (short)612958208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_0.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR;
					num2 = (short)666697739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 19:
				{
					if (!A_1.IsTlsPskCompatible)
					{
						goto IL_1B8;
					}
					num2 = (short)96147149;
					short num4 = num2;
					num2 = (short)501749453;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_296;
					default:
						num2 = (short)1089667072;
						if (num2 != 0)
						{
						}
						num2 = (short)2015756289;
						if (num2 != 0)
						{
						}
						num2 = (short)2066284558;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 20:
				{
					global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue = (global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue)global::System.Convert.ToByte(A_1.DefaultGatewayNetworkAttachmentValue);
					num2 = (short)1955856392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_6D;
				IL_1B8:
				A_0.RadioBBFSuiteVersion = A_1.BBFBundleVersion;
				num2 = (short)214827017;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_296:
				A_0.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
				num2 = (short)766771203;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C5:
				num2 = (short)283377681;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_367:
				num2 = (short)1468071955;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_41A:
				A_0.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
				num2 = (short)1374683137;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_47A:
			A_0.PendingBBFSuiteVersion = A_1.PendingBbfBundleVersion;
			A_0.CodeplugSessionID = A_1.CodeplugSessionID;
			A_0.DownloadPercent = A_1.DownloadPercent;
			return;
			IL_47C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidPSDT);
			IL_6D:
			A_0.CodeplugVersion = A_1.CodeplugVersion;
			A_0.ModelNumber = A_1.ModelNumber;
			A_0.SerialNumber = A_1.SerialNumber;
			A_0.SoftwareVersion = A_1.HostVersion;
			num2 = (short)29294604;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000A2C4 File Offset: 0x000084C4
		private static void a(global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo A_0, global::Motorola.Common.Communication.RadioParams A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (A_1.ESerialNumber.Length == 0)
					{
						return;
					}
					num2 = (short)1477256865;
					short num3 = num2;
					num2 = (short)1174152865;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15E;
					default:
					{
						num2 = (short)1848049664;
						short num4 = num2;
						num2 = (short)1268252672;
						if (num2 != 0)
						{
						}
						num2 = (short)91750402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_15E;
				case 2:
					A_0.ESN = new byte[A_1.ESerialNumber.Length];
					A_1.ESerialNumber.CopyTo(A_0.ESN, 0);
					num2 = (short)104398851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				case 4:
					num2 = (short)636944385;
					if (num2 != 0)
					{
					}
					if (A_1.ESerialNumber != null)
					{
						num2 = (short)1318256641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
				IL_15E:
				num2 = (short)1154678784;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			A_0.UUID = A_1.Uuid.ToString();
			A_0.RadioBBFSuiteVersion = A_1.BBFBundleVersion;
			A_0.TuneVersion = A_1.TuneVersion;
			A_0.PsdtVersion = A_1.PsdtVersion;
			A_0.MaceFlashVersion = A_1.MaceFlashVersion;
			A_0.DspVersion = A_1.DspVersion;
			A_0.BootloaderVersion = A_1.BootAppVersion;
			A_0.OptionBoardFlashImageType = A_1.OptBrdFlashImageType;
			A_0.OptionBoardFlashImageVersion = A_1.OptBrdFlashImageVersion;
			A_0.OptionBoardHardwareHostVersion = A_1.OptBrdHwHostVersion;
			A_0.OptionBoardHardwareNotPresentFlag = A_1.OptBrdHwNotPresentFlag;
			A_0.OptionBoardHardwareType = A_1.OptBrdHardwareType;
			A_0.OptionBoardName = A_1.OptBoardName;
			A_0.ConsoletteBoardHardwareType = A_1.ConBrdHardwareType;
			A_0.ConsoletteBoardHardwareHostVersion = A_1.ConBrdHwHostVersion;
			A_0.MaceSecureHardwareType = A_1.MaceHardwareType;
			A_0.MaceSecureHardwareVersion = A_1.MaceHardwareVersion;
			num2 = (short)1282211844;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000A528 File Offset: 0x00008728
		private global::Motorola.Common.Communication.RadioParams b()
		{
			short num = (short)1493172732;
			short num2 = num;
			num = (short)485884412;
			switch (num2 == num)
			{
			}
			num = (short)189399041;
			if (num != 0)
			{
			}
			num = (short)731119616;
			short num3 = num;
			num = (short)980156416;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.RadioParams result = this.d();
			if (!this.c())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000A5EC File Offset: 0x000087EC
		internal global::Motorola.Common.Communication.RadioParams f()
		{
			global::Motorola.Common.Communication.RadioParams radioParams = this.a();
			if (!this.a(radioParams.Uuid))
			{
				short num = (short)911855895;
				short num2 = num;
				num = (short)1974915351;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return radioParams;
				case 1:
					break;
				default:
				{
					num = (short)1365835776;
					short num3 = num;
					break;
				}
				}
				num = (short)2133786625;
				if (num != 0)
				{
				}
				num = (short)1898643456;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			}
			return radioParams;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000A6BC File Offset: 0x000088BC
		private bool a(global::System.Guid A_0)
		{
			short num = (short)1622802433;
			if (num != 0)
			{
			}
			num = (short)254541824;
			short num2 = num;
			bool result;
			using (global::System.Collections.Generic.Dictionary<global::System.Guid, string>.KeyCollection.Enumerator enumerator = global::Motorola.Common.Communication.AstroSequenceManager.f.Value.Keys.GetEnumerator())
			{
				num = (short)819593222;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1690828801;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1A8;
					case 2:
						goto IL_18E;
					case 3:
						if (enumerator.Current == A_0)
						{
							num = (short)182517765;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						if (enumerator.MoveNext())
						{
							num = (short)328118441;
							short num4 = num;
							num = (short)1816113321;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1440153600;
								if (num != 0)
								{
								}
								num = (short)1118633987;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						num = (short)549453824;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						result = true;
						num = (short)1638531074;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					}
					IL_AC:
					num = (short)2010382340;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA:
					goto IL_AC;
				}
				IL_18E:
				return result;
				IL_1A8:
				return false;
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		private global::Motorola.Common.Communication.RadioParams a()
		{
			short num = (short)72286208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				global::Motorola.Common.Communication.RadioParams radioParams;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2;
				char[] trimChars;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber;
				global::Motorola.Common.Communication.Rcmp.RcmpBigEndianHexVersionInformation rcmpBigEndianHexVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation4;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation5;
				global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation6;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation7;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation8;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation9;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation10;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1034747909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F7;
					case 1:
						radioParams.ConBrdHardwareType = rcmpVersionInformation2.VersionInformation.TrimEnd(trimChars);
						num = (short)1534787603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3A3;
					case 3:
					{
						num = (short)2104819712;
						short num3 = num;
						goto IL_951;
					}
					case 4:
						goto IL_89B;
					case 5:
						radioParams.OptBoardName = rcmpVersionInformation.VersionInformation.TrimEnd(trimChars);
						goto IL_5F3;
					case 6:
						if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)188874780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_417;
					case 7:
						if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)2131820568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					case 8:
						goto IL_45C;
					case 9:
						goto IL_8DD;
					case 10:
						if (rcmpVersionInformation2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1860894721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59C;
					case 11:
						if (rcmpBigEndianHexVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1592328218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioParams;
					case 12:
						return radioParams;
					case 13:
						radioParams.OptBrdHwNotPresentFlag = true;
						num = (short)1988362265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						radioParams.MaceHardwareVersion = rcmpVersionInformation4.VersionInformation.TrimEnd(trimChars);
						num = (short)2097938440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						if (rcmpVersionInformation4.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							goto IL_45C;
						}
						num = (short)1423046965;
						short num4 = num;
						num = (short)1658779957;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5F3;
						default:
							num = (short)40763392;
							if (num != 0)
							{
							}
							num = (short)1446313998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						goto IL_812;
					case 17:
						radioParams.OptBrdHwHostVersion = rcmpVersionInformation5.VersionInformation.TrimEnd(trimChars);
						num = (short)1204682775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (string.IsNullOrEmpty(radioParams.OptBrdHardwareType))
						{
							num = (short)1691222029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_417;
					case 19:
						goto IL_59C;
					case 20:
						if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)69664802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_559;
					case 21:
						if (rcmpVersionInformation6.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1765933089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_812;
					case 22:
						if (rcmpVersionInformation5.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)961085457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					case 23:
						goto IL_683;
					case 24:
						radioParams.ESerialNumber = rcmpReadWriteSerialNumber.SerialRawBytes;
						num = (short)1439956994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_417;
					case 26:
						radioParams.IsTlsPskCompatible = true;
						radioParams.TlsPskPortNumber = rcmpBigEndianHexVersionInformation.VersionInformation.ToString();
						num = (short)258998284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						radioParams.BBFBundleVersion = rcmpVersionInformation7.VersionInformation.TrimEnd(trimChars);
						num = (short)7995401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						radioParams.OptBrdHardwareType = rcmpVersionInformation3.VersionInformation.TrimEnd(trimChars);
						num = (short)394657810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_559;
					case 30:
						if (rcmpVersionInformation7.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)2012086299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8DD;
					case 31:
						radioParams.MaceHardwareType = rcmpVersionInformation8.VersionInformation.TrimEnd(trimChars);
						num = (short)1081344003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (rcmpVersionInformation8.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)741670943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_951;
					case 33:
						radioParams.OptBrdFlashImageType = rcmpVersionInformation6.VersionInformation.TrimEnd(trimChars);
						radioParams.OptBrdHwHostVersion = rcmpVersionInformation9.VersionInformation.TrimEnd(trimChars);
						num = (short)383451152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						radioParams.DefaultGatewayNetworkAttachmentValue = rcmpRadioStatus.Status[0].ToString();
						num = (short)892665885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_6F7;
					case 36:
						if (rcmpVersionInformation10.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1966014501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 37:
						radioParams.ConBrdHwHostVersion = rcmpVersionInformation10.VersionInformation.TrimEnd(trimChars);
						num = (short)815005700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7;
					IL_3A3:
					num = (short)2103509024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_417:
					num = (short)94830592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45C:
					num = (short)2031222804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_559:
					num = (short)251396107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59C:
					num = (short)1001324580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F3:
					num = (short)2032664611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_683:
					num = (short)2092302357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F7:
					num = (short)1701969921;
					if (num != 0)
					{
					}
					num = (short)1648689174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_812:
					num = (short)788594698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89B:
					num = (short)633208839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DD:
					num = (short)1003749382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_951:
					num = (short)1237975055;
					num2 = (int)((global::System.IntPtr)num);
				}
				return radioParams;
				IL_C7:
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
				rcmpVersionInformation7 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.BBFBundleVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation7);
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
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardName);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation);
				rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardHardwareType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation3);
				rcmpVersionInformation5 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardMainAppVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation5);
				rcmpVersionInformation9 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardFlashImageVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation9);
				rcmpVersionInformation6 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardFlashImageType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation6);
				rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConsoletteBrdHwType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation2);
				rcmpVersionInformation10 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConsoletteBrdHostVer);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation10);
				rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadESN, null);
				xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber);
				rcmpVersionInformation8 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceHardwareType);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation8);
				rcmpVersionInformation4 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceHardwareVersion);
				xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation4);
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
				num = (short)1126629406;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000B290 File Offset: 0x00009490
		protected void UpdateWiFiPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)701772210;
				short num2 = num;
				num = (short)375992754;
				switch (num2 == num)
				{
				}
				num = (short)1476526080;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.v.b(pbaToWrite, global::authAES.AESCryptography.CIPHER_DEF_KEY, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("풣슥즧\udea9즫玲\ud9af\uddb3\ud9b7즹쾻즽꾿냁ꃃ蓅귇곉ꏋ볍뗏藑ꛓ뿕곗뿙ﳛ룝臟诡裣菥賧쫩鯫蟭蓯髱컳훵菷쫹臻", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_WiFi_Password_Fail);
			}
			num = (short)167772161;
			if (num != 0)
			{
			}
			num = (short)2006122496;
			short num3 = num;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000B3A4 File Offset: 0x000095A4
		protected void UpdateWiFiPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)1585727388;
				short num2 = num;
				num = (short)576538524;
				switch (num2 == num)
				{
				}
				num = (short)1375600641;
				if (num != 0)
				{
				}
				num = (short)597622784;
				if (num != 0)
				{
				}
				bool a_2 = global::Motorola.Common.Communication.v.e(pbaForRead);
				global::Motorola.Common.Communication.v.b(pbaForRead, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, global::authAES.AESCryptography.CIPHER_DEF_KEY, a_2);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("\ud8a7캩춫\udaad햯\uddb3톷\uddbb춽뎿뗁ꯃ듅곇诉꫋뫍뗏ꃑ蛓돕맗뻙ﳛ룝臟诡裣菥賧쫩鯫蟭蓯髱컳훵菷쫹臻", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_WiFi_Password_Fail);
			}
			num = (short)1706491904;
			short num3 = num;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000B4BC File Offset: 0x000096BC
		protected void UpdateOobeBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)1921877697;
				short num2 = num;
				num = (short)141854401;
				switch (num2 == num)
				{
				}
				num = (short)431882240;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.v.d(pba);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("ﺪ\uddac쮮킰잲킴첸쾺\ud9be菀곂뷄苆뇈믊꣌뷎룐뛒믔듖볘鷚뇜뻞蛠럢諤ꇦ裨蟪黬諮퇰闲铴黶闸黺駼\udffe瘀樂焄漆㌈⬊瘌㼎氐", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Update_Oobe_Field_Fail);
			}
			num = (short)1002831873;
			if (num != 0)
			{
			}
			num = (short)419037184;
			short num3 = num;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000B5BC File Offset: 0x000097BC
		protected void UpdateExternalDataModemPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)1722214917;
				short num2 = num;
				num = (short)2084891141;
				switch (num2 == num)
				{
				}
				num = (short)656998400;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.v.a(pbaToWrite, global::authAES.AESCryptography.CIPHER_DEF_KEY, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("ﶧ\udaa9좫쾭쒯ힱ캵첷\udfb9캻킽ꆿ껁胃Ʂ볇ꯉ臋ꇍ듏럑맓蛕맗꧙꿛꧝迟郡胣ꓥ跧賩菫鳭闯ꗱ蛳鿵賷鿹\udcfb飽懿欁栃挅氇⨉笋服搏稑⸓㘕挗⨙愛", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_External_Data_Modem_Password_Fail);
			}
			num = (short)981925889;
			if (num != 0)
			{
			}
			num = (short)300875776;
			short num3 = num;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000B6CC File Offset: 0x000098CC
		protected void UpdateExternalDataModemPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)690996102;
				short num2 = num;
				num = (short)497140614;
				switch (num2 == num)
				{
				}
				num = (short)1462894592;
				if (num != 0)
				{
				}
				bool a_2 = global::Motorola.Common.Communication.v.e(pbaForRead);
				global::Motorola.Common.Communication.v.a(pbaForRead, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, global::authAES.AESCryptography.CIPHER_DEF_KEY, a_2);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("ﶧ\udaa9좫쾭쒯ힱ캵첷\udfb9캻킽ꆿ껁胃Ʂ볇ꯉ臋ꇍ듏럑맓蛕맗꧙꿛꧝迟郡胣꟥軧黩觫鳭ꋯ韱闳鋵\ud8f7鳹鷻韽泿朁怃★缇按砋昍⨏㈑漓☕攗", a_), new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_External_Data_Modem_Password_Fail);
			}
			num = (short)899547137;
			if (num != 0)
			{
			}
			num = (short)116523008;
			short num3 = num;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000B7E4 File Offset: 0x000099E4
		protected void UpdateMacAddressBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 14;
			short num;
			try
			{
				num = (short)514260992;
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
					byte[] array;
					int num4;
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							if (array != null)
							{
								num = (short)1099956233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_235;
						case 1:
							goto IL_235;
						case 2:
							goto IL_1E7;
						case 3:
							goto IL_131;
						case 4:
							if (array != null)
							{
								num = (short)1905786886;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E7;
						case 5:
							if (array != null)
							{
								num = (short)1813381127;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_131;
						case 6:
						{
							num = (short)726947274;
							short num3 = num;
							num = (short)1230394826;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1491730432;
								if (num != 0)
								{
								}
								global::Motorola.Common.Communication.v.a(pbaToWrite, array, num4);
								break;
							}
							num = (short)1502740482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							global::Motorola.Common.Communication.v.a(pbaToWrite, array, num4);
							num = (short)1775108099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_24F;
						case 9:
							global::Motorola.Common.Communication.v.a(pbaToWrite, array, num4);
							num = (short)881786881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F;
						IL_131:
						num4 = 206;
						array = this.a(pbaObject, num4, 6);
						num = (short)1289289728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E7:
						num4 = 200;
						array = this.a(pbaObject, num4, 6);
						num = (short)542113797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_235:
						num = (short)23396360;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_24F:
					break;
					IL_5F:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
					list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(208, 900, 0));
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.SetCodeplug(codeplug);
					num4 = 163;
					array = this.a(pbaObject, num4, 6);
					num = (short)186384388;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("ﲨ\udbaa즬캮얰횲횶\udab8諸\ud9bc\udbbe돀ꛂ뛄듆诈껊ꯌꃎꏐ뛒苔ꗖ냘꿚룜￞蟠苢賤详賨迪췬飮飰蟲鷴췶\ud9f8胺췼苾", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			num = (short)717029377;
			if (num != 0)
			{
			}
			num = (short)2108293120;
			short num5 = num;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000BADC File Offset: 0x00009CDC
		private byte[] a(global::Motorola.Common.Communication.Pba.PbaObject A_0, int A_1, int A_2)
		{
			short num = (short)1649803264;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				byte[] array = null;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)1099956229;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)1919680518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							array = new byte[A_2];
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							global::System.Array.Copy(value.Data, A_1, array, 0, A_2);
							num = (short)517472258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
							num = (short)331677703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data != null)
							{
								num = (short)1282342915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_7F;
							}
							continue;
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data.Length > A_1 + A_2)
							{
								num = (short)591265793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::Motorola.Common.Communication.CommonUtil.IshHeader key;
							if (key.IshType == 900)
							{
								num = (short)727384064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							goto IL_1F6;
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)329711626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)1457061892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							num = (short)1639710728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C7:
						num = (short)1018953737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7F:
						goto IL_C7;
					}
					IL_1F6:;
				}
				finally
				{
					num = (short)1470693377;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1004019888;
						short num3 = num;
						num = (short)1297555632;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)248709120;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_2B1;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_279;
								}
								continue;
							case 2:
								goto IL_293;
							}
							IL_279:
							if (enumerator != null)
							{
								num = (short)637272066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B3;
						}
						IL_293:
						enumerator.Dispose();
						num = (short)978780160;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2B1:
					IL_2B3:;
				}
				num = (short)1143144448;
				short num4 = num;
				num = (short)1396768769;
				if (num != 0)
				{
				}
				return array;
			}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000BE0C File Offset: 0x0000A00C
		protected bool IsFirmwareSupport_ESN_Encryption_Decryption()
		{
			int a_ = 15;
			short num = (short)2114931804;
			short num2 = num;
			num = (short)1579699292;
			switch (num2 == num)
			{
			}
			num = (short)1043464192;
			short num3 = num;
			num = (short)2025259009;
			if (num != 0)
			{
			}
			num = (short)1543897088;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.ag.a(this.ExtendedDeviceInfo.SoftwareVersion, global::Motorola.Common.Communication.Crc32.c("鲫隭麯誱膳颵袷誹", a_)) > 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		protected void UpdatePINPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)290258944;
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
						string a_2;
						string a_3;
						string encryptedPwd;
						switch (num2)
						{
						case 0:
							goto IL_276;
						case 1:
						{
							string text;
							a_2 = text.Substring(0, 4);
							a_3 = text.Substring(4);
							num = (short)897187847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (!this.IsFirmwareSupport_ESN_Encryption_Decryption())
							{
								num = (short)238223363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35F;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("삤킦覨좬첮쒰솲\udcb4쎶삸鮺\udebe돀럂계돆ꃈ꓊ꏌꛐ뫒ꇔ뿖律꿚뗜뫞쇠賢觤菦짨跪蓬鷮鳰蓲铴藶鳸ퟺ\uddfc꯾䤀䨂嘄✆䀈堊ⴌ与ㄐ娒嬔䄖堘圚吜嬞Ġ焢搤挦怨搪̬", a_), global::System.Array.Empty<object>());
							num = (short)1324220421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							string text = global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd);
							num = (short)562298886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_35F;
						case 6:
						{
							string text;
							if (text.Length > 4)
							{
								num = (short)621871105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = text;
							num = (short)690094092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_2C5;
						case 8:
							if (global::Motorola.Common.Communication.v.f(pbaObject))
							{
								num = (short)1350565904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_2 = string.Empty;
							a_3 = string.Empty;
							num = (short)1716322317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_39F;
						case 10:
						{
							num = (short)1500392583;
							short num3 = num;
							num = (short)1459694727;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1CD;
							default:
								num = (short)300941312;
								if (num != 0)
								{
								}
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Crc32.c("햤쎦좨\udfaa좬ﾮﶲ횶쪸좺쪼킾돀Ꟃ蟄ꋆ꿈꓊뿌꫎蛐ꇒ볔ꏖ볘ﯚ뻜럞蓠胢軤쟦鷨菪裬쿮鏰鿲髴银鋸\udbfa鯼黾栀漂⤄✆怈缊ⴌ挎縐簒縔搖㤘礚砜㼞䀠̢䄤並伨䴪䠬崮到娲吴嬶ᤸ氺似嘾㕀♂敄㝆⡈㽊╌", a_), global::System.Array.Empty<object>());
								num = (short)990052352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							if (!global::Motorola.Common.Communication.v.a(pbaToWrite))
							{
								num = (short)1650524170;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							encryptedPwd = global::Motorola.Common.Communication.v.c(pbaToWrite);
							num = (short)1015676936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_2C5;
						case 13:
							if (encryptedPwd != global::Motorola.Common.Communication.Crc32.c("鎢閤鞦馨鮪鶬龮膰莲薴螶覸论趼达杻﯊﷌ￎ퇠폢헤ퟦ\ud9e8\udbea\uddec\udfee쇰쏲열쟶째쯺췼쿾㄀㌂㔄㜆㤈㬊㴌㼎ℐ⌒└✖⤘⬚ⴜ⼞ᄠጢᔤᜦᤨᬪᴬἮİ̲Դܶस଺഼༾煀獂畄睆祈筊経罎慐捒敔杖楘歚浜潞兠", a_))
							{
								num = (short)829292548;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_39F;
						case 14:
							goto IL_39F;
						case 15:
							goto IL_3B7;
						case 16:
							goto IL_1CD;
						}
						goto IL_7B;
						IL_1CD:
						num = (short)911605762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C5:
						global::Motorola.Common.Communication.v.a(pbaToWrite, a_2, a_3);
						num = (short)1788411913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_35F:
						string a_4 = global::authAES.AESCryptography.AESEncrypt(global::authAES.AESCryptography.AESDecryptWithDefKey(encryptedPwd), (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
						global::Motorola.Common.Communication.v.a(pbaToWrite, a_4);
						num = (short)89128974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_39F:
						num = (short)1080819727;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_276:
					IL_3B7:
					break;
					IL_7B:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
					list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 903, 0));
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.SetCodeplug(codeplug);
					num = (short)1481244683;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Crc32.c("햤쎦좨\udfaa좬ﾮﶲ횶쪸좺쪼킾돀Ꟃ蟄ꋆ꿈꓊뿌꫎蛐ꇒ볔ꏖ볘ﯚ믜뻞裠迢胤菦짨鳪蓬鯮駰짲헴賶째蛺", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			num = (short)1695809537;
			if (num != 0)
			{
			}
			num = (short)134021120;
			short num4 = num;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000C340 File Offset: 0x0000A540
		protected void ValidateCodeplugVersion(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			int a_ = 2;
			short num = (short)1371275264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				string cpversion;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)353107968;
						short num3 = num;
						num = (short)1802240009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num4;
						int num5;
						if (num4 == num5)
						{
							num = (short)1160249344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						num = (short)524708689;
						short num6 = num;
						num = (short)1002269521;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_83;
						default:
							num = (short)386596864;
							if (num != 0)
							{
							}
							num = (short)1622474755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)855965697;
						if (num != 0)
						{
						}
						if (cpversion.StartsWith(global::Motorola.Common.Communication.Crc32.c("쾜", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)931201032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_83;
					case 5:
						num = (short)1187643393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_E0;
					case 7:
					{
						int num4;
						int num5;
						if (num4 >= num5)
						{
							num = (short)840630277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20C;
					}
					case 8:
					{
						string text = this.IOController.QueryCodeplugVersion();
						int num5 = (int)global::System.Convert.ToInt16(text.Substring(1, 2), 10);
						int num4 = (int)global::System.Convert.ToInt16(cpversion.Substring(1, 2), 10);
						int num7 = (int)global::System.Convert.ToInt16(text.Substring(4, 2), 10);
						int num8 = (int)global::System.Convert.ToInt16(cpversion.Substring(4, 2), 10);
						num = (short)418185223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						int num7;
						int num8;
						if (num8 < num7)
						{
							num = (short)1280245766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					goto IL_60;
					IL_83:
					if (writePBA.IsRetoreJob)
					{
						return;
					}
					num = (short)1471741954;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E0:
				IL_20C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CPVersionVerifyFailed);
				IL_60:
				cpversion = writePBA.CodeplugData.CPVersion;
				num = (short)1248460804;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000C5EC File Offset: 0x0000A7EC
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
					num2 = (short)399114249;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (pbaObject.ValidationInfos != null)
					{
						num2 = (short)1541406720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)2029453313;
					if (num2 != 0)
					{
					}
					num2 = (short)1186398211;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (validateItemsToRead.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
					{
						num2 = (short)1015873544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_132;
				case 4:
				{
					num2 = (short)432878995;
					short num3 = num2;
					num2 = (short)1040135571;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num2 = (short)193658880;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)670826496;
					if (num2 != 0)
					{
					}
					if (validateItemsToRead != null)
					{
						num2 = (short)2082340866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_132;
				}
				case 5:
					goto IL_132;
				case 6:
					global::Motorola.Common.Communication.IshHandler.Validator.ValidateInfos(pbaObject.ValidationInfos, this.ReadExtendedDeviceInfo(), new global::Motorola.Common.Communication.ag());
					num2 = (short)1699086343;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return;
				case 8:
				{
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = this.ReadIshItems(validateItemsToRead);
					ishItemCollection = this.a(ishItemCollection);
					global::Motorola.Common.Communication.IshHandler.Validator.ValidateFields(pbaObject.ValidationFields, ishItemCollection);
					num2 = (short)1825898501;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					if (pbaObject.ValidationInfos.Count > 0)
					{
						num2 = (short)911998982;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_38;
				IL_132:
				num2 = (short)774373377;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(pbaObject.ValidationFields);
			num2 = (short)1625292804;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000C834 File Offset: 0x0000AA34
		protected virtual global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			short num = (short)535705666;
			short num2 = num;
			num = (short)292960322;
			switch (num2 == num)
			{
			}
			num = (short)547815425;
			if (num != 0)
			{
			}
			num = (short)836239360;
			if (num != 0)
			{
			}
			num = (short)1671757824;
			short num3 = num;
			return this.IshHandler.ReadIshItems(ishHeaders, null);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0)
		{
			short num = (short)1139605504;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)272957441;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							value.Data = value.Data.Take(value.Data.Length - 2).ToArray<byte>();
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							ishItemCollection.Add(keyValuePair.Key, value);
							num = (short)1238237188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_70;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1294008325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
							num = (short)694353926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_182;
						case 4:
							num = (short)1681522689;
							if (num != 0)
							{
							}
							break;
						case 5:
							num = (short)655228931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IshItem value;
							if (value.Data.Length > 2)
							{
								num = (short)183435264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_BA:
						num = (short)86048770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_70:
						goto IL_BA;
					}
					IL_182:;
				}
				finally
				{
					num = (short)1696399362;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_242;
						case 1:
						{
							num = (short)591817224;
							short num3 = num;
							num = (short)944648;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1C0;
							default:
								num = (short)119406592;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)988610560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1BA;
							}
							continue;
						}
						goto IL_1BA;
						IL_1C0:
						num = (short)251723777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BA:
						if (enumerator != null)
						{
							goto IL_1C0;
						}
						break;
					}
					IL_242:;
				}
				num = (short)1202323456;
				short num4 = num;
				return ishItemCollection;
			}
			}
		}

		// Token: 0x06000050 RID: 80
		protected abstract void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite, bool hostedDepotOperation, global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader cplgHeader = null);

		// Token: 0x06000051 RID: 81 RVA: 0x0000CB88 File Offset: 0x0000AD88
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			short num = (short)1017311374;
			short num2 = num;
			num = (short)699068558;
			switch (num2 == num)
			{
			}
			num = (short)771031041;
			if (num != 0)
			{
			}
			num = (short)1527054336;
			if (num != 0)
			{
			}
			num = (short)1423966208;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			global::Motorola.Common.Communication.RadioParams a_ = this.b();
			global::Motorola.Common.Communication.AstroSequenceManager.a(deviceInfo, a_);
			deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			return deviceInfo;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			short num = (short)1677505860;
			short num2 = num;
			num = (short)1417983300;
			switch (num2 == num)
			{
			}
			num = (short)1399390208;
			if (num != 0)
			{
			}
			num = (short)124452865;
			if (num != 0)
			{
			}
			num = (short)1703411712;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
			astroDeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			global::Motorola.Common.Communication.RadioParams a_ = this.f();
			global::Motorola.Common.Communication.AstroSequenceManager.a(astroDeviceInfo, a_);
			global::Motorola.Common.Communication.AstroSequenceManager.a(astroDeviceInfo, a_);
			this.a = astroDeviceInfo;
			return astroDeviceInfo;
		}

		// Token: 0x06000053 RID: 83
		public abstract global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID);

		// Token: 0x06000054 RID: 84
		public abstract global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation);

		// Token: 0x06000055 RID: 85 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			short num = (short)499685728;
			short num2 = num;
			num = (short)387619168;
			switch (num2 == num)
			{
			}
			num = (short)994639873;
			if (num != 0)
			{
			}
			num = (short)852557824;
			if (num != 0)
			{
			}
			num = (short)1658454016;
			short num3 = num;
			return this.WriteDevice(writePBA, sessionID, pcrNewPassword, hostedDepotOperation);
		}

		// Token: 0x06000056 RID: 86
		public abstract global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList);

		// Token: 0x06000057 RID: 87 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)1076306081;
			short num2 = num;
			num = (short)776282273;
			switch (num2 == num)
			{
			}
			num = (short)1365901313;
			if (num != 0)
			{
			}
			num = (short)1410859008;
			if (num != 0)
			{
			}
			num = (short)2003042304;
			short num3 = num;
			return true;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000CE7C File Offset: 0x0000B07C
		// Note: this type is marked as 'beforefieldinit'.
		static AstroSequenceManager()
		{
			short num = (short)1415722873;
			short num2 = num;
			num = (short)1893480313;
			switch (num2 == num)
			{
			}
			num = (short)1415774209;
			if (num != 0)
			{
			}
			num = (short)109969408;
			if (num != 0)
			{
			}
			num = (short)2026962944;
			short num3 = num;
			global::Motorola.Common.Communication.AstroSequenceManager.f = new global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Guid, string>>(new global::System.Func<global::System.Collections.Generic.Dictionary<global::System.Guid, string>>(global::Motorola.Common.Communication.AstroSequenceManager.e), global::System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
		}

		// Token: 0x0400003E RID: 62
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo a;

		// Token: 0x0400003F RID: 63
		private char[] b = new char[]
		{
			'\0',
			' ',
			'\r',
			'\n'
		};

		// Token: 0x04000040 RID: 64
		protected int m_MaxTransportPacketSize;

		// Token: 0x04000041 RID: 65
		private global::Motorola.Common.Communication.IMessageExecutor c;

		// Token: 0x04000042 RID: 66
		private global::Motorola.Common.Communication.IshHandler.IOController d;

		// Token: 0x04000043 RID: 67
		private global::Motorola.Common.Communication.IshHandler.CommonIshHandler e;

		// Token: 0x04000044 RID: 68
		private static readonly global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Guid, string>> f;

		// Token: 0x04000045 RID: 69
		protected global::Motorola.Common.Communication.CommonUtil.SessionParameter m_SessionParameter;

		// Token: 0x04000046 RID: 70
		private global::Motorola.Common.Communication.RadioParams g;

		// Token: 0x04000047 RID: 71
		private bool h;

		// Token: 0x04000048 RID: 72
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.IProgressIndicator i;
	}
}
