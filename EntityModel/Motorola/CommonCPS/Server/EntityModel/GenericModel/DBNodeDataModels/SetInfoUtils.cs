using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001E8 RID: 488
	public static class SetInfoUtils
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x001049B0 File Offset: 0x00102BB0
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo> GetAllSetInfo(global::System.IO.Stream inputStream)
		{
			int a_ = 16;
			short num = (short)2021326848;
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
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo> dictionary;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
					switch (num2)
					{
					case 0:
						if (inputStream.CanRead)
						{
							num = (short)385351682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_705;
					case 1:
						try
						{
							num = (short)2113732611;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_62C;
								case 1:
								{
									global::System.Xml.Linq.XElement xelement = enumerator.Current;
									string value = xelement.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("崍甏昑䀓漕栗缙", a_)).Value;
									global::System.Xml.Linq.XAttribute xattribute = xelement.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("崍甏昑唓稕焗笙漛", a_));
									string setAlias = (xattribute != null && !string.IsNullOrEmpty(xattribute.Value)) ? xattribute.Value : string.Empty;
									global::System.Xml.Linq.XAttribute xattribute2 = xelement.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("崍砏猑易猕礗砙瀛笝", a_));
									string shareable = (xattribute2 != null && !string.IsNullOrWhiteSpace(xattribute2.Value)) ? xattribute2.Value.ToLowerInvariant() : null;
									global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo setInfo = null;
									if (!dictionary.TryGetValue(value, out setInfo))
									{
										setInfo = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo
										{
											SetType = value,
											SetAlias = setAlias,
											Shareable = shareable
										};
										dictionary.Add(value, setInfo);
									}
									global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2 = xelement.Descendants(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䠍礏眑砓爕", a_)).GetEnumerator();
									num = (short)1662255109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)155451392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E8;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)595197954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2066415617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									try
									{
										num = (short)1496973324;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo fieldInfo;
											switch (num2)
											{
											case 0:
												num = (short)1451163652;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_324;
											case 2:
												goto IL_565;
											case 3:
												goto IL_283;
											case 4:
											{
												global::System.Xml.Linq.XAttribute xattribute;
												bool isMoved;
												if (bool.TryParse(xattribute.Value, out isMoved))
												{
													num = (short)1947074569;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_324;
											}
											case 5:
											{
												global::System.Xml.Linq.XAttribute xattribute;
												bool isLocked;
												if (bool.TryParse(xattribute.Value, out isLocked))
												{
													num = (short)546308109;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_283;
											}
											case 6:
											{
												global::System.Xml.Linq.XAttribute xattribute;
												if (xattribute != null)
												{
													num = (short)157155338;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_283;
											}
											case 7:
												IL_3B5:
												num = (short)700776450;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												bool isMoved;
												fieldInfo.IsMoved = isMoved;
												num = (short)1691222017;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												num = (short)849346565;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
											{
												global::System.Xml.Linq.XAttribute xattribute;
												if (xattribute != null)
												{
													num = (short)1935015936;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_324;
											}
											case 12:
												switch (0)
												{
												case 0:
													goto IL_27E;
												}
												continue;
											case 13:
											{
												bool isLocked;
												fieldInfo.IsLocked = isLocked;
												num = (short)655032323;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
											{
												global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)720437255;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.Linq.XElement xelement2 = enumerator2.Current;
												fieldInfo = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.FieldInfo
												{
													BLLFieldName = xelement2.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䰍小帑刓缕紗瘙砛倝䄟伡䄣", a_)).Value,
													RMFieldName = xelement2.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("對崏向紓猕琗縙创缝䴟䜡", a_)).Value,
													IsNeedToEncrypt = bool.Parse(xelement2.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䜍挏少焓猕簗丙猛嬝丟䄡嘣弥堧帩", a_)).Value)
												};
												global::System.Xml.Linq.XAttribute xattribute = xelement2.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䜍挏帑笓甕猗缙砛", a_));
												bool isLocked = false;
												num = (short)206372870;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											goto IL_27E;
											IL_283:
											num = (short)393948921;
											short num3 = num;
											num = (short)456208121;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_3B5;
											default:
											{
												num = (short)1728249856;
												if (num != 0)
												{
												}
												global::System.Xml.Linq.XElement xelement2;
												global::System.Xml.Linq.XAttribute xattribute = xelement2.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䜍挏弑笓怕紗縙", a_));
												bool isMoved = false;
												num = (short)733609995;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_324:
											global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo setInfo;
											setInfo.FieldInfos.Add(fieldInfo.BLLFieldName, fieldInfo);
											num = (short)1618608136;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_379:
											num = (short)1665728526;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_27E:
											goto IL_379;
										}
										IL_565:;
									}
									finally
									{
										num = (short)515440640;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_599;
												}
												continue;
											case 1:
												goto IL_5D2;
											case 2:
												enumerator2.Dispose();
												num = (short)48758785;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_599:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1996095490;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5D2:;
									}
									break;
								}
								IL_5D5:
								num = (short)1796341764;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E8:
								goto IL_5D5;
							}
							IL_62C:
							goto IL_705;
						}
						finally
						{
							num = (short)455016448;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_663;
									}
									continue;
								case 1:
									goto IL_699;
								case 2:
									enumerator.Dispose();
									num = (short)208732161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_663:
								if (enumerator == null)
								{
									break;
								}
								num = (short)572391426;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_699:;
						}
						goto IL_69C;
					case 2:
						num = (short)680919041;
						if (num != 0)
						{
						}
						goto IL_69C;
					}
					goto IL_43;
					IL_69C:
					enumerator = global::System.Xml.Linq.XElement.Load(inputStream).Descendants(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("崍甏昑", a_)).GetEnumerator();
					num = (short)1859584000;
					short num4 = num;
					num = (short)376242177;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_705:
				return dictionary.Values.ToList<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo>();
				IL_43:
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo>();
				num = (short)2119172096;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
