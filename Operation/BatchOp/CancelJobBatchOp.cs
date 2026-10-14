using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200002A RID: 42
	public class CancelJobBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00021794 File Offset: 0x0001F994
		public CancelJobBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList)
		{
			base.SelectedItems = radioList;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000217B0 File Offset: 0x0001F9B0
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1278408619;
				short num2 = num;
				num = (short)637335467;
				switch (num2 == num)
				{
				}
				num = (short)194117632;
				if (num != 0)
				{
				}
				num = (short)1124466688;
				short num3 = num;
				num = (short)1858928641;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CancelJob;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0002185C File Offset: 0x0001FA5C
		public override string JobName
		{
			get
			{
				short num = (short)571678628;
				short num2 = num;
				num = (short)1596202916;
				switch (num2 == num)
				{
				}
				num = (short)1724317697;
				if (num != 0)
				{
				}
				num = (short)1430257664;
				short num3 = num;
				num = (short)1398734848;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.CancelJob_BatchJobName;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0002190C File Offset: 0x0001FB0C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)2049572864;
			switch (num)
			{
			default:
			{
				num = (short)913113088;
				short num2 = num;
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1570897922;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Guid? guid;
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
						global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary;
						switch (num4)
						{
						case 0:
						{
							num = (short)1085283587;
							short num5 = num;
							num = (short)1853234435;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_139;
							default:
							{
								num = (short)1587871744;
								if (num != 0)
								{
								}
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
								base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
								{
									radioSummary.ToUiModel(true)
								});
								num = (short)1202323470;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							goto IL_134;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_D3;
							}
							continue;
						case 3:
							num = (short)501940242;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (guid != null)
							{
								num = (short)1251475473;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_322;
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.WorkingCodeplug);
							num = (short)1214513161;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_139;
						case 7:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							entitySummary.Name = (string.IsNullOrEmpty(radioBase.DeviceID) ? radioBase.SerialNumber : radioBase.DeviceID);
							global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
							global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).CancelJob(base.JobContainerGuid, entitySummary, validateEntitySet);
							num = (short)975568907;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2115108867;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)1448345620;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_1A9;
						case 10:
							goto IL_322;
						case 11:
						{
							global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
							if (radioSummary != null)
							{
								num = (short)575930368;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 13:
							if (guid != null)
							{
								num = (short)1367670789;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A9;
						case 14:
							goto IL_24B;
						case 15:
							num = (short)1209204737;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.LastJob);
							num = (short)902365190;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
						{
							global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio.LastJob);
							num = (short)234553354;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							goto IL_48B;
						case 19:
							if (radio.LastJob != null)
							{
								num = (short)872022032;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_139;
						case 20:
						{
							if (base.CancellationPending)
							{
								num = (short)1619984399;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							radio = radioBase.ToServerModel();
							global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
							validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
							validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
							validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, radio);
							guid = radio.LastJobUuid;
							num = (short)2108096516;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_D3;
						IL_139:
						entitySummary = new global::Motorola.CommonCPS.Server.EntityModel.EntitySummary();
						entitySummary.Uuid = radio.Uuid;
						num = (short)287113223;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A9:
						num = (short)753467411;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_24B:
						num3++;
						base.ReportProgress(num3);
						num = (short)442433548;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_322:
						guid = radio.WorkingCodeplugUuid;
						num = (short)1882390541;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_36B:
						num = (short)1110966280;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D3:
						goto IL_36B;
					}
					IL_134:
					IL_48B:;
				}
				finally
				{
					num = (short)1312686082;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1893859329;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1605894145;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_51F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4E9;
							}
							continue;
						}
						IL_4E9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2019426304;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_51F:;
				}
				return;
			}
			}
		}
	}
}
