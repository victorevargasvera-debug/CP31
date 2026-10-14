using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D0 RID: 1488
	[global::System.Serializable]
	public class ConventionalAliasListsRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600CE64 RID: 52836 RVA: 0x00C01AAC File Offset: 0x00BFFCAC
		public ConventionalAliasListsRecset()
		{
			int a_ = 8;
			base..ctor(global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ많듐뷒ꇔ뻖뛘뗚볜돞쇠ꋢ觤軦裨飪췬ꏮ飰胲致蓶", a_));
			this.SetValues();
		}

		// Token: 0x0600CE65 RID: 52837 RVA: 0x00C01ADC File Offset: 0x00BFFCDC
		public ConventionalAliasListsRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x0600CE66 RID: 52838 RVA: 0x00C01B08 File Offset: 0x00BFFD08
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1425473536;
			short num2 = num;
			num = (short)1102183409;
			short num3 = num;
			num = (short)1860172785;
			switch (num3 == num)
			{
			}
			num = (short)825950209;
			if (num != 0)
			{
			}
			num = (short)1918435328;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.ConventionalAliasLists(this);
		}

		// Token: 0x0600CE67 RID: 52839 RVA: 0x00C01BB8 File Offset: 0x00BFFDB8
		internal void SetValues()
		{
			int a_ = 4;
			short num = (short)2127101952;
			short num2 = num;
			num = (short)1511709846;
			short num3 = num;
			num = (short)944692374;
			switch (num3 == num)
			{
			}
			num = (short)876085248;
			if (num != 0)
			{
			}
			num = (short)2090795009;
			if (num != 0)
			{
			}
			base.Id = 2007;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮닰鳲鯴臶鳸闺觼雾渀洂搄欆⤈䠊戌愎眐稒爔或欘稚検瘞丠䴢礤搦䘨䔪嬬䨮弰䜲尴堶圸娺儼Ἶ@⽂ⱄ♆㩈歊Ō♎≐❒♔ୖᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮばὲᱴᙶ੸㝺ᑼ౾ꮄﾆ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALALIASLISTS;
			base.DataTransferOrder = 32;
		}
	}
}
