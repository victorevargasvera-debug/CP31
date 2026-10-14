using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200008A RID: 138
	[global::System.Runtime.Serialization.DataContract]
	public enum CommRC
	{
		// Token: 0x040003EB RID: 1003
		[global::System.Runtime.Serialization.EnumMember]
		RD0000_CommSuccess,
		// Token: 0x040003EC RID: 1004
		[global::System.Runtime.Serialization.EnumMember]
		RD0001_RH_CommErrGeneric,
		// Token: 0x040003ED RID: 1005
		[global::System.Runtime.Serialization.EnumMember]
		RD0002_RH_CommErrDataSize,
		// Token: 0x040003EE RID: 1006
		[global::System.Runtime.Serialization.EnumMember]
		RD0003_RH_CommErrBadImage,
		// Token: 0x040003EF RID: 1007
		[global::System.Runtime.Serialization.EnumMember]
		RD0004_RH_CommErrBadMemMap,
		// Token: 0x040003F0 RID: 1008
		[global::System.Runtime.Serialization.EnumMember]
		RD0005_RH_CommErrInvalidParameter,
		// Token: 0x040003F1 RID: 1009
		[global::System.Runtime.Serialization.EnumMember]
		RD0006_RH_CommErrUnknownHWID,
		// Token: 0x040003F2 RID: 1010
		[global::System.Runtime.Serialization.EnumMember]
		RD0007_RH_CommErrFlashType,
		// Token: 0x040003F3 RID: 1011
		[global::System.Runtime.Serialization.EnumMember]
		RD0008_RH_CommErrOperationMode,
		// Token: 0x040003F4 RID: 1012
		[global::System.Runtime.Serialization.EnumMember]
		RD0009_RH_CommErrInvalidTEI,
		// Token: 0x040003F5 RID: 1013
		[global::System.Runtime.Serialization.EnumMember]
		RD0010_RH_CommErrCPUIDMismatch,
		// Token: 0x040003F6 RID: 1014
		[global::System.Runtime.Serialization.EnumMember]
		RD0011_RH_CommErrCannotDetectCPArea,
		// Token: 0x040003F7 RID: 1015
		[global::System.Runtime.Serialization.EnumMember]
		RD0012_RH_CommErrSrecordLoadFailed,
		// Token: 0x040003F8 RID: 1016
		[global::System.Runtime.Serialization.EnumMember]
		RD0013_RH_CommErrModelMisedInMetadata,
		// Token: 0x040003F9 RID: 1017
		[global::System.Runtime.Serialization.EnumMember]
		RD0014_RH_CommErrInvalidCPVersion,
		// Token: 0x040003FA RID: 1018
		[global::System.Runtime.Serialization.EnumMember]
		RD0015_RH_CommErrByteOrderConflict,
		// Token: 0x040003FB RID: 1019
		[global::System.Runtime.Serialization.EnumMember]
		RD0015_RH_CommErrReceivedDataLengthGreaterThanExpectedLength,
		// Token: 0x040003FC RID: 1020
		[global::System.Runtime.Serialization.EnumMember]
		RD0016_RH_CommErrInvalidInputAddress,
		// Token: 0x040003FD RID: 1021
		[global::System.Runtime.Serialization.EnumMember]
		RD0017_RH_CommErrNoSpecifyFilePath,
		// Token: 0x040003FE RID: 1022
		[global::System.Runtime.Serialization.EnumMember]
		RD0018_RH_CommErrIOCanceled,
		// Token: 0x040003FF RID: 1023
		[global::System.Runtime.Serialization.EnumMember]
		RD0019_RH_CommErrInvalidFDTStatus,
		// Token: 0x04000400 RID: 1024
		[global::System.Runtime.Serialization.EnumMember]
		RD0020_RH_CommErrNotSupportedOperation,
		// Token: 0x04000401 RID: 1025
		[global::System.Runtime.Serialization.EnumMember]
		RD0021_RH_CommErrReadZeroLengthData,
		// Token: 0x04000402 RID: 1026
		[global::System.Runtime.Serialization.EnumMember]
		RD0022_RH_CommErrUnknownCPUByteOrder,
		// Token: 0x04000403 RID: 1027
		[global::System.Runtime.Serialization.EnumMember]
		RD0023_RH_CommErrInvalidSWFile,
		// Token: 0x04000404 RID: 1028
		[global::System.Runtime.Serialization.EnumMember]
		RD0024_RH_CommErrInvalidHardwareId,
		// Token: 0x04000405 RID: 1029
		[global::System.Runtime.Serialization.EnumMember]
		RD0025_RH_PowerOffRadioFailed,
		// Token: 0x04000406 RID: 1030
		[global::System.Runtime.Serialization.EnumMember]
		RD0026_RH_CanNotGetRadioModelInfoViaModelType,
		// Token: 0x04000407 RID: 1031
		[global::System.Runtime.Serialization.EnumMember]
		RD0100_PNP_CommErrProcessPnPMsg,
		// Token: 0x04000408 RID: 1032
		[global::System.Runtime.Serialization.EnumMember]
		RD0200_RH_CommErrInvalidModelTableFile,
		// Token: 0x04000409 RID: 1033
		[global::System.Runtime.Serialization.EnumMember]
		RD4000_FDI_CommErrFDISizeAreaMismatch,
		// Token: 0x0400040A RID: 1034
		[global::System.Runtime.Serialization.EnumMember]
		RD4001_FDI_CommErrFDIBlockSize,
		// Token: 0x0400040B RID: 1035
		[global::System.Runtime.Serialization.EnumMember]
		RD4002_FDI_CommErrFDIException,
		// Token: 0x0400040C RID: 1036
		[global::System.Runtime.Serialization.EnumMember]
		RD4003_FDI_CommErrFDIMissingBlock,
		// Token: 0x0400040D RID: 1037
		[global::System.Runtime.Serialization.EnumMember]
		RD4004_FDI_CommErrFDIConfig,
		// Token: 0x0400040E RID: 1038
		[global::System.Runtime.Serialization.EnumMember]
		RD5000_FDT_CommErrFDTNotInit,
		// Token: 0x0400040F RID: 1039
		[global::System.Runtime.Serialization.EnumMember]
		RD5001_FDT_CommErrFDTInvalidParameter,
		// Token: 0x04000410 RID: 1040
		[global::System.Runtime.Serialization.EnumMember]
		RD5002_FDT_CommErrCannotReadFDT,
		// Token: 0x04000411 RID: 1041
		[global::System.Runtime.Serialization.EnumMember]
		RD5003_FDT_CommErrCannotWriteFDTUnit,
		// Token: 0x04000412 RID: 1042
		[global::System.Runtime.Serialization.EnumMember]
		RD5004_FDT_CommErrUnknownFDTType,
		// Token: 0x04000413 RID: 1043
		[global::System.Runtime.Serialization.EnumMember]
		RD5050_FP_CommErrFPInitError,
		// Token: 0x04000414 RID: 1044
		[global::System.Runtime.Serialization.EnumMember]
		RD5063_FP_HuffmanFail,
		// Token: 0x04000415 RID: 1045
		[global::System.Runtime.Serialization.EnumMember]
		RD5064_FP_UnHuffmanFail,
		// Token: 0x04000416 RID: 1046
		[global::System.Runtime.Serialization.EnumMember]
		RD5065_FP_BuildLLPFail,
		// Token: 0x04000417 RID: 1047
		[global::System.Runtime.Serialization.EnumMember]
		RD5066_FP_ParseLLPFail,
		// Token: 0x04000418 RID: 1048
		[global::System.Runtime.Serialization.EnumMember]
		RD5070_FP_ERASESLOTFail,
		// Token: 0x04000419 RID: 1049
		[global::System.Runtime.Serialization.EnumMember]
		RD5072_FP_CommErrWriteMandatoryFPFailed,
		// Token: 0x0400041A RID: 1050
		[global::System.Runtime.Serialization.EnumMember]
		RD5073_FP_CommErrWriteLLPFailed,
		// Token: 0x0400041B RID: 1051
		[global::System.Runtime.Serialization.EnumMember]
		RD5074_FP_DeleteFlashPackFromCathcFailed,
		// Token: 0x0400041C RID: 1052
		[global::System.Runtime.Serialization.EnumMember]
		RD5075_FP_ReleaseIDTypeIsNone,
		// Token: 0x0400041D RID: 1053
		[global::System.Runtime.Serialization.EnumMember]
		RD5076_FP_InvalidCopyRightStringInReleaseID,
		// Token: 0x0400041E RID: 1054
		[global::System.Runtime.Serialization.EnumMember]
		RD5078_FP_NoSoftwareVersionInfoInReleaseID,
		// Token: 0x0400041F RID: 1055
		[global::System.Runtime.Serialization.EnumMember]
		RD1000_PR_CommErrSBEPGeneric,
		// Token: 0x04000420 RID: 1056
		[global::System.Runtime.Serialization.EnumMember]
		RD1001_PR_CommErrSBEPBadWriteReply,
		// Token: 0x04000421 RID: 1057
		[global::System.Runtime.Serialization.EnumMember]
		RD1002_PR_CommErrSBEPCannotOpenPipe,
		// Token: 0x04000422 RID: 1058
		[global::System.Runtime.Serialization.EnumMember]
		RD1003_PR_CommErrSBEPInsufficientBuffer,
		// Token: 0x04000423 RID: 1059
		[global::System.Runtime.Serialization.EnumMember]
		RD1004_PR_CommErrSBEPMSGCheckSumError,
		// Token: 0x04000424 RID: 1060
		[global::System.Runtime.Serialization.EnumMember]
		RD1005_PR_CommErrSBEPMSGWrongFormat,
		// Token: 0x04000425 RID: 1061
		[global::System.Runtime.Serialization.EnumMember]
		RD1006_PR_CommErrSBEPNack,
		// Token: 0x04000426 RID: 1062
		[global::System.Runtime.Serialization.EnumMember]
		RD1007_PR_CommErrSBEPNoAcknowledge,
		// Token: 0x04000427 RID: 1063
		[global::System.Runtime.Serialization.EnumMember]
		RD1008_PR_CommErrSBEPReadCommError,
		// Token: 0x04000428 RID: 1064
		[global::System.Runtime.Serialization.EnumMember]
		RD1009_PR_CommErrSBEPReadTimeOut,
		// Token: 0x04000429 RID: 1065
		[global::System.Runtime.Serialization.EnumMember]
		RD1010_PR_CommErrSBEPReceiveMessageError,
		// Token: 0x0400042A RID: 1066
		[global::System.Runtime.Serialization.EnumMember]
		RD1011_PR_CommErrSBEPSendMessageError,
		// Token: 0x0400042B RID: 1067
		[global::System.Runtime.Serialization.EnumMember]
		RD1012_PR_CommErrSBEPTimeOut,
		// Token: 0x0400042C RID: 1068
		[global::System.Runtime.Serialization.EnumMember]
		RD1013_PR_CommErrSBEPUndefinedWriteReply,
		// Token: 0x0400042D RID: 1069
		[global::System.Runtime.Serialization.EnumMember]
		RD1014_PR_CommErrSBEPUnknownReply,
		// Token: 0x0400042E RID: 1070
		[global::System.Runtime.Serialization.EnumMember]
		RD1015_PR_CommErrSBEPUnsupportReply,
		// Token: 0x0400042F RID: 1071
		[global::System.Runtime.Serialization.EnumMember]
		RD1016_PR_CommErrSBEPUnsupportedType,
		// Token: 0x04000430 RID: 1072
		[global::System.Runtime.Serialization.EnumMember]
		RD1017_PR_CommErrSBEPWriteCommError,
		// Token: 0x04000431 RID: 1073
		[global::System.Runtime.Serialization.EnumMember]
		RD1018_PR_CommErrSBEPWriteNack,
		// Token: 0x04000432 RID: 1074
		[global::System.Runtime.Serialization.EnumMember]
		RD1019_PR_CommErrSBEPWriteNoAcknowledge,
		// Token: 0x04000433 RID: 1075
		[global::System.Runtime.Serialization.EnumMember]
		RD1020_PR_CommErrSBEPWriteTimeOut,
		// Token: 0x04000434 RID: 1076
		[global::System.Runtime.Serialization.EnumMember]
		RD1021_PR_CommErrSBEPWrongParameter,
		// Token: 0x04000435 RID: 1077
		[global::System.Runtime.Serialization.EnumMember]
		RD1022_PR_CommErrSBEPNoneCommPipe,
		// Token: 0x04000436 RID: 1078
		[global::System.Runtime.Serialization.EnumMember]
		RD1023_PR_CommErrSBEPACK,
		// Token: 0x04000437 RID: 1079
		[global::System.Runtime.Serialization.EnumMember]
		RD1024_PR_CommErrRPMsgWrongFormat,
		// Token: 0x04000438 RID: 1080
		[global::System.Runtime.Serialization.EnumMember]
		RD1025_PR_CommErrRPWrongParameter,
		// Token: 0x04000439 RID: 1081
		[global::System.Runtime.Serialization.EnumMember]
		RD1026_PR_CommErrRPWriteCommError,
		// Token: 0x0400043A RID: 1082
		[global::System.Runtime.Serialization.EnumMember]
		RD1027_PR_CommErrRPWriteTimeout,
		// Token: 0x0400043B RID: 1083
		[global::System.Runtime.Serialization.EnumMember]
		RD1028_PR_CommErrRPReadCommError,
		// Token: 0x0400043C RID: 1084
		[global::System.Runtime.Serialization.EnumMember]
		RD1029_PR_CommErrRPReadTimeout,
		// Token: 0x0400043D RID: 1085
		[global::System.Runtime.Serialization.EnumMember]
		RD1030_PR_CommErrRPNoneCommPipe,
		// Token: 0x0400043E RID: 1086
		[global::System.Runtime.Serialization.EnumMember]
		RD1031_PR_CommErrRPMsgRejected,
		// Token: 0x0400043F RID: 1087
		[global::System.Runtime.Serialization.EnumMember]
		RD1032_PR_CommErrRPRejectBadBattery,
		// Token: 0x04000440 RID: 1088
		[global::System.Runtime.Serialization.EnumMember]
		RD1033_PR_CommErrRPRejectRPEmergency,
		// Token: 0x04000441 RID: 1089
		[global::System.Runtime.Serialization.EnumMember]
		RD1034_PR_CommErrRPInvalidID,
		// Token: 0x04000442 RID: 1090
		[global::System.Runtime.Serialization.EnumMember]
		RD1035_PR_CommErrRPReceiveMsgError,
		// Token: 0x04000443 RID: 1091
		[global::System.Runtime.Serialization.EnumMember]
		RD1036_PR_CommErrRPInvalidIDFormat,
		// Token: 0x04000444 RID: 1092
		[global::System.Runtime.Serialization.EnumMember]
		RD1037_PR_CommErrRPInvalidMode,
		// Token: 0x04000445 RID: 1093
		[global::System.Runtime.Serialization.EnumMember]
		RD1038_PR_CommErrRPUnsupportedProtocol,
		// Token: 0x04000446 RID: 1094
		[global::System.Runtime.Serialization.EnumMember]
		RD1039_PR_CommErrSbepNotEnoughLengthToParseOpcode,
		// Token: 0x04000447 RID: 1095
		[global::System.Runtime.Serialization.EnumMember]
		RD1040_PR_CommErrSbepReceivedUnexpectedIndication,
		// Token: 0x04000448 RID: 1096
		[global::System.Runtime.Serialization.EnumMember]
		RD1041_PR_CommErrATDeviceIsBusy,
		// Token: 0x04000449 RID: 1097
		[global::System.Runtime.Serialization.EnumMember]
		RD1042_PR_CommErrATGeneralError,
		// Token: 0x0400044A RID: 1098
		[global::System.Runtime.Serialization.EnumMember]
		RD1043_PR_CommErrATNoCommunicationPipe,
		// Token: 0x0400044B RID: 1099
		[global::System.Runtime.Serialization.EnumMember]
		RD1044_PR_CommErrATReadTimeout,
		// Token: 0x0400044C RID: 1100
		[global::System.Runtime.Serialization.EnumMember]
		RD1045_PR_CommErrATReceiveMessageError,
		// Token: 0x0400044D RID: 1101
		[global::System.Runtime.Serialization.EnumMember]
		RD1046_PR_CommErrATWriteDataError,
		// Token: 0x0400044E RID: 1102
		[global::System.Runtime.Serialization.EnumMember]
		RD1047_PR_CommErrATWriteDataTimeout,
		// Token: 0x0400044F RID: 1103
		[global::System.Runtime.Serialization.EnumMember]
		RD1048_PR_CommErrATInvalidInputParameters,
		// Token: 0x04000450 RID: 1104
		[global::System.Runtime.Serialization.EnumMember]
		RD1049_PR_CommErrATInvalidReply,
		// Token: 0x04000451 RID: 1105
		[global::System.Runtime.Serialization.EnumMember]
		RD1050_PR_CommErrATOperationNotAllowed,
		// Token: 0x04000452 RID: 1106
		[global::System.Runtime.Serialization.EnumMember]
		RD1051_PR_CommErrATLowBattery,
		// Token: 0x04000453 RID: 1107
		[global::System.Runtime.Serialization.EnumMember]
		RD1052_PR_CommErrATMsInEmergency,
		// Token: 0x04000454 RID: 1108
		[global::System.Runtime.Serialization.EnumMember]
		RD1053_PR_CommErrATAccessCodeNeedChange,
		// Token: 0x04000455 RID: 1109
		[global::System.Runtime.Serialization.EnumMember]
		RD1054_PR_CommErrATWrongPassword,
		// Token: 0x04000456 RID: 1110
		[global::System.Runtime.Serialization.EnumMember]
		RD1055_PR_CommErrATChargerNotConnected,
		// Token: 0x04000457 RID: 1111
		[global::System.Runtime.Serialization.EnumMember]
		RD6001_RH_CommErrFailedToResetDataBoxRadio,
		// Token: 0x04000458 RID: 1112
		[global::System.Runtime.Serialization.EnumMember]
		RD6002_MS_CommErrTargetFolderNotExist,
		// Token: 0x04000459 RID: 1113
		[global::System.Runtime.Serialization.EnumMember]
		RD6003_MS_CommErrFileOperationError,
		// Token: 0x0400045A RID: 1114
		[global::System.Runtime.Serialization.EnumMember]
		RD6004_MS_CommErrSizeLargerThanExpected,
		// Token: 0x0400045B RID: 1115
		[global::System.Runtime.Serialization.EnumMember]
		RD6005_MS_CommErrSourceFileNotExist,
		// Token: 0x0400045C RID: 1116
		[global::System.Runtime.Serialization.EnumMember]
		RD6006_MS_CommErrSwitchModeFail,
		// Token: 0x0400045D RID: 1117
		[global::System.Runtime.Serialization.EnumMember]
		RD6007_MS_CommErrNotEnoughSpaceForPush,
		// Token: 0x0400045E RID: 1118
		[global::System.Runtime.Serialization.EnumMember]
		RD7001_S19_CommErrInvalidS19Header,
		// Token: 0x0400045F RID: 1119
		[global::System.Runtime.Serialization.EnumMember]
		RD7002_S19_CommErrUnsupportedS19FileType,
		// Token: 0x04000460 RID: 1120
		[global::System.Runtime.Serialization.EnumMember]
		RD7003_S19_CommErrInvalidS19Format,
		// Token: 0x04000461 RID: 1121
		[global::System.Runtime.Serialization.EnumMember]
		RD7004_S19_CommErrFailedToValidateAddress,
		// Token: 0x04000462 RID: 1122
		[global::System.Runtime.Serialization.EnumMember]
		RD8001_NAND_CommErrConvertS19ToImage,
		// Token: 0x04000463 RID: 1123
		[global::System.Runtime.Serialization.EnumMember]
		RD8002_NAND_CommErrLoadFromImage,
		// Token: 0x04000464 RID: 1124
		[global::System.Runtime.Serialization.EnumMember]
		RD8003_NAND_ExportToS19File,
		// Token: 0x04000465 RID: 1125
		[global::System.Runtime.Serialization.EnumMember]
		RD9001_GeneralOperation_CommErrInvalidOperationCode,
		// Token: 0x04000466 RID: 1126
		[global::System.Runtime.Serialization.EnumMember]
		RE0001_LANGUAGE_LPValidFail,
		// Token: 0x04000467 RID: 1127
		[global::System.Runtime.Serialization.EnumMember]
		RD9001_AUTHEN_Failed,
		// Token: 0x04000468 RID: 1128
		[global::System.Runtime.Serialization.EnumMember]
		RF0001_FlashRegionOperation_FaiedToReadRegion,
		// Token: 0x04000469 RID: 1129
		[global::System.Runtime.Serialization.EnumMember]
		RF0002_FlashRegionOperation_FailedToConvertImageToFile,
		// Token: 0x0400046A RID: 1130
		[global::System.Runtime.Serialization.EnumMember]
		RF0003_FlashRegionOperation_CanNotFindImageBackupFile,
		// Token: 0x0400046B RID: 1131
		[global::System.Runtime.Serialization.EnumMember]
		RF0004_FlashRegionOperation_FailedToLoadImageFromBackupFile,
		// Token: 0x0400046C RID: 1132
		[global::System.Runtime.Serialization.EnumMember]
		RF0005_FlashRegionOperation_FailedToConstructSRecordFromImage,
		// Token: 0x0400046D RID: 1133
		[global::System.Runtime.Serialization.EnumMember]
		RF0006_FlashRegionOperation_InvalidBackupFileFormat,
		// Token: 0x0400046E RID: 1134
		[global::System.Runtime.Serialization.EnumMember]
		RF0007_FlashRegionOperation_DatalightUpgradeFailed,
		// Token: 0x0400046F RID: 1135
		[global::System.Runtime.Serialization.EnumMember]
		RG0001_CommMetadataNoRecordOfFPSupport
	}
}
