using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x0200002C RID: 44
	[global::System.Serializable]
	public sealed class VoiceAnnouncementGeneralSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00002650 File Offset: 0x00000850
		internal VoiceAnnouncementGeneralSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000265F File Offset: 0x0000085F
		internal VoiceAnnouncementGeneralSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000591C0 File Offset: 0x000573C0
		public override void Init()
		{
			int a_ = 6;
			short num = (short)2028460641;
			short num2 = num;
			num = (short)1356388961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)823197696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1372848129;
			if (num != 0)
			{
			}
			num = (short)715849728;
			if (num != 0)
			{
			}
			this.voiceFileName_A21220 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf88햒ﲔﮖﲘ햚ﲜ쒠ﲢ閦風馪龬龮", a_), global::CommonResources.AppResources.Voice_Filename, 32);
			this.voiceFileName_A21220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.voiceFileName_A21220.DataTransferOrder = 4;
			this.voiceFileName_A21220.EvaluateRecRefs = true;
			this.voiceAnnouncementFileHashcode_A24563 = new global::AcpBusinessLayer.AcpField<uint>(0U, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf88튒ﮔ練ﲞ쒠캢삤즦\udda8첬\udcae\ud9b0킲\udab4펶\udcb8", a_), global::CommonResources.AppResources.Voice_Hashcode);
			this.voiceAnnouncementFileHashcode_A24563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.voiceAnnouncementFileHashcode_A24563.DataTransferOrder = 2;
			this.voiceAnnouncementEncodeType_A22264 = new global::AcpBusinessLayer.AcpListField(1, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf88튒ﮔ練ﲞ쒠캢삤즦\udda8쎬첮\udeb0ힲ킴삸쮺\ud8bc", a_), global::CommonResources.AppResources.Encode_Type, global::SpecialFeatures.VoiceAnnouncements.List.LOVs.VoiceAnnouncementEncodeType_A22264LovStrs);
			this.voiceAnnouncementEncodeType_A22264.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.voiceAnnouncementEncodeType_A22264.DataTransferOrder = 3;
			this.voiceFileDataInfo_A21213 = new global::AcpBusinessLayer.AcpVoiceFileField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf88튒ﮔ練ﲞ쒠캢삤즦\udda8쒬쎮풰", a_), global::CommonResources.AppResources.Voice_Data);
			this.voiceFileDataInfo_A21213.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.voiceFileDataInfo_A21213.DataTransferOrder = 1;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캈璉", a_);
			base.Id = 10500;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00059398 File Offset: 0x00057598
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)465384775;
			short num2 = num;
			num = (short)917583175;
			switch (num2 == num)
			{
			default:
			{
				num = (short)83099648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1622212609;
			if (num != 0)
			{
			}
			num = (short)368836608;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00059448 File Offset: 0x00057648
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1148846092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.voiceAnnouncementFileHashcode_A24563 = new global::AcpBusinessLayer.AcpField<uint>(0U, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\ud898풠춢욤슦쒨캪쎬\udbae聆튲운\udfb6\udab8풺\ud9bc\udabe", a_), global::CommonResources.AppResources.Voice_Hashcode);
					this.voiceAnnouncementFileHashcode_A24563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.voiceAnnouncementFileHashcode_A24563.DataTransferOrder = 2;
					num = (short)726925315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)962592781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\ud898풠춢욤슦쒨캪쎬\udbae\udab2\ud9b4튶", a_)))
					{
						num = (short)2125463557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_404;
				case 3:
					goto IL_26A;
				case 4:
					goto IL_351;
				case 5:
					this.voiceFileDataInfo_A21213 = new global::AcpBusinessLayer.AcpVoiceFileField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\ud898풠춢욤슦쒨캪쎬\udbae\udab2\ud9b4튶", a_), global::CommonResources.AppResources.Voice_Data);
					this.voiceFileDataInfo_A21213.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.voiceFileDataInfo_A21213.DataTransferOrder = 1;
					num = (short)1330577412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.voiceAnnouncementEncodeType_A22264 = new global::AcpBusinessLayer.AcpListField(1, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\ud898풠춢욤슦쒨캪쎬\udbae\uddb2횴\ud8b6\uddb8\udeba욾뇀ꛂ", a_), global::CommonResources.AppResources.Encode_Type, global::SpecialFeatures.VoiceAnnouncements.List.LOVs.VoiceAnnouncementEncodeType_A22264LovStrs);
					this.voiceAnnouncementEncodeType_A22264.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.voiceAnnouncementEncodeType_A22264.DataTransferOrder = 3;
					num = (short)1596981263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\ud898풠춢욤슦쒨캪쎬\udbae聆튲운\udfb6\udab8풺\ud9bc\udabe", a_)))
					{
						num = (short)1603731456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26A;
				case 8:
				{
					num = (short)1249312768;
					short num3 = num;
					this.voiceFileName_A21220 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\udf98爵슢좤슦龬麮莰膲薴", a_), global::CommonResources.AppResources.Voice_Filename, 32);
					this.voiceFileName_A21220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.voiceFileName_A21220.DataTransferOrder = 4;
					this.voiceFileName_A21220.EvaluateRecRefs = true;
					num = (short)60096522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)194707467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_356;
				case 11:
					num = (short)958201857;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)24903681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_404;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 13:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\udf98爵슢좤슦龬麮莰膲薴", a_)))
					{
						goto IL_16F;
					}
					goto IL_356;
				case 14:
				{
					num = (short)1382040542;
					short num4 = num;
					num = (short)1260340190;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16F;
					default:
						num = (short)709099520;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗\ud898풠춢욤슦쒨캪쎬\udbae\uddb2횴\ud8b6\uddb8\udeba욾뇀ꛂ", a_)))
						{
							num = (short)518782982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					}
					break;
				}
				case 15:
					goto IL_1B6;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)119537673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16F:
				num = (short)703135752;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B6:
				num = (short)648806402;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26A:
				num = (short)1257963534;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_356:
				num = (short)796131335;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_351:
			IL_404:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좎ﶒ", a_);
			base.Id = 10500;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0005988C File Offset: 0x00057A8C
		public override void PopulateReferences()
		{
			short num = (short)85852162;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					global::AcpCommonLib.Document containerDoc = base.ParentRecset.ContainerDoc;
					goto IL_FC;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1820440696;
				short num3 = num;
				num = (short)202815608;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_FC:
					num = (short)1920598016;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1752432641;
					if (num != 0)
					{
					}
					num = (short)166002688;
					if (num != 0)
					{
					}
					if (base.ParentRecset == null)
					{
						return;
					}
					num = (short)1652817920;
					short num4 = num;
					num = (short)765460481;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000599B0 File Offset: 0x00057BB0
		public override void DropReferences()
		{
			short num = (short)2098421157;
			short num2 = num;
			num = (short)1193041317;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1604780032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)116195329;
			if (num != 0)
			{
			}
			num = (short)281018368;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00059A5C File Offset: 0x00057C5C
		public override void SetConstraints()
		{
			short num = (short)820495933;
			short num2 = num;
			num = (short)703579709;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1998585856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1052704769;
			if (num != 0)
			{
			}
			num = (short)897187840;
			if (num != 0)
			{
			}
			this.voiceFileName_A21220.ValidateAcrossRecset = true;
			this.voiceFileName_A21220.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementsConstraints.conVoiceAnnouncementFileValidity);
			this.voiceFileName_A21220.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementsConstraints.conSetVAFieldsValue);
			this.voiceFileName_A21220.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementsConstraints.conSetVoiceAnnouncementFileEditability);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00059B54 File Offset: 0x00057D54
		public override void SetupDependencies()
		{
			short num = (short)2090829244;
			short num2 = num;
			num = (short)1188464060;
			switch (num2 == num)
			{
			default:
			{
				num = (short)648478720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)923271168;
			if (num != 0)
			{
			}
			num = (short)299237377;
			if (num != 0)
			{
			}
			this.voiceFileName_A21220.AddDependentObject(this.voiceAnnouncementEncodeType_A22264);
			this.voiceFileName_A21220.AddDependentObject(this.voiceFileDataInfo_A21213);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00059C20 File Offset: 0x00057E20
		public bool HasDiffs
		{
			get
			{
				short num = (short)469042474;
				short num2 = num;
				num = (short)565970218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495793664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522466817;
				if (num != 0)
				{
				}
				num = (short)1404829696;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00059CD0 File Offset: 0x00057ED0
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00059D84 File Offset: 0x00057F84
		public string VoiceFileName_A21220Value
		{
			get
			{
				short num = (short)1058799617;
				if (num != 0)
				{
				}
				num = (short)1527644160;
				short num2 = num;
				num = (short)2078532128;
				short num3 = num;
				num = (short)1342824992;
				switch (num3 == num)
				{
				}
				num = (short)2136670208;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Value;
			}
			set
			{
				short num = (short)910048042;
				short num2 = num;
				num = (short)403651370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390280704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1122762753;
				if (num != 0)
				{
				}
				num = (short)153157632;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Value = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00059E3C File Offset: 0x0005803C
		public global::AcpBusinessLayer.AcpKeyField VoiceFileName_A21220Object
		{
			get
			{
				short num = (short)1870450717;
				short num2 = num;
				num = (short)740282397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889520128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435828225;
				if (num != 0)
				{
				}
				num = (short)373620736;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00059EEC File Offset: 0x000580EC
		internal string VoiceFileName_A21220_UILabel
		{
			get
			{
				short num = (short)1067081891;
				short num2 = num;
				num = (short)1093361827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1118371840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)50331649;
				if (num != 0)
				{
				}
				num = (short)1901789184;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.UIName;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00059FA0 File Offset: 0x000581A0
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0005A054 File Offset: 0x00058254
		public bool VoiceFileName_A21220_Applicable
		{
			get
			{
				short num = (short)2065031368;
				short num2 = num;
				num = (short)242016456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861011968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1257766912;
				if (num != 0)
				{
				}
				num = (short)1823539201;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Applicable;
			}
			set
			{
				short num = (short)1042895541;
				short num2 = num;
				num = (short)1774867125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179830784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696385536;
				if (num != 0)
				{
				}
				num = (short)1427570689;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Applicable = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0005A108 File Offset: 0x00058308
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0005A1BC File Offset: 0x000583BC
		public bool VoiceFileName_A21220_Editable
		{
			get
			{
				short num = (short)1240175773;
				short num2 = num;
				num = (short)955094173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56164352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)8781825;
				if (num != 0)
				{
				}
				num = (short)1945829376;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Editable;
			}
			set
			{
				short num = (short)597477932;
				short num2 = num;
				num = (short)670091820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536346624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719271425;
				if (num != 0)
				{
				}
				num = (short)994770944;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Editable = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0005A274 File Offset: 0x00058474
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x0005A324 File Offset: 0x00058524
		public bool VoiceFileName_A21220_Visible
		{
			get
			{
				short num = (short)908460033;
				if (num != 0)
				{
				}
				num = (short)1949302784;
				short num2 = num;
				num = (short)1111802075;
				short num3 = num;
				num = (short)832422107;
				switch (num3 == num)
				{
				}
				num = (short)1289486336;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Visible;
			}
			set
			{
				short num = (short)841871478;
				short num2 = num;
				num = (short)1675554934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)761593856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)590741504;
				if (num != 0)
				{
				}
				num = (short)381812737;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Visible = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0005A3D4 File Offset: 0x000585D4
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x0005A488 File Offset: 0x00058688
		public bool VoiceFileName_A21220_Valid
		{
			get
			{
				short num = (short)581912287;
				short num2 = num;
				num = (short)1053640415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501612544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2134114305;
				if (num != 0)
				{
				}
				num = (short)423690240;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.Valid;
			}
			set
			{
				short num = (short)636106829;
				short num2 = num;
				num = (short)954218573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624113152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122383361;
				if (num != 0)
				{
				}
				num = (short)119472128;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.Valid = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0005A53C File Offset: 0x0005873C
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x0005A5F0 File Offset: 0x000587F0
		internal bool VoiceFileName_A21220_HiddenStatic
		{
			get
			{
				short num = (short)739685192;
				short num2 = num;
				num = (short)1199813448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1693122560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115633153;
				if (num != 0)
				{
				}
				num = (short)1094385664;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.HiddenStatic;
			}
			set
			{
				short num = (short)1463152097;
				short num2 = num;
				num = (short)1033760225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314521088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)339804160;
				if (num != 0)
				{
				}
				num = (short)2010841089;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.HiddenStatic = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0005A6A8 File Offset: 0x000588A8
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0005A75C File Offset: 0x0005895C
		internal bool VoiceFileName_A21220_HiddenDynamic
		{
			get
			{
				short num = (short)1635689713;
				short num2 = num;
				num = (short)1186374897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1887961088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467599360;
				if (num != 0)
				{
				}
				num = (short)2070675457;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220.HiddenDynamic;
			}
			set
			{
				short num = (short)1487371534;
				short num2 = num;
				num = (short)1819114766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)938541056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1354891265;
				if (num != 0)
				{
				}
				num = (short)904331264;
				if (num != 0)
				{
				}
				this.voiceFileName_A21220.HiddenDynamic = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0005A810 File Offset: 0x00058A10
		public bool VoiceFileName_A21220_HasDiffs
		{
			get
			{
				short num = (short)1916778744;
				short num2 = num;
				num = (short)1432271096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140602368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1893138432;
				if (num != 0)
				{
				}
				num = (short)472711169;
				if (num != 0)
				{
				}
				return this.voiceFileName_A21220._HasDiffs;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0005A8C4 File Offset: 0x00058AC4
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0005A978 File Offset: 0x00058B78
		public uint VoiceAnnouncementFileHashcode_A24563Value
		{
			get
			{
				short num = (short)1290367938;
				short num2 = num;
				num = (short)376206274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119485952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537474560;
				if (num != 0)
				{
				}
				num = (short)55967745;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Value;
			}
			set
			{
				short num = (short)1256905622;
				short num2 = num;
				num = (short)26401686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)774242304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784872961;
				if (num != 0)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Value = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0005AA2C File Offset: 0x00058C2C
		public global::AcpBusinessLayer.AcpField<uint> VoiceAnnouncementFileHashcode_A24563
		{
			get
			{
				short num = (short)68213218;
				short num2 = num;
				num = (short)111532514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)276430848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131230721;
				if (num != 0)
				{
				}
				num = (short)1734672384;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0005AAE0 File Offset: 0x00058CE0
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x0005AB94 File Offset: 0x00058D94
		public uint VoiceAnnouncementFileHashcode_A24563_UIValue
		{
			get
			{
				short num = (short)1257692084;
				short num2 = num;
				num = (short)2094455732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)115212288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)571146241;
				if (num != 0)
				{
				}
				num = (short)18219008;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Value;
			}
			set
			{
				short num = (short)1641326897;
				short num2 = num;
				num = (short)2019731761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1339555840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1470431233;
				if (num != 0)
				{
				}
				num = (short)1652031488;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Value = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0005AC4C File Offset: 0x00058E4C
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0005AD00 File Offset: 0x00058F00
		public bool VoiceAnnouncementFileHashcode_A24563_Applicable
		{
			get
			{
				short num = (short)675086337;
				if (num != 0)
				{
				}
				num = (short)696516608;
				short num2 = num;
				num = (short)168445577;
				short num3 = num;
				num = (short)209929865;
				switch (num3 == num)
				{
				}
				num = (short)1062797312;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Applicable;
			}
			set
			{
				short num = (short)1540823071;
				short num2 = num;
				num = (short)1890654239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1635319808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)44892161;
				if (num != 0)
				{
				}
				num = (short)1841954816;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Applicable = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0005ADB4 File Offset: 0x00058FB4
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x0005AE6C File Offset: 0x0005906C
		public bool VoiceAnnouncementFileHashcode_A24563_Valid
		{
			get
			{
				short num = (short)1429221835;
				short num2 = num;
				num = (short)116797899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384906752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)806551553;
				if (num != 0)
				{
				}
				num = (short)574423040;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Valid;
			}
			set
			{
				short num = (short)1090617377;
				short num2 = num;
				num = (short)1183481889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536346624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)241369089;
				if (num != 0)
				{
				}
				num = (short)1089470464;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Valid = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0005AF20 File Offset: 0x00059120
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0005AFD4 File Offset: 0x000591D4
		public bool VoiceAnnouncementFileHashcode_A24563_Visible
		{
			get
			{
				short num = (short)932210814;
				short num2 = num;
				num = (short)1323722878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1050083328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1839398913;
				if (num != 0)
				{
				}
				num = (short)1948254208;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Visible;
			}
			set
			{
				short num = (short)368548268;
				short num2 = num;
				num = (short)2063571372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1546321920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2080374785;
				if (num != 0)
				{
				}
				num = (short)1238630400;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Visible = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0005B08C File Offset: 0x0005928C
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x0005B140 File Offset: 0x00059340
		public bool VoiceAnnouncementFileHashcode_A24563_Editable
		{
			get
			{
				short num = (short)285016065;
				if (num != 0)
				{
				}
				num = (short)2012807168;
				short num2 = num;
				num = (short)90773451;
				short num3 = num;
				num = (short)1663375307;
				switch (num3 == num)
				{
				}
				num = (short)478478336;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.Editable;
			}
			set
			{
				short num = (short)1516189962;
				short num2 = num;
				num = (short)885078282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255014400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1424359425;
				if (num != 0)
				{
				}
				num = (short)149291008;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.Editable = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0005B1F8 File Offset: 0x000593F8
		internal string VoiceAnnouncementFileHashcode_A24563_UILabel
		{
			get
			{
				short num = (short)1008141022;
				short num2 = num;
				num = (short)648086238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1204486144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939720704;
				if (num != 0)
				{
				}
				num = (short)1812922369;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.UIName;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0005B360 File Offset: 0x00059560
		internal bool VoiceAnnouncementFileHashcode_A24563_HiddenStatic
		{
			get
			{
				short num = (short)2002094349;
				short num2 = num;
				num = (short)256739597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450115072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1371078657;
				if (num != 0)
				{
				}
				num = (short)1231093760;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.HiddenStatic;
			}
			set
			{
				short num = (short)262650803;
				short num2 = num;
				num = (short)897956787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)992804864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582170113;
				if (num != 0)
				{
				}
				num = (short)1571422208;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.HiddenStatic = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0005B418 File Offset: 0x00059618
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x0005B4CC File Offset: 0x000596CC
		internal bool VoiceAnnouncementFileHashcode_A24563_HiddenDynamic
		{
			get
			{
				short num = (short)1691179771;
				short num2 = num;
				num = (short)379345659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)416546816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636368385;
				if (num != 0)
				{
				}
				num = (short)6684672;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563.HiddenDynamic;
			}
			set
			{
				short num = (short)1947926529;
				if (num != 0)
				{
				}
				num = (short)746192896;
				short num2 = num;
				num = (short)248356446;
				short num3 = num;
				num = (short)799645278;
				switch (num3 == num)
				{
				}
				num = (short)1922170880;
				if (num != 0)
				{
				}
				this.voiceAnnouncementFileHashcode_A24563.HiddenDynamic = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0005B580 File Offset: 0x00059780
		internal bool VoiceAnnouncementFileHashcode_A24563_HasDiffs
		{
			get
			{
				short num = (short)846464700;
				short num2 = num;
				num = (short)1827866300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098514432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)279511041;
				if (num != 0)
				{
				}
				num = (short)1808007168;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementFileHashcode_A24563._HasDiffs;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0005B634 File Offset: 0x00059834
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0005B6E8 File Offset: 0x000598E8
		public int VoiceAnnouncementEncodeType_A22264Value
		{
			get
			{
				short num = (short)893514868;
				short num2 = num;
				num = (short)361624692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460404224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)867434496;
				if (num != 0)
				{
				}
				num = (short)947978241;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Value;
			}
			set
			{
				short num = (short)1755865169;
				short num2 = num;
				num = (short)1384996945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637351424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2037514240;
				if (num != 0)
				{
				}
				num = (short)1755054081;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Value = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0005B79C File Offset: 0x0005999C
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x0005B850 File Offset: 0x00059A50
		public string VoiceAnnouncementEncodeType_A22264_UIValue
		{
			get
			{
				short num = (short)1101777362;
				short num2 = num;
				num = (short)106482130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436076544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564789249;
				if (num != 0)
				{
				}
				num = (short)856096768;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.UIValue;
			}
			set
			{
				short num = (short)1931559654;
				short num2 = num;
				num = (short)1453933286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1652621312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337327617;
				if (num != 0)
				{
				}
				num = (short)1292697600;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.UIValue = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0005B904 File Offset: 0x00059B04
		public global::AcpBusinessLayer.AcpListField VoiceAnnouncementEncodeType_A22264
		{
			get
			{
				short num = (short)1098937234;
				short num2 = num;
				num = (short)1361474450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)787939328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236926465;
				if (num != 0)
				{
				}
				num = (short)1560674304;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0005B9B0 File Offset: 0x00059BB0
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x0005BA68 File Offset: 0x00059C68
		public bool VoiceAnnouncementEncodeType_A22264_Applicable
		{
			get
			{
				short num = (short)756421877;
				short num2 = num;
				num = (short)569709813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332215808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)114032640;
				if (num != 0)
				{
				}
				num = (short)1549205505;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Applicable;
			}
			set
			{
				short num = (short)1916006217;
				short num2 = num;
				num = (short)58847049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)840105984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)694026241;
				if (num != 0)
				{
				}
				num = (short)105512960;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Applicable = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0005BB20 File Offset: 0x00059D20
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x0005BBD4 File Offset: 0x00059DD4
		public bool VoiceAnnouncementEncodeType_A22264_Valid
		{
			get
			{
				short num = (short)71761921;
				if (num != 0)
				{
				}
				num = (short)640548864;
				short num2 = num;
				num = (short)1574581791;
				short num3 = num;
				num = (short)2014000671;
				switch (num3 == num)
				{
				}
				num = (short)864681984;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Valid;
			}
			set
			{
				short num = (short)1379074008;
				short num2 = num;
				num = (short)1990131672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534380544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1928527873;
				if (num != 0)
				{
				}
				num = (short)754319360;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Valid = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0005BC88 File Offset: 0x00059E88
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0005BD3C File Offset: 0x00059F3C
		public bool VoiceAnnouncementEncodeType_A22264_Visible
		{
			get
			{
				short num = (short)871339064;
				short num2 = num;
				num = (short)1960875064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287178752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047199744;
				if (num != 0)
				{
				}
				num = (short)506658817;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Visible;
			}
			set
			{
				short num = (short)768409600;
				short num2 = num;
				num = (short)1520813137;
				short num3 = num;
				num = (short)440124497;
				switch (num3 == num)
				{
				}
				num = (short)165281792;
				if (num != 0)
				{
				}
				num = (short)612958209;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Visible = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0005BDF4 File Offset: 0x00059FF4
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0005BEAC File Offset: 0x0005A0AC
		public bool VoiceAnnouncementEncodeType_A22264_Editable
		{
			get
			{
				short num = (short)1662255104;
				short num2 = num;
				num = (short)870640767;
				short num3 = num;
				num = (short)988867711;
				switch (num3 == num)
				{
				}
				num = (short)1763049473;
				if (num != 0)
				{
				}
				num = (short)1476526080;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.Editable;
			}
			set
			{
				short num = (short)1597505536;
				short num2 = num;
				num = (short)103977045;
				short num3 = num;
				num = (short)1860603989;
				switch (num3 == num)
				{
				}
				num = (short)216203265;
				if (num != 0)
				{
				}
				num = (short)125829120;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.Editable = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0005BF60 File Offset: 0x0005A160
		internal string VoiceAnnouncementEncodeType_A22264_UILabel
		{
			get
			{
				short num = (short)376111104;
				short num2 = num;
				num = (short)1479067344;
				short num3 = num;
				num = (short)1826735824;
				switch (num3 == num)
				{
				}
				num = (short)576847873;
				if (num != 0)
				{
				}
				num = (short)1786445824;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.UIName;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0005C014 File Offset: 0x0005A214
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x0005C0C8 File Offset: 0x0005A2C8
		internal bool VoiceAnnouncementEncodeType_A22264_HiddenStatic
		{
			get
			{
				short num = (short)591790080;
				short num2 = num;
				num = (short)1716256639;
				short num3 = num;
				num = (short)1616707455;
				switch (num3 == num)
				{
				}
				num = (short)1984561153;
				if (num != 0)
				{
				}
				num = (short)2110324736;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.HiddenStatic;
			}
			set
			{
				short num = (short)727121920;
				short num2 = num;
				num = (short)61794786;
				short num3 = num;
				num = (short)796649954;
				switch (num3 == num)
				{
				}
				num = (short)1060175873;
				if (num != 0)
				{
				}
				num = (short)893190144;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.HiddenStatic = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0005C17C File Offset: 0x0005A37C
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x0005C22C File Offset: 0x0005A42C
		internal bool VoiceAnnouncementEncodeType_A22264_HiddenDynamic
		{
			get
			{
				short num = (short)1238106112;
				short num2 = num;
				num = (short)2014964391;
				short num3 = num;
				num = (short)1257761447;
				switch (num3 == num)
				{
				}
				num = (short)1345323009;
				if (num != 0)
				{
				}
				num = (short)1257111552;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementEncodeType_A22264.HiddenDynamic;
			}
			set
			{
				short num = (short)537460736;
				short num2 = num;
				num = (short)1699589081;
				short num3 = num;
				num = (short)677882841;
				switch (num3 == num)
				{
				}
				num = (short)1860304897;
				if (num != 0)
				{
				}
				num = (short)473628672;
				if (num != 0)
				{
				}
				this.voiceAnnouncementEncodeType_A22264.HiddenDynamic = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0005C2E4 File Offset: 0x0005A4E4
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x0005C39C File Offset: 0x0005A59C
		public global::AcpBusinessLayer.AcpVoiceFileStruct VoiceFileDataInfo_A21213Value
		{
			get
			{
				short num = (short)1656815616;
				short num2 = num;
				num = (short)104278390;
				short num3 = num;
				num = (short)1126050166;
				switch (num3 == num)
				{
				}
				num = (short)625606656;
				if (num != 0)
				{
				}
				num = (short)1866268673;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Value;
			}
			set
			{
				short num = (short)1269956608;
				short num2 = num;
				num = (short)241121519;
				short num3 = num;
				num = (short)1431255279;
				switch (num3 == num)
				{
				}
				num = (short)153878529;
				if (num != 0)
				{
				}
				num = (short)82509824;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Value = value;
				this.voiceFileDataInfo_A21213.SetUITimer();
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0005C45C File Offset: 0x0005A65C
		public global::AcpBusinessLayer.AcpVoiceFileField VoiceFileDataInfo_A21213
		{
			get
			{
				short num = (short)901316608;
				short num2 = num;
				num = (short)1435759777;
				short num3 = num;
				num = (short)1390081185;
				switch (num3 == num)
				{
				}
				num = (short)1103233025;
				if (num != 0)
				{
				}
				num = (short)1339162624;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0005C50C File Offset: 0x0005A70C
		internal string VoiceFileDataInfo_A21213_UILabel
		{
			get
			{
				short num = (short)1790509056;
				short num2 = num;
				num = (short)597473277;
				short num3 = num;
				num = (short)1259190269;
				switch (num3 == num)
				{
				}
				num = (short)1679228929;
				if (num != 0)
				{
				}
				num = (short)1808793600;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.UIName;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0005C674 File Offset: 0x0005A874
		public bool VoiceFileDataInfo_A21213_Applicable
		{
			get
			{
				short num = (short)1649410048;
				short num2 = num;
				num = (short)1576808152;
				short num3 = num;
				num = (short)238628568;
				switch (num3 == num)
				{
				}
				num = (short)2099970048;
				if (num != 0)
				{
				}
				num = (short)510263297;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Applicable;
			}
			set
			{
				short num = (short)436994048;
				short num2 = num;
				num = (short)1797742759;
				short num3 = num;
				num = (short)486695079;
				switch (num3 == num)
				{
				}
				num = (short)90439681;
				if (num != 0)
				{
				}
				num = (short)787087360;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Applicable = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0005C728 File Offset: 0x0005A928
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x0005C7DC File Offset: 0x0005A9DC
		public bool VoiceFileDataInfo_A21213_Editable
		{
			get
			{
				short num = (short)1220411392;
				short num2 = num;
				num = (short)1872882230;
				short num3 = num;
				num = (short)58255926;
				switch (num3 == num)
				{
				}
				num = (short)1214906369;
				if (num != 0)
				{
				}
				num = (short)1194852352;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Editable;
			}
			set
			{
				short num = (short)562757632;
				short num2 = num;
				num = (short)1980234480;
				short num3 = num;
				num = (short)784661232;
				switch (num3 == num)
				{
				}
				num = (short)690880513;
				if (num != 0)
				{
				}
				num = (short)642908160;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Editable = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0005C890 File Offset: 0x0005AA90
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0005C948 File Offset: 0x0005AB48
		public bool VoiceFileDataInfo_A21213_Visible
		{
			get
			{
				short num = (short)1397424128;
				short num2 = num;
				num = (short)1273344608;
				short num3 = num;
				num = (short)790999648;
				switch (num3 == num)
				{
				}
				num = (short)1158152193;
				if (num != 0)
				{
				}
				num = (short)319029248;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Visible;
			}
			set
			{
				short num = (short)1265106944;
				short num2 = num;
				num = (short)1578338256;
				short num3 = num;
				num = (short)1270515664;
				switch (num3 == num)
				{
				}
				num = (short)1129840640;
				if (num != 0)
				{
				}
				num = (short)1985544193;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Visible = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0005C9FC File Offset: 0x0005ABFC
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x0005CAB4 File Offset: 0x0005ACB4
		internal bool VoiceFileDataInfo_A21213_HiddenStatic
		{
			get
			{
				short num = (short)902103040;
				short num2 = num;
				num = (short)2079321496;
				short num3 = num;
				num = (short)147647896;
				switch (num3 == num)
				{
				}
				num = (short)104529921;
				if (num != 0)
				{
				}
				num = (short)191496192;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.HiddenStatic;
			}
			set
			{
				short num = (short)1556283392;
				short num2 = num;
				num = (short)1635761618;
				short num3 = num;
				num = (short)1592442322;
				switch (num3 == num)
				{
				}
				num = (short)878641152;
				if (num != 0)
				{
				}
				num = (short)1087635457;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.HiddenStatic = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0005CB6C File Offset: 0x0005AD6C
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x0005CC1C File Offset: 0x0005AE1C
		public bool VoiceFileDataInfo_A21213_Valid
		{
			get
			{
				short num = (short)45023232;
				short num2 = num;
				num = (short)512557057;
				if (num != 0)
				{
				}
				num = (short)225410202;
				short num3 = num;
				num = (short)765164698;
				switch (num3 == num)
				{
				}
				num = (short)1358102528;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213.Valid;
			}
			set
			{
				short num = (short)561381376;
				short num2 = num;
				num = (short)451565644;
				short num3 = num;
				num = (short)1153062988;
				switch (num3 == num)
				{
				}
				num = (short)1262485505;
				if (num != 0)
				{
				}
				num = (short)1867186176;
				if (num != 0)
				{
				}
				this.voiceFileDataInfo_A21213.Valid = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0005CCD0 File Offset: 0x0005AED0
		public bool VoiceFileDataInfo_A21213_HasDiffs
		{
			get
			{
				short num = (short)1499725824;
				short num2 = num;
				num = (short)287723395;
				short num3 = num;
				num = (short)1430409091;
				switch (num3 == num)
				{
				}
				num = (short)1173684225;
				if (num != 0)
				{
				}
				num = (short)1554448384;
				if (num != 0)
				{
				}
				return this.voiceFileDataInfo_A21213._HasDiffs;
			}
		}

		// Token: 0x04000274 RID: 628
		private global::AcpBusinessLayer.AcpKeyField voiceFileName_A21220;

		// Token: 0x04000275 RID: 629
		private global::AcpBusinessLayer.AcpField<uint> voiceAnnouncementFileHashcode_A24563;

		// Token: 0x04000276 RID: 630
		private global::AcpBusinessLayer.AcpListField voiceAnnouncementEncodeType_A22264;

		// Token: 0x04000277 RID: 631
		private global::AcpBusinessLayer.AcpVoiceFileField voiceFileDataInfo_A21213;
	}
}
