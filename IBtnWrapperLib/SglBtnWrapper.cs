using System;

namespace IBtnWrapperLib
{
	// Token: 0x02000014 RID: 20
	public class SglBtnWrapper : global::IBtnWrapperLib.IBtnWrapperBase
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000156B0 File Offset: 0x000138B0
		public override void OpenButton(int options)
		{
			int a_ = 11;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_41;
				}
				int num;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (this.btnCommon != null)
						{
							num2 = (short)332005378;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_7F;
					case 1:
						goto IL_1F5;
					case 2:
						base.CloseButton();
						num2 = (short)1433796612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_1DE;
					case 4:
					{
						num2 = (short)987469341;
						short num3 = num2;
						num2 = (short)252548637;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A0;
						default:
							num2 = (short)1232994304;
							if (num2 != 0)
							{
							}
							goto IL_7F;
						}
						break;
					}
					case 5:
						goto IL_1DE;
					case 6:
						if (!this.bOpenForInit)
						{
							num2 = (short)2024669191;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17F;
					case 7:
						goto IL_1A0;
					case 8:
						goto IL_17F;
					case 9:
						if (!this.bMotoBtn)
						{
							num2 = (short)1829568520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.b();
						this.bButtonOpened = true;
						num2 = (short)600834053;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_41;
					IL_7F:
					this.btnCommon = new global::IBtnWrapperLib.IBtnCommon();
					this.btnCommon.PortType = this.portType;
					this.btnCommon.InitMicroLan(options, 4);
					num2 = (short)234815494;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_17F:
					this.bButtonOpened = true;
					num2 = (short)921698307;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1A0:
					num2 = (short)1846476809;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1DE:
					num2 = (short)1980432385;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1F5:
				num2 = (short)657981441;
				if (num2 != 0)
				{
				}
				goto IL_24D;
				IL_41:
				this.bButtonOpened = false;
				num2 = (short)2141061120;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::IBtnWrapperLib.TMEXException ex)
			{
				base.CloseButton();
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ń㑅㩇╉㹋湍㽏≑ㅓ㡕ㅗ㑙㭛繝य़⁡ᅣብᱧթɫ乭", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				base.CloseButton();
				throw ex2;
			}
			IL_24D:
			num2 = (short)1124139008;
			short num4 = num2;
		}
	}
}
