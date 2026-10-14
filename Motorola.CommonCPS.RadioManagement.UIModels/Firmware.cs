using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using CommonUtility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000D5 RID: 213
	public class Firmware : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase, global::System.IComparable
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x0009A410 File Offset: 0x00098610
		public Firmware() : base(global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware.t())
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0009A428 File Offset: 0x00098628
		public Firmware(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0009A43C File Offset: 0x0009863C
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0009A4EC File Offset: 0x000986EC
		public string Guid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)645985192;
				short num2 = num;
				num = (short)1550513064;
				switch (num2 == num)
				{
				}
				num = (short)416219137;
				if (num != 0)
				{
				}
				num = (short)1964769280;
				if (num != 0)
				{
				}
				num = (short)931725312;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1068758967;
				short num2 = num;
				num = (short)1513027511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448345600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1613430785;
				if (num != 0)
				{
				}
				num = (short)1159135232;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0009A59C File Offset: 0x0009879C
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0009A67C File Offset: 0x0009887C
		public string Version
		{
			get
			{
				short num = (short)1348009985;
				if (num != 0)
				{
				}
				num = (short)201719808;
				short num2 = num;
				num = (short)436684698;
				short num3 = num;
				num = (short)1905346458;
				switch (num3 == num)
				{
				}
				num = (short)2082340864;
				if (num != 0)
				{
				}
				string text = this.a<string>(new global::System.Func<string>(this.s), new global::System.Func<string>(this.r), new global::System.Func<string>(this.q));
				return text ?? string.Empty;
			}
			set
			{
				short num = (short)706483218;
				short num2 = num;
				num = (short)465966098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889978880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)68157441;
				if (num != 0)
				{
				}
				num = (short)859111424;
				if (num != 0)
				{
				}
				value = (value ?? string.Empty);
				this.a(delegate()
				{
					short num4 = (short)478470194;
					short num5 = num4;
					num4 = (short)2117460018;
					switch (num5 == num4)
					{
					}
					num4 = (short)1503330305;
					if (num4 != 0)
					{
					}
					num4 = (short)1300365312;
					if (num4 != 0)
					{
					}
					num4 = (short)638386176;
					short num6 = num4;
					this.PBBFirmwareSummary.PackageVersion = value;
				}, delegate()
				{
					short num4 = (short)559896704;
					short num5 = num4;
					num4 = (short)302274688;
					switch (num5 == num4)
					{
					}
					num4 = (short)2045509632;
					if (num4 != 0)
					{
					}
					num4 = (short)808779777;
					if (num4 != 0)
					{
					}
					num4 = (short)439222272;
					short num6 = num4;
					this.AstroFirmwareSummary.PackageVersion = value;
				}, delegate()
				{
					short num4 = (short)1646106373;
					short num5 = num4;
					num4 = (short)616666885;
					switch (num5 == num4)
					{
					}
					num4 = (short)1048641537;
					if (num4 != 0)
					{
					}
					num4 = (short)1940717568;
					if (num4 != 0)
					{
					}
					num4 = (short)2073821184;
					short num6 = num4;
					this.PcrFirmwareCodeplugPairGroupSummary.FirmwareVersion = value;
				});
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0009A77C File Offset: 0x0009897C
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0009A86C File Offset: 0x00098A6C
		public int Size
		{
			get
			{
				short num = (short)2115108864;
				short num2 = num;
				num = (short)697186181;
				short num3 = num;
				num = (short)1916417925;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)466354177;
					if (num != 0)
					{
					}
					num = (short)1369309184;
					if (num != 0)
					{
					}
					string s = this.a<string>(new global::System.Func<string>(this.p), new global::System.Func<string>(this.o), new global::System.Func<string>(this.n));
					if (!int.TryParse(s, out num4))
					{
						return 0;
					}
					break;
				}
				}
				return (num4 + 1023) / 1024;
			}
			set
			{
				short num = (short)537362760;
				short num2 = num;
				num = (short)1026654536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1645608960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865665025;
				if (num != 0)
				{
				}
				num = (short)304414720;
				if (num != 0)
				{
				}
				int size = value * 1024 - 1023;
				this.a(delegate()
				{
					short num4 = (short)2104984479;
					short num5 = num4;
					num4 = (short)43746207;
					switch (num5 == num4)
					{
					}
					num4 = (short)1683423233;
					if (num4 != 0)
					{
					}
					num4 = (short)2095185920;
					if (num4 != 0)
					{
					}
					num4 = (short)719388672;
					short num6 = num4;
					this.PBBFirmwareSummary.FileSize = new int?(size);
				}, delegate()
				{
					short num4 = (short)924199449;
					short num5 = num4;
					num4 = (short)133311001;
					switch (num5 == num4)
					{
					}
					num4 = (short)1981939713;
					if (num4 != 0)
					{
					}
					num4 = (short)33423360;
					if (num4 != 0)
					{
					}
					num4 = (short)1001062400;
					short num6 = num4;
					this.AstroFirmwareSummary.FileSize = new int?(size);
				}, delegate()
				{
					short num4 = (short)408045462;
					short num5 = num4;
					num4 = (short)1546143638;
					switch (num5 == num4)
					{
					}
					num4 = (short)2082471937;
					if (num4 != 0)
					{
					}
					num4 = (short)401539072;
					if (num4 != 0)
					{
					}
					num4 = (short)216072192;
					short num6 = num4;
					this.PcrFirmwareCodeplugPairGroupSummary.Size = size.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
				});
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0009A960 File Offset: 0x00098B60
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0009AA38 File Offset: 0x00098C38
		public override string Comments
		{
			get
			{
				short num = (short)1352375801;
				short num2 = num;
				num = (short)671849977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1606221824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338165760;
				if (num != 0)
				{
				}
				num = (short)1369309185;
				if (num != 0)
				{
				}
				return this.a<string>(new global::System.Func<string>(this.m), new global::System.Func<string>(this.l), new global::System.Func<string>(this.k));
			}
			set
			{
				short num = (short)1147994114;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1045561348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						value = string.Empty;
						num = (short)1869152261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2111631395;
						short num3 = num;
						num = (short)99020835;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1775304705;
							if (num != 0)
							{
							}
							num = (short)88932352;
							short num4 = num;
							num = (short)1076625408;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_DC;
							}
							continue;
						}
						}
						break;
					}
					case 3:
						return;
					case 4:
						if (string.IsNullOrEmpty(value))
						{
							num = (short)1620967425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109;
					case 5:
						goto IL_109;
					}
					IL_DC:
					if (value != base.SummaryEntity.Comment)
					{
						num = (short)958791680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_109:
					base.SummaryEntity.Comment = value.Trim();
					num = (short)10747907;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0009ABD0 File Offset: 0x00098DD0
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0009ACD8 File Offset: 0x00098ED8
		public string Codeplug
		{
			get
			{
				short num = (short)874184577;
				short num2 = num;
				num = (short)434962305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2039611392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)988807169;
				if (num != 0)
				{
				}
				num = (short)679346176;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)837026563;
					short num5 = num4;
					num4 = (short)1543504643;
					switch (num5 == num4)
					{
					}
					num4 = (short)1897332737;
					if (num4 != 0)
					{
					}
					num4 = (short)1885011968;
					if (num4 != 0)
					{
					}
					num4 = (short)1166475264;
					short num6 = num4;
					return string.Empty;
				}, delegate()
				{
					short num4 = (short)1743549684;
					short num5 = num4;
					num4 = (short)78738676;
					switch (num5 == num4)
					{
					}
					num4 = (short)1307312129;
					if (num4 != 0)
					{
					}
					num4 = (short)76873728;
					if (num4 != 0)
					{
					}
					num4 = (short)730333184;
					short num6 = num4;
					return string.Empty;
				}, new global::System.Func<string>(this.j));
			}
			set
			{
				short num = (short)598802433;
				if (num != 0)
				{
				}
				num = (short)316407808;
				short num2 = num;
				num = (short)1255822372;
				short num3 = num;
				num = (short)951669796;
				switch (num3 == num)
				{
				}
				num = (short)1219231744;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)1939012045;
					short num5 = num4;
					num4 = (short)474479053;
					switch (num5 == num4)
					{
					}
					num4 = (short)1304428545;
					if (num4 != 0)
					{
					}
					num4 = (short)1164836864;
					if (num4 != 0)
					{
					}
					num4 = (short)663093248;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)1203258605;
					short num5 = num4;
					num4 = (short)497435885;
					switch (num5 == num4)
					{
					}
					num4 = (short)1556938752;
					if (num4 != 0)
					{
					}
					num4 = (short)1249247233;
					if (num4 != 0)
					{
					}
					num4 = (short)2125594624;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)2071199745;
					if (num4 != 0)
					{
					}
					num4 = (short)2067429414;
					short num5 = num4;
					num4 = (short)225343526;
					switch (num5 == num4)
					{
					}
					num4 = (short)1291845632;
					short num6 = num4;
					num4 = (short)364445696;
					if (num4 != 0)
					{
					}
					this.PcrFirmwareCodeplugPairGroupSummary.CodeplugVersion = (value ?? string.Empty);
				});
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0009ADF0 File Offset: 0x00098FF0
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0009AEBC File Offset: 0x000990BC
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName Region
		{
			get
			{
				short num = (short)1054212096;
				short num2 = num;
				num = (short)1168674932;
				short num3 = num;
				num = (short)1604358260;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1731264512;
					if (num != 0)
					{
					}
					num = (short)2054356993;
					if (num != 0)
					{
					}
					if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary))
					{
						return global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL;
					}
					break;
				}
				return (global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName)this.PcrFirmwareCodeplugPairGroupSummary.Region.Value;
			}
			set
			{
				short num = (short)1645132450;
				short num2 = num;
				num = (short)965282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313406976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)778174465;
				if (num != 0)
				{
				}
				num = (short)465371136;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0009AF64 File Offset: 0x00099164
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0009B068 File Offset: 0x00099268
		public string MACE
		{
			get
			{
				short num = (short)591808321;
				short num2 = num;
				num = (short)899172161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978714624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634402305;
				if (num != 0)
				{
				}
				num = (short)913178624;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)1104530186;
					short num5 = num4;
					num4 = (short)1526123274;
					switch (num5 == num4)
					{
					}
					num4 = (short)1897988097;
					if (num4 != 0)
					{
					}
					num4 = (short)1208942592;
					if (num4 != 0)
					{
					}
					num4 = (short)524746752;
					short num6 = num4;
					return string.Empty;
				}, new global::System.Func<string>(this.i), delegate()
				{
					short num4 = (short)1792212993;
					if (num4 != 0)
					{
					}
					num4 = (short)1792349723;
					short num5 = num4;
					num4 = (short)715593243;
					switch (num5 == num4)
					{
					}
					num4 = (short)1678901248;
					if (num4 != 0)
					{
					}
					num4 = (short)2129264640;
					short num6 = num4;
					return string.Empty;
				});
			}
			set
			{
				short num = (short)880719493;
				short num2 = num;
				num = (short)729855621;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382468096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1605238785;
				if (num != 0)
				{
				}
				num = (short)1865416704;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)1912531049;
					short num5 = num4;
					num4 = (short)2018175081;
					switch (num5 == num4)
					{
					}
					num4 = (short)1583742977;
					if (num4 != 0)
					{
					}
					num4 = (short)416546816;
					if (num4 != 0)
					{
					}
					num4 = (short)69074944;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)1427505153;
					if (num4 != 0)
					{
					}
					num4 = (short)610801960;
					short num5 = num4;
					num4 = (short)2140608808;
					switch (num5 == num4)
					{
					}
					num4 = (short)2093154304;
					short num6 = num4;
					num4 = (short)896204800;
					if (num4 != 0)
					{
					}
					this.AstroFirmwareSummary.MaceFlashVersion = (value ?? string.Empty);
				}, delegate()
				{
					short num4 = (short)1902597541;
					short num5 = num4;
					num4 = (short)942822821;
					switch (num5 == num4)
					{
					}
					num4 = (short)2145189889;
					if (num4 != 0)
					{
					}
					num4 = (short)995885056;
					if (num4 != 0)
					{
					}
					num4 = (short)2124349440;
					short num6 = num4;
				});
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0009B180 File Offset: 0x00099380
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0009B288 File Offset: 0x00099488
		public bool? IsFreonFirmwareUpgradeFile
		{
			get
			{
				short num = (short)280204777;
				short num2 = num;
				num = (short)58103273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452132864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1516699648;
				if (num != 0)
				{
				}
				num = (short)18284545;
				if (num != 0)
				{
				}
				return new bool?(this.a<bool>(delegate()
				{
					short num4 = (short)1830684403;
					short num5 = num4;
					num4 = (short)485689075;
					switch (num5 == num4)
					{
					}
					num4 = (short)257687553;
					if (num4 != 0)
					{
					}
					num4 = (short)769392640;
					if (num4 != 0)
					{
					}
					num4 = (short)1502806016;
					short num6 = num4;
					return false;
				}, new global::System.Func<bool>(this.h), delegate()
				{
					short num4 = (short)2092198710;
					short num5 = num4;
					num4 = (short)359623478;
					switch (num5 == num4)
					{
					}
					num4 = (short)1810825217;
					if (num4 != 0)
					{
					}
					num4 = (short)2032664576;
					if (num4 != 0)
					{
					}
					num4 = (short)807534592;
					short num6 = num4;
					return false;
				}));
			}
			set
			{
				short num = (short)1602355201;
				if (num != 0)
				{
				}
				num = (short)413466624;
				short num2 = num;
				num = (short)199035466;
				short num3 = num;
				num = (short)348850762;
				switch (num3 == num)
				{
				}
				num = (short)1702887424;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)1362506832;
					short num5 = num4;
					num4 = (short)1302213712;
					switch (num5 == num4)
					{
					}
					num4 = (short)1847197697;
					if (num4 != 0)
					{
					}
					num4 = (short)898367488;
					if (num4 != 0)
					{
					}
					num4 = (short)602079232;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)119072872;
					short num5 = num4;
					num4 = (short)1761994856;
					switch (num5 == num4)
					{
					}
					num4 = (short)1837105152;
					if (num4 != 0)
					{
					}
					num4 = (short)1547829248;
					short num6 = num4;
					num4 = (short)264241153;
					if (num4 != 0)
					{
					}
					this.AstroFirmwareSummary.IsFreonFirmwareUpgradeFile = new bool?(value.GetValueOrDefault());
				}, delegate()
				{
					short num4 = (short)126353409;
					if (num4 != 0)
					{
					}
					num4 = (short)1437821292;
					short num5 = num4;
					num4 = (short)709519724;
					switch (num5 == num4)
					{
					}
					num4 = (short)1040449536;
					if (num4 != 0)
					{
					}
					num4 = (short)1740570624;
					short num6 = num4;
				});
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0009B3A0 File Offset: 0x000995A0
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0009B4A8 File Offset: 0x000996A8
		public bool? IsOMAPFirmwareUpgradeFile
		{
			get
			{
				short num = (short)1610007540;
				short num2 = num;
				num = (short)987808756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2078146560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262288897;
				if (num != 0)
				{
				}
				num = (short)971571200;
				if (num != 0)
				{
				}
				return new bool?(this.a<bool>(delegate()
				{
					short num4 = (short)496369665;
					if (num4 != 0)
					{
					}
					num4 = (short)1450831866;
					short num5 = num4;
					num4 = (short)358346746;
					switch (num5 == num4)
					{
					}
					num4 = (short)1891303424;
					if (num4 != 0)
					{
					}
					num4 = (short)716177408;
					short num6 = num4;
					return false;
				}, new global::System.Func<bool>(this.g), delegate()
				{
					short num4 = (short)73334785;
					if (num4 != 0)
					{
					}
					num4 = (short)1756516354;
					short num5 = num4;
					num4 = (short)1457934338;
					switch (num5 == num4)
					{
					}
					num4 = (short)795803648;
					if (num4 != 0)
					{
					}
					num4 = (short)666042368;
					short num6 = num4;
					return false;
				}));
			}
			set
			{
				short num = (short)1332056016;
				short num2 = num;
				num = (short)2092732368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)725483520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148963329;
				if (num != 0)
				{
				}
				num = (short)566755328;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)57999058;
					short num5 = num4;
					num4 = (short)1333526226;
					switch (num5 == num4)
					{
					}
					num4 = (short)1815543808;
					if (num4 != 0)
					{
					}
					num4 = (short)220069889;
					if (num4 != 0)
					{
					}
					num4 = (short)1053229056;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)1053041980;
					short num5 = num4;
					num4 = (short)1631135036;
					switch (num5 == num4)
					{
					}
					num4 = (short)1822097409;
					if (num4 != 0)
					{
					}
					num4 = (short)623968256;
					short num6 = num4;
					num4 = (short)1233584128;
					if (num4 != 0)
					{
					}
					this.AstroFirmwareSummary.IsOMAPFirmwareUpgradeFile = new bool?(value.GetValueOrDefault());
				}, delegate()
				{
					short num4 = (short)907724287;
					short num5 = num4;
					num4 = (short)1705297407;
					switch (num5 == num4)
					{
					}
					num4 = (short)816447488;
					if (num4 != 0)
					{
					}
					num4 = (short)2127167489;
					if (num4 != 0)
					{
					}
					num4 = (short)1976172544;
					short num6 = num4;
				});
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0009B5C0 File Offset: 0x000997C0
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0009B6C0 File Offset: 0x000998C0
		public string TargetModel
		{
			get
			{
				short num = (short)737280001;
				if (num != 0)
				{
				}
				num = (short)2064777216;
				short num2 = num;
				num = (short)487484883;
				short num3 = num;
				num = (short)597388755;
				switch (num3 == num)
				{
				}
				num = (short)503840768;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)189711751;
					short num5 = num4;
					num4 = (short)732677511;
					switch (num5 == num4)
					{
					}
					num4 = (short)1633943553;
					if (num4 != 0)
					{
					}
					num4 = (short)772800512;
					if (num4 != 0)
					{
					}
					num4 = (short)2066219008;
					short num6 = num4;
					return string.Empty;
				}, new global::System.Func<string>(this.f), delegate()
				{
					short num4 = (short)1761480751;
					short num5 = num4;
					num4 = (short)145297455;
					switch (num5 == num4)
					{
					}
					num4 = (short)1163198465;
					if (num4 != 0)
					{
					}
					num4 = (short)1987379200;
					if (num4 != 0)
					{
					}
					num4 = (short)481558528;
					short num6 = num4;
					return string.Empty;
				});
			}
			set
			{
				short num = (short)1841364993;
				if (num != 0)
				{
				}
				num = (short)972226560;
				short num2 = num;
				num = (short)312985945;
				short num3 = num;
				num = (short)1683212633;
				switch (num3 == num)
				{
				}
				num = (short)388825088;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0009B768 File Offset: 0x00099968
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0009B86C File Offset: 0x00099A6C
		public string ModelNumber
		{
			get
			{
				short num = (short)1516282143;
				short num2 = num;
				num = (short)609788191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825753600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)87687168;
				if (num != 0)
				{
				}
				num = (short)1400373249;
				if (num != 0)
				{
				}
				return this.a<string>(new global::System.Func<string>(this.e), delegate()
				{
					short num4 = (short)2032292116;
					short num5 = num4;
					num4 = (short)9130260;
					switch (num5 == num4)
					{
					}
					num4 = (short)797114369;
					if (num4 != 0)
					{
					}
					num4 = (short)2041774080;
					if (num4 != 0)
					{
					}
					num4 = (short)1874591744;
					short num6 = num4;
					return string.Empty;
				}, delegate()
				{
					short num4 = (short)1230621539;
					short num5 = num4;
					num4 = (short)1020971875;
					switch (num5 == num4)
					{
					}
					num4 = (short)1620770817;
					if (num4 != 0)
					{
					}
					num4 = (short)851836928;
					if (num4 != 0)
					{
					}
					num4 = (short)1991770112;
					short num6 = num4;
					return string.Empty;
				});
			}
			set
			{
				short num = (short)1109047377;
				short num2 = num;
				num = (short)1732819025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1361641472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)521142272;
				if (num != 0)
				{
				}
				num = (short)633470977;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0009B914 File Offset: 0x00099B14
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0009BA1C File Offset: 0x00099C1C
		public string RDate
		{
			get
			{
				short num = (short)550073544;
				short num2 = num;
				num = (short)1393718472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)268042240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)497549313;
				if (num != 0)
				{
				}
				num = (short)2032336896;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)520945665;
					if (num4 != 0)
					{
					}
					num4 = (short)135223556;
					short num5 = num4;
					num4 = (short)82139396;
					switch (num5 == num4)
					{
					}
					num4 = (short)1100677120;
					if (num4 != 0)
					{
					}
					num4 = (short)32702464;
					short num6 = num4;
					return string.Empty;
				}, delegate()
				{
					short num4 = (short)575392765;
					short num5 = num4;
					num4 = (short)1676463101;
					switch (num5 == num4)
					{
					}
					num4 = (short)1742667777;
					if (num4 != 0)
					{
					}
					num4 = (short)1405091840;
					if (num4 != 0)
					{
					}
					num4 = (short)1776549888;
					short num6 = num4;
					return string.Empty;
				}, new global::System.Func<string>(this.d));
			}
			set
			{
				short num = (short)728043962;
				short num2 = num;
				num = (short)1168314810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890109952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529741313;
				if (num != 0)
				{
				}
				num = (short)127139840;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)1549495735;
					short num5 = num4;
					num4 = (short)1574137271;
					switch (num5 == num4)
					{
					}
					num4 = (short)1350303745;
					if (num4 != 0)
					{
					}
					num4 = (short)311820288;
					if (num4 != 0)
					{
					}
					num4 = (short)1082720256;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)93358328;
					short num5 = num4;
					num4 = (short)1849788664;
					switch (num5 == num4)
					{
					}
					num4 = (short)222167041;
					if (num4 != 0)
					{
					}
					num4 = (short)1358954496;
					if (num4 != 0)
					{
					}
					num4 = (short)1914109952;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)264936069;
					short num5 = num4;
					num4 = (short)369203845;
					switch (num5 == num4)
					{
					}
					num4 = (short)1369571328;
					if (num4 != 0)
					{
					}
					num4 = (short)346161152;
					short num6 = num4;
					num4 = (short)975241217;
					if (num4 != 0)
					{
					}
					this.PcrFirmwareCodeplugPairGroupSummary.RDate = (value ?? string.Empty);
				});
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0009BB34 File Offset: 0x00099D34
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0009BBE8 File Offset: 0x00099DE8
		public int Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1915887391;
				short num2 = num;
				num = (short)630923039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3473408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1853358080;
				if (num != 0)
				{
				}
				num = (short)1488322561;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)799705695;
				short num2 = num;
				num = (short)298879583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746979328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1140260864;
				if (num != 0)
				{
				}
				num = (short)553254913;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0009BC98 File Offset: 0x00099E98
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0009BF1C File Offset: 0x0009A11C
		public int ReferencesInConfiguration
		{
			get
			{
				short num = (short)537067520;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					int result;
					for (;;)
					{
						IL_27:
						global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary pcrfirmwareCodeplugPairGroupSummary;
						int? referenceCountInConfiguration;
						switch (num2)
						{
						case 0:
							if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
							{
								num = (short)1571225601;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1717239812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1D2;
						case 2:
							referenceCountInConfiguration = pcrfirmwareCodeplugPairGroupSummary.ReferenceCountInConfiguration;
							result = referenceCountInConfiguration.Value;
							num = (short)949551111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary;
							referenceCountInConfiguration = astrofirmwareSummary.ReferenceCountInConfiguration;
							result = referenceCountInConfiguration.Value;
							num = (short)1561001992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)705822721;
							if (num != 0)
							{
							}
							if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
							{
								num = (short)70713353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 5:
							if (referenceCountInConfiguration != null)
							{
								num = (short)1394802690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 6:
						{
							if (referenceCountInConfiguration == null)
							{
								return result;
							}
							num = (short)1772197436;
							short num3 = num;
							num = (short)867997244;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D2;
							default:
							{
								num = (short)1376714752;
								short num4 = num;
								num = (short)861601792;
								if (num != 0)
								{
								}
								num = (short)1043267587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 7:
							return result;
						case 8:
							return result;
						case 9:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary;
							referenceCountInConfiguration = astrofirmwareSummary.ReferenceCountInConfiguration;
							num = (short)139001862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_56;
						IL_1D2:
						pcrfirmwareCodeplugPairGroupSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary);
						referenceCountInConfiguration = pcrfirmwareCodeplugPairGroupSummary.ReferenceCountInConfiguration;
						num = (short)1995309061;
						num2 = (int)((global::System.IntPtr)num);
					}
					return result;
					IL_56:
					result = 0;
					num = (short)11993088;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			set
			{
				short num = (short)1194221486;
				short num2 = num;
				num = (short)1162370990;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_89:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					break;
				default:
				{
					num = (short)1576534016;
					short num3 = num;
					num = (short)484769792;
					if (num != 0)
					{
					}
					num = (short)265945089;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_93:
					switch (num4)
					{
					case 0:
						goto IL_CE;
					case 1:
						goto IL_89;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary;
						astrofirmwareSummary.ReferenceCountInConfiguration = new int?(value);
						num = (short)1437007876;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)23396353;
						if (num != 0)
						{
						}
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
						{
							num = (short)2114322434;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					}
					goto IL_AD;
				}
				IL_CE:
				global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary pcrfirmwareCodeplugPairGroupSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary;
				pcrfirmwareCodeplugPairGroupSummary.ReferenceCountInConfiguration = new int?(value);
				return;
				IL_AD:
				if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
				{
					num = (short)338952192;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_93;
				}
				num = (short)975699971;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0009C0B0 File Offset: 0x0009A2B0
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0009C330 File Offset: 0x0009A530
		public int ReferencesInTemplate
		{
			get
			{
				short num = (short)565379072;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					int result;
					for (;;)
					{
						IL_27:
						global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary pcrfirmwareCodeplugPairGroupSummary;
						int? referenceCountInTemplate;
						switch (num2)
						{
						case 0:
							if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
							{
								num = (short)506200065;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1671692292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1CC;
						case 2:
							referenceCountInTemplate = pcrfirmwareCodeplugPairGroupSummary.ReferenceCountInTemplate;
							result = referenceCountInTemplate.Value;
							num = (short)577568775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							num = (short)505741313;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary;
							referenceCountInTemplate = astrofirmwareSummary.ReferenceCountInTemplate;
							result = referenceCountInTemplate.Value;
							num = (short)1175191560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
							{
								num = (short)791674889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 5:
							if (referenceCountInTemplate != null)
							{
								num = (short)2079457282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 6:
						{
							if (referenceCountInTemplate == null)
							{
								return result;
							}
							num = (short)1751876588;
							short num3 = num;
							num = (short)1630634988;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1CC;
							default:
							{
								num = (short)1586298880;
								short num4 = num;
								num = (short)178585600;
								if (num != 0)
								{
								}
								num = (short)1114243075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 7:
							return result;
						case 8:
							return result;
						case 9:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary;
							referenceCountInTemplate = astrofirmwareSummary.ReferenceCountInTemplate;
							num = (short)1363607558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_56;
						IL_1CC:
						pcrfirmwareCodeplugPairGroupSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary);
						referenceCountInTemplate = pcrfirmwareCodeplugPairGroupSummary.ReferenceCountInTemplate;
						num = (short)1581973509;
						num2 = (int)((global::System.IntPtr)num);
					}
					return result;
					IL_56:
					result = 0;
					num = (short)471859200;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			set
			{
				short num = (short)87937856;
				short num2 = num;
				num = (short)579130176;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_88:
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					break;
				default:
				{
					num = (short)1864302592;
					short num3 = num;
					num = (short)322699264;
					if (num != 0)
					{
					}
					num = (short)1990459393;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_92:
					switch (num4)
					{
					case 0:
						goto IL_CD;
					case 1:
						goto IL_88;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary;
						astrofirmwareSummary.ReferenceCountInTemplate = new int?(value);
						num = (short)49741828;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
						{
							num = (short)1706819586;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					}
					goto IL_AC;
				}
				IL_CD:
				num = (short)1849819137;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary pcrfirmwareCodeplugPairGroupSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary;
				pcrfirmwareCodeplugPairGroupSummary.ReferenceCountInTemplate = new int?(value);
				return;
				IL_AC:
				if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
				{
					num = (short)1928986624;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_92;
				}
				num = (short)2141847555;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_92;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0009C4B8 File Offset: 0x0009A6B8
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0009C5B8 File Offset: 0x0009A7B8
		public string BaseVersion
		{
			get
			{
				short num = (short)508035073;
				if (num != 0)
				{
				}
				num = (short)1786118144;
				short num2 = num;
				num = (short)1974629361;
				short num3 = num;
				num = (short)606958577;
				switch (num3 == num)
				{
				}
				num = (short)1696268288;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)836650529;
					short num5 = num4;
					num4 = (short)1151026721;
					switch (num5 == num4)
					{
					}
					num4 = (short)858980353;
					if (num4 != 0)
					{
					}
					num4 = (short)1629814784;
					if (num4 != 0)
					{
					}
					num4 = (short)1774518272;
					short num6 = num4;
					return string.Empty;
				}, new global::System.Func<string>(this.c), delegate()
				{
					short num4 = (short)1319594462;
					short num5 = num4;
					num4 = (short)290482654;
					switch (num5 == num4)
					{
					}
					num4 = (short)1690959873;
					if (num4 != 0)
					{
					}
					num4 = (short)331874304;
					if (num4 != 0)
					{
					}
					num4 = (short)966328320;
					short num6 = num4;
					return string.Empty;
				});
			}
			set
			{
				short num = (short)1883373569;
				if (num != 0)
				{
				}
				num = (short)936640512;
				short num2 = num;
				num = (short)1142437876;
				short num3 = num;
				num = (short)1597847540;
				switch (num3 == num)
				{
				}
				num = (short)1208483840;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)903247348;
					short num5 = num4;
					num4 = (short)1054701044;
					switch (num5 == num4)
					{
					}
					num4 = (short)2060910593;
					if (num4 != 0)
					{
					}
					num4 = (short)471400448;
					if (num4 != 0)
					{
					}
					num4 = (short)1977942016;
					short num6 = num4;
				}, delegate()
				{
					short num4 = (short)1965219897;
					short num5 = num4;
					num4 = (short)118480953;
					switch (num5 == num4)
					{
					}
					num4 = (short)618332161;
					if (num4 != 0)
					{
					}
					num4 = (short)895746048;
					short num6 = num4;
					num4 = (short)1534066688;
					if (num4 != 0)
					{
					}
					this.AstroFirmwareSummary.BaseSoftwareVersion = value;
				}, delegate()
				{
					short num4 = (short)380939308;
					short num5 = num4;
					num4 = (short)2034674732;
					switch (num5 == num4)
					{
					}
					num4 = (short)19398657;
					if (num4 != 0)
					{
					}
					num4 = (short)1817706496;
					if (num4 != 0)
					{
					}
					num4 = (short)1387069440;
					short num6 = num4;
				});
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0009C6D0 File Offset: 0x0009A8D0
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0009C780 File Offset: 0x0009A980
		public string VValue
		{
			get
			{
				short num = (short)347340801;
				if (num != 0)
				{
				}
				num = (short)933494784;
				short num2 = num;
				num = (short)593568669;
				short num3 = num;
				num = (short)1058284445;
				switch (num3 == num)
				{
				}
				num = (short)811859968;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1141621666;
				short num2 = num;
				num = (short)1957741474;
				switch (num2 == num)
				{
				}
				num = (short)1485766656;
				short num3 = num;
				num = (short)880738305;
				if (num != 0)
				{
				}
				num = (short)2009333760;
				if (num != 0)
				{
				}
				this.a = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware.get_VValue())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0009C864 File Offset: 0x0009AA64
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0009C964 File Offset: 0x0009AB64
		public string Release
		{
			get
			{
				short num = (short)1684209665;
				if (num != 0)
				{
				}
				num = (short)1550158956;
				short num2 = num;
				num = (short)371297388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)376045568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436352512;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)1451451284;
					short num5 = num4;
					num4 = (short)112550804;
					switch (num5 == num4)
					{
					}
					num4 = (short)1274150912;
					if (num4 != 0)
					{
					}
					num4 = (short)1623719937;
					if (num4 != 0)
					{
					}
					num4 = (short)568524800;
					short num6 = num4;
					return string.Empty;
				}, new global::System.Func<string>(this.b), delegate()
				{
					short num4 = (short)1265205542;
					short num5 = num4;
					num4 = (short)861176102;
					switch (num5 == num4)
					{
					}
					num4 = (short)976355329;
					if (num4 != 0)
					{
					}
					num4 = (short)235470848;
					if (num4 != 0)
					{
					}
					num4 = (short)2062680064;
					short num6 = num4;
					return string.Empty;
				});
			}
			set
			{
				short num = (short)669450241;
				if (num != 0)
				{
				}
				num = (short)439504467;
				short num2 = num;
				num = (short)814632531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243400704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)561840128;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)1981913994;
					short num5 = num4;
					num4 = (short)1753717642;
					switch (num5 == num4)
					{
					}
					num4 = (short)1271529472;
					if (num4 != 0)
					{
					}
					num4 = (short)948436992;
					short num6 = num4;
					num4 = (short)1338310657;
					if (num4 != 0)
					{
					}
				}, delegate()
				{
					short num4 = (short)1587150849;
					if (num4 != 0)
					{
					}
					num4 = (short)486993407;
					short num5 = num4;
					num4 = (short)374140415;
					switch (num5 == num4)
					{
					}
					num4 = (short)810876928;
					short num6 = num4;
					num4 = (short)135200768;
					if (num4 != 0)
					{
					}
					this.AstroFirmwareSummary.TargetRelease = value;
				}, delegate()
				{
					short num4 = (short)1413560274;
					short num5 = num4;
					num4 = (short)1770338258;
					switch (num5 == num4)
					{
					}
					num4 = (short)1521811456;
					if (num4 != 0)
					{
					}
					num4 = (short)2133000192;
					short num6 = num4;
					num4 = (short)1018429441;
					if (num4 != 0)
					{
					}
				});
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0009CA78 File Offset: 0x0009AC78
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0009CB7C File Offset: 0x0009AD7C
		public string MaxCodeplug
		{
			get
			{
				short num = (short)439746561;
				if (num != 0)
				{
				}
				num = (short)1445236452;
				short num2 = num;
				num = (short)1127780068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966604288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982122496;
				if (num != 0)
				{
				}
				return this.a<string>(delegate()
				{
					short num4 = (short)1109852161;
					if (num4 != 0)
					{
					}
					num4 = (short)1668591276;
					short num5 = num4;
					num4 = (short)1317449388;
					switch (num5 == num4)
					{
					}
					num4 = (short)1324875776;
					short num6 = num4;
					num4 = (short)1120927744;
					if (num4 != 0)
					{
					}
					return string.Empty;
				}, new global::System.Func<string>(this.a), delegate()
				{
					short num4 = (short)78256268;
					short num5 = num4;
					num4 = (short)591730828;
					switch (num5 == num4)
					{
					}
					num4 = (short)1410990081;
					if (num4 != 0)
					{
					}
					num4 = (short)1272840192;
					short num6 = num4;
					num4 = (short)1514078208;
					if (num4 != 0)
					{
					}
					return string.Empty;
				});
			}
			set
			{
				short num = (short)1827733505;
				if (num != 0)
				{
				}
				num = (short)1827913968;
				short num2 = num;
				num = (short)251576560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036334592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168624128;
				if (num != 0)
				{
				}
				this.a(delegate()
				{
					short num4 = (short)343179322;
					short num5 = num4;
					num4 = (short)1056997434;
					switch (num5 == num4)
					{
					}
					num4 = (short)287571969;
					if (num4 != 0)
					{
					}
					num4 = (short)1002438656;
					short num6 = num4;
					num4 = (short)1905655808;
					if (num4 != 0)
					{
					}
				}, delegate()
				{
					short num4 = (short)970080750;
					short num5 = num4;
					num4 = (short)23347694;
					switch (num5 == num4)
					{
					}
					num4 = (short)76349441;
					if (num4 != 0)
					{
					}
					num4 = (short)658374656;
					short num6 = num4;
					num4 = (short)1434976256;
					if (num4 != 0)
					{
					}
					this.AstroFirmwareSummary.MaxCodeplugVersion = value;
				}, delegate()
				{
					short num4 = (short)1677787179;
					short num5 = num4;
					num4 = (short)1652162603;
					switch (num5 == num4)
					{
					}
					num4 = (short)1612644353;
					if (num4 != 0)
					{
					}
					num4 = (short)1064632320;
					short num6 = num4;
					num4 = (short)757989376;
					if (num4 != 0)
					{
					}
				});
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0009CC90 File Offset: 0x0009AE90
		private global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary AstroFirmwareSummary
		{
			get
			{
				short num = (short)233052892;
				short num2 = num;
				num = (short)2045319900;
				switch (num2 == num)
				{
				}
				num = (short)1254621184;
				short num3 = num;
				num = (short)872677376;
				if (num != 0)
				{
				}
				num = (short)591396865;
				if (num != 0)
				{
				}
				return base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0009CD44 File Offset: 0x0009AF44
		private global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary PcrFirmwareCodeplugPairGroupSummary
		{
			get
			{
				short num = (short)1642689541;
				short num2 = num;
				num = (short)1276277765;
				switch (num2 == num)
				{
				}
				num = (short)1873870848;
				short num3 = num;
				num = (short)1932591105;
				if (num != 0)
				{
				}
				num = (short)499515392;
				if (num != 0)
				{
				}
				return base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0009CDF8 File Offset: 0x0009AFF8
		private global::Motorola.CommonCPS.Server.EntityModel.PBBFirmwareSummary PBBFirmwareSummary
		{
			get
			{
				short num = (short)866419820;
				short num2 = num;
				num = (short)911574124;
				switch (num2 == num)
				{
				}
				num = (short)2061041664;
				short num3 = num;
				num = (short)1676148737;
				if (num != 0)
				{
				}
				num = (short)491978752;
				if (num != 0)
				{
				}
				return base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PBBFirmwareSummary;
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0009CEAC File Offset: 0x0009B0AC
		public int CompareTo(object obj)
		{
			int a_ = 3;
			short num = (short)1721892865;
			if (num != 0)
			{
			}
			num = (short)459145216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1942618112;
				short num3 = num;
				int result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D6;
					}
					string strA;
					string strB;
					string strA2;
					string strB2;
					for (;;)
					{
						IL_87:
						switch (num2)
						{
						case 0:
							if (string.Compare(strA, strB, global::System.StringComparison.Ordinal) > 0)
							{
								num = (short)450232329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1623654414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							result = 1;
							num = (short)1551564803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_38D;
						case 3:
							goto IL_38D;
						case 4:
							if (string.Equals(strA2, strB2, global::System.StringComparison.Ordinal))
							{
								num = (short)228327435;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38D;
						case 5:
							goto IL_38D;
						case 6:
							result = -1;
							num = (short)683868165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_38D;
						case 8:
							result = 0;
							num = (short)1813970951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							result = -1;
							num = (short)586416130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (string.Compare(strA2, strB2, global::System.StringComparison.Ordinal) < 0)
							{
								num = (short)1834876945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1576927236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)394067968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (string.Compare(strA2, strB2, global::System.StringComparison.Ordinal) > 0)
							{
								num = (short)1061945350;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1947861002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_38D;
						case 14:
							if (string.Compare(strA, strB, global::System.StringComparison.Ordinal) < 0)
							{
								num = (short)1875312641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17C;
						case 15:
						{
							if (!string.Equals(strA, strB, global::System.StringComparison.Ordinal))
							{
								goto IL_38D;
							}
							num = (short)1233311253;
							short num4 = num;
							num = (short)384161301;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17C;
							default:
								num = (short)134217728;
								if (num != 0)
								{
								}
								num = (short)1600258056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							goto IL_3A5;
						case 17:
							result = 1;
							num = (short)866779149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
						IL_17C:
						num = (short)1682440207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38D:
						num = (short)313720848;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3A5:
					return result;
					IL_D6:
					global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware = obj as global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware;
					strA = this.Version[0].ToString();
					strB = firmware.ToString();
					strA2 = this.Version.Substring(1);
					strB2 = firmware.Version.Substring(1);
					num = (short)1511522316;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_87;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("紽⼿⽁㑃❅㩇⽉汋⭍⡏ㅑㅓ♕ⱗ㍙㍛そ", a_), ex.InnerException);
				}
				return result;
			}
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0009D29C File Offset: 0x0009B49C
		private static global::Motorola.CommonCPS.Server.EntityModel.PackageSummary t()
		{
			short num = (short)1198301749;
			short num2 = num;
			num = (short)305570357;
			switch (num2 == num)
			{
			}
			num = (short)1775697920;
			short num3 = num;
			num = (short)890765312;
			if (num != 0)
			{
			}
			num = (short)1381171201;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary();
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0009D348 File Offset: 0x0009B548
		private a a<a>(global::System.Func<a> A_0, global::System.Func<a> A_1, global::System.Func<a> A_2)
		{
			short num = (short)1176633347;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)941984862;
					short num3 = num;
					num = (short)2115865694;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8B;
					case 1:
						goto IL_106;
					}
					goto Block_2;
				}
				case 1:
					goto IL_A2;
				case 2:
					num = (short)1460862977;
					if (num != 0)
					{
					}
					if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
					{
						num = (short)77070336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)909508613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					goto IL_60;
				case 5:
					if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
					{
						goto IL_8B;
					}
					goto IL_19A;
				}
				IL_3C:
				if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PBBFirmwareSummary)
				{
					num = (short)896466948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1433534466;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B:
				num = (short)1952382977;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_60:
			return A_0();
			IL_A2:
			return A_2();
			Block_2:
			num = (short)1311375360;
			short num4 = num;
			IL_106:
			num = (short)1445855232;
			if (num != 0)
			{
			}
			return A_1();
			IL_19A:
			return default(a);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		private void a(global::System.Action A_0, global::System.Action A_1, global::System.Action A_2)
		{
			short num = (short)1460862979;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_190;
				case 1:
					goto IL_18E;
				case 2:
					A_2();
					num = (short)865796097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 4:
					if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
					{
						num = (short)210698246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)611713031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1633205269;
					short num3 = num;
					num = (short)1440267285;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					default:
						num = (short)500498432;
						if (num != 0)
						{
						}
						num = (short)165871617;
						if (num != 0)
						{
						}
						A_0();
						num = (short)1576206336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_1CE;
				case 7:
					if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
					{
						num = (short)1914634242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_45:
				if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PBBFirmwareSummary)
				{
					num = (short)1311178757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_190:
				num = (short)279773188;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_18E:
			return;
			IL_1CE:
			num = (short)486539264;
			short num4 = num;
			A_1();
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0009D6D8 File Offset: 0x0009B8D8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string s()
		{
			short num = (short)701831211;
			short num2 = num;
			num = (short)900077611;
			switch (num2 == num)
			{
			}
			num = (short)1737162752;
			short num3 = num;
			num = (short)380043265;
			if (num != 0)
			{
			}
			num = (short)1572864;
			if (num != 0)
			{
			}
			return this.PBBFirmwareSummary.PackageVersion;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0009D790 File Offset: 0x0009B990
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string r()
		{
			short num = (short)876093225;
			short num2 = num;
			num = (short)303111977;
			switch (num2 == num)
			{
			}
			num = (short)105906176;
			short num3 = num;
			num = (short)1244200961;
			if (num != 0)
			{
			}
			num = (short)361758720;
			if (num != 0)
			{
			}
			return this.AstroFirmwareSummary.PackageVersion;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0009D848 File Offset: 0x0009BA48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string q()
		{
			short num = (short)960455147;
			short num2 = num;
			num = (short)1051156971;
			switch (num2 == num)
			{
			}
			num = (short)141885440;
			short num3 = num;
			num = (short)1186004993;
			if (num != 0)
			{
			}
			num = (short)1721434112;
			if (num != 0)
			{
			}
			return this.PcrFirmwareCodeplugPairGroupSummary.FirmwareVersion;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0009D900 File Offset: 0x0009BB00
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string p()
		{
			while (this.PBBFirmwareSummary.FileSize != null)
			{
				short num = (short)1051915842;
				short num2 = num;
				num = (short)2068837954;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)89325568;
					short num3 = num;
					num = (short)1212022784;
					if (num != 0)
					{
					}
					num = (short)1425866753;
					if (num != 0)
					{
					}
					return this.PBBFirmwareSummary.FileSize.ToString();
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0009D9E4 File Offset: 0x0009BBE4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string o()
		{
			while (this.AstroFirmwareSummary.FileSize != null)
			{
				short num = (short)558470130;
				short num2 = num;
				num = (short)1148687346;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1429667840;
					short num3 = num;
					num = (short)1141243905;
					if (num != 0)
					{
					}
					num = (short)1903558656;
					if (num != 0)
					{
					}
					return this.AstroFirmwareSummary.FileSize.ToString();
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0009DAC8 File Offset: 0x0009BCC8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string n()
		{
			short num = (short)1608942398;
			short num2 = num;
			num = (short)737772350;
			switch (num2 == num)
			{
			}
			num = (short)1373896704;
			short num3 = num;
			num = (short)83034112;
			if (num != 0)
			{
			}
			num = (short)1472593921;
			if (num != 0)
			{
			}
			return this.PcrFirmwareCodeplugPairGroupSummary.Size;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0009DB7C File Offset: 0x0009BD7C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string m()
		{
			while (!string.IsNullOrWhiteSpace(this.PBBFirmwareSummary.Comment))
			{
				short num = (short)1933276447;
				short num2 = num;
				num = (short)1617065247;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)194904064;
					short num3 = num;
					num = (short)1881800705;
					if (num != 0)
					{
					}
					num = (short)149094400;
					if (num != 0)
					{
					}
					return this.PBBFirmwareSummary.Comment.Trim();
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0009DC50 File Offset: 0x0009BE50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string l()
		{
			while (!string.IsNullOrWhiteSpace(this.AstroFirmwareSummary.Comment))
			{
				short num = (short)2017460225;
				if (num != 0)
				{
				}
				num = (short)262435316;
				short num2 = num;
				num = (short)1047425524;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)570753024;
					short num3 = num;
					break;
				}
				}
				num = (short)1929379840;
				if (num != 0)
				{
				}
				return this.AstroFirmwareSummary.Comment.Trim();
			}
			return string.Empty;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0009DD28 File Offset: 0x0009BF28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string k()
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			bool? isUpdating;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_14E;
				case 1:
				{
					num2 = (short)331046421;
					short num3 = num2;
					num2 = (short)2142920213;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_187;
					}
					break;
				}
				case 2:
					if (isUpdating.Value)
					{
						num2 = (short)18939904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9E;
				case 3:
					if (isUpdating != null)
					{
						num2 = (short)1940914176;
						short num4 = num2;
						num2 = (short)717881348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9E;
				case 4:
					isUpdating = this.PcrFirmwareCodeplugPairGroupSummary.IsUpdating;
					num2 = (short)2016215042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!string.IsNullOrWhiteSpace(base.SummaryEntity.Comment))
					{
						num2 = (short)1898315777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D4;
				}
				goto IL_31;
				IL_9E:
				num2 = (short)289275909;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14E:
			return this.PcrFirmwareCodeplugPairGroupSummary.Comment + global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("扁", a_) + global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_UnexpectErrorAferImportPcrFwPackage;
			IL_187:
			num2 = (short)192544769;
			if (num2 != 0)
			{
			}
			num2 = (short)1318191104;
			if (num2 != 0)
			{
			}
			return base.SummaryEntity.Comment.Trim();
			IL_1D4:
			return string.Empty;
			IL_31:
			isUpdating = this.PcrFirmwareCodeplugPairGroupSummary.IsUpdating;
			num2 = (short)2013200387;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0009DF10 File Offset: 0x0009C110
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j()
		{
			short num = (short)1903276914;
			short num2 = num;
			num = (short)1108325234;
			switch (num2 == num)
			{
			}
			num = (short)1437138944;
			short num3 = num;
			num = (short)50921473;
			if (num != 0)
			{
			}
			num = (short)1365508096;
			if (num != 0)
			{
			}
			return this.PcrFirmwareCodeplugPairGroupSummary.CodeplugVersion ?? string.Empty;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0009DFD0 File Offset: 0x0009C1D0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i()
		{
			short num = (short)1396390743;
			short num2 = num;
			num = (short)686701399;
			switch (num2 == num)
			{
			}
			num = (short)29884416;
			short num3 = num;
			num = (short)350683136;
			if (num != 0)
			{
			}
			num = (short)180158465;
			if (num != 0)
			{
			}
			return this.AstroFirmwareSummary.MaceFlashVersion ?? string.Empty;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0009E090 File Offset: 0x0009C290
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h()
		{
			short num = (short)1746567919;
			short num2 = num;
			num = (short)1461945071;
			switch (num2 == num)
			{
			}
			num = (short)817627136;
			short num3 = num;
			num = (short)888209409;
			if (num != 0)
			{
			}
			num = (short)658767872;
			if (num != 0)
			{
			}
			return this.AstroFirmwareSummary.IsFreonFirmwareUpgradeFile.GetValueOrDefault();
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0009E14C File Offset: 0x0009C34C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g()
		{
			short num = (short)666449375;
			short num2 = num;
			num = (short)22164959;
			switch (num2 == num)
			{
			}
			num = (short)678887424;
			short num3 = num;
			num = (short)1101135873;
			if (num != 0)
			{
			}
			num = (short)865140736;
			if (num != 0)
			{
			}
			return this.AstroFirmwareSummary.IsOMAPFirmwareUpgradeFile.GetValueOrDefault();
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0009E208 File Offset: 0x0009C408
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f()
		{
			int a_ = 2;
			short num = (short)993525760;
			short num2 = num;
			num = (short)82247686;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (global::CommonUtility.BundleNameUtility.IsNextBundle(this.AstroFirmwareSummary.TargetModel))
					{
						num = (short)34471938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1364459531;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1D9;
				case 2:
					goto IL_224;
				case 3:
					if (global::CommonUtility.BundleNameUtility.IsPortableBBF(this.AstroFirmwareSummary.TargetModel))
					{
						num = (short)2088435719;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)664731656;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)881852417;
					if (num != 0)
					{
					}
					if (!(this.AstroFirmwareSummary.TargetModel.Substring(0, 1).ToUpper(global::System.Globalization.CultureInfo.CurrentCulture) == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("甼", a_)))
					{
						num = (short)1193541637;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22F;
				case 5:
					num = (short)724828163;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 7:
					goto IL_277;
				case 8:
					if (global::CommonUtility.BundleNameUtility.IsMegaBundle(this.AstroFirmwareSummary.TargetModel))
					{
						num = (short)1850343434;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1346895872;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_A8;
				case 10:
					goto IL_2BD;
				case 11:
					if (global::CommonUtility.BundleNameUtility.IsAlohaBundle(this.AstroFirmwareSummary.TargetModel))
					{
						num = (short)1005912065;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C2;
				}
				IL_85:
				if (this.AstroFirmwareSummary.TargetModel == null)
				{
					num = (short)1227554825;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)609157124;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A8:
			goto IL_1DB;
			IL_1D9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Aloha;
			IL_1DB:
			return string.Empty;
			IL_224:
			num = (short)2043409650;
			short num4 = num;
			num = (short)887158002;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1DB;
			default:
				num = (short)1993998336;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ApxNext;
			}
			IL_22F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Portable;
			IL_277:
			goto IL_22F;
			IL_2BD:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.BothPortableAndMobile;
			IL_2C2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Mobile;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0009E4DC File Offset: 0x0009C6DC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e()
		{
			int a_ = 2;
			short num = (short)266272769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)63221029;
					short num3 = num;
					num = (short)938388773;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_100;
					default:
						num = (short)990904320;
						if (num != 0)
						{
						}
						if (this.PBBFirmwareSummary.ModelNumber == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("猼࠾煀獂瑄", a_))
						{
							num = (short)1779499010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D2;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_198;
				case 3:
					goto IL_75;
				}
				IL_3D:
				if (this.PBBFirmwareSummary.ModelNumber == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渼瘾慀၂DᕆH๊Ṍ潎ݐRᡔ", a_))
				{
					num = (short)354746371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_100:
				num = (short)1343160320;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_75:
			num = (short)1508900865;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("䘼༾㱀捂浄㱆硈㙊摌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渼嘾瑀獂畄", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("甼琾獀獂獄畆ࡈ", a_));
			IL_198:
			num = (short)1921318912;
			short num4 = num;
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("䘼༾㱀捂浄㱆硈㙊摌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渼嘾瑀獂畄", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("猼࠾煀獂瑄", a_));
			IL_1D2:
			return this.PBBFirmwareSummary.ModelNumber;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0009E6C8 File Offset: 0x0009C8C8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d()
		{
			short num = (short)635497228;
			short num2 = num;
			num = (short)2023549708;
			switch (num2 == num)
			{
			}
			num = (short)2010972161;
			if (num != 0)
			{
			}
			num = (short)2000748544;
			if (num != 0)
			{
			}
			num = (short)1909653504;
			short num3 = num;
			return this.PcrFirmwareCodeplugPairGroupSummary.RDate ?? string.Empty;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0009E78C File Offset: 0x0009C98C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c()
		{
			short num = (short)258883146;
			short num2 = num;
			num = (short)2021277258;
			switch (num2 == num)
			{
			}
			num = (short)1932328961;
			if (num != 0)
			{
			}
			num = (short)1927151616;
			if (num != 0)
			{
			}
			num = (short)537395200;
			short num3 = num;
			return this.AstroFirmwareSummary.BaseSoftwareVersion;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0009E844 File Offset: 0x0009CA44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b()
		{
			short num = (short)1933667383;
			short num2 = num;
			num = (short)1236757559;
			switch (num2 == num)
			{
			}
			num = (short)38338561;
			if (num != 0)
			{
			}
			num = (short)1916928000;
			if (num != 0)
			{
			}
			num = (short)758906880;
			short num3 = num;
			return this.AstroFirmwareSummary.TargetRelease;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0009E8FC File Offset: 0x0009CAFC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a()
		{
			short num = (short)1014574145;
			short num2 = num;
			num = (short)401288257;
			switch (num2 == num)
			{
			}
			num = (short)1250951169;
			if (num != 0)
			{
			}
			num = (short)1441792000;
			if (num != 0)
			{
			}
			num = (short)1012662272;
			short num3 = num;
			return this.AstroFirmwareSummary.MaxCodeplugVersion;
		}

		// Token: 0x040003AC RID: 940
		private string a;

		// Token: 0x040003AD RID: 941
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040003AE RID: 942
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
