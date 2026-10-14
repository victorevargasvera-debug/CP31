using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000043 RID: 67
	public class UpgradeLanguageInRadiosBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<object>
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00029180 File Offset: 0x00027380
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00029230 File Offset: 0x00027430
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> SelectedRadios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1126301697;
				if (num != 0)
				{
				}
				num = (short)57868288;
				short num2 = num;
				num = (short)1131200276;
				short num3 = num;
				num = (short)792379156;
				switch (num3 == num)
				{
				}
				num = (short)1307115520;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1005748241;
				short num2 = num;
				num = (short)405372945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217200128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452526081;
				if (num != 0)
				{
				}
				num = (short)362676224;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000292E0 File Offset: 0x000274E0
		public override string JobName
		{
			get
			{
				short num = (short)74178781;
				short num2 = num;
				num = (short)279240925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)301400064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18808832;
				if (num != 0)
				{
				}
				num = (short)1613692929;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.UpgradeLanguagePackJobName;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00029390 File Offset: 0x00027590
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1484573961;
				short num2 = num;
				num = (short)932891913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979435520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1937768448;
				if (num != 0)
				{
				}
				num = (short)1939079169;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeLanguagePack;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00029438 File Offset: 0x00027638
		public UpgradeLanguageInRadiosBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedRadios)
		{
			base.SelectedItems = new global::System.Collections.Generic.List<object>
			{
				new object()
			};
			this.SelectedRadios = selectedRadios;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00029468 File Offset: 0x00027668
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1229193216;
			switch (num)
			{
			default:
			{
				num = (short)439943169;
				if (num != 0)
				{
				}
				num = (short)28508160;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>();
				global::System.Collections.Generic.List<global::System.Guid> list2 = new global::System.Collections.Generic.List<global::System.Guid>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator = this.SelectedRadios.GetEnumerator())
				{
					num = (short)1728249860;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							num = (short)1925513219;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (enumerator.MoveNext())
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary item = radioBase.ToEntity();
								list.Add(item);
								list2.Add(radioBase.ToEntity().Uuid);
								num = (short)1684379292;
								short num4 = num;
								num = (short)1887803036;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1638137856;
									if (num != 0)
									{
									}
									num = (short)1034747904;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							num = (short)1886584833;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1AE;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						}
						IL_155:
						num = (short)580845570;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C2:
						goto IL_155;
					}
					IL_1AE:;
				}
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> a_ = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).UpdateLanguagePackOnRadios(list2);
				this.a(a_);
				this.b(a_);
				base.ReportProgress(base.SelectedItems.Count);
				return;
			}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0002967C File Offset: 0x0002787C
		private void b(global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> A_0)
		{
			short num = (short)1696137217;
			if (num != 0)
			{
			}
			num = (short)916455424;
			short num2 = num;
			num = (short)1202259011;
			short num3 = num;
			num = (short)1345258563;
			switch (num3 == num)
			{
			}
			num = (short)2002452480;
			if (num != 0)
			{
			}
			base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(A_0.Where(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> n)
			{
				short num4 = (short)54859163;
				short num5 = num4;
				num4 = (short)1710757275;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)1692073984;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)1156710401;
				if (num4 != 0)
				{
				}
				num4 = (short)648937472;
				if (num4 != 0)
				{
				}
				return n.Value == global::Motorola.Common.CustomException.CommonErrorCode.None;
			}).Select(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> n)
			{
				short num4 = (short)2129821801;
				short num5 = num4;
				num4 = (short)454852713;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)735444992;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)1323892737;
				if (num4 != 0)
				{
				}
				num4 = (short)837877760;
				if (num4 != 0)
				{
				}
				return n.Key;
			}).ToList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>().ToUiModels(true));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002978C File Offset: 0x0002798C
		private void a(global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> A_0)
		{
			short num = (short)15925248;
			switch (num)
			{
			default:
			{
				num = (short)841285632;
				short num2 = num;
				int? num3 = null;
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode>.Enumerator enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)608829445;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> keyValuePair;
							global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
							{
								JobDescription = keyValuePair.Key.SerialNumber,
								ErrorCode = ((keyValuePair.Value == global::Motorola.Common.CustomException.CommonErrorCode.None) ? num3 : new int?((int)keyValuePair.Value)),
								JobStatus = ((keyValuePair.Value == global::Motorola.Common.CustomException.CommonErrorCode.None) ? global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED : global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED),
								JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
							};
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(job);
							num = (short)1639747637;
							short num5 = num;
							num = (short)1659342901;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1CD;
							default:
								num = (short)2077687808;
								if (num != 0)
								{
								}
								num = (short)75169792;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_1CD;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)490930178;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> keyValuePair = enumerator.Current;
							num = (short)895287297;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1ED;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						}
						IL_191:
						num = (short)1000538115;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_95:
						goto IL_191;
						IL_1CD:
						num = (short)1245249540;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1ED:;
				}
				finally
				{
					num = (short)7340033;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x0400007E RID: 126
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> a;
	}
}
