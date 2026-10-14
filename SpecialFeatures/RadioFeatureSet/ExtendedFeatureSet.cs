using System;
using System.Collections.Generic;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200006B RID: 107
	public sealed class ExtendedFeatureSet : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x06000909 RID: 2313 RVA: 0x00002A2D File Offset: 0x00000C2D
		internal ExtendedFeatureSet(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.a = new global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerRecset();
			base.EmbeddedRecset = this.a;
			this.a.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000A348C File Offset: 0x000A168C
		public override void Init()
		{
			int a_ = 16;
			short num = (short)753130211;
			short num2 = num;
			num = (short)1674762979;
			switch (num2 == num)
			{
			}
			num = (short)110690305;
			if (num != 0)
			{
			}
			num = (short)1779892224;
			if (num != 0)
			{
			}
			num = (short)525795328;
			short num3 = num;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횒ﲘ列爵얠莢슦좨\udfaa\ud8ac\uddae풰鎲튶춸", a_);
			base.Id = 33;
			base.UIName = global::CommonResources.AppResources.Extended_Feature_Set;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x000A3564 File Offset: 0x000A1764
		public bool IsVisible_EmbeddedRecset
		{
			get
			{
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FeatureNode> enumerator = base.EmbeddedRecset.GetEnumerator();
				short num;
				bool result;
				try
				{
					num = (short)1939144704;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_59;
							}
							continue;
						case 1:
							goto IL_179;
						case 2:
							result = true;
							num = (short)247398403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_11B;
						case 4:
						{
							global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner extendedFeatureSetInner;
							if (extendedFeatureSetInner.ExtendedFeatureSetInnerSection != null)
							{
								num = (short)1662124039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner extendedFeatureSetInner;
							if (extendedFeatureSetInner.ExtendedFeatureSetInnerSection.ExtendedFeature_Visible)
							{
								num = (short)2142371842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1570045960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)630849537;
							if (num != 0)
							{
							}
							global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner extendedFeatureSetInner = (global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner)enumerator.Current;
							num = (short)742653956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)778240005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)232980481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5B:
						num = (short)1261305862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_59:
						goto IL_5B;
					}
					IL_11B:
					goto IL_232;
					IL_179:
					return false;
				}
				finally
				{
					for (;;)
					{
						IL_17E:
						num = (short)2094006274;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_22F;
							case 1:
								enumerator.Dispose();
								num = (short)1019281408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1AE;
								}
								continue;
							}
							IL_1AE:
							num = (short)412245867;
							short num3 = num;
							num = (short)609312619;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17E;
							default:
								num = (short)1055916032;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_231;
								}
								num = (short)1175257089;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
					}
					IL_22F:
					IL_231:;
				}
				IL_232:
				num = (short)1754923008;
				short num4 = num;
				return result;
			}
		}

		// Token: 0x04000395 RID: 917
		private global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerRecset a;
	}
}
