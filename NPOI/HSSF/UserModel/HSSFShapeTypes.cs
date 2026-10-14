using System;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000359 RID: 857
	public enum HSSFShapeTypes
	{
		// Token: 0x04000A20 RID: 2592
		NotPrimitive,
		// Token: 0x04000A21 RID: 2593
		Rectangle,
		// Token: 0x04000A22 RID: 2594
		RoundRectangle,
		// Token: 0x04000A23 RID: 2595
		Ellipse,
		// Token: 0x04000A24 RID: 2596
		Diamond,
		// Token: 0x04000A25 RID: 2597
		IsocelesTriangle,
		// Token: 0x04000A26 RID: 2598
		RightTriangle,
		// Token: 0x04000A27 RID: 2599
		Parallelogram,
		// Token: 0x04000A28 RID: 2600
		Trapezoid,
		// Token: 0x04000A29 RID: 2601
		Hexagon,
		// Token: 0x04000A2A RID: 2602
		Octagon,
		// Token: 0x04000A2B RID: 2603
		Plus,
		// Token: 0x04000A2C RID: 2604
		Star,
		// Token: 0x04000A2D RID: 2605
		Arrow,
		// Token: 0x04000A2E RID: 2606
		ThickArrow,
		// Token: 0x04000A2F RID: 2607
		HomePlate,
		// Token: 0x04000A30 RID: 2608
		Cube,
		// Token: 0x04000A31 RID: 2609
		Balloon,
		// Token: 0x04000A32 RID: 2610
		Seal,
		// Token: 0x04000A33 RID: 2611
		Arc,
		// Token: 0x04000A34 RID: 2612
		Line,
		// Token: 0x04000A35 RID: 2613
		Plaque,
		// Token: 0x04000A36 RID: 2614
		Can,
		// Token: 0x04000A37 RID: 2615
		Donut,
		// Token: 0x04000A38 RID: 2616
		TextSimple,
		// Token: 0x04000A39 RID: 2617
		TextOctagon,
		// Token: 0x04000A3A RID: 2618
		TextHexagon,
		// Token: 0x04000A3B RID: 2619
		TextCurve,
		// Token: 0x04000A3C RID: 2620
		TextWave,
		// Token: 0x04000A3D RID: 2621
		TextRing,
		// Token: 0x04000A3E RID: 2622
		TextOnCurve,
		// Token: 0x04000A3F RID: 2623
		TextOnRing,
		// Token: 0x04000A40 RID: 2624
		StraightConnector1,
		// Token: 0x04000A41 RID: 2625
		BentConnector2,
		// Token: 0x04000A42 RID: 2626
		BentConnector3,
		// Token: 0x04000A43 RID: 2627
		BentConnector4,
		// Token: 0x04000A44 RID: 2628
		BentConnector5,
		// Token: 0x04000A45 RID: 2629
		CurvedConnector2,
		// Token: 0x04000A46 RID: 2630
		CurvedConnector3,
		// Token: 0x04000A47 RID: 2631
		CurvedConnector4,
		// Token: 0x04000A48 RID: 2632
		CurvedConnector5,
		// Token: 0x04000A49 RID: 2633
		Callout1,
		// Token: 0x04000A4A RID: 2634
		Callout2,
		// Token: 0x04000A4B RID: 2635
		Callout3,
		// Token: 0x04000A4C RID: 2636
		AccentCallout1,
		// Token: 0x04000A4D RID: 2637
		AccentCallout2,
		// Token: 0x04000A4E RID: 2638
		AccentCallout3,
		// Token: 0x04000A4F RID: 2639
		BorderCallout1,
		// Token: 0x04000A50 RID: 2640
		BorderCallout2,
		// Token: 0x04000A51 RID: 2641
		BorderCallout3,
		// Token: 0x04000A52 RID: 2642
		AccentBorderCallout1,
		// Token: 0x04000A53 RID: 2643
		AccentBorderCallout2,
		// Token: 0x04000A54 RID: 2644
		AccentBorderCallout3,
		// Token: 0x04000A55 RID: 2645
		Ribbon,
		// Token: 0x04000A56 RID: 2646
		Ribbon2,
		// Token: 0x04000A57 RID: 2647
		Chevron,
		// Token: 0x04000A58 RID: 2648
		Pentagon,
		// Token: 0x04000A59 RID: 2649
		NoSmoking,
		// Token: 0x04000A5A RID: 2650
		Star8,
		// Token: 0x04000A5B RID: 2651
		Star16,
		// Token: 0x04000A5C RID: 2652
		Star32,
		// Token: 0x04000A5D RID: 2653
		WedgeRectCallout,
		// Token: 0x04000A5E RID: 2654
		WedgeRRectCallout,
		// Token: 0x04000A5F RID: 2655
		WedgeEllipseCallout,
		// Token: 0x04000A60 RID: 2656
		Wave,
		// Token: 0x04000A61 RID: 2657
		FoldedCorner,
		// Token: 0x04000A62 RID: 2658
		LeftArrow,
		// Token: 0x04000A63 RID: 2659
		DownArrow,
		// Token: 0x04000A64 RID: 2660
		UpArrow,
		// Token: 0x04000A65 RID: 2661
		LeftRightArrow,
		// Token: 0x04000A66 RID: 2662
		UpDownArrow,
		// Token: 0x04000A67 RID: 2663
		IrregularSeal1,
		// Token: 0x04000A68 RID: 2664
		IrregularSeal2,
		// Token: 0x04000A69 RID: 2665
		LightningBolt,
		// Token: 0x04000A6A RID: 2666
		Heart,
		// Token: 0x04000A6B RID: 2667
		PictureFrame,
		// Token: 0x04000A6C RID: 2668
		QuadArrow,
		// Token: 0x04000A6D RID: 2669
		LeftArrowCallout,
		// Token: 0x04000A6E RID: 2670
		RightArrowCallout,
		// Token: 0x04000A6F RID: 2671
		UpArrowCallout,
		// Token: 0x04000A70 RID: 2672
		DownArrowCallout,
		// Token: 0x04000A71 RID: 2673
		LeftRightArrowCallout,
		// Token: 0x04000A72 RID: 2674
		UpDownArrowCallout,
		// Token: 0x04000A73 RID: 2675
		QuadArrowCallout,
		// Token: 0x04000A74 RID: 2676
		Bevel,
		// Token: 0x04000A75 RID: 2677
		LeftBracket,
		// Token: 0x04000A76 RID: 2678
		RightBracket,
		// Token: 0x04000A77 RID: 2679
		LeftBrace,
		// Token: 0x04000A78 RID: 2680
		RightBrace,
		// Token: 0x04000A79 RID: 2681
		LeftUpArrow,
		// Token: 0x04000A7A RID: 2682
		BentUpArrow,
		// Token: 0x04000A7B RID: 2683
		BentArrow,
		// Token: 0x04000A7C RID: 2684
		Star24,
		// Token: 0x04000A7D RID: 2685
		StripedRightArrow,
		// Token: 0x04000A7E RID: 2686
		NotchedRightArrow,
		// Token: 0x04000A7F RID: 2687
		BlockArc,
		// Token: 0x04000A80 RID: 2688
		SmileyFace,
		// Token: 0x04000A81 RID: 2689
		VerticalScroll,
		// Token: 0x04000A82 RID: 2690
		HorizontalScroll,
		// Token: 0x04000A83 RID: 2691
		CircularArrow,
		// Token: 0x04000A84 RID: 2692
		NotchedCircularArrow,
		// Token: 0x04000A85 RID: 2693
		UturnArrow,
		// Token: 0x04000A86 RID: 2694
		CurvedRightArrow,
		// Token: 0x04000A87 RID: 2695
		CurvedLeftArrow,
		// Token: 0x04000A88 RID: 2696
		CurvedUpArrow,
		// Token: 0x04000A89 RID: 2697
		CurvedDownArrow,
		// Token: 0x04000A8A RID: 2698
		CloudCallout,
		// Token: 0x04000A8B RID: 2699
		EllipseRibbon,
		// Token: 0x04000A8C RID: 2700
		EllipseRibbon2,
		// Token: 0x04000A8D RID: 2701
		FlowChartProcess,
		// Token: 0x04000A8E RID: 2702
		FlowChartDecision,
		// Token: 0x04000A8F RID: 2703
		FlowChartInputOutput,
		// Token: 0x04000A90 RID: 2704
		FlowChartPredefinedProcess,
		// Token: 0x04000A91 RID: 2705
		FlowChartInternalStorage,
		// Token: 0x04000A92 RID: 2706
		FlowChartDocument,
		// Token: 0x04000A93 RID: 2707
		FlowChartMultidocument,
		// Token: 0x04000A94 RID: 2708
		FlowChartTerminator,
		// Token: 0x04000A95 RID: 2709
		FlowChartPreparation,
		// Token: 0x04000A96 RID: 2710
		FlowChartManualInput,
		// Token: 0x04000A97 RID: 2711
		FlowChartManualOperation,
		// Token: 0x04000A98 RID: 2712
		FlowChartConnector,
		// Token: 0x04000A99 RID: 2713
		FlowChartPunchedCard,
		// Token: 0x04000A9A RID: 2714
		FlowChartPunchedTape,
		// Token: 0x04000A9B RID: 2715
		FlowChartSummingJunction,
		// Token: 0x04000A9C RID: 2716
		FlowChartOr,
		// Token: 0x04000A9D RID: 2717
		FlowChartCollate,
		// Token: 0x04000A9E RID: 2718
		FlowChartSort,
		// Token: 0x04000A9F RID: 2719
		FlowChartExtract,
		// Token: 0x04000AA0 RID: 2720
		FlowChartMerge,
		// Token: 0x04000AA1 RID: 2721
		FlowChartOfflineStorage,
		// Token: 0x04000AA2 RID: 2722
		FlowChartOnlineStorage,
		// Token: 0x04000AA3 RID: 2723
		FlowChartMagneticTape,
		// Token: 0x04000AA4 RID: 2724
		FlowChartMagneticDisk,
		// Token: 0x04000AA5 RID: 2725
		FlowChartMagneticDrum,
		// Token: 0x04000AA6 RID: 2726
		FlowChartDisplay,
		// Token: 0x04000AA7 RID: 2727
		FlowChartDelay,
		// Token: 0x04000AA8 RID: 2728
		TextPlainText,
		// Token: 0x04000AA9 RID: 2729
		TextStop,
		// Token: 0x04000AAA RID: 2730
		TextTriangle,
		// Token: 0x04000AAB RID: 2731
		TextTriangleInverted,
		// Token: 0x04000AAC RID: 2732
		TextChevron,
		// Token: 0x04000AAD RID: 2733
		TextChevronInverted,
		// Token: 0x04000AAE RID: 2734
		TextRingInside,
		// Token: 0x04000AAF RID: 2735
		TextRingOutside,
		// Token: 0x04000AB0 RID: 2736
		TextArchUpCurve,
		// Token: 0x04000AB1 RID: 2737
		TextArchDownCurve,
		// Token: 0x04000AB2 RID: 2738
		TextCircleCurve,
		// Token: 0x04000AB3 RID: 2739
		TextButtonCurve,
		// Token: 0x04000AB4 RID: 2740
		TextArchUpPour,
		// Token: 0x04000AB5 RID: 2741
		TextArchDownPour,
		// Token: 0x04000AB6 RID: 2742
		TextCirclePour,
		// Token: 0x04000AB7 RID: 2743
		TextButtonPour,
		// Token: 0x04000AB8 RID: 2744
		TextCurveUp,
		// Token: 0x04000AB9 RID: 2745
		TextCurveDown,
		// Token: 0x04000ABA RID: 2746
		TextCascadeUp,
		// Token: 0x04000ABB RID: 2747
		TextCascadeDown,
		// Token: 0x04000ABC RID: 2748
		TextWave1,
		// Token: 0x04000ABD RID: 2749
		TextWave2,
		// Token: 0x04000ABE RID: 2750
		TextWave3,
		// Token: 0x04000ABF RID: 2751
		TextWave4,
		// Token: 0x04000AC0 RID: 2752
		TextInflate,
		// Token: 0x04000AC1 RID: 2753
		TextDeflate,
		// Token: 0x04000AC2 RID: 2754
		TextInflateBottom,
		// Token: 0x04000AC3 RID: 2755
		TextDeflateBottom,
		// Token: 0x04000AC4 RID: 2756
		TextInflateTop,
		// Token: 0x04000AC5 RID: 2757
		TextDeflateTop,
		// Token: 0x04000AC6 RID: 2758
		TextDeflateInflate,
		// Token: 0x04000AC7 RID: 2759
		TextDeflateInflateDeflate,
		// Token: 0x04000AC8 RID: 2760
		TextFadeRight,
		// Token: 0x04000AC9 RID: 2761
		TextFadeLeft,
		// Token: 0x04000ACA RID: 2762
		TextFadeUp,
		// Token: 0x04000ACB RID: 2763
		TextFadeDown,
		// Token: 0x04000ACC RID: 2764
		TextSlantUp,
		// Token: 0x04000ACD RID: 2765
		TextSlantDown,
		// Token: 0x04000ACE RID: 2766
		TextCanUp,
		// Token: 0x04000ACF RID: 2767
		TextCanDown,
		// Token: 0x04000AD0 RID: 2768
		FlowChartAlternateProcess,
		// Token: 0x04000AD1 RID: 2769
		FlowChartOffpageConnector,
		// Token: 0x04000AD2 RID: 2770
		Callout90,
		// Token: 0x04000AD3 RID: 2771
		AccentCallout90,
		// Token: 0x04000AD4 RID: 2772
		BorderCallout90,
		// Token: 0x04000AD5 RID: 2773
		AccentBorderCallout90,
		// Token: 0x04000AD6 RID: 2774
		LeftRightUpArrow,
		// Token: 0x04000AD7 RID: 2775
		Sun,
		// Token: 0x04000AD8 RID: 2776
		Moon,
		// Token: 0x04000AD9 RID: 2777
		BracketPair,
		// Token: 0x04000ADA RID: 2778
		BracePair,
		// Token: 0x04000ADB RID: 2779
		Star4,
		// Token: 0x04000ADC RID: 2780
		DoubleWave,
		// Token: 0x04000ADD RID: 2781
		ActionButtonBlank,
		// Token: 0x04000ADE RID: 2782
		ActionButtonHome,
		// Token: 0x04000ADF RID: 2783
		ActionButtonHelp,
		// Token: 0x04000AE0 RID: 2784
		ActionButtonInformation,
		// Token: 0x04000AE1 RID: 2785
		ActionButtonForwardNext,
		// Token: 0x04000AE2 RID: 2786
		ActionButtonBackPrevious,
		// Token: 0x04000AE3 RID: 2787
		ActionButtonEnd,
		// Token: 0x04000AE4 RID: 2788
		ActionButtonBeginning,
		// Token: 0x04000AE5 RID: 2789
		ActionButtonReturn,
		// Token: 0x04000AE6 RID: 2790
		ActionButtonDocument,
		// Token: 0x04000AE7 RID: 2791
		ActionButtonSound,
		// Token: 0x04000AE8 RID: 2792
		ActionButtonMovie,
		// Token: 0x04000AE9 RID: 2793
		HostControl,
		// Token: 0x04000AEA RID: 2794
		TextBox
	}
}
