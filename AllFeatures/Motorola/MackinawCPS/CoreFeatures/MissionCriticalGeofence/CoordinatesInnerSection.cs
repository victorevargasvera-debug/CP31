using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x02000269 RID: 617
	[global::System.Serializable]
	public class CoordinatesInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006E25 RID: 28197 RVA: 0x006233F8 File Offset: 0x006215F8
		public CoordinatesInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00623414 File Offset: 0x00621614
		protected CoordinatesInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x0062342C File Offset: 0x0062162C
		public override void Init()
		{
			int a_ = 19;
			short num = (short)723771027;
			short num2 = num;
			num = (short)142990995;
			switch (num2 == num)
			{
			}
			num = (short)614400000;
			if (num != 0)
			{
			}
			num = (short)1904476161;
			if (num != 0)
			{
			}
			num = (short)332398592;
			short num3 = num;
			this.mcGeofenceLongitude_42893 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.ConvertCoorindates(), this, global::AllFeatures.CodeplugGuid.b("駓뗕鿗뿙돛룝藟賡蟣菥ꓧ藩苫觭駯蛱至鋵鷷ꗹ죻쳽㣿㬁㜃", a_), global::CommonResources.AcgResources.ID_LONGITUDE, -1800000000, 1800000000, 1);
			this.mcGeofenceLongitude_42893.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mcGeofenceLongitude_42893.DataTransferOrder = 97;
			this.mcGeofenceLongitude_42893.ShowHexValue = false;
			this.mcGeofenceLatitude_42894 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.ConvertCoorindates(), this, global::AllFeatures.CodeplugGuid.b("駓뗕鿗뿙돛룝藟賡蟣菥ꓧ诩飫蟭蓯蟱郳鏵ꟷ컹컻웽㧿㘁", a_), global::CommonResources.AcgResources.ID_LATITUDE, -900000000, 900000000, 1);
			this.mcGeofenceLatitude_42894.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mcGeofenceLatitude_42894.DataTransferOrder = 98;
			this.mcGeofenceLatitude_42894.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韓맕럗꣙룛럝軟菡郣菥鯧", a_);
			base.Id = 10811;
			base.UIName = global::CommonResources.AcgResources.ID_COORDINATES;
			base.DataTransferOrder = 96;
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x006235C0 File Offset: 0x006217C0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)675151879;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟉꿋觍뗏뷑닓돕뛗맙맛鋝迟賡菣迥鳧鿩裫语꿯웱웳컵쇷짹", a_)))
					{
						num = (short)333316101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 1:
					if (producerFields != null)
					{
						num = (short)123207688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				case 2:
					goto IL_1C3;
				case 3:
					goto IL_125;
				case 4:
					num = (short)2013200385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.mcGeofenceLongitude_42893 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.ConvertCoorindates(), this, global::AllFeatures.CodeplugGuid.b("蟉꿋觍뗏뷑닓돕뛗맙맛鋝迟賡菣迥鳧鿩裫语꿯웱웳컵쇷짹", a_), global::CommonResources.AcgResources.ID_LONGITUDE);
					this.mcGeofenceLongitude_42893.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mcGeofenceLongitude_42893.DataTransferOrder = 97;
					this.mcGeofenceLongitude_42893.ShowHexValue = false;
					num = (short)864681987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟉꿋觍뗏뷑닓돕뛗맙맛鋝臟雡跣鋥鷧軩觫뇭쓯샱쳳쿵쳷", a_)))
					{
						num = (short)1385037833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 8:
				{
					num = (short)556737637;
					short num3 = num;
					num = (short)1419519077;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
					{
						num = (short)750452737;
						if (num != 0)
						{
						}
						num = (short)543686656;
						if (num != 0)
						{
						}
						num = (short)1714683904;
						short num4 = num;
						num = (short)316014592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 9:
					this.mcGeofenceLatitude_42894 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.ConvertCoorindates(), this, global::AllFeatures.CodeplugGuid.b("蟉꿋觍뗏뷑닓돕뛗맙맛鋝臟雡跣鋥鷧軩觫뇭쓯샱쳳쿵쳷", a_), global::CommonResources.AcgResources.ID_LATITUDE);
					this.mcGeofenceLatitude_42894.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mcGeofenceLatitude_42894.DataTransferOrder = 98;
					this.mcGeofenceLatitude_42894.ShowHexValue = false;
					num = (short)861798402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1689452548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)14614534;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_125:
				goto IL_79;
			}
			IL_1C3:
			IL_2AF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觉ꏋꇍꋏ뛑뷓룕맗껙맛귝", a_);
			base.Id = 10811;
			base.UIName = global::CommonResources.AcgResources.ID_COORDINATES;
			base.DataTransferOrder = 96;
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x006238B0 File Offset: 0x00621AB0
		public override void PopulateReferences()
		{
			short num = (short)1519393961;
			short num2 = num;
			num = (short)1263148201;
			switch (num2 == num)
			{
			}
			num = (short)1719664641;
			if (num != 0)
			{
			}
			num = (short)819920896;
			if (num != 0)
			{
			}
			num = (short)1745158144;
			short num3 = num;
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x00623958 File Offset: 0x00621B58
		public override void DropReferences()
		{
			short num = (short)1073031820;
			short num2 = num;
			num = (short)948054668;
			switch (num2 == num)
			{
			}
			num = (short)67239937;
			if (num != 0)
			{
			}
			num = (short)510656512;
			if (num != 0)
			{
			}
			num = (short)20250624;
			short num3 = num;
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x00623A00 File Offset: 0x00621C00
		public override void SetConstraints()
		{
			short num = (short)1036433483;
			short num2 = num;
			num = (short)891533387;
			switch (num2 == num)
			{
			}
			num = (short)1627389953;
			if (num != 0)
			{
			}
			num = (short)1500708864;
			if (num != 0)
			{
			}
			num = (short)1630273536;
			short num3 = num;
			this.mcGeofenceLongitude_42893.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConLocationEnableIsEnabled);
			this.mcGeofenceLongitude_42893.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConSetGeofenceRadius);
			this.mcGeofenceLatitude_42894.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConLocationEnableIsEnabled);
			this.mcGeofenceLatitude_42894.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConSetGeofenceRadius);
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x00623B08 File Offset: 0x00621D08
		public override void SetupDependencies()
		{
			short num = (short)354823701;
			short num2 = num;
			num = (short)1219636757;
			switch (num2 == num)
			{
			}
			num = (short)610205697;
			if (num != 0)
			{
			}
			num = (short)964362240;
			if (num != 0)
			{
			}
			num = (short)502530048;
			short num3 = num;
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.mcGeofenceLongitude_42893);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.mcGeofenceLatitude_42894);
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x06006E2D RID: 28205 RVA: 0x00623BE8 File Offset: 0x00621DE8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1304410268;
				short num2 = num;
				num = (short)1183103132;
				switch (num2 == num)
				{
				}
				num = (short)431357953;
				if (num != 0)
				{
				}
				num = (short)831782912;
				if (num != 0)
				{
				}
				num = (short)1653014528;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x00623C98 File Offset: 0x00621E98
		// (set) Token: 0x06006E2F RID: 28207 RVA: 0x00623D4C File Offset: 0x00621F4C
		public int McGeofenceLongitude_42893Value
		{
			get
			{
				short num = (short)1016394857;
				short num2 = num;
				num = (short)249099369;
				switch (num2 == num)
				{
				}
				num = (short)1115488256;
				if (num != 0)
				{
				}
				num = (short)890109953;
				if (num != 0)
				{
				}
				num = (short)910163968;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Value;
			}
			set
			{
				short num = (short)1823207734;
				short num2 = num;
				num = (short)677376310;
				switch (num2 == num)
				{
				}
				num = (short)1316618241;
				if (num != 0)
				{
				}
				num = (short)1455095808;
				if (num != 0)
				{
				}
				num = (short)1819869184;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Value = value;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x00623E04 File Offset: 0x00622004
		public global::AcpBusinessLayer.AcpRangeField<int, string> McGeofenceLongitude_42893
		{
			get
			{
				short num = (short)522961633;
				short num2 = num;
				num = (short)1469039329;
				switch (num2 == num)
				{
				}
				num = (short)1811152897;
				if (num != 0)
				{
				}
				num = (short)1010106368;
				if (num != 0)
				{
				}
				num = (short)1626865664;
				short num3 = num;
				return this.mcGeofenceLongitude_42893;
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x00623EB8 File Offset: 0x006220B8
		// (set) Token: 0x06006E32 RID: 28210 RVA: 0x00623F6C File Offset: 0x0062216C
		public string McGeofenceLongitude_42893_UIValue
		{
			get
			{
				short num = (short)1503335059;
				short num2 = num;
				num = (short)2059145875;
				switch (num2 == num)
				{
				}
				num = (short)198639616;
				if (num != 0)
				{
				}
				num = (short)1202978817;
				if (num != 0)
				{
				}
				num = (short)697696256;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.UIValue;
			}
			set
			{
				short num = (short)1900281857;
				if (num != 0)
				{
				}
				num = (short)1840025169;
				short num2 = num;
				num = (short)1119456849;
				switch (num2 == num)
				{
				}
				num = (short)690487296;
				if (num != 0)
				{
				}
				num = (short)1235222528;
				short num3 = num;
				this.mcGeofenceLongitude_42893.UIValue = value;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x00624020 File Offset: 0x00622220
		// (set) Token: 0x06006E34 RID: 28212 RVA: 0x006240D4 File Offset: 0x006222D4
		internal int McGeofenceLongitude_42893Min
		{
			get
			{
				short num = (short)1668725707;
				short num2 = num;
				num = (short)579713995;
				switch (num2 == num)
				{
				}
				num = (short)1847984129;
				if (num != 0)
				{
				}
				num = (short)846921728;
				if (num != 0)
				{
				}
				num = (short)133955584;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Min;
			}
			set
			{
				short num = (short)370029008;
				short num2 = num;
				num = (short)482816464;
				switch (num2 == num)
				{
				}
				num = (short)126943232;
				if (num != 0)
				{
				}
				num = (short)1995767809;
				if (num != 0)
				{
				}
				num = (short)2001993728;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Min = value;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0062418C File Offset: 0x0062238C
		// (set) Token: 0x06006E36 RID: 28214 RVA: 0x00624244 File Offset: 0x00622444
		internal int McGeofenceLongitude_42893Max
		{
			get
			{
				short num = (short)1527674896;
				short num2 = num;
				num = (short)347437072;
				switch (num2 == num)
				{
				}
				num = (short)884342785;
				if (num != 0)
				{
				}
				num = (short)1656487936;
				if (num != 0)
				{
				}
				num = (short)1130889216;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Max;
			}
			set
			{
				short num = (short)1644626394;
				short num2 = num;
				num = (short)1720254938;
				switch (num2 == num)
				{
				}
				num = (short)1127940097;
				if (num != 0)
				{
				}
				num = (short)308150272;
				if (num != 0)
				{
				}
				num = (short)326303744;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Max = value;
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x006242F8 File Offset: 0x006224F8
		// (set) Token: 0x06006E38 RID: 28216 RVA: 0x006243AC File Offset: 0x006225AC
		internal int McGeofenceLongitude_42893Step
		{
			get
			{
				short num = (short)2084044801;
				if (num != 0)
				{
				}
				num = (short)2084757091;
				short num2 = num;
				num = (short)811523683;
				switch (num2 == num)
				{
				}
				num = (short)1089798144;
				if (num != 0)
				{
				}
				num = (short)1829568512;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.StepSize;
			}
			set
			{
				short num = (short)1121650313;
				short num2 = num;
				num = (short)733349513;
				switch (num2 == num)
				{
				}
				num = (short)1960640513;
				if (num != 0)
				{
				}
				num = (short)2053373952;
				if (num != 0)
				{
				}
				num = (short)492568576;
				short num3 = num;
				this.mcGeofenceLongitude_42893.StepSize = value;
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x06006E39 RID: 28217 RVA: 0x00624460 File Offset: 0x00622660
		// (set) Token: 0x06006E3A RID: 28218 RVA: 0x00624514 File Offset: 0x00622714
		public bool McGeofenceLongitude_42893_Applicable
		{
			get
			{
				short num = (short)1588714945;
				short num2 = num;
				num = (short)681500097;
				switch (num2 == num)
				{
				}
				num = (short)75956224;
				if (num != 0)
				{
				}
				num = (short)1663369217;
				if (num != 0)
				{
				}
				num = (short)402915328;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Applicable;
			}
			set
			{
				short num = (short)171027392;
				short num2 = num;
				num = (short)852077504;
				switch (num2 == num)
				{
				}
				num = (short)1872035841;
				if (num != 0)
				{
				}
				num = (short)1137967104;
				if (num != 0)
				{
				}
				num = (short)192086016;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Applicable = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x006245CC File Offset: 0x006227CC
		// (set) Token: 0x06006E3C RID: 28220 RVA: 0x00624680 File Offset: 0x00622880
		public bool McGeofenceLongitude_42893_Valid
		{
			get
			{
				short num = (short)1055304603;
				short num2 = num;
				num = (short)1277930395;
				switch (num2 == num)
				{
				}
				num = (short)209584129;
				if (num != 0)
				{
				}
				num = (short)1266286592;
				if (num != 0)
				{
				}
				num = (short)1726545920;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Valid;
			}
			set
			{
				short num = (short)1536848606;
				short num2 = num;
				num = (short)1241281246;
				switch (num2 == num)
				{
				}
				num = (short)1766129664;
				if (num != 0)
				{
				}
				num = (short)306708481;
				if (num != 0)
				{
				}
				num = (short)1177223168;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Valid = value;
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x00624738 File Offset: 0x00622938
		// (set) Token: 0x06006E3E RID: 28222 RVA: 0x006247EC File Offset: 0x006229EC
		public bool McGeofenceLongitude_42893_Visible
		{
			get
			{
				short num = (short)706153681;
				short num2 = num;
				num = (short)24841425;
				switch (num2 == num)
				{
				}
				num = (short)669384704;
				if (num != 0)
				{
				}
				num = (short)1713438721;
				if (num != 0)
				{
				}
				num = (short)871235584;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Visible;
			}
			set
			{
				short num = (short)1792120988;
				short num2 = num;
				num = (short)192583836;
				switch (num2 == num)
				{
				}
				num = (short)384630785;
				if (num != 0)
				{
				}
				num = (short)191561728;
				if (num != 0)
				{
				}
				num = (short)767361024;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Visible = value;
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x006248A0 File Offset: 0x00622AA0
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00624954 File Offset: 0x00622B54
		public bool McGeofenceLongitude_42893_Editable
		{
			get
			{
				short num = (short)1741588576;
				short num2 = num;
				num = (short)304318560;
				switch (num2 == num)
				{
				}
				num = (short)653524993;
				if (num != 0)
				{
				}
				num = (short)1305280512;
				if (num != 0)
				{
				}
				num = (short)118620160;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.Editable;
			}
			set
			{
				short num = (short)516816897;
				if (num != 0)
				{
				}
				num = (short)925141996;
				short num2 = num;
				num = (short)1798343660;
				switch (num2 == num)
				{
				}
				num = (short)529137664;
				if (num != 0)
				{
				}
				num = (short)1074593792;
				short num3 = num;
				this.mcGeofenceLongitude_42893.Editable = value;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x00624A08 File Offset: 0x00622C08
		internal string McGeofenceLongitude_42893_UILabel
		{
			get
			{
				short num = (short)1507828375;
				short num2 = num;
				num = (short)1422041751;
				switch (num2 == num)
				{
				}
				num = (short)73728000;
				if (num != 0)
				{
				}
				num = (short)1675624449;
				if (num != 0)
				{
				}
				num = (short)845479936;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.UIName;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x06006E42 RID: 28226 RVA: 0x00624AC0 File Offset: 0x00622CC0
		// (set) Token: 0x06006E43 RID: 28227 RVA: 0x00624B74 File Offset: 0x00622D74
		internal bool McGeofenceLongitude_42893_HiddenStatic
		{
			get
			{
				short num = (short)1185218561;
				if (num != 0)
				{
				}
				num = (short)1440631580;
				short num2 = num;
				num = (short)17976092;
				switch (num2 == num)
				{
				}
				num = (short)296419328;
				if (num != 0)
				{
				}
				num = (short)568655872;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.HiddenStatic;
			}
			set
			{
				short num = (short)1991008640;
				short num2 = num;
				num = (short)635527552;
				switch (num2 == num)
				{
				}
				num = (short)198049793;
				if (num != 0)
				{
				}
				num = (short)1203634176;
				if (num != 0)
				{
				}
				num = (short)1806565376;
				short num3 = num;
				this.mcGeofenceLongitude_42893.HiddenStatic = value;
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x00624C2C File Offset: 0x00622E2C
		// (set) Token: 0x06006E45 RID: 28229 RVA: 0x00624CE4 File Offset: 0x00622EE4
		internal bool McGeofenceLongitude_42893_HiddenDynamic
		{
			get
			{
				short num = (short)1842283148;
				short num2 = num;
				num = (short)769917580;
				switch (num2 == num)
				{
				}
				num = (short)2064515073;
				if (num != 0)
				{
				}
				num = (short)126681088;
				if (num != 0)
				{
				}
				num = (short)1697775616;
				short num3 = num;
				return this.mcGeofenceLongitude_42893.HiddenDynamic;
			}
			set
			{
				short num = (short)1650676103;
				short num2 = num;
				num = (short)1128812935;
				switch (num2 == num)
				{
				}
				num = (short)1582628864;
				if (num != 0)
				{
				}
				num = (short)789053441;
				if (num != 0)
				{
				}
				num = (short)105775104;
				short num3 = num;
				this.mcGeofenceLongitude_42893.HiddenDynamic = value;
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x06006E46 RID: 28230 RVA: 0x00624D98 File Offset: 0x00622F98
		public bool McGeofenceLongitude_42893_HasDiffs
		{
			get
			{
				short num = (short)581329276;
				short num2 = num;
				num = (short)1204248956;
				switch (num2 == num)
				{
				}
				num = (short)520683521;
				if (num != 0)
				{
				}
				num = (short)928645120;
				if (num != 0)
				{
				}
				num = (short)615645184;
				short num3 = num;
				return this.mcGeofenceLongitude_42893._HasDiffs;
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x00624E4C File Offset: 0x0062304C
		// (set) Token: 0x06006E48 RID: 28232 RVA: 0x00624F04 File Offset: 0x00623104
		public int McGeofenceLatitude_42894Value
		{
			get
			{
				short num = (short)1147635697;
				short num2 = num;
				num = (short)881428465;
				switch (num2 == num)
				{
				}
				num = (short)680067073;
				if (num != 0)
				{
				}
				num = (short)644546560;
				if (num != 0)
				{
				}
				num = (short)1870462976;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Value;
			}
			set
			{
				short num = (short)93290832;
				short num2 = num;
				num = (short)1827701072;
				switch (num2 == num)
				{
				}
				num = (short)1931083777;
				if (num != 0)
				{
				}
				num = (short)135593984;
				if (num != 0)
				{
				}
				num = (short)1502806016;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Value = value;
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x00624FBC File Offset: 0x006231BC
		public global::AcpBusinessLayer.AcpRangeField<int, string> McGeofenceLatitude_42894
		{
			get
			{
				short num = (short)580714497;
				if (num != 0)
				{
				}
				num = (short)115937450;
				short num2 = num;
				num = (short)649924778;
				switch (num2 == num)
				{
				}
				num = (short)2057568256;
				if (num != 0)
				{
				}
				num = (short)616759296;
				short num3 = num;
				return this.mcGeofenceLatitude_42894;
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x06006E4A RID: 28234 RVA: 0x0062506C File Offset: 0x0062326C
		// (set) Token: 0x06006E4B RID: 28235 RVA: 0x00625120 File Offset: 0x00623320
		public string McGeofenceLatitude_42894_UIValue
		{
			get
			{
				short num = (short)1995301863;
				short num2 = num;
				num = (short)1273029607;
				switch (num2 == num)
				{
				}
				num = (short)1645084673;
				if (num != 0)
				{
				}
				num = (short)1769275392;
				if (num != 0)
				{
				}
				num = (short)1518469120;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.UIValue;
			}
			set
			{
				short num = (short)521535489;
				if (num != 0)
				{
				}
				num = (short)1852112417;
				short num2 = num;
				num = (short)1532427809;
				switch (num2 == num)
				{
				}
				num = (short)13303808;
				if (num != 0)
				{
				}
				num = (short)743636992;
				short num3 = num;
				this.mcGeofenceLatitude_42894.UIValue = value;
			}
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x006251D4 File Offset: 0x006233D4
		// (set) Token: 0x06006E4D RID: 28237 RVA: 0x0062528C File Offset: 0x0062348C
		internal int McGeofenceLatitude_42894Min
		{
			get
			{
				short num = (short)1806368769;
				if (num != 0)
				{
				}
				num = (short)1107658574;
				short num2 = num;
				num = (short)265848654;
				switch (num2 == num)
				{
				}
				num = (short)1239416832;
				if (num != 0)
				{
				}
				num = (short)1555234816;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Min;
			}
			set
			{
				short num = (short)2072548933;
				short num2 = num;
				num = (short)2015729221;
				switch (num2 == num)
				{
				}
				num = (short)1025966080;
				if (num != 0)
				{
				}
				num = (short)1268449281;
				if (num != 0)
				{
				}
				num = (short)784924672;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Min = value;
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x06006E4E RID: 28238 RVA: 0x00625344 File Offset: 0x00623544
		// (set) Token: 0x06006E4F RID: 28239 RVA: 0x006253FC File Offset: 0x006235FC
		internal int McGeofenceLatitude_42894Max
		{
			get
			{
				short num = (short)612766960;
				short num2 = num;
				num = (short)1585583344;
				switch (num2 == num)
				{
				}
				num = (short)1931214849;
				if (num != 0)
				{
				}
				num = (short)974979072;
				if (num != 0)
				{
				}
				num = (short)605618176;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Max;
			}
			set
			{
				short num = (short)1184759809;
				if (num != 0)
				{
				}
				num = (short)1855630552;
				short num2 = num;
				num = (short)984198360;
				switch (num2 == num)
				{
				}
				num = (short)1348009984;
				if (num != 0)
				{
				}
				num = (short)1041367040;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Max = value;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x06006E50 RID: 28240 RVA: 0x006254B4 File Offset: 0x006236B4
		// (set) Token: 0x06006E51 RID: 28241 RVA: 0x00625568 File Offset: 0x00623768
		internal int McGeofenceLatitude_42894Step
		{
			get
			{
				short num = (short)375378480;
				short num2 = num;
				num = (short)70439472;
				switch (num2 == num)
				{
				}
				num = (short)1144324096;
				if (num != 0)
				{
				}
				num = (short)1707016193;
				if (num != 0)
				{
				}
				num = (short)808648704;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.StepSize;
			}
			set
			{
				short num = (short)819448284;
				short num2 = num;
				num = (short)1646250460;
				switch (num2 == num)
				{
				}
				num = (short)1069350912;
				if (num != 0)
				{
				}
				num = (short)384892929;
				if (num != 0)
				{
				}
				num = (short)1438384128;
				short num3 = num;
				this.mcGeofenceLatitude_42894.StepSize = value;
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x00625624 File Offset: 0x00623824
		// (set) Token: 0x06006E53 RID: 28243 RVA: 0x006256DC File Offset: 0x006238DC
		public bool McGeofenceLatitude_42894_Applicable
		{
			get
			{
				short num = (short)453176690;
				short num2 = num;
				num = (short)1342303602;
				switch (num2 == num)
				{
				}
				num = (short)838598656;
				if (num != 0)
				{
				}
				num = (short)1917779969;
				if (num != 0)
				{
				}
				num = (short)677117952;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Applicable;
			}
			set
			{
				short num = (short)1528868059;
				short num2 = num;
				num = (short)1347661019;
				switch (num2 == num)
				{
				}
				num = (short)307429376;
				if (num != 0)
				{
				}
				num = (short)142540801;
				if (num != 0)
				{
				}
				num = (short)240844800;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Applicable = value;
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x00625794 File Offset: 0x00623994
		// (set) Token: 0x06006E55 RID: 28245 RVA: 0x00625848 File Offset: 0x00623A48
		public bool McGeofenceLatitude_42894_Valid
		{
			get
			{
				short num = (short)1678835713;
				if (num != 0)
				{
				}
				num = (short)956045152;
				short num2 = num;
				num = (short)748033888;
				switch (num2 == num)
				{
				}
				num = (short)1708720128;
				if (num != 0)
				{
				}
				num = (short)638386176;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Valid;
			}
			set
			{
				short num = (short)826195908;
				short num2 = num;
				num = (short)1282523076;
				switch (num2 == num)
				{
				}
				num = (short)633733120;
				if (num != 0)
				{
				}
				num = (short)270139393;
				if (num != 0)
				{
				}
				num = (short)1294073856;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Valid = value;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x006258FC File Offset: 0x00623AFC
		// (set) Token: 0x06006E57 RID: 28247 RVA: 0x006259B0 File Offset: 0x00623BB0
		public bool McGeofenceLatitude_42894_Visible
		{
			get
			{
				short num = (short)791065540;
				short num2 = num;
				num = (short)424653764;
				switch (num2 == num)
				{
				}
				num = (short)1585971201;
				if (num != 0)
				{
				}
				num = (short)1885011968;
				if (num != 0)
				{
				}
				num = (short)1085865984;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Visible;
			}
			set
			{
				short num = (short)1717370715;
				short num2 = num;
				num = (short)1327038299;
				switch (num2 == num)
				{
				}
				num = (short)483328001;
				if (num != 0)
				{
				}
				num = (short)1616773120;
				if (num != 0)
				{
				}
				num = (short)23724032;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Visible = value;
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x06006E58 RID: 28248 RVA: 0x00625A68 File Offset: 0x00623C68
		// (set) Token: 0x06006E59 RID: 28249 RVA: 0x00625B1C File Offset: 0x00623D1C
		public bool McGeofenceLatitude_42894_Editable
		{
			get
			{
				short num = (short)1081988438;
				short num2 = num;
				num = (short)637654358;
				switch (num2 == num)
				{
				}
				num = (short)1743781889;
				if (num != 0)
				{
				}
				num = (short)909115392;
				if (num != 0)
				{
				}
				num = (short)1883308032;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.Editable;
			}
			set
			{
				short num = (short)1121906436;
				short num2 = num;
				num = (short)1496706820;
				switch (num2 == num)
				{
				}
				num = (short)102367233;
				if (num != 0)
				{
				}
				num = (short)33030144;
				if (num != 0)
				{
				}
				num = (short)1774714880;
				short num3 = num;
				this.mcGeofenceLatitude_42894.Editable = value;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x06006E5A RID: 28250 RVA: 0x00625BD0 File Offset: 0x00623DD0
		internal string McGeofenceLatitude_42894_UILabel
		{
			get
			{
				short num = (short)1870281482;
				short num2 = num;
				num = (short)861747978;
				switch (num2 == num)
				{
				}
				num = (short)1839464449;
				if (num != 0)
				{
				}
				num = (short)859635712;
				if (num != 0)
				{
				}
				num = (short)981991424;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.UIName;
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x00625C84 File Offset: 0x00623E84
		// (set) Token: 0x06006E5C RID: 28252 RVA: 0x00625D38 File Offset: 0x00623F38
		internal bool McGeofenceLatitude_42894_HiddenStatic
		{
			get
			{
				short num = (short)1563182236;
				short num2 = num;
				num = (short)471876764;
				switch (num2 == num)
				{
				}
				num = (short)624427008;
				if (num != 0)
				{
				}
				num = (short)1522008065;
				if (num != 0)
				{
				}
				num = (short)406978560;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.HiddenStatic;
			}
			set
			{
				short num = (short)1193287522;
				short num2 = num;
				num = (short)36904802;
				switch (num2 == num)
				{
				}
				num = (short)79495169;
				if (num != 0)
				{
				}
				num = (short)1584005120;
				if (num != 0)
				{
				}
				num = (short)1941569536;
				short num3 = num;
				this.mcGeofenceLatitude_42894.HiddenStatic = value;
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x00625DF0 File Offset: 0x00623FF0
		// (set) Token: 0x06006E5E RID: 28254 RVA: 0x00625EA4 File Offset: 0x006240A4
		internal bool McGeofenceLatitude_42894_HiddenDynamic
		{
			get
			{
				short num = (short)72874198;
				short num2 = num;
				num = (short)1149368534;
				switch (num2 == num)
				{
				}
				num = (short)189267969;
				if (num != 0)
				{
				}
				num = (short)87097344;
				if (num != 0)
				{
				}
				num = (short)875036672;
				short num3 = num;
				return this.mcGeofenceLatitude_42894.HiddenDynamic;
			}
			set
			{
				short num = (short)1857121205;
				short num2 = num;
				num = (short)1794730933;
				switch (num2 == num)
				{
				}
				num = (short)1937440769;
				if (num != 0)
				{
				}
				num = (short)605421568;
				if (num != 0)
				{
				}
				num = (short)1408958464;
				short num3 = num;
				this.mcGeofenceLatitude_42894.HiddenDynamic = value;
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x00625F5C File Offset: 0x0062415C
		public bool McGeofenceLatitude_42894_HasDiffs
		{
			get
			{
				short num = (short)201457665;
				if (num != 0)
				{
				}
				num = (short)204871572;
				short num2 = num;
				num = (short)1961236372;
				switch (num2 == num)
				{
				}
				num = (short)1227423744;
				if (num != 0)
				{
				}
				num = (short)1276248064;
				short num3 = num;
				return this.mcGeofenceLatitude_42894._HasDiffs;
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x06006E60 RID: 28256 RVA: 0x0062600C File Offset: 0x0062420C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2056750093;
				short num2 = num;
				num = (short)1016845;
				switch (num2 == num)
				{
				}
				num = (short)1040908289;
				if (num != 0)
				{
				}
				num = (short)84148224;
				if (num != 0)
				{
				}
				num = (short)1384579072;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x006260CC File Offset: 0x006242CC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1284177920;
			short num2 = num;
			num = (short)1495507500;
			short num3 = num;
			num = (short)2009244204;
			global::AcpCommonLib.IAcpRecordset result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1510735872;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BF;
				}
				int num4;
				for (;;)
				{
					IL_7E:
					num = (short)821166081;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_120;
					case 1:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)453771264;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							num = (short)1228275715;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						num = (short)521601028;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)2087059457;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_BF;
				}
				IL_120:
				break;
				IL_BF:
				result = null;
				num = (short)545587202;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
			}
			return result;
		}

		// Token: 0x04002AE9 RID: 10985
		private global::AcpBusinessLayer.AcpRangeField<int, string> mcGeofenceLongitude_42893;

		// Token: 0x04002AEA RID: 10986
		private global::AcpBusinessLayer.AcpRangeField<int, string> mcGeofenceLatitude_42894;
	}
}
