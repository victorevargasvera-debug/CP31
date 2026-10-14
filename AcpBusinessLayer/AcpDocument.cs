using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpFileHandlerLib;
using AcpUtility;
using Motorola.Common.BinarySerializer;

namespace AcpBusinessLayer
{
	// Token: 0x02000009 RID: 9
	public class AcpDocument : global::AcpCommonLib.Document
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00007C98 File Offset: 0x00005E98
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00007D44 File Offset: 0x00005F44
		public static string CpgVersionErrStr
		{
			get
			{
				short num = (short)455249648;
				short num2 = num;
				num = (short)333287152;
				switch (num2 == num)
				{
				}
				num = (short)1307377665;
				if (num != 0)
				{
				}
				num = (short)1111490560;
				if (num != 0)
				{
				}
				num = (short)121765888;
				short num3 = num;
				return global::AcpBusinessLayer.AcpDocument.a;
			}
			set
			{
				short num = (short)1798209956;
				short num2 = num;
				num = (short)532709796;
				switch (num2 == num)
				{
				}
				num = (short)1165230080;
				if (num != 0)
				{
				}
				num = (short)506789889;
				if (num != 0)
				{
				}
				num = (short)2068119552;
				short num3 = num;
				global::AcpBusinessLayer.AcpDocument.a = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00007DF4 File Offset: 0x00005FF4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00007EA4 File Offset: 0x000060A4
		public static int RadInfoFeatureID
		{
			get
			{
				short num = (short)158010413;
				short num2 = num;
				num = (short)391646253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266417664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939065344;
				if (num != 0)
				{
				}
				num = (short)1634533377;
				if (num != 0)
				{
				}
				return global::AcpBusinessLayer.AcpDocument.b;
			}
			set
			{
				short num = (short)246090305;
				short num2 = num;
				num = (short)665389633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1455816704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61865985;
				if (num != 0)
				{
				}
				num = (short)314900480;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpDocument.b = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00007F54 File Offset: 0x00006154
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00008000 File Offset: 0x00006200
		public static int RadInfoGenSectionId
		{
			get
			{
				short num = (short)1108278975;
				short num2 = num;
				num = (short)973930175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1796734976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)809697281;
				if (num != 0)
				{
				}
				num = (short)546177024;
				if (num != 0)
				{
				}
				return global::AcpBusinessLayer.AcpDocument.c;
			}
			set
			{
				short num = (short)1298233004;
				short num2 = num;
				num = (short)846034604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1978204160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51838977;
				if (num != 0)
				{
				}
				num = (short)1870397440;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpDocument.c = value;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000080B4 File Offset: 0x000062B4
		public AcpDocument()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000080C8 File Offset: 0x000062C8
		public AcpDocument(bool background, global::AcpCommonLib.DocumentType type) : base(background, type)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000080E0 File Offset: 0x000062E0
		public bool FileNew()
		{
			short num = (short)1788492087;
			short num2 = num;
			num = (short)239155511;
			switch (num2 == num)
			{
			default:
			{
				num = (short)677576704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)270598145;
			if (num != 0)
			{
			}
			num = (short)492240896;
			if (num != 0)
			{
			}
			global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
			this.OpenFromFileNew = true;
			return true;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008198 File Offset: 0x00006398
		public bool FileClose()
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			bool flag;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (!base.Background || !flag)
					{
						return true;
					}
					num2 = (short)110770891;
					short num3 = num2;
					num2 = (short)1281571531;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_183;
					default:
						num2 = (short)1120796672;
						if (num2 != 0)
						{
						}
						num2 = (short)705429511;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport != null)
					{
						num2 = (short)1642921988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_78;
				case 2:
					global::AcpBusinessLayer.Recordset.ResetMaxPools();
					global::AcpBusinessLayer.FeatureSection.InitializedSections.Clear();
					num2 = (short)512098305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.IsMainDocument)
					{
						num2 = (short)1526267906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_78;
				case 4:
					goto IL_183;
				case 5:
					goto IL_78;
				case 6:
					flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					num2 = (short)819068938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)1568669696;
					short num4 = num2;
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					num2 = (short)393019401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (base.Background)
					{
						num2 = (short)131923974;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EF;
				case 9:
					return true;
				case 10:
					num2 = (short)457768961;
					if (num2 != 0)
					{
					}
					goto IL_1EF;
				}
				goto IL_3C;
				IL_78:
				base.IsDirty = false;
				base.IsOpen = false;
				num2 = (short)319160320;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_183:
				global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Clear();
				num2 = (short)74448901;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1EF:
				global::AcpBusinessLayer.AcpDocument.Closing = true;
				base.Clear();
				global::AcpBusinessLayer.AcpDocument.Closing = false;
				num2 = (short)999424003;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_3C:
			flag = false;
			num2 = (short)22347784;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000840C File Offset: 0x0000660C
		public bool FileOpen(string path, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes)
		{
			int a_ = 17;
			short num = (short)1811415040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				bool flag;
				bool result;
				for (;;)
				{
					IL_31:
					global::System.Collections.ArrayList arrayList;
					global::AcpFileHandlerLib.AcpFileHandler acpFileHandler;
					switch (num2)
					{
					case 0:
						num = (short)1731985409;
						if (num != 0)
						{
						}
						flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						num = (short)612630530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)6160384;
						short num3 = num;
						if (base.Background)
						{
							num = (short)2039349248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					}
					case 2:
						goto IL_71F;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_FD;
							}
							for (;;)
							{
								IL_B6:
								string text;
								global::System.Collections.IEnumerator enumerator2;
								switch (num2)
								{
								case 0:
									if (int.Parse(global::AcpCommonLib.Document.CodePlugVersionNumber.Substring(1, 2)) < global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER)
									{
										num = (short)82247692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1BA;
								case 1:
									try
									{
										num = (short)607584258;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)924123140;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												((global::AcpBusinessLayer.Recordset)enumerator.Current).RepairRecRefs();
												num = (short)144637953;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_274;
												}
												continue;
											case 3:
												goto IL_2EC;
											case 4:
												num = (short)1827405827;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_276:
											num = (short)180092928;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_274:
											goto IL_276;
										}
										IL_2EC:;
									}
									finally
									{
										num = (short)159711232;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_323;
												}
												continue;
											case 1:
											{
												num = (short)871254935;
												short num4 = num;
												num = (short)483281815;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													continue;
												default:
													goto IL_394;
												}
												break;
											}
											case 2:
												enumerator.Dispose();
												num = (short)641728513;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_323:
											if (enumerator == null)
											{
												goto IL_3AB;
											}
											num = (short)1870069762;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_394:
										num = (short)112787456;
										if (num != 0)
										{
										}
										IL_3AB:;
									}
									this.AddNewFeatures(text);
									this.docFileName = global::System.IO.Path.GetFileName(path);
									this.docFilePath = global::System.IO.Path.GetFullPath(path);
									this.OpenFromFileNew = false;
									result = true;
									num = (short)752091140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									try
									{
										num = (short)1303117828;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)2140143621;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)2116485120;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator2.Current as global::AcpCommonLib.IAcpRecordset;
												num = (short)251068422;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::AcpCommonLib.IAcpRecordset acpRecordset;
												base.AddFeature(acpRecordset);
												num = (short)1079377923;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_554;
												}
												continue;
											case 5:
												goto IL_60D;
											case 6:
											{
												global::AcpCommonLib.IAcpRecordset acpRecordset;
												if (acpRecordset != null)
												{
													num = (short)1591410690;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_575:
											num = (short)419627009;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_554:
											goto IL_575;
										}
										IL_60D:
										goto IL_190;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_62F;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_61C:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)278331394;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_68A;
											case 1:
												goto IL_688;
											case 2:
												disposable.Dispose();
												num = (short)618528769;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_62F;
										}
										IL_688:
										IL_68A:
										goto EndFinally_21;
										IL_62F:
										disposable = (enumerator2 as global::System.IDisposable);
										num = (short)1792999424;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_61C;
										EndFinally_21:;
									}
									goto IL_68B;
									IL_190:
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = base.Features.GetEnumerator();
									num = (short)609812481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Globalization.CultureInfo currentUICulture;
									if (!(currentUICulture.TwoLetterISOLanguageName == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蛢诤", a_)))
									{
										num = (short)1134362639;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1BA;
								}
								case 4:
									goto IL_68B;
								case 5:
									goto IL_6A4;
								case 6:
									if (global::AcpBusinessLayer.AcpDocument.ValidCodeplugVersion(text))
									{
										num = (short)972881931;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_68B;
								case 7:
									goto IL_68B;
								case 8:
									if (arrayList.Count > 0)
									{
										num = (short)1830092813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_496;
								case 9:
									if (this.Info != null)
									{
										num = (short)121503758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_496;
								case 10:
									goto IL_496;
								case 11:
								{
									global::System.Globalization.CultureInfo currentUICulture = global::System.Threading.Thread.CurrentThread.CurrentUICulture;
									num = (short)467075072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)1387855875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									this.Info = (arrayList[0] as global::AcpBusinessLayer.AcpDocInfo);
									num = (short)546111497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									this.Info.Document = this;
									num = (short)105119754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									global::AcpCommonLib.AppInfoManager.NonEngOldCodeplug = true;
									result = false;
									num = (short)1674117127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_FD;
								IL_1BA:
								enumerator2 = arrayList.GetEnumerator();
								num = (short)766312450;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_496:
								text = this.a(arrayList);
								global::AcpCommonLib.AppInfoManager.CodeplugVersion = global::AcpCommonLib.Document.CodePlugVersionNumber;
								num = (short)1324417030;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_68B:
								num = (short)1822818309;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A4:
							return result;
							IL_FD:
							global::AcpFileHandlerLib.AcpFileHeader acpFileHeader = acpFileHandler.ReadHeader(path);
							global::AcpCommonLib.FeatureManager.BeginAddFeatures(this);
							global::AcpCommonLib.Document.CodePlugVersionNumber = acpFileHeader.VersionNumber;
							acpFileHandler.ReadFile<global::System.Collections.ArrayList>(out arrayList, out acpFileHeader, path, true, allowedTypes);
							num = (short)1076363272;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_B6;
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						finally
						{
							num = (short)31129600;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6DC;
									}
									continue;
								case 1:
									goto IL_717;
								case 2:
									global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
									num = (short)227082241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6DC:
								if (!base.Background || !flag)
								{
									break;
								}
								num = (short)2019426306;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_717:
							global::AcpCommonLib.FeatureManager.EndAddFeatures();
						}
						goto IL_71F;
					}
					goto IL_48;
					IL_71F:
					result = false;
					global::AcpCommonLib.AppInfoManager.NonEngOldCodeplug = false;
					global::System.DateTime now = global::System.DateTime.Now;
					acpFileHandler = new global::AcpFileHandlerLib.AcpFileHandler();
					arrayList = null;
					num = (short)2086666243;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_48:
				flag = false;
				num = (short)1189150721;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008C18 File Offset: 0x00006E18
		protected virtual void AddNewFeatures(string codeplugVersion)
		{
			short num = (short)169410561;
			if (num != 0)
			{
			}
			num = (short)730427730;
			short num2 = num;
			num = (short)603353426;
			switch (num2 == num)
			{
			}
			num = (short)1714028544;
			short num3 = num;
			num = (short)1680408576;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008CC0 File Offset: 0x00006EC0
		private string a(global::System.Collections.ArrayList A_0)
		{
			int a_ = 16;
			short num = (short)851902464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string result = "";
				global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)315752456;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (result != "")
							{
								num = (short)630194181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FC;
						case 1:
							num = (short)726204425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)1333657603;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									switch (num2)
									{
									case 0:
										goto IL_4F5;
									case 1:
										try
										{
											num = (short)151453701;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_3D4;
												case 1:
												{
													global::AcpCommonLib.IAcpField acpField;
													result = (acpField as global::AcpBusinessLayer.AcpStringField).Value;
													num = (short)1880883200;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													num = (short)318242820;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													global::AcpCommonLib.IAcpField acpField;
													if (acpField.Name == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻뷽濿昁愃瘅搇缉欋堍甏怑朓缕眗琙䌛弝ᜟᐡᰣᔥ", a_))
													{
														num = (short)262078465;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 4:
													goto IL_482;
												case 5:
													switch (0)
													{
													case 0:
														goto IL_3B0;
													}
													continue;
												case 6:
												{
													if (!enumerator2.MoveNext())
													{
														num = (short)986710018;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField = enumerator2.Current;
													num = (short)31916035;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_3D9:
												num = (short)1750532102;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_3B0:
												goto IL_3D9;
											}
											IL_3D4:
											IL_482:
											goto IL_57E;
										}
										finally
										{
											num = (short)1340211201;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_4F2;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_4BB;
													}
													continue;
												case 2:
													enumerator2.Dispose();
													num = (short)1840185344;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_4BB:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)906887170;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_4F2:;
										}
										goto IL_4F5;
									case 2:
										goto IL_579;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_31F;
										}
										continue;
									case 4:
										num = (short)1558904834;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										num = (short)1637351431;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										if (result != "")
										{
											num = (short)22544388;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 7:
										goto IL_5DB;
									case 8:
										if (acpFeatureSection.FeatureSectionId == global::AcpBusinessLayer.AcpDocument.RadInfoGenSectionId)
										{
											num = (short)1992163328;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_57E;
									case 9:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
										if (!enumerator3.MoveNext())
										{
											num = (short)2752517;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureSection = enumerator3.Current;
										num = (short)1890517000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_31F;
									IL_4F5:
									enumerator2 = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)605487105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_522:
									num = (short)50855945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_31F:
									goto IL_522;
									IL_57E:
									num = (short)238944262;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_579:
								IL_5DB:
								goto IL_243;
							}
							finally
							{
								num = (short)1002307585;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3;
									switch (num2)
									{
									case 0:
										goto IL_649;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_612;
										}
										continue;
									case 2:
										enumerator3.Dispose();
										num = (short)626524160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_612:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)609943554;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_649:;
							}
							goto IL_64C;
							IL_243:
							num = (short)315228160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_664;
						case 4:
							goto IL_16E;
						case 5:
						{
							num = (short)1108377664;
							short num3 = num;
							num = (short)920027200;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)533856256;
								if (num != 0)
								{
								}
								num = (short)1532755972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)827457549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator3 = acpRecordset[0].FeatureSectionsCollection.GetEnumerator();
							num = (short)207486978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_98;
							}
							continue;
						case 9:
						{
							num = (short)486670337;
							if (num != 0)
							{
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset.RecsetId == global::AcpBusinessLayer.AcpDocument.RadInfoFeatureID)
							{
								num = (short)1895038983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FC;
						}
						case 10:
							if (result != "")
							{
								num = (short)168296454;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 11:
						{
							global::AcpCommonLib.IAcpRecordset acpRecordset;
							if (acpRecordset != null)
							{
								num = (short)97910785;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FC;
						}
						case 12:
							goto IL_64C;
						case 13:
							goto IL_E3;
						case 14:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)590807052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current as global::AcpCommonLib.IAcpRecordset;
							num = (short)120127499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_173:
						num = (short)701300750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_98:
						goto IL_173;
						IL_1FC:
						num = (short)1908473866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_64C:
						num = (short)1182400515;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_E3:
					IL_16E:
					IL_664:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_683;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_670:
						switch (num2)
						{
						case 0:
							goto IL_6D7;
						case 1:
							if (disposable != null)
							{
								num = (short)1440415746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6D9;
						case 2:
							disposable.Dispose();
							num = (short)489684992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					}
					IL_6D7:
					IL_6D9:
					goto EndFinally_22;
					IL_683:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2081751041;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_670;
					EndFinally_22:;
				}
				num = (short)1166802944;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000941C File Offset: 0x0000761C
		public static bool ValidCodeplugVersion(string cpgVersion)
		{
			int a_ = 13;
			short num = (short)1390411776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E8;
				}
				bool flag;
				string appVersion;
				for (;;)
				{
					IL_31:
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						goto IL_3A8;
					case 1:
					{
						int num3;
						int num4;
						if (num3 == num4)
						{
							num = (short)711327783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1891368965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int num3;
						int num4;
						if (num3 < num4)
						{
							num = (short)966066217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2079391761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!flag)
						{
							num = (short)511246376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					case 4:
						num = (short)300417025;
						if (num != 0)
						{
						}
						num = (short)1318912028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						flag2 = false;
						goto IL_32C;
					case 6:
						num = (short)1137770519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3A8;
					case 8:
						if (cpgVersion.Length >= 9)
						{
							num = (short)1701052445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2004746251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_3A8;
					case 10:
						flag2 = true;
						goto IL_32C;
					case 11:
						if (cpgVersion == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("駠틢", a_))
						{
							num = (short)1178468390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1401880601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)950206465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)160170015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_3A8;
					case 15:
					{
						int num5;
						int num6;
						if (num5 == num6)
						{
							num = (short)1850605610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					}
					case 16:
						flag = true;
						num = (short)1128988672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int num3;
						int num4;
						if (num3 == num4)
						{
							num = (short)1788149773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					}
					case 18:
						if (!flag)
						{
							num = (short)965279750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 19:
						flag3 = !appVersion.StartsWith(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跞", a_));
						goto IL_500;
					case 20:
						num = (short)177668131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_3A8;
					case 22:
					{
						string[] array;
						int num7;
						if ((int)global::System.Convert.ToInt16(array[2], 10) <= num7)
						{
							num = (short)1070137380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)477429793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (global::AcpBusinessLayer.AcpDocument.a == "")
						{
							num = (short)574685210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 24:
						if (appVersion.StartsWith(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跞", a_)))
						{
							num = (short)1500184580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1045299202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						flag3 = false;
						goto IL_500;
					case 26:
						global::AcpBusinessLayer.AcpDocument.a = global::AcpCommonResources.AcpResources.Codeplug_Req.AcpStringFormat(new object[]
						{
							cpgVersion
						});
						num = (short)506462240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_3A8;
					case 28:
						if (cpgVersion.StartsWith(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跞", a_)))
						{
							num = (short)1796866068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpDocument.a = global::AcpCommonResources.AcpResources.Cannot_Read_Development_Codeplugs;
						num = (short)1308491803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						string[] array2 = appVersion.Substring(1).Split(new char[]
						{
							'.'
						});
						string[] array = cpgVersion.Substring(1).Split(new char[]
						{
							'.'
						});
						int num4 = (int)global::System.Convert.ToInt16(array2[0], 10);
						int num3 = (int)global::System.Convert.ToInt16(array[0], 10);
						int num6 = (int)global::System.Convert.ToInt16(array2[1], 10);
						int num5 = (int)global::System.Convert.ToInt16(array[1], 10);
						num = (short)2037907480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_3A8;
					case 31:
					{
						int num5;
						int num6;
						if (num5 < num6)
						{
							num = (short)1463746603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)596049935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						return flag;
					case 33:
						goto IL_3A8;
					case 34:
					{
						int num5;
						int num6;
						flag2 = (num5 <= num6);
						goto IL_32C;
					}
					case 35:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)1315438604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)748748810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						flag = true;
						num = (short)465567751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (cpgVersion == appVersion)
						{
							num = (short)1218576400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)241827848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)1092550675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)615841826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						global::AcpBusinessLayer.AcpDocument.a = global::AcpCommonResources.AcpResources.Invalid_Codeplug.AcpStringFormat(new object[]
						{
							cpgVersion
						});
						num = (short)161415182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						flag = true;
						num = (short)580648969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						num = (short)392203691;
						short num8 = num;
						num = (short)531991979;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A8;
						default:
						{
							num = (short)701890560;
							if (num != 0)
							{
							}
							string[] array2;
							int num7 = (int)global::System.Convert.ToInt16(array2[2], 10);
							num = (short)1272119318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 43:
					{
						flag = true;
						num = (short)1549533184;
						short num9 = num;
						num = (short)1607401502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_E8;
					IL_32C:
					flag = flag2;
					num = (short)362414101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A8:
					num = (short)591069202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_500:
					flag = flag3;
					num = (short)320405507;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_E8:
				flag = false;
				appVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
				global::AcpBusinessLayer.AcpDocument.a = "";
				num = (short)1222836261;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009C2C File Offset: 0x00007E2C
		private void a()
		{
			short num = (short)568852480;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = base.Features.GetEnumerator();
				try
				{
					num = (short)900595715;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1927282691;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::AcpBusinessLayer.Recordset recordset;
										if (recordset.Count > 0)
										{
											num = (short)812908548;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)827326470;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)enumerator2.Current;
										num = (short)387252225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_176;
										}
										continue;
									case 4:
									{
										global::AcpBusinessLayer.Recordset recordset;
										this.a(recordset[0] as global::AcpBusinessLayer.FeatureNode);
										num = (short)1395785728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_23A;
									case 6:
										num = (short)1543503877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1E8:
									num = (short)1124794370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_176:
									goto IL_1E8;
								}
								IL_23A:
								break;
							}
							finally
							{
								num = (short)616693760;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_271;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)98041858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2A6;
									}
									IL_271:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1593442305;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2A6:;
							}
							goto IL_2A9;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)355532804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.Recordset recordset2 = (global::AcpBusinessLayer.Recordset)enumerator.Current;
							num = (short)1598619650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpBusinessLayer.Recordset recordset2;
							if (recordset2.Count > 0)
							{
								num = (short)1568473094;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_6E;
							}
							continue;
						case 4:
							goto IL_2A9;
						case 5:
							goto IL_30C;
						case 6:
						{
							IL_12F:
							global::AcpBusinessLayer.Recordset recordset2;
							this.a(recordset2[0] as global::AcpBusinessLayer.FeatureNode);
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = recordset2[0].EmbeddedRecordsets.GetEnumerator();
							num = (short)1240203264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_AF:
						num = (short)320602113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6E:
						goto IL_AF;
						IL_2A9:
						num = (short)2141707645;
						short num3 = num;
						num = (short)1270537597;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12F;
						default:
							num = (short)1122435072;
							if (num != 0)
							{
							}
							num = (short)1627848709;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_30C:;
				}
				finally
				{
					num = (short)554369024;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1405616129;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_36A;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)334954498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_39F;
						}
						IL_36A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1998520321;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_39F:;
				}
				num = (short)1792671744;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000A038 File Offset: 0x00008238
		private void a(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)1228743492;
			short num2 = num;
			num = (short)1390748484;
			switch (num2 == num)
			{
			}
			num = (short)1265369089;
			if (num != 0)
			{
			}
			num = (short)1530986496;
			short num3 = num;
			num = (short)534642688;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public bool FileSaveAs(string path, global::AcpFileHandlerLib.AcpFileHeader fileHeader)
		{
			short num = (short)171245568;
			switch (num)
			{
			default:
			{
				num = (short)73859072;
				short num2 = num;
				num = (short)528154625;
				if (num != 0)
				{
				}
				global::AcpFileHandlerLib.AcpFileHandler acpFileHandler = new global::AcpFileHandlerLib.AcpFileHandler();
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				arrayList.Add(new global::AcpBusinessLayer.AcpDocInfo(this));
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = base.Features.GetEnumerator();
				try
				{
					num = (short)1717764098;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1030094849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_146;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_CF;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)131923968;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpRecordset value = enumerator.Current;
							arrayList.Add(value);
							num = (short)2005794819;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_F8:
						num = (short)528416772;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CF:
						goto IL_F8;
					}
					IL_146:;
				}
				finally
				{
					num = (short)377225217;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_200;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_17D;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)476905472;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_17D:
						num = (short)1074957698;
						short num4 = num;
						num = (short)1143377282;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_200;
						default:
							num = (short)1434648576;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_202;
							}
							num = (short)371326978;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_200:
					IL_202:;
				}
				acpFileHandler.WriteFile<global::System.Collections.ArrayList>(arrayList, fileHeader, path, true);
				this.docFileName = global::System.IO.Path.GetFileName(path);
				this.docFilePath = global::System.IO.Path.GetFullPath(path);
				base.IsDirty = false;
				base.WriteModificationLog();
				return true;
			}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A334 File Offset: 0x00008534
		public void Initialized(bool dirty)
		{
			short num = (short)729009299;
			short num2 = num;
			num = (short)647154835;
			switch (num2 == num)
			{
			}
			num = (short)1279590400;
			if (num != 0)
			{
			}
			num = (short)1452605440;
			short num3 = num;
			num = (short)717029377;
			if (num != 0)
			{
			}
			global::AcpCommonLib.ConstraintManager.Resume();
			base.Init();
			base.IsDirty = dirty;
			base.IsOpen = true;
			global::AcpCommonLib.UndoRedo.UndoManager.Reset();
			global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000A404 File Offset: 0x00008604
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000A4B4 File Offset: 0x000086B4
		internal global::AcpBusinessLayer.AcpDocInfo Info
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1609456898;
				short num2 = num;
				num = (short)2037406978;
				switch (num2 == num)
				{
				}
				num = (short)20185089;
				if (num != 0)
				{
				}
				num = (short)1026359296;
				short num3 = num;
				num = (short)1753415680;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)247614912;
				short num2 = num;
				num = (short)2117553600;
				switch (num2 == num)
				{
				}
				num = (short)1686765569;
				if (num != 0)
				{
				}
				num = (short)1433862144;
				short num3 = num;
				num = (short)1029767168;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000A568 File Offset: 0x00008768
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000A61C File Offset: 0x0000881C
		public bool OpenFromFileNew
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)115948692;
				short num2 = num;
				num = (short)998653076;
				switch (num2 == num)
				{
				}
				num = (short)1296891905;
				if (num != 0)
				{
				}
				num = (short)749862912;
				short num3 = num;
				num = (short)1182203904;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)486754663;
				short num2 = num;
				num = (short)1848265063;
				switch (num2 == num)
				{
				}
				num = (short)416940033;
				if (num != 0)
				{
				}
				num = (short)1053294592;
				short num3 = num;
				num = (short)134938624;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A6CC File Offset: 0x000088CC
		// Note: this type is marked as 'beforefieldinit'.
		static AcpDocument()
		{
			short num = (short)428352521;
			short num2 = num;
			num = (short)305013769;
			switch (num2 == num)
			{
			}
			num = (short)1316487169;
			if (num != 0)
			{
			}
			num = (short)639434752;
			short num3 = num;
			num = (short)1603993600;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpDocument.a = "";
			global::AcpBusinessLayer.AcpDocument.b = 0;
			global::AcpBusinessLayer.AcpDocument.c = 0;
			global::AcpBusinessLayer.AcpDocument.Closing = false;
			global::AcpBusinessLayer.AcpDocument.PageOnLoading = false;
		}

		// Token: 0x0400000B RID: 11
		private static string a;

		// Token: 0x0400000C RID: 12
		private static int b;

		// Token: 0x0400000D RID: 13
		private static int c;

		// Token: 0x0400000E RID: 14
		internal static bool Closing;

		// Token: 0x0400000F RID: 15
		public static bool PageOnLoading;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.AcpDocInfo d;

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;
	}
}
