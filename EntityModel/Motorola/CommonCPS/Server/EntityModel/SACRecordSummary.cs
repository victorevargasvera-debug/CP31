using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200017E RID: 382
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SACRecordSummary : global::Motorola.CommonCPS.Server.EntityModel.CloneableObj
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x000DA178 File Offset: 0x000D8378
		public SACRecordSummary()
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000DA18C File Offset: 0x000D838C
		public SACRecordSummary(global::Motorola.CommonCPS.Server.EntityModel.SACRecord sac)
		{
			this.Uuid = new global::System.Guid?(sac.Uuid);
			this.Timestamp = sac.Timestamp;
			this.SystemUuid = sac.SystemUuid;
			this.SerialNumber = sac.SerialNumber;
			this.RadioID = sac.RadioID;
			this.PhysicalSerialNumber = sac.PhysicalSerialNumber;
			this.RadioUuid = sac.RadioUuid;
			this.EnableOnSystem = new bool?(sac.EnableOnSystem);
			this.DeviceType = new global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType?(sac.DeviceType);
			this.SACSiteSelUuid = sac.SACSiteSelUuid;
			this.TelephoneGatewayUuid = sac.TelephoneGatewayUuid;
			this.RecordingSiteUuid = sac.RecordingSiteUuid;
			this.BroadcastVoiceCall = new bool?(sac.BroadcastVoiceCall);
			this.CallAlert = new bool?(sac.CallAlert);
			this.GroupDataCall = new bool?(sac.GroupDataCall);
			this.GroupVoiceCall = new bool?(sac.GroupVoiceCall);
			this.IndividualDataCall = new bool?(sac.IndividualDataCall);
			this.IndividualVoiceCall = new bool?(sac.IndividualVoiceCall);
			this.InitiateStunRevive = new bool?(sac.InitiateStunRevive);
			this.MultiSiteAllCall = new bool?(sac.MultiSiteAllCall);
			this.QueuePriority = sac.QueuePriority;
			this.RadioCheckTX = new bool?(sac.RadioCheckTX);
			this.StatusCall = new bool?(sac.StatusCall);
			this.SystemAllCallTx = new bool?(sac.SystemAllCallTx);
			this.KillRX = new bool?(sac.KillRX);
			this.DgnaRx = new bool?(sac.DgnaRx);
			this.KillTx = new bool?(sac.KillTx);
			this.Preempt = new bool?(sac.Preempt);
			this.ReceiveIndividualVoiceCall = new bool?(sac.ReceiveIndividualVoiceCall);
			this.ReceiveRemoteMonitor = new bool?(sac.ReceiveRemoteMonitor);
			this.ReceiveStunRevive = new bool?(sac.ReceiveStunRevive);
			this.ReceiveTelephoneCall = new bool?(sac.ReceiveTelephoneCall);
			this.EmergencyCall = new bool?(sac.EmergencyCall);
			this.RemoteMonitor = new bool?(sac.RemoteMonitor);
			this.ShortDataCall = new bool?(sac.ShortDataCall);
			this.SiteAllCall = new bool?(sac.SiteAllCall);
			this.TelephoneCall = new bool?(sac.TelephoneCall);
			this.VoiceInterruptTX = new bool?(sac.VoiceInterruptTX);
			this.UserDomainID = new int?(sac.UserDomainID);
			this.RadioAlias = sac.RadioAlias;
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x000DA410 File Offset: 0x000D8610
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x000DA4BC File Offset: 0x000D86BC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)243413922;
				short num2 = num;
				num = (short)1483879330;
				switch (num2 == num)
				{
				}
				num = (short)980090881;
				if (num != 0)
				{
				}
				num = (short)1655504896;
				if (num != 0)
				{
				}
				num = (short)503906304;
				short num3 = num;
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1556034255;
				short num2 = num;
				num = (short)838939343;
				switch (num2 == num)
				{
				}
				num = (short)1480851457;
				if (num != 0)
				{
				}
				num = (short)1618739200;
				if (num != 0)
				{
				}
				num = (short)363134976;
				short num3 = num;
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x000DA570 File Offset: 0x000D8770
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x000DA620 File Offset: 0x000D8820
		[global::System.Runtime.Serialization.DataMember]
		public byte[] Timestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1585114135;
				short num2 = num;
				num = (short)586935319;
				switch (num2 == num)
				{
				}
				num = (short)847577089;
				if (num != 0)
				{
				}
				num = (short)1548550144;
				if (num != 0)
				{
				}
				num = (short)735903744;
				short num3 = num;
				return this.<Timestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)855348890;
				short num2 = num;
				num = (short)230659738;
				switch (num2 == num)
				{
				}
				num = (short)1755381761;
				if (num != 0)
				{
				}
				num = (short)1247936512;
				if (num != 0)
				{
				}
				num = (short)1646067712;
				short num3 = num;
				this.<Timestamp>k__BackingField = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x000DA6D0 File Offset: 0x000D88D0
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x000DA780 File Offset: 0x000D8980
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? SystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)713895232;
				short num2 = num;
				num = (short)2074225984;
				switch (num2 == num)
				{
				}
				num = (short)23330816;
				if (num != 0)
				{
				}
				num = (short)1290272769;
				if (num != 0)
				{
				}
				num = (short)903872512;
				short num3 = num;
				return this.<SystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)977179841;
				short num2 = num;
				num = (short)1203279041;
				switch (num2 == num)
				{
				}
				num = (short)987627521;
				if (num != 0)
				{
				}
				num = (short)738328576;
				if (num != 0)
				{
				}
				num = (short)2094006272;
				short num3 = num;
				this.<SystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000DA830 File Offset: 0x000D8A30
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x000DA8E4 File Offset: 0x000D8AE4
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)374660365;
				short num2 = num;
				num = (short)659479821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1070596096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1904803841;
				if (num != 0)
				{
				}
				num = (short)1631977472;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1866956546;
				short num2 = num;
				num = (short)2107080450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)283181056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)359399424;
				if (num != 0)
				{
				}
				num = (short)1822294017;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x000DA994 File Offset: 0x000D8B94
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x000DAA44 File Offset: 0x000D8C44
		[global::System.Runtime.Serialization.DataMember]
		public int RadioID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1464029320;
				short num2 = num;
				num = (short)1971081352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)392036352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1379467265;
				if (num != 0)
				{
				}
				num = (short)342491136;
				if (num != 0)
				{
				}
				return this.<RadioID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)368771073;
				if (num != 0)
				{
				}
				num = (short)707395584;
				short num2 = num;
				num = (short)1033821625;
				short num3 = num;
				num = (short)1948376505;
				switch (num3 == num)
				{
				}
				num = (short)477036544;
				if (num != 0)
				{
				}
				this.<RadioID>k__BackingField = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x000DAAF4 File Offset: 0x000D8CF4
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x000DABA4 File Offset: 0x000D8DA4
		[global::System.Runtime.Serialization.DataMember]
		public string PhysicalSerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)870992558;
				short num2 = num;
				num = (short)1271810734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858994176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055274496;
				if (num != 0)
				{
				}
				num = (short)848625665;
				if (num != 0)
				{
				}
				return this.<PhysicalSerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2090683857;
				short num2 = num;
				num = (short)355749329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1756954624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144113664;
				if (num != 0)
				{
				}
				num = (short)1026818049;
				if (num != 0)
				{
				}
				this.<PhysicalSerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x000DAC54 File Offset: 0x000D8E54
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x000DAD04 File Offset: 0x000D8F04
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1006279406;
				short num2 = num;
				num = (short)488545006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1058865152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129264641;
				if (num != 0)
				{
				}
				num = (short)1044054016;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1153429434;
				short num2 = num;
				num = (short)2049372090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1212219392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1088225281;
				if (num != 0)
				{
				}
				num = (short)1883897856;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x000DADB4 File Offset: 0x000D8FB4
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x000DAE68 File Offset: 0x000D9068
		[global::System.Runtime.Serialization.DataMember]
		public bool? EnableOnSystem
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)796524545;
				if (num != 0)
				{
				}
				num = (short)1553924096;
				short num2 = num;
				num = (short)1503407728;
				short num3 = num;
				num = (short)1170419312;
				switch (num3 == num)
				{
				}
				num = (short)1551171584;
				if (num != 0)
				{
				}
				return this.<EnableOnSystem>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2021937285;
				short num2 = num;
				num = (short)1050628229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562443776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151519232;
				if (num != 0)
				{
				}
				num = (short)478543873;
				if (num != 0)
				{
				}
				this.<EnableOnSystem>k__BackingField = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x000DAF1C File Offset: 0x000D911C
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x000DAFC8 File Offset: 0x000D91C8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType? DeviceType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)197190205;
				short num2 = num;
				num = (short)1624498749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908408320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329121793;
				if (num != 0)
				{
				}
				num = (short)1354170368;
				if (num != 0)
				{
				}
				return this.<DeviceType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1236668144;
				short num2 = num;
				num = (short)498077424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098186752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593769985;
				if (num != 0)
				{
				}
				num = (short)1540358144;
				if (num != 0)
				{
				}
				this.<DeviceType>k__BackingField = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x000DB078 File Offset: 0x000D9278
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x000DB128 File Offset: 0x000D9328
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? SACSiteSelUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1845997223;
				short num2 = num;
				num = (short)609857191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)994443264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1129971712;
				if (num != 0)
				{
				}
				num = (short)1040121857;
				if (num != 0)
				{
				}
				return this.<SACSiteSelUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1775638547;
				short num2 = num;
				num = (short)86054931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)580845568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1488650241;
				if (num != 0)
				{
				}
				num = (short)1512636416;
				if (num != 0)
				{
				}
				this.<SACSiteSelUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x000DB1DC File Offset: 0x000D93DC
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x000DB28C File Offset: 0x000D948C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? TelephoneGatewayUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1779134512;
				short num2 = num;
				num = (short)264335408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521418240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1664548865;
				if (num != 0)
				{
				}
				num = (short)1792016384;
				if (num != 0)
				{
				}
				return this.<TelephoneGatewayUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)424641810;
				short num2 = num;
				num = (short)1705739538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1114963968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1718747137;
				if (num != 0)
				{
				}
				num = (short)544931840;
				if (num != 0)
				{
				}
				this.<TelephoneGatewayUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x000DB33C File Offset: 0x000D953C
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x000DB3EC File Offset: 0x000D95EC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RecordingSiteUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)603652322;
				short num2 = num;
				num = (short)181207266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470627840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519372800;
				if (num != 0)
				{
				}
				num = (short)1889206273;
				if (num != 0)
				{
				}
				return this.<RecordingSiteUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)928776193;
				if (num != 0)
				{
				}
				num = (short)76480512;
				short num2 = num;
				num = (short)131809308;
				short num3 = num;
				num = (short)2072264732;
				switch (num3 == num)
				{
				}
				num = (short)41615360;
				if (num != 0)
				{
				}
				this.<RecordingSiteUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x000DB49C File Offset: 0x000D969C
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x000DB54C File Offset: 0x000D974C
		[global::System.Runtime.Serialization.DataMember]
		public bool? BroadcastVoiceCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1848524539;
				short num2 = num;
				num = (short)1998405371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591083008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726007808;
				if (num != 0)
				{
				}
				num = (short)1536163841;
				if (num != 0)
				{
				}
				return this.<BroadcastVoiceCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1027492002;
				short num2 = num;
				num = (short)841631906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735524352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)700645377;
				if (num != 0)
				{
				}
				num = (short)1813250048;
				if (num != 0)
				{
				}
				this.<BroadcastVoiceCall>k__BackingField = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x000DB5FC File Offset: 0x000D97FC
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x000DB6AC File Offset: 0x000D98AC
		[global::System.Runtime.Serialization.DataMember]
		public bool? CallAlert
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)849783350;
				short num2 = num;
				num = (short)824486454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757137408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1424424961;
				if (num != 0)
				{
				}
				num = (short)1240858624;
				if (num != 0)
				{
				}
				return this.<CallAlert>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1681612386;
				short num2 = num;
				num = (short)967466594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660747776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056716288;
				if (num != 0)
				{
				}
				num = (short)53870593;
				if (num != 0)
				{
				}
				this.<CallAlert>k__BackingField = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x000DB75C File Offset: 0x000D995C
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x000DB808 File Offset: 0x000D9A08
		[global::System.Runtime.Serialization.DataMember]
		public bool? GroupDataCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1485450355;
				short num2 = num;
				num = (short)1386425459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843396608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706688513;
				if (num != 0)
				{
				}
				num = (short)212533248;
				if (num != 0)
				{
				}
				return this.<GroupDataCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1381811951;
				short num2 = num;
				num = (short)1556530927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348206592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)145489920;
				if (num != 0)
				{
				}
				num = (short)1632174081;
				if (num != 0)
				{
				}
				this.<GroupDataCall>k__BackingField = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000DB8B8 File Offset: 0x000D9AB8
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x000DB964 File Offset: 0x000D9B64
		[global::System.Runtime.Serialization.DataMember]
		public bool? GroupVoiceCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1756803336;
				short num2 = num;
				num = (short)485601544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220987392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143603200;
				if (num != 0)
				{
				}
				num = (short)1277952001;
				if (num != 0)
				{
				}
				return this.<GroupVoiceCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)817471668;
				short num2 = num;
				num = (short)1192599732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199360512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825556993;
				if (num != 0)
				{
				}
				num = (short)2040266752;
				if (num != 0)
				{
				}
				this.<GroupVoiceCall>k__BackingField = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x000DBA14 File Offset: 0x000D9C14
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x000DBAC0 File Offset: 0x000D9CC0
		[global::System.Runtime.Serialization.DataMember]
		public bool? IndividualDataCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)748298049;
				short num2 = num;
				num = (short)39788353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056112640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)456327169;
				if (num != 0)
				{
				}
				num = (short)308740096;
				if (num != 0)
				{
				}
				return this.<IndividualDataCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)798967235;
				short num2 = num;
				num = (short)75646403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)273481728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1043136513;
				if (num != 0)
				{
				}
				num = (short)332398592;
				if (num != 0)
				{
				}
				this.<IndividualDataCall>k__BackingField = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x000DBB70 File Offset: 0x000D9D70
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x000DBC24 File Offset: 0x000D9E24
		[global::System.Runtime.Serialization.DataMember]
		public bool? IndividualVoiceCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1005355465;
				short num2 = num;
				num = (short)1898349001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822949376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407044096;
				if (num != 0)
				{
				}
				num = (short)1605369857;
				if (num != 0)
				{
				}
				return this.<IndividualVoiceCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1689461305;
				short num2 = num;
				num = (short)1847534137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)362872832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)641859585;
				if (num != 0)
				{
				}
				num = (short)1092943872;
				if (num != 0)
				{
				}
				this.<IndividualVoiceCall>k__BackingField = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x000DBCD8 File Offset: 0x000D9ED8
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x000DBD88 File Offset: 0x000D9F88
		[global::System.Runtime.Serialization.DataMember]
		public bool? InitiateStunRevive
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1978069181;
				short num2 = num;
				num = (short)420606141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1920270336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1139867649;
				if (num != 0)
				{
				}
				num = (short)952238080;
				if (num != 0)
				{
				}
				return this.<InitiateStunRevive>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1740086649;
				short num2 = num;
				num = (short)944414073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1349844992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216465409;
				if (num != 0)
				{
				}
				num = (short)367853568;
				if (num != 0)
				{
				}
				this.<InitiateStunRevive>k__BackingField = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x000DBE3C File Offset: 0x000DA03C
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x000DBEEC File Offset: 0x000DA0EC
		[global::System.Runtime.Serialization.DataMember]
		public bool? MultiSiteAllCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)621212061;
				short num2 = num;
				num = (short)2088104349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1791754240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)990773249;
				if (num != 0)
				{
				}
				num = (short)657981440;
				if (num != 0)
				{
				}
				return this.<MultiSiteAllCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)797210334;
				short num2 = num;
				num = (short)442529502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026962944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)528351233;
				if (num != 0)
				{
				}
				num = (short)1909456896;
				if (num != 0)
				{
				}
				this.<MultiSiteAllCall>k__BackingField = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x000DBF9C File Offset: 0x000DA19C
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x000DC054 File Offset: 0x000DA254
		[global::System.Runtime.Serialization.DataMember]
		public int? QueuePriority
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)100335617;
				if (num != 0)
				{
				}
				num = (short)446496768;
				short num2 = num;
				num = (short)1216720297;
				short num3 = num;
				num = (short)1074965929;
				switch (num3 == num)
				{
				}
				num = (short)1566310400;
				if (num != 0)
				{
				}
				return this.<QueuePriority>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1176084805;
				short num2 = num;
				num = (short)1677435205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1102381056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115895297;
				if (num != 0)
				{
				}
				num = (short)1804140544;
				if (num != 0)
				{
				}
				this.<QueuePriority>k__BackingField = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x000DC104 File Offset: 0x000DA304
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x000DC1B4 File Offset: 0x000DA3B4
		[global::System.Runtime.Serialization.DataMember]
		public bool? RadioCheckTX
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1468961491;
				short num2 = num;
				num = (short)103387859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1213923328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665138688;
				if (num != 0)
				{
				}
				num = (short)609157121;
				if (num != 0)
				{
				}
				return this.<RadioCheckTX>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)451805185;
				if (num != 0)
				{
				}
				num = (short)25296896;
				short num2 = num;
				num = (short)1066410678;
				short num3 = num;
				num = (short)1404052150;
				switch (num3 == num)
				{
				}
				num = (short)781254656;
				if (num != 0)
				{
				}
				this.<RadioCheckTX>k__BackingField = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x000DC264 File Offset: 0x000DA464
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x000DC314 File Offset: 0x000DA514
		[global::System.Runtime.Serialization.DataMember]
		public bool? StatusCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1034124057;
				short num2 = num;
				num = (short)547650329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)576847872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16449537;
				if (num != 0)
				{
				}
				num = (short)1046216704;
				if (num != 0)
				{
				}
				return this.<StatusCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1967259649;
				if (num != 0)
				{
				}
				num = (short)2029977600;
				short num2 = num;
				num = (short)550417758;
				short num3 = num;
				num = (short)681031006;
				switch (num3 == num)
				{
				}
				num = (short)391315456;
				if (num != 0)
				{
				}
				this.<StatusCall>k__BackingField = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000DC3C8 File Offset: 0x000DA5C8
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x000DC478 File Offset: 0x000DA678
		[global::System.Runtime.Serialization.DataMember]
		public bool? SystemAllCallTx
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)260628404;
				short num2 = num;
				num = (short)1648811956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)710868992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816054273;
				if (num != 0)
				{
				}
				num = (short)805306368;
				if (num != 0)
				{
				}
				return this.<SystemAllCallTx>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)807121548;
				short num2 = num;
				num = (short)241480332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1328545792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1659830273;
				if (num != 0)
				{
				}
				num = (short)659030016;
				if (num != 0)
				{
				}
				this.<SystemAllCallTx>k__BackingField = value;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x000DC528 File Offset: 0x000DA728
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x000DC5D8 File Offset: 0x000DA7D8
		[global::System.Runtime.Serialization.DataMember]
		public bool? KillRX
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)496500401;
				short num2 = num;
				num = (short)393871025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806827520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078605313;
				if (num != 0)
				{
				}
				num = (short)239534080;
				if (num != 0)
				{
				}
				return this.<KillRX>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)397452114;
				short num2 = num;
				num = (short)1503634258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081278464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				num = (short)175767553;
				if (num != 0)
				{
				}
				this.<KillRX>k__BackingField = value;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000DC688 File Offset: 0x000DA888
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x000DC73C File Offset: 0x000DA93C
		[global::System.Runtime.Serialization.DataMember]
		public bool? KillTx
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1685661217;
				short num2 = num;
				num = (short)1465787937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508507648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)722141184;
				if (num != 0)
				{
				}
				num = (short)981401601;
				if (num != 0)
				{
				}
				return this.<KillTx>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1307794357;
				short num2 = num;
				num = (short)747133877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1551040512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948895744;
				if (num != 0)
				{
				}
				num = (short)854654977;
				if (num != 0)
				{
				}
				this.<KillTx>k__BackingField = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000DC7F0 File Offset: 0x000DA9F0
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x000DC8A0 File Offset: 0x000DAAA0
		[global::System.Runtime.Serialization.DataMember]
		public bool? DgnaRx
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1411767681;
				short num2 = num;
				num = (short)661904769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1524039680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700593664;
				if (num != 0)
				{
				}
				num = (short)888406017;
				if (num != 0)
				{
				}
				return this.<DgnaRx>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1808990209;
				if (num != 0)
				{
				}
				num = (short)92471296;
				short num2 = num;
				num = (short)861451564;
				short num3 = num;
				num = (short)535409964;
				switch (num3 == num)
				{
				}
				num = (short)1330249728;
				if (num != 0)
				{
				}
				this.<DgnaRx>k__BackingField = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000DC954 File Offset: 0x000DAB54
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x000DCA04 File Offset: 0x000DAC04
		[global::System.Runtime.Serialization.DataMember]
		public bool? Preempt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1463005449;
				short num2 = num;
				num = (short)65450249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)333578240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)579141633;
				if (num != 0)
				{
				}
				num = (short)2022506496;
				if (num != 0)
				{
				}
				return this.<Preempt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1251520144;
				short num2 = num;
				num = (short)2064887440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)214695936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396441089;
				if (num != 0)
				{
				}
				num = (short)10616832;
				if (num != 0)
				{
				}
				this.<Preempt>k__BackingField = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000DCAB4 File Offset: 0x000DACB4
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x000DCB64 File Offset: 0x000DAD64
		[global::System.Runtime.Serialization.DataMember]
		public bool? ReceiveIndividualVoiceCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1359622637;
				short num2 = num;
				num = (short)412627437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)77266944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567869440;
				if (num != 0)
				{
				}
				num = (short)767557633;
				if (num != 0)
				{
				}
				return this.<ReceiveIndividualVoiceCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1552460794;
				short num2 = num;
				num = (short)1426566138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)907345920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716898305;
				if (num != 0)
				{
				}
				num = (short)1601568768;
				if (num != 0)
				{
				}
				this.<ReceiveIndividualVoiceCall>k__BackingField = value;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x000DCC10 File Offset: 0x000DAE10
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x000DCCC0 File Offset: 0x000DAEC0
		[global::System.Runtime.Serialization.DataMember]
		public bool? ReceiveRemoteMonitor
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2032949150;
				short num2 = num;
				num = (short)974018462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558249472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)763756545;
				if (num != 0)
				{
				}
				num = (short)1754791936;
				if (num != 0)
				{
				}
				return this.<ReceiveRemoteMonitor>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1958798494;
				short num2 = num;
				num = (short)1853088926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1738407936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1198718977;
				if (num != 0)
				{
				}
				num = (short)167968768;
				if (num != 0)
				{
				}
				this.<ReceiveRemoteMonitor>k__BackingField = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000DCD70 File Offset: 0x000DAF70
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x000DCE1C File Offset: 0x000DB01C
		[global::System.Runtime.Serialization.DataMember]
		public bool? ReceiveStunRevive
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1710161920;
				short num2 = num;
				num = (short)1637280394;
				short num3 = num;
				num = (short)847374986;
				switch (num3 == num)
				{
				}
				num = (short)1636499456;
				if (num != 0)
				{
				}
				num = (short)1677000705;
				if (num != 0)
				{
				}
				return this.<ReceiveStunRevive>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1929510912;
				short num2 = num;
				num = (short)1785364139;
				short num3 = num;
				num = (short)1649770155;
				switch (num3 == num)
				{
				}
				num = (short)360054784;
				if (num != 0)
				{
				}
				num = (short)1474887681;
				if (num != 0)
				{
				}
				this.<ReceiveStunRevive>k__BackingField = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000DCECC File Offset: 0x000DB0CC
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x000DCF7C File Offset: 0x000DB17C
		[global::System.Runtime.Serialization.DataMember]
		public bool? ReceiveTelephoneCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)687538176;
				short num2 = num;
				num = (short)1359413249;
				if (num != 0)
				{
				}
				num = (short)581784207;
				short num3 = num;
				num = (short)1160991375;
				switch (num3 == num)
				{
				}
				num = (short)1927413760;
				if (num != 0)
				{
				}
				return this.<ReceiveTelephoneCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)435552256;
				short num2 = num;
				num = (short)470780312;
				short num3 = num;
				num = (short)1030195608;
				switch (num3 == num)
				{
				}
				num = (short)1037565953;
				if (num != 0)
				{
				}
				num = (short)156893184;
				if (num != 0)
				{
				}
				this.<ReceiveTelephoneCall>k__BackingField = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x000DD02C File Offset: 0x000DB22C
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x000DD0DC File Offset: 0x000DB2DC
		[global::System.Runtime.Serialization.DataMember]
		public bool? EmergencyCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1618149376;
				short num2 = num;
				num = (short)1909402801;
				short num3 = num;
				num = (short)1709780145;
				switch (num3 == num)
				{
				}
				num = (short)1262944257;
				if (num != 0)
				{
				}
				num = (short)310181888;
				if (num != 0)
				{
				}
				return this.<EmergencyCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1984561152;
				short num2 = num;
				num = (short)446955521;
				if (num != 0)
				{
				}
				num = (short)1002023418;
				short num3 = num;
				num = (short)641903098;
				switch (num3 == num)
				{
				}
				num = (short)1320157184;
				if (num != 0)
				{
				}
				this.<EmergencyCall>k__BackingField = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x000DD18C File Offset: 0x000DB38C
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x000DD23C File Offset: 0x000DB43C
		[global::System.Runtime.Serialization.DataMember]
		public bool? RemoteMonitor
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)644481024;
				short num2 = num;
				num = (short)263990928;
				short num3 = num;
				num = (short)99495568;
				switch (num3 == num)
				{
				}
				num = (short)995164161;
				if (num != 0)
				{
				}
				num = (short)3145728;
				if (num != 0)
				{
				}
				return this.<RemoteMonitor>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)492568576;
				short num2 = num;
				num = (short)1395458049;
				if (num != 0)
				{
				}
				num = (short)593843498;
				short num3 = num;
				num = (short)2029344042;
				switch (num3 == num)
				{
				}
				num = (short)578879488;
				if (num != 0)
				{
				}
				this.<RemoteMonitor>k__BackingField = value;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x000DD2EC File Offset: 0x000DB4EC
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x000DD39C File Offset: 0x000DB59C
		[global::System.Runtime.Serialization.DataMember]
		public bool? ShortDataCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)910819328;
				short num2 = num;
				num = (short)355823088;
				short num3 = num;
				num = (short)1612475888;
				switch (num3 == num)
				{
				}
				num = (short)487456768;
				if (num != 0)
				{
				}
				num = (short)1809448961;
				if (num != 0)
				{
				}
				return this.<ShortDataCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)875495424;
				short num2 = num;
				num = (short)1155664951;
				short num3 = num;
				num = (short)1821510711;
				switch (num3 == num)
				{
				}
				num = (short)1103953920;
				if (num != 0)
				{
				}
				num = (short)2001993729;
				if (num != 0)
				{
				}
				this.<ShortDataCall>k__BackingField = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000DD44C File Offset: 0x000DB64C
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x000DD500 File Offset: 0x000DB700
		[global::System.Runtime.Serialization.DataMember]
		public bool? SiteAllCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1940193280;
				short num2 = num;
				num = (short)494493640;
				short num3 = num;
				num = (short)244015048;
				switch (num3 == num)
				{
				}
				num = (short)1769537537;
				if (num != 0)
				{
				}
				num = (short)1477115904;
				if (num != 0)
				{
				}
				return this.<SiteAllCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1532821504;
				short num2 = num;
				num = (short)1488912385;
				if (num != 0)
				{
				}
				num = (short)886588612;
				short num3 = num;
				num = (short)600786116;
				switch (num3 == num)
				{
				}
				num = (short)1465974784;
				if (num != 0)
				{
				}
				this.<SiteAllCall>k__BackingField = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x000DD5B4 File Offset: 0x000DB7B4
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x000DD664 File Offset: 0x000DB864
		[global::System.Runtime.Serialization.DataMember]
		public bool? TelephoneCall
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1189937152;
				short num2 = num;
				num = (short)292560211;
				short num3 = num;
				num = (short)2025725267;
				switch (num3 == num)
				{
				}
				num = (short)2090663936;
				if (num != 0)
				{
				}
				num = (short)332988417;
				if (num != 0)
				{
				}
				return this.<TelephoneCall>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1227423744;
				short num2 = num;
				num = (short)848181192;
				short num3 = num;
				num = (short)641218504;
				switch (num3 == num)
				{
				}
				num = (short)741736449;
				if (num != 0)
				{
				}
				num = (short)362741760;
				if (num != 0)
				{
				}
				this.<TelephoneCall>k__BackingField = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x000DD714 File Offset: 0x000DB914
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x000DD7C4 File Offset: 0x000DB9C4
		[global::System.Runtime.Serialization.DataMember]
		public bool? VoiceInterruptTX
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)15269888;
				short num2 = num;
				num = (short)1132948073;
				short num3 = num;
				num = (short)1474062953;
				switch (num3 == num)
				{
				}
				num = (short)347996161;
				if (num != 0)
				{
				}
				num = (short)1214906368;
				if (num != 0)
				{
				}
				return this.<VoiceInterruptTX>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)636420096;
				short num2 = num;
				num = (short)1303760618;
				short num3 = num;
				num = (short)964742890;
				switch (num3 == num)
				{
				}
				num = (short)1412169729;
				if (num != 0)
				{
				}
				num = (short)1029701632;
				if (num != 0)
				{
				}
				this.<VoiceInterruptTX>k__BackingField = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x000DD874 File Offset: 0x000DBA74
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x000DD924 File Offset: 0x000DBB24
		[global::System.Runtime.Serialization.DataMember]
		public int? UserDomainID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)48234496;
				short num2 = num;
				num = (short)1018294847;
				short num3 = num;
				num = (short)1973875263;
				switch (num3 == num)
				{
				}
				num = (short)1394475009;
				if (num != 0)
				{
				}
				num = (short)372178944;
				if (num != 0)
				{
				}
				return this.<UserDomainID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1230766080;
				short num2 = num;
				num = (short)1227677227;
				short num3 = num;
				num = (short)1572527659;
				switch (num3 == num)
				{
				}
				num = (short)1845624833;
				if (num != 0)
				{
				}
				num = (short)38993920;
				if (num != 0)
				{
				}
				this.<UserDomainID>k__BackingField = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x000DD9D8 File Offset: 0x000DBBD8
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x000DDA88 File Offset: 0x000DBC88
		[global::System.Runtime.Serialization.DataMember]
		public string RadioAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)282066944;
				short num2 = num;
				num = (short)696435971;
				short num3 = num;
				num = (short)447923459;
				switch (num3 == num)
				{
				}
				num = (short)1883045888;
				if (num != 0)
				{
				}
				num = (short)743571457;
				if (num != 0)
				{
				}
				return this.<RadioAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1663172608;
				short num2 = num;
				num = (short)1833470365;
				short num3 = num;
				num = (short)1257671069;
				switch (num3 == num)
				{
				}
				num = (short)1783431168;
				if (num != 0)
				{
				}
				num = (short)284426241;
				if (num != 0)
				{
				}
				this.<RadioAlias>k__BackingField = value;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000DDB38 File Offset: 0x000DBD38
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecord ConvertTo()
		{
			short num = (short)159121408;
			short num2 = num;
			num = (short)152305665;
			if (num != 0)
			{
			}
			num = (short)876112110;
			short num3 = num;
			num = (short)138504430;
			switch (num3 == num)
			{
			}
			num = (short)1818099712;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.SACRecord
			{
				Uuid = (this.Uuid ?? global::System.Guid.NewGuid()),
				Timestamp = this.Timestamp,
				SystemUuid = this.SystemUuid,
				SerialNumber = this.SerialNumber,
				RadioID = this.RadioID,
				PhysicalSerialNumber = this.PhysicalSerialNumber,
				RadioUuid = this.RadioUuid,
				EnableOnSystem = (this.EnableOnSystem ?? true),
				DeviceType = this.DeviceType.GetValueOrDefault(),
				SACSiteSelUuid = this.SACSiteSelUuid,
				TelephoneGatewayUuid = this.TelephoneGatewayUuid,
				RecordingSiteUuid = this.RecordingSiteUuid,
				CallAlert = (this.CallAlert ?? true),
				GroupVoiceCall = (this.GroupVoiceCall ?? true),
				IndividualDataCall = (this.IndividualDataCall ?? true),
				IndividualVoiceCall = (this.IndividualVoiceCall ?? true),
				QueuePriority = new int?(this.QueuePriority ?? 6),
				ReceiveIndividualVoiceCall = (this.ReceiveIndividualVoiceCall ?? true),
				ReceiveRemoteMonitor = (this.ReceiveRemoteMonitor ?? true),
				ReceiveStunRevive = (this.ReceiveStunRevive ?? true),
				ReceiveTelephoneCall = (this.ReceiveTelephoneCall ?? true),
				EmergencyCall = (this.EmergencyCall ?? true),
				InitiateStunRevive = this.InitiateStunRevive.GetValueOrDefault(),
				RadioCheckTX = this.RadioCheckTX.GetValueOrDefault(),
				StatusCall = this.StatusCall.GetValueOrDefault(),
				SystemAllCallTx = this.SystemAllCallTx.GetValueOrDefault(),
				KillRX = (this.KillRX ?? true),
				DgnaRx = this.DgnaRx.GetValueOrDefault(),
				KillTx = this.KillTx.GetValueOrDefault(),
				Preempt = this.Preempt.GetValueOrDefault(),
				MultiSiteAllCall = this.MultiSiteAllCall.GetValueOrDefault(),
				GroupDataCall = this.GroupDataCall.GetValueOrDefault(),
				BroadcastVoiceCall = this.BroadcastVoiceCall.GetValueOrDefault(),
				RemoteMonitor = this.RemoteMonitor.GetValueOrDefault(),
				ShortDataCall = this.ShortDataCall.GetValueOrDefault(),
				SiteAllCall = this.SiteAllCall.GetValueOrDefault(),
				TelephoneCall = this.TelephoneCall.GetValueOrDefault(),
				VoiceInterruptTX = this.VoiceInterruptTX.GetValueOrDefault(),
				UserDomainID = this.UserDomainID.GetValueOrDefault(),
				RadioAlias = this.RadioAlias
			};
		}
	}
}
