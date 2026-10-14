using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E8 RID: 232
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002168 RID: 8552 RVA: 0x0020E810 File Offset: 0x0020CA10
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x0020E82C File Offset: 0x0020CA2C
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0020E844 File Offset: 0x0020CA44
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1206009423;
			short num2 = num;
			num = (short)2102607439;
			switch (num2 == num)
			{
			}
			num = (short)2062811136;
			short num3 = num;
			num = (short)1238040576;
			if (num != 0)
			{
			}
			num = (short)1418002433;
			if (num != 0)
			{
			}
			this.secWideLabtoolPIDIndexMapping_A8279 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("菏럑럓臕뇗뻙맛鋝臟胡郣觥蟧蛩볫꟭듯믱髳鋵鷷苹뇻鿽烿爁洃栅漇唉䴋㘍∏┑ⴓ", a_), global::CommonResources.AcgResources.ID_PIDINDEXMAPPING, 0, 65535, null, null, 0, 1);
			this.secWideLabtoolPIDIndexMapping_A8279.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.secWideLabtoolPIDIndexMapping_A8279.DataTransferOrder = -1;
			this.secWideLabtoolPIDIndexMapping_A8279.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳏돑뛓ꋕ럗뗙냛", a_);
			base.Id = 10039;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0020E978 File Offset: 0x0020CB78
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)2050162689;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1510998017;
					if (num != 0)
					{
					}
					this.secWideLabtoolPIDIndexMapping_A8279 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗雙뷛볝铟跡诣諥룧ꏩ꣫꟭黯雱釳軵뗷鯹賻軽槿氁挃夅䤇㈉㸋㤍⤏", a_), global::CommonResources.AcgResources.ID_PIDINDEXMAPPING, null, null, 0, 1);
					this.secWideLabtoolPIDIndexMapping_A8279.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.secWideLabtoolPIDIndexMapping_A8279.DataTransferOrder = -1;
					this.secWideLabtoolPIDIndexMapping_A8279.ShowHexValue = false;
					num = (short)1166606341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗雙뷛볝铟跡诣諥룧ꏩ꣫꟭黯雱釳軵뗷鯹賻軽槿氁挃夅䤇㈉㸋㤍⤏", a_)))
					{
						num = (short)1960050688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F7;
				case 3:
				{
					num = (short)945209625;
					short num3 = num;
					num = (short)1886765337;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DA;
					default:
						num = (short)1815543808;
						if (num != 0)
						{
						}
						num = (short)640286726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
				{
					num = (short)807141376;
					short num4 = num;
					num = (short)1509490690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_F5;
				case 6:
					if (producerFields != null)
					{
						goto IL_1DA;
					}
					goto IL_1F7;
				}
				IL_4A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1467875331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1DA:
				num = (short)1394999300;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F5:
			IL_1F7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胋꿍닏ꛑ믓맕듗", a_);
			base.Id = 10039;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0020EBB0 File Offset: 0x0020CDB0
		public override void PopulateReferences()
		{
			short num = (short)43904819;
			short num2 = num;
			num = (short)1818292019;
			switch (num2 == num)
			{
			}
			num = (short)121438208;
			short num3 = num;
			num = (short)424738816;
			if (num != 0)
			{
			}
			num = (short)303104001;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x0020EC5C File Offset: 0x0020CE5C
		public override void DropReferences()
		{
			short num = (short)159070204;
			short num2 = num;
			num = (short)2076063740;
			switch (num2 == num)
			{
			}
			num = (short)1930231808;
			short num3 = num;
			num = (short)977403905;
			if (num != 0)
			{
			}
			num = (short)1232404480;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x0020ED04 File Offset: 0x0020CF04
		public override void SetConstraints()
		{
			short num = (short)1065432813;
			short num2 = num;
			num = (short)867317485;
			switch (num2 == num)
			{
			}
			num = (short)1312423936;
			short num3 = num;
			num = (short)1719926784;
			if (num != 0)
			{
			}
			num = (short)817299457;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x0020EDAC File Offset: 0x0020CFAC
		public override void SetupDependencies()
		{
			short num = (short)484311476;
			short num2 = num;
			num = (short)821625268;
			switch (num2 == num)
			{
			}
			num = (short)1339490304;
			short num3 = num;
			num = (short)1877475329;
			if (num != 0)
			{
			}
			num = (short)604307456;
			if (num != 0)
			{
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0020EE58 File Offset: 0x0020D058
		public bool HasDiffs
		{
			get
			{
				short num = (short)578879489;
				if (num != 0)
				{
				}
				num = (short)1190555698;
				short num2 = num;
				num = (short)1985638450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1449066496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543948800;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x0020EF08 File Offset: 0x0020D108
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x0020EFC0 File Offset: 0x0020D1C0
		public int SecWideLabtoolPIDIndexMapping_A8279Value
		{
			get
			{
				short num = (short)911803165;
				short num2 = num;
				num = (short)404816669;
				switch (num2 == num)
				{
				}
				num = (short)1153761280;
				short num3 = num;
				num = (short)461438977;
				if (num != 0)
				{
				}
				num = (short)761462784;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Value;
			}
			set
			{
				short num = (short)1538670822;
				short num2 = num;
				num = (short)1674264806;
				switch (num2 == num)
				{
				}
				num = (short)687210496;
				short num3 = num;
				num = (short)1206714369;
				if (num != 0)
				{
				}
				num = (short)1307508736;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Value = value;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x0020F078 File Offset: 0x0020D278
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideLabtoolPIDIndexMapping_A8279
		{
			get
			{
				short num = (short)1280935618;
				short num2 = num;
				num = (short)853771970;
				switch (num2 == num)
				{
				}
				num = (short)947716096;
				short num3 = num;
				num = (short)2111504385;
				if (num != 0)
				{
				}
				num = (short)122421248;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x0020F128 File Offset: 0x0020D328
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x0020F1DC File Offset: 0x0020D3DC
		public string SecWideLabtoolPIDIndexMapping_A8279_UIValue
		{
			get
			{
				short num = (short)13141964;
				short num2 = num;
				num = (short)687835084;
				switch (num2 == num)
				{
				}
				num = (short)1609760768;
				short num3 = num;
				num = (short)71761921;
				if (num != 0)
				{
				}
				num = (short)1741357056;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.UIValue;
			}
			set
			{
				short num = (short)1308154173;
				short num2 = num;
				num = (short)1521473853;
				switch (num2 == num)
				{
				}
				num = (short)778633216;
				short num3 = num;
				num = (short)1550319617;
				if (num != 0)
				{
				}
				num = (short)272695296;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.UIValue = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x0020F294 File Offset: 0x0020D494
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x0020F348 File Offset: 0x0020D548
		internal int SecWideLabtoolPIDIndexMapping_A8279Min
		{
			get
			{
				short num = (short)316356096;
				short num2 = num;
				num = (short)1100494336;
				switch (num2 == num)
				{
				}
				num = (short)2068971520;
				short num3 = num;
				num = (short)632094720;
				if (num != 0)
				{
				}
				num = (short)2143944705;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Min;
			}
			set
			{
				short num = (short)335129766;
				short num2 = num;
				num = (short)618966182;
				switch (num2 == num)
				{
				}
				num = (short)409403392;
				short num3 = num;
				num = (short)491847681;
				if (num != 0)
				{
				}
				num = (short)1487863808;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Min = value;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x0020F3FC File Offset: 0x0020D5FC
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x0020F4B0 File Offset: 0x0020D6B0
		internal int SecWideLabtoolPIDIndexMapping_A8279Max
		{
			get
			{
				short num = (short)911378765;
				short num2 = num;
				num = (short)1324714317;
				switch (num2 == num)
				{
				}
				num = (short)1902510080;
				short num3 = num;
				num = (short)904265728;
				if (num != 0)
				{
				}
				num = (short)235405313;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Max;
			}
			set
			{
				short num = (short)537700251;
				short num2 = num;
				num = (short)2069473179;
				switch (num2 == num)
				{
				}
				num = (short)1292042240;
				short num3 = num;
				num = (short)452460545;
				if (num != 0)
				{
				}
				num = (short)1776025600;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Max = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x0020F568 File Offset: 0x0020D768
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x0020F61C File Offset: 0x0020D81C
		internal int SecWideLabtoolPIDIndexMapping_A8279Step
		{
			get
			{
				short num = (short)1615729692;
				short num2 = num;
				num = (short)1957631004;
				switch (num2 == num)
				{
				}
				num = (short)117833728;
				short num3 = num;
				num = (short)608108545;
				if (num != 0)
				{
				}
				num = (short)831520768;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.StepSize;
			}
			set
			{
				short num = (short)410884126;
				short num2 = num;
				num = (short)628922398;
				switch (num2 == num)
				{
				}
				num = (short)820969472;
				short num3 = num;
				num = (short)1213530113;
				if (num != 0)
				{
				}
				num = (short)1518010368;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.StepSize = value;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x0020F6D0 File Offset: 0x0020D8D0
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x0020F784 File Offset: 0x0020D984
		public bool SecWideLabtoolPIDIndexMapping_A8279_Applicable
		{
			get
			{
				short num = (short)1907264580;
				short num2 = num;
				num = (short)67537988;
				switch (num2 == num)
				{
				}
				num = (short)38993920;
				short num3 = num;
				num = (short)1598816257;
				if (num != 0)
				{
				}
				num = (short)1835335680;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Applicable;
			}
			set
			{
				short num = (short)877723649;
				if (num != 0)
				{
				}
				num = (short)1760301125;
				short num2 = num;
				num = (short)1927090245;
				switch (num2 == num)
				{
				}
				num = (short)1692139520;
				short num3 = num;
				num = (short)546373632;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Applicable = value;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x0020F83C File Offset: 0x0020DA3C
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0020F8F0 File Offset: 0x0020DAF0
		public bool SecWideLabtoolPIDIndexMapping_A8279_Valid
		{
			get
			{
				short num = (short)413538771;
				short num2 = num;
				num = (short)298457555;
				switch (num2 == num)
				{
				}
				num = (short)401473537;
				if (num != 0)
				{
				}
				num = (short)1754923008;
				short num3 = num;
				num = (short)1497497600;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Valid;
			}
			set
			{
				short num = (short)857235023;
				short num2 = num;
				num = (short)523132495;
				switch (num2 == num)
				{
				}
				num = (short)720830464;
				if (num != 0)
				{
				}
				num = (short)584450048;
				short num3 = num;
				num = (short)1471086593;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Valid = value;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0020F9A4 File Offset: 0x0020DBA4
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x0020FA58 File Offset: 0x0020DC58
		public bool SecWideLabtoolPIDIndexMapping_A8279_Visible
		{
			get
			{
				short num = (short)184827329;
				short num2 = num;
				num = (short)1509375425;
				switch (num2 == num)
				{
				}
				num = (short)1808072705;
				if (num != 0)
				{
				}
				num = (short)836370432;
				short num3 = num;
				num = (short)2037710848;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Visible;
			}
			set
			{
				short num = (short)1610538169;
				short num2 = num;
				num = (short)1549786297;
				switch (num2 == num)
				{
				}
				num = (short)1116667905;
				if (num != 0)
				{
				}
				num = (short)875298816;
				short num3 = num;
				num = (short)2092957696;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Visible = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0020FB0C File Offset: 0x0020DD0C
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0020FBC4 File Offset: 0x0020DDC4
		public bool SecWideLabtoolPIDIndexMapping_A8279_Editable
		{
			get
			{
				short num = (short)521534692;
				short num2 = num;
				num = (short)386530532;
				switch (num2 == num)
				{
				}
				num = (short)878247937;
				if (num != 0)
				{
				}
				num = (short)374734848;
				short num3 = num;
				num = (short)1780350976;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.Editable;
			}
			set
			{
				short num = (short)1037572450;
				short num2 = num;
				num = (short)611916130;
				switch (num2 == num)
				{
				}
				num = (short)1290928128;
				if (num != 0)
				{
				}
				num = (short)1985740800;
				short num3 = num;
				num = (short)1354825729;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.Editable = value;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0020FC7C File Offset: 0x0020DE7C
		internal string SecWideLabtoolPIDIndexMapping_A8279_UILabel
		{
			get
			{
				short num = (short)272936899;
				short num2 = num;
				num = (short)1534570435;
				switch (num2 == num)
				{
				}
				num = (short)1933246464;
				if (num != 0)
				{
				}
				num = (short)1931214848;
				short num3 = num;
				num = (short)1518141441;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.UIName;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x0020FD34 File Offset: 0x0020DF34
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x0020FDEC File Offset: 0x0020DFEC
		internal bool SecWideLabtoolPIDIndexMapping_A8279_HiddenStatic
		{
			get
			{
				short num = (short)1977286657;
				if (num != 0)
				{
				}
				num = (short)1680021133;
				short num2 = num;
				num = (short)782046861;
				switch (num2 == num)
				{
				}
				num = (short)1316159488;
				short num3 = num;
				num = (short)223936512;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.HiddenStatic;
			}
			set
			{
				short num = (short)1334656132;
				short num2 = num;
				num = (short)780156036;
				switch (num2 == num)
				{
				}
				num = (short)1351876608;
				if (num != 0)
				{
				}
				num = (short)2116026368;
				short num3 = num;
				num = (short)483196929;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.HiddenStatic = value;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x0020FEA4 File Offset: 0x0020E0A4
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x0020FF5C File Offset: 0x0020E15C
		internal bool SecWideLabtoolPIDIndexMapping_A8279_HiddenDynamic
		{
			get
			{
				short num = (short)631360911;
				short num2 = num;
				num = (short)296078735;
				switch (num2 == num)
				{
				}
				num = (short)130678785;
				if (num != 0)
				{
				}
				num = (short)1371013120;
				short num3 = num;
				num = (short)761659392;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279.HiddenDynamic;
			}
			set
			{
				short num = (short)1786831392;
				short num2 = num;
				num = (short)1485562400;
				switch (num2 == num)
				{
				}
				num = (short)637796352;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				short num3 = num;
				num = (short)1498677249;
				if (num != 0)
				{
				}
				this.secWideLabtoolPIDIndexMapping_A8279.HiddenDynamic = value;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00210010 File Offset: 0x0020E210
		public bool SecWideLabtoolPIDIndexMapping_A8279_HasDiffs
		{
			get
			{
				short num = (short)1108723106;
				short num2 = num;
				num = (short)1188611490;
				switch (num2 == num)
				{
				}
				num = (short)774242305;
				if (num != 0)
				{
				}
				num = (short)808714240;
				short num3 = num;
				num = (short)1986854912;
				if (num != 0)
				{
				}
				return this.secWideLabtoolPIDIndexMapping_A8279._HasDiffs;
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x002100C4 File Offset: 0x0020E2C4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1999470714;
					short num3 = num2;
					num2 = (short)1511817338;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_164;
					default:
						num2 = (short)602865664;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)62652419;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					num2 = (short)701104128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_B0;
				case 3:
					goto IL_164;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1077673985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_164:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)662110210;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B0:
			num2 = (short)1899560961;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)71696384;
			short num4 = num2;
			num2 = (short)566099972;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000BD1 RID: 3025
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideLabtoolPIDIndexMapping_A8279;
	}
}
