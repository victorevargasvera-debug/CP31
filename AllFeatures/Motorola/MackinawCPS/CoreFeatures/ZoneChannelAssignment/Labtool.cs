using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x02000049 RID: 73
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0002E30C File Offset: 0x0002C50C
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0002E324 File Offset: 0x0002C524
		public override void Init()
		{
			int a_ = 14;
			short num = (short)526581761;
			if (num != 0)
			{
			}
			num = (short)2073670130;
			short num2 = num;
			num = (short)1788981746;
			switch (num2 == num)
			{
			}
			num = (short)1771765760;
			short num3 = num;
			num = (short)1720909824;
			if (num != 0)
			{
			}
			this.znChanCfgLabtoolLastSelectedChnl_A41075 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闎뿐郒뷔뛖럘飚믜룞균苢蟤鏦蛨蓪臬ꏮ郰胲致ꓶ鳸韺飼鳾甀昂愄䐆愈攊愌倎倐✒␔✖⸘⸚", a_), global::CommonResources.AcgResources.ID_LASTSELECTEDCHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.znChanCfgLabtoolLastSelectedChnl_A41075.IgnoreOnCompare = true;
			this.znChanCfgLabtoolLastSelectedChnl_A41075.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.znChanCfgLabtoolLastSelectedChnl_A41075.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菎냐뇒ꇔ룖뛘럚", a_);
			base.Id = 10711;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0002E460 File Offset: 0x0002C660
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1551040516;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)1028194306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FD;
				case 1:
					goto IL_90;
				case 2:
					num = (short)1233846278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.znChanCfgLabtoolLastSelectedChnl_A41075 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("韌ꇎ鋐믒듔맖高뷚뫜鏞胠臢釤裦蛨蟪ꇬ軮苰蟲꛴鋶闸黺黼课搀朂䘄漆月朊刌与┐−└‖Ⱈ", a_), global::CommonResources.AcgResources.ID_LASTSELECTEDCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.znChanCfgLabtoolLastSelectedChnl_A41075.IgnoreOnCompare = true;
					this.znChanCfgLabtoolLastSelectedChnl_A41075.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.znChanCfgLabtoolLastSelectedChnl_A41075.DataTransferOrder = -1;
					num = (short)267583493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					goto IL_105;
				case 6:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韌ꇎ鋐믒듔맖高뷚뫜鏞胠臢釤裦蛨蟪ꇬ軮苰蟲꛴鋶闸黺黼课搀朂䘄漆月朊刌与┐−└‖Ⱈ", a_)))
					{
						goto IL_1FD;
					}
					num = (short)1433141452;
					short num3 = num;
					num = (short)63701196;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						num = (short)1574240257;
						if (num != 0)
						{
						}
						num = (short)1047789568;
						if (num != 0)
						{
						}
						num = (short)2030174211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_49:
				num = (short)297992192;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1816592385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_90:
				num = (short)1760231424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_105:
			IL_1FD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臌껎돐꟒뫔룖뗘", a_);
			base.Id = 10711;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0002E69C File Offset: 0x0002C89C
		public override void PopulateReferences()
		{
			short num = (short)1868845218;
			short num2 = num;
			num = (short)1489391778;
			switch (num2 == num)
			{
			}
			num = (short)1650589697;
			if (num != 0)
			{
			}
			num = (short)1134034944;
			short num3 = num;
			num = (short)1694498816;
			if (num != 0)
			{
			}
			this.znChanCfgLabtoolLastSelectedChnl_A41075.SetRecset(base.Parent[10114].EmbeddedRecset);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0002E768 File Offset: 0x0002C968
		public override void DropReferences()
		{
			short num = (short)543165544;
			short num2 = num;
			num = (short)585960552;
			switch (num2 == num)
			{
			}
			num = (short)2064777217;
			if (num != 0)
			{
			}
			num = (short)1889861632;
			short num3 = num;
			num = (short)1474822144;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0002E810 File Offset: 0x0002CA10
		public override void SetConstraints()
		{
			short num = (short)1242949696;
			short num2 = num;
			num = (short)1158539328;
			switch (num2 == num)
			{
			}
			num = (short)1463943168;
			if (num != 0)
			{
			}
			num = (short)134873088;
			short num3 = num;
			num = (short)2048000001;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
		public override void SetupDependencies()
		{
			short num = (short)1882324996;
			short num2 = num;
			num = (short)896139268;
			switch (num2 == num)
			{
			}
			num = (short)135266305;
			if (num != 0)
			{
			}
			num = (short)1975189504;
			short num3 = num;
			num = (short)1543897088;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0002E960 File Offset: 0x0002CB60
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForZnChanCfgLabtoolLastSelectedChnl_A41075
		{
			get
			{
				short num = (short)1902071689;
				short num2 = num;
				num = (short)1908494217;
				switch (num2 == num)
				{
				}
				num = (short)1050673152;
				if (num != 0)
				{
				}
				num = (short)1638268928;
				short num3 = num;
				num = (short)1352400897;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0002EA18 File Offset: 0x0002CC18
		public bool HasDiffs
		{
			get
			{
				short num = (short)1772744823;
				short num2 = num;
				num = (short)1797255287;
				switch (num2 == num)
				{
				}
				num = (short)1553465345;
				if (num != 0)
				{
				}
				num = (short)134479872;
				short num3 = num;
				num = (short)1777729536;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0002EB78 File Offset: 0x0002CD78
		public int ZnChanCfgLabtoolLastSelectedChnl_A41075Value
		{
			get
			{
				short num = (short)1833780912;
				short num2 = num;
				num = (short)1929070256;
				switch (num2 == num)
				{
				}
				num = (short)1461190656;
				short num3 = num;
				num = (short)2072510465;
				if (num != 0)
				{
				}
				num = (short)1571749888;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.Value;
			}
			set
			{
				short num = (short)670864503;
				short num2 = num;
				num = (short)831100023;
				switch (num2 == num)
				{
				}
				num = (short)1780285440;
				short num3 = num;
				num = (short)1241251841;
				if (num != 0)
				{
				}
				num = (short)315752448;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.Value = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0002EC30 File Offset: 0x0002CE30
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0002ECE4 File Offset: 0x0002CEE4
		public string ZnChanCfgLabtoolLastSelectedChnl_A41075_UIValue
		{
			get
			{
				short num = (short)463741428;
				short num2 = num;
				num = (short)1582178804;
				switch (num2 == num)
				{
				}
				num = (short)131465216;
				short num3 = num;
				num = (short)347144192;
				if (num != 0)
				{
				}
				num = (short)1444085761;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.UIValue;
			}
			set
			{
				short num = (short)2110791752;
				short num2 = num;
				num = (short)1609703496;
				switch (num2 == num)
				{
				}
				num = (short)251527168;
				short num3 = num;
				num = (short)295698432;
				if (num != 0)
				{
				}
				num = (short)1670250497;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.UIValue = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0002ED98 File Offset: 0x0002CF98
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgLabtoolLastSelectedChnl_A41075
		{
			get
			{
				short num = (short)1466965275;
				short num2 = num;
				num = (short)107814171;
				switch (num2 == num)
				{
				}
				num = (short)46596096;
				short num3 = num;
				num = (short)312672257;
				if (num != 0)
				{
				}
				num = (short)1160904704;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0002EE48 File Offset: 0x0002D048
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0002EEFC File Offset: 0x0002D0FC
		public bool ZnChanCfgLabtoolLastSelectedChnl_A41075_Applicable
		{
			get
			{
				short num = (short)117341824;
				short num2 = num;
				num = (short)305299072;
				switch (num2 == num)
				{
				}
				num = (short)2016083968;
				short num3 = num;
				num = (short)205651969;
				if (num != 0)
				{
				}
				num = (short)1346371584;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.Applicable;
			}
			set
			{
				short num = (short)930414593;
				if (num != 0)
				{
				}
				num = (short)488493189;
				short num2 = num;
				num = (short)1169412229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1940717568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584267264;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.Applicable = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0002F06C File Offset: 0x0002D26C
		public bool ZnChanCfgLabtoolLastSelectedChnl_A41075_Valid
		{
			get
			{
				short num = (short)164032414;
				short num2 = num;
				num = (short)1471868830;
				switch (num2 == num)
				{
				}
				num = (short)1976958976;
				short num3 = num;
				num = (short)354156545;
				if (num != 0)
				{
				}
				num = (short)316211200;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.Valid;
			}
			set
			{
				short num = (short)1759444993;
				if (num != 0)
				{
				}
				num = (short)438601616;
				short num2 = num;
				num = (short)1245218704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1270546432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)143065088;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.Valid = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0002F124 File Offset: 0x0002D324
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
		public bool ZnChanCfgLabtoolLastSelectedChnl_A41075_Visible
		{
			get
			{
				short num = (short)1808937312;
				short num2 = num;
				num = (short)1665216864;
				switch (num2 == num)
				{
				}
				num = (short)1556611072;
				short num3 = num;
				num = (short)1847132161;
				if (num != 0)
				{
				}
				num = (short)83689472;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.Visible;
			}
			set
			{
				short num = (short)640586552;
				short num2 = num;
				num = (short)1464046392;
				switch (num2 == num)
				{
				}
				num = (short)1201012736;
				short num3 = num;
				num = (short)1381892097;
				if (num != 0)
				{
				}
				num = (short)1823670272;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.Visible = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0002F290 File Offset: 0x0002D490
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0002F344 File Offset: 0x0002D544
		public bool ZnChanCfgLabtoolLastSelectedChnl_A41075_Editable
		{
			get
			{
				short num = (short)103870637;
				short num2 = num;
				num = (short)1668804781;
				switch (num2 == num)
				{
				}
				num = (short)1125122048;
				short num3 = num;
				num = (short)2083782657;
				if (num != 0)
				{
				}
				num = (short)750518272;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.Editable;
			}
			set
			{
				short num = (short)2022610815;
				short num2 = num;
				num = (short)261068671;
				switch (num2 == num)
				{
				}
				num = (short)871890944;
				short num3 = num;
				num = (short)1478950912;
				if (num != 0)
				{
				}
				num = (short)555220993;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.Editable = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0002F3FC File Offset: 0x0002D5FC
		internal string ZnChanCfgLabtoolLastSelectedChnl_A41075_UILabel
		{
			get
			{
				short num = (short)1462501377;
				if (num != 0)
				{
				}
				num = (short)185886832;
				short num2 = num;
				num = (short)113272944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1613627392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)162004992;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.UIName;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0002F560 File Offset: 0x0002D760
		internal bool ZnChanCfgLabtoolLastSelectedChnl_A41075_HiddenStatic
		{
			get
			{
				short num = (short)1263796294;
				short num2 = num;
				num = (short)33161286;
				switch (num2 == num)
				{
				}
				num = (short)488374272;
				short num3 = num;
				num = (short)255328257;
				if (num != 0)
				{
				}
				num = (short)1114832896;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.HiddenStatic;
			}
			set
			{
				short num = (short)62863751;
				short num2 = num;
				num = (short)1162492295;
				switch (num2 == num)
				{
				}
				num = (short)1930690560;
				short num3 = num;
				num = (short)1219690497;
				if (num != 0)
				{
				}
				num = (short)1301807104;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.HiddenStatic = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0002F614 File Offset: 0x0002D814
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		internal bool ZnChanCfgLabtoolLastSelectedChnl_A41075_HiddenDynamic
		{
			get
			{
				short num = (short)1609492561;
				short num2 = num;
				num = (short)473557073;
				switch (num2 == num)
				{
				}
				num = (short)1644756992;
				short num3 = num;
				num = (short)522452992;
				if (num != 0)
				{
				}
				num = (short)2115895297;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075.HiddenDynamic;
			}
			set
			{
				short num = (short)66015278;
				short num2 = num;
				num = (short)1990545454;
				switch (num2 == num)
				{
				}
				num = (short)1018626048;
				short num3 = num;
				num = (short)938475521;
				if (num != 0)
				{
				}
				num = (short)1224146944;
				if (num != 0)
				{
				}
				this.znChanCfgLabtoolLastSelectedChnl_A41075.HiddenDynamic = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0002F77C File Offset: 0x0002D97C
		public bool ZnChanCfgLabtoolLastSelectedChnl_A41075_HasDiffs
		{
			get
			{
				short num = (short)266387255;
				short num2 = num;
				num = (short)1341964087;
				switch (num2 == num)
				{
				}
				num = (short)78446592;
				short num3 = num;
				num = (short)1180172288;
				if (num != 0)
				{
				}
				num = (short)448135169;
				if (num != 0)
				{
				}
				return this.znChanCfgLabtoolLastSelectedChnl_A41075._HasDiffs;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0002F82C File Offset: 0x0002DA2C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_D5;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1179451396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)702087169;
					if (num2 != 0)
					{
					}
					num2 = (short)209453056;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1408172032;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_F1;
				case 4:
					num2 = (short)733544451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_D5:
			return result;
			IL_24:
			num2 = (short)1055103286;
			short num4 = num2;
			num2 = (short)210540854;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F1:
				if (base.ParentRecset.ContainerDoc != null)
				{
					num2 = (short)690225154;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)783024128;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)2026635265;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x040000B6 RID: 182
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgLabtoolLastSelectedChnl_A41075;
	}
}
