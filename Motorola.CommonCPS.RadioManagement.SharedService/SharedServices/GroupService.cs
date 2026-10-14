using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000063 RID: 99
	internal class GroupService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00049B20 File Offset: 0x00047D20
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00049C40 File Offset: 0x00047E40
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> GroupCache
		{
			get
			{
				short num = (short)189202432;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						this.GetGroupsTree();
						goto IL_F5;
					case 2:
						goto IL_10C;
					}
					IL_30:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a != null)
					{
						break;
					}
					num = (short)1359723294;
					short num3 = num;
					num = (short)605535006;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1715011585;
						if (num != 0)
						{
						}
						num = (short)1423966208;
						short num4 = num;
						num = (short)1370095616;
						if (num != 0)
						{
						}
						num = (short)1862008833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_F5:
					num = (short)228982786;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10C:
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a;
			}
			set
			{
				short num = (short)2008285185;
				if (num != 0)
				{
				}
				num = (short)1947729920;
				short num2 = num;
				num = (short)870810725;
				short num3 = num;
				num = (short)2129560677;
				switch (num3 == num)
				{
				}
				num = (short)1870594048;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a = value;
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00049CF0 File Offset: 0x00047EF0
		public GroupService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor)
		{
			int a_ = 18;
			this.b = new string[]
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("蚨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("鎨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("莨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("隨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("躨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("讨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("閨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("鞨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햨", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("镗", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꙗ", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("덗", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꍗ", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("뙗", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("깗", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ꭗ", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("땗", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("띗", a_),
				global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_)
			};
			base..ctor(serverAccessor);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00049E7C File Offset: 0x0004807C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group AddGroup(global::System.Guid? parentGroupUuid)
		{
			short num = (short)920450610;
			short num2 = num;
			num = (short)1009448498;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1997668352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1241186305;
			if (num != 0)
			{
			}
			num = (short)2082734080;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.Group result = this.a(base.ServerAccessor.AddGroup(parentGroupUuid));
			global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a = null;
			return result;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00049F3C File Offset: 0x0004813C
		public string GetGroupName(global::System.Guid groupUuid)
		{
			short num = (short)1055201688;
			short num2 = num;
			num = (short)1147345304;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1622343680;
				if (num != 0)
				{
				}
				group = this.FindGroup(new global::System.Guid?(groupUuid));
				if (group.ID == null)
				{
					return string.Empty;
				}
				num = (short)1152385025;
				if (num != 0)
				{
				}
				num = (short)443023360;
				short num3 = num;
				break;
			}
			}
			return group.Name;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0004A010 File Offset: 0x00048210
		public void DeleteGroup(global::System.Guid groupUuid)
		{
			short num = (short)1057458889;
			short num2 = num;
			num = (short)950176457;
			switch (num2 == num)
			{
			default:
			{
				num = (short)288948224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2104492033;
			if (num != 0)
			{
			}
			num = (short)1653211136;
			if (num != 0)
			{
			}
			base.ServerAccessor.DeleteGroup(groupUuid);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a = null;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0004A0CC File Offset: 0x000482CC
		public int GetRadioCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, bool includeSubGroups = false)
		{
			short num = (short)1615646324;
			short num2 = num;
			num = (short)2133905012;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2070085632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1654325248;
			if (num != 0)
			{
			}
			num = (short)1262944257;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetRadioCount(groupUuid, workMode, includeSubGroups);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0004A180 File Offset: 0x00048380
		public byte[] UpdatedGroup(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group)
		{
			short num = (short)75346269;
			short num2 = num;
			num = (short)314093917;
			switch (num2 == num)
			{
			default:
			{
				num = (short)814546944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)35717121;
			if (num != 0)
			{
			}
			num = (short)687079424;
			if (num != 0)
			{
			}
			byte[] result = base.ServerAccessor.UpdateGroup(this.a(group));
			global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a = null;
			return result;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0004A244 File Offset: 0x00048444
		public bool ValidateGroupName(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, string newName, out string err)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1001062400;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (!this.a(newName.Trim(), out err))
						{
							num = (short)1695154181;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2107375619;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)113377281;
						if (num != 0)
						{
						}
						if (group == null)
						{
							num = (short)1515585538;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1190689280;
						short num4 = num;
						num = (short)1413904896;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)794558464;
							if (num != 0)
							{
							}
							num = (short)1656094720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_CD;
					case 3:
						if (base.ServerAccessor.GetGroups().Any(delegate(global::Motorola.CommonCPS.Server.EntityModel.Group g)
						{
							switch (0)
							{
							case 0:
								goto IL_44;
							}
							short num6;
							for (;;)
							{
								IL_0A:
								int num5;
								bool flag;
								bool flag2;
								switch (num5)
								{
								case 0:
									goto IL_1E7;
								case 1:
									flag = false;
									goto IL_1C9;
								case 2:
								{
									num6 = (short)835125249;
									if (num6 != 0)
									{
									}
									global::System.Guid uuid;
									global::System.Guid? guid;
									flag2 = (uuid != guid.GetValueOrDefault());
									goto IL_29B;
								}
								case 3:
									num6 = (short)774569989;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								case 4:
								{
									global::System.Guid? guid;
									if (guid == null)
									{
										num6 = (short)1298595843;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									goto IL_176;
								}
								case 5:
									flag2 = true;
									goto IL_29B;
								case 6:
									num6 = (short)1550057473;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								case 7:
								{
									global::System.Guid? guid = g.ParentUuid;
									global::System.Guid? id = group.Parent.ID;
									num6 = (short)507183114;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								case 8:
								{
									global::System.Guid? guid;
									if (guid == null)
									{
										num6 = (short)2039021568;
										short num7 = num6;
										num6 = (short)202047499;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									num6 = (short)1094189068;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								case 9:
									flag = true;
									goto IL_1C9;
								case 10:
								{
									global::System.Guid? guid;
									global::System.Guid? id;
									if (guid != null != (id != null))
									{
										num6 = (short)1878917126;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									num6 = (short)1482620936;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								case 11:
									num6 = (short)1991114761;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								case 12:
								{
									global::System.Guid? guid;
									global::System.Guid? id;
									flag = (guid.GetValueOrDefault() == id.GetValueOrDefault());
									goto IL_1C9;
								}
								}
								goto IL_44;
								IL_1C9:
								if (flag)
								{
									num6 = (short)1742798848;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								return false;
								IL_29B:
								if (!flag2)
								{
									return false;
								}
								num6 = (short)2110783495;
								num5 = (int)((global::System.IntPtr)num6);
							}
							IL_1E7:
							return this.a(newName.Trim(), g.Name);
							IL_44:
							num6 = (short)290467158;
							short num8 = num6;
							num6 = (short)461712726;
							switch ((num8 == num6) ? 1 : 0)
							{
							case 0:
							case 2:
							{
								IL_176:
								num6 = (short)1090715650;
								int num5 = (int)((global::System.IntPtr)num6);
								goto IL_0A;
							}
							default:
							{
								num6 = (short)1972764672;
								if (num6 != 0)
								{
								}
								global::System.Guid uuid = g.Uuid;
								global::System.Guid? guid = group.ID;
								num6 = (short)1784676356;
								int num5 = (int)((global::System.IntPtr)num6);
								goto IL_0A;
							}
							}
						}))
						{
							num = (short)218300420;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						goto IL_120;
					case 5:
						return false;
					}
					break;
				}
				IL_52:
				num = (short)1758461953;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_CD:
			err = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Group_EmptyNameError;
			return false;
			IL_120:
			err = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_GroupExist_Error;
			return false;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0004A420 File Offset: 0x00048620
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> GetGroupsTree()
		{
			short num = (short)783745024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Group> enumerator;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> observableCollection;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> observableCollection2;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> source;
					global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, global::System.Guid?> keySelector;
					global::System.Linq.ILookup<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.Group> lookup2;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1143209985;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_37B;
									}
									continue;
								case 2:
									num = (short)404619268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)488374274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.Group group = enumerator.Current;
									observableCollection.Add(this.a(group));
									num = (short)1722023936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_3F6;
								}
								IL_3AA:
								num = (short)1701117955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_37B:
								goto IL_3AA;
							}
							IL_3F6:
							goto IL_C2;
						}
						finally
						{
							num = (short)2034302976;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_42F;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)885063682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_465;
								}
								IL_42F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)495714305;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_465:;
						}
						goto IL_468;
						IL_C2:
						observableCollection2 = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>();
						num = (short)2074017793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						source = observableCollection;
						if ((keySelector = global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.<>c.<>9__12_0) == null)
						{
							goto IL_323;
						}
						goto IL_468;
					case 2:
						goto IL_F3;
						try
						{
							for (;;)
							{
								IL_F3:
								num = (short)630063107;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)303693829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Linq.ILookup<global::System.Guid?, global::Motorola.CommonCPS.RadioManagement.UIModels.Group> lookup = lookup2;
										global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2;
										global::System.Guid? id = group2.Parent.ID;
										global::Motorola.CommonCPS.RadioManagement.UIModels.Group group3 = lookup[new global::System.Guid?(id.Value)].First<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>();
										group3.Children.Add(group2);
										group2.Parent = group3;
										num = (short)277741570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_139;
										}
										continue;
									case 4:
									{
										global::System.Guid? id;
										if (id == null)
										{
											global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2;
											observableCollection2.Add(group2);
											num = (short)265814023;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1215628301;
										short num3 = num;
										num = (short)102827021;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_F3;
										default:
											num = (short)1783693312;
											if (num != 0)
											{
											}
											num = (short)1095172097;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_2B1;
									case 6:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)2026766336;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2 = enumerator2.Current;
										global::System.Guid? id = group2.Parent.ID;
										num = (short)1422393348;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_238:
									num = (short)1650851846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_139:
									goto IL_238;
								}
							}
							IL_2B1:
							goto IL_494;
						}
						finally
						{
							num = (short)324861952;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2E9;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1735655426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_320;
								}
								IL_2E9:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)218628097;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_320:;
						}
						goto IL_323;
					}
					goto IL_3C;
					IL_468:
					lookup2 = source.ToLookup(keySelector);
					enumerator2 = observableCollection.GetEnumerator();
					num = (short)635371522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_323:
					keySelector = (global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.<>c.<>9__12_0 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.Group i)
					{
						short num5 = (short)445952101;
						short num6 = num5;
						num5 = (short)1357295717;
						switch (num6 == num5)
						{
						}
						num5 = (short)1466695681;
						if (num5 != 0)
						{
						}
						num5 = (short)174784512;
						short num7 = num5;
						num5 = (short)1915420672;
						if (num5 != 0)
						{
						}
						return i.ID;
					});
					goto IL_468;
				}
				IL_494:
				this.GroupCache = observableCollection2;
				return observableCollection2;
				IL_3C:
				num = (short)1754136577;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.Group> groups = base.ServerAccessor.GetGroups();
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>();
				enumerator = groups.GetEnumerator();
				num = (short)1308819456;
				short num4 = num;
				num = (short)1994194944;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0004A900 File Offset: 0x00048B00
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group FindGroup(global::System.Guid? guid)
		{
			short num = (short)454033409;
			if (num != 0)
			{
			}
			num = (short)65273856;
			short num2 = num;
			num = (short)1503979601;
			short num3 = num;
			num = (short)184477777;
			switch (num3 == num)
			{
			}
			num = (short)363266048;
			if (num != 0)
			{
			}
			return this.a(guid, this.GroupCache);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0004A9B8 File Offset: 0x00048BB8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group FindGroup(string guid)
		{
			short num = (short)2092699926;
			short num2 = num;
			num = (short)316543254;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1891827713;
				if (num != 0)
				{
				}
				num = (short)958332928;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(guid))
				{
					return new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
				}
				num = (short)73531392;
				short num3 = num;
				break;
			}
			}
			return this.a(new global::System.Guid?(new global::System.Guid(guid)), this.GroupCache);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0004AA88 File Offset: 0x00048C88
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group FindGroupByPath(string groupPath)
		{
			short num = (short)1482948608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
				for (;;)
				{
					IL_1E:
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
							goto IL_1B7;
						case 1:
							goto IL_10E;
						case 2:
						{
							string[] array = groupPath.Split(new char[]
							{
								'/'
							});
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> source = this.GroupCache;
							string[] array2 = array;
							int num3 = 0;
							num = (short)500170753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (!groupPath.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.Group_Field_None.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).Trim()))
							{
								num = (short)1553924098;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return group;
						case 4:
							goto IL_10E;
						case 5:
							goto IL_218;
						case 6:
						{
							num = (short)955435302;
							short num4 = num;
							num = (short)924698918;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E;
							default:
							{
								num = (short)47251456;
								if (num != 0)
								{
								}
								num = (short)1223950337;
								if (num != 0)
								{
								}
								string[] array2;
								int num3;
								if (num3 >= array2.Length)
								{
									num = (short)1843068928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string name = array2[num3];
								global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> source;
								group = source.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.Group g)
								{
									short num6 = (short)427811270;
									short num7 = num6;
									num6 = (short)447078854;
									switch (num7 == num6)
									{
									}
									num6 = (short)2085552129;
									if (num6 != 0)
									{
									}
									num6 = (short)100204544;
									short num8 = num6;
									num6 = (short)1082195968;
									if (num6 != 0)
									{
									}
									return g.Name == name;
								});
								num = (short)792592391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 7:
						{
							if (group == null)
							{
								num = (short)496762885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> source = group.Children;
							int num3;
							num3++;
							num = (short)1110376452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
						IL_10E:
						num = (short)768278534;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4F:
					group = new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
					num = (short)1667825667;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				IL_1B7:
				return group;
				IL_218:
				num = (short)1394999296;
				short num5 = num;
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
			}
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0004ACDC File Offset: 0x00048EDC
		public string GetGroupFullPath(global::System.Guid? groupId)
		{
			for (;;)
			{
				IL_00:
				short num = (short)406650880;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)563019777;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 1:
					{
						string text;
						if (text == null)
						{
							num = (short)633864195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					case 2:
						goto IL_78;
					case 3:
						goto IL_147;
					}
					IL_5A:
					if (groupId == null)
					{
						num = (short)1335296002;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1429852095;
						short num3 = num;
						num = (short)1361432511;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1381367808;
							if (num != 0)
							{
							}
							num = (short)1966997504;
							short num4 = num;
							string text = this.a(groupId.Value);
							num = (short)572194817;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
			}
			IL_78:
			return null;
			IL_147:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.GroupService.a = null;
			return this.a(groupId.Value);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0004AE38 File Offset: 0x00049038
		public string CheckGroupNameBeforeImportingFromFile(string groupNameFromFile, global::Motorola.CommonCPS.RadioManagement.UIModels.Group currentGroup)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			string text;
			short num2;
			string[] array;
			for (;;)
			{
				IL_0A:
				string value;
				switch (num)
				{
				case 0:
					value = currentGroup.Name;
					goto IL_133;
				case 1:
					goto IL_151;
				case 2:
					goto IL_281;
				case 3:
					goto IL_1A6;
				case 4:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)1979187208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_281;
				case 5:
					goto IL_279;
				case 6:
					num2 = (short)171114497;
					if (num2 != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(text))
					{
						num2 = (short)2113077250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1656487943;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)551813120;
					short num3 = num2;
					if (text.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.Group_Field_None.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).Trim()))
					{
						num2 = (short)150601733;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					array = text.Split(new char[]
					{
						'/'
					});
					num2 = (short)595525643;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					num2 = (short)1133969414;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					value = null;
					goto IL_133;
				case 10:
					num2 = (short)567410697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (array.Length != 0)
					{
						num2 = (short)349765635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2BA;
				case 12:
					if (currentGroup == null)
					{
						num2 = (short)945160202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1693319168;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_44;
				IL_133:
				if (!string.IsNullOrEmpty(value))
				{
					num2 = (short)1217855489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1A8;
				IL_281:
				num2 = (short)402456588;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_151:
			return this.GetGroupFullPath(currentGroup.ID);
			IL_1A6:
			return this.a(array);
			IL_1A8:
			num2 = (short)1519873833;
			short num4 = num2;
			num2 = (short)1949003561;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_151;
			default:
				num2 = (short)1022099456;
				if (num2 != 0)
				{
				}
				return string.Empty;
			}
			IL_279:
			return string.Empty;
			IL_2BA:
			this.a(text);
			return text;
			IL_44:
			text = this.b(groupNameFromFile);
			num2 = (short)437518340;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0004B108 File Offset: 0x00049308
		public bool CheckIfTheGroupIsParentOrAncestor(global::Motorola.CommonCPS.RadioManagement.UIModels.Group groupToCheck, global::Motorola.CommonCPS.RadioManagement.UIModels.Group possibleAncestor)
		{
			short num = (short)912719872;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Guid? id;
				global::System.Guid? id2;
				bool flag;
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
				switch (num2)
				{
				case 0:
					num = (short)948043777;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 1:
					num = (short)1582104590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return false;
				case 3:
					num = (short)611516422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return true;
				case 5:
					flag = (id.GetValueOrDefault() == id2.GetValueOrDefault());
					goto IL_176;
				case 6:
					flag = false;
					goto IL_176;
				case 7:
					goto IL_222;
				case 8:
					if (id == null)
					{
						num = (short)1951465472;
						short num3 = num;
						num = (short)161808385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1630470149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_174;
				case 10:
					num = (short)1649082379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (possibleAncestor == null)
					{
						num = (short)646578185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					group = groupToCheck;
					num = (short)1634926599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					if (id != null == (id2 != null))
					{
						num = (short)1284505608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)87741270;
					short num4 = num;
					num = (short)142463830;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
						num = (short)1854406656;
						if (num != 0)
						{
						}
						num = (short)442957827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					if (group == null)
					{
						num = (short)570556418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_222;
				case 14:
					flag = true;
					goto IL_176;
				}
				goto IL_89;
				IL_8F:
				num = (short)732168202;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				if (groupToCheck != null)
				{
					goto IL_8F;
				}
				break;
				IL_176:
				if (flag)
				{
					num = (short)1200029700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				group = group.Parent;
				num = (short)1012269069;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_222:
				id = group.ID;
				id2 = possibleAncestor.ID;
				num = (short)1426587660;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_174:
			return false;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0004B3D8 File Offset: 0x000495D8
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group a(global::System.Guid? A_0, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> A_1)
		{
			short num = (short)1883766784;
			short num2 = num;
			num = (short)1826291712;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
					{
						if (A_0.IsNullOrEmpty())
						{
							num = (short)1866792961;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator = A_1.GetEnumerator();
						num = (short)1256783874;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return group;
					case 2:
						goto IL_423;
					}
					goto IL_67;
				}
				return group;
				IL_423:
				try
				{
					num = (short)275972096;
					num3 = (int)((global::System.IntPtr)num);
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group result;
					for (;;)
					{
						bool flag;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_135;
							}
							continue;
						case 1:
							goto IL_392;
						case 2:
							num = (short)1220083722;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							flag = true;
							goto IL_358;
						case 4:
						{
							global::System.Guid? id;
							if (id == null)
							{
								num = (short)535494664;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)568590347;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Guid? guid;
							if (guid != null)
							{
								num = (short)343474178;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A4;
						}
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)619905039;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2 = enumerator.Current;
							global::System.Guid? id = group2.ID;
							global::System.Guid? guid = A_0;
							num = (short)1621753868;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_19F;
						case 8:
							num = (short)1169096707;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2;
							result = group2;
							num = (short)133824519;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_24D;
						case 11:
						{
							global::System.Guid? id;
							global::System.Guid? guid;
							flag = (id.GetValueOrDefault() == guid.GetValueOrDefault());
							goto IL_358;
						}
						case 12:
						{
							global::System.Guid? id;
							global::System.Guid? guid;
							if (id != null != (guid != null))
							{
								num = (short)770179085;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1407778820;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_217;
						case 14:
							flag = false;
							goto IL_358;
						case 15:
							num = (short)592510977;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
						IL_1A4:
						num = (short)507183110;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_135:
						num = (short)1195411536;
						short num4 = num;
						num = (short)1203275856;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_217:
							num = (short)1378484238;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)850788352;
							if (num != 0)
							{
							}
							goto IL_1A4;
						}
						IL_358:
						if (flag)
						{
							num = (short)885391369;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2;
							group = this.a(A_0, group2.Children);
							global::System.Guid? guid = group.ID;
							num = (short)1881079813;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
					IL_19F:
					return result;
					IL_24D:
					IL_392:
					return group;
				}
				finally
				{
					num = (short)272760834;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator;
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)625213441;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3FD;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3C7;
							}
							continue;
						}
						IL_3C7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1932918784;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3FD:;
				}
				return group;
				IL_67:
				num = (short)1687945217;
				if (num != 0)
				{
				}
				group = new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
				num = (short)1097924608;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0004B82C File Offset: 0x00049A2C
		private string a(global::System.Guid groupId)
		{
			int a_ = 16;
			short num = (short)2090532864;
			short num2 = num;
			num = (short)555548672;
			switch (num)
			{
			default:
			{
				num = (short)1145569281;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Stack<string> stack = new global::System.Collections.Generic.Stack<string>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator = this.GroupCache.GetEnumerator();
				string result;
				try
				{
					num = (short)418709505;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						bool flag;
						switch (num3)
						{
						case 0:
							num = (short)1149566983;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F8;
							}
							continue;
						case 2:
							result = string.Join(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("袦", a_), stack.Reverse<string>());
							num = (short)850984968;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_399;
						case 4:
							num = (short)116981773;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Guid? id;
							if (id == null)
							{
								num = (short)622919684;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)85327884;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							flag = false;
							goto IL_22C;
						case 8:
							goto IL_12D;
						case 9:
							goto IL_2D0;
						case 10:
							num = (short)1946615811;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
							result = group.Name;
							num = (short)669319177;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::System.Guid? id;
							flag = (id.GetValueOrDefault() == groupId);
							goto IL_22C;
						}
						case 13:
							flag = true;
							goto IL_22C;
						case 14:
						{
							global::System.Guid? id;
							if (id == null)
							{
								num = (short)53477376;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)807534598;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)486473738;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group group = enumerator.Current;
							stack.Push(group.Name);
							global::System.Guid? id = group.ID;
							num = (short)886964238;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
							if (!this.a(groupId, group.Children, stack))
							{
								stack.Pop();
								num = (short)727515141;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)770363170;
							short num4 = num;
							num = (short)1687801634;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_399;
							default:
								num = (short)1983381504;
								if (num != 0)
								{
								}
								num = (short)777453570;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_F8;
						IL_22C:
						if (flag)
						{
							num = (short)909443083;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1211760656;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EA:
						num = (short)843186191;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F8:
						goto IL_1EA;
					}
					IL_12D:
					IL_2D0:
					return result;
					IL_399:
					goto IL_8B;
				}
				finally
				{
					num = (short)1637613570;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1109786625;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_405;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3D0;
							}
							continue;
						}
						IL_3D0:
						if (enumerator == null)
						{
							break;
						}
						num = (short)474284032;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_405:;
				}
				return result;
				IL_8B:
				return null;
			}
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0004BC60 File Offset: 0x00049E60
		private string b(string groupName)
		{
			int a_ = 15;
			short num = (short)1460274559;
			short num2 = num;
			num = (short)720242047;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_89:
				num = (short)522452992;
				short num3 = num;
				num = (short)1734868993;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(groupName))
				{
					return groupName;
				}
				num = (short)28508160;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1512833024;
				if (num != 0)
				{
				}
				num = (short)518193154;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)1572798465;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_111;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				}
				goto IL_89;
			}
			IL_111:
			return string.Join(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("覥", a_), groupName.Trim().Trim(new char[]
			{
				'/'
			}).Split(new char[]
			{
				'/'
			}).Select(delegate(string n)
			{
				short num5 = (short)1423850118;
				short num6 = num5;
				num5 = (short)1442462342;
				switch (num6 == num5)
				{
				}
				num5 = (short)1255997440;
				if (num5 != 0)
				{
				}
				num5 = (short)872349696;
				short num7 = num5;
				num5 = (short)1698758657;
				if (num5 != 0)
				{
				}
				return n.Trim();
			}));
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0004BDE4 File Offset: 0x00049FE4
		private bool a(string A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_70;
				case 1:
					if (string.IsNullOrEmpty(A_0))
					{
						num2 = (short)1175322624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1149108227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_12A;
				case 3:
					if (A_0.Length <= 128)
					{
						string[] array = this.b;
						int num3 = 0;
						num2 = (short)740308689;
						short num4 = num2;
						num2 = (short)1332688593;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1264254976;
							if (num2 != 0)
							{
							}
							num2 = (short)1698496517;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					num2 = (short)1919877124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_FD;
				case 5:
					goto IL_12A;
				case 6:
					return true;
				case 7:
				{
					string[] array;
					int num3;
					if (num3 >= array.Length)
					{
						num2 = (short)81199104;
						short num5 = num2;
						num2 = (short)76152838;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string value = array[num3];
					num2 = (short)1255276553;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_BC;
				case 9:
				{
					string value;
					if (A_0.Contains(value))
					{
						num2 = (short)1387200520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num3;
					num3++;
					num2 = (short)141819906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_38;
				IL_12A:
				num2 = (short)1390280711;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_70:
			A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Group_EmptyNameError;
			return false;
			IL_BC:
			A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidGroupName;
			return false;
			IL_FD:
			num2 = (short)1310457857;
			if (num2 != 0)
			{
			}
			A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_GroupNameLength_Error;
			return false;
			IL_38:
			A_1 = string.Empty;
			num2 = (short)1872494593;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0004C028 File Offset: 0x0004A228
		private void a(string groupName)
		{
			short num = (short)361234432;
			short num2 = num;
			string text = null;
			if (this.a(groupName, out text))
			{
				num = (short)642711553;
				if (num != 0)
				{
				}
				num = (short)1525330498;
				short num3 = num;
				num = (short)253473346;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)290848768;
					if (num != 0)
					{
					}
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidField_For_ImportCSV, new string[]
			{
				text
			}));
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
		private string a(string[] A_0)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_104;
				case 1:
				{
					string text;
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(text))
					{
						goto IL_1D2;
					}
					this.a(text);
					num2++;
					num3 = (short)932839431;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					num3 = (short)1949302785;
					if (num3 != 0)
					{
					}
					num3 = (short)132579329;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_1EA;
				case 4:
				{
					if (num2 >= A_0.Length)
					{
						num3 = (short)1701969925;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1750597632;
					short num4 = num3;
					string text = A_0[num2];
					num3 = (short)269352966;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 5:
					goto IL_187;
				case 6:
				{
					string text;
					if (!string.IsNullOrWhiteSpace(text))
					{
						num3 = (short)400031746;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_7C;
				}
				case 7:
					goto IL_104;
				}
				goto IL_39;
				IL_104:
				num3 = (short)1567881698;
				short num5 = num3;
				num3 = (short)1779497442;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1D2:
					num3 = (short)657653763;
					num = (int)((global::System.IntPtr)num3);
					break;
				default:
					num3 = (short)1809186816;
					if (num3 != 0)
					{
					}
					num3 = (short)781713412;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
			}
			IL_7C:
			throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_InvalidField_For_ImportCSV, new string[]
			{
				global::Motorola.CommonCPS.ResourceRepository.Resources.Error_InvalidGroupName
			}));
			IL_187:
			return string.Join(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("讣", a_), A_0);
			IL_1EA:
			goto IL_7C;
			IL_39:
			num2 = 0;
			num3 = (short)1946288128;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0004C308 File Offset: 0x0004A508
		private bool a(global::System.Guid A_0, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> A_1, global::System.Collections.Generic.Stack<string> A_2)
		{
			short num = (short)1779367936;
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
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (group != null)
						{
							num = (short)1451425796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 1:
						return false;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator = A_1.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.Group g)
						{
							short num5 = (short)336068609;
							if (num5 != 0)
							{
							}
							num5 = (short)1371144192;
							short num6 = num5;
							if (g.Children != null)
							{
								num5 = (short)1695696483;
								short num7 = num5;
								num5 = (short)1001866851;
								switch ((num7 == num5) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num5 = (short)59637760;
									if (num5 != 0)
									{
									}
									return g.Children.Count > 0;
								}
							}
							return false;
						}).GetEnumerator();
						num = (short)1958346755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)221511680;
						short num3 = num;
						num = (short)2111700993;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1411448832;
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
										goto IL_DF;
									}
									continue;
								case 2:
									goto IL_153;
								case 3:
									goto IL_21D;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)888143877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2 = enumerator.Current;
									A_2.Push(group2.Name);
									goto IL_F4;
								}
								case 5:
									num = (short)857866243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									result = true;
									num = (short)751370242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2;
									if (this.a(A_0, group2.Children, A_2))
									{
										num = (short)1849425926;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									A_2.Pop();
									num = (short)668281024;
									short num4 = num;
									num = (short)2072717504;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_F4;
									default:
										num = (short)992149504;
										if (num != 0)
										{
										}
										num = (short)1680277505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_DF;
								IL_F4:
								num = (short)39911431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_158:
								num = (short)167903236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DF:
								goto IL_158;
							}
							IL_153:
							return result;
							IL_21D:
							goto IL_2B2;
						}
						finally
						{
							num = (short)301137922;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1916076033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_28C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_255;
									}
									continue;
								}
								IL_255:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2014445568;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_28C:;
						}
						goto IL_28F;
						IL_2B2:
						num = (short)1392377857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_94;
					}
					goto IL_43;
					IL_28F:
					num = (short)1148715010;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_94:
				A_2.Push(group.Name);
				return true;
				IL_43:
				group = A_1.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.Group g)
				{
					int num5;
					global::System.Guid? id;
					short num6;
					global::System.Guid targetGroupId;
					switch (0)
					{
					case 0:
						break;
					default:
					{
						for (;;)
						{
							IL_0A:
							switch (num5)
							{
							case 0:
								goto IL_61;
							case 1:
								goto IL_E9;
							case 2:
								if (id == null)
								{
									num6 = (short)1837432833;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								goto IL_119;
							case 3:
								if (id == null)
								{
									num6 = (short)1915682816;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								num6 = (short)1639972866;
								num5 = (int)((global::System.IntPtr)num6);
								continue;
							}
							goto IL_20;
						}
						IL_61:
						num6 = (short)1921384448;
						short num7 = num6;
						return false;
						IL_E9:
						num6 = (short)1051629964;
						short num8 = num6;
						num6 = (short)357079436;
						switch ((num8 == num6) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E;
						default:
							num6 = (short)1243938816;
							if (num6 != 0)
							{
							}
							return true;
						}
						IL_119:
						num6 = (short)588709889;
						if (num6 != 0)
						{
						}
						return id.GetValueOrDefault() == targetGroupId;
					}
					}
					IL_20:
					id = g.ID;
					targetGroupId = A_0;
					IL_2E:
					num6 = (short)1966342147;
					num5 = (int)((global::System.IntPtr)num6);
					goto IL_0A;
				});
				num = (short)1015283712;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0004C6A4 File Offset: 0x0004A8A4
		private bool a(string name1, string name2)
		{
			short num = (short)1998454784;
			short num2 = num;
			num = (short)463536131;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_F8;
				case 1:
					if (string.IsNullOrWhiteSpace(name2))
					{
						num = (short)704708608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_121;
				case 2:
					num = (short)1722089473;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1599583582;
					short num4 = num;
					num = (short)1899148638;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_121;
					default:
						num = (short)1652162560;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					break;
				}
				}
				IL_A5:
				if (string.IsNullOrWhiteSpace(name1))
				{
					break;
				}
				num = (short)1924857858;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_F8:
			num = (short)1239941121;
			if (num != 0)
			{
			}
			return false;
			IL_121:
			name1 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.StringToDBC(name1);
			name2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.StringToDBC(name2);
			return name2.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture).Equals(name1.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture));
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0004C800 File Offset: 0x0004AA00
		private global::Motorola.CommonCPS.Server.EntityModel.Group a(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num = (short)1684013056;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			int num4;
			global::Motorola.CommonCPS.Server.EntityModel.Group group;
			global::System.Guid? id;
			for (;;)
			{
				IL_35:
				num = (short)334063438;
				short num3 = num;
				num = (short)980182862;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1587019777;
					if (num != 0)
					{
					}
					num = (short)1345454080;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.IEntity entity = group;
						id = A_0.ID;
						entity.Uuid = id.Value;
						num = (short)1711931393;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return group;
					case 2:
						if (id != null)
						{
							goto IL_10E;
						}
						return group;
					}
					goto IL_B8;
				}
				IL_10E:
				num = (short)336265216;
				num4 = (int)((global::System.IntPtr)num);
			}
			return group;
			IL_B8:
			group = new global::Motorola.CommonCPS.Server.EntityModel.Group
			{
				Name = A_0.Name,
				Timestamp = A_0.Timestamp,
				ParentUuid = A_0.Parent.ID
			};
			id = A_0.ID;
			num = (short)576520194;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0004C964 File Offset: 0x0004AB64
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group a(global::Motorola.CommonCPS.Server.EntityModel.Group group)
		{
			short num = (short)1925971968;
			short num2 = num;
			if (group == null)
			{
				num = (short)232606463;
				short num3 = num;
				num = (short)475089663;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1267269632;
					if (num != 0)
					{
					}
					return null;
				}
			}
			num = (short)1972109313;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.Group
			{
				ID = new global::System.Guid?(group.Uuid),
				Name = group.Name,
				Timestamp = group.Timestamp,
				Parent = 
				{
					ID = group.ParentUuid
				}
			};
		}

		// Token: 0x04000083 RID: 131
		private static global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> a;

		// Token: 0x04000084 RID: 132
		private readonly string[] b;
	}
}
