using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000039 RID: 57
	public class SessionIdGenerator
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00018C6C File Offset: 0x00016E6C
		private SessionIdGenerator()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00018C98 File Offset: 0x00016E98
		public global::System.Collections.Generic.HashSet<ushort> GetSessionID
		{
			get
			{
				short num = (short)1660928429;
				short num2 = num;
				num = (short)343982509;
				switch (num2 == num)
				{
				}
				num = (short)1450115073;
				if (num != 0)
				{
				}
				num = (short)1116733440;
				short num3 = num;
				num = (short)863633408;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00018D4C File Offset: 0x00016F4C
		public static global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator Instance
		{
			get
			{
				short num = (short)853436369;
				short num2 = num;
				num = (short)60516305;
				switch (num2 == num)
				{
				}
				num = (short)931725313;
				if (num != 0)
				{
				}
				num = (short)834797568;
				short num3 = num;
				num = (short)1184235520;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.d;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00018DFC File Offset: 0x00016FFC
		internal ushort GenerateNewUnqiueID(ushort differentSessionID = 0, ushort min = 1)
		{
			short num = (short)163250176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1949040640;
				short num3 = num;
				object obj = global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.e;
				bool flag = false;
				ushort result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9B;
					}
					for (;;)
					{
						IL_5C:
						int num4;
						ushort num5;
						switch (num2)
						{
						case 0:
							goto IL_145;
						case 1:
							goto IL_29D;
						case 2:
							goto IL_183;
						case 3:
							if (min != 2)
							{
								num = (short)919404546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27F;
						case 4:
							goto IL_E2;
						case 5:
							goto IL_302;
						case 6:
							if (num4 >= 10000)
							{
								num = (short)1196556292;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_222;
						case 7:
							if (num4 >= 10000)
							{
								num = (short)2028535808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a.Add(num5);
							result = num5;
							num = (short)1169096709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_188;
						case 9:
							if (!this.a.Contains(num5))
							{
								num = (short)1674444801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_188;
						case 10:
							goto IL_222;
						case 11:
							if (num5 == differentSessionID)
							{
								num = (short)236322824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E2;
						case 12:
							if (min != 1)
							{
								num = (short)340459533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27F;
						case 13:
							num = (short)449445891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
						IL_E2:
						num = (short)1131413505;
						if (num != 0)
						{
						}
						num = (short)1168637959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_188:
						num = (short)768903190;
						short num6 = num;
						num = (short)99518486;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_29D:
							num = (short)1211760651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1423835136;
							if (num != 0)
							{
							}
							num = (short)1182924806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_222:
						num5 = (ushort)this.b.Next((int)min, 65535);
						num4++;
						num = (short)1717436425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_27F:
						num5 = 0;
						num4 = 0;
						num = (short)1115947018;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_145:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerGenerateNewUnqiueIDFailure);
					IL_183:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerGenerateNewUnqiueIDFailure);
					IL_302:
					return result;
					IL_9B:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)26345484;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5C;
				}
				finally
				{
					num = (short)1230635010;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1793654785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_36D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_336;
							}
							continue;
						}
						IL_336:
						if (!flag)
						{
							break;
						}
						num = (short)312279040;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_36D:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00019198 File Offset: 0x00017398
		public void ReturnID(ushort ID)
		{
			int a_ = 3;
			object obj = global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.e;
			bool flag = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_33;
				}
				int num;
				for (;;)
				{
					IL_1D:
					switch (num)
					{
					case 0:
						goto IL_111;
					case 1:
					{
						num2 = (short)349585302;
						short num3 = num2;
						num2 = (short)288833430;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_60;
						default:
							num2 = (short)768933888;
							if (num2 != 0)
							{
							}
							this.a.Remove(ID);
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ୗ㽙⽛ⵝय़ൡ੣䙥ŧ๩䱫ᕭ䁯ཱ味ѵᵷ๹ॻ౽ꢅ", a_), new object[]
							{
								ID
							});
							num2 = (short)122880000;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_128;
					case 3:
						if (this.a.Contains(ID))
						{
							goto IL_60;
						}
						goto IL_111;
					}
					goto IL_33;
					IL_60:
					num2 = (short)2117992449;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_111:
					num2 = (short)1268449282;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_128:
				goto IL_190;
				IL_33:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num2 = (short)1373110275;
				num = (int)((global::System.IntPtr)num2);
				goto IL_1D;
			}
			finally
			{
				num2 = (short)7798786;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num2 = (short)747831297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_18D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_15A;
						}
						continue;
					}
					IL_15A:
					if (!flag)
					{
						break;
					}
					num2 = (short)565248000;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_18D:;
			}
			IL_190:
			num2 = (short)626655232;
			short num4 = num2;
			num2 = (short)2009530369;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000193A4 File Offset: 0x000175A4
		// Note: this type is marked as 'beforefieldinit'.
		static SessionIdGenerator()
		{
			short num = (short)192411055;
			short num2 = num;
			num = (short)2080306607;
			switch (num2 == num)
			{
			}
			num = (short)2064056321;
			if (num != 0)
			{
			}
			num = (short)576782336;
			short num3 = num;
			num = (short)1861222400;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.d = new global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator();
			global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.e = new object();
		}

		// Token: 0x04000056 RID: 86
		private global::System.Collections.Generic.HashSet<ushort> a = new global::System.Collections.Generic.HashSet<ushort>();

		// Token: 0x04000057 RID: 87
		private global::System.Random b = new global::System.Random();

		// Token: 0x04000058 RID: 88
		private const int c = 10000;

		// Token: 0x04000059 RID: 89
		private static global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator d;

		// Token: 0x0400005A RID: 90
		private static object e;
	}
}
