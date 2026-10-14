using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005E4 RID: 1508
	[global::System.Serializable]
	public class TalkgroupList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CFB0 RID: 53168 RVA: 0x00C14574 File Offset: 0x00C12774
		public TalkgroupList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x00C145B4 File Offset: 0x00C127B4
		protected TalkgroupList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x00C145CC File Offset: 0x00C127CC
		public override void Init()
		{
			int a_ = 0;
			short num = (short)392871575;
			short num2 = num;
			num = (short)1159511703;
			switch (num2 == num)
			{
			}
			num = (short)1904607232;
			short num3 = num;
			num = (short)494338048;
			if (num != 0)
			{
			}
			num = (short)1239810049;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闀ꋂ꧄곆껈맊ꋌ뫎ꇐ駔뻖꫘꿚", a_);
			base.Id = 10152;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUPLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x00C146B4 File Offset: 0x00C128B4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)665826441;
			short num2 = num;
			num = (short)862237833;
			switch (num2 == num)
			{
			}
			num = (short)832569344;
			short num3 = num;
			num = (short)1477902336;
			if (num != 0)
			{
			}
			num = (short)1234305025;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳇ꯉꃋꗍ럏ꃑ믓ꏕ꣗龎郛럝鏟雡", a_);
			base.Id = 10152;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUPLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x00C14794 File Offset: 0x00C12994
		public override void PopulateReferences()
		{
			short num = (short)133279219;
			short num2 = num;
			num = (short)186822131;
			switch (num2 == num)
			{
			}
			num = (short)189071360;
			short num3 = num;
			num = (short)1994391553;
			if (num != 0)
			{
			}
			num = (short)900595712;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x00C1483C File Offset: 0x00C12A3C
		public override void DropReferences()
		{
			short num = (short)2059182579;
			short num2 = num;
			num = (short)812556787;
			switch (num2 == num)
			{
			}
			num = (short)2063138816;
			short num3 = num;
			num = (short)680198145;
			if (num != 0)
			{
			}
			num = (short)1640628224;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x00C148E4 File Offset: 0x00C12AE4
		public override void SetConstraints()
		{
			short num = (short)1711180714;
			short num2 = num;
			num = (short)1662553002;
			switch (num2 == num)
			{
			}
			num = (short)1478492160;
			short num3 = num;
			num = (short)1550909441;
			if (num != 0)
			{
			}
			num = (short)86900736;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x00C1498C File Offset: 0x00C12B8C
		public override void SetupDependencies()
		{
			short num = (short)319332526;
			short num2 = num;
			num = (short)1211211950;
			switch (num2 == num)
			{
			}
			num = (short)1684537344;
			short num3 = num;
			num = (short)776011776;
			if (num != 0)
			{
			}
			num = (short)1972240385;
			if (num != 0)
			{
			}
		}

		// Token: 0x17006855 RID: 26709
		// (get) Token: 0x0600CFB8 RID: 53176 RVA: 0x00C14A38 File Offset: 0x00C12C38
		public bool HasDiffs
		{
			get
			{
				short num = (short)2140092742;
				short num2 = num;
				num = (short)1136802118;
				switch (num2 == num)
				{
				}
				num = (short)101580800;
				short num3 = num;
				num = (short)1301676032;
				if (num != 0)
				{
				}
				num = (short)376897537;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x00C14AE8 File Offset: 0x00C12CE8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)86704130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)763953152;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)747629596;
					short num3 = num2;
					num2 = (short)79293468;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)57540608;
						if (num2 != 0)
						{
						}
						num2 = (short)151912452;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)2010578945;
					if (num2 != 0)
					{
					}
					num2 = (short)1402208257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)1010434048;
			short num4 = num2;
			result = null;
			num2 = (short)719519747;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040065AC RID: 26028
		private global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset innerRecset;
	}
}
