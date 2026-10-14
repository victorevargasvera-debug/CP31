using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUITTS;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.Wide
{
	// Token: 0x0200001C RID: 28
	public class VoiceAnnouncementWidePage : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x00049894 File Offset: 0x00047A94
		public VoiceAnnouncementWidePage()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception)
			{
			}
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000498CC File Offset: 0x00047ACC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1579810817;
			if (num != 0)
			{
			}
			num = (short)1798045696;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 1:
					try
					{
						num = (short)506134529;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpUI.AcpExpander acpExpander;
								if (acpExpander != null)
								{
									num = (short)1274085378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C3;
								}
								continue;
							case 2:
							{
								global::AcpUI.AcpExpander acpExpander;
								base.Expanders.Add(acpExpander);
								num = (short)760676355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)457506821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_178;
							case 6:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1312555012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpUI.AcpExpander acpExpander = ((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander;
								num = (short)186843136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_104:
							num = (short)841351174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C3:
							goto IL_104;
						}
						IL_178:
						goto IL_265;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_199;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_187:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1412759554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EB;
							case 1:
								goto IL_1E9;
							case 2:
								disposable.Dispose();
								num = (short)396296193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_199;
						}
						IL_1E9:
						IL_1EB:
						goto EndFinally_7;
						IL_199:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)438370304;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_187;
						EndFinally_7:;
					}
					goto IL_1EC;
					IL_265:
					this.MyStackPanel.Children[0].Focus();
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)5373954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2A2;
				case 3:
					goto IL_1EC;
				}
				IL_5D:
				if (!this.a)
				{
					num = (short)417398787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_1EC:
				num = (short)2033914310;
				short num3 = num;
				num = (short)875499974;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)569901056;
					if (num != 0)
					{
					}
					global::AcpUI.AcpExpander acpExpander = null;
					global::System.Collections.IEnumerator enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)822476801;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_2A2:
			num = (short)2119761920;
			short num4 = num;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00049BB8 File Offset: 0x00047DB8
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)577568768;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1325639520;
					short num3 = num;
					num = (short)48605024;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)81068032;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_E7;
				case 2:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)1440612353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7D:
				if (!this.a)
				{
					break;
				}
				num = (short)1939210241;
				if (num != 0)
				{
				}
				num = (short)378077186;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E7:
			num = (short)189333504;
			short num4 = num;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00049CD8 File Offset: 0x00047ED8
		public override void SetDataContext()
		{
			if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
			{
				short num = (short)763822080;
				short num2 = num;
				num = (short)988988965;
				short num3 = num;
				num = (short)134923813;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1051721729;
					if (num != 0)
					{
					}
					num = (short)1004601344;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2301);
					return;
				}
			}
			base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2301);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00049DB0 File Offset: 0x00047FB0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)13041665;
			if (num != 0)
			{
			}
			num = (short)496230376;
			short num2 = num;
			num = (short)239984616;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1552744448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1558904832;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00049E60 File Offset: 0x00048060
		private void HLinkVoiceAnnouncementClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1008233752;
			short num2 = num;
			num = (short)877882648;
			switch (num2 == num)
			{
			}
			num = (short)2089877504;
			short num3 = num;
			num = (short)2034630657;
			if (num != 0)
			{
			}
			num = (short)451280896;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00049F10 File Offset: 0x00048110
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 19;
			if (!this.b)
			{
				short num = (short)1944911872;
				short num2 = num;
				num = (short)2056144633;
				short num3 = num;
				num = (short)1474053881;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)776929281;
					if (num != 0)
					{
					}
					num = (short)1780875264;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릕쮗鍊ﶝ즟쎡좣춧쮩\ud8ab\udbad슯ힱ잳趵\udbb7햹톻캽꾿곁ꇃꣅ볇뫋ꇍ맏뇑뇓럕뛗듙돛ꯝ軟臡臣该跧蓩飫鷭\udfef蓱鯳鿵鯷鿹鷻都滿洁焃栅欇漉愋欍縏昑挓缕簗缙㌛栝伟䬡䜣䌥䤧䐩䈫䄭䔯就圳匵唷弹刻䨽㜿⭁⁃⍅晇㉉ⵋ⍍㱏", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00049FF4 File Offset: 0x000481F4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)98369538;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1527775233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_C7C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_C34;
				case 2:
					goto IL_777;
				case 3:
					goto IL_12EB;
				case 4:
					goto IL_1C70;
				case 5:
					goto IL_20C6;
				case 6:
					goto IL_1AF9;
				case 7:
					goto IL_915;
				case 8:
					goto IL_1B20;
				case 9:
					goto IL_1509;
				case 10:
					goto IL_B7A;
				case 11:
					goto IL_875;
				case 12:
					goto IL_18A1;
				case 13:
					goto IL_1595;
				case 14:
					goto IL_1B6B;
				case 15:
					goto IL_16B1;
				case 16:
					goto IL_E3D;
				case 17:
					goto IL_1AAE;
				case 18:
					goto IL_1105;
				case 19:
					goto IL_2229;
				case 20:
					goto IL_1DB3;
				case 21:
					goto IL_EF0;
				case 22:
					goto IL_1403;
				case 23:
					goto IL_1FB3;
				case 24:
					goto IL_1C7D;
				case 25:
					goto IL_1BD0;
				case 26:
					goto IL_1716;
				case 27:
					goto IL_1561;
				case 28:
					goto IL_956;
				case 29:
					goto IL_EA2;
				case 30:
					goto IL_211E;
				case 31:
					goto IL_F08;
				case 32:
					goto IL_131C;
				case 33:
					goto IL_226A;
				case 34:
					goto IL_1B78;
				case 35:
					goto IL_1F1D;
				case 36:
					goto IL_112C;
				case 37:
					goto IL_1E63;
				case 38:
					goto IL_B49;
				case 39:
					goto IL_1200;
				case 40:
					goto IL_203A;
				case 41:
					goto IL_1146;
				case 42:
					goto IL_1894;
				case 43:
					goto IL_1FF2;
				case 44:
					goto IL_1E56;
				case 45:
					goto IL_1547;
				case 46:
					goto IL_19DA;
				case 47:
					goto IL_135D;
				case 48:
					goto IL_F2C;
				case 49:
					goto IL_B9E;
				case 50:
					goto IL_69C;
				case 51:
					goto IL_10B0;
				case 52:
					goto IL_13B5;
				case 53:
					goto IL_B6D;
				case 54:
					goto IL_A37;
				case 55:
					goto IL_CD9;
				case 56:
					goto IL_1112;
				case 57:
					goto IL_93C;
				case 58:
					goto IL_2243;
				case 59:
					goto IL_15F7;
				case 60:
					goto IL_7A8;
				case 61:
					goto IL_963;
				case 62:
					goto IL_8F1;
				case 63:
					goto IL_225D;
				case 64:
					goto IL_1A70;
				case 65:
					goto IL_13C2;
				case 66:
					goto IL_11C2;
				case 67:
					goto IL_2291;
				case 68:
					goto IL_9EC;
				case 69:
					goto IL_12BA;
				case 70:
					goto IL_1C0E;
				case 71:
					goto IL_1D5B;
				case 72:
					goto IL_2092;
				case 73:
					goto IL_784;
				case 74:
					goto IL_180E;
				case 75:
					goto IL_111F;
				case 76:
					goto IL_21D1;
				case 77:
					goto IL_1E3C;
				case 78:
					goto IL_21C4;
				case 79:
					goto IL_1CA4;
				case 80:
					goto IL_66B;
				case 81:
					goto IL_19C0;
				case 82:
					goto IL_827;
				case 83:
					goto IL_994;
				case 84:
					goto IL_1B13;
				case 85:
					goto IL_7B5;
				case 86:
					goto IL_1DC0;
				case 87:
					goto IL_13DC;
				case 88:
					goto IL_1B85;
				case 89:
					goto IL_B3C;
				case 90:
					goto IL_19B3;
				case 91:
					goto IL_6FE;
				case 92:
					goto IL_92F;
				case 93:
					goto IL_165C;
				case 94:
					goto IL_85B;
				case 95:
					goto IL_FA8;
				case 96:
					goto IL_84E;
				case 97:
					goto IL_1289;
				case 98:
					goto IL_1832;
				case 99:
					goto IL_195B;
				case 100:
					goto IL_1968;
				case 101:
					goto IL_10A3;
				case 102:
					goto IL_1C97;
				case 103:
					goto IL_1000;
				case 104:
					goto IL_E61;
				case 105:
					goto IL_D7C;
				case 106:
					goto IL_1C01;
				case 107:
					goto IL_173A;
				case 108:
					goto IL_841;
				case 109:
					goto IL_116D;
				case 110:
					goto IL_198F;
				case 111:
					goto IL_16EF;
				case 112:
					goto IL_D3B;
				case 113:
					goto IL_153A;
				case 114:
					goto IL_1910;
				case 115:
					goto IL_18C8;
				case 116:
					goto IL_1DA6;
				case 117:
					goto IL_1139;
				case 118:
					goto IL_81A;
				case 119:
					goto IL_1F10;
				case 120:
					goto IL_152D;
				case 121:
					goto IL_1AD5;
				case 122:
					goto IL_88F;
				case 123:
					goto IL_1DE4;
				case 124:
					goto IL_A06;
				case 125:
					goto IL_CA8;
				case 126:
					goto IL_C0D;
				case 127:
					goto IL_15C6;
				case 128:
					goto IL_BC2;
				case 129:
					goto IL_1B06;
				case 130:
					goto IL_1062;
				case 131:
					goto IL_1747;
				case 132:
					goto IL_1E94;
				case 133:
					goto IL_8C0;
				case 134:
					goto IL_D89;
				case 135:
					goto IL_EBC;
				case 136:
					goto IL_14E2;
				case 137:
					goto IL_14FC;
				case 138:
					goto IL_139B;
				case 139:
					goto IL_1B47;
				case 140:
					goto IL_A6B;
				case 141:
					goto IL_1B92;
				case 142:
					goto IL_FF3;
				case 143:
					goto IL_1B9F;
				case 144:
					goto IL_2061;
				case 145:
					goto IL_1E18;
				case 146:
					goto IL_1611;
				case 147:
					goto IL_EC9;
				case 148:
					goto IL_2104;
				case 149:
					goto IL_800;
				case 150:
					goto IL_7F3;
				case 151:
					goto IL_1F44;
				case 152:
					goto IL_C9B;
				case 153:
					goto IL_A5E;
				case 154:
					goto IL_A78;
				case 155:
					goto IL_191D;
				case 156:
					goto IL_1ABB;
				case 157:
					goto IL_20D3;
				case 158:
					goto IL_AAC;
				case 159:
					goto IL_1AA1;
				case 160:
					goto IL_106F;
				case 161:
					goto IL_19F4;
				case 162:
					goto IL_1604;
				case 163:
					goto IL_2179;
				case 164:
					goto IL_2277;
				case 165:
					goto IL_C8E;
				case 166:
					goto IL_E95;
				case 167:
					goto IL_1801;
				case 168:
					goto IL_141B;
				case 169:
					goto IL_CB5;
				case 170:
					goto IL_753;
				case 171:
					goto IL_A9F;
				case 172:
					goto IL_1588;
				case 173:
					goto IL_1E49;
				case 174:
					goto IL_219D;
				case 175:
					goto IL_119E;
				case 176:
					goto IL_882;
				case 177:
					goto IL_124B;
				case 178:
					goto IL_1642;
				case 179:
					goto IL_EE3;
				case 180:
					goto IL_1435;
				case 181:
					goto IL_1442;
				case 182:
					goto IL_1D1D;
				case 183:
					goto IL_FB5;
				case 184:
					goto IL_1887;
				case 185:
					goto IL_221C;
				case 186:
					goto IL_16E2;
				case 187:
					goto IL_10BD;
				case 188:
					goto IL_1336;
				case 189:
					goto IL_C1A;
				case 190:
					goto IL_868;
				case 191:
					goto IL_1D4E;
				case 192:
					goto IL_1A1B;
				case 193:
					goto IL_1A4C;
				case 194:
					goto IL_1265;
				case 195:
					goto IL_1709;
				case 196:
					goto IL_D62;
				case 197:
					goto IL_16D5;
				case 198:
					goto IL_F77;
				case 199:
					goto IL_192A;
				case 200:
					goto IL_18BB;
				case 201:
					goto IL_A85;
				case 202:
					goto IL_E88;
				case 203:
					goto IL_1754;
				case 204:
					goto IL_2236;
				case 205:
					goto IL_A13;
				case 206:
					goto IL_17B9;
				case 207:
					goto IL_C81;
				case 208:
					goto IL_1A01;
				case 209:
					goto IL_1096;
				case 210:
					goto IL_1E87;
				case 211:
					goto IL_B18;
				case 212:
					goto IL_21EB;
				case 213:
					goto IL_123E;
				case 214:
					goto IL_13E9;
				case 215:
					goto IL_A51;
				case 216:
					goto IL_65E;
				case 217:
					goto IL_1BAC;
				case 218:
					goto IL_AD0;
				case 219:
					goto IL_2054;
				case 220:
					goto IL_1D68;
				case 221:
					goto IL_1231;
				case 222:
					goto IL_21DE;
				case 223:
					goto IL_17DD;
				case 224:
					goto IL_DE1;
				case 225:
					goto IL_6F1;
				case 226:
					goto IL_1191;
				case 227:
					goto IL_987;
				case 228:
					goto IL_9F9;
				case 229:
					goto IL_1377;
				case 230:
					goto IL_D0A;
				case 231:
					goto IL_DBA;
				case 232:
					goto IL_D2E;
				case 233:
					goto IL_1FE5;
				case 234:
					goto IL_20B9;
				case 235:
					goto IL_1C28;
				case 236:
					goto IL_1A28;
				case 237:
					goto IL_1554;
				case 238:
					goto IL_C00;
				case 239:
					goto IL_1792;
				case 240:
					goto IL_1FD8;
				case 241:
					goto IL_1EEC;
				case 242:
					goto IL_1982;
				case 243:
					goto IL_194E;
				case 244:
					goto IL_80D;
				case 245:
					goto IL_1C8A;
				case 246:
					goto IL_E16;
				case 247:
					goto IL_F39;
				case 248:
					goto IL_206E;
				case 249:
					goto IL_BF3;
				case 250:
					goto IL_1024;
				case 251:
					goto IL_F6A;
				case 252:
					goto IL_E6E;
				case 253:
					goto IL_BCF;
				case 254:
					goto IL_DD4;
				case 255:
					goto IL_13A8;
				case 256:
					goto IL_1E0B;
				case 257:
					goto IL_D55;
				case 258:
					goto IL_20AC;
				case 259:
					goto IL_6C0;
				case 260:
					goto IL_1863;
				case 261:
					goto IL_19E7;
				case 262:
					goto IL_DAD;
				case 263:
					goto IL_EAF;
				case 264:
					goto IL_14B1;
				case 265:
					goto IL_63A;
				case 266:
					goto IL_E23;
				case 267:
					goto IL_21B7;
				case 268:
					goto IL_19CD;
				case 269:
					goto IL_2284;
				case 270:
					goto IL_13CF;
				case 271:
					goto IL_1669;
				case 272:
					goto IL_148D;
				case 273:
					goto IL_1258;
				case 274:
					goto IL_C27;
				case 275:
					goto IL_D6F;
				case 276:
					goto IL_20F7;
				case 277:
					goto IL_168D;
				case 278:
					goto IL_1329;
				case 279:
					goto IL_1153;
				case 280:
					goto IL_8B3;
				case 281:
					goto IL_22B5;
				case 282:
					goto IL_1428;
				case 283:
					goto IL_9AE;
				case 284:
					goto IL_1F8F;
				case 285:
					goto IL_A44;
				case 286:
					goto IL_15EA;
				case 287:
					goto IL_1089;
				case 288:
					goto IL_1F75;
				case 289:
					goto IL_1CF9;
				case 290:
					goto IL_1635;
				case 291:
					goto IL_1AC8;
				case 292:
					goto IL_18AE;
				case 293:
					goto IL_1A0E;
				case 294:
					goto IL_949;
				case 295:
					goto IL_12C7;
				case 296:
					goto IL_AF4;
				case 297:
					goto IL_157B;
				case 298:
					goto IL_CFD;
				case 299:
					goto IL_156E;
				case 300:
					goto IL_D48;
				case 301:
					goto IL_14BE;
				case 302:
					goto IL_12AD;
				case 303:
					goto IL_7E6;
				case 304:
					goto IL_1466;
				case 305:
					goto IL_F5D;
				case 306:
					goto IL_14EF;
				case 307:
					goto IL_678;
				case 308:
					goto IL_1D82;
				case 309:
					goto IL_1975;
				case 310:
					goto IL_9A1;
				case 311:
					goto IL_834;
				case 312:
					goto IL_1343;
				case 313:
					goto IL_120D;
				case 314:
					goto IL_1160;
				case 315:
					goto IL_9D2;
				case 316:
					goto IL_1B3A;
				case 317:
					goto IL_DC7;
				case 318:
					goto IL_16FC;
				case 319:
					goto IL_2016;
				case 320:
					goto IL_FC2;
				case 321:
					goto IL_1761;
				case 322:
					goto IL_179F;
				case 323:
					goto IL_E30;
				case 324:
					goto IL_8E4;
				case 325:
					goto IL_2155;
				case 326:
					goto IL_9DF;
				case 327:
					goto IL_1DFE;
				case 328:
					goto IL_1CEC;
				case 329:
					goto IL_722;
				case 330:
					goto IL_2047;
				case 331:
					goto IL_21F8;
				case 332:
					goto IL_1C4C;
				case 333:
					goto IL_17AC;
				case 334:
					goto IL_2111;
				case 335:
					goto IL_21AA;
				case 336:
					goto IL_A92;
				case 337:
					goto IL_F84;
				case 338:
					goto IL_7D9;
				case 339:
					goto IL_11CF;
				case 340:
					goto IL_922;
				case 341:
					goto IL_209F;
				case 342:
					goto IL_6E4;
				case 343:
					goto IL_10E1;
				case 344:
					goto IL_1A7D;
				case 345:
					goto IL_1F2A;
				case 346:
					goto IL_22C2;
				case 347:
					goto IL_E7B;
				case 348:
					goto IL_107C;
				case 349:
					goto IL_1031;
				case 350:
					goto IL_136A;
				case 351:
					goto IL_1055;
				case 352:
					goto IL_1FCB;
				case 353:
					goto IL_1F37;
				case 354:
					goto IL_1BF4;
				case 355:
					goto IL_1CC8;
				case 356:
					goto IL_18EC;
				case 357:
					goto IL_1473;
				case 358:
					goto IL_1DF1;
				case 359:
					goto IL_164F;
				case 360:
					goto IL_1D75;
				case 361:
					goto IL_11DC;
				case 362:
					goto IL_1C1B;
				case 363:
					goto IL_FE6;
				case 364:
					goto IL_2250;
				case 365:
					goto IL_1D41;
				case 366:
					goto IL_1F68;
				case 367:
					goto IL_72F;
				case 368:
					goto IL_15A2;
				case 369:
					goto IL_1480;
				case 370:
					goto IL_1B2D;
				case 371:
					goto IL_130F;
				case 372:
					goto IL_1856;
				case 373:
					goto IL_176E;
				case 374:
					goto IL_1350;
				case 375:
					goto IL_ED6;
				case 376:
					goto IL_1F82;
				case 377:
					goto IL_13F6;
				default:
					num = (short)431489024;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_63A:
			this.RadErgoSelfCheckFailAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoSelfCheckFailAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_65E:
			this.CVBtnRadErgoCfgVAWide_A41506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_66B:
			this.TTSBtnRadErgoDirectModeOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_678:
			this.LblRadErgoCfgVAWidePowerDown = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWidePowerDown.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_69C:
			this.MonitorOnAnnouncementID_A22254 = (global::AcpUI.AcpComboBox)target;
			this.MonitorOnAnnouncementID_A22254.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C0:
			this.LblRadErgoCfgVAWideSelfCheckFailure = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideSelfCheckFailure.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6E4:
			this.CVBtnRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6F1:
			this.RTDBtnRadErgoMultiFuntionalButtonSecondaryModeCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6FE:
			this.RadErgoDirectModeOffVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoDirectModeOffVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_722:
			this.RadErgoAntennaFailureAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_72F:
			this.LblRadErgoCfgVAWideNonHZMAccessory = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideNonHZMAccessory.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_753:
			this.RadErgoCfgVAWide_A41502 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41502.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_777:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_784:
			this.LblDirectModeOnAnnouncementID_A22258 = (global::AcpUI.AcpLabel)target;
			this.LblDirectModeOnAnnouncementID_A22258.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7A8:
			this.CVBtnMonitorOffAnnouncementID_A22256 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7B5:
			this.LblDirectModeOffAnnouncementID_A22121 = (global::AcpUI.AcpLabel)target;
			this.LblDirectModeOffAnnouncementID_A22121.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7D9:
			this.TTSBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_7E6:
			this.RTDBtnRadErgoOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7F3:
			this.CVBtnRadErgoInCallUserAlertOffVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_800:
			this.RadErgoCfgVAWide_A41499Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_80D:
			this.CpyBtnRadErgoWrongBatteryVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_81A:
			this.CpyBtnRadErgoTxInhibitOffVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_827:
			this.CpyBtnRadErgoDirectModeOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_834:
			this.RadErgoCfgVAWidePowerDownComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_841:
			this.CVBtnTxInhibitOffAnnouncementID_A22262 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_84E:
			this.CVBtnTxInhibitOnAnnouncementID_A22260 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_85B:
			this.CpyBtnRadErgoDirectModeOffVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_868:
			this.CpyBtnRadErgoKeyPadControlsLockOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_875:
			this.RTDBtnVoiceAnnouncementPriority_A7651 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_882:
			this.TTSBtnRadErgoSecureTxSelectOffVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_88F:
			this.RadErgoCfgVAWide_A41500 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41500.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8B3:
			this.CpyBtnRadErgoAccessoryFailureAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8C0:
			this.LblRadErgoCfgVAWide_A41497 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41497.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8E4:
			this.CVBtnRadErgoAntennaFailureAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8F1:
			this.MonitorOffAnnouncementID_A22256 = (global::AcpUI.AcpComboBox)target;
			this.MonitorOffAnnouncementID_A22256.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_915:
			this.GrpBoxExpanderVoiceAnnouncementGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_922:
			this.CpyBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92F:
			this.TTSBtnRadErgoDirectModeOffVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_93C:
			this.RTDBtnRadErgoMonitorOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_949:
			this.CVBtnRadErgoCfgVAWideOverTemperature = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_956:
			this.CpyBtnScanOnAnnouncementID_A22250 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_963:
			this.LblMonitorOffAnnouncementID_A22256 = (global::AcpUI.AcpLabel)target;
			this.LblMonitorOffAnnouncementID_A22256.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_987:
			this.RadErgoMultiFuntionalButtonSecondaryModeCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_994:
			this.RadErgoDirectModeOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_9A1:
			this.CpyBtnRadErgoCfgVAWidePowerDown = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9AE:
			this.LblRadErgoCfgVAWideOutOfRange = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideOutOfRange.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9D2:
			this.RTDBtnRadErgoPowerDownAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9DF:
			this.TTSBtnRadErgoAntennaFailureAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_9EC:
			this.TTSBtnRadErgoMonitorOffVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_9F9:
			this.CVBtnSiteSelectableAlertAllowedinOutofRange_A42013 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A06:
			this.CpyBtnRadErgoCfgVAWide_A41500 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A13:
			this.LblRadErgoCfgVAWide_A41505 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41505.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A37:
			this.CVBtnRadErgoMonitorOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A44:
			this.RTDBtnRadErgoCfgVAWideOutOfRange = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A51:
			this.RadErgoMultiFuntionalButtonPrimaryModeCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_A5E:
			this.RTDBtnRadErgoInCallUserAlertOffVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A6B:
			this.TTSBtnRadErgoInCallUserAlertOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_A78:
			this.CpyBtnRadErgoInCallUserAlertOffVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A85:
			this.RTDBtnRadErgoKeyPadControlsLockOffVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A92:
			this.CVBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9F:
			this.RTDBtnRadErgoCfgVAWide_A41502 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AAC:
			this.RadErgoCfgVAWide_A41501 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41501.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AD0:
			this.RadErgoCfgVAWide_A41506 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AF4:
			this.RadErgoCfgVAWideOverTemperature = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideOverTemperature.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B18:
			this.RadErgoMultiFuntionalButtonPrimaryModeCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoMultiFuntionalButtonPrimaryModeCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B3C:
			this.DirectModeOffAnnouncementID_A22121Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_B49:
			this.ScanOffAnnouncementID_A22252 = (global::AcpUI.AcpComboBox)target;
			this.ScanOffAnnouncementID_A22252.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B6D:
			this.MonitorOnAnnouncementID_A22254Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_B7A:
			this.VoiceAnnouncementPriority_A7651 = (global::AcpUI.AcpComboBox)target;
			this.VoiceAnnouncementPriority_A7651.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B9E:
			this.LblMonitorOnAnnouncementID_A22254 = (global::AcpUI.AcpLabel)target;
			this.LblMonitorOnAnnouncementID_A22254.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BC2:
			this.TTSBtnRadErgoEmergencyOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_BCF:
			this.RadErgoExitHazardZoneModeAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoExitHazardZoneModeAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BF3:
			this.RTDBtnRadErgoCfgVAWideExitHazardZoneMode = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C00:
			this.CpyBtnWrongBatteryOnAnnouncementID_43251 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C0D:
			this.CVBtnRadErgoEmergencyOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C1A:
			this.RTDBtnRadErgoKeyPadControlsLockOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C27:
			this.CpyBtnRadErgoCfgVAWideAccessoryFailure = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C34:
			((global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementWidePage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementWidePage)target).Unloaded += this.OnUnloaded;
			return;
			IL_C7C:
			this.b = true;
			return;
			IL_C81:
			this.RTDBtnRadErgoCfgVAWide_A41505 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C8E:
			this.RTDBtnRadErgoSecureTxSelectOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C9B:
			this.TTSBtnRadErgoInCallUserAlertOffVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_CA8:
			this.RadErgoCfgVAWide_A41500Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_CB5:
			this.LblRadErgoCfgVAWide_A41502 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41502.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CD9:
			this.RadErgoMonitorOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoMonitorOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CFD:
			this.CpyBtnRadErgoCfgVAWideOverTemperature = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D0A:
			this.SiteSelectableAlertAllowedinOutofRange_A42013 = (global::AcpUI.AcpCheckBox)target;
			this.SiteSelectableAlertAllowedinOutofRange_A42013.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D2E:
			this.CpyBtnSiteSelectableAlertAllowedinOutofRange_A42013 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D3B:
			this.CpyBtnTxInhibitOffAnnouncementID_A22262 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D48:
			this.CVBtnRadErgoOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D55:
			this.RadErgoExitHazardZoneModeAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_D62:
			this.CpyBtnRadErgoCfgVAWide_A41504 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D6F:
			this.RadErgoCfgVAWideAccessoryFailureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_D7C:
			this.RTDBtnRadErgoTxInhibitOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D89:
			this.RadErgoCfgVAWide_A41497 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41497.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DAD:
			this.CpyBtnRadErgoCfgVAWideSelfCheckFailure = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DBA:
			this.RTDBtnSiteSelectableAlertAllowedinOutofRange_A42013 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DC7:
			this.RadErgoPowerDownAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_DD4:
			this.TTSBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_DE1:
			num = (short)1329397761;
			if (num != 0)
			{
			}
			this.TTSBtnRadErgoMultiFuntionalButtonSecondaryModeCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_E16:
			this.CVBtnRadErgoCfgVAWideExitHazardZoneMode = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E23:
			this.TTSBtnRadErgoSelfCheckFailAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_E30:
			this.RadErgoCfgVAWideAntennaFailureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_E3D:
			this.SuppressReplay_A44925 = (global::AcpUI.AcpCheckBox)target;
			this.SuppressReplay_A44925.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E61:
			this.TTSBtnRadErgoTxInhibitOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_E6E:
			this.CVBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E7B:
			this.RadErgoCfgVAWideOptionalComponentCumulativeOverTemperatureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_E88:
			this.CpyBtnRadErgoKeyPadControlsLockOffVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E95:
			this.CpyBtnRadErgoSecureTxSelectOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EA2:
			this.ScanOnAnnouncementID_A22250Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_EAF:
			this.RadErgoCfgVAWideSelfCheckFailureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_EBC:
			this.RTDBtnRadErgoCfgVAWide_A41497 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EC9:
			this.RTDBtnRadErgoCfgVAWide_A41499 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ED6:
			this.RTDBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EE3:
			this.RadErgoSecureTxSelectOffVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_EF0:
			((global::AcpUI.AcpLabel)target).MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F08:
			this.RadErgoScanOnAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoScanOnAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F2C:
			this.CVBtnMonitorOnAnnouncementID_A22254 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F39:
			this.LblRadErgoCfgVAWideExitHazardZoneMode = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideExitHazardZoneMode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F5D:
			this.RadErgoOverTemperatureAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_F6A:
			this.RadErgoCfgVAWideExitHazardZoneModeComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_F77:
			this.CVBtnRadErgoKeyPadControlsLockOffVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F84:
			this.RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FA8:
			this.RadErgoDirectModeOffVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_FB5:
			this.RTDBtnRadErgoCfgVAWide_A41503 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FC2:
			this.RadErgoCfgVAWideAntennaFailure = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideAntennaFailure.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FE6:
			this.RTDBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FF3:
			this.CpyBtnRadErgoInCallUserAlertOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1000:
			this.RadErgoTxInhibitOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoTxInhibitOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1024:
			this.CpyBtnRadErgoCfgVAWideExitHazardZoneMode = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1031:
			this.RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1055:
			this.RTDBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1062:
			this.CpyBtnRadErgoEmergencyOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_106F:
			this.CpyBtnRadErgoCfgVAWide_A41501 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_107C:
			this.CVBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1089:
			this.RadErgoCfgVAWideOutOfRangeComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1096:
			this.RadErgoCfgVAWide_A41505Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_10A3:
			this.TxInhibitOnAnnouncementID_A22260Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_10B0:
			this.RTDBtnMonitorOnAnnouncementID_A22254 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10BD:
			this.RadErgoKeyPadControlsLockOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoKeyPadControlsLockOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10E1:
			this.LblRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1105:
			this.CpyBtnSuppressReplay_A44925 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1112:
			this.TTSBtnRadErgoMonitorOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_111F:
			this.RTDBtnDirectModeOnAnnouncementID_A22258 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_112C:
			this.CVBtnScanOffAnnouncementID_A22252 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1139:
			this.RTDBtnRadErgoTxInhibitOffVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1146:
			this.ScanOffAnnouncementID_A22252Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1153:
			this.RTDBtnRadErgoAccessoryFailureAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1160:
			this.TTSBtnRadErgoPowerDownAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_116D:
			this.LblTxInhibitOffAnnouncementID_A22262 = (global::AcpUI.AcpLabel)target;
			this.LblTxInhibitOffAnnouncementID_A22262.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1191:
			this.CpyBtnRadErgoMultiFuntionalButtonSecondaryModeCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_119E:
			this.RadErgoSecureTxSelectOffVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoSecureTxSelectOffVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11C2:
			this.CVBtnRadErgoMonitorOffVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11CF:
			this.RTDBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11DC:
			this.RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1200:
			this.RTDBtnScanOffAnnouncementID_A22252 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_120D:
			this.RadErgoPowerDownAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoPowerDownAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1231:
			this.RadErgoCfgVAWide_A41506Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_123E:
			this.RTDBtnRadErgoMultiFuntionalButtonPrimaryModeCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_124B:
			this.RTDBtnRadErgoSecureTxSelectOffVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1258:
			this.RTDBtnRadErgoCfgVAWideAccessoryFailure = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1265:
			this.RadErgoCfgVAWide_A41504 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41504.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1289:
			this.LblTxInhibitOnAnnouncementID_A22260 = (global::AcpUI.AcpLabel)target;
			this.LblTxInhibitOnAnnouncementID_A22260.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12AD:
			this.TTSBtnRadErgoOverTemperatureAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_12BA:
			this.RTDBtnRadErgoMonitorOffVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12C7:
			this.LblRadErgoCfgVAWideOverTemperature = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideOverTemperature.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12EB:
			this.HLinkVoiceAnnouncementGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkVoiceAnnouncementGeneral.Click += this.HLinkVoiceAnnouncementClick;
			return;
			IL_130F:
			this.RadErgoCfgVAWideNonHZMAccessoryComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_131C:
			this.TTSBtnRadErgoScanOnAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1329:
			this.TTSBtnRadErgoAccessoryFailureAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1336:
			this.TTSBtnRadErgoKeyPadControlsLockOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1343:
			this.CVBtnRadErgoPowerDownAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1350:
			this.TTSBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_135D:
			this.RadErgoScanOffAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_136A:
			this.TTSBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1377:
			this.LblSiteSelectableAlertAllowedinOutofRange_A42013 = (global::AcpUI.AcpLabel)target;
			this.LblSiteSelectableAlertAllowedinOutofRange_A42013.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_139B:
			this.CVBtnRadErgoInCallUserAlertOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13A8:
			this.RTDBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13B5:
			this.CpyBtnMonitorOnAnnouncementID_A22254 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13C2:
			this.MonitorOffAnnouncementID_A22256Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_13CF:
			this.CVBtnRadErgoCfgVAWideAccessoryFailure = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13DC:
			this.RTDBtnDirectModeOffAnnouncementID_A22121 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13E9:
			this.CpyBtnRadErgoMultiFuntionalButtonPrimaryModeCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13F6:
			this.RadErgoNonHZMAccessoryAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1403:
			((global::AcpUI.AcpLabel)target).MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_141B:
			this.CVBtnRadErgoCfgVAWide_A41502 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1428:
			this.CVBtnRadErgoCfgVAWideOutOfRange = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1435:
			this.CVBtnRadErgoCfgVAWide_A41503 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1442:
			this.LblRadErgoCfgVAWide_A41503 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41503.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1466:
			this.CpyBtnRadErgoOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1473:
			this.RTDBtnRadErgoCfgVAWideBatteryCumulativeOverTemperature = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1480:
			this.RTDBtnRadErgoCfgVAWideNonHZMAccessory = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_148D:
			this.RadErgoCfgVAWideAccessoryFailure = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideAccessoryFailure.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14B1:
			this.CVBtnRadErgoSelfCheckFailAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14BE:
			this.RadErgoOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoOverTemperatureAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14E2:
			this.CpyBtnRadErgoCfgVAWide_A41497 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14EF:
			this.CVBtnRadErgoCfgVAWidePowerDown = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14FC:
			this.RadErgoCfgVAWide_A41497Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1509:
			this.LblVoiceAnnouncementPriority_A7651 = (global::AcpUI.AcpLabel)target;
			this.LblVoiceAnnouncementPriority_A7651.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_152D:
			this.CVBtnRadErgoCfgVAWide_A41500 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_153A:
			this.TxInhibitOffAnnouncementID_A22262Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1547:
			this.RTDBtnRadErgoScanOffAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1554:
			this.RTDBtnWrongBatteryOnAnnouncementID_43251 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1561:
			this.RTDBtnScanOnAnnouncementID_A22250 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_156E:
			this.RadErgoCfgVAWideOverTemperatureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_157B:
			this.RTDBtnRadErgoCfgVAWideOverTemperature = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1588:
			this.CpyBtnRadErgoCfgVAWide_A41502 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1595:
			this.VoiceAnnouncementPriority_A7651Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_15A2:
			this.RadErgoCfgVAWideNonHZMAccessory = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideNonHZMAccessory.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15C6:
			this.RadErgoEmergencyOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoEmergencyOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15EA:
			this.CpyBtnRadErgoCfgVAWideOutOfRange = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15F7:
			this.RadErgoMonitorOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1604:
			this.CVBtnRadErgoSecureTxSelectOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1611:
			this.RadErgoCfgVAWide_A41499 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41499.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1635:
			this.TTSBtnRadErgoOutOfRangeAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1642:
			this.CpyBtnRadErgoSecureTxSelectOffVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_164F:
			this.RadErgoCfgVAWideBatteryCumulativeOverTemperatureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_165C:
			this.RTDBtnRadErgoDirectModeOffVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1669:
			this.LblRadErgoCfgVAWideAccessoryFailure = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideAccessoryFailure.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_168D:
			this.RadErgoAccessoryFailureAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoAccessoryFailureAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16B1:
			this.LblSuppressReplay_A44925 = (global::AcpUI.AcpLabel)target;
			this.LblSuppressReplay_A44925.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16D5:
			this.RadErgoCfgVAWide_A41504Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_16E2:
			this.CVBtnRadErgoKeyPadControlsLockOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16EF:
			this.RTDBtnTxInhibitOffAnnouncementID_A22262 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16FC:
			this.CVBtnRadErgoCfgVAWideAntennaFailure = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1709:
			this.RTDBtnRadErgoCfgVAWide_A41504 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1716:
			this.ScanOnAnnouncementID_A22250 = (global::AcpUI.AcpComboBox)target;
			this.ScanOnAnnouncementID_A22250.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_173A:
			this.RadErgoTxInhibitOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1747:
			this.RadErgoEmergencyOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1754:
			this.RadErgoKeyPadControlsLockOffVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1761:
			this.RTDBtnRadErgoCfgVAWideAntennaFailure = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_176E:
			this.RadErgoNonHZMAccessoryAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoNonHZMAccessoryAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1792:
			this.WrongBatteryOnAnnouncementID_43251Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_179F:
			this.CpyBtnRadErgoCfgVAWideAntennaFailure = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17AC:
			this.RTDBtnRadErgoCfgVAWideRFDeviceCumulativeOverTemperature = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17B9:
			this.RadErgoCfgVAWide_A41505 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41505.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17DD:
			this.RadErgoMultiFuntionalButtonSecondaryModeCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoMultiFuntionalButtonSecondaryModeCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1801:
			this.RadErgoSecureTxSelectOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_180E:
			this.DirectModeOnAnnouncementID_A22258 = (global::AcpUI.AcpComboBox)target;
			this.DirectModeOnAnnouncementID_A22258.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1832:
			this.TxInhibitOnAnnouncementID_A22260 = (global::AcpUI.AcpComboBox)target;
			this.TxInhibitOnAnnouncementID_A22260.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1856:
			this.CVBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1863:
			this.RadErgoCfgVAWideSelfCheckFailure = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideSelfCheckFailure.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1887:
			this.CpyBtnRadErgoCfgVAWide_A41503 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1894:
			this.CVBtnRadErgoScanOffAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_18A1:
			this.CpyBtnVoiceAnnouncementPriority_A7651 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18AE:
			this.CpyBtnRadErgoOutOfRangeAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18BB:
			this.TTSBtnRadErgoKeyPadControlsLockOffVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_18C8:
			this.RadErgoTxInhibitOffVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoTxInhibitOffVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18EC:
			this.RadErgoCfgVAWideBatteryCumulativeOverTemperature = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideBatteryCumulativeOverTemperature.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1910:
			this.CVBtnRadErgoTxInhibitOffVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_191D:
			this.RadErgoInCallUserAlertOffVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_192A:
			this.RadErgoKeyPadControlsLockOffVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoKeyPadControlsLockOffVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_194E:
			this.RTDBtnRadErgoWrongBatteryVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_195B:
			this.RTDBtnTxInhibitOnAnnouncementID_A22260 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1968:
			this.CpyBtnTxInhibitOnAnnouncementID_A22260 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1975:
			this.RTDBtnRadErgoCfgVAWidePowerDown = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1982:
			this.TTSBtnRadErgoWrongBatteryVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_198F:
			this.TxInhibitOffAnnouncementID_A22262 = (global::AcpUI.AcpComboBox)target;
			this.TxInhibitOffAnnouncementID_A22262.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19B3:
			this.CVBtnRadErgoDirectModeOffVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19C0:
			this.RTDBtnRadErgoDirectModeOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19CD:
			this.CpyBtnRadErgoSelfCheckFailAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19DA:
			this.CpyBtnRadErgoScanOffAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19E7:
			this.RTDBtnRadErgoCfgVAWideSelfCheckFailure = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19F4:
			this.RadErgoCfgVAWide_A41501Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1A01:
			this.CpyBtnRadErgoCfgVAWide_A41505 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A0E:
			this.RadErgoOutOfRangeAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1A1B:
			this.CVBtnRadErgoCfgVAWide_A41504 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A28:
			this.WrongBatteryOnAnnouncementID_43251 = (global::AcpUI.AcpComboBox)target;
			this.WrongBatteryOnAnnouncementID_43251.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A4C:
			this.LblRadErgoCfgVAWide_A41504 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41504.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A70:
			this.CpyBtnMonitorOffAnnouncementID_A22256 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A7D:
			this.RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AA1:
			this.RTDBtnRadErgoCfgVAWide_A41501 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1AAE:
			this.RTDBtnSuppressReplay_A44925 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1ABB:
			this.CVBtnRadErgoCfgVAWide_A41501 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AC8:
			this.RTDBtnRadErgoOutOfRangeAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1AD5:
			this.LblRadErgoCfgVAWide_A41500 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41500.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1AF9:
			this.ExpanderVoiceAnnouncementGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1B06:
			this.RTDBtnRadErgoEmergencyOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B13:
			this.CVBtnDirectModeOffAnnouncementID_A22121 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B20:
			this.CVBtnVoiceAnnouncementPriority_A7651 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B2D:
			this.CpyBtnRadErgoCfgVAWideNonHZMAccessory = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B3A:
			this.CpyBtnRadErgoPowerDownAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B47:
			this.RadErgoInCallUserAlertOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoInCallUserAlertOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B6B:
			this.CVBtnSuppressReplay_A44925 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B78:
			this.CpyBtnRadErgoScanOnAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B85:
			this.CpyBtnDirectModeOffAnnouncementID_A22121 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B92:
			this.RTDBtnRadErgoInCallUserAlertOnVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B9F:
			this.RadErgoInCallUserAlertOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1BAC:
			this.LblRadErgoCfgVAWide_A41506 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BD0:
			this.LblScanOnAnnouncementID_A22250 = (global::AcpUI.AcpLabel)target;
			this.LblScanOnAnnouncementID_A22250.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BF4:
			this.CVBtnRadErgoCfgVAWideBatteryCumulativeOverTemperature = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C01:
			this.CpyBtnRadErgoTxInhibitOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C0E:
			this.CpyBtnRadErgoMonitorOffVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C1B:
			this.TTSBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1C28:
			this.LblWrongBatteryOnAnnouncementID_43251 = (global::AcpUI.AcpLabel)target;
			this.LblWrongBatteryOnAnnouncementID_43251.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C4C:
			this.RadErgoCfgVAWideRFDeviceCumulativeOverTemperature = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideRFDeviceCumulativeOverTemperature.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C70:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1C7D:
			this.CVBtnScanOnAnnouncementID_A22250 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C8A:
			this.RadErgoWrongBatteryVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1C97:
			this.CVBtnRadErgoTxInhibitOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CA4:
			this.RadErgoDirectModeOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoDirectModeOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CC8:
			this.LblRadErgoCfgVAWideBatteryCumulativeOverTemperature = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideBatteryCumulativeOverTemperature.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CEC:
			this.CpyBtnRadErgoAntennaFailureAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1CF9:
			this.RadErgoOutOfRangeAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoOutOfRangeAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D1D:
			this.RadErgoCfgVAWide_A41503 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWide_A41503.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D41:
			this.RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1D4E:
			this.RadErgoKeyPadControlsLockOnVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1D5B:
			this.RadErgoMonitorOffVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1D68:
			this.CpyBtnRadErgoCfgVAWide_A41506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D75:
			this.CVBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D82:
			this.RadErgoCfgVAWidePowerDown = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWidePowerDown.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DA6:
			this.TTSBtnRadErgoTxInhibitOffVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1DB3:
			this.StdGrpBoxExpanderVoiceAnnouncementGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1DC0:
			this.DirectModeOffAnnouncementID_A22121 = (global::AcpUI.AcpComboBox)target;
			this.DirectModeOffAnnouncementID_A22121.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DE4:
			this.RTDBtnRadErgoCfgVAWide_A41500 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DF1:
			this.CpyBtnRadErgoCfgVAWideBatteryCumulativeOverTemperature = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DFE:
			this.RTDBtnRadErgoAntennaFailureAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E0B:
			this.CpyBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E18:
			this.LblRadErgoCfgVAWide_A41499 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41499.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E3C:
			this.DirectModeOnAnnouncementID_A22258Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1E49:
			this.RadErgoCfgVAWide_A41502Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1E56:
			this.TTSBtnRadErgoScanOffAnnouncementVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1E63:
			this.LblScanOffAnnouncementID_A22252 = (global::AcpUI.AcpLabel)target;
			this.LblScanOffAnnouncementID_A22252.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E87:
			this.CVBtnRadErgoMultiFuntionalButtonPrimaryModeCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E94:
			num = (short)1583671885;
			short num3 = num;
			num = (short)568584781;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9D2;
			default:
				num = (short)1988820992;
				if (num != 0)
				{
				}
				this.CVBtnRadErgoCfgVAWide_A41497 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_1EEC:
			this.RadErgoWrongBatteryVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoWrongBatteryVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F10:
			this.RadErgoTxInhibitOffVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1F1D:
			this.RadErgoScanOnAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1F2A:
			this.RTDBtnRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F37:
			this.RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1F44:
			this.RadErgoInCallUserAlertOffVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoInCallUserAlertOffVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F68:
			this.CVBtnRadErgoCfgVAWideNonHZMAccessory = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F75:
			this.CVBtnRadErgoOutOfRangeAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F82:
			this.CpyBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F8F:
			this.RadErgoCfgVAWideOutOfRange = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideOutOfRange.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1FB3:
			((global::AcpUI.AcpLabel)target).MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FCB:
			this.CpyBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FD8:
			this.CVBtnRadErgoWrongBatteryVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FE5:
			this.SiteSelectableAlertAllowedinOutofRange_A42013Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1FF2:
			this.RadErgoScanOffAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoScanOffAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2016:
			this.LblRadErgoCfgVAWideAntennaFailure = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideAntennaFailure.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_203A:
			this.CpyBtnScanOffAnnouncementID_A22252 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2047:
			this.CVBtnRadErgoCfgVAWideRFDeviceCumulativeOverTemperature = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2054:
			this.RTDBtnRadErgoCfgVAWide_A41506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2061:
			this.CVBtnRadErgoCfgVAWide_A41499 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_206E:
			this.RadErgoCfgVAWideExitHazardZoneMode = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgVAWideExitHazardZoneMode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2092:
			this.CVBtnDirectModeOnAnnouncementID_A22258 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_209F:
			this.RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_20AC:
			this.CVBtnRadErgoCfgVAWideSelfCheckFailure = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20B9:
			this.CVBtnWrongBatteryOnAnnouncementID_43251 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20C6:
			this.ExpanderVoiceAnnouncementGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_20D3:
			this.LblRadErgoCfgVAWide_A41501 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWide_A41501.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20F7:
			this.CVBtnRadErgoAccessoryFailureAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2104:
			this.CpyBtnRadErgoCfgVAWide_A41499 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2111:
			this.CpyBtnRadErgoCfgVAWideRFDeviceCumulativeOverTemperature = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_211E:
			num = (short)1853358080;
			short num4 = num;
			this.CVBtnRadErgoScanOnAnnouncementVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2155:
			this.RadErgoAntennaFailureAnnouncementVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoAntennaFailureAnnouncementVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2179:
			this.RadErgoSecureTxSelectOnVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoSecureTxSelectOnVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_219D:
			this.CVBtnRadErgoSecureTxSelectOffVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21AA:
			this.RadErgoCfgVAWideRFDeviceCumulativeOverTemperatureComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_21B7:
			this.RTDBtnRadErgoSelfCheckFailAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21C4:
			this.CVBtnRadErgoDirectModeOnVoiceCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21D1:
			this.CpyBtnDirectModeOnAnnouncementID_A22258 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21DE:
			this.CVBtnRadErgoMultiFuntionalButtonSecondaryModeCommand = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21EB:
			this.TTSBtnRadErgoMultiFuntionalButtonPrimaryModeCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_21F8:
			this.LblRadErgoCfgVAWideRFDeviceCumulativeOverTemperature = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgVAWideRFDeviceCumulativeOverTemperature.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_221C:
			this.RadErgoCfgVAWide_A41503Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2229:
			this.SuppressReplay_A44925Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2236:
			this.CVBtnRadErgoCfgVAWide_A41505 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2243:
			this.CpyBtnRadErgoMonitorOnVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2250:
			this.CpyBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_225D:
			this.RTDBtnMonitorOffAnnouncementID_A22256 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_226A:
			this.RTDBtnRadErgoScanOnAnnouncementVoiceCommand = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2277:
			this.TTSBtnRadErgoSecureTxSelectOnVoiceCommand = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_2284:
			this.RadErgoSelfCheckFailAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2291:
			this.RadErgoMonitorOffVoiceCommand = (global::AcpUI.AcpTextBox)target;
			this.RadErgoMonitorOffVoiceCommand.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22B5:
			this.RadErgoAccessoryFailureAnnouncementVoiceCommandComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_22C2:
			this.CpyBtnRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature = (global::AcpUI.AcpCopyButton)target;
		}

		// Token: 0x0400009D RID: 157
		private bool a;

		// Token: 0x0400009E RID: 158
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400009F RID: 159
		internal global::System.Windows.Documents.Hyperlink HLinkVoiceAnnouncementGeneral;

		// Token: 0x040000A0 RID: 160
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040000A1 RID: 161
		internal global::AcpUI.AcpExpander ExpanderVoiceAnnouncementGeneral;

		// Token: 0x040000A2 RID: 162
		internal global::System.Windows.Controls.Grid ExpanderVoiceAnnouncementGeneralGrid;

		// Token: 0x040000A3 RID: 163
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderVoiceAnnouncementGeneralPseudo0;

		// Token: 0x040000A4 RID: 164
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVoiceAnnouncementPriority_A7651;

		// Token: 0x040000A5 RID: 165
		internal global::AcpUI.AcpLabel LblVoiceAnnouncementPriority_A7651;

		// Token: 0x040000A6 RID: 166
		internal global::AcpUI.AcpComboBox VoiceAnnouncementPriority_A7651;

		// Token: 0x040000A7 RID: 167
		internal global::AcpUI.AcpRtdButton RTDBtnVoiceAnnouncementPriority_A7651;

		// Token: 0x040000A8 RID: 168
		internal global::AcpUI.AcpCopyButton CpyBtnVoiceAnnouncementPriority_A7651;

		// Token: 0x040000A9 RID: 169
		internal global::AcpUI.AcpViewOnlyCtrl VoiceAnnouncementPriority_A7651Comp;

		// Token: 0x040000AA RID: 170
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSuppressReplay_A44925;

		// Token: 0x040000AB RID: 171
		internal global::AcpUI.AcpLabel LblSuppressReplay_A44925;

		// Token: 0x040000AC RID: 172
		internal global::AcpUI.AcpCheckBox SuppressReplay_A44925;

		// Token: 0x040000AD RID: 173
		internal global::AcpUI.AcpRtdButton RTDBtnSuppressReplay_A44925;

		// Token: 0x040000AE RID: 174
		internal global::AcpUI.AcpCopyButton CpyBtnSuppressReplay_A44925;

		// Token: 0x040000AF RID: 175
		internal global::AcpUI.AcpCheckBox SuppressReplay_A44925Comp;

		// Token: 0x040000B0 RID: 176
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderVoiceAnnouncementGeneralPseudo0;

		// Token: 0x040000B1 RID: 177
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanOnAnnouncementID_A22250;

		// Token: 0x040000B2 RID: 178
		internal global::AcpUI.AcpLabel LblScanOnAnnouncementID_A22250;

		// Token: 0x040000B3 RID: 179
		internal global::AcpUI.AcpComboBox ScanOnAnnouncementID_A22250;

		// Token: 0x040000B4 RID: 180
		internal global::AcpUI.AcpRtdButton RTDBtnScanOnAnnouncementID_A22250;

		// Token: 0x040000B5 RID: 181
		internal global::AcpUI.AcpCopyButton CpyBtnScanOnAnnouncementID_A22250;

		// Token: 0x040000B6 RID: 182
		internal global::AcpUI.AcpViewOnlyCtrl ScanOnAnnouncementID_A22250Comp;

		// Token: 0x040000B7 RID: 183
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoScanOnAnnouncementVoiceCommand;

		// Token: 0x040000B8 RID: 184
		internal global::AcpUI.AcpTextBox RadErgoScanOnAnnouncementVoiceCommand;

		// Token: 0x040000B9 RID: 185
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoScanOnAnnouncementVoiceCommand;

		// Token: 0x040000BA RID: 186
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoScanOnAnnouncementVoiceCommand;

		// Token: 0x040000BB RID: 187
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoScanOnAnnouncementVoiceCommand;

		// Token: 0x040000BC RID: 188
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoScanOnAnnouncementVoiceCommandComp;

		// Token: 0x040000BD RID: 189
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanOffAnnouncementID_A22252;

		// Token: 0x040000BE RID: 190
		internal global::AcpUI.AcpLabel LblScanOffAnnouncementID_A22252;

		// Token: 0x040000BF RID: 191
		internal global::AcpUI.AcpComboBox ScanOffAnnouncementID_A22252;

		// Token: 0x040000C0 RID: 192
		internal global::AcpUI.AcpRtdButton RTDBtnScanOffAnnouncementID_A22252;

		// Token: 0x040000C1 RID: 193
		internal global::AcpUI.AcpCopyButton CpyBtnScanOffAnnouncementID_A22252;

		// Token: 0x040000C2 RID: 194
		internal global::AcpUI.AcpViewOnlyCtrl ScanOffAnnouncementID_A22252Comp;

		// Token: 0x040000C3 RID: 195
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoScanOffAnnouncementVoiceCommand;

		// Token: 0x040000C4 RID: 196
		internal global::AcpUI.AcpTextBox RadErgoScanOffAnnouncementVoiceCommand;

		// Token: 0x040000C5 RID: 197
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoScanOffAnnouncementVoiceCommand;

		// Token: 0x040000C6 RID: 198
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoScanOffAnnouncementVoiceCommand;

		// Token: 0x040000C7 RID: 199
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoScanOffAnnouncementVoiceCommand;

		// Token: 0x040000C8 RID: 200
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoScanOffAnnouncementVoiceCommandComp;

		// Token: 0x040000C9 RID: 201
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMonitorOnAnnouncementID_A22254;

		// Token: 0x040000CA RID: 202
		internal global::AcpUI.AcpLabel LblMonitorOnAnnouncementID_A22254;

		// Token: 0x040000CB RID: 203
		internal global::AcpUI.AcpComboBox MonitorOnAnnouncementID_A22254;

		// Token: 0x040000CC RID: 204
		internal global::AcpUI.AcpRtdButton RTDBtnMonitorOnAnnouncementID_A22254;

		// Token: 0x040000CD RID: 205
		internal global::AcpUI.AcpCopyButton CpyBtnMonitorOnAnnouncementID_A22254;

		// Token: 0x040000CE RID: 206
		internal global::AcpUI.AcpViewOnlyCtrl MonitorOnAnnouncementID_A22254Comp;

		// Token: 0x040000CF RID: 207
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoMonitorOnVoiceCommand;

		// Token: 0x040000D0 RID: 208
		internal global::AcpUI.AcpTextBox RadErgoMonitorOnVoiceCommand;

		// Token: 0x040000D1 RID: 209
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoMonitorOnVoiceCommand;

		// Token: 0x040000D2 RID: 210
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoMonitorOnVoiceCommand;

		// Token: 0x040000D3 RID: 211
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoMonitorOnVoiceCommand;

		// Token: 0x040000D4 RID: 212
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoMonitorOnVoiceCommandComp;

		// Token: 0x040000D5 RID: 213
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMonitorOffAnnouncementID_A22256;

		// Token: 0x040000D6 RID: 214
		internal global::AcpUI.AcpLabel LblMonitorOffAnnouncementID_A22256;

		// Token: 0x040000D7 RID: 215
		internal global::AcpUI.AcpComboBox MonitorOffAnnouncementID_A22256;

		// Token: 0x040000D8 RID: 216
		internal global::AcpUI.AcpRtdButton RTDBtnMonitorOffAnnouncementID_A22256;

		// Token: 0x040000D9 RID: 217
		internal global::AcpUI.AcpCopyButton CpyBtnMonitorOffAnnouncementID_A22256;

		// Token: 0x040000DA RID: 218
		internal global::AcpUI.AcpViewOnlyCtrl MonitorOffAnnouncementID_A22256Comp;

		// Token: 0x040000DB RID: 219
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoMonitorOffVoiceCommand;

		// Token: 0x040000DC RID: 220
		internal global::AcpUI.AcpTextBox RadErgoMonitorOffVoiceCommand;

		// Token: 0x040000DD RID: 221
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoMonitorOffVoiceCommand;

		// Token: 0x040000DE RID: 222
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoMonitorOffVoiceCommand;

		// Token: 0x040000DF RID: 223
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoMonitorOffVoiceCommand;

		// Token: 0x040000E0 RID: 224
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoMonitorOffVoiceCommandComp;

		// Token: 0x040000E1 RID: 225
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDirectModeOnAnnouncementID_A22258;

		// Token: 0x040000E2 RID: 226
		internal global::AcpUI.AcpLabel LblDirectModeOnAnnouncementID_A22258;

		// Token: 0x040000E3 RID: 227
		internal global::AcpUI.AcpComboBox DirectModeOnAnnouncementID_A22258;

		// Token: 0x040000E4 RID: 228
		internal global::AcpUI.AcpRtdButton RTDBtnDirectModeOnAnnouncementID_A22258;

		// Token: 0x040000E5 RID: 229
		internal global::AcpUI.AcpCopyButton CpyBtnDirectModeOnAnnouncementID_A22258;

		// Token: 0x040000E6 RID: 230
		internal global::AcpUI.AcpViewOnlyCtrl DirectModeOnAnnouncementID_A22258Comp;

		// Token: 0x040000E7 RID: 231
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoDirectModeOnVoiceCommand;

		// Token: 0x040000E8 RID: 232
		internal global::AcpUI.AcpTextBox RadErgoDirectModeOnVoiceCommand;

		// Token: 0x040000E9 RID: 233
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoDirectModeOnVoiceCommand;

		// Token: 0x040000EA RID: 234
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoDirectModeOnVoiceCommand;

		// Token: 0x040000EB RID: 235
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoDirectModeOnVoiceCommand;

		// Token: 0x040000EC RID: 236
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoDirectModeOnVoiceCommandComp;

		// Token: 0x040000ED RID: 237
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDirectModeOffAnnouncementID_A22121;

		// Token: 0x040000EE RID: 238
		internal global::AcpUI.AcpLabel LblDirectModeOffAnnouncementID_A22121;

		// Token: 0x040000EF RID: 239
		internal global::AcpUI.AcpComboBox DirectModeOffAnnouncementID_A22121;

		// Token: 0x040000F0 RID: 240
		internal global::AcpUI.AcpRtdButton RTDBtnDirectModeOffAnnouncementID_A22121;

		// Token: 0x040000F1 RID: 241
		internal global::AcpUI.AcpCopyButton CpyBtnDirectModeOffAnnouncementID_A22121;

		// Token: 0x040000F2 RID: 242
		internal global::AcpUI.AcpViewOnlyCtrl DirectModeOffAnnouncementID_A22121Comp;

		// Token: 0x040000F3 RID: 243
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoDirectModeOffVoiceCommand;

		// Token: 0x040000F4 RID: 244
		internal global::AcpUI.AcpTextBox RadErgoDirectModeOffVoiceCommand;

		// Token: 0x040000F5 RID: 245
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoDirectModeOffVoiceCommand;

		// Token: 0x040000F6 RID: 246
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoDirectModeOffVoiceCommand;

		// Token: 0x040000F7 RID: 247
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoDirectModeOffVoiceCommand;

		// Token: 0x040000F8 RID: 248
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoDirectModeOffVoiceCommandComp;

		// Token: 0x040000F9 RID: 249
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTxInhibitOnAnnouncementID_A22260;

		// Token: 0x040000FA RID: 250
		internal global::AcpUI.AcpLabel LblTxInhibitOnAnnouncementID_A22260;

		// Token: 0x040000FB RID: 251
		internal global::AcpUI.AcpComboBox TxInhibitOnAnnouncementID_A22260;

		// Token: 0x040000FC RID: 252
		internal global::AcpUI.AcpRtdButton RTDBtnTxInhibitOnAnnouncementID_A22260;

		// Token: 0x040000FD RID: 253
		internal global::AcpUI.AcpCopyButton CpyBtnTxInhibitOnAnnouncementID_A22260;

		// Token: 0x040000FE RID: 254
		internal global::AcpUI.AcpViewOnlyCtrl TxInhibitOnAnnouncementID_A22260Comp;

		// Token: 0x040000FF RID: 255
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoTxInhibitOnVoiceCommand;

		// Token: 0x04000100 RID: 256
		internal global::AcpUI.AcpTextBox RadErgoTxInhibitOnVoiceCommand;

		// Token: 0x04000101 RID: 257
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoTxInhibitOnVoiceCommand;

		// Token: 0x04000102 RID: 258
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoTxInhibitOnVoiceCommand;

		// Token: 0x04000103 RID: 259
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoTxInhibitOnVoiceCommand;

		// Token: 0x04000104 RID: 260
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoTxInhibitOnVoiceCommandComp;

		// Token: 0x04000105 RID: 261
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTxInhibitOffAnnouncementID_A22262;

		// Token: 0x04000106 RID: 262
		internal global::AcpUI.AcpLabel LblTxInhibitOffAnnouncementID_A22262;

		// Token: 0x04000107 RID: 263
		internal global::AcpUI.AcpComboBox TxInhibitOffAnnouncementID_A22262;

		// Token: 0x04000108 RID: 264
		internal global::AcpUI.AcpRtdButton RTDBtnTxInhibitOffAnnouncementID_A22262;

		// Token: 0x04000109 RID: 265
		internal global::AcpUI.AcpCopyButton CpyBtnTxInhibitOffAnnouncementID_A22262;

		// Token: 0x0400010A RID: 266
		internal global::AcpUI.AcpViewOnlyCtrl TxInhibitOffAnnouncementID_A22262Comp;

		// Token: 0x0400010B RID: 267
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoTxInhibitOffVoiceCommand;

		// Token: 0x0400010C RID: 268
		internal global::AcpUI.AcpTextBox RadErgoTxInhibitOffVoiceCommand;

		// Token: 0x0400010D RID: 269
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoTxInhibitOffVoiceCommand;

		// Token: 0x0400010E RID: 270
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoTxInhibitOffVoiceCommand;

		// Token: 0x0400010F RID: 271
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoTxInhibitOffVoiceCommand;

		// Token: 0x04000110 RID: 272
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoTxInhibitOffVoiceCommandComp;

		// Token: 0x04000111 RID: 273
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41500;

		// Token: 0x04000112 RID: 274
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41500;

		// Token: 0x04000113 RID: 275
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41500;

		// Token: 0x04000114 RID: 276
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41500;

		// Token: 0x04000115 RID: 277
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41500;

		// Token: 0x04000116 RID: 278
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41500Comp;

		// Token: 0x04000117 RID: 279
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoEmergencyOnVoiceCommand;

		// Token: 0x04000118 RID: 280
		internal global::AcpUI.AcpTextBox RadErgoEmergencyOnVoiceCommand;

		// Token: 0x04000119 RID: 281
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoEmergencyOnVoiceCommand;

		// Token: 0x0400011A RID: 282
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoEmergencyOnVoiceCommand;

		// Token: 0x0400011B RID: 283
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoEmergencyOnVoiceCommand;

		// Token: 0x0400011C RID: 284
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoEmergencyOnVoiceCommandComp;

		// Token: 0x0400011D RID: 285
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41497;

		// Token: 0x0400011E RID: 286
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41497;

		// Token: 0x0400011F RID: 287
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41497;

		// Token: 0x04000120 RID: 288
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41497;

		// Token: 0x04000121 RID: 289
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41497;

		// Token: 0x04000122 RID: 290
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41497Comp;

		// Token: 0x04000123 RID: 291
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoInCallUserAlertOnVoiceCommand;

		// Token: 0x04000124 RID: 292
		internal global::AcpUI.AcpTextBox RadErgoInCallUserAlertOnVoiceCommand;

		// Token: 0x04000125 RID: 293
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoInCallUserAlertOnVoiceCommand;

		// Token: 0x04000126 RID: 294
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoInCallUserAlertOnVoiceCommand;

		// Token: 0x04000127 RID: 295
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoInCallUserAlertOnVoiceCommand;

		// Token: 0x04000128 RID: 296
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoInCallUserAlertOnVoiceCommandComp;

		// Token: 0x04000129 RID: 297
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41499;

		// Token: 0x0400012A RID: 298
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41499;

		// Token: 0x0400012B RID: 299
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41499;

		// Token: 0x0400012C RID: 300
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41499;

		// Token: 0x0400012D RID: 301
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41499;

		// Token: 0x0400012E RID: 302
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41499Comp;

		// Token: 0x0400012F RID: 303
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoInCallUserAlertOffVoiceCommand;

		// Token: 0x04000130 RID: 304
		internal global::AcpUI.AcpTextBox RadErgoInCallUserAlertOffVoiceCommand;

		// Token: 0x04000131 RID: 305
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoInCallUserAlertOffVoiceCommand;

		// Token: 0x04000132 RID: 306
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoInCallUserAlertOffVoiceCommand;

		// Token: 0x04000133 RID: 307
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoInCallUserAlertOffVoiceCommand;

		// Token: 0x04000134 RID: 308
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoInCallUserAlertOffVoiceCommandComp;

		// Token: 0x04000135 RID: 309
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41501;

		// Token: 0x04000136 RID: 310
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41501;

		// Token: 0x04000137 RID: 311
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41501;

		// Token: 0x04000138 RID: 312
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41501;

		// Token: 0x04000139 RID: 313
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41501;

		// Token: 0x0400013A RID: 314
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41501Comp;

		// Token: 0x0400013B RID: 315
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoSecureTxSelectOnVoiceCommand;

		// Token: 0x0400013C RID: 316
		internal global::AcpUI.AcpTextBox RadErgoSecureTxSelectOnVoiceCommand;

		// Token: 0x0400013D RID: 317
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoSecureTxSelectOnVoiceCommand;

		// Token: 0x0400013E RID: 318
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoSecureTxSelectOnVoiceCommand;

		// Token: 0x0400013F RID: 319
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoSecureTxSelectOnVoiceCommand;

		// Token: 0x04000140 RID: 320
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoSecureTxSelectOnVoiceCommandComp;

		// Token: 0x04000141 RID: 321
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41502;

		// Token: 0x04000142 RID: 322
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41502;

		// Token: 0x04000143 RID: 323
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41502;

		// Token: 0x04000144 RID: 324
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41502;

		// Token: 0x04000145 RID: 325
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41502;

		// Token: 0x04000146 RID: 326
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41502Comp;

		// Token: 0x04000147 RID: 327
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoSecureTxSelectOffVoiceCommand;

		// Token: 0x04000148 RID: 328
		internal global::AcpUI.AcpTextBox RadErgoSecureTxSelectOffVoiceCommand;

		// Token: 0x04000149 RID: 329
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoSecureTxSelectOffVoiceCommand;

		// Token: 0x0400014A RID: 330
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoSecureTxSelectOffVoiceCommand;

		// Token: 0x0400014B RID: 331
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoSecureTxSelectOffVoiceCommand;

		// Token: 0x0400014C RID: 332
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoSecureTxSelectOffVoiceCommandComp;

		// Token: 0x0400014D RID: 333
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41503;

		// Token: 0x0400014E RID: 334
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41503;

		// Token: 0x0400014F RID: 335
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41503;

		// Token: 0x04000150 RID: 336
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41503;

		// Token: 0x04000151 RID: 337
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41503;

		// Token: 0x04000152 RID: 338
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41503Comp;

		// Token: 0x04000153 RID: 339
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoKeyPadControlsLockOnVoiceCommand;

		// Token: 0x04000154 RID: 340
		internal global::AcpUI.AcpTextBox RadErgoKeyPadControlsLockOnVoiceCommand;

		// Token: 0x04000155 RID: 341
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoKeyPadControlsLockOnVoiceCommand;

		// Token: 0x04000156 RID: 342
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoKeyPadControlsLockOnVoiceCommand;

		// Token: 0x04000157 RID: 343
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoKeyPadControlsLockOnVoiceCommand;

		// Token: 0x04000158 RID: 344
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoKeyPadControlsLockOnVoiceCommandComp;

		// Token: 0x04000159 RID: 345
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41504;

		// Token: 0x0400015A RID: 346
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41504;

		// Token: 0x0400015B RID: 347
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41504;

		// Token: 0x0400015C RID: 348
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41504;

		// Token: 0x0400015D RID: 349
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41504;

		// Token: 0x0400015E RID: 350
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41504Comp;

		// Token: 0x0400015F RID: 351
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoKeyPadControlsLockOffVoiceCommand;

		// Token: 0x04000160 RID: 352
		internal global::AcpUI.AcpTextBox RadErgoKeyPadControlsLockOffVoiceCommand;

		// Token: 0x04000161 RID: 353
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoKeyPadControlsLockOffVoiceCommand;

		// Token: 0x04000162 RID: 354
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoKeyPadControlsLockOffVoiceCommand;

		// Token: 0x04000163 RID: 355
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoKeyPadControlsLockOffVoiceCommand;

		// Token: 0x04000164 RID: 356
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoKeyPadControlsLockOffVoiceCommandComp;

		// Token: 0x04000165 RID: 357
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41505;

		// Token: 0x04000166 RID: 358
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41505;

		// Token: 0x04000167 RID: 359
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41505;

		// Token: 0x04000168 RID: 360
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41505;

		// Token: 0x04000169 RID: 361
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41505;

		// Token: 0x0400016A RID: 362
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41505Comp;

		// Token: 0x0400016B RID: 363
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoMultiFuntionalButtonPrimaryModeCommand;

		// Token: 0x0400016C RID: 364
		internal global::AcpUI.AcpTextBox RadErgoMultiFuntionalButtonPrimaryModeCommand;

		// Token: 0x0400016D RID: 365
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoMultiFuntionalButtonPrimaryModeCommand;

		// Token: 0x0400016E RID: 366
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoMultiFuntionalButtonPrimaryModeCommand;

		// Token: 0x0400016F RID: 367
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoMultiFuntionalButtonPrimaryModeCommand;

		// Token: 0x04000170 RID: 368
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoMultiFuntionalButtonPrimaryModeCommandComp;

		// Token: 0x04000171 RID: 369
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWide_A41506;

		// Token: 0x04000172 RID: 370
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWide_A41506;

		// Token: 0x04000173 RID: 371
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWide_A41506;

		// Token: 0x04000174 RID: 372
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWide_A41506;

		// Token: 0x04000175 RID: 373
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWide_A41506;

		// Token: 0x04000176 RID: 374
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWide_A41506Comp;

		// Token: 0x04000177 RID: 375
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoMultiFuntionalButtonSecondaryModeCommand;

		// Token: 0x04000178 RID: 376
		internal global::AcpUI.AcpTextBox RadErgoMultiFuntionalButtonSecondaryModeCommand;

		// Token: 0x04000179 RID: 377
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoMultiFuntionalButtonSecondaryModeCommand;

		// Token: 0x0400017A RID: 378
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoMultiFuntionalButtonSecondaryModeCommand;

		// Token: 0x0400017B RID: 379
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoMultiFuntionalButtonSecondaryModeCommand;

		// Token: 0x0400017C RID: 380
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoMultiFuntionalButtonSecondaryModeCommandComp;

		// Token: 0x0400017D RID: 381
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSiteSelectableAlertAllowedinOutofRange_A42013;

		// Token: 0x0400017E RID: 382
		internal global::AcpUI.AcpLabel LblSiteSelectableAlertAllowedinOutofRange_A42013;

		// Token: 0x0400017F RID: 383
		internal global::AcpUI.AcpCheckBox SiteSelectableAlertAllowedinOutofRange_A42013;

		// Token: 0x04000180 RID: 384
		internal global::AcpUI.AcpRtdButton RTDBtnSiteSelectableAlertAllowedinOutofRange_A42013;

		// Token: 0x04000181 RID: 385
		internal global::AcpUI.AcpCopyButton CpyBtnSiteSelectableAlertAllowedinOutofRange_A42013;

		// Token: 0x04000182 RID: 386
		internal global::AcpUI.AcpCheckBox SiteSelectableAlertAllowedinOutofRange_A42013Comp;

		// Token: 0x04000183 RID: 387
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnWrongBatteryOnAnnouncementID_43251;

		// Token: 0x04000184 RID: 388
		internal global::AcpUI.AcpLabel LblWrongBatteryOnAnnouncementID_43251;

		// Token: 0x04000185 RID: 389
		internal global::AcpUI.AcpComboBox WrongBatteryOnAnnouncementID_43251;

		// Token: 0x04000186 RID: 390
		internal global::AcpUI.AcpRtdButton RTDBtnWrongBatteryOnAnnouncementID_43251;

		// Token: 0x04000187 RID: 391
		internal global::AcpUI.AcpCopyButton CpyBtnWrongBatteryOnAnnouncementID_43251;

		// Token: 0x04000188 RID: 392
		internal global::AcpUI.AcpViewOnlyCtrl WrongBatteryOnAnnouncementID_43251Comp;

		// Token: 0x04000189 RID: 393
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWrongBatteryVoiceCommand;

		// Token: 0x0400018A RID: 394
		internal global::AcpUI.AcpTextBox RadErgoWrongBatteryVoiceCommand;

		// Token: 0x0400018B RID: 395
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoWrongBatteryVoiceCommand;

		// Token: 0x0400018C RID: 396
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWrongBatteryVoiceCommand;

		// Token: 0x0400018D RID: 397
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWrongBatteryVoiceCommand;

		// Token: 0x0400018E RID: 398
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoWrongBatteryVoiceCommandComp;

		// Token: 0x0400018F RID: 399
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideExitHazardZoneMode;

		// Token: 0x04000190 RID: 400
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideExitHazardZoneMode;

		// Token: 0x04000191 RID: 401
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideExitHazardZoneMode;

		// Token: 0x04000192 RID: 402
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideExitHazardZoneMode;

		// Token: 0x04000193 RID: 403
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideExitHazardZoneMode;

		// Token: 0x04000194 RID: 404
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideExitHazardZoneModeComp;

		// Token: 0x04000195 RID: 405
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand;

		// Token: 0x04000196 RID: 406
		internal global::AcpUI.AcpTextBox RadErgoExitHazardZoneModeAnnouncementVoiceCommand;

		// Token: 0x04000197 RID: 407
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand;

		// Token: 0x04000198 RID: 408
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand;

		// Token: 0x04000199 RID: 409
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoExitHazardZoneModeAnnouncementVoiceCommand;

		// Token: 0x0400019A RID: 410
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoExitHazardZoneModeAnnouncementVoiceCommandComp;

		// Token: 0x0400019B RID: 411
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideSelfCheckFailure;

		// Token: 0x0400019C RID: 412
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideSelfCheckFailure;

		// Token: 0x0400019D RID: 413
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideSelfCheckFailure;

		// Token: 0x0400019E RID: 414
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideSelfCheckFailure;

		// Token: 0x0400019F RID: 415
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideSelfCheckFailure;

		// Token: 0x040001A0 RID: 416
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideSelfCheckFailureComp;

		// Token: 0x040001A1 RID: 417
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoSelfCheckFailAnnouncementVoiceCommand;

		// Token: 0x040001A2 RID: 418
		internal global::AcpUI.AcpTextBox RadErgoSelfCheckFailAnnouncementVoiceCommand;

		// Token: 0x040001A3 RID: 419
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoSelfCheckFailAnnouncementVoiceCommand;

		// Token: 0x040001A4 RID: 420
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoSelfCheckFailAnnouncementVoiceCommand;

		// Token: 0x040001A5 RID: 421
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoSelfCheckFailAnnouncementVoiceCommand;

		// Token: 0x040001A6 RID: 422
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoSelfCheckFailAnnouncementVoiceCommandComp;

		// Token: 0x040001A7 RID: 423
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideAccessoryFailure;

		// Token: 0x040001A8 RID: 424
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideAccessoryFailure;

		// Token: 0x040001A9 RID: 425
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideAccessoryFailure;

		// Token: 0x040001AA RID: 426
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideAccessoryFailure;

		// Token: 0x040001AB RID: 427
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideAccessoryFailure;

		// Token: 0x040001AC RID: 428
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideAccessoryFailureComp;

		// Token: 0x040001AD RID: 429
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAccessoryFailureAnnouncementVoiceCommand;

		// Token: 0x040001AE RID: 430
		internal global::AcpUI.AcpTextBox RadErgoAccessoryFailureAnnouncementVoiceCommand;

		// Token: 0x040001AF RID: 431
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoAccessoryFailureAnnouncementVoiceCommand;

		// Token: 0x040001B0 RID: 432
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAccessoryFailureAnnouncementVoiceCommand;

		// Token: 0x040001B1 RID: 433
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAccessoryFailureAnnouncementVoiceCommand;

		// Token: 0x040001B2 RID: 434
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoAccessoryFailureAnnouncementVoiceCommandComp;

		// Token: 0x040001B3 RID: 435
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideOutOfRange;

		// Token: 0x040001B4 RID: 436
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideOutOfRange;

		// Token: 0x040001B5 RID: 437
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideOutOfRange;

		// Token: 0x040001B6 RID: 438
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideOutOfRange;

		// Token: 0x040001B7 RID: 439
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideOutOfRange;

		// Token: 0x040001B8 RID: 440
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideOutOfRangeComp;

		// Token: 0x040001B9 RID: 441
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoOutOfRangeAnnouncementVoiceCommand;

		// Token: 0x040001BA RID: 442
		internal global::AcpUI.AcpTextBox RadErgoOutOfRangeAnnouncementVoiceCommand;

		// Token: 0x040001BB RID: 443
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoOutOfRangeAnnouncementVoiceCommand;

		// Token: 0x040001BC RID: 444
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoOutOfRangeAnnouncementVoiceCommand;

		// Token: 0x040001BD RID: 445
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoOutOfRangeAnnouncementVoiceCommand;

		// Token: 0x040001BE RID: 446
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoOutOfRangeAnnouncementVoiceCommandComp;

		// Token: 0x040001BF RID: 447
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideOverTemperature;

		// Token: 0x040001C0 RID: 448
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideOverTemperature;

		// Token: 0x040001C1 RID: 449
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideOverTemperature;

		// Token: 0x040001C2 RID: 450
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideOverTemperature;

		// Token: 0x040001C3 RID: 451
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideOverTemperature;

		// Token: 0x040001C4 RID: 452
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideOverTemperatureComp;

		// Token: 0x040001C5 RID: 453
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001C6 RID: 454
		internal global::AcpUI.AcpTextBox RadErgoOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001C7 RID: 455
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001C8 RID: 456
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001C9 RID: 457
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001CA RID: 458
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoOverTemperatureAnnouncementVoiceCommandComp;

		// Token: 0x040001CB RID: 459
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWidePowerDown;

		// Token: 0x040001CC RID: 460
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWidePowerDown;

		// Token: 0x040001CD RID: 461
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWidePowerDown;

		// Token: 0x040001CE RID: 462
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWidePowerDown;

		// Token: 0x040001CF RID: 463
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWidePowerDown;

		// Token: 0x040001D0 RID: 464
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWidePowerDownComp;

		// Token: 0x040001D1 RID: 465
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoPowerDownAnnouncementVoiceCommand;

		// Token: 0x040001D2 RID: 466
		internal global::AcpUI.AcpTextBox RadErgoPowerDownAnnouncementVoiceCommand;

		// Token: 0x040001D3 RID: 467
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoPowerDownAnnouncementVoiceCommand;

		// Token: 0x040001D4 RID: 468
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoPowerDownAnnouncementVoiceCommand;

		// Token: 0x040001D5 RID: 469
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoPowerDownAnnouncementVoiceCommand;

		// Token: 0x040001D6 RID: 470
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoPowerDownAnnouncementVoiceCommandComp;

		// Token: 0x040001D7 RID: 471
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideAntennaFailure;

		// Token: 0x040001D8 RID: 472
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideAntennaFailure;

		// Token: 0x040001D9 RID: 473
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideAntennaFailure;

		// Token: 0x040001DA RID: 474
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideAntennaFailure;

		// Token: 0x040001DB RID: 475
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideAntennaFailure;

		// Token: 0x040001DC RID: 476
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideAntennaFailureComp;

		// Token: 0x040001DD RID: 477
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAntennaFailureAnnouncementVoiceCommand;

		// Token: 0x040001DE RID: 478
		internal global::AcpUI.AcpTextBox RadErgoAntennaFailureAnnouncementVoiceCommand;

		// Token: 0x040001DF RID: 479
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoAntennaFailureAnnouncementVoiceCommand;

		// Token: 0x040001E0 RID: 480
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAntennaFailureAnnouncementVoiceCommand;

		// Token: 0x040001E1 RID: 481
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAntennaFailureAnnouncementVoiceCommand;

		// Token: 0x040001E2 RID: 482
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoAntennaFailureAnnouncementVoiceCommandComp;

		// Token: 0x040001E3 RID: 483
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideRFDeviceCumulativeOverTemperature;

		// Token: 0x040001E4 RID: 484
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideRFDeviceCumulativeOverTemperature;

		// Token: 0x040001E5 RID: 485
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideRFDeviceCumulativeOverTemperature;

		// Token: 0x040001E6 RID: 486
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideRFDeviceCumulativeOverTemperature;

		// Token: 0x040001E7 RID: 487
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideRFDeviceCumulativeOverTemperature;

		// Token: 0x040001E8 RID: 488
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideRFDeviceCumulativeOverTemperatureComp;

		// Token: 0x040001E9 RID: 489
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001EA RID: 490
		internal global::AcpUI.AcpTextBox RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001EB RID: 491
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001EC RID: 492
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001ED RID: 493
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001EE RID: 494
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommandComp;

		// Token: 0x040001EF RID: 495
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature;

		// Token: 0x040001F0 RID: 496
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature;

		// Token: 0x040001F1 RID: 497
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature;

		// Token: 0x040001F2 RID: 498
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature;

		// Token: 0x040001F3 RID: 499
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideOptionalComponentCumulativeOverTemperature;

		// Token: 0x040001F4 RID: 500
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideOptionalComponentCumulativeOverTemperatureComp;

		// Token: 0x040001F5 RID: 501
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001F6 RID: 502
		internal global::AcpUI.AcpTextBox RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001F7 RID: 503
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001F8 RID: 504
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001F9 RID: 505
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x040001FA RID: 506
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommandComp;

		// Token: 0x040001FB RID: 507
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideBatteryCumulativeOverTemperature;

		// Token: 0x040001FC RID: 508
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideBatteryCumulativeOverTemperature;

		// Token: 0x040001FD RID: 509
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideBatteryCumulativeOverTemperature;

		// Token: 0x040001FE RID: 510
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideBatteryCumulativeOverTemperature;

		// Token: 0x040001FF RID: 511
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideBatteryCumulativeOverTemperature;

		// Token: 0x04000200 RID: 512
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideBatteryCumulativeOverTemperatureComp;

		// Token: 0x04000201 RID: 513
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x04000202 RID: 514
		internal global::AcpUI.AcpTextBox RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x04000203 RID: 515
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x04000204 RID: 516
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x04000205 RID: 517
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x04000206 RID: 518
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommandComp;

		// Token: 0x04000207 RID: 519
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgVAWideNonHZMAccessory;

		// Token: 0x04000208 RID: 520
		internal global::AcpUI.AcpLabel LblRadErgoCfgVAWideNonHZMAccessory;

		// Token: 0x04000209 RID: 521
		internal global::AcpUI.AcpComboBox RadErgoCfgVAWideNonHZMAccessory;

		// Token: 0x0400020A RID: 522
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgVAWideNonHZMAccessory;

		// Token: 0x0400020B RID: 523
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgVAWideNonHZMAccessory;

		// Token: 0x0400020C RID: 524
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoCfgVAWideNonHZMAccessoryComp;

		// Token: 0x0400020D RID: 525
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand;

		// Token: 0x0400020E RID: 526
		internal global::AcpUI.AcpTextBox RadErgoNonHZMAccessoryAnnouncementVoiceCommand;

		// Token: 0x0400020F RID: 527
		internal global::AcpUITTS.AcpTTSButton TTSBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand;

		// Token: 0x04000210 RID: 528
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand;

		// Token: 0x04000211 RID: 529
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoNonHZMAccessoryAnnouncementVoiceCommand;

		// Token: 0x04000212 RID: 530
		internal global::AcpUI.AcpViewOnlyCtrl RadErgoNonHZMAccessoryAnnouncementVoiceCommandComp;

		// Token: 0x04000213 RID: 531
		private bool b;
	}
}
