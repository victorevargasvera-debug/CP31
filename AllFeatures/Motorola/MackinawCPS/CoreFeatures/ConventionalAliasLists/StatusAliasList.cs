using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D8 RID: 1496
	[global::System.Serializable]
	public class StatusAliasList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CECA RID: 52938 RVA: 0x00C06580 File Offset: 0x00C04780
		public StatusAliasList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x00C065C0 File Offset: 0x00C047C0
		protected StatusAliasList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x00C065D8 File Offset: 0x00C047D8
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1641017529;
			short num2 = num;
			num = (short)1962143929;
			switch (num2 == num)
			{
			}
			num = (short)1235484673;
			if (num != 0)
			{
			}
			num = (short)1792999424;
			short num3 = num;
			num = (short)1850474496;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟓ꋕ맗껙꧛귝샟ꏡ裣迥觧駩쳫ꋭ駯臱胳", a_);
			base.Id = 10014;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIASLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x00C066BC File Offset: 0x00C048BC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)1595604992;
			short num2 = num;
			num = (short)2101521813;
			short num3 = num;
			num = (short)2067443093;
			switch (num3 == num)
			{
			}
			num = (short)463142913;
			if (num != 0)
			{
			}
			num = (short)1432223744;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韃닅꧇뻉맋뷍鏑룓뿕맗꧙ﳛ鋝觟釡郣", a_);
			base.Id = 10014;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIASLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x00C067A0 File Offset: 0x00C049A0
		public override void PopulateReferences()
		{
			short num = (short)403505152;
			short num2 = num;
			num = (short)1453698463;
			short num3 = num;
			num = (short)477343135;
			switch (num3 == num)
			{
			}
			num = (short)690618369;
			if (num != 0)
			{
			}
			num = (short)178061312;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x00C06848 File Offset: 0x00C04A48
		public override void DropReferences()
		{
			short num = (short)383778816;
			short num2 = num;
			num = (short)1359205546;
			short num3 = num;
			num = (short)105239722;
			switch (num3 == num)
			{
			}
			num = (short)1250689025;
			if (num != 0)
			{
			}
			num = (short)323485696;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x00C068F0 File Offset: 0x00C04AF0
		public override void SetConstraints()
		{
			short num = (short)1771831296;
			short num2 = num;
			num = (short)207683585;
			if (num != 0)
			{
			}
			num = (short)235633679;
			short num3 = num;
			num = (short)728071183;
			switch (num3 == num)
			{
			}
			num = (short)95354880;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CED1 RID: 52945 RVA: 0x00C06998 File Offset: 0x00C04B98
		public override void SetupDependencies()
		{
			short num = (short)571277312;
			short num2 = num;
			num = (short)1215627265;
			if (num != 0)
			{
			}
			num = (short)1769482785;
			short num3 = num;
			num = (short)2037525025;
			switch (num3 == num)
			{
			}
			num = (short)844169216;
			if (num != 0)
			{
			}
		}

		// Token: 0x170067FC RID: 26620
		// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x00C06A40 File Offset: 0x00C04C40
		public bool HasDiffs
		{
			get
			{
				short num = (short)663879680;
				short num2 = num;
				num = (short)1550843905;
				if (num != 0)
				{
				}
				num = (short)617221080;
				short num3 = num;
				num = (short)1289489368;
				switch (num3 == num)
				{
				}
				num = (short)1733623808;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CED3 RID: 52947 RVA: 0x00C06AF0 File Offset: 0x00C04CF0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)626196480;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)348258306;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					goto IL_AE;
				case 2:
					num = (short)1006239747;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)235857888;
					short num4 = num;
					num = (short)857925600;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)41680896;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1029832708;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1962475521;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
			}
			IL_AE:
			num = (short)203161601;
			if (num != 0)
			{
			}
			return result;
			IL_4D:
			result = null;
			num = (short)211681280;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x04006542 RID: 25922
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset innerRecset;
	}
}
