using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using EntityModel.GenericModel;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000B5 RID: 181
	public class ViewCacheNotifier
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x0005D024 File Offset: 0x0005B224
		private ViewCacheNotifier()
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0005D038 File Offset: 0x0005B238
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier Instance
		{
			get
			{
				short num = (short)617873408;
				short num2 = num;
				num = (short)584060960;
				short num3 = num;
				num = (short)330960928;
				switch (num3 == num)
				{
				}
				num = (short)2093088769;
				if (num != 0)
				{
				}
				num = (short)306577408;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0005D0E4 File Offset: 0x0005B2E4
		public void NotifyViewCacheAddItems<T>(global::System.Collections.Generic.IList<T> items) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
				switch (num)
				{
				case 0:
					if (list != null)
					{
						num2 = (short)941883394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BF;
				case 1:
				{
					num2 = (short)556466176;
					short num3 = num2;
					try
					{
						num2 = (short)6619136;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_8D;
								}
								continue;
							case 1:
								goto IL_107;
							case 3:
								num2 = (short)1295319041;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1065156611;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								enumerator.Current.ItemChanged<T>(global::System.Data.Linq.ChangeAction.Insert, items.ToList<T>(), null, global::System.Array.Empty<object>());
								num2 = (short)481099778;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_8F:
							num2 = (short)531103748;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_8D:
							goto IL_8F;
						}
						IL_107:
						goto IL_1BF;
					}
					finally
					{
						num2 = (short)1229651968;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_13C;
								}
								continue;
							case 1:
								goto IL_170;
							case 2:
								enumerator.Dispose();
								num2 = (short)1293877249;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_13C:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1331757058;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_170:;
					}
					goto IL_173;
				}
				case 2:
					IL_50:
					goto IL_173;
				}
				goto IL_1C;
				IL_173:
				enumerator = list.GetEnumerator();
				num2 = (short)929234945;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BF:
				num2 = (short)1277820929;
				if (num2 != 0)
				{
				}
				num2 = (short)1356497915;
				short num4 = num2;
				num2 = (short)1517061115;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_50;
				default:
					goto IL_21B;
				}
			}
			IL_21B:
			num2 = (short)479264768;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			list = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
			num2 = (short)623443968;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0005D334 File Offset: 0x0005B534
		public bool CheckViewCacheListsTypeMatch(global::System.Type type)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a a;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (list != null)
					{
						goto IL_4A;
					}
					return false;
				case 1:
				{
					if (!(a.a == null))
					{
						goto IL_144;
					}
					num2 = (short)1188757504;
					short num3 = num2;
					num2 = (short)823839802;
					short num4 = num2;
					num2 = (short)1182977082;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A;
					default:
						num2 = (short)628883456;
						if (num2 != 0)
						{
						}
						num2 = (short)2047016962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_13F;
				case 3:
					num2 = (short)2052718593;
					if (num2 != 0)
					{
					}
					num2 = (short)1388969985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_4A:
				num2 = (short)169672707;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_13F:
			return false;
			IL_144:
			return list.Any(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache, bool>(a.b));
			IL_20:
			a = new global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
			a.a = type;
			list = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
			num2 = (short)333774848;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0005D498 File Offset: 0x0005B698
		public void NotifyViewCacheUpdateItems<T>(global::System.Collections.Generic.IList<T> items) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
				switch (num)
				{
				case 0:
					if (list != null)
					{
						num2 = (short)1668939778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					try
					{
						num2 = (short)1862991872;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_E2;
								}
								continue;
							case 1:
								goto IL_1B1;
							case 3:
								goto IL_162;
							case 4:
							{
								num2 = (short)256873523;
								short num3 = num2;
								num2 = (short)782275635;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_162;
								default:
									num2 = (short)1236598784;
									if (num2 != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num2 = (short)1268318211;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									enumerator.Current.ItemChanged<T>(global::System.Data.Linq.ChangeAction.Update, items.ToList<T>(), null, global::System.Array.Empty<object>());
									num2 = (short)564789250;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							}
							IL_E4:
							num2 = (short)291241988;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_E2:
							goto IL_E4;
							IL_162:
							num2 = (short)1416167425;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1B1:
						return;
					}
					finally
					{
						num2 = (short)745340929;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1725562882;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1E7;
								}
								continue;
							case 2:
								goto IL_21D;
							}
							IL_1E7:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)591593472;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_21D:;
					}
					goto IL_220;
				case 2:
					goto IL_220;
				}
				goto IL_1C;
				IL_220:
				enumerator = list.GetEnumerator();
				num2 = (short)176816129;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			list = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
			num2 = (short)1648427009;
			if (num2 != 0)
			{
			}
			num2 = (short)52232192;
			short num4 = num2;
			num2 = (short)1462697984;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0005D704 File Offset: 0x0005B904
		public void NotifyViewCacheReplaceItems<T>(global::System.Collections.Generic.Dictionary<global::System.Guid, T> items) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
				switch (num)
				{
				case 0:
					num2 = (short)1746468865;
					if (num2 != 0)
					{
					}
					goto IL_229;
				case 1:
				{
					num2 = (short)1018101760;
					short num3 = num2;
					if (list != null)
					{
						num2 = (short)1254359040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					try
					{
						num2 = (short)404881411;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)1941713346;
								short num4 = num2;
								num2 = (short)1278620098;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_160;
								default:
									num2 = (short)1238761472;
									if (num2 != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num2 = (short)1649475585;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									enumerator.Current.ItemChanged<T>(global::System.Data.Linq.ChangeAction.Update, items.Values.ToList<T>(), items.Keys.ToList<global::System.Guid>(), global::System.Array.Empty<object>());
									num2 = (short)566296580;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 1:
								goto IL_160;
							case 2:
								goto IL_1BD;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_DF;
								}
								continue;
							}
							IL_E1:
							num2 = (short)853934080;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_DF:
							goto IL_E1;
							IL_160:
							num2 = (short)444923906;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1BD:
						return;
					}
					finally
					{
						num2 = (short)1810628609;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1741357058;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1F2;
								}
								continue;
							case 2:
								goto IL_226;
							}
							IL_1F2:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)683343872;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_226:;
					}
					goto IL_229;
				}
				goto IL_1C;
				IL_229:
				enumerator = list.GetEnumerator();
				num2 = (short)1885667330;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			list = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
			num2 = (short)870580225;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0005D97C File Offset: 0x0005BB7C
		public void NotifyViewCacheDeleteItems<T>(global::System.Collections.Generic.IList<global::System.Guid> idList) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)1016397825;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			int num2;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
			for (;;)
			{
				IL_30:
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_21D;
				case 1:
					if (list != null)
					{
						num = (short)1995243520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					try
					{
						num = (short)1230831619;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)462514045;
								short num3 = num;
								num = (short)670984061;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_162;
								default:
									num = (short)184090624;
									if (num != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num = (short)1676869633;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.ItemChanged<T>(global::System.Data.Linq.ChangeAction.Delete, null, idList.ToList<global::System.Guid>(), global::System.Array.Empty<object>());
									num = (short)12582916;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_162;
							case 2:
								goto IL_1B0;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_DF;
								}
								continue;
							}
							IL_E1:
							num = (short)56164352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_DF:
							goto IL_E1;
							IL_162:
							num = (short)660733954;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1B0:
						return;
					}
					finally
					{
						num = (short)1633353729;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)393084930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1E6;
								}
								continue;
							case 2:
								goto IL_21A;
							}
							IL_1E6:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2010316800;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_21A:;
					}
					goto IL_21D;
				}
				goto IL_42;
				IL_21D:
				enumerator = list.GetEnumerator();
				num = (short)1575354370;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_42:
			list = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
			num = (short)1698889728;
			short num4 = num;
			num = (short)410189825;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0005DBE8 File Offset: 0x0005BDE8
		public void CFSNotifyViewCacheLicenseChanged(global::EntityModel.GenericModel.CFSUpdateResult cfsUpdatedResult, bool isNeedRefreshRadio = false)
		{
			short num = (short)1791754240;
			switch (num)
			{
			default:
			{
				num = (short)2015887370;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> list6;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)799866883;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1588461569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> changedItem;
									enumerator.Current.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(global::System.Data.Linq.ChangeAction.Insert, changedItem, null, new object[]
									{
										cfsUpdatedResult.RadioSummary.GroupUuid
									});
									num = (short)238223364;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)893452290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_325;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_294;
									}
									continue;
								}
								IL_296:
								num = (short)1221263360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_294:
								goto IL_296;
							}
							IL_325:;
						}
						finally
						{
							num = (short)1244135425;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)57671682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_359;
									}
									continue;
								case 2:
									goto IL_38F;
								}
								IL_359:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1735458816;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_38F:;
						}
						goto IL_392;
					case 1:
						this.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
						{
							cfsUpdatedResult.RadioSummary.ToUiModel(true)
						});
						num = (short)1833828354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> changedItem = cfsUpdatedResult.RadioFeatureObjs.CreatedList.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.a)).Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
						num = (short)1341521953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1161822211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1230766088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (cfsUpdatedResult.RadioFeatureObjs.UpdatedList != null)
						{
							num = (short)1531641861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_93A;
					case 7:
						num = (short)828833805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (cfsUpdatedResult.RadioFeatureObjs.UpdatedList.Count > 0)
						{
							num = (short)1658060820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_93A;
					case 9:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> changedItem2 = cfsUpdatedResult.RadioFeatureObjs.UpdatedList.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.b)).Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list2 = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
						num = (short)2013790235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					case 11:
						if (cfsUpdatedResult.RadioFeatureObjs.RemovedList.Count > 0)
						{
							num = (short)1213071367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C55;
					case 12:
						try
						{
							num = (short)1736900610;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> list3;
									enumerator.Current.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(global::System.Data.Linq.ChangeAction.Delete, list3, list3.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.d)).ToList<global::System.Guid>(), new object[]
									{
										cfsUpdatedResult.RadioSummary.GroupUuid
									});
									num = (short)776470528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B0D;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1081278469;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1270349825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_BE7;
								case 5:
									num = (short)1082916868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B39:
								num = (short)1862008835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B0D:
								goto IL_B39;
							}
							IL_BE7:;
						}
						finally
						{
							num = (short)2047934464;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C1B;
									}
									continue;
								case 1:
									goto IL_C52;
								case 2:
									enumerator.Dispose();
									num = (short)1881210881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C1B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)354811906;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C52:;
						}
						goto IL_C55;
					case 13:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> list3 = cfsUpdatedResult.RadioFeatureObjs.RemovedList.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.c)).Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.<>c.<>9.c)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list4 = global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a();
						num = (short)2136932353;
						if (num != 0)
						{
						}
						num = (short)2046296094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list4;
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator = list4.GetEnumerator();
						num = (short)206503948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						try
						{
							num = (short)1121124353;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7E9;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1923481604;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> changedItem2;
									enumerator.Current.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(global::System.Data.Linq.ChangeAction.Update, changedItem2, null, new object[]
									{
										cfsUpdatedResult.RadioSummary.GroupUuid
									});
									num = (short)137953280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_87B;
								case 4:
									num = (short)289931267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7EB:
								num = (short)1179320322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7E9:
								goto IL_7EB;
							}
							IL_87B:;
						}
						finally
						{
							num = (short)176095232;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8B2;
									}
									continue;
								case 1:
									goto IL_937;
								case 2:
								{
									num = (short)6746207;
									short num3 = num;
									num = (short)226095199;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_937;
									default:
										num = (short)702283776;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)2106130433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_8B2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)804126722;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_937:;
						}
						goto IL_93A;
					case 16:
						if (cfsUpdatedResult.RadioFeatureObjs.UpdatedList.Count > 0)
						{
							num = (short)1182662681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_93A;
					case 17:
					{
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list2;
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator = list2.GetEnumerator();
						num = (short)1509556239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> list5;
						try
						{
							num = (short)1699151879;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary radioFeatureSummary;
								switch (num2)
								{
								case 0:
									num = (short)1671561218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_53F;
								case 2:
									if (!radioFeatureSummary.IsVisible)
									{
										num = (short)1395916801;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									list5.Add(radioFeatureSummary);
									num = (short)2043936776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)874577925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									radioFeatureSummary = enumerator2.Current;
									num = (short)1889140745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)784072710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_5C6;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_4A9;
									}
									continue;
								case 9:
									if (radioFeatureSummary.FeatureStatus != 64)
									{
										num = (short)171311104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_53F;
								}
								IL_502:
								num = (short)45875203;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A9:
								goto IL_502;
								IL_53F:
								list6.Add(radioFeatureSummary);
								num = (short)1640038404;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C6:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						cfsUpdatedResult.RadioFeatureObjs.UpdatedList = list5;
						num = (short)1953366037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> enumerator = list.GetEnumerator();
						num = (short)1548222464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> list5 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>();
						list6 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>.Enumerator enumerator2 = cfsUpdatedResult.RadioFeatureObjs.UpdatedList.GetEnumerator();
						num = (short)1787166738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (cfsUpdatedResult.RadioFeatureObjs.RemovedList == null)
						{
							num = (short)273547286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64D;
					case 22:
						cfsUpdatedResult.RadioFeatureObjs.RemovedList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>();
						num = (short)2009989143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_64D;
					case 24:
						num = (short)504168459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)783220745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (cfsUpdatedResult.RadioFeatureObjs.CreatedList != null)
						{
							num = (short)53805087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_392;
					case 27:
					{
						num = (short)1028653056;
						short num4 = num;
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list2;
						if (list2 != null)
						{
							num = (short)726401041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_93A;
					}
					case 28:
						if (isNeedRefreshRadio)
						{
							num = (short)277151745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						if (cfsUpdatedResult.RadioFeatureObjs.CreatedList.Count > 0)
						{
							num = (short)476512260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_392;
					case 30:
					{
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list4;
						if (list4 != null)
						{
							num = (short)1016791054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C55;
					}
					case 31:
						num = (short)120193053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						return;
					case 33:
					{
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
						if (list != null)
						{
							num = (short)1077477395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_392;
					}
					case 34:
						if (cfsUpdatedResult.RadioFeatureObjs.RemovedList != null)
						{
							num = (short)232325144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C55;
					}
					IL_D3:
					if (cfsUpdatedResult == null)
					{
						num = (short)1395392544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)140705818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_392:
					num = (short)434438150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64D:
					cfsUpdatedResult.RadioFeatureObjs.RemovedList.AddRange(list6);
					num = (short)1395654672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_93A:
					num = (short)1748697122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C55:
					num = (short)575602716;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0005E91C File Offset: 0x0005CB1C
		private static global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> a()
		{
			short num = (short)1267007488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::System.ComponentModel.ICollectionView collectionView;
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
						if (viewCache != null)
						{
							num = (short)1836056581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					}
					case 1:
						goto IL_22E;
					case 2:
						if (collectionView != null)
						{
							num = (short)973930500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache2;
						list.Add(viewCache2);
						num = (short)416088065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = collectionView.SourceCollection as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
						num = (short)1936326656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
						list.Add(viewCache);
						num = (short)667287560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache2;
						if (viewCache2 != null)
						{
							num = (short)1980497923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					case 7:
					{
						global::System.ComponentModel.ICollectionView collectionView2;
						if (collectionView2 != null)
						{
							num = (short)960036873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					case 8:
						goto IL_24F;
					case 9:
					{
						global::System.ComponentModel.ICollectionView collectionView2;
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache2 = collectionView2.SourceCollection as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
						num = (short)1165950982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_56;
				}
				IL_22E:
				return list;
				IL_24F:
				goto IL_184;
				IL_56:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache>();
				collectionView = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext as global::System.ComponentModel.ICollectionView);
				num = (short)469695517;
				short num3 = num;
				num = (short)2146040861;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_184:
					global::System.ComponentModel.ICollectionView collectionView2 = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.CachedDataContext as global::System.ComponentModel.ICollectionView;
					num = (short)628359175;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
				{
					num = (short)1330970625;
					if (num != 0)
					{
					}
					num = (short)1368784896;
					if (num != 0)
					{
					}
					num = (short)701956096;
					short num4 = num;
					num = (short)1174274050;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0005EB80 File Offset: 0x0005CD80
		// Note: this type is marked as 'beforefieldinit'.
		static ViewCacheNotifier()
		{
			short num = (short)1884157789;
			short num2 = num;
			num = (short)1858139997;
			switch (num2 == num)
			{
			}
			num = (short)1483603968;
			if (num != 0)
			{
			}
			num = (short)985137152;
			short num3 = num;
			num = (short)1755381761;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier();
		}

		// Token: 0x040000E6 RID: 230
		private static readonly global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier a;

		// Token: 0x020000B6 RID: 182
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000447 RID: 1095 RVA: 0x0005EC4C File Offset: 0x0005CE4C
			internal bool b(global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache A_0)
			{
				short num = (short)104640257;
				short num2 = num;
				num = (short)1977003777;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2032336897;
					if (num != 0)
					{
					}
					num = (short)659554304;
					if (num != 0)
					{
					}
					if (A_0 != null)
					{
						num = (short)1160970240;
						short num3 = num;
						return A_0.IsTypeMatchViewCache(this.a);
					}
					break;
				}
				return false;
			}

			// Token: 0x040000E7 RID: 231
			public global::System.Type a;
		}
	}
}
