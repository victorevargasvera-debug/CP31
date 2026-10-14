using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000032 RID: 50
	public class ScheduleJobView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00024EE4 File Offset: 0x000230E4
		public ScheduleJobView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00024F00 File Offset: 0x00023100
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num = (short)539951105;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)1563984397;
				short num2 = num;
				num = (short)2035384845;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1589706752;
					short num3 = num;
					break;
				}
				}
				num = (short)728629248;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("軂꫄돆ꛈ맊ꋌꏎ냐﷒雔룖듘뛚닜뇞ꋠ돢뛤짦믨諪觬蛮黰뻲铴駶飸鳺飼鋾搀洂焄⤆嬈樊椌明縐⠒瘔砖琘欚爜焞䐠䴢儤ࠦ娨䠪䔬䨮唰䘲头制匸吺弼䤾⡀♂㉄框㩈⡊╌⩎㕐♒㥔㉖㍘㑚㽜⥞ࡠ٢ቤ䥦ᅨ੪lͮ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00024FE0 File Offset: 0x000231E0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1858666497;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1441794;
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
					goto IL_204;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_2F2;
				case 2:
					goto IL_2D8;
				case 3:
					goto IL_2A4;
				case 4:
					goto IL_158;
				case 5:
					goto IL_216;
				case 6:
					goto IL_13E;
				case 7:
					goto IL_209;
				case 8:
					goto IL_1B7;
				case 9:
					goto IL_2BE;
				case 10:
					goto IL_223;
				case 11:
					goto IL_297;
				case 12:
					goto IL_27D;
				case 13:
					goto IL_1DE;
				case 14:
					goto IL_270;
				case 15:
					goto IL_2CB;
				case 16:
					goto IL_326;
				case 17:
					goto IL_30C;
				case 18:
					goto IL_131;
				case 19:
					goto IL_17F;
				case 20:
					goto IL_2E5;
				case 21:
					goto IL_28A;
				case 22:
					goto IL_165;
				case 23:
					goto IL_D8;
				case 24:
					goto IL_2FF;
				case 25:
					goto IL_263;
				case 26:
					goto IL_333;
				case 27:
					goto IL_2B1;
				case 28:
					goto IL_14B;
				case 29:
					goto IL_1C4;
				case 30:
					goto IL_230;
				case 31:
					goto IL_172;
				case 32:
					goto IL_319;
				case 33:
					goto IL_1D1;
				default:
					num = (short)99287040;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D8:
			num = (short)1349364159;
			short num3 = num;
			num = (short)2106108351;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_223:
				this.sysCertEnableAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
				return;
			default:
				num = (short)63373312;
				if (num != 0)
				{
				}
				this.rbtAny = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
				return;
			}
			IL_131:
			this.rbtUSB = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_13E:
			this.MaxUserDeffersAllowed = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_14B:
			this.ditStartDate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDateInput)target;
			return;
			IL_158:
			this.cbxWriteProtect = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_165:
			this.rbtOVA = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_172:
			this.msiEndTime = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_17F:
			num = (short)1721237504;
			short num4 = num;
			this.rbtWired = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_1B7:
			this.usercertUninstallAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_1C4:
			this.msiStartTime = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_1D1:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1DE:
			this.rbtReadType = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_204:
			this._contentLoaded = true;
			return;
			IL_209:
			this.gpUserCertifiate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox)target;
			return;
			IL_216:
			this.EnableImmediateDeploymentCb = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_230:
			num = (short)2050293761;
			if (num != 0)
			{
			}
			this.ditEndDate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDateInput)target;
			return;
			IL_263:
			this.nitSwitchover = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput)target;
			return;
			IL_270:
			this.cbxGenerateConfiguration = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_27D:
			this.rbtIsTypeSwitchoverEditable = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_28A:
			this.rbtRRP = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_297:
			this.sysCertDisableAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_2A4:
			this.cbxWriteJob = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_2B1:
			this.cbxTimeZone = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_2BE:
			this.gpSystemCertifiate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox)target;
			return;
			IL_2CB:
			this.cbxApplyRadio = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_2D8:
			this.rbtWriteType = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_2E5:
			this.rbtPOP25 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_2F2:
			this.gpbJobType = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox)target;
			return;
			IL_2FF:
			this.cbxSwitchover = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_30C:
			this.rbtIsTypeFactoryResetEditable = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_319:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_326:
			this.cbxRetrieveLogFile = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
			return;
			IL_333:
			this.tbxName = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
		}

		// Token: 0x040000FA RID: 250
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox gpbJobType;

		// Token: 0x040000FB RID: 251
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtWriteType;

		// Token: 0x040000FC RID: 252
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxWriteJob;

		// Token: 0x040000FD RID: 253
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxWriteProtect;

		// Token: 0x040000FE RID: 254
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox EnableImmediateDeploymentCb;

		// Token: 0x040000FF RID: 255
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox MaxUserDeffersAllowed;

		// Token: 0x04000100 RID: 256
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox gpUserCertifiate;

		// Token: 0x04000101 RID: 257
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox usercertUninstallAll;

		// Token: 0x04000102 RID: 258
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox gpSystemCertifiate;

		// Token: 0x04000103 RID: 259
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox sysCertEnableAll;

		// Token: 0x04000104 RID: 260
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox sysCertDisableAll;

		// Token: 0x04000105 RID: 261
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtIsTypeSwitchoverEditable;

		// Token: 0x04000106 RID: 262
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtReadType;

		// Token: 0x04000107 RID: 263
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxGenerateConfiguration;

		// Token: 0x04000108 RID: 264
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxApplyRadio;

		// Token: 0x04000109 RID: 265
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxRetrieveLogFile;

		// Token: 0x0400010A RID: 266
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtIsTypeFactoryResetEditable;

		// Token: 0x0400010B RID: 267
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtUSB;

		// Token: 0x0400010C RID: 268
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtWired;

		// Token: 0x0400010D RID: 269
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtPOP25;

		// Token: 0x0400010E RID: 270
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtRRP;

		// Token: 0x0400010F RID: 271
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtOVA;

		// Token: 0x04000110 RID: 272
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtAny;

		// Token: 0x04000111 RID: 273
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxSwitchover;

		// Token: 0x04000112 RID: 274
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput nitSwitchover;

		// Token: 0x04000113 RID: 275
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox tbxName;

		// Token: 0x04000114 RID: 276
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbxTimeZone;

		// Token: 0x04000115 RID: 277
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDateInput ditStartDate;

		// Token: 0x04000116 RID: 278
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiStartTime;

		// Token: 0x04000117 RID: 279
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDateInput ditEndDate;

		// Token: 0x04000118 RID: 280
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiEndTime;

		// Token: 0x04000119 RID: 281
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400011A RID: 282
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400011B RID: 283
		private bool _contentLoaded;
	}
}
