using System;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200004C RID: 76
	internal class e : global::Motorola.Common.Communication.IProgressIndicator
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x000192C8 File Offset: 0x000174C8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.Service.IOperationServiceEvent e()
		{
			short num = (short)205075794;
			short num2 = num;
			num = (short)1111831890;
			switch (num2 == num)
			{
			}
			num = (short)2078670848;
			if (num != 0)
			{
			}
			num = (short)957939712;
			short num3 = num;
			num = (short)375062529;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00019378 File Offset: 0x00017578
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.Common.Communication.Service.IOperationServiceEvent A_0)
		{
			short num = (short)1538973782;
			short num2 = num;
			num = (short)612294742;
			switch (num2 == num)
			{
			}
			num = (short)1759182849;
			if (num != 0)
			{
			}
			num = (short)503382016;
			short num3 = num;
			num = (short)623312896;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00019428 File Offset: 0x00017628
		public void StartRecord()
		{
			short num = (short)872598627;
			short num2 = num;
			num = (short)1760283747;
			switch (num2 == num)
			{
			}
			num = (short)1629028353;
			if (num != 0)
			{
			}
			num = (short)1344995328;
			short num3 = num;
			num = (short)923795456;
			if (num != 0)
			{
			}
			this.d = true;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000194DC File Offset: 0x000176DC
		public void StopRecord()
		{
			short num = (short)68762306;
			short num2 = num;
			num = (short)1590901442;
			switch (num2 == num)
			{
			}
			num = (short)1467547648;
			if (num != 0)
			{
			}
			num = (short)505217024;
			short num3 = num;
			num = (short)1367801857;
			if (num != 0)
			{
			}
			this.d = false;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001958C File Offset: 0x0001778C
		public global::Motorola.Common.Communication.CommonUtil.ProgressStatus get_CurrentStatus()
		{
			short num = (short)1797113994;
			short num2 = num;
			num = (short)634243210;
			switch (num2 == num)
			{
			}
			num = (short)955777025;
			if (num != 0)
			{
			}
			num = (short)40960000;
			short num3 = num;
			num = (short)2123366400;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001963C File Offset: 0x0001783C
		public double get_CurrentProgress()
		{
			short num = (short)1998550750;
			short num2 = num;
			num = (short)1700296414;
			switch (num2 == num)
			{
			}
			num = (short)1294467072;
			if (num != 0)
			{
			}
			num = (short)470482944;
			short num3 = num;
			num = (short)2122907649;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000196EC File Offset: 0x000178EC
		private double d()
		{
			short num = (short)258541899;
			short num2 = num;
			num = (short)689113419;
			switch (num2 == num)
			{
			}
			num = (short)1407844353;
			if (num != 0)
			{
			}
			num = (short)1520697344;
			short num3 = num;
			num = (short)261029888;
			if (num != 0)
			{
			}
			return this.f - this.e;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000197A0 File Offset: 0x000179A0
		public e(global::Motorola.Common.Communication.Service.IOperationServiceEvent A_0)
		{
			this.b = 0.0;
			this.c = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.None;
			this.a(A_0);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000197E8 File Offset: 0x000179E8
		public e() : this(global::System.ServiceModel.OperationContext.Current.GetCallbackChannel<global::Motorola.Common.Communication.Service.IOperationServiceEvent>())
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00019808 File Offset: 0x00017A08
		public void SetCurrentScope(int start, int end)
		{
			int a_ = 2;
			short num = (short)1245708290;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1034551301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_15B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 3:
					goto IL_8D;
				case 4:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("춃揄憐ﲑ秊벛튟춡쎣풥춧\ud9a9\udfab躭쎯톱\udbb3욵\uddb7钹鲻\uddbd떿냁뛃ꏅꛇ뻉觋ꃍ듏苑믓ꗕꇙꏝ쳟싡韣鋥觧飩飫폭误쏱觳", a_), new object[]
					{
						this.e,
						start
					});
					num = (short)610140166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)966782086;
					short num3 = num;
					num = (short)1641147526;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15B;
					default:
						num = (short)2111242241;
						if (num != 0)
						{
						}
						num = (short)26869760;
						if (num != 0)
						{
						}
						if (this.f != (double)start)
						{
							num = (short)900333572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20C;
					}
					break;
				}
				case 6:
					goto IL_20A;
				}
				IL_4A:
				if (start >= end)
				{
					num = (short)921763840;
					short num4 = num;
					num = (short)1705246723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)944504833;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15B:
				if (this.f >= 1.0)
				{
					goto IL_20C;
				}
				num = (short)2132082688;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8D:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("춃ﺇ늑ﶙﮝ펟톡蒣향쮧얩\udcab쮭邯솱톳습첷펹튻\ud9bd럃닅꧇룉룋ꯏ꧓𥉉뿙닛뫝\udddf駡헣鯥웧쓩", a_), new object[]
			{
				start,
				end
			});
			return;
			IL_20A:
			IL_20C:
			this.e = (double)start / 100.0;
			this.f = (double)end / 100.0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00019A48 File Offset: 0x00017C48
		public void UpdateProgress(double percent)
		{
			short num = (short)1451098113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2033000844;
					short num3 = num;
					num = (short)215753100;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_66;
					default:
					{
						num = (short)1696661504;
						if (num != 0)
						{
						}
						double num4;
						if ((int)(this.b * 100.0) != (int)(num4 * 100.0))
						{
							num = (short)1440874500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					goto IL_A6;
				case 3:
				{
					double num4 = this.e + percent * this.d();
					num = (short)351207424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					double num4;
					this.b = num4;
					this.a();
					goto IL_66;
				}
				}
				IL_38:
				if (this.d)
				{
					num = (short)2621443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_66:
				num = (short)2060124160;
				short num5 = num;
				num = (short)1307574274;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A6:
			num = (short)146407425;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00019BD8 File Offset: 0x00017DD8
		public void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			short num = (short)1199308801;
			if (num != 0)
			{
			}
			num = (short)1422524417;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.c = processStatus;
					this.UpdateProgress(percent);
					num = (short)1813905410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					IL_3C:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_C4;
				}
				IL_58:
				num = (short)783482880;
				short num3 = num;
				if (this.d)
				{
					num = (short)160628736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C4:
				num = (short)658249806;
				short num4 = num;
				num = (short)1194203214;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3C;
				default:
					goto IL_F9;
				}
			}
			IL_F9:
			num = (short)254672896;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00019CF4 File Offset: 0x00017EF4
		public void IncreaseProcess(double increasePercent)
		{
			short num = (short)198770689;
			int num2 = (int)((global::System.IntPtr)num);
			double num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((int)(this.b * 100.0) != (int)(num3 * 100.0))
					{
						num = (short)859176964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.b = num3;
					num = (short)424476674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					goto IL_C6;
				case 3:
				{
					num3 = this.b + increasePercent * this.d();
					num = (short)643497984;
					short num4 = num;
					num = (short)710082560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_162;
				}
				IL_39:
				if (!this.d)
				{
					break;
				}
				num = (short)603358488;
				short num5 = num;
				num = (short)1738638616;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C6;
				default:
					num = (short)2016346112;
					if (num != 0)
					{
					}
					num = (short)1007288323;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C6:
			goto IL_167;
			IL_162:
			this.b = num3;
			this.a();
			return;
			IL_167:
			num = (short)586809345;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00019E90 File Offset: 0x00018090
		public void IncreaseProcess(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
		{
			short num = (short)96927745;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.c = processStatus;
					this.IncreaseProcess(increasePercent);
					num = (short)1908539394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					IL_15:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_9B;
				}
				IL_31:
				if (this.d)
				{
					num = (short)104529920;
					short num3 = num;
					num = (short)1592066048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9B:
				num = (short)1625182605;
				short num4 = num;
				num = (short)1461473677;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15;
				default:
					goto IL_D0;
				}
			}
			IL_D0:
			num = (short)233897985;
			if (num != 0)
			{
			}
			num = (short)151650304;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00019FAC File Offset: 0x000181AC
		public void Reset()
		{
			short num = (short)471188224;
			short num2 = num;
			num = (short)847561472;
			switch (num2 == num)
			{
			}
			num = (short)710410241;
			if (num != 0)
			{
			}
			num = (short)1453522944;
			short num3 = num;
			num = (short)1781596160;
			if (num != 0)
			{
			}
			this.e = 0.0;
			this.f = 1.0;
			this.b = 0.0;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0001A080 File Offset: 0x00018280
		private void a()
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)589824006;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::System.Console.ForegroundColor = global::System.ConsoleColor.Red;
						global::System.Console.ResetColor();
						num = (short)2056912897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.b <= this.f)
						{
							num = (short)1390084104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 2:
						goto IL_C0;
					case 3:
						if (this.b > 1.0)
						{
							num = (short)820445194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0;
					case 4:
					{
						num = (short)363857424;
						short num3 = num;
						num = (short)1427113488;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17A;
						default:
							goto IL_20D;
						}
						break;
					}
					case 5:
						goto IL_17A;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 7:
						if (this.b >= this.e)
						{
							num = (short)1880096773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 8:
						num = (short)221511687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1C0;
					case 10:
						this.b = 1.0;
						num = (short)1935081474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5A:
					if (this.e() != null)
					{
						num = (short)260308992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
					IL_C0:
					this.e().OnProgress((int)(100.0 * this.b), this.c);
					num = (short)1832255497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17A:
					num = (short)657522691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C0:
					num = (short)212926468;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20D:
				num = (short)688979968;
				if (num != 0)
				{
				}
			}
			catch (global::System.ServiceModel.CommunicationObjectAbortedException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("첎﶐朗練뮚\udc9cﶞ캠톢톤螦쒪쎬솮풰킲솴\udeb6횸햺鲼", a_), global::System.Array.Empty<object>());
				this.a(null);
			}
			catch (global::System.ServiceModel.CommunicationException)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("첎﶐朗練뮚\udc9cﶞ캠톢톤螦쒪쎬솮풰킲솴\udeb6횸햺鲼", a_), global::System.Array.Empty<object>());
				this.a(null);
			}
			num = (short)1458503680;
			short num4 = num;
			num = (short)2050228225;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000E8 RID: 232
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.Service.IOperationServiceEvent a;

		// Token: 0x040000E9 RID: 233
		private double b;

		// Token: 0x040000EA RID: 234
		private global::Motorola.Common.Communication.CommonUtil.ProgressStatus c;

		// Token: 0x040000EB RID: 235
		private bool d = true;

		// Token: 0x040000EC RID: 236
		private double e;

		// Token: 0x040000ED RID: 237
		private double f = 1.0;
	}
}
