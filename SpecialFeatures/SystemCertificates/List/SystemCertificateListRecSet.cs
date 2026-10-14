using System;
using System.IO;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001AE RID: 430
	[global::System.Serializable]
	public sealed class SystemCertificateListRecSet : global::AcpBusinessLayer.Recordset, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001450 RID: 5200 RVA: 0x00003868 File Offset: 0x00001A68
		public SystemCertificateListRecSet() : base(global::CommonResources.AppResources.System_Cerfiticate_List_ID, true, false, false, null)
		{
			this.SetValues();
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x001D4968 File Offset: 0x001D2B68
		public new void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1918310872;
			short num2 = num;
			num = (short)1728518616;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1701380096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1802633217;
			if (num != 0)
			{
			}
			num = (short)2021654528;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x001D4A18 File Offset: 0x001D2C18
		internal SystemCertificateListRecSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			this.SetValues();
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x001D4A58 File Offset: 0x001D2C58
		public override int MaxPool
		{
			get
			{
				short num = (short)2141675247;
				short num2 = num;
				num = (short)654728943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118423552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415446529;
				if (num != 0)
				{
				}
				num = (short)227082240;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet._MaxPool;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x001D4B08 File Offset: 0x001D2D08
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x001D4BC8 File Offset: 0x001D2DC8
		public override int Max
		{
			get
			{
				while (this._DynMax != -1)
				{
					short num = (short)832934693;
					short num2 = num;
					num = (short)435720997;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1296760833;
						if (num != 0)
						{
						}
						num = (short)1030815744;
						short num3 = num;
						num = (short)1240596480;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet._Max;
			}
			set
			{
				short num = (short)533921793;
				if (num != 0)
				{
				}
				num = (short)1031667712;
				short num2 = num;
				num = (short)2110439820;
				short num3 = num;
				num = (short)1088143756;
				switch (num3 == num)
				{
				}
				num = (short)381222912;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x001D4C78 File Offset: 0x001D2E78
		public override int Min
		{
			get
			{
				short num = (short)138805249;
				if (num != 0)
				{
				}
				num = (short)1181089792;
				short num2 = num;
				num = (short)1577317076;
				short num3 = num;
				num = (short)2069361364;
				switch (num3 == num)
				{
				}
				num = (short)1145307136;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet._Min;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x001D4D2C File Offset: 0x001D2F2C
		public override int CounterToMax
		{
			get
			{
				short num = (short)317111322;
				short num2 = num;
				num = (short)1448328218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1064894464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1076822017;
				if (num != 0)
				{
				}
				num = (short)702349312;
				if (num != 0)
				{
				}
				return this.Max - base.Count;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x001D4DE0 File Offset: 0x001D2FE0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1692614751;
				short num2 = num;
				num = (short)1520320607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364852736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151205377;
				if (num != 0)
				{
				}
				num = (short)1116405760;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x001D4E8C File Offset: 0x001D308C
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)378601472;
			switch (num)
			{
			default:
			{
				num = (short)488833024;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1961164800;
					short num3 = num;
					string text;
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C5;
							}
							for (;;)
							{
								IL_AA:
								switch (num2)
								{
								case 0:
								{
									num = (short)1193288722;
									short num4 = num;
									num = (short)349709330;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1E3;
									default:
										num = (short)202964992;
										if (num != 0)
										{
										}
										num = (short)1205338116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_221;
								case 2:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)363593728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_208;
								case 3:
									try
									{
										global::System.IO.File.Delete(text);
									}
									catch (global::System.Exception)
									{
									}
									goto IL_208;
								case 4:
									if (global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles.Length <= global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateCount)
									{
										goto IL_1E3;
									}
									goto IL_208;
								}
								goto IL_C5;
								IL_1E3:
								num = (short)1294860291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_208:
								num = (short)1924333569;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_221:
							goto IL_281;
							IL_C5:
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							byte[] array = new byte[fileStream.Length];
							fileStream.Read(array, 0, (int)fileStream.Length);
							global::AcpBusinessLayer.AcpVoiceFileStruct value = new global::AcpBusinessLayer.AcpVoiceFileStruct(text);
							value.voicefile = text;
							value.voiceData = new global::System.IO.MemoryStream(array, 0, array.Length, true, true);
							systemCertificateList.General.SecSysCertGeneralCertificateFileData_A43635.SetValue(value);
							systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Object.Value = global::System.IO.Path.GetFileName(text);
							num = (short)493355010;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_AA;
						}
						catch (global::System.Exception)
						{
							string message = global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
							{
								text
							});
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, message);
							goto IL_281;
						}
						goto IL_249;
					case 2:
						goto IL_249;
					}
					IL_7C:
					if (global::AcpCommonLib.AppInfoManager.LoadingVoiceData)
					{
						num = (short)1211432962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_249:
					text = global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles[global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateCount++];
					systemCertificateList = (record as global::SpecialFeatures.SystemCertificates.List.SystemCertificateList);
					num = (short)1868431361;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_281:
				num = (short)1547501569;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x001D5178 File Offset: 0x001D3378
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1771503617;
			if (num != 0)
			{
			}
			num = (short)256376832;
			short num2 = num;
			num = (short)23601621;
			short num3 = num;
			num = (short)648421845;
			switch (num3 == num)
			{
			}
			num = (short)468189184;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.SystemCertificates.List.SystemCertificateList(this);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x001D5228 File Offset: 0x001D3428
		internal void SetValues()
		{
			int a_ = 15;
			short num = (short)1311185999;
			short num2 = num;
			num = (short)1625627727;
			switch (num2 == num)
			{
			}
			num = (short)2031550464;
			short num3 = num;
			num = (short)1565130753;
			if (num != 0)
			{
			}
			num = (short)1616248832;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4228;
			base.SingleInstance = false;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯\udbb3\udbb5좷햹튻\udbbd꺿뛁飃藅귇룉룋ꟍ뛏믑럓럕곗뿙釛뿝軟菡菣菥藧迩苫髭곯ꇱ跳藵賷鿹釻뷽旿瀁瀃漅渇按漋漍搏眑堓缕欗渙䀛䴝够儡倣䌥䔧椩䤫尭䐯嬱刳張嬷嬹䠻嬽ి⭁㝃㉅᱇⡉⁋恍⡏㍑㥓㩕", a_);
			base.UIName = global::CommonResources.AppResources.System_Cerfiticate_List_ID;
			base.KeySeed = global::CommonResources.AppResources.System_Certificate_Alias_ID;
			base.DataTransferOrder = 70;
			base.HideRecordsFromTree = true;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x001D532C File Offset: 0x001D352C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemCertificateListRecSet()
		{
			short num = (short)7153131;
			short num2 = num;
			num = (short)601499115;
			switch (num2 == num)
			{
			}
			num = (short)1521418240;
			short num3 = num;
			num = (short)2117402624;
			if (num != 0)
			{
			}
			num = (short)822149121;
			if (num != 0)
			{
			}
			global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateCount = 0;
			global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet._MaxPool = int.MaxValue;
			global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet._Max = 5000;
			global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet._Min = 1;
		}

		// Token: 0x04000B21 RID: 2849
		public static string[] systemCertificateFiles;

		// Token: 0x04000B22 RID: 2850
		public static int systemCertificateCount;

		// Token: 0x04000B23 RID: 2851
		public static int _MaxPool;

		// Token: 0x04000B24 RID: 2852
		public static int _Max;

		// Token: 0x04000B25 RID: 2853
		internal int _DynMax;

		// Token: 0x04000B26 RID: 2854
		public static int _Min;
	}
}
