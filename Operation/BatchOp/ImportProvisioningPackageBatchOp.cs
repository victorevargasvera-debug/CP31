using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
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
	// Token: 0x02000016 RID: 22
	public class ImportProvisioningPackageBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000AED4 File Offset: 0x000090D4
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000AF84 File Offset: 0x00009184
		protected string ManifestFileRoot
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1626688778;
				short num2 = num;
				num = (short)91442442;
				switch (num2 == num)
				{
				}
				num = (short)1859256321;
				if (num != 0)
				{
				}
				num = (short)1397489664;
				short num3 = num;
				num = (short)1306394624;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)803340289;
				if (num != 0)
				{
				}
				num = (short)2099452591;
				short num2 = num;
				num = (short)780802735;
				switch (num2 == num)
				{
				}
				num = (short)912850944;
				short num3 = num;
				num = (short)430178304;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000B034 File Offset: 0x00009234
		public ImportProvisioningPackageBatchOp(global::System.Collections.Generic.List<string> fileList)
		{
			base.SelectedItems = fileList;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000B050 File Offset: 0x00009250
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)810503404;
				short num2 = num;
				num = (short)848514284;
				switch (num2 == num)
				{
				}
				num = (short)329056257;
				if (num != 0)
				{
				}
				num = (short)751501312;
				short num3 = num;
				num = (short)24444928;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportGeneralPackages;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000B0FC File Offset: 0x000092FC
		public override string JobName
		{
			get
			{
				short num = (short)1151860737;
				if (num != 0)
				{
				}
				num = (short)909064539;
				short num2 = num;
				num = (short)2112239963;
				switch (num2 == num)
				{
				}
				num = (short)2074607616;
				short num3 = num;
				num = (short)1521418240;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportPackages;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000B1AC File Offset: 0x000093AC
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 14;
			short num = (short)1961164800;
			switch (num)
			{
			default:
			{
				int num2 = 0;
				global::System.Collections.Generic.IEnumerator<string> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)887226375;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_19B;
								}
								global::Motorola.CommonCPS.Server.EntityModel.PBBPackage pbbpackage;
								string text;
								string text2;
								for (;;)
								{
									IL_158:
									switch (num3)
									{
									case 0:
										goto IL_400;
									case 1:
									{
										bool flag;
										if (flag)
										{
											num = (short)962134026;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage item;
										base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>
										{
											item
										});
										num = (short)1390084104;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										if (packageSummary != null)
										{
											num = (short)1707671555;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_400;
									}
									case 3:
									{
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary;
										global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage item = packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage;
										num = (short)79691777;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_1ED;
									case 5:
										goto IL_29E;
									case 6:
										num = (short)1526988807;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										if (pbbpackage.RMFile.Url == null)
										{
											num = (short)1378680837;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag = false;
										global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.CheckAndImportBacthPackage(base.JobContainerGuid, text, pbbpackage, text, out flag);
										num = (short)1714094082;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_400;
									case 9:
										num = (short)780140556;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage item;
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>
										{
											item
										});
										num = (short)341835776;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										goto IL_41A;
									case 12:
										if (pbbpackage.RMFile != null)
										{
											num = (short)753598470;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_32C;
									case 13:
										if (string.IsNullOrEmpty(text2))
										{
											num = (short)1471807492;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										pbbpackage = this.a(text, text2);
										num = (short)1318584334;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										if (pbbpackage != null)
										{
											num = (short)1719861257;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_32C;
									}
									goto IL_19B;
									IL_400:
									num = (short)1952972811;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1ED:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Manifest_File_Absent);
								IL_29E:
								IL_32C:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CpsDidntReturnInfo + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_File0, pbbpackage));
								IL_41A:
								goto IL_A0;
								IL_19B:
								text2 = this.b(text, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("뻒듔맖냘뷚룜곞闠췢鷤諦藨", a_));
								num = (short)329187341;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_158;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								string text;
								batchOperationJob.JobDescription = text;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData == null)
								{
									goto IL_476;
								}
								IL_45A:
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								IL_476:
								num = (short)548712657;
								short num4 = num;
								num = (short)1711517905;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_45A;
								default:
									num = (short)1644363776;
									if (num != 0)
									{
									}
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
									goto IL_A0;
								}
							}
							goto IL_4F2;
							IL_A0:
							base.ReportProgress(++num2);
							num = (short)1574830084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)221511685;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_9B;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)155058177;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = enumerator.Current;
							global::Motorola.CommonCPS.Server.EntityModel.PBBPackage pbbpackage = null;
							num = (short)515964936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_529;
						case 6:
							num = (short)1646526466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_81;
							}
							continue;
						case 8:
							if (base.CancellationPending)
							{
								num = (short)1033043974;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4F2;
						}
						IL_10E:
						num = (short)2031222787;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_81:
						goto IL_10E;
						IL_4F2:
						num = (short)973799424;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_9B:
					IL_529:;
				}
				finally
				{
					num = (short)211550209;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_594;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_55D;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1703542784;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_55D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)117112834;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_594:;
				}
				num = (short)728760320;
				short num5 = num;
				num = (short)813432833;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000B7D8 File Offset: 0x000099D8
		private string b(string A_0, string A_1)
		{
			int a_ = 15;
			short num = (short)768540672;
			switch (num)
			{
			default:
			{
				num = (short)84803585;
				if (num != 0)
				{
				}
				num = (short)583270400;
				short num2 = num;
				string text = string.Empty;
				try
				{
					string text2 = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("맓蛕맗맙럛뿝蟟蟡샣", a_));
					global::System.IO.Directory.CreateDirectory(text2);
					global::System.IO.Compression.ZipArchive zipArchive = global::System.IO.Compression.ZipFile.OpenRead(A_0);
					try
					{
						global::System.Collections.Generic.IEnumerator<global::System.IO.Compression.ZipArchiveEntry> enumerator = zipArchive.Entries.GetEnumerator();
						try
						{
							num = (short)512425989;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									text = global::System.IO.Path.Combine(text2, global::System.IO.Path.GetRandomFileName());
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
									zipArchiveEntry.ExtractToFile(text, true);
									num = (short)525664260;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
									if (zipArchiveEntry.Name.Equals(A_1, global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)61800448;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)296747014;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry = enumerator.Current;
									num = (short)1107623937;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1C7;
								case 4:
									goto IL_1AD;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_F7;
									}
									continue;
								case 6:
									goto IL_1AD;
								}
								IL_F9:
								num = (short)2057895938;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_F7:
								goto IL_F9;
								IL_1AD:
								num = (short)1045430275;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1C7:;
						}
						finally
						{
							num = (short)662765569;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									num = (short)671437777;
									short num4 = num;
									num = (short)1343378385;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_26B;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1FE;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)918159360;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1FE:
								if (enumerator == null)
								{
									goto IL_282;
								}
								num = (short)2107768834;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_26B:
							num = (short)352059392;
							if (num != 0)
							{
							}
							IL_282:;
						}
					}
					finally
					{
						num = (short)1662189569;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_2F0;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2B8;
								}
								continue;
							case 2:
								((global::System.IDisposable)zipArchive).Dispose();
								num = (short)1635450880;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2B8:
							if (zipArchive == null)
							{
								break;
							}
							num = (short)6881282;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2F0:;
					}
				}
				catch (global::System.Exception)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PBB_Fail_To_Open_Package);
				}
				return text;
			}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000BB34 File Offset: 0x00009D34
		private global::Motorola.CommonCPS.Server.EntityModel.PBBProvisioning a(string A_0, string A_1)
		{
			int a_ = 12;
			short num = (short)225312768;
			short num2 = num;
			num = (short)1810807376;
			short num3 = num;
			num = (short)93764176;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)768933888;
				if (num != 0)
				{
				}
				num = (short)321323009;
				if (num != 0)
				{
				}
				num = (short)1948581888;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::Motorola.CommonCPS.Server.EntityModel.PBBProvisioning pbbprovisioning = null;
			global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(A_1);
			try
			{
				try
				{
					switch (0)
					{
					case 0:
						goto IL_167;
					}
					int num4;
					global::System.Xml.Linq.XDocument xdocument;
					string text;
					for (;;)
					{
						IL_DC:
						switch (num4)
						{
						case 0:
							goto IL_30D;
						case 1:
							pbbprovisioning.RebootCount = new int?(xdocument.Descendants(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("냐냒ꇔ뻖뛘뗚", a_)).Count(delegate(global::System.Xml.Linq.XElement e)
							{
								int a_2 = 1;
								short num5 = (short)1621950464;
								short num6 = num5;
								num5 = (short)481626116;
								short num7 = num5;
								num5 = (short)1636894724;
								switch (num7 == num5)
								{
								}
								num5 = (short)1069613056;
								if (num5 != 0)
								{
								}
								num5 = (short)988741633;
								if (num5 != 0)
								{
								}
								return e.Value.Equals(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("듅귇꣉ꏋꇍ꓏", a_2));
							}));
							pbbprovisioning.PackageName = global::System.IO.Path.GetFileNameWithoutExtension(A_0);
							pbbprovisioning.RMFile = new global::Motorola.CommonCPS.Server.EntityModel.RMFile
							{
								Url = A_0
							};
							num = (short)1654718464;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source;
							if (source.Count<global::System.Xml.Linq.XElement>() != 0)
							{
								num = (short)595460117;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						}
						case 3:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable;
							if (enumerable != null)
							{
								num = (short)160497688;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_54E;
						}
						case 4:
							text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Package_Schema_Version_Absent;
							num = (short)643301389;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_30D;
						case 6:
							goto IL_30D;
						case 7:
						{
							global::System.Xml.Linq.XElement xelement;
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source2;
							if (this.AddtionalValidateManifestFile(xelement, source2.First<global::System.Xml.Linq.XElement>().Value))
							{
								num = (short)52101152;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30D;
						}
						case 8:
							num = (short)2003501067;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_30D;
						case 10:
							pbbprovisioning.IsContainStage = new bool?(xdocument.Descendants(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("럐뫒맔닖跘ꋚ규뫞", a_)).Count(delegate(global::System.Xml.Linq.XElement e)
							{
								int a_2 = 0;
								short num5 = (short)1554186240;
								short num6 = num5;
								num5 = (short)1202728820;
								short num7 = num5;
								num5 = (short)94711668;
								switch (num7 == num5)
								{
								}
								num5 = (short)464846848;
								if (num5 != 0)
								{
								}
								num5 = (short)672464897;
								if (num5 != 0)
								{
								}
								return e.Value.Equals(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("雄돆꣈곊꓌ꇎ뛐", a_2));
							}) != 0);
							num = (short)379650049;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source2;
							if (string.IsNullOrEmpty(source2.First<global::System.Xml.Linq.XElement>().Value))
							{
								num = (short)1784807450;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)726269959;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_76C;
						case 13:
							goto IL_30D;
						case 14:
							goto IL_295;
						case 15:
							goto IL_30D;
						case 16:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source3;
							if (source3.First<global::System.Xml.Linq.XElement>().Value == null)
							{
								num = (short)1632436249;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1751711746;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)420151318;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1784021004;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_1C6;
						case 19:
							num = (short)1375469584;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source;
							if (source.First<global::System.Xml.Linq.XElement>().Value == null)
							{
								num = (short)1515716622;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)493158427;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							num = (short)104661012;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_34A;
						case 23:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable;
							if (enumerable.Count<global::System.Xml.Linq.XElement>() == 0)
							{
								num = (short)936378398;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source = xdocument.Descendants(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("볐닒믔뻖뿘뻚껜ꯞ럠蛢韤铦胨蓪菬", a_));
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source3 = xdocument.Descendants(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꇐ닒뛔볖룘볚룜觞蓠釢雤軦蛨藪", a_));
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source2 = xdocument.Descendants(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꇐ닒뛔볖룘볚룜鯞蓠郢蛤闦胨鯪駬蛮黰鷲", a_));
							global::System.Xml.Linq.XElement xelement = enumerable.First<global::System.Xml.Linq.XElement>();
							num = (short)27066397;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							num = (short)1551368215;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							goto IL_6AE;
						case 26:
							goto IL_353;
						case 27:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source2;
							if (source2.Count<global::System.Xml.Linq.XElement>() != 0)
							{
								num = (short)810942472;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_353;
						}
						case 28:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source3;
							if (source3.Count<global::System.Xml.Linq.XElement>() != 0)
							{
								num = (short)909574163;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6AE;
						}
						case 29:
						{
							global::System.Xml.Linq.XElement xelement;
							if (xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꋐ냒뷔닖듘뫚诜뫞鏠郢賤裦蟨", a_)) == null)
							{
								num = (short)1058013188;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1300824092;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							goto IL_54E;
						case 31:
						{
							if (string.IsNullOrEmpty(this.ManifestFileRoot))
							{
								num = (short)1322057746;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = string.Empty;
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = xdocument.Descendants(this.ManifestFileRoot);
							num = (short)72548355;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 32:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source3;
							pbbprovisioning.PackageVersion = source3.First<global::System.Xml.Linq.XElement>().Value;
							pbbprovisioning.ManifestRoot = this.ManifestFileRoot;
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source;
							pbbprovisioning.ManifestVersion = source.First<global::System.Xml.Linq.XElement>().Value;
							global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> source2;
							pbbprovisioning.PackageDescription = source2.First<global::System.Xml.Linq.XElement>().Value.Trim();
							num = (short)321650698;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_167;
						IL_295:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Manifest_Version_Absent;
						num = (short)399441929;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_30D:
						num = (short)566820881;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_353:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Package_Description_Absent;
						num = (short)993525766;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_54E:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Manifest_File_Mismatch;
						num = (short)379912207;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_6AE:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PBB_Package_Version_Absent;
						num = (short)293601285;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1C6:
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鳐닒믔뻖뿘뻚껜ꯞ꟠諢觤苦믨蓪苬鯮", a_));
					IL_34A:
					throw new global::Motorola.Common.CustomException.CommonException(text);
					IL_76C:
					return pbbprovisioning;
					IL_167:
					pbbprovisioning = new global::Motorola.CommonCPS.Server.EntityModel.PBBProvisioning();
					pbbprovisioning.CreatedDate = new global::System.DateTime?(global::System.DateTime.Now);
					xdocument = global::System.Xml.Linq.XDocument.Load(xmlReader);
					num = (short)1830682655;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_DC;
				}
				catch (global::System.Exception ex)
				{
					throw new global::Motorola.Common.CustomException.CommonException(ex.Message);
				}
				finally
				{
					xmlReader.Close();
				}
			}
			finally
			{
				num = (short)1916403712;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7B2;
						}
						continue;
					case 1:
						((global::System.IDisposable)xmlReader).Dispose();
						num = (short)1039007746;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_7E7;
					}
					IL_7B2:
					if (xmlReader == null)
					{
						break;
					}
					num = (short)1519190017;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_7E7:;
			}
			return pbbprovisioning;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000C378 File Offset: 0x0000A578
		protected virtual bool AddtionalValidateManifestFile(global::System.Xml.Linq.XElement root, string pkgDescription)
		{
			short num = (short)1041301504;
			short num2 = num;
			num = (short)1203493682;
			short num3 = num;
			num = (short)662428466;
			switch (num3 == num)
			{
			}
			num = (short)426115073;
			if (num != 0)
			{
			}
			num = (short)1285029888;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
