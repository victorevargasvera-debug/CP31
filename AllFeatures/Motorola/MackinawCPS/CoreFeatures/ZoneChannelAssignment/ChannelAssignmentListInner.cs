using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x02000037 RID: 55
	[global::System.Serializable]
	public class ChannelAssignmentListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00007A68 File Offset: 0x00005C68
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection ChannelAssignmentListInnerSection
		{
			get
			{
				short num = (short)2031943680;
				short num2 = num;
				num = (short)1989216391;
				short num3 = num;
				num = (short)1906051207;
				switch (num3 == num)
				{
				}
				num = (short)653590529;
				if (num != 0)
				{
				}
				num = (short)1723727872;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection)base[10115];
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00007B20 File Offset: 0x00005D20
		public ChannelAssignmentListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("金볓럕뛗듙맛닝샟ꏡ韣闥臧跩苫菭闯鳱胳훵듷鏹迻諽", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTLIST;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00007B6C File Offset: 0x00005D6C
		protected ChannelAssignmentListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藅ꃇꯉꋋꃍ뗏뻑韕ꯗ꧙뗛망軟迡臣裥鳧쫩ꃫ蟭華蛱", a_);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public override string ReferenceKey
		{
			get
			{
				int a_ = 2;
				for (;;)
				{
					IL_09:
					short num = (short)274268160;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_3D;
							}
							continue;
						case 1:
							num = (short)1554513923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_16A;
						case 3:
						{
							if (this.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659 == null)
							{
								goto IL_16F;
							}
							num = (short)1173946368;
							short num3 = num;
							num = (short)1598215236;
							short num4 = num;
							num = (short)103994436;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)1320615937;
								if (num != 0)
								{
								}
								num = (short)1900085248;
								if (num != 0)
								{
								}
								num = (short)1014431746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_3D:
						if (this.ChannelAssignmentListInnerSection == null)
						{
							goto IL_16F;
						}
						num = (short)1967915009;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_16A:
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + this.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659.ToString();
				IL_16F:
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + base.FeatureName;
			}
		}
	}
}
