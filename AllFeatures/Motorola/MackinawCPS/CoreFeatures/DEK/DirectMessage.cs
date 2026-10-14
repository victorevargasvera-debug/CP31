using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000335 RID: 821
	[global::System.Serializable]
	public class DirectMessage : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007EF8 RID: 32504 RVA: 0x0074F158 File Offset: 0x0074D358
		public DirectMessage(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x0074F198 File Offset: 0x0074D398
		protected DirectMessage(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x0074F1B0 File Offset: 0x0074D3B0
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1888091376;
			short num2 = num;
			num = (short)1902968048;
			switch (num2 == num)
			{
			}
			num = (short)151650304;
			short num3 = num;
			num = (short)527499265;
			if (num != 0)
			{
			}
			num = (short)1737359360;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雑뷓ꓕ뷗맙꣛ﻝ귟蟡韣闥觧跩觫", a_);
			base.Id = 10229;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMESSAGE;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x0074F294 File Offset: 0x0074D494
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1467608434;
			short num2 = num;
			num = (short)524021106;
			switch (num2 == num)
			{
			}
			num = (short)474349568;
			short num3 = num;
			num = (short)641138689;
			if (num != 0)
			{
			}
			num = (short)2094333952;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍맏ꃑ뇓뗕곗龎釛믝鏟釡藣臥跧", a_);
			base.Id = 10229;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMESSAGE;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x0074F378 File Offset: 0x0074D578
		public override void PopulateReferences()
		{
			short num = (short)80559667;
			short num2 = num;
			num = (short)1927757363;
			switch (num2 == num)
			{
			}
			num = (short)337510400;
			short num3 = num;
			num = (short)377552896;
			if (num != 0)
			{
			}
			num = (short)1031471105;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x0074F420 File Offset: 0x0074D620
		public override void DropReferences()
		{
			short num = (short)484089755;
			short num2 = num;
			num = (short)77504411;
			switch (num2 == num)
			{
			}
			num = (short)2002518016;
			short num3 = num;
			num = (short)471072768;
			if (num != 0)
			{
			}
			num = (short)1330511873;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x0074F4C4 File Offset: 0x0074D6C4
		public override void SetConstraints()
		{
			short num = (short)1336643733;
			short num2 = num;
			num = (short)647467157;
			switch (num2 == num)
			{
			}
			num = (short)995033088;
			short num3 = num;
			num = (short)169738240;
			if (num != 0)
			{
			}
			num = (short)695599105;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x0074F56C File Offset: 0x0074D76C
		public override void SetupDependencies()
		{
			short num = (short)254279681;
			if (num != 0)
			{
			}
			num = (short)302513933;
			short num2 = num;
			num = (short)1721630477;
			switch (num2 == num)
			{
			default:
			{
				num = (short)995950592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)9830400;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x06007F00 RID: 32512 RVA: 0x0074F614 File Offset: 0x0074D814
		public bool HasDiffs
		{
			get
			{
				short num = (short)1330222499;
				short num2 = num;
				num = (short)812684707;
				switch (num2 == num)
				{
				}
				num = (short)816840704;
				short num3 = num;
				num = (short)195690497;
				if (num != 0)
				{
				}
				num = (short)88604672;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x0074F6C4 File Offset: 0x0074D8C4
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
					num2 = (short)1656619009;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)821297152;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_D9;
				case 3:
				{
					num2 = (short)340000768;
					short num3 = num2;
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)396558337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)1687382716;
					short num4 = num2;
					num2 = (short)1543793340;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num2 = (short)1325268992;
						if (num2 != 0)
						{
						}
						num2 = (short)1473249282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_D9:
				num2 = (short)93913091;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)938672132;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400399F RID: 14751
		private global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset innerRecset;
	}
}
