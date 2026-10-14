using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x02000032 RID: 50
	public static class SSAConstraints
	{
		// Token: 0x06000692 RID: 1682 RVA: 0x000619DC File Offset: 0x0005FBDC
		internal static void ConUpdateSSAConfigType(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)129695744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				bool flag;
				global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList41985 siteSelectableAlertList;
				global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset siteSelectableAlertTableInnerRecset;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (flag)
						{
							num = (short)1975952599;
							short num3 = num;
							num = (short)481010903;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_AA;
							case 1:
								break;
							default:
							{
								num = (short)1450377216;
								short num4 = num;
								break;
							}
							}
							num = (short)2075262976;
							if (num != 0)
							{
							}
							num = (short)1919287300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(siteSelectableAlertList.SiteSelectableAlertListConfigurationType_A42058, 0));
						num = (short)594149379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (siteSelectableAlertTableInnerRecset != null)
						{
							num = (short)750125058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						num = (short)977469445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						goto IL_155;
					case 5:
						if (siteSelectableAlertList != null)
						{
							num = (short)173801479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						try
						{
							num = (short)1464795138;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner siteSelectableAlertTableInner;
									if (siteSelectableAlertTableInner != null)
									{
										num = (short)1488060417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1562902532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_274;
									}
									continue;
								case 3:
									goto IL_28E;
								case 4:
								{
									global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner siteSelectableAlertTableInner;
									if (siteSelectableAlertTableInner.SiteSelectableAlertTableInnerSection.VASSASubscriberEncodable_A41992.Value)
									{
										num = (short)310378501;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									flag = true;
									num = (short)544735235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)2079195144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1414856710;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner siteSelectableAlertTableInner = enumerator.Current as global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner;
									num = (short)1447034880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_372;
								}
								IL_2D4:
								num = (short)1586495495;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_274:
								goto IL_2D4;
							}
							IL_28E:
							IL_372:
							goto IL_AA;
						}
						finally
						{
							num = (short)187760640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3AA;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)92602370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3E0;
								}
								IL_3AA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2138308609;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E0:;
						}
						return;
					case 7:
					{
						num = (short)1499856897;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = siteSelectableAlertTableInnerRecset.GetEnumerator();
						num = (short)1953038342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_50;
					IL_AA:
					num = (short)1248657408;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_155:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(siteSelectableAlertList.SiteSelectableAlertListConfigurationType_A42058, 1));
				return;
				IL_50:
				flag = false;
				siteSelectableAlertTableInnerRecset = (self.Parent.Parent as global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset);
				siteSelectableAlertList = (self.ParentRecset.ParentSection as global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList41985);
				num = (short)964886529;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}
	}
}
