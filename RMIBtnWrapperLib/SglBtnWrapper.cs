using System;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000013 RID: 19
	public class SglBtnWrapper : global::RMIBtnWrapperLib.IBtnWrapperBase
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00015780 File Offset: 0x00013980
		public override void OpenButton(int options)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)107667575;
				short num2 = num;
				num = (short)226025591;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_91:
					num = (short)499056649;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1315962880;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1EA;
					case 1:
						base.CloseButton();
						num = (short)1536819202;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C8;
					case 3:
						goto IL_1D3;
					case 4:
						goto IL_1D3;
					case 5:
						if (!this.bMotoBtn)
						{
							num = (short)1692663814;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.b();
						this.bButtonOpened = true;
						num = (short)1464467460;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_175;
					case 7:
						num = (short)1129644037;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!this.bOpenForInit)
						{
							num = (short)739835911;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					case 9:
						if (this.btnCommon != null)
						{
							num = (short)295436289;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8;
					}
					goto IL_8A;
					IL_C8:
					this.btnCommon = new global::RMIBtnWrapperLib.IBtnCommon();
					this.btnCommon.PortType = this.portType;
					this.btnCommon.InitMicroLan(options, 4);
					num = (short)741015560;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_175:
					this.bButtonOpened = true;
					num = (short)1010040835;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					num = (short)1111818240;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1EA:
				goto IL_21A;
				IL_8A:
				this.bButtonOpened = false;
				goto IL_91;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				base.CloseButton();
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("햏秊몙얟첡춣좥쾧誩얫얯욱삳\ud9b5횷骹", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				base.CloseButton();
				throw ex2;
			}
			IL_21A:
			num = (short)2058027009;
			if (num != 0)
			{
			}
			num = (short)551747584;
			short num4 = num;
		}
	}
}
