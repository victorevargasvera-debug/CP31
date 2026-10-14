using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml;
using CommonUtility;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.ModelConvertor;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000024 RID: 36
	public static class ModelConverter
	{
		// Token: 0x06000188 RID: 392 RVA: 0x0001A678 File Offset: 0x00018878
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> ToFirmwares<TIn>(this global::System.Collections.Generic.IEnumerable<TIn> package) where TIn : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)138047508;
			short num2 = num;
			num = (short)1522429972;
			switch (num2 == num)
			{
			}
			num = (short)371720192;
			short num3 = num;
			num = (short)824246273;
			if (num != 0)
			{
			}
			num = (short)1608450048;
			if (num != 0)
			{
			}
			return package.ToUiModel<TIn, global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001A72C File Offset: 0x0001892C
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> ToLanguagePacks<TIn>(this global::System.Collections.Generic.IEnumerable<TIn> package) where TIn : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)773877615;
			short num2 = num;
			num = (short)683306863;
			switch (num2 == num)
			{
			}
			num = (short)814678016;
			short num3 = num;
			num = (short)2050818049;
			if (num != 0)
			{
			}
			num = (short)774373376;
			if (num != 0)
			{
			}
			return package.ToUiModel<TIn, global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001A7DC File Offset: 0x000189DC
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement> ToVoiceAnnouncement<T>(this global::System.Collections.Generic.IEnumerable<T> package) where T : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)1400941988;
			short num2 = num;
			num = (short)1177464228;
			switch (num2 == num)
			{
			}
			num = (short)1763901440;
			short num3 = num;
			num = (short)1393623041;
			if (num != 0)
			{
			}
			num = (short)1605304320;
			if (num != 0)
			{
			}
			return package.ToUiModel<T, global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001A890 File Offset: 0x00018A90
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates> ToCACertificates<T>(this global::System.Collections.Generic.IEnumerable<T> package) where T : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)1191876125;
			short num2 = num;
			num = (short)422024733;
			switch (num2 == num)
			{
			}
			num = (short)211156992;
			short num3 = num;
			num = (short)1565523969;
			if (num != 0)
			{
			}
			num = (short)1302069248;
			if (num != 0)
			{
			}
			return package.ToUiModel<T, global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001A944 File Offset: 0x00018B44
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles> ToDVRSFiles<T>(this global::System.Collections.Generic.IEnumerable<T> package) where T : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)660157969;
			short num2 = num;
			num = (short)1041249809;
			switch (num2 == num)
			{
			}
			num = (short)2026962944;
			short num3 = num;
			num = (short)2140864512;
			if (num != 0)
			{
			}
			num = (short)1482686465;
			if (num != 0)
			{
			}
			return package.ToUiModel<T, global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech> ToTextToSpeech<T>(this global::System.Collections.Generic.IEnumerable<T> package) where T : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)1855571305;
			short num2 = num;
			num = (short)80987497;
			switch (num2 == num)
			{
			}
			num = (short)824115200;
			short num3 = num;
			num = (short)298254337;
			if (num != 0)
			{
			}
			num = (short)1261568000;
			if (num != 0)
			{
			}
			return package.ToUiModel<T, global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001AAA4 File Offset: 0x00018CA4
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> ToGeneralUIPakcage<T>(this global::System.Collections.Generic.IEnumerable<T> package) where T : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
		{
			short num = (short)359901157;
			short num2 = num;
			num = (short)287090661;
			switch (num2 == num)
			{
			}
			num = (short)476250112;
			short num3 = num;
			num = (short)241041409;
			if (num != 0)
			{
			}
			num = (short)350814208;
			if (num != 0)
			{
			}
			return package.ToUiModel<T, global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001AB54 File Offset: 0x00018D54
		public static global::System.Collections.Generic.IEnumerable<TResult> ToUiModel<TIn, TResult>(this global::System.Collections.Generic.IEnumerable<TIn> packages) where TIn : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary where TResult : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase, new()
		{
			global::System.Collections.Generic.IEnumerable<TResult> result;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				global::System.Collections.Generic.List<TResult> list;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						list.AddRange(packages.Select(new global::System.Func<TIn, TResult>(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.<>c__9<TIn, TResult>.<>9.a)));
						result = list;
						num2 = (short)139584860;
						short num3 = num2;
						num2 = (short)1165747548;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)2036924416;
							if (num2 != 0)
							{
							}
							num2 = (short)1716846593;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_11E;
					case 2:
						goto IL_93;
					case 3:
						if (packages == null)
						{
							num2 = (short)1462239236;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1712783360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						result = list;
						num2 = (short)122159106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				IL_93:
				IL_11E:
				goto IL_135;
				IL_24:
				list = new global::System.Collections.Generic.List<TResult>();
				num2 = (short)1495203843;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PM_ConvertData_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ConvertData_Error, ex);
			}
			IL_135:
			num2 = (short)1319305217;
			if (num2 != 0)
			{
			}
			num2 = (short)1067778048;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001AD1C File Offset: 0x00018F1C
		public static global::System.Collections.Generic.IEnumerable<TResult> ConvertPackageTo<TIn, TResult>(this global::System.Collections.Generic.IEnumerable<TIn> packages) where TIn : global::Motorola.CommonCPS.Server.EntityModel.Package where TResult : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase, new()
		{
			short num;
			global::System.Collections.Generic.IEnumerable<TResult> result;
			try
			{
				num = (short)904344439;
				short num2 = num;
				num = (short)1888236407;
				switch (num2 == num)
				{
				}
				num = (short)1139802113;
				if (num != 0)
				{
				}
				num = (short)1044840448;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<TResult> list = new global::System.Collections.Generic.List<TResult>();
				list.AddRange(packages.Select(new global::System.Func<TIn, TResult>(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.<>c__10<TIn, TResult>.<>9.a)));
				result = list;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PM_ConvertData_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ConvertData_Error, ex);
			}
			num = (short)749535232;
			short num3 = num;
			return result;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001AE30 File Offset: 0x00019030
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> ToUimFirmwares<T>(this global::System.Collections.Generic.IEnumerable<T> packages) where T : global::Motorola.CommonCPS.Server.EntityModel.Package
		{
			short num = (short)960939423;
			short num2 = num;
			num = (short)809223583;
			switch (num2 == num)
			{
			}
			num = (short)1370619904;
			short num3 = num;
			num = (short)207880192;
			if (num != 0)
			{
			}
			num = (short)1790115841;
			if (num != 0)
			{
			}
			return packages.ConvertPackageTo<T, global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001AEE4 File Offset: 0x000190E4
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> ToUimLanguagePacks<T>(this global::System.Collections.Generic.IEnumerable<T> packages) where T : global::Motorola.CommonCPS.Server.EntityModel.Package
		{
			short num = (short)571734714;
			short num2 = num;
			num = (short)1185807034;
			switch (num2 == num)
			{
			}
			num = (short)566099968;
			short num3 = num;
			num = (short)1121386496;
			if (num != 0)
			{
			}
			num = (short)1320026113;
			if (num != 0)
			{
			}
			return packages.ConvertPackageTo<T, global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001AF98 File Offset: 0x00019198
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement> ToUimVoiceAnnouncements<T>(this global::System.Collections.Generic.IEnumerable<T> packages) where T : global::Motorola.CommonCPS.Server.EntityModel.Package
		{
			short num = (short)688264451;
			short num2 = num;
			num = (short)294786307;
			switch (num2 == num)
			{
			}
			num = (short)575471616;
			short num3 = num;
			num = (short)1384185857;
			if (num != 0)
			{
			}
			num = (short)1065877504;
			if (num != 0)
			{
			}
			return packages.ConvertPackageTo<T, global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001B048 File Offset: 0x00019248
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates> ToUimCACertificates<T>(this global::System.Collections.Generic.IEnumerable<T> packages) where T : global::Motorola.CommonCPS.Server.EntityModel.Package
		{
			short num = (short)1217649472;
			short num2 = num;
			num = (short)604035904;
			switch (num2 == num)
			{
			}
			num = (short)122355712;
			short num3 = num;
			num = (short)1134690304;
			if (num != 0)
			{
			}
			num = (short)1481048065;
			if (num != 0)
			{
			}
			return packages.ConvertPackageTo<T, global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001B0FC File Offset: 0x000192FC
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles> ToUimDVRSFiles<T>(this global::System.Collections.Generic.IEnumerable<T> packages) where T : global::Motorola.CommonCPS.Server.EntityModel.Package
		{
			short num = (short)422046820;
			short num2 = num;
			num = (short)1243868260;
			switch (num2 == num)
			{
			}
			num = (short)424804352;
			short num3 = num;
			num = (short)192282625;
			if (num != 0)
			{
			}
			num = (short)1316225024;
			if (num != 0)
			{
			}
			return packages.ConvertPackageTo<T, global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001B1AC File Offset: 0x000193AC
		public static global::Motorola.CommonCPS.Server.EntityModel.Package ToServerModel(this global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase)
		{
			if (packageBase != null)
			{
				short num = (short)770375681;
				if (num != 0)
				{
				}
				num = (short)1177566398;
				short num2 = num;
				num = (short)68500670;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_05;
				case 1:
					break;
				default:
				{
					num = (short)1989607424;
					short num3 = num;
					break;
				}
				}
				num = (short)2135293952;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.EntityModel.Package
				{
					Uuid = packageBase.Uuid,
					Timestamp = packageBase.Timestamp,
					Comment = packageBase.Comments
				};
			}
			IL_05:
			return new global::Motorola.CommonCPS.Server.EntityModel.Package();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001B288 File Offset: 0x00019488
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary)
		{
			int a_ = 10;
			short num = (short)1863319570;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)684785664;
					short num3 = num;
					num = (short)209125381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)708640778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)937754625;
					if (num != 0)
					{
					}
					if (!(packageSummary is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary))
					{
						num = (short)190316545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_197;
				case 3:
					goto IL_2E8;
				case 4:
					goto IL_378;
				case 5:
					if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary)
					{
						num = (short)245432326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1704263687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_34E;
				case 7:
					if (!(packageSummary is global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary))
					{
						num = (short)1871839248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 8:
					goto IL_1EE;
				case 9:
					if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)
					{
						num = (short)1918107656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)392167428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
					{
						num = (short)1364525067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1869021196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_2A9;
				case 12:
					if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary)
					{
						num = (short)529727502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A0;
				case 13:
					goto IL_39B;
				case 14:
					goto IL_26D;
				case 15:
					if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)
					{
						num = (short)214302723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1573453833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1590951953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
					{
						num = (short)740425747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2018967567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				case 19:
					goto IL_192;
				}
				IL_7D:
				if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary)
				{
					goto IL_19E;
				}
				num = (short)1749329619;
				short num4 = num;
				num = (short)236824275;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)682491904;
					if (num != 0)
					{
					}
					num = (short)989003776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_378:
				if (packageSummary is global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary)
				{
					num = (short)763953165;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1942880258;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_192:
			goto IL_353;
			IL_197:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack(packageSummary);
			IL_19E:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware(packageSummary);
			IL_1EE:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles(packageSummary);
			IL_26D:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage(packageSummary);
			IL_2A9:
			goto IL_197;
			IL_2E8:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates(packageSummary);
			IL_34E:
			goto IL_19E;
			IL_353:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement(packageSummary);
			IL_39B:
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech(packageSummary);
			IL_3A0:
			throw new global::System.NotSupportedException(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("焣䠥䌧䔩嬫䀭ု戱唳唵匷嬹嬻嬽怿ᙁ㵃㙅ⵇ", a_));
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001B648 File Offset: 0x00019848
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.Package rawData, bool setValidator = true)
		{
			short num = (short)1371340800;
			short num2 = num;
			num = (short)1867710465;
			if (num != 0)
			{
			}
			num = (short)132893660;
			short num3 = num;
			num = (short)1256115164;
			switch (num3 == num)
			{
			}
			num = (short)105709568;
			if (num != 0)
			{
			}
			return rawData.AutoConverToSummary().ToUiModel();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001B6FC File Offset: 0x000198FC
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary rawData, bool setValidator = true)
		{
			short num = (short)5701637;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate pcrtemplate;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate astrotemplate;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					pcrtemplate = new global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate(rawData as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary);
					num = (short)1997930500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					astrotemplate = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate(rawData as global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary);
					num = (short)1856700419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (rawData is global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary)
					{
						num = (short)476708865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 3:
					goto IL_8F;
				case 4:
					if (setValidator)
					{
						num = (short)183566342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22B;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 6:
				{
					num = (short)85524481;
					if (num != 0)
					{
					}
					num = (short)887095296;
					short num3 = num;
					pcrtemplate.a();
					num = (short)737411081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					astrotemplate.a();
					num = (short)666535495;
					short num4 = num;
					num = (short)336430663;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
						num = (short)1310720;
						if (num != 0)
						{
						}
						num = (short)1036779528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_226;
				case 9:
					goto IL_10A;
				}
				IL_4D:
				if (rawData is global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary)
				{
					num = (short)662241280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1011286018;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F:
				if (!setValidator)
				{
					goto IL_10F;
				}
				num = (short)1844903943;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10A:
			goto IL_22B;
			IL_10F:
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(astrotemplate);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(astrotemplate);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(astrotemplate, null);
			return astrotemplate;
			IL_226:
			goto IL_10F;
			IL_22B:
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(((global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary)rawData).LanguagePacksDetail, pcrtemplate);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(pcrtemplate);
			return pcrtemplate;
			IL_244:
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001B950 File Offset: 0x00019B50
		public static global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> ToUiModel(this global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> rawData, bool setValidator = true)
		{
			short num = (short)948436992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)182976513;
						if (num != 0)
						{
						}
						if (rawData == null)
						{
							goto IL_433;
						}
						num = (short)2004261946;
						short num3 = num;
						num = (short)413310010;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42E;
						default:
							num = (short)1792081920;
							if (num != 0)
							{
							}
							num = (short)2047475714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_42E;
					case 2:
						goto IL_40F;
					}
					goto IL_3A;
					IL_40F:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> enumerator = rawData.GetEnumerator();
					num = (short)1505427457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42E:
					try
					{
						num = (short)1786183681;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary;
							global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate pcrtemplate;
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate astrotemplate;
							switch (num2)
							{
							case 0:
								if (setValidator)
								{
									num = (short)517931021;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_183;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_17E;
								}
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1294336010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								templateSummary = enumerator.Current;
								num = (short)1661337606;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_324;
							case 4:
								goto IL_183;
							case 5:
								if (setValidator)
								{
									num = (short)354746375;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_281;
							case 6:
								if (templateSummary is global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary)
								{
									num = (short)1873215503;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_324;
							case 7:
								pcrtemplate.a();
								num = (short)529203208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_281;
							case 9:
								astrotemplate = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate(templateSummary as global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary);
								num = (short)795017216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								num = (short)539623438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								if (templateSummary is global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary)
								{
									num = (short)1283325961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 13:
								astrotemplate.a();
								num = (short)265945092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_3A0;
							case 15:
								pcrtemplate = new global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate(templateSummary as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary);
								num = (short)589430789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17E;
							IL_183:
							global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(astrotemplate);
							global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(astrotemplate);
							list.Add(astrotemplate);
							num = (short)291831819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_243:
							num = (short)1111359490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_17E:
							goto IL_243;
							IL_281:
							global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(((global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary)templateSummary).LanguagePacksDetail, pcrtemplate);
							global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(pcrtemplate);
							list.Add(pcrtemplate);
							num = (short)424738819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_324:
							num = (short)1184169996;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3A0:
						break;
					}
					finally
					{
						num = (short)306118656;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3D7;
								}
								continue;
							case 1:
								goto IL_40C;
							case 2:
								enumerator.Dispose();
								num = (short)1845755905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3D7:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1267597314;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_40C:;
					}
					goto IL_40F;
				}
				IL_433:
				global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(list.OfType<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate>());
				return list;
				IL_3A:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>();
				num = (short)171638784;
				short num4 = num;
				num = (short)1017577472;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001BDB8 File Offset: 0x00019FB8
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.Radio rawData, bool setValidator = true)
		{
			short num = (short)1294139393;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)229376001;
					if (num != 0)
					{
					}
					if (rawData is global::Motorola.CommonCPS.Server.EntityModel.APXRadio)
					{
						num = (short)1581252612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1047920642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
				{
					if (rawData is global::Motorola.CommonCPS.Server.EntityModel.PBBRadio)
					{
						num = (short)1815216133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)262059028;
					short num3 = num;
					num = (short)393393172;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C9;
					default:
						goto IL_191;
					}
					break;
				}
				case 3:
					goto IL_5C;
				case 4:
					goto IL_12C;
				case 5:
					goto IL_91;
				}
				IL_3C:
				if (rawData is global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio)
				{
					num = (short)438894595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C9:
				num = (short)1842151424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5C:
			return (rawData as global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio).ToSummary().ToUiModel(setValidator);
			IL_91:
			return (rawData as global::Motorola.CommonCPS.Server.EntityModel.PBBRadio).ToSummary().ToUiModel(setValidator);
			IL_12C:
			num = (short)1146028032;
			short num4 = num;
			return (rawData as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ToSummary().ToUiModel(setValidator);
			IL_191:
			num = (short)1810890752;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001BF6C File Offset: 0x0001A16C
		public static global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ToRadioSummary(global::Motorola.CommonCPS.Server.EntityModel.Radio rawData)
		{
			short num = (short)1874722817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1249902593;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (rawData is global::Motorola.CommonCPS.Server.EntityModel.APXRadio)
					{
						num = (short)1010434052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)620429314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 2:
				{
					if (rawData is global::Motorola.CommonCPS.Server.EntityModel.PBBRadio)
					{
						num = (short)2124414981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)365538664;
					short num3 = num;
					num = (short)1341107560;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						goto IL_17D;
					}
					break;
				}
				case 3:
					goto IL_81;
				case 4:
					goto IL_119;
				case 5:
					goto IL_BC;
				}
				IL_64:
				if (rawData is global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio)
				{
					num = (short)825032707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E2:
				num = (short)1941307392;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_81:
			return (rawData as global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio).ToSummary();
			IL_BC:
			return (rawData as global::Motorola.CommonCPS.Server.EntityModel.PBBRadio).ToSummary();
			IL_119:
			num = (short)2147287040;
			short num4 = num;
			return (rawData as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ToSummary();
			IL_17D:
			num = (short)119078912;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001C110 File Offset: 0x0001A310
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> ToUiModels(this global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> rawData, bool setValidator = true)
		{
			short num = (short)497352704;
			short num2 = num;
			num = (short)172607931;
			short num3 = num;
			num = (short)2094582203;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1849950208;
				if (num != 0)
				{
				}
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>.Enumerator enumerator = rawData.GetEnumerator();
				try
				{
					num = (short)74842112;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_BE;
							}
							continue;
						case 1:
							goto IL_139;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1010106372;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData2 = enumerator.Current;
							list.Add(rawData2.ToUiModel(setValidator));
							num = (short)1121255426;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)610205697;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EC:
						num = (short)711065603;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_BE:
						goto IL_EC;
					}
					IL_139:;
				}
				finally
				{
					num = (short)676528129;
					if (num != 0)
					{
					}
					((global::System.IDisposable)enumerator).Dispose();
				}
				break;
			}
			}
			return list;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001C2A0 File Offset: 0x0001A4A0
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData, bool setValidator = true)
		{
			short num = (short)1127415808;
			short num2 = num;
			num = (short)54129683;
			short num3 = num;
			num = (short)1368192019;
			switch (num3 == num)
			{
			}
			num = (short)1155596289;
			if (num != 0)
			{
			}
			num = (short)1626931200;
			if (num != 0)
			{
			}
			return rawData.ToUiModel(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance, setValidator);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001C354 File Offset: 0x0001A554
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData, global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer, bool setValidator = true)
		{
			short num = (short)2064580608;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					if (setValidator)
					{
						goto IL_C6;
					}
					goto IL_100;
				case 1:
					goto IL_100;
				case 2:
					radioBase.a(serviceContainer);
					num = (short)1005715457;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_44;
				IL_C6:
				num = (short)550305794;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_100:
				num = (short)185486869;
				short num4 = num;
				num = (short)511725077;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C6;
				default:
					goto IL_136;
				}
			}
			IL_136:
			num = (short)191102977;
			if (num != 0)
			{
			}
			num = (short)1462763520;
			if (num != 0)
			{
			}
			rawData.CFS = null;
			return radioBase;
			IL_44:
			radioBase = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(rawData);
			radioBase.GroupName = serviceContainer.GroupService.GetGroupFullPath(rawData.GroupUuid);
			radioBase.UIJobStatus = global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterServerJobStatusToUiJobStatus(radioBase.JobStatus, radioBase.CruncherStatus, radioBase.JobType);
			radioBase.RadioFeatureSet = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>();
			radioBase.UIRadioFeatureSet = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>();
			radioBase.ExtendedRadioFeatureSet = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>();
			radioBase.UIExtendedRadioFeatureSet = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>();
			num = (short)904003584;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary A_0)
		{
			short num = (short)1907228672;
			short num2 = num;
			num = (short)369014418;
			short num3 = num;
			num = (short)1710864018;
			switch (num3 == num)
			{
			}
			num = (short)1384185856;
			if (num != 0)
			{
			}
			num = (short)1120206849;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio(A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary);
			radioBase.IsLoading = true;
			radioBase = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary, radioBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
			radioBase.IsLoading = false;
			radioBase.LanguagePacksInfo = global::Motorola.CommonCPS.RadioManagement.ModelConvertor.LanguageSettingConverter.Convert2UIDispaly((A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary).LanguageSetting, A_0);
			radioBase.VAFiles = (string.IsNullOrEmpty((A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary).VASetting) ? string.Empty : string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_VA_Files, (A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary).VASetting));
			return radioBase;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001C60C File Offset: 0x0001A80C
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase EditLocalRadio(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase oldDevice, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues)
		{
			short num = (short)407659228;
			short num2 = num;
			num = (short)255288028;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)41091072;
				if (num != 0)
				{
				}
				num = (short)1497432064;
				switch (num)
				{
				default:
				{
					num = (short)1957429248;
					short num3 = num;
					radioSummary = oldDevice.ToEntity();
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> enumerator = fieldValues.GetEnumerator();
					try
					{
						num = (short)780795904;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_DB;
								}
								continue;
							case 1:
								goto IL_19F;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1290207233;
									if (num != 0)
									{
									}
									num = (short)1449852932;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object> keyValuePair = enumerator.Current;
								radioSummary.GetType().GetProperty(keyValuePair.Key.ToString()).SetValue(radioSummary, keyValuePair.Value);
								num = (short)129761282;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)670367745;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_128:
							num = (short)1246429187;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_DB:
							goto IL_128;
						}
						IL_19F:;
					}
					finally
					{
						num = (short)1530986496;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1D5;
								}
								continue;
							case 1:
								goto IL_20C;
							case 2:
								enumerator.Dispose();
								num = (short)1858011137;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1D5:
							if (enumerator == null)
							{
								break;
							}
							num = (short)192544770;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_20C:;
					}
					break;
				}
				}
				break;
			}
			return radioSummary.ToUiModel(true);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001C84C File Offset: 0x0001AA4C
		public static void GetRadioFeatureList(this global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawRd, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase localRd)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			string cfs;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)462618627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1325465600;
					short num3 = num2;
					if (string.IsNullOrEmpty(cfs))
					{
						num2 = (short)119930882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection optionsCollection = global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection.DeserializeFromXML(cfs);
					num2 = (short)1042087940;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				case 3:
				{
					global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection optionsCollection;
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> collection = optionsCollection.OptionsList.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.<>c.<>9.a));
					(localRd as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).LicensedFeatureList = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>(collection);
					num2 = (short)1307770885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)1568355869;
					short num4 = num2;
					num2 = (short)340669981;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)742916097;
						if (num2 != 0)
						{
						}
						num2 = (short)199622656;
						if (num2 != 0)
						{
						}
						if (rawRd is global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary)
						{
							num2 = (short)1523580928;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 5:
					return;
				}
				goto IL_28;
			}
			return;
			IL_28:
			cfs = rawRd.CFS;
			num2 = (short)703528961;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001CA14 File Offset: 0x0001AC14
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType? GetAPXRadioType(this global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawRd)
		{
			short num = (short)174568690;
			short num2 = num;
			num = (short)375895282;
			global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType? result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F5:
				result = (rawRd as global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary).APXRadioType;
				num = (short)1594490882;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1550647296;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_80:
				switch (num3)
				{
				case 0:
					goto IL_F5;
				case 1:
					if (rawRd is global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary)
					{
						num = (short)1153433600;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					return result;
				}
				goto IL_92;
			}
			return result;
			IL_5F:
			num = (short)1419509760;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_92;
			}
			goto IL_80;
			IL_92:
			num = (short)357498881;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1471807489;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_80;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001CB40 File Offset: 0x0001AD40
		public static global::Motorola.CommonCPS.Server.EntityModel.Radio ToServerModel(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase localData)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Guid? guid;
				switch (num)
				{
				case 0:
					return radio;
				case 1:
				{
					num2 = (short)1003861445;
					short num3 = num2;
					num2 = (short)1724167621;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_264;
					default:
						num2 = (short)1100087296;
						if (num2 != 0)
						{
						}
						radio = new global::Motorola.CommonCPS.Server.EntityModel.APXRadio();
						radio.WorkingCodeplug = new global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug();
						num2 = (short)1448149000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (localData is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
					{
						num2 = (short)16318465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return radio;
				case 3:
					goto IL_264;
				case 4:
					if (guid != null)
					{
						num2 = (short)196608009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C1;
				case 5:
					goto IL_295;
				case 6:
					goto IL_1C1;
				case 7:
					guid = localData.WorkingTemplateUuid;
					num2 = (short)334823428;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (string.IsNullOrEmpty(localData.ConfigurationName))
					{
						num2 = (short)489160704;
						short num4 = num2;
						num2 = (short)1657602051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_295;
				case 9:
					goto IL_269;
				case 10:
					if (guid != null)
					{
						num2 = (short)723779585;
						if (num2 != 0)
						{
						}
						num2 = (short)1283981317;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_112;
				case 11:
					if (string.IsNullOrEmpty(localData.TemplateName))
					{
						num2 = (short)1430126599;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_269;
				case 12:
					goto IL_112;
				}
				goto IL_44;
				IL_112:
				num2 = (short)1368457227;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C1:
				global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio, localData as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
				num2 = (short)1920335872;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_264:
				guid = localData.WorkingConfigurationUuid;
				num2 = (short)1552678922;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_269:
				radio.WorkingCodeplug.Template = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
				num2 = (short)1928396806;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_295:
				radio.WorkingCodeplug.Configuration = new global::Motorola.CommonCPS.Server.EntityModel.Configuration();
				num2 = (short)1868234764;
				num = (int)((global::System.IntPtr)num2);
			}
			return radio;
			IL_44:
			radio = null;
			num2 = (short)710410242;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001CE10 File Offset: 0x0001B010
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary rawData, bool setValidator = true)
		{
			short num = (short)476655738;
			short num2 = num;
			num = (short)1412640890;
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EB:
				astroSystem.a();
				num = (short)2080047106;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)719257600;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_A6:
				switch (num3)
				{
				case 0:
					goto IL_EB;
				case 1:
					if (setValidator)
					{
						num = (short)512098304;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return astroSystem;
				case 2:
					return astroSystem;
				}
				goto IL_B8;
			}
			return astroSystem;
			IL_5F:
			num = (short)882442241;
			if (num != 0)
			{
			}
			num = (short)825032704;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			goto IL_A6;
			IL_B8:
			astroSystem = new global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem(rawData);
			num = (short)303235073;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A6;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001CF28 File Offset: 0x0001B128
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem rawData, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			short num = (short)494256489;
			short num2 = num;
			num = (short)1835843945;
			switch (num2 == num)
			{
			}
			num = (short)70713344;
			short num3 = num;
			num = (short)442892289;
			if (num != 0)
			{
			}
			num = (short)862584832;
			if (num != 0)
			{
			}
			return rawData.ToSummary(radio).ToUiModel(true);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary rawData)
		{
			short num = (short)609088341;
			short num2 = num;
			num = (short)1145566037;
			switch (num2 == num)
			{
			}
			num = (short)1664155648;
			short num3 = num;
			num = (short)881131520;
			if (num != 0)
			{
			}
			num = (short)32636929;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo(rawData);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001D090 File Offset: 0x0001B290
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary rawData)
		{
			short num = (short)1033989895;
			short num2 = num;
			num = (short)2134732551;
			switch (num2 == num)
			{
			}
			num = (short)1126957056;
			short num3 = num;
			num = (short)400031745;
			if (num != 0)
			{
			}
			num = (short)1273430016;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo(rawData);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001D140 File Offset: 0x0001B340
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary rawData, bool setValidator = true)
		{
			short num = (short)1233387521;
			if (num != 0)
			{
			}
			num = (short)226689024;
			short num2 = num;
			num = (short)273018711;
			short num3 = num;
			num = (short)1951461207;
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EE:
				astroDataProfile.a();
				num = (short)1691287554;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1944911872;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BB;
				}
				break;
			}
			for (;;)
			{
				IL_A9:
				switch (num4)
				{
				case 0:
					goto IL_EE;
				case 1:
					if (setValidator)
					{
						num = (short)851902464;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return astroDataProfile;
				case 2:
					return astroDataProfile;
				}
				goto IL_BB;
			}
			return astroDataProfile;
			IL_BB:
			astroDataProfile = new global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile(rawData);
			num = (short)1614217217;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A9;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001D25C File Offset: 0x0001B45C
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo rawData)
		{
			short num = (short)1464113113;
			short num2 = num;
			num = (short)601659353;
			switch (num2 == num)
			{
			}
			num = (short)630521856;
			short num3 = num;
			num = (short)672268289;
			if (num != 0)
			{
			}
			num = (short)2052390912;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo(rawData);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001D30C File Offset: 0x0001B50C
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary rawData)
		{
			short num = (short)643880624;
			short num2 = num;
			num = (short)429512368;
			switch (num2 == num)
			{
			}
			num = (short)488439808;
			short num3 = num;
			num = (short)392232961;
			if (num != 0)
			{
			}
			num = (short)1368260608;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo(rawData);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001D3BC File Offset: 0x0001B5BC
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
			for (;;)
			{
				IL_0A:
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				switch (num)
				{
				case 0:
					if (radio.LastJob != null)
					{
						num2 = (short)866058248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_280;
				case 1:
				{
					num2 = (short)939491232;
					short num3 = num2;
					num2 = (short)983859104;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_262;
					default:
						num2 = (short)776798208;
						if (num2 != 0)
						{
						}
						num2 = (short)1906311168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (radio != null)
					{
						num2 = (short)1908473857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 3:
					goto IL_1C4;
				case 4:
					if (apxcodeplug.Template != null)
					{
						num2 = (short)782893065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C4;
				case 5:
					goto IL_1E8;
				case 6:
					if (radio.WorkingCodeplug != null)
					{
						num2 = (short)647495692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 7:
					astroDataProfile.RadioAlias = apxcodeplug.RadioAlias;
					num2 = (short)598016001;
					if (num2 != 0)
					{
					}
					num2 = (short)266731524;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					astroDataProfile.JobStatus = new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(radio.LastJob.JobStatus);
					num2 = (short)103874570;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)1060962304;
					short num4 = num2;
					astroDataProfile.TemplateName = apxcodeplug.Template.Name;
					goto IL_262;
				}
				case 10:
					goto IL_280;
				case 11:
					if (apxcodeplug != null)
					{
						num2 = (short)1828716551;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 12:
					apxcodeplug = (radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num2 = (short)867500043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_44;
				IL_1C4:
				astroDataProfile.BluetoothEnable = apxcodeplug.BluetoothEnable;
				num2 = (short)1667694597;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_262:
				num2 = (short)107282435;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_280:
				astroDataProfile.DeviceID = new global::System.Guid?(radio.Uuid);
				astroDataProfile.RadioStatus = new global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)radio.RadioStatus);
				astroDataProfile.SerialNumber = radio.SerialNumber;
				num2 = (short)1877671942;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1E8:
			IL_2E9:
			astroDataProfile.IsLoading = false;
			return astroDataProfile;
			IL_44:
			astroDataProfile = apxDataProfile.ToSummary().ToUiModel(true);
			astroDataProfile.IsLoading = true;
			num2 = (short)2124218370;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO rawData, bool setValidator = true)
		{
			short num = (short)192975408;
			short num2 = num;
			num = (short)1754108464;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C3:
				astrootarProfile.a();
				num = (short)1824260097;
				if (num != 0)
				{
				}
				num = (short)1897725954;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)778829824;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_7E:
				switch (num3)
				{
				case 0:
					goto IL_C3;
				case 1:
					if (setValidator)
					{
						num = (short)1695612928;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return astrootarProfile;
				case 2:
					return astrootarProfile;
				}
				goto IL_90;
			}
			return astrootarProfile;
			IL_5E:
			num = (short)88276992;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			goto IL_7E;
			IL_90:
			astrootarProfile = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile(rawData);
			num = (short)321650689;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001D7D4 File Offset: 0x0001B9D4
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO rawData)
		{
			short num = (short)895568589;
			short num2 = num;
			num = (short)392645325;
			switch (num2 == num)
			{
			}
			num = (short)759562240;
			short num3 = num;
			num = (short)2141323264;
			if (num != 0)
			{
			}
			num = (short)1698955265;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo(rawData);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001D884 File Offset: 0x0001BA84
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO rawData)
		{
			short num = (short)1178050315;
			short num2 = num;
			num = (short)1429708555;
			switch (num2 == num)
			{
			}
			num = (short)1897922560;
			short num3 = num;
			num = (short)1962803201;
			if (num != 0)
			{
			}
			num = (short)1507328000;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo(rawData);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001D934 File Offset: 0x0001BB34
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxOtarProfile, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			short num = (short)1388576769;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			int num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					goto IL_207;
				case 1:
					if (radio != null)
					{
						num = (short)159383555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
					num = (short)1381367808;
					short num3 = num;
					num = (short)177405957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					astrootarProfile.RadioID = new global::System.Guid?(radio.Uuid);
					astrootarProfile.SerialNumber = radio.SerialNumber;
					num = (short)10485769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					astrootarProfile.TemplateName = apxcodeplug.Template.Name;
					num = (short)200081419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					if (apxcodeplug != null)
					{
						num = (short)232849414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				}
				case 6:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					astrootarProfile.RadioAlias = apxcodeplug.RadioAlias;
					num = (short)268173322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					num = (short)537739203;
					short num4 = num;
					num = (short)275267523;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)886767616;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						if (apxcodeplug.Configuration != null)
						{
							num = (short)2137456648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A7;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					astrootarProfile.ConfigurationName = apxcodeplug.Configuration.Name;
					num = (short)1202323456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (radio.WorkingCodeplug != null)
					{
						num = (short)1583742978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				case 10:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					if (apxcodeplug.Template != null)
					{
						num = (short)2555908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
				}
				case 11:
					goto IL_AF;
				}
				goto IL_67;
				IL_AF:
				num = (short)433258503;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_207:
			IL_2A7:
			astrootarProfile.IsLoading = false;
			return astrootarProfile;
			IL_67:
			astrootarProfile = apxOtarProfile.ToDto().ToUiModel(false);
			astrootarProfile.IsLoading = true;
			num = (short)1214709761;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001DBF0 File Offset: 0x0001BDF0
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jobContainerSummarie)
		{
			short num = (short)1500331997;
			short num2 = num;
			num = (short)707608541;
			switch (num2 == num)
			{
			}
			num = (short)2080768000;
			short num3 = num;
			num = (short)895746048;
			if (num != 0)
			{
			}
			num = (short)1940914177;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer(jobContainerSummarie);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity jobSum)
		{
			short num = (short)1543569409;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase jobBase;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)698635329;
					short num3 = num;
					num = (short)911955009;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)5308417;
						if (num != 0)
						{
						}
						num = (short)933560320;
						if (num != 0)
						{
						}
						if (jobSum is global::Motorola.CommonCPS.Server.EntityModel.BatchOpJobViewSummary)
						{
							num = (short)1518141443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					jobBase = new global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob(jobSum as global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary);
					num = (short)967180293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					jobBase = new global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob(jobSum as global::Motorola.CommonCPS.Server.EntityModel.BatchOpJobViewSummary);
					num = (short)371916804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_A9;
				case 5:
					goto IL_183;
				}
				IL_3C:
				if (jobSum is global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary)
				{
					num = (short)1797849088;
					short num4 = num;
					num = (short)203292674;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)230948864;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A9:
			IL_183:
			goto IL_18B;
			IL_185:
			throw new global::System.NotImplementedException();
			IL_18B:
			jobBase.UIJobStatus = global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterServerJobStatusToUiJobStatus(new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(jobSum.JobStatus), new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(jobSum.CruncherStatus), new global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?(jobSum.JobType));
			jobBase.Reason = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(jobSum.Parameters, jobSum.ErrorCode, jobSum.ErrorMessage, jobSum.WarningMessage, jobSum.InformationMessage);
			return jobBase;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001DE90 File Offset: 0x0001C090
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob rawData)
		{
			short num = (short)793976761;
			short num2 = num;
			num = (short)518004665;
			switch (num2 == num)
			{
			}
			num = (short)653131776;
			short num3 = num;
			num = (short)288489472;
			if (num != 0)
			{
			}
			num = (short)1485307905;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob(rawData)
			{
				JobStatus = global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterServerJobStatusToUiJobStatus(new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(rawData.JobStatus), new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(rawData.CruncherStatus), new global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?(rawData.JobContainer.JobType)),
				Reason = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(rawData.Parameters, rawData.ErrorCode, rawData.ErrorMessage, rawData.WarningMessage, rawData.InformationMessage)
			};
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001DF9C File Offset: 0x0001C19C
		public static global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob ToServerModel(this global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob localData)
		{
			short num = (short)2102536278;
			short num2 = num;
			num = (short)427632726;
			switch (num2 == num)
			{
			}
			num = (short)21757952;
			short num3 = num;
			num = (short)337248257;
			if (num != 0)
			{
			}
			num = (short)74514432;
			if (num != 0)
			{
			}
			return localData.RawData;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001E050 File Offset: 0x0001C250
		public static global::Motorola.CommonCPS.Server.EntityModel.Radio ToServerModel(this global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetail)
		{
			short num = (short)394256400;
			short num2 = num;
			num = (short)696639504;
			switch (num2 == num)
			{
			}
			num = (short)927662080;
			short num3 = num;
			num = (short)178585601;
			if (num != 0)
			{
			}
			num = (short)48168960;
			if (num != 0)
			{
			}
			return radioDetail.Radio;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		public static global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection ToServerModel(this global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> options)
		{
			short num = (short)471597056;
			short num2 = num;
			global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection optionsCollection = new global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Option> enumerator = options.GetEnumerator();
			try
			{
				num = (short)1920860161;
				if (num != 0)
				{
				}
				num = (short)1628635137;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)75465244;
						short num4 = num;
						num = (short)1572110876;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_76;
						default:
						{
							num = (short)1747058688;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)612499458;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.Option option = enumerator.Current;
							optionsCollection.OptionsList.Add(option.ToServerModel());
							num = (short)797507587;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_76;
					case 2:
						num = (short)1827930116;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_167;
					}
					goto IL_9A;
					IL_76:
					switch (0)
					{
					case 0:
						IL_9A:
						goto IL_CB;
					}
					continue;
					IL_CB:
					num = (short)593494016;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_167:;
			}
			finally
			{
				num = (short)835649537;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)2079588354;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_19A;
						}
						continue;
					case 2:
						goto IL_1D0;
					}
					IL_19A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1967063040;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D0:;
			}
			return optionsCollection;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		public static global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem ToServerModel(this global::Motorola.CommonCPS.RadioManagement.UIModels.Option option)
		{
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem optionDesItem;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_10A;
					case 1:
						num2 = (short)521994245;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_191;
					case 3:
						goto IL_E7;
					case 4:
						if (option.IsActive)
						{
							num2 = (short)1341063169;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)630784001;
						if (num2 != 0)
						{
						}
						optionDesItem.OptionStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_DISABLED;
						num2 = (short)1114374146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
					{
						if (option.Editable)
						{
							num2 = (short)846462982;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1287734875;
						short num3 = num2;
						num2 = (short)1974290011;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)70516736;
							if (num2 != 0)
							{
							}
							optionDesItem.OptionStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.FREE;
							num2 = (short)1339228163;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 6:
						optionDesItem.OptionStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_ENABLED;
						num2 = (short)1979121664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_2C:
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition optionID = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ASTRO_OptionIDDefinition(option.ResourceID);
				optionDesItem = new global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem(option.OptionTag, optionID, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None);
				num2 = (short)622985220;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_E7:
			IL_10A:
			return optionDesItem;
			IL_191:
			num2 = (short)1822359552;
			short num4 = num2;
			return optionDesItem;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.Option ToUIModel(this global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem option)
		{
			short num = (short)1244266497;
			if (num != 0)
			{
			}
			num = (short)329475768;
			short num2 = num;
			num = (short)275670712;
			switch (num2 == num)
			{
			default:
			{
				num = (short)4587520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)548143104;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.Option(option.OptionTag, option.OptionID.ResourceID)
			{
				OptionTag = option.OptionTag,
				ResourceID = option.OptionID.ResourceID,
				Editable = option.Editable,
				IsActive = option.IsActive,
				Visible = option.Visible,
				DisplayStatus = global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(option.OptionStatus.ToString(), null),
				DisplayName = global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(option.OptionID.ResourceID, null)
			};
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001E608 File Offset: 0x0001C808
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase ToUiModel(this global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest rawData)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A9;
				case 1:
					radioBase = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio();
					global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(rawData as global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest, radioBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
					num2 = (short)421789698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return radioBase;
				}
				goto IL_1C;
			}
			IL_A9:
			num2 = (short)418381825;
			if (num2 != 0)
			{
			}
			if (rawData is global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest)
			{
				goto IL_D8;
			}
			return radioBase;
			IL_1C:
			radioBase = null;
			num2 = (short)1975835307;
			short num3 = num2;
			num2 = (short)749001387;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D8:
				num2 = (short)1659371521;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)743768064;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)885391360;
			if (num2 != 0)
			{
			}
			num2 = (short)695271424;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001E73C File Offset: 0x0001C93C
		public static global::Motorola.CommonCPS.Server.EntityModel.Radio UpdateRadioFromCSVRequest(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest request, global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio2;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return radio2;
				case 1:
				{
					num2 = (short)940812480;
					short num3 = num2;
					num2 = (short)825272512;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						num2 = (short)514654208;
						if (num2 != 0)
						{
						}
						goto IL_8A;
					}
					break;
				}
				case 2:
					num2 = (short)246022145;
					if (num2 != 0)
					{
					}
					radio2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.Clone<global::Motorola.CommonCPS.Server.EntityModel.APXRadio>(radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
					num2 = (short)683147269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (request is global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest)
					{
						num2 = (short)1123418114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return radio2;
				case 4:
					radio2.WorkingCodeplug = new global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug();
					num2 = (short)2008743937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (radio2.WorkingCodeplug == null)
					{
						num2 = (short)823656452;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8A;
				}
				goto IL_28;
				IL_8A:
				global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(request as global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest, radio2 as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
				num2 = (short)1641742336;
				short num4 = num2;
				num2 = (short)292683776;
				num = (int)((global::System.IntPtr)num2);
			}
			return radio2;
			IL_28:
			radio2 = null;
			num2 = (short)1177026563;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		public static global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo ToEntityMode(this global::Motorola.CommonCPS.RadioManagement.Global.DBMigrationInfo dbMigrationInfo)
		{
			short num = (short)578916812;
			short num2 = num;
			num = (short)1482789324;
			switch (num2 == num)
			{
			}
			num = (short)2127822848;
			short num3 = num;
			num = (short)1606877185;
			if (num != 0)
			{
			}
			num = (short)146079744;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo
			{
				Version = dbMigrationInfo.LegacyDBVersion,
				MigrationStatus = (global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus)dbMigrationInfo.CurrentProgress
			};
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		private static void a(string A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate A_1)
		{
			int a_ = 16;
			short num = (short)748421120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_61;
				}
				string text;
				global::System.Xml.XmlDocument xmlDocument;
				for (;;)
				{
					IL_32:
					global::System.Xml.XmlNode documentElement;
					switch (num2)
					{
					case 0:
						goto IL_112;
					case 1:
						A_1.LanguagePacks = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>();
						num = (short)755040258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_43B;
					case 3:
						num = (short)550895622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (documentElement == null)
						{
							num = (short)277086216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Xml.XmlNodeList xmlNodeList = documentElement.SelectNodes(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ԩ怫伭帯唱䄳圵強弹氻弽⌿⥁㝃楅ే⽉㡋⽍㥏㹑", a_));
						text = string.Empty;
						num = (short)1458765833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_547;
					case 6:
						if (A_1.LanguagePacks == null)
						{
							num = (short)1185021953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43B;
					case 7:
						if (!string.IsNullOrEmpty(A_0))
						{
							num = (short)784662531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54C;
					case 8:
						return;
					case 9:
					{
						num = (short)1205207040;
						short num3 = num;
						global::System.Xml.XmlNodeList xmlNodeList;
						if (xmlNodeList != null)
						{
							num = (short)692518917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42E;
					}
					}
					goto IL_61;
					IL_43B:
					num = (short)1958936577;
					if (num != 0)
					{
					}
					A_0 = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᘩጫ嘭崯帱ᐳ䀵崷䠹伻圽⼿ⱁ祃摅祇摉籋汍潏汑桓ᩕ㥗㑙㭛⭝şաţ㙥१३ݫᵭ乯", a_) + A_0 + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᘩ̫戭儯就匳䌵夷崹夻渽ℿ⅁⽃㕅癇", a_);
					xmlDocument.LoadXml(A_0);
					documentElement = xmlDocument.DocumentElement;
					num = (short)1042546692;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_112:
				try
				{
					num = (short)1676869640;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Xml.XmlElement xmlElement;
							if (xmlElement != null)
							{
								num = (short)761135111;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							global::System.Xml.XmlElement xmlElement2;
							if (xmlElement2 != null)
							{
								num = (short)231407618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Xml.XmlElement xmlElement = xmlNode[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("稩䴫䴭嬯匱匳匵瘷嬹儻嬽", a_)];
							num = (short)737214464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1999110148;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							global::System.Xml.XmlElement xmlElement2 = xmlNode[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("稩䴫䴭嬯匱匳匵焷縹", a_)];
							num = (short)1869086721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)850591750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Xml.XmlElement xmlElement3;
							if (xmlElement3 != null)
							{
								num = (short)689373193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_3B3;
						case 7:
						{
							global::System.Xml.XmlNode xmlNode;
							global::System.Xml.XmlElement xmlElement3 = xmlNode[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("稩䴫䴭嬯匱匳匵渷弹主䴽⤿ⵁ⩃", a_)];
							global::System.Xml.XmlElement xmlElement;
							text = text + xmlElement.InnerText + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ة", a_);
							num = (short)1836449797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_1E8;
							}
							continue;
						case 9:
						{
							global::System.Xml.XmlElement xmlElement;
							global::System.Xml.XmlElement xmlElement2;
							global::System.Xml.XmlElement xmlElement3;
							A_1.LanguagePacks.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo
							{
								PackageName = xmlElement.InnerText,
								PackageID = xmlElement2.InnerText,
								PackageVersion = xmlElement3.InnerText
							});
							num = (short)29229066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1ED:
						num = (short)728170499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E8:
						goto IL_1ED;
					}
					IL_3B3:
					goto IL_13F;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_3D5;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_3C2:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)182059009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42D;
						case 1:
							disposable.Dispose();
							num = (short)1248526338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_42B;
						}
						goto IL_3D5;
					}
					IL_42B:
					IL_42D:
					goto EndFinally_12;
					IL_3D5:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1918763008;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3C2;
					EndFinally_12:;
				}
				goto IL_42E;
				IL_13F:
				A_1.LanguagePacksInfo = text.TrimEnd(new char[]
				{
					','
				});
				return;
				IL_42E:
				A_1.LanguagePacksInfo = string.Empty;
				return;
				IL_547:
				goto IL_F1;
				IL_54C:
				A_1.LanguagePacksInfo = string.Empty;
				return;
				IL_61:
				xmlDocument = new global::System.Xml.XmlDocument();
				num = (short)1367552459;
				short num4 = num;
				num = (short)558969291;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F1:
					global::System.Xml.XmlNodeList xmlNodeList;
					global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
					num = (short)1928003584;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				default:
					num = (short)1431109632;
					if (num != 0)
					{
					}
					num = (short)1429864455;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				break;
			}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001EF30 File Offset: 0x0001D130
		private static void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate A_0)
		{
			short num = (short)210657252;
			short num2 = num;
			num = (short)163405796;
			switch (num2 == num)
			{
			}
			num = (short)951648256;
			short num3 = num;
			num = (short)392364033;
			if (num != 0)
			{
			}
			num = (short)1797783552;
			if (num != 0)
			{
			}
			int? cplanguageIndex = A_0.CPLanguageIndex;
			string lpID = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroDecodeLanguageIndexToLPID(cplanguageIndex);
			string resourceID = global::CommonUtility.ASTROLanguageUtility.Instance.ConvertLPID2LanguageID(lpID);
			A_0.LanguagePacksInfo = global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(resourceID, null);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001F00C File Offset: 0x0001D20C
		private static void a(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
		{
			short num = (short)1651367302;
			short num2 = num;
			num = (short)606526854;
			switch (num2 == num)
			{
			}
			num = (short)565641216;
			short num3 = num;
			num = (short)1079640065;
			if (num != 0)
			{
			}
			num = (short)385089536;
			if (num != 0)
			{
			}
			A_0.VAFiles = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_VA_Files, A_0.VATotalCount);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
		private static void a(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> A_1 = null)
		{
			short num = (short)1134821376;
			switch (num)
			{
			default:
			{
				num = (short)1564147713;
				if (num != 0)
				{
				}
				num = (short)64421890;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> observableCollection;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_FF;
					case 1:
						A_1 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles, null);
						num = (short)215416836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 3:
						try
						{
							num = (short)2041249797;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto astrodvrsfileDto;
									observableCollection.Add(astrodvrsfileDto.Equals(A_0.DVRSFile) ? A_0.DVRSFile : astrodvrsfileDto);
									num = (short)78118919;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary;
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto astrodvrsfileDto = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto(astrodvrsfilesSummary, A_0.Name);
									num = (short)1390280704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1634140166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = (global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)enumerator.Current;
									num = (short)1302462468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_30C;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary;
									if (A_0.DVRSHashCodeLong == astrodvrsfilesSummary.DVRSFileHash.Value)
									{
										num = (short)479920129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1F7;
									}
									continue;
								case 6:
									num = (short)1737031683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_292:
								num = (short)1310261250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F7:
								goto IL_292;
							}
							IL_30C:
							goto IL_E7;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_31F;
						IL_E7:
						num = (short)1807089664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_141;
					}
					IL_7E:
					num = (short)1080141401;
					short num3 = num;
					num = (short)469542489;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)513867776;
						if (num != 0)
						{
						}
						if (A_1 == null)
						{
							num = (short)223477761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_141:
					observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>();
					enumerator = A_1.GetEnumerator();
					num = (short)1449721859;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				num = (short)1722089472;
				short num4 = num;
				global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> collection = observableCollection;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto item = (A_0.DVRSFile.Uuid == global::System.Guid.Empty) ? A_0.DVRSFile : new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto(A_0.Name);
				IL_31F:
				collection.Add(item);
				A_0.DVRSFiles = observableCollection;
				return;
			}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001F42C File Offset: 0x0001D62C
		private static void a(global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> A_0)
		{
			short num = (short)901316609;
			if (num != 0)
			{
			}
			num = (short)1784511323;
			short num2 = num;
			num = (short)682589019;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)900071424;
				short num3 = num;
				break;
			}
			}
			num = (short)2052980736;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> a_ = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles, null);
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)1912930306;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)198049795;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(enumerator.Current, a_);
						num = (short)868220929;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_ED;
						}
						continue;
					case 3:
						num = (short)655884292;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_15E;
					}
					IL_113:
					num = (short)2120220672;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED:
					goto IL_113;
				}
				IL_15E:;
			}
			finally
			{
				num = (short)1259274240;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_192;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1691811842;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1C7;
					}
					IL_192:
					if (enumerator == null)
					{
						break;
					}
					num = (short)5505025;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1C7:;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001F614 File Offset: 0x0001D814
		private static global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a a(string A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_1)
		{
			short num = (short)2067660807;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1374814208;
					short num3 = num;
					if (global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a.Keys.Contains(A_0))
					{
						num = (short)369819650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24F;
				}
				case 1:
					num = (short)1312620544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)49545225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_6C;
				case 4:
					if (A_1.ConfigurationOptionList == null)
					{
						num = (short)3604488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(A_1.ConfigurationOptionList, A_1);
					num = (short)2113077254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_24B;
				case 6:
				{
					num = (short)1719951246;
					short num4 = num;
					num = (short)1087594382;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DC;
					default:
						num = (short)69664768;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1695154177;
							if (num != 0)
							{
							}
							num = (short)912130049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24F;
					}
					break;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 8:
					goto IL_1DA;
				case 9:
					if (global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a[A_0].Keys.Contains(text))
					{
						num = (short)177537029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24F;
				}
				IL_4C:
				if (string.IsNullOrEmpty(A_0))
				{
					num = (short)87818243;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1541865476;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6C:
			return null;
			IL_1DA:
			return null;
			IL_1DC:
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a a = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a[A_0][text];
			return global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a[A_0][text];
			IL_24B:
			goto IL_1DC;
			IL_24F:
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001F874 File Offset: 0x0001DA74
		private static string a(global::System.Collections.Generic.List<int> A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_1)
		{
			int a_ = 8;
			short num;
			string result;
			for (;;)
			{
				IL_09:
				num = (short)1343881220;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (A_1 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
						{
							num = (short)281280517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					case 1:
						num = (short)428736518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1A6;
					case 3:
						return result;
					case 4:
						num = (short)1222770689;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 5:
					{
						string str;
						result = A_1.ModelNumber + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤡ", a_) + str;
						num = (short)1326505867;
						short num3 = num;
						num = (short)5431179;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1122500608;
							if (num != 0)
							{
							}
							num = (short)1232011267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						if (A_0.Count == 0)
						{
							num = (short)1109655554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0.Sort();
						string str = string.Join<int>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ม", a_), A_0);
						result = string.Empty;
						num = (short)1559756800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_70:
					if (A_0 == null)
					{
						goto IL_1AA;
					}
					num = (short)1455226881;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return result;
			IL_1A6:
			goto IL_1AA;
			IL_1A8:
			return null;
			IL_1AA:
			num = (short)1392836608;
			short num4 = num;
			return null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001FA58 File Offset: 0x0001DC58
		private static void a(string A_0, global::System.Collections.Generic.List<int> A_1, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_2)
		{
			short num = (short)1693843458;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a a;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.Count == 0)
					{
						num = (short)1755774984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(A_1, A_2);
					num = (short)310575109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a[A_0].TryAdd(text, a);
					num = (short)564985868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 3:
					if (A_1 != null)
					{
						num = (short)1139408905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (!global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a.Keys.Contains(A_0))
					{
						num = (short)2057502731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)32571399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)141295622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
				{
					a = new global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a();
					a.e(A_2.MismatchFlags);
					a.e(A_2.RadioFeatureSet);
					a.e(A_2.RadioOptionCollection);
					a.e(A_2.MismatchOptionList);
					num = (short)65732608;
					short num3 = num;
					num = (short)1366938421;
					short num4 = num;
					num = (short)618386229;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						num = (short)579272705;
						if (num != 0)
						{
						}
						num = (short)509214720;
						if (num != 0)
						{
						}
						num = (short)1059192836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (!global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a[A_0].Keys.Contains(text))
					{
						num = (short)750911489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_2EA;
				case 9:
					num = (short)1610153984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return;
				case 11:
					goto IL_27D;
				case 12:
					goto IL_2AC;
				}
				goto IL_58;
				IL_60:
				num = (short)743243786;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58:
				if (string.IsNullOrEmpty(A_0))
				{
					goto IL_60;
				}
				num = (short)985726979;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_27D:
			global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a> concurrentDictionary = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a>();
			concurrentDictionary.TryAdd(text, a);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a.TryAdd(A_0, concurrentDictionary);
			return;
			IL_2AC:
			return;
			IL_2EA:;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001FD54 File Offset: 0x0001DF54
		private static global::Motorola.CommonCPS.Server.EntityModel.Radio a(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest A_0, global::Motorola.CommonCPS.Server.EntityModel.Radio A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.b b;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (string.IsNullOrEmpty(b.a.GroupName))
					{
						num2 = (short)1378222081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1139212294;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_154;
				case 2:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_GroupName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)2037448708;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_264;
				case 3:
					goto IL_264;
				case 4:
				{
					num2 = (short)753401856;
					short num3 = num2;
					num2 = (short)994021195;
					short num4 = num2;
					num2 = (short)672632651;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_154;
					default:
						num2 = (short)171638784;
						if (num2 != 0)
						{
						}
						num2 = (short)1740505088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_FC;
				case 6:
					if (A_1.Group == null)
					{
						num2 = (short)1321074697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FC;
				case 7:
					A_1.Comments = b.a.Comments;
					num2 = (short)1454899210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!b.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(b, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.b)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.b.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest.get_Comments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1269825543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return A_1;
				case 9:
					num2 = (short)1892220929;
					if (num2 != 0)
					{
					}
					A_1.Group = new global::Motorola.CommonCPS.Server.EntityModel.Group();
					num2 = (short)1361641477;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return A_1;
				case 11:
					goto IL_264;
				}
				goto IL_40;
				IL_FC:
				A_1.Group.Name = b.a.GroupName;
				num2 = (short)639238155;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_154:
				A_1.Group = null;
				num2 = (short)571932675;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_264:
				num2 = (short)1788936200;
				num = (int)((global::System.IntPtr)num2);
			}
			return A_1;
			IL_40:
			b = new global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.b();
			b.a = A_0;
			A_1.SerialNumber = b.a.SerialNumber;
			A_1.WorkingCodeplug.RadioAlias = b.a.RadioAlias;
			num2 = (short)1647837186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000200B8 File Offset: 0x0001E2B8
		private static global::Motorola.CommonCPS.Server.EntityModel.Radio a(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest A_0, global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_88;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c c;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return A_1;
				case 1:
					apxcodeplug.OtarID = c.a.OtarID;
					num2 = (short)1857552387;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_6BF;
				case 3:
				{
					num2 = (short)1077670642;
					short num3 = num2;
					num2 = (short)777777906;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_497;
					default:
						num2 = (short)1726152704;
						if (num2 != 0)
						{
						}
						goto IL_410;
					}
					break;
				}
				case 4:
					apxcodeplug.VRID = c.a.VRID;
					num2 = (short)545718272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)459997212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_77B;
				case 6:
					goto IL_385;
				case 7:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserLoginUnitID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1124597780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27B;
				case 8:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_VRID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)2118320132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return A_1;
				case 9:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)656539663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 10:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_ForeignIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)805634062;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6BF;
				case 11:
				{
					num2 = (short)1645281280;
					short num4 = num2;
					apxcodeplug.BluetoothDUNPeerIP = c.a.BluetoothDUNPeerIP;
					num2 = (short)568459288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					goto IL_138;
				case 13:
					goto IL_5AA;
				case 14:
					A_1.ForeignIP = c.a.ForeignIP;
					num2 = (short)64815106;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					apxcodeplug.BluetoothDUNSubscriberIP = c.a.BluetoothDUNSubscriberIP;
					num2 = (short)467206166;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1036779543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 17:
					goto IL_77B;
				case 18:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_OtarID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)288030721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_410;
				case 19:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1562312715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_634;
				case 20:
					apxcodeplug.UserLoginUnitID = c.a.UserLoginUnitID;
					num2 = (short)714997786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					apxcodeplug.BluetoothFriendlyName = c.a.BluetoothFriendlyName;
					num2 = (short)1447362573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_1F1;
				case 23:
					apxcodeplug.SubscriberIP = c.a.SubscriberIP;
					num2 = (short)634585100;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					goto IL_634;
				case 25:
					apxcodeplug.UserName = c.a.UserName;
					num2 = (short)453902342;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					goto IL_27B;
				case 27:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1485766681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_385;
				case 28:
					goto IL_497;
				case 29:
					if (!c.a.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(c, typeof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c)), fieldof(global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c.a)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothFriendlyName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
					{
						num2 = (short)1700331541;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5AA;
				}
				goto IL_88;
				IL_138:
				num2 = (short)1532952583;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F1:
				num2 = (short)635633693;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27B:
				num2 = (short)615383041;
				if (num2 != 0)
				{
				}
				num2 = (short)161349659;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_385:
				num2 = (short)183697416;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_410:
				num2 = (short)300154885;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_497:
				apxcodeplug.PeerIP = c.a.PeerIP;
				num2 = (short)1821966353;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5AA:
				num2 = (short)311361546;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_634:
				num2 = (short)1874001929;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6BF:
				num2 = (short)479854610;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_77B:
				num2 = (short)1475739664;
				num = (int)((global::System.IntPtr)num2);
			}
			return A_1;
			IL_88:
			c = new global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.c();
			c.a = A_0;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(c.a, A_1);
			apxcodeplug = (A_1.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			num2 = (short)1076297747;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00020944 File Offset: 0x0001EB44
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_1)
		{
			short num = (short)617754518;
			short num2 = num;
			num = (short)523382678;
			switch (num2 == num)
			{
			}
			num = (short)1136328704;
			short num3 = num;
			num = (short)1626144769;
			if (num != 0)
			{
			}
			num = (short)218300416;
			if (num != 0)
			{
			}
			A_1.SerialNumber = A_0.SerialNumber;
			A_1.RadioAlias = A_0.RadioAlias;
			A_1.GroupName = A_0.GroupName;
			A_1.Comments = A_0.Comments;
			return A_1;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00020A20 File Offset: 0x0001EC20
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_1)
		{
			short num = (short)1065419516;
			short num2 = num;
			num = (short)1772225276;
			switch (num2 == num)
			{
			}
			num = (short)998834176;
			short num3 = num;
			num = (short)846135296;
			if (num != 0)
			{
			}
			num = (short)1540030465;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(A_0, A_1);
			A_1.BluetoothDUNPeerIP = A_0.BluetoothDUNPeerIP;
			A_1.BluetoothDUNSubscriberIP = A_0.BluetoothDUNSubscriberIP;
			A_1.BluetoothFriendlyName = A_0.BluetoothFriendlyName;
			A_1.ForeignIP = A_0.ForeignIP;
			A_1.OtarID = A_0.OtarID;
			A_1.PeerIP = A_0.PeerIP;
			A_1.SubscriberIP = A_0.SubscriberIP;
			A_1.UserLoginUnitID = A_0.UserLoginUnitID;
			A_1.UserName = A_0.UserName;
			A_1.PassWord = A_0.ReadPassword;
			A_1.VRID = A_0.VRID;
			return A_1;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00020B58 File Offset: 0x0001ED58
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_1)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_E3;
				case 1:
					goto IL_1E9;
				case 2:
					if (!string.IsNullOrEmpty(A_0.UserPIN))
					{
						num2 = (short)2028994564;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_271;
				case 3:
					if (!string.IsNullOrEmpty(A_1.AstroPurchasedFlashCode))
					{
						goto IL_107;
					}
					goto IL_154;
				case 4:
					num2 = (short)708050952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroParseFlashCode(A_0, A_1);
					A_1.LicensedFeatureList = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>(list);
					num2 = (short)1921056774;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_26F;
				case 7:
					A_1.UserPIN = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroPINPasswordConvert(A_0.UserPIN, false);
					num2 = (short)1272840192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (A_0.UserPIN != global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤪ漬ᰮа爲4ȶ࠸఺簼ܾ畀畂灄睆繈ཊ瑌癎扐扒敔晖ᵘ湚湜歞呠⁢⁤≦婨⩪⽬Ɱ㝰㙲䁴䅶䵸䍺㽼㹾뢀떂낄솆놈쪊벌릎킐ꂒ킔톖\uda98\ud89a꾜\ud99e邢閤钦钬肴薶许貺寮螾蟀ﳄﻆﻈ諊裌諎铔ퟠꛢꏤꓦ\udce8", a_))
					{
						num2 = (short)1097531399;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_271;
				case 9:
					num2 = (short)1619984385;
					if (num2 != 0)
					{
					}
					goto IL_E3;
				case 10:
					num2 = (short)1757151243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!string.IsNullOrEmpty(A_0.ModelNumber))
					{
						num2 = (short)53673989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_154;
				}
				goto IL_49;
				IL_E3:
				num2 = (short)1092288515;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_107:
				num2 = (short)775159818;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_154:
				A_1.LicensedFeatureList = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>();
				num2 = (short)1535574016;
				short num3 = num2;
				num2 = (short)594805813;
				short num4 = num2;
				num2 = (short)2036466741;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_107;
				default:
					num2 = (short)1843920896;
					if (num2 != 0)
					{
					}
					num2 = (short)457637889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_271:
				A_1.UserPIN = string.Empty;
				num2 = (short)1731330057;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1E9:
			IL_26F:
			A_1.ID = new global::System.Guid?(A_0.Uuid);
			A_1.PasswordPolicy = A_0.PasswordPolicy;
			return A_1;
			IL_49:
			A_1.AstroPurchasedFlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(A_0.AstroPurchasedFlashCode);
			num2 = (short)407830530;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00020E44 File Offset: 0x0001F044
		private static byte a(string A_0)
		{
			short num = (short)758974309;
			short num2 = num;
			num = (short)1410598757;
			switch (num2 == num)
			{
			}
			num = (short)942735360;
			short num3 = num;
			num = (short)45154305;
			if (num != 0)
			{
			}
			num = (short)922877952;
			if (num != 0)
			{
			}
			byte result = 0;
			global::CommonUtility.FeatureNoticeUtility.GetLatestNoticeValueFromBase64Str(A_0, out result);
			return result;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_1)
		{
			short num = (short)716111872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_CF;
				}
				for (;;)
				{
					IL_28:
					global::System.Guid? guid;
					global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
					bool flag;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? jobType;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Group group = new global::Motorola.CommonCPS.Server.EntityModel.Group();
						guid = A_1.CurentGroup.ID;
						group.Uuid = guid.Value;
						group.Name = A_1.CurentGroup.Name;
						A_0.Group = group;
						num = (short)707985439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus;
						if (cruncherStatus != null)
						{
							num = (short)1563820049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					}
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.IEntity entity = workingCodeplug;
						guid = A_1.WorkingCodeplugUUID;
						entity.Uuid = guid.Value;
						num = (short)975896603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1598793212;
						short num3 = num;
						num = (short)678077948;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_363;
						default:
							num = (short)1616838656;
							if (num != 0)
							{
							}
							num = (short)1585250312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						guid = A_1.CurentGroup.ID;
						num = (short)1508114454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						guid = A_1.WorkingTemplateUuid;
						num = (short)447807502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Job lastJob = A_0.LastJob;
						jobStatus = A_1.JobStatus;
						lastJob.JobStatus = jobStatus.Value;
						num = (short)626786311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_7CB;
					case 8:
						flag = false;
						goto IL_7A9;
					case 9:
						goto IL_363;
					case 10:
						goto IL_719;
					case 11:
						if (jobStatus != null)
						{
							num = (short)2008350726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CB;
					case 12:
						flag = true;
						goto IL_7A9;
					case 13:
					{
						global::Motorola.CommonCPS.Server.EntityModel.JobContainer jobContainer = A_0.LastJob.JobContainer;
						jobType = A_1.JobType;
						jobContainer.JobType = jobType.Value;
						num = (short)2140209172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (guid != null)
						{
							num = (short)1331494947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F;
					case 15:
						if (workingCodeplug.Template != null)
						{
							num = (short)1259274245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_325;
					case 16:
						goto IL_320;
					case 17:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Job lastJob2 = A_0.LastJob;
						global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus = A_1.CruncherStatus;
						lastJob2.CruncherStatus = cruncherStatus.Value;
						num = (short)1807941661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (guid == null)
						{
							num = (short)758186021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)112853016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (guid != null)
						{
							num = (short)317718551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_719;
					case 20:
						goto IL_2B8;
					case 21:
						if (guid != null)
						{
							num = (short)2059862018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_434;
					case 22:
						if (guid != null)
						{
							num = (short)1406009344;
							short num4 = num;
							num = (short)1124532256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF;
					case 23:
					{
						global::Motorola.CommonCPS.Server.EntityModel.IEntity configuration = workingCodeplug.Configuration;
						guid = A_1.WorkingConfigurationUuid;
						configuration.Uuid = guid.Value;
						num = (short)2039611402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (guid == null)
						{
							num = (short)1862205443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)879165470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_22F;
					case 26:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = A_1.ProductFamily;
						A_0.ProductFamily = ((productFamily != null) ? new int?((int)productFamily.GetValueOrDefault()) : null);
						workingCodeplug = A_0.WorkingCodeplug;
						guid = A_1.WorkingCodeplugUUID;
						num = (short)1568669717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_434;
					case 28:
					{
						A_0.LastJob = new global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob();
						A_0.LastJob.JobContainer = new global::Motorola.CommonCPS.Server.EntityModel.JobContainer();
						global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus = A_1.CruncherStatus;
						num = (short)1665728513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_26E;
					case 30:
					{
						global::System.Guid empty;
						flag = (guid.GetValueOrDefault() != empty);
						goto IL_7A9;
					}
					case 31:
						goto IL_1BF;
					case 32:
					{
						guid = A_1.CurentGroup.ID;
						global::System.Guid empty = global::System.Guid.Empty;
						num = (short)1349910546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (workingCodeplug.Configuration != null)
						{
							num = (short)1543110665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_719;
					case 34:
						if (guid != null)
						{
							num = (short)915472412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D1;
					case 35:
					{
						global::Motorola.CommonCPS.Server.EntityModel.IEntity template = workingCodeplug.Template;
						guid = A_1.WorkingTemplateUuid;
						template.Uuid = guid.Value;
						num = (short)1982726169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_325;
					case 37:
						num = (short)1173291020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (jobType != null)
						{
							num = (short)1980825613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B8;
					case 39:
						if (A_1.CurentGroup != null)
						{
							num = (short)453902340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF;
					}
					goto IL_CF;
					IL_1BF:
					A_0.Uuid = A_1.DeviceUuid;
					A_0.ModelNumber = A_1.ModelNumber;
					A_0.SerialNumber = A_1.SerialNumber;
					A_0.WorkingCodeplugUuid = A_1.WorkingCodeplugUUID;
					num = (short)837943322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A9:
					if (flag)
					{
						num = (short)1586167808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
					IL_22F:
					workingCodeplug.Template.Name = A_1.TemplateName;
					workingCodeplug.Template.Timestamp = A_1.TemplateTimestamp;
					num = (short)276365348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26E:
					jobStatus = A_1.JobStatus;
					num = (short)513605643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B8:
					A_0.LastJob.Timestamp = A_1.JobTimestamp;
					global::Motorola.CommonCPS.Server.EntityModel.IEntity lastJob3 = A_0.LastJob;
					guid = A_1.JobUuid;
					lastJob3.Uuid = guid.Value;
					num = (short)1633484801;
					if (num != 0)
					{
					}
					num = (short)458817552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_325:
					num = (short)1503658017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_363:
					guid = A_1.WorkingConfigurationUuid;
					num = (short)1644298259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					workingCodeplug.CodeplugVersion = A_1.CodeplugVersion;
					workingCodeplug.FirmwareVersion = A_1.FirmwareVersion;
					workingCodeplug.BBFBundleVersion = A_1.BBFBundleVersion;
					workingCodeplug.RadioAlias = A_1.RadioAlias;
					workingCodeplug.Timestamp = A_1.CodeplugTimestamp;
					num = (short)373555215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_719:
					workingCodeplug.ChangeIndicator = new int?(A_1.ChangeIndicator);
					guid = A_1.JobUuid;
					num = (short)1606287394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CB:
					A_0.LastJob.JobContainer.JobName = A_1.JobName;
					jobType = A_1.JobType;
					num = (short)470024230;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_320:
				IL_8D1:
				A_0.RadioStatus = (int)A_1.RadioStatus;
				A_0.Timestamp = A_1.RadioTimestamp;
				return;
				IL_CF:
				A_0.Comments = A_1.Comments;
				num = (short)1525415975;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000217F0 File Offset: 0x0001F9F0
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
			short num2;
			for (;;)
			{
				IL_0A:
				int? num3;
				int num4;
				switch (num)
				{
				case 0:
					if (apxcodeplug != null)
					{
						num2 = (short)1679949826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					apxcodeplug.AstroPurchasedFlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode(A_1.AstroPurchasedFlashCode);
					apxcodeplug.PeerIP_A41818 = A_1.PeerIP_Link2;
					apxcodeplug.PeerIP = A_1.PeerIP;
					apxcodeplug.AskRequired = new bool?(A_1.AskRequired);
					apxcodeplug.BluetoothDUNPeerIP = A_1.BluetoothDUNPeerIP;
					apxcodeplug.BluetoothDUNSubscriberIP = A_1.BluetoothDUNSubscriberIP;
					apxcodeplug.BluetoothFriendlyName = A_1.BluetoothFriendlyName;
					apxcodeplug.OtarID = A_1.OtarID;
					apxcodeplug.SubscriberIP = A_1.SubscriberIP;
					apxcodeplug.SubscriberIP_A41819 = A_1.SubscriberIP_Link2;
					apxcodeplug.UserLoginUnitID = A_1.UserLoginUnitID;
					apxcodeplug.UserName = A_1.UserName;
					apxcodeplug.UserPIN = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroPINPasswordConvert(A_1.UserPIN, true);
					num3 = A_1.ExtendedFlags;
					num2 = (short)1194459145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1CC;
				case 4:
				{
					if (num3.GetValueOrDefault() == num4 & num3 != null)
					{
						num2 = (short)1089798152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1056041960;
					short num5 = num2;
					num2 = (short)663350248;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num2 = (short)1629356032;
						short num6 = num2;
						break;
					}
					}
					num2 = (short)1639710720;
					if (num2 != 0)
					{
					}
					num3 = apxcodeplug.OwnerAdvKeyType;
					num4 = 1;
					num2 = (short)1776680965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (num3.GetValueOrDefault() == num4 & num3 != null)
					{
						num2 = (short)1061748746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CC;
				case 6:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2 = apxcodeplug;
					num3 = A_1.ExtendedFlags;
					apxcodeplug2.ExtendedFlags = num3.Value;
					num2 = (short)703660043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_1CC;
				case 8:
					apxcodeplug.HomeSystemId = A_1.OwnerSystemId;
					num2 = (short)822476807;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (num3 != null)
					{
						num2 = (short)1361313798;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_324;
				case 10:
					apxcodeplug.OwnerWacnId = A_1.OwnerSystemId;
					num2 = (short)199557123;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)558825473;
					if (num2 != 0)
					{
					}
					goto IL_324;
				}
				goto IL_40;
				IL_1CC:
				apxcodeplug.VRID = A_1.VRID;
				apxcodeplug.DVRSHardwareEnable = A_1.DVRSHardwareEnable;
				num2 = (short)1804861441;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_324:
				apxcodeplug.RadioAliasEnable = A_1.RadioAliasEnable;
				apxcodeplug.OtarEnable = A_1.OtarEnable;
				apxcodeplug.AstroOtarEnable = A_1.ASTROOtarEnable;
				apxcodeplug.SecureOperation = A_1.SecureOperation;
				apxcodeplug.AESEnable = A_1.AESEnable;
				apxcodeplug.BluetoothDunPeerIpAssignmentType = A_1.AssignmentType;
				apxcodeplug.BluetoothEnable = A_1.BluetoothEnable;
				apxcodeplug.LocationEnable = A_1.LocationEnable;
				apxcodeplug.P25LocationReporting = A_1.P25LocationReporting;
				apxcodeplug.LocationServerIPAddress = A_1.LocServerIPAddress;
				apxcodeplug.ArsMode = A_1.ArsMode;
				apxcodeplug.DirectLocationRegistration = A_1.DirectLocationRegistration;
				apxcodeplug.BluetoothPANNetworkBaseAddress = A_1.BluetoothPANNetworkBaseAddress;
				apxcodeplug.UserNameDisplayTextSize = A_1.UserNameDisplayTextSize;
				apxcodeplug.UserLoginUnitIDTextSize = A_1.UserLoginUnitIDTextSize;
				apxcodeplug.UserLoginUnitIDEnable = A_1.UserLoginUnitIDEnable;
				apxcodeplug.AutomaticRegistrationServerAddress = A_1.AutoRegServerAddress;
				apxcodeplug.AstroPurchasedFlashCode = A_1.ServerSideASTROPurchasedFlashCode;
				A_0.ForeignIP = A_1.ForeignIP;
				apxcodeplug.UpgradeAbility = A_1.UpgradeAbility;
				apxcodeplug.DeviceInfoFields = A_1.DeviceInfoFields;
				apxcodeplug.OwnerAdvKeyType = A_1.OwnerAdvKeyType;
				apxcodeplug.DisableWriteProtect = A_1.DisableWriteProtect;
				num3 = apxcodeplug.OwnerAdvKeyType;
				num4 = 0;
				num2 = (short)676462596;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_40:
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a(A_0, A_1);
			apxcodeplug = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			num2 = (short)1328611328;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00021C88 File Offset: 0x0001FE88
		private static bool a(string A_0, global::System.Globalization.NumberStyles A_1, out int A_2)
		{
			int a_ = 0;
			global::System.Globalization.CultureInfo provider;
			for (;;)
			{
				IL_09:
				short num = (short)896860162;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_79;
					case 1:
						goto IL_144;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 3:
					{
						provider = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("缙爛㌝生無", a_));
						num = (short)1392071818;
						short num3 = num;
						num = (short)1633309834;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1118830592;
							if (num != 0)
							{
							}
							num = (short)2050228224;
							short num4 = num;
							num = (short)1436811265;
							if (num != 0)
							{
							}
							num = (short)570359809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_3D:
					if ((A_1 & global::System.Globalization.NumberStyles.AllowCurrencySymbol) > global::System.Globalization.NumberStyles.None)
					{
						num = (short)1520238595;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						provider = global::System.Globalization.CultureInfo.InvariantCulture;
						num = (short)197459968;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_79:
			IL_144:
			return int.TryParse(A_0, A_1, provider, out A_2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00021DE4 File Offset: 0x0001FFE4
		private static bool a(string A_0, global::System.Globalization.NumberStyles A_1, out long A_2)
		{
			int a_ = 6;
			global::System.Globalization.CultureInfo provider;
			for (;;)
			{
				IL_09:
				short num = (short)1739587586;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_9F;
					case 1:
						goto IL_144;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 3:
					{
						provider = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䔟䰡ण猥笧", a_));
						num = (short)969696782;
						short num3 = num;
						num = (short)1040016910;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)220594176;
							short num4 = num;
							num = (short)1650655232;
							if (num != 0)
							{
							}
							num = (short)726859777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_3E:
					if ((A_1 & global::System.Globalization.NumberStyles.AllowCurrencySymbol) > global::System.Globalization.NumberStyles.None)
					{
						num = (short)1383858179;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1043202049;
						if (num != 0)
						{
						}
						provider = global::System.Globalization.CultureInfo.InvariantCulture;
						num = (short)1593376768;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_9F:
			IL_144:
			return long.TryParse(A_0, A_1, provider, out A_2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00021F40 File Offset: 0x00020140
		private static string a(string A_0, int? A_1, string A_2, string A_3, string A_4)
		{
			int a_ = 16;
			short num = (short)870514688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				string text;
				string[] array;
				for (;;)
				{
					IL_31:
					global::Motorola.Common.CustomException.CommonErrorCode value;
					switch (num2)
					{
					case 0:
						goto IL_38F;
					case 1:
						if (value != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
						{
							num = (short)1687093259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 2:
						goto IL_185;
					case 3:
						goto IL_185;
					case 4:
						value = (global::Motorola.Common.CustomException.CommonErrorCode)A_1.Value;
						num = (short)1328873473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (A_4 != null)
						{
							num = (short)424738822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					case 6:
						text = A_4;
						num = (short)285736970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (A_1 != null)
						{
							num = (short)297402372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)944963592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (A_3 != null)
						{
							num = (short)699465741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)322895877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_38F;
					case 10:
						goto IL_185;
					case 11:
						num = (short)1436418064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						text = A_2;
						num = (short)158990345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text = global::Motorola.CommonCPS.Common.CommonUtility.WarningMessageConverter.SourceToTarget(A_3, array);
						num = (short)1347616771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_144;
					case 15:
						text = text.Replace(global::System.Environment.NewLine, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("਩", a_));
						num = (short)1404305425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1543045121;
						if (num != 0)
						{
						}
						if (value == global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
						{
							num = (short)589824014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_283;
					case 17:
						return text;
					case 18:
						if (!string.IsNullOrEmpty(A_2))
						{
							num = (short)165806092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_283;
					case 19:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1182990351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					goto IL_88;
					IL_144:
					num = (short)941883410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)1874657299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_283:
					text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(value.ToString(), array);
					num = (short)531441459;
					short num3 = num;
					num = (short)548480819;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_185;
					default:
					{
						num = (short)1896284160;
						short num4 = num;
						num = (short)569573376;
						if (num != 0)
						{
						}
						num = (short)1238368256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_38F:
					string[] array2 = new string[5];
					array2[0] = global::Motorola.CommonCPS.ResourceRepository.Resources.Left_Square_Brackets;
					array2[1] = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ऩ", a_);
					int num5 = 2;
					int num6 = (int)value;
					array2[num5] = num6.ToString();
					array2[3] = global::Motorola.CommonCPS.ResourceRepository.Resources.Right_Square_Brackets;
					array2[4] = text;
					text = string.Concat(array2);
					num = (short)812843010;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_88:
				text = null;
				array = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterStringToParameterArray(A_0);
				num = (short)1483538439;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00022354 File Offset: 0x00020554
		// Note: this type is marked as 'beforefieldinit'.
		static ModelConverter()
		{
			short num = (short)75300864;
			short num2 = num;
			num = (short)585709995;
			short num3 = num;
			num = (short)1803303339;
			switch (num3 == num)
			{
			}
			num = (short)304414720;
			if (num != 0)
			{
			}
			num = (short)523304961;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a>>();
		}

		// Token: 0x0400003C RID: 60
		private static global::System.Collections.Concurrent.ConcurrentDictionary<string, global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.ModelConverter.a>> a;

		// Token: 0x0400003D RID: 61
		private const string b = "2B35A5517A846507D993101D5345CEE3ABCFE5648BA965F8A16A3EFCC2FF303FB9EEC5227D8F4997AEE03A453506EFC5";

		// Token: 0x02000025 RID: 37
		private class a
		{
			// Token: 0x060001D0 RID: 464 RVA: 0x00022408 File Offset: 0x00020608
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public bool e()
			{
				short num = (short)1168834560;
				short num2 = num;
				num = (short)569195386;
				short num3 = num;
				num = (short)1650408314;
				switch (num3 == num)
				{
				}
				num = (short)764674048;
				if (num != 0)
				{
				}
				num = (short)1294598145;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x000224B8 File Offset: 0x000206B8
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void e(bool A_0)
			{
				short num = (short)763101184;
				short num2 = num;
				num = (short)781843759;
				short num3 = num;
				num = (short)859241775;
				switch (num3 == num)
				{
				}
				num = (short)1320353792;
				if (num != 0)
				{
				}
				num = (short)1722482689;
				if (num != 0)
				{
				}
				this.a = A_0;
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x00022568 File Offset: 0x00020768
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> f()
			{
				short num = (short)92340224;
				short num2 = num;
				num = (short)2113434704;
				short num3 = num;
				num = (short)1909814352;
				switch (num3 == num)
				{
				}
				num = (short)1499660288;
				if (num != 0)
				{
				}
				num = (short)293142529;
				if (num != 0)
				{
				}
				return this.b;
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x00022618 File Offset: 0x00020818
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void e(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> A_0)
			{
				short num = (short)980615168;
				short num2 = num;
				num = (short)807469057;
				if (num != 0)
				{
				}
				num = (short)1039887755;
				short num3 = num;
				num = (short)40725899;
				switch (num3 == num)
				{
				}
				num = (short)2095644672;
				if (num != 0)
				{
				}
				this.b = A_0;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x000226CC File Offset: 0x000208CC
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSet> g()
			{
				short num = (short)1086586880;
				short num2 = num;
				num = (short)21692417;
				if (num != 0)
				{
				}
				num = (short)1778414970;
				short num3 = num;
				num = (short)1633121658;
				switch (num3 == num)
				{
				}
				num = (short)517799936;
				if (num != 0)
				{
				}
				return this.c;
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0002277C File Offset: 0x0002097C
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void e(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSet> A_0)
			{
				short num = (short)1812791296;
				short num2 = num;
				num = (short)1313144833;
				if (num != 0)
				{
				}
				num = (short)471192665;
				short num3 = num;
				num = (short)1208276057;
				switch (num3 == num)
				{
				}
				num = (short)135004160;
				if (num != 0)
				{
				}
				this.c = A_0;
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x0002282C File Offset: 0x00020A2C
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection h()
			{
				short num = (short)1009844224;
				short num2 = num;
				num = (short)1177036223;
				short num3 = num;
				num = (short)1816405439;
				switch (num3 == num)
				{
				}
				num = (short)1602748417;
				if (num != 0)
				{
				}
				num = (short)491978752;
				if (num != 0)
				{
				}
				return this.d;
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x000228DC File Offset: 0x00020ADC
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void e(global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection A_0)
			{
				short num = (short)823787520;
				short num2 = num;
				num = (short)864802433;
				short num3 = num;
				num = (short)1002362497;
				switch (num3 == num)
				{
				}
				num = (short)72024065;
				if (num != 0)
				{
				}
				num = (short)1206386688;
				if (num != 0)
				{
				}
				this.d = A_0;
			}

			// Token: 0x0400003E RID: 62
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private bool a;

			// Token: 0x0400003F RID: 63
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> b;

			// Token: 0x04000040 RID: 64
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSet> c;

			// Token: 0x04000041 RID: 65
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection d;
		}

		// Token: 0x02000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x04000048 RID: 72
			public global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest a;
		}

		// Token: 0x0200002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x04000049 RID: 73
			public global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest a;
		}
	}
}
