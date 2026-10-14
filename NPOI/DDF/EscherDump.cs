using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200053C RID: 1340
	public class EscherDump
	{
		// Token: 0x06003293 RID: 12947 RVA: 0x0009A328 File Offset: 0x00098528
		public void Dump(byte[] data, int offset, int size)
		{
			global::NPOI.DDF.IEscherRecordFactory escherRecordFactory = new global::NPOI.DDF.DefaultEscherRecordFactory();
			int num;
			for (int i = offset; i < offset + size; i += num)
			{
				global::NPOI.DDF.EscherRecord escherRecord = escherRecordFactory.CreateRecord(data, i);
				num = escherRecord.FillFields(data, i, escherRecordFactory);
				global::System.Console.WriteLine(escherRecord.ToString());
			}
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x0009A368 File Offset: 0x00098568
		public void DumpOld(long maxLength, global::System.IO.Stream in1)
		{
			long num = maxLength;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = false;
			while (!flag && num > 0L)
			{
				stringBuilder = new global::System.Text.StringBuilder();
				short num2 = global::NPOI.Util.LittleEndian.ReadShort(in1);
				short num3 = global::NPOI.Util.LittleEndian.ReadShort(in1);
				int i = global::NPOI.Util.LittleEndian.ReadInt(in1);
				num -= 8L;
				string value;
				switch (num3)
				{
				case -4096:
					value = "MsofbtDggContainer";
					break;
				case -4095:
					value = "MsofbtBstoreContainer";
					break;
				case -4094:
					value = "MsofbtDgContainer";
					break;
				case -4093:
					value = "MsofbtSpgrContainer";
					break;
				case -4092:
					value = "MsofbtSpContainer";
					break;
				case -4091:
					value = "MsofbtSolverContainer";
					break;
				case -4090:
					value = "MsofbtDgg";
					break;
				case -4089:
					value = "MsofbtBSE";
					break;
				case -4088:
					value = "MsofbtDg";
					break;
				case -4087:
					value = "MsofbtSpgr";
					break;
				case -4086:
					value = "MsofbtSp";
					break;
				case -4085:
					value = "MsofbtOPT";
					break;
				case -4084:
					value = "MsofbtTextbox";
					break;
				case -4083:
					value = "MsofbtClientTextbox";
					break;
				case -4082:
					value = "MsofbtAnchor";
					break;
				case -4081:
					value = "MsofbtChildAnchor";
					break;
				case -4080:
					value = "MsofbtClientAnchor";
					break;
				case -4079:
					value = "MsofbtClientData";
					break;
				case -4078:
					value = "MsofbtConnectorRule";
					break;
				case -4077:
					value = "MsofbtAlignRule";
					break;
				case -4076:
					value = "MsofbtArcRule";
					break;
				case -4075:
					value = "MsofbtClientRule";
					break;
				case -4074:
					value = "MsofbtCLSID";
					break;
				case -4073:
					value = "MsofbtCalloutRule";
					break;
				default:
					switch (num3)
					{
					case -3816:
						value = "MsofbtRegroupItem";
						goto IL_271;
					case -3815:
						value = "MsofbtSelection";
						goto IL_271;
					case -3814:
						value = "MsofbtColorMRU";
						goto IL_271;
					case -3811:
						value = "MsofbtDeletedPspl";
						goto IL_271;
					case -3810:
						value = "MsofbtSplitMenuColors";
						goto IL_271;
					case -3809:
						value = "MsofbtOleObject";
						goto IL_271;
					case -3808:
						value = "MsofbtColorScheme";
						goto IL_271;
					case -3806:
						value = "MsofbtUDefProp";
						goto IL_271;
					}
					if (num3 >= -4072 && num3 <= -3817)
					{
						value = "MsofbtBLIP";
					}
					else if ((num2 & 15) == 15)
					{
						value = "UNKNOWN container";
					}
					else
					{
						value = "UNKNOWN ID";
					}
					break;
				}
				IL_271:
				stringBuilder.Append("  ");
				stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(num3));
				stringBuilder.Append("  ").Append(value).Append(" [");
				stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(num2));
				stringBuilder.Append(',');
				stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(i));
				stringBuilder.Append("]  instance: ");
				stringBuilder.Append(global::NPOI.Util.HexDump.ToHex((short)(num2 >> 4)));
				global::System.Console.WriteLine(stringBuilder.ToString());
				if (num3 == -4089 && 36L <= num && 36 <= i)
				{
					stringBuilder = new global::System.Text.StringBuilder("    btWin32: ");
					byte b = (byte)in1.ReadByte();
					stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(b));
					stringBuilder.Append(this.GetBlipType(b));
					stringBuilder.Append("  btMacOS: ");
					b = (byte)in1.ReadByte();
					stringBuilder.Append(global::NPOI.Util.HexDump.ToHex(b));
					stringBuilder.Append(this.GetBlipType(b));
					global::System.Console.WriteLine(stringBuilder.ToString());
					global::System.Console.WriteLine("    rgbUid:");
					global::NPOI.Util.HexDump.Dump(in1, 0, 16);
					global::System.Console.Write("    tag: ");
					this.OutHex(2, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    size: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    cRef: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    offs: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    usage: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    cbName: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    unused2: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    unused3: ");
					this.OutHex(4, in1);
					global::System.Console.WriteLine();
					num -= 36L;
					i = 0;
				}
				else if (num3 == -4080 && 18L <= num && 18 <= i)
				{
					global::System.Console.Write("    Flag: ");
					this.OutHex(2, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    Col1: ");
					this.OutHex(2, in1);
					global::System.Console.Write("    dX1: ");
					this.OutHex(2, in1);
					global::System.Console.Write("    Row1: ");
					this.OutHex(2, in1);
					global::System.Console.Write("    dY1: ");
					this.OutHex(2, in1);
					global::System.Console.WriteLine();
					global::System.Console.Write("    Col2: ");
					this.OutHex(2, in1);
					global::System.Console.Write("    dX2: ");
					this.OutHex(2, in1);
					global::System.Console.Write("    Row2: ");
					this.OutHex(2, in1);
					global::System.Console.Write("    dY2: ");
					this.OutHex(2, in1);
					global::System.Console.WriteLine();
					num -= 18L;
					i -= 18;
				}
				else if (num3 == -4085 || num3 == -3806)
				{
					int num4 = 0;
					global::System.Console.WriteLine("    PROPID        VALUE");
					while (i >= 6 + num4)
					{
						if (num < (long)(6 + num4))
						{
							break;
						}
						short num5 = global::NPOI.Util.LittleEndian.ReadShort(in1);
						int num6 = global::NPOI.Util.LittleEndian.ReadInt(in1);
						i -= 6;
						num -= 6L;
						global::System.Console.Write("    ");
						global::System.Console.Write(global::NPOI.Util.HexDump.ToHex(num5));
						global::System.Console.Write(" (");
						int num7 = (int)(num5 & 16383);
						global::System.Console.Write(" " + num7.ToString());
						if ((num5 & -32768) == 0)
						{
							if ((num5 & 16384) != 0)
							{
								global::System.Console.Write(", fBlipID");
							}
							global::System.Console.Write(")  ");
							global::System.Console.Write(global::NPOI.Util.HexDump.ToHex(num6));
							if ((num5 & 16384) == 0)
							{
								global::System.Console.Write(" (");
								global::System.Console.Write(this.Dec1616(num6));
								global::System.Console.Write(')');
								global::System.Console.Write(" {" + this.PropertyName((short)num7) + "}");
							}
							global::System.Console.WriteLine();
						}
						else
						{
							global::System.Console.Write(", fComplex)  ");
							global::System.Console.Write(global::NPOI.Util.HexDump.ToHex(num6));
							global::System.Console.Write(" - Complex prop len");
							global::System.Console.WriteLine(" {" + this.PropertyName((short)num7) + "}");
							num4 += num6;
						}
					}
					while (((long)num4 & num) > 0L)
					{
						short num8 = (num4 > (int)num) ? ((short)num) : ((short)num4);
						global::NPOI.Util.HexDump.Dump(in1, 0, (int)num8);
						num4 -= (int)num8;
						i -= (int)num8;
						num -= (long)num8;
					}
				}
				else if (num3 == -4078)
				{
					global::System.Console.Write("    Connector rule: ");
					global::System.Console.Write(global::NPOI.Util.LittleEndian.ReadInt(in1));
					global::System.Console.Write("    ShapeID A: ");
					global::System.Console.Write(global::NPOI.Util.LittleEndian.ReadInt(in1));
					global::System.Console.Write("   ShapeID B: ");
					global::System.Console.Write(global::NPOI.Util.LittleEndian.ReadInt(in1));
					global::System.Console.Write("    ShapeID connector: ");
					global::System.Console.Write(global::NPOI.Util.LittleEndian.ReadInt(in1));
					global::System.Console.Write("   Connect pt A: ");
					global::System.Console.Write(global::NPOI.Util.LittleEndian.ReadInt(in1));
					global::System.Console.Write("   Connect pt B: ");
					global::System.Console.WriteLine(global::NPOI.Util.LittleEndian.ReadInt(in1));
					i -= 24;
					num -= 24L;
				}
				else if (num3 >= -4072 && num3 < -3817)
				{
					global::System.Console.WriteLine("    Secondary UID: ");
					global::NPOI.Util.HexDump.Dump(in1, 0, 16);
					global::System.Console.WriteLine("    Cache of size: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Boundary top: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Boundary left: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Boundary width: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Boundary height: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    X: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Y: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Cache of saved size: " + global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
					global::System.Console.WriteLine("    Compression Flag: " + global::NPOI.Util.HexDump.ToHex((byte)in1.ReadByte()));
					global::System.Console.WriteLine("    Filter: " + global::NPOI.Util.HexDump.ToHex((byte)in1.ReadByte()));
					global::System.Console.WriteLine("    Data (after decompression): ");
					i -= 50;
					num -= 50L;
					short num8 = (i > (int)num) ? ((short)num) : ((short)i);
					byte[] array = new byte[(int)num8];
					int num9 = in1.Read(array, 0, array.Length);
					while (num9 != -1 && num9 < (int)num8)
					{
						num9 += in1.Read(array, num9, array.Length);
					}
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
					{
						global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf = new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(false);
						using (global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream inflaterInputStream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream(memoryStream, inf))
						{
							int bytesToDump = -1;
							global::NPOI.Util.HexDump.Dump(inflaterInputStream, 0, bytesToDump);
							i -= (int)num8;
							num -= (long)num8;
						}
					}
				}
				if ((num2 & 15) == 15 && num >= 0L)
				{
					if (i <= (int)num)
					{
						global::System.Console.WriteLine("            completed within");
					}
					else
					{
						global::System.Console.WriteLine("            continued elsewhere");
					}
				}
				else if (num >= 0L)
				{
					short num8 = (i > (int)num) ? ((short)num) : ((short)i);
					if (num8 != 0)
					{
						global::NPOI.Util.HexDump.Dump(in1, 0, (int)num8);
						num -= (long)num8;
					}
				}
				else
				{
					global::System.Console.WriteLine(" >> OVERRUN <<");
				}
			}
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x0009AD38 File Offset: 0x00098F38
		private string PropertyName(short propertyId)
		{
			global::NPOI.DDF.EscherDump.PropName[] array = new global::NPOI.DDF.EscherDump.PropName[]
			{
				new global::NPOI.DDF.EscherDump.PropName(4, "transform.rotation"),
				new global::NPOI.DDF.EscherDump.PropName(119, "protection.lockrotation"),
				new global::NPOI.DDF.EscherDump.PropName(120, "protection.lockaspectratio"),
				new global::NPOI.DDF.EscherDump.PropName(121, "protection.lockposition"),
				new global::NPOI.DDF.EscherDump.PropName(122, "protection.lockagainstselect"),
				new global::NPOI.DDF.EscherDump.PropName(123, "protection.lockcropping"),
				new global::NPOI.DDF.EscherDump.PropName(124, "protection.lockvertices"),
				new global::NPOI.DDF.EscherDump.PropName(125, "protection.locktext"),
				new global::NPOI.DDF.EscherDump.PropName(126, "protection.lockadjusthandles"),
				new global::NPOI.DDF.EscherDump.PropName(127, "protection.lockagainstgrouping"),
				new global::NPOI.DDF.EscherDump.PropName(128, "text.textid"),
				new global::NPOI.DDF.EscherDump.PropName(129, "text.textleft"),
				new global::NPOI.DDF.EscherDump.PropName(130, "text.texttop"),
				new global::NPOI.DDF.EscherDump.PropName(131, "text.textright"),
				new global::NPOI.DDF.EscherDump.PropName(132, "text.textbottom"),
				new global::NPOI.DDF.EscherDump.PropName(133, "text.wraptext"),
				new global::NPOI.DDF.EscherDump.PropName(134, "text.scaletext"),
				new global::NPOI.DDF.EscherDump.PropName(135, "text.anchortext"),
				new global::NPOI.DDF.EscherDump.PropName(136, "text.textflow"),
				new global::NPOI.DDF.EscherDump.PropName(137, "text.fontrotation"),
				new global::NPOI.DDF.EscherDump.PropName(138, "text.idofnextshape"),
				new global::NPOI.DDF.EscherDump.PropName(139, "text.bidir"),
				new global::NPOI.DDF.EscherDump.PropName(187, "text.singleclickselects"),
				new global::NPOI.DDF.EscherDump.PropName(188, "text.usehostmargins"),
				new global::NPOI.DDF.EscherDump.PropName(189, "text.rotatetextwithshape"),
				new global::NPOI.DDF.EscherDump.PropName(190, "text.sizeshapetofittext"),
				new global::NPOI.DDF.EscherDump.PropName(191, "text.sizetexttofitshape"),
				new global::NPOI.DDF.EscherDump.PropName(192, "geotext.unicode"),
				new global::NPOI.DDF.EscherDump.PropName(193, "geotext.rtftext"),
				new global::NPOI.DDF.EscherDump.PropName(194, "geotext.alignmentoncurve"),
				new global::NPOI.DDF.EscherDump.PropName(195, "geotext.defaultpointsize"),
				new global::NPOI.DDF.EscherDump.PropName(196, "geotext.textspacing"),
				new global::NPOI.DDF.EscherDump.PropName(197, "geotext.fontfamilyname"),
				new global::NPOI.DDF.EscherDump.PropName(240, "geotext.reverseroworder"),
				new global::NPOI.DDF.EscherDump.PropName(241, "geotext.hastexteffect"),
				new global::NPOI.DDF.EscherDump.PropName(242, "geotext.rotatecharacters"),
				new global::NPOI.DDF.EscherDump.PropName(243, "geotext.kerncharacters"),
				new global::NPOI.DDF.EscherDump.PropName(244, "geotext.tightortrack"),
				new global::NPOI.DDF.EscherDump.PropName(245, "geotext.stretchtofitshape"),
				new global::NPOI.DDF.EscherDump.PropName(246, "geotext.charboundingbox"),
				new global::NPOI.DDF.EscherDump.PropName(247, "geotext.scaletextonpath"),
				new global::NPOI.DDF.EscherDump.PropName(248, "geotext.stretchcharheight"),
				new global::NPOI.DDF.EscherDump.PropName(249, "geotext.nomeasurealongpath"),
				new global::NPOI.DDF.EscherDump.PropName(250, "geotext.boldfont"),
				new global::NPOI.DDF.EscherDump.PropName(251, "geotext.italicfont"),
				new global::NPOI.DDF.EscherDump.PropName(252, "geotext.underlinefont"),
				new global::NPOI.DDF.EscherDump.PropName(253, "geotext.shadowfont"),
				new global::NPOI.DDF.EscherDump.PropName(254, "geotext.smallcapsfont"),
				new global::NPOI.DDF.EscherDump.PropName(255, "geotext.strikethroughfont"),
				new global::NPOI.DDF.EscherDump.PropName(256, "blip.cropfromtop"),
				new global::NPOI.DDF.EscherDump.PropName(257, "blip.cropfrombottom"),
				new global::NPOI.DDF.EscherDump.PropName(258, "blip.cropfromleft"),
				new global::NPOI.DDF.EscherDump.PropName(259, "blip.cropfromright"),
				new global::NPOI.DDF.EscherDump.PropName(260, "blip.bliptodisplay"),
				new global::NPOI.DDF.EscherDump.PropName(261, "blip.blipfilename"),
				new global::NPOI.DDF.EscherDump.PropName(262, "blip.blipflags"),
				new global::NPOI.DDF.EscherDump.PropName(263, "blip.transparentcolor"),
				new global::NPOI.DDF.EscherDump.PropName(264, "blip.contrastSetting"),
				new global::NPOI.DDF.EscherDump.PropName(265, "blip.brightnessSetting"),
				new global::NPOI.DDF.EscherDump.PropName(266, "blip.gamma"),
				new global::NPOI.DDF.EscherDump.PropName(267, "blip.pictureid"),
				new global::NPOI.DDF.EscherDump.PropName(268, "blip.doublemod"),
				new global::NPOI.DDF.EscherDump.PropName(269, "blip.picturefillmod"),
				new global::NPOI.DDF.EscherDump.PropName(270, "blip.pictureline"),
				new global::NPOI.DDF.EscherDump.PropName(271, "blip.printblip"),
				new global::NPOI.DDF.EscherDump.PropName(272, "blip.printblipfilename"),
				new global::NPOI.DDF.EscherDump.PropName(273, "blip.printflags"),
				new global::NPOI.DDF.EscherDump.PropName(316, "blip.nohittestpicture"),
				new global::NPOI.DDF.EscherDump.PropName(317, "blip.picturegray"),
				new global::NPOI.DDF.EscherDump.PropName(318, "blip.picturebilevel"),
				new global::NPOI.DDF.EscherDump.PropName(319, "blip.pictureactive"),
				new global::NPOI.DDF.EscherDump.PropName(320, "geometry.left"),
				new global::NPOI.DDF.EscherDump.PropName(321, "geometry.top"),
				new global::NPOI.DDF.EscherDump.PropName(322, "geometry.right"),
				new global::NPOI.DDF.EscherDump.PropName(323, "geometry.bottom"),
				new global::NPOI.DDF.EscherDump.PropName(324, "geometry.shapepath"),
				new global::NPOI.DDF.EscherDump.PropName(325, "geometry.vertices"),
				new global::NPOI.DDF.EscherDump.PropName(326, "geometry.segmentinfo"),
				new global::NPOI.DDF.EscherDump.PropName(327, "geometry.adjustvalue"),
				new global::NPOI.DDF.EscherDump.PropName(328, "geometry.adjust2value"),
				new global::NPOI.DDF.EscherDump.PropName(329, "geometry.adjust3value"),
				new global::NPOI.DDF.EscherDump.PropName(330, "geometry.adjust4value"),
				new global::NPOI.DDF.EscherDump.PropName(331, "geometry.adjust5value"),
				new global::NPOI.DDF.EscherDump.PropName(332, "geometry.adjust6value"),
				new global::NPOI.DDF.EscherDump.PropName(333, "geometry.adjust7value"),
				new global::NPOI.DDF.EscherDump.PropName(334, "geometry.adjust8value"),
				new global::NPOI.DDF.EscherDump.PropName(335, "geometry.adjust9value"),
				new global::NPOI.DDF.EscherDump.PropName(336, "geometry.adjust10value"),
				new global::NPOI.DDF.EscherDump.PropName(378, "geometry.shadowOK"),
				new global::NPOI.DDF.EscherDump.PropName(379, "geometry.3dok"),
				new global::NPOI.DDF.EscherDump.PropName(380, "geometry.lineok"),
				new global::NPOI.DDF.EscherDump.PropName(381, "geometry.geotextok"),
				new global::NPOI.DDF.EscherDump.PropName(382, "geometry.fillshadeshapeok"),
				new global::NPOI.DDF.EscherDump.PropName(383, "geometry.fillok"),
				new global::NPOI.DDF.EscherDump.PropName(384, "fill.filltype"),
				new global::NPOI.DDF.EscherDump.PropName(385, "fill.fillcolor"),
				new global::NPOI.DDF.EscherDump.PropName(386, "fill.fillopacity"),
				new global::NPOI.DDF.EscherDump.PropName(387, "fill.fillbackcolor"),
				new global::NPOI.DDF.EscherDump.PropName(388, "fill.backopacity"),
				new global::NPOI.DDF.EscherDump.PropName(389, "fill.crmod"),
				new global::NPOI.DDF.EscherDump.PropName(390, "fill.patterntexture"),
				new global::NPOI.DDF.EscherDump.PropName(391, "fill.blipfilename"),
				new global::NPOI.DDF.EscherDump.PropName(392, "fill.blipflags"),
				new global::NPOI.DDF.EscherDump.PropName(393, "fill.width"),
				new global::NPOI.DDF.EscherDump.PropName(394, "fill.height"),
				new global::NPOI.DDF.EscherDump.PropName(395, "fill.angle"),
				new global::NPOI.DDF.EscherDump.PropName(396, "fill.focus"),
				new global::NPOI.DDF.EscherDump.PropName(397, "fill.toleft"),
				new global::NPOI.DDF.EscherDump.PropName(398, "fill.totop"),
				new global::NPOI.DDF.EscherDump.PropName(399, "fill.toright"),
				new global::NPOI.DDF.EscherDump.PropName(400, "fill.tobottom"),
				new global::NPOI.DDF.EscherDump.PropName(401, "fill.rectleft"),
				new global::NPOI.DDF.EscherDump.PropName(402, "fill.recttop"),
				new global::NPOI.DDF.EscherDump.PropName(403, "fill.rectright"),
				new global::NPOI.DDF.EscherDump.PropName(404, "fill.rectbottom"),
				new global::NPOI.DDF.EscherDump.PropName(405, "fill.dztype"),
				new global::NPOI.DDF.EscherDump.PropName(406, "fill.shadepReset"),
				new global::NPOI.DDF.EscherDump.PropName(407, "fill.shadecolors"),
				new global::NPOI.DDF.EscherDump.PropName(408, "fill.originx"),
				new global::NPOI.DDF.EscherDump.PropName(409, "fill.originy"),
				new global::NPOI.DDF.EscherDump.PropName(410, "fill.shapeoriginx"),
				new global::NPOI.DDF.EscherDump.PropName(411, "fill.shapeoriginy"),
				new global::NPOI.DDF.EscherDump.PropName(412, "fill.shadetype"),
				new global::NPOI.DDF.EscherDump.PropName(443, "fill.filled"),
				new global::NPOI.DDF.EscherDump.PropName(444, "fill.hittestfill"),
				new global::NPOI.DDF.EscherDump.PropName(445, "fill.shape"),
				new global::NPOI.DDF.EscherDump.PropName(446, "fill.userect"),
				new global::NPOI.DDF.EscherDump.PropName(447, "fill.nofillhittest"),
				new global::NPOI.DDF.EscherDump.PropName(448, "linestyle.color"),
				new global::NPOI.DDF.EscherDump.PropName(449, "linestyle.opacity"),
				new global::NPOI.DDF.EscherDump.PropName(450, "linestyle.backcolor"),
				new global::NPOI.DDF.EscherDump.PropName(451, "linestyle.crmod"),
				new global::NPOI.DDF.EscherDump.PropName(452, "linestyle.linetype"),
				new global::NPOI.DDF.EscherDump.PropName(453, "linestyle.fillblip"),
				new global::NPOI.DDF.EscherDump.PropName(454, "linestyle.fillblipname"),
				new global::NPOI.DDF.EscherDump.PropName(455, "linestyle.fillblipflags"),
				new global::NPOI.DDF.EscherDump.PropName(456, "linestyle.fillwidth"),
				new global::NPOI.DDF.EscherDump.PropName(457, "linestyle.fillheight"),
				new global::NPOI.DDF.EscherDump.PropName(458, "linestyle.filldztype"),
				new global::NPOI.DDF.EscherDump.PropName(459, "linestyle.linewidth"),
				new global::NPOI.DDF.EscherDump.PropName(460, "linestyle.linemiterlimit"),
				new global::NPOI.DDF.EscherDump.PropName(461, "linestyle.linestyle"),
				new global::NPOI.DDF.EscherDump.PropName(462, "linestyle.linedashing"),
				new global::NPOI.DDF.EscherDump.PropName(463, "linestyle.linedashstyle"),
				new global::NPOI.DDF.EscherDump.PropName(464, "linestyle.linestartarrowhead"),
				new global::NPOI.DDF.EscherDump.PropName(465, "linestyle.lineendarrowhead"),
				new global::NPOI.DDF.EscherDump.PropName(466, "linestyle.linestartarrowwidth"),
				new global::NPOI.DDF.EscherDump.PropName(467, "linestyle.lineestartarrowLength"),
				new global::NPOI.DDF.EscherDump.PropName(468, "linestyle.lineendarrowwidth"),
				new global::NPOI.DDF.EscherDump.PropName(469, "linestyle.lineendarrowLength"),
				new global::NPOI.DDF.EscherDump.PropName(470, "linestyle.linejoinstyle"),
				new global::NPOI.DDF.EscherDump.PropName(471, "linestyle.lineendcapstyle"),
				new global::NPOI.DDF.EscherDump.PropName(507, "linestyle.arrowheadsok"),
				new global::NPOI.DDF.EscherDump.PropName(508, "linestyle.anyline"),
				new global::NPOI.DDF.EscherDump.PropName(509, "linestyle.hitlinetest"),
				new global::NPOI.DDF.EscherDump.PropName(510, "linestyle.linefillshape"),
				new global::NPOI.DDF.EscherDump.PropName(511, "linestyle.nolinedrawdash"),
				new global::NPOI.DDF.EscherDump.PropName(512, "shadowstyle.type"),
				new global::NPOI.DDF.EscherDump.PropName(513, "shadowstyle.color"),
				new global::NPOI.DDF.EscherDump.PropName(514, "shadowstyle.highlight"),
				new global::NPOI.DDF.EscherDump.PropName(515, "shadowstyle.crmod"),
				new global::NPOI.DDF.EscherDump.PropName(516, "shadowstyle.opacity"),
				new global::NPOI.DDF.EscherDump.PropName(517, "shadowstyle.offsetx"),
				new global::NPOI.DDF.EscherDump.PropName(518, "shadowstyle.offsety"),
				new global::NPOI.DDF.EscherDump.PropName(519, "shadowstyle.secondoffsetx"),
				new global::NPOI.DDF.EscherDump.PropName(520, "shadowstyle.secondoffsety"),
				new global::NPOI.DDF.EscherDump.PropName(521, "shadowstyle.scalextox"),
				new global::NPOI.DDF.EscherDump.PropName(522, "shadowstyle.scaleytox"),
				new global::NPOI.DDF.EscherDump.PropName(523, "shadowstyle.scalextoy"),
				new global::NPOI.DDF.EscherDump.PropName(524, "shadowstyle.scaleytoy"),
				new global::NPOI.DDF.EscherDump.PropName(525, "shadowstyle.perspectivex"),
				new global::NPOI.DDF.EscherDump.PropName(526, "shadowstyle.perspectivey"),
				new global::NPOI.DDF.EscherDump.PropName(527, "shadowstyle.weight"),
				new global::NPOI.DDF.EscherDump.PropName(528, "shadowstyle.originx"),
				new global::NPOI.DDF.EscherDump.PropName(529, "shadowstyle.originy"),
				new global::NPOI.DDF.EscherDump.PropName(574, "shadowstyle.shadow"),
				new global::NPOI.DDF.EscherDump.PropName(575, "shadowstyle.shadowobsured"),
				new global::NPOI.DDF.EscherDump.PropName(576, "perspective.type"),
				new global::NPOI.DDF.EscherDump.PropName(577, "perspective.offsetx"),
				new global::NPOI.DDF.EscherDump.PropName(578, "perspective.offsety"),
				new global::NPOI.DDF.EscherDump.PropName(579, "perspective.scalextox"),
				new global::NPOI.DDF.EscherDump.PropName(580, "perspective.scaleytox"),
				new global::NPOI.DDF.EscherDump.PropName(581, "perspective.scalextoy"),
				new global::NPOI.DDF.EscherDump.PropName(582, "perspective.scaleytox"),
				new global::NPOI.DDF.EscherDump.PropName(583, "perspective.perspectivex"),
				new global::NPOI.DDF.EscherDump.PropName(584, "perspective.perspectivey"),
				new global::NPOI.DDF.EscherDump.PropName(585, "perspective.weight"),
				new global::NPOI.DDF.EscherDump.PropName(586, "perspective.originx"),
				new global::NPOI.DDF.EscherDump.PropName(587, "perspective.originy"),
				new global::NPOI.DDF.EscherDump.PropName(639, "perspective.perspectiveon"),
				new global::NPOI.DDF.EscherDump.PropName(640, "3d.specularamount"),
				new global::NPOI.DDF.EscherDump.PropName(661, "3d.diffuseamount"),
				new global::NPOI.DDF.EscherDump.PropName(662, "3d.shininess"),
				new global::NPOI.DDF.EscherDump.PropName(663, "3d.edGethickness"),
				new global::NPOI.DDF.EscherDump.PropName(664, "3d.extrudeforward"),
				new global::NPOI.DDF.EscherDump.PropName(665, "3d.extrudebackward"),
				new global::NPOI.DDF.EscherDump.PropName(666, "3d.extrudeplane"),
				new global::NPOI.DDF.EscherDump.PropName(667, "3d.extrusioncolor"),
				new global::NPOI.DDF.EscherDump.PropName(648, "3d.crmod"),
				new global::NPOI.DDF.EscherDump.PropName(700, "3d.3deffect"),
				new global::NPOI.DDF.EscherDump.PropName(701, "3d.metallic"),
				new global::NPOI.DDF.EscherDump.PropName(702, "3d.useextrusioncolor"),
				new global::NPOI.DDF.EscherDump.PropName(703, "3d.lightface"),
				new global::NPOI.DDF.EscherDump.PropName(704, "3dstyle.yrotationangle"),
				new global::NPOI.DDF.EscherDump.PropName(705, "3dstyle.xrotationangle"),
				new global::NPOI.DDF.EscherDump.PropName(706, "3dstyle.rotationaxisx"),
				new global::NPOI.DDF.EscherDump.PropName(707, "3dstyle.rotationaxisy"),
				new global::NPOI.DDF.EscherDump.PropName(708, "3dstyle.rotationaxisz"),
				new global::NPOI.DDF.EscherDump.PropName(709, "3dstyle.rotationangle"),
				new global::NPOI.DDF.EscherDump.PropName(710, "3dstyle.rotationcenterx"),
				new global::NPOI.DDF.EscherDump.PropName(711, "3dstyle.rotationcentery"),
				new global::NPOI.DDF.EscherDump.PropName(712, "3dstyle.rotationcenterz"),
				new global::NPOI.DDF.EscherDump.PropName(713, "3dstyle.rendermode"),
				new global::NPOI.DDF.EscherDump.PropName(714, "3dstyle.tolerance"),
				new global::NPOI.DDF.EscherDump.PropName(715, "3dstyle.xviewpoint"),
				new global::NPOI.DDF.EscherDump.PropName(716, "3dstyle.yviewpoint"),
				new global::NPOI.DDF.EscherDump.PropName(717, "3dstyle.zviewpoint"),
				new global::NPOI.DDF.EscherDump.PropName(718, "3dstyle.originx"),
				new global::NPOI.DDF.EscherDump.PropName(719, "3dstyle.originy"),
				new global::NPOI.DDF.EscherDump.PropName(720, "3dstyle.skewangle"),
				new global::NPOI.DDF.EscherDump.PropName(721, "3dstyle.skewamount"),
				new global::NPOI.DDF.EscherDump.PropName(722, "3dstyle.ambientintensity"),
				new global::NPOI.DDF.EscherDump.PropName(723, "3dstyle.keyx"),
				new global::NPOI.DDF.EscherDump.PropName(724, "3dstyle.keyy"),
				new global::NPOI.DDF.EscherDump.PropName(725, "3dstyle.keyz"),
				new global::NPOI.DDF.EscherDump.PropName(726, "3dstyle.keyintensity"),
				new global::NPOI.DDF.EscherDump.PropName(727, "3dstyle.fillx"),
				new global::NPOI.DDF.EscherDump.PropName(728, "3dstyle.filly"),
				new global::NPOI.DDF.EscherDump.PropName(729, "3dstyle.fillz"),
				new global::NPOI.DDF.EscherDump.PropName(730, "3dstyle.fillintensity"),
				new global::NPOI.DDF.EscherDump.PropName(763, "3dstyle.constrainrotation"),
				new global::NPOI.DDF.EscherDump.PropName(764, "3dstyle.rotationcenterauto"),
				new global::NPOI.DDF.EscherDump.PropName(765, "3dstyle.parallel"),
				new global::NPOI.DDF.EscherDump.PropName(766, "3dstyle.keyharsh"),
				new global::NPOI.DDF.EscherDump.PropName(767, "3dstyle.fillharsh"),
				new global::NPOI.DDF.EscherDump.PropName(769, "shape.master"),
				new global::NPOI.DDF.EscherDump.PropName(771, "shape.connectorstyle"),
				new global::NPOI.DDF.EscherDump.PropName(772, "shape.blackandwhiteSettings"),
				new global::NPOI.DDF.EscherDump.PropName(773, "shape.wmodepurebw"),
				new global::NPOI.DDF.EscherDump.PropName(774, "shape.wmodebw"),
				new global::NPOI.DDF.EscherDump.PropName(826, "shape.oleicon"),
				new global::NPOI.DDF.EscherDump.PropName(827, "shape.preferrelativeresize"),
				new global::NPOI.DDF.EscherDump.PropName(828, "shape.lockshapetype"),
				new global::NPOI.DDF.EscherDump.PropName(830, "shape.deleteattachedobject"),
				new global::NPOI.DDF.EscherDump.PropName(831, "shape.backgroundshape"),
				new global::NPOI.DDF.EscherDump.PropName(832, "callout.callouttype"),
				new global::NPOI.DDF.EscherDump.PropName(833, "callout.xycalloutgap"),
				new global::NPOI.DDF.EscherDump.PropName(834, "callout.calloutangle"),
				new global::NPOI.DDF.EscherDump.PropName(835, "callout.calloutdroptype"),
				new global::NPOI.DDF.EscherDump.PropName(836, "callout.calloutdropspecified"),
				new global::NPOI.DDF.EscherDump.PropName(837, "callout.calloutLengthspecified"),
				new global::NPOI.DDF.EscherDump.PropName(889, "callout.iscallout"),
				new global::NPOI.DDF.EscherDump.PropName(890, "callout.calloutaccentbar"),
				new global::NPOI.DDF.EscherDump.PropName(891, "callout.callouttextborder"),
				new global::NPOI.DDF.EscherDump.PropName(892, "callout.calloutminusx"),
				new global::NPOI.DDF.EscherDump.PropName(893, "callout.calloutminusy"),
				new global::NPOI.DDF.EscherDump.PropName(894, "callout.dropauto"),
				new global::NPOI.DDF.EscherDump.PropName(895, "callout.Lengthspecified"),
				new global::NPOI.DDF.EscherDump.PropName(896, "groupshape.shapename"),
				new global::NPOI.DDF.EscherDump.PropName(897, "groupshape.description"),
				new global::NPOI.DDF.EscherDump.PropName(898, "groupshape.hyperlink"),
				new global::NPOI.DDF.EscherDump.PropName(899, "groupshape.wrappolygonvertices"),
				new global::NPOI.DDF.EscherDump.PropName(900, "groupshape.wrapdistleft"),
				new global::NPOI.DDF.EscherDump.PropName(901, "groupshape.wrapdisttop"),
				new global::NPOI.DDF.EscherDump.PropName(902, "groupshape.wrapdistright"),
				new global::NPOI.DDF.EscherDump.PropName(903, "groupshape.wrapdistbottom"),
				new global::NPOI.DDF.EscherDump.PropName(904, "groupshape.regroupid"),
				new global::NPOI.DDF.EscherDump.PropName(953, "groupshape.editedwrap"),
				new global::NPOI.DDF.EscherDump.PropName(954, "groupshape.behinddocument"),
				new global::NPOI.DDF.EscherDump.PropName(955, "groupshape.ondblclicknotify"),
				new global::NPOI.DDF.EscherDump.PropName(956, "groupshape.isbutton"),
				new global::NPOI.DDF.EscherDump.PropName(957, "groupshape.1dadjustment"),
				new global::NPOI.DDF.EscherDump.PropName(958, "groupshape.hidden"),
				new global::NPOI.DDF.EscherDump.PropName(959, "groupshape.print")
			};
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].id == (int)propertyId)
				{
					return array[i].name;
				}
			}
			return "unknown property";
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x0009C35C File Offset: 0x0009A55C
		private string GetBlipType(byte b)
		{
			switch (b)
			{
			case 0:
				return " ERROR";
			case 1:
				return " UNKNOWN";
			case 2:
				return " EMF";
			case 3:
				return " WMF";
			case 4:
				return " PICT";
			case 5:
				return " JPEG";
			case 6:
				return " PNG";
			case 7:
				return " DIB";
			default:
				if (b < 32)
				{
					return " NotKnown";
				}
				return " Client";
			}
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0009C3D4 File Offset: 0x0009A5D4
		private string Dec1616(int n32)
		{
			return "" + ((short)(n32 >> 16)).ToString() + "." + ((short)(n32 & 65535)).ToString();
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x0009C418 File Offset: 0x0009A618
		private void OutHex(int bytes, global::System.IO.Stream in1)
		{
			switch (bytes)
			{
			case 1:
				global::System.Console.Write(global::NPOI.Util.HexDump.ToHex((byte)in1.ReadByte()));
				return;
			case 2:
				global::System.Console.Write(global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadShort(in1)));
				return;
			case 4:
				global::System.Console.Write(global::NPOI.Util.HexDump.ToHex(global::NPOI.Util.LittleEndian.ReadInt(in1)));
				return;
			}
			throw new global::System.IO.IOException("Unable to output variable of that width");
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x0009C47D File Offset: 0x0009A67D
		public void Dump(int recordSize, byte[] data)
		{
			this.Dump(data, 0, recordSize);
		}

		// Token: 0x02000630 RID: 1584
		private class PropName
		{
			// Token: 0x060036F4 RID: 14068 RVA: 0x000A7C1F File Offset: 0x000A5E1F
			public PropName(int id, string name)
			{
				this.id = id;
				this.name = name;
			}

			// Token: 0x04001AC5 RID: 6853
			public int id;

			// Token: 0x04001AC6 RID: 6854
			public string name;
		}
	}
}
