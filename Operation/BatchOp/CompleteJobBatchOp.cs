using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000037 RID: 55
	public class CompleteJobBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00026614 File Offset: 0x00024814
		public CompleteJobBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> rds)
		{
			base.SelectedItems = rds;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00026630 File Offset: 0x00024830
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1843767829;
				short num2 = num;
				num = (short)1086695957;
				switch (num2 == num)
				{
				}
				num = (short)908722176;
				short num3 = num;
				num = (short)1974075393;
				if (num != 0)
				{
				}
				num = (short)1042874368;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CompleteRadio;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000266D8 File Offset: 0x000248D8
		public override string JobName
		{
			get
			{
				short num = (short)2089108953;
				short num2 = num;
				num = (short)6374873;
				switch (num2 == num)
				{
				}
				num = (short)891420672;
				short num3 = num;
				num = (short)806813697;
				if (num != 0)
				{
				}
				num = (short)2001272832;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.CompleteRadioBatchJob;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00026784 File Offset: 0x00024984
		public override bool IsSafe
		{
			get
			{
				short num = (short)1253441537;
				if (num != 0)
				{
				}
				num = (short)1778606193;
				short num2 = num;
				num = (short)448684145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427636224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2099838976;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0002682C File Offset: 0x00024A2C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1529020416;
			switch (num)
			{
			default:
			{
				num = (short)516030464;
				short num2 = num;
				int num3 = 0;
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)574488578;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)330891268;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)511180801;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1375338496;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.Radio item = enumerator.Current.ToServerModel();
							list.Add(item);
							num = (short)184614915;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3B8;
							}
							continue;
						case 4:
							goto IL_45F;
						}
						IL_3BA:
						num = (short)1934819329;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B8:
						goto IL_3BA;
					}
					IL_45F:
					goto IL_371;
				}
				finally
				{
					num = (short)899481600;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_497;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1056899074;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_4CC;
						}
						IL_497:
						if (enumerator == null)
						{
							break;
						}
						num = (short)535756801;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_4CC:;
				}
				return;
				for (;;)
				{
					IL_371:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Radio> enumerator2 = list.GetEnumerator();
					try
					{
						num = (short)1344143362;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 1:
								goto IL_272;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B5;
								}
								continue;
							case 3:
								num = (short)1073610763;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary;
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
								entitySummary.Name = (string.IsNullOrEmpty(radio.DeviceID) ? radio.SerialNumber : radio.DeviceID);
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).CompleteJob(base.JobContainerGuid, entitySummary, validateEntitySet);
								num = (short)37617671;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1449852931;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio = enumerator2.Current;
								num = (short)653983754;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								num = (short)905183241;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
								if (radioSummary != null)
								{
									num = (short)675938312;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_272;
							}
							case 8:
							{
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
								base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
								{
									radioSummary.ToUiModel(true)
								});
								num = (short)1717436417;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_CF;
							case 10:
							{
								if (base.CancellationPending)
								{
									num = (short)1391591430;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
								validateEntitySet.RelatedObject = new global::System.Guid?(radio.Uuid);
								validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
								validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
								global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary = new global::Motorola.CommonCPS.Server.EntityModel.EntitySummary();
								entitySummary.Uuid = radio.Uuid;
								num = (short)110362628;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								goto IL_2B2;
							}
							IL_144:
							num = (short)1359609861;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_B5:
							goto IL_144;
							IL_272:
							num3++;
							base.ReportProgress(num3);
							num = (short)1665794048;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_CF:
						IL_2B2:
						break;
					}
					finally
					{
						num = (short)1079115776;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2E9;
								}
								continue;
							case 1:
								enumerator2.Dispose();
								num = (short)1197932546;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)1927240322;
								short num5 = num;
								num = (short)1865308802;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_359;
								}
								break;
							}
							}
							IL_2E9:
							if (enumerator2 == null)
							{
								goto IL_370;
							}
							num = (short)517668865;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_359:
						num = (short)1436286976;
						if (num != 0)
						{
						}
						IL_370:;
					}
				}
				return;
			}
			}
		}
	}
}
