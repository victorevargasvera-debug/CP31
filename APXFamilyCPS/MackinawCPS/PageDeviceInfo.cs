using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using AcpUI;
using AcpUI.Common;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200002C RID: 44
	public class PageDeviceInfo : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00012280 File Offset: 0x00010480
		public void OnExpSelectionChanged1(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1259339776;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int selectedIndex;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					return;
				case 2:
					switch (selectedIndex)
					{
					case 0:
						goto IL_19D;
					case 1:
						goto IL_83;
					case 2:
						goto IL_4C;
					case 3:
						goto IL_190;
					case 4:
					{
						num = (short)2108200915;
						short num3 = num;
						num = (short)1877448659;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)79364097;
							if (num != 0)
							{
							}
							num = (short)963706880;
							if (num != 0)
							{
							}
							this.myExpander1 = this.ExpID5;
							num = (short)1935474691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_1AB;
					}
					num = (short)753401857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				}
				IL_34:
				global::System.Windows.Controls.Primitives.Selector selector = (global::AcpUI.AcpListBox)e.Source;
				if (this.myExpander1 == null)
				{
					this.myExpander1 = new global::System.Windows.Controls.Expander();
				}
				selectedIndex = selector.SelectedIndex;
				num = (short)1786314754;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4C:
			num = (short)1791557632;
			short num4 = num;
			this.myExpander1 = this.ExpID3;
			return;
			IL_83:
			this.myExpander1 = this.ExpID2;
			return;
			IL_190:
			this.myExpander1 = this.ExpID4;
			return;
			IL_19D:
			this.myExpander1 = this.ExpID1;
			return;
			IL_1AB:
			this.myExpander1 = this.ExpID6;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00012444 File Offset: 0x00010644
		public PageDeviceInfo()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00012464 File Offset: 0x00010664
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num = (short)1817862125;
			short num2 = num;
			num = (short)303718381;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1277296641;
				if (num != 0)
				{
				}
				num = (short)232652800;
				short num3 = num;
				num = (short)694288384;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\uddf1뗳꛵ꃷ볹鷻鏽槿渁紃䔅堇変㜋洍缏缑搓礕瘗缙爛樝༟䘡䄣倥䄧䤩䤫䌭儯就唳儵崷䠹ጻ丽ℿ╁⅃≅ⵇ㱉╋ⵍ㕏㭑㩓さ㝗瑙⑛㽝ൟ๡", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00012544 File Offset: 0x00010744
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)277479425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)542375938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					goto IL_20E;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_2D6;
				case 2:
					goto IL_348;
				case 3:
					goto IL_49A;
				case 4:
					goto IL_3FE;
				case 5:
					goto IL_33B;
				case 6:
					goto IL_3B9;
				case 7:
					goto IL_168;
				case 8:
					goto IL_220;
				case 9:
					goto IL_466;
				case 10:
					goto IL_213;
				case 11:
					goto IL_14E;
				case 12:
					goto IL_288;
				case 13:
					goto IL_1C2;
				case 14:
					goto IL_2AF;
				case 15:
					goto IL_22D;
				case 16:
					goto IL_2BC;
				case 17:
					goto IL_27B;
				case 18:
					goto IL_2A2;
				case 19:
					goto IL_3AC;
				case 20:
					goto IL_40B;
				case 21:
					goto IL_261;
				case 22:
					goto IL_254;
				case 23:
					goto IL_1E9;
				case 24:
					goto IL_307;
				case 25:
					goto IL_321;
				case 26:
					goto IL_425;
				case 27:
					goto IL_480;
				case 28:
					goto IL_2FA;
				case 29:
					goto IL_2C9;
				case 30:
					goto IL_4C1;
				case 31:
					goto IL_141;
				case 32:
					goto IL_1B5;
				case 33:
					goto IL_48D;
				case 34:
					goto IL_473;
				case 35:
					goto IL_26E;
				case 36:
					goto IL_4B4;
				case 37:
					goto IL_418;
				case 38:
					goto IL_175;
				case 39:
					goto IL_134;
				case 40:
					goto IL_459;
				case 41:
					goto IL_43F;
				case 42:
					goto IL_314;
				case 43:
					goto IL_247;
				case 44:
					goto IL_3C6;
				case 45:
					goto IL_295;
				case 46:
					goto IL_15B;
				case 47:
					goto IL_432;
				case 48:
					goto IL_1CF;
				case 49:
					goto IL_23A;
				case 50:
					goto IL_32E;
				case 51:
					goto IL_182;
				case 52:
					goto IL_39F;
				case 53:
					goto IL_44C;
				case 54:
					goto IL_1DC;
				case 55:
					goto IL_4A7;
				default:
					num = (short)882507776;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_134:
			this.LblSerNo5 = (global::AcpUI.AcpLabel)target;
			return;
			IL_141:
			this.LblTune4 = (global::AcpUI.AcpLabel)target;
			return;
			IL_14E:
			this.ExpID2 = (global::AcpUI.AcpExpander)target;
			return;
			IL_15B:
			this.LblMace15 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_168:
			this.LblSerNo11 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_175:
			this.ExpID5 = (global::AcpUI.AcpExpander)target;
			return;
			IL_182:
			num = (short)1934163969;
			if (num != 0)
			{
			}
			this.LblMace6 = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B5:
			this.LblHostDsp4 = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C2:
			this.LblTune2 = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CF:
			this.LblSerNo6 = (global::AcpUI.AcpLabel)target;
			return;
			IL_1DC:
			this.LblTune16 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1E9:
			this.LblHostDsp3 = (global::AcpUI.AcpLabel)target;
			return;
			IL_20E:
			this._contentLoaded = true;
			return;
			IL_213:
			this.LblMace11 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_220:
			this.LblHostDsp11 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_22D:
			this.LblMace2 = (global::AcpUI.AcpLabel)target;
			return;
			IL_23A:
			this.LblTune6 = (global::AcpUI.AcpLabel)target;
			return;
			IL_247:
			this.LblSerNo15 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_254:
			this.LblTune3 = (global::AcpUI.AcpLabel)target;
			return;
			IL_261:
			this.LblSerNo3 = (global::AcpUI.AcpLabel)target;
			return;
			IL_26E:
			this.LblHostDsp14 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_27B:
			this.LblHostDsp12 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_288:
			this.LblSerNo2 = (global::AcpUI.AcpLabel)target;
			return;
			IL_295:
			this.LblTune15 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2A2:
			this.LblTune12 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2AF:
			this.LblHostDsp2 = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BC:
			this.LblSerNo12 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2C9:
			this.ExpID4 = (global::AcpUI.AcpExpander)target;
			return;
			IL_2D6:
			this.LstBoxDI = (global::AcpUI.AcpListBox)target;
			this.LstBoxDI.SelectionChanged += new global::System.Windows.Controls.SelectionChangedEventHandler(this.OnExpSelectionChanged1);
			return;
			IL_2FA:
			this.LblMace13 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_307:
			this.LblMace3 = (global::AcpUI.AcpLabel)target;
			return;
			IL_314:
			this.LblMace5 = (global::AcpUI.AcpLabel)target;
			return;
			IL_321:
			this.LblSerNo13 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_32E:
			this.LblHostDsp6 = (global::AcpUI.AcpLabel)target;
			return;
			IL_33B:
			this.LblTune1 = (global::AcpUI.AcpLabel)target;
			return;
			IL_348:
			num = (short)738373121;
			short num3 = num;
			num = (short)1738714625;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_49A:
				this.LblSerNo1 = (global::AcpUI.AcpLabel)target;
				return;
			default:
				num = (short)1779433472;
				if (num != 0)
				{
				}
				this.ExpID1 = (global::AcpUI.AcpExpander)target;
				return;
			}
			IL_39F:
			this.LblSerNo16 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_3AC:
			this.LblMace12 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_3B9:
			this.LblMace1 = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C6:
			num = (short)520290304;
			short num4 = num;
			this.LblHostDsp15 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_3FE:
			this.LblHostDsp1 = (global::AcpUI.AcpLabel)target;
			return;
			IL_40B:
			this.ExpID3 = (global::AcpUI.AcpExpander)target;
			return;
			IL_418:
			this.LblMace14 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_425:
			this.LblHostDsp13 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_432:
			this.ExpID6 = (global::AcpUI.AcpExpander)target;
			return;
			IL_43F:
			this.LblHostDsp5 = (global::AcpUI.AcpLabel)target;
			return;
			IL_44C:
			this.LblHostDsp16 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_459:
			this.LblTune5 = (global::AcpUI.AcpLabel)target;
			return;
			IL_466:
			this.LblTune11 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_473:
			this.LblSerNo14 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_480:
			this.LblTune13 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_48D:
			this.LblMace4 = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A7:
			this.LblMace16 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_4B4:
			this.LblTune14 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_4C1:
			this.LblSerNo4 = (global::AcpUI.AcpLabel)target;
		}

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Controls.Expander myExpander1;

		// Token: 0x04000075 RID: 117
		internal global::AcpUI.AcpListBox LstBoxDI;

		// Token: 0x04000076 RID: 118
		internal global::AcpUI.AcpExpander ExpID1;

		// Token: 0x04000077 RID: 119
		internal global::AcpUI.AcpLabel LblSerNo1;

		// Token: 0x04000078 RID: 120
		internal global::AcpUI.AcpLabel LblHostDsp1;

		// Token: 0x04000079 RID: 121
		internal global::AcpUI.AcpLabel LblTune1;

		// Token: 0x0400007A RID: 122
		internal global::AcpUI.AcpLabel LblMace1;

		// Token: 0x0400007B RID: 123
		internal global::AcpUI.AcpViewOnlyCtrl LblSerNo11;

		// Token: 0x0400007C RID: 124
		internal global::AcpUI.AcpViewOnlyCtrl LblHostDsp11;

		// Token: 0x0400007D RID: 125
		internal global::AcpUI.AcpViewOnlyCtrl LblTune11;

		// Token: 0x0400007E RID: 126
		internal global::AcpUI.AcpViewOnlyCtrl LblMace11;

		// Token: 0x0400007F RID: 127
		internal global::AcpUI.AcpExpander ExpID2;

		// Token: 0x04000080 RID: 128
		internal global::AcpUI.AcpLabel LblSerNo2;

		// Token: 0x04000081 RID: 129
		internal global::AcpUI.AcpLabel LblTune2;

		// Token: 0x04000082 RID: 130
		internal global::AcpUI.AcpLabel LblHostDsp2;

		// Token: 0x04000083 RID: 131
		internal global::AcpUI.AcpLabel LblMace2;

		// Token: 0x04000084 RID: 132
		internal global::AcpUI.AcpViewOnlyCtrl LblSerNo12;

		// Token: 0x04000085 RID: 133
		internal global::AcpUI.AcpViewOnlyCtrl LblHostDsp12;

		// Token: 0x04000086 RID: 134
		internal global::AcpUI.AcpViewOnlyCtrl LblTune12;

		// Token: 0x04000087 RID: 135
		internal global::AcpUI.AcpViewOnlyCtrl LblMace12;

		// Token: 0x04000088 RID: 136
		internal global::AcpUI.AcpExpander ExpID3;

		// Token: 0x04000089 RID: 137
		internal global::AcpUI.AcpLabel LblSerNo3;

		// Token: 0x0400008A RID: 138
		internal global::AcpUI.AcpLabel LblTune3;

		// Token: 0x0400008B RID: 139
		internal global::AcpUI.AcpLabel LblHostDsp3;

		// Token: 0x0400008C RID: 140
		internal global::AcpUI.AcpLabel LblMace3;

		// Token: 0x0400008D RID: 141
		internal global::AcpUI.AcpViewOnlyCtrl LblSerNo13;

		// Token: 0x0400008E RID: 142
		internal global::AcpUI.AcpViewOnlyCtrl LblHostDsp13;

		// Token: 0x0400008F RID: 143
		internal global::AcpUI.AcpViewOnlyCtrl LblTune13;

		// Token: 0x04000090 RID: 144
		internal global::AcpUI.AcpViewOnlyCtrl LblMace13;

		// Token: 0x04000091 RID: 145
		internal global::AcpUI.AcpExpander ExpID4;

		// Token: 0x04000092 RID: 146
		internal global::AcpUI.AcpLabel LblSerNo4;

		// Token: 0x04000093 RID: 147
		internal global::AcpUI.AcpLabel LblTune4;

		// Token: 0x04000094 RID: 148
		internal global::AcpUI.AcpLabel LblHostDsp4;

		// Token: 0x04000095 RID: 149
		internal global::AcpUI.AcpLabel LblMace4;

		// Token: 0x04000096 RID: 150
		internal global::AcpUI.AcpViewOnlyCtrl LblSerNo14;

		// Token: 0x04000097 RID: 151
		internal global::AcpUI.AcpViewOnlyCtrl LblHostDsp14;

		// Token: 0x04000098 RID: 152
		internal global::AcpUI.AcpViewOnlyCtrl LblTune14;

		// Token: 0x04000099 RID: 153
		internal global::AcpUI.AcpViewOnlyCtrl LblMace14;

		// Token: 0x0400009A RID: 154
		internal global::AcpUI.AcpExpander ExpID5;

		// Token: 0x0400009B RID: 155
		internal global::AcpUI.AcpLabel LblSerNo5;

		// Token: 0x0400009C RID: 156
		internal global::AcpUI.AcpLabel LblTune5;

		// Token: 0x0400009D RID: 157
		internal global::AcpUI.AcpLabel LblHostDsp5;

		// Token: 0x0400009E RID: 158
		internal global::AcpUI.AcpLabel LblMace5;

		// Token: 0x0400009F RID: 159
		internal global::AcpUI.AcpViewOnlyCtrl LblSerNo15;

		// Token: 0x040000A0 RID: 160
		internal global::AcpUI.AcpViewOnlyCtrl LblHostDsp15;

		// Token: 0x040000A1 RID: 161
		internal global::AcpUI.AcpViewOnlyCtrl LblTune15;

		// Token: 0x040000A2 RID: 162
		internal global::AcpUI.AcpViewOnlyCtrl LblMace15;

		// Token: 0x040000A3 RID: 163
		internal global::AcpUI.AcpExpander ExpID6;

		// Token: 0x040000A4 RID: 164
		internal global::AcpUI.AcpLabel LblSerNo6;

		// Token: 0x040000A5 RID: 165
		internal global::AcpUI.AcpLabel LblTune6;

		// Token: 0x040000A6 RID: 166
		internal global::AcpUI.AcpLabel LblHostDsp6;

		// Token: 0x040000A7 RID: 167
		internal global::AcpUI.AcpLabel LblMace6;

		// Token: 0x040000A8 RID: 168
		internal global::AcpUI.AcpViewOnlyCtrl LblSerNo16;

		// Token: 0x040000A9 RID: 169
		internal global::AcpUI.AcpViewOnlyCtrl LblHostDsp16;

		// Token: 0x040000AA RID: 170
		internal global::AcpUI.AcpViewOnlyCtrl LblTune16;

		// Token: 0x040000AB RID: 171
		internal global::AcpUI.AcpViewOnlyCtrl LblMace16;

		// Token: 0x040000AC RID: 172
		private bool _contentLoaded;

		// Token: 0x040000AD RID: 173
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
