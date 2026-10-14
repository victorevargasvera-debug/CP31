using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000047 RID: 71
	public class DBUpgradeProcessInfo : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00043278 File Offset: 0x00041478
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00043328 File Offset: 0x00041528
		public int CurrentResolverVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1261410522;
				short num2 = num;
				num = (short)736139482;
				switch (num2 == num)
				{
				}
				num = (short)1542127617;
				if (num != 0)
				{
				}
				num = (short)151060480;
				short num3 = num;
				num = (short)1373634560;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2020951816;
				short num2 = num;
				num = (short)819218184;
				switch (num2 == num)
				{
				}
				num = (short)1567686656;
				if (num != 0)
				{
				}
				num = (short)1438842880;
				short num3 = num;
				num = (short)81854465;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000433DC File Offset: 0x000415DC
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0004348C File Offset: 0x0004168C
		public bool IsInitialStructCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)282821059;
				short num2 = num;
				num = (short)1680769475;
				switch (num2 == num)
				{
				}
				num = (short)1962672128;
				if (num != 0)
				{
				}
				num = (short)2084962304;
				short num3 = num;
				num = (short)204734465;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1567704993;
				short num2 = num;
				num = (short)649611169;
				switch (num2 == num)
				{
				}
				num = (short)515440641;
				if (num != 0)
				{
				}
				num = (short)1265958912;
				short num3 = num;
				num = (short)1310130176;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00043540 File Offset: 0x00041740
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x000435F0 File Offset: 0x000417F0
		public bool IsFinalizeCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1838275282;
				short num2 = num;
				num = (short)1099356882;
				switch (num2 == num)
				{
				}
				num = (short)1309278209;
				if (num != 0)
				{
				}
				num = (short)966328320;
				short num3 = num;
				num = (short)1055260672;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1303511041;
				if (num != 0)
				{
				}
				num = (short)1278677171;
				short num2 = num;
				num = (short)1773211827;
				switch (num2 == num)
				{
				}
				num = (short)503054336;
				short num3 = num;
				num = (short)1244594176;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000436A4 File Offset: 0x000418A4
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00043754 File Offset: 0x00041954
		public string RecordType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1582528282;
				short num2 = num;
				num = (short)1201174298;
				switch (num2 == num)
				{
				}
				num = (short)628162561;
				if (num != 0)
				{
				}
				num = (short)940441600;
				short num3 = num;
				num = (short)40566784;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)280462396;
				short num2 = num;
				num = (short)652117052;
				switch (num2 == num)
				{
				}
				num = (short)768409600;
				if (num != 0)
				{
				}
				num = (short)2049441792;
				short num3 = num;
				num = (short)711917569;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00043804 File Offset: 0x00041A04
		public static int CleanData(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.DBUpgradeProcessInfo target)
		{
			int a_ = 6;
			global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("倃吅崇䐉伋伍䐏圑㐓䈕夗堙倛嬝\u001f䘡䘣䤥ا温渫笭䀯唱䘳圵尷弹氻䰽⼿⅁⅃㕅㭇͉≋⡍㽏", a_), sqlConnect);
			int result;
			short num;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				num = (short)1581776898;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						((global::System.IDisposable)sqlCommand).Dispose();
						num = (short)2006456765;
						short num3 = num;
						num = (short)273226173;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
							num = (short)1160904704;
							if (num != 0)
							{
							}
							num = (short)521994241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_E0;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					goto IL_5C;
					IL_62:
					num = (short)463667200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C:
					if (sqlCommand != null)
					{
						goto IL_62;
					}
					break;
				}
				IL_E0:;
			}
			num = (short)550830080;
			short num4 = num;
			num = (short)658833409;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00043958 File Offset: 0x00041B58
		public static int TriggerRadioSync(global::System.Data.SqlClient.SqlConnection sqlConnect, global::Motorola.CommonCPS.Server.EntityModel.DBUpgradeProcessInfo target)
		{
			int a_ = 16;
			short num = (short)43843584;
			switch (num)
			{
			default:
			{
				num = (short)1556021249;
				if (num != 0)
				{
				}
				string format = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("̍ᨏ㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอု䜱䐳刵夷丹夻ḽ㬿牁㥃晅䕇䁉汋湍灏牑瑓癕硗穙籛繝䁟䉡䑣䙥䡧䩩Ὣ୭ѯ剱祳籵塷婹屻幽ꁿꊁꒃꚅꢇꪉ겋꺍낏늑뒓뚕뢗몙벛뺝\udb9f銡\ud9a3袥\udfa9\udeab\udcad햯\udcb1삳ힷ풹\udabbힽꞿ럁뛃Ʂ볇ꏉꏋꃍ蛏럑ꛓꗕ뇗뗙닛距铟菡解雥헧쫩迫샭ꛯ韱蛳藵釷闹鋻귽瓿持椃瘅␇܉؋⸍』㈑㐓㘕㠗㨙㰛㸝\u001fȡУإࠧ਩ఫอုሱᐳ䴵࠷䜹ሻ眽㌿ുㅃ㉅݇ⱉὋ㝍㹏ㅑ楓癕啗偙籛繝䁟䉡䑣䙥䡧䩩䱫乭偯剱味噵塷婹屻幽ꁿꊁꒃꚅﾋ낏ﲓ몙낝톧쒩쾫톯욱햳\uddb7좹쾻ힽ꾿곁韃닅꧇Ꟊ볋럓诗ꏙ닛뷝ꓟ菡郣蟥뻧迩黫鷭駯鷱髳ꗵ賷鯹釻軽⃿洁瘃★稇␉䐋䄍怏昑紓礕瘗䰙礛氝匟䬡䬣䠥笧帩䴫䌭䀯ሱ࠳࠵嬷ᐹ琻焽〿㙁ⵃ⥅♇᱉⥋㱍⍏㭑㭓㡕ୗ⹙㵛㍝ၟ潡湣䙥䡧䩩䱫乭偯剱味噵塷婹屻幽ꁿꊁꒃꚅꢇꪉ겋꺍낏늑뒓ﾙ뺝醟芡솣쪥\udba7쾩貫麭붯뢱钳隵颷骹鲻麽龎ﳛﻝ藟賡胣쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿∁␃★⠇氉縋愍紏㈑漓☕攗㨙減ጝ⨟ȡУإࠧ਩ఫอုሱᐳᘵᠷᨹ᰻ḽ怿扁⡃⍅⹇㹉汋⑍㽏㭑㩓癕᭗㕙㉛㡝य़աᅣᑥ१ṩիŭṯ㝱౳ɵᵷᑹࡻ᝽ꒃꢇ꺍벑힓秊ﲙ劣햟킡얣튥솧얩슫ﮭ얯\udbb1킳讵\udbb7钹ﾻ톽꺿꓁귃ꇅ뷇룉귋뫍맏뷑뫓菕귗동룛폝싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9\udcfb\udefd⃿∁洃栅昇漉縋⸍稏紑紓砕㠗圙紛渝攟䰡倣伥尧䌩䤫崭ု弱ᐳ夵嘷ᨹ弻ွ̿ⵁ⩃⁅ⅇⵉ㥋㱍ㅏ♑㵓㥕㙗ཙ⥛㝝џ彡ॣ䡥㡧୩ṫ୭ṯٱⅳ⍵ㅷṹ屻ώꒃꚇ\uda89ﲍﲑ슕鍊ꎝ螟쮣좥캧쎩쮫\uddad鞯뾱뺳隵颷骹鲻麽뇗듙닛믝鋟싡軣觥臧蓩쳫ꫭ닯꟱蓳釵諷鯹飻鯽僿瀁欃攅洇礉缋䜍縏琑笓㘕洗㨙猛瀝\u001f伡ਣ攥䀧䌩䀫䨭支朱紳刵Է伹ሻ欽㔿⭁⁃晅⥇⑉⡋湍╏籑ᵓ╕ṗ㍙㉛㽝౟ୡṣͥ⭧թūṭᱯ᝱s፵ᱷ䝹䵻獽詿ꊁꒃꚅꢇꪉ겋꺍낏늑뒓뚕뢗몙벛뺝肟芡펣캥춧\ud8a9즫躭슯鲱\ud9b5횷\udcb9햻\ud9bd떿냁ꗃ닅ꇇꗉꋋ鯍ꗏ믑냓뇗꧙ﳛ냝迟雡쓣裥鷧蛩胫컭釯鳱郳훵諷퓹뿻诽狿瀁愃栅簇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡爣䌥娧天䔫䄭帯愱䀳圵唷䨹;=⌿汁ቃ⍅㩇㥉╋⅍㹏ő⁓㝕㕗⩙兛呝䁟䉡䑣䙥䡧䩩䱫乭偯剱味噵", a_);
				int num2 = 0;
				using (global::System.Collections.Generic.Dictionary<global::System.Type, string>.ValueCollection.Enumerator enumerator = global::Motorola.CommonCPS.Server.EntityModel.DBUpgradeProcessInfo.a.Values.GetEnumerator())
				{
					num = (short)1837891588;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1F8;
						case 1:
							goto IL_210;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1803812864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string arg = enumerator.Current;
							global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, arg), sqlConnect);
							num = (short)1727004675;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								global::System.Data.SqlClient.SqlCommand sqlCommand;
								sqlCommand.CommandTimeout = 180;
								num2 += sqlCommand.ExecuteNonQuery();
								break;
							}
							finally
							{
								num = (short)731578370;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Data.SqlClient.SqlCommand sqlCommand;
									switch (num3)
									{
									case 0:
										((global::System.IDisposable)sqlCommand).Dispose();
										num = (short)201981953;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1F5;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1BD;
										}
										continue;
									}
									IL_1BD:
									if (sqlCommand == null)
									{
										break;
									}
									num = (short)640614400;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1F5:;
							}
							goto IL_1F8;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						}
						IL_E3:
						num = (short)195921566;
						short num4 = num;
						num = (short)1276413598;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_210;
						default:
							num = (short)129957888;
							if (num != 0)
							{
							}
							num = (short)1769275394;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_AB:
						goto IL_E3;
						IL_1F8:
						num = (short)914489345;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_210:;
				}
				num = (short)312410112;
				short num5 = num;
				return num2;
			}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00043BF8 File Offset: 0x00041DF8
		// Note: this type is marked as 'beforefieldinit'.
		static DBUpgradeProcessInfo()
		{
			int a_ = 18;
			short num = (short)307797002;
			short num2 = num;
			num = (short)595565578;
			switch (num2 == num)
			{
			}
			num = (short)555745281;
			if (num != 0)
			{
			}
			num = (short)1495465984;
			short num3 = num;
			num = (short)661716992;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.DBUpgradeProcessInfo.a = new global::System.Collections.Generic.Dictionary<global::System.Type, string>
			{
				{
					typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("儏䈑䰓䐕礗縙甛焝猟圡䤣䬥䤧堩唫", a_)
				},
				{
					typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("崏猑怓搕焗戙丛缝䐟䬡䬣甥崧䜩䄫伭䈯䬱", a_)
				},
				{
					typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary),
					global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䀏們嘓䐕礗縙甛焝猟圡䤣䬥䤧堩唫", a_)
				}
			};
		}

		// Token: 0x040002F6 RID: 758
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, string> a;

		// Token: 0x040002F7 RID: 759
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x040002F8 RID: 760
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x040002F9 RID: 761
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x040002FA RID: 762
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;
	}
}
