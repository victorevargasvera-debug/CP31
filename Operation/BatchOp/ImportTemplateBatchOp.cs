using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000054 RID: 84
	public class ImportTemplateBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00031444 File Offset: 0x0002F644
		public ImportTemplateBatchOp(global::System.Collections.Generic.IList<string> filePath, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> ReadPassWordDictionary)
		{
			base.SelectedItems = filePath;
			this.ReadPassWordDictionary = ReadPassWordDictionary;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00031468 File Offset: 0x0002F668
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1102752977;
				short num2 = num;
				num = (short)1038134481;
				switch (num2 == num)
				{
				}
				num = (short)317194241;
				if (num != 0)
				{
				}
				num = (short)215613440;
				if (num != 0)
				{
				}
				num = (short)1527054336;
				short num3 = num;
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportTemplates;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00031514 File Offset: 0x0002F714
		public override string JobName
		{
			get
			{
				short num = (short)799449208;
				short num2 = num;
				num = (short)713138296;
				switch (num2 == num)
				{
				}
				num = (short)1230372865;
				if (num != 0)
				{
				}
				num = (short)752812032;
				if (num != 0)
				{
				}
				num = (short)572784640;
				short num3 = num;
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ImportTemplatesJobName;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000315C0 File Offset: 0x0002F7C0
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00031674 File Offset: 0x0002F874
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob> JobList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1092616193;
				if (num != 0)
				{
				}
				num = (short)724931753;
				short num2 = num;
				num = (short)1428395177;
				switch (num2 == num)
				{
				}
				num = (short)575602688;
				if (num != 0)
				{
				}
				num = (short)941293568;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1552184261;
				short num2 = num;
				num = (short)1329624005;
				switch (num2 == num)
				{
				}
				num = (short)303431681;
				if (num != 0)
				{
				}
				num = (short)2075787264;
				if (num != 0)
				{
				}
				num = (short)1307508736;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00031724 File Offset: 0x0002F924
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000317D4 File Offset: 0x0002F9D4
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> ReadPassWordDictionary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1442886396;
				short num2 = num;
				num = (short)866300668;
				switch (num2 == num)
				{
				}
				num = (short)865075200;
				if (num != 0)
				{
				}
				num = (short)1871839233;
				if (num != 0)
				{
				}
				num = (short)880082944;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)910688257;
				if (num != 0)
				{
				}
				num = (short)851757184;
				short num2 = num;
				num = (short)312723584;
				switch (num2 == num)
				{
				}
				num = (short)1538064384;
				if (num != 0)
				{
				}
				num = (short)999817216;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00031888 File Offset: 0x0002FA88
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00031934 File Offset: 0x0002FB34
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary ImportedTemplate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2051736125;
				short num2 = num;
				num = (short)1760297533;
				switch (num2 == num)
				{
				}
				num = (short)2078736385;
				if (num != 0)
				{
				}
				num = (short)1673265152;
				if (num != 0)
				{
				}
				num = (short)1430388736;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2056580746;
				short num2 = num;
				num = (short)723578506;
				switch (num2 == num)
				{
				}
				num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)886112256;
				if (num != 0)
				{
				}
				num = (short)1108148224;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000319E4 File Offset: 0x0002FBE4
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)186777600;
			switch (num)
			{
			default:
			{
				int num2 = 0;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)186646532;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_5CA;
						case 1:
							try
							{
								num = (short)1147273220;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									string password;
									string text;
									switch (num3)
									{
									case 0:
										if (this.ReadPassWordDictionary != null)
										{
											num = (short)288751622;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4A2;
									case 1:
										try
										{
											num = (short)920453126;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
												{
													global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)1123287045;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword = enumerator2.Current;
													num = (short)750780420;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													goto IL_336;
												case 3:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword;
													password = filePassword.Password;
													num = (short)531365889;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword;
													if (global::System.IO.Path.GetFileNameWithoutExtension(text) == filePassword.FileName)
													{
														num = (short)1060306947;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 5:
													num = (short)1642266626;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													switch (0)
													{
													case 0:
														goto IL_273;
													}
													continue;
												}
												IL_2E3:
												num = (short)238026752;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_273:
												goto IL_2E3;
											}
											IL_336:
											goto IL_4A2;
										}
										finally
										{
											num = (short)307167234;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator2;
												switch (num3)
												{
												case 0:
													goto IL_3A8;
												case 1:
													enumerator2.Dispose();
													num = (short)1801388032;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_36F;
													}
													continue;
												}
												IL_36F:
												if (enumerator2 != null)
												{
													num = (short)728367105;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_3A8:
												num = (short)1570158516;
												short num4 = num;
												num = (short)324253620;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_36F;
												default:
													goto IL_3DC;
												}
											}
											IL_3DC:
											num = (short)1372454912;
											if (num != 0)
											{
											}
										}
										goto IL_3F2;
									case 2:
										goto IL_51B;
									case 3:
										base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
										{
											this.ImportedTemplate.ToUiModel(true)
										});
										num = (short)577699845;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_201;
										}
										continue;
									case 5:
										goto IL_502;
									case 6:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator2 = this.ReadPassWordDictionary.GetEnumerator();
										num = (short)1213333505;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										if (this.ImportedTemplate != null)
										{
											num = (short)1997996035;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_502;
									case 8:
										goto IL_22C;
									}
									IL_201:
									if (string.IsNullOrEmpty(global::System.IO.Path.GetFileNameWithoutExtension(text).Trim()))
									{
										num = (short)264699912;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)193134592;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_4A2:
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;
									global::Motorola.CommonCPS.Server.EntityModel.Template template = templateService.ParseTemplateFile(text, password, false);
									this.ImportedTemplate = templateService.ImportToServer(base.JobContainerGuid, text, template);
									num = (short)605880327;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_502:
									num = (short)1664811010;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_22C:
								IL_3F2:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_EmptyFileName_Error);
								IL_51B:
								goto IL_A8;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								string text;
								batchOperationJob.JobDescription = global::System.IO.Path.GetFileNameWithoutExtension(text);
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;
								templateService.AddBatchOperationJob(batchOperationJob);
								num2++;
								base.ReportProgress(num2);
								break;
							}
							goto IL_5B0;
							IL_A8:
							num2++;
							base.ReportProgress(num2);
							num = (short)989790210;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1542782987;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_87;
							}
							continue;
						case 5:
							if (base.CancellationPending)
							{
								num = (short)1190985731;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)954007560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)263585799;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_5E7;
						case 8:
						{
							if (flag)
							{
								num = (short)1162805258;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
							string password = null;
							num = (short)1329659905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2008285190;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							num = (short)2020474885;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_5B0;
						case 11:
							goto IL_A3;
						}
						IL_112:
						num = (short)901382153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_87:
						goto IL_112;
						IL_5B0:
						num = (short)1969487872;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_A3:
					IL_5CA:
					IL_5E7:;
				}
				finally
				{
					num = (short)369360898;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_67E;
						case 1:
							enumerator.Dispose();
							num = (short)1289289728;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_61E;
							}
							continue;
						}
						IL_61E:
						num = (short)416808961;
						if (num != 0)
						{
						}
						if (enumerator == null)
						{
							break;
						}
						num = (short)2006253569;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_67E:;
				}
				num = (short)121569280;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x04000098 RID: 152
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob> a;

		// Token: 0x04000099 RID: 153
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> b;

		// Token: 0x0400009A RID: 154
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary c;
	}
}
