using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000049 RID: 73
	public abstract class PrepareScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00023014 File Offset: 0x00021214
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext Context
		{
			get
			{
				short num = (short)1627541906;
				short num2 = num;
				num = (short)1719685522;
				switch (num2 == num)
				{
				}
				num = (short)477954048;
				short num3 = num;
				num = (short)1037107201;
				if (num != 0)
				{
				}
				num = (short)786759680;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000230C4 File Offset: 0x000212C4
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)286523392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				global::System.Collections.ICollection collection;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
						switch (num2)
						{
						case 0:
							num = (short)1706622980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1433796609;
							if (num != 0)
							{
							}
							try
							{
								num = (short)183762948;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										result = false;
										num = (short)120717315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										if (!base.UIValidateService.CanCreateJob(radioBase.JobStatus))
										{
											num = (short)742457344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_205;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_147;
										}
										continue;
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1085538310;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
										num = (short)712245249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)670564354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1AF:
									num = (short)1846542341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_147:
									goto IL_1AF;
								}
								IL_205:
								return result;
							}
							finally
							{
								num = (short)1404567552;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_23C;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)664272898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_272;
									}
									IL_23C:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1259864065;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_272:;
							}
							goto IL_275;
						case 2:
							list = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
							if (((global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)list).Count == 0)
							{
								goto IL_275;
							}
							goto IL_2E3;
						case 3:
							if (collection != null)
							{
								num = (short)700186624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 4:
						{
							num = (short)497287168;
							short num3 = num;
							if (collection.Count == 0)
							{
								num = (short)355336197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1247413013;
							short num4 = num;
							num = (short)1871971093;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_51;
							default:
								num = (short)229376000;
								if (num != 0)
								{
								}
								num = (short)703856642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_2DE;
						}
						goto IL_46;
						IL_2E3:
						enumerator = ((global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)list).GetEnumerator();
						num = (short)1962082305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_275:
						result = false;
						goto IL_2E3;
					}
					return false;
					IL_2DE:
					return false;
				}
				IL_46:
				result = true;
				collection = (paras[0] as global::System.Collections.ICollection);
				IL_51:
				num = (short)126943235;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00023420 File Offset: 0x00021620
		public int GetAllRadiosCount()
		{
			short num = (short)1057834278;
			short num2 = num;
			num = (short)2054767910;
			switch (num2 == num)
			{
			}
			num = (short)1460731904;
			short num3 = num;
			num = (short)504299521;
			if (num != 0)
			{
			}
			num = (short)1079312384;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000234CC File Offset: 0x000216CC
		public int GetNewRadiosCount()
		{
			short num = (short)1403016983;
			short num2 = num;
			num = (short)610752279;
			switch (num2 == num)
			{
			}
			num = (short)1887961088;
			short num3 = num;
			num = (short)1681850369;
			if (num != 0)
			{
			}
			num = (short)1332871168;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0002357C File Offset: 0x0002177C
		public int GetNullConfigRadiosCount()
		{
			short num = (short)811292069;
			short num2 = num;
			num = (short)50222501;
			switch (num2 == num)
			{
			}
			num = (short)1630535680;
			short num3 = num;
			num = (short)1078722561;
			if (num != 0)
			{
			}
			num = (short)1632567296;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0002362C File Offset: 0x0002182C
		public int GetNullTemplateRadiosCount()
		{
			short num = (short)2116969778;
			short num2 = num;
			num = (short)1883530546;
			switch (num2 == num)
			{
			}
			num = (short)496041984;
			short num3 = num;
			num = (short)1164705792;
			if (num != 0)
			{
			}
			num = (short)978845697;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000236DC File Offset: 0x000218DC
		private bool a()
		{
			short num = (short)1671795611;
			short num2 = num;
			num = (short)335319963;
			switch (num2 == num)
			{
			}
			num = (short)48693248;
			short num3 = num;
			num = (short)1774452736;
			if (num != 0)
			{
			}
			num = (short)335544321;
			if (num != 0)
			{
			}
			return this.e;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0002378C File Offset: 0x0002198C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1130233857;
			if (num != 0)
			{
			}
			num = (short)1722417154;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DD;
				case 1:
				{
					num = (short)579246656;
					short num3 = num;
					num = (short)88119872;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						num = (short)1594490880;
						if (num != 0)
						{
						}
						num = (short)647102468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 3:
					goto IL_167;
				case 4:
					if (paras.Count<object>() <= 0)
					{
						num = (short)526188547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1345781760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5F;
				IL_65:
				num = (short)1295319041;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F:
				if (paras != null)
				{
					goto IL_65;
				}
				goto IL_FC;
			}
			IL_DD:
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
			{
				short num5 = (short)463533768;
				short num6 = num5;
				num5 = (short)1080686280;
				switch (num6 == num5)
				{
				}
				num5 = (short)532152320;
				short num7 = num5;
				num5 = (short)27721729;
				if (num5 != 0)
				{
				}
				num5 = (short)271187968;
				if (num5 != 0)
				{
				}
				return d.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
			}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			this.InitializeContext(radios);
			base.Interaction.ShowScheduleJobDialog(this.f);
			return null;
			IL_FC:
			num = (short)1722023936;
			short num4 = num;
			throw new global::System.ArgumentNullException();
			IL_167:
			goto IL_FC;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00023940 File Offset: 0x00021B40
		protected virtual void InitializeContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			short num = (short)1194917888;
			switch (num)
			{
			default:
			{
				this.f.ConnectionMethod = global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired;
				this.f.IsTypeReadEditable = true;
				global::System.TimeZoneInfo local = global::System.TimeZoneInfo.Local;
				global::System.Collections.Generic.List<global::System.TimeZoneInfo> list = new global::System.Collections.Generic.List<global::System.TimeZoneInfo>();
				global::System.Collections.Generic.IEnumerator<global::System.TimeZoneInfo> enumerator = global::System.TimeZoneInfo.GetSystemTimeZones().GetEnumerator();
				try
				{
					num = (short)179896323;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)276299782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.TimeZoneInfo timeZoneInfo = enumerator.Current;
							num = (short)1831600133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_144;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_91;
							}
							continue;
						case 4:
						{
							global::System.TimeZoneInfo timeZoneInfo;
							list.Add(timeZoneInfo);
							num = (short)1648427009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.TimeZoneInfo timeZoneInfo;
							if (timeZoneInfo != local)
							{
								num = (short)251527172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)293404674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CF:
						num = (short)1937571840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_91:
						goto IL_CF;
					}
					IL_144:;
				}
				finally
				{
					for (;;)
					{
						num = (short)376504321;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1B4;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_17D;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1387528192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_17D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1385496578;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1B6:
						num = (short)136642561;
						if (num != 0)
						{
						}
						num = (short)757365454;
						short num3 = num;
						num = (short)1973975758;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_212;
						}
						IL_1B4:
						goto IL_1B6;
					}
					IL_212:
					num = (short)1991770112;
					if (num != 0)
					{
					}
				}
				num = (short)1041104896;
				short num4 = num;
				this.f.TimeZoneInfos = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo>(list);
				global::System.TimeZoneInfo.ClearCachedData();
				this.f.SelectedTimeZoneInfo = global::System.TimeZoneInfo.Local;
				this.f.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(radios);
				this.GetRadioListStatus(radios);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType defaultScheduleJobType = this.GetDefaultScheduleJobType(radios);
				this.InitContextBasedOnDefaultJobType(defaultScheduleJobType);
				return;
			}
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00023BFC File Offset: 0x00021DFC
		protected virtual void InitContextBasedOnDefaultJobType(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType defaultType)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)1370488833;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.f.IsTypeWriteEditable = true;
					this.f.IsTypeReadGenerateConfigurationOrTemplateEditable = false;
					this.f.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
					this.f.TypeReadGenerateConfigurationOrTemplate = false;
					this.f.TypeReadGenerateConfigurationOrTemplateApplyToRadio = false;
					num = (short)1154154496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_11F;
				case 3:
				{
					if (defaultType != global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read)
					{
						num = (short)2061631492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1260038415;
					short num3 = num;
					num = (short)1596631311;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_191;
					default:
						num = (short)419102720;
						if (num != 0)
						{
						}
						num = (short)1299709954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_191;
				}
				goto IL_4A;
				IL_191:
				if (defaultType != global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write)
				{
					return;
				}
				num = (short)1753481217;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11F:
			this.f.IsTypeWriteEditable = false;
			this.f.IsTypeReadGenerateConfigurationOrTemplateEditable = true;
			this.f.TypeReadGenerateConfigurationOrTemplate = false;
			this.f.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
			this.f.TypeReadGenerateConfigurationOrTemplateApplyToRadio = false;
			return;
			IL_4A:
			this.f.Type = defaultType;
			this.Context.UIUserDefersAllowed = this.Context.DefaultUIUserDefersAllowed;
			this.Context.EnableImmediateDeployment = false;
			num = (short)5898240;
			short num4 = num;
			num = (short)1031995395;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00023DF8 File Offset: 0x00021FF8
		protected virtual global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType GetDefaultScheduleJobType(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			short num = (short)1193148420;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_123;
				case 1:
					if (this.d != this.a)
					{
						num = (short)114622465;
						if (num != 0)
						{
						}
						num = (short)89260032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read;
				case 2:
					if (this.e)
					{
						num = (short)710017029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write;
				case 3:
				{
					num = (short)2108751872;
					short num3 = num;
					num = (short)1738670082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read;
				case 6:
					num = (short)1083179009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_13A;
				}
				IL_45:
				if (this.c == this.a)
				{
					num = (short)265742506;
					short num4 = num;
					num = (short)1907615914;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13A;
					default:
						num = (short)1028194304;
						if (num != 0)
						{
						}
						num = (short)1429929990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				IL_123:
				num = (short)455933959;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13A:
				if (this.b == this.a)
				{
					break;
				}
				num = (short)1025048579;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00023FD8 File Offset: 0x000221D8
		protected virtual void GetRadioListStatus(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			short num = (short)350486528;
			switch (num)
			{
			default:
			{
				this.a = radios.Count;
				this.e = false;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = radios.GetEnumerator();
				try
				{
					num = (short)1644494852;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1F0;
						case 1:
							num = (short)654770176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							bool? isOutOfSync;
							bool flag;
							if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
							{
								num = (short)1362755589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)226689025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)890765318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_80;
							}
							continue;
						case 5:
							this.e = true;
							num = (short)186843143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							if (radioBase.RadioStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
							{
								this.b++;
							}
							if (radioBase.WorkingConfigurationUuid == null)
							{
								this.c++;
							}
							if (radioBase.WorkingTemplateUuid == null)
							{
								this.d++;
							}
							bool? isOutOfSync = radioBase.IsOutOfSync;
							bool flag = true;
							num = (short)1261174785;
							if (num != 0)
							{
							}
							num = (short)99418114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_199:
						num = (short)1155334147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_80:
						goto IL_199;
					}
					IL_1F0:;
				}
				finally
				{
					for (;;)
					{
						num = (short)1012334593;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_25F;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_228;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1043070976;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_228:
							if (enumerator == null)
							{
								break;
							}
							num = (short)865206274;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_261:
						num = (short)1256459000;
						short num3 = num;
						num = (short)1302858488;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_297;
						}
						IL_25F:
						goto IL_261;
					}
					IL_297:
					num = (short)44630016;
					if (num != 0)
					{
					}
				}
				num = (short)237305856;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x04000045 RID: 69
		private int a;

		// Token: 0x04000046 RID: 70
		private int b;

		// Token: 0x04000047 RID: 71
		private int c;

		// Token: 0x04000048 RID: 72
		private int d;

		// Token: 0x04000049 RID: 73
		private bool e;

		// Token: 0x0400004A RID: 74
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext f = new global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext();
	}
}
