using System;
using CommonResources;
using ConstraintHelper;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200017E RID: 382
	public class CompatibilityChecks
	{
		// Token: 0x060012CA RID: 4810 RVA: 0x00003733 File Offset: 0x00001933
		internal CompatibilityChecks(string srcUsedFlashcode, string srcPurchasedFlashcode, string radioFlashcode, string srcModelNumber, string radioModelNumber)
		{
			this.c = global::ConstraintHelper.UtilityMack.IsPortable();
			this.a(srcUsedFlashcode, srcPurchasedFlashcode, radioFlashcode, srcModelNumber, radioModelNumber);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0000375A File Offset: 0x0000195A
		public CompatibilityChecks(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate srcData, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug targetData, string targetModelNumber)
		{
			this.c = (srcData.ModelNumber[0] == 'H');
			this.a(srcData, targetData, targetModelNumber);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x001A471C File Offset: 0x001A291C
		private void a(string A_0, string A_1, string A_2, string A_3, string A_4)
		{
			short num = (short)1213130838;
			short num2 = num;
			num = (short)1154017366;
			switch (num2 == num)
			{
			}
			num = (short)1451229184;
			if (num != 0)
			{
			}
			num = (short)1000407041;
			if (num != 0)
			{
			}
			num = (short)1568735232;
			short num3 = num;
			this.a = new global::SpecialFeatures.Clone_Configuration.Common.CodeplugData();
			this.a.usedFlashcode = A_0;
			this.a.modelNumber = A_3;
			this.a.purchasedFlashcode = A_1;
			this.b = new global::SpecialFeatures.Clone_Configuration.Common.CodeplugData();
			this.b.purchasedFlashcode = A_2;
			this.b.modelNumber = A_4;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x001A481C File Offset: 0x001A2A1C
		private void a(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate A_0, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_1, string A_2)
		{
			short num = (short)99942400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_239;
					case 1:
						goto IL_239;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().XMLToEntityCollections<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>(A_0.DataProfiles);
						int num3 = 0;
						num = (short)401473536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_276;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array;
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)2019753990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile item = array[num3];
						this.a._data.APXDataProfiles.Add(item);
						num3++;
						num = (short)553123841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num3;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array2;
						if (num3 >= array2.Length)
						{
							num = (short)640679938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_201;
					}
					case 6:
						goto IL_274;
					case 7:
						goto IL_276;
					}
					goto IL_4F;
					IL_239:
					num = (short)467861508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_276:
					num = (short)1084817413;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_274:
				this.a.recSetCounts = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.LoadRecSetItemsFromXml(A_0.RecSetCounts);
				this.b = new global::SpecialFeatures.Clone_Configuration.Common.CodeplugData();
				this.b._data = A_1;
				this.b.modelNumber = A_2;
				this.b.purchasedFlashcode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(A_1.AstroPurchasedFlashCode, A_1.AstroPurchasedFlashCode.Length);
				this.b.recSetCounts = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.LoadRecSetItemsFromXml(A_1.RecSetCounts);
				return;
				IL_4F:
				num = (short)834878542;
				short num4 = num;
				num = (short)1121074254;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_201:
					int num3;
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array2;
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem item2 = array2[num3];
					this.a._data.APXRadioSystems.Add(item2);
					num3++;
					num = (short)1121452035;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				default:
				{
					num = (short)1384579073;
					if (num != 0)
					{
					}
					num = (short)1936064512;
					if (num != 0)
					{
					}
					num = (short)335216640;
					short num5 = num;
					this.a = new global::SpecialFeatures.Clone_Configuration.Common.CodeplugData();
					this.a._data = new global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug();
					this.a.modelNumber = A_0.ModelNumber;
					this.a.purchasedFlashcode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(A_0.AstroPurchasedFlashCode, A_0.AstroPurchasedFlashCode.Length);
					this.a.usedFlashcode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(A_0.AstroEnableFlashCode, A_0.AstroEnableFlashCode.Length);
					this.a._data.AllowInvalidFrequency = A_0.AllowInvalidFrequency;
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().XMLToEntityCollections<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>(A_0.RadioSystems);
					int num3 = 0;
					num = (short)832110599;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x001A4B4C File Offset: 0x001A2D4C
		public bool PerfomChecks(ref string stsErrorMsg)
		{
			switch (0)
			{
			case 0:
				goto IL_B5;
			}
			short num;
			int num4;
			bool flag;
			for (;;)
			{
				IL_0A:
				num = (short)1530909932;
				short num2 = num;
				num = (short)1649071340;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)117702656;
					short num3 = num;
					num = (short)539099136;
					if (num != 0)
					{
					}
					num = (short)242417665;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						return flag;
					case 1:
						stsErrorMsg = global::CommonResources.AppResources.Failure_due_to_mismatch_of_Codeplug_Used_FLASHcode_and_Radio_Purchased_FLASHcode;
						flag = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowClone(this.a, this.b, this.c, ref stsErrorMsg);
						num = (short)485752832;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_F7;
					}
					goto IL_B5;
				}
				}
				IL_F7:
				if (!flag)
				{
					break;
				}
				num = (short)1047855105;
				num4 = (int)((global::System.IntPtr)num);
			}
			return flag;
			IL_B5:
			stsErrorMsg = "";
			flag = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.ModelNumberCheck(this.a.modelNumber, this.b.modelNumber, this.c, ref stsErrorMsg);
			num = (short)1830748162;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000A1C RID: 2588
		private global::SpecialFeatures.Clone_Configuration.Common.CodeplugData a;

		// Token: 0x04000A1D RID: 2589
		private global::SpecialFeatures.Clone_Configuration.Common.CodeplugData b;

		// Token: 0x04000A1E RID: 2590
		private bool c = true;
	}
}
