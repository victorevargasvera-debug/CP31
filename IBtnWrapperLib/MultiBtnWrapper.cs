using System;
using System.Diagnostics;

namespace IBtnWrapperLib
{
	// Token: 0x02000013 RID: 19
	public class MultiBtnWrapper : global::IBtnWrapperLib.IBtnWrapperBase
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00014A9C File Offset: 0x00012C9C
		public void CreateButton()
		{
			short num;
			try
			{
				num = (short)943106995;
				short num2 = num;
				num = (short)288074675;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1606352897;
					if (num != 0)
					{
					}
					num = (short)2123694080;
					if (num != 0)
					{
					}
					num = (short)1604386816;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 1:
						goto IL_E4;
					case 2:
						base.CloseButton();
						num = (short)653656065;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_11E;
					}
					IL_A8:
					if (this.btnCommon != null)
					{
						num = (short)1780809730;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E4:
					this.btnCommon = new global::IBtnWrapperLib.IBtnCommon();
					this.btnCommon.PortType = this.portType;
					this.bButtonOpened = true;
					num = (short)1392508931;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_11E:;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			num = (short)417792000;
			short num4 = num;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00014C14 File Offset: 0x00012E14
		public override void OpenButton(int options)
		{
			int a_ = 16;
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
						goto IL_139;
					case 1:
						num2 = (short)562102274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!this.bMotoBtn)
						{
							num2 = (short)1334378501;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.b();
						this.bButtonOpened = true;
						num2 = (short)1437663236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (!this.bOpenForInit)
						{
							num2 = (short)675545089;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CB;
					case 4:
						goto IL_139;
					case 5:
						goto IL_CB;
					case 6:
						goto IL_152;
					}
					goto IL_35;
					IL_CB:
					this.bButtonOpened = true;
					num2 = (short)2058026808;
					short num3 = num2;
					num2 = (short)171638584;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1203372032;
						if (num2 != 0)
						{
						}
						num2 = (short)1451425792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_139:
					num2 = (short)1364197382;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_152:
				goto IL_182;
				IL_35:
				this.bButtonOpened = false;
				num2 = (short)520814595;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::IBtnWrapperLib.TMEXException ex)
			{
				base.CloseButton();
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ై㥊㽌⁎⍐獒㩔❖㱘㕚㑜ㅞ٠䍢౤╦ᱨὪᥬnὰ卲", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				base.CloseButton();
				throw ex2;
			}
			IL_182:
			num2 = (short)440598528;
			short num4 = num2;
			num2 = (short)527302657;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00014E28 File Offset: 0x00013028
		public bool FindFirstBtn(short family)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!this.bButtonOpened)
					{
						num2 = (short)1006567425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1613365250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_84;
				case 2:
					goto IL_2C5;
				}
				goto IL_25;
			}
			IL_84:
			IL_228:
			num2 = (short)2061812799;
			short num3 = num2;
			num2 = (short)1871168575;
			bool flag;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return flag;
			default:
				num2 = (short)46727169;
				if (num2 != 0)
				{
				}
				num2 = (short)1406533632;
				if (num2 != 0)
				{
				}
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ṅ͆硈ᙊ浌N⅐㙒㭔ᕖⱘ⽚⥜ぞའ䍢୤ࡦᵨ䭪๬๮ᵰὲၴ፶", a_));
			}
			IL_2C5:
			try
			{
				num2 = (short)1635385344;
				num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					case 1:
						if (flag)
						{
							num2 = (short)1663172610;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1C0;
					case 2:
						flag = this.btnCommon.FindFirst(this.hSession, family);
						num2 = (short)1168965636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						this.btnCommon.EndSession(this.hSession);
						num2 = (short)1041170438;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_1C0;
					case 5:
						goto IL_1D8;
					case 6:
						goto IL_117;
					}
					IL_C9:
					if (this.hSession > 0)
					{
						num2 = (short)967507971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_117:
					this.btnCommon.PortType = this.portType;
					this.btnCommon.Port = this.portNum;
					this.btnCommon.GetSessionHandle(ref this.hSession);
					flag = this.btnCommon.DoTMSetup(this.hSession);
					num2 = (short)2077818881;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1C0:
					num2 = (short)14876677;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1D8:
				return flag;
			}
			catch (global::IBtnWrapperLib.TMEXException ex)
			{
				string message = global::IBtnWrapperLib.TMEXException.g("̈́⹆❈⽊ୌ♎⍐⁒⅔睖᱘⥚⽜ぞ፠", a_) + ex.Message;
				if (ex.MethodCode == global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession && ex.ErrorCode == -201)
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
			goto IL_228;
			IL_25:
			num2 = (short)1802502144;
			short num4 = num2;
			flag = false;
			num2 = (short)1930493952;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00015134 File Offset: 0x00013334
		public bool FindNextBtn()
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!this.bButtonOpened)
					{
						num2 = (short)1352204289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.btnCommon.PortType = this.portType;
					this.btnCommon.Port = this.portNum;
					num2 = (short)2113994754;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_86;
				case 2:
					goto IL_225;
				}
				goto IL_25;
			}
			IL_86:
			num2 = (short)1716256769;
			if (num2 != 0)
			{
			}
			IL_18D:
			num2 = (short)2032145564;
			short num3 = num2;
			num2 = (short)564270236;
			bool flag;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return flag;
			default:
				num2 = (short)276496384;
				if (num2 != 0)
				{
				}
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᬿف畃ᭅ桇Չ㱋⭍㹏ၑ⅓≕ⱗ㕙㉛繝๟ൡၣ䙥୧୩kɭᕯᙱ", a_));
			}
			IL_225:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_D2;
				}
				for (;;)
				{
					IL_BC:
					switch (num)
					{
					case 0:
						flag = this.btnCommon.FindNext(this.hSession);
						num2 = (short)111476738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (flag)
						{
							num2 = (short)858980352;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_14E;
					case 2:
						goto IL_14E;
					case 3:
						goto IL_166;
					}
					goto IL_D2;
					IL_14E:
					num2 = (short)1959002115;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_166:
				return flag;
				IL_D2:
				this.btnCommon.GetSessionHandle(ref this.hSession);
				flag = this.btnCommon.DoTMSetup(this.hSession);
				num2 = (short)1812135937;
				num = (int)((global::System.IntPtr)num2);
				goto IL_BC;
			}
			catch (global::IBtnWrapperLib.TMEXException ex)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("⤿Aㅃ㉅㱇╉≋湍㽏≑ㅓ⑕㥗⹙㕛ㅝ๟䉡ţᑥᩧթṫ呭偯", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_18D;
			IL_25:
			num2 = (short)483786752;
			short num4 = num2;
			flag = false;
			num2 = (short)42663936;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00015388 File Offset: 0x00013588
		public bool FindBtn(byte[] serialNum)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_79;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)1831927809;
				if (num != 0)
				{
				}
				num = (short)1242628096;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (!this.bButtonOpened)
					{
						num = (short)1527840769;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)718536706;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_B2;
				case 2:
					goto IL_2CB;
				}
				goto IL_79;
			}
			IL_B2:
			IL_254:
			num = (short)1988891076;
			short num4 = num;
			num = (short)66458052;
			bool flag;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return flag;
			default:
				num = (short)1840185344;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᅉࡋ罍൏牑᭓♕㵗㑙ṛ⭝ᑟᙡୣࡥ䡧ѩͫᩭ偯ᅱᕳ᩵ᑷό᡻", a_));
			}
			IL_2CB:
			try
			{
				num = (short)191168512;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_F7;
						}
						continue;
					case 1:
						if (flag)
						{
							num = (short)1311047682;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F0;
					case 2:
						flag = this.btnCommon.FindDevice(this.hSession, serialNum);
						num = (short)1960050692;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.btnCommon.EndSession(this.hSession);
						num = (short)1499267078;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1F0;
					case 5:
						goto IL_207;
					case 6:
						goto IL_145;
					}
					IL_F7:
					if (this.hSession > 0)
					{
						num = (short)1957429251;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_145:
					this.btnCommon.PortType = this.portType;
					this.btnCommon.Port = this.portNum;
					this.btnCommon.GetSessionHandle(ref this.hSession);
					flag = this.btnCommon.DoTMSetup(this.hSession);
					num = (short)223412225;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F0:
					num = (short)1111490565;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_207:
				return flag;
			}
			catch (global::IBtnWrapperLib.TMEXException ex)
			{
				string message = global::IBtnWrapperLib.TMEXException.g("౉╋⁍㑏ၑ⁓㡕硗Ὑ⹛ⱝཟၡ", a_) + ex.Message;
				if (ex.MethodCode == global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession && ex.ErrorCode == -201)
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
			goto IL_254;
			IL_79:
			flag = false;
			num = (short)502005760;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}
	}
}
