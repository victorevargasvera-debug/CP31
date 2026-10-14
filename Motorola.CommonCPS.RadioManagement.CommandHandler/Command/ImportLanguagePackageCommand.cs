using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C3 RID: 195
	internal class ImportLanguagePackageCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x000452FC File Offset: 0x000434FC
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)790691846;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
				switch (num2)
				{
				case 0:
					num = (short)1240137729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (importLanguagePackContext.SelectedLanguagePacks.Count > 0)
					{
						num = (short)328073224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1776615431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_124;
				case 4:
					if (importLanguagePackContext.SelectedLanguagePacks != null)
					{
						num = (short)1420165120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
				{
					num = (short)2049260706;
					short num3 = num;
					num = (short)1123499170;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						num = (short)1643642880;
						if (num != 0)
						{
						}
						num = (short)1112801284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 7:
					if (paras.Count<object>() > 0)
					{
						num = (short)458031107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					return true;
				case 9:
					num = (short)1817772033;
					if (num != 0)
					{
					}
					if (importLanguagePackContext != null)
					{
						num = (short)1039007744;
						short num4 = num;
						num = (short)889389061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_4D:
				if (paras != null)
				{
					num = (short)1212481538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_124:
				importLanguagePackContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext);
				num = (short)676659209;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0004550C File Offset: 0x0004370C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1402994689;
			if (num != 0)
			{
			}
			num = (short)312999936;
			switch (num)
			{
			default:
			{
				num = (short)771751946;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> list;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)1198587905;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)130744324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1680998400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack importedLanguagePack = enumerator.Current;
									list.Add(importedLanguagePack.ToEntity());
									num = (short)672131895;
									short num3 = num;
									num = (short)533392183;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)870973440;
										if (num != 0)
										{
										}
										num = (short)1241972739;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_254;
								}
								IL_1FB:
								num = (short)817102850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_180:
								goto IL_1FB;
							}
							IL_254:
							goto IL_377;
						}
						finally
						{
							num = (short)578486273;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2048720898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_28B;
									}
									continue;
								case 2:
									goto IL_2C1;
								}
								IL_28B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)558891008;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C1:;
						}
						goto IL_2C4;
						IL_377:
						num = (short)295108608;
						short num4 = num;
						num = (short)297861127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
						if (importLanguagePackContext.SelectedLanguagePacks.Count <= 0)
						{
							num = (short)304414722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack> enumerator = importLanguagePackContext.SelectedLanguagePacks.GetEnumerator();
						num = (short)1471283200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_331;
					case 3:
						num = (short)1003880456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
						if (importLanguagePackContext != null)
						{
							num = (short)762904588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42D;
					}
					case 5:
						goto IL_3DD;
					case 6:
						num = (short)1244135425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (list.Count <= 0)
						{
							num = (short)1844969477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C4;
					case 8:
					{
						if (paras.Count<object>() <= 0)
						{
							num = (short)1669726219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext;
						num = (short)2075066372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_2EA;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 11:
						goto IL_372;
					case 12:
						num = (short)10289165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
						if (importLanguagePackContext.SelectedLanguagePacks != null)
						{
							num = (short)1710096390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42D;
					}
					}
					IL_A2:
					if (paras != null)
					{
						num = (short)1700069379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2C4:
					global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportLanguagePacksBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportLanguagePacksBatchOp(list);
					base.ExecuteBatchOp<global::Motorola.CommonCPS.Server.EntityModel.Package>(op);
					num = (short)496173065;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_140:
				throw new global::System.ArgumentNullException();
				IL_2EA:
				goto IL_42D;
				IL_331:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_NoItem_Selected);
				IL_372:
				goto IL_140;
				IL_3DD:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_NoItem_Selected);
				IL_42D:
				return true;
			}
			}
		}
	}
}
