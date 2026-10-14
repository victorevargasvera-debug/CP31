using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000234 RID: 564
	public class BaseHandOutXMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.AcpBaseXMLCoreEngine
	{
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0026C9F4 File Offset: 0x0026ABF4
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0026CAA4 File Offset: 0x0026ACA4
		protected global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem refTrunking
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1988702709;
				short num2 = num;
				num = (short)1997746677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1779957760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1627914241;
				if (num != 0)
				{
				}
				num = (short)913768448;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)532615065;
				short num2 = num;
				num = (short)1289162649;
				switch (num2 == num)
				{
				default:
				{
					num = (short)995557376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)537329664;
				if (num != 0)
				{
				}
				num = (short)1050214401;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0026CB54 File Offset: 0x0026AD54
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0026CC04 File Offset: 0x0026AE04
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset recsetKeypad
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2052139379;
				short num2 = num;
				num = (short)160967027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)193855488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716046337;
				if (num != 0)
				{
				}
				num = (short)2100428800;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1661168175;
				short num2 = num;
				num = (short)562260527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1261305856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2883585;
				if (num != 0)
				{
				}
				num = (short)214892544;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0026CCB8 File Offset: 0x0026AEB8
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x0026CD68 File Offset: 0x0026AF68
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButton
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1476631593;
				short num2 = num;
				num = (short)1373084713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373030912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)76283904;
				if (num != 0)
				{
				}
				num = (short)1685979137;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)770638743;
				short num2 = num;
				num = (short)2069103511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805451264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682754049;
				if (num != 0)
				{
				}
				num = (short)1518796800;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0026CE18 File Offset: 0x0026B018
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0026CEC8 File Offset: 0x0026B0C8
		protected int count
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)598596150;
				short num2 = num;
				num = (short)1446631990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046558208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)135528449;
				if (num != 0)
				{
				}
				num = (short)103415808;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2010248871;
				short num2 = num;
				num = (short)1735063207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246101504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422131200;
				if (num != 0)
				{
				}
				num = (short)965476353;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0026CF74 File Offset: 0x0026B174
		public BaseHandOutXMLCoreEngine()
		{
			this.refTrunking = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			this.recsetKeypad = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
			if (this.recsetKeypad != null)
			{
				this.keypadButton = (this.recsetKeypad[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
			}
			this.count = 0;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0026CFF0 File Offset: 0x0026B1F0
		protected void AddFieldValue(ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptFields, string fieldValue)
		{
			short num = (short)1833959425;
			if (num != 0)
			{
			}
			num = (short)201981952;
			short num2 = num;
			num = (short)442755485;
			short num3 = num;
			num = (short)1620502941;
			switch (num3 == num)
			{
			}
			num = (short)839385088;
			if (num != 0)
			{
			}
			global::SpecialFeatures.AcpXMLCoreEngineLib._Value value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
			value.FieldValue = fieldValue;
			rptFields.values.Add(value);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0026D0B4 File Offset: 0x0026B2B4
		protected virtual void AddUiFieldDescByCondition(ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptFields, string uiName, string conditionName, string descValue)
		{
			short num = (short)639827971;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)1823801348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)289931265;
					if (num != 0)
					{
					}
					goto IL_93;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					if (!(uiName == conditionName))
					{
						num = (short)816644102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
				case 5:
				{
					num = (short)340411051;
					short num3 = num;
					num = (short)1856127659;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52;
					default:
						num = (short)691273728;
						if (num != 0)
						{
						}
						if (conditionName == null)
						{
							num = (short)112132098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 6:
					num = (short)334430213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_41;
				IL_52:
				num = (short)334757888;
				short num4 = num;
				num = (short)52428801;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41:
				if (string.IsNullOrEmpty(rptFields.UIFieldDes))
				{
					goto IL_52;
				}
				break;
				IL_93:
				rptFields.UIFieldDes = descValue;
				num = (short)419364864;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0026D268 File Offset: 0x0026B468
		protected virtual void AddMultiValueByRTL(bool? condition1, bool? condition2, string value1, string value2, ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptField)
		{
			short num = (short)615841793;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_76;
			}
			int num2;
			string fieldValue;
			string fieldValue2;
			for (;;)
			{
				IL_30:
				string text;
				string text2;
				switch (num2)
				{
				case 0:
				{
					if (global::System.Convert.ToBoolean(condition2))
					{
						num = (short)926941186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)765984768;
					short num3 = num;
					num = (short)1625685281;
					short num4 = num;
					num = (short)1242168609;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AA;
					default:
						num = (short)27852800;
						if (num != 0)
						{
						}
						num = (short)486604806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)1541668871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					text = value2;
					goto IL_228;
				case 3:
					if (!global::System.Convert.ToBoolean(condition1))
					{
						num = (short)1000669185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1855848457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (condition2 != null)
					{
						num = (short)954925067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AA;
				case 5:
					if (condition1 != null)
					{
						num = (short)1617690636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 6:
					num = (short)2058878991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					text2 = string.Empty;
					goto IL_2D4;
				case 8:
					if (base.isRTL)
					{
						num = (short)951975950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F3;
				case 9:
					text2 = value1;
					goto IL_2D4;
				case 10:
					goto IL_258;
				case 11:
					num = (short)830472192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1716191235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_1AA;
				case 14:
					goto IL_1E3;
				case 15:
					text = string.Empty;
					goto IL_228;
				}
				goto IL_76;
				IL_1AA:
				num = (short)2018967560;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_228:
				fieldValue = text;
				num = (short)782893069;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_258:
				num = (short)352911364;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D4:
				fieldValue2 = text2;
				num = (short)1957625866;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E3:
			this.AddFieldValue(ref rptField, fieldValue2);
			this.AddFieldValue(ref rptField, fieldValue);
			return;
			IL_2F3:
			this.AddFieldValue(ref rptField, fieldValue);
			this.AddFieldValue(ref rptField, fieldValue2);
			return;
			IL_76:
			fieldValue2 = value1;
			fieldValue = value2;
			num = (short)1226113029;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0026D57C File Offset: 0x0026B77C
		protected virtual void AddMultiValueByRTL(bool? condition1, bool? condition2, bool? condition3, bool? condition4, string value1, string value2, string value3, string value4, ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptField)
		{
			short num = (short)1298464768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				string fieldValue;
				string fieldValue2;
				string fieldValue3;
				string fieldValue4;
				for (;;)
				{
					IL_28:
					string text;
					string text2;
					string text3;
					string text4;
					switch (num2)
					{
					case 0:
						text = value1;
						goto IL_402;
					case 1:
						text2 = value4;
						goto IL_332;
					case 2:
						if (condition1 != null)
						{
							num = (short)1918042127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
					case 3:
						if (!global::System.Convert.ToBoolean(condition4))
						{
							num = (short)89980939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)363986945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.isRTL)
						{
							num = (short)412549128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54C;
					case 5:
						text = string.Empty;
						goto IL_402;
					case 6:
						goto IL_4C8;
					case 7:
						if (!global::System.Convert.ToBoolean(condition1))
						{
							num = (short)1525022736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)258932736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_257;
					case 9:
						goto IL_F4;
					case 10:
						text3 = string.Empty;
						goto IL_46B;
					case 11:
						num = (short)390266903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1729232924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text3 = value2;
						goto IL_46B;
					case 14:
						text4 = value3;
						goto IL_4A9;
					case 15:
						num = (short)1259077639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)669384709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (condition2 != null)
						{
							num = (short)1483931660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C8;
					case 18:
						if (condition3 != null)
						{
							num = (short)1328611357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 19:
						if (condition4 != null)
						{
							num = (short)184811545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C;
					case 20:
					{
						num = (short)764622677;
						short num3 = num;
						num = (short)911226709;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32D;
						default:
							num = (short)76611584;
							if (num != 0)
							{
							}
							if (!global::System.Convert.ToBoolean(condition3))
							{
								num = (short)1248329749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)940113934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						num = (short)1640431642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_21C;
					case 23:
						text2 = string.Empty;
						goto IL_332;
					case 24:
						goto IL_32D;
					case 25:
						num = (short)1941045251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						text4 = string.Empty;
						goto IL_4A9;
					case 27:
					{
						num = (short)509149184;
						short num4 = num;
						goto IL_157;
					}
					case 28:
						if (!global::System.Convert.ToBoolean(condition2))
						{
							num = (short)879624216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2117009421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)266403860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
					IL_F4:
					num = (short)1725825043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					num = (short)968949777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21C:
					num = (short)2099904516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					num = (short)1776418826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_332:
					fieldValue = text2;
					num = (short)1226506262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_402:
					fieldValue2 = text;
					num = (short)957743131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46B:
					fieldValue3 = text3;
					num = (short)457244678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A9:
					fieldValue4 = text4;
					num = (short)1413742601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C8:
					num = (short)1143472146;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_257:
				num = (short)1732444161;
				if (num != 0)
				{
				}
				this.AddFieldValue(ref rptField, fieldValue);
				this.AddFieldValue(ref rptField, fieldValue4);
				this.AddFieldValue(ref rptField, fieldValue2);
				this.AddFieldValue(ref rptField, fieldValue3);
				return;
				IL_54C:
				this.AddFieldValue(ref rptField, fieldValue3);
				this.AddFieldValue(ref rptField, fieldValue2);
				this.AddFieldValue(ref rptField, fieldValue4);
				this.AddFieldValue(ref rptField, fieldValue);
				return;
				IL_A7:
				fieldValue2 = value1;
				fieldValue3 = value2;
				fieldValue4 = value3;
				fieldValue = value4;
				num = (short)1745747970;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0026DAFC File Offset: 0x0026BCFC
		protected virtual void KeypadButtonSequenceRTL(bool? condition1, bool? condition2, string value1, string value2, ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields rptField)
		{
			short num = (short)342625604;
			short num2 = num;
			num = (short)2003307844;
			switch (num2 == num)
			{
			default:
			{
				num = (short)106561536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1825767425;
			if (num != 0)
			{
			}
			num = (short)384696320;
			if (num != 0)
			{
			}
			this.AddMultiValueByRTL(condition1, condition2, value1, value2, ref this.rptFields);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0026DBB8 File Offset: 0x0026BDB8
		protected virtual void AddKeypadButton(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table rptTable)
		{
			int a_ = 12;
			short num = (short)815857827;
			short num2 = num;
			num = (short)1024131235;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_896:
				rptTable.RecSet.Add(base.rptRec);
				num = (short)1337655301;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1286144001;
				if (num != 0)
				{
				}
				num = (short)502857728;
				if (num != 0)
				{
				}
				num = (short)1139671040;
				switch (num)
				{
				default:
					num = (short)573767683;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				num = (short)1446182912;
				short num4 = num;
				switch (num3)
				{
				case 0:
				{
					base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					int num5 = this.count;
					this.count = num5 + 1;
					base.rptRec.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒎ﶘ쒚\udf9c햠힢쪤즦\udaa8", a_), base.ci);
					base.rptRec.RecNo = this.count.ToString();
					int num6 = 0;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.keypadButton.GetEnumerator();
					num = (short)1268056068;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (!this.recsetKeypad.HiddenStatic)
					{
						num = (short)643694592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_852;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_102;
					}
					continue;
				case 4:
					try
					{
						num = (short)1687486465;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							string text;
							string text2;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
							switch (num3)
							{
							case 0:
							{
								string uiName = text;
								string conditionName = null;
								string @string = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\ude94튖삘쮚\udc9c\udb9e", a_), base.ci);
								int num5;
								int num6 = num5 = num6 + 1;
								this.AddUiFieldDescByCondition(ref this.rptFields, uiName, conditionName, @string + num5.ToString());
								num = (short)1120796682;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_17A;
								}
								continue;
							case 2:
								num = (short)1954414599;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
								text2 = text2 + base.indexSeparator + radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
								num = (short)1818689545;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								if (this.rptFields.UIFieldDes == string.Empty)
								{
									num = (short)1881604096;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17F;
							case 6:
								if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒잔튖햘\uda9a쒜쾞ﮨ", a_), base.ci))
								{
									num = (short)1382088708;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EA;
							case 7:
								goto IL_7E0;
							case 8:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)2030960642;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpFeatureNode = enumerator.Current;
								this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
								keypadButtonInnerSection = (acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection);
								int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
								text2 = (string)(acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, base.ci);
								string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue = (acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
								num = (short)1426259974;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_1EA;
							case 10:
								goto IL_17F;
							}
							goto IL_17A;
							IL_17F:
							base.rptRec.UIFields.Add(this.rptFields);
							num = (short)1238761475;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_1AD:
							num = (short)525074440;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_17A:
							goto IL_1AD;
							IL_1EA:
							this.KeypadButtonSequenceRTL(new bool?(!this.refTrunking.Parent.HiddenStatic), new bool?(!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic), text2, text2, ref this.rptFields);
							this.rptFields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
							text = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒쾔튖쮘풚궜", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒쾔튖쮘풚궜", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삎ﾐ꒔좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삎ﾐ꒔좖킘ﾚ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8eﲒꞔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8eﲒꞔ좖킘ﾚ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8e戀ꪘ쒚풜ﮞ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8e戀ꪘ쒚풜ﮞ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ﺐꎖ욘튚列", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ﺐꎖ욘튚列", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ꊖ욘튚列", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ꊖ욘튚列", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eꎔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eꎔ좖킘ﾚ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e練꺘쒚풜ﮞ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e練꺘쒚풜ﮞ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪎ﶔꆘ쒚풜ﮞ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪎ﶔꆘ쒚풜ﮞ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솎ﶒ꺖욘튚列", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솎ﶒ꺖욘튚列", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e좖킘ﾚ", a_), base.ci));
							this.AddUiFieldDescByCondition(ref this.rptFields, text, global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8eﺐﮔ톘漢ﺠ솤", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture), global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8eﺐﮔ톘漢ﺠ솤", a_), base.ci));
							num = (short)2078343173;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_7E0:
						goto IL_896;
					}
					finally
					{
						num = (short)697499648;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_818;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1850277890;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_84F;
							}
							IL_818:
							if (enumerator == null)
							{
								break;
							}
							num = (short)323747841;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_84F:;
					}
					goto IL_852;
				case 5:
					return;
				}
				IL_102:
				if (this.keypadButton != null)
				{
					num = (short)31195138;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_852:
				num = (short)1461780481;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0026E530 File Offset: 0x0026C730
		protected virtual void CreateTableHeader(ref global::SpecialFeatures.AcpXMLCoreEngineLib._table rptTable)
		{
			int a_ = 9;
			short num = (short)1260299245;
			short num2 = num;
			num = (short)675652589;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1898577920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)778436608;
			if (num != 0)
			{
			}
			num = (short)674037761;
			if (num != 0)
			{
			}
			rptTable.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캋ﮍﮓ얙ﶛ쒟ﶡ즥욧\udea9\udeab솭\udcaf솱", a_), base.ci);
			rptTable.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋즕톗ﺙ", a_), base.ci));
			rptTable.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋ﾕ캟ﶡ슥", a_), base.ci));
			rptTable.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾋ﺏ솟캡ﮣ첧", a_), base.ci));
			rptTable.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88bﲍﲑﾓﾕﶙ쎛힝", a_), base.ci));
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0026E6AC File Offset: 0x0026C8AC
		public override void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj)
		{
			short num = (short)1968046081;
			if (num != 0)
			{
			}
			num = (short)593428480;
			short num2 = num;
			num = (short)1091521573;
			short num3 = num;
			num = (short)587615269;
			switch (num3 == num)
			{
			}
			num = (short)1111031808;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0026E754 File Offset: 0x0026C954
		protected virtual void AddGeneral(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_13:
				global::AcpCommonLib.IAcpField acpField;
				switch (num)
				{
				case 0:
					base.rptValue.FieldValue = acpField.ToString();
					this.rptFields.values.Add(base.rptValue);
					this.rptFields.UIFieldName = acpField.Name;
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐\ude92\uda94펖\udc98힚펜쪞", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					this.rptTable.RecSet.Add(base.rptRec);
					num2 = (short)1902772230;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					if (radioInformation != null)
					{
						num2 = (short)1861746692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)1127219200;
					short num3 = num2;
					goto IL_95;
				}
				case 4:
				{
					this.rptTable.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪌ﾐ펚ﮞ얠욢쮤", a_);
					string @string = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐풒킔\ud996\udc98즚\udc9c펞", a_), base.ci);
					this.rptTable.ColTitle.Add(@string);
					base.rptRec.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾌", a_);
					base.rptRec.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌", a_);
					acpField = null;
					acpField = radioInformation.General.RadInfoGeneralModelNumber_A8539;
					num2 = (short)506593287;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					base.rptValue.FieldValue = acpField.ToString();
					this.rptFields.values.Add(base.rptValue);
					this.rptFields.UIFieldName = acpField.Name;
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐삒킔얖킘\uda9a톜톞ﮨ", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					this.rptTable.RecSet.Add(base.rptRec);
					num2 = (short)1997209601;
					if (num2 != 0)
					{
					}
					num2 = (short)357040131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_4B8;
				case 7:
					if (acpField != null)
					{
						num2 = (short)292683776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4B8;
				case 8:
					base.rptValue.FieldValue = acpField.ToString();
					this.rptFields.values.Add(base.rptValue);
					this.rptFields.UIFieldName = acpField.Name;
					this.rptFields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒌쮎캐햒\ud994횖쪘펚\ude9c킞", a_), base.ci);
					base.rptRec.UIFields.Add(this.rptFields);
					this.rptTable.RecSet.Add(base.rptRec);
					num2 = (short)762642443;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)2041272267;
					short num4 = num2;
					num2 = (short)657479627;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1809186816;
						if (num2 != 0)
						{
						}
						if (acpField != null)
						{
							num2 = (short)1530003464;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_31E;
					}
					break;
				}
				case 10:
					if (acpField != null)
					{
						num2 = (short)387710981;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_95;
				case 11:
					goto IL_31E;
				}
				goto IL_49;
				IL_95:
				base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				base.rptValue = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
				this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				acpField = null;
				base.rptRec.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌", a_);
				base.rptRec.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾌", a_);
				acpField = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132;
				num2 = (short)1945305097;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_31E:
				RptXMLData.tables.Add(this.rptTable);
				num2 = (short)916193281;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4B8:
				base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				base.rptValue = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
				this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				acpField = null;
				base.rptRec.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌", a_);
				base.rptRec.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벌", a_);
				acpField = radioInformation.General.RadInfoGeneralSerialNumber_A9122;
				num2 = (short)1756233738;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_49:
			radioInformation = null;
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num2 = (short)1561001986;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0026ECB8 File Offset: 0x0026CEB8
		private void a(ref global::System.Collections.Generic.Dictionary<int, string> A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num3;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_0A:
				int num2;
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					A_0.Add(num2, channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659Value);
					channelAssignmentListInner = null;
					num3 = (short)1873608714;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
				{
					if (num2 >= zoneChannelAssignment.Channels.EmbeddedRecset.Count)
					{
						num3 = (short)551550983;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)zoneChannelAssignment.Channels.EmbeddedRecset[num2];
					num3 = (short)1604124681;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = null;
					num2 = 0;
					num3 = (short)1754071046;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
					if (zoneChannelAssignment != null)
					{
						num3 = (short)202702853;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 4:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num3 = (short)655360008;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)2136080385;
					if (num3 != 0)
					{
					}
					num3 = (short)1988755467;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					num3 = (short)1810694148;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					goto IL_190;
				case 7:
					goto IL_1D5;
				case 8:
					goto IL_21E;
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					if (channelAssignmentListInner != null)
					{
						num3 = (short)711327744;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_223;
				}
				case 10:
				{
					num3 = (short)474787250;
					short num4 = num3;
					num3 = (short)767798706;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num3 = (short)1277165568;
						if (num3 != 0)
						{
						}
						goto IL_223;
					}
					break;
				}
				case 11:
					if (zoneChannelAssignment.Channels.HasEmbeddedRecset)
					{
						num3 = (short)1441267714;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 12:
					goto IL_190;
				}
				goto IL_44;
				IL_190:
				num3 = (short)663552001;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_223:
				num2++;
				num3 = (short)1901264908;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_1D5:
			return;
			IL_21E:
			num3 = (short)1393557504;
			short num5 = num3;
			return;
			IL_44:
			zoneChannelAssignment = null;
			zoneChannelAssignment = (global::AcpCommonLib.FeatureManager.GetFeature(2051)[A_1 - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num3 = (short)489291779;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0026EF94 File Offset: 0x0026D194
		protected void AddZonesAndChannels(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 7;
			short num = (short)539295744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E7;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<int, string>> list;
					int num4;
					string text;
					int num5;
					int num6;
					int num7;
					string text2;
					int num9;
					int num10;
					string item;
					int num11;
					int num12;
					int num15;
					switch (num2)
					{
					case 0:
						list.Reverse();
						num = (short)900726820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int num3 = 0;
						num = (short)1526661146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_74F;
					case 3:
						num = (short)1179516939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						text = string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪉ뺍", a_), num4);
						goto IL_5F7;
					case 5:
						if (num5 < num6)
						{
							num = (short)1499922456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B2;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = zoneChannelAssignment2.Parent[num7] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						if (zoneChannelAssignment == null)
						{
							num = (short)1017053223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = zoneChannelAssignment.KeyField.Value;
						goto IL_70C;
					}
					case 7:
						num = (short)23396377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num7 >= zoneChannelAssignment2.Parent.Count)
						{
							num = (short)1185087515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)881459206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_85B;
					case 10:
						goto IL_2AA;
					case 11:
					{
						num = (short)185464850;
						short num8 = num;
						num = (short)2055665682;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_148;
						default:
							num = (short)1719205888;
							if (num != 0)
							{
							}
							num9 = 3;
							goto IL_49A;
						}
						break;
					}
					case 12:
						goto IL_2AA;
					case 13:
						goto IL_2AA;
					case 14:
						if (base.isRTL)
						{
							num = (short)1158807559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_387;
					case 15:
						text = string.Empty;
						goto IL_5F7;
					case 16:
						goto IL_85B;
					case 17:
						goto IL_585;
					case 18:
						if (zoneChannelAssignment2.Parent.Count <= 3)
						{
							num = (short)1484914691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)322175004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_148;
					case 20:
						goto IL_3F0;
					case 21:
						this.rptTable.ColTitle.Insert(num10, item);
						num = (short)1161101324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num4 >= num11)
						{
							num = (short)1950482461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num12 = num6 * num4;
						num = (short)1346764842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						int num13 = num6 - (zoneChannelAssignment2.Parent.Count - num12);
						int num14 = 0;
						num = (short)129368084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)20643848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (num4 == num15)
						{
							num = (short)606339095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_387;
					case 26:
						goto IL_74F;
					case 27:
						goto IL_3B2;
					case 28:
						num9 = 6;
						goto IL_49A;
					case 29:
						return;
					case 30:
						if (base.isRTL)
						{
							num = (short)217907232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.rptTable.ColTitle.Add(item);
						num = (short)1205075978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (base.isRTL)
						{
							num = (short)355794944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_537;
					case 32:
						num = (short)279576614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_459;
					case 34:
						goto IL_3F0;
					case 35:
					{
						num = (short)1334247424;
						short num16 = num;
						goto IL_387;
					}
					case 36:
						goto IL_537;
					case 37:
					{
						int num13;
						int num14;
						if (num14 >= num13)
						{
							num = (short)324010019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.rptTable.ColTitle.Insert(1, string.Empty);
						num14++;
						num10++;
						num = (short)1227423778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						num = (short)60555265;
						if (num != 0)
						{
						}
						if (num4 == num15)
						{
							num = (short)1287323669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.rptTable.ColTitle.Insert(1, item);
						num = (short)198508557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						text2 = null;
						goto IL_70C;
					case 40:
						if (num4 == num15)
						{
							num = (short)12582913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_459;
					case 41:
						goto IL_585;
					case 42:
						if (num4 <= 0)
						{
							num = (short)1707999251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)57278468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						int num3;
						if (num3 >= num6 - num5)
						{
							num = (short)1232207905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list.Add(new global::System.Collections.Generic.Dictionary<int, string>
						{
							{
								0,
								string.Empty
							}
						});
						num3++;
						num = (short)1755447298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_E7;
					IL_148:
					num = (short)1193082895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA:
					global::System.Collections.Generic.Dictionary<int, string> item2 = new global::System.Collections.Generic.Dictionary<int, string>();
					this.a(ref item2, num7 + 1);
					list.Add(item2);
					num7 = ++num5 + num12;
					num = (short)1391984681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_387:
					list = new global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<int, string>>();
					num5 = 0;
					num7 = num12;
					num = (short)631701521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B2:
					num = (short)304742440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F0:
					num = (short)164757541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_459:
					num = (short)1441267743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49A:
					num6 = num9;
					num11 = (int)global::System.Math.Ceiling((double)zoneChannelAssignment2.Parent.Count / (double)num6);
					num15 = num11 - 1;
					num4 = 0;
					num = (short)1361969161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_537:
					this.rptTable.RecSet.AddRange(this.a(list));
					RptXMLData.tables.Add(this.rptTable);
					num4++;
					num = (short)940507152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_585:
					num = (short)550764549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F7:
					string str = text;
					this.rptTable = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
					this.rptTable.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킉쮓ﺙ쎛\udd9d좟쎡쪣좥춧용\udfab", a_), base.ci) + str;
					this.rptTable.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즉ﺏﲑ歹얙햛瞧", a_), base.ci));
					num10 = 1;
					num = (short)799604750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70C:
					item = text2;
					num = (short)1293615134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74F:
					num = (short)2006319147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85B:
					num = (short)1774780438;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_E7:
				zoneChannelAssignment2 = null;
				zoneChannelAssignment2 = (global::AcpCommonLib.FeatureManager.GetFeature(2051)[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)452395026;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0026F870 File Offset: 0x0026DA70
		private global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet> a(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<int, string>> A_0)
		{
			int a_ = 5;
			short num = (short)662044672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet> list;
				for (;;)
				{
					IL_30:
					int num4;
					int num5;
					int num7;
					global::System.Func<global::System.Collections.Generic.Dictionary<int, string>, int> selector;
					switch (num2)
					{
					case 0:
						goto IL_242;
					case 1:
					{
						num = (short)582811649;
						if (num != 0)
						{
						}
						global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
						try
						{
							num = (short)672464903;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.Dictionary<int, string> dictionary;
								switch (num2)
								{
								case 2:
								{
									num = (short)1958512891;
									short num3 = num;
									num = (short)767920379;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_109;
									default:
										num = (short)1832976384;
										if (num != 0)
										{
										}
										num = (short)681181187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_205;
								case 4:
								{
									string fieldValue;
									dictionary.TryGetValue(num4, out fieldValue);
									this.AddFieldValue(ref uifields, fieldValue);
									num = (short)2112028672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_109;
								case 6:
								{
									global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<int, string>>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1331757058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dictionary = enumerator.Current;
									num = (short)1735917573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_C2;
									}
									continue;
								}
								goto IL_C2;
								IL_109:
								if (dictionary.Count > num4)
								{
									num = (short)1542848516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								this.AddFieldValue(ref uifields, string.Empty);
								num = (short)301858817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_132:
								num = (short)70451206;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C2:
								goto IL_132;
							}
							IL_205:
							goto IL_2C4;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<int, string>>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_218;
						IL_2C4:
						uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇ﺏ\ud895聯鍊", a_);
						global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
						uifields.UIFieldDes = recSet.RecNo;
						recSet.UIFields.Add(uifields);
						list.Add(recSet);
						num4++;
						num = (short)2069495808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (num4 >= num5)
						{
							num = (short)432406528;
							short num6 = num;
							num = (short)1901789188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욇쾏\udb91", a_), base.ci) + num7.ToString();
						recSet.RecNo = num7++.ToString();
						global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<int, string>>.Enumerator enumerator = A_0.GetEnumerator();
						num = (short)452722689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_242;
					case 4:
						return list;
					case 5:
						if ((selector = global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine.<>c.<>9__28_0) == null)
						{
							selector = (global::SpecialFeatures.ACPXMLCoreEngineLib.BaseHandOutXMLCoreEngine.<>c.<>9__28_0 = delegate(global::System.Collections.Generic.Dictionary<int, string> x)
							{
								short num8 = (short)2002405934;
								short num9 = num8;
								num8 = (short)1365199406;
								switch (num9 == num8)
								{
								}
								num8 = (short)788660225;
								if (num8 != 0)
								{
								}
								num8 = (short)151322624;
								if (num8 != 0)
								{
								}
								num8 = (short)2144403456;
								short num10 = num8;
								return x.Count;
							});
							goto IL_218;
						}
						goto IL_218;
					}
					goto IL_4F;
					IL_218:
					num5 = A_0.Max(selector);
					num7 = 1;
					num4 = 0;
					num = (short)1385234435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_242:
					num = (short)1931345922;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_4F:
				list = new global::System.Collections.Generic.List<global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet>();
				num = (short)903938053;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0026FC58 File Offset: 0x0026DE58
		private int a(global::System.Collections.Generic.Dictionary<int, string> A_0, global::System.Collections.Generic.Dictionary<int, string> A_1, global::System.Collections.Generic.Dictionary<int, string> A_2)
		{
			short num = (short)2092726261;
			short num2 = num;
			num = (short)1040611317;
			switch (num2 == num)
			{
			}
			num = (short)1158873089;
			if (num != 0)
			{
			}
			num = (short)1472659456;
			if (num != 0)
			{
			}
			num = (short)1429733376;
			short num3 = num;
			return global::System.Math.Max(global::System.Math.Max(A_0.Count, A_1.Count), A_2.Count);
		}

		// Token: 0x04000E07 RID: 3591
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem a;

		// Token: 0x04000E08 RID: 3592
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset b;

		// Token: 0x04000E09 RID: 3593
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset c;

		// Token: 0x04000E0A RID: 3594
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int d;
	}
}
