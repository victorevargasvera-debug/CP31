using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using AcpUtility;
using CommonResources;
using CommonUtility;
using Encaten;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport
{
	// Token: 0x020000C5 RID: 197
	public sealed class FlashportUpgradeFile
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x000FE130 File Offset: 0x000FC330
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x000FE1E4 File Offset: 0x000FC3E4
		public string UpgradeFilePath
		{
			get
			{
				short num = (short)2004308198;
				short num2 = num;
				num = (short)1015566566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422510592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508821505;
				if (num != 0)
				{
				}
				num = (short)594411520;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)772829674;
				short num2 = num;
				num = (short)1223848426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67239936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1455620096;
				if (num != 0)
				{
				}
				num = (short)1390018561;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002E85 File Offset: 0x00001085
		public FlashportUpgradeFile()
		{
			this.b = string.Empty;
			this.a = null;
			this.d = false;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002EB1 File Offset: 0x000010B1
		public FlashportUpgradeFile(string path)
		{
			this.b = path;
			this.a = global::Encaten.EncatenWrapperFactory.CreateEncatenWrapper();
			this.d = false;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000FE294 File Offset: 0x000FC494
		public bool OpenUpgradeFile()
		{
			int a_ = 12;
			short num = (short)1898657639;
			short num2 = num;
			num = (short)1613117287;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1499332608;
				short num3 = num;
				num = (short)2109341696;
				if (num != 0)
				{
				}
				bool flag = false;
				try
				{
					num = (short)2105737222;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (this.d)
							{
								num = (short)1286340613;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1035862026;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_100;
						case 2:
							num = (short)1506344961;
							if (num != 0)
							{
							}
							this.d = true;
							num = (short)1573519371;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_261;
						case 4:
							if (flag)
							{
								num = (short)2055208962;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_263;
						case 5:
							result = true;
							num = (short)1745354755;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						case 7:
							goto IL_27B;
						case 8:
							this.a.getFilePackageEncryptionStatus(out flag);
							num = (short)319160321;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1333002240;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (this.a.openAndGetFilePackage(this.b, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺎펐꒒ꖔ꺖꺘\ude9aꖜ늞骢钦蒨骪鲬쮮蒰麲蒶﮸ﺺ邼达藆杻跊迌ￎ铔", a_), out this.e) >= 0)
							{
								num = (short)1460011016;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_100;
						case 11:
							goto IL_263;
						}
						IL_DA:
						if (global::System.IO.File.Exists(this.b))
						{
							num = (short)2124611593;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_263;
						IL_100:
						num = (short)766836740;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_263:
						num = (short)2145845255;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_261:
					break;
					IL_27B:
					return flag;
				}
				catch
				{
					throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						this.UpgradeFilePath
					}));
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000FE560 File Offset: 0x000FC760
		internal bool CheckFileContentsValid()
		{
			int a_ = 10;
			int num;
			short num2;
			string componentName;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)494534657;
						if (num2 != 0)
						{
						}
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8c쮎얐튒", a_);
						num2 = (short)54263823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)463994880;
						short num3 = num2;
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)218497036;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B8;
					}
					case 2:
						return false;
					case 3:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)391774212;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_25C;
					case 4:
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐킒", a_);
						num2 = (short)679346187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						return false;
					case 6:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)1831337993;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 7:
						return false;
					case 8:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)444465154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B8;
					case 9:
						return false;
					case 10:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)1809514496;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌즎욐힒", a_);
						num2 = (short)741212173;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)1801846789;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_25C;
					case 12:
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌즎욐킒", a_);
						num2 = (short)1254555656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)543293447;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B8;
					case 14:
						return false;
					case 15:
						if (this.selectCurrentFile(componentName) < 1)
						{
							num2 = (short)38666254;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐튒", a_);
						num2 = (short)95027203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_59;
					IL_1B8:
					componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌즎욐\uda92", a_);
					num2 = (short)76742662;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_25C:
					componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즌즎욐튒", a_);
					num2 = (short)1630419831;
					short num4 = num2;
					num2 = (short)1085225847;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						num2 = (short)1719795712;
						if (num2 != 0)
						{
						}
						num2 = (short)1098842113;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return false;
			}
			IL_59:
			componentName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얌즎욐삒", a_);
			IL_68:
			num2 = (short)597229578;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000FE8E0 File Offset: 0x000FCAE0
		internal int selectCurrentFile(string ComponentName)
		{
			int a_ = 9;
			short num;
			int result;
			try
			{
				num = (short)1250509140;
				short num2 = num;
				num = (short)1417363796;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1382940673;
					if (num != 0)
					{
					}
					num = (short)547815424;
					if (num != 0)
					{
					}
					num3 = 0;
					global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(this.e));
					try
					{
						switch (0)
						{
						case 0:
							goto IL_DD;
						}
						int num4;
						for (;;)
						{
							IL_9B:
							switch (num4)
							{
							case 0:
								num = (short)316145669;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (xmlReader.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲏ\udd93ﶗ", a_))
								{
									num = (short)436666370;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EC;
							case 2:
								num = (short)532480011;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (xmlReader.MoveToAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲏ\uda93ﾙ", a_)))
								{
									num = (short)1574567946;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EC;
							case 4:
								goto IL_2CF;
							case 5:
								if (xmlReader.Value == ComponentName)
								{
									num = (short)95485958;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EC;
							case 6:
								num3++;
								num = (short)1189478407;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_1EC;
							case 8:
								if (!xmlReader.Read())
								{
									num = (short)1601044494;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1709965313;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_1EC;
							case 10:
								num = (short)1081737229;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								if (xmlReader.MoveToFirstAttribute())
								{
									num = (short)705429516;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EC;
							case 12:
								num = (short)1203306499;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								if (xmlReader.HasValue)
								{
									num = (short)2022965248;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EC;
							case 14:
								num = (short)621871108;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DD;
							IL_1EC:
							num = (short)310771720;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2CF:
						break;
						IL_DD:
						xmlReader.MoveToContent();
						num = (short)2117795849;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_9B;
					}
					finally
					{
						num = (short)35848192;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_303;
								}
								continue;
							case 1:
								goto IL_338;
							case 2:
								((global::System.IDisposable)xmlReader).Dispose();
								num = (short)491388929;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_303:
							if (xmlReader == null)
							{
								break;
							}
							num = (short)1021378562;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_338:;
					}
					break;
				}
				}
				result = num3;
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			num = (short)493879296;
			short num5 = num;
			return result;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000FECAC File Offset: 0x000FCEAC
		internal bool CheckFileDestinatioInfoValid(string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_93;
			}
			short num;
			int num3;
			string text;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1420191865;
				short num2 = num;
				num = (short)1378248825;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)810024961;
					if (num != 0)
					{
					}
					num = (short)1975058432;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						text = text.Trim();
						num = (short)985923588;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						result = true;
						num = (short)1268973571;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1607335936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						return result;
					case 4:
						goto IL_115;
					}
					goto IL_93;
				}
				IL_115:
				num = (short)1140064256;
				short num4 = num;
				if (modelNumber.Trim()[0] != text[0])
				{
					break;
				}
				num = (short)682098689;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_93:
			result = false;
			text = (text = this.getFilePackageDestinationInfo());
			num = (short)1325858818;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000FEE2C File Offset: 0x000FD02C
		internal string getFilePackageDestinationInfo()
		{
			int a_ = 10;
			string text = string.Empty;
			short num;
			string result;
			try
			{
				num = (short)1803799950;
				short num2 = num;
				num = (short)2024918414;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1147142144;
					if (num != 0)
					{
					}
					global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(this.e));
					try
					{
						num = (short)971571205;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_1E0;
							case 1:
								num = (short)52363271;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1E0;
							case 3:
								num = (short)1610022918;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (!xmlReader.Read())
								{
									num = (short)1296302080;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)717684744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_BF;
								}
								continue;
							case 6:
								if (xmlReader.HasValue)
								{
									num = (short)1830223882;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 7:
								if (xmlReader.MoveToAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("﶐얔滛ﲜ쒠삤풦\udda8슪쎬캮얰\udab2\udab4\ud9b6햺\udbbc킾", a_)))
								{
									num = (short)204734467;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 8:
								if (xmlReader.MoveToFirstAttribute())
								{
									num = (short)473956353;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 9:
								goto IL_1F7;
							case 10:
								text = xmlReader.Value;
								num = (short)2097610754;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_119:
							num = (short)364838916;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_BF:
							goto IL_119;
							IL_1E0:
							num = (short)1448869897;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1F7:;
					}
					finally
					{
						num = (short)2111438848;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_229;
								}
								continue;
							case 1:
								goto IL_25C;
							case 2:
								((global::System.IDisposable)xmlReader).Dispose();
								num = (short)672464897;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_229:
							if (xmlReader == null)
							{
								break;
							}
							num = (short)738983938;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_25C:;
					}
					break;
				}
				}
				result = text;
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			num = (short)989921280;
			short num4 = num;
			num = (short)1801584641;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000FF144 File Offset: 0x000FD344
		internal bool CheckFileDestinatioInfoValidForBBF(string modelNumber)
		{
			short num = (short)1153761281;
			if (num != 0)
			{
			}
			num = (short)1816395776;
			short num2 = num;
			bool result = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				int num3;
				string bundleName;
				for (;;)
				{
					IL_60:
					switch (num3)
					{
					case 0:
						goto IL_165;
					case 1:
						num = (short)1034682371;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (modelNumber[0] != 'M')
						{
							num = (short)38338561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					case 3:
						if (modelNumber[0] == 'L')
						{
							num = (short)955908096;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_242;
					case 4:
						if (global::CommonUtility.BundleNameUtility.IsMobileBBF(bundleName))
						{
							num = (short)155058185;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_242;
					case 5:
						goto IL_D9;
					case 6:
						goto IL_259;
					case 7:
						num = (short)663814152;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (modelNumber[0] != 'H')
						{
							num = (short)1213923333;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					case 9:
						num = (short)878575618;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_242;
					case 11:
						if (global::CommonUtility.BundleNameUtility.IsPortableBBF(bundleName))
						{
							num = (short)475463687;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					}
					goto IL_96;
					IL_D9:
					num = (short)536518208;
					short num4 = num;
					num = (short)235707968;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num = (short)708313088;
						if (num != 0)
						{
						}
						num = (short)774832132;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_165:
					result = true;
					num = (short)920453130;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_242:
					num = (short)1429602310;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_259:
				return result;
				IL_96:
				bundleName = string.Empty;
				bundleName = this.GetFileTargetModelNumberForBBF();
				num = (short)1233321995;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_60;
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			return result;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000FF3EC File Offset: 0x000FD5EC
		public string GetFileTargetModelNumberForBBF()
		{
			short num = (short)701038593;
			if (num != 0)
			{
			}
			num = (short)229310464;
			switch (num)
			{
			default:
			{
				num = (short)1127940096;
				short num2 = num;
				string result = string.Empty;
				goto IL_75;
				try
				{
					byte[] array;
					for (;;)
					{
						IL_75:
						array = new byte[64];
						global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
						try
						{
							long offset = 24L;
							fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
							fileStream.Read(array, 0, 64);
						}
						finally
						{
							num = (short)1327890434;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)1044709377;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_10F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_DA;
									}
									continue;
								}
								IL_DA:
								if (fileStream == null)
								{
									break;
								}
								num = (short)2029715456;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_10F:;
						}
						num = (short)987629309;
						short num4 = num;
						num = (short)812058365;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_148;
						}
					}
					IL_148:
					num = (short)1045364736;
					if (num != 0)
					{
					}
					char[] trimChars = new char[]
					{
						'\0',
						' ',
						'\r',
						'\n'
					};
					result = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
				}
				catch
				{
					throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						this.UpgradeFilePath
					}));
				}
				return result;
			}
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000FF5D8 File Offset: 0x000FD7D8
		public string GetFileTargetModelNumber()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string filePackageDestinationInfo;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1890358102;
					short num3 = num2;
					num2 = (short)1292407638;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)108593152;
						if (num2 != 0)
						{
						}
						result = filePackageDestinationInfo.Trim();
						break;
					}
					num2 = (short)1073020929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					if (!string.IsNullOrEmpty(filePackageDestinationInfo))
					{
						num2 = (short)372113408;
						short num4 = num2;
						num2 = (short)1454571521;
						if (num2 != 0)
						{
						}
						num2 = (short)2117206016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = string.Empty;
			filePackageDestinationInfo = this.getFilePackageDestinationInfo();
			num2 = (short)201392130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000FF700 File Offset: 0x000FD900
		public string GetBBFSuiteVersion()
		{
			short num = (short)793903104;
			switch (num)
			{
			default:
			{
				num = (short)797966336;
				short num2 = num;
				string result = string.Empty;
				goto IL_4E;
				try
				{
					byte[] array;
					for (;;)
					{
						IL_4E:
						array = new byte[16];
						global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
						try
						{
							long offset = 88L;
							fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
							fileStream.Read(array, 0, 16);
						}
						finally
						{
							num = (short)720961538;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)640024577;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_E7;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B2;
									}
									continue;
								}
								IL_B2:
								if (fileStream == null)
								{
									break;
								}
								num = (short)1203699712;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_E7:;
						}
						num = (short)84118705;
						short num4 = num;
						num = (short)133139633;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11E;
						}
					}
					IL_11E:
					num = (short)1951727617;
					if (num != 0)
					{
					}
					num = (short)857341952;
					if (num != 0)
					{
					}
					char[] trimChars = new char[]
					{
						'\0',
						' ',
						'\r',
						'\n'
					};
					result = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
				}
				catch
				{
					throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						this.UpgradeFilePath
					}));
				}
				return result;
			}
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000FF8E8 File Offset: 0x000FDAE8
		public string GetFileComponentVersion(string componentName, bool noPeriods = true)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					text = text.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꮄ", a_), "");
					num2 = (short)669188101;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (noPeriods)
					{
						num2 = (short)1772224512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 2:
				{
					text = text.TrimEnd(global::System.Array.Empty<char>());
					char[] trimChars = new char[]
					{
						'\0',
						' ',
						'\r',
						'\n'
					};
					text = text.TrimEnd(trimChars);
					goto IL_D5;
				}
				case 3:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)665649154;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 4:
				{
					num2 = (short)42860544;
					short num3 = num2;
					text = this.getCurrentFileVersion(componentName);
					num2 = (short)585382442;
					short num4 = num2;
					num2 = (short)1515731498;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5;
					default:
						num2 = (short)796459009;
						if (num2 != 0)
						{
						}
						num2 = (short)999751680;
						if (num2 != 0)
						{
						}
						num2 = (short)1333657603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					return text;
				case 6:
					if (this.selectCurrentFile(componentName) > 0)
					{
						num2 = (short)1856176132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				}
				goto IL_35;
				IL_D5:
				num2 = (short)2017329153;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_35:
			text = string.Empty;
			num2 = (short)1281687558;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000FFAE4 File Offset: 0x000FDCE4
		internal string getCurrentFileVersion(string ComponentName)
		{
			int a_ = 19;
			short num2;
			string result;
			try
			{
				string text = string.Empty;
				global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(this.e));
				try
				{
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					int num;
					for (;;)
					{
						IL_2C:
						switch (num)
						{
						case 0:
							if (xmlReader.Value == ComponentName)
							{
								num2 = (short)276234246;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 1:
							num2 = (short)1820786688;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							num2 = (short)1456537607;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							num2 = (short)970850315;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							if (xmlReader.MoveToFirstAttribute())
							{
								num2 = (short)244776962;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 5:
							if (xmlReader.MoveToAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("鍊좝얟킡힣쾥잧쒩", a_)))
							{
								num2 = (short)1682046979;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 6:
							num2 = (short)155516933;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 7:
							if (xmlReader.MoveToAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("鍊킝솟쾡솣", a_)))
							{
								num2 = (short)1022230540;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 8:
						{
							num2 = (short)1347429293;
							short num3 = num2;
							num2 = (short)1629496237;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_20D;
							default:
								num2 = (short)1834024960;
								if (num2 != 0)
								{
								}
								if (!xmlReader.Read())
								{
									num2 = (short)1475674127;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)86835210;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 9:
							if (xmlReader.HasValue)
							{
								num2 = (short)1814364161;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 10:
							if (xmlReader.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("鍊힝풟잡즣", a_))
							{
								num2 = (short)449773584;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 11:
							if (xmlReader.HasValue)
							{
								num2 = (short)31784977;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 12:
							num2 = (short)2022113289;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 13:
							goto IL_342;
						case 14:
							goto IL_32A;
						case 15:
							goto IL_20D;
						case 16:
							num2 = (short)1367539716;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 17:
							text = xmlReader.Value;
							num2 = (short)2092367886;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 18:
							goto IL_189;
						}
						goto IL_7E;
						IL_189:
						num2 = (short)506265608;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_32A:
						num2 = (short)1759772685;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_20D:
						goto IL_32A;
					}
					IL_342:
					goto IL_3AB;
					IL_7E:
					xmlReader.MoveToContent();
					num2 = (short)797245458;
					num = (int)((global::System.IntPtr)num2);
					goto IL_2C;
				}
				finally
				{
					num2 = (short)746258434;
					int num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							((global::System.IDisposable)xmlReader).Dispose();
							num2 = (short)238092289;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_3A8;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_374;
							}
							continue;
						}
						IL_374:
						if (xmlReader == null)
						{
							break;
						}
						num2 = (short)733347840;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_3A8:;
				}
				IL_3AB:
				result = text;
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			num2 = (short)1559363585;
			if (num2 != 0)
			{
			}
			num2 = (short)472645632;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000FFF48 File Offset: 0x000FE148
		public void GetComponentData(string componentName, out string data)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)748105837;
					short num3 = num2;
					num2 = (short)1061695597;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1520369664;
						if (num2 != 0)
						{
						}
						data = this.getCurrentFileData(componentName);
						break;
					}
					num2 = (short)11206657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
				{
					num2 = (short)240975872;
					short num4 = num2;
					if (this.selectCurrentFile(componentName) > 0)
					{
						num2 = (short)1222770688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1889206273;
			if (num2 != 0)
			{
			}
			data = string.Empty;
			num2 = (short)1752104962;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00100074 File Offset: 0x000FE274
		internal string getCurrentFileData(string ComponentName)
		{
			int a_ = 3;
			short num;
			string result;
			try
			{
				num = (short)1298792448;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)2056585217;
					if (num != 0)
					{
					}
					string text = string.Empty;
					global::System.Xml.XmlReaderSettings xmlReaderSettings = new global::System.Xml.XmlReaderSettings();
					xmlReaderSettings.IgnoreWhitespace = true;
					global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(this.e), xmlReaderSettings);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						for (;;)
						{
							IL_7F:
							switch (num2)
							{
							case 0:
							{
								if (!xmlReader.MoveToAttribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삍ﾑ", a_)))
								{
									goto IL_261;
								}
								num = (short)2114297541;
								short num3 = num;
								num = (short)31628997;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2E3;
								default:
									num = (short)2144272384;
									if (num != 0)
									{
									}
									num = (short)1698627589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)1354629134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)184287238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)55443465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_261;
							case 5:
								num = (short)49872908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (xmlReader.Value == ComponentName)
								{
									num = (short)1377435651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_261;
							case 7:
								if (xmlReader.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍", a_))
								{
									num = (short)840761362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_193;
							case 8:
								if (xmlReader.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잍煉", a_))
								{
									num = (short)255459341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_261;
							case 9:
								goto IL_193;
							case 10:
								if (xmlReader.MoveToFirstAttribute())
								{
									num = (short)388104209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_261;
							case 11:
								goto IL_261;
							case 12:
								if (xmlReader.HasValue)
								{
									num = (short)1214185474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_261;
							case 13:
								num = (short)939327498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_3E1;
							case 15:
								if (!xmlReader.Read())
								{
									num = (short)746061835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1745027079;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								if (!xmlReader.Read())
								{
									num = (short)457900033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2E3;
							case 17:
								num = (short)436797440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
								text = (global::System.Xml.Linq.XNode.ReadFrom(xmlReader) as global::System.Xml.Linq.XElement).Value.Trim();
								num = (short)1433665540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 19:
								goto IL_261;
							}
							goto IL_D6;
							IL_193:
							num = (short)771424271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_261:
							num = (short)770441232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2E3:
							num = (short)2103115784;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3E1:
						goto IL_450;
						IL_D6:
						xmlReader.MoveToContent();
						num = (short)1181351955;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_7F;
					}
					finally
					{
						num = (short)1565917186;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)xmlReader).Dispose();
								num = (short)1041825793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_44D;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_417;
								}
								continue;
							}
							IL_417:
							if (xmlReader == null)
							{
								break;
							}
							num = (short)339673088;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_44D:;
					}
					IL_450:
					result = text;
					break;
				}
				}
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			num = (short)761987072;
			short num4 = num;
			return result;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00100554 File Offset: 0x000FE754
		public bool ExtractDataToFile(string componentName, string filePath)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_97;
				case 1:
					goto IL_109;
				case 2:
				{
					num2 = (short)1543176192;
					short num3 = num2;
					this.a.extractCurrentFileToFile(filePath);
					num2 = (short)992946847;
					short num4 = num2;
					num2 = (short)1786718879;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)363986944;
						if (num2 != 0)
						{
						}
						num2 = (short)947650561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (this.selectCurrentFile(componentName) > 0)
					{
						num2 = (short)673120258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = false;
					num2 = (short)1159987200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_97:
			IL_109:
			num2 = (short)1435566081;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = true;
			num2 = (short)1414725635;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00100694 File Offset: 0x000FE894
		public bool ComponentPresent(string componentName)
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num3;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)2027743702;
				short num2 = num;
				num = (short)1634527702;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_65;
				default:
					num = (short)36372480;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (this.selectCurrentFile(componentName) > 0)
						{
							num = (short)1712521217;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						result = true;
						num = (short)1676148738;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_E5;
					}
					goto IL_65;
				}
			}
			IL_E5:
			num = (short)1513816065;
			if (num != 0)
			{
			}
			return result;
			IL_65:
			result = false;
			num = (short)1244659712;
			short num4 = num;
			num = (short)457441280;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x001007B4 File Offset: 0x000FE9B4
		public bool verifyBBFMagicNumber()
		{
			int a_ = 12;
			short num = (short)1353358954;
			short num2 = num;
			num = (short)631610986;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9B;
			case 1:
				break;
			default:
			{
				num = (short)975962112;
				short num3 = num;
				break;
			}
			}
			num = (short)1946484736;
			if (num != 0)
			{
			}
			num = (short)964296704;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_9B:
				bool result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_C4;
					}
					global::System.IO.FileStream fileStream;
					byte[] array;
					string text;
					for (;;)
					{
						IL_A9:
						switch (num4)
						{
						case 0:
							try
							{
								fileStream.Read(array, 0, 8);
								goto IL_18D;
							}
							finally
							{
								num = (short)1362427904;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_136;
										}
										continue;
									case 1:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1416626178;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_16D;
									}
									IL_136:
									if (fileStream == null)
									{
										break;
									}
									num = (short)380502017;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_16D:;
							}
							goto IL_170;
							IL_18D:
							text = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length);
							num = (short)1560936450;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1E8;
						case 2:
							if (global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾎펐톒펔ﾖﶘ\udd9c", a_) == text)
							{
								num = (short)1835401219;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 3:
							goto IL_170;
						case 4:
							goto IL_202;
						}
						goto IL_C4;
						IL_170:
						result = true;
						num = (short)769851393;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E8:
						num = (short)1228603396;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_202:
					goto IL_224;
					IL_C4:
					array = new byte[8];
					text = string.Empty;
					fileStream = global::System.IO.File.OpenRead(this.b);
					num = (short)1448869888;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_A9;
				}
				catch
				{
					throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						this.UpgradeFilePath
					}));
				}
				IL_224:
				num = (short)115081217;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00100A44 File Offset: 0x000FEC44
		public bool verifyChecksum()
		{
			short num = (short)2051458338;
			short num2 = num;
			num = (short)499369250;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BA;
			case 1:
				break;
			default:
			{
				num = (short)2027356160;
				short num3 = num;
				break;
			}
			}
			num = (short)941948928;
			if (num != 0)
			{
			}
			num = (short)2027552769;
			if (num != 0)
			{
			}
			num = (short)778043392;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_BA:
				bool flag = false;
				bool result;
				try
				{
					global::SpecialFeatures.Flashport.Crc32 crc = new global::SpecialFeatures.Flashport.Crc32();
					byte[] array = new byte[4];
					byte[] array2 = new byte[4];
					global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_106;
						}
						int num5;
						byte[] array3;
						int num6;
						for (;;)
						{
							IL_EB:
							switch (num4)
							{
							case 0:
								goto IL_1AC;
							case 1:
								goto IL_1AC;
							case 2:
							{
								if (num5 >= array3.Length)
								{
									num = (short)1703936003;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								byte b = array3[num5];
								array2[num6] = b;
								num6++;
								num5++;
								num = (short)566951937;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								flag = array.SequenceEqual(array2);
								num = (short)1918763012;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_208;
							}
							goto IL_106;
							IL_1AC:
							num = (short)1307705346;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_208:
						goto IL_277;
						IL_106:
						byte[] buffer = new byte[fileStream.Length - 4L];
						long offset = fileStream.Length - 4L;
						fileStream.Read(buffer, 0, (int)fileStream.Length - 4);
						fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
						fileStream.Read(array, 0, 4);
						num6 = 0;
						array3 = crc.ComputeHash(buffer);
						num5 = 0;
						num = (short)1834287104;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_EB;
					}
					finally
					{
						num = (short)2141519872;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_23C;
								}
								continue;
							case 1:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)756154370;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_274;
							}
							IL_23C:
							if (fileStream == null)
							{
								break;
							}
							num = (short)1798832129;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_274:;
					}
					IL_277:
					result = flag;
				}
				catch
				{
					throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
					{
						this.UpgradeFilePath
					}));
				}
				return result;
			}
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00100D24 File Offset: 0x000FEF24
		public global::System.Collections.Generic.Dictionary<string, byte[]> GetAllSectionsData()
		{
			int a_ = 6;
			short num = (short)1683095552;
			short num2 = num;
			num = (short)1144427517;
			short num3 = num;
			num = (short)933270525;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2060189696;
				if (num != 0)
				{
				}
				num = (short)433192960;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::System.Collections.Generic.Dictionary<string, byte[]> dictionary = new global::System.Collections.Generic.Dictionary<string, byte[]>();
			int num5 = 512;
			int num6 = this.GetImageSectionsCount() - 1;
			global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_129;
				}
				int num4;
				int num12;
				for (;;)
				{
					IL_CA:
					int num10;
					int num13;
					switch (num4)
					{
					case 0:
					{
						string text;
						string key = global::System.Guid.NewGuid().ToString() + text;
						byte[] array;
						dictionary.Add(key, array);
						num = (short)1081081867;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string @string;
						if (!global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즈즊쾌즎ﺒ힖", a_).Equals(@string))
						{
							num = (short)2109276163;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						fileStream.Seek(2L, global::System.IO.SeekOrigin.Current);
						byte[] array2 = new byte[2];
						fileStream.Read(array2, 0, array2.Length);
						int num7 = (int)global::System.BitConverter.ToInt16(array2, 0);
						fileStream.Seek(2L, global::System.IO.SeekOrigin.Current);
						byte[] array3 = new byte[2];
						fileStream.Read(array3, 0, array3.Length);
						int num8 = (int)global::System.BitConverter.ToInt16(array3, 0);
						fileStream.Seek(8L, global::System.IO.SeekOrigin.Current);
						byte[] array4 = new byte[4];
						fileStream.Read(array4, 0, array4.Length);
						int num9 = global::System.BitConverter.ToInt32(array4, 0);
						fileStream.Seek(4L, global::System.IO.SeekOrigin.Current);
						byte[] array5 = new byte[8];
						fileStream.Read(array5, 0, array5.Length);
						string string2 = global::System.Text.Encoding.ASCII.GetString(array5);
						byte[] array6 = new byte[16];
						fileStream.Read(array6, 0, array6.Length);
						global::System.Text.Encoding.ASCII.GetString(array6);
						fileStream.Seek(4L, global::System.IO.SeekOrigin.Current);
						fileStream.Seek(4L, global::System.IO.SeekOrigin.Current);
						num = (short)102105104;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)860946432;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_572;
					}
					case 3:
						dictionary.Clear();
						num = (short)876216328;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (0 < num10)
						{
							num = (short)240058385;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31C;
					case 5:
					{
						int num7;
						int num8;
						int num9;
						double num11 = global::System.Math.Pow(2.0, (double)num7) * (double)num9 - (double)((num8 == 3) ? 256 : 0);
						num = (short)2098397190;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						double num11;
						if (num11 <= 2147483647.0)
						{
							num = (short)1691942931;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_572;
					}
					case 7:
						goto IL_481;
					case 8:
						goto IL_407;
					case 9:
					{
						if (num12 >= num6)
						{
							num = (short)1101201426;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num13 = 0;
						byte[] array7 = new byte[8];
						fileStream.Read(array7, 0, array7.Length);
						string @string = global::System.Text.Encoding.ASCII.GetString(array7, 0, array7.Length);
						num = (short)678559745;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_153;
					case 11:
						goto IL_572;
					case 12:
						goto IL_5D3;
					case 13:
						fileStream.Seek(256L, global::System.IO.SeekOrigin.Current);
						num = (short)1316814858;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_481;
					case 15:
						goto IL_31C;
					case 16:
					{
						int num8;
						if (num8 == 3)
						{
							num = (short)1447297037;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					}
					case 17:
						num = (short)1032257556;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1085603852;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						double num11;
						byte[] array = new byte[(int)num11];
						fileStream.Read(array, 0, array.Length);
						num13 += (int)num11;
						string string2;
						string text = this.ValidateImageSectionName(string2);
						num = (short)1250885634;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (num10 < 16)
						{
							num = (short)1993474049;
							if (num != 0)
							{
							}
							num = (short)1186398229;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31C;
					case 21:
						fileStream.Seek((long)num10, global::System.IO.SeekOrigin.Current);
						num = (short)683540495;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_129;
					IL_153:
					num = (short)337248261;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_31C:
					num12++;
					num = (short)975110151;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_481:
					num = (short)420151305;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_572:
					num10 = 16 - num13 % 16;
					num = (short)1019346948;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_407:
				IL_5D3:
				return dictionary;
				IL_129:
				fileStream.Seek((long)num5, global::System.IO.SeekOrigin.Begin);
				num12 = 0;
				num = (short)409403406;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_CA;
			}
			finally
			{
				num = (short)1211760640;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_607;
						}
						continue;
					case 1:
						((global::System.IDisposable)fileStream).Dispose();
						num = (short)1835859970;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_63E;
					}
					IL_607:
					if (fileStream == null)
					{
						break;
					}
					num = (short)983105537;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_63E:;
			}
			return dictionary;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00101390 File Offset: 0x000FF590
		public global::System.Collections.Generic.Dictionary<string, byte[]> GetTargetSectionsData(string imageSectionName)
		{
			int a_ = 8;
			short num = (short)2099838976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.Generic.Dictionary<string, byte[]> dictionary;
				for (;;)
				{
					IL_30:
					int num6;
					global::System.IO.FileStream fileStream;
					int num11;
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(imageSectionName))
						{
							num = (short)1940717569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68D;
					case 1:
						return dictionary;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_18D;
							}
							int num5;
							for (;;)
							{
								IL_12E:
								int num3;
								int num7;
								switch (num2)
								{
								case 0:
									goto IL_4D2;
								case 1:
									goto IL_378;
								case 2:
									dictionary.Clear();
									num = (short)1333788680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (num3 < 16)
									{
										num = (short)537657354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_354;
								case 4:
								{
									string @string;
									if (imageSectionName.Equals(@string.TrimEnd(new char[]
									{
										'\0',
										' ',
										'\r',
										'\n'
									})))
									{
										num = (short)1607860241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_444;
								}
								case 5:
								{
									int num4;
									if (num4 == 3)
									{
										num = (short)1250033680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_378;
								}
								case 6:
								{
									if (num5 >= num6)
									{
										num = (short)442695699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num7 = 0;
									byte[] array = new byte[8];
									fileStream.Read(array, 0, array.Length);
									string string2 = global::System.Text.Encoding.ASCII.GetString(array, 0, array.Length);
									num = (short)1687552013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									int num4;
									int num9;
									int num10;
									double num8 = global::System.Math.Pow(2.0, (double)num9) * (double)num10 - (double)((num4 == 3) ? 256 : 0);
									num = (short)1009909769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_438;
								case 9:
								{
									double num8;
									if (num8 <= 2147483647.0)
									{
										num = (short)2111635474;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_444;
								}
								case 10:
									fileStream.Seek((long)num3, global::System.IO.SeekOrigin.Current);
									num = (short)1121124373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (0 < num3)
									{
										num = (short)787218447;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_354;
								case 12:
									goto IL_61B;
								case 13:
								{
									string string2;
									if (!global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮊쾌춎힐朗\ud998", a_).Equals(string2))
									{
										num = (short)1620639746;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									fileStream.Seek(2L, global::System.IO.SeekOrigin.Current);
									byte[] array2 = new byte[2];
									fileStream.Read(array2, 0, array2.Length);
									int num9 = (int)global::System.BitConverter.ToInt16(array2, 0);
									fileStream.Seek(2L, global::System.IO.SeekOrigin.Current);
									byte[] array3 = new byte[2];
									fileStream.Read(array3, 0, array3.Length);
									int num4 = (int)global::System.BitConverter.ToInt16(array3, 0);
									fileStream.Seek(8L, global::System.IO.SeekOrigin.Current);
									byte[] array4 = new byte[4];
									fileStream.Read(array4, 0, array4.Length);
									int num10 = global::System.BitConverter.ToInt32(array4, 0);
									fileStream.Seek(4L, global::System.IO.SeekOrigin.Current);
									byte[] array5 = new byte[8];
									fileStream.Read(array5, 0, array5.Length);
									string @string = global::System.Text.Encoding.ASCII.GetString(array5);
									byte[] array6 = new byte[16];
									fileStream.Read(array6, 0, array6.Length);
									global::System.Text.Encoding.ASCII.GetString(array6);
									fileStream.Seek(4L, global::System.IO.SeekOrigin.Current);
									fileStream.Seek(4L, global::System.IO.SeekOrigin.Current);
									num = (short)507707397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									goto IL_4D2;
								case 15:
									num = (short)1925513219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									fileStream.Seek(256L, global::System.IO.SeekOrigin.Current);
									num = (short)613220353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									string @string;
									string key = global::System.Guid.NewGuid().ToString() + this.ValidateImageSectionName(@string);
									byte[] array7;
									dictionary.Add(key, array7);
									num = (short)1336147988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									double num8;
									byte[] array7 = new byte[(int)num8];
									fileStream.Read(array7, 0, array7.Length);
									num7 += (int)num8;
									num = (short)652083204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									num = (short)580780044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_557;
								case 21:
									goto IL_354;
								}
								goto IL_18D;
								IL_354:
								num5++;
								num = (short)1371734016;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_378:
								num = (short)2034302983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_444:
								num3 = 16 - num7 % 16;
								num = (short)2020605963;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D2:
								num = (short)1889992710;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_438:
							IL_557:
							IL_61B:
							return dictionary;
							IL_18D:
							fileStream.Seek((long)num11, global::System.IO.SeekOrigin.Begin);
							num5 = 0;
							num = (short)54329358;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_12E;
						}
						finally
						{
							num = (short)736493568;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_653;
									}
									continue;
								case 1:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)212729858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_68A;
								}
								IL_653:
								if (fileStream == null)
								{
									break;
								}
								num = (short)433717249;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_68A:;
						}
						goto IL_68D;
					}
					goto IL_43;
					IL_68D:
					num11 = 512;
					num6 = this.GetImageSectionsCount() - 1;
					fileStream = global::System.IO.File.OpenRead(this.b);
					num = (short)2118975490;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_43:
				num = (short)790888448;
				short num12 = num;
				num = (short)651628021;
				short num13 = num;
				num = (short)519572981;
				switch ((num13 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)229507072;
					if (num != 0)
					{
					}
					num = (short)1453457409;
					if (num != 0)
					{
					}
					dictionary = new global::System.Collections.Generic.Dictionary<string, byte[]>();
					break;
				}
				num = (short)426049536;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00101A84 File Offset: 0x000FFC84
		public string ValidateImageSectionName(string imageName)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			string imageName2;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					while (global::CommonUtility.BundleNameUtility.IsBBFImageSection(imageName2))
					{
						num2 = (short)1542256908;
						short num3 = num2;
						num2 = (short)1094383884;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num2 = (short)434176000;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1850277889;
						if (num2 != 0)
						{
						}
						num2 = (short)737542144;
						if (num2 != 0)
						{
						}
						num2 = (short)1206845441;
						num = (int)((global::System.IntPtr)num2);
						goto IL_13;
					}
					num2 = (short)1678508034;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_112;
				case 2:
					if (global::CommonUtility.BundleNameUtility.IsCVNImageSection(imageName2))
					{
						num2 = (short)460062723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16A;
				case 3:
					goto IL_159;
				}
				goto IL_29;
			}
			IL_112:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦆ", a_);
			IL_159:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦆﶊ", a_);
			IL_16A:
			return string.Empty;
			IL_29:
			imageName2 = imageName.TrimEnd(new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			});
			num2 = (short)1233649664;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00101C00 File Offset: 0x000FFE00
		public int GetImageSectionsCount()
		{
			short num;
			int result;
			try
			{
				num = (short)1990721536;
				switch (num)
				{
				default:
				{
					byte[] array = new byte[4];
					global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
					try
					{
						long offset = 20L;
						fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
						fileStream.Read(array, 0, 4);
					}
					finally
					{
						num = (short)1108803586;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_108;
							case 1:
							{
								num = (short)911767965;
								short num3 = num;
								num = (short)772307357;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_10A;
								default:
									num = (short)493092864;
									if (num != 0)
									{
									}
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)2041643008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_82;
								}
								continue;
							}
							IL_82:
							if (fileStream == null)
							{
								break;
							}
							num = (short)1985478657;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_108:
						IL_10A:;
					}
					result = global::System.BitConverter.ToInt32(array, 0);
					break;
				}
				}
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			num = (short)1487273985;
			if (num != 0)
			{
			}
			num = (short)1862991872;
			short num4 = num;
			return result;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00101DC8 File Offset: 0x000FFFC8
		public int GetValidationBlockOffset()
		{
			short num;
			int result;
			try
			{
				num = (short)352845824;
				switch (num)
				{
				default:
				{
					byte[] array = new byte[4];
					global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
					try
					{
						num = (short)1021706241;
						if (num != 0)
						{
						}
						long offset = 104L;
						fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
						fileStream.Read(array, 0, 4);
					}
					finally
					{
						num = (short)402784258;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_12D;
							case 1:
							{
								num = (short)132099118;
								short num3 = num;
								num = (short)2020977710;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_12F;
								default:
									num = (short)1349124096;
									if (num != 0)
									{
									}
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)668401664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A7;
								}
								continue;
							}
							IL_A7:
							if (fileStream == null)
							{
								break;
							}
							num = (short)302120961;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_12D:
						IL_12F:;
					}
					result = global::System.BitConverter.ToInt32(array, 0);
					break;
				}
				}
			}
			catch
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
				{
					this.UpgradeFilePath
				}));
			}
			num = (short)194052096;
			short num4 = num;
			return result;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00101F8C File Offset: 0x0010018C
		public byte[] GetBBFFileData()
		{
			short num = (short)552125343;
			short num2 = num;
			num = (short)2036450207;
			switch (num2 == num)
			{
			}
			num = (short)291700736;
			if (num != 0)
			{
			}
			num = (short)1815740417;
			if (num != 0)
			{
			}
			num = (short)9961472;
			short num3 = num;
			return global::System.IO.File.ReadAllBytes(this.b);
		}

		// Token: 0x040005FA RID: 1530
		private global::Encaten.IEncateWrapper a;

		// Token: 0x040005FB RID: 1531
		private string b;

		// Token: 0x040005FC RID: 1532
		private const string c = "1B7097E8-D9E3-11d5-A3BE-0060B0FB015A";

		// Token: 0x040005FD RID: 1533
		private bool d;

		// Token: 0x040005FE RID: 1534
		private string e = string.Empty;

		// Token: 0x040005FF RID: 1535
		private const string f = "fileItem";

		// Token: 0x04000600 RID: 1536
		private const string g = "fileName";

		// Token: 0x04000601 RID: 1537
		private const string h = "filePackageDestinationInfo";

		// Token: 0x04000602 RID: 1538
		private const string i = "fileVersion";

		// Token: 0x04000603 RID: 1539
		private const string j = "fileData";

		// Token: 0x04000604 RID: 1540
		private const string k = "@BBFhdr@";

		// Token: 0x04000605 RID: 1541
		private const string l = "@BBFimg@";

		// Token: 0x04000606 RID: 1542
		private const int m = 64;

		// Token: 0x04000607 RID: 1543
		private const int n = 512;

		// Token: 0x04000608 RID: 1544
		private const int o = 256;

		// Token: 0x04000609 RID: 1545
		private const int p = 24;
	}
}
