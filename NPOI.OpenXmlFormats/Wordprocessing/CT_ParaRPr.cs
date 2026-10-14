using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200015D RID: 349
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ParaRPr
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000238A8 File Offset: 0x00021AA8
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x000238B0 File Offset: 0x00021AB0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange ins
		{
			get
			{
				return this.insField;
			}
			set
			{
				this.insField = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000238B9 File Offset: 0x00021AB9
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x000238C1 File Offset: 0x00021AC1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange del
		{
			get
			{
				return this.delField;
			}
			set
			{
				this.delField = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000238CA File Offset: 0x00021ACA
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x000238D2 File Offset: 0x00021AD2
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveFrom
		{
			get
			{
				return this.moveFromField;
			}
			set
			{
				this.moveFromField = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000238DB File Offset: 0x00021ADB
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x000238E3 File Offset: 0x00021AE3
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveTo
		{
			get
			{
				return this.moveToField;
			}
			set
			{
				this.moveToField = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000238EC File Offset: 0x00021AEC
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x000238F4 File Offset: 0x00021AF4
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String rStyle
		{
			get
			{
				return this.rStyleField;
			}
			set
			{
				this.rStyleField = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000238FD File Offset: 0x00021AFD
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00023905 File Offset: 0x00021B05
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts rFonts
		{
			get
			{
				return this.rFontsField;
			}
			set
			{
				this.rFontsField = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002390E File Offset: 0x00021B0E
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00023916 File Offset: 0x00021B16
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0002391F File Offset: 0x00021B1F
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00023927 File Offset: 0x00021B27
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bCs
		{
			get
			{
				return this.bCsField;
			}
			set
			{
				this.bCsField = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00023930 File Offset: 0x00021B30
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00023938 File Offset: 0x00021B38
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00023941 File Offset: 0x00021B41
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00023949 File Offset: 0x00021B49
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff iCs
		{
			get
			{
				return this.iCsField;
			}
			set
			{
				this.iCsField = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00023952 File Offset: 0x00021B52
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0002395A File Offset: 0x00021B5A
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff caps
		{
			get
			{
				return this.capsField;
			}
			set
			{
				this.capsField = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00023963 File Offset: 0x00021B63
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0002396B File Offset: 0x00021B6B
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff smallCaps
		{
			get
			{
				return this.smallCapsField;
			}
			set
			{
				this.smallCapsField = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00023974 File Offset: 0x00021B74
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0002397C File Offset: 0x00021B7C
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff strike
		{
			get
			{
				return this.strikeField;
			}
			set
			{
				this.strikeField = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00023985 File Offset: 0x00021B85
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0002398D File Offset: 0x00021B8D
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dstrike
		{
			get
			{
				return this.dstrikeField;
			}
			set
			{
				this.dstrikeField = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00023996 File Offset: 0x00021B96
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0002399E File Offset: 0x00021B9E
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000239A7 File Offset: 0x00021BA7
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000239AF File Offset: 0x00021BAF
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000239B8 File Offset: 0x00021BB8
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x000239C0 File Offset: 0x00021BC0
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff emboss
		{
			get
			{
				return this.embossField;
			}
			set
			{
				this.embossField = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000239C9 File Offset: 0x00021BC9
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000239D1 File Offset: 0x00021BD1
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff imprint
		{
			get
			{
				return this.imprintField;
			}
			set
			{
				this.imprintField = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000239DA File Offset: 0x00021BDA
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x000239E2 File Offset: 0x00021BE2
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noProof
		{
			get
			{
				return this.noProofField;
			}
			set
			{
				this.noProofField = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000239EB File Offset: 0x00021BEB
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x000239F3 File Offset: 0x00021BF3
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff snapToGrid
		{
			get
			{
				return this.snapToGridField;
			}
			set
			{
				this.snapToGridField = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000239FC File Offset: 0x00021BFC
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00023A04 File Offset: 0x00021C04
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff vanish
		{
			get
			{
				return this.vanishField;
			}
			set
			{
				this.vanishField = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00023A0D File Offset: 0x00021C0D
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00023A15 File Offset: 0x00021C15
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff webHidden
		{
			get
			{
				return this.webHiddenField;
			}
			set
			{
				this.webHiddenField = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00023A1E File Offset: 0x00021C1E
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00023A26 File Offset: 0x00021C26
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00023A2F File Offset: 0x00021C2F
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00023A37 File Offset: 0x00021C37
		[global::System.Xml.Serialization.XmlElement(Order = 23)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure spacing
		{
			get
			{
				return this.spacingField;
			}
			set
			{
				this.spacingField = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00023A40 File Offset: 0x00021C40
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00023A48 File Offset: 0x00021C48
		[global::System.Xml.Serialization.XmlElement(Order = 24)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00023A51 File Offset: 0x00021C51
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00023A59 File Offset: 0x00021C59
		[global::System.Xml.Serialization.XmlElement(Order = 25)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure kern
		{
			get
			{
				return this.kernField;
			}
			set
			{
				this.kernField = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00023A62 File Offset: 0x00021C62
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00023A6A File Offset: 0x00021C6A
		[global::System.Xml.Serialization.XmlElement(Order = 26)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00023A73 File Offset: 0x00021C73
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00023A7B File Offset: 0x00021C7B
		[global::System.Xml.Serialization.XmlElement(Order = 27)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00023A84 File Offset: 0x00021C84
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00023A8C File Offset: 0x00021C8C
		[global::System.Xml.Serialization.XmlElement(Order = 28)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure szCs
		{
			get
			{
				return this.szCsField;
			}
			set
			{
				this.szCsField = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00023A95 File Offset: 0x00021C95
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00023A9D File Offset: 0x00021C9D
		[global::System.Xml.Serialization.XmlElement(Order = 29)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight highlight
		{
			get
			{
				return this.highlightField;
			}
			set
			{
				this.highlightField = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00023AA6 File Offset: 0x00021CA6
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00023AAE File Offset: 0x00021CAE
		[global::System.Xml.Serialization.XmlElement(Order = 30)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00023AB7 File Offset: 0x00021CB7
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00023ABF File Offset: 0x00021CBF
		[global::System.Xml.Serialization.XmlElement(Order = 31)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect effect
		{
			get
			{
				return this.effectField;
			}
			set
			{
				this.effectField = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00023AC8 File Offset: 0x00021CC8
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00023AD0 File Offset: 0x00021CD0
		[global::System.Xml.Serialization.XmlElement(Order = 32)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bdr
		{
			get
			{
				return this.bdrField;
			}
			set
			{
				this.bdrField = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00023AD9 File Offset: 0x00021CD9
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00023AE1 File Offset: 0x00021CE1
		[global::System.Xml.Serialization.XmlElement(Order = 33)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shd
		{
			get
			{
				return this.shdField;
			}
			set
			{
				this.shdField = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00023AEA File Offset: 0x00021CEA
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00023AF2 File Offset: 0x00021CF2
		[global::System.Xml.Serialization.XmlElement(Order = 34)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText fitText
		{
			get
			{
				return this.fitTextField;
			}
			set
			{
				this.fitTextField = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00023AFB File Offset: 0x00021CFB
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00023B03 File Offset: 0x00021D03
		[global::System.Xml.Serialization.XmlElement(Order = 35)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun vertAlign
		{
			get
			{
				return this.vertAlignField;
			}
			set
			{
				this.vertAlignField = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00023B0C File Offset: 0x00021D0C
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00023B14 File Offset: 0x00021D14
		[global::System.Xml.Serialization.XmlElement(Order = 36)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtl
		{
			get
			{
				return this.rtlField;
			}
			set
			{
				this.rtlField = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00023B1D File Offset: 0x00021D1D
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00023B25 File Offset: 0x00021D25
		[global::System.Xml.Serialization.XmlElement(Order = 37)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff cs
		{
			get
			{
				return this.csField;
			}
			set
			{
				this.csField = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00023B2E File Offset: 0x00021D2E
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00023B36 File Offset: 0x00021D36
		[global::System.Xml.Serialization.XmlElement(Order = 38)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em em
		{
			get
			{
				return this.emField;
			}
			set
			{
				this.emField = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00023B3F File Offset: 0x00021D3F
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00023B47 File Offset: 0x00021D47
		[global::System.Xml.Serialization.XmlElement(Order = 39)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00023B50 File Offset: 0x00021D50
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00023B58 File Offset: 0x00021D58
		[global::System.Xml.Serialization.XmlElement(Order = 40)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout eastAsianLayout
		{
			get
			{
				return this.eastAsianLayoutField;
			}
			set
			{
				this.eastAsianLayoutField = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00023B61 File Offset: 0x00021D61
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00023B69 File Offset: 0x00021D69
		[global::System.Xml.Serialization.XmlElement(Order = 41)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff specVanish
		{
			get
			{
				return this.specVanishField;
			}
			set
			{
				this.specVanishField = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00023B72 File Offset: 0x00021D72
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00023B7A File Offset: 0x00021D7A
		[global::System.Xml.Serialization.XmlElement(Order = 42)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff oMath
		{
			get
			{
				return this.oMathField;
			}
			set
			{
				this.oMathField = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00023B83 File Offset: 0x00021D83
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00023B8B File Offset: 0x00021D8B
		[global::System.Xml.Serialization.XmlElement(Order = 43)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange rPrChange
		{
			get
			{
				return this.rPrChangeField;
			}
			set
			{
				this.rPrChangeField = value;
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00023B94 File Offset: 0x00021D94
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewNoProof()
		{
			if (this.noProofField == null)
			{
				this.noProofField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.noProofField;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00023BB0 File Offset: 0x00021DB0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr ct_ParaRPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ins")
				{
					ct_ParaRPr.ins = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_ParaRPr.del = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_ParaRPr.moveFrom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_ParaRPr.moveTo = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rStyle")
				{
					ct_ParaRPr.rStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rFonts")
				{
					ct_ParaRPr.rFonts = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_ParaRPr.b = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bCs")
				{
					ct_ParaRPr.bCs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "i")
				{
					ct_ParaRPr.i = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "iCs")
				{
					ct_ParaRPr.iCs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "caps")
				{
					ct_ParaRPr.caps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smallCaps")
				{
					ct_ParaRPr.smallCaps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strike")
				{
					ct_ParaRPr.strike = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dstrike")
				{
					ct_ParaRPr.dstrike = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outline")
				{
					ct_ParaRPr.outline = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_ParaRPr.shadow = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "emboss")
				{
					ct_ParaRPr.emboss = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "imprint")
				{
					ct_ParaRPr.imprint = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noProof")
				{
					ct_ParaRPr.noProof = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "snapToGrid")
				{
					ct_ParaRPr.snapToGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vanish")
				{
					ct_ParaRPr.vanish = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webHidden")
				{
					ct_ParaRPr.webHidden = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_ParaRPr.color = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spacing")
				{
					ct_ParaRPr.spacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "w")
				{
					ct_ParaRPr.w = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "kern")
				{
					ct_ParaRPr.kern = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "position")
				{
					ct_ParaRPr.position = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sz")
				{
					ct_ParaRPr.sz = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "szCs")
				{
					ct_ParaRPr.szCs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "highlight")
				{
					ct_ParaRPr.highlight = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "u")
				{
					ct_ParaRPr.u = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effect")
				{
					ct_ParaRPr.effect = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bdr")
				{
					ct_ParaRPr.bdr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_ParaRPr.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fitText")
				{
					ct_ParaRPr.fitText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vertAlign")
				{
					ct_ParaRPr.vertAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rtl")
				{
					ct_ParaRPr.rtl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cs")
				{
					ct_ParaRPr.cs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "em")
				{
					ct_ParaRPr.em = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lang")
				{
					ct_ParaRPr.lang = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "eastAsianLayout")
				{
					ct_ParaRPr.eastAsianLayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "specVanish")
				{
					ct_ParaRPr.specVanish = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_ParaRPr.oMath = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rPrChange")
				{
					ct_ParaRPr.rPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ParaRPr;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00024244 File Offset: 0x00022444
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.ins != null)
			{
				this.ins.Write(sw, "ins");
			}
			if (this.del != null)
			{
				this.del.Write(sw, "del");
			}
			if (this.moveFrom != null)
			{
				this.moveFrom.Write(sw, "moveFrom");
			}
			if (this.moveTo != null)
			{
				this.moveTo.Write(sw, "moveTo");
			}
			if (this.rStyle != null)
			{
				this.rStyle.Write(sw, "rStyle");
			}
			if (this.rFonts != null)
			{
				this.rFonts.Write(sw, "rFonts");
			}
			if (this.b != null)
			{
				this.b.Write(sw, "b");
			}
			if (this.bCs != null)
			{
				this.bCs.Write(sw, "bCs");
			}
			if (this.i != null)
			{
				this.i.Write(sw, "i");
			}
			if (this.iCs != null)
			{
				this.iCs.Write(sw, "iCs");
			}
			if (this.caps != null)
			{
				this.caps.Write(sw, "caps");
			}
			if (this.smallCaps != null)
			{
				this.smallCaps.Write(sw, "smallCaps");
			}
			if (this.strike != null)
			{
				this.strike.Write(sw, "strike");
			}
			if (this.dstrike != null)
			{
				this.dstrike.Write(sw, "dstrike");
			}
			if (this.outline != null)
			{
				this.outline.Write(sw, "outline");
			}
			if (this.shadow != null)
			{
				this.shadow.Write(sw, "shadow");
			}
			if (this.emboss != null)
			{
				this.emboss.Write(sw, "emboss");
			}
			if (this.imprint != null)
			{
				this.imprint.Write(sw, "imprint");
			}
			if (this.noProof != null)
			{
				this.noProof.Write(sw, "noProof");
			}
			if (this.snapToGrid != null)
			{
				this.snapToGrid.Write(sw, "snapToGrid");
			}
			if (this.vanish != null)
			{
				this.vanish.Write(sw, "vanish");
			}
			if (this.webHidden != null)
			{
				this.webHidden.Write(sw, "webHidden");
			}
			if (this.color != null)
			{
				this.color.Write(sw, "color");
			}
			if (this.spacing != null)
			{
				this.spacing.Write(sw, "spacing");
			}
			if (this.w != null)
			{
				this.w.Write(sw, "w");
			}
			if (this.kern != null)
			{
				this.kern.Write(sw, "kern");
			}
			if (this.position != null)
			{
				this.position.Write(sw, "position");
			}
			if (this.sz != null)
			{
				this.sz.Write(sw, "sz");
			}
			if (this.szCs != null)
			{
				this.szCs.Write(sw, "szCs");
			}
			if (this.highlight != null)
			{
				this.highlight.Write(sw, "highlight");
			}
			if (this.u != null)
			{
				this.u.Write(sw, "u");
			}
			if (this.effect != null)
			{
				this.effect.Write(sw, "effect");
			}
			if (this.bdr != null)
			{
				this.bdr.Write(sw, "bdr");
			}
			if (this.shd != null)
			{
				this.shd.Write(sw, "shd");
			}
			if (this.fitText != null)
			{
				this.fitText.Write(sw, "fitText");
			}
			if (this.vertAlign != null)
			{
				this.vertAlign.Write(sw, "vertAlign");
			}
			if (this.rtl != null)
			{
				this.rtl.Write(sw, "rtl");
			}
			if (this.cs != null)
			{
				this.cs.Write(sw, "cs");
			}
			if (this.em != null)
			{
				this.em.Write(sw, "em");
			}
			if (this.lang != null)
			{
				this.lang.Write(sw, "lang");
			}
			if (this.eastAsianLayout != null)
			{
				this.eastAsianLayout.Write(sw, "eastAsianLayout");
			}
			if (this.specVanish != null)
			{
				this.specVanish.Write(sw, "specVanish");
			}
			if (this.oMath != null)
			{
				this.oMath.Write(sw, "oMath");
			}
			if (this.rPrChange != null)
			{
				this.rPrChange.Write(sw, "rPrChange");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x040009B4 RID: 2484
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange insField;

		// Token: 0x040009B5 RID: 2485
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange delField;

		// Token: 0x040009B6 RID: 2486
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveFromField;

		// Token: 0x040009B7 RID: 2487
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveToField;

		// Token: 0x040009B8 RID: 2488
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String rStyleField;

		// Token: 0x040009B9 RID: 2489
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts rFontsField;

		// Token: 0x040009BA RID: 2490
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bField;

		// Token: 0x040009BB RID: 2491
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bCsField;

		// Token: 0x040009BC RID: 2492
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff iField;

		// Token: 0x040009BD RID: 2493
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff iCsField;

		// Token: 0x040009BE RID: 2494
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff capsField;

		// Token: 0x040009BF RID: 2495
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff smallCapsField;

		// Token: 0x040009C0 RID: 2496
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff strikeField;

		// Token: 0x040009C1 RID: 2497
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dstrikeField;

		// Token: 0x040009C2 RID: 2498
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff outlineField;

		// Token: 0x040009C3 RID: 2499
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff shadowField;

		// Token: 0x040009C4 RID: 2500
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff embossField;

		// Token: 0x040009C5 RID: 2501
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff imprintField;

		// Token: 0x040009C6 RID: 2502
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noProofField;

		// Token: 0x040009C7 RID: 2503
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff snapToGridField;

		// Token: 0x040009C8 RID: 2504
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff vanishField;

		// Token: 0x040009C9 RID: 2505
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff webHiddenField;

		// Token: 0x040009CA RID: 2506
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color colorField;

		// Token: 0x040009CB RID: 2507
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure spacingField;

		// Token: 0x040009CC RID: 2508
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale wField;

		// Token: 0x040009CD RID: 2509
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure kernField;

		// Token: 0x040009CE RID: 2510
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure positionField;

		// Token: 0x040009CF RID: 2511
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure szField;

		// Token: 0x040009D0 RID: 2512
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure szCsField;

		// Token: 0x040009D1 RID: 2513
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight highlightField;

		// Token: 0x040009D2 RID: 2514
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline uField;

		// Token: 0x040009D3 RID: 2515
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect effectField;

		// Token: 0x040009D4 RID: 2516
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bdrField;

		// Token: 0x040009D5 RID: 2517
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shdField;

		// Token: 0x040009D6 RID: 2518
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText fitTextField;

		// Token: 0x040009D7 RID: 2519
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun vertAlignField;

		// Token: 0x040009D8 RID: 2520
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtlField;

		// Token: 0x040009D9 RID: 2521
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff csField;

		// Token: 0x040009DA RID: 2522
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em emField;

		// Token: 0x040009DB RID: 2523
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language langField;

		// Token: 0x040009DC RID: 2524
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout eastAsianLayoutField;

		// Token: 0x040009DD RID: 2525
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff specVanishField;

		// Token: 0x040009DE RID: 2526
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff oMathField;

		// Token: 0x040009DF RID: 2527
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrChange rPrChangeField;
	}
}
