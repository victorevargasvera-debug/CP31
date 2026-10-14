using System;
using System.Diagnostics;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000012 RID: 18
	public class MultiBtnWrapper : global::RMIBtnWrapperLib.IBtnWrapperBase
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00014B44 File Offset: 0x00012D44
		public void CreateButton()
		{
			short num;
			try
			{
				num = (short)1217069059;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.CloseButton();
						num = (short)1206910977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1409024001;
						if (num != 0)
						{
						}
						goto IL_E7;
					case 2:
						goto IL_122;
					case 3:
					{
						num = (short)1349016154;
						short num3 = num;
						num = (short)1208310362;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_122;
						default:
							num = (short)184614912;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_82;
							}
							continue;
						}
						break;
					}
					}
					IL_82:
					if (this.btnCommon != null)
					{
						num = (short)1450246144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E7:
					this.btnCommon = new global::RMIBtnWrapperLib.IBtnCommon();
					this.btnCommon.PortType = this.portType;
					this.bButtonOpened = true;
					num = (short)907083778;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_122:;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			num = (short)1556283392;
			short num4 = num;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00014CC0 File Offset: 0x00012EC0
		public override void OpenButton(int options)
		{
			int a_ = 6;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_35;
				}
				int num;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_151;
					case 1:
					{
						num2 = (short)1498297816;
						short num3 = num2;
						num2 = (short)1696478680;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_151;
						default:
							num2 = (short)229048320;
							if (num2 != 0)
							{
							}
							goto IL_139;
						}
						break;
					}
					case 2:
						goto IL_119;
					case 3:
						goto IL_139;
					case 4:
						if (!this.bMotoBtn)
						{
							num2 = (short)507379714;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.b();
						this.bButtonOpened = true;
						num2 = (short)463208449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						num2 = (short)2038169604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (!this.bOpenForInit)
						{
							num2 = (short)1243152389;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_119;
					}
					goto IL_35;
					IL_119:
					this.bButtonOpened = true;
					num2 = (short)1013383171;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_139:
					num2 = (short)1504247808;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_151:
				num2 = (short)148176897;
				if (num2 != 0)
				{
				}
				goto IL_1A8;
				IL_35:
				this.bButtonOpened = false;
				num2 = (short)66125830;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				base.CloseButton();
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("솃慎ﺋ꺍ﾏﮛ뺝즟톣튥\udca7얩슫躭", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				base.CloseButton();
				throw ex2;
			}
			IL_1A8:
			num2 = (short)1720516608;
			short num4 = num2;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00014ED4 File Offset: 0x000130D4
		public bool FindFirstBtn(short family)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)446955520;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_84;
				case 1:
					goto IL_29E;
				case 2:
					if (!this.bButtonOpened)
					{
						num = (short)1132003328;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1966145537;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
			}
			IL_84:
			IL_272:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("풎햐ꊒ좔랖횘횢톤펦욨얪趬솮\udeb0잲閴풶\ud8b8ힺ톼\udabeꗀ", a_));
			IL_29E:
			num = (short)662437889;
			if (num != 0)
			{
			}
			bool flag;
			try
			{
				num = (short)107937798;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_225;
					case 1:
					{
						num = (short)1921774953;
						short num4 = num;
						num = (short)1241380201;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_225;
						default:
							num = (short)613351424;
							if (num != 0)
							{
							}
							flag = this.btnCommon.FindFirst(this.hSession, family);
							num = (short)419954692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (flag)
						{
							num = (short)46071809;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E;
					case 3:
						goto IL_118;
					case 4:
						goto IL_20E;
					case 5:
						this.btnCommon.EndSession(this.hSession);
						num = (short)2027421699;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					}
					IL_C9:
					if (this.hSession > 0)
					{
						num = (short)1113784325;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_118:
					this.btnCommon.PortType = this.portType;
					this.btnCommon.Port = this.portNum;
					this.btnCommon.GetSessionHandle(ref this.hSession);
					flag = this.btnCommon.DoTMSetup(this.hSession);
					num = (short)294912002;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_20E:
					num = (short)1817509888;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_225:
				return flag;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				string message = global::RMIBtnWrapperLib.TMEXException.g("즎ﶒ톖膠힤햦욨\ud9aa", a_) + ex.Message;
				if (ex.MethodCode == global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession && ex.ErrorCode == -201)
				{
					global::System.Diagnostics.Trace.WriteLine(message);
					return flag;
				}
				throw new global::System.Exception(message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_272;
			IL_4E:
			flag = false;
			num = (short)763035650;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000151E0 File Offset: 0x000133E0
		public bool FindNextBtn()
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)135856128;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_AF;
				case 1:
					goto IL_22F;
				case 2:
					if (!this.bButtonOpened)
					{
						num = (short)406192128;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.btnCommon.PortType = this.portType;
					this.btnCommon.Port = this.portNum;
					num = (short)1773666305;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
			}
			IL_AF:
			IL_1E1:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud882솄뚆품ꮊ슌ﾎﶒ힔膠춢쪤펦覨좪첬쎮\uddb0횲톴", a_));
			IL_22F:
			bool flag;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_122;
				}
				for (;;)
				{
					IL_BE:
					num = (short)2073887992;
					short num4 = num;
					num = (short)525927672;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BD;
					default:
						num = (short)1096089600;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							flag = this.btnCommon.FindNext(this.hSession);
							num = (short)2083782657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1A6;
						case 2:
							goto IL_1BD;
						case 3:
							if (flag)
							{
								num = (short)1428815872;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A6;
						}
						goto IL_122;
						IL_1A6:
						num = (short)324534274;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1BD:
				return flag;
				IL_122:
				this.btnCommon.GetSessionHandle(ref this.hSession);
				flag = this.btnCommon.DoTMSetup(this.hSession);
				num = (short)264110083;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_BE;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("임ﶈﾊ놐ﲒ漢캠춢薤슦\udba8\ud9aa슬\uddae记鎲", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_1E1;
			IL_4E:
			flag = false;
			num = (short)708050945;
			if (num != 0)
			{
			}
			num = (short)901185538;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00015458 File Offset: 0x00013658
		public bool FindBtn(byte[] serialNum)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)1151991808;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_85;
				case 1:
					goto IL_2CB;
				case 2:
					if (!this.bButtonOpened)
					{
						num = (short)1390149632;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)347537409;
					if (num != 0)
					{
					}
					num = (short)2001731585;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4F;
			}
			IL_85:
			IL_277:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udd85첇뮉톋꺍\udf8f\uda97쾟첡蒣좥잧\udea9貫춭톯\udeb1\ud8b3펵\udcb7", a_));
			IL_2CB:
			bool flag;
			try
			{
				num = (short)2020278278;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_22A;
					case 1:
					{
						num = (short)1904886893;
						short num4 = num;
						num = (short)881280109;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22A;
						default:
							num = (short)911605760;
							if (num != 0)
							{
							}
							flag = this.btnCommon.FindDevice(this.hSession, serialNum);
							num = (short)1574502404;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (flag)
						{
							num = (short)202113025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					case 3:
						goto IL_11C;
					case 4:
						goto IL_213;
					case 5:
						this.btnCommon.EndSession(this.hSession);
						num = (short)1026686979;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					}
					IL_CC:
					if (this.hSession > 0)
					{
						num = (short)259915781;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_11C:
					this.btnCommon.PortType = this.portType;
					this.btnCommon.Port = this.portNum;
					this.btnCommon.GetSessionHandle(ref this.hSession);
					flag = this.btnCommon.DoTMSetup(this.hSession);
					num = (short)990707714;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_213:
					num = (short)774504448;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_22A:
				return flag;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				string message = global::RMIBtnWrapperLib.TMEXException.g("삅첍ﲑ뒓펕", a_) + ex.Message;
				if (ex.MethodCode == global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession && ex.ErrorCode == -201)
				{
					global::System.Diagnostics.Trace.WriteLine(message);
					return flag;
				}
				throw new global::System.Exception(message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_277;
			IL_4F:
			flag = false;
			num = (short)1230241794;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}
	}
}
