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
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x02000061 RID: 97
	public class PageTrunkingWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x0007D394 File Offset: 0x0007B594
		public PageTrunkingWide()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0007D3CC File Offset: 0x0007B5CC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)224329731;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				global::AcpUI.AcpExpander acpExpander;
				switch (num2)
				{
				case 0:
					num = (short)651689985;
					if (num != 0)
					{
					}
					goto IL_264;
				case 1:
					goto IL_2B9;
				case 2:
					try
					{
						num = (short)150274048;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_EC;
								}
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)836894722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)712704006;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1643446276;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								base.Expanders.Add(acpExpander);
								num = (short)976289797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1A0;
							case 6:
								if (acpExpander != null)
								{
									num = (short)618987523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_12D:
							num = (short)725155841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_EC:
							goto IL_12D;
						}
						IL_1A0:
						goto IL_293;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1C1;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1AF:
							switch (num2)
							{
							case 0:
								goto IL_261;
							case 1:
							{
								num = (short)1870048447;
								short num3 = num;
								num = (short)806464703;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)649396224;
									if (num != 0)
									{
									}
									break;
								}
								disposable.Dispose();
								num = (short)364249088;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								if (disposable != null)
								{
									num = (short)553254913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_263;
							}
							goto IL_1C1;
						}
						IL_261:
						IL_263:
						goto EndFinally_7;
						IL_1C1:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)357105666;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1AF;
						EndFinally_7:;
					}
					goto IL_264;
					IL_293:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)147652609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1369047040;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				}
				}
				IL_5F:
				if (!this.a)
				{
					num = (short)558563328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_264:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1198194690;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2B9:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0007D6BC File Offset: 0x0007B8BC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)767754240;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1211262924;
				short num3 = num;
				num = (short)923363276;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)235667457;
					if (num != 0)
					{
					}
					num = (short)1292894208;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_15;
					case 1:
						return;
					case 2:
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)534511617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB;
				}
				IL_15:
				num = (short)315686912;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_CB:
					if (!this.a)
					{
						return;
					}
					num = (short)1756299266;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0007D7E0 File Offset: 0x0007B9E0
		public override void SetDataContext()
		{
			short num = (short)824180736;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 1:
					goto IL_199;
				case 2:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2027);
					num = (short)1831731203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_AF;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)583663621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				case 5:
				{
					num = (short)494338048;
					short num3 = num;
					global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2027);
					goto IL_182;
				}
				case 6:
					goto IL_AF;
				}
				IL_40:
				num = (short)522365951;
				short num4 = num;
				num = (short)662940671;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_182:
					num = (short)855048193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)2126381056;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1117585410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2027);
					num = (short)1445724166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				num = (short)499843076;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_199:
			IL_19B:
			num = (short)95813633;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0007D9B4 File Offset: 0x0007BBB4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2143748096;
			short num2 = num;
			num = (short)790665376;
			short num3 = num;
			num = (short)1342019744;
			switch (num3 == num)
			{
			}
			num = (short)1749745664;
			if (num != 0)
			{
			}
			num = (short)1232666625;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0007DA64 File Offset: 0x0007BC64
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1361313792;
			short num2 = num;
			num = (short)82778514;
			short num3 = num;
			num = (short)1322916242;
			switch (num3 == num)
			{
			}
			num = (short)156958721;
			if (num != 0)
			{
			}
			num = (short)1457324032;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0007DB10 File Offset: 0x0007BD10
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)1995833344;
				short num2 = num;
				if (this.b)
				{
					break;
				}
				num = (short)1713617726;
				short num3 = num;
				num = (short)508148542;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_73;
				}
			}
			return;
			IL_73:
			num = (short)173801473;
			if (num != 0)
			{
			}
			num = (short)43974656;
			if (num != 0)
			{
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﯓ韕듗뛙髛믝臟雡釣铥跧駩ퟫ跭鿯鿱蓳駵雷鿹鋻諽⿿瘁瘃猅昇愉攋怍眏㜑☓☕笗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯ᴱ䀳䐵䴷吹圻圽⸿╁慃瑅硇㵉╋⩍㕏絑⁓⑕ⵗ㑙㝛㝝๟ա፣ཥ౧ཀྵ䉫᙭ᅯάᡳ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0007DBF4 File Offset: 0x0007BDF4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1178337281;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1539899394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_B61;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_55F;
				case 2:
					goto IL_B66;
				case 3:
					goto IL_1279;
				case 4:
					goto IL_1911;
				case 5:
					goto IL_766;
				case 6:
					goto IL_152D;
				case 7:
					goto IL_A78;
				case 8:
					goto IL_6AF;
				case 9:
					goto IL_16EC;
				case 10:
					goto IL_15E7;
				case 11:
					goto IL_1A4A;
				case 12:
					goto IL_DA8;
				case 13:
					goto IL_107C;
				case 14:
					goto IL_13ED;
				case 15:
					goto IL_ECE;
				case 16:
					goto IL_1A8B;
				case 17:
					goto IL_159C;
				case 18:
					goto IL_1751;
				case 19:
					goto IL_E52;
				case 20:
					goto IL_7BE;
				case 21:
					goto IL_12C1;
				case 22:
					goto IL_EDB;
				case 23:
					goto IL_1904;
				case 24:
					goto IL_10D1;
				case 25:
					goto IL_118E;
				case 26:
					goto IL_A47;
				case 27:
					goto IL_1A23;
				case 28:
					goto IL_1102;
				case 29:
					goto IL_1582;
				case 30:
					goto IL_19D8;
				case 31:
					goto IL_103E;
				case 32:
					goto IL_1319;
				case 33:
					goto IL_A9C;
				case 34:
					goto IL_EE8;
				case 35:
					goto IL_4C9;
				case 36:
					goto IL_A6B;
				case 37:
					goto IL_91E;
				case 38:
					goto IL_BF9;
				case 39:
					goto IL_7A4;
				case 40:
					goto IL_10A0;
				case 41:
					goto IL_139F;
				case 42:
					goto IL_5B4;
				case 43:
					goto IL_742;
				case 44:
					goto IL_7E2;
				case 45:
					goto IL_161B;
				case 46:
					goto IL_1248;
				case 47:
					goto IL_1150;
				case 48:
					goto IL_8EA;
				case 49:
					goto IL_13AC;
				case 50:
					goto IL_1860;
				case 51:
					goto IL_590;
				case 52:
					goto IL_10AD;
				case 53:
					goto IL_19CB;
				case 54:
					goto IL_18B9;
				case 55:
					goto IL_1980;
				case 56:
					goto IL_498;
				case 57:
					goto IL_194F;
				case 58:
					goto IL_633;
				case 59:
					goto IL_853;
				case 60:
					goto IL_5C1;
				case 61:
					goto IL_13C6;
				case 62:
					goto IL_122E;
				case 63:
					goto IL_A23;
				case 64:
					goto IL_514;
				case 65:
					goto IL_797;
				case 66:
					goto IL_1697;
				case 67:
					goto IL_695;
				case 68:
					goto IL_688;
				case 69:
					goto IL_F36;
				case 70:
					goto IL_101A;
				case 71:
					goto IL_175E;
				case 72:
					goto IL_F8E;
				case 73:
					goto IL_1713;
				case 74:
					goto IL_DB5;
				case 75:
					goto IL_CE1;
				case 76:
					goto IL_155E;
				case 77:
					goto IL_664;
				case 78:
					goto IL_1129;
				case 79:
					goto IL_1A16;
				case 80:
					goto IL_C72;
				case 81:
					goto IL_1551;
				case 82:
					goto IL_10DE;
				case 83:
					goto IL_60F;
				case 84:
					goto IL_1A30;
				case 85:
					goto IL_1601;
				case 86:
					goto IL_1506;
				case 87:
					goto IL_6E0;
				case 88:
					goto IL_FC2;
				case 89:
					goto IL_904;
				case 90:
					goto IL_BC8;
				case 91:
					goto IL_AF4;
				case 92:
					goto IL_AA9;
				case 93:
					goto IL_1520;
				case 94:
					goto IL_E83;
				case 95:
					goto IL_711;
				case 96:
					goto IL_CEE;
				case 97:
					goto IL_1782;
				case 98:
					goto IL_136E;
				case 99:
					goto IL_F81;
				case 100:
					goto IL_980;
				case 101:
					goto IL_198D;
				case 102:
					goto IL_183C;
				case 103:
					goto IL_1635;
				case 104:
					goto IL_E90;
				case 105:
					goto IL_5F5;
				case 106:
					goto IL_5E8;
				case 107:
					goto IL_18F7;
				case 108:
					goto IL_1628;
				case 109:
					goto IL_95C;
				case 110:
					goto IL_BA4;
				case 111:
					goto IL_98D;
				case 112:
					goto IL_FCF;
				case 113:
					goto IL_9D8;
				case 114:
					goto IL_1A64;
				case 115:
					goto IL_15C3;
				case 116:
					goto IL_E2E;
				case 117:
					goto IL_1411;
				case 118:
					goto IL_B97;
				case 119:
					goto IL_1822;
				case 120:
					goto IL_552;
				case 121:
					goto IL_1466;
				case 122:
					goto IL_9B4;
				case 123:
					goto IL_BEC;
				case 124:
					goto IL_11F0;
				case 125:
					goto IL_6D3;
				case 126:
					goto IL_1143;
				case 127:
					goto IL_EAA;
				case 128:
					goto IL_1442;
				case 129:
					goto IL_167D;
				case 130:
					goto IL_F43;
				case 131:
					goto IL_1706;
				case 132:
					goto IL_1062;
				case 133:
					goto IL_12DB;
				case 134:
					goto IL_B18;
				case 135:
					goto IL_6A2;
				case 136:
					goto IL_1744;
				case 137:
					goto IL_1221;
				case 138:
					goto IL_16F9;
				case 139:
					goto IL_F1C;
				case 140:
					goto IL_CB0;
				case 141:
					goto IL_E0A;
				case 142:
					goto IL_1942;
				case 143:
					goto IL_99A;
				case 144:
					goto IL_182F;
				case 145:
					goto IL_911;
				case 146:
					goto IL_FF6;
				case 147:
					goto IL_B73;
				case 148:
					goto IL_17A6;
				case 149:
					goto IL_A16;
				case 150:
					goto IL_13D3;
				case 151:
					goto IL_11E3;
				case 152:
					goto IL_48B;
				case 153:
					goto IL_94F;
				case 154:
					goto IL_199A;
				case 155:
					goto IL_9E5;
				case 156:
					goto IL_11D6;
				case 157:
					goto IL_1A71;
				case 158:
					goto IL_507;
				case 159:
					goto IL_1136;
				case 160:
					goto IL_D5D;
				case 161:
					goto IL_806;
				case 162:
					goto IL_8F7;
				case 163:
					goto IL_1361;
				case 164:
					goto IL_158F;
				case 165:
					goto IL_C41;
				case 166:
					goto IL_D1F;
				case 167:
					goto IL_C4E;
				case 168:
					goto IL_17FB;
				case 169:
					goto IL_AE7;
				case 170:
					goto IL_19BE;
				case 171:
					goto IL_18EA;
				case 172:
					goto IL_602;
				case 173:
					goto IL_19F2;
				case 174:
					goto IL_137B;
				case 175:
					goto IL_EF5;
				case 176:
					goto IL_D81;
				case 177:
					goto IL_ADA;
				case 178:
					goto IL_F9B;
				case 179:
					goto IL_DC2;
				case 180:
					goto IL_AB6;
				case 181:
					goto IL_D50;
				case 182:
					goto IL_F0F;
				case 183:
					goto IL_4D6;
				case 184:
					goto IL_14EC;
				case 185:
					goto IL_C8C;
				case 186:
					goto IL_16A4;
				case 187:
					goto IL_47E;
				case 188:
					goto IL_D12;
				case 189:
					goto IL_E76;
				case 190:
					goto IL_D8E;
				case 191:
					goto IL_14C8;
				case 192:
					goto IL_16C8;
				case 193:
					goto IL_13B9;
				case 194:
					goto IL_B3C;
				case 195:
					goto IL_160E;
				case 196:
					goto IL_CD4;
				case 197:
					goto IL_11FD;
				case 198:
					goto IL_6ED;
				case 199:
					goto IL_12CE;
				case 200:
					goto IL_86D;
				case 201:
					goto IL_942;
				case 202:
					goto IL_1A3D;
				case 203:
					goto IL_110F;
				case 204:
					goto IL_FE9;
				case 205:
					goto IL_141E;
				case 206:
					goto IL_1659;
				case 207:
					goto IL_15B6;
				case 208:
					goto IL_7B1;
				case 209:
					goto IL_A09;
				case 210:
					goto IL_14F9;
				case 211:
					goto IL_1255;
				case 212:
					goto IL_C1D;
				case 213:
					goto IL_5DB;
				case 214:
					goto IL_1513;
				case 215:
					goto IL_C7F;
				case 216:
					goto IL_123B;
				case 217:
					goto IL_4A5;
				case 218:
					goto IL_148A;
				case 219:
					goto IL_657;
				case 220:
					goto IL_860;
				case 221:
					goto IL_F02;
				case 222:
					goto IL_15A9;
				case 223:
					goto IL_87A;
				case 224:
					goto IL_11B2;
				case 225:
					goto IL_111C;
				case 226:
					goto IL_12FF;
				case 227:
					goto IL_D43;
				case 228:
					goto IL_1935;
				case 229:
					goto IL_71E;
				case 230:
					goto IL_89E;
				case 231:
					goto IL_F50;
				case 232:
					goto IL_538;
				case 233:
					goto IL_1808;
				case 234:
					goto IL_D9B;
				case 235:
					goto IL_1720;
				case 236:
					goto IL_17B3;
				case 237:
					goto IL_19E5;
				case 238:
					goto IL_9A7;
				case 239:
					goto IL_5CE;
				case 240:
					goto IL_1815;
				case 241:
					goto IL_78A;
				case 242:
					goto IL_4E3;
				case 243:
					goto IL_115D;
				case 244:
					goto IL_F29;
				case 245:
					goto IL_106F;
				case 246:
					goto IL_1A57;
				case 247:
					goto IL_FDC;
				case 248:
					goto IL_DE6;
				case 249:
					goto IL_133D;
				case 250:
					goto IL_FA8;
				case 251:
					goto IL_FB5;
				case 252:
					goto IL_1973;
				case 253:
					goto IL_1A7E;
				case 254:
					goto IL_14AE;
				case 255:
					goto IL_168A;
				case 256:
					goto IL_18C6;
				case 257:
					goto IL_F5D;
				case 258:
					goto IL_1181;
				case 259:
					goto IL_545;
				case 260:
					goto IL_15F4;
				case 261:
					goto IL_14BB;
				case 262:
					goto IL_17D7;
				case 263:
					goto IL_129D;
				case 264:
					goto IL_13E0;
				case 265:
					goto IL_E9D;
				case 266:
					goto IL_130C;
				default:
					num = (short)1475411968;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_47E:
			this.RTDBtnTrkWideCAIDataTxLongRandomRangeMs_A9547 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_48B:
			this.GrpBoxExpanderTrunkingWideCAIDataCAIData = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_498:
			this.CVBtnTrkWideFilterConstantsFilterConstantK2_A8115 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A5:
			this.LblTrkWideAdvancedFullSpectrumControlChannelScan_A8161 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedFullSpectrumControlChannelScan_A8161.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C9:
			this.TrkWideGeneralEmergencyBlockedInFailsoft_A7934Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4D6:
			this.TrkWideCAIDataTxShortRandomRangems_A9566Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4E3:
			this.LblTrkWideAdvancedISWWindowAdjustment_A8358 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedISWWindowAdjustment_A8358.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_507:
			this.TrkWideCAIDataMaxTxAttempts_A8475Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_514:
			this.TrkWideFilterConstantsFilterConstantK3_A8116 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideFilterConstantsFilterConstantK3_A8116.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_538:
			this.CpyBtnTrkWideAdvancedInternalRadioHoldoffmin_A8309 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_545:
			this.CpyBtnTrkWideLabtoolDesenseRSSIThreshold_A7827 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_552:
			this.CVBtnTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_55F:
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.PageTrunkingWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.PageTrunkingWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_590:
			this.LblTrkWideFilterConstantsFilterConstantK1_A8114 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideFilterConstantsFilterConstantK1_A8114.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5B4:
			this.CVBtnTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C1:
			this.CpyBtnTrkWideFilterConstantsFilterConstantK2_A8115 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5CE:
			this.TrkWideAdvancedHoldoffDelaysec_A8201Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5DB:
			this.RTDBtnTrkWideAdvancedAffiliationHoldOffsec_A7412 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5E8:
			this.TrkWideRSSIThresholdsDesenseTimer_A7828Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5F5:
			this.CpyBtnTrkWideRSSIThresholdsDesenseTimer_A7828 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_602:
			this.CVBtnTrkWideCAIDataFrameSyncSeekPeriodms_A8146 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_60F:
			this.TrkWideFilterConstantsFilterThresholdConstantT3_A8119 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideFilterConstantsFilterThresholdConstantT3_A8119.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_633:
			this.TrkWideFilterConstantsFilterConstantK2_A8115 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideFilterConstantsFilterConstantK2_A8115.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_657:
			this.RTDBtnTrkWideAdvancedFullSpectrumControlChannelScan_A8161 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_664:
			this.TrkWideFilterConstantsFilterThresholdConstantT2_A8118 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideFilterConstantsFilterThresholdConstantT2_A8118.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_688:
			this.GrpBoxExpanderTrunkingWideFilterConstantsSMARTZoneThresholdConstants = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_695:
			this.TrkWideFilterConstantsFilterConstantK3_A8116Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6A2:
			this.RTDBtnTrkWideRSSIThresholdsStrongSignalRoaming_A24630 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6AF:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_6D3:
			this.TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_6E0:
			this.ExpanderTrunkingWideRSSIThresholds = (global::AcpUI.AcpExpander)target;
			return;
			IL_6ED:
			this.TrkWideCAIDataTxLimitedPatienceSec_A9545 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataTxLimitedPatienceSec_A9545.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_711:
			this.CVBtnTrkWideRSSIThresholdsRSSIOSPCounter_A8994 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_71E:
			this.LblTrkWideAdvancedInternalRadioHoldoffmin_A8309 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedInternalRadioHoldoffmin_A8309.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_742:
			this.LblTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_766:
			this.HLinkRSSIThresholds = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRSSIThresholds.Click += this.HLinkClick;
			return;
			IL_78A:
			this.CVBtnTrkWideAdvancedISWWindowAdjustment_A8358 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_797:
			this.RTDBtnTrkWideFilterConstantsFilterConstantK3_A8116 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7A4:
			this.RTDBtnTrkWideGeneralAFCDisable_A41850 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7B1:
			this.CpyBtnTrkWideAdvancedFailsoftInactivitysec_A8010 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7BE:
			this.TrkWideGeneralPrivateCallMaxInitialRingsec_A8758 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideGeneralPrivateCallMaxInitialRingsec_A8758.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7E2:
			this.TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = (global::AcpUI.AcpCheckBox)target;
			this.TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_806:
			num = (short)1344143360;
			short num3 = num;
			this.TrkWideCAIDataResponseTimerms_A8949 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataResponseTimerms_A8949.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_853:
			this.RTDBtnTrkWideFilterConstantsFilterConstantK2_A8115 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_860:
			this.CpyBtnTrkWideAdvancedFullSpectrumControlChannelScan_A8161 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_86D:
			this.CpyBtnTrkWideCAIDataTxLimitedPatienceSec_A9545 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_87A:
			this.LblTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_89E:
			num = (short)255787009;
			if (num != 0)
			{
			}
			this.TrkWideAdvancedInternalRadioHoldoffmin_A8309 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideAdvancedInternalRadioHoldoffmin_A8309.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8EA:
			this.ExpanderTrunkingWideFilterConstants = (global::AcpUI.AcpExpander)target;
			return;
			IL_8F7:
			this.RTDBtnTrkWideCAIDataResponseTimerms_A8949 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_904:
			this.CVBtnTrkWideRSSIThresholdsRSSIOSWCounter_A8995 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_911:
			this.CVBtnTrkWideSmartConnectRSSIReturnThreshold_43723 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_91E:
			this.LblTrkWideGeneralAFCDisable_A41850 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideGeneralAFCDisable_A41850.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_942:
			this.TrkWideCAIDataTxLimitedPatienceSec_A9545Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_94F:
			this.CVBtnTrkWideCAIDataMaxTxAttempts_A8475 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_95C:
			this.LblTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_980:
			this.TrkWideRSSIThresholdsRSSIOSPCounter_A8994Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_98D:
			this.RTDBtnTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_99A:
			this.CpyBtnTrkWideRSSIBackupPTTFallbackThreshold_A43626 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9A7:
			this.CpyBtnTrkWideAdvancedHoldoffDelaysec_A8201 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9B4:
			this.TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9D8:
			this.TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_9E5:
			this.TrkWideCAIDataMaxTxAttempts_A8475 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataMaxTxAttempts_A8475.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A09:
			this.TrkWideAdvancedFailsoftInactivitysec_A8010Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A16:
			this.CpyBtnTrkWideSmartConnectRSSIReturnThreshold_43723 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A23:
			this.LblTrkWideFilterConstantsFilterConstantK3_A8116 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideFilterConstantsFilterConstantK3_A8116.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A47:
			this.TrkWideGeneralPhoneAutoDialHoldoffms_A7506 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideGeneralPhoneAutoDialHoldoffms_A7506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A6B:
			this.CVBtnTrkWideGeneralAFCDisable_A41850 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A78:
			this.HLinkAdvanced = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAdvanced.Click += this.HLinkClick;
			return;
			IL_A9C:
			this.RTDBtnTrkWideGeneralEmergencyBlockedInFailsoft_A7934 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AA9:
			this.RTDBtnTrkWideRSSIThresholdsRSSIOSWCounter_A8995 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AB6:
			this.TrkWideCAIDataTxShortRandomRangems_A9566 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataTxShortRandomRangems_A9566.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ADA:
			this.TrkWideCAIDataFrameSyncSeekPeriodms_A8146Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AE7:
			this.CpyBtnTrkWideCAIDataMinResponseTimerms_A8515 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AF4:
			this.TrkWideRSSIThresholdsRSSIOSWCounter_A8995 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideRSSIThresholdsRSSIOSWCounter_A8995.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B18:
			this.TrkWideRSSIThresholdsStrongSignalRoaming_A24630 = (global::AcpUI.AcpCheckBox)target;
			this.TrkWideRSSIThresholdsStrongSignalRoaming_A24630.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B3C:
			this.CpyBtnTrkWideCAIDataTxRespRandomRangems_A9564 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B61:
			this.b = true;
			return;
			IL_B66:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_B73:
			this.TrkWideSmartConnectRSSIReturnThreshold_43723 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideSmartConnectRSSIReturnThreshold_43723.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B97:
			this.CpyBtnTrkWideRSSIThresholdsRSSIGoodThreshold_A8992 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BA4:
			this.TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BC8:
			this.LblTrkWideRSSIThresholdsRSSIOSWCounter_A8995 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsRSSIOSWCounter_A8995.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BEC:
			this.RTDBtnTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BF9:
			this.TrkWideGeneralAFCDisable_A41850 = (global::AcpUI.AcpCheckBox)target;
			this.TrkWideGeneralAFCDisable_A41850.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C1D:
			this.TrkWideAdvancedAffiliationHoldOffsec_A7412 = (global::AcpUI.AcpComboBox)target;
			this.TrkWideAdvancedAffiliationHoldOffsec_A7412.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C41:
			this.CVBtnTrkWideCAIDataMinResponseTimerms_A8515 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C4E:
			this.TrkWideCAIDataMinResponseTimerms_A8515 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataMinResponseTimerms_A8515.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C72:
			this.TrkWideFilterConstantsFilterThresholdConstantT2_A8118Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_C7F:
			this.TrkWideAdvancedAffiliationHoldOffsec_A7412Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C8C:
			this.LblTrkWideCAIDataTxLongRandomRangeMs_A9547 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataTxLongRandomRangeMs_A9547.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CB0:
			this.LblTrkWideRSSIBackupPTTFallbackThreshold_A43626 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIBackupPTTFallbackThreshold_A43626.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CD4:
			this.CVBtnTrkWideCAIDataTxLimitedPatienceSec_A9545 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CE1:
			this.CVBtnTrkWideFilterConstantsFilterThresholdConstantT2_A8118 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CEE:
			this.LblTrkWideRSSIThresholdsRSSIOSPCounter_A8994 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsRSSIOSPCounter_A8994.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D12:
			this.CpyBtnTrkWideCAIDataTxLongRandomRangeMs_A9547 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D1F:
			this.LblTrkWideCAIDataMinResponseTimerms_A8515 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataMinResponseTimerms_A8515.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D43:
			this.TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D50:
			this.RTDBtnTrkWideCAIDataTxShortRandomRangems_A9566 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D5D:
			this.LblTrkWideCAIDataResponseTimerms_A8949 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataResponseTimerms_A8949.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D81:
			this.CpyBtnTrkWideCAIDataFrameSyncSeekPeriodms_A8146 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D8E:
			this.CVBtnTrkWideCAIDataTxRespRandomRangems_A9564 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D9B:
			this.CVBtnTrkWideAdvancedHoldoffDelaysec_A8201 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DA8:
			this.CVBtnTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DB5:
			this.TrkWideFilterConstantsFilterThresholdConstantT1_A8117Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_DC2:
			this.LblTrkWideCAIDataTxShortRandomRangems_A9566 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataTxShortRandomRangems_A9566.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DE6:
			this.LblTrkWideAdvancedVirtualPartnerCallActivityTime_A43675 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedVirtualPartnerCallActivityTime_A43675.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E0A:
			this.TrkWideRSSIBackupPTTFallbackThreshold_A43626 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideRSSIBackupPTTFallbackThreshold_A43626.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E2E:
			this.TrkWideRSSIThresholdsRSSIGoodThreshold_A8992 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideRSSIThresholdsRSSIGoodThreshold_A8992.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E52:
			this.LblTrkWideGeneralPrivateCallMaxInitialRingsec_A8758 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideGeneralPrivateCallMaxInitialRingsec_A8758.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E76:
			this.TrkWideCAIDataTxLongRandomRangeMs_A9547Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E83:
			this.TrkWideRSSIThresholdsRSSIOSWCounter_A8995Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E90:
			this.RTDBtnTrkWideRSSIThresholdsDesenseTimer_A7828 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E9D:
			this.CpyBtnTrkWideLabtoolPhase2ScramblingDisable_A37983 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EAA:
			this.LblTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ECE:
			this.RTDBtnTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EDB:
			this.CpyBtnTrkWideGeneralPrivateCallMaxInitialRingsec_A8758 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EE8:
			this.CpyBtnTrkWideGeneralEmergencyBlockedInFailsoft_A7934 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EF5:
			this.RTDBtnTrkWideCAIDataFrameSyncSeekPeriodms_A8146 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F02:
			this.TrkWideAdvancedFullSpectrumControlChannelScan_A8161Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F0F:
			this.CpyBtnTrkWideCAIDataTxShortRandomRangems_A9566 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F1C:
			this.CVBtnTrkWideRSSIBackupPTTFallbackThreshold_A43626 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F29:
			this.RTDBtnTrkWideAdvancedISWWindowAdjustment_A8358 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F36:
			this.CVBtnTrkWideFilterConstantsFilterThresholdConstantT1_A8117 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F43:
			this.CpyBtnTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F50:
			this.RTDBtnTrkWideAdvancedInternalRadioHoldoffmin_A8309 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F5D:
			this.TrkWideLabtoolDesenseRSSIThreshold_A7827 = (global::AcpUI.AcpTextBoxDecHex)target;
			this.TrkWideLabtoolDesenseRSSIThreshold_A7827.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F81:
			this.CpyBtnTrkWideRSSIThresholdsRSSIOSPCounter_A8994 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F8E:
			this.RTDBtnTrkWideFilterConstantsFilterThresholdConstantT1_A8117 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F9B:
			this.CVBtnTrkWideCAIDataTxShortRandomRangems_A9566 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FA8:
			this.RTDBtnTrkWideAdvancedVirtualPartnerCallActivityTime_A43675 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FB5:
			this.CpyBtnTrkWideAdvancedVirtualPartnerCallActivityTime_A43675 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FC2:
			this.GrpBoxExpanderTrunkingWideRSSIThresholdsPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_FCF:
			this.CpyBtnTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FDC:
			this.CVBtnTrkWideAdvancedVirtualPartnerCallActivityTime_A43675 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FE9:
			this.CVBtnTrkWideAdvancedFailsoftInactivitysec_A8010 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FF6:
			this.LblTrkWideSmartConnectRSSIReturnThreshold_43723 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideSmartConnectRSSIReturnThreshold_43723.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_101A:
			this.LblTrkWideFilterConstantsFilterThresholdConstantT1_A8117 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideFilterConstantsFilterThresholdConstantT1_A8117.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_103E:
			this.LblTrkWideGeneralEmergencyBlockedInFailsoft_A7934 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideGeneralEmergencyBlockedInFailsoft_A7934.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1062:
			this.CVBtnTrkWideRSSIThresholdsStrongSignalRoaming_A24630 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_106F:
			this.CpyBtnTrkWideAdvancedISWWindowAdjustment_A8358 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_107C:
			this.LblTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10A0:
			this.CpyBtnTrkWideGeneralAFCDisable_A41850 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10AD:
			this.TrkWideFilterConstantsFilterConstantK1_A8114 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideFilterConstantsFilterConstantK1_A8114.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10D1:
			this.CVBtnTrkWideGeneralPhoneAutoDialHoldoffms_A7506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10DE:
			this.LblTrkWideFilterConstantsFilterThresholdConstantT3_A8119 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideFilterConstantsFilterThresholdConstantT3_A8119.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1102:
			this.CpyBtnTrkWideGeneralPhoneAutoDialHoldoffms_A7506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_110F:
			this.GrpBoxExpanderTrunkingWideAdvancedSMARTZone = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_111C:
			this.RTDBtnTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1129:
			this.RTDBtnTrkWideFilterConstantsFilterThresholdConstantT2_A8118 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1136:
			this.CVBtnTrkWideCAIDataResponseTimerms_A8949 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1143:
			this.CVBtnTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1150:
			this.TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_115D:
			this.TrkWideAdvancedISWWindowAdjustment_A8358 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideAdvancedISWWindowAdjustment_A8358.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1181:
			this.RTDBtnTrkWideLabtoolDesenseRSSIThreshold_A7827 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_118E:
			this.LblTrkWideGeneralPhoneAutoDialHoldoffms_A7506 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideGeneralPhoneAutoDialHoldoffms_A7506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11B2:
			this.TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11D6:
			this.RTDBtnTrkWideCAIDataMaxTxAttempts_A8475 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11E3:
			this.ExpanderTrunkingWideCAIData = (global::AcpUI.AcpExpander)target;
			return;
			IL_11F0:
			this.CpyBtnTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11FD:
			this.LblTrkWideCAIDataTxLimitedPatienceSec_A9545 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataTxLimitedPatienceSec_A9545.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1221:
			this.TrkWideRSSIThresholdsStrongSignalRoaming_A24630Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_122E:
			this.CVBtnTrkWideFilterConstantsFilterConstantK3_A8116 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_123B:
			this.CVBtnTrkWideAdvancedFullSpectrumControlChannelScan_A8161 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1248:
			this.CpyBtnTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1255:
			this.LblTrkWideAdvancedAffiliationHoldOffsec_A7412 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedAffiliationHoldOffsec_A7412.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1279:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_129D:
			this.TrkWideLabtoolPhase2ScramblingDisable_A37983 = (global::AcpUI.AcpCheckBox)target;
			this.TrkWideLabtoolPhase2ScramblingDisable_A37983.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12C1:
			this.RTDBtnTrkWideGeneralPrivateCallMaxInitialRingsec_A8758 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12CE:
			this.RTDBtnTrkWideCAIDataTxLimitedPatienceSec_A9545 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12DB:
			this.LblTrkWideRSSIThresholdsStrongSignalRoaming_A24630 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsStrongSignalRoaming_A24630.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12FF:
			this.CpyBtnTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_130C:
			this.TrkWideLabtoolPhase2ScramblingDisable_A37983Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1319:
			this.TrkWideGeneralEmergencyBlockedInFailsoft_A7934 = (global::AcpUI.AcpCheckBox)target;
			this.TrkWideGeneralEmergencyBlockedInFailsoft_A7934.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_133D:
			this.TrkWideAdvancedVirtualPartnerCallActivityTime_A43675 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideAdvancedVirtualPartnerCallActivityTime_A43675.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1361:
			this.CpyBtnTrkWideCAIDataResponseTimerms_A8949 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_136E:
			this.RTDBtnTrkWideRSSIThresholdsRSSIOSPCounter_A8994 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_137B:
			this.TrkWideCAIDataFrameSyncSeekPeriodms_A8146 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataFrameSyncSeekPeriodms_A8146.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_139F:
			this.TrkWideGeneralAFCDisable_A41850Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_13AC:
			this.GrpBoxExpanderTrunkingWideFilterConstantsSMARTZoneFilterConstants = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_13B9:
			this.RTDBtnTrkWideCAIDataTxRespRandomRangems_A9564 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13C6:
			this.TrkWideFilterConstantsFilterConstantK2_A8115Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_13D3:
			this.TrkWideSmartConnectRSSIReturnThreshold_43723Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_13E0:
			this.RTDBtnTrkWideLabtoolPhase2ScramblingDisable_A37983 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13ED:
			this.TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1411:
			this.RTDBtnTrkWideRSSIThresholdsRSSIGoodThreshold_A8992 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_141E:
			this.LblTrkWideAdvancedFailsoftInactivitysec_A8010 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedFailsoftInactivitysec_A8010.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1442:
			this.TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1466:
			this.LblTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_148A:
			this.TrkWideAdvancedFullSpectrumControlChannelScan_A8161 = (global::AcpUI.AcpCheckBox)target;
			this.TrkWideAdvancedFullSpectrumControlChannelScan_A8161.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14AE:
			this.GrpBoxExpanderTrunkingWideLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_14BB:
			this.CVBtnTrkWideLabtoolPhase2ScramblingDisable_A37983 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14C8:
			this.LblTrkWideCAIDataTxRespRandomRangems_A9564 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataTxRespRandomRangems_A9564.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14EC:
			this.CVBtnTrkWideCAIDataTxLongRandomRangeMs_A9547 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14F9:
			this.CVBtnTrkWideAdvancedAffiliationHoldOffsec_A7412 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1506:
			this.TrkWideFilterConstantsFilterThresholdConstantT3_A8119Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_1513:
			this.CpyBtnTrkWideAdvancedAffiliationHoldOffsec_A7412 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1520:
			this.CpyBtnTrkWideRSSIThresholdsRSSIOSWCounter_A8995 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_152D:
			this.HLinkCAIData = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkCAIData.Click += this.HLinkClick;
			return;
			IL_1551:
			this.CVBtnTrkWideFilterConstantsFilterThresholdConstantT3_A8119 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_155E:
			this.LblTrkWideFilterConstantsFilterThresholdConstantT2_A8118 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideFilterConstantsFilterThresholdConstantT2_A8118.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1582:
			this.TrkWideGeneralPhoneAutoDialHoldoffms_A7506Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_158F:
			this.TrkWideCAIDataResponseTimerms_A8949Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_159C:
			this.TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_15A9:
			this.CVBtnTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15B6:
			this.RTDBtnTrkWideAdvancedFailsoftInactivitysec_A8010 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15C3:
			this.LblTrkWideRSSIThresholdsRSSIGoodThreshold_A8992 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsRSSIGoodThreshold_A8992.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15E7:
			this.ExpanderTrunkingWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_15F4:
			this.TrkWideLabtoolDesenseRSSIThreshold_A7827Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_1601:
			this.CpyBtnTrkWideFilterConstantsFilterThresholdConstantT3_A8119 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_160E:
			this.TrkWideCAIDataTxRespRandomRangems_A9564Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_161B:
			this.RTDBtnTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1628:
			this.CVBtnTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1635:
			this.TrkWideRSSIThresholdsDesenseTimer_A7828 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideRSSIThresholdsDesenseTimer_A7828.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1659:
			this.TrkWideAdvancedFailsoftInactivitysec_A8010 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideAdvancedFailsoftInactivitysec_A8010.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_167D:
			this.RTDBtnTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_168A:
			this.CVBtnTrkWideLabtoolDesenseRSSIThreshold_A7827 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1697:
			this.CpyBtnTrkWideFilterConstantsFilterConstantK3_A8116 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16A4:
			this.TrkWideCAIDataTxLongRandomRangeMs_A9547 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataTxLongRandomRangeMs_A9547.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16C8:
			this.TrkWideCAIDataTxRespRandomRangems_A9564 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideCAIDataTxRespRandomRangems_A9564.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16EC:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_16F9:
			this.GrpBoxExpanderTrunkingWideRSSIThresholdsSMARTConnectRSSIThresholds = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1706:
			this.TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_1713:
			this.CpyBtnTrkWideFilterConstantsFilterThresholdConstantT1_A8117 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1720:
			this.LblTrkWideAdvancedHoldoffDelaysec_A8201 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideAdvancedHoldoffDelaysec_A8201.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1744:
			this.CpyBtnTrkWideRSSIThresholdsStrongSignalRoaming_A24630 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1751:
			this.CVBtnTrkWideGeneralPrivateCallMaxInitialRingsec_A8758 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_175E:
			this.TrkWideFilterConstantsFilterThresholdConstantT1_A8117 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkWideFilterConstantsFilterThresholdConstantT1_A8117.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1782:
			this.TrkWideRSSIThresholdsRSSIOSPCounter_A8994 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideRSSIThresholdsRSSIOSPCounter_A8994.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17A6:
			this.RTDBtnTrkWideSmartConnectRSSIReturnThreshold_43723 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17B3:
			this.TrkWideAdvancedHoldoffDelaysec_A8201 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkWideAdvancedHoldoffDelaysec_A8201.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17D7:
			this.LblTrkWideLabtoolPhase2ScramblingDisable_A37983 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideLabtoolPhase2ScramblingDisable_A37983.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17FB:
			this.RTDBtnTrkWideCAIDataMinResponseTimerms_A8515 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1808:
			this.TrkWideAdvancedInternalRadioHoldoffmin_A8309Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1815:
			this.GrpBoxExpanderTrunkingWideAdvancedPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1822:
			this.TrkWideRSSIThresholdsRSSIGoodThreshold_A8992Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_182F:
			this.TrkWideRSSIBackupPTTFallbackThreshold_A43626Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_183C:
			this.LblTrkWideRSSIThresholdsDesenseTimer_A7828 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideRSSIThresholdsDesenseTimer_A7828.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1860:
			num = (short)1360173953;
			short num4 = num;
			num = (short)1983814529;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_47E;
			default:
				num = (short)118816768;
				if (num != 0)
				{
				}
				this.CVBtnTrkWideFilterConstantsFilterConstantK1_A8114 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_18B9:
			this.CpyBtnTrkWideFilterConstantsFilterConstantK1_A8114 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18C6:
			this.LblTrkWideLabtoolDesenseRSSIThreshold_A7827 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideLabtoolDesenseRSSIThreshold_A7827.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18EA:
			this.GrpBoxExpanderTrunkingWideCAIDataPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18F7:
			this.GrpBoxExpanderTrunkingWideRSSIThresholdsSMARTZoneRSSIThresholds = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1904:
			this.TrkWideGeneralPrivateCallMaxInitialRingsec_A8758Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1911:
			this.HLinkFilterConstants = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFilterConstants.Click += this.HLinkClick;
			return;
			IL_1935:
			this.CVBtnTrkWideAdvancedInternalRadioHoldoffmin_A8309 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1942:
			this.RTDBtnTrkWideRSSIBackupPTTFallbackThreshold_A43626 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_194F:
			this.LblTrkWideFilterConstantsFilterConstantK2_A8115 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideFilterConstantsFilterConstantK2_A8115.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1973:
			this.TrkWideAdvancedVirtualPartnerCallActivityTime_A43675Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1980:
			this.TrkWideFilterConstantsFilterConstantK1_A8114Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_198D:
			this.CVBtnTrkWideRSSIThresholdsDesenseTimer_A7828 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_199A:
			this.LblTrkWideCAIDataMaxTxAttempts_A8475 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataMaxTxAttempts_A8475.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_19BE:
			this.TrkWideCAIDataMinResponseTimerms_A8515Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19CB:
			this.RTDBtnTrkWideFilterConstantsFilterConstantK1_A8114 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19D8:
			this.CVBtnTrkWideGeneralEmergencyBlockedInFailsoft_A7934 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19E5:
			this.RTDBtnTrkWideAdvancedHoldoffDelaysec_A8201 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19F2:
			this.LblTrkWideCAIDataFrameSyncSeekPeriodms_A8146 = (global::AcpUI.AcpLabel)target;
			this.LblTrkWideCAIDataFrameSyncSeekPeriodms_A8146.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A16:
			this.CpyBtnTrkWideFilterConstantsFilterThresholdConstantT2_A8118 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A23:
			this.RTDBtnTrkWideGeneralPhoneAutoDialHoldoffms_A7506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A30:
			this.RTDBtnTrkWideFilterConstantsFilterThresholdConstantT3_A8119 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A3D:
			this.ExpanderTrunkingWideAdvanced = (global::AcpUI.AcpExpander)target;
			return;
			IL_1A4A:
			this.GrpBoxExpanderTrunkingWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1A57:
			this.TrkWideAdvancedISWWindowAdjustment_A8358Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_1A64:
			this.CVBtnTrkWideRSSIThresholdsRSSIGoodThreshold_A8992 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A71:
			this.CpyBtnTrkWideCAIDataMaxTxAttempts_A8475 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A7E:
			this.ExpanderTrunkingWideLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_1A8B:
			this.CpyBtnTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = (global::AcpUI.AcpCopyButton)target;
		}

		// Token: 0x04000219 RID: 537
		private bool a;

		// Token: 0x0400021A RID: 538
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400021B RID: 539
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400021C RID: 540
		internal global::System.Windows.Documents.Hyperlink HLinkFilterConstants;

		// Token: 0x0400021D RID: 541
		internal global::System.Windows.Documents.Hyperlink HLinkRSSIThresholds;

		// Token: 0x0400021E RID: 542
		internal global::System.Windows.Documents.Hyperlink HLinkCAIData;

		// Token: 0x0400021F RID: 543
		internal global::System.Windows.Documents.Hyperlink HLinkAdvanced;

		// Token: 0x04000220 RID: 544
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04000221 RID: 545
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000222 RID: 546
		internal global::AcpUI.AcpExpander ExpanderTrunkingWideGeneral;

		// Token: 0x04000223 RID: 547
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideGeneralPseudo0;

		// Token: 0x04000224 RID: 548
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;

		// Token: 0x04000225 RID: 549
		internal global::AcpUI.AcpLabel LblTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;

		// Token: 0x04000226 RID: 550
		internal global::AcpUI.AcpTextBoxSpinner TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;

		// Token: 0x04000227 RID: 551
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;

		// Token: 0x04000228 RID: 552
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;

		// Token: 0x04000229 RID: 553
		internal global::AcpUI.AcpLabel TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290Comp;

		// Token: 0x0400022A RID: 554
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideGeneralPrivateCallMaxInitialRingsec_A8758;

		// Token: 0x0400022B RID: 555
		internal global::AcpUI.AcpLabel LblTrkWideGeneralPrivateCallMaxInitialRingsec_A8758;

		// Token: 0x0400022C RID: 556
		internal global::AcpUI.AcpTextBoxSpinner TrkWideGeneralPrivateCallMaxInitialRingsec_A8758;

		// Token: 0x0400022D RID: 557
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideGeneralPrivateCallMaxInitialRingsec_A8758;

		// Token: 0x0400022E RID: 558
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideGeneralPrivateCallMaxInitialRingsec_A8758;

		// Token: 0x0400022F RID: 559
		internal global::AcpUI.AcpLabel TrkWideGeneralPrivateCallMaxInitialRingsec_A8758Comp;

		// Token: 0x04000230 RID: 560
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideGeneralPhoneAutoDialHoldoffms_A7506;

		// Token: 0x04000231 RID: 561
		internal global::AcpUI.AcpLabel LblTrkWideGeneralPhoneAutoDialHoldoffms_A7506;

		// Token: 0x04000232 RID: 562
		internal global::AcpUI.AcpTextBoxSpinner TrkWideGeneralPhoneAutoDialHoldoffms_A7506;

		// Token: 0x04000233 RID: 563
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideGeneralPhoneAutoDialHoldoffms_A7506;

		// Token: 0x04000234 RID: 564
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideGeneralPhoneAutoDialHoldoffms_A7506;

		// Token: 0x04000235 RID: 565
		internal global::AcpUI.AcpLabel TrkWideGeneralPhoneAutoDialHoldoffms_A7506Comp;

		// Token: 0x04000236 RID: 566
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideGeneralEmergencyBlockedInFailsoft_A7934;

		// Token: 0x04000237 RID: 567
		internal global::AcpUI.AcpLabel LblTrkWideGeneralEmergencyBlockedInFailsoft_A7934;

		// Token: 0x04000238 RID: 568
		internal global::AcpUI.AcpCheckBox TrkWideGeneralEmergencyBlockedInFailsoft_A7934;

		// Token: 0x04000239 RID: 569
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideGeneralEmergencyBlockedInFailsoft_A7934;

		// Token: 0x0400023A RID: 570
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideGeneralEmergencyBlockedInFailsoft_A7934;

		// Token: 0x0400023B RID: 571
		internal global::AcpUI.AcpCheckBox TrkWideGeneralEmergencyBlockedInFailsoft_A7934Comp;

		// Token: 0x0400023C RID: 572
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideGeneralAFCDisable_A41850;

		// Token: 0x0400023D RID: 573
		internal global::AcpUI.AcpLabel LblTrkWideGeneralAFCDisable_A41850;

		// Token: 0x0400023E RID: 574
		internal global::AcpUI.AcpCheckBox TrkWideGeneralAFCDisable_A41850;

		// Token: 0x0400023F RID: 575
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideGeneralAFCDisable_A41850;

		// Token: 0x04000240 RID: 576
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideGeneralAFCDisable_A41850;

		// Token: 0x04000241 RID: 577
		internal global::AcpUI.AcpCheckBox TrkWideGeneralAFCDisable_A41850Comp;

		// Token: 0x04000242 RID: 578
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;

		// Token: 0x04000243 RID: 579
		internal global::AcpUI.AcpLabel LblTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;

		// Token: 0x04000244 RID: 580
		internal global::AcpUI.AcpCheckBox TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;

		// Token: 0x04000245 RID: 581
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;

		// Token: 0x04000246 RID: 582
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;

		// Token: 0x04000247 RID: 583
		internal global::AcpUI.AcpCheckBox TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447Comp;

		// Token: 0x04000248 RID: 584
		internal global::AcpUI.AcpExpander ExpanderTrunkingWideFilterConstants;

		// Token: 0x04000249 RID: 585
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideFilterConstantsSMARTZoneFilterConstants;

		// Token: 0x0400024A RID: 586
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideFilterConstantsFilterConstantK1_A8114;

		// Token: 0x0400024B RID: 587
		internal global::AcpUI.AcpLabel LblTrkWideFilterConstantsFilterConstantK1_A8114;

		// Token: 0x0400024C RID: 588
		internal global::AcpUI.AcpTextBoxSpinner TrkWideFilterConstantsFilterConstantK1_A8114;

		// Token: 0x0400024D RID: 589
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideFilterConstantsFilterConstantK1_A8114;

		// Token: 0x0400024E RID: 590
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideFilterConstantsFilterConstantK1_A8114;

		// Token: 0x0400024F RID: 591
		internal global::AcpUI.AcpLabel TrkWideFilterConstantsFilterConstantK1_A8114Comp;

		// Token: 0x04000250 RID: 592
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideFilterConstantsFilterConstantK2_A8115;

		// Token: 0x04000251 RID: 593
		internal global::AcpUI.AcpLabel LblTrkWideFilterConstantsFilterConstantK2_A8115;

		// Token: 0x04000252 RID: 594
		internal global::AcpUI.AcpTextBoxSpinner TrkWideFilterConstantsFilterConstantK2_A8115;

		// Token: 0x04000253 RID: 595
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideFilterConstantsFilterConstantK2_A8115;

		// Token: 0x04000254 RID: 596
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideFilterConstantsFilterConstantK2_A8115;

		// Token: 0x04000255 RID: 597
		internal global::AcpUI.AcpLabel TrkWideFilterConstantsFilterConstantK2_A8115Comp;

		// Token: 0x04000256 RID: 598
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideFilterConstantsFilterConstantK3_A8116;

		// Token: 0x04000257 RID: 599
		internal global::AcpUI.AcpLabel LblTrkWideFilterConstantsFilterConstantK3_A8116;

		// Token: 0x04000258 RID: 600
		internal global::AcpUI.AcpTextBoxSpinner TrkWideFilterConstantsFilterConstantK3_A8116;

		// Token: 0x04000259 RID: 601
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideFilterConstantsFilterConstantK3_A8116;

		// Token: 0x0400025A RID: 602
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideFilterConstantsFilterConstantK3_A8116;

		// Token: 0x0400025B RID: 603
		internal global::AcpUI.AcpLabel TrkWideFilterConstantsFilterConstantK3_A8116Comp;

		// Token: 0x0400025C RID: 604
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideFilterConstantsSMARTZoneThresholdConstants;

		// Token: 0x0400025D RID: 605
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideFilterConstantsFilterThresholdConstantT1_A8117;

		// Token: 0x0400025E RID: 606
		internal global::AcpUI.AcpLabel LblTrkWideFilterConstantsFilterThresholdConstantT1_A8117;

		// Token: 0x0400025F RID: 607
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideFilterConstantsFilterThresholdConstantT1_A8117;

		// Token: 0x04000260 RID: 608
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideFilterConstantsFilterThresholdConstantT1_A8117;

		// Token: 0x04000261 RID: 609
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideFilterConstantsFilterThresholdConstantT1_A8117;

		// Token: 0x04000262 RID: 610
		internal global::AcpUI.AcpTextBoxDecHex TrkWideFilterConstantsFilterThresholdConstantT1_A8117Comp;

		// Token: 0x04000263 RID: 611
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideFilterConstantsFilterThresholdConstantT2_A8118;

		// Token: 0x04000264 RID: 612
		internal global::AcpUI.AcpLabel LblTrkWideFilterConstantsFilterThresholdConstantT2_A8118;

		// Token: 0x04000265 RID: 613
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideFilterConstantsFilterThresholdConstantT2_A8118;

		// Token: 0x04000266 RID: 614
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideFilterConstantsFilterThresholdConstantT2_A8118;

		// Token: 0x04000267 RID: 615
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideFilterConstantsFilterThresholdConstantT2_A8118;

		// Token: 0x04000268 RID: 616
		internal global::AcpUI.AcpTextBoxDecHex TrkWideFilterConstantsFilterThresholdConstantT2_A8118Comp;

		// Token: 0x04000269 RID: 617
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideFilterConstantsFilterThresholdConstantT3_A8119;

		// Token: 0x0400026A RID: 618
		internal global::AcpUI.AcpLabel LblTrkWideFilterConstantsFilterThresholdConstantT3_A8119;

		// Token: 0x0400026B RID: 619
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideFilterConstantsFilterThresholdConstantT3_A8119;

		// Token: 0x0400026C RID: 620
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideFilterConstantsFilterThresholdConstantT3_A8119;

		// Token: 0x0400026D RID: 621
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideFilterConstantsFilterThresholdConstantT3_A8119;

		// Token: 0x0400026E RID: 622
		internal global::AcpUI.AcpTextBoxDecHex TrkWideFilterConstantsFilterThresholdConstantT3_A8119Comp;

		// Token: 0x0400026F RID: 623
		internal global::AcpUI.AcpExpander ExpanderTrunkingWideRSSIThresholds;

		// Token: 0x04000270 RID: 624
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideRSSIThresholdsPseudo0;

		// Token: 0x04000271 RID: 625
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsRSSIOSWCounter_A8995;

		// Token: 0x04000272 RID: 626
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsRSSIOSWCounter_A8995;

		// Token: 0x04000273 RID: 627
		internal global::AcpUI.AcpTextBoxSpinner TrkWideRSSIThresholdsRSSIOSWCounter_A8995;

		// Token: 0x04000274 RID: 628
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsRSSIOSWCounter_A8995;

		// Token: 0x04000275 RID: 629
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsRSSIOSWCounter_A8995;

		// Token: 0x04000276 RID: 630
		internal global::AcpUI.AcpLabel TrkWideRSSIThresholdsRSSIOSWCounter_A8995Comp;

		// Token: 0x04000277 RID: 631
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsRSSIOSPCounter_A8994;

		// Token: 0x04000278 RID: 632
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsRSSIOSPCounter_A8994;

		// Token: 0x04000279 RID: 633
		internal global::AcpUI.AcpTextBoxSpinner TrkWideRSSIThresholdsRSSIOSPCounter_A8994;

		// Token: 0x0400027A RID: 634
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsRSSIOSPCounter_A8994;

		// Token: 0x0400027B RID: 635
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsRSSIOSPCounter_A8994;

		// Token: 0x0400027C RID: 636
		internal global::AcpUI.AcpLabel TrkWideRSSIThresholdsRSSIOSPCounter_A8994Comp;

		// Token: 0x0400027D RID: 637
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsDesenseTimer_A7828;

		// Token: 0x0400027E RID: 638
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsDesenseTimer_A7828;

		// Token: 0x0400027F RID: 639
		internal global::AcpUI.AcpTextBoxSpinner TrkWideRSSIThresholdsDesenseTimer_A7828;

		// Token: 0x04000280 RID: 640
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsDesenseTimer_A7828;

		// Token: 0x04000281 RID: 641
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsDesenseTimer_A7828;

		// Token: 0x04000282 RID: 642
		internal global::AcpUI.AcpLabel TrkWideRSSIThresholdsDesenseTimer_A7828Comp;

		// Token: 0x04000283 RID: 643
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideRSSIThresholdsSMARTZoneRSSIThresholds;

		// Token: 0x04000284 RID: 644
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;

		// Token: 0x04000285 RID: 645
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;

		// Token: 0x04000286 RID: 646
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;

		// Token: 0x04000287 RID: 647
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;

		// Token: 0x04000288 RID: 648
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;

		// Token: 0x04000289 RID: 649
		internal global::AcpUI.AcpTextBoxDecHex TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989Comp;

		// Token: 0x0400028A RID: 650
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsRSSIGoodThreshold_A8992;

		// Token: 0x0400028B RID: 651
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsRSSIGoodThreshold_A8992;

		// Token: 0x0400028C RID: 652
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideRSSIThresholdsRSSIGoodThreshold_A8992;

		// Token: 0x0400028D RID: 653
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsRSSIGoodThreshold_A8992;

		// Token: 0x0400028E RID: 654
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsRSSIGoodThreshold_A8992;

		// Token: 0x0400028F RID: 655
		internal global::AcpUI.AcpTextBoxDecHex TrkWideRSSIThresholdsRSSIGoodThreshold_A8992Comp;

		// Token: 0x04000290 RID: 656
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;

		// Token: 0x04000291 RID: 657
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;

		// Token: 0x04000292 RID: 658
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;

		// Token: 0x04000293 RID: 659
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;

		// Token: 0x04000294 RID: 660
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;

		// Token: 0x04000295 RID: 661
		internal global::AcpUI.AcpTextBoxDecHex TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996Comp;

		// Token: 0x04000296 RID: 662
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991;

		// Token: 0x04000297 RID: 663
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991;

		// Token: 0x04000298 RID: 664
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991;

		// Token: 0x04000299 RID: 665
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991;

		// Token: 0x0400029A RID: 666
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsRSSIExcellentThreshold_A8991;

		// Token: 0x0400029B RID: 667
		internal global::AcpUI.AcpTextBoxDecHex TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991Comp;

		// Token: 0x0400029C RID: 668
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIThresholdsStrongSignalRoaming_A24630;

		// Token: 0x0400029D RID: 669
		internal global::AcpUI.AcpLabel LblTrkWideRSSIThresholdsStrongSignalRoaming_A24630;

		// Token: 0x0400029E RID: 670
		internal global::AcpUI.AcpCheckBox TrkWideRSSIThresholdsStrongSignalRoaming_A24630;

		// Token: 0x0400029F RID: 671
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIThresholdsStrongSignalRoaming_A24630;

		// Token: 0x040002A0 RID: 672
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIThresholdsStrongSignalRoaming_A24630;

		// Token: 0x040002A1 RID: 673
		internal global::AcpUI.AcpCheckBox TrkWideRSSIThresholdsStrongSignalRoaming_A24630Comp;

		// Token: 0x040002A2 RID: 674
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideRSSIThresholdsSMARTConnectRSSIThresholds;

		// Token: 0x040002A3 RID: 675
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideRSSIBackupPTTFallbackThreshold_A43626;

		// Token: 0x040002A4 RID: 676
		internal global::AcpUI.AcpLabel LblTrkWideRSSIBackupPTTFallbackThreshold_A43626;

		// Token: 0x040002A5 RID: 677
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideRSSIBackupPTTFallbackThreshold_A43626;

		// Token: 0x040002A6 RID: 678
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideRSSIBackupPTTFallbackThreshold_A43626;

		// Token: 0x040002A7 RID: 679
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideRSSIBackupPTTFallbackThreshold_A43626;

		// Token: 0x040002A8 RID: 680
		internal global::AcpUI.AcpTextBoxDecHex TrkWideRSSIBackupPTTFallbackThreshold_A43626Comp;

		// Token: 0x040002A9 RID: 681
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideSmartConnectRSSIReturnThreshold_43723;

		// Token: 0x040002AA RID: 682
		internal global::AcpUI.AcpLabel LblTrkWideSmartConnectRSSIReturnThreshold_43723;

		// Token: 0x040002AB RID: 683
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideSmartConnectRSSIReturnThreshold_43723;

		// Token: 0x040002AC RID: 684
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideSmartConnectRSSIReturnThreshold_43723;

		// Token: 0x040002AD RID: 685
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideSmartConnectRSSIReturnThreshold_43723;

		// Token: 0x040002AE RID: 686
		internal global::AcpUI.AcpTextBoxDecHex TrkWideSmartConnectRSSIReturnThreshold_43723Comp;

		// Token: 0x040002AF RID: 687
		internal global::AcpUI.AcpExpander ExpanderTrunkingWideCAIData;

		// Token: 0x040002B0 RID: 688
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideCAIDataCAIData;

		// Token: 0x040002B1 RID: 689
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataMaxTxAttempts_A8475;

		// Token: 0x040002B2 RID: 690
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataMaxTxAttempts_A8475;

		// Token: 0x040002B3 RID: 691
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataMaxTxAttempts_A8475;

		// Token: 0x040002B4 RID: 692
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataMaxTxAttempts_A8475;

		// Token: 0x040002B5 RID: 693
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataMaxTxAttempts_A8475;

		// Token: 0x040002B6 RID: 694
		internal global::AcpUI.AcpLabel TrkWideCAIDataMaxTxAttempts_A8475Comp;

		// Token: 0x040002B7 RID: 695
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataResponseTimerms_A8949;

		// Token: 0x040002B8 RID: 696
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataResponseTimerms_A8949;

		// Token: 0x040002B9 RID: 697
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataResponseTimerms_A8949;

		// Token: 0x040002BA RID: 698
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataResponseTimerms_A8949;

		// Token: 0x040002BB RID: 699
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataResponseTimerms_A8949;

		// Token: 0x040002BC RID: 700
		internal global::AcpUI.AcpLabel TrkWideCAIDataResponseTimerms_A8949Comp;

		// Token: 0x040002BD RID: 701
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataMinResponseTimerms_A8515;

		// Token: 0x040002BE RID: 702
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataMinResponseTimerms_A8515;

		// Token: 0x040002BF RID: 703
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataMinResponseTimerms_A8515;

		// Token: 0x040002C0 RID: 704
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataMinResponseTimerms_A8515;

		// Token: 0x040002C1 RID: 705
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataMinResponseTimerms_A8515;

		// Token: 0x040002C2 RID: 706
		internal global::AcpUI.AcpLabel TrkWideCAIDataMinResponseTimerms_A8515Comp;

		// Token: 0x040002C3 RID: 707
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideCAIDataPseudo1;

		// Token: 0x040002C4 RID: 708
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataFrameSyncSeekPeriodms_A8146;

		// Token: 0x040002C5 RID: 709
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataFrameSyncSeekPeriodms_A8146;

		// Token: 0x040002C6 RID: 710
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataFrameSyncSeekPeriodms_A8146;

		// Token: 0x040002C7 RID: 711
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataFrameSyncSeekPeriodms_A8146;

		// Token: 0x040002C8 RID: 712
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataFrameSyncSeekPeriodms_A8146;

		// Token: 0x040002C9 RID: 713
		internal global::AcpUI.AcpLabel TrkWideCAIDataFrameSyncSeekPeriodms_A8146Comp;

		// Token: 0x040002CA RID: 714
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataTxShortRandomRangems_A9566;

		// Token: 0x040002CB RID: 715
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataTxShortRandomRangems_A9566;

		// Token: 0x040002CC RID: 716
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataTxShortRandomRangems_A9566;

		// Token: 0x040002CD RID: 717
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataTxShortRandomRangems_A9566;

		// Token: 0x040002CE RID: 718
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataTxShortRandomRangems_A9566;

		// Token: 0x040002CF RID: 719
		internal global::AcpUI.AcpLabel TrkWideCAIDataTxShortRandomRangems_A9566Comp;

		// Token: 0x040002D0 RID: 720
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataTxLongRandomRangeMs_A9547;

		// Token: 0x040002D1 RID: 721
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataTxLongRandomRangeMs_A9547;

		// Token: 0x040002D2 RID: 722
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataTxLongRandomRangeMs_A9547;

		// Token: 0x040002D3 RID: 723
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataTxLongRandomRangeMs_A9547;

		// Token: 0x040002D4 RID: 724
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataTxLongRandomRangeMs_A9547;

		// Token: 0x040002D5 RID: 725
		internal global::AcpUI.AcpLabel TrkWideCAIDataTxLongRandomRangeMs_A9547Comp;

		// Token: 0x040002D6 RID: 726
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataTxRespRandomRangems_A9564;

		// Token: 0x040002D7 RID: 727
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataTxRespRandomRangems_A9564;

		// Token: 0x040002D8 RID: 728
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataTxRespRandomRangems_A9564;

		// Token: 0x040002D9 RID: 729
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataTxRespRandomRangems_A9564;

		// Token: 0x040002DA RID: 730
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataTxRespRandomRangems_A9564;

		// Token: 0x040002DB RID: 731
		internal global::AcpUI.AcpLabel TrkWideCAIDataTxRespRandomRangems_A9564Comp;

		// Token: 0x040002DC RID: 732
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideCAIDataTxLimitedPatienceSec_A9545;

		// Token: 0x040002DD RID: 733
		internal global::AcpUI.AcpLabel LblTrkWideCAIDataTxLimitedPatienceSec_A9545;

		// Token: 0x040002DE RID: 734
		internal global::AcpUI.AcpTextBoxSpinner TrkWideCAIDataTxLimitedPatienceSec_A9545;

		// Token: 0x040002DF RID: 735
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideCAIDataTxLimitedPatienceSec_A9545;

		// Token: 0x040002E0 RID: 736
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideCAIDataTxLimitedPatienceSec_A9545;

		// Token: 0x040002E1 RID: 737
		internal global::AcpUI.AcpLabel TrkWideCAIDataTxLimitedPatienceSec_A9545Comp;

		// Token: 0x040002E2 RID: 738
		internal global::AcpUI.AcpExpander ExpanderTrunkingWideAdvanced;

		// Token: 0x040002E3 RID: 739
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideAdvancedSMARTZone;

		// Token: 0x040002E4 RID: 740
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedFailsoftInactivitysec_A8010;

		// Token: 0x040002E5 RID: 741
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedFailsoftInactivitysec_A8010;

		// Token: 0x040002E6 RID: 742
		internal global::AcpUI.AcpTextBoxSpinner TrkWideAdvancedFailsoftInactivitysec_A8010;

		// Token: 0x040002E7 RID: 743
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedFailsoftInactivitysec_A8010;

		// Token: 0x040002E8 RID: 744
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedFailsoftInactivitysec_A8010;

		// Token: 0x040002E9 RID: 745
		internal global::AcpUI.AcpLabel TrkWideAdvancedFailsoftInactivitysec_A8010Comp;

		// Token: 0x040002EA RID: 746
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedAffiliationHoldOffsec_A7412;

		// Token: 0x040002EB RID: 747
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedAffiliationHoldOffsec_A7412;

		// Token: 0x040002EC RID: 748
		internal global::AcpUI.AcpComboBox TrkWideAdvancedAffiliationHoldOffsec_A7412;

		// Token: 0x040002ED RID: 749
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedAffiliationHoldOffsec_A7412;

		// Token: 0x040002EE RID: 750
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedAffiliationHoldOffsec_A7412;

		// Token: 0x040002EF RID: 751
		internal global::AcpUI.AcpLabel TrkWideAdvancedAffiliationHoldOffsec_A7412Comp;

		// Token: 0x040002F0 RID: 752
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedFullSpectrumControlChannelScan_A8161;

		// Token: 0x040002F1 RID: 753
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedFullSpectrumControlChannelScan_A8161;

		// Token: 0x040002F2 RID: 754
		internal global::AcpUI.AcpCheckBox TrkWideAdvancedFullSpectrumControlChannelScan_A8161;

		// Token: 0x040002F3 RID: 755
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedFullSpectrumControlChannelScan_A8161;

		// Token: 0x040002F4 RID: 756
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedFullSpectrumControlChannelScan_A8161;

		// Token: 0x040002F5 RID: 757
		internal global::AcpUI.AcpCheckBox TrkWideAdvancedFullSpectrumControlChannelScan_A8161Comp;

		// Token: 0x040002F6 RID: 758
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;

		// Token: 0x040002F7 RID: 759
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;

		// Token: 0x040002F8 RID: 760
		internal global::AcpUI.AcpTextBoxSpinner TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;

		// Token: 0x040002F9 RID: 761
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;

		// Token: 0x040002FA RID: 762
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;

		// Token: 0x040002FB RID: 763
		internal global::AcpUI.AcpLabel TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162Comp;

		// Token: 0x040002FC RID: 764
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedInternalRadioHoldoffmin_A8309;

		// Token: 0x040002FD RID: 765
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedInternalRadioHoldoffmin_A8309;

		// Token: 0x040002FE RID: 766
		internal global::AcpUI.AcpTextBoxSpinner TrkWideAdvancedInternalRadioHoldoffmin_A8309;

		// Token: 0x040002FF RID: 767
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedInternalRadioHoldoffmin_A8309;

		// Token: 0x04000300 RID: 768
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedInternalRadioHoldoffmin_A8309;

		// Token: 0x04000301 RID: 769
		internal global::AcpUI.AcpLabel TrkWideAdvancedInternalRadioHoldoffmin_A8309Comp;

		// Token: 0x04000302 RID: 770
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedHoldoffDelaysec_A8201;

		// Token: 0x04000303 RID: 771
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedHoldoffDelaysec_A8201;

		// Token: 0x04000304 RID: 772
		internal global::AcpUI.AcpTextBoxSpinner TrkWideAdvancedHoldoffDelaysec_A8201;

		// Token: 0x04000305 RID: 773
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedHoldoffDelaysec_A8201;

		// Token: 0x04000306 RID: 774
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedHoldoffDelaysec_A8201;

		// Token: 0x04000307 RID: 775
		internal global::AcpUI.AcpLabel TrkWideAdvancedHoldoffDelaysec_A8201Comp;

		// Token: 0x04000308 RID: 776
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideAdvancedPseudo1;

		// Token: 0x04000309 RID: 777
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedISWWindowAdjustment_A8358;

		// Token: 0x0400030A RID: 778
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedISWWindowAdjustment_A8358;

		// Token: 0x0400030B RID: 779
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkWideAdvancedISWWindowAdjustment_A8358;

		// Token: 0x0400030C RID: 780
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedISWWindowAdjustment_A8358;

		// Token: 0x0400030D RID: 781
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedISWWindowAdjustment_A8358;

		// Token: 0x0400030E RID: 782
		internal global::AcpUI.AcpTextBoxDecHex TrkWideAdvancedISWWindowAdjustment_A8358Comp;

		// Token: 0x0400030F RID: 783
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideAdvancedVirtualPartnerCallActivityTime_A43675;

		// Token: 0x04000310 RID: 784
		internal global::AcpUI.AcpLabel LblTrkWideAdvancedVirtualPartnerCallActivityTime_A43675;

		// Token: 0x04000311 RID: 785
		internal global::AcpUI.AcpTextBoxSpinner TrkWideAdvancedVirtualPartnerCallActivityTime_A43675;

		// Token: 0x04000312 RID: 786
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideAdvancedVirtualPartnerCallActivityTime_A43675;

		// Token: 0x04000313 RID: 787
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideAdvancedVirtualPartnerCallActivityTime_A43675;

		// Token: 0x04000314 RID: 788
		internal global::AcpUI.AcpLabel TrkWideAdvancedVirtualPartnerCallActivityTime_A43675Comp;

		// Token: 0x04000315 RID: 789
		internal global::AcpUI.AcpExpander ExpanderTrunkingWideLabtool;

		// Token: 0x04000316 RID: 790
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingWideLabtoolPseudo0;

		// Token: 0x04000317 RID: 791
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideLabtoolDesenseRSSIThreshold_A7827;

		// Token: 0x04000318 RID: 792
		internal global::AcpUI.AcpLabel LblTrkWideLabtoolDesenseRSSIThreshold_A7827;

		// Token: 0x04000319 RID: 793
		internal global::AcpUI.AcpTextBoxDecHex TrkWideLabtoolDesenseRSSIThreshold_A7827;

		// Token: 0x0400031A RID: 794
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideLabtoolDesenseRSSIThreshold_A7827;

		// Token: 0x0400031B RID: 795
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideLabtoolDesenseRSSIThreshold_A7827;

		// Token: 0x0400031C RID: 796
		internal global::AcpUI.AcpTextBoxDecHex TrkWideLabtoolDesenseRSSIThreshold_A7827Comp;

		// Token: 0x0400031D RID: 797
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkWideLabtoolPhase2ScramblingDisable_A37983;

		// Token: 0x0400031E RID: 798
		internal global::AcpUI.AcpLabel LblTrkWideLabtoolPhase2ScramblingDisable_A37983;

		// Token: 0x0400031F RID: 799
		internal global::AcpUI.AcpCheckBox TrkWideLabtoolPhase2ScramblingDisable_A37983;

		// Token: 0x04000320 RID: 800
		internal global::AcpUI.AcpRtdButton RTDBtnTrkWideLabtoolPhase2ScramblingDisable_A37983;

		// Token: 0x04000321 RID: 801
		internal global::AcpUI.AcpCopyButton CpyBtnTrkWideLabtoolPhase2ScramblingDisable_A37983;

		// Token: 0x04000322 RID: 802
		internal global::AcpUI.AcpCheckBox TrkWideLabtoolPhase2ScramblingDisable_A37983Comp;

		// Token: 0x04000323 RID: 803
		private bool b;
	}
}
