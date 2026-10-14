using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000BB RID: 187
	public class PrepareMoveDeviceBatchCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00042CB0 File Offset: 0x00040EB0
		public override bool CanExecute(params object[] paras)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1535049728;
				switch (num)
				{
				default:
				{
					num = (short)2110980096;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_67;
							}
							continue;
						case 1:
							goto IL_34C;
						case 2:
							if (observableCollection.Count > 0)
							{
								num = (short)1926692870;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 3:
						{
							num = (short)1896808448;
							short num3 = num;
							num = (short)712179713;
							if (num != 0)
							{
							}
							if (paras[0] != null)
							{
								num = (short)980549633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						case 4:
							return false;
						case 5:
							try
							{
								num = (short)1258815488;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_F6;
										}
										continue;
									case 1:
										num = (short)744488972;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1346174977;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
										num = (short)56033286;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
										num = (short)1589051396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										if (jobStatus.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED)
										{
											num = (short)1564934152;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_132;
									}
									case 5:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										if (jobStatus.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING)
										{
											num = (short)883163149;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_132;
									}
									case 6:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										if (jobStatus != null)
										{
											num = (short)1585250318;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										if (jobStatus.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING)
										{
											num = (short)1034223619;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_132;
									}
									case 8:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
										num = (short)372441099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										goto IL_132;
									case 10:
										goto IL_14D;
									case 11:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										if (jobStatus.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED)
										{
											num = (short)677183497;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
										goto IL_2DB;
									case 13:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
										num = (short)189923335;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
										num = (short)1367736325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_F8:
									num = (short)145031170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_F6:
									goto IL_F8;
									IL_132:
									result = false;
									num = (short)148307978;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_14D:
								return result;
								IL_2DB:
								return true;
							}
							finally
							{
								num = (short)397869056;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_313;
										}
										continue;
									case 1:
										goto IL_349;
									case 2:
										enumerator.Dispose();
										num = (short)613154817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_313:
									if (enumerator == null)
									{
										break;
									}
									num = (short)944308226;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_349:;
							}
							goto IL_34C;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = observableCollection.GetEnumerator();
							num = (short)1228996613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							return false;
						case 8:
						{
							if ((paras[1] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>).Count == 0)
							{
								num = (short)844169223;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)535350782;
							short num4 = num;
							num = (short)1252183550;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)405405696;
								if (num != 0)
								{
								}
								num = (short)688259075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_67:
						if ((paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>).Count == 0)
						{
							num = (short)947716100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)678166536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_34C:
						observableCollection = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
						num = (short)438108162;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			return false;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000431B8 File Offset: 0x000413B8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1240072192;
			short num2 = num;
			num = (short)906715723;
			short num3 = num;
			num = (short)1163158091;
			switch (num3 == num)
			{
			}
			num = (short)157220865;
			if (num != 0)
			{
			}
			num = (short)1151533056;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext moveDeviceContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext();
			moveDeviceContext.Groups = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
			moveDeviceContext.Radios = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowMoveDeviceDialog(moveDeviceContext);
			return null;
		}
	}
}
