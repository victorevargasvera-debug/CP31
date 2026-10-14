using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200004F RID: 79
	public abstract class ScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00025CAC File Offset: 0x00023EAC
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1448607744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)711983104;
				short num3 = num;
				num = (short)1765071875;
				short num4 = num;
				num = (short)2089802755;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1394212864;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 1:
						num = (short)148045825;
						if (num != 0)
						{
						}
						num = (short)1126694914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!paras.Any<object>())
						{
							num = (short)346095619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					case 3:
						goto IL_12F;
					}
					break;
				}
				IL_AB:
				if (paras == null)
				{
					break;
				}
				num = (short)1647443969;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F1:
			throw new global::System.ArgumentNullException();
			IL_12F:
			goto IL_F1;
			IL_131:
			return !(paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext).HasError();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00025DFC File Offset: 0x00023FFC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)90701824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				bool flag2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext warningContext;
				for (;;)
				{
					IL_28:
					bool flag;
					global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> warningList;
					switch (num2)
					{
					case 0:
						num = (short)1169162250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						flag = false;
						goto IL_21C;
					case 2:
						warningContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext();
						warningContext.ScheduleJobContext = context;
						warningContext.NormalRadios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(warningList.Value);
						warningContext.WarningRadios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>(warningList.Key);
						warningContext.SelectWarningRadios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>();
						global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
						{
							short num5 = (short)127664128;
							short num6 = num5;
							num5 = (short)1579414482;
							short num7 = num5;
							num5 = (short)766505938;
							switch (num7 == num5)
							{
							}
							num5 = (short)1029242880;
							if (num5 != 0)
							{
							}
							num5 = (short)1713700865;
							if (num5 != 0)
							{
							}
							bool flag3 = this.Interaction.ShowSelectWarningRadiostoScheduleJobDialog(warningContext);
							context.IsExecuted = !flag3;
						}), global::System.Array.Empty<object>()).Wait();
						flag2 = true;
						num = (short)422445059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1D7;
					case 4:
						if (warningList.Key.Count > 0)
						{
							num = (short)1958215680;
							short num3 = num;
							num = (short)1253965826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 5:
					{
						num = (short)2119912333;
						short num4 = num;
						num = (short)1267092365;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1798701057;
							if (num != 0)
							{
							}
							num = (short)31260672;
							if (num != 0)
							{
							}
							if (context.IsFirmwareRecoverJob)
							{
								num = (short)765919245;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)635895809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)2065563652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2AD;
					case 8:
						goto IL_217;
					case 9:
						if (paras != null)
						{
							num = (short)1346699264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					case 10:
						if (!paras.Any<object>())
						{
							num = (short)691666952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						context = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext);
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).CheckCompatibility();
						num = (short)1858928645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (warningList.Key != null)
						{
							num = (short)307298310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 12:
						flag = !context.IsSynchronizationRead;
						goto IL_21C;
					case 13:
						num = (short)1620246540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67;
					IL_21C:
					bool isFirmwareRecoveryBeforeSynchronizationRead = flag;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType = this.GetJobType(context);
					warningList = this.GetWarningList(context.Radios.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(), global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired, jobType, isFirmwareRecoveryBeforeSynchronizationRead);
					num = (short)603848715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_288:
					flag2 = this.ExecuteOperation(context);
					num = (short)1184104455;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_137:
				throw new global::System.ArgumentNullException();
				IL_1D7:
				goto IL_3B1;
				IL_217:
				goto IL_137;
				IL_2AD:
				IL_3B1:
				return flag2;
				IL_67:
				num = (short)586547209;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000261C0 File Offset: 0x000243C0
		protected global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> GetWarningList(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isFirmwareRecoveryBeforeSynchronizationRead)
		{
			short num = (short)175887802;
			short num2 = num;
			num = (short)1102239162;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1037631488;
				if (num != 0)
				{
				}
				num = (short)1348272129;
				if (num != 0)
				{
				}
				num = (short)456523776;
				short num3 = num;
				num = (short)2010251264;
				switch (num)
				{
				}
				break;
			}
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>();
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> result = new global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio>, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(list, list2);
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = radios.GetEnumerator();
			try
			{
				num = (short)457113603;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio warningRadio;
						if (this.GetWarningRadio(radioBase, type, warningRadio, transport, isFirmwareRecoveryBeforeSynchronizationRead))
						{
							num = (short)1002962946;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						list2.Add(radioBase);
						num = (short)643563526;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio warningRadio;
						list.Add(warningRadio);
						num = (short)1068171264;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_11A;
						}
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1203634181;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio warningRadio = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio(radioBase);
						num = (short)206766081;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1549598727;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_209;
					}
					IL_16B:
					num = (short)777125892;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_11A:
					goto IL_16B;
				}
				IL_209:;
			}
			finally
			{
				num = (short)1738014720;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_23D;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1770913794;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_272;
					}
					IL_23D:
					if (enumerator == null)
					{
						break;
					}
					num = (short)633602049;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_272:;
			}
			return result;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00026460 File Offset: 0x00024660
		protected virtual bool GetWarningRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio warningRadio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isFirmwareRecoveryBeforeSynchronizationRead)
		{
			short num = (short)299892736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				bool result;
				for (;;)
				{
					IL_29:
					bool flag;
					bool flag2;
					string item;
					string text;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = d.ProductFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2 = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
						num = (short)1637285897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						flag = false;
						goto IL_286;
					case 2:
						if (!flag2)
						{
							num = (short)2067267587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1786249217;
						if (num != 0)
						{
						}
						num = (short)76283909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1703739404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!warningRadio.OriginalReasonList.Contains(item))
						{
							num = (short)1820262411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
					{
						num = (short)922222592;
						short num3 = num;
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobSchedule_Warning_FactoryReset_ModifyState;
						goto IL_172;
					}
					case 6:
					{
						num = (short)569443333;
						short num4 = num;
						num = (short)961086469;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1346895872;
							if (num != 0)
							{
							}
							if (d.UIModified)
							{
								num = (short)129892366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						break;
					}
					case 7:
						return result;
					case 8:
						if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read || flag2)
						{
							num = (short)311033869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily2;
						flag = (productFamily.GetValueOrDefault() == productFamily2 & productFamily != null);
						goto IL_286;
					}
					case 10:
						if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset)
						{
							num = (short)759824384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)282787841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						warningRadio.OriginalReasonList.Add(item);
						result = true;
						num = (short)755236871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobSchedule_Warning_Read_ModifyState;
						goto IL_172;
					case 13:
						num = (short)1284505602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)447938568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C;
					IL_172:
					item = text;
					num = (short)2132017156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_286:
					flag2 = flag;
					num = (short)640745478;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6C:
				result = false;
				num = (short)578748426;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00026780 File Offset: 0x00024980
		protected void RunOperationWrapper(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context, global::Motorola.CommonCPS.RadioManagement.BatchOp.ScheduleJobBatchOp operation)
		{
			short num = (short)1638465536;
			short num2 = num;
			num = (short)1850431401;
			short num3 = num;
			num = (short)142497705;
			switch (num3 == num)
			{
			}
			num = (short)350158849;
			if (num != 0)
			{
			}
			num = (short)1366294528;
			if (num != 0)
			{
			}
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(operation);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00026830 File Offset: 0x00024A30
		protected virtual bool ExecuteOperation(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			short num = (short)316801024;
			short num2 = num;
			num = (short)426699030;
			short num3 = num;
			num = (short)318892310;
			switch (num3 == num)
			{
			}
			num = (short)1163329537;
			if (num != 0)
			{
			}
			num = (short)1612840960;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000268DC File Offset: 0x00024ADC
		protected virtual global::Motorola.CommonCPS.Server.CommonDBConstants.JobType GetJobType(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			int a_ = 9;
			short num = (short)1886191616;
			short num2 = num;
			num = (short)1974897877;
			short num3 = num;
			num = (short)1419545813;
			switch (num3 == num)
			{
			}
			num = (short)398262272;
			if (num != 0)
			{
			}
			num = (short)1751187457;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꧹铻鿽泿渁␃栅朇縉Ⰻ洍缏缑紓砕缗㨙琛笝刟䜡", a_));
		}
	}
}
