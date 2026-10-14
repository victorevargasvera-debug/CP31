using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002CB RID: 715
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007706 RID: 30470 RVA: 0x006BA4C4 File Offset: 0x006B86C4
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x006BA504 File Offset: 0x006B8704
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x006BA51C File Offset: 0x006B871C
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1605042177;
			if (num != 0)
			{
			}
			num = (short)447540657;
			short num2 = num;
			num = (short)1080094129;
			switch (num2 == num)
			{
			}
			num = (short)1188954112;
			short num3 = num;
			num = (short)1679294464;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諌꫎뿐뛒꟔뛖뗘", a_);
			base.Id = 10747;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 123;
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x006BA5FC File Offset: 0x006B87FC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)327932576;
			short num2 = num;
			num = (short)1706613408;
			switch (num2 == num)
			{
			}
			num = (short)631177217;
			if (num != 0)
			{
			}
			num = (short)607780864;
			short num3 = num;
			num = (short)1040908288;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諌꫎뿐뛒꟔뛖뗘", a_);
			base.Id = 10747;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 123;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x006BA6E0 File Offset: 0x006B88E0
		public override void PopulateReferences()
		{
			short num = (short)1835852808;
			short num2 = num;
			num = (short)2046551048;
			switch (num2 == num)
			{
			}
			num = (short)55181312;
			if (num != 0)
			{
			}
			num = (short)1867710464;
			short num3 = num;
			num = (short)1117061121;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x006BA788 File Offset: 0x006B8988
		public override void DropReferences()
		{
			short num = (short)1833638734;
			short num2 = num;
			num = (short)487529294;
			switch (num2 == num)
			{
			}
			num = (short)735969280;
			if (num != 0)
			{
			}
			num = (short)76218368;
			short num3 = num;
			num = (short)1846214657;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x006BA830 File Offset: 0x006B8A30
		public override void SetConstraints()
		{
			short num = (short)246318443;
			short num2 = num;
			num = (short)1119192427;
			switch (num2 == num)
			{
			}
			num = (short)264437760;
			if (num != 0)
			{
			}
			num = (short)1486684160;
			short num3 = num;
			num = (short)1245446145;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x006BA8DC File Offset: 0x006B8ADC
		public override void SetupDependencies()
		{
			short num = (short)829418746;
			short num2 = num;
			num = (short)112585978;
			switch (num2 == num)
			{
			}
			num = (short)1825767425;
			if (num != 0)
			{
			}
			num = (short)26607616;
			short num3 = num;
			num = (short)593428480;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600770E RID: 30478 RVA: 0x006BA984 File Offset: 0x006B8B84
		public bool HasDiffs
		{
			get
			{
				short num = (short)1860453274;
				short num2 = num;
				num = (short)63194010;
				switch (num2 == num)
				{
				}
				num = (short)238747649;
				if (num != 0)
				{
				}
				num = (short)373817344;
				short num3 = num;
				num = (short)1436549120;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x006BAA34 File Offset: 0x006B8C34
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
					num2 = (short)649044000;
					short num3 = num2;
					num2 = (short)1139318816;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					default:
						num2 = (short)1902706688;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)164298754;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)154992644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1252851713;
					if (num2 != 0)
					{
					}
					num2 = (short)1827078147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					goto IL_B1;
				}
				goto IL_24;
				IL_B1:
				num2 = (short)288161792;
				short num4 = num2;
				num2 = (short)1932263424;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)27066369;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400317C RID: 12668
		private global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset innerRecset;
	}
}
