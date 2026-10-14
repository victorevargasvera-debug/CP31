using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000DB RID: 219
	public enum OptionIDs
	{
		// Token: 0x04000659 RID: 1625
		NULL,
		// Token: 0x0400065A RID: 1626
		Trunked_Radio_Trace_Remote_Monitor,
		// Token: 0x0400065B RID: 1627
		Over_the_Air_Provisioning,
		// Token: 0x0400065C RID: 1628
		APX6000XE,
		// Token: 0x0400065D RID: 1629
		RF_Preamp,
		// Token: 0x0400065E RID: 1630
		ASTRO_Digital_Operation,
		// Token: 0x0400065F RID: 1631
		P25_Radio_Authentication,
		// Token: 0x04000660 RID: 1632
		OTAR_with_Multikey,
		// Token: 0x04000661 RID: 1633
		Multikey_Id,
		// Token: 0x04000662 RID: 1634
		Federal_Government_Front_Panel_Programming_Enhancement,
		// Token: 0x04000663 RID: 1635
		Motorcycle_Radio,
		// Token: 0x04000664 RID: 1636
		_7_800_MHz_Primary_Band,
		// Token: 0x04000665 RID: 1637
		VHF_Primary_Band,
		// Token: 0x04000666 RID: 1638
		UHF_Range_1_Primary_Band,
		// Token: 0x04000667 RID: 1639
		_900MHZ_ID,
		// Token: 0x04000668 RID: 1640
		VHF_MP_Primary_Band,
		// Token: 0x04000669 RID: 1641
		VHF_HP_Primary_Band,
		// Token: 0x0400066A RID: 1642
		UHF_R1_MP_Primary_Band,
		// Token: 0x0400066B RID: 1643
		UHF_R1_HP_Primary_Band,
		// Token: 0x0400066C RID: 1644
		UHF_R2_MP_Primary_Band,
		// Token: 0x0400066D RID: 1645
		UHF_Range_2_Primary_Band,
		// Token: 0x0400066E RID: 1646
		_7_800_MHz_Secondary_Band,
		// Token: 0x0400066F RID: 1647
		VHF_Secondary_Band,
		// Token: 0x04000670 RID: 1648
		UHF_Range_1_Secondary_Band,
		// Token: 0x04000671 RID: 1649
		UHF_Range_2_Secondary_Band,
		// Token: 0x04000672 RID: 1650
		VHF_MPZ_Secondary_Band,
		// Token: 0x04000673 RID: 1651
		VHF_HP_Secondary_Band,
		// Token: 0x04000674 RID: 1652
		UHF_R1_MP_Secondary_Band,
		// Token: 0x04000675 RID: 1653
		UHF_R1_HP_Secondary_Band,
		// Token: 0x04000676 RID: 1654
		UHF_R2_MP_Secondary_Band,
		// Token: 0x04000677 RID: 1655
		Bluetooth_Id,
		// Token: 0x04000678 RID: 1656
		Enhanced_Zone_Bank,
		// Token: 0x04000679 RID: 1657
		ASK_Enable,
		// Token: 0x0400067A RID: 1658
		Legacy_SW_System_Key_Enable,
		// Token: 0x0400067B RID: 1659
		Enable_Dual_Band_Operation,
		// Token: 0x0400067C RID: 1660
		One_Touch_Status_Message,
		// Token: 0x0400067D RID: 1661
		SMARTZONE_Systems_Operation,
		// Token: 0x0400067E RID: 1662
		SMARTNET_Systems_Operation,
		// Token: 0x0400067F RID: 1663
		Man_Down_Operation,
		// Token: 0x04000680 RID: 1664
		Enhancement_Level_2,
		// Token: 0x04000681 RID: 1665
		Advanced_Digital_Privacy_Software,
		// Token: 0x04000682 RID: 1666
		_125_kHz_FCC_Mandate,
		// Token: 0x04000683 RID: 1667
		Conventional_Tactical_Rekey,
		// Token: 0x04000684 RID: 1668
		Extreme_Noise_Reduction,
		// Token: 0x04000685 RID: 1669
		DVRS_PSU_Activation,
		// Token: 0x04000686 RID: 1670
		Extended_Dispatch_Enable,
		// Token: 0x04000687 RID: 1671
		Enhancement_Level_1,
		// Token: 0x04000688 RID: 1672
		GPS_Activation,
		// Token: 0x04000689 RID: 1673
		APX_Lite_Option,
		// Token: 0x0400068A RID: 1674
		P_9600_or_3600_Single_System_Trigger,
		// Token: 0x0400068B RID: 1675
		Packet_Data_Interface,
		// Token: 0x0400068C RID: 1676
		SMARTZONE_OMNILINK_Multizone_Operation,
		// Token: 0x0400068D RID: 1677
		Conventional_Voting_Scan,
		// Token: 0x0400068E RID: 1678
		FCC_Conventional_Front_Panel_Programming,
		// Token: 0x0400068F RID: 1679
		ASTRO_25_9600_Baud_Trunking_Systems_Operation,
		// Token: 0x04000690 RID: 1680
		Collaborative_Phase_1,
		// Token: 0x04000691 RID: 1681
		Encrypted_Tactical_Inhibit,
		// Token: 0x04000692 RID: 1682
		TDMA_Operation,
		// Token: 0x04000693 RID: 1683
		FDNY_Emergency_Rx_Tx_Tone_Set,
		// Token: 0x04000694 RID: 1684
		Front_Display_and_Full_Keypad,
		// Token: 0x04000695 RID: 1685
		Fireground_Accountability_Software,
		// Token: 0x04000696 RID: 1686
		V24_Software_Enable,
		// Token: 0x04000697 RID: 1687
		DVRS_MSU_Operation,
		// Token: 0x04000698 RID: 1688
		P25_Common_Air_Interface,
		// Token: 0x04000699 RID: 1689
		Enhanced_Data_Operation,
		// Token: 0x0400069A RID: 1690
		Site_Selectable_Alert_For_P25_Trunking,
		// Token: 0x0400069B RID: 1691
		LTE_Operation,
		// Token: 0x0400069C RID: 1692
		Dual_Radio_Operation,
		// Token: 0x0400069D RID: 1693
		Encrypted_VPN_Gateway,
		// Token: 0x0400069E RID: 1694
		Alstro_Alert_Operation,
		// Token: 0x0400069F RID: 1695
		Geo_Fence_Option,
		// Token: 0x040006A0 RID: 1696
		RSI_Data,
		// Token: 0x040006A1 RID: 1697
		Primary_Band_800_900MHz,
		// Token: 0x040006A2 RID: 1698
		WiFi_Capability,
		// Token: 0x040006A3 RID: 1699
		DINC_PLUS_AUDIO,
		// Token: 0x040006A4 RID: 1700
		Group_Services,
		// Token: 0x040006A5 RID: 1701
		Motorola_VML_Data_Modem_Tethering,
		// Token: 0x040006A6 RID: 1702
		Mission_Critical_Geofence,
		// Token: 0x040006A7 RID: 1703
		Third_Part_Modem_Tethering,
		// Token: 0x040006A8 RID: 1704
		Advanced_Encryption_Standard,
		// Token: 0x040006A9 RID: 1705
		Night_Vision_Goggle,
		// Token: 0x040006AA RID: 1706
		NYPD_Trigger,
		// Token: 0x040006AB RID: 1707
		Multi_System_OTAR,
		// Token: 0x040006AC RID: 1708
		SmartConnectOverBroadband = 84,
		// Token: 0x040006AD RID: 1709
		SmartConnect,
		// Token: 0x040006AE RID: 1710
		Des_Sw_Software_Crypto,
		// Token: 0x040006AF RID: 1711
		DVRS_PSU_CONVENTIONAL_SCAN_ENABLED,
		// Token: 0x040006B0 RID: 1712
		ETSI_Regulatory_Region_Enabled,
		// Token: 0x040006B1 RID: 1713
		German_Fed_Gov_Enabled,
		// Token: 0x040006B2 RID: 1714
		Voice_Control,
		// Token: 0x040006B3 RID: 1715
		ATAK_HOption,
		// Token: 0x040006B4 RID: 1716
		AdaptiveSpeakerVolume_HOption,
		// Token: 0x040006B5 RID: 1717
		Voice_Control_Basic,
		// Token: 0x040006B6 RID: 1718
		LTE_ENABLEMENT,
		// Token: 0x040006B7 RID: 1719
		Tactical_Services_HOption
	}
}
